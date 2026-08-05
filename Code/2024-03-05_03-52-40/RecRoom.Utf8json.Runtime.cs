using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class BMHLGCLLEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x698B400", Offset = "0x698A200", VA = "0x18698B400")]
	public static bool NBFCJBNILJA(this TypeInfo LPFFKBBBCBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class GDIHJNAALLL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LOENCKKACEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] FFAHLDBEJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
	public GDIHJNAALLL(Type EECKGBMLFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class JJADPOAAKGO : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LIIELLDODCF<T>(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T EADHKFMGBKO<T>(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN AEBEIKCOJPH);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AEBJIPJMENI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EOBPAHIDCCA<T> : AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ECOHJEPCDGP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GLEGFEGEPPE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AJDJHLFFNIJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC430", Offset = "0x2CFB230", VA = "0x182CFC430")]
	public static string ACHCJEOPLDF<T>(this EOBPAHIDCCA<T> KGOIEKIFHMI, T MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EOBPAHIDCCA<T> OELNKKJKACK<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AJHDJKAHNEH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2CFDDB0", Offset = "0x2CFCBB0", VA = "0x182CFDDB0")]
	public static EOBPAHIDCCA<T> GKIFLMNEJCD<T>(this LNCEEOCCIFN AEBEIKCOJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6987980", Offset = "0x6986780", VA = "0x186987980")]
	public static object BFFDAPKADKA(this LNCEEOCCIFN AEBEIKCOJPH, Type LPFFKBBBCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HLFFKPJIKAD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6996760", Offset = "0x6995560", VA = "0x186996760")]
	public HLFFKPJIKAD(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BJOFEHNPFPA
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class FHHOLHBCCKH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] LIICAAPCJGB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] CBBAPBHENAM;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6995C70", Offset = "0x6994A70", VA = "0x186995C70")]
		public static byte[] CLLOHKMOIGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6995D10", Offset = "0x6994B10", VA = "0x186995D10")]
		public static char[] NJGEHEAHMCI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> FHPMMECBEDP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] BFJHAILIIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] HCFBAPHHICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int LBJEFCOBKGF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool NIMCBFIACMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6989ED0", Offset = "0x6988CD0", VA = "0x186989ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x698B3A0", Offset = "0x698A1A0", VA = "0x18698B3A0")]
	public BJOFEHNPFPA(byte[] HCFBAPHHICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x698B240", Offset = "0x698A040", VA = "0x18698B240")]
	public BJOFEHNPFPA(byte[] HCFBAPHHICF, int LBJEFCOBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6989030", Offset = "0x6987E30", VA = "0x186989030")]
	private ANOAPLMLKKN FLELHCADCJI(string JNBBCPIKJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x698AA90", Offset = "0x6989890", VA = "0x18698AA90")]
	private ANOAPLMLKKN OOOEPJEKJNF(string LJCDGDONMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6988170", Offset = "0x6986F70", VA = "0x186988170")]
	public void COFDOFJMCNB(int LBJEFCOBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
	public byte[] IKEGPDDBDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0020", Offset = "0x1D9EE20", VA = "0x181DA0020")]
	public int IGPFPPNMEKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6988180", Offset = "0x6986F80", VA = "0x186988180")]
	public NGDGFAGHDIJ DBFEKKJDGGM()
	{
		return default(NGDGFAGHDIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69897E0", Offset = "0x69885E0", VA = "0x1869897E0")]
	public void GBPJBNKFMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x698A970", Offset = "0x6989770", VA = "0x18698A970")]
	public bool OHCHGDAAEHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x698AEA0", Offset = "0x6989CA0", VA = "0x18698AEA0")]
	public bool PGONODDIIGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6987FD0", Offset = "0x6986DD0", VA = "0x186987FD0")]
	public void AOOFOHAEJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6989E40", Offset = "0x6988C40", VA = "0x186989E40")]
	public bool HLIHBKIHBGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69884E0", Offset = "0x69872E0", VA = "0x1869884E0")]
	public bool EHJPNPCALCK(int DPKFLHPPNCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x698AB80", Offset = "0x6989980", VA = "0x18698AB80")]
	public bool OPEHLIMCNEK(int DPKFLHPPNCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6988EC0", Offset = "0x6987CC0", VA = "0x186988EC0")]
	public bool FFMGFIHMGEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x698A6F0", Offset = "0x69894F0", VA = "0x18698A6F0")]
	public void MJJBFGIJEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69883A0", Offset = "0x69871A0", VA = "0x1869883A0")]
	public bool EBJIONAJLMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6989EF0", Offset = "0x6988CF0", VA = "0x186989EF0")]
	public bool IOLGPOBLEIO(int DPKFLHPPNCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x698A360", Offset = "0x6989160", VA = "0x18698A360")]
	public bool LEBFEIGNPIL(int DPKFLHPPNCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x698A1E0", Offset = "0x6988FE0", VA = "0x18698A1E0")]
	public bool KLPEOCHLKDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x698A2C0", Offset = "0x69890C0", VA = "0x18698A2C0")]
	public void LADBKCFENGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6988D50", Offset = "0x6987B50", VA = "0x186988D50")]
	public bool EOLGKOBCFPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x698A140", Offset = "0x6988F40", VA = "0x18698A140")]
	public void KHJKKBBKBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69885B0", Offset = "0x69873B0", VA = "0x1869885B0")]
	private void EMNDMPGDPNO([Out] byte[] NNLNGAEDNDO, [Out] int JEMGAOOFKHF, [Out] int NDNPMIJHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6988430", Offset = "0x6987230", VA = "0x186988430")]
	private static int EEDGADIBOAE(char AOHIFIJNOBB, char FNDBFMFAGPH, char MEJOABMJHGI, char GLPEKNLBHMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6988F50", Offset = "0x6987D50", VA = "0x186988F50")]
	private static int FHPKBDKNFIJ(char BJKAJHEJDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x698A850", Offset = "0x6989650", VA = "0x18698A850")]
	public ArraySegment<byte> NHKGCEBHBCN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6988DE0", Offset = "0x6987BE0", VA = "0x186988DE0")]
	public string EPEAFGMCJBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6988330", Offset = "0x6987130", VA = "0x186988330")]
	public string DLJIIHPMLMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6989C20", Offset = "0x6988A20", VA = "0x186989C20")]
	public ArraySegment<byte> HFJINDJAOPP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6987F60", Offset = "0x6986D60", VA = "0x186987F60")]
	public ArraySegment<byte> AFDEHHDBBNA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69899D0", Offset = "0x69887D0", VA = "0x1869899D0")]
	public bool GMHLHAJPHMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6989910", Offset = "0x6988710", VA = "0x186989910")]
	private static bool GGEJKICDCIF(byte MEJOABMJHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x698AC50", Offset = "0x6989A50", VA = "0x18698AC50")]
	private void PANEAHINGPA(NGDGFAGHDIJ BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x698A270", Offset = "0x6989070", VA = "0x18698A270")]
	public void KMAJHNONOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6989680", Offset = "0x6988480", VA = "0x186989680")]
	private void GBLEFNNCHKB(int DJKMLFDOALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x698A0C0", Offset = "0x6988EC0", VA = "0x18698A0C0")]
	public sbyte JICCEGIBGED()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x698A430", Offset = "0x6989230", VA = "0x18698A430")]
	public short LFFPDFPJCKK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x698A4B0", Offset = "0x69892B0", VA = "0x18698A4B0")]
	public int LJJPHGKCGGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x698A790", Offset = "0x6989590", VA = "0x18698A790")]
	public long MKIDHCPEICD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6988070", Offset = "0x6986E70", VA = "0x186988070")]
	public byte BFLFCEOGFCH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x698B0A0", Offset = "0x6989EA0", VA = "0x18698B0A0")]
	public ushort PMGLNJAHIKM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69880F0", Offset = "0x6986EF0", VA = "0x1869880F0")]
	public uint BNBMPPNFKIF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x698A630", Offset = "0x6989430", VA = "0x18698A630")]
	public ulong MJHJAJICHGE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6989FC0", Offset = "0x6988DC0", VA = "0x186989FC0")]
	public float JCPEHDJJJED()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x698A530", Offset = "0x6989330", VA = "0x18698A530")]
	public double LPLMJFHIMNL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6989580", Offset = "0x6988380", VA = "0x186989580")]
	public ArraySegment<byte> GAIIIIHKJOK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x698AF30", Offset = "0x6989D30", VA = "0x18698AF30")]
	private static int PHLIHPDEAKH(byte[] HCFBAPHHICF, int LBJEFCOBKGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ANOAPLMLKKN : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference LDKAGKACOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int HBEOJPBCPDN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EBBAINNAODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC0C1F0", Offset = "0xC0AFF0", VA = "0x180C0C1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DOKAMOGIMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8630D0", Offset = "0x861ED0", VA = "0x1808630D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6987BD0", Offset = "0x69869D0", VA = "0x186987BD0")]
	public ANOAPLMLKKN(string LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6987AE0", Offset = "0x69868E0", VA = "0x186987AE0")]
	public ANOAPLMLKKN(string LJCDGDONMLD, byte[] GCOACMPKFLM, int LBJEFCOBKGF, int HBEOJPBCPDN, string GGEEMBEJJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ADAPDGEBANO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class NDBMCOGAHGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] LIICAAPCJGB;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69A0DB0", Offset = "0x699FBB0", VA = "0x1869A0DB0")]
		public static byte[] CLLOHKMOIGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class CFBGAGHGICH
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void KMINKKGDOCG(MFNBEJGCMIB FCAJMDOFLNK, object MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object INOJBHCBEIF(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN AEBEIKCOJPH);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class LHKKOKBKBHL
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class ILGDLHKMFKN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
				public ILGDLHKMFKN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x4097BB0", Offset = "0x40969B0", VA = "0x184097BB0")]
				internal bool LLGBPIHHBFL(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6998BB0", Offset = "0x69979B0", VA = "0x186998BB0")]
				internal bool NILIJHLOJPP(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, LNCEEOCCIFN, byte[]> ICDNMJGMDFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, LNCEEOCCIFN> NKFLMDJJKCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly KMINKKGDOCG EMPEPJKBKCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, LNCEEOCCIFN, ArraySegment<byte>> FPKNFEMFKJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, LNCEEOCCIFN, string> OFHLKOFBOHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, LNCEEOCCIFN, object> AAMDPIKGLGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, LNCEEOCCIFN, object> LIKACJNKFKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, LNCEEOCCIFN, object> BHINPEMGLFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly INOJBHCBEIF JALOBLPFKDF;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x699D4D0", Offset = "0x699C2D0", VA = "0x18699D4D0")]
			public LHKKOKBKBHL(Type LPFFKBBBCBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2CC1F30", Offset = "0x2CC0D30", VA = "0x182CC1F30")]
			private static T CPEGEMLHNLE<T>(DynamicMethod MLFGHCBBCPJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x699D280", Offset = "0x699C080", VA = "0x18699D280")]
			private static MethodInfo NHEIJKAOFNB(Type LPFFKBBBCBL, string OCCHBLONHPL, Type[] OHHPHLJFHPD)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, LHKKOKBKBHL> KLGNKMGBHAO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly OFDLPHNFDHG<LHKKOKBKBHL> IGAENIDFLOO;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x698C300", Offset = "0x698B100", VA = "0x18698C300")]
		static CFBGAGHGICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x698C280", Offset = "0x698B080", VA = "0x18698C280")]
		private static LHKKOKBKBHL NJLMLDPHJOK(Type LPFFKBBBCBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x698C100", Offset = "0x698AF00", VA = "0x18698C100")]
		public static void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, object MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x698BFF0", Offset = "0x698ADF0", VA = "0x18698BFF0")]
		public static void CDDFPMJNNJO(Type LPFFKBBBCBL, MFNBEJGCMIB FCAJMDOFLNK, object MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static LNCEEOCCIFN EHECNJAAABH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] DBGHJDHPEBK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NFLKKCKOGMA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static LNCEEOCCIFN JELMFAOGDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6987150", Offset = "0x6985F50", VA = "0x186987150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AMNKABLPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x69876F0", Offset = "0x69864F0", VA = "0x1869876F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6987680", Offset = "0x6986480", VA = "0x186987680")]
	public static void GCOCNLGHNAH(LNCEEOCCIFN AEBEIKCOJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3680", Offset = "0x2CF2480", VA = "0x182CF3680")]
	public static byte[] CDDFPMJNNJO<T>(T KDHDNCADFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3700", Offset = "0x2CF2500", VA = "0x182CF3700")]
	public static byte[] CDDFPMJNNJO<T>(T MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3B30", Offset = "0x2CF2930", VA = "0x182CF3B30")]
	public static void CDDFPMJNNJO<T>(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3BC0", Offset = "0x2CF29C0", VA = "0x182CF3BC0")]
	public static void CDDFPMJNNJO<T>(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3D20", Offset = "0x2CF2B20", VA = "0x182CF3D20")]
	public static void CDDFPMJNNJO<T>(Stream KLGEPLBEDMJ, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3870", Offset = "0x2CF2670", VA = "0x182CF3870")]
	public static void CDDFPMJNNJO<T>(Stream KLGEPLBEDMJ, T MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2CF35F0", Offset = "0x2CF23F0", VA = "0x182CF35F0")]
	public static ArraySegment<byte> BHODBMNMAOB<T>(T KDHDNCADFDJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3460", Offset = "0x2CF2260", VA = "0x182CF3460")]
	public static ArraySegment<byte> BHODBMNMAOB<T>(T MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1DA0", Offset = "0x2CF0BA0", VA = "0x182CF1DA0")]
	public static string ACHCJEOPLDF<T>(T MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1E20", Offset = "0x2CF0C20", VA = "0x182CF1E20")]
	public static string ACHCJEOPLDF<T>(T MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2C70", Offset = "0x2CF1A70", VA = "0x182CF2C70")]
	public static T APHAODHFANA<T>(string KJOKICDNNHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2AF0", Offset = "0x2CF18F0", VA = "0x182CF2AF0")]
	public static T APHAODHFANA<T>(string KJOKICDNNHP, LNCEEOCCIFN AEBEIKCOJPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2F40", Offset = "0x2CF1D40", VA = "0x182CF2F40")]
	public static T APHAODHFANA<T>(byte[] HCFBAPHHICF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2BE0", Offset = "0x2CF19E0", VA = "0x182CF2BE0")]
	public static T APHAODHFANA<T>(byte[] HCFBAPHHICF, LNCEEOCCIFN AEBEIKCOJPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3260", Offset = "0x2CF2060", VA = "0x182CF3260")]
	public static T APHAODHFANA<T>(byte[] HCFBAPHHICF, int LBJEFCOBKGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2960", Offset = "0x2CF1760", VA = "0x182CF2960")]
	public static T APHAODHFANA<T>(byte[] HCFBAPHHICF, int LBJEFCOBKGF, LNCEEOCCIFN AEBEIKCOJPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2EC0", Offset = "0x2CF1CC0", VA = "0x182CF2EC0")]
	public static T APHAODHFANA<T>(BJOFEHNPFPA INLIFCPEGKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3110", Offset = "0x2CF1F10", VA = "0x182CF3110")]
	public static T APHAODHFANA<T>(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN AEBEIKCOJPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3090", Offset = "0x2CF1E90", VA = "0x182CF3090")]
	public static T APHAODHFANA<T>(Stream KLGEPLBEDMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2D80", Offset = "0x2CF1B80", VA = "0x182CF2D80")]
	public static T APHAODHFANA<T>(Stream KLGEPLBEDMJ, LNCEEOCCIFN AEBEIKCOJPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69873E0", Offset = "0x69861E0", VA = "0x1869873E0")]
	public static string GCNCBMOCEPM(byte[] KJOKICDNNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6987540", Offset = "0x6986340", VA = "0x186987540")]
	public static string GCNCBMOCEPM(byte[] KJOKICDNNHP, int LBJEFCOBKGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6987250", Offset = "0x6986050", VA = "0x186987250")]
	public static string GCNCBMOCEPM(string KJOKICDNNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6986550", Offset = "0x6985350", VA = "0x186986550")]
	public static byte[] COGHMPCMDOL(byte[] KJOKICDNNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6986400", Offset = "0x6985200", VA = "0x186986400")]
	public static byte[] COGHMPCMDOL(byte[] KJOKICDNNHP, int LBJEFCOBKGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69866D0", Offset = "0x69854D0", VA = "0x1869866D0")]
	public static byte[] COGHMPCMDOL(string KJOKICDNNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6986880", Offset = "0x6985680", VA = "0x186986880")]
	private static void DJPMAGMJBKI(BJOFEHNPFPA INLIFCPEGKK, MFNBEJGCMIB FCAJMDOFLNK, int NBANIMBJCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6987750", Offset = "0x6986550", VA = "0x186987750")]
	private static int LOFNDEEPBGJ(Stream PMNEDIFJMIN, byte[] LIICAAPCJGB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum NGDGFAGHDIJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BeginObject,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	EndObject,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BeginArray,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	EndArray,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Number,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	String,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	False,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Null,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ValueSeparator,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NameSeparator
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct MFNBEJGCMIB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] CCCEBKMCFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] LIICAAPCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int LBJEFCOBKGF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EAABHOAGHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0020", Offset = "0x1D9EE20", VA = "0x181DA0020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6988170", Offset = "0x6986F70", VA = "0x186988170")]
	public void COFDOFJMCNB(int LBJEFCOBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69A0290", Offset = "0x699F090", VA = "0x1869A0290")]
	public static byte[] LCICJIDAMPD(string AOPFLAFGCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x699F870", Offset = "0x699E670", VA = "0x18699F870")]
	public static byte[] BABJMJEHMCI(string AOPFLAFGCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x699FDD0", Offset = "0x699EBD0", VA = "0x18699FDD0")]
	public static byte[] KENJGIBMBKB(string AOPFLAFGCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x699FF40", Offset = "0x699ED40", VA = "0x18699FF40")]
	public static byte[] KOCGBOFFFAJ(string AOPFLAFGCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55C8950", Offset = "0x55C7750", VA = "0x1855C8950")]
	public MFNBEJGCMIB(byte[] GHGDDDMFPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x699FAA0", Offset = "0x699E8A0", VA = "0x18699FAA0")]
	public ArraySegment<byte> CLLOHKMOIGJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69A00C0", Offset = "0x699EEC0", VA = "0x1869A00C0")]
	public byte[] LACLJMBJIDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69A0850", Offset = "0x699F650", VA = "0x1869A0850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x699FDC0", Offset = "0x699EBC0", VA = "0x18699FDC0")]
	public void ILPEDGONBCF(int PEIEGLLFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69A0490", Offset = "0x699F290", VA = "0x1869A0490")]
	public void LEMHJECJKME(byte NKGNBJCIAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69A0430", Offset = "0x699F230", VA = "0x1869A0430")]
	public void LEMHJECJKME(byte[] NKGNBJCIAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x69A03F0", Offset = "0x699F1F0", VA = "0x1869A03F0")]
	public void LEBBEEAACPP(byte NKGNBJCIAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x699FC40", Offset = "0x699EA40", VA = "0x18699FC40")]
	public void FJJJJHOIIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x69A06C0", Offset = "0x699F4C0", VA = "0x1869A06C0")]
	public void NGDOAPPLDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x699F9E0", Offset = "0x699E7E0", VA = "0x18699F9E0")]
	public void BBMLDDCBPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x69A0710", Offset = "0x699F510", VA = "0x1869A0710")]
	public void NHNOMIGMHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x69A0760", Offset = "0x699F560", VA = "0x1869A0760")]
	public void NNODDGMJBDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x699FD00", Offset = "0x699EB00", VA = "0x18699FD00")]
	public void IGNPMEPANJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x69A05B0", Offset = "0x699F3B0", VA = "0x1869A05B0")]
	public void MICDFDMPLGF(string AOPFLAFGCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x69A04F0", Offset = "0x699F2F0", VA = "0x1869A04F0")]
	public void LJOKMCKPHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x699F440", Offset = "0x699E240", VA = "0x18699F440")]
	public void AGLEHEIFHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69A0130", Offset = "0x699EF30", VA = "0x1869A0130")]
	public void LAKECDBMJBP(bool MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x699FBC0", Offset = "0x699E9C0", VA = "0x18699FBC0")]
	public void EGIPHKGJCAL(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x699FB40", Offset = "0x699E940", VA = "0x18699FB40")]
	public void EAHEPDFPCJH(double MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69A0650", Offset = "0x699F450", VA = "0x1869A0650")]
	public void MNCLPHOJMCB(byte MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69A0540", Offset = "0x699F340", VA = "0x1869A0540")]
	public void LNMNPNODIJG(ushort MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x699FC90", Offset = "0x699EA90", VA = "0x18699FC90")]
	public void HEAAJDLLJHN(uint MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x69A07B0", Offset = "0x699F5B0", VA = "0x1869A07B0")]
	public void NOJAPFFKIPG(ulong MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x699FD50", Offset = "0x699EB50", VA = "0x18699FD50")]
	public void IHOLAMAHILK(sbyte MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x699FA30", Offset = "0x699E830", VA = "0x18699FA30")]
	public void BEDDNAGPBCP(short MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69A07E0", Offset = "0x699F5E0", VA = "0x1869A07E0")]
	public void OMHGNPJNHFC(int MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69A03C0", Offset = "0x699F1C0", VA = "0x1869A03C0")]
	public void LCPEBFIMCPB(long MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x699F4E0", Offset = "0x699E2E0", VA = "0x18699F4E0")]
	public void AJCMPHFIFOC(string MAEBFBHFPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class AACLJGEHEND : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class HAJIMAHJEPP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x377BA30", Offset = "0x377A830", VA = "0x18377BA30")]
		static HAJIMAHJEPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private AACLJGEHEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FKGHIIGJMEL : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class JNNDHIOPIAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A7D0", Offset = "0x3A795D0", VA = "0x183A7A7D0")]
		static JNNDHIOPIAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class JGJDECJAFMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> KNMKCKJOBIC;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6998F90", Offset = "0x6997D90", VA = "0x186998F90")]
		internal static object OELNKKJKACK(Type BHBDNAGLKEL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private FKGHIIGJMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class FIFEKMDIJJG : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class JGLEGEMANCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F2D0", Offset = "0x3A5E0D0", VA = "0x183A5F2D0")]
		static JGLEGEMANCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly FIFEKMDIJJG ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool HNDJOKIFEKE;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static AEBJIPJMENI[] HJGPPOLFECK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static LNCEEOCCIFN[] GACLDLIONIB;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private FIFEKMDIJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6996120", Offset = "0x6994F20", VA = "0x186996120")]
	public static void GGPDGFKFIKF(params LNCEEOCCIFN[] GACLDLIONIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6996040", Offset = "0x6994E40", VA = "0x186996040")]
	public static void GGPDGFKFIKF(params AEBJIPJMENI[] HJGPPOLFECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6995DB0", Offset = "0x6994BB0", VA = "0x186995DB0")]
	public static void FILBCDGAICK(AEBJIPJMENI[] HJGPPOLFECK, LNCEEOCCIFN[] GACLDLIONIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GJNGKDHODEA : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class EMCHMGIKBPC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x32B1CB0", Offset = "0x32B0AB0", VA = "0x1832B1CB0")]
		static EMCHMGIKBPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private GJNGKDHODEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LAGPIJPALAB
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly LNCEEOCCIFN DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly LNCEEOCCIFN NBKNNFIMDBE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly LNCEEOCCIFN AMHDMHMKPNG;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly LNCEEOCCIFN DLDIFCKGJFH;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly LNCEEOCCIFN DHDKMFJDCHO;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly LNCEEOCCIFN ODCIGJCPLCB;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly LNCEEOCCIFN DMCHHPIMNBE;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LNCEEOCCIFN MJDIGKICBAB;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly LNCEEOCCIFN OKDDAENEGDM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly LNCEEOCCIFN GHJAHEDPJGN;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly LNCEEOCCIFN PFMAMHPAMCM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly LNCEEOCCIFN KBBGEJKPPDF;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class KMCFANBLBGA
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly LNCEEOCCIFN DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly LNCEEOCCIFN MMPLKKMJAKI;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MJKGLBAEEEP
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly LNCEEOCCIFN DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LNCEEOCCIFN NBKNNFIMDBE;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly LNCEEOCCIFN AMHDMHMKPNG;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LNCEEOCCIFN DLDIFCKGJFH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly LNCEEOCCIFN DHDKMFJDCHO;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly LNCEEOCCIFN ODCIGJCPLCB;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly LNCEEOCCIFN DMCHHPIMNBE;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly LNCEEOCCIFN MJDIGKICBAB;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly LNCEEOCCIFN OKDDAENEGDM;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly LNCEEOCCIFN GHJAHEDPJGN;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly LNCEEOCCIFN PFMAMHPAMCM;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly LNCEEOCCIFN KBBGEJKPPDF;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class ILEMNFHMNEO
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> KNMKCKJOBIC;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6996F00", Offset = "0x6995D00", VA = "0x186996F00")]
	internal static object OELNKKJKACK(Type BHBDNAGLKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6996EC0", Offset = "0x6995CC0", VA = "0x186996EC0")]
	private static object NDNBIEMMOPM(Type AAMEJBGEENC, Type[] PPALFGHEONC, params object[] OHHPHLJFHPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class DLOPGNMOLFG : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class CFAPAFGDAGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4C592D0", Offset = "0x4C580D0", VA = "0x184C592D0")]
		static CFAPAFGDAGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly KGEMLJCECGG ICLNCINPFME;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x698D300", Offset = "0x698C100", VA = "0x18698D300")]
	static DLOPGNMOLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private DLOPGNMOLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class HNABFKJHBIN : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class CEIPAKDBFKC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4C58B90", Offset = "0x4C57990", VA = "0x184C58B90")]
		static CEIPAKDBFKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly KGEMLJCECGG ICLNCINPFME;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x69967C0", Offset = "0x69955C0", VA = "0x1869967C0")]
	static HNABFKJHBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private HNABFKJHBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class LLFOEOBOKCB : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class GBLBGMNEKCG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x36E15F0", Offset = "0x36E03F0", VA = "0x1836E15F0")]
		static GBLBGMNEKCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly KGEMLJCECGG ICLNCINPFME;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x699EFD0", Offset = "0x699DDD0", VA = "0x18699EFD0")]
	static LLFOEOBOKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private LLFOEOBOKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class IEGBKCOHCEL : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class NBLFFLNFHHK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F160", Offset = "0x3E7DF60", VA = "0x183E7F160")]
		static NBLFFLNFHHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly KGEMLJCECGG ICLNCINPFME;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6996B30", Offset = "0x6995930", VA = "0x186996B30")]
	static IEGBKCOHCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private IEGBKCOHCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class PJCIEOJNKGK : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class KKPJHENKONO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3B29580", Offset = "0x3B28380", VA = "0x183B29580")]
		static KKPJHENKONO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly KGEMLJCECGG ICLNCINPFME;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x69A11A0", Offset = "0x699FFA0", VA = "0x1869A11A0")]
	static PJCIEOJNKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private PJCIEOJNKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class POAFCKFCEIC : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class GECNIFLLIIP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x36F1D20", Offset = "0x36F0B20", VA = "0x1836F1D20")]
		static GECNIFLLIIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly KGEMLJCECGG ICLNCINPFME;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x69A1370", Offset = "0x69A0170", VA = "0x1869A1370")]
	static POAFCKFCEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private POAFCKFCEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class IBKPFKLKOPH : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class COCBFHGMNNE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4D390D0", Offset = "0x4D37ED0", VA = "0x184D390D0")]
		static COCBFHGMNNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public IBKPFKLKOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class PHEKOHBKAIM : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class FAJMHBEMHKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x35F1C30", Offset = "0x35F0A30", VA = "0x1835F1C30")]
		static FAJMHBEMHKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PHEKOHBKAIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class DHLJHBPCFBG : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class INDJEPCNKPP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x38A1130", Offset = "0x389FF30", VA = "0x1838A1130")]
		static INDJEPCNKPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public DHLJHBPCFBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class JFMBDNBIEMG : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class LCAFJDHJPFN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2D60", Offset = "0x3BF1B60", VA = "0x183BF2D60")]
		static LCAFJDHJPFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public JFMBDNBIEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class GPPODNNKDOI : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class BHJGAEIOBPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x47BA920", Offset = "0x47B9720", VA = "0x1847BA920")]
		static BHJGAEIOBPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public GPPODNNKDOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class IBBMODFGCIO : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class DAIHBHKMFJL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x501BD90", Offset = "0x501AB90", VA = "0x18501BD90")]
		static DAIHBHKMFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> HMMIECNIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool BILBDNPOCKP;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public IBBMODFGCIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class DMFDEIEMPOK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct MNJHFOPGAAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AEODDCIJMGA KHDPLFLELPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder DMMHONJIDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder FNKOKJDDNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class KIEOBKGNKCE
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class DELLJJCINAO
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo KENJGIBMBKB;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo BABJMJEHMCI;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo KOCGBOFFFAJ;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo LCICJIDAMPD;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo AGLEHEIFHGN;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo LEMHJECJKME;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo BBMLDDCBPJG;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo NHNOMIGMHDF;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo NNODDGMJBDO;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x698C450", Offset = "0x698B250", VA = "0x18698C450")]
			static DELLJJCINAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class BPDLHMHENKL
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo OHCHGDAAEHA;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo MJJBFGIJEIP;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo IOLGPOBLEIO;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo FOOBFAAHMIP;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo KMAJHNONOJO;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo IKEGPDDBDDN;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo IGPFPPNMEKO;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x698B430", Offset = "0x698A230", VA = "0x18698B430")]
			static BPDLHMHENKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class EDGJLGAALLM
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo LOENCKKACEE;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo FFAHLDBEJLL;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo HMFELCNHCDO;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo GKIFLMNEJCD;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo DFLDGCDNEGG;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo DGABFIBHJNL;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo HNPMOJAHEOF;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo DAFMEPDLKLC;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo EOJMPONBIGJ;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo JCCIJBPPKOL;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo LPJCCEEDHPM;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo LGLPIBDOPCC;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo ALODMLCMIJJ;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo JHELNACBIGO;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x699B0E0", Offset = "0x6999EE0", VA = "0x18699B0E0")]
		public static MethodInfo CDDFPMJNNJO(Type LPFFKBBBCBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x699AEA0", Offset = "0x6999CA0", VA = "0x18699AEA0")]
		public static MethodInfo APHAODHFANA(Type LPFFKBBBCBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x699B370", Offset = "0x699A170", VA = "0x18699B370")]
		public static MethodInfo OEIMBDDIKGM(Type LPFFKBBBCBL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class GLDKNAAEHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<AEODDCIJMGA, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public GLDKNAAEHNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class KBIODFEEHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public GLDKNAAEHNC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public KBIODFEEHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x699AE60", Offset = "0x6999C60", VA = "0x18699AE60")]
		internal void KFPNFAKOHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x699ADC0", Offset = "0x6999BC0", VA = "0x18699ADC0")]
		internal bool JCEENDOEOIG(int index, AEODDCIJMGA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IILHJJELLPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GLDKNAAEHNC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public IILHJJELLPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6996E20", Offset = "0x6995C20", VA = "0x186996E20")]
		internal bool GNFGPEBAFOI(int index, AEODDCIJMGA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class ACNKAEGBGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public ACNKAEGBGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x36377C0", Offset = "0x36365C0", VA = "0x1836377C0")]
		internal string BAFNIPLEALM(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class PMDLBPFNJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public PMDLBPFNJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x69A1310", Offset = "0x69A0110", VA = "0x1869A1310")]
		internal bool CCEBKFPMKIJ(AEODDCIJMGA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HILHMBLBJOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ACNKAEGBGGO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public HILHMBLBJOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6996750", Offset = "0x6995550", VA = "0x186996750")]
		internal void GOAMGCNGIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x69965D0", Offset = "0x69953D0", VA = "0x1869965D0")]
		internal bool FPAJILIGOIJ(int index, AEODDCIJMGA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class IEHGNJEMDCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public ACNKAEGBGGO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public IEHGNJEMDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6996CA0", Offset = "0x6995AA0", VA = "0x186996CA0")]
		internal bool JKAGFOBLOIE(int index, AEODDCIJMGA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class FPILGKNKNGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public FPILGKNKNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x69963A0", Offset = "0x69951A0", VA = "0x1869963A0")]
		internal Label BILMBOCMPOK(AEODDCIJMGA _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class INDBCCMBHDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public MNJHFOPGAAJ[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, AEODDCIJMGA, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public JCDFOGJMJEH argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public JCDFOGJMJEH argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public INDBCCMBHDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6998D70", Offset = "0x6997B70", VA = "0x186998D70")]
		internal MNJHFOPGAAJ EHBMBCABOAB(AEODDCIJMGA item)
		{
			return default(MNJHFOPGAAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class BFBJOCBGDGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public INDBCCMBHDM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public BFBJOCBGDGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6987C30", Offset = "0x6986A30", VA = "0x186987C30")]
		internal void DKGKCBPAALP(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6987EC0", Offset = "0x6986CC0", VA = "0x186987EC0")]
		internal void MLAAFKCKHBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LGMAIOAJLGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AEODDCIJMGA item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public LGMAIOAJLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB9A450", Offset = "0xB99250", VA = "0x180B9A450")]
		internal bool IPLMFOPGGAF(MNJHFOPGAAJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class FNOGHPOHMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AEODDCIJMGA item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public FNOGHPOHMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB9A450", Offset = "0xB99250", VA = "0x180B9A450")]
		internal bool CFBHANIHLGJ(MNJHFOPGAAJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex GEEHMCBPBGK;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int INDJPLDONAM;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> NNLICKFJEPL;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> COPGLCGKAOI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x25D6120", Offset = "0x25D4F20", VA = "0x1825D6120")]
	public static object MCHFLKFEKLG<T>(KGEMLJCECGG ICLNCINPFME, LNCEEOCCIFN OIKBNGNPLBC, Func<string, string> HMMIECNIPDL, bool BILBDNPOCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x25CB2F0", Offset = "0x25CA0F0", VA = "0x1825CB2F0")]
	public static object MBCOECHDNEA<T>(LNCEEOCCIFN OIKBNGNPLBC, Func<string, string> HMMIECNIPDL, bool BILBDNPOCKP, bool MEJFLNFECFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x698FB40", Offset = "0x698E940", VA = "0x18698FB40")]
	private static TypeInfo KPKBFKJNCGB(KGEMLJCECGG ICLNCINPFME, Type LPFFKBBBCBL, Func<string, string> HMMIECNIPDL, bool BILBDNPOCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6991BA0", Offset = "0x69909A0", VA = "0x186991BA0")]
	public static object MLCAPMKHAOH(Type LPFFKBBBCBL, Func<string, string> HMMIECNIPDL, bool BILBDNPOCKP, bool MEJFLNFECFF, bool MPDLHFJEHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x698DB50", Offset = "0x698C950", VA = "0x18698DB50")]
	private static Dictionary<AEODDCIJMGA, FieldInfo> DDLFCAOCBNL(TypeBuilder IJDNDGBDCBA, AKHNDHPLPDM EFLINIEMOEE, ConstructorInfo OMHFOKENAPK, FieldBuilder GMNPGBEEFHF, ILGenerator JAGDCBIABLD, bool BILBDNPOCKP, bool GFMGCHKMPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6994B70", Offset = "0x6993970", VA = "0x186994B70")]
	private static Dictionary<AEODDCIJMGA, FieldInfo> NHBMMMJEEIO(TypeBuilder IJDNDGBDCBA, AKHNDHPLPDM EFLINIEMOEE, ILGenerator JAGDCBIABLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6990560", Offset = "0x698F360", VA = "0x186990560")]
	private static void MDAMHIJCGLI(Type LPFFKBBBCBL, AKHNDHPLPDM EFLINIEMOEE, ILGenerator JAGDCBIABLD, Action MFDMEFCDJPD, Func<int, AEODDCIJMGA, bool> OHJIFKJEOAN, bool BILBDNPOCKP, bool GFMGCHKMPAD, int CMINLCEABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x698E280", Offset = "0x698D080", VA = "0x18698E280")]
	private static void EIFGGJNJBBB(TypeInfo LPFFKBBBCBL, AEODDCIJMGA NKALGMMDECH, ILGenerator JAGDCBIABLD, int OHINPGIGDNE, Func<int, AEODDCIJMGA, bool> OHJIFKJEOAN, JCDFOGJMJEH FCAJMDOFLNK, JCDFOGJMJEH MDJDPMJGBCL, JCDFOGJMJEH PLEHILMFDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x69936D0", Offset = "0x69924D0", VA = "0x1869936D0")]
	private static void NECFMJBOKIE(Type LPFFKBBBCBL, AKHNDHPLPDM EFLINIEMOEE, ILGenerator JAGDCBIABLD, Func<int, AEODDCIJMGA, bool> OHJIFKJEOAN, bool OOKACEMGGEN, int CMINLCEABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x698F550", Offset = "0x698E350", VA = "0x18698F550")]
	private static void HNNMGJOBGCH(ILGenerator JAGDCBIABLD, MNJHFOPGAAJ EFLINIEMOEE, int OHINPGIGDNE, Func<int, AEODDCIJMGA, bool> OHJIFKJEOAN, JCDFOGJMJEH INLIFCPEGKK, JCDFOGJMJEH PLEHILMFDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x698E7C0", Offset = "0x698D5C0", VA = "0x18698E7C0")]
	private static LocalBuilder EOABMCAKPCB(ILGenerator JAGDCBIABLD, Type LPFFKBBBCBL, AKHNDHPLPDM EFLINIEMOEE, MNJHFOPGAAJ[] FJDAFCJBFOP, bool GHDFANLFGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x698D470", Offset = "0x698C270", VA = "0x18698D470")]
	private static bool BJAEPHGEHKB(ConstructorInfo KFEBOKPNLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x698F9C0", Offset = "0x698E7C0", VA = "0x18698F9C0")]
	private static bool JCDFAPFCEFI(Type LPFFKBBBCBL, [Out] Type KFJPGFMJLFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void EDDEPFAIFNK<T>(byte[][] GMNPGBEEFHF, object[] BJPEDGAHNCF, MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN AEBEIKCOJPH);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T HPFJIHCHMBJ<T>(object[] BJPEDGAHNCF, BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN AEBEIKCOJPH);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class FHONBKJBCJN<T> : EOBPAHIDCCA<T>, AEBJIPJMENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] GMNPGBEEFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] AOFELMHJBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] NJEGJKFMDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly EDDEPFAIFNK<T> GHHGPKNCNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly HPFJIHCHMBJ<T> IOPBHGELOCA;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E600", Offset = "0x1D8D400", VA = "0x181D8E600")]
	public FHONBKJBCJN(byte[][] GMNPGBEEFHF, object[] AOFELMHJBMJ, object[] NJEGJKFMDFO, EDDEPFAIFNK<T> GHHGPKNCNJM, HPFJIHCHMBJ<T> IOPBHGELOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x360D1F0", Offset = "0x360BFF0", VA = "0x18360D1F0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x360D100", Offset = "0x360BF00", VA = "0x18360D100", Slot = "5")]
	public T APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class HIFJHNGEDIJ : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class BCCAFFCDBPC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4751B90", Offset = "0x4750990", VA = "0x184751B90")]
		static BCCAFFCDBPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private HIFJHNGEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class OIBDEONGCMP : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class KEBMKAKKOHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DA90", Offset = "0x3B0C890", VA = "0x183B0DA90")]
		static KEBMKAKKOHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private OIBDEONGCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class KKILIIHPPNL
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly LNCEEOCCIFN[] ONKADGNFCOP;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class MAPMDHBLDPO : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class GFMCGKDKDGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x36F4A90", Offset = "0x36F3890", VA = "0x1836F4A90")]
		static GFMCGKDKDGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class OAFPNKMPNKM : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class DKADPPMJFNL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5045AC0", Offset = "0x50448C0", VA = "0x185045AC0")]
			static DKADPPMJFNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private OAFPNKMPNKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private MAPMDHBLDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class MCKACOGHDEP : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class GCPIAAKCBLA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x36E91C0", Offset = "0x36E7FC0", VA = "0x1836E91C0")]
		static GCPIAAKCBLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class PHFGJIPHGKL : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class IBIPMLJDDPG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x38627D0", Offset = "0x38615D0", VA = "0x1838627D0")]
			static IBIPMLJDDPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private PHFGJIPHGKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private MCKACOGHDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class NHNNMGPNKEF : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class LKIBMCKPHOC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3C27420", Offset = "0x3C26220", VA = "0x183C27420")]
		static LKIBMCKPHOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class JNBLMDBKNGJ : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class FOPMEBJGKJI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x364D750", Offset = "0x364C550", VA = "0x18364D750")]
			static FOPMEBJGKJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private JNBLMDBKNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private NHNNMGPNKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class CGFBJNADNIM : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class HNECDCBONOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x37D1CF0", Offset = "0x37D0AF0", VA = "0x1837D1CF0")]
		static HNECDCBONOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class MDILDNABGKH : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class JLKFMLJKDJK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3A70E50", Offset = "0x3A6FC50", VA = "0x183A70E50")]
			static JLKFMLJKDJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private MDILDNABGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private CGFBJNADNIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class HHHIFDLCKOJ : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class LCCGNJIMHBJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF96C0", Offset = "0x3BF84C0", VA = "0x183BF96C0")]
		static LCCGNJIMHBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class BCCDNDDEGIH : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class GFNDIBDEKHO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x36F9710", Offset = "0x36F8510", VA = "0x1836F9710")]
			static GFNDIBDEKHO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private BCCDNDDEGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private HHHIFDLCKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class CPDNOJFCIIH : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class FGKNBGKKEJL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3602550", Offset = "0x3601350", VA = "0x183602550")]
		static FGKNBGKKEJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class PBPIJNHEKJN : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class GOIMKMBPLBG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3718090", Offset = "0x3716E90", VA = "0x183718090")]
			static GOIMKMBPLBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private PBPIJNHEKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private CPDNOJFCIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class PHHHPGDKHJP : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class IOMDBFAMMHH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x38A7A00", Offset = "0x38A6800", VA = "0x1838A7A00")]
		static IOMDBFAMMHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class CDJJHPJIBEO : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class DJPKAJLINHK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5042700", Offset = "0x5041500", VA = "0x185042700")]
			static DJPKAJLINHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private CDJJHPJIBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private PHHHPGDKHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class CADPDJFMPEG : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class BMLKJNGOGAI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x48AE5A0", Offset = "0x48AD3A0", VA = "0x1848AE5A0")]
		static BMLKJNGOGAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class GNEIJPIOHBM : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class AEMEAHADIDF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x38B7210", Offset = "0x38B6010", VA = "0x1838B7210")]
			static AEMEAHADIDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private GNEIJPIOHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private CADPDJFMPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class ENELMCLECFA : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class OAJPKGNFKMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3FAAAE0", Offset = "0x3FA98E0", VA = "0x183FAAAE0")]
		static OAJPKGNFKMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class LOHPAMPNANG : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class IJNCIKPPOEN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x388A6E0", Offset = "0x38894E0", VA = "0x18388A6E0")]
			static IJNCIKPPOEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private LOHPAMPNANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private ENELMCLECFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class PADLMBBIMPM : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class LLNCIGPKIEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C304A0", Offset = "0x3C2F2A0", VA = "0x183C304A0")]
		static LLNCIGPKIEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class BIKAPBLLGJN : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class JJLAMIFEBAO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3A6DD40", Offset = "0x3A6CB40", VA = "0x183A6DD40")]
			static JJLAMIFEBAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private BIKAPBLLGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private PADLMBBIMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class LACOEEFKLOB : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class FHGCIKDCJGE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3606D30", Offset = "0x3605B30", VA = "0x183606D30")]
		static FHGCIKDCJGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class ALHLBOKHBFO : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class KOJMPBNILDD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3B88DC0", Offset = "0x3B87BC0", VA = "0x183B88DC0")]
			static KOJMPBNILDD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private ALHLBOKHBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private LACOEEFKLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class OCEKNJGGMIC : LNCEEOCCIFN
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class AEIAPCGFHKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x375EE40", Offset = "0x375DC40", VA = "0x18375EE40")]
		static AEIAPCGFHKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class MNLBECKLEBD : LNCEEOCCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class DCMLDCKALPD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly EOBPAHIDCCA<T> KGOIEKIFHMI;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x50212A0", Offset = "0x50200A0", VA = "0x1850212A0")]
			static DCMLDCKALPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly LNCEEOCCIFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly LNCEEOCCIFN[] GACLDLIONIB;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private MNLBECKLEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
		public EOBPAHIDCCA<T> OELNKKJKACK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly LNCEEOCCIFN ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly EOBPAHIDCCA<object> CCIMKKAGELK;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	private OCEKNJGGMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	public EOBPAHIDCCA<T> OELNKKJKACK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct AKCPNGKHCBA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] DGOMIJDIBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int LGOFLDBOEMA;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x39A2DC0", Offset = "0x39A1BC0", VA = "0x1839A2DC0")]
	public AKCPNGKHCBA(int LAJNMJLCNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x39A28F0", Offset = "0x39A16F0", VA = "0x1839A28F0")]
	public void GALNLGNAACN(T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x39A2D30", Offset = "0x39A1B30", VA = "0x1839A2D30")]
	public T[] IHCFJPKKPKE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class KBLJCBDFHHG : CFDFPJHILOK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly KBLJCBDFHHG DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x69B21D0", Offset = "0x69B0FD0", VA = "0x1869B21D0")]
	public KBLJCBDFHHG(int CIADIECEBDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class CFDFPJHILOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int CIADIECEBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object ECBNFFCKGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int OHINPGIGDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] GIFDLKFEJDH;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4C5DE60", Offset = "0x4C5CC60", VA = "0x184C5DE60")]
	public CFDFPJHILOK(int CIADIECEBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C5D860", Offset = "0x4C5C660", VA = "0x184C5D860")]
	public T[] GDNABHAICFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C5DC20", Offset = "0x4C5CA20", VA = "0x184C5DC20")]
	public void KOPJGAKFDOE(T[] HHAMBPGBENG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class GKNNDMOEKKM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class GIEBGEJEMPC : IComparable<GIEBGEJEMPC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class MGPELGLBJFO : IEnumerable<GIEBGEJEMPC>, IEnumerable, IEnumerator<GIEBGEJEMPC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private GIEBGEJEMPC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public GIEBGEJEMPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private GIEBGEJEMPC System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
			[DebuggerHidden]
			public MGPELGLBJFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x69B2D10", Offset = "0x69B1B10", VA = "0x1869B2D10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x69B2E40", Offset = "0x69B1C40", VA = "0x1869B2E40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x69B2D90", Offset = "0x69B1B90", VA = "0x1869B2D90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GIEBGEJEMPC> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x69B2D90", Offset = "0x69B1B90", VA = "0x1869B2D90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class LLCAHJKNGKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public LLCAHJKNGKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x69963A0", Offset = "0x69951A0", VA = "0x1869963A0")]
			internal Label PNCOEKHDBBP(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x69963A0", Offset = "0x69951A0", VA = "0x1869963A0")]
			internal Label CBKCGIFNEHI(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly GIEBGEJEMPC[] ACDPIMKFKPM;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] JFFCJCNIBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong HBMNMFEKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int CIONEDGAKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string CODECKKFGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private GIEBGEJEMPC[] CJIFIAFJMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] IBDJLEFOELI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int DPKFLHPPNCH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool EAMEHCNAFPI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x52DE040", Offset = "0x52DCE40", VA = "0x1852DE040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x69AC7E0", Offset = "0x69AB5E0", VA = "0x1869AC7E0")]
		public GIEBGEJEMPC(ulong ONOECNHBCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x69AB5C0", Offset = "0x69AA3C0", VA = "0x1869AB5C0")]
		public GIEBGEJEMPC GALNLGNAACN(ulong ONOECNHBCDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x69AB560", Offset = "0x69AA360", VA = "0x1869AB560")]
		public GIEBGEJEMPC GALNLGNAACN(ulong ONOECNHBCDA, int MAEBFBHFPDE, string CODECKKFGBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x69AB7C0", Offset = "0x69AA5C0", VA = "0x1869AB7C0")]
		public GIEBGEJEMPC LAHLPMNNKMB(byte[] BNKGEELECNO, int LBJEFCOBKGF, int ADMKMCMKAJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x69AB9C0", Offset = "0x69AA7C0", VA = "0x1869AB9C0")]
		internal static int MLKJPFCPDEK(ulong[] HHAMBPGBENG, int OHINPGIGDNE, int AKCMMEDPGHB, ulong MAEBFBHFPDE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x69AB530", Offset = "0x69AA330", VA = "0x1869AB530", Slot = "4")]
		public int CompareTo(GIEBGEJEMPC EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x69AB940", Offset = "0x69AA740", VA = "0x1869AB940")]
		[IteratorStateMachine(typeof(MGPELGLBJFO))]
		public IEnumerable<GIEBGEJEMPC> LEFMCIEPOMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x69AB1B0", Offset = "0x69A9FB0", VA = "0x1869AB1B0")]
		public void AAOLPPHEPDL(ILGenerator JAGDCBIABLD, LocalBuilder BNKGEELECNO, LocalBuilder ADMKMCMKAJM, LocalBuilder ONOECNHBCDA, Action<KeyValuePair<string, int>> PCDABDJEABH, Action GHEAPDODNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x69ABA50", Offset = "0x69AA850", VA = "0x1869ABA50")]
		private static void OJMFPEABCFN(ILGenerator JAGDCBIABLD, LocalBuilder BNKGEELECNO, LocalBuilder ADMKMCMKAJM, LocalBuilder ONOECNHBCDA, Action<KeyValuePair<string, int>> PCDABDJEABH, Action GHEAPDODNOB, GIEBGEJEMPC[] CJIFIAFJMJD, int DPKFLHPPNCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class PHJFCOPJHNK : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private IEnumerable<GIEBGEJEMPC> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<GIEBGEJEMPC> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<GIEBGEJEMPC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private GIEBGEJEMPC <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA87FC0", Offset = "0xA86DC0", VA = "0x180A87FC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x69B7C00", Offset = "0x69B6A00", VA = "0x1869B7C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CA17A0", Offset = "0x1CA05A0", VA = "0x181CA17A0")]
		[DebuggerHidden]
		public PHJFCOPJHNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x69B7C50", Offset = "0x69B6A50", VA = "0x1869B7C50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x69B7650", Offset = "0x69B6450", VA = "0x1869B7650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x69B7600", Offset = "0x69B6400", VA = "0x1869B7600")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x69B7AB0", Offset = "0x69B68B0", VA = "0x1869B7AB0")]
		private void PDHPDAEENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x69B7BB0", Offset = "0x69B69B0", VA = "0x1869B7BB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x69B7B00", Offset = "0x69B6900", VA = "0x1869B7B00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x69B7B00", Offset = "0x69B6900", VA = "0x1869B7B00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly GIEBGEJEMPC GOKLEGFJHEB;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x69AD350", Offset = "0x69AC150", VA = "0x1869AD350")]
	public GKNNDMOEKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x69ACCE0", Offset = "0x69ABAE0", VA = "0x1869ACCE0")]
	public void GALNLGNAACN(byte[] HCFBAPHHICF, int MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x69AD1E0", Offset = "0x69ABFE0", VA = "0x1869AD1E0")]
	public bool NLBEDBBCNBF(ArraySegment<byte> ONOECNHBCDA, [Out] int MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x69AD2C0", Offset = "0x69AC0C0", VA = "0x1869AD2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x69ACF00", Offset = "0x69ABD00", VA = "0x1869ACF00")]
	private static void NEGOEBEJOKA(IEnumerable<GIEBGEJEMPC> CJIFIAFJMJD, StringBuilder GNKEDKBIMAC, int NBANIMBJCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x69ACDF0", Offset = "0x69ABBF0", VA = "0x1869ACDF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x69ACDF0", Offset = "0x69ABBF0", VA = "0x1869ACDF0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x69ACE50", Offset = "0x69ABC50", VA = "0x1869ACE50")]
	[IteratorStateMachine(typeof(PHJFCOPJHNK))]
	private static IEnumerable<KeyValuePair<string, int>> IDOMHIFGMAF(IEnumerable<GIEBGEJEMPC> CJIFIAFJMJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x69ACED0", Offset = "0x69ABCD0", VA = "0x1869ACED0")]
	public void MKGDJIOJCEE(ILGenerator JAGDCBIABLD, LocalBuilder BNKGEELECNO, LocalBuilder ADMKMCMKAJM, LocalBuilder ONOECNHBCDA, Action<KeyValuePair<string, int>> PCDABDJEABH, Action GHEAPDODNOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class PMKKHODCIOL
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo GFOLDALMKPG;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x69B7DA0", Offset = "0x69B6BA0", VA = "0x1869B7DA0")]
	public static ulong CEJKPOMOJGH(byte[] HCFBAPHHICF, int LBJEFCOBKGF, int ADMKMCMKAJM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class AJIJLHIOPML
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69A2C70", Offset = "0x69A1A70", VA = "0x1869A2C70")]
	public static void ILPEDGONBCF(byte[] HCFBAPHHICF, int LBJEFCOBKGF, int PEIEGLLFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x69A2DB0", Offset = "0x69A1BB0", VA = "0x1869A2DB0")]
	public static void OBMJOPEFEKN(byte[] HHAMBPGBENG, int KKABCLALAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x69A2ED0", Offset = "0x69A1CD0", VA = "0x1869A2ED0")]
	public static byte[] ONOHJAGPHNA(byte[] MCFKOLILEBF, int KKABCLALAJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class BEBADFGKPKO
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69A4940", Offset = "0x69A3740", VA = "0x1869A4940")]
	public static bool LHCAAHNMCLB(byte[] ANKHBAIOGIL, int ANBDAHPEKOK, int NOKPHONCDKD, byte[] ABGNJNPHFHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class NECGKCJNDJJ<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct MLPEDEDEFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] HBMNMFEKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T CIONEDGAKHL;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E31BD0", Offset = "0x3E309D0", VA = "0x183E31BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class NIINLIDEPMH : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public NECGKCJNDJJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private MLPEDEDEFKE[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private MLPEDEDEFKE[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA87FC0", Offset = "0xA86DC0", VA = "0x180A87FC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x3685650", Offset = "0x3684450", VA = "0x183685650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
		[DebuggerHidden]
		public NIINLIDEPMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3EB3850", Offset = "0x3EB2650", VA = "0x183EB3850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4BB0", Offset = "0x3EB39B0", VA = "0x183EB4BB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly MLPEDEDEFKE[][] KGGBDJBLNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong HFKIDDJCNDG;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3E88840", Offset = "0x3E87640", VA = "0x183E88840")]
	public NECGKCJNDJJ(int DKDCFCAKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E88860", Offset = "0x3E87660", VA = "0x183E88860")]
	public NECGKCJNDJJ(int DKDCFCAKJAJ, float GFEILBJHLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3E87B80", Offset = "0x3E86980", VA = "0x183E87B80")]
	public void GALNLGNAACN(byte[] ONOECNHBCDA, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3E87E00", Offset = "0x3E86C00", VA = "0x183E87E00")]
	private bool LGOHLKJGLMI(byte[] ONOECNHBCDA, T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E87330", Offset = "0x3E86130", VA = "0x183E87330")]
	public bool EMHKBCLCPNM(ArraySegment<byte> ONOECNHBCDA, [Out] T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3E87DB0", Offset = "0x3E86BB0", VA = "0x183E87DB0")]
	private static ulong IJOCKOPILKC(byte[] BJKAJHEJDMP, int LBJEFCOBKGF, int DPKFLHPPNCH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3E87D80", Offset = "0x3E86B80", VA = "0x183E87D80")]
	private static int HIAPLGKFPHO(int LHBDGFCGCBF, float GFEILBJHLMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E87C60", Offset = "0x3E86A60", VA = "0x183E87C60", Slot = "4")]
	[IteratorStateMachine(typeof(NECGKCJNDJJ<>.NIINLIDEPMH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x34F6B00", Offset = "0x34F5900", VA = "0x1834F6B00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class GJEFBKIKKED : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] KONLJJNIDNA;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] BCIIANLBABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int MBGKEADILOH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool AAKBNNCLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69AC8A0", Offset = "0x69AB6A0", VA = "0x1869AC8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x69AC9F0", Offset = "0x69AB7F0", VA = "0x1869AC9F0")]
	static GJEFBKIKKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x69ACC50", Offset = "0x69ABA50", VA = "0x1869ACC50")]
	public GJEFBKIKKED(byte[] BAPHHBPMFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x69AC8F0", Offset = "0x69AB6F0", VA = "0x1869AC8F0")]
	public OpCode ICJMGOJFGLA()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct OMAABJEBFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid CIONEDGAKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte BNNFGLGFHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte ALAOGMOPIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte NHOKDFDNHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte JDNBKAGCIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte GLDFFMJPNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte MFLHDPLFGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte JDHJCKJKLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte IGOIILCKKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte EBOJDDLFNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte FPAKIBADOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte LDHGPOKGDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte DNOKFOMCPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte DGOBFKBAJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte AMBHAHMEGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte ECPJFAECLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte EEBPHFJGCMI;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] PIOGDEKIOFO;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] MEJFOHJLHHD;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x69B4F60", Offset = "0x69B3D60", VA = "0x1869B4F60")]
	public OMAABJEBFOD(Guid MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x69B4F70", Offset = "0x69B3D70", VA = "0x1869B4F70")]
	public OMAABJEBFOD(ArraySegment<byte> AGONGMHKILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x69B4CB0", Offset = "0x69B3AB0", VA = "0x1869B4CB0")]
	private static byte LPKEMMNDFKG(byte[] HCFBAPHHICF, int IMKDLKHFLOB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x69B4D50", Offset = "0x69B3B50", VA = "0x1869B4D50")]
	private static byte MHDFMNKPALH(byte FNDBFMFAGPH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x69B4000", Offset = "0x69B2E00", VA = "0x1869B4000")]
	public void IAJGBDBCFBH(byte[] LIICAAPCJGB, int LBJEFCOBKGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class IOJDLODEMGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x69B03D0", Offset = "0x69AF1D0", VA = "0x1869B03D0")]
	public static bool ELDFAMKDHKD(byte MEJOABMJHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x69B0610", Offset = "0x69AF410", VA = "0x1869B0610")]
	public static bool HCEIJOKFCLH(byte MEJOABMJHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x69B0760", Offset = "0x69AF560", VA = "0x1869B0760")]
	public static sbyte JICCEGIBGED(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x69B1200", Offset = "0x69B0000", VA = "0x1869B1200")]
	public static short LFFPDFPJCKK(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x69B12F0", Offset = "0x69B00F0", VA = "0x1869B12F0")]
	public static int LJJPHGKCGGP(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x69B15D0", Offset = "0x69B03D0", VA = "0x1869B15D0")]
	public static long MKIDHCPEICD(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x69B02D0", Offset = "0x69AF0D0", VA = "0x1869B02D0")]
	public static byte BFLFCEOGFCH(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x69B1D10", Offset = "0x69B0B10", VA = "0x1869B1D10")]
	public static ushort PMGLNJAHIKM(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x69B0350", Offset = "0x69AF150", VA = "0x1869B0350")]
	public static uint BNBMPPNFKIF(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x69B14C0", Offset = "0x69B02C0", VA = "0x1869B14C0")]
	public static ulong MJHJAJICHGE(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x69B0680", Offset = "0x69AF480", VA = "0x1869B0680")]
	public static float JCPEHDJJJED(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x69B13E0", Offset = "0x69B01E0", VA = "0x1869B13E0")]
	public static double LPLMJFHIMNL(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x69B1670", Offset = "0x69B0470", VA = "0x1869B1670")]
	public static int NOJAPFFKIPG(byte[] LIICAAPCJGB, int LBJEFCOBKGF, ulong MAEBFBHFPDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x69B0840", Offset = "0x69AF640", VA = "0x1869B0840")]
	public static int LCPEBFIMCPB(byte[] LIICAAPCJGB, int LBJEFCOBKGF, long MAEBFBHFPDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x69B03E0", Offset = "0x69AF1E0", VA = "0x1869B03E0")]
	public static bool GMHLHAJPHMC(byte[] HCFBAPHHICF, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class FKHLFDEJNNP
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class MIHHIGPFFHG : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
		[DebuggerHidden]
		public MIHHIGPFFHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x69B3470", Offset = "0x69B2270", VA = "0x1869B3470", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x69B2EE0", Offset = "0x69B1CE0", VA = "0x1869B2EE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x69B2E90", Offset = "0x69B1C90", VA = "0x1869B2E90")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x69B3310", Offset = "0x69B2110", VA = "0x1869B3310")]
		private void PDHPDAEENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x69B3420", Offset = "0x69B2220", VA = "0x1869B3420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x69B3360", Offset = "0x69B2160", VA = "0x1869B3360", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x69B3360", Offset = "0x69B2160", VA = "0x1869B3360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class BKMNMBFBPLH : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
		[DebuggerHidden]
		public BKMNMBFBPLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x69A5160", Offset = "0x69A3F60", VA = "0x1869A5160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x69A4BD0", Offset = "0x69A39D0", VA = "0x1869A4BD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x69A4B80", Offset = "0x69A3980", VA = "0x1869A4B80")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x69A5000", Offset = "0x69A3E00", VA = "0x1869A5000")]
		private void PDHPDAEENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x69A5110", Offset = "0x69A3F10", VA = "0x1869A5110", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x69A5050", Offset = "0x69A3E50", VA = "0x1869A5050", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x69A5050", Offset = "0x69A3E50", VA = "0x1869A5050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x69AAE00", Offset = "0x69A9C00", VA = "0x1869AAE00")]
	public static bool BEDCKIIOJKB(this TypeInfo LPFFKBBBCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x69AAFE0", Offset = "0x69A9DE0", VA = "0x1869AAFE0")]
	public static bool GCLGNLHHBHO(this TypeInfo LPFFKBBBCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x69AAD80", Offset = "0x69A9B80", VA = "0x1869AAD80")]
	public static IEnumerable<PropertyInfo> APANMNKAMNN(this Type LPFFKBBBCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x69AAEC0", Offset = "0x69A9CC0", VA = "0x1869AAEC0")]
	[IteratorStateMachine(typeof(MIHHIGPFFHG))]
	private static IEnumerable<PropertyInfo> EIGDIIIAKFK(Type LPFFKBBBCBL, HashSet<string> IPPPPJFNLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x69AAF60", Offset = "0x69A9D60", VA = "0x1869AAF60")]
	public static IEnumerable<FieldInfo> EPPEHFICOMA(this Type LPFFKBBBCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x69AB110", Offset = "0x69A9F10", VA = "0x1869AB110")]
	[IteratorStateMachine(typeof(BKMNMBFBPLH))]
	private static IEnumerable<FieldInfo> KJEDMPCAHGC(Type LPFFKBBBCBL, HashSet<string> IPPPPJFNLKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class HHIAPPDJAIO
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding BICDACICLOK;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class NGCPGKPNMHH
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static string PIIJDNGENOH(string LOCINIADGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x69B3770", Offset = "0x69B2570", VA = "0x1869B3770")]
	public static string EJJNMNDOJIG(string LOCINIADGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x69B3850", Offset = "0x69B2650", VA = "0x1869B3850")]
	public static string JFNAOFJCCEM(string LOCINIADGEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class OFDLPHNFDHG<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class LCHLFLBBHAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type HBMNMFEKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue CIONEDGAKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int KODDFNIBEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public LCHLFLBBHAA JNLGPAPFKNP;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAD90", Offset = "0x3BF9B90", VA = "0x183BFAD90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAD50", Offset = "0x3BF9B50", VA = "0x183BFAD50")]
		private int EDOFPONLMHN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public LCHLFLBBHAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class DDGFNMKOCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public DDGFNMKOCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70")]
		internal TValue KLEEMFAOBCE(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private LCHLFLBBHAA[] KGGBDJBLNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int JEOEJJBKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object CNGLGBCBMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float GFEILBJHLMI;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4190", Offset = "0x3FC2F90", VA = "0x183FC4190")]
	public OFDLPHNFDHG(int DKDCFCAKJAJ = 4, float GFEILBJHLMI = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3FC37E0", Offset = "0x3FC25E0", VA = "0x183FC37E0")]
	public bool IJLDICBJDCE(Type ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3910", Offset = "0x3FC2710", VA = "0x183FC3910")]
	public bool IJLDICBJDCE(Type ONOECNHBCDA, Func<Type, TValue> FNACGKJEGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3980", Offset = "0x3FC2780", VA = "0x183FC3980")]
	private bool LGOHLKJGLMI(Type ONOECNHBCDA, Func<Type, TValue> FNACGKJEGFD, [Out] TValue AFKMFAMGJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3270", Offset = "0x3FC2070", VA = "0x183FC3270")]
	private bool EMIBOKFLMDG(LCHLFLBBHAA[] KGGBDJBLNJJ, Type JJCPHGFMAAB, LCHLFLBBHAA INILFCCLGCO, Func<Type, TValue> FNACGKJEGFD, [Out] TValue AFKMFAMGJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2D70", Offset = "0x3FC1B70", VA = "0x183FC2D70")]
	public bool EMHKBCLCPNM(Type ONOECNHBCDA, [Out] TValue MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4040", Offset = "0x3FC2E40", VA = "0x183FC4040")]
	public TValue NJLMLDPHJOK(Type ONOECNHBCDA, Func<Type, TValue> FNACGKJEGFD)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3E87D80", Offset = "0x3E86B80", VA = "0x183E87D80")]
	private static int HIAPLGKFPHO(int LHBDGFCGCBF, float GFEILBJHLMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3950", Offset = "0x3FC2750", VA = "0x183FC3950")]
	private static void IPEHMPJGEPH(LCHLFLBBHAA PHJFGJAKPGK, LCHLFLBBHAA MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3950", Offset = "0x3FC2750", VA = "0x183FC3950")]
	private static void IPEHMPJGEPH(LCHLFLBBHAA[] PHJFGJAKPGK, LCHLFLBBHAA[] MAEBFBHFPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class KGEMLJCECGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder MBFDCGPGHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder BGNGNJFDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object ECBNFFCKGCL;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x69B2220", Offset = "0x69B1020", VA = "0x1869B2220")]
	public TypeBuilder PCIIGJCKIOF(string OCCHBLONHPL, TypeAttributes DCNMMAHIGEI, Type FEOGIMKDFKL, Type[] JBOPGLLBIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x69B2320", Offset = "0x69B1120", VA = "0x1869B2320")]
	public KGEMLJCECGG(string LIJEJBBFKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class DDMFGPJPDMG
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x69A7470", Offset = "0x69A6270", VA = "0x1869A7470")]
	private static MethodInfo MEFKBFCLKNA(LambdaExpression KGHCIALCBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x25B9400", Offset = "0x25B8200", VA = "0x1825B9400")]
	public static MethodInfo OKJODAHHECC<T>(Expression<Func<T>> KGHCIALCBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x25B9400", Offset = "0x25B8200", VA = "0x1825B9400")]
	public static MethodInfo OKJODAHHECC<T, TR>(Expression<Func<T, TR>> KGHCIALCBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x25B9400", Offset = "0x25B8200", VA = "0x1825B9400")]
	public static MethodInfo OKJODAHHECC<T>(Expression<Action<T>> KGHCIALCBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x25B9400", Offset = "0x25B8200", VA = "0x1825B9400")]
	public static MethodInfo OKJODAHHECC<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> KGHCIALCBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x25B9410", Offset = "0x25B8210", VA = "0x1825B9410")]
	private static MemberInfo PABNAOPPINH<T>(Expression<T> CCBBNNMCBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x25B9360", Offset = "0x25B8160", VA = "0x1825B9360")]
	public static PropertyInfo NAGDMFFGGOD<T, TR>(Expression<Func<T, TR>> KGHCIALCBBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct JCDFOGJMJEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int GKGOKFIMAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool HAKHBJOKBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator JAGDCBIABLD;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x69B1E90", Offset = "0x69B0C90", VA = "0x1869B1E90")]
	public JCDFOGJMJEH(ILGenerator JAGDCBIABLD, int GKGOKFIMAIP, bool HAKHBJOKBHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x69B1ED0", Offset = "0x69B0CD0", VA = "0x1869B1ED0")]
	public JCDFOGJMJEH(ILGenerator JAGDCBIABLD, int GKGOKFIMAIP, Type LPFFKBBBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69B1D90", Offset = "0x69B0B90", VA = "0x1869B1D90")]
	public void OIJOFFBABKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class FGDAKEPADHF
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x69AA8F0", Offset = "0x69A96F0", VA = "0x1869AA8F0")]
	public static void HKBELFBBGBH(this ILGenerator JAGDCBIABLD, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x69AA8B0", Offset = "0x69A96B0", VA = "0x1869AA8B0")]
	public static void HKBELFBBGBH(this ILGenerator JAGDCBIABLD, LocalBuilder LFIIGMMEMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x69A9CA0", Offset = "0x69A8AA0", VA = "0x1869A9CA0")]
	public static void AMIOBFBCEKN(this ILGenerator JAGDCBIABLD, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x69A9C60", Offset = "0x69A8A60", VA = "0x1869A9C60")]
	public static void AMIOBFBCEKN(this ILGenerator JAGDCBIABLD, LocalBuilder LFIIGMMEMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x69AA090", Offset = "0x69A8E90", VA = "0x1869AA090")]
	public static void EGLJOGHJKLO(this ILGenerator JAGDCBIABLD, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x69A9F90", Offset = "0x69A8D90", VA = "0x1869A9F90")]
	public static void EGLJOGHJKLO(this ILGenerator JAGDCBIABLD, LocalBuilder LFIIGMMEMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x69AAAE0", Offset = "0x69A98E0", VA = "0x1869AAAE0")]
	public static void HPLMIJBACAK(this ILGenerator JAGDCBIABLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x69A9F80", Offset = "0x69A8D80", VA = "0x1869A9F80")]
	public static void CIEIJCIIICL(this ILGenerator JAGDCBIABLD, bool MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x69AA2E0", Offset = "0x69A90E0", VA = "0x1869AA2E0")]
	public static void FDDBIIDJPHH(this ILGenerator JAGDCBIABLD, int MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x69AAC00", Offset = "0x69A9A00", VA = "0x1869AAC00")]
	public static void MPLPGMCHBDO(this ILGenerator JAGDCBIABLD, Type LPFFKBBBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x69AACE0", Offset = "0x69A9AE0", VA = "0x1869AACE0")]
	public static void NDAKDADELKK(this ILGenerator JAGDCBIABLD, Type LPFFKBBBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x69AA6C0", Offset = "0x69A94C0", VA = "0x1869AA6C0")]
	public static void GCLFEHKFBFO(this ILGenerator JAGDCBIABLD, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x69AAB80", Offset = "0x69A9980", VA = "0x1869AAB80")]
	public static void LMBKPBBKNED(this ILGenerator JAGDCBIABLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x69AA170", Offset = "0x69A8F70", VA = "0x1869AA170")]
	public static void EHJFCKJLEGL(this ILGenerator JAGDCBIABLD, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x69A9E90", Offset = "0x69A8C90", VA = "0x1869A9E90")]
	public static void BOIIKFENAGI(this ILGenerator JAGDCBIABLD, MethodInfo NJAGOKEEGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x69AAAF0", Offset = "0x69A98F0", VA = "0x1869AAAF0")]
	public static void KMLOEDKFGKL(this ILGenerator JAGDCBIABLD, FieldInfo OOKEJJNLNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69AA250", Offset = "0x69A9050", VA = "0x1869AA250")]
	public static void EMILAJOHNCH(this ILGenerator JAGDCBIABLD, ulong MAEBFBHFPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class AEODDCIJMGA
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class DJNOFFBNACB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public DJNOFFBNACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x69A7730", Offset = "0x69A6530", VA = "0x1869A7730")]
		internal bool PKMDJOLAGDE(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo IHBIHALMPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo BGIINLFGJEK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string PAHJIBDDKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string KJAHAOMLKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PNOHBAOFAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x69A24A0", Offset = "0x69A12A0", VA = "0x1869A24A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ACNNPOCEHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE950", Offset = "0x7BD750", VA = "0x1807BE950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA40", Offset = "0x7BD840", VA = "0x1807BEA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GLBCJMLKPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x914F20", Offset = "0x913D20", VA = "0x180914F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x914A60", Offset = "0x913860", VA = "0x180914A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type BCIPLIOEBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F60", Offset = "0x7B7D60", VA = "0x1807B8F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo KJCMAGKCJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo CGEAAOAENLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7BE970", Offset = "0x7BD770", VA = "0x1807BE970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo MAJEKKCNKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B40", Offset = "0x7B7940", VA = "0x1807B8B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B7D20", VA = "0x1807B8F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x69A2A30", Offset = "0x69A1830", VA = "0x1869A2A30")]
	protected AEODDCIJMGA(Type LPFFKBBBCBL, string OCCHBLONHPL, string DCFPHEJKPPM, bool HDKCBEJGNGN, bool HECAAFMMKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x69A2920", Offset = "0x69A1720", VA = "0x1869A2920")]
	public AEODDCIJMGA(FieldInfo EFLINIEMOEE, string OCCHBLONHPL, bool MEJFLNFECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x69A2AB0", Offset = "0x69A18B0", VA = "0x1869A2AB0")]
	public AEODDCIJMGA(PropertyInfo EFLINIEMOEE, string OCCHBLONHPL, bool MEJFLNFECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x69A24B0", Offset = "0x69A12B0", VA = "0x1869A24B0")]
	private static MethodInfo DEPGEKPADIL(MemberInfo EFLINIEMOEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF46A0", Offset = "0x2CF34A0", VA = "0x182CF46A0")]
	public T MNOMLMINCNA<T>(bool JGHLLBBAGAP) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x69A27A0", Offset = "0x69A15A0", VA = "0x1869A27A0", Slot = "4")]
	public virtual void EJKALMPGCPP(ILGenerator JAGDCBIABLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x69A2620", Offset = "0x69A1420", VA = "0x1869A2620", Slot = "5")]
	public virtual void EAGLKPDCJNP(ILGenerator JAGDCBIABLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class LFPDGADPNBD : AEODDCIJMGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string DMJPNKIGDLJ;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x69B26B0", Offset = "0x69B14B0", VA = "0x1869B26B0")]
	public LFPDGADPNBD(string OCCHBLONHPL, string DMJPNKIGDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x69B2600", Offset = "0x69B1400", VA = "0x1869B2600", Slot = "4")]
	public override void EJKALMPGCPP(ILGenerator JAGDCBIABLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x69B25B0", Offset = "0x69B13B0", VA = "0x1869B25B0", Slot = "5")]
	public override void EAGLKPDCJNP(ILGenerator JAGDCBIABLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class PBHAPFHOGAK : AEODDCIJMGA
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo MEFJMBDLJJD;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo KFJAJJCGGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal JCDFOGJMJEH NCIMKDKEMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal JCDFOGJMJEH MDJDPMJGBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal JCDFOGJMJEH PLEHILMFDIM;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x69B7020", Offset = "0x69B5E20", VA = "0x1869B7020")]
	public PBHAPFHOGAK(string OCCHBLONHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x69B6890", Offset = "0x69B5690", VA = "0x1869B6890", Slot = "4")]
	public override void EJKALMPGCPP(ILGenerator JAGDCBIABLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x69B6840", Offset = "0x69B5640", VA = "0x1869B6840", Slot = "5")]
	public override void EAGLKPDCJNP(ILGenerator JAGDCBIABLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x69B6950", Offset = "0x69B5750", VA = "0x1869B6950")]
	public void HKEMINIOJOG(ILGenerator JAGDCBIABLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class AKHNDHPLPDM
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type BCIPLIOEBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MEAAHACJJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x87B500", Offset = "0x87A300", VA = "0x18087B500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B83F0", Offset = "0x7B71F0", VA = "0x1807B83F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CGMPINAOIFO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x913FA0", Offset = "0x912DA0", VA = "0x180913FA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x913310", Offset = "0x912110", VA = "0x180913310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo LBAACLAHFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F00", Offset = "0x7B7D00", VA = "0x1807B8F00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public AEODDCIJMGA[] LPKAHIPADNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F60", Offset = "0x7B7D60", VA = "0x1807B8F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public AEODDCIJMGA[] GNEKFHFMDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x69A30E0", Offset = "0x69A1EE0", VA = "0x1869A30E0")]
	public AKHNDHPLPDM(Type LPFFKBBBCBL, Func<string, string> EGEKCCLJBIO, bool MEJFLNFECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x69A3000", Offset = "0x69A1E00", VA = "0x1869A3000")]
	private static bool NBGAIEPHFFC(IEnumerator<ConstructorInfo> JGMJHJADIBN, ConstructorInfo ODPLFDEKEED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct MDOGKLJLJOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong CJBAJKJOOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int IOKJIKNDOFL;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1DD40A0", Offset = "0x1DD2EA0", VA = "0x181DD40A0")]
	public MDOGKLJLJOE(ulong NKJFCEFKNDI, int CIOAGLFMNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x69B2C60", Offset = "0x69B1A60", VA = "0x1869B2C60")]
	public void KGBFPOHOIMF(MDOGKLJLJOE EDOEJIMPOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x69B2B30", Offset = "0x69B1930", VA = "0x1869B2B30")]
	public static MDOGKLJLJOE CBCFEKIFKIB(MDOGKLJLJOE AOHIFIJNOBB, MDOGKLJLJOE FNDBFMFAGPH)
	{
		return default(MDOGKLJLJOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x69B2B40", Offset = "0x69B1940", VA = "0x1869B2B40")]
	public void EGCPIDLPLDH(MDOGKLJLJOE EDOEJIMPOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x69B2C70", Offset = "0x69B1A70", VA = "0x1869B2C70")]
	public static MDOGKLJLJOE NHLHDKGKKOK(MDOGKLJLJOE AOHIFIJNOBB, MDOGKLJLJOE FNDBFMFAGPH)
	{
		return default(MDOGKLJLJOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x69B2BD0", Offset = "0x69B19D0", VA = "0x1869B2BD0")]
	public void IGNFCGGLBLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x69B2C10", Offset = "0x69B1A10", VA = "0x1869B2C10")]
	public static MDOGKLJLJOE IGNFCGGLBLI(MDOGKLJLJOE AOHIFIJNOBB)
	{
		return default(MDOGKLJLJOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct OIJEILGJPJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] LIICAAPCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int LBJEFCOBKGF;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1865EF0", Offset = "0x1864CF0", VA = "0x181865EF0")]
	public OIJEILGJPJE(byte[] LIICAAPCJGB, int AJFNKFFNDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x69A0490", Offset = "0x699F290", VA = "0x1869A0490")]
	public void DHCIIHIGBKN(byte OMFBJPLNJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x69B3CE0", Offset = "0x69B2AE0", VA = "0x1869B3CE0")]
	public void DHDDOGKIAMD(byte[] OMFBJPLNJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x69B3E00", Offset = "0x69B2C00", VA = "0x1869B3E00")]
	public void FNOANMCEBIP(byte[] OMFBJPLNJIJ, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x69B3D60", Offset = "0x69B2B60", VA = "0x1869B3D60")]
	public void FNOANMCEBIP(byte[] OMFBJPLNJIJ, int CJNJFDOAKGB, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x69B3E80", Offset = "0x69B2C80", VA = "0x1869B3E80")]
	public void HEDFIGCNABM(byte MEJOABMJHGI, int DPKFLHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69B3F00", Offset = "0x69B2D00", VA = "0x1869B3F00")]
	public void JMBCFFOODLJ(string OMFBJPLNJIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class ECIMCCLDKJO
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum FEOODPIANHO
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum PIBAOMIHGHK
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum EHIKBCIGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[ThreadStatic]
	private static byte[] CAHJNABJLLH;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] PENKDEBEDPK;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] BLGINBEMOMN;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] MNDOLHIHFJD;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly EHIKBCIGMBA MMLEAFDLPLH;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char HICCMFNLKBE;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int CAHPAODIHCK;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int GHMHIICMLBI;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] OKDNPMMENCN;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x69A8480", Offset = "0x69A7280", VA = "0x1869A8480")]
	private static byte[] IIDNBGEOCNA(int JEOEJJBKODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x69A7930", Offset = "0x69A6730", VA = "0x1869A7930")]
	private static byte[] HDLCBLPIJHO(int JEOEJJBKODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x69A96D0", Offset = "0x69A84D0", VA = "0x1869A96D0")]
	public static int PHIANEBGKFM(byte[] LIICAAPCJGB, int LBJEFCOBKGF, float MAEBFBHFPDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x69A95B0", Offset = "0x69A83B0", VA = "0x1869A95B0")]
	public static int PHIANEBGKFM(byte[] LIICAAPCJGB, int LBJEFCOBKGF, double MAEBFBHFPDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x69A7840", Offset = "0x69A6640", VA = "0x1869A7840")]
	private static bool BPPEKODHBLI(byte[] LIICAAPCJGB, int AKCMMEDPGHB, ulong GHJOBJDLGFA, ulong CBNBMIDHLKJ, ulong ADMKMCMKAJM, ulong HHFABOOPBKH, ulong IOENFJLJAEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x69A8280", Offset = "0x69A7080", VA = "0x1869A8280")]
	private static void IBPPIMHONDL(uint PBDJDCDANCD, int GIEFBCDHFGJ, [Out] uint JAHDHNJPEBH, [Out] int IOEEJOOMOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x69A7A10", Offset = "0x69A6810", VA = "0x1869A7A10")]
	private static bool HFPPAMKPBFA(MDOGKLJLJOE FDCLFEPBKMK, MDOGKLJLJOE LFPADPMEJPL, MDOGKLJLJOE LDIHMNNLKIE, byte[] LIICAAPCJGB, [Out] int AKCMMEDPGHB, [Out] int NOAPCPPNDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x69A7E00", Offset = "0x69A6C00", VA = "0x1869A7E00")]
	private static bool HLLPOEDEMPL(double FJKGEGOOFKM, FEOODPIANHO DEFFIHPLIBJ, byte[] LIICAAPCJGB, [Out] int AKCMMEDPGHB, [Out] int BLAGEFFNJMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x69A8370", Offset = "0x69A7170", VA = "0x1869A8370")]
	private static bool ICMDKPOJBPD(double FJKGEGOOFKM, FEOODPIANHO DEFFIHPLIBJ, byte[] LIICAAPCJGB, [Out] int AKCMMEDPGHB, [Out] int KFFMDDIACEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x69A8E60", Offset = "0x69A7C60", VA = "0x1869A8E60")]
	private static bool MNMEGKPAGDJ(double MAEBFBHFPDE, OIJEILGJPJE AFJNIOMGNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x69A8980", Offset = "0x69A7780", VA = "0x1869A8980")]
	private static bool KIECDLMPPGL(double MAEBFBHFPDE, OIJEILGJPJE AFJNIOMGNOM, PIBAOMIHGHK DEFFIHPLIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x69A9030", Offset = "0x69A7E30", VA = "0x1869A9030")]
	private static void MPPDDMKEBMP(byte[] HBCGHMKMNKL, int AKCMMEDPGHB, int KFFMDDIACEN, int IKHIIBCHIBB, OIJEILGJPJE AFJNIOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x69A8550", Offset = "0x69A7350", VA = "0x1869A8550")]
	private static void KDDDKJCCBIK(byte[] HBCGHMKMNKL, int AKCMMEDPGHB, int CIOAGLFMNAB, OIJEILGJPJE AFJNIOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x69A93C0", Offset = "0x69A81C0", VA = "0x1869A93C0")]
	private static bool NMLACKJAKFC(double FJKGEGOOFKM, PIBAOMIHGHK DEFFIHPLIBJ, int EOINOPMCKEC, byte[] ACOBIKOBIGI, [Out] bool EHODGADOEPH, [Out] int AKCMMEDPGHB, [Out] int MNMDECHMAEG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct DDBDKNFCLCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double GLPEKNLBHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong LHIAPAMCPJJ;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct LOBAADPCDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float CJBAJKJOOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint PBDBPLEPBKE;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct AEMMNFPGCPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong IHJPPCHBEBL;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x69A23F0", Offset = "0x69A11F0", VA = "0x1869A23F0")]
	public AEMMNFPGCPK(double GLPEKNLBHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x69A2400", Offset = "0x69A1200", VA = "0x1869A2400")]
	public AEMMNFPGCPK(MDOGKLJLJOE GLPEKNLBHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x69A1EB0", Offset = "0x69A0CB0", VA = "0x1869A1EB0")]
	public MDOGKLJLJOE ALIMLHHGNDE()
	{
		return default(MDOGKLJLJOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x69A1F20", Offset = "0x69A0D20", VA = "0x1869A1F20")]
	public MDOGKLJLJOE BPEMGGKGCDD()
	{
		return default(MDOGKLJLJOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
	public ulong ODDJBBDBGMI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x69A2020", Offset = "0x69A0E20", VA = "0x1869A2020")]
	public double GMLIDLANFIJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x69A2320", Offset = "0x69A1120", VA = "0x1869A2320")]
	public double OKOJHHODFHI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x69A1FF0", Offset = "0x69A0DF0", VA = "0x1869A1FF0")]
	public int FENAJFJPJDA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x69A23C0", Offset = "0x69A11C0", VA = "0x1869A23C0")]
	public ulong PKLCAJGHJLI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x69A1E90", Offset = "0x69A0C90", VA = "0x1869A1E90")]
	public bool AELIAKKIOBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x69A2160", Offset = "0x69A0F60", VA = "0x1869A2160")]
	public bool LHJLFPCDDKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x69A1FC0", Offset = "0x69A0DC0", VA = "0x1869A1FC0")]
	public bool FDIPNNBELDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x69A1E60", Offset = "0x69A0C60", VA = "0x1869A1E60")]
	public bool AECHPIEIHMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x69A1FA0", Offset = "0x69A0DA0", VA = "0x1869A1FA0")]
	public int EICIGJPNJCE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x69A2180", Offset = "0x69A0F80", VA = "0x1869A2180")]
	public void LMNEDIMIEKF([Out] MDOGKLJLJOE KCLNEIKIDCD, [Out] MDOGKLJLJOE AMJDPDLODOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x69A22D0", Offset = "0x69A10D0", VA = "0x1869A22D0")]
	public bool NEFBAIGCNDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A340", Offset = "0x2C99140", VA = "0x182C9A340")]
	public double MAEBFBHFPDE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x69A20B0", Offset = "0x69A0EB0", VA = "0x1869A20B0")]
	public static int JINNKAEPDLB(int IMIHFLPIKJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x69A20A0", Offset = "0x69A0EA0", VA = "0x1869A20A0")]
	public static double HMMBBCIEJJI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x69A20D0", Offset = "0x69A0ED0", VA = "0x1869A20D0")]
	public static ulong KLLBIEMFAJM(MDOGKLJLJOE GKMEEIFHFBC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct CJDPMONGKIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint PMOFDPLIOGK;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F13690", Offset = "0x1F12490", VA = "0x181F13690")]
	public CJDPMONGKIJ(float CJBAJKJOOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x69A5770", Offset = "0x69A4570", VA = "0x1869A5770")]
	public MDOGKLJLJOE ALIMLHHGNDE()
	{
		return default(MDOGKLJLJOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
	public uint NJLDCOMNMBI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x69A57C0", Offset = "0x69A45C0", VA = "0x1869A57C0")]
	public int FENAJFJPJDA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x69A5950", Offset = "0x69A4750", VA = "0x1869A5950")]
	public uint PKLCAJGHJLI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x69A5760", Offset = "0x69A4560", VA = "0x1869A5760")]
	public bool AELIAKKIOBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x69A57E0", Offset = "0x69A45E0", VA = "0x1869A57E0")]
	public void LMNEDIMIEKF([Out] MDOGKLJLJOE KCLNEIKIDCD, [Out] MDOGKLJLJOE AMJDPDLODOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x69A5910", Offset = "0x69A4710", VA = "0x1869A5910")]
	public bool NEFBAIGCNDC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct POHBMAPOIAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong NKJFCEFKNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short MKADJHHEBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short BLAGEFFNJMF;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x69B89C0", Offset = "0x69B77C0", VA = "0x1869B89C0")]
	public POHBMAPOIAE(ulong NKJFCEFKNDI, short MKADJHHEBEK, short BLAGEFFNJMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class HLEONKPMLPJ
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly POHBMAPOIAE[] CFNINPHICDF;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x69AF260", Offset = "0x69AE060", VA = "0x1869AF260")]
	public static void NOCOPIGHCOL(int EPFFIGNAKEF, int JFCHIOENILM, [Out] MDOGKLJLJOE JAHDHNJPEBH, [Out] int BLAGEFFNJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x69AF190", Offset = "0x69ADF90", VA = "0x1869AF190")]
	public static void MLILCCLOBGD(int NLOMIKHFCMI, [Out] MDOGKLJLJOE JAHDHNJPEBH, [Out] int GMINGMFMCMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct EMPIBFFOGCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] HCFBAPHHICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int CJNJFDOAKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int DAMGMGAFAIG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x69A9AA0", Offset = "0x69A88A0", VA = "0x1869A9AA0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3791FA0", Offset = "0x3790DA0", VA = "0x183791FA0")]
	public EMPIBFFOGCC(byte[] HCFBAPHHICF, int CJNJFDOAKGB, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F41D60", Offset = "0x1F40B60", VA = "0x181F41D60")]
	public int AKCMMEDPGHB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x69A9A40", Offset = "0x69A8840", VA = "0x1869A9A40")]
	public EMPIBFFOGCC GCCEFJMFHPB(int MJNOHBDDECC, int ANDIBGAILAG)
	{
		return default(EMPIBFFOGCC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class CNDLELCMDHF
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] HICKDEIHKAJ;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] JEGDCKKOMAI;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int HKMINMBIACJ;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x69A7070", Offset = "0x69A5E70", VA = "0x1869A7070")]
	private static byte[] NINAIJEKAAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x69A5970", Offset = "0x69A4770", VA = "0x1869A5970")]
	private static EMPIBFFOGCC AONINBMNJPO(EMPIBFFOGCC LIICAAPCJGB)
	{
		return default(EMPIBFFOGCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x69A7150", Offset = "0x69A5F50", VA = "0x1869A7150")]
	private static EMPIBFFOGCC ONFNEDLFDNM(EMPIBFFOGCC LIICAAPCJGB)
	{
		return default(EMPIBFFOGCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x69A64A0", Offset = "0x69A52A0", VA = "0x1869A64A0")]
	private static void HDKPKEOIKDE(EMPIBFFOGCC LIICAAPCJGB, int CIOAGLFMNAB, byte[] AJFJOMINLLJ, [Out] int FPHAMLEIKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x69A6530", Offset = "0x69A5330", VA = "0x1869A6530")]
	private static void HOJJMFNKFMN(EMPIBFFOGCC LIICAAPCJGB, int CIOAGLFMNAB, byte[] FLOLFCGPFIN, int DOHPFDIBDLA, [Out] EMPIBFFOGCC HJIDADGGEKI, [Out] int MHIAAJBDFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x69A6C10", Offset = "0x69A5A10", VA = "0x1869A6C10")]
	private static ulong LIHCJCOLEOP(EMPIBFFOGCC LIICAAPCJGB, [Out] int DCOMGCHNPPF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x69A6360", Offset = "0x69A5160", VA = "0x1869A6360")]
	private static void GHNPIHIPGME(EMPIBFFOGCC LIICAAPCJGB, [Out] MDOGKLJLJOE ELGNBNFKLLL, [Out] int DMBMGBLNHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x69A6CA0", Offset = "0x69A5AA0", VA = "0x1869A6CA0")]
	private static bool MLEOCDHCAIA(EMPIBFFOGCC HJIDADGGEKI, int CIOAGLFMNAB, [Out] double ELGNBNFKLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x69A5B70", Offset = "0x69A4970", VA = "0x1869A5B70")]
	private static MDOGKLJLJOE CBGGDJEAIAO(int CIOAGLFMNAB)
	{
		return default(MDOGKLJLJOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x69A5D10", Offset = "0x69A4B10", VA = "0x1869A5D10")]
	private static bool FFPJAHOJLJO(EMPIBFFOGCC LIICAAPCJGB, int CIOAGLFMNAB, [Out] double ELGNBNFKLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x69A6AF0", Offset = "0x69A58F0", VA = "0x1869A6AF0")]
	private static bool KAPMPGIPPBJ(EMPIBFFOGCC HJIDADGGEKI, int CIOAGLFMNAB, [Out] double EMKKGAJHHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x69A5A50", Offset = "0x69A4850", VA = "0x1869A5A50")]
	public static double? BAGDJOFANBH(EMPIBFFOGCC LIICAAPCJGB, int CIOAGLFMNAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x69A6820", Offset = "0x69A5620", VA = "0x1869A6820")]
	public static float? IDIEONDPOOF(EMPIBFFOGCC LIICAAPCJGB, int CIOAGLFMNAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct DIEBBANNJOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] LIICAAPCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int LBJEFCOBKGF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte CIONEDGAKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x69A76C0", Offset = "0x69A64C0", VA = "0x1869A76C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1865EF0", Offset = "0x1864CF0", VA = "0x181865EF0")]
	public DIEBBANNJOM(byte[] LIICAAPCJGB, int LBJEFCOBKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x69A75C0", Offset = "0x69A63C0", VA = "0x1869A75C0")]
	public static DIEBBANNJOM CGHALAOJHIH(DIEBBANNJOM OELHNDCFEMO)
	{
		return default(DIEBBANNJOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x69A7640", Offset = "0x69A6440", VA = "0x1869A7640")]
	public static DIEBBANNJOM LAOAHLPDKDH(DIEBBANNJOM OELHNDCFEMO, int AKCMMEDPGHB)
	{
		return default(DIEBBANNJOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x69A7720", Offset = "0x69A6520", VA = "0x1869A7720")]
	public static int PMCFGOFDBNP(DIEBBANNJOM MAJJJNOEIPE, DIEBBANNJOM FBEFKCHGALI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x69A7600", Offset = "0x69A6400", VA = "0x1869A7600")]
	public static bool EILLJGMDDAM(DIEBBANNJOM MAJJJNOEIPE, DIEBBANNJOM FBEFKCHGALI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x69A75B0", Offset = "0x69A63B0", VA = "0x1869A75B0")]
	public static bool CDMEFABOJMD(DIEBBANNJOM MAJJJNOEIPE, DIEBBANNJOM FBEFKCHGALI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x69A7610", Offset = "0x69A6410", VA = "0x1869A7610")]
	public static bool EILLJGMDDAM(DIEBBANNJOM MAJJJNOEIPE, char FBEFKCHGALI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x69A7580", Offset = "0x69A6380", VA = "0x1869A7580")]
	public static bool CDMEFABOJMD(DIEBBANNJOM MAJJJNOEIPE, char FBEFKCHGALI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x69A7580", Offset = "0x69A6380", VA = "0x1869A7580")]
	public static bool CDMEFABOJMD(DIEBBANNJOM MAJJJNOEIPE, byte FBEFKCHGALI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x69A75D0", Offset = "0x69A63D0", VA = "0x1869A75D0")]
	public static bool DOJNPLHBFDH(DIEBBANNJOM MAJJJNOEIPE, char FBEFKCHGALI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x69A7550", Offset = "0x69A6350", VA = "0x1869A7550")]
	public static bool AIHCHNMIFHD(DIEBBANNJOM MAJJJNOEIPE, char FBEFKCHGALI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x69A76F0", Offset = "0x69A64F0", VA = "0x1869A76F0")]
	public static bool LIMNCLLMJKC(DIEBBANNJOM MAJJJNOEIPE, char FBEFKCHGALI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x69A7690", Offset = "0x69A6490", VA = "0x1869A7690")]
	public static bool LCHHKINHBGG(DIEBBANNJOM MAJJJNOEIPE, char FBEFKCHGALI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class GPLBBAIFAOL
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] GBIIPAHHDKM;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] KJCAPOIDPFF;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] BLGINBEMOMN;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] MNDOLHIHFJD;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] BFBMEHCPPDG;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int LOEKPFEFHAN;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] ENAIJHCEMBG;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int AAEFECNHDOM;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x69AD5A0", Offset = "0x69AC3A0", VA = "0x1869AD5A0")]
	private static byte[] CLLOHKMOIGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x69AEAB0", Offset = "0x69AD8B0", VA = "0x1869AEAB0")]
	private static byte[] PDHMHDDILNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x69AE9B0", Offset = "0x69AD7B0", VA = "0x1869AE9B0")]
	public static double NKNLKPHNGED(byte[] LIICAAPCJGB, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x69AD770", Offset = "0x69AC570", VA = "0x1869AD770")]
	public static float HBEBJADBENO(byte[] LIICAAPCJGB, int LBJEFCOBKGF, [Out] int OKLLOBOGPPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x69AEB90", Offset = "0x69AD990", VA = "0x1869AEB90")]
	private static bool PLAPOOOIKIL(int BJKAJHEJDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x69AE7C0", Offset = "0x69AD5C0", VA = "0x1869AE7C0")]
	private static bool LMHDDNKOLJP(DIEBBANNJOM PCCBOCOMPKF, DIEBBANNJOM INMKHBKJJMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x69AD6A0", Offset = "0x69AC4A0", VA = "0x1869AD6A0")]
	private static bool DDKHNMMPKJD(DIEBBANNJOM PCCBOCOMPKF, DIEBBANNJOM INMKHBKJJMP, byte[] MLPEFICIPFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x69AEA60", Offset = "0x69AD860", VA = "0x1869AEA60")]
	private static bool OGANDHLMIEN(DIEBBANNJOM PAHDLPCDKJI, byte[] OMFBJPLNJIJ, int LBJEFCOBKGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x69AD680", Offset = "0x69AC480", VA = "0x1869AD680")]
	private static double DBLJEMEIPPF(bool EHODGADOEPH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x69AD820", Offset = "0x69AC620", VA = "0x1869AD820")]
	private static double JGJMCMFBJNN(DIEBBANNJOM PMNEDIFJMIN, int AKCMMEDPGHB, bool FKEBJOODIBJ, [Out] int NJMMMNFPKCB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class BMEHAKGAAND<T> : EOBPAHIDCCA<T[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly CFDFPJHILOK<T> LLFJLGIHECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly GLEGFEGEPPE IOOPEOHKEPO;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3870BA0", Offset = "0x386F9A0", VA = "0x183870BA0")]
	public BMEHAKGAAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
	public BMEHAKGAAND(GLEGFEGEPPE IOOPEOHKEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x47D6100", Offset = "0x47D4F00", VA = "0x1847D6100", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x47D5D30", Offset = "0x47D4B30", VA = "0x1847D5D30", Slot = "5")]
	public T[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class PEDCOEBENKB<T> : EOBPAHIDCCA<ArraySegment<T>>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly CFDFPJHILOK<T> LLFJLGIHECM;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x409EEF0", Offset = "0x409DCF0", VA = "0x18409EEF0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ArraySegment<T> MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x409EAD0", Offset = "0x409D8D0", VA = "0x18409EAD0", Slot = "5")]
	public ArraySegment<T> APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class ICGMCPDIELO<T> : EOBPAHIDCCA<List<T>>, AEBJIPJMENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly GLEGFEGEPPE IOOPEOHKEPO;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3870BA0", Offset = "0x386F9A0", VA = "0x183870BA0")]
	public ICGMCPDIELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
	public ICGMCPDIELO(GLEGFEGEPPE IOOPEOHKEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x386E090", Offset = "0x386CE90", VA = "0x18386E090", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, List<T> MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x386CC50", Offset = "0x386BA50", VA = "0x18386CC50", Slot = "5")]
	public List<T> APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class HKEACIDKNPL<TElement, TIntermediate, TEnumerator, TCollection> : EOBPAHIDCCA<TCollection>, AEBJIPJMENI where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x37CC820", Offset = "0x37CB620", VA = "0x1837CC820", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, TCollection MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x37CB190", Offset = "0x37C9F90", VA = "0x1837CB190", Slot = "5")]
	public TCollection APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator KGHHBLLDOMH(TCollection CCBBNNMCBIL);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate KNBFKAAGFFE();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void GALNLGNAACN(TIntermediate GPNEIINKPKB, int OHINPGIGDNE, TElement MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection HOEPGDMFNPH(TIntermediate OMACIOBFGCN);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected HKEACIDKNPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class GCINEKPMHPN<TElement, TIntermediate, TCollection> : HKEACIDKNPL<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x36E3CC0", Offset = "0x36E2AC0", VA = "0x1836E3CC0", Slot = "6")]
	protected override IEnumerator<TElement> KGHHBLLDOMH(TCollection CCBBNNMCBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3277670", Offset = "0x3276470", VA = "0x183277670")]
	protected GCINEKPMHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class CIMJIBMBGAC<TElement, TCollection> : GCINEKPMHPN<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected sealed override TCollection HOEPGDMFNPH(TCollection OMACIOBFGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class DCJAHGDOEJB<TElement, TCollection> : CIMJIBMBGAC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x501FCE0", Offset = "0x501EAE0", VA = "0x18501FCE0", Slot = "7")]
	protected override TCollection KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x501FC20", Offset = "0x501EA20", VA = "0x18501FC20", Slot = "8")]
	protected override void GALNLGNAACN(TCollection GPNEIINKPKB, int OHINPGIGDNE, TElement MAEBFBHFPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class EMFGOECDGBP<T> : HKEACIDKNPL<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x32B28B0", Offset = "0x32B16B0", VA = "0x1832B28B0", Slot = "8")]
	protected override void GALNLGNAACN(LinkedList<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override LinkedList<T> HOEPGDMFNPH(LinkedList<T> OMACIOBFGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override LinkedList<T> KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x32B28F0", Offset = "0x32B16F0", VA = "0x1832B28F0", Slot = "6")]
	protected override LinkedList<T>.Enumerator KGHHBLLDOMH(LinkedList<T> CCBBNNMCBIL)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class PGGCICGCCHB<T> : HKEACIDKNPL<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x32B28B0", Offset = "0x32B16B0", VA = "0x1832B28B0", Slot = "8")]
	protected override void GALNLGNAACN(Queue<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override Queue<T> KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x38BAEC0", Offset = "0x38B9CC0", VA = "0x1838BAEC0", Slot = "6")]
	protected override Queue<T>.Enumerator KGHHBLLDOMH(Queue<T> CCBBNNMCBIL)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override Queue<T> HOEPGDMFNPH(Queue<T> OMACIOBFGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class AECADEFBBMK<T> : HKEACIDKNPL<T, AKCPNGKHCBA<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3293FE0", Offset = "0x3292DE0", VA = "0x183293FE0", Slot = "8")]
	protected override void GALNLGNAACN(AKCPNGKHCBA<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3294090", Offset = "0x3292E90", VA = "0x183294090", Slot = "7")]
	protected override AKCPNGKHCBA<T> KNBFKAAGFFE()
	{
		return default(AKCPNGKHCBA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3758F80", Offset = "0x3757D80", VA = "0x183758F80", Slot = "6")]
	protected override Stack<T>.Enumerator KGHHBLLDOMH(Stack<T> CCBBNNMCBIL)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3758EA0", Offset = "0x3757CA0", VA = "0x183758EA0", Slot = "9")]
	protected override Stack<T> HOEPGDMFNPH(AKCPNGKHCBA<T> OMACIOBFGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class AFKIFKMIPGO<T> : HKEACIDKNPL<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x32B28B0", Offset = "0x32B16B0", VA = "0x1832B28B0", Slot = "8")]
	protected override void GALNLGNAACN(HashSet<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override HashSet<T> HOEPGDMFNPH(HashSet<T> OMACIOBFGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override HashSet<T> KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x38BAEC0", Offset = "0x38B9CC0", VA = "0x1838BAEC0", Slot = "6")]
	protected override HashSet<T>.Enumerator KGHHBLLDOMH(HashSet<T> CCBBNNMCBIL)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class NHPJHEKEFGM<T> : GCINEKPMHPN<T, AKCPNGKHCBA<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3293FE0", Offset = "0x3292DE0", VA = "0x183293FE0", Slot = "8")]
	protected override void GALNLGNAACN(AKCPNGKHCBA<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2800", Offset = "0x3EB1600", VA = "0x183EB2800", Slot = "9")]
	protected override ReadOnlyCollection<T> HOEPGDMFNPH(AKCPNGKHCBA<T> OMACIOBFGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3EB28A0", Offset = "0x3EB16A0", VA = "0x183EB28A0", Slot = "7")]
	protected override AKCPNGKHCBA<T> KNBFKAAGFFE()
	{
		return default(AKCPNGKHCBA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class AALGBMPLPAE<T> : GCINEKPMHPN<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x32B28B0", Offset = "0x32B16B0", VA = "0x1832B28B0", Slot = "8")]
	protected override void GALNLGNAACN(List<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override List<T> KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override IList<T> HOEPGDMFNPH(List<T> OMACIOBFGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class NEGKCOKNHPM<T> : GCINEKPMHPN<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x32B28B0", Offset = "0x32B16B0", VA = "0x1832B28B0", Slot = "8")]
	protected override void GALNLGNAACN(List<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override List<T> KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override ICollection<T> HOEPGDMFNPH(List<T> OMACIOBFGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class CNOKLGFOGFH<T> : GCINEKPMHPN<T, AKCPNGKHCBA<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3293FE0", Offset = "0x3292DE0", VA = "0x183293FE0", Slot = "8")]
	protected override void GALNLGNAACN(AKCPNGKHCBA<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3294090", Offset = "0x3292E90", VA = "0x183294090", Slot = "7")]
	protected override AKCPNGKHCBA<T> KNBFKAAGFFE()
	{
		return default(AKCPNGKHCBA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4D38570", Offset = "0x4D37370", VA = "0x184D38570", Slot = "9")]
	protected override IEnumerable<T> HOEPGDMFNPH(AKCPNGKHCBA<T> OMACIOBFGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x32850C0", Offset = "0x3283EC0", VA = "0x1832850C0")]
	public CNOKLGFOGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class CCODDMCJJAF<TKey, TElement> : EOBPAHIDCCA<IGrouping<TKey, TElement>>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x4B86EA0", Offset = "0x4B85CA0", VA = "0x184B86EA0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, IGrouping<TKey, TElement> MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x4B86BA0", Offset = "0x4B859A0", VA = "0x184B86BA0", Slot = "5")]
	public IGrouping<TKey, TElement> APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class FHIOFEOGDKN<TKey, TElement> : EOBPAHIDCCA<ILookup<TKey, TElement>>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x360B0E0", Offset = "0x3609EE0", VA = "0x18360B0E0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ILookup<TKey, TElement> MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x360AD90", Offset = "0x3609B90", VA = "0x18360AD90", Slot = "5")]
	public ILookup<TKey, TElement> APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class LKKMFCALJBB<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey ONOECNHBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> CFHMGHCOIDN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey HBMNMFEKKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7C6440", Offset = "0x7C5240", VA = "0x1807C6440")]
	public LKKMFCALJBB(TKey ONOECNHBCDA, IEnumerable<TElement> CFHMGHCOIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3C29210", Offset = "0x3C28010", VA = "0x183C29210", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3294810", Offset = "0x3293610", VA = "0x183294810", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class FNCNILAOMOF<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> NICJPFPIKOB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3637C20", Offset = "0x3636A20", VA = "0x183637C20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public FNCNILAOMOF(Dictionary<TKey, IGrouping<TKey, TElement>> NICJPFPIKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3637B20", Offset = "0x3636920", VA = "0x183637B20", Slot = "5")]
	public bool Contains(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3637B60", Offset = "0x3636960", VA = "0x183637B60", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3637B60", Offset = "0x3636960", VA = "0x183637B60", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class PBDOGEPCPOL<T> : EOBPAHIDCCA<T>, AEBJIPJMENI where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x40993D0", Offset = "0x40981D0", VA = "0x1840993D0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x4099150", Offset = "0x4097F50", VA = "0x184099150", Slot = "5")]
	public T APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PBDOGEPCPOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NHKEOEIJJII : EOBPAHIDCCA<IEnumerable>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly EOBPAHIDCCA<IEnumerable> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x69C7810", Offset = "0x69C6610", VA = "0x1869C7810", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, IEnumerable MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x69C75C0", Offset = "0x69C63C0", VA = "0x1869C75C0", Slot = "5")]
	public IEnumerable APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public NHKEOEIJJII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class HPNACMPPALP : EOBPAHIDCCA<ICollection>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly EOBPAHIDCCA<ICollection> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x69C3400", Offset = "0x69C2200", VA = "0x1869C3400", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ICollection MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x69C31B0", Offset = "0x69C1FB0", VA = "0x1869C31B0", Slot = "5")]
	public ICollection APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HPNACMPPALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CDOOHMFDPMO : EOBPAHIDCCA<IList>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly EOBPAHIDCCA<IList> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x69BC6C0", Offset = "0x69BB4C0", VA = "0x1869BC6C0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, IList MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x69BC470", Offset = "0x69BB270", VA = "0x1869BC470", Slot = "5")]
	public IList APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public CDOOHMFDPMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class EDFLMAEPOHP<T> : GCINEKPMHPN<T, AKCPNGKHCBA<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3293FB0", Offset = "0x3292DB0", VA = "0x183293FB0", Slot = "8")]
	protected override void GALNLGNAACN(AKCPNGKHCBA<T> GPNEIINKPKB, int OHINPGIGDNE, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3294090", Offset = "0x3292E90", VA = "0x183294090", Slot = "7")]
	protected override AKCPNGKHCBA<T> KNBFKAAGFFE()
	{
		return default(AKCPNGKHCBA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3294040", Offset = "0x3292E40", VA = "0x183294040", Slot = "9")]
	protected override IReadOnlyList<T> HOEPGDMFNPH(AKCPNGKHCBA<T> OMACIOBFGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x32849F0", Offset = "0x32837F0", VA = "0x1832849F0")]
	public EDFLMAEPOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class IDPKLNMNFFM
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x69C4A70", Offset = "0x69C3870", VA = "0x1869C4A70")]
	public static DateTime JEAGKJGIKFM(DateTime IMGDJKEFGGG)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class EJNMGAKPNCE : EOBPAHIDCCA<DateTime>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly EOBPAHIDCCA<DateTime> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x69BED40", Offset = "0x69BDB40", VA = "0x1869BED40", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, DateTime MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x69BE030", Offset = "0x69BCE30", VA = "0x1869BE030", Slot = "5")]
	public DateTime APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EJNMGAKPNCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class BKNIBOOBEHD : EOBPAHIDCCA<DateTimeOffset>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly EOBPAHIDCCA<DateTimeOffset> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x69BB720", Offset = "0x69BA520", VA = "0x1869BB720", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, DateTimeOffset MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x69BAB00", Offset = "0x69B9900", VA = "0x1869BAB00", Slot = "5")]
	public DateTimeOffset APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public BKNIBOOBEHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class IBLMEJPKBMO : EOBPAHIDCCA<TimeSpan>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly EOBPAHIDCCA<TimeSpan> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] BCGCMPAHLNM;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x69C4130", Offset = "0x69C2F30", VA = "0x1869C4130", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, TimeSpan MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x69C3820", Offset = "0x69C2620", VA = "0x1869C3820", Slot = "5")]
	public TimeSpan APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public IBLMEJPKBMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class FJGHHNHNJKM<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : EOBPAHIDCCA<TDictionary>, AEBJIPJMENI where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3618670", Offset = "0x3617470", VA = "0x183618670", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, TDictionary MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3615180", Offset = "0x3613F80", VA = "0x183615180", Slot = "5")]
	public TDictionary APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator KGHHBLLDOMH(TDictionary CCBBNNMCBIL);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate KNBFKAAGFFE();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void GALNLGNAACN(TIntermediate GPNEIINKPKB, int OHINPGIGDNE, TKey ONOECNHBCDA, TValue MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary HOEPGDMFNPH(TIntermediate OMACIOBFGCN);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected FJGHHNHNJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class HBNNHGJPAGD<TKey, TValue, TIntermediate, TDictionary> : FJGHHNHNJKM<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x36E3CC0", Offset = "0x36E2AC0", VA = "0x1836E3CC0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> KGHHBLLDOMH(TDictionary CCBBNNMCBIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class FKMODHDFLFC<TKey, TValue, TDictionary> : HBNNHGJPAGD<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override TDictionary HOEPGDMFNPH(TDictionary OMACIOBFGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class KLIFNFEFEJN<TKey, TValue> : FJGHHNHNJKM<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B130", Offset = "0x3B29F30", VA = "0x183B2B130", Slot = "8")]
	protected override void GALNLGNAACN(Dictionary<TKey, TValue> GPNEIINKPKB, int OHINPGIGDNE, TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override Dictionary<TKey, TValue> HOEPGDMFNPH(Dictionary<TKey, TValue> OMACIOBFGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override Dictionary<TKey, TValue> KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B280", Offset = "0x3B2A080", VA = "0x183B2B280", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator KGHHBLLDOMH(Dictionary<TKey, TValue> CCBBNNMCBIL)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3276960", Offset = "0x3275760", VA = "0x183276960")]
	public KLIFNFEFEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class HHFOCFCPMIO<TKey, TValue, TDictionary> : FKMODHDFLFC<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x37BB600", Offset = "0x37BA400", VA = "0x1837BB600", Slot = "8")]
	protected override void GALNLGNAACN(TDictionary GPNEIINKPKB, int OHINPGIGDNE, TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3099220", Offset = "0x3098020", VA = "0x183099220", Slot = "7")]
	protected override TDictionary KNBFKAAGFFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class IKJICANKFKF<TKey, TValue> : HBNNHGJPAGD<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3899BD0", Offset = "0x38989D0", VA = "0x183899BD0", Slot = "8")]
	protected override void GALNLGNAACN(Dictionary<TKey, TValue> GPNEIINKPKB, int OHINPGIGDNE, TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override Dictionary<TKey, TValue> KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override IDictionary<TKey, TValue> HOEPGDMFNPH(Dictionary<TKey, TValue> OMACIOBFGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class NNHMJAKBBMK<TKey, TValue> : FKMODHDFLFC<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x3899BD0", Offset = "0x38989D0", VA = "0x183899BD0", Slot = "8")]
	protected override void GALNLGNAACN(SortedList<TKey, TValue> GPNEIINKPKB, int OHINPGIGDNE, TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override SortedList<TKey, TValue> KNBFKAAGFFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class JPLFEKHEHHJ<TKey, TValue> : FJGHHNHNJKM<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3899BD0", Offset = "0x38989D0", VA = "0x183899BD0", Slot = "8")]
	protected override void GALNLGNAACN(SortedDictionary<TKey, TValue> GPNEIINKPKB, int OHINPGIGDNE, TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x89F130", Offset = "0x89DF30", VA = "0x18089F130", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> HOEPGDMFNPH(SortedDictionary<TKey, TValue> OMACIOBFGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1760", VA = "0x1832B2960", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> KNBFKAAGFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3A87F20", Offset = "0x3A86D20", VA = "0x183A87F20", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator KGHHBLLDOMH(SortedDictionary<TKey, TValue> CCBBNNMCBIL)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class EGOJHEPALJL<T> : EOBPAHIDCCA<T>, AEBJIPJMENI where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3295AF0", Offset = "0x32948F0", VA = "0x183295AF0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3295850", Offset = "0x3294650", VA = "0x183295850", Slot = "5")]
	public T APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EGOJHEPALJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class FNPDFIMIBKP : EOBPAHIDCCA<IDictionary>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly EOBPAHIDCCA<IDictionary> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x69C1B30", Offset = "0x69C0930", VA = "0x1869C1B30", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, IDictionary MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x69C1900", Offset = "0x69C0700", VA = "0x1869C1900", Slot = "5")]
	public IDictionary APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public FNPDFIMIBKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class JAJPGLOEEPD : EOBPAHIDCCA<object>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void AOIBENOMLFE(object EEHAPCELOAO, MFNBEJGCMIB FCAJMDOFLNK, object MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly OFDLPHNFDHG<KeyValuePair<object, AOIBENOMLFE>> EKBNIJLGIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly LNCEEOCCIFN[] GIBFMPFEEGF;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x69C5790", Offset = "0x69C4590", VA = "0x1869C5790")]
	public JAJPGLOEEPD(params LNCEEOCCIFN[] GIBFMPFEEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x69C4DD0", Offset = "0x69C3BD0", VA = "0x1869C4DD0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, object MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x69C4D40", Offset = "0x69C3B40", VA = "0x1869C4D40", Slot = "5")]
	public object APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class NOCIMFFIGAN
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x69C7B40", Offset = "0x69C6940", VA = "0x1869C7B40")]
	public static object HLABMBADHDG(Type LPFFKBBBCBL, [Out] bool DJJMMAONHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x69C8430", Offset = "0x69C7230", VA = "0x1869C8430")]
	public static object OBPNMFOKEKA(Type LPFFKBBBCBL, [Out] bool DJJMMAONHCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class PPLMLBPJDMF<T> : EOBPAHIDCCA<T>, AEBJIPJMENI, ECOHJEPCDGP<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class HCPMPKMFDEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public HCPMPKMFDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3790B30", Offset = "0x378F930", VA = "0x183790B30")]
		internal bool FCDCIOMGLKN(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class PAGMLMKMCIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public PAGMLMKMCIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x4097BB0", Offset = "0x40969B0", VA = "0x184097BB0")]
		internal bool BCBAPPHILEE(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class AKPENMPKPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public LIIELLDODCF<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public AKPENMPKPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x39A4A10", Offset = "0x39A3810", VA = "0x1839A4A10")]
		internal void EGIHPEAHGIJ(MFNBEJGCMIB writer, T value, LNCEEOCCIFN _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class AIALFEFMHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public EADHKFMGBKO<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public AIALFEFMHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x38C0070", Offset = "0x38BEE70", VA = "0x1838C0070")]
		internal T GLJPDEPMGEO(BJOFEHNPFPA reader, LNCEEOCCIFN _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly NECGKCJNDJJ<T> BIMKKIGKDEA;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> GIIKIKJGKAA;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly LIIELLDODCF<T> GNJKJFFJHIF;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly EADHKFMGBKO<T> BFADOJLIOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool OBOKEDACGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly LIIELLDODCF<T> IOLDPEHCKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly EADHKFMGBKO<T> EIBEGMBIBFE;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x40E2390", Offset = "0x40E1190", VA = "0x1840E2390")]
	static PPLMLBPJDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x40E7F00", Offset = "0x40E6D00", VA = "0x1840E7F00")]
	public PPLMLBPJDMF(bool OBOKEDACGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x40D81D0", Offset = "0x40D6FD0", VA = "0x1840D81D0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x40D53D0", Offset = "0x40D41D0", VA = "0x1840D53D0", Slot = "5")]
	public T APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x40D9E70", Offset = "0x40D8C70", VA = "0x1840D9E70", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, T MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x40D8810", Offset = "0x40D7610", VA = "0x1840D8810", Slot = "7")]
	public T ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class MNLFEINGACG<T> : EOBPAHIDCCA<T[,]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3E36340", Offset = "0x3E35140", VA = "0x183E36340", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T[,] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3E36010", Offset = "0x3E34E10", VA = "0x183E36010", Slot = "5")]
	public T[,] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MNLFEINGACG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class FEKFHDFACAN<T> : EOBPAHIDCCA<T[,,]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x35F7E40", Offset = "0x35F6C40", VA = "0x1835F7E40", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T[,,] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x35F7A00", Offset = "0x35F6800", VA = "0x1835F7A00", Slot = "5")]
	public T[,,] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public FEKFHDFACAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class MMIPIENPMID<T> : EOBPAHIDCCA<T[,,,]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E34620", Offset = "0x3E33420", VA = "0x183E34620", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T[,,,] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E340D0", Offset = "0x3E32ED0", VA = "0x183E340D0", Slot = "5")]
	public T[,,,] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MMIPIENPMID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class IIDFJHIOFMF<T> : EOBPAHIDCCA<T?>, AEBJIPJMENI where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3886780", Offset = "0x3885580", VA = "0x183886780", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3886400", Offset = "0x3885200", VA = "0x183886400", Slot = "5")]
	public T? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public IIDFJHIOFMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class BHJFINBEIGD<T> : EOBPAHIDCCA<T?>, AEBJIPJMENI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly EOBPAHIDCCA<T> IKFAPEJBKJG;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public BHJFINBEIGD(EOBPAHIDCCA<T> IKFAPEJBKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x477BC10", Offset = "0x477AA10", VA = "0x18477BC10", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, T? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x477B650", Offset = "0x477A450", VA = "0x18477B650", Slot = "5")]
	public T? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class HHLGAMAIMFL : EOBPAHIDCCA<sbyte>, AEBJIPJMENI, ECOHJEPCDGP<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly HHLGAMAIMFL DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x69C2C50", Offset = "0x69C1A50", VA = "0x1869C2C50", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, sbyte MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x69C2C00", Offset = "0x69C1A00", VA = "0x1869C2C00", Slot = "5")]
	public sbyte APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x69C2D70", Offset = "0x69C1B70", VA = "0x1869C2D70", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, sbyte MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x69C2CB0", Offset = "0x69C1AB0", VA = "0x1869C2CB0", Slot = "7")]
	public sbyte ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HHLGAMAIMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class BBLKANMDJGD : EOBPAHIDCCA<sbyte?>, AEBJIPJMENI, ECOHJEPCDGP<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly BBLKANMDJGD DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x69BA580", Offset = "0x69B9380", VA = "0x1869BA580", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, sbyte? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x69BA4D0", Offset = "0x69B92D0", VA = "0x1869BA4D0", Slot = "5")]
	public sbyte? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x69BA760", Offset = "0x69B9560", VA = "0x1869BA760", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, sbyte? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x69BA640", Offset = "0x69B9440", VA = "0x1869BA640", Slot = "7")]
	public sbyte? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public BBLKANMDJGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class ABJNCBJOPBF : EOBPAHIDCCA<sbyte[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly ABJNCBJOPBF DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x69B8DB0", Offset = "0x69B7BB0", VA = "0x1869B8DB0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, sbyte[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x69B8C20", Offset = "0x69B7A20", VA = "0x1869B8C20", Slot = "5")]
	public sbyte[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public ABJNCBJOPBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class BEILIMNHCBJ : EOBPAHIDCCA<short>, AEBJIPJMENI, ECOHJEPCDGP<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly BEILIMNHCBJ DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x69BA8F0", Offset = "0x69B96F0", VA = "0x1869BA8F0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, short MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x69BA8A0", Offset = "0x69B96A0", VA = "0x1869BA8A0", Slot = "5")]
	public short APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x69BAA10", Offset = "0x69B9810", VA = "0x1869BAA10", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, short MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x69BA950", Offset = "0x69B9750", VA = "0x1869BA950", Slot = "7")]
	public short ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public BEILIMNHCBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class BNMBHDIGCKM : EOBPAHIDCCA<short?>, AEBJIPJMENI, ECOHJEPCDGP<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly BNMBHDIGCKM DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x69BC150", Offset = "0x69BAF50", VA = "0x1869BC150", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, short? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x69BC0A0", Offset = "0x69BAEA0", VA = "0x1869BC0A0", Slot = "5")]
	public short? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x69BC330", Offset = "0x69BB130", VA = "0x1869BC330", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, short? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x69BC210", Offset = "0x69BB010", VA = "0x1869BC210", Slot = "7")]
	public short? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public BNMBHDIGCKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class KOEFCNFHEHB : EOBPAHIDCCA<short[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly KOEFCNFHEHB DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x69C6360", Offset = "0x69C5160", VA = "0x1869C6360", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, short[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x69C61D0", Offset = "0x69C4FD0", VA = "0x1869C61D0", Slot = "5")]
	public short[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public KOEFCNFHEHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class JELKAMGJAGG : EOBPAHIDCCA<int>, AEBJIPJMENI, ECOHJEPCDGP<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly JELKAMGJAGG DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x69C5BD0", Offset = "0x69C49D0", VA = "0x1869C5BD0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, int MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x69C5B80", Offset = "0x69C4980", VA = "0x1869C5B80", Slot = "5")]
	public int APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x69C5CF0", Offset = "0x69C4AF0", VA = "0x1869C5CF0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, int MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x69C5C30", Offset = "0x69C4A30", VA = "0x1869C5C30", Slot = "7")]
	public int ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public JELKAMGJAGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class GBNPPNCPMKE : EOBPAHIDCCA<int?>, AEBJIPJMENI, ECOHJEPCDGP<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly GBNPPNCPMKE DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x69C2140", Offset = "0x69C0F40", VA = "0x1869C2140", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, int? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x69C2090", Offset = "0x69C0E90", VA = "0x1869C2090", Slot = "5")]
	public int? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x69C2320", Offset = "0x69C1120", VA = "0x1869C2320", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, int? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x69C2200", Offset = "0x69C1000", VA = "0x1869C2200", Slot = "7")]
	public int? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public GBNPPNCPMKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class CMHACHHJIGF : EOBPAHIDCCA<int[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly CMHACHHJIGF DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x69BCE60", Offset = "0x69BBC60", VA = "0x1869BCE60", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, int[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x69BCCD0", Offset = "0x69BBAD0", VA = "0x1869BCCD0", Slot = "5")]
	public int[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public CMHACHHJIGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class KOOHPEOFFIK : EOBPAHIDCCA<long>, AEBJIPJMENI, ECOHJEPCDGP<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly KOOHPEOFFIK DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x69C6560", Offset = "0x69C5360", VA = "0x1869C6560", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, long MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x69C6510", Offset = "0x69C5310", VA = "0x1869C6510", Slot = "5")]
	public long APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x69C6680", Offset = "0x69C5480", VA = "0x1869C6680", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, long MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x69C65C0", Offset = "0x69C53C0", VA = "0x1869C65C0", Slot = "7")]
	public long ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public KOOHPEOFFIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class ICDGIDOKIEJ : EOBPAHIDCCA<long?>, AEBJIPJMENI, ECOHJEPCDGP<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly ICDGIDOKIEJ DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x69C4730", Offset = "0x69C3530", VA = "0x1869C4730", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, long? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x69C4670", Offset = "0x69C3470", VA = "0x1869C4670", Slot = "5")]
	public long? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x69C4930", Offset = "0x69C3730", VA = "0x1869C4930", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, long? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x69C47F0", Offset = "0x69C35F0", VA = "0x1869C47F0", Slot = "7")]
	public long? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public ICDGIDOKIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class ALDFBGBMADO : EOBPAHIDCCA<long[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly ALDFBGBMADO DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x69BA1D0", Offset = "0x69B8FD0", VA = "0x1869BA1D0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, long[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x69BA040", Offset = "0x69B8E40", VA = "0x1869BA040", Slot = "5")]
	public long[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public ALDFBGBMADO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class GMDDJFALELE : EOBPAHIDCCA<byte>, AEBJIPJMENI, ECOHJEPCDGP<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly GMDDJFALELE DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x69C26D0", Offset = "0x69C14D0", VA = "0x1869C26D0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, byte MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x69C2680", Offset = "0x69C1480", VA = "0x1869C2680", Slot = "5")]
	public byte APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x69C27F0", Offset = "0x69C15F0", VA = "0x1869C27F0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, byte MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x69C2730", Offset = "0x69C1530", VA = "0x1869C2730", Slot = "7")]
	public byte ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public GMDDJFALELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class AEJDPHNMCIN : EOBPAHIDCCA<byte?>, AEBJIPJMENI, ECOHJEPCDGP<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly AEJDPHNMCIN DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x69B9270", Offset = "0x69B8070", VA = "0x1869B9270", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, byte? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x69B91C0", Offset = "0x69B7FC0", VA = "0x1869B91C0", Slot = "5")]
	public byte? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x69B9450", Offset = "0x69B8250", VA = "0x1869B9450", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, byte? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x69B9330", Offset = "0x69B8130", VA = "0x1869B9330", Slot = "7")]
	public byte? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public AEJDPHNMCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class FJGLBLPBEOG : EOBPAHIDCCA<ushort>, AEBJIPJMENI, ECOHJEPCDGP<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly FJGLBLPBEOG DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x69C1220", Offset = "0x69C0020", VA = "0x1869C1220", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ushort MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x69C11D0", Offset = "0x69BFFD0", VA = "0x1869C11D0", Slot = "5")]
	public ushort APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x69C1340", Offset = "0x69C0140", VA = "0x1869C1340", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, ushort MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x69C1280", Offset = "0x69C0080", VA = "0x1869C1280", Slot = "7")]
	public ushort ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public FJGLBLPBEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class MGEBOAHDFMP : EOBPAHIDCCA<ushort?>, AEBJIPJMENI, ECOHJEPCDGP<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly MGEBOAHDFMP DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x69C72A0", Offset = "0x69C60A0", VA = "0x1869C72A0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ushort? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x69C71F0", Offset = "0x69C5FF0", VA = "0x1869C71F0", Slot = "5")]
	public ushort? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x69C7480", Offset = "0x69C6280", VA = "0x1869C7480", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, ushort? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x69C7360", Offset = "0x69C6160", VA = "0x1869C7360", Slot = "7")]
	public ushort? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MGEBOAHDFMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class EFLOAGHOBCF : EOBPAHIDCCA<ushort[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly EFLOAGHOBCF DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x69BDAB0", Offset = "0x69BC8B0", VA = "0x1869BDAB0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ushort[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x69BD920", Offset = "0x69BC720", VA = "0x1869BD920", Slot = "5")]
	public ushort[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EFLOAGHOBCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class DMLELGGEFJH : EOBPAHIDCCA<uint>, AEBJIPJMENI, ECOHJEPCDGP<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly DMLELGGEFJH DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x69BD060", Offset = "0x69BBE60", VA = "0x1869BD060", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, uint MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x69BD010", Offset = "0x69BBE10", VA = "0x1869BD010", Slot = "5")]
	public uint APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x69BD180", Offset = "0x69BBF80", VA = "0x1869BD180", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, uint MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x69BD0C0", Offset = "0x69BBEC0", VA = "0x1869BD0C0", Slot = "7")]
	public uint ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public DMLELGGEFJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class OGCDBPEDCOM : EOBPAHIDCCA<uint?>, AEBJIPJMENI, ECOHJEPCDGP<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly OGCDBPEDCOM DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x69C91A0", Offset = "0x69C7FA0", VA = "0x1869C91A0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, uint? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x69C90F0", Offset = "0x69C7EF0", VA = "0x1869C90F0", Slot = "5")]
	public uint? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x69C9380", Offset = "0x69C8180", VA = "0x1869C9380", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, uint? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x69C9260", Offset = "0x69C8060", VA = "0x1869C9260", Slot = "7")]
	public uint? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public OGCDBPEDCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class JEGCKKOLGIE : EOBPAHIDCCA<uint[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly JEGCKKOLGIE DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x69C59D0", Offset = "0x69C47D0", VA = "0x1869C59D0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, uint[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x69C5840", Offset = "0x69C4640", VA = "0x1869C5840", Slot = "5")]
	public uint[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public JEGCKKOLGIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class BNJBBBKHNCB : EOBPAHIDCCA<ulong>, AEBJIPJMENI, ECOHJEPCDGP<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly BNJBBBKHNCB DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x69BBE90", Offset = "0x69BAC90", VA = "0x1869BBE90", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ulong MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x69BBE40", Offset = "0x69BAC40", VA = "0x1869BBE40", Slot = "5")]
	public ulong APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x69BBFB0", Offset = "0x69BADB0", VA = "0x1869BBFB0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, ulong MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x69BBEF0", Offset = "0x69BACF0", VA = "0x1869BBEF0", Slot = "7")]
	public ulong ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public BNJBBBKHNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class PKEHILGMHHB : EOBPAHIDCCA<ulong?>, AEBJIPJMENI, ECOHJEPCDGP<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly PKEHILGMHHB DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x69C9E50", Offset = "0x69C8C50", VA = "0x1869C9E50", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ulong? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x69C9D90", Offset = "0x69C8B90", VA = "0x1869C9D90", Slot = "5")]
	public ulong? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x69CA050", Offset = "0x69C8E50", VA = "0x1869CA050", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, ulong? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x69C9F10", Offset = "0x69C8D10", VA = "0x1869C9F10", Slot = "7")]
	public ulong? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PKEHILGMHHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class AGDCAFNDHIE : EOBPAHIDCCA<ulong[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly AGDCAFNDHIE DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x69B9A90", Offset = "0x69B8890", VA = "0x1869B9A90", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ulong[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x69B9900", Offset = "0x69B8700", VA = "0x1869B9900", Slot = "5")]
	public ulong[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public AGDCAFNDHIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class KPALKFKGHLB : EOBPAHIDCCA<float>, AEBJIPJMENI, ECOHJEPCDGP<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly KPALKFKGHLB DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x69C67C0", Offset = "0x69C55C0", VA = "0x1869C67C0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, float MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x69C6770", Offset = "0x69C5570", VA = "0x1869C6770", Slot = "5")]
	public float APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x69C68E0", Offset = "0x69C56E0", VA = "0x1869C68E0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, float MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x69C6820", Offset = "0x69C5620", VA = "0x1869C6820", Slot = "7")]
	public float ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public KPALKFKGHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class EJFADGPMKDD : EOBPAHIDCCA<float?>, AEBJIPJMENI, ECOHJEPCDGP<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly EJFADGPMKDD DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x69BDD10", Offset = "0x69BCB10", VA = "0x1869BDD10", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, float? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x69BDC60", Offset = "0x69BCA60", VA = "0x1869BDC60", Slot = "5")]
	public float? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x69BDEF0", Offset = "0x69BCCF0", VA = "0x1869BDEF0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, float? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x69BDDD0", Offset = "0x69BCBD0", VA = "0x1869BDDD0", Slot = "7")]
	public float? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EJFADGPMKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class PAHGKPFCDAK : EOBPAHIDCCA<float[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly PAHGKPFCDAK DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x69C9650", Offset = "0x69C8450", VA = "0x1869C9650", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, float[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x69C94C0", Offset = "0x69C82C0", VA = "0x1869C94C0", Slot = "5")]
	public float[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PAHGKPFCDAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class CGCHEBAMPJF : EOBPAHIDCCA<double>, AEBJIPJMENI, ECOHJEPCDGP<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly CGCHEBAMPJF DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x69BCAC0", Offset = "0x69BB8C0", VA = "0x1869BCAC0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, double MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x69BCA70", Offset = "0x69BB870", VA = "0x1869BCA70", Slot = "5")]
	public double APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x69BCBE0", Offset = "0x69BB9E0", VA = "0x1869BCBE0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, double MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x69BCB20", Offset = "0x69BB920", VA = "0x1869BCB20", Slot = "7")]
	public double ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public CGCHEBAMPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class AKLCPOFAOIL : EOBPAHIDCCA<double?>, AEBJIPJMENI, ECOHJEPCDGP<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly AKLCPOFAOIL DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x69B9D00", Offset = "0x69B8B00", VA = "0x1869B9D00", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, double? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x69B9C40", Offset = "0x69B8A40", VA = "0x1869B9C40", Slot = "5")]
	public double? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x69B9F00", Offset = "0x69B8D00", VA = "0x1869B9F00", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, double? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x69B9DC0", Offset = "0x69B8BC0", VA = "0x1869B9DC0", Slot = "7")]
	public double? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public AKLCPOFAOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class FGJJKGPDBHD : EOBPAHIDCCA<double[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly FGJJKGPDBHD DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x69BFB20", Offset = "0x69BE920", VA = "0x1869BFB20", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, double[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x69BF990", Offset = "0x69BE790", VA = "0x1869BF990", Slot = "5")]
	public double[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public FGJJKGPDBHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class ABOHGIDAMFD : EOBPAHIDCCA<bool>, AEBJIPJMENI, ECOHJEPCDGP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly ABOHGIDAMFD DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x69B8FB0", Offset = "0x69B7DB0", VA = "0x1869B8FB0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, bool MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x69B8F60", Offset = "0x69B7D60", VA = "0x1869B8F60", Slot = "5")]
	public bool APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x69B90D0", Offset = "0x69B7ED0", VA = "0x1869B90D0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, bool MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x69B9010", Offset = "0x69B7E10", VA = "0x1869B9010", Slot = "7")]
	public bool ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public ABOHGIDAMFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class OFHFKKAEMCL : EOBPAHIDCCA<bool?>, AEBJIPJMENI, ECOHJEPCDGP<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly OFHFKKAEMCL DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x69C8DD0", Offset = "0x69C7BD0", VA = "0x1869C8DD0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, bool? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x69C8D20", Offset = "0x69C7B20", VA = "0x1869C8D20", Slot = "5")]
	public bool? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x69C8FB0", Offset = "0x69C7DB0", VA = "0x1869C8FB0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, bool? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x69C8E90", Offset = "0x69C7C90", VA = "0x1869C8E90", Slot = "7")]
	public bool? ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public OFHFKKAEMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class HJMPNBPMHFL : EOBPAHIDCCA<bool[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly HJMPNBPMHFL DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x69C2FF0", Offset = "0x69C1DF0", VA = "0x1869C2FF0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, bool[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x69C2E60", Offset = "0x69C1C60", VA = "0x1869C2E60", Slot = "5")]
	public bool[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HJMPNBPMHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class FHJJPCJFCFA : EOBPAHIDCCA<object>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly EOBPAHIDCCA<object> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> MJICCCDLHOL;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x69C0120", Offset = "0x69BEF20", VA = "0x1869C0120", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, object MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x69BFCE0", Offset = "0x69BEAE0", VA = "0x1869BFCE0", Slot = "5")]
	public object APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public FHJJPCJFCFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class MABLIMNBAMF : EOBPAHIDCCA<byte[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly EOBPAHIDCCA<byte[]> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x69C6ED0", Offset = "0x69C5CD0", VA = "0x1869C6ED0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, byte[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x69C6E20", Offset = "0x69C5C20", VA = "0x1869C6E20", Slot = "5")]
	public byte[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MABLIMNBAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class FKCCBCHLCLN : EOBPAHIDCCA<ArraySegment<byte>>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly EOBPAHIDCCA<ArraySegment<byte>> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x69C1750", Offset = "0x69C0550", VA = "0x1869C1750", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, ArraySegment<byte> MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x69C1640", Offset = "0x69C0440", VA = "0x1869C1640", Slot = "5")]
	public ArraySegment<byte> APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public FKCCBCHLCLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class DOEDFNLHPJG : EOBPAHIDCCA<string>, AEBJIPJMENI, ECOHJEPCDGP<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly EOBPAHIDCCA<string> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x69BD2C0", Offset = "0x69BC0C0", VA = "0x1869BD2C0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, string MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x69BD270", Offset = "0x69BC070", VA = "0x1869BD270", Slot = "5")]
	public string APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x69BD370", Offset = "0x69BC170", VA = "0x1869BD370", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, string MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x69BD320", Offset = "0x69BC120", VA = "0x1869BD320", Slot = "7")]
	public string ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public DOEDFNLHPJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class PBKLOIKPLMK : EOBPAHIDCCA<string[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly PBKLOIKPLMK DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x69C99E0", Offset = "0x69C87E0", VA = "0x1869C99E0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, string[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x69C9810", Offset = "0x69C8610", VA = "0x1869C9810", Slot = "5")]
	public string[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PBKLOIKPLMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class LNOFMNFFOHB : EOBPAHIDCCA<char>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LNOFMNFFOHB DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x69C6A40", Offset = "0x69C5840", VA = "0x1869C6A40", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, char MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x69C69D0", Offset = "0x69C57D0", VA = "0x1869C69D0", Slot = "5")]
	public char APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public LNOFMNFFOHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class LOENGNCCICO : EOBPAHIDCCA<char?>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly LOENGNCCICO DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x69C6CA0", Offset = "0x69C5AA0", VA = "0x1869C6CA0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, char? MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x69C6B80", Offset = "0x69C5980", VA = "0x1869C6B80", Slot = "5")]
	public char? APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public LOENGNCCICO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class JGIMOPEBDKH : EOBPAHIDCCA<char[]>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly JGIMOPEBDKH DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x69C5FA0", Offset = "0x69C4DA0", VA = "0x1869C5FA0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, char[] MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x69C5DE0", Offset = "0x69C4BE0", VA = "0x1869C5DE0", Slot = "5")]
	public char[] APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public JGIMOPEBDKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class EMMJBMBDFLL : EOBPAHIDCCA<Guid>, AEBJIPJMENI, ECOHJEPCDGP<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly EOBPAHIDCCA<Guid> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x69BF600", Offset = "0x69BE400", VA = "0x1869BF600", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, Guid MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x69BF570", Offset = "0x69BE370", VA = "0x1869BF570", Slot = "5")]
	public Guid APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x69BF7D0", Offset = "0x69BE5D0", VA = "0x1869BF7D0", Slot = "6")]
	public void GPAGCOACMNN(MFNBEJGCMIB FCAJMDOFLNK, Guid MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x69BF730", Offset = "0x69BE530", VA = "0x1869BF730", Slot = "7")]
	public Guid ECIDDNJFDKC(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EMMJBMBDFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class DPMPBIAPLOK : EOBPAHIDCCA<decimal>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly EOBPAHIDCCA<decimal> DKIJAJPJIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool KMOBLIJPMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x524D830", Offset = "0x524C630", VA = "0x18524D830")]
	public DPMPBIAPLOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x17C8E20", Offset = "0x17C7C20", VA = "0x1817C8E20")]
	public DPMPBIAPLOK(bool KMOBLIJPMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x69BD6F0", Offset = "0x69BC4F0", VA = "0x1869BD6F0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, decimal MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x69BD450", Offset = "0x69BC250", VA = "0x1869BD450", Slot = "5")]
	public decimal APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GGPDDHJDBBF : EOBPAHIDCCA<Uri>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly EOBPAHIDCCA<Uri> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x69C2520", Offset = "0x69C1320", VA = "0x1869C2520", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, Uri MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x69C2460", Offset = "0x69C1260", VA = "0x1869C2460", Slot = "5")]
	public Uri APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public GGPDDHJDBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class PKBMOMFNABP : EOBPAHIDCCA<Version>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly EOBPAHIDCCA<Version> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x69C9C50", Offset = "0x69C8A50", VA = "0x1869C9C50", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, Version MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x69C9B90", Offset = "0x69C8990", VA = "0x1869C9B90", Slot = "5")]
	public Version APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PKBMOMFNABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class KODLOGKDBNM<TKey, TValue> : EOBPAHIDCCA<KeyValuePair<TKey, TValue>>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F0E0", Offset = "0x3B2DEE0", VA = "0x183B2F0E0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, KeyValuePair<TKey, TValue> MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EDB0", Offset = "0x3B2DBB0", VA = "0x183B2EDB0", Slot = "5")]
	public KeyValuePair<TKey, TValue> APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MEJNDIOGGFK : EOBPAHIDCCA<StringBuilder>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly EOBPAHIDCCA<StringBuilder> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x69C70D0", Offset = "0x69C5ED0", VA = "0x1869C70D0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, StringBuilder MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x69C7010", Offset = "0x69C5E10", VA = "0x1869C7010", Slot = "5")]
	public StringBuilder APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MEJNDIOGGFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class GPCOPENIHIE : EOBPAHIDCCA<BitArray>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly EOBPAHIDCCA<BitArray> DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x69C2A60", Offset = "0x69C1860", VA = "0x1869C2A60", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, BitArray MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x69C28E0", Offset = "0x69C16E0", VA = "0x1869C28E0", Slot = "5")]
	public BitArray APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public GPCOPENIHIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class AELLCJIPDPJ : EOBPAHIDCCA<Type>, AEBJIPJMENI
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly AELLCJIPDPJ DKIJAJPJIFN;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex GEEHMCBPBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool LBIMLHLCOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool GENCJJPOLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool ILOHPOGFDOL;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x69B98E0", Offset = "0x69B86E0", VA = "0x1869B98E0")]
	public AELLCJIPDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9140", Offset = "0x5FE7F40", VA = "0x185FE9140")]
	public AELLCJIPDPJ(bool LBIMLHLCOPM, bool GENCJJPOLHK, bool ILOHPOGFDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x69B96E0", Offset = "0x69B84E0", VA = "0x1869B96E0", Slot = "4")]
	public void CDDFPMJNNJO(MFNBEJGCMIB FCAJMDOFLNK, Type MAEBFBHFPDE, LNCEEOCCIFN IOOENPNIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x69B9590", Offset = "0x69B8390", VA = "0x1869B9590", Slot = "5")]
	public Type APHAODHFANA(BJOFEHNPFPA INLIFCPEGKK, LNCEEOCCIFN IOOENPNIHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class IODIHDIEPNB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] IGMHIKFEPBD;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly GKNNDMOEKKM CMBPADIMGEG;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x69C4B30", Offset = "0x69C3930", VA = "0x1869C4B30")]
	static IODIHDIEPNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class FJHGLCHPPCP
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] HBNNEBCIAMA;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly GKNNDMOEKKM FFGJHAOGILC;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x69C1430", Offset = "0x69C0230", VA = "0x1869C1430")]
	static FJHGLCHPPCP()
	{
	}
}
namespace Cpp2IlInjected;

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
