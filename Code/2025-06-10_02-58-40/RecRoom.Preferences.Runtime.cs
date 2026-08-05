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
		[Cpp2IlInjected.Address(RVA = "0x8012840", Offset = "0x8011A40", VA = "0x188012840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ALAAJDPECKP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class IIJKLMMBNKE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void LCFCELIHEKL(HPOPFPOPKJN KPLDOPEGNHI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x800F760", Offset = "0x800E960", VA = "0x18800F760")]
	private static void BFICEIPEDKA(HPOPFPOPKJN KPLDOPEGNHI, LCFCELIHEKL PBHNHCIFFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x800F7E0", Offset = "0x800E9E0", VA = "0x18800F7E0")]
	public static bool CHDEGFAAANF(this HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, [Optional] LCFCELIHEKL PBHNHCIFFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x800FBF0", Offset = "0x800EDF0", VA = "0x18800FBF0")]
	public static CMCLIKEIBCN FPFICOFPHCF(this HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, string KJIOHKMJAPE, [Optional] LCFCELIHEKL PBHNHCIFFNL)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x800FAB0", Offset = "0x800ECB0", VA = "0x18800FAB0")]
	public static CMCLIKEIBCN DPLEHPFDCCB(this HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, int KJIOHKMJAPE, [Optional] LCFCELIHEKL PBHNHCIFFNL)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x800FE80", Offset = "0x800F080", VA = "0x18800FE80")]
	public static CMCLIKEIBCN ODNLIPEPKLL(this HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, bool KJIOHKMJAPE, [Optional] LCFCELIHEKL PBHNHCIFFNL)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x800F610", Offset = "0x800E810", VA = "0x18800F610")]
	public static CMCLIKEIBCN BEMBPPKJLCN(this HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, float KJIOHKMJAPE, [Optional] LCFCELIHEKL PBHNHCIFFNL)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x800F940", Offset = "0x800EB40", VA = "0x18800F940")]
	public static CMCLIKEIBCN DOGCJJMIAMF(this HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, DateTime KJIOHKMJAPE, [Optional] LCFCELIHEKL PBHNHCIFFNL)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x800FD40", Offset = "0x800EF40", VA = "0x18800FD40")]
	public static CMCLIKEIBCN HBJBNEKGDGM(this HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, long KJIOHKMJAPE, [Optional] LCFCELIHEKL PBHNHCIFFNL)
	{
		return default(CMCLIKEIBCN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KFFDMGCIGKC : MHKEPNKOKKD, HPOPFPOPKJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CGAFGMGAKPP FENMLPHGKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> EEPHMLFGFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> HJLPLMGDMBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> AOPCOMLCMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8010710", Offset = "0x800F910", VA = "0x188010710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action HMFCMPCMFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8011B10", Offset = "0x8010D10", VA = "0x188011B10")]
	[UnityEngine.Scripting.Preserve]
	public KFFDMGCIGKC([NGLIAOPBMFM(null)] CGAFGMGAKPP FENMLPHGKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "8")]
	public void FAMNGHPLDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x80104A0", Offset = "0x800F6A0", VA = "0x1880104A0")]
	private DirectoryInfo HIECGCLNHCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8010120", Offset = "0x800F320", VA = "0x188010120", Slot = "6")]
	public Task AKEIHGODOAD(long FKBNINAMDMM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80102E0", Offset = "0x800F4E0", VA = "0x1880102E0", Slot = "14")]
	public float DILGGDLCEJF(string MHDODBCCAJB, float FEOJADDJKIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8011960", Offset = "0x8010B60", VA = "0x188011960", Slot = "13")]
	public void PBCLLIDPAMG(string MHDODBCCAJB, bool KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8010220", Offset = "0x800F420", VA = "0x188010220", Slot = "12")]
	public bool BDLKADGHCCB(string MHDODBCCAJB, bool FEOJADDJKIL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80101B0", Offset = "0x800F3B0", VA = "0x1880101B0", Slot = "10")]
	public int AKGHOIPMPDH(string MHDODBCCAJB, int FEOJADDJKIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80103C0", Offset = "0x800F5C0", VA = "0x1880103C0", Slot = "18")]
	public DateTime HCCDMLIPMGC(string KGBLLKPNCLE, [Optional] DateTime FEOJADDJKIL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8010350", Offset = "0x800F550", VA = "0x188010350", Slot = "19")]
	public void GLBHGOGADAD(string MHDODBCCAJB, DateTime KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80106A0", Offset = "0x800F8A0", VA = "0x1880106A0", Slot = "15")]
	public void ILJKPBBMAJE(string MHDODBCCAJB, float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8010750", Offset = "0x800F950", VA = "0x188010750", Slot = "11")]
	public void LCIGDLEDDBM(string MHDODBCCAJB, int KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8011530", Offset = "0x8010730", VA = "0x188011530", Slot = "20")]
	public long OCPCKMDPLJA(string KGBLLKPNCLE, long FEOJADDJKIL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8010430", Offset = "0x800F630", VA = "0x188010430", Slot = "21")]
	public void HECDCBLKECE(string KGBLLKPNCLE, long KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39E8920", Offset = "0x39E7B20", VA = "0x1839E8920", Slot = "22")]
	public T FOCLLMMKMOP<T>(string KGBLLKPNCLE, T FEOJADDJKIL, OIKEJCNDEBN<T> PNAKPJNABJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39E8A30", Offset = "0x39E7C30", VA = "0x1839E8A30", Slot = "23")]
	public void MHFGOGNAKPO<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, OIKEJCNDEBN<T> PNAKPJNABJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8011A60", Offset = "0x8010C60", VA = "0x188011A60", Slot = "16")]
	public string POIECIFKOOP(string MHDODBCCAJB, string FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80107C0", Offset = "0x800F9C0", VA = "0x1880107C0", Slot = "17")]
	public void MDHJBJCPAHC(string MHDODBCCAJB, string KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x800FFD0", Offset = "0x800F1D0", VA = "0x18800FFD0", Slot = "24")]
	public void AFMKOODKDNO(string MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80119D0", Offset = "0x8010BD0", VA = "0x1880119D0", Slot = "9")]
	public bool PGBEIBOONKI(string MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8011000", Offset = "0x8010200", VA = "0x188011000", Slot = "25")]
	public Task MMAMKHAELBB(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80115A0", Offset = "0x80107A0", VA = "0x1880115A0")]
	private void OKAPOIHKCJN(DirectoryInfo BNFKCAGGOCI, string GFKHDHEKGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8011330", Offset = "0x8010530", VA = "0x188011330")]
	private static string NMPDKGDHLOF(string MHDODBCCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x80105A0", Offset = "0x800F7A0", VA = "0x1880105A0")]
	private static string IDEBCEOOFPD(byte[] DJMFMHNIFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3AAAF30", Offset = "0x3AAA130", VA = "0x183AAAF30")]
	private T AFHCIICHJIO<T>(string KGBLLKPNCLE, T FEOJADDJKIL, [Optional] OIKEJCNDEBN<T> IDEKOJMAAKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC050", Offset = "0x3AAB250", VA = "0x183AAC050")]
	private void DEEMOOGCBGF<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, [Optional] OIKEJCNDEBN<T> IDEKOJMAAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8010830", Offset = "0x800FA30", VA = "0x188010830")]
	private Dictionary<string, string> MHDBODMMMOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class FEMJMLIJDAK
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x800EAB0", Offset = "0x800DCB0", VA = "0x18800EAB0")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void CNMFKDBOHKK(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FFHAGGKPOGL : NKOAGAAAPNO
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x800EC10", Offset = "0x800DE10", VA = "0x18800EC10")]
	[UnityEngine.Scripting.Preserve]
	public FFHAGGKPOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NKOAGAAAPNO : MHKEPNKOKKD, HPOPFPOPKJN, JFHCEAOILPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> INCKBGNEHBE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HMFCMPCMFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "8")]
	public void FAMNGHPLDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80120A0", Offset = "0x80112A0", VA = "0x1880120A0", Slot = "6")]
	public Task AKEIHGODOAD(long FKBNINAMDMM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80125E0", Offset = "0x80117E0", VA = "0x1880125E0", Slot = "9")]
	public bool PGBEIBOONKI(string KGBLLKPNCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8012130", Offset = "0x8011330", VA = "0x188012130", Slot = "10")]
	public int AKGHOIPMPDH(string KGBLLKPNCLE, int FEOJADDJKIL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80123D0", Offset = "0x80115D0", VA = "0x1880123D0", Slot = "11")]
	public void LCIGDLEDDBM(string KGBLLKPNCLE, int KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8012190", Offset = "0x8011390", VA = "0x188012190", Slot = "12")]
	public bool BDLKADGHCCB(string KGBLLKPNCLE, bool FEOJADDJKIL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8012580", Offset = "0x8011780", VA = "0x188012580", Slot = "13")]
	public void PBCLLIDPAMG(string KGBLLKPNCLE, bool KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80121F0", Offset = "0x80113F0", VA = "0x1880121F0", Slot = "14")]
	public float DILGGDLCEJF(string KGBLLKPNCLE, float FEOJADDJKIL = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8012370", Offset = "0x8011570", VA = "0x188012370", Slot = "15")]
	public void ILJKPBBMAJE(string KGBLLKPNCLE, float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8012640", Offset = "0x8011840", VA = "0x188012640", Slot = "16")]
	public string POIECIFKOOP(string KGBLLKPNCLE, [Optional] string FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8012430", Offset = "0x8011630", VA = "0x188012430", Slot = "17")]
	public void MDHJBJCPAHC(string KGBLLKPNCLE, string KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80122B0", Offset = "0x80114B0", VA = "0x1880122B0", Slot = "18")]
	public DateTime HCCDMLIPMGC(string KGBLLKPNCLE, [Optional] DateTime FEOJADDJKIL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8012250", Offset = "0x8011450", VA = "0x188012250", Slot = "19")]
	public void GLBHGOGADAD(string KGBLLKPNCLE, DateTime KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8012520", Offset = "0x8011720", VA = "0x188012520", Slot = "20")]
	public long OCPCKMDPLJA(string KGBLLKPNCLE, long FEOJADDJKIL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8012310", Offset = "0x8011510", VA = "0x188012310", Slot = "21")]
	public void HECDCBLKECE(string KGBLLKPNCLE, long KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B617E0", Offset = "0x3B609E0", VA = "0x183B617E0", Slot = "22")]
	public T FOCLLMMKMOP<T>(string KGBLLKPNCLE, T FEOJADDJKIL, OIKEJCNDEBN<T> PNAKPJNABJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B618E0", Offset = "0x3B60AE0", VA = "0x183B618E0", Slot = "23")]
	public void MHFGOGNAKPO<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, OIKEJCNDEBN<T> PNAKPJNABJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B60A50", Offset = "0x3B5FC50", VA = "0x183B60A50")]
	public T AFHCIICHJIO<T>(string KGBLLKPNCLE, T FEOJADDJKIL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B612F0", Offset = "0x3B604F0", VA = "0x183B612F0")]
	public void DEEMOOGCBGF<T>(string KGBLLKPNCLE, T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8012040", Offset = "0x8011240", VA = "0x188012040", Slot = "24")]
	public void AFMKOODKDNO(string KGBLLKPNCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8012490", Offset = "0x8011690", VA = "0x188012490", Slot = "25")]
	public Task MMAMKHAELBB(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x800EC10", Offset = "0x800DE10", VA = "0x18800EC10")]
	public NKOAGAAAPNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class DBDPLDDCGKH<TParent> where TParent : HPOPFPOPKJN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<DBDPLDDCGKH<TParent>> ALOAIBNELHO;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41FEF30", Offset = "0x41FE130", VA = "0x1841FEF30")]
	protected DBDPLDDCGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void OLKFAGPLGGN();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void GALJGJADLCH(string MHDODBCCAJB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x41FEBE0", Offset = "0x41FDDE0", VA = "0x1841FEBE0")]
	public static void LOEDJALGNOJ(string MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41FE9C0", Offset = "0x41FDBC0", VA = "0x1841FE9C0")]
	public static void IKKCGPKCPDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KNFALDMCFIG<TParent, TValue> : DBDPLDDCGKH<TParent> where TParent : HPOPFPOPKJN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly KNFALDMCFIG<TParent, TValue> LGHIFDBIJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> PMMEGBELEOE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x514B600", Offset = "0x514A800", VA = "0x18514B600")]
	public bool FBLKJFCBGPJ(string LMBJOMEGNFK, [Out] TValue MOJCFEGIIKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x514B640", Offset = "0x514A840", VA = "0x18514B640")]
	public void MHHMGGIKNDK(string LMBJOMEGNFK, TValue KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x514B740", Offset = "0x514A940", VA = "0x18514B740", Slot = "4")]
	protected override void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4DA0870", Offset = "0x4D9FA70", VA = "0x184DA0870", Slot = "5")]
	protected override void GALJGJADLCH(string LMBJOMEGNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x514B890", Offset = "0x514AA90", VA = "0x18514B890")]
	public KNFALDMCFIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HPOPFPOPKJN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAMNGHPLDLA();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PGBEIBOONKI(string KGBLLKPNCLE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AKGHOIPMPDH(string KGBLLKPNCLE, int FEOJADDJKIL = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCIGDLEDDBM(string KGBLLKPNCLE, int KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BDLKADGHCCB(string KGBLLKPNCLE, bool FEOJADDJKIL = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PBCLLIDPAMG(string KGBLLKPNCLE, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float DILGGDLCEJF(string KGBLLKPNCLE, float FEOJADDJKIL = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ILJKPBBMAJE(string KGBLLKPNCLE, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string POIECIFKOOP(string KGBLLKPNCLE, [Optional] string FEOJADDJKIL);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MDHJBJCPAHC(string KGBLLKPNCLE, string KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime HCCDMLIPMGC(string KGBLLKPNCLE, [Optional] DateTime IDJMBMEIHJD);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GLBHGOGADAD(string KGBLLKPNCLE, DateTime IDJMBMEIHJD);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long OCPCKMDPLJA(string KGBLLKPNCLE, long FEOJADDJKIL);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HECDCBLKECE(string KGBLLKPNCLE, long KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T FOCLLMMKMOP<T>(string KGBLLKPNCLE, T FEOJADDJKIL, OIKEJCNDEBN<T> PNAKPJNABJF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MHFGOGNAKPO<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, OIKEJCNDEBN<T> PNAKPJNABJF);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AFMKOODKDNO(string KGBLLKPNCLE);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task MMAMKHAELBB([Optional] CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MHKEPNKOKKD : HPOPFPOPKJN
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HMFCMPCMFNI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task AKEIHGODOAD(long FKBNINAMDMM, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JFHCEAOILPI : HPOPFPOPKJN
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BKEOJPJNKFL : MHKEPNKOKKD, HPOPFPOPKJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BDJLPONJAOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BKEOJPJNKFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8009A10", Offset = "0x8008C10", VA = "0x188009A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8009DF0", Offset = "0x8008FF0", VA = "0x188009DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class OFNPGADNIPG : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public BKEOJPJNKFL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public OFNPGADNIPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x80126A0", Offset = "0x80118A0", VA = "0x1880126A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8012710", Offset = "0x8011910", VA = "0x188012710", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CGAFGMGAKPP FENMLPHGKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool PIKFACCFIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool DHENJOOFKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private POGLNMFMHLK NIBFMCDFOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private AFABIGEDGFJ LGOIKKDMCAH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HMFCMPCMFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x800A660", Offset = "0x8009860", VA = "0x18800A660")]
	[UnityEngine.Scripting.Preserve]
	public BKEOJPJNKFL([NGLIAOPBMFM(null)] CGAFGMGAKPP FENMLPHGKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "8")]
	public void FAMNGHPLDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8009EE0", Offset = "0x80090E0", VA = "0x188009EE0", Slot = "6")]
	public Task AKEIHGODOAD(long FKBNINAMDMM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1C03210", Offset = "0x1C02410", VA = "0x181C03210")]
	private static int JFLJBHIONIH(bool KJIOHKMJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x800A610", Offset = "0x8009810", VA = "0x18800A610", Slot = "9")]
	public bool PGBEIBOONKI(string KGBLLKPNCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8009F70", Offset = "0x8009170", VA = "0x188009F70", Slot = "10")]
	public int AKGHOIPMPDH(string KGBLLKPNCLE, int FEOJADDJKIL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x800A380", Offset = "0x8009580", VA = "0x18800A380", Slot = "11")]
	public void LCIGDLEDDBM(string KGBLLKPNCLE, int KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8009FA0", Offset = "0x80091A0", VA = "0x188009FA0", Slot = "12")]
	public bool BDLKADGHCCB(string KGBLLKPNCLE, bool FEOJADDJKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x800A5E0", Offset = "0x80097E0", VA = "0x18800A5E0", Slot = "13")]
	public void PBCLLIDPAMG(string KGBLLKPNCLE, bool KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x800A0A0", Offset = "0x80092A0", VA = "0x18800A0A0", Slot = "14")]
	public float DILGGDLCEJF(string KGBLLKPNCLE, float FEOJADDJKIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x800A2B0", Offset = "0x80094B0", VA = "0x18800A2B0", Slot = "15")]
	public void ILJKPBBMAJE(string KGBLLKPNCLE, float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x800A1D0", Offset = "0x80093D0", VA = "0x18800A1D0", Slot = "18")]
	public DateTime HCCDMLIPMGC(string KGBLLKPNCLE, [Optional] DateTime FEOJADDJKIL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x800A160", Offset = "0x8009360", VA = "0x18800A160", Slot = "19")]
	public void GLBHGOGADAD(string KGBLLKPNCLE, DateTime IDJMBMEIHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x800A4F0", Offset = "0x80096F0", VA = "0x18800A4F0", Slot = "20")]
	public long OCPCKMDPLJA(string KGBLLKPNCLE, long FEOJADDJKIL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x800A240", Offset = "0x8009440", VA = "0x18800A240", Slot = "21")]
	public void HECDCBLKECE(string KGBLLKPNCLE, long KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x378E7D0", Offset = "0x378D9D0", VA = "0x18378E7D0", Slot = "22")]
	public T FOCLLMMKMOP<T>(string KGBLLKPNCLE, T FEOJADDJKIL, OIKEJCNDEBN<T> PNAKPJNABJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x378F3C0", Offset = "0x378E5C0", VA = "0x18378F3C0", Slot = "23")]
	public void MHFGOGNAKPO<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, OIKEJCNDEBN<T> PNAKPJNABJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x378E990", Offset = "0x378DB90", VA = "0x18378E990")]
	private T MGPNMCALEGA<T>(string KGBLLKPNCLE, T FEOJADDJKIL, [Optional] OIKEJCNDEBN<T> IDEKOJMAAKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x378F4F0", Offset = "0x378E6F0", VA = "0x18378F4F0")]
	private void ODHNGPGLDAG<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, [Optional] OIKEJCNDEBN<T> IDEKOJMAAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x800A630", Offset = "0x8009830", VA = "0x18800A630", Slot = "16")]
	public string POIECIFKOOP(string KGBLLKPNCLE, string FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x800A3B0", Offset = "0x80095B0", VA = "0x18800A3B0", Slot = "17")]
	public void MDHJBJCPAHC(string KGBLLKPNCLE, string KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x800A4D0", Offset = "0x80096D0", VA = "0x18800A4D0")]
	private void NGKLHMMFDGM(string KGBLLKPNCLE, string KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x800A0D0", Offset = "0x80092D0", VA = "0x18800A0D0")]
	private string DPDPPKCIIKC(string KGBLLKPNCLE, string FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8009E50", Offset = "0x8009050", VA = "0x188009E50", Slot = "24")]
	public void AFMKOODKDNO(string KGBLLKPNCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x800A2E0", Offset = "0x80094E0", VA = "0x18800A2E0")]
	private string KMHIEPDPAHI(string MHDODBCCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x800A3E0", Offset = "0x80095E0", VA = "0x18800A3E0", Slot = "25")]
	[AsyncStateMachine(typeof(BDJLPONJAOM))]
	public Task MMAMKHAELBB(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x800A560", Offset = "0x8009760", VA = "0x18800A560")]
	[IteratorStateMachine(typeof(OFNPGADNIPG))]
	private IEnumerator<NOFGPJFCPHG> OIOMFAAJCCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x800A040", Offset = "0x8009240", VA = "0x18800A040")]
	private void BOLDLCCNOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x800A0F0", Offset = "0x80092F0", VA = "0x18800A0F0")]
	private void FPJJPDNOCHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8009FD0", Offset = "0x80091D0", VA = "0x188009FD0")]
	private void BLOFPKDEMEF(bool IHBGGNHAHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FDJFHMEJDAK : MHKEPNKOKKD, HPOPFPOPKJN
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
	private Dictionary<string, string> HJLPLMGDMBK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string CIFEHIAGFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x800DFD0", Offset = "0x800D1D0", VA = "0x18800DFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> AOPCOMLCMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x800E200", Offset = "0x800D400", VA = "0x18800E200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action HMFCMPCMFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	[UnityEngine.Scripting.Preserve]
	public FDJFHMEJDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "8")]
	public void FAMNGHPLDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x800DDA0", Offset = "0x800CFA0", VA = "0x18800DDA0", Slot = "6")]
	public Task AKEIHGODOAD(long FKBNINAMDMM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x800DF60", Offset = "0x800D160", VA = "0x18800DF60", Slot = "14")]
	public float DILGGDLCEJF(string MHDODBCCAJB, float FEOJADDJKIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x800E900", Offset = "0x800DB00", VA = "0x18800E900", Slot = "13")]
	public void PBCLLIDPAMG(string MHDODBCCAJB, bool KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x800DEA0", Offset = "0x800D0A0", VA = "0x18800DEA0", Slot = "12")]
	public bool BDLKADGHCCB(string MHDODBCCAJB, bool FEOJADDJKIL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x800DE30", Offset = "0x800D030", VA = "0x18800DE30", Slot = "10")]
	public int AKGHOIPMPDH(string MHDODBCCAJB, int FEOJADDJKIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x800E0B0", Offset = "0x800D2B0", VA = "0x18800E0B0", Slot = "18")]
	public DateTime HCCDMLIPMGC(string KGBLLKPNCLE, [Optional] DateTime FEOJADDJKIL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x800E040", Offset = "0x800D240", VA = "0x18800E040", Slot = "19")]
	public void GLBHGOGADAD(string MHDODBCCAJB, DateTime KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x800E190", Offset = "0x800D390", VA = "0x18800E190", Slot = "15")]
	public void ILJKPBBMAJE(string MHDODBCCAJB, float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x800E240", Offset = "0x800D440", VA = "0x18800E240", Slot = "11")]
	public void LCIGDLEDDBM(string MHDODBCCAJB, int KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x800E890", Offset = "0x800DA90", VA = "0x18800E890", Slot = "20")]
	public long OCPCKMDPLJA(string KGBLLKPNCLE, long FEOJADDJKIL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x800E120", Offset = "0x800D320", VA = "0x18800E120", Slot = "21")]
	public void HECDCBLKECE(string KGBLLKPNCLE, long KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x39E8920", Offset = "0x39E7B20", VA = "0x1839E8920", Slot = "22")]
	public T FOCLLMMKMOP<T>(string KGBLLKPNCLE, T FEOJADDJKIL, OIKEJCNDEBN<T> PNAKPJNABJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x39E8A30", Offset = "0x39E7C30", VA = "0x1839E8A30", Slot = "23")]
	public void MHFGOGNAKPO<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, OIKEJCNDEBN<T> PNAKPJNABJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x800EA00", Offset = "0x800DC00", VA = "0x18800EA00", Slot = "16")]
	public string POIECIFKOOP(string MHDODBCCAJB, string FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x800E2B0", Offset = "0x800D4B0", VA = "0x18800E2B0", Slot = "17")]
	public void MDHJBJCPAHC(string MHDODBCCAJB, string KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x800DCE0", Offset = "0x800CEE0", VA = "0x18800DCE0", Slot = "24")]
	public void AFMKOODKDNO(string MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x800E970", Offset = "0x800DB70", VA = "0x18800E970", Slot = "9")]
	public bool PGBEIBOONKI(string MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x800E630", Offset = "0x800D830", VA = "0x18800E630", Slot = "25")]
	public Task MMAMKHAELBB(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x39E68C0", Offset = "0x39E5AC0", VA = "0x1839E68C0")]
	private T AFHCIICHJIO<T>(string KGBLLKPNCLE, T FEOJADDJKIL, [Optional] OIKEJCNDEBN<T> IDEKOJMAAKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x39E79E0", Offset = "0x39E6BE0", VA = "0x1839E79E0")]
	private void DEEMOOGCBGF<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, [Optional] OIKEJCNDEBN<T> IDEKOJMAAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x800E350", Offset = "0x800D550", VA = "0x18800E350")]
	private Dictionary<string, string> MHDBODMMMOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PGCLBGKNLGG
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action HMFCMPCMFNI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FAMNGHPLDLA();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ONIEFCHKIFL(long FKBNINAMDMM);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JJGIEAMIAEB(ALAAJDPECKP EEEMINCEPGK = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GGMNCHAKOLJ(string KGBLLKPNCLE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PNMEHAGMAIG(string KGBLLKPNCLE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string MAKKDDBEJCJ(string KGBLLKPNCLE, [Optional] string FEOJADDJKIL, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CMCLIKEIBCN NDBJHKALBIE(string KGBLLKPNCLE, string KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int DMAEAFDNELF(string KGBLLKPNCLE, int FEOJADDJKIL = 0, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CMCLIKEIBCN KFOMMBPAAGM(string KGBLLKPNCLE, int KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DGODNIHJLCK(string KGBLLKPNCLE, bool FEOJADDJKIL, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CMCLIKEIBCN KBPAGBDOMNF(string KGBLLKPNCLE, bool KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float GHAIAOCOOOG(string KGBLLKPNCLE, float FEOJADDJKIL = 0f, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CMCLIKEIBCN PHDBLFJMGKD(string KGBLLKPNCLE, float KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime EADGOBHMFJO(string KGBLLKPNCLE, [Optional] DateTime FEOJADDJKIL, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CMCLIKEIBCN ONFJKPLFANK(string KGBLLKPNCLE, DateTime KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long JKLNAADBBNL(string KGBLLKPNCLE, long FEOJADDJKIL = 0L, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CMCLIKEIBCN KEJBKLHDIEM(string KGBLLKPNCLE, long KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T IGANAFIDFJO<T>(string KGBLLKPNCLE, [Optional] T FEOJADDJKIL, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	CMCLIKEIBCN KHOONPJHECE<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool LANPEIEEFFO(string KGBLLKPNCLE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool CBMEOFCJBEK(string KGBLLKPNCLE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string FFHHFGHDIBL(string KGBLLKPNCLE, [Optional] string FEOJADDJKIL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CMCLIKEIBCN DOIINEIGDIP(string KGBLLKPNCLE, string KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int FGCMMMJOFLH(string KGBLLKPNCLE, int FEOJADDJKIL = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CMCLIKEIBCN NIGOCEKJEMF(string KGBLLKPNCLE, int KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DNGBBHKCPDN(string KGBLLKPNCLE, bool FEOJADDJKIL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CMCLIKEIBCN JECFACPFFIL(string KGBLLKPNCLE, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float FGNNKGDGJIB(string KGBLLKPNCLE, float FEOJADDJKIL = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	CMCLIKEIBCN PGBJPGKMEON(string KGBLLKPNCLE, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime LCBMCBDMFKB(string KGBLLKPNCLE, [Optional] DateTime FEOJADDJKIL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	CMCLIKEIBCN CDHKHNBJIMP(string KGBLLKPNCLE, DateTime KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long ANIEPJJDNCP(string KGBLLKPNCLE, long FEOJADDJKIL = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	CMCLIKEIBCN HAKMPKGCBNJ(string KGBLLKPNCLE, long KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BGOACLJGEOE<T>(OIKEJCNDEBN<T> PNAKPJNABJF, [Optional] IEqualityComparer<T> PFCONGNHPEJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CEHCJGAGJJK<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable FPHPMLLPFGP();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PBOGBMFGPBP(float GKFLGCPHKEK);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task BOLDLCCNOOG([Optional] CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum CMCLIKEIBCN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EIPCOOBAHPD : PGCLBGKNLGG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class FOLAEJDGFIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<FOLAEJDGFIH> MAAHDIIGPBA;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x800ECA0", Offset = "0x800DEA0", VA = "0x18800ECA0")]
		public static void IKKCGPKCPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OLKFAGPLGGN();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		protected FOLAEJDGFIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class KNLMGJKBIGM<T> : FOLAEJDGFIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly KNLMGJKBIGM<T> AIBLJDBPKAO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OIKEJCNDEBN<T> FDDGLELFPMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> BEEGMJDBIPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DPKEOELHDCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4656DC0", Offset = "0x4655FC0", VA = "0x184656DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5167250", Offset = "0x5166450", VA = "0x185167250")]
		private KNLMGJKBIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5166F80", Offset = "0x5166180", VA = "0x185166F80")]
		public void ELDCOJNOKAJ(OIKEJCNDEBN<T> IDEKOJMAAKB, [Optional] IEqualityComparer<T> PFCONGNHPEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x51670E0", Offset = "0x51662E0", VA = "0x1851670E0", Slot = "4")]
		public override void OLKFAGPLGGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class GAPCEDNEDME : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly EIPCOOBAHPD NMANBIPPALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object EPINGCIOGII;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x800EEA0", Offset = "0x800E0A0", VA = "0x18800EEA0")]
		public GAPCEDNEDME(EIPCOOBAHPD NMANBIPPALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x800EE70", Offset = "0x800E070", VA = "0x18800EE70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct EADIGGHOCIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public EIPCOOBAHPD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x800A750", Offset = "0x8009950", VA = "0x18800A750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x800AA40", Offset = "0x8009C40", VA = "0x18800AA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct HOMOIMOBFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public EIPCOOBAHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HPOPFPOPKJN backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x800F480", Offset = "0x800E680", VA = "0x18800F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct GHCGDPBHEKG : IAsyncStateMachine
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
		public EIPCOOBAHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x800EF50", Offset = "0x800E150", VA = "0x18800EF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x800F420", Offset = "0x800E620", VA = "0x18800F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AJHOCMHOBMG : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EIPCOOBAHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public AJHOCMHOBMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8009930", Offset = "0x8008B30", VA = "0x188009930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x80099C0", Offset = "0x8008BC0", VA = "0x1880099C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly MHKEPNKOKKD CHHLCFGMBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly MHKEPNKOKKD DICFOBHFBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly JFHCEAOILPI HDMOBILHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly POGLNMFMHLK NIBFMCDFOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly IIJKLMMBNKE.LCFCELIHEKL PBHNHCIFFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly PPOFIDCPAOP KCHAEFNLPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<HPOPFPOPKJN> KLAKNMJEBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task NBALBLLNHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> JPBGBGCPPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private AFABIGEDGFJ MBJDOOEDINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object HAKMIAAFLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object DMIDLHPJHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long BFEHLJOAFGA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool KPBKHNHPNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x800AC70", Offset = "0x8009E70", VA = "0x18800AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource FHFJGOJFDJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA003E0", Offset = "0x9FF5E0", VA = "0x180A003E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action HMFCMPCMFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x800BC30", Offset = "0x800AE30", VA = "0x18800BC30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x800D1B0", Offset = "0x800C3B0", VA = "0x18800D1B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x800B200", Offset = "0x800A400", VA = "0x18800B200")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x800D910", Offset = "0x800CB10", VA = "0x18800D910")]
	[UnityEngine.Scripting.Preserve]
	public EIPCOOBAHPD([NGLIAOPBMFM("Disk")] MHKEPNKOKKD CHHLCFGMBIF, [NGLIAOPBMFM("Cloud")] MHKEPNKOKKD DICFOBHFBDA, [NGLIAOPBMFM(null)] JFHCEAOILPI HDMOBILHHHJ, [NGLIAOPBMFM(null)] POGLNMFMHLK NIBFMCDFOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x800B0F0", Offset = "0x800A2F0", VA = "0x18800B0F0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x800AF50", Offset = "0x800A150", VA = "0x18800AF50")]
	private void DHPJHABFJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x800B270", Offset = "0x800A470", VA = "0x18800B270", Slot = "6")]
	public void FAMNGHPLDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x800D400", Offset = "0x800C600", VA = "0x18800D400", Slot = "7")]
	public Task ONIEFCHKIFL(long FKBNINAMDMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x800B870", Offset = "0x800AA70", VA = "0x18800B870")]
	[AsyncStateMachine(typeof(EADIGGHOCIP))]
	private Task IDCCFKAEHJL(long FKBNINAMDMM, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x800B980", Offset = "0x800AB80", VA = "0x18800B980")]
	private void IIMMICMHBBN(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x800AE20", Offset = "0x800A020", VA = "0x18800AE20")]
	private void CGJIFAFCNKF(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x800C4B0", Offset = "0x800B6B0", VA = "0x18800C4B0")]
	private string KICFPGAOOJP(string KNBMBDILLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x800CED0", Offset = "0x800C0D0", VA = "0x18800CED0")]
	private void OBPAIIILIPJ(ALAAJDPECKP EEEMINCEPGK, string MHDODBCCAJB, [Out] MHKEPNKOKKD KPLDOPEGNHI, [Out] string BLDBLCNCGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x800BD00", Offset = "0x800AF00", VA = "0x18800BD00")]
	private MHKEPNKOKKD JIBNNBKPFOA(ALAAJDPECKP EEEMINCEPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x800BD80", Offset = "0x800AF80", VA = "0x18800BD80", Slot = "8")]
	public bool JJGIEAMIAEB(ALAAJDPECKP EEEMINCEPGK = ALAAJDPECKP.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x800B6F0", Offset = "0x800A8F0", VA = "0x18800B6F0", Slot = "9")]
	public bool GGMNCHAKOLJ(string KGBLLKPNCLE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x800D790", Offset = "0x800C990", VA = "0x18800D790", Slot = "10")]
	public bool PNMEHAGMAIG(string KGBLLKPNCLE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x800C860", Offset = "0x800BA60", VA = "0x18800C860", Slot = "11")]
	public string MAKKDDBEJCJ(string KGBLLKPNCLE, [Optional] string FEOJADDJKIL, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x800C9D0", Offset = "0x800BBD0", VA = "0x18800C9D0", Slot = "12")]
	public CMCLIKEIBCN NDBJHKALBIE(string KGBLLKPNCLE, string KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x800AFA0", Offset = "0x800A1A0", VA = "0x18800AFA0", Slot = "13")]
	public int DMAEAFDNELF(string KGBLLKPNCLE, int FEOJADDJKIL = 0, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x800C330", Offset = "0x800B530", VA = "0x18800C330", Slot = "14")]
	public CMCLIKEIBCN KFOMMBPAAGM(string KGBLLKPNCLE, int KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x800AEA0", Offset = "0x800A0A0", VA = "0x18800AEA0", Slot = "15")]
	public bool DGODNIHJLCK(string KGBLLKPNCLE, bool FEOJADDJKIL, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x800BEE0", Offset = "0x800B0E0", VA = "0x18800BEE0", Slot = "16")]
	public CMCLIKEIBCN KBPAGBDOMNF(string KGBLLKPNCLE, bool KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x800B790", Offset = "0x800A990", VA = "0x18800B790", Slot = "17")]
	public float GHAIAOCOOOG(string KGBLLKPNCLE, float FEOJADDJKIL = 0f, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x800D610", Offset = "0x800C810", VA = "0x18800D610", Slot = "18")]
	public CMCLIKEIBCN PHDBLFJMGKD(string KGBLLKPNCLE, float KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x800B130", Offset = "0x800A330", VA = "0x18800B130", Slot = "19")]
	public DateTime EADGOBHMFJO(string KGBLLKPNCLE, [Optional] DateTime FEOJADDJKIL, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x800D250", Offset = "0x800C450", VA = "0x18800D250", Slot = "20")]
	public CMCLIKEIBCN ONFJKPLFANK(string KGBLLKPNCLE, DateTime KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x800BE40", Offset = "0x800B040", VA = "0x18800BE40", Slot = "21")]
	public long JKLNAADBBNL(string KGBLLKPNCLE, long FEOJADDJKIL = 0L, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x800C060", Offset = "0x800B260", VA = "0x18800C060", Slot = "22")]
	public CMCLIKEIBCN KEJBKLHDIEM(string KGBLLKPNCLE, long KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x388EA20", Offset = "0x388DC20", VA = "0x18388EA20", Slot = "23")]
	public T IGANAFIDFJO<T>(string KGBLLKPNCLE, [Optional] T FEOJADDJKIL, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x388EA20", Offset = "0x388DC20", VA = "0x18388EA20", Slot = "24")]
	public CMCLIKEIBCN KHOONPJHECE<T>(string KGBLLKPNCLE, T KJIOHKMJAPE, ALAAJDPECKP OKAOLLONCPI = ALAAJDPECKP.CLOUD)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x800C510", Offset = "0x800B710", VA = "0x18800C510", Slot = "25")]
	public bool LANPEIEEFFO(string KGBLLKPNCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x800ADE0", Offset = "0x8009FE0", VA = "0x18800ADE0", Slot = "26")]
	public bool CBMEOFCJBEK(string KGBLLKPNCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x800B2E0", Offset = "0x800A4E0", VA = "0x18800B2E0", Slot = "27")]
	public string FFHHFGHDIBL(string KGBLLKPNCLE, [Optional] string FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x800B0C0", Offset = "0x800A2C0", VA = "0x18800B0C0", Slot = "28")]
	public CMCLIKEIBCN DOIINEIGDIP(string KGBLLKPNCLE, string KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x800B350", Offset = "0x800A550", VA = "0x18800B350", Slot = "29")]
	public int FGCMMMJOFLH(string KGBLLKPNCLE, int FEOJADDJKIL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x800CEA0", Offset = "0x800C0A0", VA = "0x18800CEA0", Slot = "30")]
	public CMCLIKEIBCN NIGOCEKJEMF(string KGBLLKPNCLE, int KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x800B050", Offset = "0x800A250", VA = "0x18800B050", Slot = "31")]
	public bool DNGBBHKCPDN(string KGBLLKPNCLE, bool FEOJADDJKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x800BCD0", Offset = "0x800AED0", VA = "0x18800BCD0", Slot = "32")]
	public CMCLIKEIBCN JECFACPFFIL(string KGBLLKPNCLE, bool KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x800B3C0", Offset = "0x800A5C0", VA = "0x18800B3C0", Slot = "33")]
	public float FGNNKGDGJIB(string KGBLLKPNCLE, float FEOJADDJKIL = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x800D5E0", Offset = "0x800C7E0", VA = "0x18800D5E0", Slot = "34")]
	public CMCLIKEIBCN PGBJPGKMEON(string KGBLLKPNCLE, float KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x800C570", Offset = "0x800B770", VA = "0x18800C570", Slot = "35")]
	public DateTime LCBMCBDMFKB(string KGBLLKPNCLE, [Optional] DateTime FEOJADDJKIL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x800ADF0", Offset = "0x8009FF0", VA = "0x18800ADF0", Slot = "36")]
	public CMCLIKEIBCN CDHKHNBJIMP(string KGBLLKPNCLE, DateTime KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x800AC00", Offset = "0x8009E00", VA = "0x18800AC00", Slot = "37")]
	public long ANIEPJJDNCP(string KGBLLKPNCLE, long FEOJADDJKIL = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x800B840", Offset = "0x800AA40", VA = "0x18800B840", Slot = "38")]
	public CMCLIKEIBCN HAKMPKGCBNJ(string KGBLLKPNCLE, long KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x800AC90", Offset = "0x8009E90", VA = "0x18800AC90")]
	private bool BGJGFHPMDDD(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x800AAA0", Offset = "0x8009CA0", VA = "0x18800AAA0")]
	private bool AIOOIPJICGE(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x800BAE0", Offset = "0x800ACE0", VA = "0x18800BAE0")]
	private CMCLIKEIBCN IOABNMNIFPE(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, string KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x800CCD0", Offset = "0x800BED0", VA = "0x18800CCD0")]
	private CMCLIKEIBCN NDJPFIFPDDE(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, int KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x800D070", Offset = "0x800C270", VA = "0x18800D070")]
	private CMCLIKEIBCN ODMEGHIOCEM(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, bool KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x800C1E0", Offset = "0x800B3E0", VA = "0x18800C1E0")]
	private CMCLIKEIBCN KFMBEFKDCII(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, float KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x800CB60", Offset = "0x800BD60", VA = "0x18800CB60")]
	private CMCLIKEIBCN NDHDBEJIKAM(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, DateTime KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x800B9A0", Offset = "0x800ABA0", VA = "0x18800B9A0")]
	private CMCLIKEIBCN IJIBGPCAIDN(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, long KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x388E380", Offset = "0x388D580", VA = "0x18388E380")]
	private T DAECCNBHMOF<T>(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, T FEOJADDJKIL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x388EC20", Offset = "0x388DE20", VA = "0x18388EC20")]
	private CMCLIKEIBCN JLGEJFGBOMO<T>(HPOPFPOPKJN KPLDOPEGNHI, string KGBLLKPNCLE, T KJIOHKMJAPE)
	{
		return default(CMCLIKEIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x388E270", Offset = "0x388D470", VA = "0x18388E270", Slot = "39")]
	public void BGOACLJGEOE<T>(OIKEJCNDEBN<T> PNAKPJNABJF, [Optional] IEqualityComparer<T> PFCONGNHPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x388E300", Offset = "0x388D500", VA = "0x18388E300", Slot = "40")]
	public void CEHCJGAGJJK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x800C900", Offset = "0x800BB00", VA = "0x18800C900")]
	[AsyncStateMachine(typeof(HOMOIMOBFHJ))]
	private void MMAMKHAELBB(HPOPFPOPKJN ENJEENEHKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x800ACF0", Offset = "0x8009EF0", VA = "0x18800ACF0", Slot = "43")]
	[AsyncStateMachine(typeof(GHCGDPBHEKG))]
	public Task BOLDLCCNOOG([Optional] CancellationToken CCLFNPCGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x800B510", Offset = "0x800A710", VA = "0x18800B510")]
	private void GENDLINEGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x800B430", Offset = "0x800A630", VA = "0x18800B430", Slot = "41")]
	public IDisposable FPHPMLLPFGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x800D5D0", Offset = "0x800C7D0", VA = "0x18800D5D0", Slot = "42")]
	public void PBOGBMFGPBP(float GKFLGCPHKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x800C5E0", Offset = "0x800B7E0", VA = "0x18800C5E0")]
	private void LNALOFPLJDP(float CALHMNKNKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x800CE10", Offset = "0x800C010", VA = "0x18800CE10")]
	[IteratorStateMachine(typeof(AJHOCMHOBMG))]
	private IEnumerator<NOFGPJFCPHG> NFGLHNBFBJI(float GKFLGCPHKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x800B1D0", Offset = "0x800A3D0", VA = "0x18800B1D0")]
	[CompilerGenerated]
	private void ECGAJPAHCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KGMHAGOMEMC : AHJMEINBFAL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static KGMHAGOMEMC AIBLJDBPKAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8011BB0", Offset = "0x8010DB0", VA = "0x188011BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8011C00", Offset = "0x8010E00", VA = "0x188011C00", Slot = "9")]
	public override string ELKKKBEIKKA(bool GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8011CF0", Offset = "0x8010EF0", VA = "0x188011CF0", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] bool KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8012000", Offset = "0x8011200", VA = "0x188012000")]
	public KGMHAGOMEMC()
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
