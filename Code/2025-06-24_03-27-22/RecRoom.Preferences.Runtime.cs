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
		[Cpp2IlInjected.Address(RVA = "0x8196120", Offset = "0x8194D20", VA = "0x188196120", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CEDIHIFCOLH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class MACDCMPGFIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void EAOJDLMMPPE(AKOCCDHEIIG ENGJJKLDCIM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8191550", Offset = "0x8190150", VA = "0x188191550")]
	private static void KEBPOIDHAEO(AKOCCDHEIIG ENGJJKLDCIM, EAOJDLMMPPE OPPLPHMDKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8191720", Offset = "0x8190320", VA = "0x188191720")]
	public static bool LDKFHNMPPHA(this AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, [Optional] EAOJDLMMPPE OPPLPHMDKMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8191B00", Offset = "0x8190700", VA = "0x188191B00")]
	public static BJDHHIAGNCN ONDDGGEFLKE(this AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, string OOHGFGHCOAJ, [Optional] EAOJDLMMPPE OPPLPHMDKMF)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8191880", Offset = "0x8190480", VA = "0x188191880")]
	public static BJDHHIAGNCN NAJMLHNIIDD(this AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, int OOHGFGHCOAJ, [Optional] EAOJDLMMPPE OPPLPHMDKMF)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8191290", Offset = "0x818FE90", VA = "0x188191290")]
	public static BJDHHIAGNCN IKFEDIGNALM(this AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, bool OOHGFGHCOAJ, [Optional] EAOJDLMMPPE OPPLPHMDKMF)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81915D0", Offset = "0x81901D0", VA = "0x1881915D0")]
	public static BJDHHIAGNCN LAOEKCPDCMD(this AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, float OOHGFGHCOAJ, [Optional] EAOJDLMMPPE OPPLPHMDKMF)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81913E0", Offset = "0x818FFE0", VA = "0x1881913E0")]
	public static BJDHHIAGNCN JMEEFCEBHIN(this AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, DateTime OOHGFGHCOAJ, [Optional] EAOJDLMMPPE OPPLPHMDKMF)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81919C0", Offset = "0x81905C0", VA = "0x1881919C0")]
	public static BJDHHIAGNCN NNLCLEDBENF(this AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, long OOHGFGHCOAJ, [Optional] EAOJDLMMPPE OPPLPHMDKMF)
	{
		return default(BJDHHIAGNCN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KLGHCOMAPIE : OINIAPKNLMK, AKOCCDHEIIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CDABPNMGELP APNNDMPBEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> JCMAKGBPPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> OFPKELLCDCP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> HIIEOCNCBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81903E0", Offset = "0x818EFE0", VA = "0x1881903E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action EAFAKADDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8190CC0", Offset = "0x818F8C0", VA = "0x188190CC0")]
	[UnityEngine.Scripting.Preserve]
	public KLGHCOMAPIE([GFNPNOLPMKK(null)] CDABPNMGELP APNNDMPBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "8")]
	public void DMPNDAIBJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x818FEB0", Offset = "0x818EAB0", VA = "0x18818FEB0")]
	private DirectoryInfo DANNGBOOAKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8190620", Offset = "0x818F220", VA = "0x188190620", Slot = "6")]
	public Task MLOLAKLBFOF(long EHDADNKLPJD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x818FE40", Offset = "0x818EA40", VA = "0x18818FE40", Slot = "14")]
	public float COGGEGPPMHD(string MEPFFFGIFGB, float IPOLOHBNCGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81905B0", Offset = "0x818F1B0", VA = "0x1881905B0", Slot = "13")]
	public void MAJBHIABNBL(string MEPFFFGIFGB, bool OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x818F150", Offset = "0x818DD50", VA = "0x18818F150", Slot = "12")]
	public bool ACNGCKDNHMD(string MEPFFFGIFGB, bool IPOLOHBNCGD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8190540", Offset = "0x818F140", VA = "0x188190540", Slot = "10")]
	public int KAGOMEGHHGP(string MEPFFFGIFGB, int IPOLOHBNCGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8190820", Offset = "0x818F420", VA = "0x188190820", Slot = "18")]
	public DateTime OFMMFEGDDBG(string HGJNKBHNLKN, [Optional] DateTime IPOLOHBNCGD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81907B0", Offset = "0x818F3B0", VA = "0x1881907B0", Slot = "19")]
	public void OANMFGLCLMB(string MEPFFFGIFGB, DateTime OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8190370", Offset = "0x818EF70", VA = "0x188190370", Slot = "15")]
	public void EPKMKABHDCJ(string MEPFFFGIFGB, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8190420", Offset = "0x818F020", VA = "0x188190420", Slot = "11")]
	public void JAFGAOPDGHD(string MEPFFFGIFGB, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8190900", Offset = "0x818F500", VA = "0x188190900", Slot = "20")]
	public long OOCMDGNGBNN(string HGJNKBHNLKN, long IPOLOHBNCGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8190890", Offset = "0x818F490", VA = "0x188190890", Slot = "21")]
	public void OKEGCLLIMGI(string HGJNKBHNLKN, long OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38A5B70", Offset = "0x38A4770", VA = "0x1838A5B70", Slot = "22")]
	public T GKACAOMIJKB<T>(string HGJNKBHNLKN, T IPOLOHBNCGD, POMHBPLMBPJ<T> JIMJOFGOGKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C660", Offset = "0x3B1B260", VA = "0x183B1C660", Slot = "23")]
	public void GBJFMEGJLJD<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, POMHBPLMBPJ<T> JIMJOFGOGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8190490", Offset = "0x818F090", VA = "0x188190490", Slot = "16")]
	public string JIKNCHCLKGE(string MEPFFFGIFGB, string IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x818F210", Offset = "0x818DE10", VA = "0x18818F210", Slot = "17")]
	public void AIBKLNIHMLA(string MEPFFFGIFGB, string OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8190B70", Offset = "0x818F770", VA = "0x188190B70", Slot = "24")]
	public void PLONGMCJMDO(string MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81902E0", Offset = "0x818EEE0", VA = "0x1881902E0", Slot = "9")]
	public bool DLKCBKDIEBL(string MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x818FFB0", Offset = "0x818EBB0", VA = "0x18818FFB0", Slot = "25")]
	public Task DGHJHJHJEOF(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x818F280", Offset = "0x818DE80", VA = "0x18818F280")]
	private void BEMNGADCAHI(DirectoryInfo IMBJHGGAOIK, string HPKJHCCDOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8190970", Offset = "0x818F570", VA = "0x188190970")]
	private static string PFJJMOCJAEM(string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81906B0", Offset = "0x818F2B0", VA = "0x1881906B0")]
	private static string NEFIAJOIOJO(byte[] OEOOBGJGDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B694D0", Offset = "0x3B680D0", VA = "0x183B694D0")]
	private T LBDBFELEJGA<T>(string HGJNKBHNLKN, T IPOLOHBNCGD, [Optional] POMHBPLMBPJ<T> LPEBMNFIGNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A5E0", Offset = "0x3B691E0", VA = "0x183B6A5E0")]
	private void PEPEIECOOBP<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, [Optional] POMHBPLMBPJ<T> LPEBMNFIGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x818F640", Offset = "0x818E240", VA = "0x18818F640")]
	private Dictionary<string, string> CGKOMBLEHHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class JDKNPCMBGDJ
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x818E8D0", Offset = "0x818D4D0", VA = "0x18818E8D0")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void MACELCFKDEA(PFGPAPHADOM MHCMGFKMEEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FDKFNLCDJOJ : KAANHHJICHA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x818DF40", Offset = "0x818CB40", VA = "0x18818DF40")]
	[UnityEngine.Scripting.Preserve]
	public FDKFNLCDJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KAANHHJICHA : OINIAPKNLMK, AKOCCDHEIIG, KFOJFMIPHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> PKHKKKFHLNA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EAFAKADDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "8")]
	public void DMPNDAIBJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x818EE20", Offset = "0x818DA20", VA = "0x18818EE20", Slot = "6")]
	public Task MLOLAKLBFOF(long EHDADNKLPJD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x818EBE0", Offset = "0x818D7E0", VA = "0x18818EBE0", Slot = "9")]
	public bool DLKCBKDIEBL(string HGJNKBHNLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x818ED60", Offset = "0x818D960", VA = "0x18818ED60", Slot = "10")]
	public int KAGOMEGHHGP(string HGJNKBHNLKN, int IPOLOHBNCGD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x818ECA0", Offset = "0x818D8A0", VA = "0x18818ECA0", Slot = "11")]
	public void JAFGAOPDGHD(string HGJNKBHNLKN, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x818EA30", Offset = "0x818D630", VA = "0x18818EA30", Slot = "12")]
	public bool ACNGCKDNHMD(string HGJNKBHNLKN, bool IPOLOHBNCGD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x818EDC0", Offset = "0x818D9C0", VA = "0x18818EDC0", Slot = "13")]
	public void MAJBHIABNBL(string HGJNKBHNLKN, bool OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x818EAF0", Offset = "0x818D6F0", VA = "0x18818EAF0", Slot = "14")]
	public float COGGEGPPMHD(string HGJNKBHNLKN, float IPOLOHBNCGD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x818EC40", Offset = "0x818D840", VA = "0x18818EC40", Slot = "15")]
	public void EPKMKABHDCJ(string HGJNKBHNLKN, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x818ED00", Offset = "0x818D900", VA = "0x18818ED00", Slot = "16")]
	public string JIKNCHCLKGE(string HGJNKBHNLKN, [Optional] string IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x818EA90", Offset = "0x818D690", VA = "0x18818EA90", Slot = "17")]
	public void AIBKLNIHMLA(string HGJNKBHNLKN, string OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x818EF10", Offset = "0x818DB10", VA = "0x18818EF10", Slot = "18")]
	public DateTime OFMMFEGDDBG(string HGJNKBHNLKN, [Optional] DateTime IPOLOHBNCGD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x818EEB0", Offset = "0x818DAB0", VA = "0x18818EEB0", Slot = "19")]
	public void OANMFGLCLMB(string HGJNKBHNLKN, DateTime OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x818EFD0", Offset = "0x818DBD0", VA = "0x18818EFD0", Slot = "20")]
	public long OOCMDGNGBNN(string HGJNKBHNLKN, long IPOLOHBNCGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x818EF70", Offset = "0x818DB70", VA = "0x18818EF70", Slot = "21")]
	public void OKEGCLLIMGI(string HGJNKBHNLKN, long OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E80", Offset = "0x3B5FA80", VA = "0x183B60E80", Slot = "22")]
	public T GKACAOMIJKB<T>(string HGJNKBHNLKN, T IPOLOHBNCGD, POMHBPLMBPJ<T> JIMJOFGOGKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B60DE0", Offset = "0x3B5F9E0", VA = "0x183B60DE0", Slot = "23")]
	public void GBJFMEGJLJD<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, POMHBPLMBPJ<T> JIMJOFGOGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B60F80", Offset = "0x3B5FB80", VA = "0x183B60F80")]
	public T LBDBFELEJGA<T>(string HGJNKBHNLKN, T IPOLOHBNCGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B617C0", Offset = "0x3B603C0", VA = "0x183B617C0")]
	public void PEPEIECOOBP<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x818F030", Offset = "0x818DC30", VA = "0x18818F030", Slot = "24")]
	public void PLONGMCJMDO(string HGJNKBHNLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x818EB50", Offset = "0x818D750", VA = "0x18818EB50", Slot = "25")]
	public Task DGHJHJHJEOF(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x818DF40", Offset = "0x818CB40", VA = "0x18818DF40")]
	public KAANHHJICHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class CJMDFFGANMO<TParent> where TParent : AKOCCDHEIIG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<CJMDFFGANMO<TParent>> CCKNEFBECAH;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6986EC0", Offset = "0x6985AC0", VA = "0x186986EC0")]
	protected CJMDFFGANMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void ILJKHADAMOK();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void LAEEFGLHHKA(string MEPFFFGIFGB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6986B70", Offset = "0x6985770", VA = "0x186986B70")]
	public static void OIGFEIOCFCC(string MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6986950", Offset = "0x6985550", VA = "0x186986950")]
	public static void NPMDJHNCGDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GKJKJAECCCC<TParent, TValue> : CJMDFFGANMO<TParent> where TParent : AKOCCDHEIIG
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly GKJKJAECCCC<TParent, TValue> DIACPKGMELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> MNGNCDJHKMC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C110", Offset = "0x4D1AD10", VA = "0x184D1C110")]
	public bool GFPOIIGIKGC(string DBGCCCIOHHI, [Out] TValue FHLOHBNEJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C1B0", Offset = "0x4D1ADB0", VA = "0x184D1C1B0")]
	public void NBDNKGGOKHP(string DBGCCCIOHHI, TValue OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C150", Offset = "0x4D1AD50", VA = "0x184D1C150", Slot = "4")]
	protected override void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C180", Offset = "0x4D1AD80", VA = "0x184D1C180", Slot = "5")]
	protected override void LAEEFGLHHKA(string DBGCCCIOHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C3D0", Offset = "0x4D1AFD0", VA = "0x184D1C3D0")]
	public GKJKJAECCCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AKOCCDHEIIG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMPNDAIBJJP();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DLKCBKDIEBL(string HGJNKBHNLKN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KAGOMEGHHGP(string HGJNKBHNLKN, int IPOLOHBNCGD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JAFGAOPDGHD(string HGJNKBHNLKN, int OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ACNGCKDNHMD(string HGJNKBHNLKN, bool IPOLOHBNCGD = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MAJBHIABNBL(string HGJNKBHNLKN, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float COGGEGPPMHD(string HGJNKBHNLKN, float IPOLOHBNCGD = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EPKMKABHDCJ(string HGJNKBHNLKN, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string JIKNCHCLKGE(string HGJNKBHNLKN, [Optional] string IPOLOHBNCGD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AIBKLNIHMLA(string HGJNKBHNLKN, string OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime OFMMFEGDDBG(string HGJNKBHNLKN, [Optional] DateTime ADDIJGEPNFI);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OANMFGLCLMB(string HGJNKBHNLKN, DateTime ADDIJGEPNFI);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long OOCMDGNGBNN(string HGJNKBHNLKN, long IPOLOHBNCGD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OKEGCLLIMGI(string HGJNKBHNLKN, long OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T GKACAOMIJKB<T>(string HGJNKBHNLKN, T IPOLOHBNCGD, POMHBPLMBPJ<T> JIMJOFGOGKG);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GBJFMEGJLJD<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, POMHBPLMBPJ<T> JIMJOFGOGKG);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PLONGMCJMDO(string HGJNKBHNLKN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task DGHJHJHJEOF([Optional] CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OINIAPKNLMK : AKOCCDHEIIG
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EAFAKADDEGP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task MLOLAKLBFOF(long EHDADNKLPJD, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KFOJFMIPHJJ : AKOCCDHEIIG
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IGDFMKGFLDO : OINIAPKNLMK, AKOCCDHEIIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NECPJEHMNAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IGDFMKGFLDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8191C50", Offset = "0x8190850", VA = "0x188191C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8192020", Offset = "0x8190C20", VA = "0x188192020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class KDGJLNDOFGL : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public IGDFMKGFLDO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public KDGJLNDOFGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x818F090", Offset = "0x818DC90", VA = "0x18818F090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x818F100", Offset = "0x818DD00", VA = "0x18818F100", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CDABPNMGELP APNNDMPBEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool APFBGINDPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool EKPBEMIFPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private IPNEFGFBDID KHIBKDLKLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GCBFJNEKOIO MGIINCKBGNK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EAFAKADDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x818E7E0", Offset = "0x818D3E0", VA = "0x18818E7E0")]
	[UnityEngine.Scripting.Preserve]
	public IGDFMKGFLDO([GFNPNOLPMKK(null)] CDABPNMGELP APNNDMPBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "8")]
	public void DMPNDAIBJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x818E500", Offset = "0x818D100", VA = "0x18818E500", Slot = "6")]
	public Task MLOLAKLBFOF(long EHDADNKLPJD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1C64600", Offset = "0x1C63200", VA = "0x181C64600")]
	private static int GBOGCHMBEPA(bool OOHGFGHCOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x818E1C0", Offset = "0x818CDC0", VA = "0x18818E1C0", Slot = "9")]
	public bool DLKCBKDIEBL(string HGJNKBHNLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x818E3E0", Offset = "0x818CFE0", VA = "0x18818E3E0", Slot = "10")]
	public int KAGOMEGHHGP(string HGJNKBHNLKN, int IPOLOHBNCGD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x818E270", Offset = "0x818CE70", VA = "0x18818E270", Slot = "11")]
	public void JAFGAOPDGHD(string HGJNKBHNLKN, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x818DFD0", Offset = "0x818CBD0", VA = "0x18818DFD0", Slot = "12")]
	public bool ACNGCKDNHMD(string HGJNKBHNLKN, bool IPOLOHBNCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x818E410", Offset = "0x818D010", VA = "0x18818E410", Slot = "13")]
	public void MAJBHIABNBL(string HGJNKBHNLKN, bool OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x818E0A0", Offset = "0x818CCA0", VA = "0x18818E0A0", Slot = "14")]
	public float COGGEGPPMHD(string HGJNKBHNLKN, float IPOLOHBNCGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x818E240", Offset = "0x818CE40", VA = "0x18818E240", Slot = "15")]
	public void EPKMKABHDCJ(string HGJNKBHNLKN, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x818E600", Offset = "0x818D200", VA = "0x18818E600", Slot = "18")]
	public DateTime OFMMFEGDDBG(string HGJNKBHNLKN, [Optional] DateTime IPOLOHBNCGD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x818E590", Offset = "0x818D190", VA = "0x18818E590", Slot = "19")]
	public void OANMFGLCLMB(string HGJNKBHNLKN, DateTime ADDIJGEPNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x818E6E0", Offset = "0x818D2E0", VA = "0x18818E6E0", Slot = "20")]
	public long OOCMDGNGBNN(string HGJNKBHNLKN, long IPOLOHBNCGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x818E670", Offset = "0x818D270", VA = "0x18818E670", Slot = "21")]
	public void OKEGCLLIMGI(string HGJNKBHNLKN, long OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8D00", Offset = "0x3AE7900", VA = "0x183AE8D00", Slot = "22")]
	public T GKACAOMIJKB<T>(string HGJNKBHNLKN, T IPOLOHBNCGD, POMHBPLMBPJ<T> JIMJOFGOGKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8BD0", Offset = "0x3AE77D0", VA = "0x183AE8BD0", Slot = "23")]
	public void GBJFMEGJLJD<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, POMHBPLMBPJ<T> JIMJOFGOGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE81A0", Offset = "0x3AE6DA0", VA = "0x183AE81A0")]
	private T FACPLANJOCD<T>(string HGJNKBHNLKN, T IPOLOHBNCGD, [Optional] POMHBPLMBPJ<T> LPEBMNFIGNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7AE0", Offset = "0x3AE66E0", VA = "0x183AE7AE0")]
	private void EMENFIPNKBC<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, [Optional] POMHBPLMBPJ<T> LPEBMNFIGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x818E2A0", Offset = "0x818CEA0", VA = "0x18818E2A0", Slot = "16")]
	public string JIKNCHCLKGE(string HGJNKBHNLKN, string IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x818E070", Offset = "0x818CC70", VA = "0x18818E070", Slot = "17")]
	public void AIBKLNIHMLA(string HGJNKBHNLKN, string OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x818E4E0", Offset = "0x818D0E0", VA = "0x18818E4E0")]
	private void MLFHCGJNILB(string HGJNKBHNLKN, string OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x818E3C0", Offset = "0x818CFC0", VA = "0x18818E3C0")]
	private string JOAGKHNMDGO(string HGJNKBHNLKN, string IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x818E750", Offset = "0x818D350", VA = "0x18818E750", Slot = "24")]
	public void PLONGMCJMDO(string HGJNKBHNLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x818E440", Offset = "0x818D040", VA = "0x18818E440")]
	private string MIDOHCKBCEN(string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x818E0D0", Offset = "0x818CCD0", VA = "0x18818E0D0", Slot = "25")]
	[AsyncStateMachine(typeof(NECPJEHMNAD))]
	public Task DGHJHJHJEOF(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x818E2D0", Offset = "0x818CED0", VA = "0x18818E2D0")]
	[IteratorStateMachine(typeof(KDGJLNDOFGL))]
	private IEnumerator<FCPCPCAPDCM> JLIIOBGKLEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x818E1E0", Offset = "0x818CDE0", VA = "0x18818E1E0")]
	private void EFNIAAHFFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x818E350", Offset = "0x818CF50", VA = "0x18818E350")]
	private void JMGGMDIPABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x818E000", Offset = "0x818CC00", VA = "0x18818E000")]
	private void ADAHKLJNEEE(bool NBKGIPELJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OFGJOPCJPOA : OINIAPKNLMK, AKOCCDHEIIG
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
	private Dictionary<string, string> OFPKELLCDCP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string LKGDBGFODGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8192890", Offset = "0x8191490", VA = "0x188192890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> HIIEOCNCBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8192900", Offset = "0x8191500", VA = "0x188192900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action EAFAKADDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	[UnityEngine.Scripting.Preserve]
	public OFGJOPCJPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "8")]
	public void DMPNDAIBJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8192B40", Offset = "0x8191740", VA = "0x188192B40", Slot = "6")]
	public Task MLOLAKLBFOF(long EHDADNKLPJD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x81924C0", Offset = "0x81910C0", VA = "0x1881924C0", Slot = "14")]
	public float COGGEGPPMHD(string MEPFFFGIFGB, float IPOLOHBNCGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8192AD0", Offset = "0x81916D0", VA = "0x188192AD0", Slot = "13")]
	public void MAJBHIABNBL(string MEPFFFGIFGB, bool OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8192080", Offset = "0x8190C80", VA = "0x188192080", Slot = "12")]
	public bool ACNGCKDNHMD(string MEPFFFGIFGB, bool IPOLOHBNCGD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8192A60", Offset = "0x8191660", VA = "0x188192A60", Slot = "10")]
	public int KAGOMEGHHGP(string MEPFFFGIFGB, int IPOLOHBNCGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8192C40", Offset = "0x8191840", VA = "0x188192C40", Slot = "18")]
	public DateTime OFMMFEGDDBG(string HGJNKBHNLKN, [Optional] DateTime IPOLOHBNCGD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8192BD0", Offset = "0x81917D0", VA = "0x188192BD0", Slot = "19")]
	public void OANMFGLCLMB(string MEPFFFGIFGB, DateTime OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8192820", Offset = "0x8191420", VA = "0x188192820", Slot = "15")]
	public void EPKMKABHDCJ(string MEPFFFGIFGB, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8192940", Offset = "0x8191540", VA = "0x188192940", Slot = "11")]
	public void JAFGAOPDGHD(string MEPFFFGIFGB, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8192D20", Offset = "0x8191920", VA = "0x188192D20", Slot = "20")]
	public long OOCMDGNGBNN(string HGJNKBHNLKN, long IPOLOHBNCGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8192CB0", Offset = "0x81918B0", VA = "0x188192CB0", Slot = "21")]
	public void OKEGCLLIMGI(string HGJNKBHNLKN, long OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x38A5B70", Offset = "0x38A4770", VA = "0x1838A5B70", Slot = "22")]
	public T GKACAOMIJKB<T>(string HGJNKBHNLKN, T IPOLOHBNCGD, POMHBPLMBPJ<T> JIMJOFGOGKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C660", Offset = "0x3B1B260", VA = "0x183B1C660", Slot = "23")]
	public void GBJFMEGJLJD<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, POMHBPLMBPJ<T> JIMJOFGOGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x81929B0", Offset = "0x81915B0", VA = "0x1881929B0", Slot = "16")]
	public string JIKNCHCLKGE(string MEPFFFGIFGB, string IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8192140", Offset = "0x8190D40", VA = "0x188192140", Slot = "17")]
	public void AIBKLNIHMLA(string MEPFFFGIFGB, string OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8192D90", Offset = "0x8191990", VA = "0x188192D90", Slot = "24")]
	public void PLONGMCJMDO(string MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8192790", Offset = "0x8191390", VA = "0x188192790", Slot = "9")]
	public bool DLKCBKDIEBL(string MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8192530", Offset = "0x8191130", VA = "0x188192530", Slot = "25")]
	public Task DGHJHJHJEOF(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F2D0", Offset = "0x3C6DED0", VA = "0x183C6F2D0")]
	private T LBDBFELEJGA<T>(string HGJNKBHNLKN, T IPOLOHBNCGD, [Optional] POMHBPLMBPJ<T> LPEBMNFIGNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C703E0", Offset = "0x3C6EFE0", VA = "0x183C703E0")]
	private void PEPEIECOOBP<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, [Optional] POMHBPLMBPJ<T> LPEBMNFIGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x81921E0", Offset = "0x8190DE0", VA = "0x1881921E0")]
	private Dictionary<string, string> CGKOMBLEHHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HOCDMBIPNHL
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action EAFAKADDEGP;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMPNDAIBJJP();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KPEGGMNCJHJ(long EHDADNKLPJD);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PKNOFOJNECG(CEDIHIFCOLH CHHDCBDPDDB = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NCMIIDBJLIA(string HGJNKBHNLKN, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NGDHICMOOLL(string HGJNKBHNLKN, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string HNOCPEAMCJK(string HGJNKBHNLKN, [Optional] string IPOLOHBNCGD, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BJDHHIAGNCN GHLBAMILBHM(string HGJNKBHNLKN, string OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int BFMPKFJHGCJ(string HGJNKBHNLKN, int IPOLOHBNCGD = 0, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BJDHHIAGNCN FICPBHDNNAF(string HGJNKBHNLKN, int OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CGMCIBEGCAA(string HGJNKBHNLKN, bool IPOLOHBNCGD, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BJDHHIAGNCN ELJFFCBJOBC(string HGJNKBHNLKN, bool OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float HMJPIBLDILG(string HGJNKBHNLKN, float IPOLOHBNCGD = 0f, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BJDHHIAGNCN JOBEBIMIBDP(string HGJNKBHNLKN, float OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime LMINNDCKKLA(string HGJNKBHNLKN, [Optional] DateTime IPOLOHBNCGD, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BJDHHIAGNCN FOBPDGHPPLP(string HGJNKBHNLKN, DateTime OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long BNKJIJINAAI(string HGJNKBHNLKN, long IPOLOHBNCGD = 0L, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	BJDHHIAGNCN HAFHBFINKEL(string HGJNKBHNLKN, long OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T LDOCMPOIJOD<T>(string HGJNKBHNLKN, [Optional] T IPOLOHBNCGD, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BJDHHIAGNCN LBCMHIJDLFD<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool DHNPAIEOAJK(string HGJNKBHNLKN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool FCDDJJMPBDI(string HGJNKBHNLKN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string BJJFJAFAEMD(string HGJNKBHNLKN, [Optional] string IPOLOHBNCGD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BJDHHIAGNCN MLDLAKDLMHB(string HGJNKBHNLKN, string OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int JJCFKIANGCF(string HGJNKBHNLKN, int IPOLOHBNCGD = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BJDHHIAGNCN CAKMEBFJJKK(string HGJNKBHNLKN, int OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LILLAFBGBOL(string HGJNKBHNLKN, bool IPOLOHBNCGD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	BJDHHIAGNCN BBIPJOJDLHF(string HGJNKBHNLKN, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float MOCNPKEMICA(string HGJNKBHNLKN, float IPOLOHBNCGD = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	BJDHHIAGNCN PKCDDCMPKNM(string HGJNKBHNLKN, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime KFEOMCKNOIP(string HGJNKBHNLKN, [Optional] DateTime IPOLOHBNCGD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	BJDHHIAGNCN KGHONANKFDJ(string HGJNKBHNLKN, DateTime OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long NNNNEFOFNPM(string HGJNKBHNLKN, long IPOLOHBNCGD = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	BJDHHIAGNCN FLBDDBPANDM(string HGJNKBHNLKN, long OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void FFAAABCMHLP<T>(POMHBPLMBPJ<T> JIMJOFGOGKG, [Optional] IEqualityComparer<T> DIMPLJBNCJB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void BMCEDPDJAJM<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable NLNKNABGAOG();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AOGADIELGKG(float KLCDLOHEBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task EFNIAAHFFHM([Optional] CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BJDHHIAGNCN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PNEKDOCCHFA : HOCDMBIPNHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class CPHLCPLENNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<CPHLCPLENNC> ILCPGOCMOEK;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x818D950", Offset = "0x818C550", VA = "0x18818D950")]
		public static void NPMDJHNCGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ILJKHADAMOK();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		protected CPHLCPLENNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class NBBEOCPGFCE<T> : CPHLCPLENNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly NBBEOCPGFCE<T> LBPNLDGACAA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public POMHBPLMBPJ<T> ACPLANPBEEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> PJHKHENCHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool MDOELMBDGJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4708B10", Offset = "0x4707710", VA = "0x184708B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x55165A0", Offset = "0x55151A0", VA = "0x1855165A0")]
		private NBBEOCPGFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5516220", Offset = "0x5514E20", VA = "0x185516220")]
		public void KHPGHNAFBFC(POMHBPLMBPJ<T> LPEBMNFIGNF, [Optional] IEqualityComparer<T> DIMPLJBNCJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5515F10", Offset = "0x5514B10", VA = "0x185515F10", Slot = "4")]
		public override void ILJKHADAMOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class EMGJDPNMHKL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly PNEKDOCCHFA AGKMNPEFBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object KMOMKFANKMN;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x818DB50", Offset = "0x818C750", VA = "0x18818DB50")]
		public EMGJDPNMHKL(PNEKDOCCHFA AGKMNPEFBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x818DB20", Offset = "0x818C720", VA = "0x18818DB20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct FAJIKLBBIFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PNEKDOCCHFA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x818DC00", Offset = "0x818C800", VA = "0x18818DC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x818DEE0", Offset = "0x818CAE0", VA = "0x18818DEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct BAFPPCEEAMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PNEKDOCCHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AKOCCDHEIIG backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x818D250", Offset = "0x818BE50", VA = "0x18818D250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct KNFIMFEKIGJ : IAsyncStateMachine
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
		public PNEKDOCCHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8190D60", Offset = "0x818F960", VA = "0x188190D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8191230", Offset = "0x818FE30", VA = "0x188191230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BHAINBPCCKK : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PNEKDOCCHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public BHAINBPCCKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x818D870", Offset = "0x818C470", VA = "0x18818D870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x818D900", Offset = "0x818C500", VA = "0x18818D900", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly OINIAPKNLMK PMDMGEKAJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly OINIAPKNLMK BDGEDBKJFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly KFOJFMIPHJJ PGLKBKHNHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IPNEFGFBDID KHIBKDLKLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MACDCMPGFIJ.EAOJDLMMPPE OPPLPHMDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly MAHLEDFAIAJ GFGBBAEDDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<AKOCCDHEIIG> NGLKJEFHMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task BBPMCGEAFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> DFFABKGHLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GCBFJNEKOIO IJGGOHBNDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object HJOJGLCGGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object IOMANINGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long AILMDAABBMH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool JAJIMKHOPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8195180", Offset = "0x8193D80", VA = "0x188195180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource KJBKHPIDFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6D0", Offset = "0xA1B2D0", VA = "0x180A1C6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action EAFAKADDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8194440", Offset = "0x8193040", VA = "0x188194440", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8193A60", Offset = "0x8192660", VA = "0x188193A60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8195970", Offset = "0x8194570", VA = "0x188195970")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8195C70", Offset = "0x8194870", VA = "0x188195C70")]
	[UnityEngine.Scripting.Preserve]
	public PNEKDOCCHFA([GFNPNOLPMKK("Disk")] OINIAPKNLMK PMDMGEKAJAH, [GFNPNOLPMKK("Cloud")] OINIAPKNLMK BDGEDBKJFPL, [GFNPNOLPMKK(null)] KFOJFMIPHJJ PGLKBKHNHHH, [GFNPNOLPMKK(null)] IPNEFGFBDID KHIBKDLKLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8193510", Offset = "0x8192110", VA = "0x188193510", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8194C70", Offset = "0x8193870", VA = "0x188194C70")]
	private void KOOJHBKANIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x81934A0", Offset = "0x81920A0", VA = "0x1881934A0", Slot = "6")]
	public void DMPNDAIBJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8194CC0", Offset = "0x81938C0", VA = "0x188194CC0", Slot = "7")]
	public Task KPEGGMNCJHJ(long EHDADNKLPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8193390", Offset = "0x8191F90", VA = "0x188193390")]
	[AsyncStateMachine(typeof(FAJIKLBBIFN))]
	private Task DLOGPBDOJKN(long EHDADNKLPJD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8192E50", Offset = "0x8191A50", VA = "0x188192E50")]
	private void AKHOEGCDJON(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8192EB0", Offset = "0x8191AB0", VA = "0x188192EB0")]
	private void BCDPBGNDMIH(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8193E50", Offset = "0x8192A50", VA = "0x188193E50")]
	private string GCCNNOOJGAF(string JKLHPHINKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x81959E0", Offset = "0x81945E0", VA = "0x1881959E0")]
	private void OPJCCJEMHJD(CEDIHIFCOLH CHHDCBDPDDB, string MEPFFFGIFGB, [Out] OINIAPKNLMK ENGJJKLDCIM, [Out] string BAOKIAELPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8194810", Offset = "0x8193410", VA = "0x188194810")]
	private OINIAPKNLMK JHNLMBBBKEB(CEDIHIFCOLH CHHDCBDPDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8195BB0", Offset = "0x81947B0", VA = "0x188195BB0", Slot = "8")]
	public bool PKNOFOJNECG(CEDIHIFCOLH CHHDCBDPDDB = CEDIHIFCOLH.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8195240", Offset = "0x8193E40", VA = "0x188195240", Slot = "9")]
	public bool NCMIIDBJLIA(string HGJNKBHNLKN, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x81952E0", Offset = "0x8193EE0", VA = "0x1881952E0", Slot = "10")]
	public bool NGDHICMOOLL(string HGJNKBHNLKN, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8194590", Offset = "0x8193190", VA = "0x188194590", Slot = "11")]
	public string HNOCPEAMCJK(string HGJNKBHNLKN, [Optional] string IPOLOHBNCGD, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8193EB0", Offset = "0x8192AB0", VA = "0x188193EB0", Slot = "12")]
	public BJDHHIAGNCN GHLBAMILBHM(string HGJNKBHNLKN, string OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8192F30", Offset = "0x8191B30", VA = "0x188192F30", Slot = "13")]
	public int BFMPKFJHGCJ(string HGJNKBHNLKN, int IPOLOHBNCGD = 0, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8193B10", Offset = "0x8192710", VA = "0x188193B10", Slot = "14")]
	public BJDHHIAGNCN FICPBHDNNAF(string HGJNKBHNLKN, int OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8193120", Offset = "0x8191D20", VA = "0x188193120", Slot = "15")]
	public bool CGMCIBEGCAA(string HGJNKBHNLKN, bool IPOLOHBNCGD, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x81937B0", Offset = "0x81923B0", VA = "0x1881937B0", Slot = "16")]
	public BJDHHIAGNCN ELJFFCBJOBC(string HGJNKBHNLKN, bool OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x81944E0", Offset = "0x81930E0", VA = "0x1881944E0", Slot = "17")]
	public float HMJPIBLDILG(string HGJNKBHNLKN, float IPOLOHBNCGD = 0f, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8194A50", Offset = "0x8193650", VA = "0x188194A50", Slot = "18")]
	public BJDHHIAGNCN JOBEBIMIBDP(string HGJNKBHNLKN, float OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8194F00", Offset = "0x8193B00", VA = "0x188194F00", Slot = "19")]
	public DateTime LMINNDCKKLA(string HGJNKBHNLKN, [Optional] DateTime IPOLOHBNCGD, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8193CB0", Offset = "0x81928B0", VA = "0x188193CB0", Slot = "20")]
	public BJDHHIAGNCN FOBPDGHPPLP(string HGJNKBHNLKN, DateTime OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8193050", Offset = "0x8191C50", VA = "0x188193050", Slot = "21")]
	public long BNKJIJINAAI(string HGJNKBHNLKN, long IPOLOHBNCGD = 0L, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8194190", Offset = "0x8192D90", VA = "0x188194190", Slot = "22")]
	public BJDHHIAGNCN HAFHBFINKEL(string HGJNKBHNLKN, long OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C87B10", Offset = "0x3C86710", VA = "0x183C87B10", Slot = "23")]
	public T LDOCMPOIJOD<T>(string HGJNKBHNLKN, [Optional] T IPOLOHBNCGD, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C87B10", Offset = "0x3C86710", VA = "0x183C87B10", Slot = "24")]
	public BJDHHIAGNCN LBCMHIJDLFD<T>(string HGJNKBHNLKN, T OOHGFGHCOAJ, CEDIHIFCOLH GCKHFKFNLLK = CEDIHIFCOLH.CLOUD)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8193330", Offset = "0x8191F30", VA = "0x188193330", Slot = "25")]
	public bool DHNPAIEOAJK(string HGJNKBHNLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8193B00", Offset = "0x8192700", VA = "0x188193B00", Slot = "26")]
	public bool FCDDJJMPBDI(string HGJNKBHNLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8192FE0", Offset = "0x8191BE0", VA = "0x188192FE0", Slot = "27")]
	public string BJJFJAFAEMD(string HGJNKBHNLKN, [Optional] string IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x81951A0", Offset = "0x8193DA0", VA = "0x1881951A0", Slot = "28")]
	public BJDHHIAGNCN MLDLAKDLMHB(string HGJNKBHNLKN, string OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8194890", Offset = "0x8193490", VA = "0x188194890", Slot = "29")]
	public int JJCFKIANGCF(string HGJNKBHNLKN, int IPOLOHBNCGD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x81930F0", Offset = "0x8191CF0", VA = "0x1881930F0", Slot = "30")]
	public BJDHHIAGNCN CAKMEBFJJKK(string HGJNKBHNLKN, int OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8194E90", Offset = "0x8193A90", VA = "0x188194E90", Slot = "31")]
	public bool LILLAFBGBOL(string HGJNKBHNLKN, bool IPOLOHBNCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8192E80", Offset = "0x8191A80", VA = "0x188192E80", Slot = "32")]
	public BJDHHIAGNCN BBIPJOJDLHF(string HGJNKBHNLKN, bool OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x81951D0", Offset = "0x8193DD0", VA = "0x1881951D0", Slot = "33")]
	public float MOCNPKEMICA(string HGJNKBHNLKN, float IPOLOHBNCGD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8195B80", Offset = "0x8194780", VA = "0x188195B80", Slot = "34")]
	public BJDHHIAGNCN PKCDDCMPKNM(string HGJNKBHNLKN, float OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8194BD0", Offset = "0x81937D0", VA = "0x188194BD0", Slot = "35")]
	public DateTime KFEOMCKNOIP(string HGJNKBHNLKN, [Optional] DateTime IPOLOHBNCGD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8194C40", Offset = "0x8193840", VA = "0x188194C40", Slot = "36")]
	public BJDHHIAGNCN KGHONANKFDJ(string HGJNKBHNLKN, DateTime OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8195540", Offset = "0x8194140", VA = "0x188195540", Slot = "37")]
	public long NNNNEFOFNPM(string HGJNKBHNLKN, long IPOLOHBNCGD = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8193C80", Offset = "0x8192880", VA = "0x188193C80", Slot = "38")]
	public BJDHHIAGNCN FLBDDBPANDM(string HGJNKBHNLKN, long OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8194630", Offset = "0x8193230", VA = "0x188194630")]
	private bool ICMDEPBAEPK(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8194030", Offset = "0x8192C30", VA = "0x188194030")]
	private bool GPNJHJMNFHO(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x81946C0", Offset = "0x81932C0", VA = "0x1881946C0")]
	private BJDHHIAGNCN JAHCFNJCCJN(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, string OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x81955B0", Offset = "0x81941B0", VA = "0x1881955B0")]
	private BJDHHIAGNCN OGMIJLGNAPJ(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, int OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8194300", Offset = "0x8192F00", VA = "0x188194300")]
	private BJDHHIAGNCN HHKDINNPJNI(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, bool OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8194900", Offset = "0x8193500", VA = "0x188194900")]
	private BJDHHIAGNCN JLGJONNNHBH(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, float OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8193640", Offset = "0x8192240", VA = "0x188193640")]
	private BJDHHIAGNCN EKNILKFEGMH(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, DateTime OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8193920", Offset = "0x8192520", VA = "0x188193920")]
	private BJDHHIAGNCN EMEBLCOJBDL(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, long OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3C86B00", Offset = "0x3C85700", VA = "0x183C86B00")]
	private T FNBOCHHEOGJ<T>(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, T IPOLOHBNCGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C87000", Offset = "0x3C85C00", VA = "0x183C87000")]
	private BJDHHIAGNCN JPOMBCBGDPN<T>(AKOCCDHEIIG ENGJJKLDCIM, string HGJNKBHNLKN, T OOHGFGHCOAJ)
	{
		return default(BJDHHIAGNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C86A70", Offset = "0x3C85670", VA = "0x183C86A70", Slot = "39")]
	public void FFAAABCMHLP<T>(POMHBPLMBPJ<T> JIMJOFGOGKG, [Optional] IEqualityComparer<T> DIMPLJBNCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C869F0", Offset = "0x3C855F0", VA = "0x183C869F0", Slot = "40")]
	public void BMCEDPDJAJM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8193260", Offset = "0x8191E60", VA = "0x188193260")]
	[AsyncStateMachine(typeof(BAFPPCEEAMB))]
	private void DGHJHJHJEOF(AKOCCDHEIIG OHILNNCMHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8193550", Offset = "0x8192150", VA = "0x188193550", Slot = "43")]
	[AsyncStateMachine(typeof(KNFIMFEKIGJ))]
	public Task EFNIAAHFFHM([Optional] CancellationToken HEDGIMBCGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8194FA0", Offset = "0x8193BA0", VA = "0x188194FA0")]
	private void MIGJKCKOEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8195460", Offset = "0x8194060", VA = "0x188195460", Slot = "41")]
	public IDisposable NLNKNABGAOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8192E70", Offset = "0x8191A70", VA = "0x188192E70", Slot = "42")]
	public void AOGADIELGKG(float KLCDLOHEBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x81956F0", Offset = "0x81942F0", VA = "0x1881956F0")]
	private void OIJNFIBGHLN(float KDLEABMHCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x81931D0", Offset = "0x8191DD0", VA = "0x1881931D0")]
	[IteratorStateMachine(typeof(BHAINBPCCKK))]
	private IEnumerator<FCPCPCAPDCM> CMLEMDJHCGJ(float KLCDLOHEBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8194690", Offset = "0x8193290", VA = "0x188194690")]
	[CompilerGenerated]
	private void INONOHLDJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BGKHLCFGDBD : JKEJPMNNMJN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static BGKHLCFGDBD LBPNLDGACAA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x818D3E0", Offset = "0x818BFE0", VA = "0x18818D3E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x818D430", Offset = "0x818C030", VA = "0x18818D430", Slot = "9")]
	public override string BLPDEIDOFHH(bool OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x818D520", Offset = "0x818C120", VA = "0x18818D520", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] bool OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x818D830", Offset = "0x818C430", VA = "0x18818D830")]
	public BGKHLCFGDBD()
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
