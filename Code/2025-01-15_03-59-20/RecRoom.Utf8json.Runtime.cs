using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class FOMLMKLPMMA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x232B520", Offset = "0x232A920", VA = "0x18232B520")]
	public static bool IIPDEEPEEIL(this TypeInfo IFBDJLKPHIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class BBIMBOBMGBN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type PNGGPJDNIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PCLFPGCMEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
	public BBIMBOBMGBN(Type IFGGJICFJKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void BPCAMHJDKJG<T>(LKMCFLGDNPK EEKKIBDAGAJ, T HCPAOILCJCB, CLCGJCMKMCJ IJLKKICNIBC);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate T AAPBCAPDAHK<T>(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ IJLKKICNIBC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CPNGADLNAJB
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CPEEKDGOLEA<T> : CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DGFKOFNBIKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, T HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BEPEBMPOFAL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JJACKCFHONC
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x30D69E0", Offset = "0x30D5DE0", VA = "0x1830D69E0")]
	public static string OFEJDBEIMGC<T>(this CPEEKDGOLEA<T> HJDDCNEPPKJ, T HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPEEKDGOLEA<T> OFFGFBOCALI<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KCPEEBDEFAK
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x310D3C0", Offset = "0x310C7C0", VA = "0x18310D3C0")]
	public static CPEEKDGOLEA<T> GMFOJNMLPDI<T>(this CLCGJCMKMCJ IJLKKICNIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A39E50", Offset = "0x7A39250", VA = "0x187A39E50")]
	public static object LIIDCKHCFNL(this CLCGJCMKMCJ IJLKKICNIBC, Type IFBDJLKPHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NFBFNNIKOFC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A3DBB0", Offset = "0x7A3CFB0", VA = "0x187A3DBB0")]
	public NFBFNNIKOFC(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public ref struct BKAFFJDLIHE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class DNHJALGJMFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly byte[] MPAENADABBP;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly byte[] IKCBCIJPNCN;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly byte[] NOAFJIDAENA;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly byte[] OGPONPHPINA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly byte[] GHBNKGCCJIG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly byte[] MMNDBDLJMOO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly byte[] GKDPPDAMKOD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly byte[] DMBKGFFNBGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private ref struct ANLCMJECCEE
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private sealed class EDFPHEGKCBL : ReadOnlySequenceSegment<byte>
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7A340A0", Offset = "0x7A334A0", VA = "0x187A340A0")]
			public EDFPHEGKCBL(ReadOnlyMemory<byte> KAGKKDFEHAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7A33F70", Offset = "0x7A33370", VA = "0x187A33F70")]
			public EDFPHEGKCBL NHPGNDAJLNG(ReadOnlyMemory<byte> KAGKKDFEHAB)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private static class FIFNEHIBNBP
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			[ThreadStatic]
			public static byte[] CELIBNPACII;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			[ThreadStatic]
			public static char[] BCOEGBCLPLJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EDFPHEGKCBL JJJPINFOLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private EDFPHEGKCBL LACNKIEAGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int BMGLCPOPAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int GNJOILPCMAH;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E110", Offset = "0x7A2D510", VA = "0x187A2E110")]
		public void NHPGNDAJLNG([In] ReadOnlySequence<byte> BPLPEMOPIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DFD0", Offset = "0x7A2D3D0", VA = "0x187A2DFD0")]
		public void NHPGNDAJLNG(char ONPHPBMPAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DCF0", Offset = "0x7A2D0F0", VA = "0x187A2DCF0")]
		public ReadOnlySequence<byte> BOMMHKABNJF()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DE20", Offset = "0x7A2D220", VA = "0x187A2DE20")]
		private void HHKCMELGNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E220", Offset = "0x7A2D620", VA = "0x187A2E220")]
		private void OMLBJKLAHCP([In] ReadOnlyMemory<byte> KAGKKDFEHAB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private SequenceReader<byte> KHDMHOKBGBD;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A335E0", Offset = "0x7A329E0", VA = "0x187A335E0")]
	public BKAFFJDLIHE([In] ReadOnlySequence<byte> EGGANFLBKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A307C0", Offset = "0x7A2FBC0", VA = "0x187A307C0")]
	private MHFCBONOCKA BFAGAHCAFCM(string KGGCKPJBIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A334C0", Offset = "0x7A328C0", VA = "0x187A334C0")]
	private MHFCBONOCKA PPIPADGHKDL(string LNICHECHJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A32ED0", Offset = "0x7A322D0", VA = "0x187A32ED0")]
	public void NINEDKBMKCE(int LHBPAMEKCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A32A50", Offset = "0x7A31E50", VA = "0x187A32A50")]
	public HHLCENLOKFF MBJACOJJPJH()
	{
		return default(HHLCENLOKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A31370", Offset = "0x7A30770", VA = "0x187A31370")]
	public void FOFKJAEPPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A30E00", Offset = "0x7A30200", VA = "0x187A30E00")]
	private bool BKLENEBOJMP(ReadOnlySpan<byte> KGGCKPJBIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A30E60", Offset = "0x7A30260", VA = "0x187A30E60")]
	private bool BKLENEBOJMP(byte KGGCKPJBIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A310D0", Offset = "0x7A304D0", VA = "0x187A310D0")]
	private void ENCPFMBDENG(byte KGGCKPJBIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7A31FC0", Offset = "0x7A313C0", VA = "0x187A31FC0")]
	public bool KJIMNCNNJBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A31720", Offset = "0x7A30B20", VA = "0x187A31720")]
	public void GGHDDEEIIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A329F0", Offset = "0x7A31DF0", VA = "0x187A329F0")]
	public bool LMLMJOJINOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A334B0", Offset = "0x7A328B0", VA = "0x187A334B0")]
	public void PDFLGJKBIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A30760", Offset = "0x7A2FB60", VA = "0x187A30760")]
	public bool AIAMEKOLCMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A307B0", Offset = "0x7A2FBB0", VA = "0x187A307B0")]
	public void AKHGHCCAKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7A32A40", Offset = "0x7A31E40", VA = "0x187A32A40")]
	public void MBFACDGBLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A31040", Offset = "0x7A30440", VA = "0x187A31040")]
	public bool ECKEACCNGMD(int ABPDJOGPHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A32690", Offset = "0x7A31A90", VA = "0x187A32690")]
	public bool LBBCEIFEKAF(int ABPDJOGPHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A32F20", Offset = "0x7A32320", VA = "0x187A32F20")]
	private ReadOnlySequence<byte> OGAKOIHCDJI()
	{
		return default(ReadOnlySequence<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A31180", Offset = "0x7A30580", VA = "0x187A31180")]
	private void FNLAGLAJBJK(ANLCMJECCEE FODBDHHLEGI, [In] SequencePosition JHBHKPILHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A32090", Offset = "0x7A31490", VA = "0x187A32090")]
	private void KNKINCEDCKP(ANLCMJECCEE FODBDHHLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A31650", Offset = "0x7A30A50", VA = "0x187A31650")]
	private static int GCDIPELLMDA(byte KENGFOGLPKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A30F70", Offset = "0x7A30370", VA = "0x187A30F70")]
	public ReadOnlySequence<byte> CIPDJNDKLGN()
	{
		return default(ReadOnlySequence<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A323C0", Offset = "0x7A317C0", VA = "0x187A323C0")]
	public string KOPMMAMFAPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A31EE0", Offset = "0x7A312E0", VA = "0x187A31EE0")]
	public string JNHMMJJHDAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A32720", Offset = "0x7A31B20", VA = "0x187A32720")]
	public ReadOnlySequence<byte> LKHGCJODNGM()
	{
		return default(ReadOnlySequence<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A32370", Offset = "0x7A31770", VA = "0x187A32370")]
	public ReadOnlySequence<byte> KOMEIPGMFGO()
	{
		return default(ReadOnlySequence<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A32D10", Offset = "0x7A32110", VA = "0x187A32D10")]
	public bool MOHCDJHKPFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7A319F0", Offset = "0x7A30DF0", VA = "0x187A319F0")]
	private void HDOLIBHJDPN(HHLCENLOKFF CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7A32080", Offset = "0x7A31480", VA = "0x187A32080")]
	public void KJODKALGOPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A31C80", Offset = "0x7A31080", VA = "0x187A31C80")]
	private void IHCIELBLHMH(int KAEAFCFADBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A315A0", Offset = "0x7A309A0", VA = "0x187A315A0")]
	public sbyte FPICPHJBNBD()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A31E30", Offset = "0x7A31230", VA = "0x187A31E30")]
	public short JMDAAOMAFCJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A33400", Offset = "0x7A32800", VA = "0x187A33400")]
	public int OHAJDGIIFAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A32620", Offset = "0x7A31A20", VA = "0x187A32620")]
	public long LALLFPOKHLK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A32C60", Offset = "0x7A32060", VA = "0x187A32C60")]
	public byte MDJCLPGOCGO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A31D80", Offset = "0x7A31180", VA = "0x187A31D80")]
	public ushort JLDGJHHHGGL()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A30EC0", Offset = "0x7A302C0", VA = "0x187A30EC0")]
	public uint CEFIJDLGBBA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7A32E60", Offset = "0x7A32260", VA = "0x187A32E60")]
	public ulong NGNOJHLDHDA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A31BE0", Offset = "0x7A30FE0", VA = "0x187A31BE0")]
	public float ICCJDHOIGBM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A31F20", Offset = "0x7A31320", VA = "0x187A31F20")]
	public double KBIJIEHEEFF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A32440", Offset = "0x7A31840", VA = "0x187A32440")]
	public ReadOnlySequence<byte> LAEBNJEBMKH()
	{
		return default(ReadOnlySequence<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7A31730", Offset = "0x7A30B30", VA = "0x187A31730")]
	private void GMBOOFEGLCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MHFCBONOCKA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string BJLCGNNHBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xE97840", Offset = "0xE96C40", VA = "0x180E97840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D6B0", Offset = "0x7A3CAB0", VA = "0x187A3D6B0")]
	public MHFCBONOCKA(string LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D710", Offset = "0x7A3CB10", VA = "0x187A3D710")]
	public MHFCBONOCKA(string LNICHECHJFC, string FCBJIBMJPBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FNNFAPMLGBM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private static class KMJBPPKLFPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[ThreadStatic]
		private static byte[] CELIBNPACII;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AC20", Offset = "0x7A3A020", VA = "0x187A3AC20")]
		public static byte[] OPNLBMENBDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static CLCGJCMKMCJ ANHPJDLMFJG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly byte[][] PLHONOLIEOO;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly byte[] IOFMKFAMFJI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static CLCGJCMKMCJ JHJCNKHJHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A347C0", Offset = "0x7A33BC0", VA = "0x187A347C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7A348B0", Offset = "0x7A33CB0", VA = "0x187A348B0")]
	public static void ONDJDJMNABD(CLCGJCMKMCJ IJLKKICNIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x302D160", Offset = "0x302C560", VA = "0x18302D160")]
	public static byte[] GKPJGNLGAKF<T>(T NCHBKHMIMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x302D1F0", Offset = "0x302C5F0", VA = "0x18302D1F0")]
	public static byte[] GKPJGNLGAKF<T>(T HCPAOILCJCB, CLCGJCMKMCJ IJLKKICNIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x302E6C0", Offset = "0x302DAC0", VA = "0x18302E6C0")]
	public static string OFEJDBEIMGC<T>(T HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x302E530", Offset = "0x302D930", VA = "0x18302E530")]
	public static string OFEJDBEIMGC<T>(T HCPAOILCJCB, CLCGJCMKMCJ IJLKKICNIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x302E140", Offset = "0x302D540", VA = "0x18302E140")]
	public static T KBLFJIABLOP<T>(string CLFFJPDPGCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x302E340", Offset = "0x302D740", VA = "0x18302E340")]
	public static T KBLFJIABLOP<T>(string CLFFJPDPGCO, CLCGJCMKMCJ IJLKKICNIBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x302E450", Offset = "0x302D850", VA = "0x18302E450")]
	public static T KBLFJIABLOP<T>([In] ReadOnlyMemory<byte> CLFFJPDPGCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x302E260", Offset = "0x302D660", VA = "0x18302E260")]
	public static T KBLFJIABLOP<T>([In] ReadOnlyMemory<byte> CLFFJPDPGCO, CLCGJCMKMCJ IJLKKICNIBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x302DCF0", Offset = "0x302D0F0", VA = "0x18302DCF0")]
	public static T KBLFJIABLOP<T>([In] ReadOnlySequence<byte> CLFFJPDPGCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x302DD90", Offset = "0x302D190", VA = "0x18302DD90")]
	public static T KBLFJIABLOP<T>([In] ReadOnlySequence<byte> CLFFJPDPGCO, CLCGJCMKMCJ IJLKKICNIBC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum HHLCENLOKFF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BeginObject,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	EndObject,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BeginArray,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	EndArray,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Number,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	String,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	True,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Null,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ValueSeparator,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NameSeparator
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LKMCFLGDNPK
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly byte[] NKPBAAKNBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private byte[] CELIBNPACII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LHBPAMEKCBO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GBNLHEBCHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x232B450", Offset = "0x232A850", VA = "0x18232B450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C830", Offset = "0x7A3BC30", VA = "0x187A3C830")]
	public void NINEDKBMKCE(int LHBPAMEKCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B550", Offset = "0x7A3A950", VA = "0x187A3B550")]
	public static byte[] APPKPHOFDBJ(string NHHEMHBDHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B8C0", Offset = "0x7A3ACC0", VA = "0x187A3B8C0")]
	public static byte[] DLFNJAIFCNM(string NHHEMHBDHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C0D0", Offset = "0x7A3B4D0", VA = "0x187A3C0D0")]
	public static byte[] LGMPCMDIJJD(string NHHEMHBDHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BF50", Offset = "0x7A3B350", VA = "0x187A3BF50")]
	public static byte[] LEJNLBALEFE(string NHHEMHBDHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x63E89E0", Offset = "0x63E7DE0", VA = "0x1863E89E0")]
	public LKMCFLGDNPK(byte[] CAOMHCIKDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C8B0", Offset = "0x7A3BCB0", VA = "0x187A3C8B0")]
	public ArraySegment<byte> OPNLBMENBDL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B6F0", Offset = "0x7A3AAF0", VA = "0x187A3B6F0")]
	public byte[] DEKBCKAAIPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CA20", Offset = "0x7A3BE20", VA = "0x187A3CA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BB20", Offset = "0x7A3AF20", VA = "0x187A3BB20")]
	public void GLKGHIFLLKL(int MHPNFGMMOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C950", Offset = "0x7A3BD50", VA = "0x187A3C950")]
	public void PANHGDKCCKM(byte[] IENGFJCPAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BF10", Offset = "0x7A3B310", VA = "0x187A3BF10")]
	public void KEBMLJOEFJB(byte IENGFJCPAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C220", Offset = "0x7A3B620", VA = "0x187A3C220")]
	public void MAGKJKLIKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B9E0", Offset = "0x7A3ADE0", VA = "0x187A3B9E0")]
	public void DNDIEGEDHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BA30", Offset = "0x7A3AE30", VA = "0x187A3BA30")]
	public void ENLCMNFAJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B630", Offset = "0x7A3AA30", VA = "0x187A3B630")]
	public void BMLPHCABKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B500", Offset = "0x7A3A900", VA = "0x187A3B500")]
	public void AKJBCJFMBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C270", Offset = "0x7A3B670", VA = "0x187A3C270")]
	public void MJOLALIPECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BBA0", Offset = "0x7A3AFA0", VA = "0x187A3BBA0")]
	public void HKMPLFJIFDJ(string NHHEMHBDHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B870", Offset = "0x7A3AC70", VA = "0x187A3B870")]
	public void DIFMAFGJPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B460", Offset = "0x7A3A860", VA = "0x187A3B460")]
	public void AFJCMBOOHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BDB0", Offset = "0x7A3B1B0", VA = "0x187A3BDB0")]
	public void JBJEGJHLDFI(bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BC40", Offset = "0x7A3B040", VA = "0x187A3BC40")]
	public void IEKAFEMKOGE(float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C2C0", Offset = "0x7A3B6C0", VA = "0x187A3C2C0")]
	public void NCJFHDIMLOM(double HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B680", Offset = "0x7A3AA80", VA = "0x187A3B680")]
	public void CIFOKGJLGIE(byte HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BB30", Offset = "0x7A3AF30", VA = "0x187A3BB30")]
	public void HEIJEAAMDKD(ushort HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C9B0", Offset = "0x7A3BDB0", VA = "0x187A3C9B0")]
	public void PNIPMHCAKIE(uint HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BAF0", Offset = "0x7A3AEF0", VA = "0x187A3BAF0")]
	public void FIBCPEEHOJM(ulong HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C840", Offset = "0x7A3BC40", VA = "0x187A3C840")]
	public void OCMADGLFCDD(sbyte HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BA80", Offset = "0x7A3AE80", VA = "0x187A3BA80")]
	public void FCLJKADDFJD(short HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C7C0", Offset = "0x7A3BBC0", VA = "0x187A3C7C0")]
	public void NENJECHPEMH(int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C1F0", Offset = "0x7A3B5F0", VA = "0x187A3C1F0")]
	public void MAEMKDKCDCI(long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C430", Offset = "0x7A3B830", VA = "0x187A3C430")]
	public void NDHLNFCMOJB(string HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class GCFNHCPFCJN : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private static class HJPPCFJPIJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x425EFD0", Offset = "0x425E3D0", VA = "0x18425EFD0")]
		static HJPPCFJPIJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private GCFNHCPFCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class AELBBGIIAAL : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class PPGHCCAMMGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4CB2B90", Offset = "0x4CB1F90", VA = "0x184CB2B90")]
		static PPGHCCAMMGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class PDJELCMIOIC
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<Type, object> NPNKKDHGEOH;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7A3FCE0", Offset = "0x7A3F0E0", VA = "0x187A3FCE0")]
		internal static object OFFGFBOCALI(Type OPGNNMINDKO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private AELBBGIIAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class LNFCAPMEIOG : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private static class BCBNGBKBMLP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x53AFEE0", Offset = "0x53AF2E0", VA = "0x1853AFEE0")]
		static BCBNGBKBMLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly LNFCAPMEIOG ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static bool OGHBJGGAJIN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static CPNGADLNAJB[] LBDGEMHMLIN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static CLCGJCMKMCJ[] LKFIKMGNKJI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private LNFCAPMEIOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CBC0", Offset = "0x7A3BFC0", VA = "0x187A3CBC0")]
	public static void EMOBGIHOLPD(params CLCGJCMKMCJ[] LKFIKMGNKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CAE0", Offset = "0x7A3BEE0", VA = "0x187A3CAE0")]
	public static void EMOBGIHOLPD(params CPNGADLNAJB[] LBDGEMHMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CCA0", Offset = "0x7A3C0A0", VA = "0x187A3CCA0")]
	public static void IAICPAGPECC(CPNGADLNAJB[] LBDGEMHMLIN, CLCGJCMKMCJ[] LKFIKMGNKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class DIPMCKMFNIP : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class DEEGDPNAKCG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E58960", Offset = "0x5E57D60", VA = "0x185E58960")]
		static DEEGDPNAKCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private DIPMCKMFNIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FBLOLKPIDJK
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly CLCGJCMKMCJ LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly CLCGJCMKMCJ NKOCAAECALA;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LNNEBLPOHIL
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly CLCGJCMKMCJ LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly CLCGJCMKMCJ BIKMMCEKGLO;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly CLCGJCMKMCJ EKAFEAHAMBI;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly CLCGJCMKMCJ HOMKDMJMBOH;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly CLCGJCMKMCJ JCNEPLHDFDD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly CLCGJCMKMCJ HDFICEOOMOC;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly CLCGJCMKMCJ OBBPHPGNGFH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly CLCGJCMKMCJ AIMNEKEKIKH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly CLCGJCMKMCJ IHJDDACAENF;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly CLCGJCMKMCJ MKOLHIBGLHN;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly CLCGJCMKMCJ NBPKDDPDFEF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly CLCGJCMKMCJ GJOOIKDPLDN;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class ONHAFIDAIFH
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Dictionary<Type, Type> NPNKKDHGEOH;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7A3DFF0", Offset = "0x7A3D3F0", VA = "0x187A3DFF0")]
	internal static object OFFGFBOCALI(Type OPGNNMINDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7A3DFB0", Offset = "0x7A3D3B0", VA = "0x187A3DFB0")]
	private static object NEDLHNICCFL(Type ABCOJOHNPFF, Type[] KBFCLDNNEOJ, params object[] FPCAFHOFFNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal sealed class HCMCAAHLIHO : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class OMOCKIGMGFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4B9FFF0", Offset = "0x4B9F3F0", VA = "0x184B9FFF0")]
		static OMOCKIGMGFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private HCMCAAHLIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class PPCCFHILLBN : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class NFMDDBMEFPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4A75C30", Offset = "0x4A75030", VA = "0x184A75C30")]
		static NFMDDBMEFPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private PPCCFHILLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CLFCKMIIKEP
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal static readonly CLCGJCMKMCJ[] NCECIIDLLCH;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class FMEHIFGABBB : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class FFHICELAHHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4072E10", Offset = "0x4072210", VA = "0x184072E10")]
		static FFHICELAHHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class HGDBKMIBKDO : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private static class CGDDEFALOAP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x57066C0", Offset = "0x5705AC0", VA = "0x1857066C0")]
			static CGDDEFALOAP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private HGDBKMIBKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private FMEHIFGABBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class GGLCGFNLCMJ : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class DHJJJPMAFIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E708E0", Offset = "0x5E6FCE0", VA = "0x185E708E0")]
		static DHJJJPMAFIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private sealed class EGFJNGBGCMC : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private static class GNDPPNCMKGH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x41AA230", Offset = "0x41A9630", VA = "0x1841AA230")]
			static GNDPPNCMKGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private EGFJNGBGCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private GGLCGFNLCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class DIJNDIEBKNJ : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class FJCNCLAAKPI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x40837A0", Offset = "0x4082BA0", VA = "0x1840837A0")]
		static FJCNCLAAKPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class LIHNLIDLAEK : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private static class FLIEBNLHGEP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x40A79F0", Offset = "0x40A6DF0", VA = "0x1840A79F0")]
			static FLIEBNLHGEP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private LIHNLIDLAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private DIJNDIEBKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NJKDCMJKHCI : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class HIHKPLHNKML<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x42568D0", Offset = "0x4255CD0", VA = "0x1842568D0")]
		static HIHKPLHNKML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private sealed class JENGDNBNANL : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private static class HKHCNKJMGNF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x426AD30", Offset = "0x426A130", VA = "0x18426AD30")]
			static HKHCNKJMGNF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private JENGDNBNANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private NJKDCMJKHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class GOEFAONJIHB : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class FELBEIBCEHK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x406AF40", Offset = "0x406A340", VA = "0x18406AF40")]
		static FELBEIBCEHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private sealed class EOBIAPGCFIG : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class KOGAAEDBBBM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4731B90", Offset = "0x4730F90", VA = "0x184731B90")]
			static KOGAAEDBBBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private EOBIAPGCFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private GOEFAONJIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class LNJCINNKLKO : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class GPNKGCFOGJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x41B9710", Offset = "0x41B8B10", VA = "0x1841B9710")]
		static GPNKGCFOGJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class PIMBKFKGFLD : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		private static class HFGMEHNKBAH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x42414E0", Offset = "0x42408E0", VA = "0x1842414E0")]
			static HFGMEHNKBAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private PIMBKFKGFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private LNJCINNKLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class BJOOPJDFNNB : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class LILOEODLKOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x47D7860", Offset = "0x47D6C60", VA = "0x1847D7860")]
		static LILOEODLKOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class DEBEBIMNMEP : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private static class JKIBJPBONEA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x458CFF0", Offset = "0x458C3F0", VA = "0x18458CFF0")]
			static JKIBJPBONEA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private DEBEBIMNMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private BJOOPJDFNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class OBEJCBBBCGB : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class FPKEKMMIABD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x40B6A30", Offset = "0x40B5E30", VA = "0x1840B6A30")]
		static FPKEKMMIABD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BKDPDODCNPF : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private static class MOCFNKCOBMP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4A160B0", Offset = "0x4A154B0", VA = "0x184A160B0")]
			static MOCFNKCOBMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private BKDPDODCNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private OBEJCBBBCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class KAIHKBAFKCK : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class CGOGMANKPKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5818C20", Offset = "0x5818020", VA = "0x185818C20")]
		static CGOGMANKPKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private sealed class OKGHGJLPDPH : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private static class KADDIBHLKBH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x46555D0", Offset = "0x46549D0", VA = "0x1846555D0")]
			static KADDIBHLKBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private OKGHGJLPDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private KAIHKBAFKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class NANPPCDAAJC : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private static class MBIBFBFNMKE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x49D4E20", Offset = "0x49D4220", VA = "0x1849D4E20")]
		static MBIBFBFNMKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class HOEHKNACLPE : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private static class PJLNKNCHNDN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x4C72350", Offset = "0x4C71750", VA = "0x184C72350")]
			static PJLNKNCHNDN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private HOEHKNACLPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private NANPPCDAAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class PGKCPECNBEP : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private static class DLDNLEPOMDI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E814E0", Offset = "0x5E808E0", VA = "0x185E814E0")]
		static DLDNLEPOMDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private sealed class BIJEGOLFPMH : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class NKLOGNCGOAI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4A94D70", Offset = "0x4A94170", VA = "0x184A94D70")]
			static NKLOGNCGOAI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private BIJEGOLFPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private PGKCPECNBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class LFFKILBPFGA : CLCGJCMKMCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private static class MIINBBMAMIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x49FE800", Offset = "0x49FDC00", VA = "0x1849FE800")]
		static MIINBBMAMIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class OGFDFHIMCOM : CLCGJCMKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private static class CEFCIKOEPOM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public static readonly CPEEKDGOLEA<T> HJDDCNEPPKJ;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x56FF6F0", Offset = "0x56FEAF0", VA = "0x1856FF6F0")]
			static CEFCIKOEPOM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly CLCGJCMKMCJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly CLCGJCMKMCJ[] LKFIKMGNKJI;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private OGFDFHIMCOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
		public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly CLCGJCMKMCJ ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly CPEEKDGOLEA<object> CHHIMOFELDC;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	private LFFKILBPFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	public CPEEKDGOLEA<T> OFFGFBOCALI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct IBJNPIPGONA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public T[] ODHEFNLNLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public int EMINOKGEAOA;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4329E80", Offset = "0x4329280", VA = "0x184329E80")]
	public IBJNPIPGONA(int ICKKGHMHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4329960", Offset = "0x4328D60", VA = "0x184329960")]
	public void EBDKDKCDLND(T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4329DF0", Offset = "0x43291F0", VA = "0x184329DF0")]
	public T[] GPFELNBEICA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class HHGIMJBLHNI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly int DHNKFIBNKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly object BPAGIJDOFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int IIACLAMOIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private T[][] CHOEJGIAPJN;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x424EDC0", Offset = "0x424E1C0", VA = "0x18424EDC0")]
	public HHGIMJBLHNI(int DHNKFIBNKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x424EB70", Offset = "0x424DF70", VA = "0x18424EB70")]
	public T[] JGJPCJIOHPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x424E9E0", Offset = "0x424DDE0", VA = "0x18424E9E0")]
	public void EKHFCIPPIIN(T[] CHDCMIMONFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class ADONBEMOIBC : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class IJNJADFMNAH : IComparable<IJNJADFMNAH>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class IEOFBKHANPG : IEnumerable<IJNJADFMNAH>, IEnumerable, IEnumerator<IJNJADFMNAH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private IJNJADFMNAH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public IJNJADFMNAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private IJNJADFMNAH System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
			[DebuggerHidden]
			public IEOFBKHANPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7A37980", Offset = "0x7A36D80", VA = "0x187A37980", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7A37AB0", Offset = "0x7A36EB0", VA = "0x187A37AB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7A37A00", Offset = "0x7A36E00", VA = "0x187A37A00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IJNJADFMNAH> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7A37A00", Offset = "0x7A36E00", VA = "0x187A37A00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly IJNJADFMNAH[] GPHCBAHDKJH;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly ulong[] ENILMKJIMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ulong ECHGIIKNGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int GFHLLJBPNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string DCOBFIHOILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IJNJADFMNAH[] BLINNJHGFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private ulong[] NOPCPDGKJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int ABPDJOGPHFP;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7A391F0", Offset = "0x7A385F0", VA = "0x187A391F0")]
		public IJNJADFMNAH(ulong LDCKBFKFIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7A38EF0", Offset = "0x7A382F0", VA = "0x187A38EF0")]
		public IJNJADFMNAH EBDKDKCDLND(ulong LDCKBFKFIKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7A390F0", Offset = "0x7A384F0", VA = "0x187A390F0")]
		public IJNJADFMNAH EBDKDKCDLND(ulong LDCKBFKFIKC, int HCPAOILCJCB, string DCOBFIHOILE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7A38D50", Offset = "0x7A38150", VA = "0x187A38D50")]
		public IJNJADFMNAH CPPCEINMDBF(SequenceReader<byte> IEMPDPINHLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7A38CC0", Offset = "0x7A380C0", VA = "0x187A38CC0")]
		internal static int BKKCLIELAKL(ulong[] CHDCMIMONFN, int IIACLAMOIEE, int OIPEPMJNPGM, ulong HCPAOILCJCB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7A38EC0", Offset = "0x7A382C0", VA = "0x187A38EC0", Slot = "4")]
		public int CompareTo(IJNJADFMNAH BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7A38C40", Offset = "0x7A38040", VA = "0x187A38C40")]
		[IteratorStateMachine(typeof(IEOFBKHANPG))]
		public IEnumerable<IJNJADFMNAH> BDNIBEMFNBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IMKAOILEDMJ : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IEnumerable<IJNJADFMNAH> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IEnumerable<IJNJADFMNAH> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private IEnumerator<IJNJADFMNAH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private IJNJADFMNAH <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x9EBC10", Offset = "0x9EB010", VA = "0x1809EBC10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7A398A0", Offset = "0x7A38CA0", VA = "0x187A398A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x21FF070", Offset = "0x21FE470", VA = "0x1821FF070")]
		[DebuggerHidden]
		public IMKAOILEDMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7A398F0", Offset = "0x7A38CF0", VA = "0x187A398F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7A392F0", Offset = "0x7A386F0", VA = "0x187A392F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7A39750", Offset = "0x7A38B50", VA = "0x187A39750")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7A392A0", Offset = "0x7A386A0", VA = "0x187A392A0")]
		private void GFPCIOJGMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7A39850", Offset = "0x7A38C50", VA = "0x187A39850", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7A397A0", Offset = "0x7A38BA0", VA = "0x187A397A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7A397A0", Offset = "0x7A38BA0", VA = "0x187A397A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly IJNJADFMNAH NIMLNKDMKHI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BCF0", Offset = "0x7A2B0F0", VA = "0x187A2BCF0")]
	public ADONBEMOIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B400", Offset = "0x7A2A800", VA = "0x187A2B400")]
	public void EBDKDKCDLND([In] ReadOnlyMemory<byte> MDABPMPEKPN, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B5E0", Offset = "0x7A2A9E0", VA = "0x187A2B5E0")]
	public void EBDKDKCDLND([In] ReadOnlySequence<byte> MDABPMPEKPN, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BB50", Offset = "0x7A2AF50", VA = "0x187A2BB50")]
	public bool OLEDKNAJEGF([In] ReadOnlySequence<byte> LDCKBFKFIKC, [Out] int HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BC60", Offset = "0x7A2B060", VA = "0x187A2BC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B7F0", Offset = "0x7A2ABF0", VA = "0x187A2B7F0")]
	private static void HKBMCNPCJLP(IEnumerable<IJNJADFMNAH> BLINNJHGFAI, StringBuilder ICPJFPKJFIA, int GPFECEMMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B790", Offset = "0x7A2AB90", VA = "0x187A2B790", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B790", Offset = "0x7A2AB90", VA = "0x187A2B790", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BAD0", Offset = "0x7A2AED0", VA = "0x187A2BAD0")]
	[IteratorStateMachine(typeof(IMKAOILEDMJ))]
	private static IEnumerable<KeyValuePair<string, int>> NLONGKJLPPI(IEnumerable<IJNJADFMNAH> BLINNJHGFAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class KFOHIBOPJEE
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly MethodInfo INNEIPLFKAD;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7A39FA0", Offset = "0x7A393A0", VA = "0x187A39FA0")]
	public static ulong NAPCGNBJENK(SequenceReader<byte> IEMPDPINHLH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class EPPLDOJKAHN
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7A342C0", Offset = "0x7A336C0", VA = "0x187A342C0")]
	public static void GLKGHIFLLKL(byte[] MDABPMPEKPN, int LHBPAMEKCBO, int MHPNFGMMOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7A34400", Offset = "0x7A33800", VA = "0x187A34400")]
	public static void PLFGAPOJKHK(byte[] CHDCMIMONFN, int DOPCGIEFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7A34520", Offset = "0x7A33920", VA = "0x187A34520")]
	public static byte[] PPPCFKNCBMK(byte[] DOELFDCMLHC, int DOPCGIEFEFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class COCMPADNGJN<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct KKMIKPDGACI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public byte[] ECHGIIKNGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public T GFHLLJBPNAP;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x469F880", Offset = "0x469EC80", VA = "0x18469F880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class DPJKNDPFPLN : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public COCMPADNGJN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private KKMIKPDGACI[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private KKMIKPDGACI[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x9EBC10", Offset = "0x9EB010", VA = "0x1809EBC10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x4101270", Offset = "0x4100670", VA = "0x184101270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public DPJKNDPFPLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D250", Offset = "0x5E8C650", VA = "0x185E8D250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DF30", Offset = "0x5E8D330", VA = "0x185E8DF30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly KKMIKPDGACI[][] EPAHCDBEHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly ulong CNAMMJAFAOB;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5912FA0", Offset = "0x59123A0", VA = "0x185912FA0")]
	public COCMPADNGJN(int GNOHMAFCFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5912FE0", Offset = "0x59123E0", VA = "0x185912FE0")]
	public COCMPADNGJN(int GNOHMAFCFKD, float MENMAALJONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5907310", Offset = "0x5906710", VA = "0x185907310")]
	public void EBDKDKCDLND(byte[] LDCKBFKFIKC, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x590B540", Offset = "0x590A940", VA = "0x18590B540")]
	private bool NNPBJDMEMBA(byte[] LDCKBFKFIKC, T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5909DA0", Offset = "0x59091A0", VA = "0x185909DA0")]
	public bool LINPJOCPLAE([In] ReadOnlySequence<byte> LDCKBFKFIKC, [Out] T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5911D50", Offset = "0x5911150", VA = "0x185911D50")]
	private static ulong OJKNKIOIFBB([In] ReadOnlyMemory<byte> KENGFOGLPKI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5910450", Offset = "0x590F850", VA = "0x185910450")]
	private static ulong OJKNKIOIFBB([In] ReadOnlySequence<byte> KENGFOGLPKI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5912F70", Offset = "0x5912370", VA = "0x185912F70")]
	private static int PMCKIGKIHFC(int OAKOJHNAFIO, float MENMAALJONP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5908130", Offset = "0x5907530", VA = "0x185908130", Slot = "4")]
	[IteratorStateMachine(typeof(COCMPADNGJN<>.DPJKNDPFPLN))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x40E8770", Offset = "0x40E7B70", VA = "0x1840E8770", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal struct GHHJBHIBEFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly Guid GFHLLJBPNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly byte KMJONLAIHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly byte AOIIIBLLPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly byte OFDIMKFDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly byte ILDJFPMODAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly byte GAAJJBEHGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly byte PLEKGNMMMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly byte BPGBJJHGIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly byte FNADLLJOKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly byte OBKLEHJFOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly byte HIOKCKLNALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly byte CPLGNIHLGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly byte IHJNEGBIJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly byte MFMICGPIIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly byte JOONJKCINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly byte FDCJDCBPCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly byte AJGHFJLDBFN;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static byte[] DMEKGJMHNNJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static byte[] BIIPANCDHMG;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7A35A60", Offset = "0x7A34E60", VA = "0x187A35A60")]
	public GHHJBHIBEFM([In] Guid HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7A35A70", Offset = "0x7A34E70", VA = "0x187A35A70")]
	public GHHJBHIBEFM([In] ReadOnlySequence<byte> KKJDFMOOMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7A358E0", Offset = "0x7A34CE0", VA = "0x187A358E0")]
	private static byte BPONHBHJEMF(ReadOnlySpan<byte> MDABPMPEKPN, int FGPFBDKODIN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7A34BB0", Offset = "0x7A33FB0", VA = "0x187A34BB0")]
	private static byte APOJHPCDOBL(byte BCCGANGEINF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7A34CD0", Offset = "0x7A340D0", VA = "0x187A34CD0")]
	public void BNJLCFOPFMP(byte[] CELIBNPACII, int LHBPAMEKCBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class AMKBMKMMKKJ
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C1C0", Offset = "0x7A2B5C0", VA = "0x187A2C1C0")]
	public static bool EAJJBAGGLLO(byte DGDCPDOCKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C1D0", Offset = "0x7A2B5D0", VA = "0x187A2C1D0")]
	public static bool EBMBLCFEMBJ(byte DGDCPDOCKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C8F0", Offset = "0x7A2BCF0", VA = "0x187A2C8F0")]
	public static sbyte FPICPHJBNBD([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CB00", Offset = "0x7A2BF00", VA = "0x187A2CB00")]
	public static short JMDAAOMAFCJ([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DC90", Offset = "0x7A2D090", VA = "0x187A2DC90")]
	public static int OHAJDGIIFAG([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CD90", Offset = "0x7A2C190", VA = "0x187A2CD90")]
	public static long LALLFPOKHLK([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CC50", Offset = "0x7A2C050", VA = "0x187A2CC50")]
	public static bool KLDIDBOCNPF(SequenceReader<byte> MDABPMPEKPN, [Out] long HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D800", Offset = "0x7A2CC00", VA = "0x187A2D800")]
	public static byte MDJCLPGOCGO([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CAA0", Offset = "0x7A2BEA0", VA = "0x187A2CAA0")]
	public static ushort JLDGJHHHGGL([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BEF0", Offset = "0x7A2B2F0", VA = "0x187A2BEF0")]
	public static uint CEFIJDLGBBA([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DBE0", Offset = "0x7A2CFE0", VA = "0x187A2DBE0")]
	public static ulong NGNOJHLDHDA([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DA90", Offset = "0x7A2CE90", VA = "0x187A2DA90")]
	public static bool NAHMEALIJHO(SequenceReader<byte> MDABPMPEKPN, [Out] ulong HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BF50", Offset = "0x7A2B350", VA = "0x187A2BF50")]
	public static bool DHBBKMOOCJB(SequenceReader<byte> IEMPDPINHLH, [Out] int CLDAFOOBOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BDE0", Offset = "0x7A2B1E0", VA = "0x187A2BDE0")]
	public static bool BCIKDPFOMCM(SequenceReader<byte> IEMPDPINHLH, [Out] int CLDAFOOBOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C120", Offset = "0x7A2B520", VA = "0x187A2C120")]
	public static bool DLNPBOGILGC(SequenceReader<byte> IEMPDPINHLH, [Out] int CLDAFOOBOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C950", Offset = "0x7A2BD50", VA = "0x187A2C950")]
	public static float ICCJDHOIGBM([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D860", Offset = "0x7A2CC60", VA = "0x187A2D860")]
	public static bool MELLELBILNC(SequenceReader<byte> IEMPDPINHLH, [Out] float HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CB60", Offset = "0x7A2BF60", VA = "0x187A2CB60")]
	public static double KBIJIEHEEFF([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CA40", Offset = "0x7A2BE40", VA = "0x187A2CA40")]
	public static bool IKAKIGAHCFM(SequenceReader<byte> IEMPDPINHLH, [Out] double HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C240", Offset = "0x7A2B640", VA = "0x187A2C240")]
	public static int FIBCPEEHOJM(byte[] CELIBNPACII, int LHBPAMEKCBO, ulong HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CE40", Offset = "0x7A2C240", VA = "0x187A2CE40")]
	public static int MAEMKDKCDCI(byte[] CELIBNPACII, int LHBPAMEKCBO, long HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D8C0", Offset = "0x7A2CCC0", VA = "0x187A2D8C0")]
	public static bool MOHCDJHKPFD([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class OHHOOKPGBAH
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7A3DE20", Offset = "0x7A3D220", VA = "0x187A3DE20")]
	public static bool JFCIKMLEDCN(this TypeInfo IFBDJLKPHIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal static class KCAPACALFFN
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static readonly Encoding IJONMIMPJCN;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct LNFPJMKDMBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public ulong HKICDKBDKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int EAIPGJCIAMN;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x231A600", Offset = "0x2319A00", VA = "0x18231A600")]
	public LNFPJMKDMBA(ulong IMHIJIAJINB, int LLKBOGFJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D0B0", Offset = "0x7A3C4B0", VA = "0x187A3D0B0")]
	public void CDKLHECIOJP(LNFPJMKDMBA BMKPAKCEMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D1E0", Offset = "0x7A3C5E0", VA = "0x187A3D1E0")]
	public static LNFPJMKDMBA OLDIDAFNFMM(LNFPJMKDMBA DDIIBBHFODJ, LNFPJMKDMBA BCCGANGEINF)
	{
		return default(LNFPJMKDMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D150", Offset = "0x7A3C550", VA = "0x187A3D150")]
	public void NINLJBNEMID(LNFPJMKDMBA BMKPAKCEMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D010", Offset = "0x7A3C410", VA = "0x187A3D010")]
	public static LNFPJMKDMBA BIHENADDCJG(LNFPJMKDMBA DDIIBBHFODJ, LNFPJMKDMBA BCCGANGEINF)
	{
		return default(LNFPJMKDMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D110", Offset = "0x7A3C510", VA = "0x187A3D110")]
	public void GFMNDIMAFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D0C0", Offset = "0x7A3C4C0", VA = "0x187A3D0C0")]
	public static LNFPJMKDMBA GFMNDIMAFCN(LNFPJMKDMBA DDIIBBHFODJ)
	{
		return default(LNFPJMKDMBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal struct MLHMDIIGBMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public byte[] CELIBNPACII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public int LHBPAMEKCBO;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x9AFA10", Offset = "0x9AEE10", VA = "0x1809AFA10")]
	public MLHMDIIGBMD(byte[] CELIBNPACII, int CPGMOBFHDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D890", Offset = "0x7A3CC90", VA = "0x187A3D890")]
	public void EOLLOFPCCIF(byte KKGBCJPEHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D8F0", Offset = "0x7A3CCF0", VA = "0x187A3D8F0")]
	public void FJGOCKCJKHK(byte[] KKGBCJPEHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D970", Offset = "0x7A3CD70", VA = "0x187A3D970")]
	public void INCNPNDGJLC(byte[] KKGBCJPEHGE, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D9F0", Offset = "0x7A3CDF0", VA = "0x187A3D9F0")]
	public void INCNPNDGJLC(byte[] KKGBCJPEHGE, int JJJPINFOLNN, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7A3DA90", Offset = "0x7A3CE90", VA = "0x187A3DA90")]
	public void MDBJDPOLILB(byte DGDCPDOCKCI, int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D790", Offset = "0x7A3CB90", VA = "0x187A3D790")]
	public void BNKAMIEFLII(string KKGBCJPEHGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal static class BDFABOHGGHJ
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private enum DFBGLGMLLKF
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private enum LBJINAPNBNL
	{
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private enum NGININIIBKI
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[ThreadStatic]
	private static byte[] EIOEDFCJMAL;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ThreadStatic]
	private static byte[] AKLOOMNFADB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly byte[] NCPBNELGCFG;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly byte[] LACOCNDNJFM;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly NGININIIBKI MFOBOBFDLJB;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly char HPOJLDAGFEB;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int ALJJNIMEIAD;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int PLNBKBJLLLN;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly uint[] LGKCIONIKNE;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F770", Offset = "0x7A2EB70", VA = "0x187A2F770")]
	private static byte[] HELBKDONBOE(int BGDDCGNLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F840", Offset = "0x7A2EC40", VA = "0x187A2F840")]
	private static byte[] JMGPEADLFAK(int BGDDCGNLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E550", Offset = "0x7A2D950", VA = "0x187A2E550")]
	public static int BMLDLFIFBKL(byte[] CELIBNPACII, int LHBPAMEKCBO, float HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E430", Offset = "0x7A2D830", VA = "0x187A2E430")]
	public static int BMLDLFIFBKL(byte[] CELIBNPACII, int LHBPAMEKCBO, double HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7A302D0", Offset = "0x7A2F6D0", VA = "0x187A302D0")]
	private static bool POEGLMHLEFN(byte[] CELIBNPACII, int OIPEPMJNPGM, ulong IFHPLAANGJL, ulong PGNEJDAGKEJ, ulong KBCLBDPEOKC, ulong PBFJKBDNBCP, ulong EKMHMCFHPGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7A301E0", Offset = "0x7A2F5E0", VA = "0x187A301E0")]
	private static void PNHBIDLBAID(uint CLDAFOOBOLA, int FKFIMMEIGBN, [Out] uint CHGPJNIDIEI, [Out] int NCJOAGGIABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7A2EEE0", Offset = "0x7A2E2E0", VA = "0x187A2EEE0")]
	private static bool FFLHHPELJDN(LNFPJMKDMBA CMOLICKHOOF, LNFPJMKDMBA MLOFEILNACF, LNFPJMKDMBA MCHLEJDMNIA, byte[] CELIBNPACII, [Out] int OIPEPMJNPGM, [Out] int EHIKCNKLKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F920", Offset = "0x7A2ED20", VA = "0x187A2F920")]
	private static bool KIPKKFMPNHD(double LLKDJGHBOID, DFBGLGMLLKF BGFBLNEGPHO, byte[] CELIBNPACII, [Out] int OIPEPMJNPGM, [Out] int DBJDHDMJGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E680", Offset = "0x7A2DA80", VA = "0x187A2E680")]
	private static bool BNFLDJCFIBB(double LLKDJGHBOID, DFBGLGMLLKF BGFBLNEGPHO, byte[] CELIBNPACII, [Out] int OIPEPMJNPGM, [Out] int EGILCLBKMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2EB20", Offset = "0x7A2DF20", VA = "0x187A2EB20")]
	private static bool DINKFAMJPDF(double HCPAOILCJCB, MLHMDIIGBMD EPJDCCJNHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F2A0", Offset = "0x7A2E6A0", VA = "0x187A2F2A0")]
	private static bool GELIFPPAHNA(double HCPAOILCJCB, MLHMDIIGBMD EPJDCCJNHFB, LBJINAPNBNL BGFBLNEGPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E790", Offset = "0x7A2DB90", VA = "0x187A2E790")]
	private static void DIDNEJJLNDG(byte[] JOGNKOGMFBB, int OIPEPMJNPGM, int EGILCLBKMJM, int GCDHAEMPJNC, MLHMDIIGBMD EPJDCCJNHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2FDA0", Offset = "0x7A2F1A0", VA = "0x187A2FDA0")]
	private static void NAEIHIHJHED(byte[] JOGNKOGMFBB, int OIPEPMJNPGM, int LLKBOGFJFDP, MLHMDIIGBMD EPJDCCJNHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7A2ECE0", Offset = "0x7A2E0E0", VA = "0x187A2ECE0")]
	private static bool DKPDEGJLGMD(double LLKDJGHBOID, LBJINAPNBNL BGFBLNEGPHO, int IFBCDPJCDDN, byte[] DIPCCCBCPPM, [Out] bool FEDBNKLPNOM, [Out] int OIPEPMJNPGM, [Out] int PEOHBJGLDBB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal struct FCCILEKFAKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public double ENDIHBOOBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public ulong EGDCCOLLDMI;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal struct FAOKBMHCKJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public float HKICDKBDKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint BNPJOEFFEDG;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct LCNGDLFBEBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private ulong FLAJHOOJNCK;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B240", Offset = "0x7A3A640", VA = "0x187A3B240")]
	public LCNGDLFBEBD(double ENDIHBOOBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B250", Offset = "0x7A3A650", VA = "0x187A3B250")]
	public LCNGDLFBEBD(LNFPJMKDMBA ENDIHBOOBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7A3AF80", Offset = "0x7A3A380", VA = "0x187A3AF80")]
	public LNFPJMKDMBA HKNIKPKAOGH()
	{
		return default(LNFPJMKDMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B100", Offset = "0x7A3A500", VA = "0x187A3B100")]
	public LNFPJMKDMBA NFLIMHFKGHE()
	{
		return default(LNFPJMKDMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
	public ulong EJHNECPNNII()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B080", Offset = "0x7A3A480", VA = "0x187A3B080")]
	public double MBAOCMDMMGK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7A3ACC0", Offset = "0x7A3A0C0", VA = "0x187A3ACC0")]
	public double AOADBHIGAMH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B050", Offset = "0x7A3A450", VA = "0x187A3B050")]
	public int LKAOJFGAIGD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B020", Offset = "0x7A3A420", VA = "0x187A3B020")]
	public ulong KOJOILAABJO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7A3AF60", Offset = "0x7A3A360", VA = "0x187A3AF60")]
	public bool FDPGJLOAKHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B190", Offset = "0x7A3A590", VA = "0x187A3B190")]
	public bool NLAIIEMKAFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7A3ADF0", Offset = "0x7A3A1F0", VA = "0x187A3ADF0")]
	public bool EBLDOGBDJNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7A3AFF0", Offset = "0x7A3A3F0", VA = "0x187A3AFF0")]
	public bool JEOPIHAMNDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B1D0", Offset = "0x7A3A5D0", VA = "0x187A3B1D0")]
	public int PKLAJOIMJDA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7A3AE20", Offset = "0x7A3A220", VA = "0x187A3AE20")]
	public void ENLGNNCPGGP([Out] LNFPJMKDMBA KNFFGLJEANH, [Out] LNFPJMKDMBA LALLPMBGJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B1F0", Offset = "0x7A3A5F0", VA = "0x187A3B1F0")]
	public bool PPEBGPHMCHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x36C4660", Offset = "0x36C3A60", VA = "0x1836C4660")]
	public double HCPAOILCJCB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B1B0", Offset = "0x7A3A5B0", VA = "0x187A3B1B0")]
	public static int ODFNACGHJKC(int EGGAIAGCNMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B180", Offset = "0x7A3A580", VA = "0x187A3B180")]
	public static double NGANGADAPAO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7A3AD60", Offset = "0x7A3A160", VA = "0x187A3AD60")]
	public static ulong CPFAGLEGEAN(LNFPJMKDMBA PCIJDIJDEJM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct JADDDEMAFKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private uint FCIFCLCMEGD;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2509A70", Offset = "0x2508E70", VA = "0x182509A70")]
	public JADDDEMAFKC(float HKICDKBDKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7A39B80", Offset = "0x7A38F80", VA = "0x187A39B80")]
	public LNFPJMKDMBA HKNIKPKAOGH()
	{
		return default(LNFPJMKDMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10")]
	public uint DAGDCMONODC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7A39C00", Offset = "0x7A39000", VA = "0x187A39C00")]
	public int LKAOJFGAIGD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7A39BE0", Offset = "0x7A38FE0", VA = "0x187A39BE0")]
	public uint KOJOILAABJO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7A39B70", Offset = "0x7A38F70", VA = "0x187A39B70")]
	public bool FDPGJLOAKHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7A39A40", Offset = "0x7A38E40", VA = "0x187A39A40")]
	public void ENLGNNCPGGP([Out] LNFPJMKDMBA KNFFGLJEANH, [Out] LNFPJMKDMBA LALLPMBGJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7A39C20", Offset = "0x7A39020", VA = "0x187A39C20")]
	public bool PPEBGPHMCHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct EHJOBLNIIIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly ulong IMHIJIAJINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly short MIIOOFHJDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly short DBJDHDMJGDP;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7A341E0", Offset = "0x7A335E0", VA = "0x187A341E0")]
	public EHJOBLNIIIB(ulong IMHIJIAJINB, short MIIOOFHJDBK, short DBJDHDMJGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal static class IILFNGICDOB
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly EHJOBLNIIIB[] LDAGEKEDHNO;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7A37BD0", Offset = "0x7A36FD0", VA = "0x187A37BD0")]
	public static void PGEHEHGMIHL(int JMIFNNMJLCB, int FJDGPOIIOGO, [Out] LNFPJMKDMBA CHGPJNIDIEI, [Out] int DBJDHDMJGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A37B00", Offset = "0x7A36F00", VA = "0x187A37B00")]
	public static void KNLLMAOANFE(int IPOIIJCHNOM, [Out] LNFPJMKDMBA CHGPJNIDIEI, [Out] int HOEAECNOHAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
internal struct IMEBMJNPCCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly byte[] MDABPMPEKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly int JJJPINFOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly int GJNCHMDIDML;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7A49000", Offset = "0x7A48400", VA = "0x187A49000")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x41AE350", Offset = "0x41AD750", VA = "0x1841AE350")]
	public IMEBMJNPCCA(byte[] MDABPMPEKPN, int JJJPINFOLNN, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x254D1B0", Offset = "0x254C5B0", VA = "0x18254D1B0")]
	public int OIPEPMJNPGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A48FA0", Offset = "0x7A483A0", VA = "0x187A48FA0")]
	public IMEBMJNPCCA GHGPKHELPDD(int INPBKEEADJL, int NHJAKHBPCNL)
	{
		return default(IMEBMJNPCCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class EKMDKHBGJJN
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[ThreadStatic]
	private static byte[] BOJMPEKDFBN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly double[] JIIPNNDBBNL;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly int CDNNHCMMCOF;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A43FE0", Offset = "0x7A433E0", VA = "0x187A43FE0")]
	private static byte[] BMOFKJAIFFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A44470", Offset = "0x7A43870", VA = "0x187A44470")]
	private static IMEBMJNPCCA FBKCFBLHCAB(IMEBMJNPCCA CELIBNPACII)
	{
		return default(IMEBMJNPCCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A451E0", Offset = "0x7A445E0", VA = "0x187A451E0")]
	private static IMEBMJNPCCA MJLPMLFILFH(IMEBMJNPCCA CELIBNPACII)
	{
		return default(IMEBMJNPCCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A43D80", Offset = "0x7A43180", VA = "0x187A43D80")]
	private static void AABKOBHHGGI(IMEBMJNPCCA CELIBNPACII, int LLKBOGFJFDP, byte[] MEKGMKMAACF, [Out] int LBGMJDEJCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A44EF0", Offset = "0x7A442F0", VA = "0x187A44EF0")]
	private static void LCPJABKMKJD(IMEBMJNPCCA CELIBNPACII, int LLKBOGFJFDP, byte[] GPOLBJGDDLC, int JGGBJPJIJOD, [Out] IMEBMJNPCCA MEEDCIKFKIM, [Out] int KKFPACKMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A44550", Offset = "0x7A43950", VA = "0x187A44550")]
	private static ulong GJOKHBIGCHM(IMEBMJNPCCA CELIBNPACII, [Out] int JCJCPKDBOMB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7A445E0", Offset = "0x7A439E0", VA = "0x187A445E0")]
	private static void GMILKMDPLDO(IMEBMJNPCCA CELIBNPACII, [Out] LNFPJMKDMBA CEDDFJCBLGM, [Out] int AFIKFMBNDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7A440C0", Offset = "0x7A434C0", VA = "0x187A440C0")]
	private static bool CDKMOFMBHHM(IMEBMJNPCCA MEEDCIKFKIM, int LLKBOGFJFDP, [Out] double CEDDFJCBLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A44D30", Offset = "0x7A44130", VA = "0x187A44D30")]
	private static LNFPJMKDMBA KHOBKODFFCF(int LLKBOGFJFDP)
	{
		return default(LNFPJMKDMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A44860", Offset = "0x7A43C60", VA = "0x187A44860")]
	private static bool HOFPNKDMJKA(IMEBMJNPCCA CELIBNPACII, int LLKBOGFJFDP, [Out] double CEDDFJCBLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A452C0", Offset = "0x7A446C0", VA = "0x187A452C0")]
	private static bool NPEGDKEOHJI(IMEBMJNPCCA MEEDCIKFKIM, int LLKBOGFJFDP, [Out] double NNGKKLDLENF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A44740", Offset = "0x7A43B40", VA = "0x187A44740")]
	public static double? HIBELAPCFCA(IMEBMJNPCCA CELIBNPACII, int LLKBOGFJFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A43E10", Offset = "0x7A43210", VA = "0x187A43E10")]
	public static float? BICBHGOAKEB(IMEBMJNPCCA CELIBNPACII, int LLKBOGFJFDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class LHMEJLPPKPC
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[ThreadStatic]
	private static byte[] EOMFKPELLLP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly byte[] NCPBNELGCFG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly byte[] LACOCNDNJFM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly byte[] BKDHPOIFGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly int BPEKKKEBDDC;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ushort[] MOEBKBPFNEA;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly int POHLEKIHDGO;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D610", Offset = "0x7A4CA10", VA = "0x187A4D610")]
	private static byte[] OPNLBMENBDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D3A0", Offset = "0x7A4C7A0", VA = "0x187A4D3A0")]
	public static bool MELLELBILNC(SequenceReader<byte> IEMPDPINHLH, [Out] float HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C070", Offset = "0x7A4B470", VA = "0x187A4C070")]
	public static bool IKAKIGAHCFM(SequenceReader<byte> IEMPDPINHLH, [Out] double HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D4E0", Offset = "0x7A4C8E0", VA = "0x187A4D4E0")]
	private static bool NJKNFGHKFEB(int KENGFOGLPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4BDB0", Offset = "0x7A4B1B0", VA = "0x187A4BDB0")]
	private static bool EMCIGHKJEFL(SequenceReader<byte> IEMPDPINHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4BCC0", Offset = "0x7A4B0C0", VA = "0x187A4BCC0")]
	private static bool ELBBCNAOAGJ(SequenceReader<byte> IEMPDPINHLH, byte[] MHGFOFJLBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D330", Offset = "0x7A4C730", VA = "0x187A4D330")]
	private static bool MEEOLHCDECI(SequenceReader<byte> IEMPDPINHLH, byte[] KKGBCJPEHGE, int LHBPAMEKCBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A4BCA0", Offset = "0x7A4B0A0", VA = "0x187A4BCA0")]
	private static double AHFCEIOLPEO(bool FEDBNKLPNOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C1B0", Offset = "0x7A4B5B0", VA = "0x187A4C1B0")]
	private static double MAPDPPINPHG(SequenceReader<byte> AOOGNGKJLKL, bool LLJKOELNDFI, [Out] int NPCIJMMJHJB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class EAKEOLPGJKN<T> : CPEEKDGOLEA<T[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly HHGIMJBLHNI<T> PJPALELIEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly BEPEBMPOFAL NLKLADJOFON;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3C7B3F0", Offset = "0x3C7A7F0", VA = "0x183C7B3F0")]
	public EAKEOLPGJKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
	public EAKEOLPGJKN(BEPEBMPOFAL NLKLADJOFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3C7ACB0", Offset = "0x3C7A0B0", VA = "0x183C7ACB0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3C7AF00", Offset = "0x3C7A300", VA = "0x183C7AF00", Slot = "5")]
	public T[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DIELKGIIKAF<T> : CPEEKDGOLEA<ArraySegment<T>>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly HHGIMJBLHNI<T> PJPALELIEJE;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E76FC0", Offset = "0x5E763C0", VA = "0x185E76FC0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ArraySegment<T> HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E772E0", Offset = "0x5E766E0", VA = "0x185E772E0", Slot = "5")]
	public ArraySegment<T> KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class EPNICNGBFFP<T> : CPEEKDGOLEA<List<T>>, CPNGADLNAJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly BEPEBMPOFAL NLKLADJOFON;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C7B3F0", Offset = "0x3C7A7F0", VA = "0x183C7B3F0")]
	public EPNICNGBFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
	public EPNICNGBFFP(BEPEBMPOFAL NLKLADJOFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5120", Offset = "0x3CE4520", VA = "0x183CE5120", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, List<T> HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3CE72C0", Offset = "0x3CE66C0", VA = "0x183CE72C0", Slot = "5")]
	public List<T> KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public abstract class LJIHDJGEJFI<TElement, TIntermediate, TEnumerator, TCollection> : CPEEKDGOLEA<TCollection>, CPNGADLNAJB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x47DA7D0", Offset = "0x47D9BD0", VA = "0x1847DA7D0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, TCollection HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x47DAF30", Offset = "0x47DA330", VA = "0x1847DAF30", Slot = "5")]
	public TCollection KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator CAEGPOPACMP(TCollection MAPPNBHJLPD);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate KOPOAAAOIOD();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void EBDKDKCDLND(TIntermediate LCKABDAHLKO, int IIACLAMOIEE, TElement HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection FHKCAKCKHMF(TIntermediate CPBFLPMAIGD);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected LJIHDJGEJFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class HPCANNOMFIM<TElement, TIntermediate, TCollection> : LJIHDJGEJFI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4274BD0", Offset = "0x4273FD0", VA = "0x184274BD0", Slot = "6")]
	protected override IEnumerator<TElement> CAEGPOPACMP(TCollection MAPPNBHJLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3C50450", Offset = "0x3C4F850", VA = "0x183C50450")]
	protected HPCANNOMFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public abstract class KCGNHOHBFBF<TElement, TCollection> : HPCANNOMFIM<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected sealed override TCollection FHKCAKCKHMF(TCollection CPBFLPMAIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public sealed class LPKDJGFJLLP<TElement, TCollection> : KCGNHOHBFBF<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x47EFA80", Offset = "0x47EEE80", VA = "0x1847EFA80", Slot = "7")]
	protected override TCollection KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x47EFA20", Offset = "0x47EEE20", VA = "0x1847EFA20", Slot = "8")]
	protected override void EBDKDKCDLND(TCollection LCKABDAHLKO, int IIACLAMOIEE, TElement HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public sealed class LKPDJJDOIDO<T> : LJIHDJGEJFI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x423C470", Offset = "0x423B870", VA = "0x18423C470", Slot = "8")]
	protected override void EBDKDKCDLND(LinkedList<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override LinkedList<T> FHKCAKCKHMF(LinkedList<T> CPBFLPMAIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override LinkedList<T> KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x404E270", Offset = "0x404D670", VA = "0x18404E270", Slot = "6")]
	protected override LinkedList<T>.Enumerator CAEGPOPACMP(LinkedList<T> MAPPNBHJLPD)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public sealed class DELNGPDKIGB<T> : LJIHDJGEJFI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x423C470", Offset = "0x423B870", VA = "0x18423C470", Slot = "8")]
	protected override void EBDKDKCDLND(Queue<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override Queue<T> KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x423C400", Offset = "0x423B800", VA = "0x18423C400", Slot = "6")]
	protected override Queue<T>.Enumerator CAEGPOPACMP(Queue<T> MAPPNBHJLPD)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override Queue<T> FHKCAKCKHMF(Queue<T> CPBFLPMAIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public sealed class CAOOHOADGOG<T> : LJIHDJGEJFI<T, IBJNPIPGONA<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4052A00", Offset = "0x4051E00", VA = "0x184052A00", Slot = "8")]
	protected override void EBDKDKCDLND(IBJNPIPGONA<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4052A50", Offset = "0x4051E50", VA = "0x184052A50", Slot = "7")]
	protected override IBJNPIPGONA<T> KOPOAAAOIOD()
	{
		return default(IBJNPIPGONA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5607940", Offset = "0x5606D40", VA = "0x185607940", Slot = "6")]
	protected override Stack<T>.Enumerator CAEGPOPACMP(Stack<T> MAPPNBHJLPD)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x56079B0", Offset = "0x5606DB0", VA = "0x1856079B0", Slot = "9")]
	protected override Stack<T> FHKCAKCKHMF(IBJNPIPGONA<T> CPBFLPMAIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public sealed class HDNOJNLGFFE<T> : LJIHDJGEJFI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x423C470", Offset = "0x423B870", VA = "0x18423C470", Slot = "8")]
	protected override void EBDKDKCDLND(HashSet<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override HashSet<T> FHKCAKCKHMF(HashSet<T> CPBFLPMAIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override HashSet<T> KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x423C400", Offset = "0x423B800", VA = "0x18423C400", Slot = "6")]
	protected override HashSet<T>.Enumerator CAEGPOPACMP(HashSet<T> MAPPNBHJLPD)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public sealed class PHBGKBOCOCG<T> : HPCANNOMFIM<T, IBJNPIPGONA<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4052A00", Offset = "0x4051E00", VA = "0x184052A00", Slot = "8")]
	protected override void EBDKDKCDLND(IBJNPIPGONA<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4C657C0", Offset = "0x4C64BC0", VA = "0x184C657C0", Slot = "9")]
	protected override ReadOnlyCollection<T> FHKCAKCKHMF(IBJNPIPGONA<T> CPBFLPMAIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4C65870", Offset = "0x4C64C70", VA = "0x184C65870", Slot = "7")]
	protected override IBJNPIPGONA<T> KOPOAAAOIOD()
	{
		return default(IBJNPIPGONA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public sealed class BGLBHJLALNN<T> : HPCANNOMFIM<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x423C470", Offset = "0x423B870", VA = "0x18423C470", Slot = "8")]
	protected override void EBDKDKCDLND(List<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override List<T> KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override IList<T> FHKCAKCKHMF(List<T> CPBFLPMAIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public sealed class AMNDHHNIPPE<T> : HPCANNOMFIM<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x423C470", Offset = "0x423B870", VA = "0x18423C470", Slot = "8")]
	protected override void EBDKDKCDLND(List<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override List<T> KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override ICollection<T> FHKCAKCKHMF(List<T> CPBFLPMAIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class FBNLKMKOMPC<T> : HPCANNOMFIM<T, IBJNPIPGONA<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x4052A00", Offset = "0x4051E00", VA = "0x184052A00", Slot = "8")]
	protected override void EBDKDKCDLND(IBJNPIPGONA<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4052A50", Offset = "0x4051E50", VA = "0x184052A50", Slot = "7")]
	protected override IBJNPIPGONA<T> KOPOAAAOIOD()
	{
		return default(IBJNPIPGONA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x4052A30", Offset = "0x4051E30", VA = "0x184052A30", Slot = "9")]
	protected override IEnumerable<T> FHKCAKCKHMF(IBJNPIPGONA<T> CPBFLPMAIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F5A0", Offset = "0x3C4E9A0", VA = "0x183C4F5A0")]
	public FBNLKMKOMPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class HJLBCBEJLGK<TKey, TElement> : CPEEKDGOLEA<IGrouping<TKey, TElement>>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x425C650", Offset = "0x425BA50", VA = "0x18425C650", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, IGrouping<TKey, TElement> HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x425C950", Offset = "0x425BD50", VA = "0x18425C950", Slot = "5")]
	public IGrouping<TKey, TElement> KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class JPMNBDAHJOB<TKey, TElement> : CPEEKDGOLEA<ILookup<TKey, TElement>>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x45A5330", Offset = "0x45A4730", VA = "0x1845A5330", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ILookup<TKey, TElement> HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x45A5470", Offset = "0x45A4870", VA = "0x1845A5470", Slot = "5")]
	public ILookup<TKey, TElement> KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal class KEIOKGPJCLN<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly TKey LDCKBFKFIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly IEnumerable<TElement> MFECDBFEDPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey ECHGIIKNGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	public KEIOKGPJCLN(TKey LDCKBFKFIKC, IEnumerable<TElement> MFECDBFEDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4663040", Offset = "0x4662440", VA = "0x184663040", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E0B0", Offset = "0x3D2D4B0", VA = "0x183D2E0B0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DefaultMember("Item")]
internal class PAPACGJDJGO<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> FHCPBJBIAFL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TElement> EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4053A20", Offset = "0x4052E20", VA = "0x184053A20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public PAPACGJDJGO(Dictionary<TKey, IGrouping<TKey, TElement>> FHCPBJBIAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F66840", Offset = "0x2F65C40", VA = "0x182F66840", Slot = "5")]
	public bool Contains(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C44200", Offset = "0x4C43600", VA = "0x184C44200", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C44200", Offset = "0x4C43600", VA = "0x184C44200", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public sealed class LHAPEFJDLNE<T> : CPEEKDGOLEA<T>, CPNGADLNAJB where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x47CC220", Offset = "0x47CB620", VA = "0x1847CC220", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x47CC530", Offset = "0x47CB930", VA = "0x1847CC530", Slot = "5")]
	public T KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LHAPEFJDLNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public sealed class JPGMFILGFKF : CPEEKDGOLEA<IEnumerable>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly CPEEKDGOLEA<IEnumerable> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A720", Offset = "0x7A49B20", VA = "0x187A4A720", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, IEnumerable HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A9D0", Offset = "0x7A49DD0", VA = "0x187A4A9D0", Slot = "5")]
	public IEnumerable KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public JPGMFILGFKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public sealed class MIBCDAELDOE : CPEEKDGOLEA<ICollection>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly CPEEKDGOLEA<ICollection> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F3D0", Offset = "0x7A4E7D0", VA = "0x187A4F3D0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ICollection HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F770", Offset = "0x7A4EB70", VA = "0x187A4F770", Slot = "5")]
	public ICollection KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MIBCDAELDOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public sealed class KPDFKOLMJHP : CPEEKDGOLEA<IList>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly CPEEKDGOLEA<IList> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B410", Offset = "0x7A4A810", VA = "0x187A4B410", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, IList HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B720", Offset = "0x7A4AB20", VA = "0x187A4B720", Slot = "5")]
	public IList KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KPDFKOLMJHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public sealed class BNHHHJHDEHP<T> : HPCANNOMFIM<T, IBJNPIPGONA<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5425FA0", Offset = "0x54253A0", VA = "0x185425FA0", Slot = "8")]
	protected override void EBDKDKCDLND(IBJNPIPGONA<T> LCKABDAHLKO, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4052A50", Offset = "0x4051E50", VA = "0x184052A50", Slot = "7")]
	protected override IBJNPIPGONA<T> KOPOAAAOIOD()
	{
		return default(IBJNPIPGONA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5426000", Offset = "0x5425400", VA = "0x185426000", Slot = "9")]
	protected override IReadOnlyList<T> FHKCAKCKHMF(IBJNPIPGONA<T> CPBFLPMAIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A0E0", Offset = "0x3C694E0", VA = "0x183C6A0E0")]
	public BNHHHJHDEHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class FBOCECHOJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum LJFBAALCAAE
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Year,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		YearMonth,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		YearMonthDay,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		YearMonthDayTime
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7A45B90", Offset = "0x7A44F90", VA = "0x187A45B90")]
	public static DateTime BFDFOGNGDCN(DateTime MKMNAFLLFPB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7A45E80", Offset = "0x7A45280", VA = "0x187A45E80")]
	public static bool HJEKPLLBFLE(SequenceReader<byte> IEMPDPINHLH, [Out] int OHEAJJLOMJN, [Out] int NHHEAJADCCN, [Out] int HEDNOHNNDFF, [Out] int BHFMDNMNHOL, [Out] int IACGPMJGOAJ, [Out] int KGLNDGDAEOK, [Out] int FCPGIDDFEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7A46240", Offset = "0x7A45640", VA = "0x187A46240")]
	public static bool PFOHPDPBJID(SequenceReader<byte> IEMPDPINHLH, [Out] int BHFMDNMNHOL, [Out] int IACGPMJGOAJ, [Out] int KGLNDGDAEOK, [Out] int FCPGIDDFEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7A46030", Offset = "0x7A45430", VA = "0x187A46030")]
	public static bool PFOHPDPBJID(SequenceReader<byte> IEMPDPINHLH, [Out] int HEDNOHNNDFF, [Out] int BHFMDNMNHOL, [Out] int IACGPMJGOAJ, [Out] int KGLNDGDAEOK, [Out] int FCPGIDDFEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7A45C50", Offset = "0x7A45050", VA = "0x187A45C50")]
	public static bool COBNFGOFHKP(SequenceReader<byte> IEMPDPINHLH, [Out] TimeSpan? LHBPAMEKCBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class INPGFDGPAMM : CPEEKDGOLEA<DateTime>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static readonly CPEEKDGOLEA<DateTime> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7A49350", Offset = "0x7A48750", VA = "0x187A49350", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, DateTime HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7A49B00", Offset = "0x7A48F00", VA = "0x187A49B00", Slot = "5")]
	public DateTime KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7A49C80", Offset = "0x7A49080", VA = "0x187A49C80")]
	private static DateTime KBLFJIABLOP([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public INPGFDGPAMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public sealed class FFKOPNBCJFA : CPEEKDGOLEA<DateTimeOffset>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static readonly CPEEKDGOLEA<DateTimeOffset> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7A464D0", Offset = "0x7A458D0", VA = "0x187A464D0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, DateTimeOffset HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7A46B70", Offset = "0x7A45F70", VA = "0x187A46B70", Slot = "5")]
	public DateTimeOffset KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7A46BE0", Offset = "0x7A45FE0", VA = "0x187A46BE0")]
	private DateTimeOffset KBLFJIABLOP([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FFKOPNBCJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public sealed class PEKPEOFOOLK : CPEEKDGOLEA<TimeSpan>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly CPEEKDGOLEA<TimeSpan> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static byte[] NGFNFNCGODF;

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7A50E70", Offset = "0x7A50270", VA = "0x187A50E70", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, TimeSpan HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7A51250", Offset = "0x7A50650", VA = "0x187A51250", Slot = "5")]
	public TimeSpan KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7A512D0", Offset = "0x7A506D0", VA = "0x187A512D0")]
	private static TimeSpan KBLFJIABLOP([In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public PEKPEOFOOLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public abstract class JDIIONDBJIF<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : CPEEKDGOLEA<TDictionary>, CPNGADLNAJB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4577640", Offset = "0x4576A40", VA = "0x184577640", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, TDictionary HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4579090", Offset = "0x4578490", VA = "0x184579090", Slot = "5")]
	public TDictionary KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator CAEGPOPACMP(TDictionary MAPPNBHJLPD);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate KOPOAAAOIOD();

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void EBDKDKCDLND(TIntermediate LCKABDAHLKO, int IIACLAMOIEE, TKey LDCKBFKFIKC, TValue HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary FHKCAKCKHMF(TIntermediate CPBFLPMAIGD);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected JDIIONDBJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public abstract class KGKCJIKLHOH<TKey, TValue, TIntermediate, TDictionary> : JDIIONDBJIF<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4274BD0", Offset = "0x4273FD0", VA = "0x184274BD0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> CAEGPOPACMP(TDictionary MAPPNBHJLPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public abstract class FNEIHPAPKCN<TKey, TValue, TDictionary> : KGKCJIKLHOH<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override TDictionary FHKCAKCKHMF(TDictionary CPBFLPMAIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class FACGKIFPPHN<TKey, TValue> : JDIIONDBJIF<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x404E3B0", Offset = "0x404D7B0", VA = "0x18404E3B0", Slot = "8")]
	protected override void EBDKDKCDLND(Dictionary<TKey, TValue> LCKABDAHLKO, int IIACLAMOIEE, TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override Dictionary<TKey, TValue> FHKCAKCKHMF(Dictionary<TKey, TValue> CPBFLPMAIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override Dictionary<TKey, TValue> KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x404E1F0", Offset = "0x404D5F0", VA = "0x18404E1F0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator CAEGPOPACMP(Dictionary<TKey, TValue> MAPPNBHJLPD)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3C4EFF0", Offset = "0x3C4E3F0", VA = "0x183C4EFF0")]
	public FACGKIFPPHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class NNHCBKGEPMO<TKey, TValue, TDictionary> : FNEIHPAPKCN<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D610", Offset = "0x4A9CA10", VA = "0x184A9D610", Slot = "8")]
	protected override void EBDKDKCDLND(TDictionary LCKABDAHLKO, int IIACLAMOIEE, TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x39BBB50", Offset = "0x39BAF50", VA = "0x1839BBB50", Slot = "7")]
	protected override TDictionary KOPOAAAOIOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public sealed class JBNBEAKJHPO<TKey, TValue> : KGKCJIKLHOH<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x404E500", Offset = "0x404D900", VA = "0x18404E500", Slot = "8")]
	protected override void EBDKDKCDLND(Dictionary<TKey, TValue> LCKABDAHLKO, int IIACLAMOIEE, TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override Dictionary<TKey, TValue> KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override IDictionary<TKey, TValue> FHKCAKCKHMF(Dictionary<TKey, TValue> CPBFLPMAIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public sealed class CIPOIJABJKC<TKey, TValue> : FNEIHPAPKCN<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x404E500", Offset = "0x404D900", VA = "0x18404E500", Slot = "8")]
	protected override void EBDKDKCDLND(SortedList<TKey, TValue> LCKABDAHLKO, int IIACLAMOIEE, TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override SortedList<TKey, TValue> KOPOAAAOIOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class MFJPBIGKFJL<TKey, TValue> : JDIIONDBJIF<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x404E500", Offset = "0x404D900", VA = "0x18404E500", Slot = "8")]
	protected override void EBDKDKCDLND(SortedDictionary<TKey, TValue> LCKABDAHLKO, int IIACLAMOIEE, TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> FHKCAKCKHMF(SortedDictionary<TKey, TValue> CPBFLPMAIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x404E560", Offset = "0x404D960", VA = "0x18404E560", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> KOPOAAAOIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x404E180", Offset = "0x404D580", VA = "0x18404E180", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator CAEGPOPACMP(SortedDictionary<TKey, TValue> MAPPNBHJLPD)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class GMFOEAGNLLP<T> : CPEEKDGOLEA<T>, CPNGADLNAJB where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x41A84A0", Offset = "0x41A78A0", VA = "0x1841A84A0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x41A8970", Offset = "0x41A7D70", VA = "0x1841A8970", Slot = "5")]
	public T KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GMFOEAGNLLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class OANCFNICLLI : CPEEKDGOLEA<IDictionary>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly CPEEKDGOLEA<IDictionary> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7A4FA10", Offset = "0x7A4EE10", VA = "0x187A4FA10", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, IDictionary HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7A4FEE0", Offset = "0x7A4F2E0", VA = "0x187A4FEE0", Slot = "5")]
	public IDictionary KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OANCFNICLLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class MFAKDDPKJLN
{
	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E830", Offset = "0x7A4DC30", VA = "0x187A4E830")]
	public static object NCMLIBIIJCN(Type IFBDJLKPHIG, [Out] bool PLAIBPOIFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DFA0", Offset = "0x7A4D3A0", VA = "0x187A4DFA0")]
	public static object MEHOHGBPEOP(Type IFBDJLKPHIG, [Out] bool PLAIBPOIFGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class PMADGGPPOFE<T> : CPEEKDGOLEA<T>, CPNGADLNAJB, DGFKOFNBIKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class HMGFCPKJAGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HMGFCPKJAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x426F760", Offset = "0x426EB60", VA = "0x18426F760")]
		internal bool AIKBHFCDOCB(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class FCMGKBKKFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FCMGKBKKFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x4054570", Offset = "0x4053970", VA = "0x184054570")]
		internal bool LEENNNMBKNL(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class NLGBNKKEKHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public BPCAMHJDKJG<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NLGBNKKEKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4A9B4C0", Offset = "0x4A9A8C0", VA = "0x184A9B4C0")]
		internal void JLIPBJKACLI(LKMCFLGDNPK writer, T value, CLCGJCMKMCJ _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class MFLJGFFKCJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AAPBCAPDAHK<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MFLJGFFKCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x49EA0C0", Offset = "0x49E94C0", VA = "0x1849EA0C0")]
		internal T CLMGMIKJDOP(BKAFFJDLIHE reader, CLCGJCMKMCJ _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly COCMPADNGJN<T> KOGCBGENDCI;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly Dictionary<T, string> DIECMGHADIN;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly BPCAMHJDKJG<T> NBOMEMLPEIB;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly AAPBCAPDAHK<T> GCMCHFIOFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly bool DPALBDNDJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly BPCAMHJDKJG<T> PJEMFKMKNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly AAPBCAPDAHK<T> EMIFMJGFPCP;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4C7D1C0", Offset = "0x4C7C5C0", VA = "0x184C7D1C0")]
	static PMADGGPPOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EA60", Offset = "0x4C8DE60", VA = "0x184C8EA60")]
	public PMADGGPPOFE(bool DPALBDNDJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4C75990", Offset = "0x4C74D90", VA = "0x184C75990", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4C7A660", Offset = "0x4C79A60", VA = "0x184C7A660", Slot = "5")]
	public T KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4C76C30", Offset = "0x4C76030", VA = "0x184C76C30", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, T HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4C7AEA0", Offset = "0x4C7A2A0", VA = "0x184C7AEA0", Slot = "7")]
	public T PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class DOBIGHIFJBP<T> : CPEEKDGOLEA<T[,]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AAC0", Offset = "0x5E89EC0", VA = "0x185E8AAC0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T[,] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AD50", Offset = "0x5E8A150", VA = "0x185E8AD50", Slot = "5")]
	public T[,] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DOBIGHIFJBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public sealed class CNDMKNIBHPB<T> : CPEEKDGOLEA<T[,,]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5903EF0", Offset = "0x59032F0", VA = "0x185903EF0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T[,,] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x5904220", Offset = "0x5903620", VA = "0x185904220", Slot = "5")]
	public T[,,] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public CNDMKNIBHPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public sealed class JMPOHNFNKKP<T> : CPEEKDGOLEA<T[,,,]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4596E90", Offset = "0x4596290", VA = "0x184596E90", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T[,,,] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4597270", Offset = "0x4596670", VA = "0x184597270", Slot = "5")]
	public T[,,,] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public JMPOHNFNKKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class BHMLKFGEHKP<T> : CPEEKDGOLEA<T?>, CPNGADLNAJB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x53D70F0", Offset = "0x53D64F0", VA = "0x1853D70F0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x53D75F0", Offset = "0x53D69F0", VA = "0x1853D75F0", Slot = "5")]
	public T? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BHMLKFGEHKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class MPEAIIEMGIC<T> : CPEEKDGOLEA<T?>, CPNGADLNAJB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly CPEEKDGOLEA<T> AMGGFPNOBDB;

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public MPEAIIEMGIC(CPEEKDGOLEA<T> AMGGFPNOBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4A18DF0", Offset = "0x4A181F0", VA = "0x184A18DF0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, T? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4A194B0", Offset = "0x4A188B0", VA = "0x184A194B0", Slot = "5")]
	public T? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public sealed class BDJGCDNNFBM : CPEEKDGOLEA<sbyte>, CPNGADLNAJB, DGFKOFNBIKP<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly BDJGCDNNFBM LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7A42550", Offset = "0x7A41950", VA = "0x187A42550", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, sbyte HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7A42620", Offset = "0x7A41A20", VA = "0x187A42620", Slot = "5")]
	public sbyte KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7A425B0", Offset = "0x7A419B0", VA = "0x187A425B0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, sbyte HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7A42630", Offset = "0x7A41A30", VA = "0x187A42630", Slot = "7")]
	public sbyte PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BDJGCDNNFBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class IMKFEGCMONE : CPEEKDGOLEA<sbyte?>, CPNGADLNAJB, DGFKOFNBIKP<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static readonly IMKFEGCMONE LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7A49040", Offset = "0x7A48440", VA = "0x187A49040", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, sbyte? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x7A491C0", Offset = "0x7A485C0", VA = "0x187A491C0", Slot = "5")]
	public sbyte? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x7A49100", Offset = "0x7A48500", VA = "0x187A49100", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, sbyte? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x7A49230", Offset = "0x7A48630", VA = "0x187A49230", Slot = "7")]
	public sbyte? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IMKFEGCMONE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class LMMJOHDJMJN : CPEEKDGOLEA<sbyte[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly LMMJOHDJMJN LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DB20", Offset = "0x7A4CF20", VA = "0x187A4DB20", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, sbyte[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DC50", Offset = "0x7A4D050", VA = "0x187A4DC50", Slot = "5")]
	public sbyte[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LMMJOHDJMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public sealed class HMEJIGNPECB : CPEEKDGOLEA<short>, CPNGADLNAJB, DGFKOFNBIKP<short>
{
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static readonly HMEJIGNPECB LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7A488B0", Offset = "0x7A47CB0", VA = "0x187A488B0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, short HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7A48980", Offset = "0x7A47D80", VA = "0x187A48980", Slot = "5")]
	public short KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7A48910", Offset = "0x7A47D10", VA = "0x187A48910", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, short HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7A48990", Offset = "0x7A47D90", VA = "0x187A48990", Slot = "7")]
	public short PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HMEJIGNPECB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public sealed class GCIGCDMFNJE : CPEEKDGOLEA<short?>, CPNGADLNAJB, DGFKOFNBIKP<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static readonly GCIGCDMFNJE LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7A47340", Offset = "0x7A46740", VA = "0x187A47340", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, short? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7A474C0", Offset = "0x7A468C0", VA = "0x187A474C0", Slot = "5")]
	public short? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7A47400", Offset = "0x7A46800", VA = "0x187A47400", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, short? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7A47530", Offset = "0x7A46930", VA = "0x187A47530", Slot = "7")]
	public short? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GCIGCDMFNJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public sealed class BCOHBCNLNDP : CPEEKDGOLEA<short[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly BCOHBCNLNDP LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7A42270", Offset = "0x7A41670", VA = "0x187A42270", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, short[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7A423A0", Offset = "0x7A417A0", VA = "0x187A423A0", Slot = "5")]
	public short[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BCOHBCNLNDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class KHHKIOCMJJC : CPEEKDGOLEA<int>, CPNGADLNAJB, DGFKOFNBIKP<int>
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly KHHKIOCMJJC LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7A4AF70", Offset = "0x7A4A370", VA = "0x187A4AF70", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, int HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B040", Offset = "0x7A4A440", VA = "0x187A4B040", Slot = "5")]
	public int KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4AFD0", Offset = "0x7A4A3D0", VA = "0x187A4AFD0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, int HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B050", Offset = "0x7A4A450", VA = "0x187A4B050", Slot = "7")]
	public int PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KHHKIOCMJJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public sealed class KHMPGAFJHCD : CPEEKDGOLEA<int?>, CPNGADLNAJB, DGFKOFNBIKP<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static readonly KHMPGAFJHCD LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B110", Offset = "0x7A4A510", VA = "0x187A4B110", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, int? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B290", Offset = "0x7A4A690", VA = "0x187A4B290", Slot = "5")]
	public int? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B1D0", Offset = "0x7A4A5D0", VA = "0x187A4B1D0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, int? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B300", Offset = "0x7A4A700", VA = "0x187A4B300", Slot = "7")]
	public int? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KHMPGAFJHCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class IJJNFFPDADM : CPEEKDGOLEA<int[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly IJJNFFPDADM LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A48CC0", Offset = "0x7A480C0", VA = "0x187A48CC0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, int[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A48DF0", Offset = "0x7A481F0", VA = "0x187A48DF0", Slot = "5")]
	public int[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IJJNFFPDADM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class JBFDOFLLPHN : CPEEKDGOLEA<long>, CPNGADLNAJB, DGFKOFNBIKP<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static readonly JBFDOFLLPHN LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A260", Offset = "0x7A49660", VA = "0x187A4A260", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, long HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A330", Offset = "0x7A49730", VA = "0x187A4A330", Slot = "5")]
	public long KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A2C0", Offset = "0x7A496C0", VA = "0x187A4A2C0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, long HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A340", Offset = "0x7A49740", VA = "0x187A4A340", Slot = "7")]
	public long PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public JBFDOFLLPHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public sealed class GEIBFOJMEDB : CPEEKDGOLEA<long?>, CPNGADLNAJB, DGFKOFNBIKP<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly GEIBFOJMEDB LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A47640", Offset = "0x7A46A40", VA = "0x187A47640", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, long? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A477C0", Offset = "0x7A46BC0", VA = "0x187A477C0", Slot = "5")]
	public long? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A47700", Offset = "0x7A46B00", VA = "0x187A47700", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, long? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A47850", Offset = "0x7A46C50", VA = "0x187A47850", Slot = "7")]
	public long? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GEIBFOJMEDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class PGCKBFAPKLA : CPEEKDGOLEA<long[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly PGCKBFAPKLA LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A51810", Offset = "0x7A50C10", VA = "0x187A51810", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, long[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7A51940", Offset = "0x7A50D40", VA = "0x187A51940", Slot = "5")]
	public long[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public PGCKBFAPKLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class LKOEBCBCNDM : CPEEKDGOLEA<byte>, CPNGADLNAJB, DGFKOFNBIKP<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static readonly LKOEBCBCNDM LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D980", Offset = "0x7A4CD80", VA = "0x187A4D980", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, byte HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DA50", Offset = "0x7A4CE50", VA = "0x187A4DA50", Slot = "5")]
	public byte KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D9E0", Offset = "0x7A4CDE0", VA = "0x187A4D9E0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, byte HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DA60", Offset = "0x7A4CE60", VA = "0x187A4DA60", Slot = "7")]
	public byte PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LKOEBCBCNDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class MHEDKJFGNHF : CPEEKDGOLEA<byte?>, CPNGADLNAJB, DGFKOFNBIKP<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly MHEDKJFGNHF LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F0C0", Offset = "0x7A4E4C0", VA = "0x187A4F0C0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, byte? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F240", Offset = "0x7A4E640", VA = "0x187A4F240", Slot = "5")]
	public byte? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F180", Offset = "0x7A4E580", VA = "0x187A4F180", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, byte? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F2B0", Offset = "0x7A4E6B0", VA = "0x187A4F2B0", Slot = "7")]
	public byte? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MHEDKJFGNHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public sealed class BFDNCEJBEIF : CPEEKDGOLEA<ushort>, CPNGADLNAJB, DGFKOFNBIKP<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly BFDNCEJBEIF LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A426F0", Offset = "0x7A41AF0", VA = "0x187A426F0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ushort HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7A427C0", Offset = "0x7A41BC0", VA = "0x187A427C0", Slot = "5")]
	public ushort KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7A42750", Offset = "0x7A41B50", VA = "0x187A42750", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, ushort HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7A427D0", Offset = "0x7A41BD0", VA = "0x187A427D0", Slot = "7")]
	public ushort PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BFDNCEJBEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class KAAMJPGLFHF : CPEEKDGOLEA<ushort?>, CPNGADLNAJB, DGFKOFNBIKP<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static readonly KAAMJPGLFHF LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4AC70", Offset = "0x7A4A070", VA = "0x187A4AC70", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ushort? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ADF0", Offset = "0x7A4A1F0", VA = "0x187A4ADF0", Slot = "5")]
	public ushort? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A4AD30", Offset = "0x7A4A130", VA = "0x187A4AD30", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, ushort? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A4AE60", Offset = "0x7A4A260", VA = "0x187A4AE60", Slot = "7")]
	public ushort? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KAAMJPGLFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class LCOEIHAHIPN : CPEEKDGOLEA<ushort[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static readonly LCOEIHAHIPN LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B9C0", Offset = "0x7A4ADC0", VA = "0x187A4B9C0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ushort[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A4BAF0", Offset = "0x7A4AEF0", VA = "0x187A4BAF0", Slot = "5")]
	public ushort[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LCOEIHAHIPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public sealed class OFIDGGAKELA : CPEEKDGOLEA<uint>, CPNGADLNAJB, DGFKOFNBIKP<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static readonly OFIDGGAKELA LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A506F0", Offset = "0x7A4FAF0", VA = "0x187A506F0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, uint HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A507C0", Offset = "0x7A4FBC0", VA = "0x187A507C0", Slot = "5")]
	public uint KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A50750", Offset = "0x7A4FB50", VA = "0x187A50750", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, uint HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A507D0", Offset = "0x7A4FBD0", VA = "0x187A507D0", Slot = "7")]
	public uint PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OFIDGGAKELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public sealed class DENEHAOFEPI : CPEEKDGOLEA<uint?>, CPNGADLNAJB, DGFKOFNBIKP<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static readonly DENEHAOFEPI LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A43540", Offset = "0x7A42940", VA = "0x187A43540", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, uint? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7A436C0", Offset = "0x7A42AC0", VA = "0x187A436C0", Slot = "5")]
	public uint? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7A43600", Offset = "0x7A42A00", VA = "0x187A43600", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, uint? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A43730", Offset = "0x7A42B30", VA = "0x187A43730", Slot = "7")]
	public uint? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DENEHAOFEPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class OEACMPIEEIO : CPEEKDGOLEA<uint[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly OEACMPIEEIO LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7A50120", Offset = "0x7A4F520", VA = "0x187A50120", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, uint[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A50250", Offset = "0x7A4F650", VA = "0x187A50250", Slot = "5")]
	public uint[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OEACMPIEEIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class HIABOEFPBML : CPEEKDGOLEA<ulong>, CPNGADLNAJB, DGFKOFNBIKP<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static readonly HIABOEFPBML LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7A48180", Offset = "0x7A47580", VA = "0x187A48180", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ulong HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7A48250", Offset = "0x7A47650", VA = "0x187A48250", Slot = "5")]
	public ulong KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7A481E0", Offset = "0x7A475E0", VA = "0x187A481E0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, ulong HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7A48260", Offset = "0x7A47660", VA = "0x187A48260", Slot = "7")]
	public ulong PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HIABOEFPBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public sealed class EMKEEPMEPAE : CPEEKDGOLEA<ulong?>, CPNGADLNAJB, DGFKOFNBIKP<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static readonly EMKEEPMEPAE LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7A45850", Offset = "0x7A44C50", VA = "0x187A45850", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ulong? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7A459D0", Offset = "0x7A44DD0", VA = "0x187A459D0", Slot = "5")]
	public ulong? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7A45910", Offset = "0x7A44D10", VA = "0x187A45910", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, ulong? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7A45A60", Offset = "0x7A44E60", VA = "0x187A45A60", Slot = "7")]
	public ulong? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EMKEEPMEPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public sealed class DDDENGBOFPE : CPEEKDGOLEA<ulong[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static readonly DDDENGBOFPE LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7A43260", Offset = "0x7A42660", VA = "0x187A43260", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ulong[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7A43390", Offset = "0x7A42790", VA = "0x187A43390", Slot = "5")]
	public ulong[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DDDENGBOFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public sealed class PKJKKKGEFNB : CPEEKDGOLEA<float>, CPNGADLNAJB, DGFKOFNBIKP<float>
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static readonly PKJKKKGEFNB LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7A51C90", Offset = "0x7A51090", VA = "0x187A51C90", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, float HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7A51D60", Offset = "0x7A51160", VA = "0x187A51D60", Slot = "5")]
	public float KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7A51CF0", Offset = "0x7A510F0", VA = "0x187A51CF0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, float HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7A51D70", Offset = "0x7A51170", VA = "0x187A51D70", Slot = "7")]
	public float PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public PKJKKKGEFNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class ACPPNJOJAOO : CPEEKDGOLEA<float?>, CPNGADLNAJB, DGFKOFNBIKP<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static readonly ACPPNJOJAOO LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7A41F60", Offset = "0x7A41360", VA = "0x187A41F60", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, float? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7A420E0", Offset = "0x7A414E0", VA = "0x187A420E0", Slot = "5")]
	public float? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7A42020", Offset = "0x7A41420", VA = "0x187A42020", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, float? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7A42150", Offset = "0x7A41550", VA = "0x187A42150", Slot = "7")]
	public float? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public ACPPNJOJAOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class ONMDOPAGFHA : CPEEKDGOLEA<float[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static readonly ONMDOPAGFHA LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7A50B80", Offset = "0x7A4FF80", VA = "0x187A50B80", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, float[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7A50CC0", Offset = "0x7A500C0", VA = "0x187A50CC0", Slot = "5")]
	public float[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public ONMDOPAGFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class PIKLIJGAJLO : CPEEKDGOLEA<double>, CPNGADLNAJB, DGFKOFNBIKP<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static readonly PIKLIJGAJLO LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7A51AF0", Offset = "0x7A50EF0", VA = "0x187A51AF0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, double HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7A51BC0", Offset = "0x7A50FC0", VA = "0x187A51BC0", Slot = "5")]
	public double KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7A51B50", Offset = "0x7A50F50", VA = "0x187A51B50", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, double HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7A51BD0", Offset = "0x7A50FD0", VA = "0x187A51BD0", Slot = "7")]
	public double PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public PIKLIJGAJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public sealed class PLLBHJDMGGL : CPEEKDGOLEA<double?>, CPNGADLNAJB, DGFKOFNBIKP<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static readonly PLLBHJDMGGL LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7A51E30", Offset = "0x7A51230", VA = "0x187A51E30", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, double? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7A51FB0", Offset = "0x7A513B0", VA = "0x187A51FB0", Slot = "5")]
	public double? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7A51EF0", Offset = "0x7A512F0", VA = "0x187A51EF0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, double? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7A52040", Offset = "0x7A51440", VA = "0x187A52040", Slot = "7")]
	public double? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public PLLBHJDMGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class OGJLAKFFEGM : CPEEKDGOLEA<double[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static readonly OGJLAKFFEGM LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7A50890", Offset = "0x7A4FC90", VA = "0x187A50890", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, double[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7A509D0", Offset = "0x7A4FDD0", VA = "0x187A509D0", Slot = "5")]
	public double[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OGJLAKFFEGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class EBPAFLHLOCC : CPEEKDGOLEA<bool>, CPNGADLNAJB, DGFKOFNBIKP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static readonly EBPAFLHLOCC LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7A43980", Offset = "0x7A42D80", VA = "0x187A43980", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, bool HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7A43A50", Offset = "0x7A42E50", VA = "0x187A43A50", Slot = "5")]
	public bool KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7A439E0", Offset = "0x7A42DE0", VA = "0x187A439E0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, bool HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7A43A60", Offset = "0x7A42E60", VA = "0x187A43A60", Slot = "7")]
	public bool PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EBPAFLHLOCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class FJOHEJJBDJG : CPEEKDGOLEA<bool?>, CPNGADLNAJB, DGFKOFNBIKP<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static readonly FJOHEJJBDJG LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x7A47030", Offset = "0x7A46430", VA = "0x187A47030", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, bool? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7A471B0", Offset = "0x7A465B0", VA = "0x187A471B0", Slot = "5")]
	public bool? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x7A470F0", Offset = "0x7A464F0", VA = "0x187A470F0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, bool? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x7A47220", Offset = "0x7A46620", VA = "0x187A47220", Slot = "7")]
	public bool? PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FJOHEJJBDJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class OFBNMJEGCEN : CPEEKDGOLEA<bool[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static readonly OFBNMJEGCEN LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7A50400", Offset = "0x7A4F800", VA = "0x187A50400", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, bool[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7A50540", Offset = "0x7A4F940", VA = "0x187A50540", Slot = "5")]
	public bool[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OFBNMJEGCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class GOHKLIKDJHC : CPEEKDGOLEA<byte[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static readonly CPEEKDGOLEA<byte[]> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7A47D80", Offset = "0x7A47180", VA = "0x187A47D80", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, byte[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7A47E40", Offset = "0x7A47240", VA = "0x187A47E40", Slot = "5")]
	public byte[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GOHKLIKDJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class HNDBLGMHBLF : CPEEKDGOLEA<ArraySegment<byte>>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly CPEEKDGOLEA<ArraySegment<byte>> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7A48A50", Offset = "0x7A47E50", VA = "0x187A48A50", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, ArraySegment<byte> HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7A48B80", Offset = "0x7A47F80", VA = "0x187A48B80", Slot = "5")]
	public ArraySegment<byte> KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HNDBLGMHBLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class DIJMKOEPANG : CPEEKDGOLEA<string>, CPNGADLNAJB, DGFKOFNBIKP<string>
{
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static readonly CPEEKDGOLEA<string> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7A43840", Offset = "0x7A42C40", VA = "0x187A43840", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, string HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7A43900", Offset = "0x7A42D00", VA = "0x187A43900", Slot = "5")]
	public string KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7A438A0", Offset = "0x7A42CA0", VA = "0x187A438A0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, string HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7A43900", Offset = "0x7A42D00", VA = "0x187A43900", Slot = "7")]
	public string PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DIJMKOEPANG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class JEOFAPKOLCH : CPEEKDGOLEA<string[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static readonly JEOFAPKOLCH LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A400", Offset = "0x7A49800", VA = "0x187A4A400", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, string[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A530", Offset = "0x7A49930", VA = "0x187A4A530", Slot = "5")]
	public string[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public JEOFAPKOLCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class IPDCOMGHAOM : CPEEKDGOLEA<char>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly IPDCOMGHAOM LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A100", Offset = "0x7A49500", VA = "0x187A4A100", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, char HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A1C0", Offset = "0x7A495C0", VA = "0x187A4A1C0", Slot = "5")]
	public char KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IPDCOMGHAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class BGMKPGDGPMJ : CPEEKDGOLEA<char?>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static readonly BGMKPGDGPMJ LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7A42B50", Offset = "0x7A41F50", VA = "0x187A42B50", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, char? HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7A42C50", Offset = "0x7A42050", VA = "0x187A42C50", Slot = "5")]
	public char? KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BGMKPGDGPMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class HJJCNONJNCJ : CPEEKDGOLEA<char[]>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static readonly HJJCNONJNCJ LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7A48500", Offset = "0x7A47900", VA = "0x187A48500", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, char[] HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7A486B0", Offset = "0x7A47AB0", VA = "0x187A486B0", Slot = "5")]
	public char[] KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HJJCNONJNCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class EMHONDNPMCN : CPEEKDGOLEA<Guid>, CPNGADLNAJB, DGFKOFNBIKP<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public static readonly CPEEKDGOLEA<Guid> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7A454A0", Offset = "0x7A448A0", VA = "0x187A454A0", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, Guid HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7A45710", Offset = "0x7A44B10", VA = "0x187A45710", Slot = "5")]
	public Guid KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7A455D0", Offset = "0x7A449D0", VA = "0x187A455D0", Slot = "6")]
	public void HKAIOLDCBBI(LKMCFLGDNPK EEKKIBDAGAJ, Guid HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7A45770", Offset = "0x7A44B70", VA = "0x187A45770", Slot = "7")]
	public Guid PJBEJAAPCOC(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EMHONDNPMCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class GNFMHPJALOO : CPEEKDGOLEA<decimal>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static readonly CPEEKDGOLEA<decimal> LNPPLFIHDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly bool DLBMIHBELIL;

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x60678F0", Offset = "0x6066CF0", VA = "0x1860678F0")]
	public GNFMHPJALOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x20DF720", Offset = "0x20DEB20", VA = "0x1820DF720")]
	public GNFMHPJALOO(bool DLBMIHBELIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7A47980", Offset = "0x7A46D80", VA = "0x187A47980", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, decimal HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7A47B30", Offset = "0x7A46F30", VA = "0x187A47B30", Slot = "5")]
	public decimal KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class HJCJPCDIHEG : CPEEKDGOLEA<Uri>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public static readonly CPEEKDGOLEA<Uri> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7A48320", Offset = "0x7A47720", VA = "0x187A48320", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, Uri HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7A48400", Offset = "0x7A47800", VA = "0x187A48400", Slot = "5")]
	public Uri KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HJCJPCDIHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BKLPOIBLPOM : CPEEKDGOLEA<Version>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly CPEEKDGOLEA<Version> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7A42D80", Offset = "0x7A42180", VA = "0x187A42D80", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, Version HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7A42E40", Offset = "0x7A42240", VA = "0x187A42E40", Slot = "5")]
	public Version KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BKLPOIBLPOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NJPDPIMGGBM<TKey, TValue> : CPEEKDGOLEA<KeyValuePair<TKey, TValue>>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x4A92070", Offset = "0x4A91470", VA = "0x184A92070", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, KeyValuePair<TKey, TValue> HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x4A92280", Offset = "0x4A91680", VA = "0x184A92280", Slot = "5")]
	public KeyValuePair<TKey, TValue> KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class MEDOPKDBEMK : CPEEKDGOLEA<StringBuilder>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public static readonly CPEEKDGOLEA<StringBuilder> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DE00", Offset = "0x7A4D200", VA = "0x187A4DE00", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, StringBuilder HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DEA0", Offset = "0x7A4D2A0", VA = "0x187A4DEA0", Slot = "5")]
	public StringBuilder KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MEDOPKDBEMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class BGIALJNOOCI : CPEEKDGOLEA<BitArray>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly CPEEKDGOLEA<BitArray> LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7A42890", Offset = "0x7A41C90", VA = "0x187A42890", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, BitArray HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7A429B0", Offset = "0x7A41DB0", VA = "0x187A429B0", Slot = "5")]
	public BitArray KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BGIALJNOOCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class CCLDBIPDPLD : CPEEKDGOLEA<Type>, CPNGADLNAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public static readonly CCLDBIPDPLD LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly Regex LKNDMBPHPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private bool DLHLAADDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private bool LKFJJDOAFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool HEAGOBOPMIM;

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7A43240", Offset = "0x7A42640", VA = "0x187A43240")]
	public CCLDBIPDPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5520", Offset = "0x6ED4920", VA = "0x186ED5520")]
	public CCLDBIPDPLD(bool DLHLAADDLBA, bool LKFJJDOAFKP, bool HEAGOBOPMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7A42F40", Offset = "0x7A42340", VA = "0x187A42F40", Slot = "4")]
	public void GKPJGNLGAKF(LKMCFLGDNPK EEKKIBDAGAJ, Type HCPAOILCJCB, CLCGJCMKMCJ KGCHBCHLOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7A43050", Offset = "0x7A42450", VA = "0x187A43050", Slot = "5")]
	public Type KBLFJIABLOP(BKAFFJDLIHE IEMPDPINHLH, CLCGJCMKMCJ KGCHBCHLOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal static class HELBOKNLFJJ
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	internal static readonly byte[][] KPALIBOJPAG;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	internal static readonly ADONBEMOIBC DJECLFGFBGB;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7A47F20", Offset = "0x7A47320", VA = "0x187A47F20")]
	static HELBOKNLFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal static class EICPLCBDDBL
{
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	internal static readonly byte[][] IHFBIAPAMGG;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal static readonly ADONBEMOIBC HBICBPJCFMC;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7A43B20", Offset = "0x7A42F20", VA = "0x187A43B20")]
	static EICPLCBDDBL()
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
