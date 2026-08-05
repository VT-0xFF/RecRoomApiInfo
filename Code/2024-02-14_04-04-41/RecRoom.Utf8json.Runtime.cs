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
internal static class JKMCMEMFPPE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66869D0", Offset = "0x6685DD0", VA = "0x1866869D0")]
	public static bool AFBCEGMAFFM(this TypeInfo ADAMDPHPFAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class BHNMAJOOBNF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LJJOGCDCBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PFAHLDNBNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
	public BHNMAJOOBNF(Type KIGPNEOCHOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class LCLCAACANNN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KOLENMMFBHH<T>(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T PLCEGAKFIMF<T>(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI FFNBKICNGDK);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MEAKMJHAEGJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CDPHELCNEFG<T> : MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FBBKFIDAJLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum CJBAJCFLGFB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LHPMEBLKDNB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x26F17E0", Offset = "0x26F0BE0", VA = "0x1826F17E0")]
	public static string PLCNPGAOHJH<T>(this CDPHELCNEFG<T> IOMEEFILDBC, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDPHELCNEFG<T> EKKGBGDOAEI<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PJACLNCOBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27A2980", Offset = "0x27A1D80", VA = "0x1827A2980")]
	public static CDPHELCNEFG<T> JNFHBFIGGIG<T>(this KJLLBNBALAI FFNBKICNGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x66909E0", Offset = "0x668FDE0", VA = "0x1866909E0")]
	public static object FKLAFALJABN(this KJLLBNBALAI FFNBKICNGDK, Type ADAMDPHPFAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GDIDOKEBNPE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6680200", Offset = "0x667F600", VA = "0x186680200")]
	public GDIDOKEBNPE(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JPFLOFNLOOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class DKDPEKPEGLM
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] BGIIPDEPEFH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] FMDMKNMGHAA;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x667F240", Offset = "0x667E640", VA = "0x18667F240")]
		public static byte[] NDDOLLGIIHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x667F1A0", Offset = "0x667E5A0", VA = "0x18667F1A0")]
		public static char[] CPFNFDPLHNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> OFAOIAEHFII;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] DLMFDHPOLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] PEBEDGMMHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int ABOMIAEBHEB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool JALAAGAMHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x668AF80", Offset = "0x668A380", VA = "0x18668AF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x668B3C0", Offset = "0x668A7C0", VA = "0x18668B3C0")]
	public JPFLOFNLOOJ(byte[] PEBEDGMMHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x668B260", Offset = "0x668A660", VA = "0x18668B260")]
	public JPFLOFNLOOJ(byte[] PEBEDGMMHMC, int ABOMIAEBHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6688880", Offset = "0x6687C80", VA = "0x186688880")]
	private DIKMCHAPHKK DMHENLCMHJI(string CFHBMAENKKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x668A1B0", Offset = "0x66895B0", VA = "0x18668A1B0")]
	private DIKMCHAPHKK LJKABJOGEAD(string DCKDMGKGDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6689C90", Offset = "0x6689090", VA = "0x186689C90")]
	public void JBFAGMGKFLK(int ABOMIAEBHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0")]
	public byte[] MAJAMMLJGGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D46F30", Offset = "0x1D46330", VA = "0x181D46F30")]
	public int ECGFBEEGJLA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6688570", Offset = "0x6687970", VA = "0x186688570")]
	public EMNKPJADAAL CMCJPAMPHAO()
	{
		return default(EMNKPJADAAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x668AD80", Offset = "0x668A180", VA = "0x18668AD80")]
	public void OFBBCJCAHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6689770", Offset = "0x6688B70", VA = "0x186689770")]
	public bool IMMMAMEHKHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x66891D0", Offset = "0x66885D0", VA = "0x1866891D0")]
	public bool FDCPEPILFPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6688E40", Offset = "0x6688240", VA = "0x186688E40")]
	public void EKCHJBNJEPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x668B020", Offset = "0x668A420", VA = "0x18668B020")]
	public bool PEJHHLLFHLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6688410", Offset = "0x6687810", VA = "0x186688410")]
	public bool BDPNOGCJHOP(int DPBEIPGOMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6687F80", Offset = "0x6687380", VA = "0x186687F80")]
	public bool AAEDLDCDGOK(int DPBEIPGOMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x668B0B0", Offset = "0x668A4B0", VA = "0x18668B0B0")]
	public bool PLJCDJLKFGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x668ACE0", Offset = "0x668A0E0", VA = "0x18668ACE0")]
	public void OCHEMEGJDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x66884E0", Offset = "0x66878E0", VA = "0x1866884E0")]
	public bool CHLOJHKKEPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x668A2A0", Offset = "0x66896A0", VA = "0x18668A2A0")]
	public bool MAIAHGEOGAO(int DPBEIPGOMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x668AEB0", Offset = "0x668A2B0", VA = "0x18668AEB0")]
	public bool OFGCGCDAHAI(int DPBEIPGOMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x66882A0", Offset = "0x66876A0", VA = "0x1866882A0")]
	public bool AHCCBAPCOAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x668A420", Offset = "0x6689820", VA = "0x18668A420")]
	public void NFDGKAIPCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6689EF0", Offset = "0x66892F0", VA = "0x186689EF0")]
	public bool JPCNGCOKCOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x66893E0", Offset = "0x66887E0", VA = "0x1866893E0")]
	public void GCCELJAECMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x668A540", Offset = "0x6689940", VA = "0x18668A540")]
	private void NPHLICINIOJ([Out] byte[] KPFAEKNJJHI, [Out] int IELFHCNPLGB, [Out] int JHDJAOIIAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x668A370", Offset = "0x6689770", VA = "0x18668A370")]
	private static int MBGHFHKPHPA(char MAGGDEMNFDG, char LFCFPOEDJCH, char AICLPFMLBHB, char KGLKPBOCCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6688330", Offset = "0x6687730", VA = "0x186688330")]
	private static int AHMMOMIBICG(char LGHEBJJLAGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6689950", Offset = "0x6688D50", VA = "0x186689950")]
	public ArraySegment<byte> IOPHIHFHGJF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6689690", Offset = "0x6688A90", VA = "0x186689690")]
	public string IIKGPNIAPNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6689F80", Offset = "0x6689380", VA = "0x186689F80")]
	public string KHAAPBLOAAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6689A70", Offset = "0x6688E70", VA = "0x186689A70")]
	public ArraySegment<byte> JBBIMHIJCLE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6688DD0", Offset = "0x66881D0", VA = "0x186688DD0")]
	public ArraySegment<byte> EJNEMLFGAMO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6689CA0", Offset = "0x66890A0", VA = "0x186689CA0")]
	public bool JNAJJDCAPAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x668A0F0", Offset = "0x66894F0", VA = "0x18668A0F0")]
	private static bool LHONKEIFCDG(byte AICLPFMLBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6688050", Offset = "0x6687450", VA = "0x186688050")]
	private void AAMJDLBPGKG(EMNKPJADAAL FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6689500", Offset = "0x6688900", VA = "0x186689500")]
	public void HOJJJOMFCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6688720", Offset = "0x6687B20", VA = "0x186688720")]
	private void DKBACBMLMHL(int GGPLPGJHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6689480", Offset = "0x6688880", VA = "0x186689480")]
	public sbyte HLOHHFOCDIJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x668A4C0", Offset = "0x66898C0", VA = "0x18668A4C0")]
	public short NMNJAOGOFIL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x668AFA0", Offset = "0x668A3A0", VA = "0x18668AFA0")]
	public int PAAHDGLBAKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66895D0", Offset = "0x66889D0", VA = "0x1866895D0")]
	public long IEFLDLECFGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6689360", Offset = "0x6688760", VA = "0x186689360")]
	public byte FLEKMHOPIBG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6688EE0", Offset = "0x66882E0", VA = "0x186688EE0")]
	public ushort ENGJIEKBBJI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6689550", Offset = "0x6688950", VA = "0x186689550")]
	public uint IBALDLMKDKN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6689890", Offset = "0x6688C90", VA = "0x186689890")]
	public ulong IOLIFNLEKDJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6689260", Offset = "0x6688660", VA = "0x186689260")]
	public float FDKOKPIEBBM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x66890D0", Offset = "0x66884D0", VA = "0x1866890D0")]
	public double FBLLIJBEAAL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6689FF0", Offset = "0x66893F0", VA = "0x186689FF0")]
	public ArraySegment<byte> KJDAECONEDI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6688F60", Offset = "0x6688360", VA = "0x186688F60")]
	private static int FBANAJGMAMB(byte[] PEBEDGMMHMC, int ABOMIAEBHEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DIKMCHAPHKK : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference BMPNILECDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int IPCKLLCIDPM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int LJINDFIJDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBA1180", Offset = "0xBA0580", VA = "0x180BA1180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string MAMCNFLAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85D950", Offset = "0x85CD50", VA = "0x18085D950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x667F040", Offset = "0x667E440", VA = "0x18667F040")]
	public DIKMCHAPHKK(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x667EF50", Offset = "0x667E350", VA = "0x18667EF50")]
	public DIKMCHAPHKK(string DCKDMGKGDFN, byte[] NBEEOPLGNKP, int ABOMIAEBHEB, int IPCKLLCIDPM, string FOJNPKKGFJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JLHBJELLNJI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class INLGFAFPNOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] BGIIPDEPEFH;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6684500", Offset = "0x6683900", VA = "0x186684500")]
		public static byte[] NDDOLLGIIHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class KLDPIKMCPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void EJGHGFNKEFP(PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object BIGGJGHJHPK(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI FFNBKICNGDK);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class IOPFADIJGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class DEIKPHAOLAC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
				public DEIKPHAOLAC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3D54150", Offset = "0x3D53550", VA = "0x183D54150")]
				internal bool FNAPAENEBHH(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x667ED90", Offset = "0x667E190", VA = "0x18667ED90")]
				internal bool MHKGMMKANFI(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, KJLLBNBALAI, byte[]> IFNJCBDCAEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, KJLLBNBALAI> MFFNOHBKGJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly EJGHGFNKEFP DBDCFIJNEOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, KJLLBNBALAI, ArraySegment<byte>> LAFNAKLMFOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, KJLLBNBALAI, string> AAHBGDACNKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, KJLLBNBALAI, object> KEAFOAOHLHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, KJLLBNBALAI, object> ALIKGAOPHEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, KJLLBNBALAI, object> BMGFPFELFEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly BIGGJGHJHPK GLEOAGMJHBJ;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x66847F0", Offset = "0x6683BF0", VA = "0x1866847F0")]
			public IOPFADIJGBJ(Type ADAMDPHPFAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE500", Offset = "0x2BCD900", VA = "0x182BCE500")]
			private static T ENPDFFEPLDC<T>(DynamicMethod AHAFOJCPKJD)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x66845A0", Offset = "0x66839A0", VA = "0x1866845A0")]
			private static MethodInfo PHPHHNIGGLE(Type ADAMDPHPFAA, string OMHHPMIDNAN, Type[] OLJAHMJIDAA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, IOPFADIJGBJ> HFINNIJGALD;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly HLJBEPCNCAC<IOPFADIJGBJ> DCKJMIHOMEM;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x668B8B0", Offset = "0x668ACB0", VA = "0x18668B8B0")]
		static KLDPIKMCPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x668B5A0", Offset = "0x668A9A0", VA = "0x18668B5A0")]
		private static IOPFADIJGBJ CHLPPFFEBAE(Type ADAMDPHPFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x668B730", Offset = "0x668AB30", VA = "0x18668B730")]
		public static void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x668B620", Offset = "0x668AA20", VA = "0x18668B620")]
		public static void LENOCDGJGPN(Type ADAMDPHPFAA, PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KJLLBNBALAI DPFKFCINPNK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] HMCLCHPGHHB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] IKBHEIPHIAO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KJLLBNBALAI MABMNPCLNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6687CF0", Offset = "0x66870F0", VA = "0x186687CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6686E80", Offset = "0x6686280", VA = "0x186686E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6687310", Offset = "0x6686710", VA = "0x186687310")]
	public static void KHJFLONNDKO(KJLLBNBALAI FFNBKICNGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x26A3500", Offset = "0x26A2900", VA = "0x1826A3500")]
	public static byte[] LENOCDGJGPN<T>(T MBCPMMHPENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x26A3390", Offset = "0x26A2790", VA = "0x1826A3390")]
	public static byte[] LENOCDGJGPN<T>(T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26A3600", Offset = "0x26A2A00", VA = "0x1826A3600")]
	public static void LENOCDGJGPN<T>(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26A39E0", Offset = "0x26A2DE0", VA = "0x1826A39E0")]
	public static void LENOCDGJGPN<T>(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26A3690", Offset = "0x26A2A90", VA = "0x1826A3690")]
	public static void LENOCDGJGPN<T>(Stream FOBHMMKPKFP, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26A3720", Offset = "0x26A2B20", VA = "0x1826A3720")]
	public static void LENOCDGJGPN<T>(Stream FOBHMMKPKFP, T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26A3AC0", Offset = "0x26A2EC0", VA = "0x1826A3AC0")]
	public static ArraySegment<byte> NNNJIMNHHFM<T>(T MBCPMMHPENP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26A3B50", Offset = "0x26A2F50", VA = "0x1826A3B50")]
	public static ArraySegment<byte> NNNJIMNHHFM<T>(T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26A3E60", Offset = "0x26A3260", VA = "0x1826A3E60")]
	public static string PLCNPGAOHJH<T>(T FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26A3CE0", Offset = "0x26A30E0", VA = "0x1826A3CE0")]
	public static string PLCNPGAOHJH<T>(T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26A2570", Offset = "0x26A1970", VA = "0x1826A2570")]
	public static T AFFCBAMFOKP<T>(string NFCAPOLGADB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26A23F0", Offset = "0x26A17F0", VA = "0x1826A23F0")]
	public static T AFFCBAMFOKP<T>(string NFCAPOLGADB, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26A27A0", Offset = "0x26A1BA0", VA = "0x1826A27A0")]
	public static T AFFCBAMFOKP<T>(byte[] PEBEDGMMHMC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26A24E0", Offset = "0x26A18E0", VA = "0x1826A24E0")]
	public static T AFFCBAMFOKP<T>(byte[] PEBEDGMMHMC, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x26A2F00", Offset = "0x26A2300", VA = "0x1826A2F00")]
	public static T AFFCBAMFOKP<T>(byte[] PEBEDGMMHMC, int ABOMIAEBHEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x26A2D70", Offset = "0x26A2170", VA = "0x1826A2D70")]
	public static T AFFCBAMFOKP<T>(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26A2720", Offset = "0x26A1B20", VA = "0x1826A2720")]
	public static T AFFCBAMFOKP<T>(JPFLOFNLOOJ AGGHEBELANL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26A2600", Offset = "0x26A1A00", VA = "0x1826A2600")]
	public static T AFFCBAMFOKP<T>(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26A2820", Offset = "0x26A1C20", VA = "0x1826A2820")]
	public static T AFFCBAMFOKP<T>(Stream FOBHMMKPKFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x26A3250", Offset = "0x26A2650", VA = "0x1826A3250")]
	public static T AFFCBAMFOKP<T>(Stream FOBHMMKPKFP, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6687070", Offset = "0x6686470", VA = "0x186687070")]
	public static string DGLJMPPBHOA(byte[] NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66871D0", Offset = "0x66865D0", VA = "0x1866871D0")]
	public static string DGLJMPPBHOA(byte[] NFCAPOLGADB, int ABOMIAEBHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6686EE0", Offset = "0x66862E0", VA = "0x186686EE0")]
	public static string DGLJMPPBHOA(string NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6686BB0", Offset = "0x6685FB0", VA = "0x186686BB0")]
	public static byte[] BIBJHIDCBCF(byte[] NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6686D30", Offset = "0x6686130", VA = "0x186686D30")]
	public static byte[] BIBJHIDCBCF(byte[] NFCAPOLGADB, int ABOMIAEBHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6686A00", Offset = "0x6685E00", VA = "0x186686A00")]
	public static byte[] BIBJHIDCBCF(string NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6687420", Offset = "0x6686820", VA = "0x186687420")]
	private static void LNMDMKMGCPI(JPFLOFNLOOJ AGGHEBELANL, PFDOBNDPOBK NADLGELBCMH, int JCOHLBKCNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6687380", Offset = "0x6686780", VA = "0x186687380")]
	private static int LEFIOMOLHEO(Stream KODNHMICLEA, byte[] BGIIPDEPEFH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum EMNKPJADAAL : byte
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
public struct PFDOBNDPOBK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] MACNAANICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] BGIIPDEPEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int ABOMIAEBHEB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CBMFDPJBCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1D46F30", Offset = "0x1D46330", VA = "0x181D46F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6689C90", Offset = "0x6689090", VA = "0x186689C90")]
	public void JBFAGMGKFLK(int ABOMIAEBHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x668FFC0", Offset = "0x668F3C0", VA = "0x18668FFC0")]
	public static byte[] LFKDOKANION(string OJJLJELNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x668FE50", Offset = "0x668F250", VA = "0x18668FE50")]
	public static byte[] KLILBPACELA(string OJJLJELNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x66900F0", Offset = "0x668F4F0", VA = "0x1866900F0")]
	public static byte[] LGPKKAFJCMG(string OJJLJELNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x668FC10", Offset = "0x668F010", VA = "0x18668FC10")]
	public static byte[] HAGEHHMEDBE(string OJJLJELNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x543FAC0", Offset = "0x543EEC0", VA = "0x18543FAC0")]
	public PFDOBNDPOBK(byte[] PEPNDBCHNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6690320", Offset = "0x668F720", VA = "0x186690320")]
	public ArraySegment<byte> NDDOLLGIIHL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x66905C0", Offset = "0x668F9C0", VA = "0x1866905C0")]
	public byte[] PCOECDOMOJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x66907A0", Offset = "0x668FBA0", VA = "0x1866907A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6690630", Offset = "0x668FA30", VA = "0x186690630")]
	public void PGCGCAKFKBJ(int KEHHGEKLKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6690420", Offset = "0x668F820", VA = "0x186690420")]
	public void NDOIFCPEPEJ(byte JLHOKMNALPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x66903C0", Offset = "0x668F7C0", VA = "0x1866903C0")]
	public void NDOIFCPEPEJ(byte[] JLHOKMNALPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x668F810", Offset = "0x668EC10", VA = "0x18668F810")]
	public void GFACGLCPMLK(byte JLHOKMNALPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x668FD90", Offset = "0x668F190", VA = "0x18668FD90")]
	public void IKLMHFHGFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x668F7C0", Offset = "0x668EBC0", VA = "0x18668F7C0")]
	public void FCCELOJNALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x668F740", Offset = "0x668EB40", VA = "0x18668F740")]
	public void EJMNLODDDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x66902D0", Offset = "0x668F6D0", VA = "0x1866902D0")]
	public void MGBKOACEKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6690570", Offset = "0x668F970", VA = "0x186690570")]
	public void PBHNKPCKFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6690480", Offset = "0x668F880", VA = "0x186690480")]
	public void NHJJBIKFLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x66904D0", Offset = "0x668F8D0", VA = "0x1866904D0")]
	public void OFIBFKKEKEP(string OJJLJELNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x668F520", Offset = "0x668E920", VA = "0x18668F520")]
	public void BMHCFEECECL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x668F390", Offset = "0x668E790", VA = "0x18668F390")]
	public void AMHLGPACAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6690640", Offset = "0x668FA40", VA = "0x186690640")]
	public void PLGPLGMLBFN(bool FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x668F430", Offset = "0x668E830", VA = "0x18668F430")]
	public void BBAMBEMGKGL(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x668F5E0", Offset = "0x668E9E0", VA = "0x18668F5E0")]
	public void DFOPAOFJCKG(double FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x668F660", Offset = "0x668EA60", VA = "0x18668F660")]
	public void EAPAINMDPGF(byte FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x668F4B0", Offset = "0x668E8B0", VA = "0x18668F4B0")]
	public void BMAEALOMHHF(ushort FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x668F570", Offset = "0x668E970", VA = "0x18668F570")]
	public void CJLPJFDJNCB(uint FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x668F790", Offset = "0x668EB90", VA = "0x18668F790")]
	public void EPKJNHDCGEB(ulong FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6690260", Offset = "0x668F660", VA = "0x186690260")]
	public void MELDGLDNGMN(sbyte FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x668FDE0", Offset = "0x668F1E0", VA = "0x18668FDE0")]
	public void JIPEDDHGMIF(short FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x668F6D0", Offset = "0x668EAD0", VA = "0x18668F6D0")]
	public void EFCAFANJAII(int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x668FBE0", Offset = "0x668EFE0", VA = "0x18668FBE0")]
	public void GJMHIMCDPCB(long FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x668F850", Offset = "0x668EC50", VA = "0x18668F850")]
	public void GGNIPAHKENG(string FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class LDFDBILEHIE : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class AKKBPLDMHPM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x365C020", Offset = "0x365B420", VA = "0x18365C020")]
		static AKKBPLDMHPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private LDFDBILEHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KKMNDJGFJBL : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class FLKACKLDPFH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3590CF0", Offset = "0x35900F0", VA = "0x183590CF0")]
		static FLKACKLDPFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class PADNJHNJKEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> BDDIEINKKGM;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x668C530", Offset = "0x668B930", VA = "0x18668C530")]
		internal static object EKKGBGDOAEI(Type FENMDPNPDJP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private KKMNDJGFJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class ANBIHFKAAAI : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class KDBJFIHIEHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F920", Offset = "0x3A5ED20", VA = "0x183A5F920")]
		static KDBJFIHIEHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly ANBIHFKAAAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool FEBPLFOFCJI;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static MEAKMJHAEGJ[] DOPEIOFEAOG;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static KJLLBNBALAI[] CNCHKGGJHCK;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private ANBIHFKAAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x667E470", Offset = "0x667D870", VA = "0x18667E470")]
	public static void LIBHGHNAKIM(params KJLLBNBALAI[] CNCHKGGJHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x667E550", Offset = "0x667D950", VA = "0x18667E550")]
	public static void LIBHGHNAKIM(params MEAKMJHAEGJ[] DOPEIOFEAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x667E1E0", Offset = "0x667D5E0", VA = "0x18667E1E0")]
	public static void GPGGCGBPPFM(MEAKMJHAEGJ[] DOPEIOFEAOG, KJLLBNBALAI[] CNCHKGGJHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MJENGFMGAOL : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class IOMPEDLDEFN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x37DC1E0", Offset = "0x37DB5E0", VA = "0x1837DC1E0")]
		static IOMPEDLDEFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private MJENGFMGAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class COLDHENFBFH
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly KJLLBNBALAI KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly KJLLBNBALAI KMMHCDIPKJK;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly KJLLBNBALAI PCKGLHKNAFB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly KJLLBNBALAI ALEGHCLNLBA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly KJLLBNBALAI AHJDOGCHHEC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly KJLLBNBALAI PPCAKIGIEAI;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly KJLLBNBALAI NBJAJNKODLB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly KJLLBNBALAI EJCAMHJCBJJ;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly KJLLBNBALAI DLOCHPJHGBN;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly KJLLBNBALAI FJBAJIIHPGG;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KJLLBNBALAI CIBDEGCNCGM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly KJLLBNBALAI KDIKDNLCIOO;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class FFNEAFOBJAC
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly KJLLBNBALAI KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly KJLLBNBALAI FEMCDCCBJKK;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IKICONNBMKA
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly KJLLBNBALAI KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly KJLLBNBALAI KMMHCDIPKJK;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly KJLLBNBALAI PCKGLHKNAFB;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly KJLLBNBALAI ALEGHCLNLBA;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly KJLLBNBALAI AHJDOGCHHEC;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly KJLLBNBALAI PPCAKIGIEAI;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly KJLLBNBALAI NBJAJNKODLB;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly KJLLBNBALAI EJCAMHJCBJJ;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly KJLLBNBALAI DLOCHPJHGBN;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly KJLLBNBALAI FJBAJIIHPGG;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly KJLLBNBALAI CIBDEGCNCGM;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly KJLLBNBALAI KDIKDNLCIOO;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class IGEOAEODOME
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> BDDIEINKKGM;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6682380", Offset = "0x6681780", VA = "0x186682380")]
	internal static object EKKGBGDOAEI(Type FENMDPNPDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6683AE0", Offset = "0x6682EE0", VA = "0x186683AE0")]
	private static object JICFIHJJLLB(Type GKGECGCFAEF, Type[] JLFMKCOFCID, params object[] OLJAHMJIDAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class LNIIKGMFFFP : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class IKNDOOGLEGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x37BA800", Offset = "0x37B9C00", VA = "0x1837BA800")]
		static IKNDOOGLEGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly MLBNKLMMCKI PIGKLLPOJDM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x668BD50", Offset = "0x668B150", VA = "0x18668BD50")]
	static LNIIKGMFFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private LNIIKGMFFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class NBEELDHJLJN : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class BAMHEHKHBBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x45DD6A0", Offset = "0x45DCAA0", VA = "0x1845DD6A0")]
		static BAMHEHKHBBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly MLBNKLMMCKI PIGKLLPOJDM;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x668C0D0", Offset = "0x668B4D0", VA = "0x18668C0D0")]
	static NBEELDHJLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private NBEELDHJLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class AJOGDDDPHPG : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class IMPHIEPIMDG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x37CFDA0", Offset = "0x37CF1A0", VA = "0x1837CFDA0")]
		static IMPHIEPIMDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly MLBNKLMMCKI PIGKLLPOJDM;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x667DF90", Offset = "0x667D390", VA = "0x18667DF90")]
	static AJOGDDDPHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private AJOGDDDPHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class HHPIHFPGMII : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class PBDBEEGMINB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F88EC0", Offset = "0x3F882C0", VA = "0x183F88EC0")]
		static PBDBEEGMINB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly MLBNKLMMCKI PIGKLLPOJDM;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6680500", Offset = "0x667F900", VA = "0x186680500")]
	static HHPIHFPGMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private HHPIHFPGMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class PIHANDDMOJK : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class AMDHAPCLKAF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3665D80", Offset = "0x3665180", VA = "0x183665D80")]
		static AMDHAPCLKAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly MLBNKLMMCKI PIGKLLPOJDM;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6690870", Offset = "0x668FC70", VA = "0x186690870")]
	static PIHANDDMOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private PIHANDDMOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class OPBIOIBLGDE : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class NKLKHLPIOFH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3E08930", Offset = "0x3E07D30", VA = "0x183E08930")]
		static NKLKHLPIOFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly MLBNKLMMCKI PIGKLLPOJDM;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x668C3C0", Offset = "0x668B7C0", VA = "0x18668C3C0")]
	static OPBIOIBLGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private OPBIOIBLGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class KIPHEBEDLKI : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class GNBGCPLMKGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x369BB60", Offset = "0x369AF60", VA = "0x18369BB60")]
		static GNBGCPLMKGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public KIPHEBEDLKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class HFLLIFOOLID : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class AMACBBAFOLB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3660140", Offset = "0x365F540", VA = "0x183660140")]
		static AMACBBAFOLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public HFLLIFOOLID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class AGEOIAJOKDI : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class ANOPCKJBNLH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3675E40", Offset = "0x3675240", VA = "0x183675E40")]
		static ANOPCKJBNLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public AGEOIAJOKDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class DILNNGMPBNB : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class CPIOOCAANMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4A33A70", Offset = "0x4A32E70", VA = "0x184A33A70")]
		static CPIOOCAANMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public DILNNGMPBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class HAIPIENBNAD : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class EJEOHNPPAPI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x31FCF80", Offset = "0x31FC380", VA = "0x1831FCF80")]
		static EJEOHNPPAPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public HAIPIENBNAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class KPOLKCDLOCK : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class LAJKEPKKBDC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3B14CE0", Offset = "0x3B140E0", VA = "0x183B14CE0")]
		static LAJKEPKKBDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> OKMMDHBMNBM;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool BOLNPNKMDPC;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public KPOLKCDLOCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class PNHOKGNBGDG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct LIMDACBBCFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public OLEMMHLFKLG GICPBMADABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder NHNKMCCGCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder JJGNDDAGNHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class IADNIFDLKAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class PBGBLNAPBPK
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo LGPKKAFJCMG;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo KLILBPACELA;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo HAGEHHMEDBE;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo LFKDOKANION;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo AMHLGPACAIF;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo NDOIFCPEPEJ;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo EJMNLODDDFK;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo MGBKOACEKFB;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo PBHNKPCKFEE;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x668E360", Offset = "0x668D760", VA = "0x18668E360")]
			static PBGBLNAPBPK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class FJJKFEGDNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo IMMMAMEHKHL;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo OCHEMEGJDNO;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo MAIAHGEOGAO;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo IKLPAKEPKMO;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo HOJJJOMFCON;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo MAJAMMLJGGA;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo ECGFBEEGJLA;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x667F5C0", Offset = "0x667E9C0", VA = "0x18667F5C0")]
			static FJJKFEGDNKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class JKGHNGFMFAI
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo LJJOGCDCBGP;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo PFAHLDNBNMI;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo PEOCLDNABAO;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo JNFHBFIGGIG;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo KAFBDDLHPDK;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo MFIMFJOLFKF;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo HPMIKBDMPDO;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo DOFNOEMENBA;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo EKLLGNAGICD;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo JHCDNIPKIJA;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo NEIJKNGJACC;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo HBPOBDOHLOO;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo NNDJGFPJPFN;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo KIGAFFABIOK;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6680B00", Offset = "0x667FF00", VA = "0x186680B00")]
		public static MethodInfo LENOCDGJGPN(Type ADAMDPHPFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6680790", Offset = "0x667FB90", VA = "0x186680790")]
		public static MethodInfo AFFCBAMFOKP(Type ADAMDPHPFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x66809D0", Offset = "0x667FDD0", VA = "0x1866809D0")]
		public static MethodInfo GHAPIAIAIHJ(Type ADAMDPHPFAA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LHPKNIDDFAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<OLEMMHLFKLG, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LHPKNIDDFAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class ALCLCDBFDJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public LHPKNIDDFAF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ALCLCDBFDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x667E1A0", Offset = "0x667D5A0", VA = "0x18667E1A0")]
		internal void PLAJEOFEJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x667E100", Offset = "0x667D500", VA = "0x18667E100")]
		internal bool AGBEPJJAKNP(int index, OLEMMHLFKLG member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class GFIPBPCLKCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public LHPKNIDDFAF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GFIPBPCLKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6680260", Offset = "0x667F660", VA = "0x186680260")]
		internal bool MPMGKDFMGFN(int index, OLEMMHLFKLG member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class FOFHNOJFBIE
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public FOFHNOJFBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3E13550", Offset = "0x3E12950", VA = "0x183E13550")]
		internal string NFOFBBPOFIM(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ADBDLAPLMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ADBDLAPLMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x667DE30", Offset = "0x667D230", VA = "0x18667DE30")]
		internal bool EPHEEJPMIKK(OLEMMHLFKLG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class LPMFKNDADBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FOFHNOJFBIE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LPMFKNDADBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x668BEC0", Offset = "0x668B2C0", VA = "0x18668BEC0")]
		internal void GCMPNFNMFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x668BED0", Offset = "0x668B2D0", VA = "0x18668BED0")]
		internal bool HADFEOABDDL(int index, OLEMMHLFKLG member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class BGBPHAEBAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public FOFHNOJFBIE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BGBPHAEBAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x667E750", Offset = "0x667DB50", VA = "0x18667E750")]
		internal bool PHNPDKMMLNG(int index, OLEMMHLFKLG member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class CGFKPBLECPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CGFKPBLECPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x667E8D0", Offset = "0x667DCD0", VA = "0x18667E8D0")]
		internal Label CLPAKECOMBG(OLEMMHLFKLG _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HLOOPDAMAJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public LIMDACBBCFA[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, OLEMMHLFKLG, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public MCNDOMPCHHF argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MCNDOMPCHHF argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HLOOPDAMAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6680670", Offset = "0x667FA70", VA = "0x186680670")]
		internal LIMDACBBCFA ADLCFMIFCAF(OLEMMHLFKLG item)
		{
			return default(LIMDACBBCFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JGDIEFIHJNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public HLOOPDAMAJJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JGDIEFIHJNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x66862F0", Offset = "0x66856F0", VA = "0x1866862F0")]
		internal void BLGEPKLAGIJ(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6686580", Offset = "0x6685980", VA = "0x186686580")]
		internal void PNAIMIMDBCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class GCBMMCDKCAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public OLEMMHLFKLG item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GCBMMCDKCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB2E0C0", Offset = "0xB2D4C0", VA = "0x180B2E0C0")]
		internal bool DJLFFONHFJH(LIMDACBBCFA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class GCBDGNEDNMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public OLEMMHLFKLG item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GCBDGNEDNMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB2E0C0", Offset = "0xB2D4C0", VA = "0x180B2E0C0")]
		internal bool PCEDBEJOCFJ(LIMDACBBCFA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex PCIFPICKIMH;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int HLKDFJGLELF;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> IMNOMOMHOJO;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> FIPPLGDGNOC;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x27B0530", Offset = "0x27AF930", VA = "0x1827B0530")]
	public static object BMGMFHFHDBM<T>(MLBNKLMMCKI PIGKLLPOJDM, KJLLBNBALAI MLBHGFKIPHI, Func<string, string> OKMMDHBMNBM, bool BOLNPNKMDPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x27B9540", Offset = "0x27B8940", VA = "0x1827B9540")]
	public static object EBCIOJOEAGG<T>(KJLLBNBALAI MLBHGFKIPHI, Func<string, string> OKMMDHBMNBM, bool BOLNPNKMDPC, bool LFJILANPPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6697F00", Offset = "0x6697300", VA = "0x186697F00")]
	private static TypeInfo PHMAAHOFOLO(MLBNKLMMCKI PIGKLLPOJDM, Type ADAMDPHPFAA, Func<string, string> OKMMDHBMNBM, bool BOLNPNKMDPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6693E00", Offset = "0x6693200", VA = "0x186693E00")]
	public static object GNGPHFBNBDE(Type ADAMDPHPFAA, Func<string, string> OKMMDHBMNBM, bool BOLNPNKMDPC, bool LFJILANPPPA, bool CBDAPJIJPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6696F70", Offset = "0x6696370", VA = "0x186696F70")]
	private static Dictionary<OLEMMHLFKLG, FieldInfo> LHNAMBONEPH(TypeBuilder NEKBLNGPEGC, NOOPFPAOOED CBJFHHJLIDF, ConstructorInfo BGNMKGIOBCO, FieldBuilder MKGIOHHPCLO, ILGenerator PMPDDDDPEFP, bool BOLNPNKMDPC, bool PIEDPKFMMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6697820", Offset = "0x6696C20", VA = "0x186697820")]
	private static Dictionary<OLEMMHLFKLG, FieldInfo> PFFFMGCONAN(TypeBuilder NEKBLNGPEGC, NOOPFPAOOED CBJFHHJLIDF, ILGenerator PMPDDDDPEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6695930", Offset = "0x6694D30", VA = "0x186695930")]
	private static void HHCPCILEAMC(Type ADAMDPHPFAA, NOOPFPAOOED CBJFHHJLIDF, ILGenerator PMPDDDDPEFP, Action MIGBMNLEOID, Func<int, OLEMMHLFKLG, bool> NAECCKOGGBO, bool BOLNPNKMDPC, bool PIEDPKFMMFN, int DIHGAAOGPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6691690", Offset = "0x6690A90", VA = "0x186691690")]
	private static void EBODGJBFBNF(TypeInfo ADAMDPHPFAA, OLEMMHLFKLG JFANFPLPAEB, ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ, Func<int, OLEMMHLFKLG, bool> NAECCKOGGBO, MCNDOMPCHHF NADLGELBCMH, MCNDOMPCHHF IKIIEEKPDAF, MCNDOMPCHHF DNKONHCEJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6691BD0", Offset = "0x6690FD0", VA = "0x186691BD0")]
	private static void EPKKDDOEOPJ(Type ADAMDPHPFAA, NOOPFPAOOED CBJFHHJLIDF, ILGenerator PMPDDDDPEFP, Func<int, OLEMMHLFKLG, bool> NAECCKOGGBO, bool OEHJNCMEPNJ, int DIHGAAOGPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6690B40", Offset = "0x668FF40", VA = "0x186690B40")]
	private static void AEMFOBKMBLN(ILGenerator PMPDDDDPEFP, LIMDACBBCFA CBJFHHJLIDF, int OJANCMLFDOJ, Func<int, OLEMMHLFKLG, bool> NAECCKOGGBO, MCNDOMPCHHF AGGHEBELANL, MCNDOMPCHHF DNKONHCEJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6693070", Offset = "0x6692470", VA = "0x186693070")]
	private static LocalBuilder FPBELEBHCHK(ILGenerator PMPDDDDPEFP, Type ADAMDPHPFAA, NOOPFPAOOED CBJFHHJLIDF, LIMDACBBCFA[] KLEHLBDECID, bool KCAKFJDLODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6690FB0", Offset = "0x66903B0", VA = "0x186690FB0")]
	private static bool BJDNIEHIJKE(ConstructorInfo DPPDKFBLAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x66976A0", Offset = "0x6696AA0", VA = "0x1866976A0")]
	private static bool PEEMGJJMMMD(Type ADAMDPHPFAA, [Out] Type BPBHPLJCBOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void MEGPPACCEGE<T>(byte[][] MKGIOHHPCLO, object[] JLJFBPHPBOF, PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T DABHCPNODEK<T>(object[] JLJFBPHPBOF, JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI FFNBKICNGDK);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class PGNENPDMDDD<T> : CDPHELCNEFG<T>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] MKGIOHHPCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] JDFMGCJMFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] LFEJJKJOLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly MEGPPACCEGE<T> IHLGPFFHGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly DABHCPNODEK<T> CNFEDBEGGPJ;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1D39230", Offset = "0x1D38630", VA = "0x181D39230")]
	public PGNENPDMDDD(byte[][] MKGIOHHPCLO, object[] JDFMGCJMFNM, object[] LFEJJKJOLGJ, MEGPPACCEGE<T> IHLGPFFHGJC, DABHCPNODEK<T> CNFEDBEGGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6500", Offset = "0x3FA5900", VA = "0x183FA6500", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6410", Offset = "0x3FA5810", VA = "0x183FA6410", Slot = "5")]
	public T AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class FHOAPGMGJOI : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class HNFHBALMHKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x36F5DF0", Offset = "0x36F51F0", VA = "0x1836F5DF0")]
		static HNFHBALMHKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private FHOAPGMGJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class FOJLPPMNPDM : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class EHJDLGCHIAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x31EB750", Offset = "0x31EAB50", VA = "0x1831EB750")]
		static EHJDLGCHIAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private FOJLPPMNPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class PDOIKDECDJI
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly KJLLBNBALAI[] CMKLNJNMDDF;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class ODIPBBFPIOP : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class MDIIEEIDHNH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A440", Offset = "0x3D39840", VA = "0x183D3A440")]
		static MDIIEEIDHNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class LAMJJLCHBDF : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class NCHJPEFKDHJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4FA0", Offset = "0x3DF43A0", VA = "0x183DF4FA0")]
			static NCHJPEFKDHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private LAMJJLCHBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private ODIPBBFPIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class EOBJMBNPEOB : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class CCOLICONMGD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x486C340", Offset = "0x486B740", VA = "0x18486C340")]
		static CCOLICONMGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class CJHOGGAOEDP : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class BHPJCCLLOCG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x45F0590", Offset = "0x45EF990", VA = "0x1845F0590")]
			static BHPJCCLLOCG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private CJHOGGAOEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private EOBJMBNPEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class ICDMDDIPPJB : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class AMMKGPAOBEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x366A370", Offset = "0x3669770", VA = "0x18366A370")]
		static AMMKGPAOBEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class HIAFEJBECEG : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class BOLFEMGPOJI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x462BE40", Offset = "0x462B240", VA = "0x18462BE40")]
			static BOLFEMGPOJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private HIAFEJBECEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private ICDMDDIPPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class KNDMAGCFCOF : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class DOOIJLEAECH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0FC0", Offset = "0x4EC03C0", VA = "0x184EC0FC0")]
		static DOOIJLEAECH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class OCHIPMDHPAH : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class ICGPEADNFKC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3793540", Offset = "0x3792940", VA = "0x183793540")]
			static ICGPEADNFKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private OCHIPMDHPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private KNDMAGCFCOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class DLMEGIEFFIH : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class IOHFIBKPPBL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x37D6970", Offset = "0x37D5D70", VA = "0x1837D6970")]
		static IOHFIBKPPBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class HLEPKEINHAI : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class ILLMBODFAFM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x37C5DA0", Offset = "0x37C51A0", VA = "0x1837C5DA0")]
			static ILLMBODFAFM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private HLEPKEINHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private DLMEGIEFFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class JPHDEBEDCMH : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class FPPNEGFJEFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x35DBC50", Offset = "0x35DB050", VA = "0x1835DBC50")]
		static FPPNEGFJEFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class OBLDKFOFKHM : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class JBBEGCHGCPO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x395C4A0", Offset = "0x395B8A0", VA = "0x18395C4A0")]
			static JBBEGCHGCPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private OBLDKFOFKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private JPHDEBEDCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class IILFLMIHDGC : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class JONJPHDPHON<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3A0FE60", Offset = "0x3A0F260", VA = "0x183A0FE60")]
		static JONJPHDPHON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class CMEDDAJDMAG : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class CKMEJCLHHAE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x49607C0", Offset = "0x495FBC0", VA = "0x1849607C0")]
			static CKMEJCLHHAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private CMEDDAJDMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private IILFLMIHDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class LEFNNOCABNJ : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class IJADMINNENF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x37B20E0", Offset = "0x37B14E0", VA = "0x1837B20E0")]
		static IJADMINNENF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class BGDFLOGEIBC : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class BIGFEDLLODO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x45F4A50", Offset = "0x45F3E50", VA = "0x1845F4A50")]
			static BIGFEDLLODO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private BGDFLOGEIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private LEFNNOCABNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class CHCFLIPAKCE : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class GGCKPBNDDEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x368EBB0", Offset = "0x368DFB0", VA = "0x18368EBB0")]
		static GGCKPBNDDEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class DOBLNBPEBMD : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class BJPBLCIGEGK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4614DA0", Offset = "0x46141A0", VA = "0x184614DA0")]
			static BJPBLCIGEGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private DOBLNBPEBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private CHCFLIPAKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class NOAFFHAEHMP : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class EMIMKKHECFN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3207030", Offset = "0x3206430", VA = "0x183207030")]
		static EMIMKKHECFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class HMEBNBKCBGC : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class LHMPFGACNDO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3B594B0", Offset = "0x3B588B0", VA = "0x183B594B0")]
			static LHMPFGACNDO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private HMEBNBKCBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private NOAFFHAEHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class GGNFJOBJPEN : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class PCHDLACEECM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3F92A60", Offset = "0x3F91E60", VA = "0x183F92A60")]
		static PCHDLACEECM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class JDKDGDEMKDN : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class LGIDHFMIEGJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3B4FEB0", Offset = "0x3B4F2B0", VA = "0x183B4FEB0")]
			static LGIDHFMIEGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private JDKDGDEMKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private GGNFJOBJPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class LFHBIFMHOJH : KJLLBNBALAI
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class KIMACCOBMHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A761E0", Offset = "0x3A755E0", VA = "0x183A761E0")]
		static KIMACCOBMHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class GFCIMEPMKJI : KJLLBNBALAI
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class LPLMAEBDDKM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly CDPHELCNEFG<T> IOMEEFILDBC;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3B798F0", Offset = "0x3B78CF0", VA = "0x183B798F0")]
			static LPLMAEBDDKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private GFCIMEPMKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
		public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly CDPHELCNEFG<object> ICPHFOCNIKO;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	private LFHBIFMHOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct LKKGEBOBJOF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] KCHDPADAINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int DPKBEHGMNCM;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B6DA70", Offset = "0x3B6CE70", VA = "0x183B6DA70")]
	public LKKGEBOBJOF(int BIMOGKLBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B6D750", Offset = "0x3B6CB50", VA = "0x183B6D750")]
	public void FLOHBAGDPJC(T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B6D9E0", Offset = "0x3B6CDE0", VA = "0x183B6D9E0")]
	public T[] LHLDIOAGHOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class PLEFJPOPCOM : NIHDPFILHMD<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly PLEFJPOPCOM KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x66AEED0", Offset = "0x66AE2D0", VA = "0x1866AEED0")]
	public PLEFJPOPCOM(int LOAEDJFFBMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class NIHDPFILHMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int LOAEDJFFBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object FLHHCMKGPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int OJANCMLFDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] FFLHEMKOONO;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF860", Offset = "0x3DFEC60", VA = "0x183DFF860")]
	public NIHDPFILHMD(int LOAEDJFFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF560", Offset = "0x3DFE960", VA = "0x183DFF560")]
	public T[] JPCNFGJJEGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF3E0", Offset = "0x3DFE7E0", VA = "0x183DFF3E0")]
	public void EKOFEBAHAIL(T[] NIKMHLBDDHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class GDPGJDBNPKH : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class CDHDHPDAPCB : IComparable<CDHDHPDAPCB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class IKGMNMAJDOI : IEnumerable<CDHDHPDAPCB>, IEnumerable, IEnumerator<CDHDHPDAPCB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private CDHDHPDAPCB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public CDHDHPDAPCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private CDHDHPDAPCB System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9346D0", Offset = "0x933AD0", VA = "0x1809346D0")]
			[DebuggerHidden]
			public IKGMNMAJDOI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x66A6BA0", Offset = "0x66A5FA0", VA = "0x1866A6BA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x66A6CD0", Offset = "0x66A60D0", VA = "0x1866A6CD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x66A6C20", Offset = "0x66A6020", VA = "0x1866A6C20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CDHDHPDAPCB> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x66A6C20", Offset = "0x66A6020", VA = "0x1866A6C20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class OKFJEPPAHCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public OKFJEPPAHCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x667E8D0", Offset = "0x667DCD0", VA = "0x18667E8D0")]
			internal Label NJBENGJOEKI(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x667E8D0", Offset = "0x667DCD0", VA = "0x18667E8D0")]
			internal Label NCMNBIHMLAF(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly CDHDHPDAPCB[] NMJCOHIELOA;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] NHHLOKDJIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong JFBDDAMOHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int NAJOFLHMBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string IJNKALDJFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CDHDHPDAPCB[] AEHKNMGPPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] IIBOJHFACKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int DPBEIPGOMHN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool KJHCBBBCCJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5173C30", Offset = "0x5173030", VA = "0x185173C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x669B940", Offset = "0x669AD40", VA = "0x18669B940")]
		public CDHDHPDAPCB(ulong KCGLPAPOILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x669B100", Offset = "0x669A500", VA = "0x18669B100")]
		public CDHDHPDAPCB FLOHBAGDPJC(ulong KCGLPAPOILB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x669B0A0", Offset = "0x669A4A0", VA = "0x18669B0A0")]
		public CDHDHPDAPCB FLOHBAGDPJC(ulong KCGLPAPOILB, int FDFHGIHHGHO, string IJNKALDJFHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x669B390", Offset = "0x669A790", VA = "0x18669B390")]
		public CDHDHPDAPCB KDKFOPANCNO(byte[] BILHHBDBFLG, int ABOMIAEBHEB, int JLMEHOHLPHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x669B300", Offset = "0x669A700", VA = "0x18669B300")]
		internal static int GOBAGKCGNHO(ulong[] NIKMHLBDDHG, int OJANCMLFDOJ, int CBKFAHCFHJN, ulong FDFHGIHHGHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x669B070", Offset = "0x669A470", VA = "0x18669B070", Slot = "4")]
		public int CompareTo(CDHDHPDAPCB AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x669A310", Offset = "0x6699710", VA = "0x18669A310")]
		[IteratorStateMachine(typeof(IKGMNMAJDOI))]
		public IEnumerable<CDHDHPDAPCB> AHPECHOJMOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x669B510", Offset = "0x669A910", VA = "0x18669B510")]
		public void PALDFOIINEP(ILGenerator PMPDDDDPEFP, LocalBuilder BILHHBDBFLG, LocalBuilder JLMEHOHLPHF, LocalBuilder KCGLPAPOILB, Action<KeyValuePair<string, int>> CCDJEOOGJCP, Action KNGCFGNMCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x669A390", Offset = "0x6699790", VA = "0x18669A390")]
		private static void BMLHNOIGJOA(ILGenerator PMPDDDDPEFP, LocalBuilder BILHHBDBFLG, LocalBuilder JLMEHOHLPHF, LocalBuilder KCGLPAPOILB, Action<KeyValuePair<string, int>> CCDJEOOGJCP, Action KNGCFGNMCBA, CDHDHPDAPCB[] AEHKNMGPPAE, int DPBEIPGOMHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class IECECPGPBEE : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<CDHDHPDAPCB> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<CDHDHPDAPCB> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<CDHDHPDAPCB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private CDHDHPDAPCB <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8E0", Offset = "0xA1DCE0", VA = "0x180A1E8E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x66A66A0", Offset = "0x66A5AA0", VA = "0x1866A66A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1C4CF50", Offset = "0x1C4C350", VA = "0x181C4CF50")]
		[DebuggerHidden]
		public IECECPGPBEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x66A66F0", Offset = "0x66A5AF0", VA = "0x1866A66F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x66A6140", Offset = "0x66A5540", VA = "0x1866A6140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x66A60A0", Offset = "0x66A54A0", VA = "0x1866A60A0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x66A60F0", Offset = "0x66A54F0", VA = "0x1866A60F0")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x66A6650", Offset = "0x66A5A50", VA = "0x1866A6650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x66A65A0", Offset = "0x66A59A0", VA = "0x1866A65A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x66A65A0", Offset = "0x66A59A0", VA = "0x1866A65A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly CDHDHPDAPCB LMAHFBOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x66A1E20", Offset = "0x66A1220", VA = "0x1866A1E20")]
	public GDPGJDBNPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x66A17E0", Offset = "0x66A0BE0", VA = "0x1866A17E0")]
	public void FLOHBAGDPJC(byte[] PEBEDGMMHMC, int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x66A19D0", Offset = "0x66A0DD0", VA = "0x1866A19D0")]
	public bool ILHGEEFCDOO(ArraySegment<byte> KCGLPAPOILB, [Out] int FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x66A1D90", Offset = "0x66A1190", VA = "0x1866A1D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x66A1AB0", Offset = "0x66A0EB0", VA = "0x1866A1AB0")]
	private static void LKBIEDMFPAA(IEnumerable<CDHDHPDAPCB> AEHKNMGPPAE, StringBuilder JCBFBOIDMHE, int JCOHLBKCNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x66A1970", Offset = "0x66A0D70", VA = "0x1866A1970", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x66A1970", Offset = "0x66A0D70", VA = "0x1866A1970", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x66A18F0", Offset = "0x66A0CF0", VA = "0x1866A18F0")]
	[IteratorStateMachine(typeof(IECECPGPBEE))]
	private static IEnumerable<KeyValuePair<string, int>> FMCGHGEPNIK(IEnumerable<CDHDHPDAPCB> AEHKNMGPPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x66A17B0", Offset = "0x66A0BB0", VA = "0x1866A17B0")]
	public void FHEODHOGDPL(ILGenerator PMPDDDDPEFP, LocalBuilder BILHHBDBFLG, LocalBuilder JLMEHOHLPHF, LocalBuilder KCGLPAPOILB, Action<KeyValuePair<string, int>> CCDJEOOGJCP, Action KNGCFGNMCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class LFKEGFKFHKK
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo MNLFEBAIDPF;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x66A7F80", Offset = "0x66A7380", VA = "0x1866A7F80")]
	public static ulong HIJNKBEKMAB(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, int JLMEHOHLPHF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class EJLBEIIDKJL
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x669F390", Offset = "0x669E790", VA = "0x18669F390")]
	public static void PGCGCAKFKBJ(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, int KEHHGEKLKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x669F140", Offset = "0x669E540", VA = "0x18669F140")]
	public static void EJKKILHFNPA(byte[] NIKMHLBDDHG, int FFHOJDHOGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x669F260", Offset = "0x669E660", VA = "0x18669F260")]
	public static byte[] MJCEEGNKILJ(byte[] DJMHFPMABHB, int FFHOJDHOGBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class CNFBDNPAKPP
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x669E5E0", Offset = "0x669D9E0", VA = "0x18669E5E0")]
	public static bool GELPFIFNPLO(byte[] LLMKJGMGCBA, int OHJFONFCIND, int HCHCEBGALPA, byte[] POHOPANPNHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class KBLKLIHGHAH<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct EHKKBCKOFGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] JFBDDAMOHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T NAJOFLHMBPO;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x31EDFF0", Offset = "0x31ED3F0", VA = "0x1831EDFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class PHMJDGIPBHF : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public KBLKLIHGHAH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private EHKKBCKOFGF[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private EHKKBCKOFGF[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8E0", Offset = "0xA1DCE0", VA = "0x180A1E8E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x35CCCD0", Offset = "0x35CC0D0", VA = "0x1835CCCD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public PHMJDGIPBHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6E60", Offset = "0x3FA6260", VA = "0x183FA6E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3FA7830", Offset = "0x3FA6C30", VA = "0x183FA7830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly EHKKBCKOFGF[][] CPEHFBOHHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong BLHIGLMCOKG;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A57340", Offset = "0x3A56740", VA = "0x183A57340")]
	public KBLKLIHGHAH(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A57360", Offset = "0x3A56760", VA = "0x183A57360")]
	public KBLKLIHGHAH(int NOOJMJOLDPD, float JJMBHIOEEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AE10", Offset = "0x3A4A210", VA = "0x183A4AE10")]
	public void FLOHBAGDPJC(byte[] KCGLPAPOILB, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A545F0", Offset = "0x3A539F0", VA = "0x183A545F0")]
	private bool MJIKPNPAGHB(byte[] KCGLPAPOILB, T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CE30", Offset = "0x3A4C230", VA = "0x183A4CE30")]
	public bool MFCFPLHBNLD(ArraySegment<byte> KCGLPAPOILB, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C0E0", Offset = "0x3A4B4E0", VA = "0x183A4C0E0")]
	private static ulong FNLMKGNFAMC(byte[] LGHEBJJLAGD, int ABOMIAEBHEB, int DPBEIPGOMHN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x36F3900", Offset = "0x36F2D00", VA = "0x1836F3900")]
	private static int FBHGAKBHDIE(int MOFJMIDPCMA, float JJMBHIOEEBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C1C0", Offset = "0x3A4B5C0", VA = "0x183A4C1C0", Slot = "4")]
	[IteratorStateMachine(typeof(KBLKLIHGHAH<>.PHMJDGIPBHF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x34A0D70", Offset = "0x34A0170", VA = "0x1834A0D70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class PMFKCENCMKJ : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] DDNFLPBEBHF;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] LBOPGLMHKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int CHDGPIOBPMP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BPLKABIKFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x66B0040", Offset = "0x66AF440", VA = "0x1866B0040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x66B0190", Offset = "0x66AF590", VA = "0x1866B0190")]
	static PMFKCENCMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x66B03F0", Offset = "0x66AF7F0", VA = "0x1866B03F0")]
	public PMFKCENCMKJ(byte[] NLDBFHBIHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x66B0090", Offset = "0x66AF490", VA = "0x1866B0090")]
	public OpCode ODFFDODCPJO()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct CNCAJBIEHGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid NAJOFLHMBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte HPKPMMNEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte EGBJAOPCCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte HNEKAKGDILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte FLMBBDLIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte FCGLPGHDPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte GGHODIIOKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte MEOCCEEAIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte BKMPMDMKPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte GHBEDHBCNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte FEACCMHFIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte JNALKLLNHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte HKKLEILAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte KJBPLFHJFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte FOHJACKOLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte CDMGKEJLPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte PHHOEHNBMEL;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] KHOMDPIJNOO;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] FDGLGJHHDFK;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x669CE80", Offset = "0x669C280", VA = "0x18669CE80")]
	public CNCAJBIEHGL(Guid FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x669CE90", Offset = "0x669C290", VA = "0x18669CE90")]
	public CNCAJBIEHGL(ArraySegment<byte> BFEOHPDDCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x669BF20", Offset = "0x669B320", VA = "0x18669BF20")]
	private static byte ECOMGHJCOEG(byte[] PEBEDGMMHMC, int JDKEAIHNDBK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x669BFC0", Offset = "0x669B3C0", VA = "0x18669BFC0")]
	private static byte NDJKCFHKMEB(byte LFCFPOEDJCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x669C0E0", Offset = "0x669B4E0", VA = "0x18669C0E0")]
	public void POJMGPDPHDM(byte[] BGIIPDEPEFH, int ABOMIAEBHEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class GIEAADNLABA
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x66A3AC0", Offset = "0x66A2EC0", VA = "0x1866A3AC0")]
	public static bool LICBOFBGCMF(byte AICLPFMLBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x66A3A50", Offset = "0x66A2E50", VA = "0x1866A3A50")]
	public static bool JOLMOPFOLDI(byte AICLPFMLBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x66A3510", Offset = "0x66A2910", VA = "0x1866A3510")]
	public static sbyte HLOHHFOCDIJ(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x66A3AD0", Offset = "0x66A2ED0", VA = "0x1866A3AD0")]
	public static short NMNJAOGOFIL(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x66A3BC0", Offset = "0x66A2FC0", VA = "0x1866A3BC0")]
	public static int PAAHDGLBAKP(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x66A3670", Offset = "0x66A2A70", VA = "0x1866A3670")]
	public static long IEFLDLECFGC(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x66A2AD0", Offset = "0x66A1ED0", VA = "0x1866A2AD0")]
	public static byte FLEKMHOPIBG(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x66A21F0", Offset = "0x66A15F0", VA = "0x1866A21F0")]
	public static ushort ENGJIEKBBJI(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x66A35F0", Offset = "0x66A29F0", VA = "0x1866A35F0")]
	public static uint IBALDLMKDKN(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x66A3710", Offset = "0x66A2B10", VA = "0x1866A3710")]
	public static ulong IOLIFNLEKDJ(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x66A29F0", Offset = "0x66A1DF0", VA = "0x1866A29F0")]
	public static float FDKOKPIEBBM(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x66A2910", Offset = "0x66A1D10", VA = "0x1866A2910")]
	public static double FBLLIJBEAAL(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x66A2270", Offset = "0x66A1670", VA = "0x1866A2270")]
	public static int EPKJNHDCGEB(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, ulong FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x66A2B50", Offset = "0x66A1F50", VA = "0x1866A2B50")]
	public static int GJMHIMCDPCB(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, long FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x66A3820", Offset = "0x66A2C20", VA = "0x1866A3820")]
	public static bool JNAJJDCAPAG(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class KMOALNPDELA
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class DBLLLFEPIDP : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x9346D0", Offset = "0x933AD0", VA = "0x1809346D0")]
		[DebuggerHidden]
		public DBLLLFEPIDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x669EC30", Offset = "0x669E030", VA = "0x18669EC30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x669E6F0", Offset = "0x669DAF0", VA = "0x18669E6F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x669E650", Offset = "0x669DA50", VA = "0x18669E650")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x669E6A0", Offset = "0x669DAA0", VA = "0x18669E6A0")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x669EBE0", Offset = "0x669DFE0", VA = "0x18669EBE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x669EB20", Offset = "0x669DF20", VA = "0x18669EB20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x669EB20", Offset = "0x669DF20", VA = "0x18669EB20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class NCDNCDDFCDO : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9346D0", Offset = "0x933AD0", VA = "0x1809346D0")]
		[DebuggerHidden]
		public NCDNCDDFCDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x66AAEE0", Offset = "0x66AA2E0", VA = "0x1866AAEE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x66AA9A0", Offset = "0x66A9DA0", VA = "0x1866AA9A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x66AA900", Offset = "0x66A9D00", VA = "0x1866AA900")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x66AA950", Offset = "0x66A9D50", VA = "0x1866AA950")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x66AAE90", Offset = "0x66AA290", VA = "0x1866AAE90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x66AADD0", Offset = "0x66AA1D0", VA = "0x1866AADD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x66AADD0", Offset = "0x66AA1D0", VA = "0x1866AADD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x66A78A0", Offset = "0x66A6CA0", VA = "0x1866A78A0")]
	public static bool HHHMIBAADHM(this TypeInfo ADAMDPHPFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x66A76D0", Offset = "0x66A6AD0", VA = "0x1866A76D0")]
	public static bool APCGHDNBJFF(this TypeInfo ADAMDPHPFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x66A7A80", Offset = "0x66A6E80", VA = "0x1866A7A80")]
	public static IEnumerable<PropertyInfo> PDIIJIODEGK(this Type ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x66A79E0", Offset = "0x66A6DE0", VA = "0x1866A79E0")]
	[IteratorStateMachine(typeof(DBLLLFEPIDP))]
	private static IEnumerable<PropertyInfo> OILBECDIGKD(Type ADAMDPHPFAA, HashSet<string> FJFDHBCBBHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x66A7960", Offset = "0x66A6D60", VA = "0x1866A7960")]
	public static IEnumerable<FieldInfo> JKHOHOKGJAM(this Type ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x66A7800", Offset = "0x66A6C00", VA = "0x1866A7800")]
	[IteratorStateMachine(typeof(NCDNCDDFCDO))]
	private static IEnumerable<FieldInfo> DHDLCNDACFM(Type ADAMDPHPFAA, HashSet<string> FJFDHBCBBHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class EDLDFHFKOLK
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding AADEBJMPEAN;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class JNDIDNLHCFP
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	public static string DHBLKHOJEKK(string MKFPNMJBPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x66A72E0", Offset = "0x66A66E0", VA = "0x1866A72E0")]
	public static string EKEFFKBKPIL(string MKFPNMJBPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x66A73C0", Offset = "0x66A67C0", VA = "0x1866A73C0")]
	public static string PMIIOBLNAHB(string MKFPNMJBPKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class HLJBEPCNCAC<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class AOKIHJIKNHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type JFBDDAMOHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue NAJOFLHMBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int MCFDHLJHIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AOKIHJIKNHE OBADPIAFNKI;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3721870", Offset = "0x3720C70", VA = "0x183721870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x37217F0", Offset = "0x3720BF0", VA = "0x1837217F0")]
		private int OICIIFDIAGM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public AOKIHJIKNHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class LJPABCGGFOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LJPABCGGFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB58670", Offset = "0xB57A70", VA = "0x180B58670")]
		internal TValue HDBIBGKEABE(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private AOKIHJIKNHE[] CPEHFBOHHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int BFFGCOIILMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object LIHIKOOELAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float JJMBHIOEEBA;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x36F4290", Offset = "0x36F3690", VA = "0x1836F4290")]
	public HLJBEPCNCAC(int NOOJMJOLDPD = 4, float JJMBHIOEEBA = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x36F34C0", Offset = "0x36F28C0", VA = "0x1836F34C0")]
	public bool AMOFEKFEHHG(Type KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x36F3720", Offset = "0x36F2B20", VA = "0x1836F3720")]
	public bool AMOFEKFEHHG(Type KCGLPAPOILB, Func<Type, TValue> JIFPACEMJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x36F3BD0", Offset = "0x36F2FD0", VA = "0x1836F3BD0")]
	private bool MJIKPNPAGHB(Type KCGLPAPOILB, Func<Type, TValue> JIFPACEMJBG, [Out] TValue AMAHGMALPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x36F30D0", Offset = "0x36F24D0", VA = "0x1836F30D0")]
	private bool AFFCPLOCPNK(AOKIHJIKNHE[] CPEHFBOHHKG, Type NFJHAPILCGK, AOKIHJIKNHE KJOILHCHHGK, Func<Type, TValue> JIFPACEMJBG, [Out] TValue AMAHGMALPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x36F3A60", Offset = "0x36F2E60", VA = "0x1836F3A60")]
	public bool MFCFPLHBNLD(Type KCGLPAPOILB, [Out] TValue FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x36F3850", Offset = "0x36F2C50", VA = "0x1836F3850")]
	public TValue CHLPPFFEBAE(Type KCGLPAPOILB, Func<Type, TValue> JIFPACEMJBG)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x36F3900", Offset = "0x36F2D00", VA = "0x1836F3900")]
	private static int FBHGAKBHDIE(int MOFJMIDPCMA, float JJMBHIOEEBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x36F3BA0", Offset = "0x36F2FA0", VA = "0x1836F3BA0")]
	private static void MHCCMAEHPMG(AOKIHJIKNHE OIEGPBDOILH, AOKIHJIKNHE FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x36F3BA0", Offset = "0x36F2FA0", VA = "0x1836F3BA0")]
	private static void MHCCMAEHPMG(AOKIHJIKNHE[] OIEGPBDOILH, AOKIHJIKNHE[] FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class MLBNKLMMCKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder CEPJJHFLGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder HNMEIFFLJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object FLHHCMKGPNE;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x66A8D70", Offset = "0x66A8170", VA = "0x1866A8D70")]
	public TypeBuilder IENKKPBFBOM(string OMHHPMIDNAN, TypeAttributes JAOOLAHHCAO, Type BBCCHMIJNJG, Type[] NLDNMGHFPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x66A8E70", Offset = "0x66A8270", VA = "0x1866A8E70")]
	public MLBNKLMMCKI(string OMJMIIKHFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class FJPPFBLMKDK
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x669F4D0", Offset = "0x669E8D0", VA = "0x18669F4D0")]
	private static MethodInfo BDPPNMMHEFD(LambdaExpression BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x26154D0", Offset = "0x26148D0", VA = "0x1826154D0")]
	public static MethodInfo FOJLMCLCDKF<T>(Expression<Func<T>> BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x26154D0", Offset = "0x26148D0", VA = "0x1826154D0")]
	public static MethodInfo FOJLMCLCDKF<T, TR>(Expression<Func<T, TR>> BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x26154D0", Offset = "0x26148D0", VA = "0x1826154D0")]
	public static MethodInfo FOJLMCLCDKF<T>(Expression<Action<T>> BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x26154D0", Offset = "0x26148D0", VA = "0x1826154D0")]
	public static MethodInfo FOJLMCLCDKF<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x26153F0", Offset = "0x26147F0", VA = "0x1826153F0")]
	private static MemberInfo ABOJEPHEONM<T>(Expression<T> JIBNFGIMNPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x26154E0", Offset = "0x26148E0", VA = "0x1826154E0")]
	public static PropertyInfo GMIFDFDIDJF<T, TR>(Expression<Func<T, TR>> BNDBJEMLHJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct MCNDOMPCHHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int CCNHOKJIGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool LGCBFJMCLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator PMPDDDDPEFP;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x66A8CA0", Offset = "0x66A80A0", VA = "0x1866A8CA0")]
	public MCNDOMPCHHF(ILGenerator PMPDDDDPEFP, int CCNHOKJIGCD, bool LGCBFJMCLHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x66A8CE0", Offset = "0x66A80E0", VA = "0x1866A8CE0")]
	public MCNDOMPCHHF(ILGenerator PMPDDDDPEFP, int CCNHOKJIGCD, Type ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x66A8BA0", Offset = "0x66A7FA0", VA = "0x1866A8BA0")]
	public void OFMBECPEBEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class PLLNHPJANOB
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x66AF210", Offset = "0x66AE610", VA = "0x1866AF210")]
	public static void GPIDOIONKCD(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x66AF400", Offset = "0x66AE800", VA = "0x1866AF400")]
	public static void GPIDOIONKCD(this ILGenerator PMPDDDDPEFP, LocalBuilder NPBAHKMGBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x66AF630", Offset = "0x66AEA30", VA = "0x1866AF630")]
	public static void HEFKMMIILEH(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x66AF820", Offset = "0x66AEC20", VA = "0x1866AF820")]
	public static void HEFKMMIILEH(this ILGenerator PMPDDDDPEFP, LocalBuilder NPBAHKMGBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x66AFD80", Offset = "0x66AF180", VA = "0x1866AFD80")]
	public static void OCNMAKMJHFG(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x66AFE60", Offset = "0x66AF260", VA = "0x1866AFE60")]
	public static void OCNMAKMJHFG(this ILGenerator PMPDDDDPEFP, LocalBuilder NPBAHKMGBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x66AEFB0", Offset = "0x66AE3B0", VA = "0x1866AEFB0")]
	public static void DJKOMDHOCFO(this ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x66AFD70", Offset = "0x66AF170", VA = "0x1866AFD70")]
	public static void NKNBFNJDGKH(this ILGenerator PMPDDDDPEFP, bool FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x66AF860", Offset = "0x66AEC60", VA = "0x1866AF860")]
	public static void HFBGLJGMFBF(this ILGenerator PMPDDDDPEFP, int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x66AEFC0", Offset = "0x66AE3C0", VA = "0x1866AEFC0")]
	public static void EOOPONMKGMP(this ILGenerator PMPDDDDPEFP, Type ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x66AFCD0", Offset = "0x66AF0D0", VA = "0x1866AFCD0")]
	public static void KMGPJPIMNOF(this ILGenerator PMPDDDDPEFP, Type ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x66AF440", Offset = "0x66AE840", VA = "0x1866AF440")]
	public static void HDNJAGDCKNB(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x66AF0A0", Offset = "0x66AE4A0", VA = "0x1866AF0A0")]
	public static void GKMODGLLAAL(this ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x66AFF60", Offset = "0x66AF360", VA = "0x1866AFF60")]
	public static void PHHJAPIGGHJ(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x66AF120", Offset = "0x66AE520", VA = "0x1866AF120")]
	public static void GPFLBGGOEBJ(this ILGenerator PMPDDDDPEFP, MethodInfo DEIILLNONCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x66AFC40", Offset = "0x66AF040", VA = "0x1866AFC40")]
	public static void JBPPCMGMMKI(this ILGenerator PMPDDDDPEFP, FieldInfo JFAEILFALDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x66AEF20", Offset = "0x66AE320", VA = "0x1866AEF20")]
	public static void BNJICDBJGJN(this ILGenerator PMPDDDDPEFP, ulong FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class OLEMMHLFKLG
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class NDHNMKCLMJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NDHNMKCLMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x66AB010", Offset = "0x66AA410", VA = "0x1866AB010")]
		internal bool GHGKCHOEONL(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo IPELOFEOHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo MFIGOHDLPEK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string OFNHONEHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x79F1B0", Offset = "0x79E5B0", VA = "0x18079F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EIMCHGLHJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x66AE7E0", Offset = "0x66ADBE0", VA = "0x1866AE7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool JBKDEIOKHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x79F210", Offset = "0x79E610", VA = "0x18079F210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x79F1D0", Offset = "0x79E5D0", VA = "0x18079F1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FOAFKHHPBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8F0", Offset = "0x8ACCF0", VA = "0x1808AD8F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5E0", Offset = "0x8AC9E0", VA = "0x1808AD5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MIOIDKGGEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7A2260", Offset = "0x7A1660", VA = "0x1807A2260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo DKJKLLCBPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo BJEGBIHCEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x79F430", Offset = "0x79E830", VA = "0x18079F430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo EGDIJLIJDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x79F150", Offset = "0x79E550", VA = "0x18079F150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x79F250", Offset = "0x79E650", VA = "0x18079F250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x66AEDB0", Offset = "0x66AE1B0", VA = "0x1866AEDB0")]
	protected OLEMMHLFKLG(Type ADAMDPHPFAA, string OMHHPMIDNAN, string CCMBMNIPICA, bool IGGPAIICACB, bool DBLPNNDDOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x66AEAE0", Offset = "0x66ADEE0", VA = "0x1866AEAE0")]
	public OLEMMHLFKLG(FieldInfo CBJFHHJLIDF, string OMHHPMIDNAN, bool LFJILANPPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x66AEBF0", Offset = "0x66ADFF0", VA = "0x1866AEBF0")]
	public OLEMMHLFKLG(PropertyInfo CBJFHHJLIDF, string OMHHPMIDNAN, bool LFJILANPPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x66AE970", Offset = "0x66ADD70", VA = "0x1866AE970")]
	private static MethodInfo OIKFKGEGMJH(MemberInfo CBJFHHJLIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x278E350", Offset = "0x278D750", VA = "0x18278E350")]
	public T FFEOGMFKKNP<T>(bool OECHNCDEFJL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x66AE7F0", Offset = "0x66ADBF0", VA = "0x1866AE7F0", Slot = "4")]
	public virtual void MOCDHGFAHII(ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x66AE660", Offset = "0x66ADA60", VA = "0x1866AE660", Slot = "5")]
	public virtual void DJABHPEDJCJ(ILGenerator PMPDDDDPEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class ANKHKLJINPO : OLEMMHLFKLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string KHLEBOFEMIJ;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x669A050", Offset = "0x6699450", VA = "0x18669A050")]
	public ANKHKLJINPO(string OMHHPMIDNAN, string KHLEBOFEMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6699FA0", Offset = "0x66993A0", VA = "0x186699FA0", Slot = "4")]
	public override void MOCDHGFAHII(ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6699F50", Offset = "0x6699350", VA = "0x186699F50", Slot = "5")]
	public override void DJABHPEDJCJ(ILGenerator PMPDDDDPEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class NGCGHJHLCIF : OLEMMHLFKLG
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo LHHBFJGIKFO;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo LGINPOGIFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal MCNDOMPCHHF NIOLFAOFCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal MCNDOMPCHHF IKIIEEKPDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal MCNDOMPCHHF DNKONHCEJBL;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x66AB900", Offset = "0x66AAD00", VA = "0x1866AB900")]
	public NGCGHJHLCIF(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x66AB330", Offset = "0x66AA730", VA = "0x1866AB330", Slot = "4")]
	public override void MOCDHGFAHII(ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x66AB120", Offset = "0x66AA520", VA = "0x1866AB120", Slot = "5")]
	public override void DJABHPEDJCJ(ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x66AB170", Offset = "0x66AA570", VA = "0x1866AB170")]
	public void KECPEPIDJHM(ILGenerator PMPDDDDPEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class NOOPFPAOOED
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type MIOIDKGGEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DEHINILGNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x80D7C0", Offset = "0x80CBC0", VA = "0x18080D7C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7A6180", Offset = "0x7A5580", VA = "0x1807A6180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EBOADOOGBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFB0", Offset = "0x8AB3B0", VA = "0x1808ABFB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8B0", Offset = "0x8AACB0", VA = "0x1808AB8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo NLMPKPLCNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C60", Offset = "0x7A0060", VA = "0x1807A0C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public OLEMMHLFKLG[] PLMENBLCPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7A2260", Offset = "0x7A1660", VA = "0x1807A2260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public OLEMMHLFKLG[] AEKKHACPLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x66ABCC0", Offset = "0x66AB0C0", VA = "0x1866ABCC0")]
	public NOOPFPAOOED(Type ADAMDPHPFAA, Func<string, string> EAMBNIHFNPH, bool LFJILANPPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x66ABBE0", Offset = "0x66AAFE0", VA = "0x1866ABBE0")]
	private static bool IFDOOPDIGBB(IEnumerator<ConstructorInfo> KDMEKJINNDL, ConstructorInfo PPFKPMCMFKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct JKBEAMDAIKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong BDOADEOBIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int KMJIPKGNLDF;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1D7E4B0", Offset = "0x1D7D8B0", VA = "0x181D7E4B0")]
	public JKBEAMDAIKK(ulong IOAGEHEMMAI, int NBJHAABFIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x66A71B0", Offset = "0x66A65B0", VA = "0x1866A71B0")]
	public void IHGHODEHAHE(JKBEAMDAIKK AAMIMDAKFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x66A7100", Offset = "0x66A6500", VA = "0x1866A7100")]
	public static JKBEAMDAIKK ABPBLACPJAC(JKBEAMDAIKK MAGGDEMNFDG, JKBEAMDAIKK LFCFPOEDJCH)
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x66A71C0", Offset = "0x66A65C0", VA = "0x1866A71C0")]
	public void MHIBHMFPDFP(JKBEAMDAIKK AAMIMDAKFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x66A7110", Offset = "0x66A6510", VA = "0x1866A7110")]
	public static JKBEAMDAIKK DPJIHMMJNIA(JKBEAMDAIKK MAGGDEMNFDG, JKBEAMDAIKK LFCFPOEDJCH)
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x66A7250", Offset = "0x66A6650", VA = "0x1866A7250")]
	public void NGLOJPGDJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x66A7290", Offset = "0x66A6690", VA = "0x1866A7290")]
	public static JKBEAMDAIKK NGLOJPGDJAG(JKBEAMDAIKK MAGGDEMNFDG)
	{
		return default(JKBEAMDAIKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct ICNOCJPABHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] BGIIPDEPEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int ABOMIAEBHEB;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x179FBD0", Offset = "0x179EFD0", VA = "0x18179FBD0")]
	public ICNOCJPABHO(byte[] BGIIPDEPEFH, int HGKJDOIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6690420", Offset = "0x668F820", VA = "0x186690420")]
	public void KAECJMHCKFB(byte ADLBCEDEBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x66A5E00", Offset = "0x66A5200", VA = "0x1866A5E00")]
	public void KIPPKEHHKAC(byte[] ADLBCEDEBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x66A5F80", Offset = "0x66A5380", VA = "0x1866A5F80")]
	public void NCBAPNCKBAP(byte[] ADLBCEDEBAN, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x66A6000", Offset = "0x66A5400", VA = "0x1866A6000")]
	public void NCBAPNCKBAP(byte[] ADLBCEDEBAN, int AJOMPGHNEBN, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x66A5D80", Offset = "0x66A5180", VA = "0x1866A5D80")]
	public void FPIBJPFKBFO(byte AICLPFMLBHB, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x66A5E80", Offset = "0x66A5280", VA = "0x1866A5E80")]
	public void LIAOFBEIDKD(string ADLBCEDEBAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class GCFNEGMDICE
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum IGMCHMEGMON
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum NIBEHKLDEOP
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum OLGCMINDNAO
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
	private static byte[] EBILOMPKNGN;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] CFCKJODGOIP;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] EHNHEEDGIMC;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] NLONEKJCLNG;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly OLGCMINDNAO GFPIPKEHKDG;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char IACPLIHABGH;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int CKHGIIHDLKN;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int JBANIECEPFE;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] HAFCEEOLCNO;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x669FBD0", Offset = "0x669EFD0", VA = "0x18669FBD0")]
	private static byte[] BHLDEFAFKFC(int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x66A1480", Offset = "0x66A0880", VA = "0x1866A1480")]
	private static byte[] OEBDFJMFOIP(int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x66A1240", Offset = "0x66A0640", VA = "0x1866A1240")]
	public static int NDINFEBECJN(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, float FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x66A1360", Offset = "0x66A0760", VA = "0x1866A1360")]
	public static int NDINFEBECJN(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, double FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x66A0BE0", Offset = "0x669FFE0", VA = "0x1866A0BE0")]
	private static bool HMIPHJLPLOL(byte[] BGIIPDEPEFH, int CBKFAHCFHJN, ulong BAJBPNDKHNP, ulong OELOHGHDGBP, ulong JLMEHOHLPHF, ulong IBFPPECIFHK, ulong MFEONNDDGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x66A0CD0", Offset = "0x66A00D0", VA = "0x1866A0CD0")]
	private static void HODNOHOOOBP(uint OBKHJBKAEPG, int IGBHPCADJPG, [Out] uint PCLEMPNBMGO, [Out] int PDNFAOGMKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x66A0180", Offset = "0x669F580", VA = "0x1866A0180")]
	private static bool CMJJIAPDDKI(JKBEAMDAIKK MKGNEPHFNKB, JKBEAMDAIKK LKDONMJJPCN, JKBEAMDAIKK BPBMHLKMPFJ, byte[] BGIIPDEPEFH, [Out] int CBKFAHCFHJN, [Out] int DNKHHJEIGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x66A0DC0", Offset = "0x66A01C0", VA = "0x1866A0DC0")]
	private static bool IJDDONILKDG(double MHNPONMPDCG, IGMCHMEGMON GBFDMJLKPAC, byte[] BGIIPDEPEFH, [Out] int CBKFAHCFHJN, [Out] int LICPKIDMBOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x66A0900", Offset = "0x669FD00", VA = "0x1866A0900")]
	private static bool EJNBHDGKALP(double MHNPONMPDCG, IGMCHMEGMON GBFDMJLKPAC, byte[] BGIIPDEPEFH, [Out] int CBKFAHCFHJN, [Out] int CEMLGKOICHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x66A0A10", Offset = "0x669FE10", VA = "0x1866A0A10")]
	private static bool ENBDEDEIGBM(double FDFHGIHHGHO, ICNOCJPABHO NPGFINHODME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x669FCA0", Offset = "0x669F0A0", VA = "0x18669FCA0")]
	private static bool BNNOIIDFFCI(double FDFHGIHHGHO, ICNOCJPABHO NPGFINHODME, NIBEHKLDEOP GBFDMJLKPAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x66A0570", Offset = "0x669F970", VA = "0x1866A0570")]
	private static void DGHGOPPEIDN(byte[] GPLAMKEOFAI, int CBKFAHCFHJN, int CEMLGKOICHB, int NCCMPMOMCMN, ICNOCJPABHO NPGFINHODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x669F7A0", Offset = "0x669EBA0", VA = "0x18669F7A0")]
	private static void AJPJCLGCHCC(byte[] GPLAMKEOFAI, int CBKFAHCFHJN, int NBJHAABFIFP, ICNOCJPABHO NPGFINHODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x669F5B0", Offset = "0x669E9B0", VA = "0x18669F5B0")]
	private static bool ADBOCPGBMKM(double MHNPONMPDCG, NIBEHKLDEOP GBFDMJLKPAC, int EEAHJMLFONC, byte[] POMEINMNNLJ, [Out] bool NDEMGCCGNFN, [Out] int CBKFAHCFHJN, [Out] int INKDDDGDGBD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct IHLLIMKIOCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double KGLKPBOCCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong AGCHEFMHGMP;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct DMDLNJLHJML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float BDOADEOBIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint EOPOMJIPPAH;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct ACONHCGELAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong BEHPIAMENBN;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6699EA0", Offset = "0x66992A0", VA = "0x186699EA0")]
	public ACONHCGELAH(double KGLKPBOCCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6699EB0", Offset = "0x66992B0", VA = "0x186699EB0")]
	public ACONHCGELAH(JKBEAMDAIKK KGLKPBOCCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6699980", Offset = "0x6698D80", VA = "0x186699980")]
	public JKBEAMDAIKK CBIJKGNDFPI()
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6699A00", Offset = "0x6698E00", VA = "0x186699A00")]
	public JKBEAMDAIKK CDIHGANDEOD()
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0")]
	public ulong ADNGKLNHHLN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6699DB0", Offset = "0x66991B0", VA = "0x186699DB0")]
	public double LBGIBAPGELC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6699BD0", Offset = "0x6698FD0", VA = "0x186699BD0")]
	public double DLKLHDINKFA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6699D80", Offset = "0x6699180", VA = "0x186699D80")]
	public int LBCMJLMOAJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6699D00", Offset = "0x6699100", VA = "0x186699D00")]
	public ulong KKDMOLMAHFG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6699910", Offset = "0x6698D10", VA = "0x186699910")]
	public bool AADCDAJNKPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6699E30", Offset = "0x6699230", VA = "0x186699E30")]
	public bool LDKPHFKJBGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6699950", Offset = "0x6698D50", VA = "0x186699950")]
	public bool BPKJJLODDHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6699E70", Offset = "0x6699270", VA = "0x186699E70")]
	public bool OMBICHMLGGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6699930", Offset = "0x6698D30", VA = "0x186699930")]
	public int BBDAMGIMFBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6699A80", Offset = "0x6698E80", VA = "0x186699A80")]
	public void DJCFMFGIIFK([Out] JKBEAMDAIKK GLCIELHGEEF, [Out] JKBEAMDAIKK LGNBBDMLOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6699D30", Offset = "0x6699130", VA = "0x186699D30")]
	public bool LBBCNINJAGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B9EAF0", Offset = "0x2B9DEF0", VA = "0x182B9EAF0")]
	public double FDFHGIHHGHO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6699E50", Offset = "0x6699250", VA = "0x186699E50")]
	public static int NNOPIJAAHKA(int LJMBCOIKEFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x66999F0", Offset = "0x6698DF0", VA = "0x1866999F0")]
	public static double CBNMIPFCLGF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6699C70", Offset = "0x6699070", VA = "0x186699C70")]
	public static ulong HMEDGDHOICO(JKBEAMDAIKK CMJMGBEMGCE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct JDBEFOJNABE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint JDHFHLHFMHM;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3B30", Offset = "0x1EB2F30", VA = "0x181EB3B30")]
	public JDBEFOJNABE(float BDOADEOBIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x66A6D30", Offset = "0x66A6130", VA = "0x1866A6D30")]
	public JKBEAMDAIKK CBIJKGNDFPI()
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x88ADC0", Offset = "0x88A1C0", VA = "0x18088ADC0")]
	public uint AGEJLEPNPGO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x66A6F10", Offset = "0x66A6310", VA = "0x1866A6F10")]
	public int LBCMJLMOAJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x66A6EB0", Offset = "0x66A62B0", VA = "0x1866A6EB0")]
	public uint KKDMOLMAHFG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x66A6D20", Offset = "0x66A6120", VA = "0x1866A6D20")]
	public bool AADCDAJNKPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x66A6D80", Offset = "0x66A6180", VA = "0x1866A6D80")]
	public void DJCFMFGIIFK([Out] JKBEAMDAIKK GLCIELHGEEF, [Out] JKBEAMDAIKK LGNBBDMLOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x66A6ED0", Offset = "0x66A62D0", VA = "0x1866A6ED0")]
	public bool LBBCNINJAGK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct BMMEAKDIEID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong IOAGEHEMMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short FIBMICOJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short LICPKIDMBOH;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x669A300", Offset = "0x6699700", VA = "0x18669A300")]
	public BMMEAKDIEID(ulong IOAGEHEMMAI, short FIBMICOJEKM, short LICPKIDMBOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class ODLMMHPOPOJ
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly BMMEAKDIEID[] LCEGGOOCBLN;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x66AD520", Offset = "0x66AC920", VA = "0x1866AD520")]
	public static void DMKOMBEKFFD(int JKCNDPKKOBM, int IIBACGAIONO, [Out] JKBEAMDAIKK PCLEMPNBMGO, [Out] int LICPKIDMBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x66AD630", Offset = "0x66ACA30", VA = "0x1866AD630")]
	public static void GEKIAGIJFFA(int NILKLIJOOOF, [Out] JKBEAMDAIKK PCLEMPNBMGO, [Out] int JEHIMIBCOLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct NHJPEHBOIJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] PEBEDGMMHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int AJOMPGHNEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int JJMMMOEDOFK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x66AB9C0", Offset = "0x66AADC0", VA = "0x1866AB9C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AB80", Offset = "0x3A69F80", VA = "0x183A6AB80")]
	public NHJPEHBOIJD(byte[] PEBEDGMMHMC, int AJOMPGHNEBN, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1EE4470", Offset = "0x1EE3870", VA = "0x181EE4470")]
	public int CBKFAHCFHJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x66ABA00", Offset = "0x66AAE00", VA = "0x1866ABA00")]
	public NHJPEHBOIJD MKDCPLCCIEA(int DNFMACCGFHJ, int AKPLHCDECML)
	{
		return default(NHJPEHBOIJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class MPNGHIFLPLL
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] CGGHDMKMKDI;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] GJFLAGKDKGM;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int CILAGFDANDP;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x66A9DC0", Offset = "0x66A91C0", VA = "0x1866A9DC0")]
	private static byte[] JDAEOIPANOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x66A93C0", Offset = "0x66A87C0", VA = "0x1866A93C0")]
	private static NHJPEHBOIJD CPPENCOAFMC(NHJPEHBOIJD BGIIPDEPEFH)
	{
		return default(NHJPEHBOIJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x66A92E0", Offset = "0x66A86E0", VA = "0x1866A92E0")]
	private static NHJPEHBOIJD CFPMIMJJMLJ(NHJPEHBOIJD BGIIPDEPEFH)
	{
		return default(NHJPEHBOIJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x66AA690", Offset = "0x66A9A90", VA = "0x1866AA690")]
	private static void MGJAJOFCHNK(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP, byte[] JEEDJABCHJM, [Out] int IHIKODNCHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AD0", Offset = "0x66A8ED0", VA = "0x1866A9AD0")]
	private static void IBLFINFHEGH(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP, byte[] JEODLGNOGGB, int IALKDKFNMPD, [Out] NHJPEHBOIJD BNKIALJICBN, [Out] int HPDEKKGBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x66A8F80", Offset = "0x66A8380", VA = "0x1866A8F80")]
	private static ulong ANIIDOEGLOB(NHJPEHBOIJD BGIIPDEPEFH, [Out] int BFAIFPDBPCM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x66A95C0", Offset = "0x66A89C0", VA = "0x1866A95C0")]
	private static void DJGDDJLKHED(NHJPEHBOIJD BGIIPDEPEFH, [Out] JKBEAMDAIKK MNKBHKEBOPJ, [Out] int MNGJLNIPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x66A9700", Offset = "0x66A8B00", VA = "0x1866A9700")]
	private static bool FKNDEOPGDDO(NHJPEHBOIJD BNKIALJICBN, int NBJHAABFIFP, [Out] double MNKBHKEBOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x66A9EA0", Offset = "0x66A92A0", VA = "0x1866A9EA0")]
	private static JKBEAMDAIKK LDAAHDJNAIA(int NBJHAABFIFP)
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x66AA040", Offset = "0x66A9440", VA = "0x1866AA040")]
	private static bool LPEHDDCNPPB(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP, [Out] double MNKBHKEBOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x66A94A0", Offset = "0x66A88A0", VA = "0x1866A94A0")]
	private static bool DJEIHLENFKG(NHJPEHBOIJD BNKIALJICBN, int NBJHAABFIFP, [Out] double MDELOMBNNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x66AA720", Offset = "0x66A9B20", VA = "0x1866AA720")]
	public static double? PNGGFNIGEOJ(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x66A9010", Offset = "0x66A8410", VA = "0x1866A9010")]
	public static float? AOKFPCKBKPI(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct IJEFDCMJOOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] BGIIPDEPEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int ABOMIAEBHEB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x66A6B40", Offset = "0x66A5F40", VA = "0x1866A6B40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x179FBD0", Offset = "0x179EFD0", VA = "0x18179FBD0")]
	public IJEFDCMJOOM(byte[] BGIIPDEPEFH, int ABOMIAEBHEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x66A6B30", Offset = "0x66A5F30", VA = "0x1866A6B30")]
	public static IJEFDCMJOOM MGINOFJNHOG(IJEFDCMJOOM NHHBAHIFHJK)
	{
		return default(IJEFDCMJOOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x66A6AE0", Offset = "0x66A5EE0", VA = "0x1866A6AE0")]
	public static IJEFDCMJOOM KILOAEIJEKO(IJEFDCMJOOM NHHBAHIFHJK, int CBKFAHCFHJN)
	{
		return default(IJEFDCMJOOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x66A69C0", Offset = "0x66A5DC0", VA = "0x1866A69C0")]
	public static int DEAFAHIGGBI(IJEFDCMJOOM CGDDINAJAOB, IJEFDCMJOOM GIFBDNCPDKC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x66A6A10", Offset = "0x66A5E10", VA = "0x1866A6A10")]
	public static bool FFFIMEBHMPG(IJEFDCMJOOM CGDDINAJAOB, IJEFDCMJOOM GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x66A69D0", Offset = "0x66A5DD0", VA = "0x1866A69D0")]
	public static bool DKCGANGKMBM(IJEFDCMJOOM CGDDINAJAOB, IJEFDCMJOOM GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x66A6A20", Offset = "0x66A5E20", VA = "0x1866A6A20")]
	public static bool FFFIMEBHMPG(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x66A69E0", Offset = "0x66A5DE0", VA = "0x1866A69E0")]
	public static bool DKCGANGKMBM(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x66A69E0", Offset = "0x66A5DE0", VA = "0x1866A69E0")]
	public static bool DKCGANGKMBM(IJEFDCMJOOM CGDDINAJAOB, byte GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x66A6A50", Offset = "0x66A5E50", VA = "0x1866A6A50")]
	public static bool FFOKIMDPMMG(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x66A6A80", Offset = "0x66A5E80", VA = "0x1866A6A80")]
	public static bool FPIOOKIBAAA(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x66A6B70", Offset = "0x66A5F70", VA = "0x1866A6B70")]
	public static bool NKMDIAMJMKN(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x66A6AB0", Offset = "0x66A5EB0", VA = "0x1866A6AB0")]
	public static bool GJMOKDAGLFM(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class HGJDJPIKGIK
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] AFEDMMBJNAC;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] ILNEDNJDCAI;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] EHNHEEDGIMC;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] NLONEKJCLNG;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] MNGBPGFLMJM;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int ECMIKLGNLPF;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] NEPIMEFJPJK;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int AGBJPPBMOMA;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x66A5220", Offset = "0x66A4620", VA = "0x1866A5220")]
	private static byte[] NDDOLLGIIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x66A5300", Offset = "0x66A4700", VA = "0x1866A5300")]
	private static byte[] OOEJLPMGHIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x66A50C0", Offset = "0x66A44C0", VA = "0x1866A50C0")]
	public static double HGDNMFHJBCO(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x66A5170", Offset = "0x66A4570", VA = "0x1866A5170")]
	public static float JJCHGEADPGN(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x66A3EA0", Offset = "0x66A32A0", VA = "0x1866A3EA0")]
	private static bool CFNNCLJLJKP(int LGHEBJJLAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x66A3CB0", Offset = "0x66A30B0", VA = "0x1866A3CB0")]
	private static bool CCGALKDJIHE(IJEFDCMJOOM OHGGFJCBDAL, IJEFDCMJOOM HPBGGHHMELE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x66A4FD0", Offset = "0x66A43D0", VA = "0x1866A4FD0")]
	private static bool FPINJNKDDOJ(IJEFDCMJOOM OHGGFJCBDAL, IJEFDCMJOOM HPBGGHHMELE, byte[] OMMFAGLFEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x66A4F80", Offset = "0x66A4380", VA = "0x1866A4F80")]
	private static bool EOGLGFADEIB(IJEFDCMJOOM JGGIJMDALAN, byte[] ADLBCEDEBAN, int ABOMIAEBHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x66A50A0", Offset = "0x66A44A0", VA = "0x1866A50A0")]
	private static double GNGNLBECJEJ(bool NDEMGCCGNFN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x66A3FE0", Offset = "0x66A33E0", VA = "0x1866A3FE0")]
	private static double CLJMDAFHLLL(IJEFDCMJOOM KODNHMICLEA, int CBKFAHCFHJN, bool KHGBIKGCDDK, [Out] int FHOHPBOOKOO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class KBICCIBMAAC<T> : CDPHELCNEFG<T[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly NIHDPFILHMD<T> FBAGFMIOMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly CJBAJCFLGFB ENPICANKJPE;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x368A460", Offset = "0x3689860", VA = "0x18368A460")]
	public KBICCIBMAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
	public KBICCIBMAAC(CJBAJCFLGFB ENPICANKJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A494D0", Offset = "0x3A488D0", VA = "0x183A494D0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A49100", Offset = "0x3A48500", VA = "0x183A49100", Slot = "5")]
	public T[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class NJCGHDHHPNP<T> : CDPHELCNEFG<ArraySegment<T>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly NIHDPFILHMD<T> FBAGFMIOMHE;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3E01550", Offset = "0x3E00950", VA = "0x183E01550", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ArraySegment<T> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3E01130", Offset = "0x3E00530", VA = "0x183E01130", Slot = "5")]
	public ArraySegment<T> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class MANCGONIDAH<T> : CDPHELCNEFG<List<T>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly CJBAJCFLGFB ENPICANKJPE;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x368A460", Offset = "0x3689860", VA = "0x18368A460")]
	public MANCGONIDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
	public MANCGONIDAH(CJBAJCFLGFB ENPICANKJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x3D2D480", Offset = "0x3D2C880", VA = "0x183D2D480", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, List<T> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3D29C50", Offset = "0x3D29050", VA = "0x183D29C50", Slot = "5")]
	public List<T> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class EPKHJPOCFBC<TElement, TIntermediate, TEnumerator, TCollection> : CDPHELCNEFG<TCollection>, MEAKMJHAEGJ where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3237740", Offset = "0x3236B40", VA = "0x183237740", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, TCollection FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3236110", Offset = "0x3235510", VA = "0x183236110", Slot = "5")]
	public TCollection AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EKCAMIJIIEA(TCollection JIBNFGIMNPP);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate NDFPICIGPEG();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void FLOHBAGDPJC(TIntermediate AIEAHONEFEF, int OJANCMLFDOJ, TElement FDFHGIHHGHO);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection LAAAOIHLIFJ(TIntermediate PGLKCKDGDOA);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected EPKHJPOCFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class HPJECNAGKOI<TElement, TIntermediate, TCollection> : EPKHJPOCFBC<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3704310", Offset = "0x3703710", VA = "0x183704310", Slot = "6")]
	protected override IEnumerator<TElement> EKCAMIJIIEA(TCollection JIBNFGIMNPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x31B5F10", Offset = "0x31B5310", VA = "0x1831B5F10")]
	protected HPJECNAGKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class KHLHJFBFBLF<TElement, TCollection> : HPJECNAGKOI<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected sealed override TCollection LAAAOIHLIFJ(TCollection PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class JKBLKGBLLCM<TElement, TCollection> : KHLHJFBFBLF<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x39E3D10", Offset = "0x39E3110", VA = "0x1839E3D10", Slot = "7")]
	protected override TCollection NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x39E3C50", Offset = "0x39E3050", VA = "0x1839E3C50", Slot = "8")]
	protected override void FLOHBAGDPJC(TCollection AIEAHONEFEF, int OJANCMLFDOJ, TElement FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class IJPLDKAOKJI<T> : EPKHJPOCFBC<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x37986F0", Offset = "0x3797AF0", VA = "0x1837986F0", Slot = "8")]
	protected override void FLOHBAGDPJC(LinkedList<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override LinkedList<T> LAAAOIHLIFJ(LinkedList<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override LinkedList<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x37B5190", Offset = "0x37B4590", VA = "0x1837B5190", Slot = "6")]
	protected override LinkedList<T>.Enumerator EKCAMIJIIEA(LinkedList<T> JIBNFGIMNPP)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class NAIEKMIHEBB<T> : EPKHJPOCFBC<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x37986F0", Offset = "0x3797AF0", VA = "0x1837986F0", Slot = "8")]
	protected override void FLOHBAGDPJC(Queue<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override Queue<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE340", Offset = "0x3DDD740", VA = "0x183DDE340", Slot = "6")]
	protected override Queue<T>.Enumerator EKCAMIJIIEA(Queue<T> JIBNFGIMNPP)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override Queue<T> LAAAOIHLIFJ(Queue<T> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class APNBABBOFJM<T> : EPKHJPOCFBC<T, LKKGEBOBJOF<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x356E7A0", Offset = "0x356DBA0", VA = "0x18356E7A0", Slot = "8")]
	protected override void FLOHBAGDPJC(LKKGEBOBJOF<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x356E7F0", Offset = "0x356DBF0", VA = "0x18356E7F0", Slot = "7")]
	protected override LKKGEBOBJOF<T> NDFPICIGPEG()
	{
		return default(LKKGEBOBJOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3725D60", Offset = "0x3725160", VA = "0x183725D60", Slot = "6")]
	protected override Stack<T>.Enumerator EKCAMIJIIEA(Stack<T> JIBNFGIMNPP)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3725DC0", Offset = "0x37251C0", VA = "0x183725DC0", Slot = "9")]
	protected override Stack<T> LAAAOIHLIFJ(LKKGEBOBJOF<T> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class CEEPEBGPJGM<T> : EPKHJPOCFBC<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x37986F0", Offset = "0x3797AF0", VA = "0x1837986F0", Slot = "8")]
	protected override void FLOHBAGDPJC(HashSet<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override HashSet<T> LAAAOIHLIFJ(HashSet<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override HashSet<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE340", Offset = "0x3DDD740", VA = "0x183DDE340", Slot = "6")]
	protected override HashSet<T>.Enumerator EKCAMIJIIEA(HashSet<T> JIBNFGIMNPP)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class OLOLMDPCGLN<T> : HPJECNAGKOI<T, LKKGEBOBJOF<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x356E7A0", Offset = "0x356DBA0", VA = "0x18356E7A0", Slot = "8")]
	protected override void FLOHBAGDPJC(LKKGEBOBJOF<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBB40", Offset = "0x3EFAF40", VA = "0x183EFBB40", Slot = "9")]
	protected override ReadOnlyCollection<T> LAAAOIHLIFJ(LKKGEBOBJOF<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBBE0", Offset = "0x3EFAFE0", VA = "0x183EFBBE0", Slot = "7")]
	protected override LKKGEBOBJOF<T> NDFPICIGPEG()
	{
		return default(LKKGEBOBJOF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class IDKGLLPMKPK<T> : HPJECNAGKOI<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x37986F0", Offset = "0x3797AF0", VA = "0x1837986F0", Slot = "8")]
	protected override void FLOHBAGDPJC(List<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override List<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override IList<T> LAAAOIHLIFJ(List<T> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class DBPKAECEIJF<T> : HPJECNAGKOI<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x37986F0", Offset = "0x3797AF0", VA = "0x1837986F0", Slot = "8")]
	protected override void FLOHBAGDPJC(List<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override List<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override ICollection<T> LAAAOIHLIFJ(List<T> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class FAAONLHGDEL<T> : HPJECNAGKOI<T, LKKGEBOBJOF<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x356E7A0", Offset = "0x356DBA0", VA = "0x18356E7A0", Slot = "8")]
	protected override void FLOHBAGDPJC(LKKGEBOBJOF<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x356E7F0", Offset = "0x356DBF0", VA = "0x18356E7F0", Slot = "7")]
	protected override LKKGEBOBJOF<T> NDFPICIGPEG()
	{
		return default(LKKGEBOBJOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x356E7D0", Offset = "0x356DBD0", VA = "0x18356E7D0", Slot = "9")]
	protected override IEnumerable<T> LAAAOIHLIFJ(LKKGEBOBJOF<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x31C3AD0", Offset = "0x31C2ED0", VA = "0x1831C3AD0")]
	public FAAONLHGDEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class PMGNMNDGKBK<TKey, TElement> : CDPHELCNEFG<IGrouping<TKey, TElement>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3FCFF60", Offset = "0x3FCF360", VA = "0x183FCFF60", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, IGrouping<TKey, TElement> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3FCFC60", Offset = "0x3FCF060", VA = "0x183FCFC60", Slot = "5")]
	public IGrouping<TKey, TElement> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class IEGLMFMNNDH<TKey, TElement> : CDPHELCNEFG<ILookup<TKey, TElement>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3798DD0", Offset = "0x37981D0", VA = "0x183798DD0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ILookup<TKey, TElement> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3798A80", Offset = "0x3797E80", VA = "0x183798A80", Slot = "5")]
	public ILookup<TKey, TElement> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class CBNJENKHDCM<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey KCGLPAPOILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> CIBMCDHAIGI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey JFBDDAMOHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7A6130", Offset = "0x7A5530", VA = "0x1807A6130")]
	public CBNJENKHDCM(TKey KCGLPAPOILB, IEnumerable<TElement> CIBMCDHAIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x478CFF0", Offset = "0x478C3F0", VA = "0x18478CFF0", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x31DEC80", Offset = "0x31DE080", VA = "0x1831DEC80", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class GPOLKAMKPDK<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> JLNCALNMKNJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x31F3A70", Offset = "0x31F2E70", VA = "0x1831F3A70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public GPOLKAMKPDK(Dictionary<TKey, IGrouping<TKey, TElement>> JLNCALNMKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x36A1860", Offset = "0x36A0C60", VA = "0x1836A1860", Slot = "5")]
	public bool Contains(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x36A18A0", Offset = "0x36A0CA0", VA = "0x1836A18A0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x36A18A0", Offset = "0x36A0CA0", VA = "0x1836A18A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BEPFAEACPEG<T> : CDPHELCNEFG<T>, MEAKMJHAEGJ where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x45EBD70", Offset = "0x45EB170", VA = "0x1845EBD70", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x45EBAF0", Offset = "0x45EAEF0", VA = "0x1845EBAF0", Slot = "5")]
	public T AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public BEPFAEACPEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class FLLKIJECHLF : CDPHELCNEFG<IEnumerable>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly CDPHELCNEFG<IEnumerable> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x66B7950", Offset = "0x66B6D50", VA = "0x1866B7950", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, IEnumerable FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x66B7700", Offset = "0x66B6B00", VA = "0x1866B7700", Slot = "5")]
	public IEnumerable AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public FLLKIJECHLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class JCIBNFCHGBB : CDPHELCNEFG<ICollection>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly CDPHELCNEFG<ICollection> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x66BBC70", Offset = "0x66BB070", VA = "0x1866BBC70", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ICollection FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x66BBA20", Offset = "0x66BAE20", VA = "0x1866BBA20", Slot = "5")]
	public ICollection AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public JCIBNFCHGBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class EFOENACHEMN : CDPHELCNEFG<IList>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly CDPHELCNEFG<IList> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x66B5060", Offset = "0x66B4460", VA = "0x1866B5060", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, IList FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x66B4E10", Offset = "0x66B4210", VA = "0x1866B4E10", Slot = "5")]
	public IList AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public EFOENACHEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class GILANDFBNBB<T> : HPJECNAGKOI<T, LKKGEBOBJOF<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3694760", Offset = "0x3693B60", VA = "0x183694760", Slot = "8")]
	protected override void FLOHBAGDPJC(LKKGEBOBJOF<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x356E7F0", Offset = "0x356DBF0", VA = "0x18356E7F0", Slot = "7")]
	protected override LKKGEBOBJOF<T> NDFPICIGPEG()
	{
		return default(LKKGEBOBJOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x36947C0", Offset = "0x3693BC0", VA = "0x1836947C0", Slot = "9")]
	protected override IReadOnlyList<T> LAAAOIHLIFJ(LKKGEBOBJOF<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x31C3470", Offset = "0x31C2870", VA = "0x1831C3470")]
	public GILANDFBNBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class FPPEJCIDMND
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x66B82E0", Offset = "0x66B76E0", VA = "0x1866B82E0")]
	public static DateTime GACDIKCHDJA(DateTime KCAHIJBKBAF)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class FCCLINJKFEH : CDPHELCNEFG<DateTime>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly CDPHELCNEFG<DateTime> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x66B6B90", Offset = "0x66B5F90", VA = "0x1866B6B90", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, DateTime FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x66B5E80", Offset = "0x66B5280", VA = "0x1866B5E80", Slot = "5")]
	public DateTime AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public FCCLINJKFEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class EFDBHCHJECA : CDPHELCNEFG<DateTimeOffset>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly CDPHELCNEFG<DateTimeOffset> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x66B46F0", Offset = "0x66B3AF0", VA = "0x1866B46F0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, DateTimeOffset FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x66B3AD0", Offset = "0x66B2ED0", VA = "0x1866B3AD0", Slot = "5")]
	public DateTimeOffset AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public EFDBHCHJECA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class LJGIKKKFKHC : CDPHELCNEFG<TimeSpan>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly CDPHELCNEFG<TimeSpan> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] AHCGEIEGAML;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x66BDC50", Offset = "0x66BD050", VA = "0x1866BDC50", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, TimeSpan FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x66BD340", Offset = "0x66BC740", VA = "0x1866BD340", Slot = "5")]
	public TimeSpan AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public LJGIKKKFKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class COCCALEBAHB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : CDPHELCNEFG<TDictionary>, MEAKMJHAEGJ where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x4967770", Offset = "0x4966B70", VA = "0x184967770", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, TDictionary FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4965C60", Offset = "0x4965060", VA = "0x184965C60", Slot = "5")]
	public TDictionary AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EKCAMIJIIEA(TDictionary JIBNFGIMNPP);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate NDFPICIGPEG();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void FLOHBAGDPJC(TIntermediate AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary LAAAOIHLIFJ(TIntermediate PGLKCKDGDOA);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected COCCALEBAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class BJNBPHHAALM<TKey, TValue, TIntermediate, TDictionary> : COCCALEBAHB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3704310", Offset = "0x3703710", VA = "0x183704310", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> EKCAMIJIIEA(TDictionary JIBNFGIMNPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class KNMBCJKKLCJ<TKey, TValue, TDictionary> : BJNBPHHAALM<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override TDictionary LAAAOIHLIFJ(TDictionary PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class NPFAKCIDLEN<TKey, TValue> : COCCALEBAHB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3E142E0", Offset = "0x3E136E0", VA = "0x183E142E0", Slot = "8")]
	protected override void FLOHBAGDPJC(Dictionary<TKey, TValue> AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override Dictionary<TKey, TValue> LAAAOIHLIFJ(Dictionary<TKey, TValue> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override Dictionary<TKey, TValue> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3E14230", Offset = "0x3E13630", VA = "0x183E14230", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator EKCAMIJIIEA(Dictionary<TKey, TValue> JIBNFGIMNPP)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x31B5200", Offset = "0x31B4600", VA = "0x1831B5200")]
	public NPFAKCIDLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NKOIDLGHAJL<TKey, TValue, TDictionary> : KNMBCJKKLCJ<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x3E09DF0", Offset = "0x3E091F0", VA = "0x183E09DF0", Slot = "8")]
	protected override void FLOHBAGDPJC(TDictionary AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x300AF60", Offset = "0x300A360", VA = "0x18300AF60", Slot = "7")]
	protected override TDictionary NDFPICIGPEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class GMEAGMLPNBG<TKey, TValue> : BJNBPHHAALM<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3578510", Offset = "0x3577910", VA = "0x183578510", Slot = "8")]
	protected override void FLOHBAGDPJC(Dictionary<TKey, TValue> AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override Dictionary<TKey, TValue> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override IDictionary<TKey, TValue> LAAAOIHLIFJ(Dictionary<TKey, TValue> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class FEEJEAIHKDJ<TKey, TValue> : KNMBCJKKLCJ<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x3578510", Offset = "0x3577910", VA = "0x183578510", Slot = "8")]
	protected override void FLOHBAGDPJC(SortedList<TKey, TValue> AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override SortedList<TKey, TValue> NDFPICIGPEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class KLPLKIPLDIB<TKey, TValue> : COCCALEBAHB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3578510", Offset = "0x3577910", VA = "0x183578510", Slot = "8")]
	protected override void FLOHBAGDPJC(SortedDictionary<TKey, TValue> AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x838700", Offset = "0x837B00", VA = "0x180838700", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> LAAAOIHLIFJ(SortedDictionary<TKey, TValue> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3578550", Offset = "0x3577950", VA = "0x183578550", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3A98E30", Offset = "0x3A98230", VA = "0x183A98E30", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator EKCAMIJIIEA(SortedDictionary<TKey, TValue> JIBNFGIMNPP)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class KFELAPMGMAG<T> : CDPHELCNEFG<T>, MEAKMJHAEGJ where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3A673B0", Offset = "0x3A667B0", VA = "0x183A673B0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3A67110", Offset = "0x3A66510", VA = "0x183A67110", Slot = "5")]
	public T AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public KFELAPMGMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class DCBPGFIKCKE : CDPHELCNEFG<IDictionary>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly CDPHELCNEFG<IDictionary> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x66B1490", Offset = "0x66B0890", VA = "0x1866B1490", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, IDictionary FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x66B1260", Offset = "0x66B0660", VA = "0x1866B1260", Slot = "5")]
	public IDictionary AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public DCBPGFIKCKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class ICIBLDDOFLG : CDPHELCNEFG<object>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void MAGFFHHEOPA(object CGLHFHGJPDC, PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly HLJBEPCNCAC<KeyValuePair<object, MAGFFHHEOPA>> CILLNINJFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly KJLLBNBALAI[] PFFEBPIOLEE;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x66BB1B0", Offset = "0x66BA5B0", VA = "0x1866BB1B0")]
	public ICIBLDDOFLG(params KJLLBNBALAI[] PFFEBPIOLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x66BA7F0", Offset = "0x66B9BF0", VA = "0x1866BA7F0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x66BA760", Offset = "0x66B9B60", VA = "0x1866BA760", Slot = "5")]
	public object AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class HICGNACGPDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x66B9870", Offset = "0x66B8C70", VA = "0x1866B9870")]
	public static object IHBHFKMEGBK(Type ADAMDPHPFAA, [Out] bool KBGPGGGHJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x66B8F80", Offset = "0x66B8380", VA = "0x1866B8F80")]
	public static object FHGCDCMIPNC(Type ADAMDPHPFAA, [Out] bool KBGPGGGHJKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class LBOANHBGPGC<T> : CDPHELCNEFG<T>, MEAKMJHAEGJ, FBBKFIDAJLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class ONLAECKCLAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ONLAECKCLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3F00AC0", Offset = "0x3EFFEC0", VA = "0x183F00AC0")]
		internal bool LEMKBINCDDN(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class MGLKJHADMAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MGLKJHADMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D54150", Offset = "0x3D53550", VA = "0x183D54150")]
		internal bool EGHLHGAKJHL(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class DFBMKNGGHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public KOLENMMFBHH<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public DFBMKNGGHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4E8AF50", Offset = "0x4E8A350", VA = "0x184E8AF50")]
		internal void LLIGPAFNNCH(PFDOBNDPOBK writer, T value, KJLLBNBALAI _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class LPJMHHMPMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public PLCEGAKFIMF<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LPJMHHMPMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B771F0", Offset = "0x3B765F0", VA = "0x183B771F0")]
		internal T EOAOJDOECLL(JPFLOFNLOOJ reader, KJLLBNBALAI _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly KBLKLIHGHAH<T> LLPIDICHCDC;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> MODHHLODBHE;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly KOLENMMFBHH<T> IKDBBMGGPPC;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly PLCEGAKFIMF<T> FEOHLCHLKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool NPHBLFDPGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly KOLENMMFBHH<T> POBOHLKHIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly PLCEGAKFIMF<T> EEFJGPLEEDP;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BAD0", Offset = "0x3B1AED0", VA = "0x183B1BAD0")]
	static LBOANHBGPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CD20", Offset = "0x3B1C120", VA = "0x183B1CD20")]
	public LBOANHBGPGC(bool NPHBLFDPGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3B19010", Offset = "0x3B18410", VA = "0x183B19010", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3B17EF0", Offset = "0x3B172F0", VA = "0x183B17EF0", Slot = "5")]
	public T AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3B19530", Offset = "0x3B18930", VA = "0x183B19530", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3B18CF0", Offset = "0x3B180F0", VA = "0x183B18CF0", Slot = "7")]
	public T IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class KCMHOEMOONB<T> : CDPHELCNEFG<T[,]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A58070", Offset = "0x3A57470", VA = "0x183A58070", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T[,] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A57D40", Offset = "0x3A57140", VA = "0x183A57D40", Slot = "5")]
	public T[,] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public KCMHOEMOONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class MIDLLLNPFBA<T> : CDPHELCNEFG<T[,,]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D669E0", Offset = "0x3D65DE0", VA = "0x183D669E0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T[,,] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D665A0", Offset = "0x3D659A0", VA = "0x183D665A0", Slot = "5")]
	public T[,,] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public MIDLLLNPFBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class KODLHIHONCJ<T> : CDPHELCNEFG<T[,,,]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DCE0", Offset = "0x3A9D0E0", VA = "0x183A9DCE0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T[,,,] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D790", Offset = "0x3A9CB90", VA = "0x183A9D790", Slot = "5")]
	public T[,,,] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public KODLHIHONCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class ADDFLINDKGJ<T> : CDPHELCNEFG<T?>, MEAKMJHAEGJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3630C40", Offset = "0x3630040", VA = "0x183630C40", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3630710", Offset = "0x362FB10", VA = "0x183630710", Slot = "5")]
	public T? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public ADDFLINDKGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class LIACMPIPECF<T> : CDPHELCNEFG<T?>, MEAKMJHAEGJ where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly CDPHELCNEFG<T> KFAMGKEFBHP;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public LIACMPIPECF(CDPHELCNEFG<T> KFAMGKEFBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B150", Offset = "0x3B5A550", VA = "0x183B5B150", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AFA0", Offset = "0x3B5A3A0", VA = "0x183B5AFA0", Slot = "5")]
	public T? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class CCGDHIKOFAF : CDPHELCNEFG<sbyte>, MEAKMJHAEGJ, FBBKFIDAJLA<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly CCGDHIKOFAF KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x66B0F10", Offset = "0x66B0310", VA = "0x1866B0F10", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, sbyte FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x66B0E00", Offset = "0x66B0200", VA = "0x1866B0E00", Slot = "5")]
	public sbyte AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x66B0F70", Offset = "0x66B0370", VA = "0x1866B0F70", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, sbyte FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x66B0E50", Offset = "0x66B0250", VA = "0x1866B0E50", Slot = "7")]
	public sbyte IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public CCGDHIKOFAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class GPHBGMKANBG : CDPHELCNEFG<sbyte?>, MEAKMJHAEGJ, FBBKFIDAJLA<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly GPHBGMKANBG KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x66B8D80", Offset = "0x66B8180", VA = "0x1866B8D80", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, sbyte? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x66B8BB0", Offset = "0x66B7FB0", VA = "0x1866B8BB0", Slot = "5")]
	public sbyte? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x66B8E40", Offset = "0x66B8240", VA = "0x1866B8E40", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, sbyte? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x66B8C60", Offset = "0x66B8060", VA = "0x1866B8C60", Slot = "7")]
	public sbyte? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public GPHBGMKANBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class OBAPALMLHJJ : CDPHELCNEFG<sbyte[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly OBAPALMLHJJ KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x66BFEB0", Offset = "0x66BF2B0", VA = "0x1866BFEB0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, sbyte[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x66BFD20", Offset = "0x66BF120", VA = "0x1866BFD20", Slot = "5")]
	public sbyte[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public OBAPALMLHJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class OPJJFOCOAMN : CDPHELCNEFG<short>, MEAKMJHAEGJ, FBBKFIDAJLA<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly OPJJFOCOAMN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x66C0CC0", Offset = "0x66C00C0", VA = "0x1866C0CC0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, short FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x66C0BB0", Offset = "0x66BFFB0", VA = "0x1866C0BB0", Slot = "5")]
	public short AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x66C0D20", Offset = "0x66C0120", VA = "0x1866C0D20", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, short FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x66C0C00", Offset = "0x66C0000", VA = "0x1866C0C00", Slot = "7")]
	public short IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public OPJJFOCOAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class LEMKELPMBON : CDPHELCNEFG<short?>, MEAKMJHAEGJ, FBBKFIDAJLA<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly LEMKELPMBON KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x66BD140", Offset = "0x66BC540", VA = "0x1866BD140", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, short? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x66BCF70", Offset = "0x66BC370", VA = "0x1866BCF70", Slot = "5")]
	public short? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x66BD200", Offset = "0x66BC600", VA = "0x1866BD200", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, short? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x66BD020", Offset = "0x66BC420", VA = "0x1866BD020", Slot = "7")]
	public short? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public LEMKELPMBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class BBEJFGHPJOP : CDPHELCNEFG<short[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly BBEJFGHPJOP KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x66B0A40", Offset = "0x66AFE40", VA = "0x1866B0A40", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, short[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x66B08B0", Offset = "0x66AFCB0", VA = "0x1866B08B0", Slot = "5")]
	public short[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public BBEJFGHPJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class LEHDMDFALJH : CDPHELCNEFG<int>, MEAKMJHAEGJ, FBBKFIDAJLA<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly LEHDMDFALJH KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x66BCBC0", Offset = "0x66BBFC0", VA = "0x1866BCBC0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, int FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x66BCAB0", Offset = "0x66BBEB0", VA = "0x1866BCAB0", Slot = "5")]
	public int AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x66BCC20", Offset = "0x66BC020", VA = "0x1866BCC20", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, int FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x66BCB00", Offset = "0x66BBF00", VA = "0x1866BCB00", Slot = "7")]
	public int IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public LEHDMDFALJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class EHAHIGKLDEE : CDPHELCNEFG<int?>, MEAKMJHAEGJ, FBBKFIDAJLA<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly EHAHIGKLDEE KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x66B55E0", Offset = "0x66B49E0", VA = "0x1866B55E0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, int? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x66B5410", Offset = "0x66B4810", VA = "0x1866B5410", Slot = "5")]
	public int? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x66B56A0", Offset = "0x66B4AA0", VA = "0x1866B56A0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, int? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x66B54C0", Offset = "0x66B48C0", VA = "0x1866B54C0", Slot = "7")]
	public int? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public EHAHIGKLDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class JMMGDGKCIID : CDPHELCNEFG<int[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly JMMGDGKCIID KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x66BC6A0", Offset = "0x66BBAA0", VA = "0x1866BC6A0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, int[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x66BC510", Offset = "0x66BB910", VA = "0x1866BC510", Slot = "5")]
	public int[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public JMMGDGKCIID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GJAIAOHJIDO : CDPHELCNEFG<long>, MEAKMJHAEGJ, FBBKFIDAJLA<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly GJAIAOHJIDO KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x66B88B0", Offset = "0x66B7CB0", VA = "0x1866B88B0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, long FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x66B87A0", Offset = "0x66B7BA0", VA = "0x1866B87A0", Slot = "5")]
	public long AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x66B8910", Offset = "0x66B7D10", VA = "0x1866B8910", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, long FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x66B87F0", Offset = "0x66B7BF0", VA = "0x1866B87F0", Slot = "7")]
	public long IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public GJAIAOHJIDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class GFAEDGAOCFN : CDPHELCNEFG<long?>, MEAKMJHAEGJ, FBBKFIDAJLA<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly GFAEDGAOCFN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x66B85A0", Offset = "0x66B79A0", VA = "0x1866B85A0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, long? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x66B83A0", Offset = "0x66B77A0", VA = "0x1866B83A0", Slot = "5")]
	public long? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x66B8660", Offset = "0x66B7A60", VA = "0x1866B8660", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, long? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x66B8460", Offset = "0x66B7860", VA = "0x1866B8460", Slot = "7")]
	public long? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public GFAEDGAOCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class FLELLHIMLKL : CDPHELCNEFG<long[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly FLELLHIMLKL KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x66B7550", Offset = "0x66B6950", VA = "0x1866B7550", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, long[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x66B73C0", Offset = "0x66B67C0", VA = "0x1866B73C0", Slot = "5")]
	public long[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public FLELLHIMLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class DLAOKKGBLBO : CDPHELCNEFG<byte>, MEAKMJHAEGJ, FBBKFIDAJLA<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly DLAOKKGBLBO KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x66B20C0", Offset = "0x66B14C0", VA = "0x1866B20C0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, byte FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x66B1FB0", Offset = "0x66B13B0", VA = "0x1866B1FB0", Slot = "5")]
	public byte AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x66B2120", Offset = "0x66B1520", VA = "0x1866B2120", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, byte FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x66B2000", Offset = "0x66B1400", VA = "0x1866B2000", Slot = "7")]
	public byte IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public DLAOKKGBLBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class PKJOFJJLLKI : CDPHELCNEFG<byte?>, MEAKMJHAEGJ, FBBKFIDAJLA<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly PKJOFJJLLKI KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x66C16F0", Offset = "0x66C0AF0", VA = "0x1866C16F0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, byte? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x66C1520", Offset = "0x66C0920", VA = "0x1866C1520", Slot = "5")]
	public byte? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x66C17B0", Offset = "0x66C0BB0", VA = "0x1866C17B0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, byte? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x66C15D0", Offset = "0x66C09D0", VA = "0x1866C15D0", Slot = "7")]
	public byte? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public PKJOFJJLLKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class JLMDAKLOGIJ : CDPHELCNEFG<ushort>, MEAKMJHAEGJ, FBBKFIDAJLA<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly JLMDAKLOGIJ KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x66BC3C0", Offset = "0x66BB7C0", VA = "0x1866BC3C0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ushort FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x66BC2B0", Offset = "0x66BB6B0", VA = "0x1866BC2B0", Slot = "5")]
	public ushort AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x66BC420", Offset = "0x66BB820", VA = "0x1866BC420", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, ushort FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x66BC300", Offset = "0x66BB700", VA = "0x1866BC300", Slot = "7")]
	public ushort IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public JLMDAKLOGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class MIIFOEPOOPN : CDPHELCNEFG<ushort?>, MEAKMJHAEGJ, FBBKFIDAJLA<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly MIIFOEPOOPN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x66BE7F0", Offset = "0x66BDBF0", VA = "0x1866BE7F0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ushort? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x66BE620", Offset = "0x66BDA20", VA = "0x1866BE620", Slot = "5")]
	public ushort? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x66BE8B0", Offset = "0x66BDCB0", VA = "0x1866BE8B0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, ushort? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x66BE6D0", Offset = "0x66BDAD0", VA = "0x1866BE6D0", Slot = "7")]
	public ushort? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public MIIFOEPOOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class HOJDEODBNMA : CDPHELCNEFG<ushort[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly HOJDEODBNMA KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x66BA5B0", Offset = "0x66B99B0", VA = "0x1866BA5B0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ushort[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x66BA420", Offset = "0x66B9820", VA = "0x1866BA420", Slot = "5")]
	public ushort[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public HOJDEODBNMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JBCMKBDJPPN : CDPHELCNEFG<uint>, MEAKMJHAEGJ, FBBKFIDAJLA<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly JBCMKBDJPPN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x66BB8D0", Offset = "0x66BACD0", VA = "0x1866BB8D0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, uint FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x66BB7C0", Offset = "0x66BABC0", VA = "0x1866BB7C0", Slot = "5")]
	public uint AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x66BB930", Offset = "0x66BAD30", VA = "0x1866BB930", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, uint FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x66BB810", Offset = "0x66BAC10", VA = "0x1866BB810", Slot = "7")]
	public uint IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public JBCMKBDJPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class OGDJODHFHEK : CDPHELCNEFG<uint?>, MEAKMJHAEGJ, FBBKFIDAJLA<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly OGDJODHFHEK KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x66C0630", Offset = "0x66BFA30", VA = "0x1866C0630", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, uint? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x66C0460", Offset = "0x66BF860", VA = "0x1866C0460", Slot = "5")]
	public uint? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x66C06F0", Offset = "0x66BFAF0", VA = "0x1866C06F0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, uint? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x66C0510", Offset = "0x66BF910", VA = "0x1866C0510", Slot = "7")]
	public uint? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public OGDJODHFHEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class PDCHIHBDFPF : CDPHELCNEFG<uint[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly PDCHIHBDFPF KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x66C0FA0", Offset = "0x66C03A0", VA = "0x1866C0FA0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, uint[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x66C0E10", Offset = "0x66C0210", VA = "0x1866C0E10", Slot = "5")]
	public uint[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public PDCHIHBDFPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class FOCNELKOCHN : CDPHELCNEFG<ulong>, MEAKMJHAEGJ, FBBKFIDAJLA<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly FOCNELKOCHN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x66B7D90", Offset = "0x66B7190", VA = "0x1866B7D90", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ulong FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x66B7C80", Offset = "0x66B7080", VA = "0x1866B7C80", Slot = "5")]
	public ulong AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x66B7DF0", Offset = "0x66B71F0", VA = "0x1866B7DF0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, ulong FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x66B7CD0", Offset = "0x66B70D0", VA = "0x1866B7CD0", Slot = "7")]
	public ulong IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public FOCNELKOCHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class OFKIKMCFGLL : CDPHELCNEFG<ulong?>, MEAKMJHAEGJ, FBBKFIDAJLA<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly OFKIKMCFGLL KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x66C0260", Offset = "0x66BF660", VA = "0x1866C0260", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ulong? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x66C0060", Offset = "0x66BF460", VA = "0x1866C0060", Slot = "5")]
	public ulong? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x66C0320", Offset = "0x66BF720", VA = "0x1866C0320", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, ulong? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x66C0120", Offset = "0x66BF520", VA = "0x1866C0120", Slot = "7")]
	public ulong? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public OFKIKMCFGLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class LPDOPAFLFDM : CDPHELCNEFG<ulong[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly LPDOPAFLFDM KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x66BE320", Offset = "0x66BD720", VA = "0x1866BE320", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ulong[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x66BE190", Offset = "0x66BD590", VA = "0x1866BE190", Slot = "5")]
	public ulong[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public LPDOPAFLFDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class NKJKIPGLFEH : CDPHELCNEFG<float>, MEAKMJHAEGJ, FBBKFIDAJLA<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly NKJKIPGLFEH KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x66BF4F0", Offset = "0x66BE8F0", VA = "0x1866BF4F0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, float FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x66BF3E0", Offset = "0x66BE7E0", VA = "0x1866BF3E0", Slot = "5")]
	public float AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x66BF550", Offset = "0x66BE950", VA = "0x1866BF550", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, float FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x66BF430", Offset = "0x66BE830", VA = "0x1866BF430", Slot = "7")]
	public float IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public NKJKIPGLFEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class PFCIPPMMCDN : CDPHELCNEFG<float?>, MEAKMJHAEGJ, FBBKFIDAJLA<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly PFCIPPMMCDN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x66C1320", Offset = "0x66C0720", VA = "0x1866C1320", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, float? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x66C1150", Offset = "0x66C0550", VA = "0x1866C1150", Slot = "5")]
	public float? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x66C13E0", Offset = "0x66C07E0", VA = "0x1866C13E0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, float? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x66C1200", Offset = "0x66C0600", VA = "0x1866C1200", Slot = "7")]
	public float? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public PFCIPPMMCDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class EONFIMGHFMN : CDPHELCNEFG<float[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly EONFIMGHFMN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x66B5CC0", Offset = "0x66B50C0", VA = "0x1866B5CC0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, float[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x66B5B30", Offset = "0x66B4F30", VA = "0x1866B5B30", Slot = "5")]
	public float[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public EONFIMGHFMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class LEJHGEOHMBI : CDPHELCNEFG<double>, MEAKMJHAEGJ, FBBKFIDAJLA<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly LEJHGEOHMBI KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x66BCE20", Offset = "0x66BC220", VA = "0x1866BCE20", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, double FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x66BCD10", Offset = "0x66BC110", VA = "0x1866BCD10", Slot = "5")]
	public double AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x66BCE80", Offset = "0x66BC280", VA = "0x1866BCE80", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, double FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x66BCD60", Offset = "0x66BC160", VA = "0x1866BCD60", Slot = "7")]
	public double IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public LEJHGEOHMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class FOJLJGKJNDN : CDPHELCNEFG<double?>, MEAKMJHAEGJ, FBBKFIDAJLA<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly FOJLJGKJNDN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x66B80E0", Offset = "0x66B74E0", VA = "0x1866B80E0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, double? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x66B7EE0", Offset = "0x66B72E0", VA = "0x1866B7EE0", Slot = "5")]
	public double? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x66B81A0", Offset = "0x66B75A0", VA = "0x1866B81A0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, double? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x66B7FA0", Offset = "0x66B73A0", VA = "0x1866B7FA0", Slot = "7")]
	public double? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public FOJLJGKJNDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class PNGMIIBNFOB : CDPHELCNEFG<double[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly PNGMIIBNFOB KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x66C1A80", Offset = "0x66C0E80", VA = "0x1866C1A80", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, double[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x66C18F0", Offset = "0x66C0CF0", VA = "0x1866C18F0", Slot = "5")]
	public double[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public PNGMIIBNFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class KJCHGOGGOFI : CDPHELCNEFG<bool>, MEAKMJHAEGJ, FBBKFIDAJLA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly KJCHGOGGOFI KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x66BC960", Offset = "0x66BBD60", VA = "0x1866BC960", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, bool FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x66BC850", Offset = "0x66BBC50", VA = "0x1866BC850", Slot = "5")]
	public bool AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x66BC9C0", Offset = "0x66BBDC0", VA = "0x1866BC9C0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, bool FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x66BC8A0", Offset = "0x66BBCA0", VA = "0x1866BC8A0", Slot = "7")]
	public bool IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public KJCHGOGGOFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class DLJLDCCPHBB : CDPHELCNEFG<bool?>, MEAKMJHAEGJ, FBBKFIDAJLA<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly DLJLDCCPHBB KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x66B23E0", Offset = "0x66B17E0", VA = "0x1866B23E0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, bool? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x66B2210", Offset = "0x66B1610", VA = "0x1866B2210", Slot = "5")]
	public bool? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x66B24A0", Offset = "0x66B18A0", VA = "0x1866B24A0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, bool? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x66B22C0", Offset = "0x66B16C0", VA = "0x1866B22C0", Slot = "7")]
	public bool? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public DLJLDCCPHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class EMPOJOEOEMN : CDPHELCNEFG<bool[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EMPOJOEOEMN KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x66B5970", Offset = "0x66B4D70", VA = "0x1866B5970", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, bool[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x66B57E0", Offset = "0x66B4BE0", VA = "0x1866B57E0", Slot = "5")]
	public bool[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public EMPOJOEOEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class ECDFHEBDEJK : CDPHELCNEFG<object>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly CDPHELCNEFG<object> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> CDIPOLKAGGE;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x66B2A20", Offset = "0x66B1E20", VA = "0x1866B2A20", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x66B25E0", Offset = "0x66B19E0", VA = "0x1866B25E0", Slot = "5")]
	public object AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public ECDFHEBDEJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class INIEPBFOMEK : CDPHELCNEFG<byte[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly CDPHELCNEFG<byte[]> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x66BB310", Offset = "0x66BA710", VA = "0x1866BB310", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, byte[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x66BB260", Offset = "0x66BA660", VA = "0x1866BB260", Slot = "5")]
	public byte[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public INIEPBFOMEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class HMAIAIEOJMI : CDPHELCNEFG<ArraySegment<byte>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly CDPHELCNEFG<ArraySegment<byte>> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x66BA270", Offset = "0x66B9670", VA = "0x1866BA270", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ArraySegment<byte> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x66BA160", Offset = "0x66B9560", VA = "0x1866BA160", Slot = "5")]
	public ArraySegment<byte> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public HMAIAIEOJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class MLFICLGDDJE : CDPHELCNEFG<string>, MEAKMJHAEGJ, FBBKFIDAJLA<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly CDPHELCNEFG<string> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x66BEA90", Offset = "0x66BDE90", VA = "0x1866BEA90", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, string FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x66BE9F0", Offset = "0x66BDDF0", VA = "0x1866BE9F0", Slot = "5")]
	public string AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x66BEAF0", Offset = "0x66BDEF0", VA = "0x1866BEAF0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, string FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x66BEA40", Offset = "0x66BDE40", VA = "0x1866BEA40", Slot = "7")]
	public string IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public MLFICLGDDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class OILHCJGHDEG : CDPHELCNEFG<string[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly OILHCJGHDEG KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x66C0A00", Offset = "0x66BFE00", VA = "0x1866C0A00", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, string[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x66C0830", Offset = "0x66BFC30", VA = "0x1866C0830", Slot = "5")]
	public string[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public OILHCJGHDEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class GNOGIIPMJDG : CDPHELCNEFG<char>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly GNOGIIPMJDG KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x66B8A70", Offset = "0x66B7E70", VA = "0x1866B8A70", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, char FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x66B8A00", Offset = "0x66B7E00", VA = "0x1866B8A00", Slot = "5")]
	public char AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public GNOGIIPMJDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class DHLMCPPCHGL : CDPHELCNEFG<char?>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly DHLMCPPCHGL KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x66B1B10", Offset = "0x66B0F10", VA = "0x1866B1B10", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, char? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x66B19F0", Offset = "0x66B0DF0", VA = "0x1866B19F0", Slot = "5")]
	public char? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public DHLMCPPCHGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class NBCHNBFEAEP : CDPHELCNEFG<char[]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly NBCHNBFEAEP KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x66BF1B0", Offset = "0x66BE5B0", VA = "0x1866BF1B0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, char[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x66BEFF0", Offset = "0x66BE3F0", VA = "0x1866BEFF0", Slot = "5")]
	public char[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public NBCHNBFEAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class NADKMHJMPEJ : CDPHELCNEFG<Guid>, MEAKMJHAEGJ, FBBKFIDAJLA<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly CDPHELCNEFG<Guid> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x66BED00", Offset = "0x66BE100", VA = "0x1866BED00", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, Guid FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x66BEBD0", Offset = "0x66BDFD0", VA = "0x1866BEBD0", Slot = "5")]
	public Guid AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x66BEE30", Offset = "0x66BE230", VA = "0x1866BEE30", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, Guid FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x66BEC60", Offset = "0x66BE060", VA = "0x1866BEC60", Slot = "7")]
	public Guid IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public NADKMHJMPEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class NPOFMHNHAOI : CDPHELCNEFG<decimal>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly CDPHELCNEFG<decimal> KBJBMEBJHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool GLOGCLOIIGO;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x50E3420", Offset = "0x50E2820", VA = "0x1850E3420")]
	public NPOFMHNHAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1722890", Offset = "0x1721C90", VA = "0x181722890")]
	public NPOFMHNHAOI(bool GLOGCLOIIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x66BFAF0", Offset = "0x66BEEF0", VA = "0x1866BFAF0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, decimal FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x66BF850", Offset = "0x66BEC50", VA = "0x1866BF850", Slot = "5")]
	public decimal AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class JFEJDFDPCMM : CDPHELCNEFG<Uri>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly CDPHELCNEFG<Uri> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x66BC150", Offset = "0x66BB550", VA = "0x1866BC150", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, Uri FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x66BC090", Offset = "0x66BB490", VA = "0x1866BC090", Slot = "5")]
	public Uri AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public JFEJDFDPCMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class CNIAAFMLAPA : CDPHELCNEFG<Version>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly CDPHELCNEFG<Version> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x66B1120", Offset = "0x66B0520", VA = "0x1866B1120", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, Version FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x66B1060", Offset = "0x66B0460", VA = "0x1866B1060", Slot = "5")]
	public Version AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public CNIAAFMLAPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class PAPKPBHCHBB<TKey, TValue> : CDPHELCNEFG<KeyValuePair<TKey, TValue>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3F86390", Offset = "0x3F85790", VA = "0x183F86390", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, KeyValuePair<TKey, TValue> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3F86060", Offset = "0x3F85460", VA = "0x183F86060", Slot = "5")]
	public KeyValuePair<TKey, TValue> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class AJANDHECOHG : CDPHELCNEFG<StringBuilder>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly CDPHELCNEFG<StringBuilder> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x66B0790", Offset = "0x66AFB90", VA = "0x1866B0790", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, StringBuilder FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x66B06D0", Offset = "0x66AFAD0", VA = "0x1866B06D0", Slot = "5")]
	public StringBuilder AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public AJANDHECOHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class DJNEKHJLIMK : CDPHELCNEFG<BitArray>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly CDPHELCNEFG<BitArray> KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x66B1E10", Offset = "0x66B1210", VA = "0x1866B1E10", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, BitArray FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x66B1C90", Offset = "0x66B1090", VA = "0x1866B1C90", Slot = "5")]
	public BitArray AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public DJNEKHJLIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class JAELKBOMHBG : CDPHELCNEFG<Type>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly JAELKBOMHBG KBJBMEBJHNF;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex PCIFPICKIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool DJJIBOLLFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool NFALGMBPPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool NCDPCJFMLPK;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x66BB7A0", Offset = "0x66BABA0", VA = "0x1866BB7A0")]
	public JAELKBOMHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E55F50", Offset = "0x5E55350", VA = "0x185E55F50")]
	public JAELKBOMHBG(bool DJJIBOLLFPF, bool NFALGMBPPAI, bool NCDPCJFMLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x66BB5A0", Offset = "0x66BA9A0", VA = "0x1866BB5A0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, Type FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x66BB450", Offset = "0x66BA850", VA = "0x1866BB450", Slot = "5")]
	public Type AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class CADMOKMBONE
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] GBCMOGMBFNG;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly GDPGJDBNPKH EMFAPNNLLIF;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x66B0BF0", Offset = "0x66AFFF0", VA = "0x1866B0BF0")]
	static CADMOKMBONE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class NNCHMAIPNAA
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] MIBOJNHPDBD;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly GDPGJDBNPKH PJPCGJFGHAJ;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x66BF640", Offset = "0x66BEA40", VA = "0x1866BF640")]
	static NNCHMAIPNAA()
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
