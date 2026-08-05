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
		[Cpp2IlInjected.Address(RVA = "0x8553400", Offset = "0x8552400", VA = "0x188553400", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KFLKGCBAEIP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class LPDHFFLAMPA
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void MMANJKPLENO(PKCDOGJFBBF PILOPLPMHHB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x85527F0", Offset = "0x85517F0", VA = "0x1885527F0")]
	private static void IHHJLNMPILN(PKCDOGJFBBF PILOPLPMHHB, MMANJKPLENO GLMGIPNJIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8552400", Offset = "0x8551400", VA = "0x188552400")]
	public static bool EFKACCNKIOF(this PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, [Optional] MMANJKPLENO GLMGIPNJIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85522B0", Offset = "0x85512B0", VA = "0x1885522B0")]
	public static HBINLHPKDAK CDADMCHONBG(this PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, string IOALKPFEKEK, [Optional] MMANJKPLENO GLMGIPNJIKI)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8552000", Offset = "0x8551000", VA = "0x188552000")]
	public static HBINLHPKDAK AIJFCNIBLEJ(this PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, int IOALKPFEKEK, [Optional] MMANJKPLENO GLMGIPNJIKI)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8552870", Offset = "0x8551870", VA = "0x188552870")]
	public static HBINLHPKDAK NIKBCDBKIJH(this PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, bool IOALKPFEKEK, [Optional] MMANJKPLENO GLMGIPNJIKI)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85526A0", Offset = "0x85516A0", VA = "0x1885526A0")]
	public static HBINLHPKDAK GLLIBCHNDNI(this PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, float IOALKPFEKEK, [Optional] MMANJKPLENO GLMGIPNJIKI)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8552140", Offset = "0x8551140", VA = "0x188552140")]
	public static HBINLHPKDAK AMHFJJGHGJJ(this PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, DateTime IOALKPFEKEK, [Optional] MMANJKPLENO GLMGIPNJIKI)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8552560", Offset = "0x8551560", VA = "0x188552560")]
	public static HBINLHPKDAK GGBGHKFIKEH(this PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, long IOALKPFEKEK, [Optional] MMANJKPLENO GLMGIPNJIKI)
	{
		return default(HBINLHPKDAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LAHOIKJLIPB : MHHEDKDNNNA, PKCDOGJFBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LIMLPGNCEJG GJJEAFBLFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> NCHIOEECCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> EJGMPNJHBMK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> AKFPPOCLHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85513C0", Offset = "0x85503C0", VA = "0x1885513C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action CAKPLCPFELE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8551950", Offset = "0x8550950", VA = "0x188551950")]
	[UnityEngine.Scripting.Preserve]
	public LAHOIKJLIPB([KELEGLJPNHI(null)] LIMLPGNCEJG GJJEAFBLFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public void NJKPJELHHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8550CE0", Offset = "0x854FCE0", VA = "0x188550CE0")]
	private DirectoryInfo ILCHBIKKMKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85515C0", Offset = "0x85505C0", VA = "0x1885515C0", Slot = "6")]
	public Task OBOMHHOBEOH(long CINGDDMGPMO, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8550010", Offset = "0x854F010", VA = "0x188550010", Slot = "14")]
	public float DDGOHKMNDIP(string DAKIIEIEKNI, float CAILINJCNIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8551650", Offset = "0x8550650", VA = "0x188551650", Slot = "13")]
	public void OPAEMOAILPO(string DAKIIEIEKNI, bool IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8551280", Offset = "0x8550280", VA = "0x188551280", Slot = "12")]
	public bool LGCAGGOGOJD(string DAKIIEIEKNI, bool CAILINJCNIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8551210", Offset = "0x8550210", VA = "0x188551210", Slot = "10")]
	public int KGOIOHPOBHM(string DAKIIEIEKNI, int CAILINJCNIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8551550", Offset = "0x8550550", VA = "0x188551550", Slot = "18")]
	public DateTime MMKKJECHBHD(string JFNKBOFNMLM, [Optional] DateTime CAILINJCNIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x854FE30", Offset = "0x854EE30", VA = "0x18854FE30", Slot = "19")]
	public void BGDIBMOFAFK(string DAKIIEIEKNI, DateTime IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x854FEA0", Offset = "0x854EEA0", VA = "0x18854FEA0", Slot = "15")]
	public void CGMJCLBMIAI(string DAKIIEIEKNI, float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8551350", Offset = "0x8550350", VA = "0x188551350", Slot = "11")]
	public void LMPCMEHBDGO(string DAKIIEIEKNI, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8550080", Offset = "0x854F080", VA = "0x188550080", Slot = "20")]
	public long ECAGAIGMAGD(string JFNKBOFNMLM, long CAILINJCNIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8550DE0", Offset = "0x854FDE0", VA = "0x188550DE0", Slot = "21")]
	public void KFCDDANPLBP(string JFNKBOFNMLM, long IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39D1810", Offset = "0x39D0810", VA = "0x1839D1810", Slot = "22")]
	public T ELLLONHMEAN<T>(string JFNKBOFNMLM, T CAILINJCNIJ, NENHAJLFEBJ<T> IPGNHICPFAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39D1920", Offset = "0x39D0920", VA = "0x1839D1920", Slot = "23")]
	public void KFKKHAHKCNA<T>(string JFNKBOFNMLM, T IOALKPFEKEK, NENHAJLFEBJ<T> IPGNHICPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85500F0", Offset = "0x854F0F0", VA = "0x1885500F0", Slot = "16")]
	public string FDBNBOEKDCK(string DAKIIEIEKNI, string CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x854FDC0", Offset = "0x854EDC0", VA = "0x18854FDC0", Slot = "17")]
	public void BAHGCFLFICC(string DAKIIEIEKNI, string IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8551400", Offset = "0x8550400", VA = "0x188551400", Slot = "24")]
	public void MGMOOIKADCI(string DAKIIEIEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85518C0", Offset = "0x85508C0", VA = "0x1885518C0", Slot = "9")]
	public bool PNHBOHGGLOG(string DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85509A0", Offset = "0x854F9A0", VA = "0x1885509A0", Slot = "25")]
	public Task HFJJLOCAHCL(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8550E50", Offset = "0x854FE50", VA = "0x188550E50")]
	private void KGEIAEBLAPC(DirectoryInfo LKEFPEOKCDL, string MNIFDOCLPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85516C0", Offset = "0x85506C0", VA = "0x1885516C0")]
	private static string PLFAKFLFBDN(string DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x854FF10", Offset = "0x854EF10", VA = "0x18854FF10")]
	private static string CNIAIGINGGD(byte[] ODOOLGJOBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B540", Offset = "0x3D4A540", VA = "0x183D4B540")]
	private T LMKONLJOAEP<T>(string JFNKBOFNMLM, T CAILINJCNIJ, [Optional] NENHAJLFEBJ<T> IFFGEKLNFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C660", Offset = "0x3D4B660", VA = "0x183D4C660")]
	private void ODADMGGOEJG<T>(string JFNKBOFNMLM, T IOALKPFEKEK, [Optional] NENHAJLFEBJ<T> IFFGEKLNFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85501A0", Offset = "0x854F1A0", VA = "0x1885501A0")]
	private Dictionary<string, string> FNMBEEJICKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class MOBNFBOKHJE
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8552B50", Offset = "0x8551B50", VA = "0x188552B50")]
	[GOMLKAICHII.NIENCEEHOCF]
	internal static void PHNOHKBOJEP(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IGBMDNCAGKF : PCKCIJIDMPJ
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x854F7D0", Offset = "0x854E7D0", VA = "0x18854F7D0")]
	[UnityEngine.Scripting.Preserve]
	public IGBMDNCAGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PCKCIJIDMPJ : MHHEDKDNNNA, PKCDOGJFBBF, CKJIJDHCFME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> ODCEMCBDJHH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CAKPLCPFELE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public void NJKPJELHHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85531C0", Offset = "0x85521C0", VA = "0x1885531C0", Slot = "6")]
	public Task OBOMHHOBEOH(long CINGDDMGPMO, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x85532B0", Offset = "0x85522B0", VA = "0x1885532B0", Slot = "9")]
	public bool PNHBOHGGLOG(string JFNKBOFNMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8552FE0", Offset = "0x8551FE0", VA = "0x188552FE0", Slot = "10")]
	public int KGOIOHPOBHM(string JFNKBOFNMLM, int CAILINJCNIJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x85530A0", Offset = "0x85520A0", VA = "0x1885530A0", Slot = "11")]
	public void LMPCMEHBDGO(string JFNKBOFNMLM, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8553040", Offset = "0x8552040", VA = "0x188553040", Slot = "12")]
	public bool LGCAGGOGOJD(string JFNKBOFNMLM, bool CAILINJCNIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8553250", Offset = "0x8552250", VA = "0x188553250", Slot = "13")]
	public void OPAEMOAILPO(string JFNKBOFNMLM, bool IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8552DD0", Offset = "0x8551DD0", VA = "0x188552DD0", Slot = "14")]
	public float DDGOHKMNDIP(string JFNKBOFNMLM, float CAILINJCNIJ = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8552D70", Offset = "0x8551D70", VA = "0x188552D70", Slot = "15")]
	public void CGMJCLBMIAI(string JFNKBOFNMLM, float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8552E90", Offset = "0x8551E90", VA = "0x188552E90", Slot = "16")]
	public string FDBNBOEKDCK(string JFNKBOFNMLM, [Optional] string CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8552CB0", Offset = "0x8551CB0", VA = "0x188552CB0", Slot = "17")]
	public void BAHGCFLFICC(string JFNKBOFNMLM, string IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8553160", Offset = "0x8552160", VA = "0x188553160", Slot = "18")]
	public DateTime MMKKJECHBHD(string JFNKBOFNMLM, [Optional] DateTime CAILINJCNIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8552D10", Offset = "0x8551D10", VA = "0x188552D10", Slot = "19")]
	public void BGDIBMOFAFK(string JFNKBOFNMLM, DateTime IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8552E30", Offset = "0x8551E30", VA = "0x188552E30", Slot = "20")]
	public long ECAGAIGMAGD(string JFNKBOFNMLM, long CAILINJCNIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8552F80", Offset = "0x8551F80", VA = "0x188552F80", Slot = "21")]
	public void KFCDDANPLBP(string JFNKBOFNMLM, long IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E343D0", Offset = "0x3E333D0", VA = "0x183E343D0", Slot = "22")]
	public T ELLLONHMEAN<T>(string JFNKBOFNMLM, T CAILINJCNIJ, NENHAJLFEBJ<T> IPGNHICPFAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E344D0", Offset = "0x3E334D0", VA = "0x183E344D0", Slot = "23")]
	public void KFKKHAHKCNA<T>(string JFNKBOFNMLM, T IOALKPFEKEK, NENHAJLFEBJ<T> IPGNHICPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E34570", Offset = "0x3E33570", VA = "0x183E34570")]
	public T LMKONLJOAEP<T>(string JFNKBOFNMLM, T CAILINJCNIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E34E10", Offset = "0x3E33E10", VA = "0x183E34E10")]
	public void ODADMGGOEJG<T>(string JFNKBOFNMLM, T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8553100", Offset = "0x8552100", VA = "0x188553100", Slot = "24")]
	public void MGMOOIKADCI(string JFNKBOFNMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8552EF0", Offset = "0x8551EF0", VA = "0x188552EF0", Slot = "25")]
	public Task HFJJLOCAHCL(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x854F7D0", Offset = "0x854E7D0", VA = "0x18854F7D0")]
	public PCKCIJIDMPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class EEBLKNDEFFL<TParent> where TParent : PKCDOGJFBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<EEBLKNDEFFL<TParent>> JJHAIKOFOIC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x48F11F0", Offset = "0x48F01F0", VA = "0x1848F11F0")]
	protected EEBLKNDEFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void JPJFAMEFLHG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void GHMHGHEJPAK(string DAKIIEIEKNI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x48F0EA0", Offset = "0x48EFEA0", VA = "0x1848F0EA0")]
	public static void MJPIGAHBILK(string DAKIIEIEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x48F0C80", Offset = "0x48EFC80", VA = "0x1848F0C80")]
	public static void JBNPDFOBIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HBJGDHIMHLJ<TParent, TValue> : EEBLKNDEFFL<TParent> where TParent : PKCDOGJFBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HBJGDHIMHLJ<TParent, TValue> HPFHFAKCNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> JPACMOLHJCA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4F2E610", Offset = "0x4F2D610", VA = "0x184F2E610")]
	public bool BOIPBPENDNC(string OOENCEFPPHA, [Out] TValue LEJOFEIMONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4F2E6D0", Offset = "0x4F2D6D0", VA = "0x184F2E6D0")]
	public void CNDLHNEONMM(string OOENCEFPPHA, TValue IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4F2E780", Offset = "0x4F2D780", VA = "0x184F2E780", Slot = "4")]
	protected override void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4F2E750", Offset = "0x4F2D750", VA = "0x184F2E750", Slot = "5")]
	protected override void GHMHGHEJPAK(string OOENCEFPPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4F2E8E0", Offset = "0x4F2D8E0", VA = "0x184F2E8E0")]
	public HBJGDHIMHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PKCDOGJFBBF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJKPJELHHIJ();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PNHBOHGGLOG(string JFNKBOFNMLM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KGOIOHPOBHM(string JFNKBOFNMLM, int CAILINJCNIJ = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMPCMEHBDGO(string JFNKBOFNMLM, int IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LGCAGGOGOJD(string JFNKBOFNMLM, bool CAILINJCNIJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OPAEMOAILPO(string JFNKBOFNMLM, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float DDGOHKMNDIP(string JFNKBOFNMLM, float CAILINJCNIJ = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CGMJCLBMIAI(string JFNKBOFNMLM, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string FDBNBOEKDCK(string JFNKBOFNMLM, [Optional] string CAILINJCNIJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BAHGCFLFICC(string JFNKBOFNMLM, string IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime MMKKJECHBHD(string JFNKBOFNMLM, [Optional] DateTime GCJFFBBGOGE);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BGDIBMOFAFK(string JFNKBOFNMLM, DateTime GCJFFBBGOGE);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long ECAGAIGMAGD(string JFNKBOFNMLM, long CAILINJCNIJ);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KFCDDANPLBP(string JFNKBOFNMLM, long IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T ELLLONHMEAN<T>(string JFNKBOFNMLM, T CAILINJCNIJ, NENHAJLFEBJ<T> IPGNHICPFAP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KFKKHAHKCNA<T>(string JFNKBOFNMLM, T IOALKPFEKEK, NENHAJLFEBJ<T> IPGNHICPFAP);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MGMOOIKADCI(string JFNKBOFNMLM);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task HFJJLOCAHCL([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MHHEDKDNNNA : PKCDOGJFBBF
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CAKPLCPFELE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OBOMHHOBEOH(long CINGDDMGPMO, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CKJIJDHCFME : PKCDOGJFBBF
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CNHPFOBCBMF : MHHEDKDNNNA, PKCDOGJFBBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GAHOHHFGELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CNHPFOBCBMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x854BC90", Offset = "0x854AC90", VA = "0x18854BC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x854C060", Offset = "0x854B060", VA = "0x18854C060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IOKNLFNBGKI : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public CNHPFOBCBMF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public IOKNLFNBGKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x854F860", Offset = "0x854E860", VA = "0x18854F860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x854F8D0", Offset = "0x854E8D0", VA = "0x18854F8D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LIMLPGNCEJG GJJEAFBLFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LHCHPHCHIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool BJCFIANPJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CHEIGCLHACI EDBMOILGDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HHGNPNNJJPG BIGEANAMKGC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action CAKPLCPFELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x854BAC0", Offset = "0x854AAC0", VA = "0x18854BAC0")]
	[UnityEngine.Scripting.Preserve]
	public CNHPFOBCBMF([KELEGLJPNHI(null)] LIMLPGNCEJG GJJEAFBLFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public void NJKPJELHHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x854B970", Offset = "0x854A970", VA = "0x18854B970", Slot = "6")]
	public Task OBOMHHOBEOH(long CINGDDMGPMO, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D762F0", Offset = "0x1D752F0", VA = "0x181D762F0")]
	private static int FFFOFMHGCLD(bool IOALKPFEKEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x854BAA0", Offset = "0x854AAA0", VA = "0x18854BAA0", Slot = "9")]
	public bool PNHBOHGGLOG(string JFNKBOFNMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x854B6B0", Offset = "0x854A6B0", VA = "0x18854B6B0", Slot = "10")]
	public int KGOIOHPOBHM(string JFNKBOFNMLM, int CAILINJCNIJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x854B840", Offset = "0x854A840", VA = "0x18854B840", Slot = "11")]
	public void LMPCMEHBDGO(string JFNKBOFNMLM, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x854B750", Offset = "0x854A750", VA = "0x18854B750", Slot = "12")]
	public bool LGCAGGOGOJD(string JFNKBOFNMLM, bool CAILINJCNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x854BA00", Offset = "0x854AA00", VA = "0x18854BA00", Slot = "13")]
	public void OPAEMOAILPO(string JFNKBOFNMLM, bool IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x854B380", Offset = "0x854A380", VA = "0x18854B380", Slot = "14")]
	public float DDGOHKMNDIP(string JFNKBOFNMLM, float CAILINJCNIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x854B350", Offset = "0x854A350", VA = "0x18854B350", Slot = "15")]
	public void CGMJCLBMIAI(string JFNKBOFNMLM, float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x854B900", Offset = "0x854A900", VA = "0x18854B900", Slot = "18")]
	public DateTime MMKKJECHBHD(string JFNKBOFNMLM, [Optional] DateTime CAILINJCNIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x854B2E0", Offset = "0x854A2E0", VA = "0x18854B2E0", Slot = "19")]
	public void BGDIBMOFAFK(string JFNKBOFNMLM, DateTime GCJFFBBGOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x854B3D0", Offset = "0x854A3D0", VA = "0x18854B3D0", Slot = "20")]
	public long ECAGAIGMAGD(string JFNKBOFNMLM, long CAILINJCNIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x854B640", Offset = "0x854A640", VA = "0x18854B640", Slot = "21")]
	public void KFCDDANPLBP(string JFNKBOFNMLM, long IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3A426C0", Offset = "0x3A416C0", VA = "0x183A426C0", Slot = "22")]
	public T ELLLONHMEAN<T>(string JFNKBOFNMLM, T CAILINJCNIJ, NENHAJLFEBJ<T> IPGNHICPFAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3A42880", Offset = "0x3A41880", VA = "0x183A42880", Slot = "23")]
	public void KFKKHAHKCNA<T>(string JFNKBOFNMLM, T IOALKPFEKEK, NENHAJLFEBJ<T> IPGNHICPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3A41C90", Offset = "0x3A40C90", VA = "0x183A41C90")]
	private T EHFEMCNKEFB<T>(string JFNKBOFNMLM, T CAILINJCNIJ, [Optional] NENHAJLFEBJ<T> IFFGEKLNFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A415C0", Offset = "0x3A405C0", VA = "0x183A415C0")]
	private void CHICDBONIHK<T>(string JFNKBOFNMLM, T IOALKPFEKEK, [Optional] NENHAJLFEBJ<T> IFFGEKLNFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x854B4A0", Offset = "0x854A4A0", VA = "0x18854B4A0", Slot = "16")]
	public string FDBNBOEKDCK(string JFNKBOFNMLM, string CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x854B2B0", Offset = "0x854A2B0", VA = "0x18854B2B0", Slot = "17")]
	public void BAHGCFLFICC(string JFNKBOFNMLM, string IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x854B3B0", Offset = "0x854A3B0", VA = "0x18854B3B0")]
	private void DKMPCEKDGHD(string JFNKBOFNMLM, string IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x854B780", Offset = "0x854A780", VA = "0x18854B780")]
	private string LKOBDLHAGMH(string JFNKBOFNMLM, string CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x854B870", Offset = "0x854A870", VA = "0x18854B870", Slot = "24")]
	public void MGMOOIKADCI(string JFNKBOFNMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x854B7A0", Offset = "0x854A7A0", VA = "0x18854B7A0")]
	private string LLBMFDEECNH(string DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x854B4D0", Offset = "0x854A4D0", VA = "0x18854B4D0", Slot = "25")]
	[AsyncStateMachine(typeof(GAHOHHFGELN))]
	public Task HFJJLOCAHCL(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x854B5C0", Offset = "0x854A5C0", VA = "0x18854B5C0")]
	[IteratorStateMachine(typeof(IOKNLFNBGKI))]
	private IEnumerator<CMMCHACHDBH> JIMADLICAHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x854B440", Offset = "0x854A440", VA = "0x18854B440")]
	private void EJOFFOCEHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x854BA30", Offset = "0x854AA30", VA = "0x18854BA30")]
	private void PBCEJBEAKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x854B6E0", Offset = "0x854A6E0", VA = "0x18854B6E0")]
	private void LBJADCHINIB(bool NCJKNKMMNAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BCHEBADNCHH : MHHEDKDNNNA, PKCDOGJFBBF
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
	private Dictionary<string, string> EJGMPNJHBMK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string LKDDHJMEOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x854AD20", Offset = "0x8549D20", VA = "0x18854AD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> AKFPPOCLHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x854AFB0", Offset = "0x8549FB0", VA = "0x18854AFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action CAKPLCPFELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	[UnityEngine.Scripting.Preserve]
	public BCHEBADNCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public void NJKPJELHHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x854B120", Offset = "0x854A120", VA = "0x18854B120", Slot = "6")]
	public Task OBOMHHOBEOH(long CINGDDMGPMO, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x854A620", Offset = "0x8549620", VA = "0x18854A620", Slot = "14")]
	public float DDGOHKMNDIP(string DAKIIEIEKNI, float CAILINJCNIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x854B1B0", Offset = "0x854A1B0", VA = "0x18854B1B0", Slot = "13")]
	public void OPAEMOAILPO(string DAKIIEIEKNI, bool IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x854AE70", Offset = "0x8549E70", VA = "0x18854AE70", Slot = "12")]
	public bool LGCAGGOGOJD(string DAKIIEIEKNI, bool CAILINJCNIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x854AE00", Offset = "0x8549E00", VA = "0x18854AE00", Slot = "10")]
	public int KGOIOHPOBHM(string DAKIIEIEKNI, int CAILINJCNIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x854B0B0", Offset = "0x854A0B0", VA = "0x18854B0B0", Slot = "18")]
	public DateTime MMKKJECHBHD(string JFNKBOFNMLM, [Optional] DateTime CAILINJCNIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x854A540", Offset = "0x8549540", VA = "0x18854A540", Slot = "19")]
	public void BGDIBMOFAFK(string DAKIIEIEKNI, DateTime IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x854A5B0", Offset = "0x85495B0", VA = "0x18854A5B0", Slot = "15")]
	public void CGMJCLBMIAI(string DAKIIEIEKNI, float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x854AF40", Offset = "0x8549F40", VA = "0x18854AF40", Slot = "11")]
	public void LMPCMEHBDGO(string DAKIIEIEKNI, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x854A690", Offset = "0x8549690", VA = "0x18854A690", Slot = "20")]
	public long ECAGAIGMAGD(string JFNKBOFNMLM, long CAILINJCNIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x854AD90", Offset = "0x8549D90", VA = "0x18854AD90", Slot = "21")]
	public void KFCDDANPLBP(string JFNKBOFNMLM, long IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x39D1810", Offset = "0x39D0810", VA = "0x1839D1810", Slot = "22")]
	public T ELLLONHMEAN<T>(string JFNKBOFNMLM, T CAILINJCNIJ, NENHAJLFEBJ<T> IPGNHICPFAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x39D1920", Offset = "0x39D0920", VA = "0x1839D1920", Slot = "23")]
	public void KFKKHAHKCNA<T>(string JFNKBOFNMLM, T IOALKPFEKEK, NENHAJLFEBJ<T> IPGNHICPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x854A700", Offset = "0x8549700", VA = "0x18854A700", Slot = "16")]
	public string FDBNBOEKDCK(string DAKIIEIEKNI, string CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x854A4A0", Offset = "0x85494A0", VA = "0x18854A4A0", Slot = "17")]
	public void BAHGCFLFICC(string DAKIIEIEKNI, string IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x854AFF0", Offset = "0x8549FF0", VA = "0x18854AFF0", Slot = "24")]
	public void MGMOOIKADCI(string DAKIIEIEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x854B220", Offset = "0x854A220", VA = "0x18854B220", Slot = "9")]
	public bool PNHBOHGGLOG(string DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x854AAB0", Offset = "0x8549AB0", VA = "0x18854AAB0", Slot = "25")]
	public Task HFJJLOCAHCL(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x39D19C0", Offset = "0x39D09C0", VA = "0x1839D19C0")]
	private T LMKONLJOAEP<T>(string JFNKBOFNMLM, T CAILINJCNIJ, [Optional] NENHAJLFEBJ<T> IFFGEKLNFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x39D2AE0", Offset = "0x39D1AE0", VA = "0x1839D2AE0")]
	private void ODADMGGOEJG<T>(string JFNKBOFNMLM, T IOALKPFEKEK, [Optional] NENHAJLFEBJ<T> IFFGEKLNFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x854A7B0", Offset = "0x85497B0", VA = "0x18854A7B0")]
	private Dictionary<string, string> FNMBEEJICKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CPIHOGHLCHC
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action CAKPLCPFELE;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJKPJELHHIJ();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FOBAEADCDML(long CINGDDMGPMO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NMHBKDINJNP(KFLKGCBAEIP FIMOCOMGJAJ = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFBMHIMNKFJ(string JFNKBOFNMLM, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LKEBDMJFMHN(string JFNKBOFNMLM, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string DEOCIBGGEIF(string JFNKBOFNMLM, [Optional] string CAILINJCNIJ, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HBINLHPKDAK FJHEJKFLHGM(string JFNKBOFNMLM, string IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int FKDGIAHGLMF(string JFNKBOFNMLM, int CAILINJCNIJ = 0, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HBINLHPKDAK CILGNJMELPN(string JFNKBOFNMLM, int IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NKPOMEELBBE(string JFNKBOFNMLM, bool CAILINJCNIJ, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HBINLHPKDAK KELFJOALDEH(string JFNKBOFNMLM, bool IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float MBHMDJMBMAF(string JFNKBOFNMLM, float CAILINJCNIJ = 0f, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HBINLHPKDAK ALDNMJJPEJD(string JFNKBOFNMLM, float IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime NKKMCGBFEEC(string JFNKBOFNMLM, [Optional] DateTime CAILINJCNIJ, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HBINLHPKDAK KEIJPBLGFNB(string JFNKBOFNMLM, DateTime IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long OKGMBADIEED(string JFNKBOFNMLM, long CAILINJCNIJ = 0L, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	HBINLHPKDAK HGGPNBPONGI(string JFNKBOFNMLM, long IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T CMLLOOMFKIG<T>(string JFNKBOFNMLM, [Optional] T CAILINJCNIJ, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	HBINLHPKDAK JFINDALKCBI<T>(string JFNKBOFNMLM, T IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool HHPKGPBBHDE(string JFNKBOFNMLM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool FEEGOGOFDHL(string JFNKBOFNMLM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string JNEGAKLMHJK(string JFNKBOFNMLM, [Optional] string CAILINJCNIJ);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	HBINLHPKDAK BJGNDJMNEBJ(string JFNKBOFNMLM, string IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int KKIPNPODDAM(string JFNKBOFNMLM, int CAILINJCNIJ = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HBINLHPKDAK PNHJCFHLFAM(string JFNKBOFNMLM, int IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IEHNMJFJCGH(string JFNKBOFNMLM, bool CAILINJCNIJ);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	HBINLHPKDAK MNGJHCHPDAB(string JFNKBOFNMLM, bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float DMBMJIOLKIB(string JFNKBOFNMLM, float CAILINJCNIJ = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	HBINLHPKDAK DMIMLIHOCAJ(string JFNKBOFNMLM, float IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime CKPBDFDOPFH(string JFNKBOFNMLM, [Optional] DateTime CAILINJCNIJ);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	HBINLHPKDAK FHGBBMCIEOH(string JFNKBOFNMLM, DateTime IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long CLCKBIDDEND(string JFNKBOFNMLM, long CAILINJCNIJ = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	HBINLHPKDAK FDOLNAEBNJI(string JFNKBOFNMLM, long IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void MLPPAAGOBFL<T>(NENHAJLFEBJ<T> IPGNHICPFAP, [Optional] IEqualityComparer<T> FFIFKGOLOOF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void COLGHALKAGA<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable KBFKIDDDGDB();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AHCHHHAFONJ(float GLANCCCAPLO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task EJOFFOCEHCP([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum HBINLHPKDAK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HCODKICGADL : CPIHOGHLCHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class HBLBPJPKBCH
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<HBLBPJPKBCH> HOMJBGPHGCH;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x854C0C0", Offset = "0x854B0C0", VA = "0x18854C0C0")]
		public static void JBNPDFOBIPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void JPJFAMEFLHG();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		protected HBLBPJPKBCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class MNDIJFNKHNE<T> : HBLBPJPKBCH
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly MNDIJFNKHNE<T> KONBGMLOLPI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NENHAJLFEBJ<T> AFMEFIDKGIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> LDMLBDHAMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool PNPPINBFKFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x48E37D0", Offset = "0x48E27D0", VA = "0x1848E37D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x56F6350", Offset = "0x56F5350", VA = "0x1856F6350")]
		private MNDIJFNKHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x56F5DB0", Offset = "0x56F4DB0", VA = "0x1856F5DB0")]
		public void AMNFOKHCMAP(NENHAJLFEBJ<T> IFFGEKLNFGD, [Optional] IEqualityComparer<T> FFIFKGOLOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x56F61D0", Offset = "0x56F51D0", VA = "0x1856F61D0", Slot = "4")]
		public override void JPJFAMEFLHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class LGFAMKLGKCM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly HCODKICGADL LHNCCIJJJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object ODGIAHLJNKL;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8551F50", Offset = "0x8550F50", VA = "0x188551F50")]
		public LGFAMKLGKCM(HCODKICGADL LHNCCIJJJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8551F20", Offset = "0x8550F20", VA = "0x188551F20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct HIMMBOAPHNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HCODKICGADL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x854F480", Offset = "0x854E480", VA = "0x18854F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x854F770", Offset = "0x854E770", VA = "0x18854F770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MLDMOOFEEPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public HCODKICGADL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PKCDOGJFBBF backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85529C0", Offset = "0x85519C0", VA = "0x1885529C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct LFJMKHIIBCI : IAsyncStateMachine
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
		public HCODKICGADL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x85519F0", Offset = "0x85509F0", VA = "0x1885519F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8551EC0", Offset = "0x8550EC0", VA = "0x188551EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FPLCJAGOBGE : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public HCODKICGADL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public FPLCJAGOBGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x854BBB0", Offset = "0x854ABB0", VA = "0x18854BBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x854BC40", Offset = "0x854AC40", VA = "0x18854BC40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly MHHEDKDNNNA FAPAOLOGKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly MHHEDKDNNNA DAAJKKHJAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly CKJIJDHCFME GMBNFJGAGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly CHEIGCLHACI EDBMOILGDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly LPDHFFLAMPA.MMANJKPLENO GLMGIPNJIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IDNPIOCKKCM OIIIBGPKMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<PKCDOGJFBBF> MCDELFCKEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task LOEOPKDHOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> KIPNCEEPPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private HHGNPNNJJPG LONNOMGHINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object JBKCCACCBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object OLMCLGEPOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long JCJOKKABBGH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool DEPPAGMLPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x854E620", Offset = "0x854D620", VA = "0x18854E620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource IFPHFMIKPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action CAKPLCPFELE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x854E280", Offset = "0x854D280", VA = "0x18854E280", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x854C6B0", Offset = "0x854B6B0", VA = "0x18854C6B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x854CDA0", Offset = "0x854BDA0", VA = "0x18854CDA0")]
	[GOMLKAICHII.NIENCEEHOCF]
	internal static void EKOODCFGNGC(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x854F0B0", Offset = "0x854E0B0", VA = "0x18854F0B0")]
	[UnityEngine.Scripting.Preserve]
	public HCODKICGADL([KELEGLJPNHI("Disk")] MHHEDKDNNNA FAPAOLOGKHM, [KELEGLJPNHI("Cloud")] MHHEDKDNNNA DAAJKKHJAJB, [KELEGLJPNHI(null)] CKJIJDHCFME GMBNFJGAGKB, [KELEGLJPNHI(null)] CHEIGCLHACI EDBMOILGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x854CC50", Offset = "0x854BC50", VA = "0x18854CC50", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x854E7A0", Offset = "0x854D7A0", VA = "0x18854E7A0")]
	private void NFBAAJPBOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x854E7F0", Offset = "0x854D7F0", VA = "0x18854E7F0", Slot = "6")]
	public void NJKPJELHHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x854D0B0", Offset = "0x854C0B0", VA = "0x18854D0B0", Slot = "7")]
	public Task FOBAEADCDML(long CINGDDMGPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x854C5A0", Offset = "0x854B5A0", VA = "0x18854C5A0")]
	[AsyncStateMachine(typeof(HIMMBOAPHNO))]
	private Task BLAAOPGBKFG(long CINGDDMGPMO, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x854CC90", Offset = "0x854BC90", VA = "0x18854CC90")]
	private void EHADIMNGAHM(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x854D670", Offset = "0x854C670", VA = "0x18854D670")]
	private void HIGJECOJOAM(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x854E1C0", Offset = "0x854D1C0", VA = "0x18854E1C0")]
	private string KPKLPAKDLOB(string BILIPLGHDJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x854D8D0", Offset = "0x854C8D0", VA = "0x18854D8D0")]
	private void IGAKABJMDDI(KFLKGCBAEIP FIMOCOMGJAJ, string DAKIIEIEKNI, [Out] MHHEDKDNNNA PILOPLPMHHB, [Out] string AHBMGKHFPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x854EEC0", Offset = "0x854DEC0", VA = "0x18854EEC0")]
	private MHHEDKDNNNA PMMJBAIAFPD(KFLKGCBAEIP FIMOCOMGJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x854EAF0", Offset = "0x854DAF0", VA = "0x18854EAF0", Slot = "8")]
	public bool NMHBKDINJNP(KFLKGCBAEIP FIMOCOMGJAJ = KFLKGCBAEIP.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x854E550", Offset = "0x854D550", VA = "0x18854E550", Slot = "9")]
	public bool MFBMHIMNKFJ(string JFNKBOFNMLM, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x854E320", Offset = "0x854D320", VA = "0x18854E320", Slot = "10")]
	public bool LKEBDMJFMHN(string JFNKBOFNMLM, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x854CAE0", Offset = "0x854BAE0", VA = "0x18854CAE0", Slot = "11")]
	public string DEOCIBGGEIF(string JFNKBOFNMLM, [Optional] string CAILINJCNIJ, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x854CE80", Offset = "0x854BE80", VA = "0x18854CE80", Slot = "12")]
	public HBINLHPKDAK FJHEJKFLHGM(string JFNKBOFNMLM, string IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x854D000", Offset = "0x854C000", VA = "0x18854D000", Slot = "13")]
	public int FKDGIAHGLMF(string JFNKBOFNMLM, int CAILINJCNIJ = 0, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x854C890", Offset = "0x854B890", VA = "0x18854C890", Slot = "14")]
	public HBINLHPKDAK CILGNJMELPN(string JFNKBOFNMLM, int IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x854E900", Offset = "0x854D900", VA = "0x18854E900", Slot = "15")]
	public bool NKPOMEELBBE(string JFNKBOFNMLM, bool CAILINJCNIJ, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x854DFE0", Offset = "0x854CFE0", VA = "0x18854DFE0", Slot = "16")]
	public HBINLHPKDAK KELFJOALDEH(string JFNKBOFNMLM, bool IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x854E4A0", Offset = "0x854D4A0", VA = "0x18854E4A0", Slot = "17")]
	public float MBHMDJMBMAF(string JFNKBOFNMLM, float CAILINJCNIJ = 0f, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x854C3F0", Offset = "0x854B3F0", VA = "0x18854C3F0", Slot = "18")]
	public HBINLHPKDAK ALDNMJJPEJD(string JFNKBOFNMLM, float IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x854E860", Offset = "0x854D860", VA = "0x18854E860", Slot = "19")]
	public DateTime NKKMCGBFEEC(string JFNKBOFNMLM, [Optional] DateTime CAILINJCNIJ, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x854DE40", Offset = "0x854CE40", VA = "0x18854DE40", Slot = "20")]
	public HBINLHPKDAK KEIJPBLGFNB(string JFNKBOFNMLM, DateTime IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x854EBB0", Offset = "0x854DBB0", VA = "0x18854EBB0", Slot = "21")]
	public long OKGMBADIEED(string JFNKBOFNMLM, long CAILINJCNIJ = 0L, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x854D4A0", Offset = "0x854C4A0", VA = "0x18854D4A0", Slot = "22")]
	public HBINLHPKDAK HGGPNBPONGI(string JFNKBOFNMLM, long IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C540", Offset = "0x3C6B540", VA = "0x183C6C540", Slot = "23")]
	public T CMLLOOMFKIG<T>(string JFNKBOFNMLM, [Optional] T CAILINJCNIJ, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C540", Offset = "0x3C6B540", VA = "0x183C6C540", Slot = "24")]
	public HBINLHPKDAK JFINDALKCBI<T>(string JFNKBOFNMLM, T IOALKPFEKEK, KFLKGCBAEIP LFEDKONNNLP = KFLKGCBAEIP.CLOUD)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x854D610", Offset = "0x854C610", VA = "0x18854D610", Slot = "25")]
	public bool HHPKGPBBHDE(string JFNKBOFNMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x854CE40", Offset = "0x854BE40", VA = "0x18854CE40", Slot = "26")]
	public bool FEEGOGOFDHL(string JFNKBOFNMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x854DCF0", Offset = "0x854CCF0", VA = "0x18854DCF0", Slot = "27")]
	public string JNEGAKLMHJK(string JFNKBOFNMLM, [Optional] string CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x854C570", Offset = "0x854B570", VA = "0x18854C570", Slot = "28")]
	public HBINLHPKDAK BJGNDJMNEBJ(string JFNKBOFNMLM, string IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x854E150", Offset = "0x854D150", VA = "0x18854E150", Slot = "29")]
	public int KKIPNPODDAM(string JFNKBOFNMLM, int CAILINJCNIJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x854EF40", Offset = "0x854DF40", VA = "0x18854EF40", Slot = "30")]
	public HBINLHPKDAK PNHJCFHLFAM(string JFNKBOFNMLM, int IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x854D860", Offset = "0x854C860", VA = "0x18854D860", Slot = "31")]
	public bool IEHNMJFJCGH(string JFNKBOFNMLM, bool CAILINJCNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x854E5F0", Offset = "0x854D5F0", VA = "0x18854E5F0", Slot = "32")]
	public HBINLHPKDAK MNGJHCHPDAB(string JFNKBOFNMLM, bool IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x854CBB0", Offset = "0x854BBB0", VA = "0x18854CBB0", Slot = "33")]
	public float DMBMJIOLKIB(string JFNKBOFNMLM, float CAILINJCNIJ = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x854CC20", Offset = "0x854BC20", VA = "0x18854CC20", Slot = "34")]
	public HBINLHPKDAK DMIMLIHOCAJ(string JFNKBOFNMLM, float IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x854CA00", Offset = "0x854BA00", VA = "0x18854CA00", Slot = "35")]
	public DateTime CKPBDFDOPFH(string JFNKBOFNMLM, [Optional] DateTime CAILINJCNIJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x854CE50", Offset = "0x854BE50", VA = "0x18854CE50", Slot = "36")]
	public HBINLHPKDAK FHGBBMCIEOH(string JFNKBOFNMLM, DateTime IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x854CA70", Offset = "0x854BA70", VA = "0x18854CA70", Slot = "37")]
	public long CLCKBIDDEND(string JFNKBOFNMLM, long CAILINJCNIJ = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x854CE10", Offset = "0x854BE10", VA = "0x18854CE10", Slot = "38")]
	public HBINLHPKDAK FDOLNAEBNJI(string JFNKBOFNMLM, long IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x854E220", Offset = "0x854D220", VA = "0x18854E220")]
	private bool LEPPDINGBEB(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x854E640", Offset = "0x854D640", VA = "0x18854E640")]
	private bool NBDJPPJDNIO(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x854D280", Offset = "0x854C280", VA = "0x18854D280")]
	private HBINLHPKDAK FOPCFJECHEE(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, string IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x854EF70", Offset = "0x854DF70", VA = "0x18854EF70")]
	private HBINLHPKDAK PPMIFDAFPDC(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, int IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x854C750", Offset = "0x854B750", VA = "0x18854C750")]
	private HBINLHPKDAK CHHNOBPOIOA(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, bool IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x854C290", Offset = "0x854B290", VA = "0x18854C290")]
	private HBINLHPKDAK AEKJKJGIDGG(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, float IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x854D6F0", Offset = "0x854C6F0", VA = "0x18854D6F0")]
	private HBINLHPKDAK IBPIHLLLBGB(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, DateTime IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x854E9B0", Offset = "0x854D9B0", VA = "0x18854E9B0")]
	private HBINLHPKDAK NLKEKFCIACH(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, long IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D400", Offset = "0x3C6C400", VA = "0x183C6D400")]
	private T LAMDLIKFFCC<T>(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, T CAILINJCNIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C7C0", Offset = "0x3C6B7C0", VA = "0x183C6C7C0")]
	private HBINLHPKDAK HKOLLKPGNHG<T>(PKCDOGJFBBF PILOPLPMHHB, string JFNKBOFNMLM, T IOALKPFEKEK)
	{
		return default(HBINLHPKDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D900", Offset = "0x3C6C900", VA = "0x183C6D900", Slot = "39")]
	public void MLPPAAGOBFL<T>(NENHAJLFEBJ<T> IPGNHICPFAP, [Optional] IEqualityComparer<T> FFIFKGOLOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C740", Offset = "0x3C6B740", VA = "0x183C6C740", Slot = "40")]
	public void COLGHALKAGA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x854D3D0", Offset = "0x854C3D0", VA = "0x18854D3D0")]
	[AsyncStateMachine(typeof(MLDMOOFEEPK))]
	private void HFJJLOCAHCL(PKCDOGJFBBF MFMBHBFAGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x854CCB0", Offset = "0x854BCB0", VA = "0x18854CCB0", Slot = "43")]
	[AsyncStateMachine(typeof(LFJMKHIIBCI))]
	public Task EJOFFOCEHCP([Optional] CancellationToken GFDDDAIMFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x854EC50", Offset = "0x854DC50", VA = "0x18854EC50")]
	private void ONLBPAHKPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x854DD60", Offset = "0x854CD60", VA = "0x18854DD60", Slot = "41")]
	public IDisposable KBFKIDDDGDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x854C3E0", Offset = "0x854B3E0", VA = "0x18854C3E0", Slot = "42")]
	public void AHCHHHAFONJ(float GLANCCCAPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x854DA70", Offset = "0x854CA70", VA = "0x18854DA70")]
	private void IJFEMHAFIKF(float EFEEIJOHEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x854EE30", Offset = "0x854DE30", VA = "0x18854EE30")]
	[IteratorStateMachine(typeof(FPLCJAGOBGE))]
	private IEnumerator<CMMCHACHDBH> PJMHPCGMMIO(float GLANCCCAPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x854CB80", Offset = "0x854BB80", VA = "0x18854CB80")]
	[CompilerGenerated]
	private void DGKGIMIHBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KGAOMNHEBPA : LHFIDOIGCLG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static KGAOMNHEBPA KONBGMLOLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x854F920", Offset = "0x854E920", VA = "0x18854F920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x854F970", Offset = "0x854E970", VA = "0x18854F970", Slot = "9")]
	public override string FBGBLPHHDGN(bool JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x854FA60", Offset = "0x854EA60", VA = "0x18854FA60", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] bool IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x854FD80", Offset = "0x854ED80", VA = "0x18854FD80")]
	public KGAOMNHEBPA()
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
