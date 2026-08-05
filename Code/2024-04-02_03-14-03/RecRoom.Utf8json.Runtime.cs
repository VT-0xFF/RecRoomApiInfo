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
internal static class ECIOGGGDLED
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C070", Offset = "0x6A1AC70", VA = "0x186A1C070")]
	public static bool FFJPKGELKPP(this TypeInfo CJEAJMFMNNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class NDDLNFEAHPD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type CNFOHOCCKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] JNIOHKJMIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
	public NDDLNFEAHPD(Type BFMLBCGNCOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class KEGLACMIOHI : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FMHEOADFBDD<T>(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T EMGNFONBPHF<T>(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE PFFKNCCHDEK);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ICLENGPGIEJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IINNILDHPHN<T> : ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JGIIGIFKJHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DKBHHFMJBBE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NCIPFCJBBBK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x29083C0", Offset = "0x2906FC0", VA = "0x1829083C0")]
	public static string AJNKIJNMFLN<T>(this IINNILDHPHN<T> CLHMIANGJIG, T BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IINNILDHPHN<T> EJBKFPEHMEF<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JOIAPLDALIL
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x283EE00", Offset = "0x283DA00", VA = "0x18283EE00")]
	public static IINNILDHPHN<T> IIGHOKDKEBA<T>(this AODINAOIEAE PFFKNCCHDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A24440", Offset = "0x6A23040", VA = "0x186A24440")]
	public static object CHIKPOPHCFO(this AODINAOIEAE PFFKNCCHDEK, Type CJEAJMFMNNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HOKMIOHMFLG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A22A30", Offset = "0x6A21630", VA = "0x186A22A30")]
	public HOKMIOHMFLG(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FJGBFMJLMMP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class JJHHPNBLDIH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] KLIMJJKAHFF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] JMFACJPNOFJ;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A24230", Offset = "0x6A22E30", VA = "0x186A24230")]
		public static byte[] EPFMOFBHLED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A24190", Offset = "0x6A22D90", VA = "0x186A24190")]
		public static char[] DHLANLJBCOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> PAKKKIPNIJF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] DPJBAEMIDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] PJGIELDOKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int OIAPMOHIBDO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool OGLBNPKBMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A1F440", Offset = "0x6A1E040", VA = "0x186A1F440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A20400", Offset = "0x6A1F000", VA = "0x186A20400")]
	public FJGBFMJLMMP(byte[] PJGIELDOKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A20460", Offset = "0x6A1F060", VA = "0x186A20460")]
	public FJGBFMJLMMP(byte[] PJGIELDOKCN, int OIAPMOHIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D650", Offset = "0x6A1C250", VA = "0x186A1D650")]
	private NKHDFODKEFI CANNDOGKKIM(string MHNBGMEGFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A1ED40", Offset = "0x6A1D940", VA = "0x186A1ED40")]
	private NKHDFODKEFI LIJKDCBKDOD(string COECLHOAJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A122F0", Offset = "0x6A10EF0", VA = "0x186A122F0")]
	public void ADJJHOIEDJH(int OIAPMOHIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0")]
	public byte[] OPABALFJADG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90")]
	public int BIPFIPAJBBI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EFA0", Offset = "0x6A1DBA0", VA = "0x186A1EFA0")]
	public JGFIGLPPAOF LOBEEPCGPJG()
	{
		return default(JGFIGLPPAOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D380", Offset = "0x6A1BF80", VA = "0x186A1D380")]
	public void BBNILGJNHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D130", Offset = "0x6A1BD30", VA = "0x186A1D130")]
	public bool AFOKMKNKKMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EA90", Offset = "0x6A1D690", VA = "0x186A1EA90")]
	public bool KNKAIGPCHIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F220", Offset = "0x6A1DE20", VA = "0x186A1F220")]
	public void MAEPBCEMKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EE30", Offset = "0x6A1DA30", VA = "0x186A1EE30")]
	public bool LKEHDNNFCEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F460", Offset = "0x6A1E060", VA = "0x186A1F460")]
	public bool NFDAFFMDCAG(int MAJIECOCCAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F150", Offset = "0x6A1DD50", VA = "0x186A1F150")]
	public bool LOBLCFICLLG(int MAJIECOCCAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EA00", Offset = "0x6A1D600", VA = "0x186A1EA00")]
	public bool KEPMBCGPHEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E2B0", Offset = "0x6A1CEB0", VA = "0x186A1E2B0")]
	public void HAMFMJLGNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FF90", Offset = "0x6A1EB90", VA = "0x186A1FF90")]
	public bool OJMCAADPNPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DCA0", Offset = "0x6A1C8A0", VA = "0x186A1DCA0")]
	public bool DJADKCEKJGA(int MAJIECOCCAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E4B0", Offset = "0x6A1D0B0", VA = "0x186A1E4B0")]
	public bool HNIGCCPLDMF(int MAJIECOCCAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D5C0", Offset = "0x6A1C1C0", VA = "0x186A1D5C0")]
	public bool BLHKCMGPJEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A20020", Offset = "0x6A1EC20", VA = "0x186A20020")]
	public void PBPEHHOFJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D530", Offset = "0x6A1C130", VA = "0x186A1D530")]
	public bool BLEMODDAOGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F2C0", Offset = "0x6A1DEC0", VA = "0x186A1F2C0")]
	public void MIMLJLDNFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F7F0", Offset = "0x6A1E3F0", VA = "0x186A1F7F0")]
	private void OGKPOMODJFM([Out] byte[] MCLFDHIDHAI, [Out] int MNFEEENGEDK, [Out] int PMMPIMLPNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E180", Offset = "0x6A1CD80", VA = "0x186A1E180")]
	private static int GHAHGKADLOO(char PKCAMDKHNLN, char ECIMPLOCMKE, char IELECLNDABB, char MDPDLOKKCJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EEC0", Offset = "0x6A1DAC0", VA = "0x186A1EEC0")]
	private static int LLFAMLGMPAN(char KLNIMOGOBLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EC20", Offset = "0x6A1D820", VA = "0x186A1EC20")]
	public ArraySegment<byte> LANCIBHLLLJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F360", Offset = "0x6A1DF60", VA = "0x186A1F360")]
	public string MMOGIBLEOFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F530", Offset = "0x6A1E130", VA = "0x186A1F530")]
	public string NFEPKKLDNGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A200C0", Offset = "0x6A1ECC0", VA = "0x186A200C0")]
	public ArraySegment<byte> PDOFCJCIBOH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D310", Offset = "0x6A1BF10", VA = "0x186A1D310")]
	public ArraySegment<byte> APPPDALCGIG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F5A0", Offset = "0x6A1E1A0", VA = "0x186A1F5A0")]
	public bool OGJMAAFIJKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D250", Offset = "0x6A1BE50", VA = "0x186A1D250")]
	private static bool AIFHGAIMLJP(byte IELECLNDABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DD70", Offset = "0x6A1C970", VA = "0x186A1DD70")]
	private void DOBCBIOAAPP(JGFIGLPPAOF DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DFC0", Offset = "0x6A1CBC0", VA = "0x186A1DFC0")]
	public void DPDPLDAJNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E350", Offset = "0x6A1CF50", VA = "0x186A1E350")]
	private void HCCDPAMDJPL(int FOAIPNAGLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D4B0", Offset = "0x6A1C0B0", VA = "0x186A1D4B0")]
	public sbyte BIEENKIEGNP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DC20", Offset = "0x6A1C820", VA = "0x186A1DC20")]
	public short DEMIPLPLJAO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DBA0", Offset = "0x6A1C7A0", VA = "0x186A1DBA0")]
	public int CFLBPPKPIPD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E7C0", Offset = "0x6A1D3C0", VA = "0x186A1E7C0")]
	public long IKMEMPJOCON()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E680", Offset = "0x6A1D280", VA = "0x186A1E680")]
	public byte IDIPHPGACPI()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E230", Offset = "0x6A1CE30", VA = "0x186A1E230")]
	public ushort GJLDGGGCHKN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E880", Offset = "0x6A1D480", VA = "0x186A1E880")]
	public uint IPNAFENBIIM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E700", Offset = "0x6A1D300", VA = "0x186A1E700")]
	public ulong IKLPOLDCDHB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EB20", Offset = "0x6A1D720", VA = "0x186A1EB20")]
	public float LAMKCOPMBLM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E580", Offset = "0x6A1D180", VA = "0x186A1E580")]
	public double IBMILHLDOHO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E900", Offset = "0x6A1D500", VA = "0x186A1E900")]
	public ArraySegment<byte> KBCNEJJEENF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E010", Offset = "0x6A1CC10", VA = "0x186A1E010")]
	private static int GAKPDJKMMMM(byte[] PJGIELDOKCN, int OIAPMOHIBDO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NKHDFODKEFI : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference HFGJHODHOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int NPFBMNKKOAK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int BOBKHJLAPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC6AC70", Offset = "0xC69870", VA = "0x180C6AC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DIFGMIAKJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x878450", Offset = "0x877050", VA = "0x180878450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A25C30", Offset = "0x6A24830", VA = "0x186A25C30")]
	public NKHDFODKEFI(string COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A25B40", Offset = "0x6A24740", VA = "0x186A25B40")]
	public NKHDFODKEFI(string COECLHOAJJF, byte[] KFNFIEPJIMF, int OIAPMOHIBDO, int NPFBMNKKOAK, string ALHHLEEHOJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IAPNOFNKAJN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class KHODGIHFLDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] KLIMJJKAHFF;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A24B90", Offset = "0x6A23790", VA = "0x186A24B90")]
		public static byte[] EPFMOFBHLED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class NBBNHNBOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void MABMHHBGIFJ(CIGBOBFPDPM EDIOJDLAEAK, object BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object EEOLFJAGIJP(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE PFFKNCCHDEK);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class CEKGGNCNIPD
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class ENFNMMCBHEG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
				public ENFNMMCBHEG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x380C250", Offset = "0x380AE50", VA = "0x18380C250")]
				internal bool FLDAFBIDBLG(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6A1CC60", Offset = "0x6A1B860", VA = "0x186A1CC60")]
				internal bool EJEBJDFMFKH(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, AODINAOIEAE, byte[]> HEIOPHMAMMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, AODINAOIEAE> LEFMHHKOEHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly MABMHHBGIFJ EENJNAPNLCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, AODINAOIEAE, ArraySegment<byte>> APMDGAAEJFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, AODINAOIEAE, string> OLGINFAPKBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, AODINAOIEAE, object> FBDDNHKLIIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, AODINAOIEAE, object> ACPBAHBLFOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, AODINAOIEAE, object> CACGJECBBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly EEOLFJAGIJP BENMPLDPMEJ;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6A105D0", Offset = "0x6A0F1D0", VA = "0x186A105D0")]
			public CEKGGNCNIPD(Type CJEAJMFMNNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2D72CA0", Offset = "0x2D718A0", VA = "0x182D72CA0")]
			private static T NMOFAIBGNIB<T>(DynamicMethod KGMCMIFBFPB)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6A10380", Offset = "0x6A0EF80", VA = "0x186A10380")]
			private static MethodInfo LKOCBOFGDBB(Type CJEAJMFMNNJ, string MPGNMPAPHDB, Type[] NNBDPNDONEN)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, CEKGGNCNIPD> DEAMEMODONL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly IDAILIKOBPP<CEKGGNCNIPD> HHDBDHMPPKP;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A259F0", Offset = "0x6A245F0", VA = "0x186A259F0")]
		static NBBNHNBOEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A256E0", Offset = "0x6A242E0", VA = "0x186A256E0")]
		private static CEKGGNCNIPD EJMKGPJAODM(Type CJEAJMFMNNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A25760", Offset = "0x6A24360", VA = "0x186A25760")]
		public static void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, object BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A258E0", Offset = "0x6A244E0", VA = "0x186A258E0")]
		public static void GAPNIKJAJOO(Type CJEAJMFMNNJ, CIGBOBFPDPM EDIOJDLAEAK, object BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static AODINAOIEAE BCMCKLMNINB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] ANKJFPOJHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] FAOLOGHPOMP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static AODINAOIEAE OKGLNEPPMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A22A90", Offset = "0x6A21690", VA = "0x186A22A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OANKOMELEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A234B0", Offset = "0x6A220B0", VA = "0x186A234B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A22B90", Offset = "0x6A21790", VA = "0x186A22B90")]
	public static void DGMIMFHIEMG(AODINAOIEAE PFFKNCCHDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2801F90", Offset = "0x2800B90", VA = "0x182801F90")]
	public static byte[] GAPNIKJAJOO<T>(T OGGNGHKHHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2802010", Offset = "0x2800C10", VA = "0x182802010")]
	public static byte[] GAPNIKJAJOO<T>(T BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2802200", Offset = "0x2800E00", VA = "0x182802200")]
	public static void GAPNIKJAJOO<T>(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2802550", Offset = "0x2801150", VA = "0x182802550")]
	public static void GAPNIKJAJOO<T>(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2802630", Offset = "0x2801230", VA = "0x182802630")]
	public static void GAPNIKJAJOO<T>(Stream LHFBIKKBMMG, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2802290", Offset = "0x2800E90", VA = "0x182802290")]
	public static void GAPNIKJAJOO<T>(Stream LHFBIKKBMMG, T BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2801D70", Offset = "0x2800970", VA = "0x182801D70")]
	public static ArraySegment<byte> EFIJKOICGJB<T>(T OGGNGHKHHGI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2801E00", Offset = "0x2800A00", VA = "0x182801E00")]
	public static ArraySegment<byte> EFIJKOICGJB<T>(T BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2800830", Offset = "0x27FF430", VA = "0x182800830")]
	public static string AJNKIJNMFLN<T>(T BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x28006B0", Offset = "0x27FF2B0", VA = "0x1828006B0")]
	public static string AJNKIJNMFLN<T>(T BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2801580", Offset = "0x2800180", VA = "0x182801580")]
	public static T DPCADENMEMJ<T>(string LJAIEPDANGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2801490", Offset = "0x2800090", VA = "0x182801490")]
	public static T DPCADENMEMJ<T>(string LJAIEPDANGA, AODINAOIEAE PFFKNCCHDEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2801910", Offset = "0x2800510", VA = "0x182801910")]
	public static T DPCADENMEMJ<T>(byte[] PJGIELDOKCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2801400", Offset = "0x2800000", VA = "0x182801400")]
	public static T DPCADENMEMJ<T>(byte[] PJGIELDOKCN, AODINAOIEAE PFFKNCCHDEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2801610", Offset = "0x2800210", VA = "0x182801610")]
	public static T DPCADENMEMJ<T>(byte[] PJGIELDOKCN, int OIAPMOHIBDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2801270", Offset = "0x27FFE70", VA = "0x182801270")]
	public static T DPCADENMEMJ<T>(byte[] PJGIELDOKCN, int OIAPMOHIBDO, AODINAOIEAE PFFKNCCHDEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2801720", Offset = "0x2800320", VA = "0x182801720")]
	public static T DPCADENMEMJ<T>(FJGBFMJLMMP ALHICDKDPIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2801BA0", Offset = "0x28007A0", VA = "0x182801BA0")]
	public static T DPCADENMEMJ<T>(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE PFFKNCCHDEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28016A0", Offset = "0x28002A0", VA = "0x1828016A0")]
	public static T DPCADENMEMJ<T>(Stream LHFBIKKBMMG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2801A60", Offset = "0x2800660", VA = "0x182801A60")]
	public static T DPCADENMEMJ<T>(Stream LHFBIKKBMMG, AODINAOIEAE PFFKNCCHDEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A22C00", Offset = "0x6A21800", VA = "0x186A22C00")]
	public static string HDOOEEEIJCP(byte[] LJAIEPDANGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A22EF0", Offset = "0x6A21AF0", VA = "0x186A22EF0")]
	public static string HDOOEEEIJCP(byte[] LJAIEPDANGA, int OIAPMOHIBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A22D60", Offset = "0x6A21960", VA = "0x186A22D60")]
	public static string HDOOEEEIJCP(string LJAIEPDANGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A23330", Offset = "0x6A21F30", VA = "0x186A23330")]
	public static byte[] HJEHCGMMCAJ(byte[] LJAIEPDANGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A23030", Offset = "0x6A21C30", VA = "0x186A23030")]
	public static byte[] HJEHCGMMCAJ(byte[] LJAIEPDANGA, int OIAPMOHIBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A23180", Offset = "0x6A21D80", VA = "0x186A23180")]
	public static byte[] HJEHCGMMCAJ(string LJAIEPDANGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A23510", Offset = "0x6A22110", VA = "0x186A23510")]
	private static void KMLHOIPCPKD(FJGBFMJLMMP ALHICDKDPIA, CIGBOBFPDPM EDIOJDLAEAK, int EIGGDODJGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A23DE0", Offset = "0x6A229E0", VA = "0x186A23DE0")]
	private static int OBDCBAJJBLE(Stream KMJAEAGEOPB, byte[] KLIMJJKAHFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum JGFIGLPPAOF : byte
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
public struct CIGBOBFPDPM
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] OJJDAGJBHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] KLIMJJKAHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int OIAPMOHIBDO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NDAOBDPCLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A122F0", Offset = "0x6A10EF0", VA = "0x186A122F0")]
	public void ADJJHOIEDJH(int OIAPMOHIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A124A0", Offset = "0x6A110A0", VA = "0x186A124A0")]
	public static byte[] DHECOMDPIIF(string CBBGNCDFNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A12780", Offset = "0x6A11380", VA = "0x186A12780")]
	public static byte[] FBIOBHOKEDC(string CBBGNCDFNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A13330", Offset = "0x6A11F30", VA = "0x186A13330")]
	public static byte[] PAOAOLHHBNH(string CBBGNCDFNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A129C0", Offset = "0x6A115C0", VA = "0x186A129C0")]
	public static byte[] HBGLAFFFPNG(string CBBGNCDFNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5601C40", Offset = "0x5600840", VA = "0x185601C40")]
	public CIGBOBFPDPM(byte[] EGBGJLMIFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A126E0", Offset = "0x6A112E0", VA = "0x186A126E0")]
	public ArraySegment<byte> EPFMOFBHLED()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A12CA0", Offset = "0x6A118A0", VA = "0x186A12CA0")]
	public byte[] KBHPNPOHNLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A134F0", Offset = "0x6A120F0", VA = "0x186A134F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A12940", Offset = "0x6A11540", VA = "0x186A12940")]
	public void FKJELFPJCGD(int CCCLGPCIGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A12230", Offset = "0x6A10E30", VA = "0x186A12230")]
	public void ACNDFGLCLHI(byte HKBKKBEIAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A12290", Offset = "0x6A10E90", VA = "0x186A12290")]
	public void ACNDFGLCLHI(byte[] HKBKKBEIAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A12460", Offset = "0x6A11060", VA = "0x186A12460")]
	public void CKBKIPOGMLO(byte HKBKKBEIAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A125D0", Offset = "0x6A111D0", VA = "0x186A125D0")]
	public void DHFIOGFKJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A12C50", Offset = "0x6A11850", VA = "0x186A12C50")]
	public void JPPJOBAGMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A128F0", Offset = "0x6A114F0", VA = "0x186A128F0")]
	public void FBMJOHJLAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A12620", Offset = "0x6A11220", VA = "0x186A12620")]
	public void EFJAPDNDPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A13240", Offset = "0x6A11E40", VA = "0x186A13240")]
	public void NDBNJJMOOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A134A0", Offset = "0x6A120A0", VA = "0x186A134A0")]
	public void PKDHGBEMICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A12BB0", Offset = "0x6A117B0", VA = "0x186A12BB0")]
	public void IFOCJCDKNGJ(string CBBGNCDFNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6A131F0", Offset = "0x6A11DF0", VA = "0x186A131F0")]
	public void NAIKGNHMDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6A130A0", Offset = "0x6A11CA0", VA = "0x186A130A0")]
	public void LLAKLOKPCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A120D0", Offset = "0x6A10CD0", VA = "0x186A120D0")]
	public void AACKPEFGHEH(bool BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A123E0", Offset = "0x6A10FE0", VA = "0x186A123E0")]
	public void CFLFLCDMIGD(float BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A13170", Offset = "0x6A11D70", VA = "0x186A13170")]
	public void MFDGKAMHNAN(double BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A12B40", Offset = "0x6A11740", VA = "0x186A12B40")]
	public void HDGGKEMDIPL(byte BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A12670", Offset = "0x6A11270", VA = "0x186A12670")]
	public void EHIKFPFDMBO(ushort BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A132C0", Offset = "0x6A11EC0", VA = "0x186A132C0")]
	public void OGFOBMOMIEI(uint BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A13290", Offset = "0x6A11E90", VA = "0x186A13290")]
	public void NJNCCDKJMOF(ulong BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A12370", Offset = "0x6A10F70", VA = "0x186A12370")]
	public void AHEDGPEKKEG(sbyte BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A12950", Offset = "0x6A11550", VA = "0x186A12950")]
	public void FLPPMHDOLJK(short BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A12300", Offset = "0x6A10F00", VA = "0x186A12300")]
	public void AGCJLNMFHHM(int BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A13140", Offset = "0x6A11D40", VA = "0x186A13140")]
	public void MEPIHLLGFNN(long BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A12D10", Offset = "0x6A11910", VA = "0x186A12D10")]
	public void KKPJLMMMLHD(string BLKAHBIJBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class GPIHLMJHOHC : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class IOJAOGGIGFN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x395C9B0", Offset = "0x395B5B0", VA = "0x18395C9B0")]
		static IOJAOGGIGFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private GPIHLMJHOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class OOMFIIEDOCE : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class IAGNLMNBJBM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3925890", Offset = "0x3924490", VA = "0x183925890")]
		static IAGNLMNBJBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class HMPPPCGJPCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> MIIDPPPMHNE;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A20C00", Offset = "0x6A1F800", VA = "0x186A20C00")]
		internal static object EJBKFPEHMEF(Type JIGADAOLAJF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private OOMFIIEDOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KAGEAIHBCGL : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class OLDELIFOAMI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4033790", Offset = "0x4032390", VA = "0x184033790")]
		static OLDELIFOAMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly KAGEAIHBCGL EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool NJAGCJLNDCD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static ICLENGPGIEJ[] ODAAHEDCJKH;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static AODINAOIEAE[] LAPIKHEMFFD;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private KAGEAIHBCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A245A0", Offset = "0x6A231A0", VA = "0x186A245A0")]
	public static void FAEDNEGPAEK(params AODINAOIEAE[] LAPIKHEMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A24680", Offset = "0x6A23280", VA = "0x186A24680")]
	public static void FAEDNEGPAEK(params ICLENGPGIEJ[] ODAAHEDCJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A24760", Offset = "0x6A23360", VA = "0x186A24760")]
	public static void IGHOMHHOLHG(ICLENGPGIEJ[] ODAAHEDCJKH, AODINAOIEAE[] LAPIKHEMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FDBGKKJIEKE : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class BDEKCKAEHIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4766030", Offset = "0x4764C30", VA = "0x184766030")]
		static BDEKCKAEHIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private FDBGKKJIEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class BALLFCCMONK
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly AODINAOIEAE IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly AODINAOIEAE DPIPILBJIGG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly AODINAOIEAE GBJFEEOMNLH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly AODINAOIEAE PGAAMOIIEHB;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly AODINAOIEAE OGHODLILDGL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly AODINAOIEAE NPGNEFPDFKP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly AODINAOIEAE AIDNAEEJGBF;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly AODINAOIEAE GCBBKGCIJIO;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly AODINAOIEAE HLPIKNBFBLF;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly AODINAOIEAE CPPNCMMACFG;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly AODINAOIEAE JBKMDMEONHO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly AODINAOIEAE MKGKAIPAODI;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IDNHGGJFKCC
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly AODINAOIEAE IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly AODINAOIEAE FLGFNDPEJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DODCGEBEFDA
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly AODINAOIEAE IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly AODINAOIEAE DPIPILBJIGG;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly AODINAOIEAE GBJFEEOMNLH;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly AODINAOIEAE PGAAMOIIEHB;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly AODINAOIEAE OGHODLILDGL;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly AODINAOIEAE NPGNEFPDFKP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly AODINAOIEAE AIDNAEEJGBF;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly AODINAOIEAE GCBBKGCIJIO;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly AODINAOIEAE HLPIKNBFBLF;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly AODINAOIEAE CPPNCMMACFG;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly AODINAOIEAE JBKMDMEONHO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly AODINAOIEAE MKGKAIPAODI;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class OPOJKIJDPEL
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> MIIDPPPMHNE;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A28CE0", Offset = "0x6A278E0", VA = "0x186A28CE0")]
	internal static object EJBKFPEHMEF(Type JIGADAOLAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A440", Offset = "0x6A29040", VA = "0x186A2A440")]
	private static object LNDJMJHEABD(Type DPAIOFJDACM, Type[] PGIEPHCCGGG, params object[] NNBDPNDONEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class JLEHCOJKAIM : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class IECFACNBBMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x392F1E0", Offset = "0x392DDE0", VA = "0x18392F1E0")]
		static IECFACNBBMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly EIDHMDFIJAL AAONCLDMEDK;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A242D0", Offset = "0x6A22ED0", VA = "0x186A242D0")]
	static JLEHCOJKAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private JLEHCOJKAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class BPABMHBILHE : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class NHOAAFHLBIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD000", Offset = "0x3EFBC00", VA = "0x183EFD000")]
		static NHOAAFHLBIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly EIDHMDFIJAL AAONCLDMEDK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A10110", Offset = "0x6A0ED10", VA = "0x186A10110")]
	static BPABMHBILHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private BPABMHBILHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class FOALINKGFHP : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class LOAAHHPDEEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C42970", Offset = "0x3C41570", VA = "0x183C42970")]
		static LOAAHHPDEEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly EIDHMDFIJAL AAONCLDMEDK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A20890", Offset = "0x6A1F490", VA = "0x186A20890")]
	static FOALINKGFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private FOALINKGFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class CLJHMOBFIOA : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class DIEFJGENLNI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x50566C0", Offset = "0x50552C0", VA = "0x1850566C0")]
		static DIEFJGENLNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly EIDHMDFIJAL AAONCLDMEDK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A135C0", Offset = "0x6A121C0", VA = "0x186A135C0")]
	static CLJHMOBFIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private CLJHMOBFIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class FFGPLKBJCHF : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class JMDBKPOBJCE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3B10820", Offset = "0x3B0F420", VA = "0x183B10820")]
		static JMDBKPOBJCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly EIDHMDFIJAL AAONCLDMEDK;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A1CFC0", Offset = "0x6A1BBC0", VA = "0x186A1CFC0")]
	static FFGPLKBJCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private FFGPLKBJCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LCKEDLIPBEJ : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class HKEDDPCGHHB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x38730E0", Offset = "0x3871CE0", VA = "0x1838730E0")]
		static HKEDDPCGHHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly EIDHMDFIJAL AAONCLDMEDK;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A24C30", Offset = "0x6A23830", VA = "0x186A24C30")]
	static LCKEDLIPBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private LCKEDLIPBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class CBKNLPLPNHH : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class GJKIBPKEGHB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37A18F0", Offset = "0x37A04F0", VA = "0x1837A18F0")]
		static GJKIBPKEGHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public CBKNLPLPNHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class MFMDGJOGKJB : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class DHEEPAEIMOG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5050FC0", Offset = "0x504FBC0", VA = "0x185050FC0")]
		static DHEEPAEIMOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public MFMDGJOGKJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HFDNGEDHMFJ : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class BEGHAJEBGPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4775910", Offset = "0x4774510", VA = "0x184775910")]
		static BEGHAJEBGPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public HFDNGEDHMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class MEAFPAKPPCA : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class PGEHBFOHFGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x41041E0", Offset = "0x4102DE0", VA = "0x1841041E0")]
		static PGEHBFOHFGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public MEAFPAKPPCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class FKIEIGANELM : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class ANDADCEPJBM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x38E2D10", Offset = "0x38E1910", VA = "0x1838E2D10")]
		static ANDADCEPJBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FKIEIGANELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class MMALDFFFEEB : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class HINBKAOKKHD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x386E230", Offset = "0x386CE30", VA = "0x18386E230")]
		static HINBKAOKKHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> EGLBBPKIALE;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool LAMIBFEILDD;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public MMALDFFFEEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class DCLAHOAGKOG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct HHELKDDNEJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MCGLAIMJFCE NDGFOOBNPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder LGEBHCHLPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder HNOACBFKOHP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class ODFNGDJBAOG
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class OAHECDBMFCO
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo PAOAOLHHBNH;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo FBIOBHOKEDC;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo HBGLAFFFPNG;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo DHECOMDPIIF;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo LLAKLOKPCIP;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo ACNDFGLCLHI;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo FBMJOHJLAFP;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo EFJAPDNDPNE;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo NDBNJJMOOEB;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6A25C90", Offset = "0x6A24890", VA = "0x186A25C90")]
			static OAHECDBMFCO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class EFDPCDBCHEI
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo AFOKMKNKKMK;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo HAMFMJLGNCG;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo DJADKCEKJGA;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo LHGHMDOKGDK;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo DPDPLDAJNNK;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo OPABALFJADG;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo BIPFIPAJBBI;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6A1C0A0", Offset = "0x6A1ACA0", VA = "0x186A1C0A0")]
			static EFDPCDBCHEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class OGBJDBKPPFK
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo CNFOHOCCKDI;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo JNIOHKJMIDD;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo GDOELDIIADJ;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo IIGHOKDKEBA;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo EPFLCDHHKNO;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo EIEHBGOAHKK;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo DKDBFIGDCNF;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo DBMALCNDJCK;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo CDFKNENMGIH;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo DJNGJLOLJKL;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo OGIBHHEFFKP;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo JKAPOHLEMKD;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo PKPPBEFIEAI;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo NCPDLBACJNM;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A26C80", Offset = "0x6A25880", VA = "0x186A26C80")]
		public static MethodInfo GAPNIKJAJOO(Type CJEAJMFMNNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A26A40", Offset = "0x6A25640", VA = "0x186A26A40")]
		public static MethodInfo DPCADENMEMJ(Type CJEAJMFMNNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A26F10", Offset = "0x6A25B10", VA = "0x186A26F10")]
		public static MethodInfo JMCDPDINOGL(Type CJEAJMFMNNJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class NMIGNPAINOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<MCGLAIMJFCE, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public NMIGNPAINOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class BOAAJHCFBKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public NMIGNPAINOG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BOAAJHCFBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A100D0", Offset = "0x6A0ECD0", VA = "0x186A100D0")]
		internal void LDLOIPHBENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6A10030", Offset = "0x6A0EC30", VA = "0x186A10030")]
		internal bool JAFPJNIKBBF(int index, MCGLAIMJFCE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JDNDOKJJFAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public NMIGNPAINOG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JDNDOKJJFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A240F0", Offset = "0x6A22CF0", VA = "0x186A240F0")]
		internal bool DMDDFFEIKDC(int index, MCGLAIMJFCE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JKJAOHPOIML
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
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JKJAOHPOIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4105830", Offset = "0x4104430", VA = "0x184105830")]
		internal string AJMDNPCDBOF(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EAPOHOMOMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EAPOHOMOMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C010", Offset = "0x6A1AC10", VA = "0x186A1C010")]
		internal bool MBMMPEAMLHI(MCGLAIMJFCE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class MGKHBABDBHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public JKJAOHPOIML CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public MGKHBABDBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6A255D0", Offset = "0x6A241D0", VA = "0x186A255D0")]
		internal void LFHGKBFCCKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6A25450", Offset = "0x6A24050", VA = "0x186A25450")]
		internal bool EPFKCNDCJLH(int index, MCGLAIMJFCE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class PMFPBOCILPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public JKJAOHPOIML CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PMFPBOCILPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A9D0", Offset = "0x6A295D0", VA = "0x186A2A9D0")]
		internal bool AIJIBGDIGCH(int index, MCGLAIMJFCE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PPANDKLGCOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PPANDKLGCOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A2AB50", Offset = "0x6A29750", VA = "0x186A2AB50")]
		internal Label CPINFCPPKAH(MCGLAIMJFCE _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class FBFOJONNFMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public HHELKDDNEJH[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, MCGLAIMJFCE, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AMKOEDMMEDB argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AMKOEDMMEDB argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FBFOJONNFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CE20", Offset = "0x6A1BA20", VA = "0x186A1CE20")]
		internal HHELKDDNEJH FPDDICFMIFL(MCGLAIMJFCE item)
		{
			return default(HHELKDDNEJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MDBHLGPMPGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public FBFOJONNFMF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public MDBHLGPMPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6A24FC0", Offset = "0x6A23BC0", VA = "0x186A24FC0")]
		internal void INCNCCMEFFE(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A24F20", Offset = "0x6A23B20", VA = "0x186A24F20")]
		internal void DDLKCADJIOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HDFEALEPCMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public MCGLAIMJFCE item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HDFEALEPCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xBB3BD0", Offset = "0xBB27D0", VA = "0x180BB3BD0")]
		internal bool MFFBDHANBEH(HHELKDDNEJH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class LFILAHNFEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public MCGLAIMJFCE item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LFILAHNFEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xBB3BD0", Offset = "0xBB27D0", VA = "0x180BB3BD0")]
		internal bool LCMJHKOPBJA(HHELKDDNEJH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex BHDFNBMIPPP;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int MJJIJGGIPIC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> POCGKLJIMNN;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> HCCHPJFANCE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2649780", Offset = "0x2648380", VA = "0x182649780")]
	public static object KCPGHHCANJL<T>(EIDHMDFIJAL AAONCLDMEDK, AODINAOIEAE IJBCDAONAEK, Func<string, string> EGLBBPKIALE, bool LAMIBFEILDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2652790", Offset = "0x2651390", VA = "0x182652790")]
	public static object PHCCLPBNNCG<T>(AODINAOIEAE IJBCDAONAEK, Func<string, string> EGLBBPKIALE, bool LAMIBFEILDD, bool LLEBCHGMFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A13C70", Offset = "0x6A12870", VA = "0x186A13C70")]
	private static TypeInfo AICEPPEDLLH(EIDHMDFIJAL AAONCLDMEDK, Type CJEAJMFMNNJ, Func<string, string> EGLBBPKIALE, bool LAMIBFEILDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A14690", Offset = "0x6A13290", VA = "0x186A14690")]
	public static object CBPNOCALFGJ(Type CJEAJMFMNNJ, Func<string, string> EGLBBPKIALE, bool LAMIBFEILDD, bool LLEBCHGMFIK, bool PHIMKCGEMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A1ADE0", Offset = "0x6A199E0", VA = "0x186A1ADE0")]
	private static Dictionary<MCGLAIMJFCE, FieldInfo> PMDGJKEIAMD(TypeBuilder BPDJFKCGECB, OLKBFPPMAAH KIGGBMJEDEA, ConstructorInfo PLOLOAPJJIC, FieldBuilder EJAPHGEAHCO, ILGenerator DKKLHEGEHOH, bool LAMIBFEILDD, bool OMOBPGJOCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A161C0", Offset = "0x6A14DC0", VA = "0x186A161C0")]
	private static Dictionary<MCGLAIMJFCE, FieldInfo> EPCJAHJIEGE(TypeBuilder BPDJFKCGECB, OLKBFPPMAAH KIGGBMJEDEA, ILGenerator DKKLHEGEHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A168A0", Offset = "0x6A154A0", VA = "0x186A168A0")]
	private static void FLNPFMDHAIK(Type CJEAJMFMNNJ, OLKBFPPMAAH KIGGBMJEDEA, ILGenerator DKKLHEGEHOH, Action JBKMAECJMNN, Func<int, MCGLAIMJFCE, bool> MFMJAMHHPPO, bool LAMIBFEILDD, bool OMOBPGJOCFD, int FPHLKLHCKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A13730", Offset = "0x6A12330", VA = "0x186A13730")]
	private static void AHJPGEKCOJD(TypeInfo CJEAJMFMNNJ, MCGLAIMJFCE BIPBOANNKEP, ILGenerator DKKLHEGEHOH, int PMIDLPOCCEE, Func<int, MCGLAIMJFCE, bool> MFMJAMHHPPO, AMKOEDMMEDB EDIOJDLAEAK, AMKOEDMMEDB AKCMCLFMEKM, AMKOEDMMEDB CPGJHAIEHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A185C0", Offset = "0x6A171C0", VA = "0x186A185C0")]
	private static void JDMALKJJJHA(Type CJEAJMFMNNJ, OLKBFPPMAAH KIGGBMJEDEA, ILGenerator DKKLHEGEHOH, Func<int, MCGLAIMJFCE, bool> MFMJAMHHPPO, bool BOBNHECMNGN, int FPHLKLHCKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A970", Offset = "0x6A19570", VA = "0x186A1A970")]
	private static void PIBBFKKGHLL(ILGenerator DKKLHEGEHOH, HHELKDDNEJH KIGGBMJEDEA, int PMIDLPOCCEE, Func<int, MCGLAIMJFCE, bool> MFMJAMHHPPO, AMKOEDMMEDB ALHICDKDPIA, AMKOEDMMEDB CPGJHAIEHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A19A60", Offset = "0x6A18660", VA = "0x186A19A60")]
	private static LocalBuilder LBFEMCJEIJB(ILGenerator DKKLHEGEHOH, Type CJEAJMFMNNJ, OLKBFPPMAAH KIGGBMJEDEA, HHELKDDNEJH[] CLMPAGENCGP, bool CDEHNDGDAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A17EE0", Offset = "0x6A16AE0", VA = "0x186A17EE0")]
	private static bool IOJGPLFDMMJ(ConstructorInfo ELHENBLDBBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A7F0", Offset = "0x6A193F0", VA = "0x186A1A7F0")]
	private static bool NPGPMEHEBCE(Type CJEAJMFMNNJ, [Out] Type MGEFPGOFJMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void DBKEPCMMIED<T>(byte[][] EJAPHGEAHCO, object[] FAFGAEEFINJ, CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE PFFKNCCHDEK);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T IEDOAJHGGKP<T>(object[] FAFGAEEFINJ, FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE PFFKNCCHDEK);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class JEOPPOPLFCO<T> : IINNILDHPHN<T>, ICLENGPGIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] EJAPHGEAHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] PGBFMPILIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] BKNCKLBFHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly DBKEPCMMIED<T> GILCHNKABKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly IEDOAJHGGKP<T> BLLPIFKPDKN;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8F20", Offset = "0x1DD7B20", VA = "0x181DD8F20")]
	public JEOPPOPLFCO(byte[][] EJAPHGEAHCO, object[] PGBFMPILIEA, object[] BKNCKLBFHOE, DBKEPCMMIED<T> GILCHNKABKE, IEDOAJHGGKP<T> BLLPIFKPDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5690", Offset = "0x3AF4290", VA = "0x183AF5690", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3AF55A0", Offset = "0x3AF41A0", VA = "0x183AF55A0", Slot = "5")]
	public T DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class GGADLAMKCKB : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class EEIPOCAKCMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x33179D0", Offset = "0x33165D0", VA = "0x1833179D0")]
		static EEIPOCAKCMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private GGADLAMKCKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class KAKINLDLIGP : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class LGKCFNOPFBI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3C1ABD0", Offset = "0x3C197D0", VA = "0x183C1ABD0")]
		static LGKCFNOPFBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private KAKINLDLIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class OICAJBNDKMA
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly AODINAOIEAE[] ENKEIHCCEGA;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class LGKFLOLFIIC : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class MKCGLGNLHGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E54740", Offset = "0x3E53340", VA = "0x183E54740")]
		static MKCGLGNLHGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class FMAACHMPPGH : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class FDDEKHEIMCF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3681390", Offset = "0x367FF90", VA = "0x183681390")]
			static FDDEKHEIMCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private FMAACHMPPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private LGKFLOLFIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class AMMMKOHIMBP : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class KBAFGAEDELH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3B61A70", Offset = "0x3B60670", VA = "0x183B61A70")]
		static KBAFGAEDELH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class KHGAANHBLDP : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class COIDNGIKOOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4C9D0F0", Offset = "0x4C9BCF0", VA = "0x184C9D0F0")]
			static COIDNGIKOOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private KHGAANHBLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private AMMMKOHIMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class HLCPIGJPCFD : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class PABLANMNAIB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x40EF640", Offset = "0x40EE240", VA = "0x1840EF640")]
		static PABLANMNAIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class LCNDDMKJMFN : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class LDILAJNPMBJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3C024E0", Offset = "0x3C010E0", VA = "0x183C024E0")]
			static LDILAJNPMBJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private LCNDDMKJMFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private HLCPIGJPCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class APNDMJOMJMH : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class DPOBPMGIPNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x506DC70", Offset = "0x506C870", VA = "0x18506DC70")]
		static DPOBPMGIPNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class HKEKFCCCJJP : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class FPIDLPIKCHI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x36BFD00", Offset = "0x36BE900", VA = "0x1836BFD00")]
			static FPIDLPIKCHI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private HKEKFCCCJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private APNDMJOMJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class INOMJEJEAON : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class DOJIIGJOHAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5067F10", Offset = "0x5066B10", VA = "0x185067F10")]
		static DOJIIGJOHAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class BKBKHHEHHMK : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class NLOLANPHJCE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3F37220", Offset = "0x3F35E20", VA = "0x183F37220")]
			static NLOLANPHJCE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private BKBKHHEHHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private INOMJEJEAON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class BPGMKCFJMBD : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class CEOHJNKPOPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4AE9DA0", Offset = "0x4AE89A0", VA = "0x184AE9DA0")]
		static CEOHJNKPOPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class AGFOGJCMLED : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class JBKFEEEKEMN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3AE84B0", Offset = "0x3AE70B0", VA = "0x183AE84B0")]
			static JBKFEEEKEMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private AGFOGJCMLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private BPGMKCFJMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class NFBEJFCDAMD : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class MIBCHEAOOHK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BD40", Offset = "0x3E2A940", VA = "0x183E2BD40")]
		static MIBCHEAOOHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class EEFGHIKLOJF : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class JFOAJJOKNJI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3AF9D80", Offset = "0x3AF8980", VA = "0x183AF9D80")]
			static JFOAJJOKNJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private EEFGHIKLOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private NFBEJFCDAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class LOAHFOMFFFH : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class JKLNCNGBEGJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3B065E0", Offset = "0x3B051E0", VA = "0x183B065E0")]
		static JKLNCNGBEGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class CPIEMOIBHFO : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class HCDFELJEOGK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3805200", Offset = "0x3803E00", VA = "0x183805200")]
			static HCDFELJEOGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private CPIEMOIBHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private LOAHFOMFFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class HJEKJBJJDOD : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class MGOMFPIKFDL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3E21160", Offset = "0x3E1FD60", VA = "0x183E21160")]
		static MGOMFPIKFDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class ICMJHLPLPNP : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class LJCMFPCAONK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3C2B5F0", Offset = "0x3C2A1F0", VA = "0x183C2B5F0")]
			static LJCMFPCAONK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private ICMJHLPLPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private HJEKJBJJDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class FMOJFBGMIDE : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class EJHLLHGLDJP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x33303A0", Offset = "0x332EFA0", VA = "0x1833303A0")]
		static EJHLLHGLDJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class MDCPBHLJGHN : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class MKLFHOPOOIK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3E5CCD0", Offset = "0x3E5B8D0", VA = "0x183E5CCD0")]
			static MKLFHOPOOIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private MDCPBHLJGHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private FMOJFBGMIDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class FLEBCDOKPEM : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class EFIHIALLOKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3321CE0", Offset = "0x33208E0", VA = "0x183321CE0")]
		static EFIHIALLOKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class JHMBAKNKFCM : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class LIIDEMPCELM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3C28530", Offset = "0x3C27130", VA = "0x183C28530")]
			static LIIDEMPCELM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private JHMBAKNKFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private FLEBCDOKPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class NMLHANEEKEH : AODINAOIEAE
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class LNCCCECKJJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly IINNILDHPHN<T> CLHMIANGJIG;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A9D0", Offset = "0x3C395D0", VA = "0x183C3A9D0")]
		static LNCCCECKJJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class PEPFOEOAGID : AODINAOIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class LFFINDHDILC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly IINNILDHPHN<T> CLHMIANGJIG;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3C09360", Offset = "0x3C07F60", VA = "0x183C09360")]
			static LFFINDHDILC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly AODINAOIEAE EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly AODINAOIEAE[] LAPIKHEMFFD;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private PEPFOEOAGID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
		public IINNILDHPHN<T> EJBKFPEHMEF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly AODINAOIEAE EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly IINNILDHPHN<object> MILOHAJCKGL;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	private NMLHANEEKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	public IINNILDHPHN<T> EJBKFPEHMEF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct MBENBLNCDEM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] FPJCICBOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int EDIMMLFINLG;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E12220", Offset = "0x3E10E20", VA = "0x183E12220")]
	public MBENBLNCDEM(int NLJACJHMFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E11E20", Offset = "0x3E10A20", VA = "0x183E11E20")]
	public void BGJHDHHBMPP(T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E12190", Offset = "0x3E10D90", VA = "0x183E12190")]
	public T[] PAOMHGHBIMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class GBGLFDHLDLG : FEEIANCLBGO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly GBGLFDHLDLG IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A345A0", Offset = "0x6A331A0", VA = "0x186A345A0")]
	public GBGLFDHLDLG(int FNNPJAMBCJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class FEEIANCLBGO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int FNNPJAMBCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object EMEFHBEPHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int PMIDLPOCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] IGADDLGANOA;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x36844E0", Offset = "0x36830E0", VA = "0x1836844E0")]
	public FEEIANCLBGO(int FNNPJAMBCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x36841E0", Offset = "0x3682DE0", VA = "0x1836841E0")]
	public T[] IDOKOEBKDCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3683EE0", Offset = "0x3682AE0", VA = "0x183683EE0")]
	public void HIJFPFFOLPB(T[] GBCEGNLFFAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class LDOJPBBOHCM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class NFOHKJCIADM : IComparable<NFOHKJCIADM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class MPCLHNEIGBI : IEnumerable<NFOHKJCIADM>, IEnumerable, IEnumerator<NFOHKJCIADM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private NFOHKJCIADM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public NFOHKJCIADM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private NFOHKJCIADM System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
			[DebuggerHidden]
			public MPCLHNEIGBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6A3C0B0", Offset = "0x6A3ACB0", VA = "0x186A3C0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6A3C1E0", Offset = "0x6A3ADE0", VA = "0x186A3C1E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6A3C130", Offset = "0x6A3AD30", VA = "0x186A3C130", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NFOHKJCIADM> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6A3C130", Offset = "0x6A3AD30", VA = "0x186A3C130", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class FHLCLILHAPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public FHLCLILHAPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6A2AB50", Offset = "0x6A29750", VA = "0x186A2AB50")]
			internal Label BEEKBILNMNG(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6A2AB50", Offset = "0x6A29750", VA = "0x186A2AB50")]
			internal Label OMEPHHPAKIH(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly NFOHKJCIADM[] ONODMJGCOJO;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] BPHAMKDHKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong BKEHFHLBEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int BLAEOCKJGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string LFKMNENKAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NFOHKJCIADM[] GGIILNHACHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] AAAMHENLNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int MAJIECOCCAC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GMBBGPJHCCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5328960", Offset = "0x5327560", VA = "0x185328960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F9C0", Offset = "0x6A3E5C0", VA = "0x186A3F9C0")]
		public NFOHKJCIADM(ulong CGGNJKGENIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E800", Offset = "0x6A3D400", VA = "0x186A3E800")]
		public NFOHKJCIADM BGJHDHHBMPP(ulong CGGNJKGENIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E7A0", Offset = "0x6A3D3A0", VA = "0x186A3E7A0")]
		public NFOHKJCIADM BGJHDHHBMPP(ulong CGGNJKGENIH, int BLKAHBIJBJO, string LFKMNENKAPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F790", Offset = "0x6A3E390", VA = "0x186A3F790")]
		public NFOHKJCIADM JLAJJMCACJN(byte[] HLHHCNMEOCH, int OIAPMOHIBDO, int KECKNIMJGNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E710", Offset = "0x6A3D310", VA = "0x186A3E710")]
		internal static int BGCECBCLDEP(ulong[] GBCEGNLFFAN, int PMIDLPOCCEE, int GFICJHOBPLH, ulong BLKAHBIJBJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EA00", Offset = "0x6A3D600", VA = "0x186A3EA00", Slot = "4")]
		public int CompareTo(NFOHKJCIADM NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EA30", Offset = "0x6A3D630", VA = "0x186A3EA30")]
		[IteratorStateMachine(typeof(MPCLHNEIGBI))]
		public IEnumerable<NFOHKJCIADM> GNBAAEDMFLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E390", Offset = "0x6A3CF90", VA = "0x186A3E390")]
		public void AFNDDAMHLJB(ILGenerator DKKLHEGEHOH, LocalBuilder HLHHCNMEOCH, LocalBuilder KECKNIMJGNE, LocalBuilder CGGNJKGENIH, Action<KeyValuePair<string, int>> AJCIBDAMLOA, Action IJEJBIELHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EAB0", Offset = "0x6A3D6B0", VA = "0x186A3EAB0")]
		private static void GPAKDBFHFND(ILGenerator DKKLHEGEHOH, LocalBuilder HLHHCNMEOCH, LocalBuilder KECKNIMJGNE, LocalBuilder CGGNJKGENIH, Action<KeyValuePair<string, int>> AJCIBDAMLOA, Action IJEJBIELHNB, NFOHKJCIADM[] GGIILNHACHN, int MAJIECOCCAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class DCFLMBJOCDG : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<NFOHKJCIADM> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<NFOHKJCIADM> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<NFOHKJCIADM> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private NFOHKJCIADM <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xADE5B0", Offset = "0xADD1B0", VA = "0x180ADE5B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A307F0", Offset = "0x6A2F3F0", VA = "0x186A307F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CE66B0", Offset = "0x1CE52B0", VA = "0x181CE66B0")]
		[DebuggerHidden]
		public DCFLMBJOCDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6A30840", Offset = "0x6A2F440", VA = "0x186A30840", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6A30290", Offset = "0x6A2EE90", VA = "0x186A30290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A301F0", Offset = "0x6A2EDF0", VA = "0x186A301F0")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A30240", Offset = "0x6A2EE40", VA = "0x186A30240")]
		private void KFBCLBKCPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6A307A0", Offset = "0x6A2F3A0", VA = "0x186A307A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A306F0", Offset = "0x6A2F2F0", VA = "0x186A306F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6A306F0", Offset = "0x6A2F2F0", VA = "0x186A306F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly NFOHKJCIADM EBCHPMPLBLG;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AE60", Offset = "0x6A39A60", VA = "0x186A3AE60")]
	public LDOJPBBOHCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A7F0", Offset = "0x6A393F0", VA = "0x186A3A7F0")]
	public void BGJHDHHBMPP(byte[] PJGIELDOKCN, int BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ACF0", Offset = "0x6A398F0", VA = "0x186A3ACF0")]
	public bool PFMCHABMPLH(ArraySegment<byte> CGGNJKGENIH, [Out] int BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ADD0", Offset = "0x6A399D0", VA = "0x186A3ADD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A990", Offset = "0x6A39590", VA = "0x186A3A990")]
	private static void INJONMECDKK(IEnumerable<NFOHKJCIADM> GGIILNHACHN, StringBuilder AJCELLDIDGO, int EIGGDODJGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A930", Offset = "0x6A39530", VA = "0x186A3A930", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A930", Offset = "0x6A39530", VA = "0x186A3A930", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AC70", Offset = "0x6A39870", VA = "0x186A3AC70")]
	[IteratorStateMachine(typeof(DCFLMBJOCDG))]
	private static IEnumerable<KeyValuePair<string, int>> PDFALLAEAPO(IEnumerable<NFOHKJCIADM> GGIILNHACHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A900", Offset = "0x6A39500", VA = "0x186A3A900")]
	public void CIFAPCKILNA(ILGenerator DKKLHEGEHOH, LocalBuilder HLHHCNMEOCH, LocalBuilder KECKNIMJGNE, LocalBuilder CGGNJKGENIH, Action<KeyValuePair<string, int>> AJCIBDAMLOA, Action IJEJBIELHNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class OMLPNCKNLIE
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo HKCMMIMKAGI;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A411A0", Offset = "0x6A3FDA0", VA = "0x186A411A0")]
	public static ulong NPDPNEIOLLE(byte[] PJGIELDOKCN, int OIAPMOHIBDO, int KECKNIMJGNE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class FKFFBMPALGF
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A33D80", Offset = "0x6A32980", VA = "0x186A33D80")]
	public static void FKJELFPJCGD(byte[] PJGIELDOKCN, int OIAPMOHIBDO, int CCCLGPCIGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A33C60", Offset = "0x6A32860", VA = "0x186A33C60")]
	public static void DMOJDHEDLJB(byte[] GBCEGNLFFAN, int GACFHCOMJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A33EC0", Offset = "0x6A32AC0", VA = "0x186A33EC0")]
	public static byte[] LEMHJGKJNJA(byte[] PHEFBNNJAMO, int GACFHCOMJJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class LMHHGNMNMMF
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B520", Offset = "0x6A3A120", VA = "0x186A3B520")]
	public static bool DGMCFGOECOC(byte[] BEKGGKODNMH, int DEHMGKGMCJE, int BIGJPMKGAIC, byte[] LILILKGBIKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class JNLBDHBFAGF<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct IGEMNDJHKON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] BKEHFHLBEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T BLAEOCKJGCA;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3939DE0", Offset = "0x39389E0", VA = "0x183939DE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class IOKIHEKNCDM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public JNLBDHBFAGF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private IGEMNDJHKON[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private IGEMNDJHKON[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xADE5B0", Offset = "0xADD1B0", VA = "0x180ADE5B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x36F3860", Offset = "0x36F2460", VA = "0x1836F3860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public IOKIHEKNCDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3960FB0", Offset = "0x395FBB0", VA = "0x183960FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3962690", Offset = "0x3961290", VA = "0x183962690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly IGEMNDJHKON[][] FDJNCNMIGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong CEINBPEKKKM;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C5B0", Offset = "0x3B1B1B0", VA = "0x183B1C5B0")]
	public JNLBDHBFAGF(int LLHBDBHCNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C4F0", Offset = "0x3B1B0F0", VA = "0x183B1C4F0")]
	public JNLBDHBFAGF(int LLHBDBHCNGJ, float NCBINPGKCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3B197F0", Offset = "0x3B183F0", VA = "0x183B197F0")]
	public void BGJHDHHBMPP(byte[] CGGNJKGENIH, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A260", Offset = "0x3B18E60", VA = "0x183B1A260")]
	private bool FACJDGAKIBL(byte[] CGGNJKGENIH, T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3B1B7C0", Offset = "0x3B1A3C0", VA = "0x183B1B7C0")]
	public bool PODAMIMAFNE(ArraySegment<byte> CGGNJKGENIH, [Out] T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3B1B530", Offset = "0x3B1A130", VA = "0x183B1B530")]
	private static ulong JDLHELGMNGJ(byte[] KLNIMOGOBLK, int OIAPMOHIBDO, int MAJIECOCCAC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x392C5C0", Offset = "0x392B1C0", VA = "0x18392C5C0")]
	private static int GDAHCLMJPCN(int KCFCIHDHGKB, float NCBINPGKCON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B1B380", Offset = "0x3B19F80", VA = "0x183B1B380", Slot = "4")]
	[IteratorStateMachine(typeof(JNLBDHBFAGF<>.IOKIHEKNCDM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3587300", Offset = "0x3585F00", VA = "0x183587300", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class IJHFCKNCIAO : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] JNLKOEBMGAM;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] AEEBODLIFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int FOCPJLJBNAG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JKBALFEFELP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A35620", Offset = "0x6A34220", VA = "0x186A35620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A35670", Offset = "0x6A34270", VA = "0x186A35670")]
	static IJHFCKNCIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A358D0", Offset = "0x6A344D0", VA = "0x186A358D0")]
	public IJHFCKNCIAO(byte[] IBKPCHNAPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A35520", Offset = "0x6A34120", VA = "0x186A35520")]
	public OpCode DBLFNFKKFFL()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct BGFOELPDAOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid BLAEOCKJGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte PHDOLEENIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte EJHIHEAFALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte PFGMLKDMLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte ONPEIHHPILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte COGJNKHDBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte DFENIBGFFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte BCNNHJJGDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte DGCDAMGLJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte OEKNFDDOPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte LGPEHPPHPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte KBOEFCLIBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte CBDDGBOJPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte IJNBINFIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte FNKKPBEMIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte IPDFKHKDJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte EEBMFPKMBMA;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] GNAEMKJGKLM;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] AEGLNMEBJND;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E300", Offset = "0x6A2CF00", VA = "0x186A2E300")]
	public BGFOELPDAOO(Guid BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E310", Offset = "0x6A2CF10", VA = "0x186A2E310")]
	public BGFOELPDAOO(ArraySegment<byte> DJIEPDLALLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D3A0", Offset = "0x6A2BFA0", VA = "0x186A2D3A0")]
	private static byte APDJKJPHFAI(byte[] PJGIELDOKCN, int NNOGAACNPDK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D440", Offset = "0x6A2C040", VA = "0x186A2D440")]
	private static byte DADLCMIOBAL(byte ECIMPLOCMKE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D560", Offset = "0x6A2C160", VA = "0x186A2D560")]
	public void FGOOLPMNHAA(byte[] KLIMJJKAHFF, int OIAPMOHIBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class DMCHLOJKINM
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6A31D90", Offset = "0x6A30990", VA = "0x186A31D90")]
	public static bool EPHLENJJADG(byte IELECLNDABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6A31E20", Offset = "0x6A30A20", VA = "0x186A31E20")]
	public static bool HLDLOOBIEAP(byte IELECLNDABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6A31AD0", Offset = "0x6A306D0", VA = "0x186A31AD0")]
	public static sbyte BIEENKIEGNP(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6A31CA0", Offset = "0x6A308A0", VA = "0x186A31CA0")]
	public static short DEMIPLPLJAO(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6A31BB0", Offset = "0x6A307B0", VA = "0x186A31BB0")]
	public static int CFLBPPKPIPD(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6A32100", Offset = "0x6A30D00", VA = "0x186A32100")]
	public static long IKMEMPJOCON(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6A31F70", Offset = "0x6A30B70", VA = "0x186A31F70")]
	public static byte IDIPHPGACPI(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6A31DA0", Offset = "0x6A309A0", VA = "0x186A31DA0")]
	public static ushort GJLDGGGCHKN(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6A321A0", Offset = "0x6A30DA0", VA = "0x186A321A0")]
	public static uint IPNAFENBIIM(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6A31FF0", Offset = "0x6A30BF0", VA = "0x186A31FF0")]
	public static ulong IKLPOLDCDHB(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6A32220", Offset = "0x6A30E20", VA = "0x186A32220")]
	public static float LAMKCOPMBLM(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6A31E90", Offset = "0x6A30A90", VA = "0x186A31E90")]
	public static double IBMILHLDOHO(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6A32CC0", Offset = "0x6A318C0", VA = "0x186A32CC0")]
	public static int NJNCCDKJMOF(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, ulong BLKAHBIJBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6A32300", Offset = "0x6A30F00", VA = "0x186A32300")]
	public static int MEPIHLLGFNN(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, long BLKAHBIJBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6A33360", Offset = "0x6A31F60", VA = "0x186A33360")]
	public static bool OGJMAAFIJKE(byte[] PJGIELDOKCN, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class HABNDCNMDLJ
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NCABJIPHIIC : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
		[DebuggerHidden]
		public NCABJIPHIIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D930", Offset = "0x6A3C530", VA = "0x186A3D930", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D3F0", Offset = "0x6A3BFF0", VA = "0x186A3D3F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D350", Offset = "0x6A3BF50", VA = "0x186A3D350")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D3A0", Offset = "0x6A3BFA0", VA = "0x186A3D3A0")]
		private void KFBCLBKCPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D8E0", Offset = "0x6A3C4E0", VA = "0x186A3D8E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D820", Offset = "0x6A3C420", VA = "0x186A3D820", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D820", Offset = "0x6A3C420", VA = "0x186A3D820", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class NFOFKPCMDJP : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
		[DebuggerHidden]
		public NFOFKPCMDJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E260", Offset = "0x6A3CE60", VA = "0x186A3E260", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DD20", Offset = "0x6A3C920", VA = "0x186A3DD20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DC80", Offset = "0x6A3C880", VA = "0x186A3DC80")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DCD0", Offset = "0x6A3C8D0", VA = "0x186A3DCD0")]
		private void KFBCLBKCPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E210", Offset = "0x6A3CE10", VA = "0x186A3E210", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E150", Offset = "0x6A3CD50", VA = "0x186A3E150", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E150", Offset = "0x6A3CD50", VA = "0x186A3E150", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6A34D10", Offset = "0x6A33910", VA = "0x186A34D10")]
	public static bool HBIAEHMBCKN(this TypeInfo CJEAJMFMNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6A34AE0", Offset = "0x6A336E0", VA = "0x186A34AE0")]
	public static bool DLAEIOBGMAP(this TypeInfo CJEAJMFMNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6A34C10", Offset = "0x6A33810", VA = "0x186A34C10")]
	public static IEnumerable<PropertyInfo> FEOBDAMMNJD(this Type CJEAJMFMNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6A34A40", Offset = "0x6A33640", VA = "0x186A34A40")]
	[IteratorStateMachine(typeof(NCABJIPHIIC))]
	private static IEnumerable<PropertyInfo> DJCAKHPJCLF(Type CJEAJMFMNNJ, HashSet<string> FKLHLNCHHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6A34C90", Offset = "0x6A33890", VA = "0x186A34C90")]
	public static IEnumerable<FieldInfo> FLHBJPLPPPI(this Type CJEAJMFMNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6A34DD0", Offset = "0x6A339D0", VA = "0x186A34DD0")]
	[IteratorStateMachine(typeof(NFOFKPCMDJP))]
	private static IEnumerable<FieldInfo> NNAGBLLABEA(Type CJEAJMFMNNJ, HashSet<string> FKLHLNCHHPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class CFBHJNMNKDC
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding GKLOHFLFKMM;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class GMBPNCDIHJJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static string KCPJBJNGPIH(string LPGMAHAMBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6A34780", Offset = "0x6A33380", VA = "0x186A34780")]
	public static string GGECPAMPFML(string LPGMAHAMBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6A345F0", Offset = "0x6A331F0", VA = "0x186A345F0")]
	public static string EIDEJEFJABN(string LPGMAHAMBKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class IDAILIKOBPP<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class HBLELOPMFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type BKEHFHLBEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue BLAEOCKJGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int PJLNOINEHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public HBLELOPMFAN DEPMFFDMOME;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3802A90", Offset = "0x3801690", VA = "0x183802A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3802980", Offset = "0x3801580", VA = "0x183802980")]
		private int LOHCAPLAMPA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HBLELOPMFAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class LJOLEFLAIGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LJOLEFLAIGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40")]
		internal TValue DFNOEFNKHOO(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private HBLELOPMFAN[] FDJNCNMIGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int JKNAAACFMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object AEIBEKIIAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float NCBINPGKCON;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x392C890", Offset = "0x392B490", VA = "0x18392C890")]
	public IDAILIKOBPP(int LLHBDBHCNGJ = 4, float NCBINPGKCON = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x392BB50", Offset = "0x392A750", VA = "0x18392BB50")]
	public bool EEDOEBJHJKJ(Type CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x392BAC0", Offset = "0x392A6C0", VA = "0x18392BAC0")]
	public bool EEDOEBJHJKJ(Type CGGNJKGENIH, Func<Type, TValue> BGFEDHEGPCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x392BF00", Offset = "0x392AB00", VA = "0x18392BF00")]
	private bool FACJDGAKIBL(Type CGGNJKGENIH, Func<Type, TValue> BGFEDHEGPCI, [Out] TValue PHAMICDNGGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x392B310", Offset = "0x3929F10", VA = "0x18392B310")]
	private bool DKEDLJEMCBO(HBLELOPMFAN[] FDJNCNMIGHP, Type IKOFABGMLMM, HBLELOPMFAN LJGAEPBBOOG, Func<Type, TValue> BGFEDHEGPCI, [Out] TValue PHAMICDNGGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x392C620", Offset = "0x392B220", VA = "0x18392C620")]
	public bool PODAMIMAFNE(Type CGGNJKGENIH, [Out] TValue BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x392BDB0", Offset = "0x392A9B0", VA = "0x18392BDB0")]
	public TValue EJMKGPJAODM(Type CGGNJKGENIH, Func<Type, TValue> BGFEDHEGPCI)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x392C5C0", Offset = "0x392B1C0", VA = "0x18392C5C0")]
	private static int GDAHCLMJPCN(int KCFCIHDHGKB, float NCBINPGKCON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x392C5F0", Offset = "0x392B1F0", VA = "0x18392C5F0")]
	private static void OBEKMNLKKKF(HBLELOPMFAN HPGOCBNKMCB, HBLELOPMFAN BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x392C5F0", Offset = "0x392B1F0", VA = "0x18392C5F0")]
	private static void OBEKMNLKKKF(HBLELOPMFAN[] HPGOCBNKMCB, HBLELOPMFAN[] BLKAHBIJBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class EIDHMDFIJAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder FOICPLPMMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder JJFKIGHDAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object EMEFHBEPHFJ;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6A33A50", Offset = "0x6A32650", VA = "0x186A33A50")]
	public TypeBuilder ALCJKDLAKMF(string MPGNMPAPHDB, TypeAttributes LCKPKGAPDFN, Type MJOMMKLGFIJ, Type[] LNMAEGLNAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6A33B50", Offset = "0x6A32750", VA = "0x186A33B50")]
	public EIDHMDFIJAL(string FKGGOLLPJHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class PHOIBELANEC
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6A41F90", Offset = "0x6A40B90", VA = "0x186A41F90")]
	private static MethodInfo JDALEOHEJOI(LambdaExpression CICLKJDGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x29501E0", Offset = "0x294EDE0", VA = "0x1829501E0")]
	public static MethodInfo ALLKGKKJJAE<T>(Expression<Func<T>> CICLKJDGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x29501E0", Offset = "0x294EDE0", VA = "0x1829501E0")]
	public static MethodInfo ALLKGKKJJAE<T, TR>(Expression<Func<T, TR>> CICLKJDGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x29501E0", Offset = "0x294EDE0", VA = "0x1829501E0")]
	public static MethodInfo ALLKGKKJJAE<T>(Expression<Action<T>> CICLKJDGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x29501E0", Offset = "0x294EDE0", VA = "0x1829501E0")]
	public static MethodInfo ALLKGKKJJAE<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> CICLKJDGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2950290", Offset = "0x294EE90", VA = "0x182950290")]
	private static MemberInfo FJODIOGLKJJ<T>(Expression<T> KNENCIBJOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x29501F0", Offset = "0x294EDF0", VA = "0x1829501F0")]
	public static PropertyInfo FIGOKKAKLNL<T, TR>(Expression<Func<T, TR>> CICLKJDGDGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct AMKOEDMMEDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int CFPNJHJGBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool PIBIEFBIDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator DKKLHEGEHOH;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D150", Offset = "0x6A2BD50", VA = "0x186A2D150")]
	public AMKOEDMMEDB(ILGenerator DKKLHEGEHOH, int CFPNJHJGBGM, bool PIBIEFBIDKA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D190", Offset = "0x6A2BD90", VA = "0x186A2D190")]
	public AMKOEDMMEDB(ILGenerator DKKLHEGEHOH, int CFPNJHJGBGM, Type CJEAJMFMNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D050", Offset = "0x6A2BC50", VA = "0x186A2D050")]
	public void HIBENFAMFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class NBGNLANCOJA
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CFB0", Offset = "0x6A3BBB0", VA = "0x186A3CFB0")]
	public static void NCEGALFODFP(this ILGenerator DKKLHEGEHOH, int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D1A0", Offset = "0x6A3BDA0", VA = "0x186A3D1A0")]
	public static void NCEGALFODFP(this ILGenerator DKKLHEGEHOH, LocalBuilder OLBBLEJNFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C650", Offset = "0x6A3B250", VA = "0x186A3C650")]
	public static void CPNCDEPKKDK(this ILGenerator DKKLHEGEHOH, int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C610", Offset = "0x6A3B210", VA = "0x186A3C610")]
	public static void CPNCDEPKKDK(this ILGenerator DKKLHEGEHOH, LocalBuilder OLBBLEJNFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CAE0", Offset = "0x6A3B6E0", VA = "0x186A3CAE0")]
	public static void JAKOCOIAMJL(this ILGenerator DKKLHEGEHOH, int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CBC0", Offset = "0x6A3B7C0", VA = "0x186A3CBC0")]
	public static void JAKOCOIAMJL(this ILGenerator DKKLHEGEHOH, LocalBuilder OLBBLEJNFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CFA0", Offset = "0x6A3BBA0", VA = "0x186A3CFA0")]
	public static void LBFKHIELHPL(this ILGenerator DKKLHEGEHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C950", Offset = "0x6A3B550", VA = "0x186A3C950")]
	public static void HFHDDELGABH(this ILGenerator DKKLHEGEHOH, bool BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C230", Offset = "0x6A3AE30", VA = "0x186A3C230")]
	public static void ALAFJNGLEEM(this ILGenerator DKKLHEGEHOH, int BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C960", Offset = "0x6A3B560", VA = "0x186A3C960")]
	public static void HHALDFHLMEI(this ILGenerator DKKLHEGEHOH, Type CJEAJMFMNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CA40", Offset = "0x6A3B640", VA = "0x186A3CA40")]
	public static void HPHFNAMHNMH(this ILGenerator DKKLHEGEHOH, Type CJEAJMFMNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CDB0", Offset = "0x6A3B9B0", VA = "0x186A3CDB0")]
	public static void KBBJHPPEBLG(this ILGenerator DKKLHEGEHOH, int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C840", Offset = "0x6A3B440", VA = "0x186A3C840")]
	public static void DLNAJNFKLHA(this ILGenerator DKKLHEGEHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D1E0", Offset = "0x6A3BDE0", VA = "0x186A3D1E0")]
	public static void PCFDGIDEKJK(this ILGenerator DKKLHEGEHOH, int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CCC0", Offset = "0x6A3B8C0", VA = "0x186A3CCC0")]
	public static void JPLHPMEMGEJ(this ILGenerator DKKLHEGEHOH, MethodInfo GJBHNELJODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C8C0", Offset = "0x6A3B4C0", VA = "0x186A3C8C0")]
	public static void FNDNHBLCIID(this ILGenerator DKKLHEGEHOH, FieldInfo FBBOCEBPODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D2C0", Offset = "0x6A3BEC0", VA = "0x186A3D2C0")]
	public static void PKFGLGJOMDO(this ILGenerator DKKLHEGEHOH, ulong BLKAHBIJBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class MCGLAIMJFCE
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class EIAMONMJHPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EIAMONMJHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6A33940", Offset = "0x6A32540", VA = "0x186A33940")]
		internal bool FKLMEHMDIEN(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo AFINOLNJGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo BNLJNAOKJFP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string CJMNNNKKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JPLFNGLHMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BB80", Offset = "0x6A3A780", VA = "0x186A3BB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MCLGHHGIADP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F80", Offset = "0x7B8B80", VA = "0x1807B9F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E30", Offset = "0x7B8A30", VA = "0x1807B9E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JNLMCJGIGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9321E0", Offset = "0x930DE0", VA = "0x1809321E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x931ED0", Offset = "0x930AD0", VA = "0x180931ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type LLGILHFCKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo JBFJBGOBECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo DJCOKCIFLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F30", Offset = "0x7B8B30", VA = "0x1807B9F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo LALIBIEPPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B50", Offset = "0x7B1750", VA = "0x1807B2B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B20", Offset = "0x7B1720", VA = "0x1807B2B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BD50", Offset = "0x6A3A950", VA = "0x186A3BD50")]
	protected MCGLAIMJFCE(Type CJEAJMFMNNJ, string MPGNMPAPHDB, string COHEAJNJIMF, bool LKFBPMGGDAF, bool IAHPNKANMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BDD0", Offset = "0x6A3A9D0", VA = "0x186A3BDD0")]
	public MCGLAIMJFCE(FieldInfo KIGGBMJEDEA, string MPGNMPAPHDB, bool LLEBCHGMFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BB90", Offset = "0x6A3A790", VA = "0x186A3BB90")]
	public MCGLAIMJFCE(PropertyInfo KIGGBMJEDEA, string MPGNMPAPHDB, bool LLEBCHGMFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B710", Offset = "0x6A3A310", VA = "0x186A3B710")]
	private static MethodInfo HEEAHANLGME(MemberInfo KIGGBMJEDEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2894700", Offset = "0x2893300", VA = "0x182894700")]
	public T GBFHADBECIB<T>(bool PNANOKIIKGH) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BA00", Offset = "0x6A3A600", VA = "0x186A3BA00", Slot = "4")]
	public virtual void OIFGHHLMJHL(ILGenerator DKKLHEGEHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B880", Offset = "0x6A3A480", VA = "0x186A3B880", Slot = "5")]
	public virtual void NDELLLODCDH(ILGenerator DKKLHEGEHOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class GNJLJDPJDNL : MCGLAIMJFCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string KJHBEMNADDO;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6A34960", Offset = "0x6A33560", VA = "0x186A34960")]
	public GNJLJDPJDNL(string MPGNMPAPHDB, string KJHBEMNADDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6A348B0", Offset = "0x6A334B0", VA = "0x186A348B0", Slot = "4")]
	public override void OIFGHHLMJHL(ILGenerator DKKLHEGEHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6A34860", Offset = "0x6A33460", VA = "0x186A34860", Slot = "5")]
	public override void NDELLLODCDH(ILGenerator DKKLHEGEHOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class JNJDFPEHEGI : MCGLAIMJFCE
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo MGBFMMGLIIP;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo DMCCGLINDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal AMKOEDMMEDB IAMBFIODHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal AMKOEDMMEDB AKCMCLFMEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal AMKOEDMMEDB CPGJHAIEHME;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A070", Offset = "0x6A38C70", VA = "0x186A3A070")]
	public JNJDFPEHEGI(string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6A39AA0", Offset = "0x6A386A0", VA = "0x186A39AA0", Slot = "4")]
	public override void OIFGHHLMJHL(ILGenerator DKKLHEGEHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6A39A50", Offset = "0x6A38650", VA = "0x186A39A50", Slot = "5")]
	public override void NDELLLODCDH(ILGenerator DKKLHEGEHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6A39890", Offset = "0x6A38490", VA = "0x186A39890")]
	public void DCGJBGDPJFC(ILGenerator DKKLHEGEHOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class OLKBFPPMAAH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type LLGILHFCKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PLLPCNKOOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E0", Offset = "0x82CCE0", VA = "0x18082E0E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C70", Offset = "0x7AF870", VA = "0x1807B0C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ABIDIKCGFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x82E0F0", Offset = "0x82CCF0", VA = "0x18082E0F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x931060", Offset = "0x92FC60", VA = "0x180931060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo PKAMGLIGPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public MCGLAIMJFCE[] GLECMOBELKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public MCGLAIMJFCE[] ILCHMLANNPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FCE0", Offset = "0x6A3E8E0", VA = "0x186A3FCE0")]
	public OLKBFPPMAAH(Type CJEAJMFMNNJ, Func<string, string> HOEBGJJANJH, bool LLEBCHGMFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FC00", Offset = "0x6A3E800", VA = "0x186A3FC00")]
	private static bool IFGOKAAMHNM(IEnumerator<ConstructorInfo> LLCNICNOALA, ConstructorInfo EIFKOAOPGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct DOLPOKAFOID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong LHGJHBCOGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int PKPFNALFKGI;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1E22BD0", Offset = "0x1E217D0", VA = "0x181E22BD0")]
	public DOLPOKAFOID(ulong OFNDCGHDALO, int IMGODEMAFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6A33760", Offset = "0x6A32360", VA = "0x186A33760")]
	public void PFEKKAPMLAC(DOLPOKAFOID NAFFCAIMPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6A33590", Offset = "0x6A32190", VA = "0x186A33590")]
	public static DOLPOKAFOID DBCOFGMDOPN(DOLPOKAFOID PKCAMDKHNLN, DOLPOKAFOID ECIMPLOCMKE)
	{
		return default(DOLPOKAFOID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A33640", Offset = "0x6A32240", VA = "0x186A33640")]
	public void JOKAHNOCOAG(DOLPOKAFOID NAFFCAIMPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6A335A0", Offset = "0x6A321A0", VA = "0x186A335A0")]
	public static DOLPOKAFOID IHCHPONDBOD(DOLPOKAFOID PKCAMDKHNLN, DOLPOKAFOID ECIMPLOCMKE)
	{
		return default(DOLPOKAFOID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6A336D0", Offset = "0x6A322D0", VA = "0x186A336D0")]
	public void NBGMPCPPPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6A33710", Offset = "0x6A32310", VA = "0x186A33710")]
	public static DOLPOKAFOID NBGMPCPPPMH(DOLPOKAFOID PKCAMDKHNLN)
	{
		return default(DOLPOKAFOID);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct LAKBMLIHCPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] KLIMJJKAHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int OIAPMOHIBDO;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x18BEA20", Offset = "0x18BD620", VA = "0x1818BEA20")]
	public LAKBMLIHCPG(byte[] KLIMJJKAHFF, int GMKEEAOHFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6A12230", Offset = "0x6A10E30", VA = "0x186A12230")]
	public void KOABIKNKHOM(byte KCOOFCLDKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A4A0", Offset = "0x6A390A0", VA = "0x186A3A4A0")]
	public void JIINMDCFFIO(byte[] KCOOFCLDKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A420", Offset = "0x6A39020", VA = "0x186A3A420")]
	public void JEDJBKLAKHK(byte[] KCOOFCLDKNM, int GFICJHOBPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A380", Offset = "0x6A38F80", VA = "0x186A3A380")]
	public void JEDJBKLAKHK(byte[] KCOOFCLDKNM, int ILKNGPHCOGM, int GFICJHOBPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A300", Offset = "0x6A38F00", VA = "0x186A3A300")]
	public void HLPEGNHKJDC(byte IELECLNDABB, int MAJIECOCCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A520", Offset = "0x6A39120", VA = "0x186A3A520")]
	public void NKHPHDBGLFF(string KCOOFCLDKNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class JJOHCKPHDIF
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum OBFBPPCHECE
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum AFLDHHEDEMN
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum JCNNDIPBOBL
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
	private static byte[] GOJKDMHLBEN;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] DLHFGDHBPNF;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] JPDGEFBNPJD;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] JHFDOAMMKJC;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly JCNNDIPBOBL ADLAOECCNOA;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char ADGFIAKIEPA;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int OJBPDOJECNL;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int NFGBNJFNLJA;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] EDHHELLODBF;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6A36220", Offset = "0x6A34E20", VA = "0x186A36220")]
	private static byte[] FMHKCPNHCDN(int JKNAAACFMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A36830", Offset = "0x6A35430", VA = "0x186A36830")]
	private static byte[] GLEIFOPFADJ(int JKNAAACFMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A37560", Offset = "0x6A36160", VA = "0x186A37560")]
	public static int MEIGNIDEJDF(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, float BLKAHBIJBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A37440", Offset = "0x6A36040", VA = "0x186A37440")]
	public static int MEIGNIDEJDF(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, double BLKAHBIJBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A36910", Offset = "0x6A35510", VA = "0x186A36910")]
	private static bool IOLEBHLBJFN(byte[] KLIMJJKAHFF, int GFICJHOBPLH, ulong MDOMLGCLOML, ulong NJGMBFLAEPJ, ulong KECKNIMJGNE, ulong NIDNACDNPHN, ulong ALIIKBGMBHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A35CB0", Offset = "0x6A348B0", VA = "0x186A35CB0")]
	private static void BJKKDABAEKB(uint MENKCHLGBFO, int IAFKFDLILNM, [Out] uint KKAOKIHIEAK, [Out] int GBEANEFBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A37680", Offset = "0x6A36280", VA = "0x186A37680")]
	private static bool MEJMGGEHBAC(DOLPOKAFOID FDDDPCFGAFK, DOLPOKAFOID PCBNIKDPPAI, DOLPOKAFOID MFCMHIFHNIC, byte[] KLIMJJKAHFF, [Out] int GFICJHOBPLH, [Out] int BILLBPLDJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A35DA0", Offset = "0x6A349A0", VA = "0x186A35DA0")]
	private static bool FALLHCDMAJD(double MKPKMCNPNND, OBFBPPCHECE HJPHBEGAFCD, byte[] KLIMJJKAHFF, [Out] int GFICJHOBPLH, [Out] int BIIHKEIPMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A362F0", Offset = "0x6A34EF0", VA = "0x186A362F0")]
	private static bool FNIBDPKNGFE(double MKPKMCNPNND, OBFBPPCHECE HJPHBEGAFCD, byte[] KLIMJJKAHFF, [Out] int GFICJHOBPLH, [Out] int GFBJLNGBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A37270", Offset = "0x6A35E70", VA = "0x186A37270")]
	private static bool KMIKLGPBHMN(double BLKAHBIJBJO, LAKBMLIHCPG MDIIBGLFMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A36D90", Offset = "0x6A35990", VA = "0x186A36D90")]
	private static bool KGHAEPBGAGL(double BLKAHBIJBJO, LAKBMLIHCPG MDIIBGLFMKH, AFLDHHEDEMN HJPHBEGAFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A36A00", Offset = "0x6A35600", VA = "0x186A36A00")]
	private static void JPANCIIFAMN(byte[] INNJGJCMMLK, int GFICJHOBPLH, int GFBJLNGBEIL, int FFFFMKKPLKL, LAKBMLIHCPG MDIIBGLFMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A36400", Offset = "0x6A35000", VA = "0x186A36400")]
	private static void GJKHCILHCPC(byte[] INNJGJCMMLK, int GFICJHOBPLH, int IMGODEMAFKH, LAKBMLIHCPG MDIIBGLFMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A37A70", Offset = "0x6A36670", VA = "0x186A37A70")]
	private static bool MOHCKNJCIHO(double MKPKMCNPNND, AFLDHHEDEMN HJPHBEGAFCD, int IFAIPANBICD, byte[] JFFPAOCPNKN, [Out] bool ABBHDAOEALC, [Out] int GFICJHOBPLH, [Out] int HBOOGDGOIKL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct ACPNLOOKKED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double MDPDLOKKCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong LDIBIEPOHJP;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct LMDEPIAKANH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float LHGJHBCOGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint MMPPHDPECJH;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct LLAIBCCGPKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong FGNDDDOHMEL;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B510", Offset = "0x6A3A110", VA = "0x186A3B510")]
	public LLAIBCCGPKJ(double MDPDLOKKCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B470", Offset = "0x6A3A070", VA = "0x186A3B470")]
	public LLAIBCCGPKJ(DOLPOKAFOID MDPDLOKKCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B1D0", Offset = "0x6A39DD0", VA = "0x186A3B1D0")]
	public DOLPOKAFOID HFLJENBIEII()
	{
		return default(DOLPOKAFOID);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B0B0", Offset = "0x6A39CB0", VA = "0x186A3B0B0")]
	public DOLPOKAFOID BNAKKEOJKBA()
	{
		return default(DOLPOKAFOID);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0")]
	public ulong JAKJJCMCADA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AEE0", Offset = "0x6A39AE0", VA = "0x186A3AEE0")]
	public double ALBMEDEFMPE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B270", Offset = "0x6A39E70", VA = "0x186A3B270")]
	public double IJAONDGFICE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B310", Offset = "0x6A39F10", VA = "0x186A3B310")]
	public int IJGMCMKPMCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B360", Offset = "0x6A39F60", VA = "0x186A3B360")]
	public ulong KODAJLCCHEF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B340", Offset = "0x6A39F40", VA = "0x186A3B340")]
	public bool JDILKMAIEJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B1B0", Offset = "0x6A39DB0", VA = "0x186A3B1B0")]
	public bool HBHOOBPDNGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B240", Offset = "0x6A39E40", VA = "0x186A3B240")]
	public bool HHENNACPFAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B180", Offset = "0x6A39D80", VA = "0x186A3B180")]
	public bool GICIBGLABNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B160", Offset = "0x6A39D60", VA = "0x186A3B160")]
	public int FFGKCLNDMEO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AF60", Offset = "0x6A39B60", VA = "0x186A3AF60")]
	public void APEFDPBMDKD([Out] DOLPOKAFOID JCHLBKEOKDI, [Out] DOLPOKAFOID AEPBNEFOFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B420", Offset = "0x6A3A020", VA = "0x186A3B420")]
	public bool NNCIFGEBDAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D42BC0", Offset = "0x2D417C0", VA = "0x182D42BC0")]
	public double BLKAHBIJBJO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B130", Offset = "0x6A39D30", VA = "0x186A3B130")]
	public static int BOJLIMDODJC(int HEKINOPHJOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B150", Offset = "0x6A39D50", VA = "0x186A3B150")]
	public static double DGDDDJLFEHG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B390", Offset = "0x6A39F90", VA = "0x186A3B390")]
	public static ulong LBIMFOLEJHD(DOLPOKAFOID GKOLCFEAJGI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct FNIDPKOJAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint BICMPHCNOHL;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B010", Offset = "0x1F79C10", VA = "0x181F7B010")]
	public FNIDPKOJAEJ(float LHGJHBCOGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A34420", Offset = "0x6A33020", VA = "0x186A34420")]
	public DOLPOKAFOID HFLJENBIEII()
	{
		return default(DOLPOKAFOID);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
	public uint HGBEIHOKBFG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A34470", Offset = "0x6A33070", VA = "0x186A34470")]
	public int IJGMCMKPMCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A344A0", Offset = "0x6A330A0", VA = "0x186A344A0")]
	public uint KODAJLCCHEF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A34490", Offset = "0x6A33090", VA = "0x186A34490")]
	public bool JDILKMAIEJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A342F0", Offset = "0x6A32EF0", VA = "0x186A342F0")]
	public void APEFDPBMDKD([Out] DOLPOKAFOID JCHLBKEOKDI, [Out] DOLPOKAFOID AEPBNEFOFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A344C0", Offset = "0x6A330C0", VA = "0x186A344C0")]
	public bool NNCIFGEBDAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct IDKBAAHGEHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong OFNDCGHDALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short BCNJGDNFJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short BIIHKEIPMJJ;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A35510", Offset = "0x6A34110", VA = "0x186A35510")]
	public IDKBAAHGEHE(ulong OFNDCGHDALO, short BCNJGDNFJAH, short BIIHKEIPMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class DJFDGDECGLM
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly IDKBAAHGEHE[] KHKFBOGGOPE;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A30990", Offset = "0x6A2F590", VA = "0x186A30990")]
	public static void BMMNANMEGGK(int BHHPAFEFLKE, int HIHLCECCHBI, [Out] DOLPOKAFOID KKAOKIHIEAK, [Out] int BIIHKEIPMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A30AA0", Offset = "0x6A2F6A0", VA = "0x186A30AA0")]
	public static void CAEIKHELHDD(int IOHBGNEFHKD, [Out] DOLPOKAFOID KKAOKIHIEAK, [Out] int LJPOEBALOBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct NDAMOOLOFPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] PJGIELDOKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int ILKNGPHCOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int DPJLEIPAICN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DAC0", Offset = "0x6A3C6C0", VA = "0x186A3DAC0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3678F30", Offset = "0x3677B30", VA = "0x183678F30")]
	public NDAMOOLOFPC(byte[] PJGIELDOKCN, int ILKNGPHCOGM, int GFICJHOBPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEA60", Offset = "0x1FBD660", VA = "0x181FBEA60")]
	public int GFICJHOBPLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DA60", Offset = "0x6A3C660", VA = "0x186A3DA60")]
	public NDAMOOLOFPC IPLKKEFIKKH(int AMJEKOIBAHJ, int MCJHMJKLMAB)
	{
		return default(NDAMOOLOFPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class ACNKLIIOLHM
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] JIIIFPOLOAE;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] ICPIGCLFBME;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int AIPJBONCMDK;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B590", Offset = "0x6A2A190", VA = "0x186A2B590")]
	private static byte[] BBIGEELOFAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CCE0", Offset = "0x6A2B8E0", VA = "0x186A2CCE0")]
	private static NDAMOOLOFPC PKADKKBHKBI(NDAMOOLOFPC KLIMJJKAHFF)
	{
		return default(NDAMOOLOFPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C520", Offset = "0x6A2B120", VA = "0x186A2C520")]
	private static NDAMOOLOFPC JJADNLGOBJN(NDAMOOLOFPC KLIMJJKAHFF)
	{
		return default(NDAMOOLOFPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C490", Offset = "0x6A2B090", VA = "0x186A2C490")]
	private static void HHOJLHENIKG(NDAMOOLOFPC KLIMJJKAHFF, int IMGODEMAFKH, byte[] LCGMKEADBBN, [Out] int FHHLPKJDAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C600", Offset = "0x6A2B200", VA = "0x186A2C600")]
	private static void JKAJJIJIDFM(NDAMOOLOFPC KLIMJJKAHFF, int IMGODEMAFKH, byte[] FLLNOBPCDAC, int JGEKGDCNHMN, [Out] NDAMOOLOFPC GEOCIKNHCAG, [Out] int ACJMJEFEEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B500", Offset = "0x6A2A100", VA = "0x186A2B500")]
	private static ulong BBANHMMGIMN(NDAMOOLOFPC KLIMJJKAHFF, [Out] int NGJFDLMDOEG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C350", Offset = "0x6A2AF50", VA = "0x186A2C350")]
	private static void HADHKMOINLI(NDAMOOLOFPC KLIMJJKAHFF, [Out] DOLPOKAFOID MGHLKGJFBCD, [Out] int HFILDDBJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B670", Offset = "0x6A2A270", VA = "0x186A2B670")]
	private static bool DAGFKAAHBJH(NDAMOOLOFPC GEOCIKNHCAG, int IMGODEMAFKH, [Out] double MGHLKGJFBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C090", Offset = "0x6A2AC90", VA = "0x186A2C090")]
	private static DOLPOKAFOID FMBDGIKOCJK(int IMGODEMAFKH)
	{
		return default(DOLPOKAFOID);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BA40", Offset = "0x6A2A640", VA = "0x186A2BA40")]
	private static bool DGJGGEFPKIL(NDAMOOLOFPC KLIMJJKAHFF, int IMGODEMAFKH, [Out] double MGHLKGJFBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C230", Offset = "0x6A2AE30", VA = "0x186A2C230")]
	private static bool FNPAOHKICLI(NDAMOOLOFPC GEOCIKNHCAG, int IMGODEMAFKH, [Out] double JEDMAPIMDJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C8F0", Offset = "0x6A2B4F0", VA = "0x186A2C8F0")]
	public static double? LIOGGBIPJOK(NDAMOOLOFPC KLIMJJKAHFF, int IMGODEMAFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CA10", Offset = "0x6A2B610", VA = "0x186A2CA10")]
	public static float? OIAADPMNBLA(NDAMOOLOFPC KLIMJJKAHFF, int IMGODEMAFKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct CPHJKEEBOEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] KLIMJJKAHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int OIAPMOHIBDO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A2FF10", Offset = "0x6A2EB10", VA = "0x186A2FF10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x18BEA20", Offset = "0x18BD620", VA = "0x1818BEA20")]
	public CPHJKEEBOEM(byte[] KLIMJJKAHFF, int OIAPMOHIBDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FFA0", Offset = "0x6A2EBA0", VA = "0x186A2FFA0")]
	public static CPHJKEEBOEM IJMDDNBEKIN(CPHJKEEBOEM NOLNJDLEMAA)
	{
		return default(CPHJKEEBOEM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FE70", Offset = "0x6A2EA70", VA = "0x186A2FE70")]
	public static CPHJKEEBOEM DBLKOCIAKKD(CPHJKEEBOEM NOLNJDLEMAA, int GFICJHOBPLH)
	{
		return default(CPHJKEEBOEM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FF00", Offset = "0x6A2EB00", VA = "0x186A2FF00")]
	public static int GIGILBKKNHF(CPHJKEEBOEM AHIHMLDOCPC, CPHJKEEBOEM APNBCADOPPJ)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FEF0", Offset = "0x6A2EAF0", VA = "0x186A2FEF0")]
	public static bool FKDJFADGJBA(CPHJKEEBOEM AHIHMLDOCPC, CPHJKEEBOEM APNBCADOPPJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A30010", Offset = "0x6A2EC10", VA = "0x186A30010")]
	public static bool MGCOHCIMIFH(CPHJKEEBOEM AHIHMLDOCPC, CPHJKEEBOEM APNBCADOPPJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FEC0", Offset = "0x6A2EAC0", VA = "0x186A2FEC0")]
	public static bool FKDJFADGJBA(CPHJKEEBOEM AHIHMLDOCPC, char APNBCADOPPJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FFE0", Offset = "0x6A2EBE0", VA = "0x186A2FFE0")]
	public static bool MGCOHCIMIFH(CPHJKEEBOEM AHIHMLDOCPC, char APNBCADOPPJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FFE0", Offset = "0x6A2EBE0", VA = "0x186A2FFE0")]
	public static bool MGCOHCIMIFH(CPHJKEEBOEM AHIHMLDOCPC, byte APNBCADOPPJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FFB0", Offset = "0x6A2EBB0", VA = "0x186A2FFB0")]
	public static bool LHAKBKIEBAI(CPHJKEEBOEM AHIHMLDOCPC, char APNBCADOPPJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FE40", Offset = "0x6A2EA40", VA = "0x186A2FE40")]
	public static bool CCFCGEBFAGD(CPHJKEEBOEM AHIHMLDOCPC, char APNBCADOPPJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FF40", Offset = "0x6A2EB40", VA = "0x186A2FF40")]
	public static bool HEEOODCEMNJ(CPHJKEEBOEM AHIHMLDOCPC, char APNBCADOPPJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FF70", Offset = "0x6A2EB70", VA = "0x186A2FF70")]
	public static bool IFENCJFJOJP(CPHJKEEBOEM AHIHMLDOCPC, char APNBCADOPPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class JKMOCEBEDPK
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] GCDOFGJICBB;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] CJAGBFOENAN;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] JPDGEFBNPJD;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] JHFDOAMMKJC;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] NFCOFGLFAPD;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int CCAOGMKAPPL;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] IKNMFMKHIAG;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int OIEGMNKMGNA;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A38FE0", Offset = "0x6A37BE0", VA = "0x186A38FE0")]
	private static byte[] EPFMOFBHLED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A39190", Offset = "0x6A37D90", VA = "0x186A39190")]
	private static byte[] IJJEIDKBPFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A390C0", Offset = "0x6A37CC0", VA = "0x186A390C0")]
	public static double GCAGFEEHGBE(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A39270", Offset = "0x6A37E70", VA = "0x186A39270")]
	public static float LAJAAKIHLFC(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, [Out] int ECLBGHKKDPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A38EA0", Offset = "0x6A37AA0", VA = "0x186A38EA0")]
	private static bool DMIEMEOJAPE(int KLNIMOGOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A39320", Offset = "0x6A37F20", VA = "0x186A39320")]
	private static bool NBHELBKAJMJ(CPHJKEEBOEM JHGDOKACGDP, CPHJKEEBOEM FFMMBPDGBBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A39510", Offset = "0x6A38110", VA = "0x186A39510")]
	private static bool PEOFBNOMIHM(CPHJKEEBOEM JHGDOKACGDP, CPHJKEEBOEM FFMMBPDGBBA, byte[] HKEOGFPKAGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A38E50", Offset = "0x6A37A50", VA = "0x186A38E50")]
	private static bool BGBOAKKFGNG(CPHJKEEBOEM CGFBACPNMCD, byte[] KCOOFCLDKNM, int OIAPMOHIBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A39170", Offset = "0x6A37D70", VA = "0x186A39170")]
	private static double HBDBEAMHMFO(bool ABBHDAOEALC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A37EB0", Offset = "0x6A36AB0", VA = "0x186A37EB0")]
	private static double ABIGLPNIEMM(CPHJKEEBOEM KMJAEAGEOPB, int GFICJHOBPLH, bool PDOEOLIDDBF, [Out] int BKEGAKCLAJH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class LIEFKCOAIHE<T> : IINNILDHPHN<T[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly FEEIANCLBGO<T> BIAOADCPBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly DKBHHFMJBBE HJCJIKLNINF;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A300", Offset = "0x3B78F00", VA = "0x183B7A300")]
	public LIEFKCOAIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
	public LIEFKCOAIHE(DKBHHFMJBBE HJCJIKLNINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C26160", Offset = "0x3C24D60", VA = "0x183C26160", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C25D90", Offset = "0x3C24990", VA = "0x183C25D90", Slot = "5")]
	public T[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class INCNJDOHHFN<T> : IINNILDHPHN<ArraySegment<T>>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly FEEIANCLBGO<T> BIAOADCPBLM;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3953A90", Offset = "0x3952690", VA = "0x183953A90", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ArraySegment<T> BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3953670", Offset = "0x3952270", VA = "0x183953670", Slot = "5")]
	public ArraySegment<T> DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class OEBGFPOPFKB<T> : IINNILDHPHN<List<T>>, ICLENGPGIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly DKBHHFMJBBE HJCJIKLNINF;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A300", Offset = "0x3B78F00", VA = "0x183B7A300")]
	public OEBGFPOPFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
	public OEBGFPOPFKB(DKBHHFMJBBE HJCJIKLNINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4005870", Offset = "0x4004470", VA = "0x184005870", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, List<T> BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4001B90", Offset = "0x4000790", VA = "0x184001B90", Slot = "5")]
	public List<T> DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class NNPJLLBDNAO<TElement, TIntermediate, TEnumerator, TCollection> : IINNILDHPHN<TCollection>, ICLENGPGIEJ where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3F50940", Offset = "0x3F4F540", VA = "0x183F50940", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, TCollection BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F4D0", Offset = "0x3F4E0D0", VA = "0x183F4F4D0", Slot = "5")]
	public TCollection DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LOEOBMCMHAO(TCollection KNENCIBJOEN);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate JOBBHNKGDPO();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BGJHDHHBMPP(TIntermediate AJGJFJPCBKM, int PMIDLPOCCEE, TElement BLKAHBIJBJO);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection OJKNFCBJGIJ(TIntermediate JBHALFFAOPK);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected NNPJLLBDNAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class JICNBLDKDCL<TElement, TIntermediate, TCollection> : NNPJLLBDNAO<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD7A0", Offset = "0x3AFC3A0", VA = "0x183AFD7A0", Slot = "6")]
	protected override IEnumerator<TElement> LOEOBMCMHAO(TCollection KNENCIBJOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x32EC4A0", Offset = "0x32EB0A0", VA = "0x1832EC4A0")]
	protected JICNBLDKDCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class KFGKIEDNACO<TElement, TCollection> : JICNBLDKDCL<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected sealed override TCollection OJKNFCBJGIJ(TCollection JBHALFFAOPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class DMNHEBBEBJM<TElement, TCollection> : KFGKIEDNACO<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5062200", Offset = "0x5060E00", VA = "0x185062200", Slot = "7")]
	protected override TCollection JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5062140", Offset = "0x5060D40", VA = "0x185062140", Slot = "8")]
	protected override void BGJHDHHBMPP(TCollection AJGJFJPCBKM, int PMIDLPOCCEE, TElement BLKAHBIJBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class EBEODIFNCLA<T> : NNPJLLBDNAO<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3304430", Offset = "0x3303030", VA = "0x183304430", Slot = "8")]
	protected override void BGJHDHHBMPP(LinkedList<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override LinkedList<T> OJKNFCBJGIJ(LinkedList<T> JBHALFFAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override LinkedList<T> JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x33044E0", Offset = "0x33030E0", VA = "0x1833044E0", Slot = "6")]
	protected override LinkedList<T>.Enumerator LOEOBMCMHAO(LinkedList<T> KNENCIBJOEN)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class FJHMDFKKGOJ<T> : NNPJLLBDNAO<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3304430", Offset = "0x3303030", VA = "0x183304430", Slot = "8")]
	protected override void BGJHDHHBMPP(Queue<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override Queue<T> JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x368BAB0", Offset = "0x368A6B0", VA = "0x18368BAB0", Slot = "6")]
	protected override Queue<T>.Enumerator LOEOBMCMHAO(Queue<T> KNENCIBJOEN)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override Queue<T> OJKNFCBJGIJ(Queue<T> JBHALFFAOPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class DJIJKAKJGCL<T> : NNPJLLBDNAO<T, MBENBLNCDEM<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3304940", Offset = "0x3303540", VA = "0x183304940", Slot = "8")]
	protected override void BGJHDHHBMPP(MBENBLNCDEM<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3304970", Offset = "0x3303570", VA = "0x183304970", Slot = "7")]
	protected override MBENBLNCDEM<T> JOBBHNKGDPO()
	{
		return default(MBENBLNCDEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5057D00", Offset = "0x5056900", VA = "0x185057D00", Slot = "6")]
	protected override Stack<T>.Enumerator LOEOBMCMHAO(Stack<T> KNENCIBJOEN)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5057D60", Offset = "0x5056960", VA = "0x185057D60", Slot = "9")]
	protected override Stack<T> OJKNFCBJGIJ(MBENBLNCDEM<T> JBHALFFAOPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class BBHDAOAMNEE<T> : NNPJLLBDNAO<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3304430", Offset = "0x3303030", VA = "0x183304430", Slot = "8")]
	protected override void BGJHDHHBMPP(HashSet<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override HashSet<T> OJKNFCBJGIJ(HashSet<T> JBHALFFAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override HashSet<T> JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x368BAB0", Offset = "0x368A6B0", VA = "0x18368BAB0", Slot = "6")]
	protected override HashSet<T>.Enumerator LOEOBMCMHAO(HashSet<T> KNENCIBJOEN)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class KLAJHAIGNMN<T> : JICNBLDKDCL<T, MBENBLNCDEM<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3304940", Offset = "0x3303540", VA = "0x183304940", Slot = "8")]
	protected override void BGJHDHHBMPP(MBENBLNCDEM<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3B73F10", Offset = "0x3B72B10", VA = "0x183B73F10", Slot = "9")]
	protected override ReadOnlyCollection<T> OJKNFCBJGIJ(MBENBLNCDEM<T> JBHALFFAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3B73ED0", Offset = "0x3B72AD0", VA = "0x183B73ED0", Slot = "7")]
	protected override MBENBLNCDEM<T> JOBBHNKGDPO()
	{
		return default(MBENBLNCDEM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class PDLGFGNOJIB<T> : JICNBLDKDCL<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3304430", Offset = "0x3303030", VA = "0x183304430", Slot = "8")]
	protected override void BGJHDHHBMPP(List<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override List<T> JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override IList<T> OJKNFCBJGIJ(List<T> JBHALFFAOPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class NKNGNBAMMMP<T> : JICNBLDKDCL<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3304430", Offset = "0x3303030", VA = "0x183304430", Slot = "8")]
	protected override void BGJHDHHBMPP(List<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override List<T> JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override ICollection<T> OJKNFCBJGIJ(List<T> JBHALFFAOPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class EBNAKGODMIJ<T> : JICNBLDKDCL<T, MBENBLNCDEM<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3304940", Offset = "0x3303540", VA = "0x183304940", Slot = "8")]
	protected override void BGJHDHHBMPP(MBENBLNCDEM<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3304970", Offset = "0x3303570", VA = "0x183304970", Slot = "7")]
	protected override MBENBLNCDEM<T> JOBBHNKGDPO()
	{
		return default(MBENBLNCDEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x33049B0", Offset = "0x33035B0", VA = "0x1833049B0", Slot = "9")]
	protected override IEnumerable<T> OJKNFCBJGIJ(MBENBLNCDEM<T> JBHALFFAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x32F9EF0", Offset = "0x32F8AF0", VA = "0x1832F9EF0")]
	public EBNAKGODMIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class NHHHMOHLAOG<TKey, TElement> : IINNILDHPHN<IGrouping<TKey, TElement>>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB230", Offset = "0x3EF9E30", VA = "0x183EFB230", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, IGrouping<TKey, TElement> BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3EFAF30", Offset = "0x3EF9B30", VA = "0x183EFAF30", Slot = "5")]
	public IGrouping<TKey, TElement> DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class CJNMMFGCJCH<TKey, TElement> : IINNILDHPHN<ILookup<TKey, TElement>>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7BB0", Offset = "0x4BC67B0", VA = "0x184BC7BB0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ILookup<TKey, TElement> BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7860", Offset = "0x4BC6460", VA = "0x184BC7860", Slot = "5")]
	public ILookup<TKey, TElement> DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class DPOFBOBLCGA<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey CGGNJKGENIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> AHOIOIMGLMJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey BKEHFHLBEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7BF470", Offset = "0x7BE070", VA = "0x1807BF470")]
	public DPOFBOBLCGA(TKey CGGNJKGENIH, IEnumerable<TElement> AHOIOIMGLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x50735B0", Offset = "0x50721B0", VA = "0x1850735B0", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3391D20", Offset = "0x3390920", VA = "0x183391D20", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class IFBIFCKGJLA<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> JOENMIDHDKD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x37367C0", Offset = "0x37353C0", VA = "0x1837367C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public IFBIFCKGJLA(Dictionary<TKey, IGrouping<TKey, TElement>> JOENMIDHDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x331D4C0", Offset = "0x331C0C0", VA = "0x18331D4C0", Slot = "5")]
	public bool Contains(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x39370B0", Offset = "0x3935CB0", VA = "0x1839370B0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x39370B0", Offset = "0x3935CB0", VA = "0x1839370B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class AOIIDDFDKFA<T> : IINNILDHPHN<T>, ICLENGPGIEJ where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x38E6290", Offset = "0x38E4E90", VA = "0x1838E6290", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x38E6010", Offset = "0x38E4C10", VA = "0x1838E6010", Slot = "5")]
	public T DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public AOIIDDFDKFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class ODPNCODBDAK : IINNILDHPHN<IEnumerable>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly IINNILDHPHN<IEnumerable> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6A51C80", Offset = "0x6A50880", VA = "0x186A51C80", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, IEnumerable BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6A51A30", Offset = "0x6A50630", VA = "0x186A51A30", Slot = "5")]
	public IEnumerable DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ODPNCODBDAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class NGNNIJAECLE : IINNILDHPHN<ICollection>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly IINNILDHPHN<ICollection> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FDA0", Offset = "0x6A4E9A0", VA = "0x186A4FDA0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ICollection BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FB50", Offset = "0x6A4E750", VA = "0x186A4FB50", Slot = "5")]
	public ICollection DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NGNNIJAECLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class FKOOIHAICPE : IINNILDHPHN<IList>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly IINNILDHPHN<IList> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6A46360", Offset = "0x6A44F60", VA = "0x186A46360", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, IList BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6A46110", Offset = "0x6A44D10", VA = "0x186A46110", Slot = "5")]
	public IList DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FKOOIHAICPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class EDLNJGLOIPJ<T> : JICNBLDKDCL<T, MBENBLNCDEM<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x330CD30", Offset = "0x330B930", VA = "0x18330CD30", Slot = "8")]
	protected override void BGJHDHHBMPP(MBENBLNCDEM<T> AJGJFJPCBKM, int PMIDLPOCCEE, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3304970", Offset = "0x3303570", VA = "0x183304970", Slot = "7")]
	protected override MBENBLNCDEM<T> JOBBHNKGDPO()
	{
		return default(MBENBLNCDEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x330CD60", Offset = "0x330B960", VA = "0x18330CD60", Slot = "9")]
	protected override IReadOnlyList<T> OJKNFCBJGIJ(MBENBLNCDEM<T> JBHALFFAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x32F9820", Offset = "0x32F8420", VA = "0x1832F9820")]
	public EDLNJGLOIPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class NBHGOCGMGOA
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DF20", Offset = "0x6A4CB20", VA = "0x186A4DF20")]
	public static DateTime AONGAGICJPC(DateTime ELJAFDHADDO)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class NGNNBMMGPMG : IINNILDHPHN<DateTime>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly IINNILDHPHN<DateTime> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F320", Offset = "0x6A4DF20", VA = "0x186A4F320", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, DateTime BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E610", Offset = "0x6A4D210", VA = "0x186A4E610", Slot = "5")]
	public DateTime DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NGNNBMMGPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class GBLCDHCNLJA : IINNILDHPHN<DateTimeOffset>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly IINNILDHPHN<DateTimeOffset> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6A47780", Offset = "0x6A46380", VA = "0x186A47780", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, DateTimeOffset BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6A46B60", Offset = "0x6A45760", VA = "0x186A46B60", Slot = "5")]
	public DateTimeOffset DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public GBLCDHCNLJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class DHGNLKAIPNB : IINNILDHPHN<TimeSpan>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly IINNILDHPHN<TimeSpan> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] FIPLHFJPJED;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6A44F10", Offset = "0x6A43B10", VA = "0x186A44F10", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, TimeSpan BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6A44600", Offset = "0x6A43200", VA = "0x186A44600", Slot = "5")]
	public TimeSpan DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public DHGNLKAIPNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class KNDAAKGPJEB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : IINNILDHPHN<TDictionary>, ICLENGPGIEJ where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C7C0", Offset = "0x3B7B3C0", VA = "0x183B7C7C0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, TDictionary BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BF40", Offset = "0x3B7AB40", VA = "0x183B7BF40", Slot = "5")]
	public TDictionary DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LOEOBMCMHAO(TDictionary KNENCIBJOEN);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate JOBBHNKGDPO();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BGJHDHHBMPP(TIntermediate AJGJFJPCBKM, int PMIDLPOCCEE, TKey CGGNJKGENIH, TValue BLKAHBIJBJO);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary OJKNFCBJGIJ(TIntermediate JBHALFFAOPK);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected KNDAAKGPJEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class KBLBKICPBFP<TKey, TValue, TIntermediate, TDictionary> : KNDAAKGPJEB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3B65430", Offset = "0x3B64030", VA = "0x183B65430", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> LOEOBMCMHAO(TDictionary KNENCIBJOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class EDNNFKIGNLC<TKey, TValue, TDictionary> : KBLBKICPBFP<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override TDictionary OJKNFCBJGIJ(TDictionary JBHALFFAOPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class ICBAJIBDBJA<TKey, TValue> : KNDAAKGPJEB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3929DE0", Offset = "0x39289E0", VA = "0x183929DE0", Slot = "8")]
	protected override void BGJHDHHBMPP(Dictionary<TKey, TValue> AJGJFJPCBKM, int PMIDLPOCCEE, TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override Dictionary<TKey, TValue> OJKNFCBJGIJ(Dictionary<TKey, TValue> JBHALFFAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override Dictionary<TKey, TValue> JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3929ED0", Offset = "0x3928AD0", VA = "0x183929ED0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator LOEOBMCMHAO(Dictionary<TKey, TValue> KNENCIBJOEN)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x32EB750", Offset = "0x32EA350", VA = "0x1832EB750")]
	public ICBAJIBDBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class MGBBIJCFMGN<TKey, TValue, TDictionary> : EDNNFKIGNLC<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D960", Offset = "0x3E1C560", VA = "0x183E1D960", Slot = "8")]
	protected override void BGJHDHHBMPP(TDictionary AJGJFJPCBKM, int PMIDLPOCCEE, TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3131930", Offset = "0x3130530", VA = "0x183131930", Slot = "7")]
	protected override TDictionary JOBBHNKGDPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class EMDBMKGBFLF<TKey, TValue> : KBLBKICPBFP<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x334A120", Offset = "0x3348D20", VA = "0x18334A120", Slot = "8")]
	protected override void BGJHDHHBMPP(Dictionary<TKey, TValue> AJGJFJPCBKM, int PMIDLPOCCEE, TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override Dictionary<TKey, TValue> JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override IDictionary<TKey, TValue> OJKNFCBJGIJ(Dictionary<TKey, TValue> JBHALFFAOPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class PAFBKIHPNHC<TKey, TValue> : EDNNFKIGNLC<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x334A120", Offset = "0x3348D20", VA = "0x18334A120", Slot = "8")]
	protected override void BGJHDHHBMPP(SortedList<TKey, TValue> AJGJFJPCBKM, int PMIDLPOCCEE, TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override SortedList<TKey, TValue> JOBBHNKGDPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class KBJFGLJJKAK<TKey, TValue> : KNDAAKGPJEB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x334A120", Offset = "0x3348D20", VA = "0x18334A120", Slot = "8")]
	protected override void BGJHDHHBMPP(SortedDictionary<TKey, TValue> AJGJFJPCBKM, int PMIDLPOCCEE, TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x8B8460", Offset = "0x8B7060", VA = "0x1808B8460", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> OJKNFCBJGIJ(SortedDictionary<TKey, TValue> JBHALFFAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3304470", Offset = "0x3303070", VA = "0x183304470", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> JOBBHNKGDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3929F40", Offset = "0x3928B40", VA = "0x183929F40", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator LOEOBMCMHAO(SortedDictionary<TKey, TValue> KNENCIBJOEN)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class JMBEIGALJKM<T> : IINNILDHPHN<T>, ICLENGPGIEJ where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E2D0", Offset = "0x3B0CED0", VA = "0x183B0E2D0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E030", Offset = "0x3B0CC30", VA = "0x183B0E030", Slot = "5")]
	public T DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public JMBEIGALJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class CNAINGDOEEF : IINNILDHPHN<IDictionary>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly IINNILDHPHN<IDictionary> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6A43E40", Offset = "0x6A42A40", VA = "0x186A43E40", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, IDictionary BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6A43C10", Offset = "0x6A42810", VA = "0x186A43C10", Slot = "5")]
	public IDictionary DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public CNAINGDOEEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class LGPELLMAFCE : IINNILDHPHN<object>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void KLGOFICNEHK(object OLDCJHCMABI, CIGBOBFPDPM EDIOJDLAEAK, object BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly IDAILIKOBPP<KeyValuePair<object, KLGOFICNEHK>> ILHECBGIMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly AODINAOIEAE[] IGLIEBICOHF;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DA70", Offset = "0x6A4C670", VA = "0x186A4DA70")]
	public LGPELLMAFCE(params AODINAOIEAE[] IGLIEBICOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D0B0", Offset = "0x6A4BCB0", VA = "0x186A4D0B0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, object BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D020", Offset = "0x6A4BC20", VA = "0x186A4D020", Slot = "5")]
	public object DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class IEJAPEHPLKA
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A250", Offset = "0x6A48E50", VA = "0x186A4A250")]
	public static object IAIMODKHBHJ(Type CJEAJMFMNNJ, [Out] bool CCNAMGNACAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6A49960", Offset = "0x6A48560", VA = "0x186A49960")]
	public static object CHFFJBLPEOF(Type CJEAJMFMNNJ, [Out] bool CCNAMGNACAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class NIADOJMOFAI<T> : IINNILDHPHN<T>, ICLENGPGIEJ, JGIIGIFKJHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class KLFOKNFNLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KLFOKNFNLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3B74C10", Offset = "0x3B73810", VA = "0x183B74C10")]
		internal bool NFICIOLLBBG(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class HEADDDJGDHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HEADDDJGDHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x380C250", Offset = "0x380AE50", VA = "0x18380C250")]
		internal bool JDLFJGDPHPM(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class CFPOKCODGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public FMHEOADFBDD<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public CFPOKCODGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4AEEAB0", Offset = "0x4AED6B0", VA = "0x184AEEAB0")]
		internal void FAEEOBDFNFM(CIGBOBFPDPM writer, T value, AODINAOIEAE _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class AJJIBFCLNFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public EMGNFONBPHF<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public AJJIBFCLNFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x37DAA00", Offset = "0x37D9600", VA = "0x1837DAA00")]
		internal T FAPILDOOMHK(FJGBFMJLMMP reader, AODINAOIEAE _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly JNLBDHBFAGF<T> IEMFBEMHDGP;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> PHLIPNHBEGC;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly FMHEOADFBDD<T> AFOABCDBIMD;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly EMGNFONBPHF<T> EECDNHJOKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool JMKHPBNHHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly FMHEOADFBDD<T> LINHPDLFOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly EMGNFONBPHF<T> FDNJLOFDACI;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3F02BB0", Offset = "0x3F017B0", VA = "0x183F02BB0")]
	static NIADOJMOFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3F099E0", Offset = "0x3F085E0", VA = "0x183F099E0")]
	public NIADOJMOFAI(bool JMKHPBNHHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3F01BA0", Offset = "0x3F007A0", VA = "0x183F01BA0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3F00D30", Offset = "0x3EFF930", VA = "0x183F00D30", Slot = "5")]
	public T DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFD00", Offset = "0x3EFE900", VA = "0x183EFFD00", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, T BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3F02540", Offset = "0x3F01140", VA = "0x183F02540", Slot = "7")]
	public T LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class JAIOBAKHCMM<T> : IINNILDHPHN<T[,]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF620", Offset = "0x3ADE220", VA = "0x183ADF620", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T[,] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF2F0", Offset = "0x3ADDEF0", VA = "0x183ADF2F0", Slot = "5")]
	public T[,] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public JAIOBAKHCMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class PBIDCDALNAN<T> : IINNILDHPHN<T[,,]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x40F8BD0", Offset = "0x40F77D0", VA = "0x1840F8BD0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T[,,] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x40F8790", Offset = "0x40F7390", VA = "0x1840F8790", Slot = "5")]
	public T[,,] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public PBIDCDALNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class PFNJDHIDAOK<T> : IINNILDHPHN<T[,,,]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x4100B50", Offset = "0x40FF750", VA = "0x184100B50", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T[,,,] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x4100600", Offset = "0x40FF200", VA = "0x184100600", Slot = "5")]
	public T[,,,] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public PFNJDHIDAOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class NMOLHHMLOPK<T> : IINNILDHPHN<T?>, ICLENGPGIEJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F4C2A0", Offset = "0x3F4AEA0", VA = "0x183F4C2A0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F4BDC0", Offset = "0x3F4A9C0", VA = "0x183F4BDC0", Slot = "5")]
	public T? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NMOLHHMLOPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class IJKCJDHEGGD<T> : IINNILDHPHN<T?>, ICLENGPGIEJ where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly IINNILDHPHN<T> POJBEOLFOGK;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public IJKCJDHEGGD(IINNILDHPHN<T> POJBEOLFOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x394D140", Offset = "0x394BD40", VA = "0x18394D140", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, T? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x394C100", Offset = "0x394AD00", VA = "0x18394C100", Slot = "5")]
	public T? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class OPJKMBDGNOE : IINNILDHPHN<sbyte>, ICLENGPGIEJ, JGIIGIFKJHI<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly OPJKMBDGNOE IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A52870", Offset = "0x6A51470", VA = "0x186A52870", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, sbyte BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A52820", Offset = "0x6A51420", VA = "0x186A52820", Slot = "5")]
	public sbyte DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A527B0", Offset = "0x6A513B0", VA = "0x186A527B0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, sbyte BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A528D0", Offset = "0x6A514D0", VA = "0x186A528D0", Slot = "7")]
	public sbyte LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public OPJKMBDGNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class PMIJEJAFAMG : IINNILDHPHN<sbyte?>, ICLENGPGIEJ, JGIIGIFKJHI<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly PMIJEJAFAMG IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A535D0", Offset = "0x6A521D0", VA = "0x186A535D0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, sbyte? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A53520", Offset = "0x6A52120", VA = "0x186A53520", Slot = "5")]
	public sbyte? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A53460", Offset = "0x6A52060", VA = "0x186A53460", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, sbyte? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A53690", Offset = "0x6A52290", VA = "0x186A53690", Slot = "7")]
	public sbyte? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public PMIJEJAFAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class JBLBKKOMMEJ : IINNILDHPHN<sbyte[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly JBLBKKOMMEJ IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B3E0", Offset = "0x6A49FE0", VA = "0x186A4B3E0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, sbyte[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B250", Offset = "0x6A49E50", VA = "0x186A4B250", Slot = "5")]
	public sbyte[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public JBLBKKOMMEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class AHHPJBMOPHK : IINNILDHPHN<short>, ICLENGPGIEJ, JGIIGIFKJHI<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly AHHPJBMOPHK IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A42770", Offset = "0x6A41370", VA = "0x186A42770", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, short BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A42720", Offset = "0x6A41320", VA = "0x186A42720", Slot = "5")]
	public short DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A426B0", Offset = "0x6A412B0", VA = "0x186A426B0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, short BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A427D0", Offset = "0x6A413D0", VA = "0x186A427D0", Slot = "7")]
	public short LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public AHHPJBMOPHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class NCGNJLJHHEG : IINNILDHPHN<short?>, ICLENGPGIEJ, JGIIGIFKJHI<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly NCGNJLJHHEG IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E150", Offset = "0x6A4CD50", VA = "0x186A4E150", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, short? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E0A0", Offset = "0x6A4CCA0", VA = "0x186A4E0A0", Slot = "5")]
	public short? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DFE0", Offset = "0x6A4CBE0", VA = "0x186A4DFE0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, short? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E210", Offset = "0x6A4CE10", VA = "0x186A4E210", Slot = "7")]
	public short? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NCGNJLJHHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class OIHLLKGJJDJ : IINNILDHPHN<short[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly OIHLLKGJJDJ IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A52140", Offset = "0x6A50D40", VA = "0x186A52140", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, short[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A51FB0", Offset = "0x6A50BB0", VA = "0x186A51FB0", Slot = "5")]
	public short[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public OIHLLKGJJDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class ICHFCLKFPCJ : IINNILDHPHN<int>, ICLENGPGIEJ, JGIIGIFKJHI<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly ICHFCLKFPCJ IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A493F0", Offset = "0x6A47FF0", VA = "0x186A493F0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, int BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A493A0", Offset = "0x6A47FA0", VA = "0x186A493A0", Slot = "5")]
	public int DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A49330", Offset = "0x6A47F30", VA = "0x186A49330", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, int BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A49450", Offset = "0x6A48050", VA = "0x186A49450", Slot = "7")]
	public int LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ICHFCLKFPCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class EKCMCKJMFIJ : IINNILDHPHN<int?>, ICLENGPGIEJ, JGIIGIFKJHI<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly EKCMCKJMFIJ IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A45B60", Offset = "0x6A44760", VA = "0x186A45B60", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, int? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A45AB0", Offset = "0x6A446B0", VA = "0x186A45AB0", Slot = "5")]
	public int? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A459F0", Offset = "0x6A445F0", VA = "0x186A459F0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, int? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A45C20", Offset = "0x6A44820", VA = "0x186A45C20", Slot = "7")]
	public int? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public EKCMCKJMFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class IAEKFMLDJFK : IINNILDHPHN<int[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly IAEKFMLDJFK IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A48E40", Offset = "0x6A47A40", VA = "0x186A48E40", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, int[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A48CB0", Offset = "0x6A478B0", VA = "0x186A48CB0", Slot = "5")]
	public int[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public IAEKFMLDJFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class NEBLKMJKNNF : IINNILDHPHN<long>, ICLENGPGIEJ, JGIIGIFKJHI<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly NEBLKMJKNNF IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E470", Offset = "0x6A4D070", VA = "0x186A4E470", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, long BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E420", Offset = "0x6A4D020", VA = "0x186A4E420", Slot = "5")]
	public long DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E3B0", Offset = "0x6A4CFB0", VA = "0x186A4E3B0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, long BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E4D0", Offset = "0x6A4D0D0", VA = "0x186A4E4D0", Slot = "7")]
	public long LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NEBLKMJKNNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class JIOHJIPIABG : IINNILDHPHN<long?>, ICLENGPGIEJ, JGIIGIFKJHI<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly JIOHJIPIABG IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B710", Offset = "0x6A4A310", VA = "0x186A4B710", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, long? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B650", Offset = "0x6A4A250", VA = "0x186A4B650", Slot = "5")]
	public long? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B590", Offset = "0x6A4A190", VA = "0x186A4B590", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, long? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B7D0", Offset = "0x6A4A3D0", VA = "0x186A4B7D0", Slot = "7")]
	public long? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public JIOHJIPIABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class KBLIDGPHDLK : IINNILDHPHN<long[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly KBLIDGPHDLK IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BB20", Offset = "0x6A4A720", VA = "0x186A4BB20", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, long[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B990", Offset = "0x6A4A590", VA = "0x186A4B990", Slot = "5")]
	public long[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public KBLIDGPHDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class DHGMOBINODN : IINNILDHPHN<byte>, ICLENGPGIEJ, JGIIGIFKJHI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly DHGMOBINODN IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A44460", Offset = "0x6A43060", VA = "0x186A44460", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, byte BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A44410", Offset = "0x6A43010", VA = "0x186A44410", Slot = "5")]
	public byte DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A443A0", Offset = "0x6A42FA0", VA = "0x186A443A0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, byte BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A444C0", Offset = "0x6A430C0", VA = "0x186A444C0", Slot = "7")]
	public byte LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public DHGMOBINODN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class IMIAECAAEAB : IINNILDHPHN<byte?>, ICLENGPGIEJ, JGIIGIFKJHI<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly IMIAECAAEAB IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A4AFF0", Offset = "0x6A49BF0", VA = "0x186A4AFF0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, byte? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A4AF40", Offset = "0x6A49B40", VA = "0x186A4AF40", Slot = "5")]
	public byte? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A4AE80", Offset = "0x6A49A80", VA = "0x186A4AE80", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, byte? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B0B0", Offset = "0x6A49CB0", VA = "0x186A4B0B0", Slot = "7")]
	public byte? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public IMIAECAAEAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class PLAMEOJJDJH : IINNILDHPHN<ushort>, ICLENGPGIEJ, JGIIGIFKJHI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly PLAMEOJJDJH IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6A52EF0", Offset = "0x6A51AF0", VA = "0x186A52EF0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ushort BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6A52EA0", Offset = "0x6A51AA0", VA = "0x186A52EA0", Slot = "5")]
	public ushort DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6A52E30", Offset = "0x6A51A30", VA = "0x186A52E30", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, ushort BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6A52F50", Offset = "0x6A51B50", VA = "0x186A52F50", Slot = "7")]
	public ushort LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public PLAMEOJJDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class PLGFPEIIFNG : IINNILDHPHN<ushort?>, ICLENGPGIEJ, JGIIGIFKJHI<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly PLGFPEIIFNG IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6A53200", Offset = "0x6A51E00", VA = "0x186A53200", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ushort? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6A53150", Offset = "0x6A51D50", VA = "0x186A53150", Slot = "5")]
	public ushort? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6A53090", Offset = "0x6A51C90", VA = "0x186A53090", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, ushort? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6A532C0", Offset = "0x6A51EC0", VA = "0x186A532C0", Slot = "7")]
	public ushort? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public PLGFPEIIFNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IBBJEMMINCA : IINNILDHPHN<ushort[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly IBBJEMMINCA IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6A49180", Offset = "0x6A47D80", VA = "0x186A49180", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ushort[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6A48FF0", Offset = "0x6A47BF0", VA = "0x186A48FF0", Slot = "5")]
	public ushort[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public IBBJEMMINCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class OPFALFEMDCK : IINNILDHPHN<uint>, ICLENGPGIEJ, JGIIGIFKJHI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly OPFALFEMDCK IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6A52610", Offset = "0x6A51210", VA = "0x186A52610", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, uint BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6A525C0", Offset = "0x6A511C0", VA = "0x186A525C0", Slot = "5")]
	public uint DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6A52550", Offset = "0x6A51150", VA = "0x186A52550", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, uint BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6A52670", Offset = "0x6A51270", VA = "0x186A52670", Slot = "7")]
	public uint LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public OPFALFEMDCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class BICLAAFIKON : IINNILDHPHN<uint?>, ICLENGPGIEJ, JGIIGIFKJHI<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly BICLAAFIKON IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6A42C60", Offset = "0x6A41860", VA = "0x186A42C60", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, uint? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6A42BB0", Offset = "0x6A417B0", VA = "0x186A42BB0", Slot = "5")]
	public uint? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6A42AF0", Offset = "0x6A416F0", VA = "0x186A42AF0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, uint? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6A42D20", Offset = "0x6A41920", VA = "0x186A42D20", Slot = "7")]
	public uint? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public BICLAAFIKON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class DIAOLHOONBF : IINNILDHPHN<uint[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly DIAOLHOONBF IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6A455E0", Offset = "0x6A441E0", VA = "0x186A455E0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, uint[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6A45450", Offset = "0x6A44050", VA = "0x186A45450", Slot = "5")]
	public uint[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public DIAOLHOONBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class DIOCGDOKEBP : IINNILDHPHN<ulong>, ICLENGPGIEJ, JGIIGIFKJHI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly DIOCGDOKEBP IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x6A45850", Offset = "0x6A44450", VA = "0x186A45850", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ulong BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6A45800", Offset = "0x6A44400", VA = "0x186A45800", Slot = "5")]
	public ulong DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6A45790", Offset = "0x6A44390", VA = "0x186A45790", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, ulong BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6A458B0", Offset = "0x6A444B0", VA = "0x186A458B0", Slot = "7")]
	public ulong LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public DIOCGDOKEBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class MMFIMDMPLBF : IINNILDHPHN<ulong?>, ICLENGPGIEJ, JGIIGIFKJHI<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly MMFIMDMPLBF IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DCA0", Offset = "0x6A4C8A0", VA = "0x186A4DCA0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ulong? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DBE0", Offset = "0x6A4C7E0", VA = "0x186A4DBE0", Slot = "5")]
	public ulong? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DB20", Offset = "0x6A4C720", VA = "0x186A4DB20", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, ulong? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DD60", Offset = "0x6A4C960", VA = "0x186A4DD60", Slot = "7")]
	public ulong? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public MMFIMDMPLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class IJBGMINHOMN : IINNILDHPHN<ulong[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly IJBGMINHOMN IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4ACD0", Offset = "0x6A498D0", VA = "0x186A4ACD0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ulong[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4AB40", Offset = "0x6A49740", VA = "0x186A4AB40", Slot = "5")]
	public ulong[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public IJBGMINHOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class GONOJODIMIC : IINNILDHPHN<float>, ICLENGPGIEJ, JGIIGIFKJHI<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly GONOJODIMIC IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6A487C0", Offset = "0x6A473C0", VA = "0x186A487C0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, float BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6A48770", Offset = "0x6A47370", VA = "0x186A48770", Slot = "5")]
	public float DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6A48700", Offset = "0x6A47300", VA = "0x186A48700", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, float BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6A48820", Offset = "0x6A47420", VA = "0x186A48820", Slot = "7")]
	public float LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public GONOJODIMIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class KKMCANJBLKP : IINNILDHPHN<float?>, ICLENGPGIEJ, JGIIGIFKJHI<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly KKMCANJBLKP IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C310", Offset = "0x6A4AF10", VA = "0x186A4C310", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, float? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C260", Offset = "0x6A4AE60", VA = "0x186A4C260", Slot = "5")]
	public float? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C1A0", Offset = "0x6A4ADA0", VA = "0x186A4C1A0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, float? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C3D0", Offset = "0x6A4AFD0", VA = "0x186A4C3D0", Slot = "7")]
	public float? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public KKMCANJBLKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class EOPCALFNAGA : IINNILDHPHN<float[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly EOPCALFNAGA IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6A45F50", Offset = "0x6A44B50", VA = "0x186A45F50", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, float[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6A45DC0", Offset = "0x6A449C0", VA = "0x186A45DC0", Slot = "5")]
	public float[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public EOPCALFNAGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class FPOPNCEHNMN : IINNILDHPHN<double>, ICLENGPGIEJ, JGIIGIFKJHI<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly FPOPNCEHNMN IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6A469C0", Offset = "0x6A455C0", VA = "0x186A469C0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, double BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6A46970", Offset = "0x6A45570", VA = "0x186A46970", Slot = "5")]
	public double DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6A46900", Offset = "0x6A45500", VA = "0x186A46900", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, double BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6A46A20", Offset = "0x6A45620", VA = "0x186A46A20", Slot = "7")]
	public double LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FPOPNCEHNMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class LAKOPOBJBAM : IINNILDHPHN<double?>, ICLENGPGIEJ, JGIIGIFKJHI<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly LAKOPOBJBAM IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CB90", Offset = "0x6A4B790", VA = "0x186A4CB90", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, double? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CAD0", Offset = "0x6A4B6D0", VA = "0x186A4CAD0", Slot = "5")]
	public double? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CA10", Offset = "0x6A4B610", VA = "0x186A4CA10", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, double? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CC50", Offset = "0x6A4B850", VA = "0x186A4CC50", Slot = "7")]
	public double? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public LAKOPOBJBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class KNOGKKCIKPA : IINNILDHPHN<double[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly KNOGKKCIKPA IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C850", Offset = "0x6A4B450", VA = "0x186A4C850", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, double[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C6C0", Offset = "0x6A4B2C0", VA = "0x186A4C6C0", Slot = "5")]
	public double[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public KNOGKKCIKPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class ONMDGKAHPHO : IINNILDHPHN<bool>, ICLENGPGIEJ, JGIIGIFKJHI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly ONMDGKAHPHO IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6A523B0", Offset = "0x6A50FB0", VA = "0x186A523B0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, bool BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6A52360", Offset = "0x6A50F60", VA = "0x186A52360", Slot = "5")]
	public bool DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6A522F0", Offset = "0x6A50EF0", VA = "0x186A522F0", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, bool BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6A52410", Offset = "0x6A51010", VA = "0x186A52410", Slot = "7")]
	public bool LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ONMDGKAHPHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class ICNMKNNHHOI : IINNILDHPHN<bool?>, ICLENGPGIEJ, JGIIGIFKJHI<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly ICNMKNNHHOI IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6A49700", Offset = "0x6A48300", VA = "0x186A49700", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, bool? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6A49650", Offset = "0x6A48250", VA = "0x186A49650", Slot = "5")]
	public bool? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6A49590", Offset = "0x6A48190", VA = "0x186A49590", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, bool? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6A497C0", Offset = "0x6A483C0", VA = "0x186A497C0", Slot = "7")]
	public bool? LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ICNMKNNHHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class HFFBHGMADBL : IINNILDHPHN<bool[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly HFFBHGMADBL IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6A48AF0", Offset = "0x6A476F0", VA = "0x186A48AF0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, bool[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6A48960", Offset = "0x6A47560", VA = "0x186A48960", Slot = "5")]
	public bool[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public HFFBHGMADBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class NLBIHADHAIE : IINNILDHPHN<object>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly IINNILDHPHN<object> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> FKFPCMGPCFP;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6A50980", Offset = "0x6A4F580", VA = "0x186A50980", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, object BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6A50540", Offset = "0x6A4F140", VA = "0x186A50540", Slot = "5")]
	public object DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NLBIHADHAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class FOBKPOCKLHP : IINNILDHPHN<byte[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly IINNILDHPHN<byte[]> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6A467C0", Offset = "0x6A453C0", VA = "0x186A467C0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, byte[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6A46710", Offset = "0x6A45310", VA = "0x186A46710", Slot = "5")]
	public byte[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FOBKPOCKLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class GIDKKLKCAMI : IINNILDHPHN<ArraySegment<byte>>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly IINNILDHPHN<ArraySegment<byte>> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6A48370", Offset = "0x6A46F70", VA = "0x186A48370", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, ArraySegment<byte> BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6A48260", Offset = "0x6A46E60", VA = "0x186A48260", Slot = "5")]
	public ArraySegment<byte> DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public GIDKKLKCAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class AIEGOECNHBL : IINNILDHPHN<string>, ICLENGPGIEJ, JGIIGIFKJHI<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly IINNILDHPHN<string> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6A429C0", Offset = "0x6A415C0", VA = "0x186A429C0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, string BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6A42970", Offset = "0x6A41570", VA = "0x186A42970", Slot = "5")]
	public string DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6A42910", Offset = "0x6A41510", VA = "0x186A42910", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, string BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6A42A20", Offset = "0x6A41620", VA = "0x186A42A20", Slot = "7")]
	public string LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public AIEGOECNHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class NINIPBMJLBK : IINNILDHPHN<string[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly NINIPBMJLBK IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6A50390", Offset = "0x6A4EF90", VA = "0x186A50390", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, string[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6A501C0", Offset = "0x6A4EDC0", VA = "0x186A501C0", Slot = "5")]
	public string[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NINIPBMJLBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class GFLGLCJPNAP : IINNILDHPHN<char>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly GFLGLCJPNAP IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6A48120", Offset = "0x6A46D20", VA = "0x186A48120", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, char BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6A480B0", Offset = "0x6A46CB0", VA = "0x186A480B0", Slot = "5")]
	public char DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public GFLGLCJPNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class CCEIGBCOBGG : IINNILDHPHN<char?>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly CCEIGBCOBGG IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6A43570", Offset = "0x6A42170", VA = "0x186A43570", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, char? BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6A43450", Offset = "0x6A42050", VA = "0x186A43450", Slot = "5")]
	public char? DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public CCEIGBCOBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class ADDHGFPOGFL : IINNILDHPHN<char[]>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly ADDHGFPOGFL IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6A42480", Offset = "0x6A41080", VA = "0x186A42480", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, char[] BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6A422C0", Offset = "0x6A40EC0", VA = "0x186A422C0", Slot = "5")]
	public char[] DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ADDHGFPOGFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class PKIFPFDGJEC : IINNILDHPHN<Guid>, ICLENGPGIEJ, JGIIGIFKJHI<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly IINNILDHPHN<Guid> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6A52BE0", Offset = "0x6A517E0", VA = "0x186A52BE0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, Guid BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6A52B50", Offset = "0x6A51750", VA = "0x186A52B50", Slot = "5")]
	public Guid DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6A52A10", Offset = "0x6A51610", VA = "0x186A52A10", Slot = "6")]
	public void DCBEGMPFBJC(CIGBOBFPDPM EDIOJDLAEAK, Guid BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6A52D10", Offset = "0x6A51910", VA = "0x186A52D10", Slot = "7")]
	public Guid LPNNNJIKEGB(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public PKIFPFDGJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class KDMJCNNPFMN : IINNILDHPHN<decimal>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly IINNILDHPHN<decimal> IDMMFBJNCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool HKMCINHPLAN;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5298150", Offset = "0x5296D50", VA = "0x185298150")]
	public KDMJCNNPFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x18283A0", Offset = "0x1826FA0", VA = "0x1818283A0")]
	public KDMJCNNPFMN(bool HKMCINHPLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BF70", Offset = "0x6A4AB70", VA = "0x186A4BF70", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, decimal BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BCD0", Offset = "0x6A4A8D0", VA = "0x186A4BCD0", Slot = "5")]
	public decimal DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class BNOPLCKFOMN : IINNILDHPHN<Uri>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly IINNILDHPHN<Uri> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6A432F0", Offset = "0x6A41EF0", VA = "0x186A432F0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, Uri BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6A43230", Offset = "0x6A41E30", VA = "0x186A43230", Slot = "5")]
	public Uri DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public BNOPLCKFOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class CEFGKPDGFOL : IINNILDHPHN<Version>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly IINNILDHPHN<Version> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6A437B0", Offset = "0x6A423B0", VA = "0x186A437B0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, Version BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6A436F0", Offset = "0x6A422F0", VA = "0x186A436F0", Slot = "5")]
	public Version DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public CEFGKPDGFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class LFLAFDEJFDL<TKey, TValue> : IINNILDHPHN<KeyValuePair<TKey, TValue>>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3C0A270", Offset = "0x3C08E70", VA = "0x183C0A270", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, KeyValuePair<TKey, TValue> BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3C09F40", Offset = "0x3C08B40", VA = "0x183C09F40", Slot = "5")]
	public KeyValuePair<TKey, TValue> DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class GJPOBAEPIFO : IINNILDHPHN<StringBuilder>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly IINNILDHPHN<StringBuilder> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6A485E0", Offset = "0x6A471E0", VA = "0x186A485E0", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, StringBuilder BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6A48520", Offset = "0x6A47120", VA = "0x186A48520", Slot = "5")]
	public StringBuilder DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public GJPOBAEPIFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class CHEMPCMNDGC : IINNILDHPHN<BitArray>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly IINNILDHPHN<BitArray> IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6A43A70", Offset = "0x6A42670", VA = "0x186A43A70", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, BitArray BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6A438F0", Offset = "0x6A424F0", VA = "0x186A438F0", Slot = "5")]
	public BitArray DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public CHEMPCMNDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class BMDFHPFLFPF : IINNILDHPHN<Type>, ICLENGPGIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly BMDFHPFLFPF IDMMFBJNCBP;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex BHDFNBMIPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool GEAPENMOHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool NCNOKJHPJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool EPMGIPKBHJB;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6A43210", Offset = "0x6A41E10", VA = "0x186A43210")]
	public BMDFHPFLFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x602EBB0", Offset = "0x602D7B0", VA = "0x18602EBB0")]
	public BMDFHPFLFPF(bool GEAPENMOHDI, bool NCNOKJHPJJE, bool EPMGIPKBHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A43010", Offset = "0x6A41C10", VA = "0x186A43010", Slot = "4")]
	public void GAPNIKJAJOO(CIGBOBFPDPM EDIOJDLAEAK, Type BLKAHBIJBJO, AODINAOIEAE CNBMEDPDMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A42EC0", Offset = "0x6A41AC0", VA = "0x186A42EC0", Slot = "5")]
	public Type DPCADENMEMJ(FJGBFMJLMMP ALHICDKDPIA, AODINAOIEAE CNBMEDPDMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class LAMJEBGANJF
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] HEEAAELCHLK;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly LDOJPBBOHCM BDMAMHDDGAJ;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CE10", Offset = "0x6A4BA10", VA = "0x186A4CE10")]
	static LAMJEBGANJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class GDPJKFKPLNF
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] BDOKMFIEEOA;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly LDOJPBBOHCM OLGKLCHFAJB;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A47EA0", Offset = "0x6A46AA0", VA = "0x186A47EA0")]
	static GDPJKFKPLNF()
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
