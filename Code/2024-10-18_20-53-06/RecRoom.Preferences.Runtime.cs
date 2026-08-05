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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7099660", Offset = "0x7098A60", VA = "0x187099660", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GDHJPLDICOK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class ONNJOAKIJGH
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void PIBOODLENKF(MCNHIDDPBLM OOEMGMJAKAK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7098EA0", Offset = "0x70982A0", VA = "0x187098EA0")]
	private static void PAAHIALMAND(MCNHIDDPBLM OOEMGMJAKAK, PIBOODLENKF EINCNMOHPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7098750", Offset = "0x7097B50", VA = "0x187098750")]
	public static bool GLOMOHPNCFD(this MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, [Optional] PIBOODLENKF EINCNMOHPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7098D50", Offset = "0x7098150", VA = "0x187098D50")]
	public static FHMKJMLPABK OEOGGLEMPCG(this MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, string EEPLCHCGAIN, [Optional] PIBOODLENKF EINCNMOHPOO)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7098AD0", Offset = "0x7097ED0", VA = "0x187098AD0")]
	public static FHMKJMLPABK LKGAELBOEPH(this MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, int EEPLCHCGAIN, [Optional] PIBOODLENKF EINCNMOHPOO)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7098C10", Offset = "0x7098010", VA = "0x187098C10")]
	public static FHMKJMLPABK NJHOKCCBOCN(this MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, bool EEPLCHCGAIN, [Optional] PIBOODLENKF EINCNMOHPOO)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7098980", Offset = "0x7097D80", VA = "0x187098980")]
	public static FHMKJMLPABK ILJLDGGILHK(this MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, float EEPLCHCGAIN, [Optional] PIBOODLENKF EINCNMOHPOO)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70985E0", Offset = "0x70979E0", VA = "0x1870985E0")]
	public static FHMKJMLPABK FNKLECBMOID(this MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, DateTime EEPLCHCGAIN, [Optional] PIBOODLENKF EINCNMOHPOO)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7098840", Offset = "0x7097C40", VA = "0x187098840")]
	public static FHMKJMLPABK HGINLHOBCIH(this MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, long EEPLCHCGAIN, [Optional] PIBOODLENKF EINCNMOHPOO)
	{
		return default(FHMKJMLPABK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KCNFAOGMBBN : CPNJPENCOPB, MCNHIDDPBLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OOCOJOEJALH DCOEKHKHPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> BLCGOOCHJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> AJHFGFILNCO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> PBFOICAHMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7097AF0", Offset = "0x7096EF0", VA = "0x187097AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action IDJHKEBHGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7097B30", Offset = "0x7096F30", VA = "0x187097B30")]
	[UnityEngine.Scripting.Preserve]
	public KCNFAOGMBBN([CCLHMIDBCEM(null)] OOCOJOEJALH DCOEKHKHPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "8")]
	public void MHKJKIIDKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70978F0", Offset = "0x7096CF0", VA = "0x1870978F0")]
	private DirectoryInfo NEGMKJABHHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7096290", Offset = "0x7095690", VA = "0x187096290", Slot = "6")]
	public Task EKGDNOJFOEJ(long JDDGCPNEBBE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7096220", Offset = "0x7095620", VA = "0x187096220", Slot = "14")]
	public float EHMDBDCPHAN(string OEOMDKHBDFI, float BMLEAJPEFAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7097810", Offset = "0x7096C10", VA = "0x187097810", Slot = "13")]
	public void MKDLADHPDJC(string OEOMDKHBDFI, bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7097210", Offset = "0x7096610", VA = "0x187097210", Slot = "12")]
	public bool IGKEAHOPEFA(string OEOMDKHBDFI, bool BMLEAJPEFAD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7097A80", Offset = "0x7096E80", VA = "0x187097A80", Slot = "10")]
	public int OCMGAPNIPHI(string OEOMDKHBDFI, int BMLEAJPEFAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7097880", Offset = "0x7096C80", VA = "0x187097880", Slot = "18")]
	public DateTime NEDLCJHPPLK(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x70972D0", Offset = "0x70966D0", VA = "0x1870972D0", Slot = "19")]
	public void IJMIMEPCMHK(string OEOMDKHBDFI, DateTime EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x70961B0", Offset = "0x70955B0", VA = "0x1870961B0", Slot = "15")]
	public void DPGABHLPJFG(string OEOMDKHBDFI, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7097340", Offset = "0x7096740", VA = "0x187097340", Slot = "11")]
	public void IPCGEKKMJLD(string OEOMDKHBDFI, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7096E10", Offset = "0x7096210", VA = "0x187096E10", Slot = "20")]
	public long HHBCOACCAGI(string BMAAJNANOMC, long BMLEAJPEFAD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7096CF0", Offset = "0x70960F0", VA = "0x187096CF0", Slot = "21")]
	public void FNHFLAAECHC(string BMAAJNANOMC, long EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA9C0", Offset = "0x2BE9DC0", VA = "0x182BEA9C0", Slot = "22")]
	public T CGBHAINEFAE<T>(string BMAAJNANOMC, T BMLEAJPEFAD, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA9C0", Offset = "0x2BE9DC0", VA = "0x182BEA9C0", Slot = "23")]
	public void GNOJGKLEFKM<T>(string BMAAJNANOMC, T EEPLCHCGAIN, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7096D60", Offset = "0x7096160", VA = "0x187096D60", Slot = "16")]
	public string GEJGPAHCLKD(string OEOMDKHBDFI, string BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x70977A0", Offset = "0x7096BA0", VA = "0x1870977A0", Slot = "17")]
	public void LKBMFGOIANK(string OEOMDKHBDFI, string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x70976E0", Offset = "0x7096AE0", VA = "0x1870976E0", Slot = "24")]
	public void KPINMJFLFMJ(string OEOMDKHBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x70979F0", Offset = "0x7096DF0", VA = "0x1870979F0", Slot = "9")]
	public bool NLNGJLAEKFL(string OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x70973B0", Offset = "0x70967B0", VA = "0x1870973B0", Slot = "25")]
	public Task JMOCJIBLKBA(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7096E80", Offset = "0x7096280", VA = "0x187096E80")]
	private void HNMJDDKMKMH(DirectoryInfo OPHNEKHOJFM, string HJKAMHOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7096320", Offset = "0x7095720", VA = "0x187096320")]
	private static string FFFHODFIBCI(string OEOMDKHBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x70960B0", Offset = "0x70954B0", VA = "0x1870960B0")]
	private static string CCODAHIECDL(byte[] FAHBHOHHIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2650", Offset = "0x2EE1A50", VA = "0x182EE2650")]
	private T CADKKGPFCDD<T>(string BMAAJNANOMC, T BMLEAJPEFAD, [Optional] DEFAGFOFBDJ<T> APABPEFHAHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3940", Offset = "0x2EE2D40", VA = "0x182EE3940")]
	private void MCAKFOHFDBM<T>(string BMAAJNANOMC, T EEPLCHCGAIN, [Optional] DEFAGFOFBDJ<T> APABPEFHAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7096520", Offset = "0x7095920", VA = "0x187096520")]
	private Dictionary<string, string> FGHPHBMPNJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class JDIJFAPILDM
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7095F60", Offset = "0x7095360", VA = "0x187095F60")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void MHNICLDHNFP(LBNNADLFMIK FKEBHAJCLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CIOHOAGLPPC : PKKLPPHNBKF
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7090770", Offset = "0x708FB70", VA = "0x187090770")]
	[UnityEngine.Scripting.Preserve]
	public CIOHOAGLPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PKKLPPHNBKF : CPNJPENCOPB, MCNHIDDPBLM, EJBHAFPDKLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> KIMOFNLBNCG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IDJHKEBHGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "8")]
	public void MHKJKIIDKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7098FE0", Offset = "0x70983E0", VA = "0x187098FE0", Slot = "6")]
	public Task EKGDNOJFOEJ(long JDDGCPNEBBE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70994C0", Offset = "0x70988C0", VA = "0x1870994C0", Slot = "9")]
	public bool NLNGJLAEKFL(string BMAAJNANOMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7099520", Offset = "0x7098920", VA = "0x187099520", Slot = "10")]
	public int OCMGAPNIPHI(string BMAAJNANOMC, int BMLEAJPEFAD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7099250", Offset = "0x7098650", VA = "0x187099250", Slot = "11")]
	public void IPCGEKKMJLD(string BMAAJNANOMC, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7099190", Offset = "0x7098590", VA = "0x187099190", Slot = "12")]
	public bool IGKEAHOPEFA(string BMAAJNANOMC, bool BMLEAJPEFAD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7099400", Offset = "0x7098800", VA = "0x187099400", Slot = "13")]
	public void MKDLADHPDJC(string BMAAJNANOMC, bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7098F80", Offset = "0x7098380", VA = "0x187098F80", Slot = "14")]
	public float EHMDBDCPHAN(string BMAAJNANOMC, float BMLEAJPEFAD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7098F20", Offset = "0x7098320", VA = "0x187098F20", Slot = "15")]
	public void DPGABHLPJFG(string BMAAJNANOMC, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x70990D0", Offset = "0x70984D0", VA = "0x1870990D0", Slot = "16")]
	public string GEJGPAHCLKD(string BMAAJNANOMC, [Optional] string BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x70993A0", Offset = "0x70987A0", VA = "0x1870993A0", Slot = "17")]
	public void LKBMFGOIANK(string BMAAJNANOMC, string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7099460", Offset = "0x7098860", VA = "0x187099460", Slot = "18")]
	public DateTime NEDLCJHPPLK(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70991F0", Offset = "0x70985F0", VA = "0x1870991F0", Slot = "19")]
	public void IJMIMEPCMHK(string BMAAJNANOMC, DateTime EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7099130", Offset = "0x7098530", VA = "0x187099130", Slot = "20")]
	public long HHBCOACCAGI(string BMAAJNANOMC, long BMLEAJPEFAD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7099070", Offset = "0x7098470", VA = "0x187099070", Slot = "21")]
	public void FNHFLAAECHC(string BMAAJNANOMC, long EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3045160", Offset = "0x3044560", VA = "0x183045160", Slot = "22")]
	public T CGBHAINEFAE<T>(string BMAAJNANOMC, T BMLEAJPEFAD, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3045280", Offset = "0x3044680", VA = "0x183045280", Slot = "23")]
	public void GNOJGKLEFKM<T>(string BMAAJNANOMC, T EEPLCHCGAIN, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x30448C0", Offset = "0x3043CC0", VA = "0x1830448C0")]
	public T CADKKGPFCDD<T>(string BMAAJNANOMC, T BMLEAJPEFAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3045360", Offset = "0x3044760", VA = "0x183045360")]
	public void MCAKFOHFDBM<T>(string BMAAJNANOMC, T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7099340", Offset = "0x7098740", VA = "0x187099340", Slot = "24")]
	public void KPINMJFLFMJ(string BMAAJNANOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70992B0", Offset = "0x70986B0", VA = "0x1870992B0", Slot = "25")]
	public Task JMOCJIBLKBA(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7090770", Offset = "0x708FB70", VA = "0x187090770")]
	public PKKLPPHNBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class EBLOEAPNHNB<TParent> where TParent : MCNHIDDPBLM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<EBLOEAPNHNB<TParent>> ABONEPIGPJP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CE60", Offset = "0x3B4C260", VA = "0x183B4CE60")]
	protected EBLOEAPNHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void KMNEPMPOIBK();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MJMBOBKACFK(string OEOMDKHBDFI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C890", Offset = "0x3B4BC90", VA = "0x183B4C890")]
	public static void GDPCHLLFAAA(string OEOMDKHBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CAE0", Offset = "0x3B4BEE0", VA = "0x183B4CAE0")]
	public static void PPNFPOGJLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MDFODKENNGA<TParent, TValue> : EBLOEAPNHNB<TParent> where TParent : MCNHIDDPBLM
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly MDFODKENNGA<TParent, TValue> BONGJJLJANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> BMKLIMEOLAK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x47B8D50", Offset = "0x47B8150", VA = "0x1847B8D50")]
	public bool LCKMIEGKAOE(string JFMMGIJOFEJ, [Out] TValue CNIECMCKMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x47B8DB0", Offset = "0x47B81B0", VA = "0x1847B8DB0")]
	public void LDPHNHOPGCF(string JFMMGIJOFEJ, TValue EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F0D0", Offset = "0x3B8E4D0", VA = "0x183B8F0D0", Slot = "4")]
	protected override void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A8C0", Offset = "0x3F39CC0", VA = "0x183F3A8C0", Slot = "5")]
	protected override void MJMBOBKACFK(string JFMMGIJOFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x47B9080", Offset = "0x47B8480", VA = "0x1847B9080")]
	public MDFODKENNGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MCNHIDDPBLM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHKJKIIDKCG();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLNGJLAEKFL(string BMAAJNANOMC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OCMGAPNIPHI(string BMAAJNANOMC, int BMLEAJPEFAD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPCGEKKMJLD(string BMAAJNANOMC, int EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IGKEAHOPEFA(string BMAAJNANOMC, bool BMLEAJPEFAD = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MKDLADHPDJC(string BMAAJNANOMC, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float EHMDBDCPHAN(string BMAAJNANOMC, float BMLEAJPEFAD = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DPGABHLPJFG(string BMAAJNANOMC, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string GEJGPAHCLKD(string BMAAJNANOMC, [Optional] string BMLEAJPEFAD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LKBMFGOIANK(string BMAAJNANOMC, string EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime NEDLCJHPPLK(string BMAAJNANOMC, [Optional] DateTime DBLOMJDMHKF);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IJMIMEPCMHK(string BMAAJNANOMC, DateTime DBLOMJDMHKF);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long HHBCOACCAGI(string BMAAJNANOMC, long BMLEAJPEFAD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FNHFLAAECHC(string BMAAJNANOMC, long EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T CGBHAINEFAE<T>(string BMAAJNANOMC, T BMLEAJPEFAD, DEFAGFOFBDJ<T> BEIMGHIDPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GNOJGKLEFKM<T>(string BMAAJNANOMC, T EEPLCHCGAIN, DEFAGFOFBDJ<T> BEIMGHIDPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KPINMJFLFMJ(string BMAAJNANOMC);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task JMOCJIBLKBA([Optional] CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CPNJPENCOPB : MCNHIDDPBLM
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IDJHKEBHGMM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task EKGDNOJFOEJ(long JDDGCPNEBBE, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EJBHAFPDKLC : MCNHIDDPBLM
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GPAFJJJAHEF : CPNJPENCOPB, MCNHIDDPBLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DNJAFLAMGBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public GPAFJJJAHEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x70911E0", Offset = "0x70905E0", VA = "0x1870911E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7091370", Offset = "0x7090770", VA = "0x187091370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OFPBENOBFFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GPAFJJJAHEF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7097D60", Offset = "0x7097160", VA = "0x187097D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7098050", Offset = "0x7097450", VA = "0x187098050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CPNJPENCOPB KOODJOKEAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly KCNFAOGMBBN KEFHHOCKBPA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7095BE0", Offset = "0x7094FE0", VA = "0x187095BE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action IDJHKEBHGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7094D20", Offset = "0x7094120", VA = "0x187094D20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7094DF0", Offset = "0x70941F0", VA = "0x187094DF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7095D90", Offset = "0x7095190", VA = "0x187095D90")]
	[UnityEngine.Scripting.Preserve]
	public GPAFJJJAHEF([CCLHMIDBCEM(null)] OOCOJOEJALH DCOEKHKHPIO, [CCLHMIDBCEM("Disk_Unity")] CPNJPENCOPB KOODJOKEAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7095920", Offset = "0x7094D20", VA = "0x187095920", Slot = "8")]
	public void MHKJKIIDKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7095B50", Offset = "0x7094F50", VA = "0x187095B50", Slot = "9")]
	public bool NLNGJLAEKFL(string BMAAJNANOMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7095C40", Offset = "0x7095040", VA = "0x187095C40", Slot = "10")]
	public int OCMGAPNIPHI(string BMAAJNANOMC, int BMLEAJPEFAD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7095640", Offset = "0x7094A40", VA = "0x187095640", Slot = "11")]
	public void IPCGEKKMJLD(string BMAAJNANOMC, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7095440", Offset = "0x7094840", VA = "0x187095440", Slot = "12")]
	public bool IGKEAHOPEFA(string BMAAJNANOMC, bool BMLEAJPEFAD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7095980", Offset = "0x7094D80", VA = "0x187095980", Slot = "13")]
	public void MKDLADHPDJC(string BMAAJNANOMC, bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7094E60", Offset = "0x7094260", VA = "0x187094E60", Slot = "14")]
	public float EHMDBDCPHAN(string BMAAJNANOMC, float BMLEAJPEFAD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7094D80", Offset = "0x7094180", VA = "0x187094D80", Slot = "15")]
	public void DPGABHLPJFG(string BMAAJNANOMC, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7095140", Offset = "0x7094540", VA = "0x187095140", Slot = "16")]
	public string GEJGPAHCLKD(string BMAAJNANOMC, [Optional] string BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70958B0", Offset = "0x7094CB0", VA = "0x1870958B0", Slot = "17")]
	public void LKBMFGOIANK(string BMAAJNANOMC, string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70959F0", Offset = "0x7094DF0", VA = "0x1870959F0", Slot = "18")]
	public DateTime NEDLCJHPPLK(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70955D0", Offset = "0x70949D0", VA = "0x1870955D0", Slot = "19")]
	public void IJMIMEPCMHK(string BMAAJNANOMC, DateTime DBLOMJDMHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x70952E0", Offset = "0x70946E0", VA = "0x1870952E0", Slot = "20")]
	public long HHBCOACCAGI(string BMAAJNANOMC, long BMLEAJPEFAD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70950D0", Offset = "0x70944D0", VA = "0x1870950D0", Slot = "21")]
	public void FNHFLAAECHC(string BMAAJNANOMC, long EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2E69A10", Offset = "0x2E68E10", VA = "0x182E69A10", Slot = "22")]
	public T CGBHAINEFAE<T>(string BMAAJNANOMC, T BMLEAJPEFAD, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A100", Offset = "0x2E69500", VA = "0x182E6A100", Slot = "23")]
	public void GNOJGKLEFKM<T>(string BMAAJNANOMC, T EEPLCHCGAIN, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x70957A0", Offset = "0x7094BA0", VA = "0x1870957A0", Slot = "24")]
	public void KPINMJFLFMJ(string BMAAJNANOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x70956B0", Offset = "0x7094AB0", VA = "0x1870956B0", Slot = "25")]
	[AsyncStateMachine(typeof(DNJAFLAMGBM))]
	public Task JMOCJIBLKBA([Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7094FC0", Offset = "0x70943C0", VA = "0x187094FC0", Slot = "6")]
	[AsyncStateMachine(typeof(OFPBENOBFFP))]
	public Task EKGDNOJFOEJ(long JDDGCPNEBBE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CJBMEOFAJHL : CPNJPENCOPB, MCNHIDDPBLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ABEMFFNGDGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CJBMEOFAJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x708F2B0", Offset = "0x708E6B0", VA = "0x18708F2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x708F690", Offset = "0x708EA90", VA = "0x18708F690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IKAGNHDBBGL : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CJBMEOFAJHL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public IKAGNHDBBGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7095EA0", Offset = "0x70952A0", VA = "0x187095EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7095F10", Offset = "0x7095310", VA = "0x187095F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OOCOJOEJALH DCOEKHKHPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool KEGGKENMBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool HKBEFAGMCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private IAKIMJPLHMP CLFOMGAKNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private NFIGMHBJPEE GNNOHLJAKJM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action IDJHKEBHGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7091010", Offset = "0x7090410", VA = "0x187091010")]
	[UnityEngine.Scripting.Preserve]
	public CJBMEOFAJHL([CCLHMIDBCEM(null)] OOCOJOEJALH DCOEKHKHPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "8")]
	public void MHKJKIIDKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7090880", Offset = "0x708FC80", VA = "0x187090880", Slot = "6")]
	public Task EKGDNOJFOEJ(long JDDGCPNEBBE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x14ED9B0", Offset = "0x14ECDB0", VA = "0x1814ED9B0")]
	private static int OLNILEEKPFG(bool EEPLCHCGAIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7090F30", Offset = "0x7090330", VA = "0x187090F30", Slot = "9")]
	public bool NLNGJLAEKFL(string BMAAJNANOMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7090FC0", Offset = "0x70903C0", VA = "0x187090FC0", Slot = "10")]
	public int OCMGAPNIPHI(string BMAAJNANOMC, int BMLEAJPEFAD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7090C10", Offset = "0x7090010", VA = "0x187090C10", Slot = "11")]
	public void IPCGEKKMJLD(string BMAAJNANOMC, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7090B00", Offset = "0x708FF00", VA = "0x187090B00", Slot = "12")]
	public bool IGKEAHOPEFA(string BMAAJNANOMC, bool BMLEAJPEFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7090DF0", Offset = "0x70901F0", VA = "0x187090DF0", Slot = "13")]
	public void MKDLADHPDJC(string BMAAJNANOMC, bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7090850", Offset = "0x708FC50", VA = "0x187090850", Slot = "14")]
	public float EHMDBDCPHAN(string BMAAJNANOMC, float BMLEAJPEFAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7090820", Offset = "0x708FC20", VA = "0x187090820", Slot = "15")]
	public void DPGABHLPJFG(string BMAAJNANOMC, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7090EC0", Offset = "0x70902C0", VA = "0x187090EC0", Slot = "18")]
	public DateTime NEDLCJHPPLK(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7090B30", Offset = "0x708FF30", VA = "0x187090B30", Slot = "19")]
	public void IJMIMEPCMHK(string BMAAJNANOMC, DateTime DBLOMJDMHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7090A90", Offset = "0x708FE90", VA = "0x187090A90", Slot = "20")]
	public long HHBCOACCAGI(string BMAAJNANOMC, long BMLEAJPEFAD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7090970", Offset = "0x708FD70", VA = "0x187090970", Slot = "21")]
	public void FNHFLAAECHC(string BMAAJNANOMC, long EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2C63600", Offset = "0x2C62A00", VA = "0x182C63600", Slot = "22")]
	public T CGBHAINEFAE<T>(string BMAAJNANOMC, T BMLEAJPEFAD, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C63600", Offset = "0x2C62A00", VA = "0x182C63600", Slot = "23")]
	public void GNOJGKLEFKM<T>(string BMAAJNANOMC, T EEPLCHCGAIN, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C637E0", Offset = "0x2C62BE0", VA = "0x182C637E0")]
	private T DPCJJLGCICM<T>(string BMAAJNANOMC, T BMLEAJPEFAD, [Optional] DEFAGFOFBDJ<T> APABPEFHAHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2C64450", Offset = "0x2C63850", VA = "0x182C64450")]
	private void IEDFAPPLPMB<T>(string BMAAJNANOMC, T EEPLCHCGAIN, [Optional] DEFAGFOFBDJ<T> APABPEFHAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7090A60", Offset = "0x708FE60", VA = "0x187090A60", Slot = "16")]
	public string GEJGPAHCLKD(string BMAAJNANOMC, string BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7090DC0", Offset = "0x70901C0", VA = "0x187090DC0", Slot = "17")]
	public void LKBMFGOIANK(string BMAAJNANOMC, string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7090800", Offset = "0x708FC00", VA = "0x187090800")]
	private void CMCGFGAEPKI(string BMAAJNANOMC, string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7090FF0", Offset = "0x70903F0", VA = "0x187090FF0")]
	private string PGPNDEEOMPE(string BMAAJNANOMC, string BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7090D30", Offset = "0x7090130", VA = "0x187090D30", Slot = "24")]
	public void KPINMJFLFMJ(string BMAAJNANOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7090E20", Offset = "0x7090220", VA = "0x187090E20")]
	private string NDIOOKFLGBM(string OEOMDKHBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7090C40", Offset = "0x7090040", VA = "0x187090C40", Slot = "25")]
	[AsyncStateMachine(typeof(ABEMFFNGDGA))]
	public Task JMOCJIBLKBA(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70909E0", Offset = "0x708FDE0", VA = "0x1870909E0")]
	[IteratorStateMachine(typeof(IKAGNHDBBGL))]
	private IEnumerator<DNOIEDKBBPN> GAPJOKEGDBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7090910", Offset = "0x708FD10", VA = "0x187090910")]
	private void FAAAEHMLPMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7090BA0", Offset = "0x708FFA0", VA = "0x187090BA0")]
	private void IMDNPLMEOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7090F50", Offset = "0x7090350", VA = "0x187090F50")]
	private void NNHLIAIFAEJ(bool OGJKKDKFOCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BFNBNOPCKOF : CPNJPENCOPB, MCNHIDDPBLM
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
	private Dictionary<string, string> AJHFGFILNCO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string PABJGFGIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x708FF80", Offset = "0x708F380", VA = "0x18708FF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> PBFOICAHMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7090730", Offset = "0x708FB30", VA = "0x187090730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action IDJHKEBHGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	[UnityEngine.Scripting.Preserve]
	public BFNBNOPCKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "8")]
	public void MHKJKIIDKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x708FA80", Offset = "0x708EE80", VA = "0x18708FA80", Slot = "6")]
	public Task EKGDNOJFOEJ(long JDDGCPNEBBE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x708FA10", Offset = "0x708EE10", VA = "0x18708FA10", Slot = "14")]
	public float EHMDBDCPHAN(string OEOMDKHBDFI, float BMLEAJPEFAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7090550", Offset = "0x708F950", VA = "0x187090550", Slot = "13")]
	public void MKDLADHPDJC(string OEOMDKHBDFI, bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x708FFF0", Offset = "0x708F3F0", VA = "0x18708FFF0", Slot = "12")]
	public bool IGKEAHOPEFA(string OEOMDKHBDFI, bool BMLEAJPEFAD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x70906C0", Offset = "0x708FAC0", VA = "0x1870906C0", Slot = "10")]
	public int OCMGAPNIPHI(string OEOMDKHBDFI, int BMLEAJPEFAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x70905C0", Offset = "0x708F9C0", VA = "0x1870905C0", Slot = "18")]
	public DateTime NEDLCJHPPLK(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x70900B0", Offset = "0x708F4B0", VA = "0x1870900B0", Slot = "19")]
	public void IJMIMEPCMHK(string OEOMDKHBDFI, DateTime EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x708F9A0", Offset = "0x708EDA0", VA = "0x18708F9A0", Slot = "15")]
	public void DPGABHLPJFG(string OEOMDKHBDFI, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7090120", Offset = "0x708F520", VA = "0x187090120", Slot = "11")]
	public void IPCGEKKMJLD(string OEOMDKHBDFI, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x708FF10", Offset = "0x708F310", VA = "0x18708FF10", Slot = "20")]
	public long HHBCOACCAGI(string BMAAJNANOMC, long BMLEAJPEFAD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x708FDF0", Offset = "0x708F1F0", VA = "0x18708FDF0", Slot = "21")]
	public void FNHFLAAECHC(string BMAAJNANOMC, long EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA9C0", Offset = "0x2BE9DC0", VA = "0x182BEA9C0", Slot = "22")]
	public T CGBHAINEFAE<T>(string BMAAJNANOMC, T BMLEAJPEFAD, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA9C0", Offset = "0x2BE9DC0", VA = "0x182BEA9C0", Slot = "23")]
	public void GNOJGKLEFKM<T>(string BMAAJNANOMC, T EEPLCHCGAIN, DEFAGFOFBDJ<T> BEIMGHIDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x708FE60", Offset = "0x708F260", VA = "0x18708FE60", Slot = "16")]
	public string GEJGPAHCLKD(string OEOMDKHBDFI, string BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x70904B0", Offset = "0x708F8B0", VA = "0x1870904B0", Slot = "17")]
	public void LKBMFGOIANK(string OEOMDKHBDFI, string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x70903F0", Offset = "0x708F7F0", VA = "0x1870903F0", Slot = "24")]
	public void KPINMJFLFMJ(string OEOMDKHBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7090630", Offset = "0x708FA30", VA = "0x187090630", Slot = "9")]
	public bool NLNGJLAEKFL(string OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7090190", Offset = "0x708F590", VA = "0x187090190", Slot = "25")]
	public Task JMOCJIBLKBA(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BE96D0", Offset = "0x2BE8AD0", VA = "0x182BE96D0")]
	private T CADKKGPFCDD<T>(string BMAAJNANOMC, T BMLEAJPEFAD, [Optional] DEFAGFOFBDJ<T> APABPEFHAHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BEABC0", Offset = "0x2BE9FC0", VA = "0x182BEABC0")]
	private void MCAKFOHFDBM<T>(string BMAAJNANOMC, T EEPLCHCGAIN, [Optional] DEFAGFOFBDJ<T> APABPEFHAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x708FB10", Offset = "0x708EF10", VA = "0x18708FB10")]
	private Dictionary<string, string> FGHPHBMPNJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LIABMCCCGLG
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action IDJHKEBHGMM;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHKJKIIDKCG();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NKAJFHEIDMI(long JDDGCPNEBBE);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DKCDNPBEJJD(GDHJPLDICOK JMOLGCHIIIL = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GCBIHDNGEND(string BMAAJNANOMC, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PBAKLJENGHB(string BMAAJNANOMC, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string KAGNDKNMMMA(string BMAAJNANOMC, [Optional] string BMLEAJPEFAD, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FHMKJMLPABK BJFIDALOMON(string BMAAJNANOMC, string EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int MNOCNFPBHEA(string BMAAJNANOMC, int BMLEAJPEFAD = 0, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FHMKJMLPABK PMGKOBAGOME(string BMAAJNANOMC, int EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CBBIDHECCIL(string BMAAJNANOMC, bool BMLEAJPEFAD, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FHMKJMLPABK JIFENIGHDCF(string BMAAJNANOMC, bool EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float LDNMEPAOHHB(string BMAAJNANOMC, float BMLEAJPEFAD = 0f, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FHMKJMLPABK CLIFHPPBGLA(string BMAAJNANOMC, float EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime LOJLJBPBEND(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FHMKJMLPABK GKHDKKPDOIE(string BMAAJNANOMC, DateTime EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long IAHFKFOCHGL(string BMAAJNANOMC, long BMLEAJPEFAD = 0L, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FHMKJMLPABK NJDPCFALCDI(string BMAAJNANOMC, long EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T EBAKICLELJP<T>(string BMAAJNANOMC, [Optional] T BMLEAJPEFAD, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FHMKJMLPABK KIKPBLGDPIH<T>(string BMAAJNANOMC, T EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool NAFOBABIHPC(string BMAAJNANOMC);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool GGLHFEGOALL(string BMAAJNANOMC);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string ONKOINOEDEB(string BMAAJNANOMC, [Optional] string BMLEAJPEFAD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FHMKJMLPABK CJGMLIELAEJ(string BMAAJNANOMC, string EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int KJEGLLJOKPC(string BMAAJNANOMC, int BMLEAJPEFAD = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FHMKJMLPABK KOMJNLEEKPL(string BMAAJNANOMC, int EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DHDDHJECPFG(string BMAAJNANOMC, bool BMLEAJPEFAD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	FHMKJMLPABK HADDFPNAGMK(string BMAAJNANOMC, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float IMJIJOEKJCK(string BMAAJNANOMC, float BMLEAJPEFAD = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	FHMKJMLPABK AHBGDANFBDK(string BMAAJNANOMC, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime NDPCLGGEDNJ(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FHMKJMLPABK GHENIEJCLEB(string BMAAJNANOMC, DateTime EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long HEINIKPBCKE(string BMAAJNANOMC, long BMLEAJPEFAD = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	FHMKJMLPABK PFPFIAJOINB(string BMAAJNANOMC, long EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void JHLFIDCHNKP<T>(DEFAGFOFBDJ<T> BEIMGHIDPCJ, [Optional] IEqualityComparer<T> IPJKNPILFIK);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AOKCABNDBKB<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable JGKDCNFMNCN();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void MIKMPIFGBMO(float FBMABEBEKJJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task FAAAEHMLPMN([Optional] CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum FHMKJMLPABK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FLICIANAPPF : LIABMCCCGLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class AGOFOCBMBIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<AGOFOCBMBIL> FIOIDGFGFOO;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x708F6F0", Offset = "0x708EAF0", VA = "0x18708F6F0")]
		public static void PPNFPOGJLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void KMNEPMPOIBK();

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		protected AGOFOCBMBIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class MCNKHJLCILG<T> : AGOFOCBMBIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly MCNKHJLCILG<T> GJPJBBHLIHD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DEFAGFOFBDJ<T> EFECGCDBMDI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> NEFKCCMOKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PKJEPHGLKKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3B43190", Offset = "0x3B42590", VA = "0x183B43190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x47B83D0", Offset = "0x47B77D0", VA = "0x1847B83D0")]
		private MCNKHJLCILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x47B80D0", Offset = "0x47B74D0", VA = "0x1847B80D0")]
		public void MHJHNBDIMHP(DEFAGFOFBDJ<T> APABPEFHAHN, [Optional] IEqualityComparer<T> IPJKNPILFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x47B7CC0", Offset = "0x47B70C0", VA = "0x1847B7CC0", Slot = "4")]
		public override void KMNEPMPOIBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class BBOEJEFJBGP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly FLICIANAPPF IJGNLNIKKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object DGKHDHAKGAB;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x708F8F0", Offset = "0x708ECF0", VA = "0x18708F8F0")]
		public BBOEJEFJBGP(FLICIANAPPF IJGNLNIKKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x708F8C0", Offset = "0x708ECC0", VA = "0x18708F8C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct GAADMODIEEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public FLICIANAPPF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x70949D0", Offset = "0x7093DD0", VA = "0x1870949D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7094CC0", Offset = "0x70940C0", VA = "0x187094CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct MEKPFKODMGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FLICIANAPPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public MCNHIDDPBLM backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7097BD0", Offset = "0x7096FD0", VA = "0x187097BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct ONELIEMDANH : IAsyncStateMachine
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
		public FLICIANAPPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x70980B0", Offset = "0x70974B0", VA = "0x1870980B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7098580", Offset = "0x7097980", VA = "0x187098580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DAJGKEFCBLF : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public FLICIANAPPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public DAJGKEFCBLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7091100", Offset = "0x7090500", VA = "0x187091100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7091190", Offset = "0x7090590", VA = "0x187091190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly CPNJPENCOPB HDJLGIJDGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly CPNJPENCOPB NBCLLKKEPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EJBHAFPDKLC CPEKFGLKKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IAKIMJPLHMP CLFOMGAKNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ONNJOAKIJGH.PIBOODLENKF EINCNMOHPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GDCNMJIEPIF IPGKLJJBCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<MCNHIDDPBLM> CCPNKKOGEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task CCDHLOEOMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> BLHODHJINEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NFIGMHBJPEE KHIOMKAMNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object MBAHEMGNPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object KILDFGFIGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long DPFDOMGMCOL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool MJLJNBHELEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7093D70", Offset = "0x7093170", VA = "0x187093D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource KGHCJEFMIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAD0", Offset = "0x8ABED0", VA = "0x1808ACAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action IDJHKEBHGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7091D00", Offset = "0x7091100", VA = "0x187091D00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x70921C0", Offset = "0x70915C0", VA = "0x1870921C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7092EF0", Offset = "0x70922F0", VA = "0x187092EF0")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void JEDBBFPEMOC(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7094600", Offset = "0x7093A00", VA = "0x187094600")]
	[UnityEngine.Scripting.Preserve]
	public FLICIANAPPF([CCLHMIDBCEM("Disk")] CPNJPENCOPB HDJLGIJDGDL, [CCLHMIDBCEM("Cloud")] CPNJPENCOPB NBCLLKKEPKL, [CCLHMIDBCEM(null)] EJBHAFPDKLC CPEKFGLKKHI, [CCLHMIDBCEM(null)] IAKIMJPLHMP CLFOMGAKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7092180", Offset = "0x7091580", VA = "0x187092180", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7093930", Offset = "0x7092D30", VA = "0x187093930")]
	private void LFKIKAOJALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7093B70", Offset = "0x7092F70", VA = "0x187093B70", Slot = "6")]
	public void MHKJKIIDKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7093F10", Offset = "0x7093310", VA = "0x187093F10", Slot = "7")]
	public Task NKAJFHEIDMI(long JDDGCPNEBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7093600", Offset = "0x7092A00", VA = "0x187093600")]
	[AsyncStateMachine(typeof(GAADMODIEEI))]
	private Task KLJAOPCEKOF(long JDDGCPNEBBE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7091DD0", Offset = "0x70911D0", VA = "0x187091DD0")]
	private void CKKDHOJLEHH(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7092670", Offset = "0x7091A70", VA = "0x187092670")]
	private void FNNLCOPLGBH(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7093330", Offset = "0x7092730", VA = "0x187093330")]
	private string JLIODHFNONP(string APPEBKCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x70942E0", Offset = "0x70936E0", VA = "0x1870942E0")]
	private void PGFGKEGJJEJ(GDHJPLDICOK JMOLGCHIIIL, string OEOMDKHBDFI, [Out] CPNJPENCOPB OOEMGMJAKAK, [Out] string IPNJEIDFGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7092040", Offset = "0x7091440", VA = "0x187092040")]
	private CPNJPENCOPB DJBJBNCAPNE(GDHJPLDICOK JMOLGCHIIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x70920C0", Offset = "0x70914C0", VA = "0x1870920C0", Slot = "8")]
	public bool DKCDNPBEJJD(GDHJPLDICOK JMOLGCHIIIL = GDHJPLDICOK.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7092970", Offset = "0x7091D70", VA = "0x187092970", Slot = "9")]
	public bool GCBIHDNGEND(string BMAAJNANOMC, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7094180", Offset = "0x7093580", VA = "0x187094180", Slot = "10")]
	public bool PBAKLJENGHB(string BMAAJNANOMC, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x70934F0", Offset = "0x70928F0", VA = "0x1870934F0", Slot = "11")]
	public string KAGNDKNMMMA(string BMAAJNANOMC, [Optional] string BMLEAJPEFAD, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7091AC0", Offset = "0x7090EC0", VA = "0x187091AC0", Slot = "12")]
	public FHMKJMLPABK BJFIDALOMON(string BMAAJNANOMC, string EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7093BF0", Offset = "0x7092FF0", VA = "0x187093BF0", Slot = "13")]
	public int MNOCNFPBHEA(string BMAAJNANOMC, int BMLEAJPEFAD = 0, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7094480", Offset = "0x7093880", VA = "0x187094480", Slot = "14")]
	public FHMKJMLPABK PMGKOBAGOME(string BMAAJNANOMC, int EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7091C50", Offset = "0x7091050", VA = "0x187091C50", Slot = "15")]
	public bool CBBIDHECCIL(string BMAAJNANOMC, bool BMLEAJPEFAD, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x70931B0", Offset = "0x70925B0", VA = "0x1870931B0", Slot = "16")]
	public FHMKJMLPABK JIFENIGHDCF(string BMAAJNANOMC, bool EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7093880", Offset = "0x7092C80", VA = "0x187093880", Slot = "17")]
	public float LDNMEPAOHHB(string BMAAJNANOMC, float BMLEAJPEFAD = 0f, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7091DF0", Offset = "0x70911F0", VA = "0x187091DF0", Slot = "18")]
	public FHMKJMLPABK CLIFHPPBGLA(string BMAAJNANOMC, float EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7093AD0", Offset = "0x7092ED0", VA = "0x187093AD0", Slot = "19")]
	public DateTime LOJLJBPBEND(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7092A50", Offset = "0x7091E50", VA = "0x187092A50", Slot = "20")]
	public FHMKJMLPABK GKHDKKPDOIE(string BMAAJNANOMC, DateTime EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7092C90", Offset = "0x7092090", VA = "0x187092C90", Slot = "21")]
	public long IAHFKFOCHGL(string BMAAJNANOMC, long BMLEAJPEFAD = 0L, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7093D90", Offset = "0x7093190", VA = "0x187093D90", Slot = "22")]
	public FHMKJMLPABK NJDPCFALCDI(string BMAAJNANOMC, long EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AE30", Offset = "0x2E4A230", VA = "0x182E4AE30", Slot = "23")]
	public T EBAKICLELJP<T>(string BMAAJNANOMC, [Optional] T BMLEAJPEFAD, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AE30", Offset = "0x2E4A230", VA = "0x182E4AE30", Slot = "24")]
	public FHMKJMLPABK KIKPBLGDPIH<T>(string BMAAJNANOMC, T EEPLCHCGAIN, GDHJPLDICOK NOMIHEIMEGJ = GDHJPLDICOK.CLOUD)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7093CA0", Offset = "0x70930A0", VA = "0x187093CA0", Slot = "25")]
	public bool NAFOBABIHPC(string BMAAJNANOMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7092A10", Offset = "0x7091E10", VA = "0x187092A10", Slot = "26")]
	public bool GGLHFEGOALL(string BMAAJNANOMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7094110", Offset = "0x7093510", VA = "0x187094110", Slot = "27")]
	public string ONKOINOEDEB(string BMAAJNANOMC, [Optional] string BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7091DA0", Offset = "0x70911A0", VA = "0x187091DA0", Slot = "28")]
	public FHMKJMLPABK CJGMLIELAEJ(string BMAAJNANOMC, string EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7093590", Offset = "0x7092990", VA = "0x187093590", Slot = "29")]
	public int KJEGLLJOKPC(string BMAAJNANOMC, int BMLEAJPEFAD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7093850", Offset = "0x7092C50", VA = "0x187093850", Slot = "30")]
	public FHMKJMLPABK KOMJNLEEKPL(string BMAAJNANOMC, int EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7091FD0", Offset = "0x70913D0", VA = "0x187091FD0", Slot = "31")]
	public bool DHDDHJECPFG(string BMAAJNANOMC, bool BMLEAJPEFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7092BF0", Offset = "0x7091FF0", VA = "0x187092BF0", Slot = "32")]
	public FHMKJMLPABK HADDFPNAGMK(string BMAAJNANOMC, bool EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7092D30", Offset = "0x7092130", VA = "0x187092D30", Slot = "33")]
	public float IMJIJOEKJCK(string BMAAJNANOMC, float BMLEAJPEFAD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7091950", Offset = "0x7090D50", VA = "0x187091950", Slot = "34")]
	public FHMKJMLPABK AHBGDANFBDK(string BMAAJNANOMC, float EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7093D00", Offset = "0x7093100", VA = "0x187093D00", Slot = "35")]
	public DateTime NDPCLGGEDNJ(string BMAAJNANOMC, [Optional] DateTime BMLEAJPEFAD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7092A20", Offset = "0x7091E20", VA = "0x187092A20", Slot = "36")]
	public FHMKJMLPABK GHENIEJCLEB(string BMAAJNANOMC, DateTime EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7092C20", Offset = "0x7092020", VA = "0x187092C20", Slot = "37")]
	public long HEINIKPBCKE(string BMAAJNANOMC, long BMLEAJPEFAD = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x70942B0", Offset = "0x70936B0", VA = "0x1870942B0", Slot = "38")]
	public FHMKJMLPABK PFPFIAJOINB(string BMAAJNANOMC, long EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7091F70", Offset = "0x7091370", VA = "0x187091F70")]
	private bool COICNPIGIMA(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7091860", Offset = "0x7090C60", VA = "0x187091860")]
	private bool AAPPDKIDGHM(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7093980", Offset = "0x7092D80", VA = "0x187093980")]
	private FHMKJMLPABK LKCHDEHCIBK(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, string EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7093710", Offset = "0x7092B10", VA = "0x187093710")]
	private FHMKJMLPABK KOKLKODNHLG(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, int EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7092350", Offset = "0x7091750", VA = "0x187092350")]
	private FHMKJMLPABK FALEAIMCNEM(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, bool EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7092DA0", Offset = "0x70921A0", VA = "0x187092DA0")]
	private FHMKJMLPABK JAPABNHLBPC(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, float EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7092F60", Offset = "0x7092360", VA = "0x187092F60")]
	private FHMKJMLPABK JGAJJNLNEAM(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, DateTime EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7091980", Offset = "0x7090D80", VA = "0x187091980")]
	private FHMKJMLPABK BGHGJLEHIPH(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, long EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B240", Offset = "0x2E4A640", VA = "0x182E4B240")]
	private T KNHLABFAHJM<T>(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, T BMLEAJPEFAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B7A0", Offset = "0x2E4ABA0", VA = "0x182E4B7A0")]
	private FHMKJMLPABK OHPJONMFCBI<T>(MCNHIDDPBLM OOEMGMJAKAK, string BMAAJNANOMC, T EEPLCHCGAIN)
	{
		return default(FHMKJMLPABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B050", Offset = "0x2E4A450", VA = "0x182E4B050", Slot = "39")]
	public void JHLFIDCHNKP<T>(DEFAGFOFBDJ<T> BEIMGHIDPCJ, [Optional] IEqualityComparer<T> IPJKNPILFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2E4ADB0", Offset = "0x2E4A1B0", VA = "0x182E4ADB0", Slot = "40")]
	public void AOKCABNDBKB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7093390", Offset = "0x7092790", VA = "0x187093390")]
	[AsyncStateMachine(typeof(MEKPFKODMGO))]
	private void JMOCJIBLKBA(MCNHIDDPBLM JHOCHPMIJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7092260", Offset = "0x7091660", VA = "0x187092260", Slot = "43")]
	[AsyncStateMachine(typeof(ONELIEMDANH))]
	public Task FAAAEHMLPMN([Optional] CancellationToken ABHFNNFMPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7092490", Offset = "0x7091890", VA = "0x187092490")]
	private void FEMPPPIKMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x70930D0", Offset = "0x70924D0", VA = "0x1870930D0", Slot = "41")]
	public IDisposable JGKDCNFMNCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7093BE0", Offset = "0x7092FE0", VA = "0x187093BE0", Slot = "42")]
	public void MIKMPIFGBMO(float FBMABEBEKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x70926F0", Offset = "0x7091AF0", VA = "0x1870926F0")]
	private void FPPFDEOLMDO(float EDCNOOGLLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7093460", Offset = "0x7092860", VA = "0x187093460")]
	[IteratorStateMachine(typeof(DAJGKEFCBLF))]
	private IEnumerator<DNOIEDKBBPN> JPFHNFCDDME(float FBMABEBEKJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x70940E0", Offset = "0x70934E0", VA = "0x1870940E0")]
	[CompilerGenerated]
	private void OBPBGDEGPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class EBHGIHNPNIG : HANHALOCPBL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static EBHGIHNPNIG GJPJBBHLIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7091650", Offset = "0x7090A50", VA = "0x187091650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x70916A0", Offset = "0x7090AA0", VA = "0x1870916A0", Slot = "9")]
	public override string IFDLICGNEEM(bool EBJHHBADCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x70913D0", Offset = "0x70907D0", VA = "0x1870913D0", Slot = "10")]
	protected override bool BLHLAFGLLHC(string EBJHHBADCKF, [Out] bool EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7091820", Offset = "0x7090C20", VA = "0x187091820")]
	public EBHGIHNPNIG()
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
