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
		[Cpp2IlInjected.Address(RVA = "0x875F270", Offset = "0x875E070", VA = "0x18875F270", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IAKLLCIHABI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class OCCKHBNIKEO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void HIDAMJNDBKO(GJAAKJPFKML NPAKDAMKFOF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x875E7C0", Offset = "0x875D5C0", VA = "0x18875E7C0")]
	private static void IFECCDJLELP(GJAAKJPFKML NPAKDAMKFOF, HIDAMJNDBKO APIFFNHAEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x875E4F0", Offset = "0x875D2F0", VA = "0x18875E4F0")]
	public static bool HDHLJKEJFKI(this GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, [Optional] HIDAMJNDBKO APIFFNHAEHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x875E840", Offset = "0x875D640", VA = "0x18875E840")]
	public static IEMPPGCHCFL MJDGGAEAKIH(this GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, string HGMAIPELJHM, [Optional] HIDAMJNDBKO APIFFNHAEHD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x875E990", Offset = "0x875D790", VA = "0x18875E990")]
	public static IEMPPGCHCFL NLCCKOCFMKK(this GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, int HGMAIPELJHM, [Optional] HIDAMJNDBKO APIFFNHAEHD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x875EAD0", Offset = "0x875D8D0", VA = "0x18875EAD0")]
	public static IEMPPGCHCFL PHHFEMMCCMK(this GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, bool HGMAIPELJHM, [Optional] HIDAMJNDBKO APIFFNHAEHD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x875E260", Offset = "0x875D060", VA = "0x18875E260")]
	public static IEMPPGCHCFL BMDHMJIAOLN(this GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, float HGMAIPELJHM, [Optional] HIDAMJNDBKO APIFFNHAEHD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x875E650", Offset = "0x875D450", VA = "0x18875E650")]
	public static IEMPPGCHCFL HOEFMKIAJDA(this GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, DateTime HGMAIPELJHM, [Optional] HIDAMJNDBKO APIFFNHAEHD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x875E3B0", Offset = "0x875D1B0", VA = "0x18875E3B0")]
	public static IEMPPGCHCFL GHLBNFFCMCD(this GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, long HGMAIPELJHM, [Optional] HIDAMJNDBKO APIFFNHAEHD)
	{
		return default(IEMPPGCHCFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LMKNCKFKDGM : PDBGDKNDGAA, GJAAKJPFKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CNPFFHCNDLP CPLLMMBMHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> CLPHGPHGDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> BBOCEFPLDIJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> JDKKFCGLDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x875D290", Offset = "0x875C090", VA = "0x18875D290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action DIMGFLDPOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x875DB30", Offset = "0x875C930", VA = "0x18875DB30")]
	[UnityEngine.Scripting.Preserve]
	public LMKNCKFKDGM([POMNKOCGGBN(null)] CNPFFHCNDLP CPLLMMBMHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public void CDANIOHNGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x875CCA0", Offset = "0x875BAA0", VA = "0x18875CCA0")]
	private DirectoryInfo JHMNIEEAGDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x875CAC0", Offset = "0x875B8C0", VA = "0x18875CAC0", Slot = "6")]
	public Task HNOCPKFGCEI(long MLOLEDFJFIL, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x875D340", Offset = "0x875C140", VA = "0x18875D340", Slot = "14")]
	public float NEPPAMAPMHG(string OPGJHIOADCK, float PGFMONBPOJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x875CC30", Offset = "0x875BA30", VA = "0x18875CC30", Slot = "13")]
	public void JFEBGLKKOEM(string OPGJHIOADCK, bool HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x875DA70", Offset = "0x875C870", VA = "0x18875DA70", Slot = "12")]
	public bool PLEKPBHPCAN(string OPGJHIOADCK, bool PGFMONBPOJI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x875C210", Offset = "0x875B010", VA = "0x18875C210", Slot = "10")]
	public int GHACNNDHHFO(string OPGJHIOADCK, int PGFMONBPOJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x875C280", Offset = "0x875B080", VA = "0x18875C280", Slot = "18")]
	public DateTime HIAIOGNPLIO(string BPCKHCGHBJN, [Optional] DateTime PGFMONBPOJI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x875D2D0", Offset = "0x875C0D0", VA = "0x18875D2D0", Slot = "19")]
	public void LMJOJCKJKJD(string OPGJHIOADCK, DateTime HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x875CDA0", Offset = "0x875BBA0", VA = "0x18875CDA0", Slot = "15")]
	public void LBJJMGOIFJI(string OPGJHIOADCK, float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x875CB50", Offset = "0x875B950", VA = "0x18875CB50", Slot = "11")]
	public void IALPKDPMPOK(string OPGJHIOADCK, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x875D440", Offset = "0x875C240", VA = "0x18875D440", Slot = "20")]
	public long OELFPMGLOPH(string BPCKHCGHBJN, long PGFMONBPOJI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x875C1A0", Offset = "0x875AFA0", VA = "0x18875C1A0", Slot = "21")]
	public void FMACPHLLGAA(string BPCKHCGHBJN, long HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1910", Offset = "0x3CE0710", VA = "0x183CE1910", Slot = "22")]
	public T OJJOFCGODLC<T>(string BPCKHCGHBJN, T PGFMONBPOJI, GNBDNPIJLBI<T> NEDEMBBOLDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1870", Offset = "0x3CE0670", VA = "0x183CE1870", Slot = "23")]
	public void GBKENALHAPG<T>(string BPCKHCGHBJN, T HGMAIPELJHM, GNBDNPIJLBI<T> NEDEMBBOLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x875BFF0", Offset = "0x875ADF0", VA = "0x18875BFF0", Slot = "16")]
	public string FKINCHBPOGG(string OPGJHIOADCK, string PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x875CBC0", Offset = "0x875B9C0", VA = "0x18875CBC0", Slot = "17")]
	public void IJFIFGLFDEF(string OPGJHIOADCK, string HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x875CE10", Offset = "0x875BC10", VA = "0x18875CE10", Slot = "24")]
	public void LBPKDFOHDJF(string OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x875D3B0", Offset = "0x875C1B0", VA = "0x18875D3B0", Slot = "9")]
	public bool NJINAHHDCLM(string OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x875CF60", Offset = "0x875BD60", VA = "0x18875CF60", Slot = "25")]
	public Task LCJGLHKFLKH(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x875D4B0", Offset = "0x875C2B0", VA = "0x18875D4B0")]
	private void OFKKCDELCDI(DirectoryInfo INEELIGLKPA, string OIOKADIAJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x875D870", Offset = "0x875C670", VA = "0x18875D870")]
	private static string OHAJNFFOLLC(string OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x875C0A0", Offset = "0x875AEA0", VA = "0x18875C0A0")]
	private static string FLIAFKEGODO(byte[] JICDOIHAMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE500", Offset = "0x3DDD300", VA = "0x183DDE500")]
	private T DPMBHNJHJDJ<T>(string BPCKHCGHBJN, T PGFMONBPOJI, [Optional] GNBDNPIJLBI<T> EGCGNJNFGNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD2B0", Offset = "0x3DDC0B0", VA = "0x183DDD2B0")]
	private void BNFJAIPBEBA<T>(string BPCKHCGHBJN, T HGMAIPELJHM, [Optional] GNBDNPIJLBI<T> EGCGNJNFGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x875C2F0", Offset = "0x875B0F0", VA = "0x18875C2F0")]
	private Dictionary<string, string> HMNHDEHICMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class MJIKHAGMPFI
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x875E100", Offset = "0x875CF00", VA = "0x18875E100")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void DKLHNMBDELP(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NNOLIOBLFMN : CKEEIMCFNOI
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8756B60", Offset = "0x8755960", VA = "0x188756B60")]
	[UnityEngine.Scripting.Preserve]
	public NNOLIOBLFMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CKEEIMCFNOI : PDBGDKNDGAA, GJAAKJPFKML, EAFLOAEBNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> EAMIEBHKKHJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DIMGFLDPOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public void CDANIOHNGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8756680", Offset = "0x8755480", VA = "0x188756680", Slot = "6")]
	public Task HNOCPKFGCEI(long MLOLEDFJFIL, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8756A40", Offset = "0x8755840", VA = "0x188756A40", Slot = "9")]
	public bool NJINAHHDCLM(string BPCKHCGHBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x87565C0", Offset = "0x87553C0", VA = "0x1887565C0", Slot = "10")]
	public int GHACNNDHHFO(string BPCKHCGHBJN, int PGFMONBPOJI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8756710", Offset = "0x8755510", VA = "0x188756710", Slot = "11")]
	public void IALPKDPMPOK(string BPCKHCGHBJN, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8756B00", Offset = "0x8755900", VA = "0x188756B00", Slot = "12")]
	public bool PLEKPBHPCAN(string BPCKHCGHBJN, bool PGFMONBPOJI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x87567D0", Offset = "0x87555D0", VA = "0x1887567D0", Slot = "13")]
	public void JFEBGLKKOEM(string BPCKHCGHBJN, bool HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x87569E0", Offset = "0x87557E0", VA = "0x1887569E0", Slot = "14")]
	public float NEPPAMAPMHG(string BPCKHCGHBJN, float PGFMONBPOJI = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8756830", Offset = "0x8755630", VA = "0x188756830", Slot = "15")]
	public void LBJJMGOIFJI(string BPCKHCGHBJN, float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8756500", Offset = "0x8755300", VA = "0x188756500", Slot = "16")]
	public string FKINCHBPOGG(string BPCKHCGHBJN, [Optional] string PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8756770", Offset = "0x8755570", VA = "0x188756770", Slot = "17")]
	public void IJFIFGLFDEF(string BPCKHCGHBJN, string HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8756620", Offset = "0x8755420", VA = "0x188756620", Slot = "18")]
	public DateTime HIAIOGNPLIO(string BPCKHCGHBJN, [Optional] DateTime PGFMONBPOJI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8756980", Offset = "0x8755780", VA = "0x188756980", Slot = "19")]
	public void LMJOJCKJKJD(string BPCKHCGHBJN, DateTime HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8756AA0", Offset = "0x87558A0", VA = "0x188756AA0", Slot = "20")]
	public long OELFPMGLOPH(string BPCKHCGHBJN, long PGFMONBPOJI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8756560", Offset = "0x8755360", VA = "0x188756560", Slot = "21")]
	public void FMACPHLLGAA(string BPCKHCGHBJN, long HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B0CE00", Offset = "0x3B0BC00", VA = "0x183B0CE00", Slot = "22")]
	public T OJJOFCGODLC<T>(string BPCKHCGHBJN, T PGFMONBPOJI, GNBDNPIJLBI<T> NEDEMBBOLDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B0CD60", Offset = "0x3B0BB60", VA = "0x183B0CD60", Slot = "23")]
	public void GBKENALHAPG<T>(string BPCKHCGHBJN, T HGMAIPELJHM, GNBDNPIJLBI<T> NEDEMBBOLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C520", Offset = "0x3B0B320", VA = "0x183B0C520")]
	public T DPMBHNJHJDJ<T>(string BPCKHCGHBJN, T PGFMONBPOJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C030", Offset = "0x3B0AE30", VA = "0x183B0C030")]
	public void BNFJAIPBEBA<T>(string BPCKHCGHBJN, T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8756890", Offset = "0x8755690", VA = "0x188756890", Slot = "24")]
	public void LBPKDFOHDJF(string BPCKHCGHBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x87568F0", Offset = "0x87556F0", VA = "0x1887568F0", Slot = "25")]
	public Task LCJGLHKFLKH(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8756B60", Offset = "0x8755960", VA = "0x188756B60")]
	public CKEEIMCFNOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class NPHGJMEPJEH<TParent> where TParent : GJAAKJPFKML
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<NPHGJMEPJEH<TParent>> PFKADAJCMLM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x59B74E0", Offset = "0x59B62E0", VA = "0x1859B74E0")]
	protected NPHGJMEPJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void FMJEOCFJDAJ();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EIMMCALHJPM(string OPGJHIOADCK);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x59B7170", Offset = "0x59B5F70", VA = "0x1859B7170")]
	public static void FKNLKBHPKHD(string OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x59B6F40", Offset = "0x59B5D40", VA = "0x1859B6F40")]
	public static void CJIMGKMKNBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DFKKHFEODBM<TParent, TValue> : NPHGJMEPJEH<TParent> where TParent : GJAAKJPFKML
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DFKKHFEODBM<TParent, TValue> HANIMDCJEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> IPOJNAAACLD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x45391A0", Offset = "0x4537FA0", VA = "0x1845391A0")]
	public bool CFOKPIKBEGL(string LKKMNPAKFAL, [Out] TValue FIBPLJJCBHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4539240", Offset = "0x4538040", VA = "0x184539240")]
	public void PNHGEGAGBNJ(string LKKMNPAKFAL, TValue HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4539210", Offset = "0x4538010", VA = "0x184539210", Slot = "4")]
	protected override void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x45391E0", Offset = "0x4537FE0", VA = "0x1845391E0", Slot = "5")]
	protected override void EIMMCALHJPM(string LKKMNPAKFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4539470", Offset = "0x4538270", VA = "0x184539470")]
	public DFKKHFEODBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GJAAKJPFKML
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDANIOHNGCJ();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NJINAHHDCLM(string BPCKHCGHBJN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GHACNNDHHFO(string BPCKHCGHBJN, int PGFMONBPOJI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IALPKDPMPOK(string BPCKHCGHBJN, int HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PLEKPBHPCAN(string BPCKHCGHBJN, bool PGFMONBPOJI = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JFEBGLKKOEM(string BPCKHCGHBJN, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float NEPPAMAPMHG(string BPCKHCGHBJN, float PGFMONBPOJI = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LBJJMGOIFJI(string BPCKHCGHBJN, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string FKINCHBPOGG(string BPCKHCGHBJN, [Optional] string PGFMONBPOJI);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IJFIFGLFDEF(string BPCKHCGHBJN, string HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime HIAIOGNPLIO(string BPCKHCGHBJN, [Optional] DateTime EEMAGLEPFIK);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LMJOJCKJKJD(string BPCKHCGHBJN, DateTime EEMAGLEPFIK);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long OELFPMGLOPH(string BPCKHCGHBJN, long PGFMONBPOJI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FMACPHLLGAA(string BPCKHCGHBJN, long HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T OJJOFCGODLC<T>(string BPCKHCGHBJN, T PGFMONBPOJI, GNBDNPIJLBI<T> NEDEMBBOLDM);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GBKENALHAPG<T>(string BPCKHCGHBJN, T HGMAIPELJHM, GNBDNPIJLBI<T> NEDEMBBOLDM);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LBPKDFOHDJF(string BPCKHCGHBJN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task LCJGLHKFLKH([Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PDBGDKNDGAA : GJAAKJPFKML
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DIMGFLDPOHO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HNOCPKFGCEI(long MLOLEDFJFIL, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EAFLOAEBNOC : GJAAKJPFKML
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ICGCIMGBOGK : PDBGDKNDGAA, GJAAKJPFKML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FHJPKDIKJMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ICGCIMGBOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x87579C0", Offset = "0x87567C0", VA = "0x1887579C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8757DA0", Offset = "0x8756BA0", VA = "0x188757DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IGOOCNCFPFL : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ICGCIMGBOGK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public IGOOCNCFPFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x875BE50", Offset = "0x875AC50", VA = "0x18875BE50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x875BEC0", Offset = "0x875ACC0", VA = "0x18875BEC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CNPFFHCNDLP CPLLMMBMHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool HJIKLEKPLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool FODOACKHCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HKHGONAOEBE BJPOEFBBDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GMJHELKMAKL PEEHDPFMKNB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DIMGFLDPOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x875BD60", Offset = "0x875AB60", VA = "0x18875BD60")]
	[UnityEngine.Scripting.Preserve]
	public ICGCIMGBOGK([POMNKOCGGBN(null)] CNPFFHCNDLP CPLLMMBMHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public void CDANIOHNGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x875B770", Offset = "0x875A570", VA = "0x18875B770", Slot = "6")]
	public Task HNOCPKFGCEI(long MLOLEDFJFIL, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3BD0", Offset = "0x1DF29D0", VA = "0x181DF3BD0")]
	private static int EHNOMLIDOLK(bool HGMAIPELJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x875BBC0", Offset = "0x875A9C0", VA = "0x18875BBC0", Slot = "9")]
	public bool NJINAHHDCLM(string BPCKHCGHBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x875B6B0", Offset = "0x875A4B0", VA = "0x18875B6B0", Slot = "10")]
	public int GHACNNDHHFO(string BPCKHCGHBJN, int PGFMONBPOJI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x875B800", Offset = "0x875A600", VA = "0x18875B800", Slot = "11")]
	public void IALPKDPMPOK(string BPCKHCGHBJN, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x875BD30", Offset = "0x875AB30", VA = "0x18875BD30", Slot = "12")]
	public bool PLEKPBHPCAN(string BPCKHCGHBJN, bool PGFMONBPOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x875B860", Offset = "0x875A660", VA = "0x18875B860", Slot = "13")]
	public void JFEBGLKKOEM(string BPCKHCGHBJN, bool HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x875BB90", Offset = "0x875A990", VA = "0x18875BB90", Slot = "14")]
	public float NEPPAMAPMHG(string BPCKHCGHBJN, float PGFMONBPOJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x875B900", Offset = "0x875A700", VA = "0x18875B900", Slot = "15")]
	public void LBJJMGOIFJI(string BPCKHCGHBJN, float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x875B700", Offset = "0x875A500", VA = "0x18875B700", Slot = "18")]
	public DateTime HIAIOGNPLIO(string BPCKHCGHBJN, [Optional] DateTime PGFMONBPOJI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x875BB20", Offset = "0x875A920", VA = "0x18875BB20", Slot = "19")]
	public void LMJOJCKJKJD(string BPCKHCGHBJN, DateTime EEMAGLEPFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x875BBE0", Offset = "0x875A9E0", VA = "0x18875BBE0", Slot = "20")]
	public long OELFPMGLOPH(string BPCKHCGHBJN, long PGFMONBPOJI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x875B640", Offset = "0x875A440", VA = "0x18875B640", Slot = "21")]
	public void FMACPHLLGAA(string BPCKHCGHBJN, long HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D45800", Offset = "0x3D44600", VA = "0x183D45800", Slot = "22")]
	public T OJJOFCGODLC<T>(string BPCKHCGHBJN, T PGFMONBPOJI, GNBDNPIJLBI<T> NEDEMBBOLDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D45000", Offset = "0x3D43E00", VA = "0x183D45000", Slot = "23")]
	public void GBKENALHAPG<T>(string BPCKHCGHBJN, T HGMAIPELJHM, GNBDNPIJLBI<T> NEDEMBBOLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D459C0", Offset = "0x3D447C0", VA = "0x183D459C0")]
	private T PBPBDDHCEOE<T>(string BPCKHCGHBJN, T PGFMONBPOJI, [Optional] GNBDNPIJLBI<T> EGCGNJNFGNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3D45130", Offset = "0x3D43F30", VA = "0x183D45130")]
	private void KANJBFEHEFJ<T>(string BPCKHCGHBJN, T HGMAIPELJHM, [Optional] GNBDNPIJLBI<T> EGCGNJNFGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x875B610", Offset = "0x875A410", VA = "0x18875B610", Slot = "16")]
	public string FKINCHBPOGG(string BPCKHCGHBJN, string PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x875B830", Offset = "0x875A630", VA = "0x18875B830", Slot = "17")]
	public void IJFIFGLFDEF(string BPCKHCGHBJN, string HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x875B6E0", Offset = "0x875A4E0", VA = "0x18875B6E0")]
	private void HCDDDPLMCKH(string BPCKHCGHBJN, string HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x875B550", Offset = "0x875A350", VA = "0x18875B550")]
	private string DBDMCKIAHNF(string BPCKHCGHBJN, string PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x875B930", Offset = "0x875A730", VA = "0x18875B930", Slot = "24")]
	public void LBPKDFOHDJF(string BPCKHCGHBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x875B570", Offset = "0x875A370", VA = "0x18875B570")]
	private string EEHIPMDPAGH(string OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x875B9C0", Offset = "0x875A7C0", VA = "0x18875B9C0", Slot = "25")]
	[AsyncStateMachine(typeof(FHJPKDIKJMF))]
	public Task LCJGLHKFLKH(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x875BC50", Offset = "0x875AA50", VA = "0x18875BC50")]
	[IteratorStateMachine(typeof(IGOOCNCFPFL))]
	private IEnumerator<PHFDFIIIMCE> OHHBPJLABMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x875BCD0", Offset = "0x875AAD0", VA = "0x18875BCD0")]
	private void PDIMIGNOJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x875BAB0", Offset = "0x875A8B0", VA = "0x18875BAB0")]
	private void LMGCCCODBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x875B890", Offset = "0x875A690", VA = "0x18875B890")]
	private void KIOANCEPHMP(bool KNGDCGHJHKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FFJDPAMHCLB : PDBGDKNDGAA, GJAAKJPFKML
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
	private Dictionary<string, string> BBOCEFPLDIJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string BLHLCODIDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8757720", Offset = "0x8756520", VA = "0x188757720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> JDKKFCGLDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8757670", Offset = "0x8756470", VA = "0x188757670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action DIMGFLDPOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	[UnityEngine.Scripting.Preserve]
	public FFJDPAMHCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public void CDANIOHNGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x87570D0", Offset = "0x8755ED0", VA = "0x1887570D0", Slot = "6")]
	public Task HNOCPKFGCEI(long MLOLEDFJFIL, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8757790", Offset = "0x8756590", VA = "0x188757790", Slot = "14")]
	public float NEPPAMAPMHG(string OPGJHIOADCK, float PGFMONBPOJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8757270", Offset = "0x8756070", VA = "0x188757270", Slot = "13")]
	public void JFEBGLKKOEM(string OPGJHIOADCK, bool HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8757900", Offset = "0x8756700", VA = "0x188757900", Slot = "12")]
	public bool PLEKPBHPCAN(string OPGJHIOADCK, bool PGFMONBPOJI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8756D10", Offset = "0x8755B10", VA = "0x188756D10", Slot = "10")]
	public int GHACNNDHHFO(string OPGJHIOADCK, int PGFMONBPOJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8756D80", Offset = "0x8755B80", VA = "0x188756D80", Slot = "18")]
	public DateTime HIAIOGNPLIO(string BPCKHCGHBJN, [Optional] DateTime PGFMONBPOJI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x87576B0", Offset = "0x87564B0", VA = "0x1887576B0", Slot = "19")]
	public void LMJOJCKJKJD(string OPGJHIOADCK, DateTime HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x87572E0", Offset = "0x87560E0", VA = "0x1887572E0", Slot = "15")]
	public void LBJJMGOIFJI(string OPGJHIOADCK, float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8757160", Offset = "0x8755F60", VA = "0x188757160", Slot = "11")]
	public void IALPKDPMPOK(string OPGJHIOADCK, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8757890", Offset = "0x8756690", VA = "0x188757890", Slot = "20")]
	public long OELFPMGLOPH(string BPCKHCGHBJN, long PGFMONBPOJI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8756CA0", Offset = "0x8755AA0", VA = "0x188756CA0", Slot = "21")]
	public void FMACPHLLGAA(string BPCKHCGHBJN, long HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1910", Offset = "0x3CE0710", VA = "0x183CE1910", Slot = "22")]
	public T OJJOFCGODLC<T>(string BPCKHCGHBJN, T PGFMONBPOJI, GNBDNPIJLBI<T> NEDEMBBOLDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1870", Offset = "0x3CE0670", VA = "0x183CE1870", Slot = "23")]
	public void GBKENALHAPG<T>(string BPCKHCGHBJN, T HGMAIPELJHM, GNBDNPIJLBI<T> NEDEMBBOLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8756BF0", Offset = "0x87559F0", VA = "0x188756BF0", Slot = "16")]
	public string FKINCHBPOGG(string OPGJHIOADCK, string PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x87571D0", Offset = "0x8755FD0", VA = "0x1887571D0", Slot = "17")]
	public void IJFIFGLFDEF(string OPGJHIOADCK, string HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8757350", Offset = "0x8756150", VA = "0x188757350", Slot = "24")]
	public void LBPKDFOHDJF(string OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8757800", Offset = "0x8756600", VA = "0x188757800", Slot = "9")]
	public bool NJINAHHDCLM(string OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8757410", Offset = "0x8756210", VA = "0x188757410", Slot = "25")]
	public Task LCJGLHKFLKH(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0750", Offset = "0x3CDF550", VA = "0x183CE0750")]
	private T DPMBHNJHJDJ<T>(string BPCKHCGHBJN, T PGFMONBPOJI, [Optional] GNBDNPIJLBI<T> EGCGNJNFGNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CDF810", Offset = "0x3CDE610", VA = "0x183CDF810")]
	private void BNFJAIPBEBA<T>(string BPCKHCGHBJN, T HGMAIPELJHM, [Optional] GNBDNPIJLBI<T> EGCGNJNFGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8756DF0", Offset = "0x8755BF0", VA = "0x188756DF0")]
	private Dictionary<string, string> HMNHDEHICMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DPCFCLHFNMK
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action DIMGFLDPOHO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDANIOHNGCJ();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FIJOMANPHJK(long MLOLEDFJFIL);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KFKPKEJCBAJ(IAKLLCIHABI IHAKIMLOAFE = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AKGMADLLOKL(string BPCKHCGHBJN, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ALAOKDEALKG(string BPCKHCGHBJN, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string HBLLDMACOOD(string BPCKHCGHBJN, [Optional] string PGFMONBPOJI, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEMPPGCHCFL HGHNFJJACHE(string BPCKHCGHBJN, string HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int IGENDHDMOON(string BPCKHCGHBJN, int PGFMONBPOJI = 0, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEMPPGCHCFL NDIJBIKCBGN(string BPCKHCGHBJN, int HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IOKNONBGDBP(string BPCKHCGHBJN, bool PGFMONBPOJI, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IEMPPGCHCFL PEIIAHHKOBO(string BPCKHCGHBJN, bool HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float PLKNOHKGPOI(string BPCKHCGHBJN, float PGFMONBPOJI = 0f, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEMPPGCHCFL MHFGGPONNOC(string BPCKHCGHBJN, float HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime LPFLBFANMBB(string BPCKHCGHBJN, [Optional] DateTime PGFMONBPOJI, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEMPPGCHCFL KPOJACDIFOA(string BPCKHCGHBJN, DateTime HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long KHELFDEHBCI(string BPCKHCGHBJN, long PGFMONBPOJI = 0L, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IEMPPGCHCFL CGBNCMMBIIC(string BPCKHCGHBJN, long HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T MNNEHFBBCNH<T>(string BPCKHCGHBJN, [Optional] T PGFMONBPOJI, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IEMPPGCHCFL HEDBJFLAOCA<T>(string BPCKHCGHBJN, T HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool BOGPHIKJNNH(string BPCKHCGHBJN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool ECEMENAKHII(string BPCKHCGHBJN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string EFIBEIHJBAI(string BPCKHCGHBJN, [Optional] string PGFMONBPOJI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IEMPPGCHCFL GMHOMLLIIMM(string BPCKHCGHBJN, string HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int BJBIAICLILA(string BPCKHCGHBJN, int PGFMONBPOJI = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IEMPPGCHCFL KACPCCHCDGE(string BPCKHCGHBJN, int HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PDKACLEGOJK(string BPCKHCGHBJN, bool PGFMONBPOJI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	IEMPPGCHCFL PABCJBAONBO(string BPCKHCGHBJN, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float ANCGIGGFECP(string BPCKHCGHBJN, float PGFMONBPOJI = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	IEMPPGCHCFL BILMDPCIMGB(string BPCKHCGHBJN, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime ICPIPNBPJPP(string BPCKHCGHBJN, [Optional] DateTime PGFMONBPOJI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	IEMPPGCHCFL HFABCGAHEAD(string BPCKHCGHBJN, DateTime HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long AEKHIFDNAJA(string BPCKHCGHBJN, long PGFMONBPOJI = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IEMPPGCHCFL AMNMCMMPFHJ(string BPCKHCGHBJN, long HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void AJCENMEPDIK<T>(GNBDNPIJLBI<T> NEDEMBBOLDM, [Optional] IEqualityComparer<T> IFGHMFNGBPM);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CPIONOFAPPJ<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable BOAHDOPCBLL();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LIIJAMLOGGE(float KBODPDIPNAF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task PDIMIGNOJEE([Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IEMPPGCHCFL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GEKJMGOHCLL : DPCFCLHFNMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class FHNLIJDDKEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<FHNLIJDDKEF> FJCEIGNGHBI;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8757E00", Offset = "0x8756C00", VA = "0x188757E00")]
		public static void CJIMGKMKNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FMJEOCFJDAJ();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		protected FHNLIJDDKEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class NEHDEHHAGFD<T> : FHNLIJDDKEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly NEHDEHHAGFD<T> MOIOIMEFPHA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GNBDNPIJLBI<T> NAJEBAGALKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> NEBLFEDEABF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BOIMNCHNDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4A31D90", Offset = "0x4A30B90", VA = "0x184A31D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5968030", Offset = "0x5966E30", VA = "0x185968030")]
		private NEHDEHHAGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5967AD0", Offset = "0x59668D0", VA = "0x185967AD0")]
		public void FAIIODDINIJ(GNBDNPIJLBI<T> EGCGNJNFGNA, [Optional] IEqualityComparer<T> IFGHMFNGBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5967DB0", Offset = "0x5966BB0", VA = "0x185967DB0", Slot = "4")]
		public override void FMJEOCFJDAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class PLJFDJLBFMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly GEKJMGOHCLL NNLOLIEJGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object LGEHNGACPHP;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x875F0E0", Offset = "0x875DEE0", VA = "0x18875F0E0")]
		public PLJFDJLBFMB(GEKJMGOHCLL NNLOLIEJGBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x875F0B0", Offset = "0x875DEB0", VA = "0x18875F0B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct GBOLNGENOKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GEKJMGOHCLL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8757FD0", Offset = "0x8756DD0", VA = "0x188757FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x87582B0", Offset = "0x87570B0", VA = "0x1887582B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct ABPJOGNECLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GEKJMGOHCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GJAAKJPFKML backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8756370", Offset = "0x8755170", VA = "0x188756370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct LNFEGEIMEHF : IAsyncStateMachine
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
		public GEKJMGOHCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x875DBD0", Offset = "0x875C9D0", VA = "0x18875DBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x875E0A0", Offset = "0x875CEA0", VA = "0x18875E0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IHBPNDKFKHL : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GEKJMGOHCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public IHBPNDKFKHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x875BF10", Offset = "0x875AD10", VA = "0x18875BF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x875BFA0", Offset = "0x875ADA0", VA = "0x18875BFA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PDBGDKNDGAA OFJIHODIMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly PDBGDKNDGAA NEANLPHEGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly EAFLOAEBNOC IFJOFHGKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HKHGONAOEBE BJPOEFBBDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly OCCKHBNIKEO.HIDAMJNDBKO APIFFNHAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly LKAPBLPAEMI PEMDLKHGMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<GJAAKJPFKML> MMHEDEPAMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task AIDBBOGELDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> GFMBBBFJPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GMJHELKMAKL DJDEPFNPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object KAPEJDJHJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object OCJCEBPMDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long GOMECABHPHF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool GFNJIMIMJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x87595C0", Offset = "0x87583C0", VA = "0x1887595C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource MMJKAKIGMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action DIMGFLDPOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x875AD50", Offset = "0x8759B50", VA = "0x18875AD50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8758D10", Offset = "0x8757B10", VA = "0x188758D10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8758CA0", Offset = "0x8757AA0", VA = "0x188758CA0")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x875B180", Offset = "0x8759F80", VA = "0x18875B180")]
	[UnityEngine.Scripting.Preserve]
	public GEKJMGOHCLL([POMNKOCGGBN("Disk")] PDBGDKNDGAA OFJIHODIMIM, [POMNKOCGGBN("Cloud")] PDBGDKNDGAA NEANLPHEGBE, [POMNKOCGGBN(null)] EAFLOAEBNOC IFJOFHGKIAF, [POMNKOCGGBN(null)] HKHGONAOEBE BJPOEFBBDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8758DB0", Offset = "0x8757BB0", VA = "0x188758DB0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8759F50", Offset = "0x8758D50", VA = "0x188759F50")]
	private void KHDAHHGMLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x87588D0", Offset = "0x87576D0", VA = "0x1887588D0", Slot = "6")]
	public void CDANIOHNGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8759280", Offset = "0x8758080", VA = "0x188759280", Slot = "7")]
	public Task FIJOMANPHJK(long MLOLEDFJFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8759170", Offset = "0x8757F70", VA = "0x188759170")]
	[AsyncStateMachine(typeof(GBOLNGENOKD))]
	private Task EPBDNHNLMIA(long MLOLEDFJFIL, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8759E40", Offset = "0x8758C40", VA = "0x188759E40")]
	private void JDHJLEPFDBB(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x875A660", Offset = "0x8759460", VA = "0x18875A660")]
	private void NAFNKEKKLMA(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8758DF0", Offset = "0x8757BF0", VA = "0x188758DF0")]
	private string EAABPKAEDNH(string LJAGKFGNPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8759AB0", Offset = "0x87588B0", VA = "0x188759AB0")]
	private void IOEIPLEHIFI(IAKLLCIHABI IHAKIMLOAFE, string OPGJHIOADCK, [Out] PDBGDKNDGAA NPAKDAMKFOF, [Out] string OKIIFGCILMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8758380", Offset = "0x8757180", VA = "0x188758380")]
	private PDBGDKNDGAA AFHCNMJCOFE(IAKLLCIHABI IHAKIMLOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8759E90", Offset = "0x8758C90", VA = "0x188759E90", Slot = "8")]
	public bool KFKPKEJCBAJ(IAKLLCIHABI IHAKIMLOAFE = IAKLLCIHABI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8758400", Offset = "0x8757200", VA = "0x188758400", Slot = "9")]
	public bool AKGMADLLOKL(string BPCKHCGHBJN, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x87584A0", Offset = "0x87572A0", VA = "0x1887584A0", Slot = "10")]
	public bool ALAOKDEALKG(string BPCKHCGHBJN, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x87595E0", Offset = "0x87583E0", VA = "0x1887595E0", Slot = "11")]
	public string HBLLDMACOOD(string BPCKHCGHBJN, [Optional] string PGFMONBPOJI, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x87596B0", Offset = "0x87584B0", VA = "0x1887596B0", Slot = "12")]
	public IEMPPGCHCFL HGHNFJJACHE(string BPCKHCGHBJN, string HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8759A00", Offset = "0x8758800", VA = "0x188759A00", Slot = "13")]
	public int IGENDHDMOON(string BPCKHCGHBJN, int PGFMONBPOJI = 0, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x875A6E0", Offset = "0x87594E0", VA = "0x18875A6E0", Slot = "14")]
	public IEMPPGCHCFL NDIJBIKCBGN(string BPCKHCGHBJN, int HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8759C50", Offset = "0x8758A50", VA = "0x188759C50", Slot = "15")]
	public bool IOKNONBGDBP(string BPCKHCGHBJN, bool PGFMONBPOJI, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x875AF50", Offset = "0x8759D50", VA = "0x18875AF50", Slot = "16")]
	public IEMPPGCHCFL PEIIAHHKOBO(string BPCKHCGHBJN, bool HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x875B0D0", Offset = "0x8759ED0", VA = "0x18875B0D0", Slot = "17")]
	public float PLKNOHKGPOI(string BPCKHCGHBJN, float PGFMONBPOJI = 0f, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x875A370", Offset = "0x8759170", VA = "0x18875A370", Slot = "18")]
	public IEMPPGCHCFL MHFGGPONNOC(string BPCKHCGHBJN, float HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x875A2D0", Offset = "0x87590D0", VA = "0x18875A2D0", Slot = "19")]
	public DateTime LPFLBFANMBB(string BPCKHCGHBJN, [Optional] DateTime PGFMONBPOJI, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x875A040", Offset = "0x8758E40", VA = "0x18875A040", Slot = "20")]
	public IEMPPGCHCFL KPOJACDIFOA(string BPCKHCGHBJN, DateTime HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8759FA0", Offset = "0x8758DA0", VA = "0x188759FA0", Slot = "21")]
	public long KHELFDEHBCI(string BPCKHCGHBJN, long PGFMONBPOJI = 0L, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8758940", Offset = "0x8757740", VA = "0x188758940", Slot = "22")]
	public IEMPPGCHCFL CGBNCMMBIIC(string BPCKHCGHBJN, long HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6100", Offset = "0x3CF4F00", VA = "0x183CF6100", Slot = "23")]
	public T MNNEHFBBCNH<T>(string BPCKHCGHBJN, [Optional] T PGFMONBPOJI, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6100", Offset = "0x3CF4F00", VA = "0x183CF6100", Slot = "24")]
	public IEMPPGCHCFL HEDBJFLAOCA<T>(string BPCKHCGHBJN, T HGMAIPELJHM, IAKLLCIHABI PHNIGCCGDHI = IAKLLCIHABI.CLOUD)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8758870", Offset = "0x8757670", VA = "0x188758870", Slot = "25")]
	public bool BOGPHIKJNNH(string BPCKHCGHBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8758E50", Offset = "0x8757C50", VA = "0x188758E50", Slot = "26")]
	public bool ECEMENAKHII(string BPCKHCGHBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8759100", Offset = "0x8757F00", VA = "0x188759100", Slot = "27")]
	public string EFIBEIHJBAI(string BPCKHCGHBJN, [Optional] string PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8759450", Offset = "0x8758250", VA = "0x188759450", Slot = "28")]
	public IEMPPGCHCFL GMHOMLLIIMM(string BPCKHCGHBJN, string HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x87586F0", Offset = "0x87574F0", VA = "0x1887586F0", Slot = "29")]
	public int BJBIAICLILA(string BPCKHCGHBJN, int PGFMONBPOJI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8759E60", Offset = "0x8758C60", VA = "0x188759E60", Slot = "30")]
	public IEMPPGCHCFL KACPCCHCDGE(string BPCKHCGHBJN, int HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x875AEE0", Offset = "0x8759CE0", VA = "0x18875AEE0", Slot = "31")]
	public bool PDKACLEGOJK(string BPCKHCGHBJN, bool PGFMONBPOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x875AD20", Offset = "0x8759B20", VA = "0x18875AD20", Slot = "32")]
	public IEMPPGCHCFL PABCJBAONBO(string BPCKHCGHBJN, bool HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8758650", Offset = "0x8757450", VA = "0x188758650", Slot = "33")]
	public float ANCGIGGFECP(string BPCKHCGHBJN, float PGFMONBPOJI = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x87586C0", Offset = "0x87574C0", VA = "0x1887586C0", Slot = "34")]
	public IEMPPGCHCFL BILMDPCIMGB(string BPCKHCGHBJN, float HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8759990", Offset = "0x8758790", VA = "0x188759990", Slot = "35")]
	public DateTime ICPIPNBPJPP(string BPCKHCGHBJN, [Optional] DateTime PGFMONBPOJI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8759680", Offset = "0x8758480", VA = "0x188759680", Slot = "36")]
	public IEMPPGCHCFL HFABCGAHEAD(string BPCKHCGHBJN, DateTime HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8758310", Offset = "0x8757110", VA = "0x188758310", Slot = "37")]
	public long AEKHIFDNAJA(string BPCKHCGHBJN, long PGFMONBPOJI = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8758620", Offset = "0x8757420", VA = "0x188758620", Slot = "38")]
	public IEMPPGCHCFL AMNMCMMPFHJ(string BPCKHCGHBJN, long HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x875A9B0", Offset = "0x87597B0", VA = "0x18875A9B0")]
	private bool NOEOEELDDFD(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8758FA0", Offset = "0x8757DA0", VA = "0x188758FA0")]
	private bool EFDHKNEHKNO(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8759840", Offset = "0x8758640", VA = "0x188759840")]
	private IEMPPGCHCFL HLMEKDFLKOA(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, string HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8758E60", Offset = "0x8757C60", VA = "0x188758E60")]
	private IEMPPGCHCFL EEPMDDDDEJJ(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, int HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8759480", Offset = "0x8758280", VA = "0x188759480")]
	private IEMPPGCHCFL GPDGBBGDHFG(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, bool HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x875A860", Offset = "0x8759660", VA = "0x18875A860")]
	private IEMPPGCHCFL NDJLDNPDJGI(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, float HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x875A4F0", Offset = "0x87592F0", VA = "0x18875A4F0")]
	private IEMPPGCHCFL MJGHNDLLONJ(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, DateTime HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8759D00", Offset = "0x8758B00", VA = "0x188759D00")]
	private IEMPPGCHCFL JCAMLFNENOL(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, long HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6F30", Offset = "0x3CF5D30", VA = "0x183CF6F30")]
	private T PGMHCMAHMGK<T>(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, T PGFMONBPOJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3CF62A0", Offset = "0x3CF50A0", VA = "0x183CF62A0")]
	private IEMPPGCHCFL JDPPPIFOBPL<T>(GJAAKJPFKML NPAKDAMKFOF, string BPCKHCGHBJN, T HGMAIPELJHM)
	{
		return default(IEMPPGCHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5FF0", Offset = "0x3CF4DF0", VA = "0x183CF5FF0", Slot = "39")]
	public void AJCENMEPDIK<T>(GNBDNPIJLBI<T> NEDEMBBOLDM, [Optional] IEqualityComparer<T> IFGHMFNGBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6080", Offset = "0x3CF4E80", VA = "0x183CF6080", Slot = "40")]
	public void CPIONOFAPPJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x875A1F0", Offset = "0x8758FF0", VA = "0x18875A1F0")]
	[AsyncStateMachine(typeof(ABPJOGNECLM))]
	private void LCJGLHKFLKH(GJAAKJPFKML NKEIMPHCNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x875ADF0", Offset = "0x8759BF0", VA = "0x18875ADF0", Slot = "43")]
	[AsyncStateMachine(typeof(LNFEGEIMEHF))]
	public Task PDIMIGNOJEE([Optional] CancellationToken OBGCPOCPFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8758AC0", Offset = "0x87578C0", VA = "0x188758AC0")]
	private void CMBDGPKFFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8758790", Offset = "0x8757590", VA = "0x188758790", Slot = "41")]
	public IDisposable BOAHDOPCBLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x875A2C0", Offset = "0x87590C0", VA = "0x18875A2C0", Slot = "42")]
	public void LIIJAMLOGGE(float KBODPDIPNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x875AA10", Offset = "0x8759810", VA = "0x18875AA10")]
	private void OMMLINDILHM(float PGCDPHGGJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x875AC90", Offset = "0x8759A90", VA = "0x18875AC90")]
	[IteratorStateMachine(typeof(IHBPNDKFKHL))]
	private IEnumerator<PHFDFIIIMCE> OOOJKLDFBED(float KBODPDIPNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8758760", Offset = "0x8757560", VA = "0x188758760")]
	[CompilerGenerated]
	private void BJKODNCANLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PABOMMIPDFH : JFLEFCOBODM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static PABOMMIPDFH MOIOIMEFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x875EF90", Offset = "0x875DD90", VA = "0x18875EF90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x875EEA0", Offset = "0x875DCA0", VA = "0x18875EEA0", Slot = "9")]
	public override string OFACCHGGJAP(bool DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x875EC20", Offset = "0x875DA20", VA = "0x18875EC20", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] bool HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x875F070", Offset = "0x875DE70", VA = "0x18875F070")]
	public PABOMMIPDFH()
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
