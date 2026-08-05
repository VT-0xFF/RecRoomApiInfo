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
		[Cpp2IlInjected.Address(RVA = "0x75884E0", Offset = "0x75872E0", VA = "0x1875884E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AGEDHBAJFAN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class NLCNKHCMBCL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void CJFKEHFJNBM(LEINENMJICN PMEDKLJCKMA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7586B90", Offset = "0x7585990", VA = "0x187586B90")]
	private static void FBAEEBDJIII(LEINENMJICN PMEDKLJCKMA, CJFKEHFJNBM BKKHFDMPACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7586D60", Offset = "0x7585B60", VA = "0x187586D60")]
	public static bool HGCIJCKAANM(this LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, [Optional] CJFKEHFJNBM BKKHFDMPACD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7586EC0", Offset = "0x7585CC0", VA = "0x187586EC0")]
	public static ENNNAPGDFDL MGINCAJOMFE(this LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, string IPHILEOFJLB, [Optional] CJFKEHFJNBM BKKHFDMPACD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7586660", Offset = "0x7585460", VA = "0x187586660")]
	public static ENNNAPGDFDL BJGEEDEJMJB(this LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, int IPHILEOFJLB, [Optional] CJFKEHFJNBM BKKHFDMPACD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75867A0", Offset = "0x75855A0", VA = "0x1875867A0")]
	public static ENNNAPGDFDL CIPGNDMGKLG(this LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, bool IPHILEOFJLB, [Optional] CJFKEHFJNBM BKKHFDMPACD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7586C10", Offset = "0x7585A10", VA = "0x187586C10")]
	public static ENNNAPGDFDL GELAHEDBBHL(this LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, float IPHILEOFJLB, [Optional] CJFKEHFJNBM BKKHFDMPACD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75868E0", Offset = "0x75856E0", VA = "0x1875868E0")]
	public static ENNNAPGDFDL ENKPKOAILGO(this LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, DateTime IPHILEOFJLB, [Optional] CJFKEHFJNBM BKKHFDMPACD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7586A50", Offset = "0x7585850", VA = "0x187586A50")]
	public static ENNNAPGDFDL EPCAAFPBPPF(this LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, long IPHILEOFJLB, [Optional] CJFKEHFJNBM BKKHFDMPACD)
	{
		return default(ENNNAPGDFDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BGKCNFJDNME : PHDMIIHGBCI, LEINENMJICN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JFEKNDCJGLN JFEPBDIHPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> LDJOGCOJDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> BADGNDIADDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> CJAJOAHFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7583510", Offset = "0x7582310", VA = "0x187583510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action JCFCKEHIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7584470", Offset = "0x7583270", VA = "0x187584470")]
	[UnityEngine.Scripting.Preserve]
	public BGKCNFJDNME([MHFJPMCEEAM(null)] JFEKNDCJGLN JFEPBDIHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "8")]
	public void OBCKEHHIILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7583F70", Offset = "0x7582D70", VA = "0x187583F70")]
	private DirectoryInfo MPGAMLNBGJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7583550", Offset = "0x7582350", VA = "0x187583550", Slot = "6")]
	public Task GEGDEEKNIAM(long BCLPNMCELJC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7584390", Offset = "0x7583190", VA = "0x187584390", Slot = "14")]
	public float PIJLIOKFGDD(string FFOHLCGHDKA, float KBHDDKCAINE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75830E0", Offset = "0x7581EE0", VA = "0x1875830E0", Slot = "13")]
	public void BCOOJCCDMMF(string FFOHLCGHDKA, bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7584070", Offset = "0x7582E70", VA = "0x187584070", Slot = "12")]
	public bool NAJOIKINJLP(string FFOHLCGHDKA, bool KBHDDKCAINE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7584320", Offset = "0x7583120", VA = "0x187584320", Slot = "10")]
	public int PCCCIKMEHOJ(string FFOHLCGHDKA, int KBHDDKCAINE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75834A0", Offset = "0x75822A0", VA = "0x1875834A0", Slot = "18")]
	public DateTime ELAJJFGHCNM(string FINLDKJJAEK, [Optional] DateTime KBHDDKCAINE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7583F00", Offset = "0x7582D00", VA = "0x187583F00", Slot = "19")]
	public void MOLPMFHMGPM(string FFOHLCGHDKA, DateTime IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75842B0", Offset = "0x75830B0", VA = "0x1875842B0", Slot = "15")]
	public void OKPMDHIFNGK(string FFOHLCGHDKA, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7583A60", Offset = "0x7582860", VA = "0x187583A60", Slot = "11")]
	public void KONOAAGFCAI(string FFOHLCGHDKA, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7584240", Offset = "0x7583040", VA = "0x187584240", Slot = "20")]
	public long ODEIFBDDELN(string FINLDKJJAEK, long KBHDDKCAINE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7584400", Offset = "0x7583200", VA = "0x187584400", Slot = "21")]
	public void PLBCFJAIDDI(string FINLDKJJAEK, long IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30738B0", Offset = "0x30726B0", VA = "0x1830738B0", Slot = "22")]
	public T IDELLLJDACN<T>(string FINLDKJJAEK, T KBHDDKCAINE, LOKNJIEHMMB<T> GMOCOKJMELP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x30738B0", Offset = "0x30726B0", VA = "0x1830738B0", Slot = "23")]
	public void EJHMNMGDMKN<T>(string FINLDKJJAEK, T IPHILEOFJLB, LOKNJIEHMMB<T> GMOCOKJMELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75835E0", Offset = "0x75823E0", VA = "0x1875835E0", Slot = "16")]
	public string IHPEODFPIEC(string FFOHLCGHDKA, string KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7583E90", Offset = "0x7582C90", VA = "0x187583E90", Slot = "17")]
	public void LPGHCAPNFAG(string FFOHLCGHDKA, string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7583150", Offset = "0x7581F50", VA = "0x187583150", Slot = "24")]
	public void BFIDGNFDCAK(string FFOHLCGHDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75839D0", Offset = "0x75827D0", VA = "0x1875839D0", Slot = "9")]
	public bool KEAMFLOOAEL(string FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7583690", Offset = "0x7582490", VA = "0x187583690", Slot = "25")]
	public Task IONCLBALKEM(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7583AD0", Offset = "0x75828D0", VA = "0x187583AD0")]
	private void LDEEFOPGKIG(DirectoryInfo HDBADIJDBOG, string HFCBDECNGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75832A0", Offset = "0x75820A0", VA = "0x1875832A0")]
	private static string DBBPBCMNCKK(string FFOHLCGHDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7584140", Offset = "0x7582F40", VA = "0x187584140")]
	private static string NDBNMJKJPDO(byte[] MDJJEFJEKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3071200", Offset = "0x3070000", VA = "0x183071200")]
	private T ANFJBBFMPMK<T>(string FINLDKJJAEK, T KBHDDKCAINE, [Optional] LOKNJIEHMMB<T> BBNDDPIDNBI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3072520", Offset = "0x3071320", VA = "0x183072520")]
	private void DJKOKNNCNMK<T>(string FINLDKJJAEK, T IPHILEOFJLB, [Optional] LOKNJIEHMMB<T> BBNDDPIDNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75828E0", Offset = "0x75816E0", VA = "0x1875828E0")]
	private Dictionary<string, string> AMOPGEMIGCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class AKBFFGBJFLA
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7582790", Offset = "0x7581590", VA = "0x187582790")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void PIKBCINMJOC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CNAHIKMAGGP : IHNAPANLBDD
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7584A40", Offset = "0x7583840", VA = "0x187584A40")]
	[UnityEngine.Scripting.Preserve]
	public CNAHIKMAGGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IHNAPANLBDD : PHDMIIHGBCI, LEINENMJICN, COBLKIMIFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> OAGACEIBEFJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JCFCKEHIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "8")]
	public void OBCKEHHIILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7585680", Offset = "0x7584480", VA = "0x187585680", Slot = "6")]
	public Task GEGDEEKNIAM(long BCLPNMCELJC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7585800", Offset = "0x7584600", VA = "0x187585800", Slot = "9")]
	public bool KEAMFLOOAEL(string FINLDKJJAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7585AA0", Offset = "0x75848A0", VA = "0x187585AA0", Slot = "10")]
	public int PCCCIKMEHOJ(string FINLDKJJAEK, int KBHDDKCAINE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7585860", Offset = "0x7584660", VA = "0x187585860", Slot = "11")]
	public void KONOAAGFCAI(string FINLDKJJAEK, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7585980", Offset = "0x7584780", VA = "0x187585980", Slot = "12")]
	public bool NAJOIKINJLP(string FINLDKJJAEK, bool KBHDDKCAINE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7585560", Offset = "0x7584360", VA = "0x187585560", Slot = "13")]
	public void BCOOJCCDMMF(string FINLDKJJAEK, bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7585B00", Offset = "0x7584900", VA = "0x187585B00", Slot = "14")]
	public float PIJLIOKFGDD(string FINLDKJJAEK, float KBHDDKCAINE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7585A40", Offset = "0x7584840", VA = "0x187585A40", Slot = "15")]
	public void OKPMDHIFNGK(string FINLDKJJAEK, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7585710", Offset = "0x7584510", VA = "0x187585710", Slot = "16")]
	public string IHPEODFPIEC(string FINLDKJJAEK, [Optional] string KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x75858C0", Offset = "0x75846C0", VA = "0x1875858C0", Slot = "17")]
	public void LPGHCAPNFAG(string FINLDKJJAEK, string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7585620", Offset = "0x7584420", VA = "0x187585620", Slot = "18")]
	public DateTime ELAJJFGHCNM(string FINLDKJJAEK, [Optional] DateTime KBHDDKCAINE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7585920", Offset = "0x7584720", VA = "0x187585920", Slot = "19")]
	public void MOLPMFHMGPM(string FINLDKJJAEK, DateTime IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75859E0", Offset = "0x75847E0", VA = "0x1875859E0", Slot = "20")]
	public long ODEIFBDDELN(string FINLDKJJAEK, long KBHDDKCAINE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7585B60", Offset = "0x7584960", VA = "0x187585B60", Slot = "21")]
	public void PLBCFJAIDDI(string FINLDKJJAEK, long IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x32EE4D0", Offset = "0x32ED2D0", VA = "0x1832EE4D0", Slot = "22")]
	public T IDELLLJDACN<T>(string FINLDKJJAEK, T KBHDDKCAINE, LOKNJIEHMMB<T> GMOCOKJMELP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x32EE3F0", Offset = "0x32ED1F0", VA = "0x1832EE3F0", Slot = "23")]
	public void EJHMNMGDMKN<T>(string FINLDKJJAEK, T IPHILEOFJLB, LOKNJIEHMMB<T> GMOCOKJMELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x32ED660", Offset = "0x32EC460", VA = "0x1832ED660")]
	public T ANFJBBFMPMK<T>(string FINLDKJJAEK, T KBHDDKCAINE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x32EDF00", Offset = "0x32ECD00", VA = "0x1832EDF00")]
	public void DJKOKNNCNMK<T>(string FINLDKJJAEK, T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x75855C0", Offset = "0x75843C0", VA = "0x1875855C0", Slot = "24")]
	public void BFIDGNFDCAK(string FINLDKJJAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7585770", Offset = "0x7584570", VA = "0x187585770", Slot = "25")]
	public Task IONCLBALKEM(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7584A40", Offset = "0x7583840", VA = "0x187584A40")]
	public IHNAPANLBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class JMMIDALNJOC<TParent> where TParent : LEINENMJICN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<JMMIDALNJOC<TParent>> HHLMPCOGPDK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x48D3B20", Offset = "0x48D2920", VA = "0x1848D3B20")]
	protected JMMIDALNJOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void NCEIDOKFHPG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FHLLEBPKBPO(string FFOHLCGHDKA);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x48D3570", Offset = "0x48D2370", VA = "0x1848D3570")]
	public static void BAFNHDKGCAL(string FFOHLCGHDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x48D37B0", Offset = "0x48D25B0", VA = "0x1848D37B0")]
	public static void LOIOKLLCCMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CIHHCOFIHFC<TParent, TValue> : JMMIDALNJOC<TParent> where TParent : LEINENMJICN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CIHHCOFIHFC<TParent, TValue> KPNHHCMCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> GECKGHIFNKM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x59648A0", Offset = "0x59636A0", VA = "0x1859648A0")]
	public bool MHAMFDPPPMK(string PADNBEPNLIP, [Out] TValue IAEEGOAMIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5964740", Offset = "0x5963540", VA = "0x185964740")]
	public void ACCDHPCGIDC(string PADNBEPNLIP, TValue IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2E50", Offset = "0x3FF1C50", VA = "0x183FF2E50", Slot = "4")]
	protected override void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x44D12C0", Offset = "0x44D00C0", VA = "0x1844D12C0", Slot = "5")]
	protected override void FHLLEBPKBPO(string PADNBEPNLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5964A40", Offset = "0x5963840", VA = "0x185964A40")]
	public CIHHCOFIHFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LEINENMJICN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBCKEHHIILA();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEAMFLOOAEL(string FINLDKJJAEK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PCCCIKMEHOJ(string FINLDKJJAEK, int KBHDDKCAINE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KONOAAGFCAI(string FINLDKJJAEK, int IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NAJOIKINJLP(string FINLDKJJAEK, bool KBHDDKCAINE = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BCOOJCCDMMF(string FINLDKJJAEK, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float PIJLIOKFGDD(string FINLDKJJAEK, float KBHDDKCAINE = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKPMDHIFNGK(string FINLDKJJAEK, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string IHPEODFPIEC(string FINLDKJJAEK, [Optional] string KBHDDKCAINE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LPGHCAPNFAG(string FINLDKJJAEK, string IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime ELAJJFGHCNM(string FINLDKJJAEK, [Optional] DateTime DODEFIJMOPJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MOLPMFHMGPM(string FINLDKJJAEK, DateTime DODEFIJMOPJ);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long ODEIFBDDELN(string FINLDKJJAEK, long KBHDDKCAINE);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PLBCFJAIDDI(string FINLDKJJAEK, long IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T IDELLLJDACN<T>(string FINLDKJJAEK, T KBHDDKCAINE, LOKNJIEHMMB<T> GMOCOKJMELP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EJHMNMGDMKN<T>(string FINLDKJJAEK, T IPHILEOFJLB, LOKNJIEHMMB<T> GMOCOKJMELP);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BFIDGNFDCAK(string FINLDKJJAEK);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task IONCLBALKEM([Optional] CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PHDMIIHGBCI : LEINENMJICN
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JCFCKEHIGKI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GEGDEEKNIAM(long BCLPNMCELJC, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface COBLKIMIFAO : LEINENMJICN
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FCGGIEKIBHC : PHDMIIHGBCI, LEINENMJICN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NMKCEINKKIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FCGGIEKIBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7587010", Offset = "0x7585E10", VA = "0x187587010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75873E0", Offset = "0x75861E0", VA = "0x1875873E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PLBCMNIOGHM : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FCGGIEKIBHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public PLBCMNIOGHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7588330", Offset = "0x7587130", VA = "0x187588330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75883A0", Offset = "0x75871A0", VA = "0x1875883A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JFEKNDCJGLN JFEPBDIHPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LBBODLIIALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool CLOPPBBJIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JACPPMCDBFA DDHBLBIAMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private CPMKHKOAIIG KNHJCILNKDE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JCFCKEHIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x75852E0", Offset = "0x75840E0", VA = "0x1875852E0")]
	[UnityEngine.Scripting.Preserve]
	public FCGGIEKIBHC([MHFJPMCEEAM(null)] JFEKNDCJGLN JFEPBDIHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "8")]
	public void OBCKEHHIILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7584CC0", Offset = "0x7583AC0", VA = "0x187584CC0", Slot = "6")]
	public Task GEGDEEKNIAM(long BCLPNMCELJC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x18AE600", Offset = "0x18AD400", VA = "0x1818AE600")]
	private static int NKKDKKKCGHH(bool IPHILEOFJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7584FB0", Offset = "0x7583DB0", VA = "0x187584FB0", Slot = "9")]
	public bool KEAMFLOOAEL(string FINLDKJJAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7585210", Offset = "0x7584010", VA = "0x187585210", Slot = "10")]
	public int PCCCIKMEHOJ(string FINLDKJJAEK, int KBHDDKCAINE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7584FD0", Offset = "0x7583DD0", VA = "0x187584FD0", Slot = "11")]
	public void KONOAAGFCAI(string FINLDKJJAEK, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7585140", Offset = "0x7583F40", VA = "0x187585140", Slot = "12")]
	public bool NAJOIKINJLP(string FINLDKJJAEK, bool KBHDDKCAINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7584B70", Offset = "0x7583970", VA = "0x187584B70", Slot = "13")]
	public void BCOOJCCDMMF(string FINLDKJJAEK, bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7585240", Offset = "0x7584040", VA = "0x187585240", Slot = "14")]
	public float PIJLIOKFGDD(string FINLDKJJAEK, float KBHDDKCAINE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75851E0", Offset = "0x7583FE0", VA = "0x1875851E0", Slot = "15")]
	public void OKPMDHIFNGK(string FINLDKJJAEK, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7584C30", Offset = "0x7583A30", VA = "0x187584C30", Slot = "18")]
	public DateTime ELAJJFGHCNM(string FINLDKJJAEK, [Optional] DateTime KBHDDKCAINE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x75850B0", Offset = "0x7583EB0", VA = "0x1875850B0", Slot = "19")]
	public void MOLPMFHMGPM(string FINLDKJJAEK, DateTime DODEFIJMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7585170", Offset = "0x7583F70", VA = "0x187585170", Slot = "20")]
	public long ODEIFBDDELN(string FINLDKJJAEK, long KBHDDKCAINE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7585270", Offset = "0x7584070", VA = "0x187585270", Slot = "21")]
	public void PLBCFJAIDDI(string FINLDKJJAEK, long IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3294410", Offset = "0x3293210", VA = "0x183294410", Slot = "22")]
	public T IDELLLJDACN<T>(string FINLDKJJAEK, T KBHDDKCAINE, LOKNJIEHMMB<T> GMOCOKJMELP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3294410", Offset = "0x3293210", VA = "0x183294410", Slot = "23")]
	public void EJHMNMGDMKN<T>(string FINLDKJJAEK, T IPHILEOFJLB, LOKNJIEHMMB<T> GMOCOKJMELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3294E60", Offset = "0x3293C60", VA = "0x183294E60")]
	private T KMBFINDEGAF<T>(string FINLDKJJAEK, T KBHDDKCAINE, [Optional] LOKNJIEHMMB<T> BBNDDPIDNBI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3294710", Offset = "0x3293510", VA = "0x183294710")]
	private void JHMEBKCPGGJ<T>(string FINLDKJJAEK, T IPHILEOFJLB, [Optional] LOKNJIEHMMB<T> BBNDDPIDNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7584E30", Offset = "0x7583C30", VA = "0x187584E30", Slot = "16")]
	public string IHPEODFPIEC(string FINLDKJJAEK, string KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7585000", Offset = "0x7583E00", VA = "0x187585000", Slot = "17")]
	public void LPGHCAPNFAG(string FINLDKJJAEK, string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7585120", Offset = "0x7583F20", VA = "0x187585120")]
	private void NABALOKEEOL(string FINLDKJJAEK, string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7584CA0", Offset = "0x7583AA0", VA = "0x187584CA0")]
	private string FEBGIIANNHB(string FINLDKJJAEK, string KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7584BA0", Offset = "0x75839A0", VA = "0x187584BA0", Slot = "24")]
	public void BFIDGNFDCAK(string FINLDKJJAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7584AD0", Offset = "0x75838D0", VA = "0x187584AD0")]
	private string ACCPGPBLDBC(string FFOHLCGHDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7584E60", Offset = "0x7583C60", VA = "0x187584E60", Slot = "25")]
	[AsyncStateMachine(typeof(NMKCEINKKIL))]
	public Task IONCLBALKEM(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7585030", Offset = "0x7583E30", VA = "0x187585030")]
	[IteratorStateMachine(typeof(PLBCMNIOGHM))]
	private IEnumerator<HLGDLHCLDFE> MJABMEPEJJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7584F50", Offset = "0x7583D50", VA = "0x187584F50")]
	private void JFBCFKCJFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7584DC0", Offset = "0x7583BC0", VA = "0x187584DC0")]
	private void GGDNFLEBGAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7584D50", Offset = "0x7583B50", VA = "0x187584D50")]
	private void GGCAGLMNHIO(bool EGBNLPCEAKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OOKPNOLLEFH : PHDMIIHGBCI, LEINENMJICN
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
	private Dictionary<string, string> BADGNDIADDE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string MHNPKJIKDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75879C0", Offset = "0x75867C0", VA = "0x1875879C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> CJAJOAHFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7587A30", Offset = "0x7586830", VA = "0x187587A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action JCFCKEHIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	[UnityEngine.Scripting.Preserve]
	public OOKPNOLLEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "8")]
	public void OBCKEHHIILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7587A70", Offset = "0x7586870", VA = "0x187587A70", Slot = "6")]
	public Task GEGDEEKNIAM(long BCLPNMCELJC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7588250", Offset = "0x7587050", VA = "0x187588250", Slot = "14")]
	public float PIJLIOKFGDD(string FFOHLCGHDKA, float KBHDDKCAINE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7587820", Offset = "0x7586620", VA = "0x187587820", Slot = "13")]
	public void BCOOJCCDMMF(string FFOHLCGHDKA, bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7588030", Offset = "0x7586E30", VA = "0x187588030", Slot = "12")]
	public bool NAJOIKINJLP(string FFOHLCGHDKA, bool KBHDDKCAINE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x75881E0", Offset = "0x7586FE0", VA = "0x1875881E0", Slot = "10")]
	public int PCCCIKMEHOJ(string FFOHLCGHDKA, int KBHDDKCAINE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7587950", Offset = "0x7586750", VA = "0x187587950", Slot = "18")]
	public DateTime ELAJJFGHCNM(string FINLDKJJAEK, [Optional] DateTime KBHDDKCAINE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7587FC0", Offset = "0x7586DC0", VA = "0x187587FC0", Slot = "19")]
	public void MOLPMFHMGPM(string FFOHLCGHDKA, DateTime IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7588170", Offset = "0x7586F70", VA = "0x187588170", Slot = "15")]
	public void OKPMDHIFNGK(string FFOHLCGHDKA, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7587EB0", Offset = "0x7586CB0", VA = "0x187587EB0", Slot = "11")]
	public void KONOAAGFCAI(string FFOHLCGHDKA, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7588100", Offset = "0x7586F00", VA = "0x187588100", Slot = "20")]
	public long ODEIFBDDELN(string FINLDKJJAEK, long KBHDDKCAINE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x75882C0", Offset = "0x75870C0", VA = "0x1875882C0", Slot = "21")]
	public void PLBCFJAIDDI(string FINLDKJJAEK, long IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30738B0", Offset = "0x30726B0", VA = "0x1830738B0", Slot = "22")]
	public T IDELLLJDACN<T>(string FINLDKJJAEK, T KBHDDKCAINE, LOKNJIEHMMB<T> GMOCOKJMELP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x30738B0", Offset = "0x30726B0", VA = "0x1830738B0", Slot = "23")]
	public void EJHMNMGDMKN<T>(string FINLDKJJAEK, T IPHILEOFJLB, LOKNJIEHMMB<T> GMOCOKJMELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7587B00", Offset = "0x7586900", VA = "0x187587B00", Slot = "16")]
	public string IHPEODFPIEC(string FFOHLCGHDKA, string KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7587F20", Offset = "0x7586D20", VA = "0x187587F20", Slot = "17")]
	public void LPGHCAPNFAG(string FFOHLCGHDKA, string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7587890", Offset = "0x7586690", VA = "0x187587890", Slot = "24")]
	public void BFIDGNFDCAK(string FFOHLCGHDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7587E20", Offset = "0x7586C20", VA = "0x187587E20", Slot = "9")]
	public bool KEAMFLOOAEL(string FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7587BB0", Offset = "0x75869B0", VA = "0x187587BB0", Slot = "25")]
	public Task IONCLBALKEM(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3496CB0", Offset = "0x3495AB0", VA = "0x183496CB0")]
	private T ANFJBBFMPMK<T>(string FINLDKJJAEK, T KBHDDKCAINE, [Optional] LOKNJIEHMMB<T> BBNDDPIDNBI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3497FD0", Offset = "0x3496DD0", VA = "0x183497FD0")]
	private void DJKOKNNCNMK<T>(string FINLDKJJAEK, T IPHILEOFJLB, [Optional] LOKNJIEHMMB<T> BBNDDPIDNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7587520", Offset = "0x7586320", VA = "0x187587520")]
	private Dictionary<string, string> AMOPGEMIGCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PIDAIGGFAFH
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action JCFCKEHIGKI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBCKEHHIILA();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PKHKFCAENKO(long BCLPNMCELJC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MEBOPDAFCJC(AGEDHBAJFAN LHKCOJICKJI = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BENMOEIDCAO(string FINLDKJJAEK, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EMIHGHJOBEK(string FINLDKJJAEK, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string CKHBLBCDPFH(string FINLDKJJAEK, [Optional] string KBHDDKCAINE, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ENNNAPGDFDL KMLKBHELFNP(string FINLDKJJAEK, string IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int FHDJBLKKBOB(string FINLDKJJAEK, int KBHDDKCAINE = 0, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ENNNAPGDFDL DOOONBBLPKO(string FINLDKJJAEK, int IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MAKLOHPGHJJ(string FINLDKJJAEK, bool KBHDDKCAINE, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ENNNAPGDFDL NIHAOKMCPKJ(string FINLDKJJAEK, bool IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float GLNIMAOEIGP(string FINLDKJJAEK, float KBHDDKCAINE = 0f, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ENNNAPGDFDL HMKIFPNFBNA(string FINLDKJJAEK, float IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime AAINCOOCLHK(string FINLDKJJAEK, [Optional] DateTime KBHDDKCAINE, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	ENNNAPGDFDL BAJKILCEDJB(string FINLDKJJAEK, DateTime IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long MAGBJABEIHN(string FINLDKJJAEK, long KBHDDKCAINE = 0L, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ENNNAPGDFDL BOHFINFPEFP(string FINLDKJJAEK, long IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T EOCOPDHOBCE<T>(string FINLDKJJAEK, [Optional] T KBHDDKCAINE, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	ENNNAPGDFDL MMNONKIHBAH<T>(string FINLDKJJAEK, T IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool GKGEJKGGOHO(string FINLDKJJAEK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool FMEJIKNBCHF(string FINLDKJJAEK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string OFCBFGLDDNJ(string FINLDKJJAEK, [Optional] string KBHDDKCAINE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ENNNAPGDFDL JCDJNNGBBCO(string FINLDKJJAEK, string IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int ADGLIBCHFDL(string FINLDKJJAEK, int KBHDDKCAINE = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	ENNNAPGDFDL KMIFPDLLABD(string FINLDKJJAEK, int IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IHLODDBJBDH(string FINLDKJJAEK, bool KBHDDKCAINE);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	ENNNAPGDFDL IHPEJCBNDAP(string FINLDKJJAEK, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float OICBCDALJMA(string FINLDKJJAEK, float KBHDDKCAINE = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	ENNNAPGDFDL PIELENLLGNO(string FINLDKJJAEK, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime NHNLKBGMGBL(string FINLDKJJAEK, [Optional] DateTime KBHDDKCAINE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	ENNNAPGDFDL JIKOODBBNPC(string FINLDKJJAEK, DateTime IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long LEBIDACCAGA(string FINLDKJJAEK, long KBHDDKCAINE = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	ENNNAPGDFDL KMBGHMPPBPL(string FINLDKJJAEK, long IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LOOGJKIBFGD<T>(LOKNJIEHMMB<T> GMOCOKJMELP, [Optional] IEqualityComparer<T> LKDCBGBNMHJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ILJJHFGDDCI<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable LKKAPKNFIGF();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PPBMPAJJILC(float CIOLBCCFHKE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task JFBCFKCJFGN([Optional] CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum ENNNAPGDFDL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AJMNDJBEPNC : PIDAIGGFAFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class LLLPCPJDAFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<LLLPCPJDAFL> IIFNGJHFFND;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7585FF0", Offset = "0x7584DF0", VA = "0x187585FF0")]
		public static void LOIOKLLCCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void NCEIDOKFHPG();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		protected LLLPCPJDAFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class KLDKHMIJEGP<T> : LLLPCPJDAFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly KLDKHMIJEGP<T> GGJCMHODIEM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LOKNJIEHMMB<T> AHIEPELGIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> KBCPGCGMHID
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CLBLMINNIAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3F5D8F0", Offset = "0x3F5C6F0", VA = "0x183F5D8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x49D3290", Offset = "0x49D2090", VA = "0x1849D3290")]
		private KLDKHMIJEGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x49D2D60", Offset = "0x49D1B60", VA = "0x1849D2D60")]
		public void EHDMJEMLBPD(LOKNJIEHMMB<T> BBNDDPIDNBI, [Optional] IEqualityComparer<T> LKDCBGBNMHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x49D30C0", Offset = "0x49D1EC0", VA = "0x1849D30C0", Slot = "4")]
		public override void NCEIDOKFHPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class KGFPDEDJGNB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly AJMNDJBEPNC KNMJFDABFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object BPNJOBDALBG;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7585BF0", Offset = "0x75849F0", VA = "0x187585BF0")]
		public KGFPDEDJGNB(AJMNDJBEPNC KNMJFDABFOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7585BC0", Offset = "0x75849C0", VA = "0x187585BC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LEEDJEMAHCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AJMNDJBEPNC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7585CA0", Offset = "0x7584AA0", VA = "0x187585CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7585F90", Offset = "0x7584D90", VA = "0x187585F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct IFOLOBDMGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AJMNDJBEPNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LEINENMJICN backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x75853D0", Offset = "0x75841D0", VA = "0x1875853D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct CDAKCCHCNLD : IAsyncStateMachine
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
		public AJMNDJBEPNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7584510", Offset = "0x7583310", VA = "0x187584510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x75849E0", Offset = "0x75837E0", VA = "0x1875849E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OKGCNAGMJEC : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AJMNDJBEPNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public OKGCNAGMJEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7587440", Offset = "0x7586240", VA = "0x187587440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x75874D0", Offset = "0x75862D0", VA = "0x1875874D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PHDMIIHGBCI IKCFNKJJHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly PHDMIIHGBCI JFIILJDNLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly COBLKIMIFAO MAPAGBGGNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JACPPMCDBFA DDHBLBIAMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NLCNKHCMBCL.CJFKEHFJNBM BKKHFDMPACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly LKPBNFNIBPJ EBGKCCMDACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<LEINENMJICN> AAMMAPBFPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task GCBPKLCEMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> ILCPIFOAHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CPMKHKOAIIG KCHOGEBCKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object BBMNIKLMLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object BOJFLNPEEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long GJEHFAMBCNN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool DEHANCFODND
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7580750", Offset = "0x757F550", VA = "0x187580750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource DFBIJLCOMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3030", VA = "0x1808F4230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8F4250", Offset = "0x8F3050", VA = "0x1808F4250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action JCFCKEHIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7581F30", Offset = "0x7580D30", VA = "0x187581F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7581C20", Offset = "0x7580A20", VA = "0x187581C20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7581030", Offset = "0x757FE30", VA = "0x187581030")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void LHLKGADJEGF(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x75823C0", Offset = "0x75811C0", VA = "0x1875823C0")]
	[UnityEngine.Scripting.Preserve]
	public AJMNDJBEPNC([MHFJPMCEEAM("Disk")] PHDMIIHGBCI IKCFNKJJHJD, [MHFJPMCEEAM("Cloud")] PHDMIIHGBCI JFIILJDNLLH, [MHFJPMCEEAM(null)] COBLKIMIFAO MAPAGBGGNCN, [MHFJPMCEEAM(null)] JACPPMCDBFA DDHBLBIAMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x75801A0", Offset = "0x757EFA0", VA = "0x1875801A0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x757FDF0", Offset = "0x757EBF0", VA = "0x18757FDF0")]
	private void CHIKCIBAJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7581FD0", Offset = "0x7580DD0", VA = "0x187581FD0", Slot = "6")]
	public void OBCKEHHIILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x75821E0", Offset = "0x7580FE0", VA = "0x1875821E0", Slot = "7")]
	public Task PKHKFCAENKO(long BCLPNMCELJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7581B10", Offset = "0x7580910", VA = "0x187581B10")]
	[AsyncStateMachine(typeof(LEEDJEMAHCK))]
	private Task NMCEAJMGGEB(long BCLPNMCELJC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x757F8B0", Offset = "0x757E6B0", VA = "0x18757F8B0")]
	private void ALGELKIEBFG(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7581550", Offset = "0x7580350", VA = "0x187581550")]
	private void MDAAAEBEDED(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x75804A0", Offset = "0x757F2A0", VA = "0x1875804A0")]
	private string FALAAMLFNJE(string DGBGJGEODOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7580BE0", Offset = "0x757F9E0", VA = "0x187580BE0")]
	private void KCDOKLKOFCI(AGEDHBAJFAN LHKCOJICKJI, string FFOHLCGHDKA, [Out] PHDMIIHGBCI PMEDKLJCKMA, [Out] string BDBFABHIACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7580500", Offset = "0x757F300", VA = "0x187580500")]
	private PHDMIIHGBCI FAPFOGCPINK(AGEDHBAJFAN LHKCOJICKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x75815D0", Offset = "0x75803D0", VA = "0x1875815D0", Slot = "8")]
	public bool MEBOPDAFCJC(AGEDHBAJFAN LHKCOJICKJI = AGEDHBAJFAN.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x757FA70", Offset = "0x757E870", VA = "0x18757FA70", Slot = "9")]
	public bool BENMOEIDCAO(string FINLDKJJAEK, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7580320", Offset = "0x757F120", VA = "0x187580320", Slot = "10")]
	public bool EMIHGHJOBEK(string FINLDKJJAEK, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x757FE40", Offset = "0x757EC40", VA = "0x18757FE40", Slot = "11")]
	public string CKHBLBCDPFH(string FINLDKJJAEK, [Optional] string KBHDDKCAINE, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7580DE0", Offset = "0x757FBE0", VA = "0x187580DE0", Slot = "12")]
	public ENNNAPGDFDL KMLKBHELFNP(string FINLDKJJAEK, string IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7580580", Offset = "0x757F380", VA = "0x187580580", Slot = "13")]
	public int FHDJBLKKBOB(string FINLDKJJAEK, int KBHDDKCAINE = 0, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7580030", Offset = "0x757EE30", VA = "0x187580030", Slot = "14")]
	public ENNNAPGDFDL DOOONBBLPKO(string FINLDKJJAEK, int IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7581360", Offset = "0x7580160", VA = "0x187581360", Slot = "15")]
	public bool MAKLOHPGHJJ(string FINLDKJJAEK, bool KBHDDKCAINE, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x75819A0", Offset = "0x75807A0", VA = "0x1875819A0", Slot = "16")]
	public ENNNAPGDFDL NIHAOKMCPKJ(string FINLDKJJAEK, bool IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x75806A0", Offset = "0x757F4A0", VA = "0x1875806A0", Slot = "17")]
	public float GLNIMAOEIGP(string FINLDKJJAEK, float KBHDDKCAINE = 0f, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7580770", Offset = "0x757F570", VA = "0x187580770", Slot = "18")]
	public ENNNAPGDFDL HMKIFPNFBNA(string FINLDKJJAEK, float IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x757F5C0", Offset = "0x757E3C0", VA = "0x18757F5C0", Slot = "19")]
	public DateTime AAINCOOCLHK(string FINLDKJJAEK, [Optional] DateTime KBHDDKCAINE, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x757F8D0", Offset = "0x757E6D0", VA = "0x18757F8D0", Slot = "20")]
	public ENNNAPGDFDL BAJKILCEDJB(string FINLDKJJAEK, DateTime IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x75812C0", Offset = "0x75800C0", VA = "0x1875812C0", Slot = "21")]
	public long MAGBJABEIHN(string FINLDKJJAEK, long KBHDDKCAINE = 0L, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x757FB10", Offset = "0x757E910", VA = "0x18757FB10", Slot = "22")]
	public ENNNAPGDFDL BOHFINFPEFP(string FINLDKJJAEK, long IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A2EFB0", Offset = "0x3A2DDB0", VA = "0x183A2EFB0", Slot = "23")]
	public T EOCOPDHOBCE<T>(string FINLDKJJAEK, [Optional] T KBHDDKCAINE, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A2EFB0", Offset = "0x3A2DDB0", VA = "0x183A2EFB0", Slot = "24")]
	public ENNNAPGDFDL MMNONKIHBAH<T>(string FINLDKJJAEK, T IPHILEOFJLB, AGEDHBAJFAN INHLONEBDGD = AGEDHBAJFAN.CLOUD)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7580640", Offset = "0x757F440", VA = "0x187580640", Slot = "25")]
	public bool GKGEJKGGOHO(string FINLDKJJAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7580630", Offset = "0x757F430", VA = "0x187580630", Slot = "26")]
	public bool FMEJIKNBCHF(string FINLDKJJAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7582040", Offset = "0x7580E40", VA = "0x187582040", Slot = "27")]
	public string OFCBFGLDDNJ(string FINLDKJJAEK, [Optional] string KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7580A90", Offset = "0x757F890", VA = "0x187580A90", Slot = "28")]
	public ENNNAPGDFDL JCDJNNGBBCO(string FINLDKJJAEK, string IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x757F660", Offset = "0x757E460", VA = "0x18757F660", Slot = "29")]
	public int ADGLIBCHFDL(string FINLDKJJAEK, int KBHDDKCAINE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7580DB0", Offset = "0x757FBB0", VA = "0x187580DB0", Slot = "30")]
	public ENNNAPGDFDL KMIFPDLLABD(string FINLDKJJAEK, int IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x75808F0", Offset = "0x757F6F0", VA = "0x1875808F0", Slot = "31")]
	public bool IHLODDBJBDH(string FINLDKJJAEK, bool KBHDDKCAINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7580960", Offset = "0x757F760", VA = "0x187580960", Slot = "32")]
	public ENNNAPGDFDL IHPEJCBNDAP(string FINLDKJJAEK, bool IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x75820B0", Offset = "0x7580EB0", VA = "0x1875820B0", Slot = "33")]
	public float OICBCDALJMA(string FINLDKJJAEK, float KBHDDKCAINE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7582120", Offset = "0x7580F20", VA = "0x187582120", Slot = "34")]
	public ENNNAPGDFDL PIELENLLGNO(string FINLDKJJAEK, float IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7581930", Offset = "0x7580730", VA = "0x187581930", Slot = "35")]
	public DateTime NHNLKBGMGBL(string FINLDKJJAEK, [Optional] DateTime KBHDDKCAINE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7580BB0", Offset = "0x757F9B0", VA = "0x187580BB0", Slot = "36")]
	public ENNNAPGDFDL JIKOODBBNPC(string FINLDKJJAEK, DateTime IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7580FC0", Offset = "0x757FDC0", VA = "0x187580FC0", Slot = "37")]
	public long LEBIDACCAGA(string FINLDKJJAEK, long KBHDDKCAINE = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7580D80", Offset = "0x757FB80", VA = "0x187580D80", Slot = "38")]
	public ENNNAPGDFDL KMBGHMPPBPL(string FINLDKJJAEK, long IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7580F60", Offset = "0x757FD60", VA = "0x187580F60")]
	private bool LDFGMMEEMHH(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7581690", Offset = "0x7580490", VA = "0x187581690")]
	private bool MIECMLDIJJK(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x757FEE0", Offset = "0x757ECE0", VA = "0x18757FEE0")]
	private ENNNAPGDFDL DNEOJJKDIFK(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, string IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7581410", Offset = "0x7580210", VA = "0x187581410")]
	private ENNNAPGDFDL MCEHBLKFNLA(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, int IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x75810A0", Offset = "0x757FEA0", VA = "0x1875810A0")]
	private ENNNAPGDFDL LHNLHOEANOB(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, bool IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x75817F0", Offset = "0x75805F0", VA = "0x1875817F0")]
	private ENNNAPGDFDL NFPGKJCDBHG(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, float IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x757FC80", Offset = "0x757EA80", VA = "0x18757FC80")]
	private ENNNAPGDFDL CFBPAPNDHHM(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, DateTime IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x75801E0", Offset = "0x757EFE0", VA = "0x1875801E0")]
	private ENNNAPGDFDL ELCKGEAHMEB(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, long IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3A2EA40", Offset = "0x3A2D840", VA = "0x183A2EA40")]
	private T DOLALOKEIND<T>(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, T KBHDDKCAINE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DE60", Offset = "0x3A2CC60", VA = "0x183A2DE60")]
	private ENNNAPGDFDL CJFODFOFCAC<T>(LEINENMJICN PMEDKLJCKMA, string FINLDKJJAEK, T IPHILEOFJLB)
	{
		return default(ENNNAPGDFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F250", Offset = "0x3A2E050", VA = "0x183A2F250", Slot = "39")]
	public void LOOGJKIBFGD<T>(LOKNJIEHMMB<T> GMOCOKJMELP, [Optional] IEqualityComparer<T> LKDCBGBNMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F1D0", Offset = "0x3A2DFD0", VA = "0x183A2F1D0", Slot = "40")]
	public void ILJJHFGDDCI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7580990", Offset = "0x757F790", VA = "0x187580990")]
	[AsyncStateMachine(typeof(IFOLOBDMGMA))]
	private void IONCLBALKEM(LEINENMJICN OOANINMJJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7580AC0", Offset = "0x757F8C0", VA = "0x187580AC0", Slot = "43")]
	[AsyncStateMachine(typeof(CDAKCCHCNLD))]
	public Task JFBCFKCJFGN([Optional] CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x757F6D0", Offset = "0x757E4D0", VA = "0x18757F6D0")]
	private void AGNJOBKEKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x75811E0", Offset = "0x757FFE0", VA = "0x1875811E0", Slot = "41")]
	public IDisposable LKKAPKNFIGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x75823B0", Offset = "0x75811B0", VA = "0x1875823B0", Slot = "42")]
	public void PPBMPAJJILC(float CIOLBCCFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7581CC0", Offset = "0x7580AC0", VA = "0x187581CC0")]
	private void NPGJGPNDLFP(float DBNNBJKNLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7582150", Offset = "0x7580F50", VA = "0x187582150")]
	[IteratorStateMachine(typeof(OKGCNAGMJEC))]
	private IEnumerator<HLGDLHCLDFE> PJGONFNLKFJ(float CIOLBCCFHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7580A60", Offset = "0x757F860", VA = "0x187580A60")]
	[CompilerGenerated]
	private void JAALPLMGHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MCAKEMKGPAF : PEJABIGEGBL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static MCAKEMKGPAF GGJCMHODIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x75861C0", Offset = "0x7584FC0", VA = "0x1875861C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7586490", Offset = "0x7585290", VA = "0x187586490", Slot = "9")]
	public override string NPIKEPIONAB(bool HEILFBEALON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7586210", Offset = "0x7585010", VA = "0x187586210", Slot = "10")]
	protected override bool MENLHFHJKLB(string HEILFBEALON, [Out] bool IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7586620", Offset = "0x7585420", VA = "0x187586620")]
	public MCAKEMKGPAF()
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
