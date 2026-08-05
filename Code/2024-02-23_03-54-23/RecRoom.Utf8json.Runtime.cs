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
	[Cpp2IlInjected.Address(RVA = "0x6873B50", Offset = "0x6872550", VA = "0x186873B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PFAHLDNBNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
	[Cpp2IlInjected.Address(RVA = "0x27487C0", Offset = "0x27471C0", VA = "0x1827487C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x27F89B0", Offset = "0x27F73B0", VA = "0x1827F89B0")]
	public static CDPHELCNEFG<T> JNFHBFIGGIG<T>(this KJLLBNBALAI FFNBKICNGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x687DB60", Offset = "0x687C560", VA = "0x18687DB60")]
	public static object FKLAFALJABN(this KJLLBNBALAI FFNBKICNGDK, Type ADAMDPHPFAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GDIDOKEBNPE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x686D380", Offset = "0x686BD80", VA = "0x18686D380")]
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
		[Cpp2IlInjected.Address(RVA = "0x686C3C0", Offset = "0x686ADC0", VA = "0x18686C3C0")]
		public static byte[] NDDOLLGIIHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x686C320", Offset = "0x686AD20", VA = "0x18686C320")]
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
		[Cpp2IlInjected.Address(RVA = "0x6878100", Offset = "0x6876B00", VA = "0x186878100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6878540", Offset = "0x6876F40", VA = "0x186878540")]
	public JPFLOFNLOOJ(byte[] PEBEDGMMHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68783E0", Offset = "0x6876DE0", VA = "0x1868783E0")]
	public JPFLOFNLOOJ(byte[] PEBEDGMMHMC, int ABOMIAEBHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6875A00", Offset = "0x6874400", VA = "0x186875A00")]
	private DIKMCHAPHKK DMHENLCMHJI(string CFHBMAENKKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6877330", Offset = "0x6875D30", VA = "0x186877330")]
	private DIKMCHAPHKK LJKABJOGEAD(string DCKDMGKGDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6876E10", Offset = "0x6875810", VA = "0x186876E10")]
	public void JBFAGMGKFLK(int ABOMIAEBHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590")]
	public byte[] MAJAMMLJGGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D60D30", Offset = "0x1D5F730", VA = "0x181D60D30")]
	public int ECGFBEEGJLA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68756F0", Offset = "0x68740F0", VA = "0x1868756F0")]
	public EMNKPJADAAL CMCJPAMPHAO()
	{
		return default(EMNKPJADAAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6877F00", Offset = "0x6876900", VA = "0x186877F00")]
	public void OFBBCJCAHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68768F0", Offset = "0x68752F0", VA = "0x1868768F0")]
	public bool IMMMAMEHKHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6876350", Offset = "0x6874D50", VA = "0x186876350")]
	public bool FDCPEPILFPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6875FC0", Offset = "0x68749C0", VA = "0x186875FC0")]
	public void EKCHJBNJEPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68781A0", Offset = "0x6876BA0", VA = "0x1868781A0")]
	public bool PEJHHLLFHLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6875590", Offset = "0x6873F90", VA = "0x186875590")]
	public bool BDPNOGCJHOP(int DPBEIPGOMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6875100", Offset = "0x6873B00", VA = "0x186875100")]
	public bool AAEDLDCDGOK(int DPBEIPGOMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6878230", Offset = "0x6876C30", VA = "0x186878230")]
	public bool PLJCDJLKFGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6877E60", Offset = "0x6876860", VA = "0x186877E60")]
	public void OCHEMEGJDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6875660", Offset = "0x6874060", VA = "0x186875660")]
	public bool CHLOJHKKEPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6877420", Offset = "0x6875E20", VA = "0x186877420")]
	public bool MAIAHGEOGAO(int DPBEIPGOMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6878030", Offset = "0x6876A30", VA = "0x186878030")]
	public bool OFGCGCDAHAI(int DPBEIPGOMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6875420", Offset = "0x6873E20", VA = "0x186875420")]
	public bool AHCCBAPCOAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68775A0", Offset = "0x6875FA0", VA = "0x1868775A0")]
	public void NFDGKAIPCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6877070", Offset = "0x6875A70", VA = "0x186877070")]
	public bool JPCNGCOKCOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6876560", Offset = "0x6874F60", VA = "0x186876560")]
	public void GCCELJAECMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68776C0", Offset = "0x68760C0", VA = "0x1868776C0")]
	private void NPHLICINIOJ([Out] byte[] KPFAEKNJJHI, [Out] int IELFHCNPLGB, [Out] int JHDJAOIIAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68774F0", Offset = "0x6875EF0", VA = "0x1868774F0")]
	private static int MBGHFHKPHPA(char MAGGDEMNFDG, char LFCFPOEDJCH, char AICLPFMLBHB, char KGLKPBOCCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68754B0", Offset = "0x6873EB0", VA = "0x1868754B0")]
	private static int AHMMOMIBICG(char LGHEBJJLAGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6876AD0", Offset = "0x68754D0", VA = "0x186876AD0")]
	public ArraySegment<byte> IOPHIHFHGJF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6876810", Offset = "0x6875210", VA = "0x186876810")]
	public string IIKGPNIAPNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6877100", Offset = "0x6875B00", VA = "0x186877100")]
	public string KHAAPBLOAAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6876BF0", Offset = "0x68755F0", VA = "0x186876BF0")]
	public ArraySegment<byte> JBBIMHIJCLE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6875F50", Offset = "0x6874950", VA = "0x186875F50")]
	public ArraySegment<byte> EJNEMLFGAMO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6876E20", Offset = "0x6875820", VA = "0x186876E20")]
	public bool JNAJJDCAPAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6877270", Offset = "0x6875C70", VA = "0x186877270")]
	private static bool LHONKEIFCDG(byte AICLPFMLBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68751D0", Offset = "0x6873BD0", VA = "0x1868751D0")]
	private void AAMJDLBPGKG(EMNKPJADAAL FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6876680", Offset = "0x6875080", VA = "0x186876680")]
	public void HOJJJOMFCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68758A0", Offset = "0x68742A0", VA = "0x1868758A0")]
	private void DKBACBMLMHL(int GGPLPGJHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6876600", Offset = "0x6875000", VA = "0x186876600")]
	public sbyte HLOHHFOCDIJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6877640", Offset = "0x6876040", VA = "0x186877640")]
	public short NMNJAOGOFIL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6878120", Offset = "0x6876B20", VA = "0x186878120")]
	public int PAAHDGLBAKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6876750", Offset = "0x6875150", VA = "0x186876750")]
	public long IEFLDLECFGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68764E0", Offset = "0x6874EE0", VA = "0x1868764E0")]
	public byte FLEKMHOPIBG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6876060", Offset = "0x6874A60", VA = "0x186876060")]
	public ushort ENGJIEKBBJI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68766D0", Offset = "0x68750D0", VA = "0x1868766D0")]
	public uint IBALDLMKDKN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6876A10", Offset = "0x6875410", VA = "0x186876A10")]
	public ulong IOLIFNLEKDJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68763E0", Offset = "0x6874DE0", VA = "0x1868763E0")]
	public float FDKOKPIEBBM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6876250", Offset = "0x6874C50", VA = "0x186876250")]
	public double FBLLIJBEAAL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6877170", Offset = "0x6875B70", VA = "0x186877170")]
	public ArraySegment<byte> KJDAECONEDI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68760E0", Offset = "0x6874AE0", VA = "0x1868760E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBACFF0", Offset = "0xBAB9F0", VA = "0x180BACFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string MAMCNFLAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x867FC0", Offset = "0x8669C0", VA = "0x180867FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x686C1C0", Offset = "0x686ABC0", VA = "0x18686C1C0")]
	public DIKMCHAPHKK(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x686C0D0", Offset = "0x686AAD0", VA = "0x18686C0D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6871680", Offset = "0x6870080", VA = "0x186871680")]
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
				[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
				public DEIKPHAOLAC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3D9A2F0", Offset = "0x3D98CF0", VA = "0x183D9A2F0")]
				internal bool FNAPAENEBHH(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x686BF10", Offset = "0x686A910", VA = "0x18686BF10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6871970", Offset = "0x6870370", VA = "0x186871970")]
			public IOPFADIJGBJ(Type ADAMDPHPFAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2C1D2B0", Offset = "0x2C1BCB0", VA = "0x182C1D2B0")]
			private static T ENPDFFEPLDC<T>(DynamicMethod AHAFOJCPKJD)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6871720", Offset = "0x6870120", VA = "0x186871720")]
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
		[Cpp2IlInjected.Address(RVA = "0x6878A30", Offset = "0x6877430", VA = "0x186878A30")]
		static KLDPIKMCPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6878720", Offset = "0x6877120", VA = "0x186878720")]
		private static IOPFADIJGBJ CHLPPFFEBAE(Type ADAMDPHPFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x68788B0", Offset = "0x68772B0", VA = "0x1868788B0")]
		public static void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68787A0", Offset = "0x68771A0", VA = "0x1868787A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6874E70", Offset = "0x6873870", VA = "0x186874E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6874000", Offset = "0x6872A00", VA = "0x186874000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6874490", Offset = "0x6872E90", VA = "0x186874490")]
	public static void KHJFLONNDKO(KJLLBNBALAI FFNBKICNGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x270A250", Offset = "0x2708C50", VA = "0x18270A250")]
	public static byte[] LENOCDGJGPN<T>(T MBCPMMHPENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x270A0E0", Offset = "0x2708AE0", VA = "0x18270A0E0")]
	public static byte[] LENOCDGJGPN<T>(T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x270A350", Offset = "0x2708D50", VA = "0x18270A350")]
	public static void LENOCDGJGPN<T>(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x270A730", Offset = "0x2709130", VA = "0x18270A730")]
	public static void LENOCDGJGPN<T>(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x270A3E0", Offset = "0x2708DE0", VA = "0x18270A3E0")]
	public static void LENOCDGJGPN<T>(Stream FOBHMMKPKFP, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x270A470", Offset = "0x2708E70", VA = "0x18270A470")]
	public static void LENOCDGJGPN<T>(Stream FOBHMMKPKFP, T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x270A810", Offset = "0x2709210", VA = "0x18270A810")]
	public static ArraySegment<byte> NNNJIMNHHFM<T>(T MBCPMMHPENP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x270A8A0", Offset = "0x27092A0", VA = "0x18270A8A0")]
	public static ArraySegment<byte> NNNJIMNHHFM<T>(T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x270ABB0", Offset = "0x27095B0", VA = "0x18270ABB0")]
	public static string PLCNPGAOHJH<T>(T FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x270AA30", Offset = "0x2709430", VA = "0x18270AA30")]
	public static string PLCNPGAOHJH<T>(T FDFHGIHHGHO, KJLLBNBALAI FFNBKICNGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27098F0", Offset = "0x27082F0", VA = "0x1827098F0")]
	public static T AFFCBAMFOKP<T>(string NFCAPOLGADB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27095E0", Offset = "0x2707FE0", VA = "0x1827095E0")]
	public static T AFFCBAMFOKP<T>(string NFCAPOLGADB, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2709C30", Offset = "0x2708630", VA = "0x182709C30")]
	public static T AFFCBAMFOKP<T>(byte[] PEBEDGMMHMC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2709860", Offset = "0x2708260", VA = "0x182709860")]
	public static T AFFCBAMFOKP<T>(byte[] PEBEDGMMHMC, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2709980", Offset = "0x2708380", VA = "0x182709980")]
	public static T AFFCBAMFOKP<T>(byte[] PEBEDGMMHMC, int ABOMIAEBHEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27096D0", Offset = "0x27080D0", VA = "0x1827096D0")]
	public static T AFFCBAMFOKP<T>(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2709BB0", Offset = "0x27085B0", VA = "0x182709BB0")]
	public static T AFFCBAMFOKP<T>(JPFLOFNLOOJ AGGHEBELANL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2709AE0", Offset = "0x27084E0", VA = "0x182709AE0")]
	public static T AFFCBAMFOKP<T>(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2709EA0", Offset = "0x27088A0", VA = "0x182709EA0")]
	public static T AFFCBAMFOKP<T>(Stream FOBHMMKPKFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2709F20", Offset = "0x2708920", VA = "0x182709F20")]
	public static T AFFCBAMFOKP<T>(Stream FOBHMMKPKFP, KJLLBNBALAI FFNBKICNGDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68741F0", Offset = "0x6872BF0", VA = "0x1868741F0")]
	public static string DGLJMPPBHOA(byte[] NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6874350", Offset = "0x6872D50", VA = "0x186874350")]
	public static string DGLJMPPBHOA(byte[] NFCAPOLGADB, int ABOMIAEBHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6874060", Offset = "0x6872A60", VA = "0x186874060")]
	public static string DGLJMPPBHOA(string NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6873D30", Offset = "0x6872730", VA = "0x186873D30")]
	public static byte[] BIBJHIDCBCF(byte[] NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6873EB0", Offset = "0x68728B0", VA = "0x186873EB0")]
	public static byte[] BIBJHIDCBCF(byte[] NFCAPOLGADB, int ABOMIAEBHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6873B80", Offset = "0x6872580", VA = "0x186873B80")]
	public static byte[] BIBJHIDCBCF(string NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x68745A0", Offset = "0x6872FA0", VA = "0x1868745A0")]
	private static void LNMDMKMGCPI(JPFLOFNLOOJ AGGHEBELANL, PFDOBNDPOBK NADLGELBCMH, int JCOHLBKCNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6874500", Offset = "0x6872F00", VA = "0x186874500")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D60D30", Offset = "0x1D5F730", VA = "0x181D60D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6876E10", Offset = "0x6875810", VA = "0x186876E10")]
	public void JBFAGMGKFLK(int ABOMIAEBHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x687D140", Offset = "0x687BB40", VA = "0x18687D140")]
	public static byte[] LFKDOKANION(string OJJLJELNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x687CFD0", Offset = "0x687B9D0", VA = "0x18687CFD0")]
	public static byte[] KLILBPACELA(string OJJLJELNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x687D270", Offset = "0x687BC70", VA = "0x18687D270")]
	public static byte[] LGPKKAFJCMG(string OJJLJELNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x687CD90", Offset = "0x687B790", VA = "0x18687CD90")]
	public static byte[] HAGEHHMEDBE(string OJJLJELNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x54B4F90", Offset = "0x54B3990", VA = "0x1854B4F90")]
	public PFDOBNDPOBK(byte[] PEPNDBCHNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x687D4A0", Offset = "0x687BEA0", VA = "0x18687D4A0")]
	public ArraySegment<byte> NDDOLLGIIHL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x687D740", Offset = "0x687C140", VA = "0x18687D740")]
	public byte[] PCOECDOMOJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x687D920", Offset = "0x687C320", VA = "0x18687D920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x687D7B0", Offset = "0x687C1B0", VA = "0x18687D7B0")]
	public void PGCGCAKFKBJ(int KEHHGEKLKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x687D5A0", Offset = "0x687BFA0", VA = "0x18687D5A0")]
	public void NDOIFCPEPEJ(byte JLHOKMNALPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x687D540", Offset = "0x687BF40", VA = "0x18687D540")]
	public void NDOIFCPEPEJ(byte[] JLHOKMNALPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x687C990", Offset = "0x687B390", VA = "0x18687C990")]
	public void GFACGLCPMLK(byte JLHOKMNALPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x687CF10", Offset = "0x687B910", VA = "0x18687CF10")]
	public void IKLMHFHGFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x687C940", Offset = "0x687B340", VA = "0x18687C940")]
	public void FCCELOJNALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x687C8C0", Offset = "0x687B2C0", VA = "0x18687C8C0")]
	public void EJMNLODDDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x687D450", Offset = "0x687BE50", VA = "0x18687D450")]
	public void MGBKOACEKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x687D6F0", Offset = "0x687C0F0", VA = "0x18687D6F0")]
	public void PBHNKPCKFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x687D600", Offset = "0x687C000", VA = "0x18687D600")]
	public void NHJJBIKFLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x687D650", Offset = "0x687C050", VA = "0x18687D650")]
	public void OFIBFKKEKEP(string OJJLJELNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x687C6A0", Offset = "0x687B0A0", VA = "0x18687C6A0")]
	public void BMHCFEECECL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x687C510", Offset = "0x687AF10", VA = "0x18687C510")]
	public void AMHLGPACAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x687D7C0", Offset = "0x687C1C0", VA = "0x18687D7C0")]
	public void PLGPLGMLBFN(bool FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x687C5B0", Offset = "0x687AFB0", VA = "0x18687C5B0")]
	public void BBAMBEMGKGL(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x687C760", Offset = "0x687B160", VA = "0x18687C760")]
	public void DFOPAOFJCKG(double FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x687C7E0", Offset = "0x687B1E0", VA = "0x18687C7E0")]
	public void EAPAINMDPGF(byte FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x687C630", Offset = "0x687B030", VA = "0x18687C630")]
	public void BMAEALOMHHF(ushort FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x687C6F0", Offset = "0x687B0F0", VA = "0x18687C6F0")]
	public void CJLPJFDJNCB(uint FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x687C910", Offset = "0x687B310", VA = "0x18687C910")]
	public void EPKJNHDCGEB(ulong FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x687D3E0", Offset = "0x687BDE0", VA = "0x18687D3E0")]
	public void MELDGLDNGMN(sbyte FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x687CF60", Offset = "0x687B960", VA = "0x18687CF60")]
	public void JIPEDDHGMIF(short FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x687C850", Offset = "0x687B250", VA = "0x18687C850")]
	public void EFCAFANJAII(int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x687CD60", Offset = "0x687B760", VA = "0x18687CD60")]
	public void GJMHIMCDPCB(long FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x687C9D0", Offset = "0x687B3D0", VA = "0x18687C9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x36910D0", Offset = "0x368FAD0", VA = "0x1836910D0")]
		static AKKBPLDMHPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private LDFDBILEHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x35BDAD0", Offset = "0x35BC4D0", VA = "0x1835BDAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68796B0", Offset = "0x68780B0", VA = "0x1868796B0")]
		internal static object EKKGBGDOAEI(Type FENMDPNPDJP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private KKMNDJGFJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A8B450", Offset = "0x3A89E50", VA = "0x183A8B450")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private ANBIHFKAAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x686B5F0", Offset = "0x6869FF0", VA = "0x18686B5F0")]
	public static void LIBHGHNAKIM(params KJLLBNBALAI[] CNCHKGGJHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x686B6D0", Offset = "0x686A0D0", VA = "0x18686B6D0")]
	public static void LIBHGHNAKIM(params MEAKMJHAEGJ[] DOPEIOFEAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x686B360", Offset = "0x6869D60", VA = "0x18686B360")]
	public static void GPGGCGBPPFM(MEAKMJHAEGJ[] DOPEIOFEAOG, KJLLBNBALAI[] CNCHKGGJHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3815600", Offset = "0x3814000", VA = "0x183815600")]
		static IOMPEDLDEFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private MJENGFMGAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x686F500", Offset = "0x686DF00", VA = "0x18686F500")]
	internal static object EKKGBGDOAEI(Type FENMDPNPDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6870C60", Offset = "0x686F660", VA = "0x186870C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x37F3B30", Offset = "0x37F2530", VA = "0x1837F3B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6878ED0", Offset = "0x68778D0", VA = "0x186878ED0")]
	static LNIIKGMFFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private LNIIKGMFFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4616EE0", Offset = "0x46158E0", VA = "0x184616EE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6879250", Offset = "0x6877C50", VA = "0x186879250")]
	static NBEELDHJLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private NBEELDHJLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x38090A0", Offset = "0x3807AA0", VA = "0x1838090A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x686B110", Offset = "0x6869B10", VA = "0x18686B110")]
	static AJOGDDDPHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private AJOGDDDPHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FBFE90", Offset = "0x3FBE890", VA = "0x183FBFE90")]
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
	[Cpp2IlInjected.Address(RVA = "0x686D680", Offset = "0x686C080", VA = "0x18686D680")]
	static HHPIHFPGMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private HHPIHFPGMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3714B10", Offset = "0x3713510", VA = "0x183714B10")]
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
	[Cpp2IlInjected.Address(RVA = "0x687D9F0", Offset = "0x687C3F0", VA = "0x18687D9F0")]
	static PIHANDDMOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private PIHANDDMOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E3EE30", Offset = "0x3E3D830", VA = "0x183E3EE30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6879540", Offset = "0x6877F40", VA = "0x186879540")]
	static OPBIOIBLGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private OPBIOIBLGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x36B9AB0", Offset = "0x36B84B0", VA = "0x1836B9AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x370EED0", Offset = "0x370D8D0", VA = "0x18370EED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x3725CE0", Offset = "0x37246E0", VA = "0x183725CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A31A90", Offset = "0x4A30490", VA = "0x184A31A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x322C7E0", Offset = "0x322B1E0", VA = "0x18322C7E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B44AC0", Offset = "0x3B434C0", VA = "0x183B44AC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
	public CDPHELCNEFG<T> EKKGBGDOAEI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
			[Cpp2IlInjected.Address(RVA = "0x687B4E0", Offset = "0x6879EE0", VA = "0x18687B4E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x686C740", Offset = "0x686B140", VA = "0x18686C740")]
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
		[Cpp2IlInjected.Address(RVA = "0x686DC80", Offset = "0x686C680", VA = "0x18686DC80")]
		public static MethodInfo LENOCDGJGPN(Type ADAMDPHPFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x686D910", Offset = "0x686C310", VA = "0x18686D910")]
		public static MethodInfo AFFCBAMFOKP(Type ADAMDPHPFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x686DB50", Offset = "0x686C550", VA = "0x18686DB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public ALCLCDBFDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x686B320", Offset = "0x6869D20", VA = "0x18686B320")]
		internal void PLAJEOFEJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x686B280", Offset = "0x6869C80", VA = "0x18686B280")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public GFIPBPCLKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x686D3E0", Offset = "0x686BDE0", VA = "0x18686D3E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public FOFHNOJFBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3E49A50", Offset = "0x3E48450", VA = "0x183E49A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public ADBDLAPLMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x686AFB0", Offset = "0x68699B0", VA = "0x18686AFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public LPMFKNDADBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6879040", Offset = "0x6877A40", VA = "0x186879040")]
		internal void GCMPNFNMFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6879050", Offset = "0x6877A50", VA = "0x186879050")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public BGBPHAEBAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x686B8D0", Offset = "0x686A2D0", VA = "0x18686B8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public CGFKPBLECPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x686BA50", Offset = "0x686A450", VA = "0x18686BA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public HLOOPDAMAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x686D7F0", Offset = "0x686C1F0", VA = "0x18686D7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public JGDIEFIHJNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6873470", Offset = "0x6871E70", VA = "0x186873470")]
		internal void BLGEPKLAGIJ(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6873700", Offset = "0x6872100", VA = "0x186873700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public GCBMMCDKCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB39F30", Offset = "0xB38930", VA = "0x180B39F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public GCBDGNEDNMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB39F30", Offset = "0xB38930", VA = "0x180B39F30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2805DC0", Offset = "0x28047C0", VA = "0x182805DC0")]
	public static object BMGMFHFHDBM<T>(MLBNKLMMCKI PIGKLLPOJDM, KJLLBNBALAI MLBHGFKIPHI, Func<string, string> OKMMDHBMNBM, bool BOLNPNKMDPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x280F990", Offset = "0x280E390", VA = "0x18280F990")]
	public static object EBCIOJOEAGG<T>(KJLLBNBALAI MLBHGFKIPHI, Func<string, string> OKMMDHBMNBM, bool BOLNPNKMDPC, bool LFJILANPPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6885080", Offset = "0x6883A80", VA = "0x186885080")]
	private static TypeInfo PHMAAHOFOLO(MLBNKLMMCKI PIGKLLPOJDM, Type ADAMDPHPFAA, Func<string, string> OKMMDHBMNBM, bool BOLNPNKMDPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6880F80", Offset = "0x687F980", VA = "0x186880F80")]
	public static object GNGPHFBNBDE(Type ADAMDPHPFAA, Func<string, string> OKMMDHBMNBM, bool BOLNPNKMDPC, bool LFJILANPPPA, bool CBDAPJIJPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x68840F0", Offset = "0x6882AF0", VA = "0x1868840F0")]
	private static Dictionary<OLEMMHLFKLG, FieldInfo> LHNAMBONEPH(TypeBuilder NEKBLNGPEGC, NOOPFPAOOED CBJFHHJLIDF, ConstructorInfo BGNMKGIOBCO, FieldBuilder MKGIOHHPCLO, ILGenerator PMPDDDDPEFP, bool BOLNPNKMDPC, bool PIEDPKFMMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x68849A0", Offset = "0x68833A0", VA = "0x1868849A0")]
	private static Dictionary<OLEMMHLFKLG, FieldInfo> PFFFMGCONAN(TypeBuilder NEKBLNGPEGC, NOOPFPAOOED CBJFHHJLIDF, ILGenerator PMPDDDDPEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6882AB0", Offset = "0x68814B0", VA = "0x186882AB0")]
	private static void HHCPCILEAMC(Type ADAMDPHPFAA, NOOPFPAOOED CBJFHHJLIDF, ILGenerator PMPDDDDPEFP, Action MIGBMNLEOID, Func<int, OLEMMHLFKLG, bool> NAECCKOGGBO, bool BOLNPNKMDPC, bool PIEDPKFMMFN, int DIHGAAOGPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x687E810", Offset = "0x687D210", VA = "0x18687E810")]
	private static void EBODGJBFBNF(TypeInfo ADAMDPHPFAA, OLEMMHLFKLG JFANFPLPAEB, ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ, Func<int, OLEMMHLFKLG, bool> NAECCKOGGBO, MCNDOMPCHHF NADLGELBCMH, MCNDOMPCHHF IKIIEEKPDAF, MCNDOMPCHHF DNKONHCEJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x687ED50", Offset = "0x687D750", VA = "0x18687ED50")]
	private static void EPKKDDOEOPJ(Type ADAMDPHPFAA, NOOPFPAOOED CBJFHHJLIDF, ILGenerator PMPDDDDPEFP, Func<int, OLEMMHLFKLG, bool> NAECCKOGGBO, bool OEHJNCMEPNJ, int DIHGAAOGPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x687DCC0", Offset = "0x687C6C0", VA = "0x18687DCC0")]
	private static void AEMFOBKMBLN(ILGenerator PMPDDDDPEFP, LIMDACBBCFA CBJFHHJLIDF, int OJANCMLFDOJ, Func<int, OLEMMHLFKLG, bool> NAECCKOGGBO, MCNDOMPCHHF AGGHEBELANL, MCNDOMPCHHF DNKONHCEJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x68801F0", Offset = "0x687EBF0", VA = "0x1868801F0")]
	private static LocalBuilder FPBELEBHCHK(ILGenerator PMPDDDDPEFP, Type ADAMDPHPFAA, NOOPFPAOOED CBJFHHJLIDF, LIMDACBBCFA[] KLEHLBDECID, bool KCAKFJDLODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x687E130", Offset = "0x687CB30", VA = "0x18687E130")]
	private static bool BJDNIEHIJKE(ConstructorInfo DPPDKFBLAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6884820", Offset = "0x6883220", VA = "0x186884820")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D52480", Offset = "0x1D50E80", VA = "0x181D52480")]
	public PGNENPDMDDD(byte[][] MKGIOHHPCLO, object[] JDFMGCJMFNM, object[] LFEJJKJOLGJ, MEGPPACCEGE<T> IHLGPFFHGJC, DABHCPNODEK<T> CNFEDBEGGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD4D0", Offset = "0x3FDBED0", VA = "0x183FDD4D0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD3E0", Offset = "0x3FDBDE0", VA = "0x183FDD3E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x37355A0", Offset = "0x3733FA0", VA = "0x1837355A0")]
		static HNFHBALMHKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private FHOAPGMGJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x321AFB0", Offset = "0x32199B0", VA = "0x18321AFB0")]
		static EHJDLGCHIAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly KJLLBNBALAI MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private FOJLPPMNPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D82400", Offset = "0x3D80E00", VA = "0x183D82400")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E2B3A0", Offset = "0x3E29DA0", VA = "0x183E2B3A0")]
			static NCHJPEFKDHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private LAMJJLCHBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private ODIPBBFPIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x485E670", Offset = "0x485D070", VA = "0x18485E670")]
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
			[Cpp2IlInjected.Address(RVA = "0x463DB50", Offset = "0x463C550", VA = "0x18463DB50")]
			static BHPJCCLLOCG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private CJHOGGAOEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private EOBJMBNPEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3719100", Offset = "0x3717B00", VA = "0x183719100")]
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
			[Cpp2IlInjected.Address(RVA = "0x466ED50", Offset = "0x466D750", VA = "0x18466ED50")]
			static BOLFEMGPOJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private HIAFEJBECEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private ICDMDDIPPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F2A3B0", Offset = "0x4F28DB0", VA = "0x184F2A3B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37CC900", Offset = "0x37CB300", VA = "0x1837CC900")]
			static ICGPEADNFKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private OCHIPMDHPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private KNDMAGCFCOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x380FC70", Offset = "0x380E670", VA = "0x18380FC70")]
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
			[Cpp2IlInjected.Address(RVA = "0x37FF0D0", Offset = "0x37FDAD0", VA = "0x1837FF0D0")]
			static ILLMBODFAFM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private HLEPKEINHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private DLMEGIEFFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x36088A0", Offset = "0x36072A0", VA = "0x1836088A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x398D9E0", Offset = "0x398C3E0", VA = "0x18398D9E0")]
			static JBBEGCHGCPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private OBLDKFOFKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private JPHDEBEDCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A3AC00", Offset = "0x3A39600", VA = "0x183A3AC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x4A1F150", Offset = "0x4A1DB50", VA = "0x184A1F150")]
			static CKMEJCLHHAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private CMEDDAJDMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private IILFLMIHDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37EBEA0", Offset = "0x37EA8A0", VA = "0x1837EBEA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x46421F0", Offset = "0x4640BF0", VA = "0x1846421F0")]
			static BIGFEDLLODO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private BGDFLOGEIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private LEFNNOCABNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x36ACDD0", Offset = "0x36AB7D0", VA = "0x1836ACDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4661BC0", Offset = "0x46605C0", VA = "0x184661BC0")]
			static BJPBLCIGEGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private DOBLNBPEBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private CHCFLIPAKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3236890", Offset = "0x3235290", VA = "0x183236890")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B89160", Offset = "0x3B87B60", VA = "0x183B89160")]
			static LHMPFGACNDO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private HMEBNBKCBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private NOAFFHAEHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FC9A30", Offset = "0x3FC8430", VA = "0x183FC9A30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B7FB60", Offset = "0x3B7E560", VA = "0x183B7FB60")]
			static LGIDHFMIEGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private JDKDGDEMKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private GGNFJOBJPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AA1650", Offset = "0x3AA0050", VA = "0x183AA1650")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BA95F0", Offset = "0x3BA7FF0", VA = "0x183BA95F0")]
			static LPLMAEBDDKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly KJLLBNBALAI MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly KJLLBNBALAI[] CNCHKGGJHCK;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private GFCIMEPMKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	private LFHBIFMHOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B9D6C0", Offset = "0x3B9C0C0", VA = "0x183B9D6C0")]
	public LKKGEBOBJOF(int BIMOGKLBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D3A0", Offset = "0x3B9BDA0", VA = "0x183B9D3A0")]
	public void FLOHBAGDPJC(T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D630", Offset = "0x3B9C030", VA = "0x183B9D630")]
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
	[Cpp2IlInjected.Address(RVA = "0x689C050", Offset = "0x689AA50", VA = "0x18689C050")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E35D60", Offset = "0x3E34760", VA = "0x183E35D60")]
	public NIHDPFILHMD(int LOAEDJFFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E35A60", Offset = "0x3E34460", VA = "0x183E35A60")]
	public T[] JPCNFGJJEGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E358E0", Offset = "0x3E342E0", VA = "0x183E358E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x93FD90", Offset = "0x93E790", VA = "0x18093FD90")]
			[DebuggerHidden]
			public IKGMNMAJDOI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6893D20", Offset = "0x6892720", VA = "0x186893D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6893E50", Offset = "0x6892850", VA = "0x186893E50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6893DA0", Offset = "0x68927A0", VA = "0x186893DA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CDHDHPDAPCB> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6893DA0", Offset = "0x68927A0", VA = "0x186893DA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public OKFJEPPAHCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x686BA50", Offset = "0x686A450", VA = "0x18686BA50")]
			internal Label NJBENGJOEKI(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x686BA50", Offset = "0x686A450", VA = "0x18686BA50")]
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
			[Cpp2IlInjected.Address(RVA = "0x51DBCA0", Offset = "0x51DA6A0", VA = "0x1851DBCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6888AC0", Offset = "0x68874C0", VA = "0x186888AC0")]
		public CDHDHPDAPCB(ulong KCGLPAPOILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6888280", Offset = "0x6886C80", VA = "0x186888280")]
		public CDHDHPDAPCB FLOHBAGDPJC(ulong KCGLPAPOILB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6888220", Offset = "0x6886C20", VA = "0x186888220")]
		public CDHDHPDAPCB FLOHBAGDPJC(ulong KCGLPAPOILB, int FDFHGIHHGHO, string IJNKALDJFHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6888510", Offset = "0x6886F10", VA = "0x186888510")]
		public CDHDHPDAPCB KDKFOPANCNO(byte[] BILHHBDBFLG, int ABOMIAEBHEB, int JLMEHOHLPHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6888480", Offset = "0x6886E80", VA = "0x186888480")]
		internal static int GOBAGKCGNHO(ulong[] NIKMHLBDDHG, int OJANCMLFDOJ, int CBKFAHCFHJN, ulong FDFHGIHHGHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x68881F0", Offset = "0x6886BF0", VA = "0x1868881F0", Slot = "4")]
		public int CompareTo(CDHDHPDAPCB AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6887490", Offset = "0x6885E90", VA = "0x186887490")]
		[IteratorStateMachine(typeof(IKGMNMAJDOI))]
		public IEnumerable<CDHDHPDAPCB> AHPECHOJMOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6888690", Offset = "0x6887090", VA = "0x186888690")]
		public void PALDFOIINEP(ILGenerator PMPDDDDPEFP, LocalBuilder BILHHBDBFLG, LocalBuilder JLMEHOHLPHF, LocalBuilder KCGLPAPOILB, Action<KeyValuePair<string, int>> CCDJEOOGJCP, Action KNGCFGNMCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6887510", Offset = "0x6885F10", VA = "0x186887510")]
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
			[Cpp2IlInjected.Address(RVA = "0xA29FA0", Offset = "0xA289A0", VA = "0x180A29FA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6893820", Offset = "0x6892220", VA = "0x186893820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1C66C20", Offset = "0x1C65620", VA = "0x181C66C20")]
		[DebuggerHidden]
		public IECECPGPBEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6893870", Offset = "0x6892270", VA = "0x186893870", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x68932C0", Offset = "0x6891CC0", VA = "0x1868932C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6893220", Offset = "0x6891C20", VA = "0x186893220")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6893270", Offset = "0x6891C70", VA = "0x186893270")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x68937D0", Offset = "0x68921D0", VA = "0x1868937D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6893720", Offset = "0x6892120", VA = "0x186893720", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6893720", Offset = "0x6892120", VA = "0x186893720", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x688EFA0", Offset = "0x688D9A0", VA = "0x18688EFA0")]
	public GDPGJDBNPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x688E960", Offset = "0x688D360", VA = "0x18688E960")]
	public void FLOHBAGDPJC(byte[] PEBEDGMMHMC, int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x688EB50", Offset = "0x688D550", VA = "0x18688EB50")]
	public bool ILHGEEFCDOO(ArraySegment<byte> KCGLPAPOILB, [Out] int FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x688EF10", Offset = "0x688D910", VA = "0x18688EF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x688EC30", Offset = "0x688D630", VA = "0x18688EC30")]
	private static void LKBIEDMFPAA(IEnumerable<CDHDHPDAPCB> AEHKNMGPPAE, StringBuilder JCBFBOIDMHE, int JCOHLBKCNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x688EAF0", Offset = "0x688D4F0", VA = "0x18688EAF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x688EAF0", Offset = "0x688D4F0", VA = "0x18688EAF0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x688EA70", Offset = "0x688D470", VA = "0x18688EA70")]
	[IteratorStateMachine(typeof(IECECPGPBEE))]
	private static IEnumerable<KeyValuePair<string, int>> FMCGHGEPNIK(IEnumerable<CDHDHPDAPCB> AEHKNMGPPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x688E930", Offset = "0x688D330", VA = "0x18688E930")]
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
	[Cpp2IlInjected.Address(RVA = "0x6895100", Offset = "0x6893B00", VA = "0x186895100")]
	public static ulong HIJNKBEKMAB(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, int JLMEHOHLPHF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class EJLBEIIDKJL
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x688C510", Offset = "0x688AF10", VA = "0x18688C510")]
	public static void PGCGCAKFKBJ(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, int KEHHGEKLKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x688C2C0", Offset = "0x688ACC0", VA = "0x18688C2C0")]
	public static void EJKKILHFNPA(byte[] NIKMHLBDDHG, int FFHOJDHOGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x688C3E0", Offset = "0x688ADE0", VA = "0x18688C3E0")]
	public static byte[] MJCEEGNKILJ(byte[] DJMHFPMABHB, int FFHOJDHOGBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class CNFBDNPAKPP
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x688B760", Offset = "0x688A160", VA = "0x18688B760")]
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
		[Cpp2IlInjected.Address(RVA = "0x321D590", Offset = "0x321BF90", VA = "0x18321D590", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xA29FA0", Offset = "0xA289A0", VA = "0x180A29FA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3638600", Offset = "0x3637000", VA = "0x183638600", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public PHMJDGIPBHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3FDDD50", Offset = "0x3FDC750", VA = "0x183FDDD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3FDE720", Offset = "0x3FDD120", VA = "0x183FDE720", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A7BA40", Offset = "0x3A7A440", VA = "0x183A7BA40")]
	public KBLKLIHGHAH(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A7BA60", Offset = "0x3A7A460", VA = "0x183A7BA60")]
	public KBLKLIHGHAH(int NOOJMJOLDPD, float JJMBHIOEEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3A75840", Offset = "0x3A74240", VA = "0x183A75840")]
	public void FLOHBAGDPJC(byte[] KCGLPAPOILB, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A7A8A0", Offset = "0x3A792A0", VA = "0x183A7A8A0")]
	private bool MJIKPNPAGHB(byte[] KCGLPAPOILB, T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A76940", Offset = "0x3A75340", VA = "0x183A76940")]
	public bool MFCFPLHBNLD(ArraySegment<byte> KCGLPAPOILB, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A76300", Offset = "0x3A74D00", VA = "0x183A76300")]
	private static ulong FNLMKGNFAMC(byte[] LGHEBJJLAGD, int ABOMIAEBHEB, int DPBEIPGOMHN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3732DD0", Offset = "0x37317D0", VA = "0x183732DD0")]
	private static int FBHGAKBHDIE(int MOFJMIDPCMA, float JJMBHIOEEBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A763E0", Offset = "0x3A74DE0", VA = "0x183A763E0", Slot = "4")]
	[IteratorStateMachine(typeof(KBLKLIHGHAH<>.PHMJDGIPBHF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x34BA080", Offset = "0x34B8A80", VA = "0x1834BA080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x689D1C0", Offset = "0x689BBC0", VA = "0x18689D1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x689D310", Offset = "0x689BD10", VA = "0x18689D310")]
	static PMFKCENCMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x689D570", Offset = "0x689BF70", VA = "0x18689D570")]
	public PMFKCENCMKJ(byte[] NLDBFHBIHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x689D210", Offset = "0x689BC10", VA = "0x18689D210")]
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
	[Cpp2IlInjected.Address(RVA = "0x688A000", Offset = "0x6888A00", VA = "0x18688A000")]
	public CNCAJBIEHGL(Guid FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x688A010", Offset = "0x6888A10", VA = "0x18688A010")]
	public CNCAJBIEHGL(ArraySegment<byte> BFEOHPDDCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x68890A0", Offset = "0x6887AA0", VA = "0x1868890A0")]
	private static byte ECOMGHJCOEG(byte[] PEBEDGMMHMC, int JDKEAIHNDBK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6889140", Offset = "0x6887B40", VA = "0x186889140")]
	private static byte NDJKCFHKMEB(byte LFCFPOEDJCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6889260", Offset = "0x6887C60", VA = "0x186889260")]
	public void POJMGPDPHDM(byte[] BGIIPDEPEFH, int ABOMIAEBHEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class GIEAADNLABA
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6890C40", Offset = "0x688F640", VA = "0x186890C40")]
	public static bool LICBOFBGCMF(byte AICLPFMLBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6890BD0", Offset = "0x688F5D0", VA = "0x186890BD0")]
	public static bool JOLMOPFOLDI(byte AICLPFMLBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6890690", Offset = "0x688F090", VA = "0x186890690")]
	public static sbyte HLOHHFOCDIJ(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6890C50", Offset = "0x688F650", VA = "0x186890C50")]
	public static short NMNJAOGOFIL(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6890D40", Offset = "0x688F740", VA = "0x186890D40")]
	public static int PAAHDGLBAKP(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x68907F0", Offset = "0x688F1F0", VA = "0x1868907F0")]
	public static long IEFLDLECFGC(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x688FC50", Offset = "0x688E650", VA = "0x18688FC50")]
	public static byte FLEKMHOPIBG(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x688F370", Offset = "0x688DD70", VA = "0x18688F370")]
	public static ushort ENGJIEKBBJI(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6890770", Offset = "0x688F170", VA = "0x186890770")]
	public static uint IBALDLMKDKN(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6890890", Offset = "0x688F290", VA = "0x186890890")]
	public static ulong IOLIFNLEKDJ(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x688FB70", Offset = "0x688E570", VA = "0x18688FB70")]
	public static float FDKOKPIEBBM(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x688FA90", Offset = "0x688E490", VA = "0x18688FA90")]
	public static double FBLLIJBEAAL(byte[] PEBEDGMMHMC, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x688F3F0", Offset = "0x688DDF0", VA = "0x18688F3F0")]
	public static int EPKJNHDCGEB(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, ulong FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x688FCD0", Offset = "0x688E6D0", VA = "0x18688FCD0")]
	public static int GJMHIMCDPCB(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, long FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x68909A0", Offset = "0x688F3A0", VA = "0x1868909A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x93FD90", Offset = "0x93E790", VA = "0x18093FD90")]
		[DebuggerHidden]
		public DBLLLFEPIDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x688BDB0", Offset = "0x688A7B0", VA = "0x18688BDB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x688B870", Offset = "0x688A270", VA = "0x18688B870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x688B7D0", Offset = "0x688A1D0", VA = "0x18688B7D0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x688B820", Offset = "0x688A220", VA = "0x18688B820")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x688BD60", Offset = "0x688A760", VA = "0x18688BD60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x688BCA0", Offset = "0x688A6A0", VA = "0x18688BCA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x688BCA0", Offset = "0x688A6A0", VA = "0x18688BCA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x93FD90", Offset = "0x93E790", VA = "0x18093FD90")]
		[DebuggerHidden]
		public NCDNCDDFCDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6898060", Offset = "0x6896A60", VA = "0x186898060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6897B20", Offset = "0x6896520", VA = "0x186897B20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6897A80", Offset = "0x6896480", VA = "0x186897A80")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6897AD0", Offset = "0x68964D0", VA = "0x186897AD0")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6898010", Offset = "0x6896A10", VA = "0x186898010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6897F50", Offset = "0x6896950", VA = "0x186897F50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6897F50", Offset = "0x6896950", VA = "0x186897F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6894A20", Offset = "0x6893420", VA = "0x186894A20")]
	public static bool HHHMIBAADHM(this TypeInfo ADAMDPHPFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6894850", Offset = "0x6893250", VA = "0x186894850")]
	public static bool APCGHDNBJFF(this TypeInfo ADAMDPHPFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6894C00", Offset = "0x6893600", VA = "0x186894C00")]
	public static IEnumerable<PropertyInfo> PDIIJIODEGK(this Type ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6894B60", Offset = "0x6893560", VA = "0x186894B60")]
	[IteratorStateMachine(typeof(DBLLLFEPIDP))]
	private static IEnumerable<PropertyInfo> OILBECDIGKD(Type ADAMDPHPFAA, HashSet<string> FJFDHBCBBHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6894AE0", Offset = "0x68934E0", VA = "0x186894AE0")]
	public static IEnumerable<FieldInfo> JKHOHOKGJAM(this Type ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6894980", Offset = "0x6893380", VA = "0x186894980")]
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
	[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270")]
	public static string DHBLKHOJEKK(string MKFPNMJBPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6894460", Offset = "0x6892E60", VA = "0x186894460")]
	public static string EKEFFKBKPIL(string MKFPNMJBPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6894540", Offset = "0x6892F40", VA = "0x186894540")]
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
		[Cpp2IlInjected.Address(RVA = "0x3727AF0", Offset = "0x37264F0", VA = "0x183727AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3727A70", Offset = "0x3726470", VA = "0x183727A70")]
		private int OICIIFDIAGM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public LJPABCGGFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3733760", Offset = "0x3732160", VA = "0x183733760")]
	public HLJBEPCNCAC(int NOOJMJOLDPD = 4, float JJMBHIOEEBA = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3732990", Offset = "0x3731390", VA = "0x183732990")]
	public bool AMOFEKFEHHG(Type KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3732BF0", Offset = "0x37315F0", VA = "0x183732BF0")]
	public bool AMOFEKFEHHG(Type KCGLPAPOILB, Func<Type, TValue> JIFPACEMJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x37330A0", Offset = "0x3731AA0", VA = "0x1837330A0")]
	private bool MJIKPNPAGHB(Type KCGLPAPOILB, Func<Type, TValue> JIFPACEMJBG, [Out] TValue AMAHGMALPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x37325A0", Offset = "0x3730FA0", VA = "0x1837325A0")]
	private bool AFFCPLOCPNK(AOKIHJIKNHE[] CPEHFBOHHKG, Type NFJHAPILCGK, AOKIHJIKNHE KJOILHCHHGK, Func<Type, TValue> JIFPACEMJBG, [Out] TValue AMAHGMALPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3732F30", Offset = "0x3731930", VA = "0x183732F30")]
	public bool MFCFPLHBNLD(Type KCGLPAPOILB, [Out] TValue FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3732D20", Offset = "0x3731720", VA = "0x183732D20")]
	public TValue CHLPPFFEBAE(Type KCGLPAPOILB, Func<Type, TValue> JIFPACEMJBG)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3732DD0", Offset = "0x37317D0", VA = "0x183732DD0")]
	private static int FBHGAKBHDIE(int MOFJMIDPCMA, float JJMBHIOEEBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3733070", Offset = "0x3731A70", VA = "0x183733070")]
	private static void MHCCMAEHPMG(AOKIHJIKNHE OIEGPBDOILH, AOKIHJIKNHE FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3733070", Offset = "0x3731A70", VA = "0x183733070")]
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
	[Cpp2IlInjected.Address(RVA = "0x6895EF0", Offset = "0x68948F0", VA = "0x186895EF0")]
	public TypeBuilder IENKKPBFBOM(string OMHHPMIDNAN, TypeAttributes JAOOLAHHCAO, Type BBCCHMIJNJG, Type[] NLDNMGHFPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6895FF0", Offset = "0x68949F0", VA = "0x186895FF0")]
	public MLBNKLMMCKI(string OMJMIIKHFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class FJPPFBLMKDK
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x688C650", Offset = "0x688B050", VA = "0x18688C650")]
	private static MethodInfo BDPPNMMHEFD(LambdaExpression BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x266A4A0", Offset = "0x2668EA0", VA = "0x18266A4A0")]
	public static MethodInfo FOJLMCLCDKF<T>(Expression<Func<T>> BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x266A4A0", Offset = "0x2668EA0", VA = "0x18266A4A0")]
	public static MethodInfo FOJLMCLCDKF<T, TR>(Expression<Func<T, TR>> BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x266A4A0", Offset = "0x2668EA0", VA = "0x18266A4A0")]
	public static MethodInfo FOJLMCLCDKF<T>(Expression<Action<T>> BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x266A4A0", Offset = "0x2668EA0", VA = "0x18266A4A0")]
	public static MethodInfo FOJLMCLCDKF<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> BNDBJEMLHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x266A3C0", Offset = "0x2668DC0", VA = "0x18266A3C0")]
	private static MemberInfo ABOJEPHEONM<T>(Expression<T> JIBNFGIMNPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x266A4B0", Offset = "0x2668EB0", VA = "0x18266A4B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6895E20", Offset = "0x6894820", VA = "0x186895E20")]
	public MCNDOMPCHHF(ILGenerator PMPDDDDPEFP, int CCNHOKJIGCD, bool LGCBFJMCLHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6895E60", Offset = "0x6894860", VA = "0x186895E60")]
	public MCNDOMPCHHF(ILGenerator PMPDDDDPEFP, int CCNHOKJIGCD, Type ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6895D20", Offset = "0x6894720", VA = "0x186895D20")]
	public void OFMBECPEBEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class PLLNHPJANOB
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x689C390", Offset = "0x689AD90", VA = "0x18689C390")]
	public static void GPIDOIONKCD(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x689C580", Offset = "0x689AF80", VA = "0x18689C580")]
	public static void GPIDOIONKCD(this ILGenerator PMPDDDDPEFP, LocalBuilder NPBAHKMGBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x689C7B0", Offset = "0x689B1B0", VA = "0x18689C7B0")]
	public static void HEFKMMIILEH(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x689C9A0", Offset = "0x689B3A0", VA = "0x18689C9A0")]
	public static void HEFKMMIILEH(this ILGenerator PMPDDDDPEFP, LocalBuilder NPBAHKMGBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x689CF00", Offset = "0x689B900", VA = "0x18689CF00")]
	public static void OCNMAKMJHFG(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x689CFE0", Offset = "0x689B9E0", VA = "0x18689CFE0")]
	public static void OCNMAKMJHFG(this ILGenerator PMPDDDDPEFP, LocalBuilder NPBAHKMGBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x689C130", Offset = "0x689AB30", VA = "0x18689C130")]
	public static void DJKOMDHOCFO(this ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x689CEF0", Offset = "0x689B8F0", VA = "0x18689CEF0")]
	public static void NKNBFNJDGKH(this ILGenerator PMPDDDDPEFP, bool FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x689C9E0", Offset = "0x689B3E0", VA = "0x18689C9E0")]
	public static void HFBGLJGMFBF(this ILGenerator PMPDDDDPEFP, int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x689C140", Offset = "0x689AB40", VA = "0x18689C140")]
	public static void EOOPONMKGMP(this ILGenerator PMPDDDDPEFP, Type ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x689CE50", Offset = "0x689B850", VA = "0x18689CE50")]
	public static void KMGPJPIMNOF(this ILGenerator PMPDDDDPEFP, Type ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x689C5C0", Offset = "0x689AFC0", VA = "0x18689C5C0")]
	public static void HDNJAGDCKNB(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x689C220", Offset = "0x689AC20", VA = "0x18689C220")]
	public static void GKMODGLLAAL(this ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x689D0E0", Offset = "0x689BAE0", VA = "0x18689D0E0")]
	public static void PHHJAPIGGHJ(this ILGenerator PMPDDDDPEFP, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x689C2A0", Offset = "0x689ACA0", VA = "0x18689C2A0")]
	public static void GPFLBGGOEBJ(this ILGenerator PMPDDDDPEFP, MethodInfo DEIILLNONCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x689CDC0", Offset = "0x689B7C0", VA = "0x18689CDC0")]
	public static void JBPPCMGMMKI(this ILGenerator PMPDDDDPEFP, FieldInfo JFAEILFALDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x689C0A0", Offset = "0x689AAA0", VA = "0x18689C0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public NDHNMKCLMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6898190", Offset = "0x6896B90", VA = "0x186898190")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string OFNHONEHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B0", Offset = "0x7A7BB0", VA = "0x1807A91B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EIMCHGLHJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x689B960", Offset = "0x689A360", VA = "0x18689B960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool JBKDEIOKHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9210", Offset = "0x7A7C10", VA = "0x1807A9210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7A91D0", Offset = "0x7A7BD0", VA = "0x1807A91D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FOAFKHHPBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8B84B0", Offset = "0x8B6EB0", VA = "0x1808B84B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B6BA0", VA = "0x1808B81A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MIOIDKGGEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7AC260", Offset = "0x7AAC60", VA = "0x1807AC260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo DKJKLLCBPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo BJEGBIHCEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7A9430", Offset = "0x7A7E30", VA = "0x1807A9430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo EGDIJLIJDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7A9150", Offset = "0x7A7B50", VA = "0x1807A9150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7A9250", Offset = "0x7A7C50", VA = "0x1807A9250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x689BF30", Offset = "0x689A930", VA = "0x18689BF30")]
	protected OLEMMHLFKLG(Type ADAMDPHPFAA, string OMHHPMIDNAN, string CCMBMNIPICA, bool IGGPAIICACB, bool DBLPNNDDOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x689BC60", Offset = "0x689A660", VA = "0x18689BC60")]
	public OLEMMHLFKLG(FieldInfo CBJFHHJLIDF, string OMHHPMIDNAN, bool LFJILANPPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x689BD70", Offset = "0x689A770", VA = "0x18689BD70")]
	public OLEMMHLFKLG(PropertyInfo CBJFHHJLIDF, string OMHHPMIDNAN, bool LFJILANPPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x689BAF0", Offset = "0x689A4F0", VA = "0x18689BAF0")]
	private static MethodInfo OIKFKGEGMJH(MemberInfo CBJFHHJLIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x27E4380", Offset = "0x27E2D80", VA = "0x1827E4380")]
	public T FFEOGMFKKNP<T>(bool OECHNCDEFJL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x689B970", Offset = "0x689A370", VA = "0x18689B970", Slot = "4")]
	public virtual void MOCDHGFAHII(ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x689B7E0", Offset = "0x689A1E0", VA = "0x18689B7E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x68871D0", Offset = "0x6885BD0", VA = "0x1868871D0")]
	public ANKHKLJINPO(string OMHHPMIDNAN, string KHLEBOFEMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6887120", Offset = "0x6885B20", VA = "0x186887120", Slot = "4")]
	public override void MOCDHGFAHII(ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x68870D0", Offset = "0x6885AD0", VA = "0x1868870D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6898A80", Offset = "0x6897480", VA = "0x186898A80")]
	public NGCGHJHLCIF(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x68984B0", Offset = "0x6896EB0", VA = "0x1868984B0", Slot = "4")]
	public override void MOCDHGFAHII(ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x68982A0", Offset = "0x6896CA0", VA = "0x1868982A0", Slot = "5")]
	public override void DJABHPEDJCJ(ILGenerator PMPDDDDPEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x68982F0", Offset = "0x6896CF0", VA = "0x1868982F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DEHINILGNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x817570", Offset = "0x815F70", VA = "0x180817570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0180", Offset = "0x7AEB80", VA = "0x1807B0180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EBOADOOGBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7530", Offset = "0x8B5F30", VA = "0x1808B7530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8B6E30", Offset = "0x8B5830", VA = "0x1808B6E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo NLMPKPLCNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public OLEMMHLFKLG[] PLMENBLCPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7AC260", Offset = "0x7AAC60", VA = "0x1807AC260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public OLEMMHLFKLG[] AEKKHACPLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6898E40", Offset = "0x6897840", VA = "0x186898E40")]
	public NOOPFPAOOED(Type ADAMDPHPFAA, Func<string, string> EAMBNIHFNPH, bool LFJILANPPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6898D60", Offset = "0x6897760", VA = "0x186898D60")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D99EA0", Offset = "0x1D988A0", VA = "0x181D99EA0")]
	public JKBEAMDAIKK(ulong IOAGEHEMMAI, int NBJHAABFIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6894330", Offset = "0x6892D30", VA = "0x186894330")]
	public void IHGHODEHAHE(JKBEAMDAIKK AAMIMDAKFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6894280", Offset = "0x6892C80", VA = "0x186894280")]
	public static JKBEAMDAIKK ABPBLACPJAC(JKBEAMDAIKK MAGGDEMNFDG, JKBEAMDAIKK LFCFPOEDJCH)
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6894340", Offset = "0x6892D40", VA = "0x186894340")]
	public void MHIBHMFPDFP(JKBEAMDAIKK AAMIMDAKFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6894290", Offset = "0x6892C90", VA = "0x186894290")]
	public static JKBEAMDAIKK DPJIHMMJNIA(JKBEAMDAIKK MAGGDEMNFDG, JKBEAMDAIKK LFCFPOEDJCH)
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x68943D0", Offset = "0x6892DD0", VA = "0x1868943D0")]
	public void NGLOJPGDJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6894410", Offset = "0x6892E10", VA = "0x186894410")]
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
	[Cpp2IlInjected.Address(RVA = "0x17B6E20", Offset = "0x17B5820", VA = "0x1817B6E20")]
	public ICNOCJPABHO(byte[] BGIIPDEPEFH, int HGKJDOIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x687D5A0", Offset = "0x687BFA0", VA = "0x18687D5A0")]
	public void KAECJMHCKFB(byte ADLBCEDEBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6892F80", Offset = "0x6891980", VA = "0x186892F80")]
	public void KIPPKEHHKAC(byte[] ADLBCEDEBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6893100", Offset = "0x6891B00", VA = "0x186893100")]
	public void NCBAPNCKBAP(byte[] ADLBCEDEBAN, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6893180", Offset = "0x6891B80", VA = "0x186893180")]
	public void NCBAPNCKBAP(byte[] ADLBCEDEBAN, int AJOMPGHNEBN, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6892F00", Offset = "0x6891900", VA = "0x186892F00")]
	public void FPIBJPFKBFO(byte AICLPFMLBHB, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6893000", Offset = "0x6891A00", VA = "0x186893000")]
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
	[Cpp2IlInjected.Address(RVA = "0x688CD50", Offset = "0x688B750", VA = "0x18688CD50")]
	private static byte[] BHLDEFAFKFC(int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x688E600", Offset = "0x688D000", VA = "0x18688E600")]
	private static byte[] OEBDFJMFOIP(int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x688E3C0", Offset = "0x688CDC0", VA = "0x18688E3C0")]
	public static int NDINFEBECJN(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, float FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x688E4E0", Offset = "0x688CEE0", VA = "0x18688E4E0")]
	public static int NDINFEBECJN(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, double FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x688DD60", Offset = "0x688C760", VA = "0x18688DD60")]
	private static bool HMIPHJLPLOL(byte[] BGIIPDEPEFH, int CBKFAHCFHJN, ulong BAJBPNDKHNP, ulong OELOHGHDGBP, ulong JLMEHOHLPHF, ulong IBFPPECIFHK, ulong MFEONNDDGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x688DE50", Offset = "0x688C850", VA = "0x18688DE50")]
	private static void HODNOHOOOBP(uint OBKHJBKAEPG, int IGBHPCADJPG, [Out] uint PCLEMPNBMGO, [Out] int PDNFAOGMKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x688D300", Offset = "0x688BD00", VA = "0x18688D300")]
	private static bool CMJJIAPDDKI(JKBEAMDAIKK MKGNEPHFNKB, JKBEAMDAIKK LKDONMJJPCN, JKBEAMDAIKK BPBMHLKMPFJ, byte[] BGIIPDEPEFH, [Out] int CBKFAHCFHJN, [Out] int DNKHHJEIGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x688DF40", Offset = "0x688C940", VA = "0x18688DF40")]
	private static bool IJDDONILKDG(double MHNPONMPDCG, IGMCHMEGMON GBFDMJLKPAC, byte[] BGIIPDEPEFH, [Out] int CBKFAHCFHJN, [Out] int LICPKIDMBOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x688DA80", Offset = "0x688C480", VA = "0x18688DA80")]
	private static bool EJNBHDGKALP(double MHNPONMPDCG, IGMCHMEGMON GBFDMJLKPAC, byte[] BGIIPDEPEFH, [Out] int CBKFAHCFHJN, [Out] int CEMLGKOICHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x688DB90", Offset = "0x688C590", VA = "0x18688DB90")]
	private static bool ENBDEDEIGBM(double FDFHGIHHGHO, ICNOCJPABHO NPGFINHODME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x688CE20", Offset = "0x688B820", VA = "0x18688CE20")]
	private static bool BNNOIIDFFCI(double FDFHGIHHGHO, ICNOCJPABHO NPGFINHODME, NIBEHKLDEOP GBFDMJLKPAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x688D6F0", Offset = "0x688C0F0", VA = "0x18688D6F0")]
	private static void DGHGOPPEIDN(byte[] GPLAMKEOFAI, int CBKFAHCFHJN, int CEMLGKOICHB, int NCCMPMOMCMN, ICNOCJPABHO NPGFINHODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x688C920", Offset = "0x688B320", VA = "0x18688C920")]
	private static void AJPJCLGCHCC(byte[] GPLAMKEOFAI, int CBKFAHCFHJN, int NBJHAABFIFP, ICNOCJPABHO NPGFINHODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x688C730", Offset = "0x688B130", VA = "0x18688C730")]
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
	[Cpp2IlInjected.Address(RVA = "0x6887020", Offset = "0x6885A20", VA = "0x186887020")]
	public ACONHCGELAH(double KGLKPBOCCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6887030", Offset = "0x6885A30", VA = "0x186887030")]
	public ACONHCGELAH(JKBEAMDAIKK KGLKPBOCCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6886B00", Offset = "0x6885500", VA = "0x186886B00")]
	public JKBEAMDAIKK CBIJKGNDFPI()
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6886B80", Offset = "0x6885580", VA = "0x186886B80")]
	public JKBEAMDAIKK CDIHGANDEOD()
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590")]
	public ulong ADNGKLNHHLN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6886F30", Offset = "0x6885930", VA = "0x186886F30")]
	public double LBGIBAPGELC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6886D50", Offset = "0x6885750", VA = "0x186886D50")]
	public double DLKLHDINKFA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6886F00", Offset = "0x6885900", VA = "0x186886F00")]
	public int LBCMJLMOAJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6886E80", Offset = "0x6885880", VA = "0x186886E80")]
	public ulong KKDMOLMAHFG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6886A90", Offset = "0x6885490", VA = "0x186886A90")]
	public bool AADCDAJNKPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6886FB0", Offset = "0x68859B0", VA = "0x186886FB0")]
	public bool LDKPHFKJBGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6886AD0", Offset = "0x68854D0", VA = "0x186886AD0")]
	public bool BPKJJLODDHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6886FF0", Offset = "0x68859F0", VA = "0x186886FF0")]
	public bool OMBICHMLGGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6886AB0", Offset = "0x68854B0", VA = "0x186886AB0")]
	public int BBDAMGIMFBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6886C00", Offset = "0x6885600", VA = "0x186886C00")]
	public void DJCFMFGIIFK([Out] JKBEAMDAIKK GLCIELHGEEF, [Out] JKBEAMDAIKK LGNBBDMLOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6886EB0", Offset = "0x68858B0", VA = "0x186886EB0")]
	public bool LBBCNINJAGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6D40", Offset = "0x2BF5740", VA = "0x182BF6D40")]
	public double FDFHGIHHGHO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6886FD0", Offset = "0x68859D0", VA = "0x186886FD0")]
	public static int NNOPIJAAHKA(int LJMBCOIKEFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6886B70", Offset = "0x6885570", VA = "0x186886B70")]
	public static double CBNMIPFCLGF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6886DF0", Offset = "0x68857F0", VA = "0x186886DF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1ECFB70", Offset = "0x1ECE570", VA = "0x181ECFB70")]
	public JDBEFOJNABE(float BDOADEOBIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6893EB0", Offset = "0x68928B0", VA = "0x186893EB0")]
	public JKBEAMDAIKK CBIJKGNDFPI()
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410")]
	public uint AGEJLEPNPGO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6894090", Offset = "0x6892A90", VA = "0x186894090")]
	public int LBCMJLMOAJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6894030", Offset = "0x6892A30", VA = "0x186894030")]
	public uint KKDMOLMAHFG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6893EA0", Offset = "0x68928A0", VA = "0x186893EA0")]
	public bool AADCDAJNKPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6893F00", Offset = "0x6892900", VA = "0x186893F00")]
	public void DJCFMFGIIFK([Out] JKBEAMDAIKK GLCIELHGEEF, [Out] JKBEAMDAIKK LGNBBDMLOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6894050", Offset = "0x6892A50", VA = "0x186894050")]
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
	[Cpp2IlInjected.Address(RVA = "0x6887480", Offset = "0x6885E80", VA = "0x186887480")]
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
	[Cpp2IlInjected.Address(RVA = "0x689A6A0", Offset = "0x68990A0", VA = "0x18689A6A0")]
	public static void DMKOMBEKFFD(int JKCNDPKKOBM, int IIBACGAIONO, [Out] JKBEAMDAIKK PCLEMPNBMGO, [Out] int LICPKIDMBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x689A7B0", Offset = "0x68991B0", VA = "0x18689A7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6898B40", Offset = "0x6897540", VA = "0x186898B40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A95BF0", Offset = "0x3A945F0", VA = "0x183A95BF0")]
	public NHJPEHBOIJD(byte[] PEBEDGMMHMC, int AJOMPGHNEBN, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1EFF270", Offset = "0x1EFDC70", VA = "0x181EFF270")]
	public int CBKFAHCFHJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6898B80", Offset = "0x6897580", VA = "0x186898B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x6896F40", Offset = "0x6895940", VA = "0x186896F40")]
	private static byte[] JDAEOIPANOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6896540", Offset = "0x6894F40", VA = "0x186896540")]
	private static NHJPEHBOIJD CPPENCOAFMC(NHJPEHBOIJD BGIIPDEPEFH)
	{
		return default(NHJPEHBOIJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6896460", Offset = "0x6894E60", VA = "0x186896460")]
	private static NHJPEHBOIJD CFPMIMJJMLJ(NHJPEHBOIJD BGIIPDEPEFH)
	{
		return default(NHJPEHBOIJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6897810", Offset = "0x6896210", VA = "0x186897810")]
	private static void MGJAJOFCHNK(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP, byte[] JEEDJABCHJM, [Out] int IHIKODNCHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6896C50", Offset = "0x6895650", VA = "0x186896C50")]
	private static void IBLFINFHEGH(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP, byte[] JEODLGNOGGB, int IALKDKFNMPD, [Out] NHJPEHBOIJD BNKIALJICBN, [Out] int HPDEKKGBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6896100", Offset = "0x6894B00", VA = "0x186896100")]
	private static ulong ANIIDOEGLOB(NHJPEHBOIJD BGIIPDEPEFH, [Out] int BFAIFPDBPCM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6896740", Offset = "0x6895140", VA = "0x186896740")]
	private static void DJGDDJLKHED(NHJPEHBOIJD BGIIPDEPEFH, [Out] JKBEAMDAIKK MNKBHKEBOPJ, [Out] int MNGJLNIPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6896880", Offset = "0x6895280", VA = "0x186896880")]
	private static bool FKNDEOPGDDO(NHJPEHBOIJD BNKIALJICBN, int NBJHAABFIFP, [Out] double MNKBHKEBOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6897020", Offset = "0x6895A20", VA = "0x186897020")]
	private static JKBEAMDAIKK LDAAHDJNAIA(int NBJHAABFIFP)
	{
		return default(JKBEAMDAIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x68971C0", Offset = "0x6895BC0", VA = "0x1868971C0")]
	private static bool LPEHDDCNPPB(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP, [Out] double MNKBHKEBOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6896620", Offset = "0x6895020", VA = "0x186896620")]
	private static bool DJEIHLENFKG(NHJPEHBOIJD BNKIALJICBN, int NBJHAABFIFP, [Out] double MDELOMBNNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x68978A0", Offset = "0x68962A0", VA = "0x1868978A0")]
	public static double? PNGGFNIGEOJ(NHJPEHBOIJD BGIIPDEPEFH, int NBJHAABFIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6896190", Offset = "0x6894B90", VA = "0x186896190")]
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
		[Cpp2IlInjected.Address(RVA = "0x6893CC0", Offset = "0x68926C0", VA = "0x186893CC0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x17B6E20", Offset = "0x17B5820", VA = "0x1817B6E20")]
	public IJEFDCMJOOM(byte[] BGIIPDEPEFH, int ABOMIAEBHEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6893CB0", Offset = "0x68926B0", VA = "0x186893CB0")]
	public static IJEFDCMJOOM MGINOFJNHOG(IJEFDCMJOOM NHHBAHIFHJK)
	{
		return default(IJEFDCMJOOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6893C60", Offset = "0x6892660", VA = "0x186893C60")]
	public static IJEFDCMJOOM KILOAEIJEKO(IJEFDCMJOOM NHHBAHIFHJK, int CBKFAHCFHJN)
	{
		return default(IJEFDCMJOOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6893B40", Offset = "0x6892540", VA = "0x186893B40")]
	public static int DEAFAHIGGBI(IJEFDCMJOOM CGDDINAJAOB, IJEFDCMJOOM GIFBDNCPDKC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6893B90", Offset = "0x6892590", VA = "0x186893B90")]
	public static bool FFFIMEBHMPG(IJEFDCMJOOM CGDDINAJAOB, IJEFDCMJOOM GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6893B50", Offset = "0x6892550", VA = "0x186893B50")]
	public static bool DKCGANGKMBM(IJEFDCMJOOM CGDDINAJAOB, IJEFDCMJOOM GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6893BA0", Offset = "0x68925A0", VA = "0x186893BA0")]
	public static bool FFFIMEBHMPG(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6893B60", Offset = "0x6892560", VA = "0x186893B60")]
	public static bool DKCGANGKMBM(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6893B60", Offset = "0x6892560", VA = "0x186893B60")]
	public static bool DKCGANGKMBM(IJEFDCMJOOM CGDDINAJAOB, byte GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6893BD0", Offset = "0x68925D0", VA = "0x186893BD0")]
	public static bool FFOKIMDPMMG(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6893C00", Offset = "0x6892600", VA = "0x186893C00")]
	public static bool FPIOOKIBAAA(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6893CF0", Offset = "0x68926F0", VA = "0x186893CF0")]
	public static bool NKMDIAMJMKN(IJEFDCMJOOM CGDDINAJAOB, char GIFBDNCPDKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6893C30", Offset = "0x6892630", VA = "0x186893C30")]
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
	[Cpp2IlInjected.Address(RVA = "0x68923A0", Offset = "0x6890DA0", VA = "0x1868923A0")]
	private static byte[] NDDOLLGIIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6892480", Offset = "0x6890E80", VA = "0x186892480")]
	private static byte[] OOEJLPMGHIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6892240", Offset = "0x6890C40", VA = "0x186892240")]
	public static double HGDNMFHJBCO(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x68922F0", Offset = "0x6890CF0", VA = "0x1868922F0")]
	public static float JJCHGEADPGN(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, [Out] int BPDGJKBHFDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6891020", Offset = "0x688FA20", VA = "0x186891020")]
	private static bool CFNNCLJLJKP(int LGHEBJJLAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6890E30", Offset = "0x688F830", VA = "0x186890E30")]
	private static bool CCGALKDJIHE(IJEFDCMJOOM OHGGFJCBDAL, IJEFDCMJOOM HPBGGHHMELE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6892150", Offset = "0x6890B50", VA = "0x186892150")]
	private static bool FPINJNKDDOJ(IJEFDCMJOOM OHGGFJCBDAL, IJEFDCMJOOM HPBGGHHMELE, byte[] OMMFAGLFEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6892100", Offset = "0x6890B00", VA = "0x186892100")]
	private static bool EOGLGFADEIB(IJEFDCMJOOM JGGIJMDALAN, byte[] ADLBCEDEBAN, int ABOMIAEBHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6892220", Offset = "0x6890C20", VA = "0x186892220")]
	private static double GNGNLBECJEJ(bool NDEMGCCGNFN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6891160", Offset = "0x688FB60", VA = "0x186891160")]
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
	[Cpp2IlInjected.Address(RVA = "0x36A8680", Offset = "0x36A7080", VA = "0x1836A8680")]
	public KBICCIBMAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
	public KBICCIBMAAC(CJBAJCFLGFB ENPICANKJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A74540", Offset = "0x3A72F40", VA = "0x183A74540", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A74170", Offset = "0x3A72B70", VA = "0x183A74170", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E37A50", Offset = "0x3E36450", VA = "0x183E37A50", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ArraySegment<T> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3E37630", Offset = "0x3E36030", VA = "0x183E37630", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x36A8680", Offset = "0x36A7080", VA = "0x1836A8680")]
	public MANCGONIDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
	public MANCGONIDAH(CJBAJCFLGFB ENPICANKJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x3D73620", Offset = "0x3D72020", VA = "0x183D73620", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, List<T> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3D6FDF0", Offset = "0x3D6E7F0", VA = "0x183D6FDF0", Slot = "5")]
	public List<T> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class EPKHJPOCFBC<TElement, TIntermediate, TEnumerator, TCollection> : CDPHELCNEFG<TCollection>, MEAKMJHAEGJ where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3266EB0", Offset = "0x32658B0", VA = "0x183266EB0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, TCollection FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3265880", Offset = "0x3264280", VA = "0x183265880", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	protected EPKHJPOCFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class HPJECNAGKOI<TElement, TIntermediate, TCollection> : EPKHJPOCFBC<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3743AC0", Offset = "0x37424C0", VA = "0x183743AC0", Slot = "6")]
	protected override IEnumerator<TElement> EKCAMIJIIEA(TCollection JIBNFGIMNPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x31E5700", Offset = "0x31E4100", VA = "0x1831E5700")]
	protected HPJECNAGKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class KHLHJFBFBLF<TElement, TCollection> : HPJECNAGKOI<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected sealed override TCollection LAAAOIHLIFJ(TCollection PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class JKBLKGBLLCM<TElement, TCollection> : KHLHJFBFBLF<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CC50", Offset = "0x3A2B650", VA = "0x183A2CC50", Slot = "7")]
	protected override TCollection NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CBF0", Offset = "0x3A2B5F0", VA = "0x183A2CBF0", Slot = "8")]
	protected override void FLOHBAGDPJC(TCollection AIEAHONEFEF, int OJANCMLFDOJ, TElement FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class IJPLDKAOKJI<T> : EPKHJPOCFBC<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x37D1AB0", Offset = "0x37D04B0", VA = "0x1837D1AB0", Slot = "8")]
	protected override void FLOHBAGDPJC(LinkedList<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override LinkedList<T> LAAAOIHLIFJ(LinkedList<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override LinkedList<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x37EE4C0", Offset = "0x37ECEC0", VA = "0x1837EE4C0", Slot = "6")]
	protected override LinkedList<T>.Enumerator EKCAMIJIIEA(LinkedList<T> JIBNFGIMNPP)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class NAIEKMIHEBB<T> : EPKHJPOCFBC<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x37D1AB0", Offset = "0x37D04B0", VA = "0x1837D1AB0", Slot = "8")]
	protected override void FLOHBAGDPJC(Queue<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override Queue<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3E14740", Offset = "0x3E13140", VA = "0x183E14740", Slot = "6")]
	protected override Queue<T>.Enumerator EKCAMIJIIEA(Queue<T> JIBNFGIMNPP)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override Queue<T> LAAAOIHLIFJ(Queue<T> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class APNBABBOFJM<T> : EPKHJPOCFBC<T, LKKGEBOBJOF<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3599940", Offset = "0x3598340", VA = "0x183599940", Slot = "8")]
	protected override void FLOHBAGDPJC(LKKGEBOBJOF<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3599990", Offset = "0x3598390", VA = "0x183599990", Slot = "7")]
	protected override LKKGEBOBJOF<T> NDFPICIGPEG()
	{
		return default(LKKGEBOBJOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x372BFE0", Offset = "0x372A9E0", VA = "0x18372BFE0", Slot = "6")]
	protected override Stack<T>.Enumerator EKCAMIJIIEA(Stack<T> JIBNFGIMNPP)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x372C040", Offset = "0x372AA40", VA = "0x18372C040", Slot = "9")]
	protected override Stack<T> LAAAOIHLIFJ(LKKGEBOBJOF<T> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class CEEPEBGPJGM<T> : EPKHJPOCFBC<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x37D1AB0", Offset = "0x37D04B0", VA = "0x1837D1AB0", Slot = "8")]
	protected override void FLOHBAGDPJC(HashSet<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override HashSet<T> LAAAOIHLIFJ(HashSet<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override HashSet<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3E14740", Offset = "0x3E13140", VA = "0x183E14740", Slot = "6")]
	protected override HashSet<T>.Enumerator EKCAMIJIIEA(HashSet<T> JIBNFGIMNPP)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class OLOLMDPCGLN<T> : HPJECNAGKOI<T, LKKGEBOBJOF<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3599940", Offset = "0x3598340", VA = "0x183599940", Slot = "8")]
	protected override void FLOHBAGDPJC(LKKGEBOBJOF<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3F30910", Offset = "0x3F2F310", VA = "0x183F30910", Slot = "9")]
	protected override ReadOnlyCollection<T> LAAAOIHLIFJ(LKKGEBOBJOF<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3F309B0", Offset = "0x3F2F3B0", VA = "0x183F309B0", Slot = "7")]
	protected override LKKGEBOBJOF<T> NDFPICIGPEG()
	{
		return default(LKKGEBOBJOF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class IDKGLLPMKPK<T> : HPJECNAGKOI<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x37D1AB0", Offset = "0x37D04B0", VA = "0x1837D1AB0", Slot = "8")]
	protected override void FLOHBAGDPJC(List<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override List<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override IList<T> LAAAOIHLIFJ(List<T> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class DBPKAECEIJF<T> : HPJECNAGKOI<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x37D1AB0", Offset = "0x37D04B0", VA = "0x1837D1AB0", Slot = "8")]
	protected override void FLOHBAGDPJC(List<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override List<T> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override ICollection<T> LAAAOIHLIFJ(List<T> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class FAAONLHGDEL<T> : HPJECNAGKOI<T, LKKGEBOBJOF<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3599940", Offset = "0x3598340", VA = "0x183599940", Slot = "8")]
	protected override void FLOHBAGDPJC(LKKGEBOBJOF<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3599990", Offset = "0x3598390", VA = "0x183599990", Slot = "7")]
	protected override LKKGEBOBJOF<T> NDFPICIGPEG()
	{
		return default(LKKGEBOBJOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3599970", Offset = "0x3598370", VA = "0x183599970", Slot = "9")]
	protected override IEnumerable<T> LAAAOIHLIFJ(LKKGEBOBJOF<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x31F30E0", Offset = "0x31F1AE0", VA = "0x1831F30E0")]
	public FAAONLHGDEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class PMGNMNDGKBK<TKey, TElement> : CDPHELCNEFG<IGrouping<TKey, TElement>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x4013F20", Offset = "0x4012920", VA = "0x184013F20", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, IGrouping<TKey, TElement> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x4013C20", Offset = "0x4012620", VA = "0x184013C20", Slot = "5")]
	public IGrouping<TKey, TElement> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class IEGLMFMNNDH<TKey, TElement> : CDPHELCNEFG<ILookup<TKey, TElement>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x37D2190", Offset = "0x37D0B90", VA = "0x1837D2190", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ILookup<TKey, TElement> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x37D1E40", Offset = "0x37D0840", VA = "0x1837D1E40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7B0130", Offset = "0x7AEB30", VA = "0x1807B0130")]
	public CBNJENKHDCM(TKey KCGLPAPOILB, IEnumerable<TElement> CIBMCDHAIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x48560B0", Offset = "0x4854AB0", VA = "0x1848560B0", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x320E4E0", Offset = "0x320CEE0", VA = "0x18320E4E0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x32232D0", Offset = "0x3221CD0", VA = "0x1832232D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public GPOLKAMKPDK(Dictionary<TKey, IGrouping<TKey, TElement>> JLNCALNMKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x36BF7B0", Offset = "0x36BE1B0", VA = "0x1836BF7B0", Slot = "5")]
	public bool Contains(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x36BF7F0", Offset = "0x36BE1F0", VA = "0x1836BF7F0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x36BF7F0", Offset = "0x36BE1F0", VA = "0x1836BF7F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BEPFAEACPEG<T> : CDPHELCNEFG<T>, MEAKMJHAEGJ where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4625180", Offset = "0x4623B80", VA = "0x184625180", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x4624F00", Offset = "0x4623900", VA = "0x184624F00", Slot = "5")]
	public T AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A4AD0", Offset = "0x68A34D0", VA = "0x1868A4AD0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, IEnumerable FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x68A4880", Offset = "0x68A3280", VA = "0x1868A4880", Slot = "5")]
	public IEnumerable AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A8DF0", Offset = "0x68A77F0", VA = "0x1868A8DF0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ICollection FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x68A8BA0", Offset = "0x68A75A0", VA = "0x1868A8BA0", Slot = "5")]
	public ICollection AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A21E0", Offset = "0x68A0BE0", VA = "0x1868A21E0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, IList FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x68A1F90", Offset = "0x68A0990", VA = "0x1868A1F90", Slot = "5")]
	public IList AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public EFOENACHEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class GILANDFBNBB<T> : HPJECNAGKOI<T, LKKGEBOBJOF<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x36B26B0", Offset = "0x36B10B0", VA = "0x1836B26B0", Slot = "8")]
	protected override void FLOHBAGDPJC(LKKGEBOBJOF<T> AIEAHONEFEF, int OJANCMLFDOJ, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3599990", Offset = "0x3598390", VA = "0x183599990", Slot = "7")]
	protected override LKKGEBOBJOF<T> NDFPICIGPEG()
	{
		return default(LKKGEBOBJOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x36B2710", Offset = "0x36B1110", VA = "0x1836B2710", Slot = "9")]
	protected override IReadOnlyList<T> LAAAOIHLIFJ(LKKGEBOBJOF<T> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x31F2A80", Offset = "0x31F1480", VA = "0x1831F2A80")]
	public GILANDFBNBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class FPPEJCIDMND
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x68A5460", Offset = "0x68A3E60", VA = "0x1868A5460")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A3D10", Offset = "0x68A2710", VA = "0x1868A3D10", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, DateTime FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x68A3000", Offset = "0x68A1A00", VA = "0x1868A3000", Slot = "5")]
	public DateTime AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A1870", Offset = "0x68A0270", VA = "0x1868A1870", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, DateTimeOffset FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x68A0C50", Offset = "0x689F650", VA = "0x1868A0C50", Slot = "5")]
	public DateTimeOffset AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AADD0", Offset = "0x68A97D0", VA = "0x1868AADD0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, TimeSpan FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x68AA4C0", Offset = "0x68A8EC0", VA = "0x1868AA4C0", Slot = "5")]
	public TimeSpan AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public LJGIKKKFKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class COCCALEBAHB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : CDPHELCNEFG<TDictionary>, MEAKMJHAEGJ where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x4A26EC0", Offset = "0x4A258C0", VA = "0x184A26EC0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, TDictionary FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4A244D0", Offset = "0x4A22ED0", VA = "0x184A244D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	protected COCCALEBAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class BJNBPHHAALM<TKey, TValue, TIntermediate, TDictionary> : COCCALEBAHB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3743AC0", Offset = "0x37424C0", VA = "0x183743AC0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> EKCAMIJIIEA(TDictionary JIBNFGIMNPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class KNMBCJKKLCJ<TKey, TValue, TDictionary> : BJNBPHHAALM<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override TDictionary LAAAOIHLIFJ(TDictionary PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class NPFAKCIDLEN<TKey, TValue> : COCCALEBAHB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A7E0", Offset = "0x3E491E0", VA = "0x183E4A7E0", Slot = "8")]
	protected override void FLOHBAGDPJC(Dictionary<TKey, TValue> AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override Dictionary<TKey, TValue> LAAAOIHLIFJ(Dictionary<TKey, TValue> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override Dictionary<TKey, TValue> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A730", Offset = "0x3E49130", VA = "0x183E4A730", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator EKCAMIJIIEA(Dictionary<TKey, TValue> JIBNFGIMNPP)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x31E49F0", Offset = "0x31E33F0", VA = "0x1831E49F0")]
	public NPFAKCIDLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NKOIDLGHAJL<TKey, TValue, TDictionary> : KNMBCJKKLCJ<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x3E402F0", Offset = "0x3E3ECF0", VA = "0x183E402F0", Slot = "8")]
	protected override void FLOHBAGDPJC(TDictionary AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3032500", Offset = "0x3030F00", VA = "0x183032500", Slot = "7")]
	protected override TDictionary NDFPICIGPEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class GMEAGMLPNBG<TKey, TValue> : BJNBPHHAALM<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x35A35B0", Offset = "0x35A1FB0", VA = "0x1835A35B0", Slot = "8")]
	protected override void FLOHBAGDPJC(Dictionary<TKey, TValue> AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override Dictionary<TKey, TValue> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override IDictionary<TKey, TValue> LAAAOIHLIFJ(Dictionary<TKey, TValue> PGLKCKDGDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class FEEJEAIHKDJ<TKey, TValue> : KNMBCJKKLCJ<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x35A35B0", Offset = "0x35A1FB0", VA = "0x1835A35B0", Slot = "8")]
	protected override void FLOHBAGDPJC(SortedList<TKey, TValue> AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override SortedList<TKey, TValue> NDFPICIGPEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class KLPLKIPLDIB<TKey, TValue> : COCCALEBAHB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x35A35B0", Offset = "0x35A1FB0", VA = "0x1835A35B0", Slot = "8")]
	protected override void FLOHBAGDPJC(SortedDictionary<TKey, TValue> AIEAHONEFEF, int OJANCMLFDOJ, TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x842B90", Offset = "0x841590", VA = "0x180842B90", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> LAAAOIHLIFJ(SortedDictionary<TKey, TValue> PGLKCKDGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x35A35F0", Offset = "0x35A1FF0", VA = "0x1835A35F0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> NDFPICIGPEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3AC44E0", Offset = "0x3AC2EE0", VA = "0x183AC44E0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator EKCAMIJIIEA(SortedDictionary<TKey, TValue> JIBNFGIMNPP)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class KFELAPMGMAG<T> : CDPHELCNEFG<T>, MEAKMJHAEGJ where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3A92420", Offset = "0x3A90E20", VA = "0x183A92420", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3A92180", Offset = "0x3A90B80", VA = "0x183A92180", Slot = "5")]
	public T AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x689E610", Offset = "0x689D010", VA = "0x18689E610", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, IDictionary FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x689E3E0", Offset = "0x689CDE0", VA = "0x18689E3E0", Slot = "5")]
	public IDictionary AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A8330", Offset = "0x68A6D30", VA = "0x1868A8330")]
	public ICIBLDDOFLG(params KJLLBNBALAI[] PFFEBPIOLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x68A7970", Offset = "0x68A6370", VA = "0x1868A7970", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x68A78E0", Offset = "0x68A62E0", VA = "0x1868A78E0", Slot = "5")]
	public object AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class HICGNACGPDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x68A69F0", Offset = "0x68A53F0", VA = "0x1868A69F0")]
	public static object IHBHFKMEGBK(Type ADAMDPHPFAA, [Out] bool KBGPGGGHJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x68A6100", Offset = "0x68A4B00", VA = "0x1868A6100")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public ONLAECKCLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3F35890", Offset = "0x3F34290", VA = "0x183F35890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public MGLKJHADMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D9A2F0", Offset = "0x3D98CF0", VA = "0x183D9A2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public DFBMKNGGHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4EF5690", Offset = "0x4EF4090", VA = "0x184EF5690")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public LPJMHHMPMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6EF0", Offset = "0x3BA58F0", VA = "0x183BA6EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B55790", Offset = "0x3B54190", VA = "0x183B55790")]
	static LBOANHBGPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E9E0", Offset = "0x3B5D3E0", VA = "0x183B5E9E0")]
	public LBOANHBGPGC(bool NPHBLFDPGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CF90", Offset = "0x3B4B990", VA = "0x183B4CF90", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3B492A0", Offset = "0x3B47CA0", VA = "0x183B492A0", Slot = "5")]
	public T AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3B4E8C0", Offset = "0x3B4D2C0", VA = "0x183B4E8C0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, T FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3B4BF20", Offset = "0x3B4A920", VA = "0x183B4BF20", Slot = "7")]
	public T IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class KCMHOEMOONB<T> : CDPHELCNEFG<T[,]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A830E0", Offset = "0x3A81AE0", VA = "0x183A830E0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T[,] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A82DB0", Offset = "0x3A817B0", VA = "0x183A82DB0", Slot = "5")]
	public T[,] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public KCMHOEMOONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class MIDLLLNPFBA<T> : CDPHELCNEFG<T[,,]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CB70", Offset = "0x3D9B570", VA = "0x183D9CB70", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T[,,] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D9C730", Offset = "0x3D9B130", VA = "0x183D9C730", Slot = "5")]
	public T[,,] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public MIDLLLNPFBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class KODLHIHONCJ<T> : CDPHELCNEFG<T[,,,]>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9390", Offset = "0x3AC7D90", VA = "0x183AC9390", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T[,,,] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8E40", Offset = "0x3AC7840", VA = "0x183AC8E40", Slot = "5")]
	public T[,,,] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public KODLHIHONCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class ADDFLINDKGJ<T> : CDPHELCNEFG<T?>, MEAKMJHAEGJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3675460", Offset = "0x3673E60", VA = "0x183675460", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3674F30", Offset = "0x3673930", VA = "0x183674F30", Slot = "5")]
	public T? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public LIACMPIPECF(CDPHELCNEFG<T> KFAMGKEFBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B8AE00", Offset = "0x3B89800", VA = "0x183B8AE00", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, T? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3B8AC50", Offset = "0x3B89650", VA = "0x183B8AC50", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x689E090", Offset = "0x689CA90", VA = "0x18689E090", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, sbyte FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x689DF80", Offset = "0x689C980", VA = "0x18689DF80", Slot = "5")]
	public sbyte AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x689E0F0", Offset = "0x689CAF0", VA = "0x18689E0F0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, sbyte FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x689DFD0", Offset = "0x689C9D0", VA = "0x18689DFD0", Slot = "7")]
	public sbyte IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A5F00", Offset = "0x68A4900", VA = "0x1868A5F00", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, sbyte? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x68A5D30", Offset = "0x68A4730", VA = "0x1868A5D30", Slot = "5")]
	public sbyte? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x68A5FC0", Offset = "0x68A49C0", VA = "0x1868A5FC0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, sbyte? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x68A5DE0", Offset = "0x68A47E0", VA = "0x1868A5DE0", Slot = "7")]
	public sbyte? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AD030", Offset = "0x68ABA30", VA = "0x1868AD030", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, sbyte[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x68ACEA0", Offset = "0x68AB8A0", VA = "0x1868ACEA0", Slot = "5")]
	public sbyte[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68ADE40", Offset = "0x68AC840", VA = "0x1868ADE40", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, short FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x68ADD30", Offset = "0x68AC730", VA = "0x1868ADD30", Slot = "5")]
	public short AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x68ADEA0", Offset = "0x68AC8A0", VA = "0x1868ADEA0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, short FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x68ADD80", Offset = "0x68AC780", VA = "0x1868ADD80", Slot = "7")]
	public short IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AA2C0", Offset = "0x68A8CC0", VA = "0x1868AA2C0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, short? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x68AA0F0", Offset = "0x68A8AF0", VA = "0x1868AA0F0", Slot = "5")]
	public short? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x68AA380", Offset = "0x68A8D80", VA = "0x1868AA380", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, short? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x68AA1A0", Offset = "0x68A8BA0", VA = "0x1868AA1A0", Slot = "7")]
	public short? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x689DBC0", Offset = "0x689C5C0", VA = "0x18689DBC0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, short[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x689DA30", Offset = "0x689C430", VA = "0x18689DA30", Slot = "5")]
	public short[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A9D40", Offset = "0x68A8740", VA = "0x1868A9D40", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, int FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x68A9C30", Offset = "0x68A8630", VA = "0x1868A9C30", Slot = "5")]
	public int AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x68A9DA0", Offset = "0x68A87A0", VA = "0x1868A9DA0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, int FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x68A9C80", Offset = "0x68A8680", VA = "0x1868A9C80", Slot = "7")]
	public int IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A2760", Offset = "0x68A1160", VA = "0x1868A2760", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, int? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x68A2590", Offset = "0x68A0F90", VA = "0x1868A2590", Slot = "5")]
	public int? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x68A2820", Offset = "0x68A1220", VA = "0x1868A2820", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, int? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x68A2640", Offset = "0x68A1040", VA = "0x1868A2640", Slot = "7")]
	public int? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A9820", Offset = "0x68A8220", VA = "0x1868A9820", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, int[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x68A9690", Offset = "0x68A8090", VA = "0x1868A9690", Slot = "5")]
	public int[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A5A30", Offset = "0x68A4430", VA = "0x1868A5A30", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, long FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x68A5920", Offset = "0x68A4320", VA = "0x1868A5920", Slot = "5")]
	public long AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x68A5A90", Offset = "0x68A4490", VA = "0x1868A5A90", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, long FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x68A5970", Offset = "0x68A4370", VA = "0x1868A5970", Slot = "7")]
	public long IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A5720", Offset = "0x68A4120", VA = "0x1868A5720", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, long? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x68A5520", Offset = "0x68A3F20", VA = "0x1868A5520", Slot = "5")]
	public long? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x68A57E0", Offset = "0x68A41E0", VA = "0x1868A57E0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, long? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x68A55E0", Offset = "0x68A3FE0", VA = "0x1868A55E0", Slot = "7")]
	public long? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A46D0", Offset = "0x68A30D0", VA = "0x1868A46D0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, long[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x68A4540", Offset = "0x68A2F40", VA = "0x1868A4540", Slot = "5")]
	public long[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x689F240", Offset = "0x689DC40", VA = "0x18689F240", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, byte FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x689F130", Offset = "0x689DB30", VA = "0x18689F130", Slot = "5")]
	public byte AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x689F2A0", Offset = "0x689DCA0", VA = "0x18689F2A0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, byte FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x689F180", Offset = "0x689DB80", VA = "0x18689F180", Slot = "7")]
	public byte IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AE870", Offset = "0x68AD270", VA = "0x1868AE870", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, byte? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x68AE6A0", Offset = "0x68AD0A0", VA = "0x1868AE6A0", Slot = "5")]
	public byte? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x68AE930", Offset = "0x68AD330", VA = "0x1868AE930", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, byte? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x68AE750", Offset = "0x68AD150", VA = "0x1868AE750", Slot = "7")]
	public byte? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A9540", Offset = "0x68A7F40", VA = "0x1868A9540", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ushort FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x68A9430", Offset = "0x68A7E30", VA = "0x1868A9430", Slot = "5")]
	public ushort AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x68A95A0", Offset = "0x68A7FA0", VA = "0x1868A95A0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, ushort FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x68A9480", Offset = "0x68A7E80", VA = "0x1868A9480", Slot = "7")]
	public ushort IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AB970", Offset = "0x68AA370", VA = "0x1868AB970", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ushort? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x68AB7A0", Offset = "0x68AA1A0", VA = "0x1868AB7A0", Slot = "5")]
	public ushort? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x68ABA30", Offset = "0x68AA430", VA = "0x1868ABA30", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, ushort? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x68AB850", Offset = "0x68AA250", VA = "0x1868AB850", Slot = "7")]
	public ushort? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A7730", Offset = "0x68A6130", VA = "0x1868A7730", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ushort[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x68A75A0", Offset = "0x68A5FA0", VA = "0x1868A75A0", Slot = "5")]
	public ushort[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A8A50", Offset = "0x68A7450", VA = "0x1868A8A50", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, uint FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x68A8940", Offset = "0x68A7340", VA = "0x1868A8940", Slot = "5")]
	public uint AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x68A8AB0", Offset = "0x68A74B0", VA = "0x1868A8AB0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, uint FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x68A8990", Offset = "0x68A7390", VA = "0x1868A8990", Slot = "7")]
	public uint IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AD7B0", Offset = "0x68AC1B0", VA = "0x1868AD7B0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, uint? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x68AD5E0", Offset = "0x68ABFE0", VA = "0x1868AD5E0", Slot = "5")]
	public uint? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x68AD870", Offset = "0x68AC270", VA = "0x1868AD870", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, uint? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x68AD690", Offset = "0x68AC090", VA = "0x1868AD690", Slot = "7")]
	public uint? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AE120", Offset = "0x68ACB20", VA = "0x1868AE120", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, uint[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x68ADF90", Offset = "0x68AC990", VA = "0x1868ADF90", Slot = "5")]
	public uint[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A4F10", Offset = "0x68A3910", VA = "0x1868A4F10", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ulong FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x68A4E00", Offset = "0x68A3800", VA = "0x1868A4E00", Slot = "5")]
	public ulong AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x68A4F70", Offset = "0x68A3970", VA = "0x1868A4F70", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, ulong FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x68A4E50", Offset = "0x68A3850", VA = "0x1868A4E50", Slot = "7")]
	public ulong IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AD3E0", Offset = "0x68ABDE0", VA = "0x1868AD3E0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ulong? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x68AD1E0", Offset = "0x68ABBE0", VA = "0x1868AD1E0", Slot = "5")]
	public ulong? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x68AD4A0", Offset = "0x68ABEA0", VA = "0x1868AD4A0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, ulong? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x68AD2A0", Offset = "0x68ABCA0", VA = "0x1868AD2A0", Slot = "7")]
	public ulong? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AB4A0", Offset = "0x68A9EA0", VA = "0x1868AB4A0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ulong[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x68AB310", Offset = "0x68A9D10", VA = "0x1868AB310", Slot = "5")]
	public ulong[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AC670", Offset = "0x68AB070", VA = "0x1868AC670", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, float FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x68AC560", Offset = "0x68AAF60", VA = "0x1868AC560", Slot = "5")]
	public float AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x68AC6D0", Offset = "0x68AB0D0", VA = "0x1868AC6D0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, float FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x68AC5B0", Offset = "0x68AAFB0", VA = "0x1868AC5B0", Slot = "7")]
	public float IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AE4A0", Offset = "0x68ACEA0", VA = "0x1868AE4A0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, float? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x68AE2D0", Offset = "0x68ACCD0", VA = "0x1868AE2D0", Slot = "5")]
	public float? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x68AE560", Offset = "0x68ACF60", VA = "0x1868AE560", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, float? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x68AE380", Offset = "0x68ACD80", VA = "0x1868AE380", Slot = "7")]
	public float? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A2E40", Offset = "0x68A1840", VA = "0x1868A2E40", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, float[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x68A2CB0", Offset = "0x68A16B0", VA = "0x1868A2CB0", Slot = "5")]
	public float[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A9FA0", Offset = "0x68A89A0", VA = "0x1868A9FA0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, double FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x68A9E90", Offset = "0x68A8890", VA = "0x1868A9E90", Slot = "5")]
	public double AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x68AA000", Offset = "0x68A8A00", VA = "0x1868AA000", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, double FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x68A9EE0", Offset = "0x68A88E0", VA = "0x1868A9EE0", Slot = "7")]
	public double IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A5260", Offset = "0x68A3C60", VA = "0x1868A5260", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, double? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x68A5060", Offset = "0x68A3A60", VA = "0x1868A5060", Slot = "5")]
	public double? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x68A5320", Offset = "0x68A3D20", VA = "0x1868A5320", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, double? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x68A5120", Offset = "0x68A3B20", VA = "0x1868A5120", Slot = "7")]
	public double? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AEC00", Offset = "0x68AD600", VA = "0x1868AEC00", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, double[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x68AEA70", Offset = "0x68AD470", VA = "0x1868AEA70", Slot = "5")]
	public double[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A9AE0", Offset = "0x68A84E0", VA = "0x1868A9AE0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, bool FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x68A99D0", Offset = "0x68A83D0", VA = "0x1868A99D0", Slot = "5")]
	public bool AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x68A9B40", Offset = "0x68A8540", VA = "0x1868A9B40", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, bool FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x68A9A20", Offset = "0x68A8420", VA = "0x1868A9A20", Slot = "7")]
	public bool IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x689F560", Offset = "0x689DF60", VA = "0x18689F560", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, bool? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x689F390", Offset = "0x689DD90", VA = "0x18689F390", Slot = "5")]
	public bool? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x689F620", Offset = "0x689E020", VA = "0x18689F620", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, bool? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x689F440", Offset = "0x689DE40", VA = "0x18689F440", Slot = "7")]
	public bool? IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A2AF0", Offset = "0x68A14F0", VA = "0x1868A2AF0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, bool[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x68A2960", Offset = "0x68A1360", VA = "0x1868A2960", Slot = "5")]
	public bool[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x689FBA0", Offset = "0x689E5A0", VA = "0x18689FBA0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, object FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x689F760", Offset = "0x689E160", VA = "0x18689F760", Slot = "5")]
	public object AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A8490", Offset = "0x68A6E90", VA = "0x1868A8490", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, byte[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x68A83E0", Offset = "0x68A6DE0", VA = "0x1868A83E0", Slot = "5")]
	public byte[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A73F0", Offset = "0x68A5DF0", VA = "0x1868A73F0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, ArraySegment<byte> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x68A72E0", Offset = "0x68A5CE0", VA = "0x1868A72E0", Slot = "5")]
	public ArraySegment<byte> AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68ABC10", Offset = "0x68AA610", VA = "0x1868ABC10", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, string FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x68ABB70", Offset = "0x68AA570", VA = "0x1868ABB70", Slot = "5")]
	public string AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x68ABC70", Offset = "0x68AA670", VA = "0x1868ABC70", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, string FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x68ABBC0", Offset = "0x68AA5C0", VA = "0x1868ABBC0", Slot = "7")]
	public string IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68ADB80", Offset = "0x68AC580", VA = "0x1868ADB80", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, string[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x68AD9B0", Offset = "0x68AC3B0", VA = "0x1868AD9B0", Slot = "5")]
	public string[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A5BF0", Offset = "0x68A45F0", VA = "0x1868A5BF0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, char FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x68A5B80", Offset = "0x68A4580", VA = "0x1868A5B80", Slot = "5")]
	public char AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x689EC90", Offset = "0x689D690", VA = "0x18689EC90", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, char? FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x689EB70", Offset = "0x689D570", VA = "0x18689EB70", Slot = "5")]
	public char? AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AC330", Offset = "0x68AAD30", VA = "0x1868AC330", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, char[] FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x68AC170", Offset = "0x68AAB70", VA = "0x1868AC170", Slot = "5")]
	public char[] AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68ABE80", Offset = "0x68AA880", VA = "0x1868ABE80", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, Guid FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x68ABD50", Offset = "0x68AA750", VA = "0x1868ABD50", Slot = "5")]
	public Guid AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x68ABFB0", Offset = "0x68AA9B0", VA = "0x1868ABFB0", Slot = "6")]
	public void PLGOMMDLGBE(PFDOBNDPOBK NADLGELBCMH, Guid FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x68ABDE0", Offset = "0x68AA7E0", VA = "0x1868ABDE0", Slot = "7")]
	public Guid IMDODIKCEGH(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x514B490", Offset = "0x5149E90", VA = "0x18514B490")]
	public NPOFMHNHAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x17385C0", Offset = "0x1736FC0", VA = "0x1817385C0")]
	public NPOFMHNHAOI(bool GLOGCLOIIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACC70", Offset = "0x68AB670", VA = "0x1868ACC70", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, decimal FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x68AC9D0", Offset = "0x68AB3D0", VA = "0x1868AC9D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A92D0", Offset = "0x68A7CD0", VA = "0x1868A92D0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, Uri FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x68A9210", Offset = "0x68A7C10", VA = "0x1868A9210", Slot = "5")]
	public Uri AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x689E2A0", Offset = "0x689CCA0", VA = "0x18689E2A0", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, Version FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x689E1E0", Offset = "0x689CBE0", VA = "0x18689E1E0", Slot = "5")]
	public Version AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public CNIAAFMLAPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class PAPKPBHCHBB<TKey, TValue> : CDPHELCNEFG<KeyValuePair<TKey, TValue>>, MEAKMJHAEGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3FBD360", Offset = "0x3FBBD60", VA = "0x183FBD360", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, KeyValuePair<TKey, TValue> FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3FBD030", Offset = "0x3FBBA30", VA = "0x183FBD030", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x689D910", Offset = "0x689C310", VA = "0x18689D910", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, StringBuilder FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x689D850", Offset = "0x689C250", VA = "0x18689D850", Slot = "5")]
	public StringBuilder AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x689EF90", Offset = "0x689D990", VA = "0x18689EF90", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, BitArray FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x689EE10", Offset = "0x689D810", VA = "0x18689EE10", Slot = "5")]
	public BitArray AFFCBAMFOKP(JPFLOFNLOOJ AGGHEBELANL, KJLLBNBALAI NBIBEAKEAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x68A8920", Offset = "0x68A7320", VA = "0x1868A8920")]
	public JAELKBOMHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF170", Offset = "0x5ECDB70", VA = "0x185ECF170")]
	public JAELKBOMHBG(bool DJJIBOLLFPF, bool NFALGMBPPAI, bool NCDPCJFMLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x68A8720", Offset = "0x68A7120", VA = "0x1868A8720", Slot = "4")]
	public void LENOCDGJGPN(PFDOBNDPOBK NADLGELBCMH, Type FDFHGIHHGHO, KJLLBNBALAI NBIBEAKEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x68A85D0", Offset = "0x68A6FD0", VA = "0x1868A85D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x689DD70", Offset = "0x689C770", VA = "0x18689DD70")]
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
	[Cpp2IlInjected.Address(RVA = "0x68AC7C0", Offset = "0x68AB1C0", VA = "0x1868AC7C0")]
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
