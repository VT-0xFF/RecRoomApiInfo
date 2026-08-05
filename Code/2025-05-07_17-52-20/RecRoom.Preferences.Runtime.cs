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
		[Cpp2IlInjected.Address(RVA = "0x7FE3710", Offset = "0x7FE2710", VA = "0x187FE3710", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FDCBB0", Offset = "0x7FDBBB0", VA = "0x187FDCBB0")]
	private static void PJPHEHGADLN(EJAEICGHADP NEIAGIIAPIA, FMPKBOPEANH LBNAINNHMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCA50", Offset = "0x7FDBA50", VA = "0x187FDCA50")]
	public static bool OOOLGFFFLFM(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC640", Offset = "0x7FDB640", VA = "0x187FDC640")]
	public static OFLEGLNACKE MOPLEPLKHLB(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, string OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC270", Offset = "0x7FDB270", VA = "0x187FDC270")]
	public static OFLEGLNACKE DGCBKIOFEDE(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, int OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC790", Offset = "0x7FDB790", VA = "0x187FDC790")]
	public static OFLEGLNACKE NINNJAGJEMI(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, bool OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC4F0", Offset = "0x7FDB4F0", VA = "0x187FDC4F0")]
	public static OFLEGLNACKE KGJMKPIBECB(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, float OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC8E0", Offset = "0x7FDB8E0", VA = "0x187FDC8E0")]
	public static OFLEGLNACKE OKEJGLLIFLF(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, DateTime OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC3B0", Offset = "0x7FDB3B0", VA = "0x187FDC3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> ECNEIEJJBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C20", Offset = "0x7FE0C20", VA = "0x187FE1C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3580", Offset = "0x7FE2580", VA = "0x187FE3580")]
	[UnityEngine.Scripting.Preserve]
	public PEAICNOAJON([DJIFKCCBBND(null)] FPBNEHFKCNA MAIHMBHHHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1CD0", Offset = "0x7FE0CD0", VA = "0x187FE1CD0")]
	private DirectoryInfo FLJLDGCBABH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1FB0", Offset = "0x7FE0FB0", VA = "0x187FE1FB0", Slot = "6")]
	public Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C60", Offset = "0x7FE0C60", VA = "0x187FE1C60", Slot = "14")]
	public float EPIJGHEEOEF(string OEHHKNIGGMI, float JMMNJNFGHEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3440", Offset = "0x7FE2440", VA = "0x187FE3440", Slot = "13")]
	public void OFNIIOFAJPM(string OEHHKNIGGMI, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FE34B0", Offset = "0x7FE24B0", VA = "0x187FE34B0", Slot = "12")]
	public bool OKLGNCIFKBA(string OEHHKNIGGMI, bool JMMNJNFGHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FE33D0", Offset = "0x7FE23D0", VA = "0x187FE33D0", Slot = "10")]
	public int NNOIHJGKKGM(string OEHHKNIGGMI, int JMMNJNFGHEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2840", Offset = "0x7FE1840", VA = "0x187FE2840", Slot = "18")]
	public DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2AB0", Offset = "0x7FE1AB0", VA = "0x187FE2AB0", Slot = "19")]
	public void KCEJNGCHGLO(string OEHHKNIGGMI, DateTime OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2FA0", Offset = "0x7FE1FA0", VA = "0x187FE2FA0", Slot = "15")]
	public void NAAAPAAPMMK(string OEHHKNIGGMI, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1BB0", Offset = "0x7FE0BB0", VA = "0x187FE1BB0", Slot = "11")]
	public void CMIPEDDPBGD(string OEHHKNIGGMI, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE19F0", Offset = "0x7FE09F0", VA = "0x187FE19F0", Slot = "20")]
	public long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1F40", Offset = "0x7FE0F40", VA = "0x187FE1F40", Slot = "21")]
	public void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x36B5420", Offset = "0x36B4420", VA = "0x1836B5420", Slot = "22")]
	public T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x36B5420", Offset = "0x36B4420", VA = "0x1836B5420", Slot = "23")]
	public void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2BB0", Offset = "0x7FE1BB0", VA = "0x187FE2BB0", Slot = "16")]
	public string LEEDJCCMEMN(string OEHHKNIGGMI, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1DD0", Offset = "0x7FE0DD0", VA = "0x187FE1DD0", Slot = "17")]
	public void GBEIMMODMEC(string OEHHKNIGGMI, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1A60", Offset = "0x7FE0A60", VA = "0x187FE1A60", Slot = "24")]
	public void BPKBPKIGDMC(string OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2B20", Offset = "0x7FE1B20", VA = "0x187FE2B20", Slot = "9")]
	public bool KKKODMEFLHH(string OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2C60", Offset = "0x7FE1C60", VA = "0x187FE2C60", Slot = "25")]
	public Task LKBHDLALJNO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3010", Offset = "0x7FE2010", VA = "0x187FE3010")]
	private void NCFKIEPADPI(DirectoryInfo GOCPDDDHFNC, string IOHNDODJOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FE28B0", Offset = "0x7FE18B0", VA = "0x187FE28B0")]
	private static string JFCFMPHHCKC(string OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1E40", Offset = "0x7FE0E40", VA = "0x187FE1E40")]
	private static string GNHKHELCLNK(byte[] ACDPPDBEDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x39F14A0", Offset = "0x39F04A0", VA = "0x1839F14A0")]
	private T PHDCGNDDLGA<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x39F0360", Offset = "0x39EF360", VA = "0x1839F0360")]
	private void DGBNDJBCMEF<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2040", Offset = "0x7FE1040", VA = "0x187FE2040")]
	private Dictionary<string, string> ICCEALGLFHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class AIKCFMNJEFH
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA7B0", Offset = "0x7FD97B0", VA = "0x187FDA7B0")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL NELIKBMJKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JMGOCDGAGLG : MODBBAKCKIL
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCC30", Offset = "0x7FDBC30", VA = "0x187FDCC30")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0CD0", Offset = "0x7FDFCD0", VA = "0x187FE0CD0", Slot = "6")]
	public Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0E20", Offset = "0x7FDFE20", VA = "0x187FE0E20", Slot = "9")]
	public bool KKKODMEFLHH(string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0FD0", Offset = "0x7FDFFD0", VA = "0x187FE0FD0", Slot = "10")]
	public int NNOIHJGKKGM(string DEMJFJNLMJF, int JMMNJNFGHEP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0B50", Offset = "0x7FDFB50", VA = "0x187FE0B50", Slot = "11")]
	public void CMIPEDDPBGD(string DEMJFJNLMJF, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1090", Offset = "0x7FE0090", VA = "0x187FE1090", Slot = "12")]
	public bool OKLGNCIFKBA(string DEMJFJNLMJF, bool JMMNJNFGHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1030", Offset = "0x7FE0030", VA = "0x187FE1030", Slot = "13")]
	public void OFNIIOFAJPM(string DEMJFJNLMJF, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0BB0", Offset = "0x7FDFBB0", VA = "0x187FE0BB0", Slot = "14")]
	public float EPIJGHEEOEF(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0F70", Offset = "0x7FDFF70", VA = "0x187FE0F70", Slot = "15")]
	public void NAAAPAAPMMK(string DEMJFJNLMJF, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0E80", Offset = "0x7FDFE80", VA = "0x187FE0E80", Slot = "16")]
	public string LEEDJCCMEMN(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0C10", Offset = "0x7FDFC10", VA = "0x187FE0C10", Slot = "17")]
	public void GBEIMMODMEC(string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0D60", Offset = "0x7FDFD60", VA = "0x187FE0D60", Slot = "18")]
	public DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0DC0", Offset = "0x7FDFDC0", VA = "0x187FE0DC0", Slot = "19")]
	public void KCEJNGCHGLO(string DEMJFJNLMJF, DateTime OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0A90", Offset = "0x7FDFA90", VA = "0x187FE0A90", Slot = "20")]
	public long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0C70", Offset = "0x7FDFC70", VA = "0x187FE0C70", Slot = "21")]
	public void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3926810", Offset = "0x3925810", VA = "0x183926810", Slot = "22")]
	public T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3926930", Offset = "0x3925930", VA = "0x183926930", Slot = "23")]
	public void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3926A10", Offset = "0x3925A10", VA = "0x183926A10")]
	public T PHDCGNDDLGA<T>(string DEMJFJNLMJF, T JMMNJNFGHEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3926320", Offset = "0x3925320", VA = "0x183926320")]
	public void DGBNDJBCMEF<T>(string DEMJFJNLMJF, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0AF0", Offset = "0x7FDFAF0", VA = "0x187FE0AF0", Slot = "24")]
	public void BPKBPKIGDMC(string DEMJFJNLMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0EE0", Offset = "0x7FDFEE0", VA = "0x187FE0EE0", Slot = "25")]
	public Task LKBHDLALJNO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCC30", Offset = "0x7FDBC30", VA = "0x187FDCC30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AD0540", Offset = "0x4ACF540", VA = "0x184AD0540")]
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
	[Cpp2IlInjected.Address(RVA = "0x4ACFF70", Offset = "0x4ACEF70", VA = "0x184ACFF70")]
	public static void BKAALCDLOJI(string OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4AD01C0", Offset = "0x4ACF1C0", VA = "0x184AD01C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A59400", Offset = "0x6A58400", VA = "0x186A59400")]
	public bool LKMKPGKLGLC(string KBMOAEOFKJM, [Out] TValue HOPGKAFMGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A592D0", Offset = "0x6A582D0", VA = "0x186A592D0")]
	public void CDGBJDHGNGE(string KBMOAEOFKJM, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FA70", Offset = "0x4A7EA70", VA = "0x184A7FA70", Slot = "4")]
	protected override void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x496DFE0", Offset = "0x496CFE0", VA = "0x18496DFE0", Slot = "5")]
	protected override void ONNIHLLFAHE(string KBMOAEOFKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A595A0", Offset = "0x6A585A0", VA = "0x186A595A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FDBE40", Offset = "0x7FDAE40", VA = "0x187FDBE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC210", Offset = "0x7FDB210", VA = "0x187FDC210", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public DBEMGJPFFOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDADB0", Offset = "0x7FD9DB0", VA = "0x187FDADB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7FDAE20", Offset = "0x7FD9E20", VA = "0x187FDAE20", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1900", Offset = "0x7FE0900", VA = "0x187FE1900")]
	[UnityEngine.Scripting.Preserve]
	public OBJLGMNGAGE([DJIFKCCBBND(null)] FPBNEHFKCNA MAIHMBHHHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1410", Offset = "0x7FE0410", VA = "0x187FE1410", Slot = "6")]
	public Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1ACBAE0", Offset = "0x1ACAAE0", VA = "0x181ACBAE0")]
	private static int IKPOKDMPCLN(bool OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1670", Offset = "0x7FE0670", VA = "0x187FE1670", Slot = "9")]
	public bool KKKODMEFLHH(string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1870", Offset = "0x7FE0870", VA = "0x187FE1870", Slot = "10")]
	public int NNOIHJGKKGM(string DEMJFJNLMJF, int JMMNJNFGHEP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7FE11F0", Offset = "0x7FE01F0", VA = "0x187FE11F0", Slot = "11")]
	public void CMIPEDDPBGD(string DEMJFJNLMJF, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FE18D0", Offset = "0x7FE08D0", VA = "0x187FE18D0", Slot = "12")]
	public bool OKLGNCIFKBA(string DEMJFJNLMJF, bool JMMNJNFGHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FE18A0", Offset = "0x7FE08A0", VA = "0x187FE18A0", Slot = "13")]
	public void OFNIIOFAJPM(string DEMJFJNLMJF, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1340", Offset = "0x7FE0340", VA = "0x187FE1340", Slot = "14")]
	public float EPIJGHEEOEF(string DEMJFJNLMJF, float JMMNJNFGHEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FE17D0", Offset = "0x7FE07D0", VA = "0x187FE17D0", Slot = "15")]
	public void NAAAPAAPMMK(string DEMJFJNLMJF, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1520", Offset = "0x7FE0520", VA = "0x187FE1520", Slot = "18")]
	public DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1600", Offset = "0x7FE0600", VA = "0x187FE1600", Slot = "19")]
	public void KCEJNGCHGLO(string DEMJFJNLMJF, DateTime PLBAFGHLBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FE10F0", Offset = "0x7FE00F0", VA = "0x187FE10F0", Slot = "20")]
	public long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE13A0", Offset = "0x7FE03A0", VA = "0x187FE13A0", Slot = "21")]
	public void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x39C93B0", Offset = "0x39C83B0", VA = "0x1839C93B0", Slot = "22")]
	public T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x39C93B0", Offset = "0x39C83B0", VA = "0x1839C93B0", Slot = "23")]
	public void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x39C80E0", Offset = "0x39C70E0", VA = "0x1839C80E0")]
	private T CGDEEHFLOCJ<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x39C8C40", Offset = "0x39C7C40", VA = "0x1839C8C40")]
	private void EIOJNGJHOIM<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1690", Offset = "0x7FE0690", VA = "0x187FE1690", Slot = "16")]
	public string LEEDJCCMEMN(string DEMJFJNLMJF, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1370", Offset = "0x7FE0370", VA = "0x187FE1370", Slot = "17")]
	public void GBEIMMODMEC(string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7FE12C0", Offset = "0x7FE02C0", VA = "0x187FE12C0")]
	private void DHAJLODPGMO(string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7FE17B0", Offset = "0x7FE07B0", VA = "0x187FE17B0")]
	private string MCPGCFBLGCL(string DEMJFJNLMJF, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1160", Offset = "0x7FE0160", VA = "0x187FE1160", Slot = "24")]
	public void BPKBPKIGDMC(string DEMJFJNLMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1220", Offset = "0x7FE0220", VA = "0x187FE1220")]
	private string DDEFEIKIPED(string OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FE16C0", Offset = "0x7FE06C0", VA = "0x187FE16C0", Slot = "25")]
	[AsyncStateMachine(typeof(ICEPJNDOHNA))]
	public Task LKBHDLALJNO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FE14A0", Offset = "0x7FE04A0", VA = "0x187FE14A0")]
	[IteratorStateMachine(typeof(DBEMGJPFFOO))]
	private IEnumerator<NFNODNEANBN> IDBAJGLGEDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7FE12E0", Offset = "0x7FE02E0", VA = "0x187FE12E0")]
	private void EIPOFNCEPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1800", Offset = "0x7FE0800", VA = "0x187FE1800")]
	private void NHDMOIOBIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1590", Offset = "0x7FE0590", VA = "0x187FE1590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string JFMFLKALIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB2B0", Offset = "0x7FDA2B0", VA = "0x187FDB2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> ECNEIEJJBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB0F0", Offset = "0x7FDA0F0", VA = "0x187FDB0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	[UnityEngine.Scripting.Preserve]
	public DPIDOAHFPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB320", Offset = "0x7FDA320", VA = "0x187FDB320", Slot = "6")]
	public Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB130", Offset = "0x7FDA130", VA = "0x187FDB130", Slot = "14")]
	public float EPIJGHEEOEF(string OEHHKNIGGMI, float JMMNJNFGHEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBC20", Offset = "0x7FDAC20", VA = "0x187FDBC20", Slot = "13")]
	public void OFNIIOFAJPM(string OEHHKNIGGMI, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBC90", Offset = "0x7FDAC90", VA = "0x187FDBC90", Slot = "12")]
	public bool OKLGNCIFKBA(string OEHHKNIGGMI, bool JMMNJNFGHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBBB0", Offset = "0x7FDABB0", VA = "0x187FDBBB0", Slot = "10")]
	public int NNOIHJGKKGM(string OEHHKNIGGMI, int JMMNJNFGHEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB6B0", Offset = "0x7FDA6B0", VA = "0x187FDB6B0", Slot = "18")]
	public DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB720", Offset = "0x7FDA720", VA = "0x187FDB720", Slot = "19")]
	public void KCEJNGCHGLO(string OEHHKNIGGMI, DateTime OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBB40", Offset = "0x7FDAB40", VA = "0x187FDBB40", Slot = "15")]
	public void NAAAPAAPMMK(string OEHHKNIGGMI, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB080", Offset = "0x7FDA080", VA = "0x187FDB080", Slot = "11")]
	public void CMIPEDDPBGD(string OEHHKNIGGMI, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAF50", Offset = "0x7FD9F50", VA = "0x187FDAF50", Slot = "20")]
	public long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB240", Offset = "0x7FDA240", VA = "0x187FDB240", Slot = "21")]
	public void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x36B5420", Offset = "0x36B4420", VA = "0x1836B5420", Slot = "22")]
	public T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x36B5420", Offset = "0x36B4420", VA = "0x1836B5420", Slot = "23")]
	public void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB820", Offset = "0x7FDA820", VA = "0x187FDB820", Slot = "16")]
	public string LEEDJCCMEMN(string OEHHKNIGGMI, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB1A0", Offset = "0x7FDA1A0", VA = "0x187FDB1A0", Slot = "17")]
	public void GBEIMMODMEC(string OEHHKNIGGMI, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAFC0", Offset = "0x7FD9FC0", VA = "0x187FDAFC0", Slot = "24")]
	public void BPKBPKIGDMC(string OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB790", Offset = "0x7FDA790", VA = "0x187FDB790", Slot = "9")]
	public bool KKKODMEFLHH(string OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB8D0", Offset = "0x7FDA8D0", VA = "0x187FDB8D0", Slot = "25")]
	public Task LKBHDLALJNO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x36B5620", Offset = "0x36B4620", VA = "0x1836B5620")]
	private T PHDCGNDDLGA<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x36B43B0", Offset = "0x36B33B0", VA = "0x1836B43B0")]
	private void DGBNDJBCMEF<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB3B0", Offset = "0x7FDA3B0", VA = "0x187FDB3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FE0730", Offset = "0x7FDF730", VA = "0x187FE0730")]
		public static void JKEPHKCGLAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void INBDHNEFJBE();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> BJDDJBEMMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool FHJCOLKGBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x44B3810", Offset = "0x44B2810", VA = "0x1844B3810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4C77330", Offset = "0x4C76330", VA = "0x184C77330")]
		private AKEECHJFHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4C76D60", Offset = "0x4C75D60", VA = "0x184C76D60")]
		public void AMBIAOGNIIF(NBHJDEFAJJO<T> PLJDBFGEJFF, [Optional] IEqualityComparer<T> EFGNCEEFOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4C770E0", Offset = "0x4C760E0", VA = "0x184C770E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FDBD90", Offset = "0x7FDAD90", VA = "0x187FDBD90")]
		public FFEJPBCLNGD(KJEKKKNMJGB MLJOMODDHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDBD60", Offset = "0x7FDAD60", VA = "0x187FDBD60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FDCCC0", Offset = "0x7FDBCC0", VA = "0x187FDCCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCFB0", Offset = "0x7FDBFB0", VA = "0x187FDCFB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FE0900", Offset = "0x7FDF900", VA = "0x187FE0900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FDD010", Offset = "0x7FDC010", VA = "0x187FDD010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD4E0", Offset = "0x7FDC4E0", VA = "0x187FDD4E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public DJOPLIEDHFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7FDAE70", Offset = "0x7FD9E70", VA = "0x187FDAE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7FDAF00", Offset = "0x7FD9F00", VA = "0x187FDAF00", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FDEE00", Offset = "0x7FDDE00", VA = "0x187FDEE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource PNPJLMPNADA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE7F0", Offset = "0x7FDD7F0", VA = "0x187FDE7F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE130", Offset = "0x7FDD130", VA = "0x187FDE130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFE10", Offset = "0x7FDEE10", VA = "0x187FDFE10")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0360", Offset = "0x7FDF360", VA = "0x187FE0360")]
	[UnityEngine.Scripting.Preserve]
	public KJEKKKNMJGB([DJIFKCCBBND("Disk")] MGBMDHHJOAM JHIBALEOLJM, [DJIFKCCBBND("Cloud")] MGBMDHHJOAM PNMPKMPMCBI, [DJIFKCCBBND(null)] MIGPCMLOJNH FBLIMLNFLJI, [DJIFKCCBBND(null)] GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDC50", Offset = "0x7FDCC50", VA = "0x187FDDC50", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDE20", Offset = "0x7FDCE20", VA = "0x187FDDE20")]
	private void FBBNEMABKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD810", Offset = "0x7FDC810", VA = "0x187FDD810", Slot = "6")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0050", Offset = "0x7FDF050", VA = "0x187FE0050", Slot = "7")]
	public Task PJCMIBBHEOE(long OGCAMFNODBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0250", Offset = "0x7FDF250", VA = "0x187FE0250")]
	[AsyncStateMachine(typeof(KAJNFBAPOOF))]
	private Task POLOJCFAAPF(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEE20", Offset = "0x7FDDE20", VA = "0x187FDEE20")]
	private void KAAKMMABKKF(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD540", Offset = "0x7FDC540", VA = "0x187FDD540")]
	private void AAEOFNLNFKE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE790", Offset = "0x7FDD790", VA = "0x187FDE790")]
	private string HFMICCJJBDJ(string HNIMABPKBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFE80", Offset = "0x7FDEE80", VA = "0x187FDFE80")]
	private void OJHCKAEFNJL(KAPLCGNEGKI EIBMKBIIOGF, string OEHHKNIGGMI, [Out] MGBMDHHJOAM NEIAGIIAPIA, [Out] string LBFEIPBHCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFD90", Offset = "0x7FDED90", VA = "0x187FDFD90")]
	private MGBMDHHJOAM NLGLCLNCNML(KAPLCGNEGKI EIBMKBIIOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFB60", Offset = "0x7FDEB60", VA = "0x187FDFB60", Slot = "8")]
	public bool NHLHDJCGBCI(KAPLCGNEGKI EIBMKBIIOGF = KAPLCGNEGKI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF570", Offset = "0x7FDE570", VA = "0x187FDF570", Slot = "9")]
	public bool MKOAELJLNPA(string DEMJFJNLMJF, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE610", Offset = "0x7FDD610", VA = "0x187FDE610", Slot = "10")]
	public bool GKGFFIMKOMO(string DEMJFJNLMJF, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD770", Offset = "0x7FDC770", VA = "0x187FDD770", Slot = "11")]
	public string BHIFOGIADJK(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEA00", Offset = "0x7FDDA00", VA = "0x187FDEA00", Slot = "12")]
	public OFLEGLNACKE IFECIEBHLFN(string DEMJFJNLMJF, string OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEED0", Offset = "0x7FDDED0", VA = "0x187FDEED0", Slot = "13")]
	public int KGHOMABCGNF(string DEMJFJNLMJF, int JMMNJNFGHEP = 0, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF3C0", Offset = "0x7FDE3C0", VA = "0x187FDF3C0", Slot = "14")]
	public OFLEGLNACKE MDOIDMCPDIG(string DEMJFJNLMJF, int OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEBB0", Offset = "0x7FDDBB0", VA = "0x187FDEBB0", Slot = "15")]
	public bool INOJIKEIAJG(string DEMJFJNLMJF, bool JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDAB0", Offset = "0x7FDCAB0", VA = "0x187FDDAB0", Slot = "16")]
	public OFLEGLNACKE DJJIJODLAHE(string DEMJFJNLMJF, bool OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEF80", Offset = "0x7FDDF80", VA = "0x187FDEF80", Slot = "17")]
	public float KLBNPCGJLFH(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF9E0", Offset = "0x7FDE9E0", VA = "0x187FDF9E0", Slot = "18")]
	public OFLEGLNACKE NCFPCFHEBNJ(string DEMJFJNLMJF, float OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE570", Offset = "0x7FDD570", VA = "0x187FDE570", Slot = "19")]
	public DateTime GDPAIGKBEHM(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEC60", Offset = "0x7FDDC60", VA = "0x187FDEC60", Slot = "20")]
	public OFLEGLNACKE JDKDCDICEJL(string DEMJFJNLMJF, DateTime OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE960", Offset = "0x7FDD960", VA = "0x187FDE960", Slot = "21")]
	public long IAICFHMLPJG(string DEMJFJNLMJF, long JMMNJNFGHEP = 0L, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFC20", Offset = "0x7FDEC20", VA = "0x187FDFC20", Slot = "22")]
	public OFLEGLNACKE NJKMGNEJJCB(string DEMJFJNLMJF, long OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x38EBDF0", Offset = "0x38EADF0", VA = "0x1838EBDF0", Slot = "23")]
	public T ICHKOICLOPN<T>(string DEMJFJNLMJF, [Optional] T JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x38EBDF0", Offset = "0x38EADF0", VA = "0x1838EBDF0", Slot = "24")]
	public OFLEGLNACKE FANLJBMFFIC<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE900", Offset = "0x7FDD900", VA = "0x187FDE900", Slot = "25")]
	public bool HPGOCANFHFN(string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF3B0", Offset = "0x7FDE3B0", VA = "0x187FDF3B0", Slot = "26")]
	public bool MDMJEBBGIDC(string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD880", Offset = "0x7FDC880", VA = "0x187FDD880", Slot = "27")]
	public string CLMAHFDFELF(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDDF0", Offset = "0x7FDCDF0", VA = "0x187FDDDF0", Slot = "28")]
	public OFLEGLNACKE EKIFAPJFAED(string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD5C0", Offset = "0x7FDC5C0", VA = "0x187FDD5C0", Slot = "29")]
	public int BADNBIINAFO(string DEMJFJNLMJF, int JMMNJNFGHEP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0020", Offset = "0x7FDF020", VA = "0x187FE0020", Slot = "30")]
	public OFLEGLNACKE OOGEFPLPPOO(string DEMJFJNLMJF, int OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDC90", Offset = "0x7FDCC90", VA = "0x187FDDC90", Slot = "31")]
	public bool EEANPDMCNNF(string DEMJFJNLMJF, bool JMMNJNFGHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF170", Offset = "0x7FDE170", VA = "0x187FDF170", Slot = "32")]
	public OFLEGLNACKE LFEHEOOKCPI(string DEMJFJNLMJF, bool OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE890", Offset = "0x7FDD890", VA = "0x187FDE890", Slot = "33")]
	public float HMDOHOEFEPD(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDC20", Offset = "0x7FDCC20", VA = "0x187FDDC20", Slot = "34")]
	public OFLEGLNACKE DPEJHGKPEAE(string DEMJFJNLMJF, float OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDF50", Offset = "0x7FDCF50", VA = "0x187FDDF50", Slot = "35")]
	public DateTime FBOCNFCAHEJ(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0220", Offset = "0x7FDF220", VA = "0x187FE0220", Slot = "36")]
	public OFLEGLNACKE PMMDODJHGPI(string DEMJFJNLMJF, DateTime OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD8F0", Offset = "0x7FDC8F0", VA = "0x187FDD8F0", Slot = "37")]
	public long DBFKINJJFHI(string DEMJFJNLMJF, long JMMNJNFGHEP = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEB80", Offset = "0x7FDDB80", VA = "0x187FDEB80", Slot = "38")]
	public OFLEGLNACKE IILLDJOFDFG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE1D0", Offset = "0x7FDD1D0", VA = "0x187FDE1D0")]
	private bool FHEEBADODPJ(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE230", Offset = "0x7FDD230", VA = "0x187FDE230")]
	private bool FLNFKGAABPG(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD960", Offset = "0x7FDC960", VA = "0x187FDD960")]
	private OFLEGLNACKE DCMLFIKLLJI(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF270", Offset = "0x7FDE270", VA = "0x187FDF270")]
	private OFLEGLNACKE MBAIKNNGIMK(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, int OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD630", Offset = "0x7FDC630", VA = "0x187FDD630")]
	private OFLEGLNACKE BDNIEIGJPHN(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, bool OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF610", Offset = "0x7FDE610", VA = "0x187FDF610")]
	private OFLEGLNACKE MMNDKJPPNOC(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, float OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDFC0", Offset = "0x7FDCFC0", VA = "0x187FDDFC0")]
	private OFLEGLNACKE FCCJLCONKNL(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, DateTime OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF030", Offset = "0x7FDE030", VA = "0x187FDF030")]
	private OFLEGLNACKE LCCGPLMODGL(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x38EBFC0", Offset = "0x38EAFC0", VA = "0x1838EBFC0")]
	private T FGLLOPAHMAA<T>(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, T JMMNJNFGHEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x38EC740", Offset = "0x38EB740", VA = "0x1838EC740")]
	private OFLEGLNACKE LCLLHBGLOKP<T>(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, T OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x38EBD40", Offset = "0x38EAD40", VA = "0x1838EBD40", Slot = "39")]
	public void BGGMEOENCAN<T>(NBHJDEFAJJO<T> BAGAKFJAGLG, [Optional] IEqualityComparer<T> EFGNCEEFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x38EC6C0", Offset = "0x38EB6C0", VA = "0x1838EC6C0", Slot = "40")]
	public void KHFBGKEMANK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF1A0", Offset = "0x7FDE1A0", VA = "0x187FDF1A0")]
	[AsyncStateMachine(typeof(MMALPGJOHEB))]
	private void LKBHDLALJNO(EJAEICGHADP LDOMBAIIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDD00", Offset = "0x7FDCD00", VA = "0x187FDDD00", Slot = "43")]
	[AsyncStateMachine(typeof(KGMKLOMMEKH))]
	public Task EIPOFNCEPMA([Optional] CancellationToken EJJDDFFADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE390", Offset = "0x7FDD390", VA = "0x187FDE390")]
	private void GAKLCPDEDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDE70", Offset = "0x7FDCE70", VA = "0x187FDDE70", Slot = "41")]
	public IDisposable FBMCCEMFOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF530", Offset = "0x7FDE530", VA = "0x187FDF530", Slot = "42")]
	public void MFLJHJIGHAL(float EPOJNFBFHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF760", Offset = "0x7FDE760", VA = "0x187FDF760")]
	private void MONAEHLMHGL(float LLKEPBHGFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEE40", Offset = "0x7FDDE40", VA = "0x187FDEE40")]
	[IteratorStateMachine(typeof(DJOPLIEDHFO))]
	private IEnumerator<NFNODNEANBN> KAHMCELNOKA(float EPOJNFBFHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF540", Offset = "0x7FDE540", VA = "0x187FDF540")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FDAC80", Offset = "0x7FD9C80", VA = "0x187FDAC80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA910", Offset = "0x7FD9910", VA = "0x187FDA910", Slot = "9")]
	public override string DFNAEDFOBIJ(bool HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAA00", Offset = "0x7FD9A00", VA = "0x187FDAA00", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] bool OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAD70", Offset = "0x7FD9D70", VA = "0x187FDAD70")]
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
