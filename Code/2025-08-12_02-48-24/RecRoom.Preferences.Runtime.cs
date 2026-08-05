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
		[Cpp2IlInjected.Address(RVA = "0x8841600", Offset = "0x883FC00", VA = "0x188841600", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NOMEIMIJJMB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class KEKLIIBDJBL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void KGLGOAAOHPC(HEGDHPPEDCK GKGDJLDIAOH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x883D430", Offset = "0x883BA30", VA = "0x18883D430")]
	private static void HGOPDDNDPOP(HEGDHPPEDCK GKGDJLDIAOH, KGLGOAAOHPC EDEPFLICLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x883D8B0", Offset = "0x883BEB0", VA = "0x18883D8B0")]
	public static bool PIAJEGNEEBO(this HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, [Optional] KGLGOAAOHPC EDEPFLICLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x883D4B0", Offset = "0x883BAB0", VA = "0x18883D4B0")]
	public static PCEJLDALHID LFKIODGNAHJ(this HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, string FKMNCAKIOFK, [Optional] KGLGOAAOHPC EDEPFLICLHP)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x883D2F0", Offset = "0x883B8F0", VA = "0x18883D2F0")]
	public static PCEJLDALHID EPDADPFMKGD(this HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, int FKMNCAKIOFK, [Optional] KGLGOAAOHPC EDEPFLICLHP)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x883D060", Offset = "0x883B660", VA = "0x18883D060")]
	public static PCEJLDALHID BKFHIBAHNKF(this HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, bool FKMNCAKIOFK, [Optional] KGLGOAAOHPC EDEPFLICLHP)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x883D1A0", Offset = "0x883B7A0", VA = "0x18883D1A0")]
	public static PCEJLDALHID CCBNDHHBLLB(this HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, float FKMNCAKIOFK, [Optional] KGLGOAAOHPC EDEPFLICLHP)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x883D600", Offset = "0x883BC00", VA = "0x18883D600")]
	public static PCEJLDALHID NILAKNDMLCJ(this HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, DateTime FKMNCAKIOFK, [Optional] KGLGOAAOHPC EDEPFLICLHP)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x883D770", Offset = "0x883BD70", VA = "0x18883D770")]
	public static PCEJLDALHID OBLJLOLIKEG(this HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, long FKMNCAKIOFK, [Optional] KGLGOAAOHPC EDEPFLICLHP)
	{
		return default(PCEJLDALHID);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IHKNKLHFMHC : AHBOLFJPCBL, HEGDHPPEDCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HFEDECNGICG CEKLBFHKPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> IHDGCEIPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> FKBHEJGACFE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> GJJCBKNHJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x883BAE0", Offset = "0x883A0E0", VA = "0x18883BAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action JKNOFKLBKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x883C860", Offset = "0x883AE60", VA = "0x18883C860")]
	[UnityEngine.Scripting.Preserve]
	public IHKNKLHFMHC([OEKMEJFDAAI(null)] HFEDECNGICG CEKLBFHKPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
	public void EDOFINOBNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x883B270", Offset = "0x8839870", VA = "0x18883B270")]
	private DirectoryInfo DLHAOLPGFPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x883B470", Offset = "0x8839A70", VA = "0x18883B470", Slot = "6")]
	public Task GDCLHBNJOKN(long BAAFLHIICBP, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x883B500", Offset = "0x8839B00", VA = "0x18883B500", Slot = "14")]
	public float GHLJBFNGJAM(string HFLDIIIPBCG, float DAKPJNHJLJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x883C360", Offset = "0x883A960", VA = "0x18883C360", Slot = "13")]
	public void MGIONEFNEJK(string HFLDIIIPBCG, bool FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x883B5E0", Offset = "0x8839BE0", VA = "0x18883B5E0", Slot = "12")]
	public bool HHKGHPGANPJ(string HFLDIIIPBCG, bool DAKPJNHJLJO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x883AF90", Offset = "0x8839590", VA = "0x18883AF90", Slot = "10")]
	public int BFKOPJPKKEI(string HFLDIIIPBCG, int DAKPJNHJLJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x883C2F0", Offset = "0x883A8F0", VA = "0x18883C2F0", Slot = "18")]
	public DateTime LLDLGNCGPFB(string NBPDNNFOMKB, [Optional] DateTime DAKPJNHJLJO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x883C7F0", Offset = "0x883ADF0", VA = "0x18883C7F0", Slot = "19")]
	public void PDPDOCANGKC(string HFLDIIIPBCG, DateTime FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x883B6B0", Offset = "0x8839CB0", VA = "0x18883B6B0", Slot = "15")]
	public void HMADIDFKLEM(string HFLDIIIPBCG, float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x883B200", Offset = "0x8839800", VA = "0x18883B200", Slot = "11")]
	public void DIEHJLOKIBP(string HFLDIIIPBCG, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x883C780", Offset = "0x883AD80", VA = "0x18883C780", Slot = "20")]
	public long OIKGPPJLLJN(string NBPDNNFOMKB, long DAKPJNHJLJO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x883C3D0", Offset = "0x883A9D0", VA = "0x18883C3D0", Slot = "21")]
	public void NDCBBKNPDMN(string NBPDNNFOMKB, long FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB500", Offset = "0x3BC9B00", VA = "0x183BCB500", Slot = "22")]
	public T CMBLHEFFCHD<T>(string NBPDNNFOMKB, T DAKPJNHJLJO, GODPFAGNMEF<T> GMAPFBEEHAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB610", Offset = "0x3BC9C10", VA = "0x183BCB610", Slot = "23")]
	public void DGLEOLFPOAM<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, GODPFAGNMEF<T> GMAPFBEEHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x883B000", Offset = "0x8839600", VA = "0x18883B000", Slot = "16")]
	public string BIOEEPCDPBO(string HFLDIIIPBCG, string DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x883B570", Offset = "0x8839B70", VA = "0x18883B570", Slot = "17")]
	public void HDHAMEDMCGN(string HFLDIIIPBCG, string FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x883B0B0", Offset = "0x88396B0", VA = "0x18883B0B0", Slot = "24")]
	public void BNDCEMELKOF(string HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x883AF00", Offset = "0x8839500", VA = "0x18883AF00", Slot = "9")]
	public bool AKCFKHHOOKL(string HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x883C440", Offset = "0x883AA40", VA = "0x18883C440", Slot = "25")]
	public Task NHDMDIKNDJL(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x883B720", Offset = "0x8839D20", VA = "0x18883B720")]
	private void JDNMAMNCGLP(DirectoryInfo PANMLBHPPDI, string IGFNKJHMION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x883AD00", Offset = "0x8839300", VA = "0x18883AD00")]
	private static string AGPHCHBEFIH(string HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x883B370", Offset = "0x8839970", VA = "0x18883B370")]
	private static string FJPCIMNOMNL(byte[] NCMOHOAIBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F310", Offset = "0x3E0D910", VA = "0x183E0F310")]
	private T JLOHDPKHFGN<T>(string NBPDNNFOMKB, T DAKPJNHJLJO, [Optional] GODPFAGNMEF<T> EEDEFNHGEJA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E0E0C0", Offset = "0x3E0C6C0", VA = "0x183E0E0C0")]
	private void ADPGIIFDGLO<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, [Optional] GODPFAGNMEF<T> EEDEFNHGEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x883BB20", Offset = "0x883A120", VA = "0x18883BB20")]
	private Dictionary<string, string> LIENNOCFAHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class KDDHFCLPINC
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x883CF10", Offset = "0x883B510", VA = "0x18883CF10")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	internal static void EBJPFNJLIPM(CFPMHDJNIAH LOLOEONEEKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BEFIOMNOGAJ : KMAPPFONJOA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x88389F0", Offset = "0x8836FF0", VA = "0x1888389F0")]
	[UnityEngine.Scripting.Preserve]
	public BEFIOMNOGAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KMAPPFONJOA : AHBOLFJPCBL, HEGDHPPEDCK, EDOJNDCLIKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> FJFFNHMMFOM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JKNOFKLBKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
	public void EDOFINOBNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x883DBF0", Offset = "0x883C1F0", VA = "0x18883DBF0", Slot = "6")]
	public Task GDCLHBNJOKN(long BAAFLHIICBP, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x883DA10", Offset = "0x883C010", VA = "0x18883DA10", Slot = "9")]
	public bool AKCFKHHOOKL(string NBPDNNFOMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x883DA70", Offset = "0x883C070", VA = "0x18883DA70", Slot = "10")]
	public int BFKOPJPKKEI(string NBPDNNFOMKB, int DAKPJNHJLJO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x883DB90", Offset = "0x883C190", VA = "0x18883DB90", Slot = "11")]
	public void DIEHJLOKIBP(string NBPDNNFOMKB, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x883DD40", Offset = "0x883C340", VA = "0x18883DD40", Slot = "12")]
	public bool HHKGHPGANPJ(string NBPDNNFOMKB, bool DAKPJNHJLJO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x883DE60", Offset = "0x883C460", VA = "0x18883DE60", Slot = "13")]
	public void MGIONEFNEJK(string NBPDNNFOMKB, bool FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x883DC80", Offset = "0x883C280", VA = "0x18883DC80", Slot = "14")]
	public float GHLJBFNGJAM(string NBPDNNFOMKB, float DAKPJNHJLJO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x883DDA0", Offset = "0x883C3A0", VA = "0x18883DDA0", Slot = "15")]
	public void HMADIDFKLEM(string NBPDNNFOMKB, float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x883DAD0", Offset = "0x883C0D0", VA = "0x18883DAD0", Slot = "16")]
	public string BIOEEPCDPBO(string NBPDNNFOMKB, [Optional] string DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x883DCE0", Offset = "0x883C2E0", VA = "0x18883DCE0", Slot = "17")]
	public void HDHAMEDMCGN(string NBPDNNFOMKB, string FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x883DE00", Offset = "0x883C400", VA = "0x18883DE00", Slot = "18")]
	public DateTime LLDLGNCGPFB(string NBPDNNFOMKB, [Optional] DateTime DAKPJNHJLJO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x883E010", Offset = "0x883C610", VA = "0x18883E010", Slot = "19")]
	public void PDPDOCANGKC(string NBPDNNFOMKB, DateTime FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x883DFB0", Offset = "0x883C5B0", VA = "0x18883DFB0", Slot = "20")]
	public long OIKGPPJLLJN(string NBPDNNFOMKB, long DAKPJNHJLJO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x883DEC0", Offset = "0x883C4C0", VA = "0x18883DEC0", Slot = "21")]
	public void NDCBBKNPDMN(string NBPDNNFOMKB, long FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E67270", Offset = "0x3E65870", VA = "0x183E67270", Slot = "22")]
	public T CMBLHEFFCHD<T>(string NBPDNNFOMKB, T DAKPJNHJLJO, GODPFAGNMEF<T> GMAPFBEEHAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E67370", Offset = "0x3E65970", VA = "0x183E67370", Slot = "23")]
	public void DGLEOLFPOAM<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, GODPFAGNMEF<T> GMAPFBEEHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E67410", Offset = "0x3E65A10", VA = "0x183E67410")]
	public T JLOHDPKHFGN<T>(string NBPDNNFOMKB, T DAKPJNHJLJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E66D80", Offset = "0x3E65380", VA = "0x183E66D80")]
	public void ADPGIIFDGLO<T>(string NBPDNNFOMKB, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x883DB30", Offset = "0x883C130", VA = "0x18883DB30", Slot = "24")]
	public void BNDCEMELKOF(string NBPDNNFOMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x883DF20", Offset = "0x883C520", VA = "0x18883DF20", Slot = "25")]
	public Task NHDMDIKNDJL(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88389F0", Offset = "0x8836FF0", VA = "0x1888389F0")]
	public KMAPPFONJOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class CMPLJHJJDOE<TParent> where TParent : HEGDHPPEDCK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<CMPLJHJJDOE<TParent>> HKAJOCMCFOB;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7D10", Offset = "0x6EC6310", VA = "0x186EC7D10")]
	protected CMPLJHJJDOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void OOIGDCNPPFG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void AHCBFFCEKHI(string HFLDIIIPBCG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7760", Offset = "0x6EC5D60", VA = "0x186EC7760")]
	public static void HODIBONHAMK(string HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC79A0", Offset = "0x6EC5FA0", VA = "0x186EC79A0")]
	public static void LNHOKMONKAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GLBLIDOLPBN<TParent, TValue> : CMPLJHJJDOE<TParent> where TParent : HEGDHPPEDCK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly GLBLIDOLPBN<TParent, TValue> COLNIIHALMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> FIMCDAIDMJP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5120", Offset = "0x4FF3720", VA = "0x184FF5120")]
	public bool NBJEBNMBDKD(string OMKCFPLCHGE, [Out] TValue GDHICCHEJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5070", Offset = "0x4FF3670", VA = "0x184FF5070")]
	public void EALFPHFFNLM(string OMKCFPLCHGE, TValue FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5160", Offset = "0x4FF3760", VA = "0x184FF5160", Slot = "4")]
	protected override void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4FF0", Offset = "0x4FF35F0", VA = "0x184FF4FF0", Slot = "5")]
	protected override void AHCBFFCEKHI(string OMKCFPLCHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4FF52C0", Offset = "0x4FF38C0", VA = "0x184FF52C0")]
	public GLBLIDOLPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HEGDHPPEDCK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDOFINOBNCO();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKCFKHHOOKL(string NBPDNNFOMKB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BFKOPJPKKEI(string NBPDNNFOMKB, int DAKPJNHJLJO = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIEHJLOKIBP(string NBPDNNFOMKB, int FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HHKGHPGANPJ(string NBPDNNFOMKB, bool DAKPJNHJLJO = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGIONEFNEJK(string NBPDNNFOMKB, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float GHLJBFNGJAM(string NBPDNNFOMKB, float DAKPJNHJLJO = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HMADIDFKLEM(string NBPDNNFOMKB, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string BIOEEPCDPBO(string NBPDNNFOMKB, [Optional] string DAKPJNHJLJO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HDHAMEDMCGN(string NBPDNNFOMKB, string FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime LLDLGNCGPFB(string NBPDNNFOMKB, [Optional] DateTime BPMDCNPGKDC);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PDPDOCANGKC(string NBPDNNFOMKB, DateTime BPMDCNPGKDC);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long OIKGPPJLLJN(string NBPDNNFOMKB, long DAKPJNHJLJO);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NDCBBKNPDMN(string NBPDNNFOMKB, long FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T CMBLHEFFCHD<T>(string NBPDNNFOMKB, T DAKPJNHJLJO, GODPFAGNMEF<T> GMAPFBEEHAF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DGLEOLFPOAM<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, GODPFAGNMEF<T> GMAPFBEEHAF);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BNDCEMELKOF(string NBPDNNFOMKB);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task NHDMDIKNDJL([Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AHBOLFJPCBL : HEGDHPPEDCK
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JKNOFKLBKLF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GDCLHBNJOKN(long BAAFLHIICBP, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EDOJNDCLIKO : HEGDHPPEDCK
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FICDPPECGGE : AHBOLFJPCBL, HEGDHPPEDCK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FKKAEFMDGKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FICDPPECGGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x883A420", Offset = "0x8838A20", VA = "0x18883A420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x883A800", Offset = "0x8838E00", VA = "0x18883A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BJJKBAJIFBB : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FICDPPECGGE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public BJJKBAJIFBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8838C50", Offset = "0x8837250", VA = "0x188838C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8838CC0", Offset = "0x88372C0", VA = "0x188838CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HFEDECNGICG CEKLBFHKPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MIPMDDBFIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool LCPOIODDIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CAOKIAILIEC MDPKAHPJNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private APLPOCKIJEJ DGONEIIJDFM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JKNOFKLBKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x883A330", Offset = "0x8838930", VA = "0x18883A330")]
	[UnityEngine.Scripting.Preserve]
	public FICDPPECGGE([OEKMEJFDAAI(null)] HFEDECNGICG CEKLBFHKPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
	public void EDOFINOBNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8839D00", Offset = "0x8838300", VA = "0x188839D00", Slot = "6")]
	public Task GDCLHBNJOKN(long BAAFLHIICBP, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E07C30", Offset = "0x1E06230", VA = "0x181E07C30")]
	private static int DCFLJEMLOLJ(bool FKMNCAKIOFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8839B20", Offset = "0x8838120", VA = "0x188839B20", Slot = "9")]
	public bool AKCFKHHOOKL(string NBPDNNFOMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8839BC0", Offset = "0x88381C0", VA = "0x188839BC0", Slot = "10")]
	public int BFKOPJPKKEI(string NBPDNNFOMKB, int DAKPJNHJLJO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8839CB0", Offset = "0x88382B0", VA = "0x188839CB0", Slot = "11")]
	public void DIEHJLOKIBP(string NBPDNNFOMKB, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8839DF0", Offset = "0x88383F0", VA = "0x188839DF0", Slot = "12")]
	public bool HHKGHPGANPJ(string NBPDNNFOMKB, bool DAKPJNHJLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8839FB0", Offset = "0x88385B0", VA = "0x188839FB0", Slot = "13")]
	public void MGIONEFNEJK(string NBPDNNFOMKB, bool FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8839D90", Offset = "0x8838390", VA = "0x188839D90", Slot = "14")]
	public float GHLJBFNGJAM(string NBPDNNFOMKB, float DAKPJNHJLJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8839E20", Offset = "0x8838420", VA = "0x188839E20", Slot = "15")]
	public void HMADIDFKLEM(string NBPDNNFOMKB, float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8839ED0", Offset = "0x88384D0", VA = "0x188839ED0", Slot = "18")]
	public DateTime LLDLGNCGPFB(string NBPDNNFOMKB, [Optional] DateTime DAKPJNHJLJO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x883A2C0", Offset = "0x88388C0", VA = "0x18883A2C0", Slot = "19")]
	public void PDPDOCANGKC(string NBPDNNFOMKB, DateTime BPMDCNPGKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x883A250", Offset = "0x8838850", VA = "0x18883A250", Slot = "20")]
	public long OIKGPPJLLJN(string NBPDNNFOMKB, long DAKPJNHJLJO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8839FE0", Offset = "0x88385E0", VA = "0x188839FE0", Slot = "21")]
	public void NDCBBKNPDMN(string NBPDNNFOMKB, long FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D87F80", Offset = "0x3D86580", VA = "0x183D87F80", Slot = "22")]
	public T CMBLHEFFCHD<T>(string NBPDNNFOMKB, T DAKPJNHJLJO, GODPFAGNMEF<T> GMAPFBEEHAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D88140", Offset = "0x3D86740", VA = "0x183D88140", Slot = "23")]
	public void DGLEOLFPOAM<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, GODPFAGNMEF<T> GMAPFBEEHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D88940", Offset = "0x3D86F40", VA = "0x183D88940")]
	private T JJPBNFNBLKL<T>(string NBPDNNFOMKB, T DAKPJNHJLJO, [Optional] GODPFAGNMEF<T> EEDEFNHGEJA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3D88270", Offset = "0x3D86870", VA = "0x183D88270")]
	private void JDJHGPEMKNL<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, [Optional] GODPFAGNMEF<T> EEDEFNHGEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8839BF0", Offset = "0x88381F0", VA = "0x188839BF0", Slot = "16")]
	public string BIOEEPCDPBO(string NBPDNNFOMKB, string DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8839DC0", Offset = "0x88383C0", VA = "0x188839DC0", Slot = "17")]
	public void HDHAMEDMCGN(string NBPDNNFOMKB, string FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8839CE0", Offset = "0x88382E0", VA = "0x188839CE0")]
	private void FLCHPFEKJMH(string NBPDNNFOMKB, string FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8839EB0", Offset = "0x88384B0", VA = "0x188839EB0")]
	private string KJFMHJAHFLO(string NBPDNNFOMKB, string DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8839C20", Offset = "0x8838220", VA = "0x188839C20", Slot = "24")]
	public void BNDCEMELKOF(string NBPDNNFOMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x883A1B0", Offset = "0x88387B0", VA = "0x18883A1B0")]
	private string OGJOMIFNEJB(string HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x883A050", Offset = "0x8838650", VA = "0x18883A050", Slot = "25")]
	[AsyncStateMachine(typeof(FKKAEFMDGKO))]
	public Task NHDMDIKNDJL(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8839B40", Offset = "0x8838140", VA = "0x188839B40")]
	[IteratorStateMachine(typeof(BJJKBAJIFBB))]
	private IEnumerator<BJJPNELKDDJ> BCNFBADLCGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8839E50", Offset = "0x8838450", VA = "0x188839E50")]
	private void IKAJIDHNODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8839F40", Offset = "0x8838540", VA = "0x188839F40")]
	private void MACNGBAIHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x883A140", Offset = "0x8838740", VA = "0x18883A140")]
	private void OCIGMKJGMDK(bool DMMMAIPFOMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DBIOGIIHGEP : AHBOLFJPCBL, HEGDHPPEDCK
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
	private Dictionary<string, string> FKBHEJGACFE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string OAJCKEGPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8838FF0", Offset = "0x88375F0", VA = "0x188838FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> GJJCBKNHJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8839340", Offset = "0x8837940", VA = "0x188839340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action JKNOFKLBKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	[UnityEngine.Scripting.Preserve]
	public DBIOGIIHGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
	public void EDOFINOBNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8839060", Offset = "0x8837660", VA = "0x188839060", Slot = "6")]
	public Task GDCLHBNJOKN(long BAAFLHIICBP, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x88390F0", Offset = "0x88376F0", VA = "0x1888390F0", Slot = "14")]
	public float GHLJBFNGJAM(string HFLDIIIPBCG, float DAKPJNHJLJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x88396F0", Offset = "0x8837CF0", VA = "0x1888396F0", Slot = "13")]
	public void MGIONEFNEJK(string HFLDIIIPBCG, bool FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8839200", Offset = "0x8837800", VA = "0x188839200", Slot = "12")]
	public bool HHKGHPGANPJ(string HFLDIIIPBCG, bool DAKPJNHJLJO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8838DA0", Offset = "0x88373A0", VA = "0x188838DA0", Slot = "10")]
	public int BFKOPJPKKEI(string HFLDIIIPBCG, int DAKPJNHJLJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8839680", Offset = "0x8837C80", VA = "0x188839680", Slot = "18")]
	public DateTime LLDLGNCGPFB(string NBPDNNFOMKB, [Optional] DateTime DAKPJNHJLJO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8839AB0", Offset = "0x88380B0", VA = "0x188839AB0", Slot = "19")]
	public void PDPDOCANGKC(string HFLDIIIPBCG, DateTime FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x88392D0", Offset = "0x88378D0", VA = "0x1888392D0", Slot = "15")]
	public void HMADIDFKLEM(string HFLDIIIPBCG, float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8838F80", Offset = "0x8837580", VA = "0x188838F80", Slot = "11")]
	public void DIEHJLOKIBP(string HFLDIIIPBCG, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8839A40", Offset = "0x8838040", VA = "0x188839A40", Slot = "20")]
	public long OIKGPPJLLJN(string NBPDNNFOMKB, long DAKPJNHJLJO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8839760", Offset = "0x8837D60", VA = "0x188839760", Slot = "21")]
	public void NDCBBKNPDMN(string NBPDNNFOMKB, long FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB500", Offset = "0x3BC9B00", VA = "0x183BCB500", Slot = "22")]
	public T CMBLHEFFCHD<T>(string NBPDNNFOMKB, T DAKPJNHJLJO, GODPFAGNMEF<T> GMAPFBEEHAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB610", Offset = "0x3BC9C10", VA = "0x183BCB610", Slot = "23")]
	public void DGLEOLFPOAM<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, GODPFAGNMEF<T> GMAPFBEEHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8838E10", Offset = "0x8837410", VA = "0x188838E10", Slot = "16")]
	public string BIOEEPCDPBO(string HFLDIIIPBCG, string DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8839160", Offset = "0x8837760", VA = "0x188839160", Slot = "17")]
	public void HDHAMEDMCGN(string HFLDIIIPBCG, string FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8838EC0", Offset = "0x88374C0", VA = "0x188838EC0", Slot = "24")]
	public void BNDCEMELKOF(string HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8838D10", Offset = "0x8837310", VA = "0x188838D10", Slot = "9")]
	public bool AKCFKHHOOKL(string HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x88397D0", Offset = "0x8837DD0", VA = "0x1888397D0", Slot = "25")]
	public Task NHDMDIKNDJL(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB6B0", Offset = "0x3BC9CB0", VA = "0x183BCB6B0")]
	private T JLOHDPKHFGN<T>(string NBPDNNFOMKB, T DAKPJNHJLJO, [Optional] GODPFAGNMEF<T> EEDEFNHGEJA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA5C0", Offset = "0x3BC8BC0", VA = "0x183BCA5C0")]
	private void ADPGIIFDGLO<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, [Optional] GODPFAGNMEF<T> EEDEFNHGEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8839380", Offset = "0x8837980", VA = "0x188839380")]
	private Dictionary<string, string> LIENNOCFAHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DPBIGCAOGIB
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action JKNOFKLBKLF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDOFINOBNCO();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task OLJKAIODDNM(long BAAFLHIICBP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LCOOOPJPCEB(NOMEIMIJJMB APPIIDLMGFH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HHKMNCNGJPK(string NBPDNNFOMKB, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DCMCELLIPEE(string NBPDNNFOMKB, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string EMJMAAGBNPJ(string NBPDNNFOMKB, [Optional] string DAKPJNHJLJO, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PCEJLDALHID AKLDLJNELEB(string NBPDNNFOMKB, string FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int IBDGNBBELEA(string NBPDNNFOMKB, int DAKPJNHJLJO = 0, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PCEJLDALHID AEAOIJJMMIL(string NBPDNNFOMKB, int FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ODNOJCIIEML(string NBPDNNFOMKB, bool DAKPJNHJLJO, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PCEJLDALHID NBIIKEHLOIF(string NBPDNNFOMKB, bool FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float MJCJHDKMABF(string NBPDNNFOMKB, float DAKPJNHJLJO = 0f, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PCEJLDALHID MPINLDMAIEF(string NBPDNNFOMKB, float FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime JIIDIMCKKHD(string NBPDNNFOMKB, [Optional] DateTime DAKPJNHJLJO, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PCEJLDALHID DBNLCJCIEJG(string NBPDNNFOMKB, DateTime FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long PKBMGPDNPDN(string NBPDNNFOMKB, long DAKPJNHJLJO = 0L, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	PCEJLDALHID JKNLDLFDIOH(string NBPDNNFOMKB, long FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T HIBPBDCHIPF<T>(string NBPDNNFOMKB, [Optional] T DAKPJNHJLJO, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	PCEJLDALHID BLIAGIKPIJB<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool AAPGAJPGCJC(string NBPDNNFOMKB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool PLNAAEPHKGK(string NBPDNNFOMKB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string CLOPANOOOIH(string NBPDNNFOMKB, [Optional] string DAKPJNHJLJO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	PCEJLDALHID DLGLBAEOHOG(string NBPDNNFOMKB, string FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int PCIPGGKEECL(string NBPDNNFOMKB, int DAKPJNHJLJO = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	PCEJLDALHID PEAHDOJJPHN(string NBPDNNFOMKB, int FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KDAELNMIOAN(string NBPDNNFOMKB, bool DAKPJNHJLJO);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PCEJLDALHID LBIHFMBJICB(string NBPDNNFOMKB, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float JFDAAEPOMMF(string NBPDNNFOMKB, float DAKPJNHJLJO = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	PCEJLDALHID BIJLGIBNHOF(string NBPDNNFOMKB, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime JAGJKDLGNCA(string NBPDNNFOMKB, [Optional] DateTime DAKPJNHJLJO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	PCEJLDALHID PIALFJAADMK(string NBPDNNFOMKB, DateTime FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long MCBBNKHEBMG(string NBPDNNFOMKB, long DAKPJNHJLJO = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	PCEJLDALHID MBKDCHANJNK(string NBPDNNFOMKB, long FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KLOIMKKGNGN<T>(GODPFAGNMEF<T> GMAPFBEEHAF, [Optional] IEqualityComparer<T> NBPCHKHLAIB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void IAJEMEDDNJE<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable KGHLCHHEIMC();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IDCIMHJINAG(float AEKHJIAHDFD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task IKAJIDHNODN([Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum PCEJLDALHID : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LDOEEHBGIKO : DPBIGCAOGIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class BGKHGLEDHKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<BGKHGLEDHKD> OIBPGNPICBF;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8838A80", Offset = "0x8837080", VA = "0x188838A80")]
		public static void LNHOKMONKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OOIGDCNPPFG();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		protected BGKHGLEDHKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class DDCFPFLPHGN<T> : BGKHGLEDHKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly DDCFPFLPHGN<T> DOBPPELCKJD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GODPFAGNMEF<T> BNGELKIALFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> MNHICDEEFJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool AJPDPNLJPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x45A0630", Offset = "0x459EC30", VA = "0x1845A0630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x45A0870", Offset = "0x459EE70", VA = "0x1845A0870")]
		private DDCFPFLPHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x45A01E0", Offset = "0x459E7E0", VA = "0x1845A01E0")]
		public void CBPAAEAGBMC(GODPFAGNMEF<T> EEDEFNHGEJA, [Optional] IEqualityComparer<T> NBPCHKHLAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x45A0670", Offset = "0x459EC70", VA = "0x1845A0670", Slot = "4")]
		public override void OOIGDCNPPFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class NBIPIPFIPIC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly LDOEEHBGIKO BGGDJHKAMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object JPBHDJONGAI;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8841460", Offset = "0x883FA60", VA = "0x188841460")]
		public NBIPIPFIPIC(LDOEEHBGIKO BGGDJHKAMHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8841430", Offset = "0x883FA30", VA = "0x188841430", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct ALBINPMEJHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LDOEEHBGIKO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x88386A0", Offset = "0x8836CA0", VA = "0x1888386A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8838990", Offset = "0x8836F90", VA = "0x188838990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LLNGCBFLIOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public LDOEEHBGIKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HEGDHPPEDCK backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x88412A0", Offset = "0x883F8A0", VA = "0x1888412A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct JGLMILOONON : IAsyncStateMachine
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
		public LDOEEHBGIKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x883C900", Offset = "0x883AF00", VA = "0x18883C900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x883CDD0", Offset = "0x883B3D0", VA = "0x18883CDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JLEMFECIIBA : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LDOEEHBGIKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public JLEMFECIIBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x883CE30", Offset = "0x883B430", VA = "0x18883CE30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x883CEC0", Offset = "0x883B4C0", VA = "0x18883CEC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly AHBOLFJPCBL KICFIOCGDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly AHBOLFJPCBL OHMPKHMGCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly EDOJNDCLIKO KHMCLFIJAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly CAOKIAILIEC MDPKAHPJNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly KEKLIIBDJBL.KGLGOAAOHPC EDEPFLICLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JHDOLFBOEBO CIHPGIPEOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<HEGDHPPEDCK> LCIMHKNBLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task PLDNJGFBOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> IPCNPHPKIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private APLPOCKIJEJ EILBBNNJEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object ODODJCMPLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object NANBCHNEMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long GJKOCAKHBLD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool EJBHOCBILKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x883FDF0", Offset = "0x883E3F0", VA = "0x18883FDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource ACCLCPHEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action JKNOFKLBKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x883EBD0", Offset = "0x883D1D0", VA = "0x18883EBD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8840770", Offset = "0x883ED70", VA = "0x188840770", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x883E070", Offset = "0x883C670", VA = "0x18883E070")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	internal static void AAICCAKCFCJ(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8840ED0", Offset = "0x883F4D0", VA = "0x188840ED0")]
	[UnityEngine.Scripting.Preserve]
	public LDOEEHBGIKO([OEKMEJFDAAI("Disk")] AHBOLFJPCBL KICFIOCGDNF, [OEKMEJFDAAI("Cloud")] AHBOLFJPCBL OHMPKHMGCDI, [OEKMEJFDAAI(null)] EDOJNDCLIKO KHMCLFIJAIC, [OEKMEJFDAAI(null)] CAOKIAILIEC MDPKAHPJNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x883EC70", Offset = "0x883D270", VA = "0x18883EC70", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x883F0F0", Offset = "0x883D6F0", VA = "0x18883F0F0")]
	private void HJDINFPDIAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x883ECB0", Offset = "0x883D2B0", VA = "0x18883ECB0", Slot = "6")]
	public void EDOFINOBNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x88408C0", Offset = "0x883EEC0", VA = "0x1888408C0", Slot = "7")]
	public Task OLJKAIODDNM(long BAAFLHIICBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x883EF20", Offset = "0x883D520", VA = "0x18883EF20")]
	[AsyncStateMachine(typeof(ALBINPMEJHH))]
	private Task FPNHMAMKDDJ(long BAAFLHIICBP, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x883F030", Offset = "0x883D630", VA = "0x18883F030")]
	private void HEDKCOPBILM(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x883E5F0", Offset = "0x883CBF0", VA = "0x18883E5F0")]
	private void BDKKMIHMIDF(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8840D10", Offset = "0x883F310", VA = "0x188840D10")]
	private string PEDMOFBNNBO(string NIEPLBDJLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x883E450", Offset = "0x883CA50", VA = "0x18883E450")]
	private void BDAMAKBIGKC(NOMEIMIJJMB APPIIDLMGFH, string HFLDIIIPBCG, [Out] AHBOLFJPCBL GKGDJLDIAOH, [Out] string BHJEINCKAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8840E40", Offset = "0x883F440", VA = "0x188840E40")]
	private AHBOLFJPCBL PKEMFJAKDHD(NOMEIMIJJMB APPIIDLMGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x883FE40", Offset = "0x883E440", VA = "0x18883FE40", Slot = "8")]
	public bool LCOOOPJPCEB(NOMEIMIJJMB APPIIDLMGFH = NOMEIMIJJMB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x883F050", Offset = "0x883D650", VA = "0x18883F050", Slot = "9")]
	public bool HHKMNCNGJPK(string NBPDNNFOMKB, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x883E9F0", Offset = "0x883CFF0", VA = "0x18883E9F0", Slot = "10")]
	public bool DCMCELLIPEE(string NBPDNNFOMKB, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x883EE80", Offset = "0x883D480", VA = "0x18883EE80", Slot = "11")]
	public string EMJMAAGBNPJ(string NBPDNNFOMKB, [Optional] string DAKPJNHJLJO, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x883E2C0", Offset = "0x883C8C0", VA = "0x18883E2C0", Slot = "12")]
	public PCEJLDALHID AKLDLJNELEB(string NBPDNNFOMKB, string FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x883F140", Offset = "0x883D740", VA = "0x18883F140", Slot = "13")]
	public int IBDGNBBELEA(string NBPDNNFOMKB, int DAKPJNHJLJO = 0, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x883E140", Offset = "0x883C740", VA = "0x18883E140", Slot = "14")]
	public PCEJLDALHID AEAOIJJMMIL(string NBPDNNFOMKB, int FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8840810", Offset = "0x883EE10", VA = "0x188840810", Slot = "15")]
	public bool ODNOJCIIEML(string NBPDNNFOMKB, bool DAKPJNHJLJO, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8840520", Offset = "0x883EB20", VA = "0x188840520", Slot = "16")]
	public PCEJLDALHID NBIIKEHLOIF(string NBPDNNFOMKB, bool FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x88402F0", Offset = "0x883E8F0", VA = "0x1888402F0", Slot = "17")]
	public float MJCJHDKMABF(string NBPDNNFOMKB, float DAKPJNHJLJO = 0f, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x88403A0", Offset = "0x883E9A0", VA = "0x1888403A0", Slot = "18")]
	public PCEJLDALHID MPINLDMAIEF(string NBPDNNFOMKB, float FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x883F520", Offset = "0x883DB20", VA = "0x18883F520", Slot = "19")]
	public DateTime JIIDIMCKKHD(string NBPDNNFOMKB, [Optional] DateTime DAKPJNHJLJO, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x883E850", Offset = "0x883CE50", VA = "0x18883E850", Slot = "20")]
	public PCEJLDALHID DBNLCJCIEJG(string NBPDNNFOMKB, DateTime FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8840DA0", Offset = "0x883F3A0", VA = "0x188840DA0", Slot = "21")]
	public long PKBMGPDNPDN(string NBPDNNFOMKB, long DAKPJNHJLJO = 0L, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x883F5C0", Offset = "0x883DBC0", VA = "0x18883F5C0", Slot = "22")]
	public PCEJLDALHID JKNLDLFDIOH(string NBPDNNFOMKB, long FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3E78070", Offset = "0x3E76670", VA = "0x183E78070", Slot = "23")]
	public T HIBPBDCHIPF<T>(string NBPDNNFOMKB, [Optional] T DAKPJNHJLJO, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3E78070", Offset = "0x3E76670", VA = "0x183E78070", Slot = "24")]
	public PCEJLDALHID BLIAGIKPIJB<T>(string NBPDNNFOMKB, T FKMNCAKIOFK, NOMEIMIJJMB EPIMCBHEFIH = NOMEIMIJJMB.CLOUD)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x883E0E0", Offset = "0x883C6E0", VA = "0x18883E0E0", Slot = "25")]
	public bool AAPGAJPGCJC(string NBPDNNFOMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8840EC0", Offset = "0x883F4C0", VA = "0x188840EC0", Slot = "26")]
	public bool PLNAAEPHKGK(string NBPDNNFOMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x883E7E0", Offset = "0x883CDE0", VA = "0x18883E7E0", Slot = "27")]
	public string CLOPANOOOIH(string NBPDNNFOMKB, [Optional] string DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x883EBA0", Offset = "0x883D1A0", VA = "0x18883EBA0", Slot = "28")]
	public PCEJLDALHID DLGLBAEOHOG(string NBPDNNFOMKB, string FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8840B20", Offset = "0x883F120", VA = "0x188840B20", Slot = "29")]
	public int PCIPGGKEECL(string NBPDNNFOMKB, int DAKPJNHJLJO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8840B90", Offset = "0x883F190", VA = "0x188840B90", Slot = "30")]
	public PCEJLDALHID PEAHDOJJPHN(string NBPDNNFOMKB, int FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x883F740", Offset = "0x883DD40", VA = "0x18883F740", Slot = "31")]
	public bool KDAELNMIOAN(string NBPDNNFOMKB, bool DAKPJNHJLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x883FE10", Offset = "0x883E410", VA = "0x18883FE10", Slot = "32")]
	public PCEJLDALHID LBIHFMBJICB(string NBPDNNFOMKB, bool FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x883F360", Offset = "0x883D960", VA = "0x18883F360", Slot = "33")]
	public float JFDAAEPOMMF(string NBPDNNFOMKB, float DAKPJNHJLJO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x883E670", Offset = "0x883CC70", VA = "0x18883E670", Slot = "34")]
	public PCEJLDALHID BIJLGIBNHOF(string NBPDNNFOMKB, float FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x883F2F0", Offset = "0x883D8F0", VA = "0x18883F2F0", Slot = "35")]
	public DateTime JAGJKDLGNCA(string NBPDNNFOMKB, [Optional] DateTime DAKPJNHJLJO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8840D70", Offset = "0x883F370", VA = "0x188840D70", Slot = "36")]
	public PCEJLDALHID PIALFJAADMK(string NBPDNNFOMKB, DateTime FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x88400A0", Offset = "0x883E6A0", VA = "0x1888400A0", Slot = "37")]
	public long MCBBNKHEBMG(string NBPDNNFOMKB, long DAKPJNHJLJO = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8840070", Offset = "0x883E670", VA = "0x188840070", Slot = "38")]
	public PCEJLDALHID MBKDCHANJNK(string NBPDNNFOMKB, long FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x883FB10", Offset = "0x883E110", VA = "0x18883FB10")]
	private bool KKEFCOKOLAD(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x883ED20", Offset = "0x883D320", VA = "0x18883ED20")]
	private bool EJOILEPNPPF(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x883F3D0", Offset = "0x883D9D0", VA = "0x18883F3D0")]
	private PCEJLDALHID JIACDEFJKHF(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, string FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x883E6A0", Offset = "0x883CCA0", VA = "0x18883E6A0")]
	private PCEJLDALHID BMPIECKNKIM(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, int FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x883FCB0", Offset = "0x883E2B0", VA = "0x18883FCB0")]
	private PCEJLDALHID KOGINCEIMBP(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, bool FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8840BC0", Offset = "0x883F1C0", VA = "0x188840BC0")]
	private PCEJLDALHID PECKOJHPCAN(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, float FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x883FF00", Offset = "0x883E500", VA = "0x18883FF00")]
	private PCEJLDALHID LHBAMNFIFIO(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, DateTime FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x883FB70", Offset = "0x883E170", VA = "0x18883FB70")]
	private PCEJLDALHID KLDHPIKHAGI(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, long FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3E78EA0", Offset = "0x3E774A0", VA = "0x183E78EA0")]
	private T HPELFHBMLAN<T>(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, T DAKPJNHJLJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3E78210", Offset = "0x3E76810", VA = "0x183E78210")]
	private PCEJLDALHID DIMCFMJHIAK<T>(HEGDHPPEDCK GKGDJLDIAOH, string NBPDNNFOMKB, T FKMNCAKIOFK)
	{
		return default(PCEJLDALHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3E79420", Offset = "0x3E77A20", VA = "0x183E79420", Slot = "39")]
	public void KLOIMKKGNGN<T>(GODPFAGNMEF<T> GMAPFBEEHAF, [Optional] IEqualityComparer<T> NBPCHKHLAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3E793A0", Offset = "0x3E779A0", VA = "0x183E793A0", Slot = "40")]
	public void IAJEMEDDNJE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x88406A0", Offset = "0x883ECA0", VA = "0x1888406A0")]
	[AsyncStateMachine(typeof(LLNGCBFLIOJ))]
	private void NHDMDIKNDJL(HEGDHPPEDCK DBJBGEPKKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x883F200", Offset = "0x883D800", VA = "0x18883F200", Slot = "43")]
	[AsyncStateMachine(typeof(JGLMILOONON))]
	public Task IKAJIDHNODN([Optional] CancellationToken HNGIMMGBLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8840110", Offset = "0x883E710", VA = "0x188840110")]
	private void MCMBBOBHGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x883FA30", Offset = "0x883E030", VA = "0x18883FA30", Slot = "41")]
	public IDisposable KGHLCHHEIMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x883F1F0", Offset = "0x883D7F0", VA = "0x18883F1F0", Slot = "42")]
	public void IDCIMHJINAG(float AEKHJIAHDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x883F7B0", Offset = "0x883DDB0", VA = "0x18883F7B0")]
	private void KDFOMGJDBGH(float IEELKILHJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8840A90", Offset = "0x883F090", VA = "0x188840A90")]
	[IteratorStateMachine(typeof(JLEMFECIIBA))]
	private IEnumerator<BJJPNELKDDJ> OOIIHPIKDDL(float AEKHJIAHDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x883EB70", Offset = "0x883D170", VA = "0x18883EB70")]
	[CompilerGenerated]
	private void DKFMFIJCEOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FOHOIDKPFOD : NEDJEPGLGDE<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static FOHOIDKPFOD DOBPPELCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x883ABD0", Offset = "0x88391D0", VA = "0x18883ABD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x883AAE0", Offset = "0x88390E0", VA = "0x18883AAE0", Slot = "9")]
	public override string CAELEDFILEL(bool EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x883A860", Offset = "0x8838E60", VA = "0x18883A860", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] bool FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x883ACC0", Offset = "0x88392C0", VA = "0x18883ACC0")]
	public FOHOIDKPFOD()
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
