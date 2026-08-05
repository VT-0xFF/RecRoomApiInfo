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
internal static class IDIJMNEEBLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68B0BD0", Offset = "0x68AF9D0", VA = "0x1868B0BD0")]
	public static bool LOGEPKBKPOB(this TypeInfo HFFNCGFKMBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class MKILDMKFEAJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type MBGGNKAKBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DAPICNEPHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
	public MKILDMKFEAJ(Type EPPFDILFOKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class JDOJKEFLBCF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void IJDHFOIFIFP<T>(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T LOFMKIPCOLK<T>(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF MMBMEGFLLJC);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MAFHFNECHNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FMHIBLCEFCM<T> : MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OLKIFIEDHPJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum CFHHPDOLEOO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IENHLKGPHLI
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x273A680", Offset = "0x2739480", VA = "0x18273A680")]
	public static string KOGIOEDHOGC<T>(this FMHIBLCEFCM<T> OBBEEFPLHMN, T NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMHIBLCEFCM<T> JDAFGHEPMMH<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ONGDCHGEPFL
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x285A6D0", Offset = "0x28594D0", VA = "0x18285A6D0")]
	public static FMHIBLCEFCM<T> MGBBBOLHNGA<T>(this MFKHLLCMIMF MMBMEGFLLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68B66D0", Offset = "0x68B54D0", VA = "0x1868B66D0")]
	public static object KAPCKGAGBLB(this MFKHLLCMIMF MMBMEGFLLJC, Type HFFNCGFKMBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DHCFGANIGIC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68A47E0", Offset = "0x68A35E0", VA = "0x1868A47E0")]
	public DHCFGANIGIC(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GDGDHLJAODB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class NFLONIIADCA
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] CDNPBOBHCMP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] GHCFGIGPCGD;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68B62D0", Offset = "0x68B50D0", VA = "0x1868B62D0")]
		public static byte[] CIKFBAMOFPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68B6230", Offset = "0x68B5030", VA = "0x1868B6230")]
		public static char[] ABEHOJICLMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> KKBDHNIPCIB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] NEDBGNGNPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] JAHCJGGEGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int OOCJLKADJBK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool ABMMIKMJCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68AB060", Offset = "0x68A9E60", VA = "0x1868AB060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68AD030", Offset = "0x68ABE30", VA = "0x1868AD030")]
	public GDGDHLJAODB(byte[] JAHCJGGEGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68AD090", Offset = "0x68ABE90", VA = "0x1868AD090")]
	public GDGDHLJAODB(byte[] JAHCJGGEGHK, int OOCJLKADJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68AB360", Offset = "0x68AA160", VA = "0x1868AB360")]
	private MCJICHPLPFN IMIHNAFAJDL(string IJJEODPJDDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68ACE20", Offset = "0x68ABC20", VA = "0x1868ACE20")]
	private MCJICHPLPFN PKLHBDHAECF(string EMKENBOOEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68AC430", Offset = "0x68AB230", VA = "0x1868AC430")]
	public void OHCFEDJLNEF(int OOCJLKADJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
	public byte[] GNCPHOACANC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130")]
	public int ONNFMNPAACL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68AB8B0", Offset = "0x68AA6B0", VA = "0x1868AB8B0")]
	public IHDMDINKMON JKBJDKOGMMC()
	{
		return default(IHDMDINKMON);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68AA720", Offset = "0x68A9520", VA = "0x1868AA720")]
	public void FKEHJIKEHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68AB080", Offset = "0x68A9E80", VA = "0x1868AB080")]
	public bool IHIOCLAEEDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68ABE10", Offset = "0x68AAC10", VA = "0x1868ABE10")]
	public bool NFHLGAJNJMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68AC170", Offset = "0x68AAF70", VA = "0x1868AC170")]
	public void NPLNJGHPJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68AA010", Offset = "0x68A8E10", VA = "0x1868AA010")]
	public bool CIDEBAPJGGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68AA0A0", Offset = "0x68A8EA0", VA = "0x1868AA0A0")]
	public bool CIFHBOHBEEI(int BPFMGMBDOBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68AA200", Offset = "0x68A9000", VA = "0x1868AA200")]
	public bool DDJIMFCAOJP(int BPFMGMBDOBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68AAE20", Offset = "0x68A9C20", VA = "0x1868AAE20")]
	public bool HGKIFENKGHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68ABC10", Offset = "0x68AAA10", VA = "0x1868ABC10")]
	public void LKJCNELBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68AAFD0", Offset = "0x68A9DD0", VA = "0x1868AAFD0")]
	public bool IAELBNJDGCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68AB210", Offset = "0x68AA010", VA = "0x1868AB210")]
	public bool IJJOLIPGGHK(int BPFMGMBDOBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68AA3B0", Offset = "0x68A91B0", VA = "0x1868AA3B0")]
	public bool DKEFJJBCPBD(int BPFMGMBDOBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68AA170", Offset = "0x68A8F70", VA = "0x1868AA170")]
	public bool COAGDFPBFIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68AA680", Offset = "0x68A9480", VA = "0x1868AA680")]
	public void FJKCPOOBHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68A9F80", Offset = "0x68A8D80", VA = "0x1868A9F80")]
	public bool BDBOGGOPEPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68ABCB0", Offset = "0x68AAAB0", VA = "0x1868ABCB0")]
	public void NEJIDDHHIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68AC680", Offset = "0x68AB480", VA = "0x1868AC680")]
	private void PFCCMJPBOKC([Out] byte[] FEOLAAECJFK, [Out] int CFIJIAPFAEG, [Out] int HBHGNKOAHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68AA850", Offset = "0x68A9650", VA = "0x1868AA850")]
	private static int FNACMGCENCJ(char GCMDJKOKHCO, char LGCDJBDIEJC, char JJJKOMKEIGG, char DDIKBLEEKFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68AAA00", Offset = "0x68A9800", VA = "0x1868AAA00")]
	private static int GLKHJAECCBN(char AHPBAINPGNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68AAEB0", Offset = "0x68A9CB0", VA = "0x1868AAEB0")]
	public ArraySegment<byte> HOCNDFNKKJA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68AA2D0", Offset = "0x68A90D0", VA = "0x1868AA2D0")]
	public string DIKKPJKNMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68AB1A0", Offset = "0x68A9FA0", VA = "0x1868AB1A0")]
	public string IIHDEFACLMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68AC210", Offset = "0x68AB010", VA = "0x1868AC210")]
	public ArraySegment<byte> OCLMKHKFNDL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68AADB0", Offset = "0x68A9BB0", VA = "0x1868AADB0")]
	public ArraySegment<byte> HCIAAIKLEIP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68AAB60", Offset = "0x68A9960", VA = "0x1868AAB60")]
	public bool HANLEIOADCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68A9D50", Offset = "0x68A8B50", VA = "0x1868A9D50")]
	private static bool AAEFOOPHAPK(byte JJJKOMKEIGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68ABEA0", Offset = "0x68AACA0", VA = "0x1868ABEA0")]
	private void NNGCIKKMAAN(IHDMDINKMON NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68ABBC0", Offset = "0x68AA9C0", VA = "0x1868ABBC0")]
	public void JPDLACGBCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68ABA60", Offset = "0x68AA860", VA = "0x1868ABA60")]
	private void JNLHFMPEHIA(int KHJFBCMDGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68AC580", Offset = "0x68AB380", VA = "0x1868AC580")]
	public sbyte OKDKFEFHIJN()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68AAAE0", Offset = "0x68A98E0", VA = "0x1868AAAE0")]
	public short HAHGKMGPFFC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68AC440", Offset = "0x68AB240", VA = "0x1868AC440")]
	public int OIHFGCBJELC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68AC4C0", Offset = "0x68AB2C0", VA = "0x1868AC4C0")]
	public long OJMBCCDCBMO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68AC0F0", Offset = "0x68AAEF0", VA = "0x1868AC0F0")]
	public byte NNGMIIEDHEH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68AC600", Offset = "0x68AB400", VA = "0x1868AC600")]
	public ushort PDCLELAAAFB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68AB2E0", Offset = "0x68AA0E0", VA = "0x1868AB2E0")]
	public uint IKKHIIIPPBD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68ABD50", Offset = "0x68AAB50", VA = "0x1868ABD50")]
	public ulong NFDIGDMAKCL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68AA580", Offset = "0x68A9380", VA = "0x1868AA580")]
	public float EOJCJEBOEKI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68AA480", Offset = "0x68A9280", VA = "0x1868AA480")]
	public double EFLFCPELFGH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x68AA900", Offset = "0x68A9700", VA = "0x1868AA900")]
	public ArraySegment<byte> FPOACHANAHA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68A9E10", Offset = "0x68A8C10", VA = "0x1868A9E10")]
	private static int ANGJBDEBFKI(byte[] JAHCJGGEGHK, int OOCJLKADJBK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MCJICHPLPFN : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference AFKPMBNCMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int BPPBOBEEMFG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int MHPLMCPGHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBB7DC0", Offset = "0xBB6BC0", VA = "0x180BB7DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string EKJHBJDAOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x871C10", Offset = "0x870A10", VA = "0x180871C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68B5D10", Offset = "0x68B4B10", VA = "0x1868B5D10")]
	public MCJICHPLPFN(string EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68B5D70", Offset = "0x68B4B70", VA = "0x1868B5D70")]
	public MCJICHPLPFN(string EMKENBOOEOH, byte[] CKADAEIJHGE, int OOCJLKADJBK, int BPPBOBEEMFG, string LNPILJJMIBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KMIBHPFAEHB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class EEJFAIHDFAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] CDNPBOBHCMP;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68A6670", Offset = "0x68A5470", VA = "0x1868A6670")]
		public static byte[] CIKFBAMOFPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class JKBKPNAAADK
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void DADCNFKLFGH(JAENEBDBLKA HNIKDBEHAFP, object NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object OEKOPFKPMGB(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF MMBMEGFLLJC);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class FFOMJJOPFIC
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class INIDDIBFHNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
				public INIDDIBFHNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x465FDB0", Offset = "0x465EBB0", VA = "0x18465FDB0")]
				internal bool MOKHHFICDHG(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x68B15B0", Offset = "0x68B03B0", VA = "0x1868B15B0")]
				internal bool PGPMBIENPFP(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, MFKHLLCMIMF, byte[]> KFPOJMGIKAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, MFKHLLCMIMF> GLHLEJALKME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly DADCNFKLFGH OHFOBHFECHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, MFKHLLCMIMF, ArraySegment<byte>> NKHEHPANGNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, MFKHLLCMIMF, string> CMMFCCCAODM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, MFKHLLCMIMF, object> PGEEGHFKNIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, MFKHLLCMIMF, object> MMDJCGHKJHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, MFKHLLCMIMF, object> EEJMAPEFLDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly OEKOPFKPMGB OIDPFOILNDM;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x68A7080", Offset = "0x68A5E80", VA = "0x1868A7080")]
			public FFOMJJOPFIC(Type HFFNCGFKMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A1A0", Offset = "0x2C88FA0", VA = "0x182C8A1A0")]
			private static T PIBPBOAANDP<T>(DynamicMethod BLDJHDOFFOM)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x68A6E30", Offset = "0x68A5C30", VA = "0x1868A6E30")]
			private static MethodInfo OPHOKBADEGD(Type HFFNCGFKMBJ, string OHHBGJPCFJD, Type[] JGFJPKHAJJF)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, FFOMJJOPFIC> LHLIDIFGOAF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly HJNOGLODLJN<FFOMJJOPFIC> MEJGEDKNEPB;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68B3E30", Offset = "0x68B2C30", VA = "0x1868B3E30")]
		static JKBKPNAAADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68B3DB0", Offset = "0x68B2BB0", VA = "0x1868B3DB0")]
		private static FFOMJJOPFIC JBIMBFCKBJC(Type HFFNCGFKMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x68B3C30", Offset = "0x68B2A30", VA = "0x1868B3C30")]
		public static void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, object NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68B3B20", Offset = "0x68B2920", VA = "0x1868B3B20")]
		public static void FILLENIGNNA(Type HFFNCGFKMBJ, JAENEBDBLKA HNIKDBEHAFP, object NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MFKHLLCMIMF BDLIKAPLCDC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] LDOGLONKAPF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] OFOMCMOJOJG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static MFKHLLCMIMF KFELAOFLDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68B59E0", Offset = "0x68B47E0", VA = "0x1868B59E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x68B5980", Offset = "0x68B4780", VA = "0x1868B5980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68B5910", Offset = "0x68B4710", VA = "0x1868B5910")]
	public static void GCMMILEBAJN(MFKHLLCMIMF MMBMEGFLLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2780790", Offset = "0x277F590", VA = "0x182780790")]
	public static byte[] FILLENIGNNA<T>(T NHLNHJGAONN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2780620", Offset = "0x277F420", VA = "0x182780620")]
	public static byte[] FILLENIGNNA<T>(T NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2780CC0", Offset = "0x277FAC0", VA = "0x182780CC0")]
	public static void FILLENIGNNA<T>(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2780810", Offset = "0x277F610", VA = "0x182780810")]
	public static void FILLENIGNNA<T>(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2780970", Offset = "0x277F770", VA = "0x182780970")]
	public static void FILLENIGNNA<T>(Stream MKCMLPKFPPN, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2780A00", Offset = "0x277F800", VA = "0x182780A00")]
	public static void FILLENIGNNA<T>(Stream MKCMLPKFPPN, T NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x277EF40", Offset = "0x277DD40", VA = "0x18277EF40")]
	public static ArraySegment<byte> AEEDALEEAKK<T>(T NHLNHJGAONN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x277EFD0", Offset = "0x277DDD0", VA = "0x18277EFD0")]
	public static ArraySegment<byte> AEEDALEEAKK<T>(T NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2780D50", Offset = "0x277FB50", VA = "0x182780D50")]
	public static string KOGIOEDHOGC<T>(T NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2780DD0", Offset = "0x277FBD0", VA = "0x182780DD0")]
	public static string KOGIOEDHOGC<T>(T NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x277FCA0", Offset = "0x277EAA0", VA = "0x18277FCA0")]
	public static T CINNELLPCMC<T>(string DLLLAJJCCDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x277FBB0", Offset = "0x277E9B0", VA = "0x18277FBB0")]
	public static T CINNELLPCMC<T>(string DLLLAJJCCDH, MFKHLLCMIMF MMBMEGFLLJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27804A0", Offset = "0x277F2A0", VA = "0x1827804A0")]
	public static T CINNELLPCMC<T>(byte[] JAHCJGGEGHK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x277FB20", Offset = "0x277E920", VA = "0x18277FB20")]
	public static T CINNELLPCMC<T>(byte[] JAHCJGGEGHK, MFKHLLCMIMF MMBMEGFLLJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2780010", Offset = "0x277EE10", VA = "0x182780010")]
	public static T CINNELLPCMC<T>(byte[] JAHCJGGEGHK, int OOCJLKADJBK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x277FD30", Offset = "0x277EB30", VA = "0x18277FD30")]
	public static T CINNELLPCMC<T>(byte[] JAHCJGGEGHK, int OOCJLKADJBK, MFKHLLCMIMF MMBMEGFLLJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27800A0", Offset = "0x277EEA0", VA = "0x1827800A0")]
	public static T CINNELLPCMC<T>(GDGDHLJAODB FECOEFBKMHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x277FF40", Offset = "0x277ED40", VA = "0x18277FF40")]
	public static T CINNELLPCMC<T>(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF MMBMEGFLLJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2780520", Offset = "0x277F320", VA = "0x182780520")]
	public static T CINNELLPCMC<T>(Stream MKCMLPKFPPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27801F0", Offset = "0x277EFF0", VA = "0x1827801F0")]
	public static T CINNELLPCMC<T>(Stream MKCMLPKFPPN, MFKHLLCMIMF MMBMEGFLLJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68B51A0", Offset = "0x68B3FA0", VA = "0x1868B51A0")]
	public static string BIHIJJPLEOL(byte[] DLLLAJJCCDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68B5060", Offset = "0x68B3E60", VA = "0x1868B5060")]
	public static string BIHIJJPLEOL(byte[] DLLLAJJCCDH, int OOCJLKADJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68B5300", Offset = "0x68B4100", VA = "0x1868B5300")]
	public static string BIHIJJPLEOL(string DLLLAJJCCDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68B5490", Offset = "0x68B4290", VA = "0x1868B5490")]
	public static byte[] COEAACIBMHA(byte[] DLLLAJJCCDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68B57C0", Offset = "0x68B45C0", VA = "0x1868B57C0")]
	public static byte[] COEAACIBMHA(byte[] DLLLAJJCCDH, int OOCJLKADJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x68B5610", Offset = "0x68B4410", VA = "0x1868B5610")]
	public static byte[] COEAACIBMHA(string DLLLAJJCCDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x68B4790", Offset = "0x68B3590", VA = "0x1868B4790")]
	private static void BAIOMOBBMDJ(GDGDHLJAODB FECOEFBKMHD, JAENEBDBLKA HNIKDBEHAFP, int OCFGNBFHNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68B5AE0", Offset = "0x68B48E0", VA = "0x1868B5AE0")]
	private static int LCMDCAMBOBK(Stream ECKJJAACLOE, byte[] CDNPBOBHCMP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IHDMDINKMON : byte
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
public struct JAENEBDBLKA
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] FPNFDONIKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] CDNPBOBHCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int OOCJLKADJBK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OIGLCKHMHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x68AC430", Offset = "0x68AB230", VA = "0x1868AC430")]
	public void OHCFEDJLNEF(int OOCJLKADJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68B3120", Offset = "0x68B1F20", VA = "0x1868B3120")]
	public static byte[] JPFPNBGMIOC(string FEDBJFFPCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68B23D0", Offset = "0x68B11D0", VA = "0x1868B23D0")]
	public static byte[] AAMCMCEFOMA(string FEDBJFFPCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x68B2D70", Offset = "0x68B1B70", VA = "0x1868B2D70")]
	public static byte[] IGOLAGGNBIA(string FEDBJFFPCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x68B2F30", Offset = "0x68B1D30", VA = "0x1868B2F30")]
	public static byte[] IOIKNFJFKBK(string FEDBJFFPCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x54E28B0", Offset = "0x54E16B0", VA = "0x1854E28B0")]
	public JAENEBDBLKA(byte[] LBLJGIKABAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x68B2AF0", Offset = "0x68B18F0", VA = "0x1868B2AF0")]
	public ArraySegment<byte> CIKFBAMOFPI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68B2650", Offset = "0x68B1450", VA = "0x1868B2650")]
	public byte[] BJIGPGEBFNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x68B37E0", Offset = "0x68B25E0", VA = "0x1868B37E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x68B2C80", Offset = "0x68B1A80", VA = "0x1868B2C80")]
	public void FMNNOHFMJEL(int FGIKNLOFFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x68B2C20", Offset = "0x68B1A20", VA = "0x1868B2C20")]
	public void EDHBLLCHEOM(byte CKFIHLKODDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x68B2BC0", Offset = "0x68B19C0", VA = "0x1868B2BC0")]
	public void EDHBLLCHEOM(byte[] CKFIHLKODDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x68B3730", Offset = "0x68B2530", VA = "0x1868B3730")]
	public void OOODMLDEMEN(byte CKFIHLKODDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x68B25B0", Offset = "0x68B13B0", VA = "0x1868B25B0")]
	public void AEFBHMJJFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x68B32D0", Offset = "0x68B20D0", VA = "0x1868B32D0")]
	public void LLHFBMAOIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x68B2AA0", Offset = "0x68B18A0", VA = "0x1868B2AA0")]
	public void CDAJDLHEBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x68B2600", Offset = "0x68B1400", VA = "0x1868B2600")]
	public void AMNPJEONNIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x68B2EE0", Offset = "0x68B1CE0", VA = "0x1868B2EE0")]
	public void IMEFBDFNNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x68B26C0", Offset = "0x68B14C0", VA = "0x1868B26C0")]
	public void BJLJOBOKHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x68B3320", Offset = "0x68B2120", VA = "0x1868B3320")]
	public void MJFDAHNLHHB(string FEDBJFFPCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x68B3470", Offset = "0x68B2270", VA = "0x1868B3470")]
	public void OAFMAHNKGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x68B3620", Offset = "0x68B2420", VA = "0x1868B3620")]
	public void OELPOAEIIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x68B34C0", Offset = "0x68B22C0", VA = "0x1868B34C0")]
	public void OEHLAMGMALI(bool NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x68B33F0", Offset = "0x68B21F0", VA = "0x1868B33F0")]
	public void OAAFONEAIOD(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x68B3250", Offset = "0x68B2050", VA = "0x1868B3250")]
	public void KJHMNJJEACF(double NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x68B2D00", Offset = "0x68B1B00", VA = "0x1868B2D00")]
	public void IGNJDHJAOPE(byte NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x68B30B0", Offset = "0x68B1EB0", VA = "0x1868B30B0")]
	public void JHOKBKBIGFM(ushort NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68B2C90", Offset = "0x68B1A90", VA = "0x1868B2C90")]
	public void HMFFKIKLDGC(uint NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x68B2B90", Offset = "0x68B1990", VA = "0x1868B2B90")]
	public void CNBJNNPBNPD(ulong NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x68B36C0", Offset = "0x68B24C0", VA = "0x1868B36C0")]
	public void OLENHBOCLPB(sbyte NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x68B2540", Offset = "0x68B1340", VA = "0x1868B2540")]
	public void AAOLBPEEPGL(short NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x68B3770", Offset = "0x68B2570", VA = "0x1868B3770")]
	public void PGOBCDKFDND(int NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68B33C0", Offset = "0x68B21C0", VA = "0x1868B33C0")]
	public void MJNJBHFFIAP(long NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x68B2710", Offset = "0x68B1510", VA = "0x1868B2710")]
	public void BLLCIMPJGDD(string NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class PLFLPJDHMPC : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class BNBOANFGICG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x46B4F10", Offset = "0x46B3D10", VA = "0x1846B4F10")]
		static BNBOANFGICG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private PLFLPJDHMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JBEGFLKEOCN : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class DKCAELEKEBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4F48290", Offset = "0x4F47090", VA = "0x184F48290")]
		static DKCAELEKEBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class DIPOHDFGPEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> KHDJKLKGMBB;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68A4840", Offset = "0x68A3640", VA = "0x1868A4840")]
		internal static object JDAFGHEPMMH(Type GBMCNPIMCLE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private JBEGFLKEOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class ALIMFABMKJG : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class BDPHPJPAEOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x466F420", Offset = "0x466E220", VA = "0x18466F420")]
		static BDPHPJPAEOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly ALIMFABMKJG AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool AANGJEEMLLD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static MAFHFNECHNN[] KALLMLGOFJD;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static MFKHLLCMIMF[] MPBFKMLAHII;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private ALIMFABMKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x689BED0", Offset = "0x689ACD0", VA = "0x18689BED0")]
	public static void NLHDMBJLIGN(params MFKHLLCMIMF[] MPBFKMLAHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x689BFB0", Offset = "0x689ADB0", VA = "0x18689BFB0")]
	public static void NLHDMBJLIGN(params MAFHFNECHNN[] KALLMLGOFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x689BC40", Offset = "0x689AA40", VA = "0x18689BC40")]
	public static void JHPILKLEPHE(MAFHFNECHNN[] KALLMLGOFJD, MFKHLLCMIMF[] MPBFKMLAHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NNAHNFAEPPF : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class EGDCBNLEJGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x323F8B0", Offset = "0x323E6B0", VA = "0x18323F8B0")]
		static EGDCBNLEJGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private NNAHNFAEPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class JPFEJHGECEA
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly MFKHLLCMIMF IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly MFKHLLCMIMF NNEGLDKJLFE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly MFKHLLCMIMF BKCBJPBMDGG;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly MFKHLLCMIMF HIAKOBCIMNG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly MFKHLLCMIMF DPONIAHDHLC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly MFKHLLCMIMF KIPCGMJFOPF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly MFKHLLCMIMF BCLGNNJIIGB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly MFKHLLCMIMF PGFLAKJMLHC;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly MFKHLLCMIMF GDFDJJEKNEO;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly MFKHLLCMIMF NNLHOJOBHBN;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MFKHLLCMIMF FIAEDDPMNBJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly MFKHLLCMIMF EDPHAFFEEMG;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class FOCPCJHDCHI
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly MFKHLLCMIMF IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly MFKHLLCMIMF CBILCJJEKLE;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IHIFDIBKNGJ
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly MFKHLLCMIMF IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly MFKHLLCMIMF NNEGLDKJLFE;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly MFKHLLCMIMF BKCBJPBMDGG;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly MFKHLLCMIMF HIAKOBCIMNG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly MFKHLLCMIMF DPONIAHDHLC;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly MFKHLLCMIMF KIPCGMJFOPF;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly MFKHLLCMIMF BCLGNNJIIGB;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly MFKHLLCMIMF PGFLAKJMLHC;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly MFKHLLCMIMF GDFDJJEKNEO;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly MFKHLLCMIMF NNLHOJOBHBN;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly MFKHLLCMIMF FIAEDDPMNBJ;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly MFKHLLCMIMF EDPHAFFEEMG;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class HCHHCELNLKC
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> KHDJKLKGMBB;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x68AD330", Offset = "0x68AC130", VA = "0x1868AD330")]
	internal static object JDAFGHEPMMH(Type GBMCNPIMCLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x68AD2F0", Offset = "0x68AC0F0", VA = "0x1868AD2F0")]
	private static object HAOJIKPDIPD(Type IKPGECLBGFG, Type[] KPIEAKAPIFK, params object[] JGFJPKHAJJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class IMCFCDJFOJE : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class KPKMLLILJIO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3B19180", Offset = "0x3B17F80", VA = "0x183B19180")]
		static KPKMLLILJIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly EJAGAJBHPLO NLIBPBNJBGF;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x68B1090", Offset = "0x68AFE90", VA = "0x1868B1090")]
	static IMCFCDJFOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private IMCFCDJFOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class OFEPBKLHMML : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class EEAPBOPPOCM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3232220", Offset = "0x3231020", VA = "0x183232220")]
		static EEAPBOPPOCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly EJAGAJBHPLO NLIBPBNJBGF;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68B63F0", Offset = "0x68B51F0", VA = "0x1868B63F0")]
	static OFEPBKLHMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private OFEPBKLHMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class GDFIBNFKIFD : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class JEIPPKECKOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A250C0", Offset = "0x3A23EC0", VA = "0x183A250C0")]
		static JEIPPKECKOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly EJAGAJBHPLO NLIBPBNJBGF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68A9BE0", Offset = "0x68A89E0", VA = "0x1868A9BE0")]
	static GDFIBNFKIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private GDFIBNFKIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JBPOFMKMPEJ : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class APGPBKEAEJG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x373C490", Offset = "0x373B290", VA = "0x18373C490")]
		static APGPBKEAEJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly EJAGAJBHPLO NLIBPBNJBGF;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68B3930", Offset = "0x68B2730", VA = "0x1868B3930")]
	static JBPOFMKMPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private JBPOFMKMPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class OHEBMJCPCCC : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class KGDAENNPAGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3AA78D0", Offset = "0x3AA66D0", VA = "0x183AA78D0")]
		static KGDAENNPAGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly EJAGAJBHPLO NLIBPBNJBGF;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x68B6560", Offset = "0x68B5360", VA = "0x1868B6560")]
	static OHEBMJCPCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private OHEBMJCPCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class OPHOGHFOBMF : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class FIMEDLODOEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x35CEDC0", Offset = "0x35CDBC0", VA = "0x1835CEDC0")]
		static FIMEDLODOEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly EJAGAJBHPLO NLIBPBNJBGF;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x68B6830", Offset = "0x68B5630", VA = "0x1868B6830")]
	static OPHOGHFOBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private OPHOGHFOBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class BEFBEDPAAKO : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class MPPCDMGHDJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E05F10", Offset = "0x3E04D10", VA = "0x183E05F10")]
		static MPPCDMGHDJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public BEFBEDPAAKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class JKECEDPHEKO : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class ABMFGLNCLGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3665770", Offset = "0x3664570", VA = "0x183665770")]
		static ABMFGLNCLGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JKECEDPHEKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class MFJNADCHKCB : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class BDONFCINDNL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4666A60", Offset = "0x4665860", VA = "0x184666A60")]
		static BDONFCINDNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public MFJNADCHKCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class GHPMHGGHNGO : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class JIHLHLMNMHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A38B20", Offset = "0x3A37920", VA = "0x183A38B20")]
		static JIHLHLMNMHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public GHPMHGGHNGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class ADLLHODFMCE : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class JPGEICJPFIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A66CF0", Offset = "0x3A65AF0", VA = "0x183A66CF0")]
		static JPGEICJPFIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public ADLLHODFMCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class AHBLEEGKLGO : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class ENIMDHDPBDJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x325BAE0", Offset = "0x325A8E0", VA = "0x18325BAE0")]
		static ENIMDHDPBDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> NABKPMDLECF;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool EHIBLJCNLKL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public AHBLEEGKLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class BAFBEGIBFEM
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct ADAPCNFMBDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MIIAJNKAMBP MIAOKCOLCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder HOMAGFFAFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder BMBPLMHJIIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class HDACLAAJMFB
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class GBOEFIPPPOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo IGOLAGGNBIA;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo AAMCMCEFOMA;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo IOIKNFJFKBK;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo JPFPNBGMIOC;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo OELPOAEIIFG;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo EDHBLLCHEOM;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo CDAJDLHEBGO;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo AMNPJEONNIJ;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo IMEFBDFNNNM;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x68A8E30", Offset = "0x68A7C30", VA = "0x1868A8E30")]
			static GBOEFIPPPOG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class IPFBGBBOKAA
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo IHIOCLAEEDH;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo LKJCNELBDGF;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo IJJOLIPGGHK;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo LJKCOLAIPPN;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo JPDLACGBCOJ;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo GNCPHOACANC;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo ONNFMNPAACL;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x68B1810", Offset = "0x68B0610", VA = "0x1868B1810")]
			static IPFBGBBOKAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class IMOKBOLKBLK
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo MBGGNKAKBOP;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo DAPICNEPHGG;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo OIAJAKJAICI;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo MGBBBOLHNGA;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo BBEHGEJHIBP;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo DBFEFNLDNHD;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo BJAPHMJDFHH;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo KMFPBKHHDBL;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo IKBKBMAMHFM;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo AAGNMEOJMBL;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo DKBKNBPCCLC;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo IHEMMGKGEGD;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo MLLDCAPNDGK;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo FPKPAFLJJDD;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x68AF220", Offset = "0x68AE020", VA = "0x1868AF220")]
		public static MethodInfo FILLENIGNNA(Type HFFNCGFKMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68AEFE0", Offset = "0x68ADDE0", VA = "0x1868AEFE0")]
		public static MethodInfo CINNELLPCMC(Type HFFNCGFKMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x68AF4B0", Offset = "0x68AE2B0", VA = "0x1868AF4B0")]
		public static MethodInfo IIKLNPOIJDJ(Type HFFNCGFKMBJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class DGLJHDBPDLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<MIIAJNKAMBP, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DGLJHDBPDLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class EGNIMINCFOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public DGLJHDBPDLN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EGNIMINCFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x68A6930", Offset = "0x68A5730", VA = "0x1868A6930")]
		internal void FKIPIEBKPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x68A6890", Offset = "0x68A5690", VA = "0x1868A6890")]
		internal bool BEGKADEJGJI(int index, MIIAJNKAMBP member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IOBJACDHJNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public DGLJHDBPDLN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IOBJACDHJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68B1770", Offset = "0x68B0570", VA = "0x1868B1770")]
		internal bool GBKMOGICKCE(int index, MIIAJNKAMBP member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class KDCAMLKNDLG
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
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public KDCAMLKNDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC8C0", Offset = "0x3DDB6C0", VA = "0x183DDC8C0")]
		internal string JPCBMNKIFLB(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BMNLKILPBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public BMNLKILPBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68A4700", Offset = "0x68A3500", VA = "0x1868A4700")]
		internal bool PIEEKNKEMPE(MIIAJNKAMBP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ELGOLHJEEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public KDCAMLKNDLG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ELGOLHJEEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x68A6AF0", Offset = "0x68A58F0", VA = "0x1868A6AF0")]
		internal void LEIIIGKKDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x68A6970", Offset = "0x68A5770", VA = "0x1868A6970")]
		internal bool ACCFIIADNNP(int index, MIIAJNKAMBP member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class EGDEFOOOFOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public KDCAMLKNDLG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EGDEFOOOFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x68A6710", Offset = "0x68A5510", VA = "0x1868A6710")]
		internal bool IBDKPHDFIMJ(int index, MIIAJNKAMBP member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class MMKIIDMEDCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MMKIIDMEDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68B6200", Offset = "0x68B5000", VA = "0x1868B6200")]
		internal Label BNIHJNJCJIK(MIIAJNKAMBP _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class MIMEAFLPBLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public ADAPCNFMBDO[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, MIIAJNKAMBP, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public ACJKNIBDLMB argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public ACJKNIBDLMB argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MIMEAFLPBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x68B60E0", Offset = "0x68B4EE0", VA = "0x1868B60E0")]
		internal ADAPCNFMBDO MAEKANEELDM(MIIAJNKAMBP item)
		{
			return default(ADAPCNFMBDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ENLJOGDHGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public MIMEAFLPBLC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ENLJOGDHGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x68A6BA0", Offset = "0x68A59A0", VA = "0x1868A6BA0")]
		internal void ODHBFPIPGFB(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x68A6B00", Offset = "0x68A5900", VA = "0x1868A6B00")]
		internal void FDMLPGGBCHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class ONLCPCJDPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public MIIAJNKAMBP item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ONLCPCJDPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB49B50", Offset = "0xB48950", VA = "0x180B49B50")]
		internal bool DJBKPGCOKPK(ADAPCNFMBDO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class CHKKJOGEDLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public MIIAJNKAMBP item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CHKKJOGEDLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB49B50", Offset = "0xB48950", VA = "0x180B49B50")]
		internal bool FMKOOEGGAGO(ADAPCNFMBDO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex AKKEFJCGIFP;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int BIKNALFJELA;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> PJMPNMCLHFN;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> MJHGBLDEFBL;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x24D57F0", Offset = "0x24D45F0", VA = "0x1824D57F0")]
	public static object DKKGKLMINEG<T>(EJAGAJBHPLO NLIBPBNJBGF, MFKHLLCMIMF GPJGDCDPEMH, Func<string, string> NABKPMDLECF, bool EHIBLJCNLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x24DE810", Offset = "0x24DD610", VA = "0x1824DE810")]
	public static object HLLLGGIMOME<T>(MFKHLLCMIMF GPJGDCDPEMH, Func<string, string> NABKPMDLECF, bool EHIBLJCNLKL, bool IGIHBJHPHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x689DAC0", Offset = "0x689C8C0", VA = "0x18689DAC0")]
	private static TypeInfo EPAJIMMEOFN(EJAGAJBHPLO NLIBPBNJBGF, Type HFFNCGFKMBJ, Func<string, string> NABKPMDLECF, bool EHIBLJCNLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x689F270", Offset = "0x689E070", VA = "0x18689F270")]
	public static object IOIFPKJHMDE(Type HFFNCGFKMBJ, Func<string, string> NABKPMDLECF, bool EHIBLJCNLKL, bool IGIHBJHPHCB, bool ONJIPBHCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x68A3180", Offset = "0x68A1F80", VA = "0x1868A3180")]
	private static Dictionary<MIIAJNKAMBP, FieldInfo> OBNMJCNHFLI(TypeBuilder HIPEGNMLNMG, MOCOMADGEPC LINKNNNEGKJ, ConstructorInfo NLCJLEOLBHL, FieldBuilder MJKLMOGDEAJ, ILGenerator AOHJIEFACJL, bool EHIBLJCNLKL, bool GCCHLFKJMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x68A0DA0", Offset = "0x689FBA0", VA = "0x1868A0DA0")]
	private static Dictionary<MIIAJNKAMBP, FieldInfo> JCKHAHMLAOD(TypeBuilder HIPEGNMLNMG, MOCOMADGEPC LINKNNNEGKJ, ILGenerator AOHJIEFACJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x68A1480", Offset = "0x68A0280", VA = "0x1868A1480")]
	private static void KILDOHEDMHI(Type HFFNCGFKMBJ, MOCOMADGEPC LINKNNNEGKJ, ILGenerator AOHJIEFACJL, Action LPMIDJMADAL, Func<int, MIIAJNKAMBP, bool> CFNJOALGMGH, bool EHIBLJCNLKL, bool GCCHLFKJMGL, int AEHMDFGCGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x68A2C40", Offset = "0x68A1A40", VA = "0x1868A2C40")]
	private static void LONAKNAHAOJ(TypeInfo HFFNCGFKMBJ, MIIAJNKAMBP FDBBPCJFNFK, ILGenerator AOHJIEFACJL, int ENPOKNEMOMH, Func<int, MIIAJNKAMBP, bool> CFNJOALGMGH, ACJKNIBDLMB HNIKDBEHAFP, ACJKNIBDLMB MCDICIECHHF, ACJKNIBDLMB AGKHMPPAEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x689C1B0", Offset = "0x689AFB0", VA = "0x18689C1B0")]
	private static void ACOEBPICOCN(Type HFFNCGFKMBJ, MOCOMADGEPC LINKNNNEGKJ, ILGenerator AOHJIEFACJL, Func<int, MIIAJNKAMBP, bool> CFNJOALGMGH, bool LNAGGKEIEIC, int AEHMDFGCGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x689D650", Offset = "0x689C450", VA = "0x18689D650")]
	private static void EBPANKLGNLD(ILGenerator AOHJIEFACJL, ADAPCNFMBDO LINKNNNEGKJ, int ENPOKNEMOMH, Func<int, MIIAJNKAMBP, bool> CFNJOALGMGH, ACJKNIBDLMB FECOEFBKMHD, ACJKNIBDLMB AGKHMPPAEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x689E4E0", Offset = "0x689D2E0", VA = "0x18689E4E0")]
	private static LocalBuilder HDMLPLPDILA(ILGenerator AOHJIEFACJL, Type HFFNCGFKMBJ, MOCOMADGEPC LINKNNNEGKJ, ADAPCNFMBDO[] PHFBNFMANFA, bool DIFJIAOGJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x68A38B0", Offset = "0x68A26B0", VA = "0x1868A38B0")]
	private static bool OLKIEDDPOOH(ConstructorInfo HBKLBPOJCGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x68A2AC0", Offset = "0x68A18C0", VA = "0x1868A2AC0")]
	private static bool LCBMPODMDMJ(Type HFFNCGFKMBJ, [Out] Type BJACMMKGGHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void JHKKLMMLOEP<T>(byte[][] MJKLMOGDEAJ, object[] JJHKOHAHNBD, JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF MMBMEGFLLJC);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T KCPCHIMCBDB<T>(object[] JJHKOHAHNBD, GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF MMBMEGFLLJC);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class JPACCLNHAJJ<T> : FMHIBLCEFCM<T>, MAFHFNECHNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] MJKLMOGDEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] GEFDEFNFDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] DNAJAMPOGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly JHKKLMMLOEP<T> JPGELOMJBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly KCPCHIMCBDB<T> JECALFMPKFL;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D720", Offset = "0x1D5C520", VA = "0x181D5D720")]
	public JPACCLNHAJJ(byte[][] MJKLMOGDEAJ, object[] GEFDEFNFDIA, object[] DNAJAMPOGDN, JHKKLMMLOEP<T> JPGELOMJBIH, KCPCHIMCBDB<T> JECALFMPKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3A62AE0", Offset = "0x3A618E0", VA = "0x183A62AE0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3A629F0", Offset = "0x3A617F0", VA = "0x183A629F0", Slot = "5")]
	public T CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class JJOCLHHBKMF : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class NOBKDNEGJGD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E92990", Offset = "0x3E91790", VA = "0x183E92990")]
		static NOBKDNEGJGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private JJOCLHHBKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class COKJNHMFOOA : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class LNHKIIBMMDN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3C20730", Offset = "0x3C1F530", VA = "0x183C20730")]
		static LNHKIIBMMDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private COKJNHMFOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class KADFDBCGGMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly MFKHLLCMIMF[] FMAABNMNGPC;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class ACHOJCBAPEA : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class FFHCFPPLCKF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x35C75D0", Offset = "0x35C63D0", VA = "0x1835C75D0")]
		static FFHCFPPLCKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class FHJKPMLCKHG : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class IKLKGCHBLFA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x38680C0", Offset = "0x3866EC0", VA = "0x1838680C0")]
			static IKLKGCHBLFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private FHJKPMLCKHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private ACHOJCBAPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class MHEBGGGIBAA : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class DEEEMFOLBNJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4F28AE0", Offset = "0x4F278E0", VA = "0x184F28AE0")]
		static DEEEMFOLBNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class EKHEHMHIDOC : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class NBAFBAFFLLG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3E4AF20", Offset = "0x3E49D20", VA = "0x183E4AF20")]
			static NBAFBAFFLLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private EKHEHMHIDOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private MHEBGGGIBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class OJAHIIBBNFC : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class JBHBNAAMEFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3A19B60", Offset = "0x3A18960", VA = "0x183A19B60")]
		static JBHBNAAMEFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class OGOFOMMELPL : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class NFFNJNIACLA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3E68440", Offset = "0x3E67240", VA = "0x183E68440")]
			static NFFNJNIACLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private OGOFOMMELPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private OJAHIIBBNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class FGFBBHBHJIB : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class MGPNAIPCOKG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3F30", Offset = "0x3DE2D30", VA = "0x183DE3F30")]
		static MGPNAIPCOKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class AIJPLGGGMAH : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class GIAGGPJKOKD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x36C08B0", Offset = "0x36BF6B0", VA = "0x1836C08B0")]
			static GIAGGPJKOKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private AIJPLGGGMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private FGFBBHBHJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class EGOHEBDFPOJ : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class GFCAKEKONFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x36930A0", Offset = "0x3691EA0", VA = "0x1836930A0")]
		static GFCAKEKONFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class GMPOHENKJKA : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class IGMGKOILPHG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x384D770", Offset = "0x384C570", VA = "0x18384D770")]
			static IGMGKOILPHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private GMPOHENKJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private EGOHEBDFPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class ANHGPJMMPAA : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class OMKJKAOILDO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EBB0", Offset = "0x3F7D9B0", VA = "0x183F7EBB0")]
		static OMKJKAOILDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class JECJOAJNIDC : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class HKHJFAHCDEF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x37A5EB0", Offset = "0x37A4CB0", VA = "0x1837A5EB0")]
			static HKHJFAHCDEF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private JECJOAJNIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private ANHGPJMMPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class IKBNLLPHCFK : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class KKHKFHPDMDJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD12A0", Offset = "0x3AD00A0", VA = "0x183AD12A0")]
		static KKHKFHPDMDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class AMGNAFBIPPL : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class KCNJBNKAEBH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3A9DF30", Offset = "0x3A9CD30", VA = "0x183A9DF30")]
			static KCNJBNKAEBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private AMGNAFBIPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private IKBNLLPHCFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class AEFMMIHLBEA : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class ELCBOLJEDHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x324FBE0", Offset = "0x324E9E0", VA = "0x18324FBE0")]
		static ELCBOLJEDHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class GPFKKEOCMNL : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class BLGBJPBBOJF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x46AED20", Offset = "0x46ADB20", VA = "0x1846AED20")]
			static BLGBJPBBOJF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private GPFKKEOCMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private AEFMMIHLBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class PPNEGIMKMIL : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class NNHLBIIDLLL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D640", Offset = "0x3E7C440", VA = "0x183E7D640")]
		static NNHLBIIDLLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class FLMCPHKGENL : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class MNHKBNJFIME<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3DFD140", Offset = "0x3DFBF40", VA = "0x183DFD140")]
			static MNHKBNJFIME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private FLMCPHKGENL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private PPNEGIMKMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class CAAFDOCILEB : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class NCJNLNEEEMD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3E598F0", Offset = "0x3E586F0", VA = "0x183E598F0")]
		static NCJNLNEEEMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class FPDNIAPCGPA : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class HBPIPHLBCNO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3706290", Offset = "0x3705090", VA = "0x183706290")]
			static HBPIPHLBCNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private FPDNIAPCGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private CAAFDOCILEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class FEJIBBHLPFG : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class GFKJMPKPOMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x369E630", Offset = "0x369D430", VA = "0x18369E630")]
		static GFKJMPKPOMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class MAANEIMMLOO : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class EPLNAPMAFLK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3271940", Offset = "0x3270740", VA = "0x183271940")]
			static EPLNAPMAFLK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private MAANEIMMLOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private FEJIBBHLPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class OOBIDLBJMEH : MFKHLLCMIMF
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class EDDOKNAINBJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x322AE70", Offset = "0x3229C70", VA = "0x18322AE70")]
		static EDDOKNAINBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class OIIDOCFIOJA : MFKHLLCMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class NELFIGNJGFH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly FMHIBLCEFCM<T> OBBEEFPLHMN;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3E667F0", Offset = "0x3E655F0", VA = "0x183E667F0")]
			static NELFIGNJGFH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly MFKHLLCMIMF AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly MFKHLLCMIMF[] MPBFKMLAHII;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private OIIDOCFIOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
		public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly MFKHLLCMIMF AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly FMHIBLCEFCM<object> CKEDBGIHFIB;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	private OOBIDLBJMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	public FMHIBLCEFCM<T> JDAFGHEPMMH<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct NAINONDNJOP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] CLLDLCLJCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int MLMGACONFEP;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E46600", Offset = "0x3E45400", VA = "0x183E46600")]
	public NAINONDNJOP(int MODMJFMHILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E46200", Offset = "0x3E45000", VA = "0x183E46200")]
	public void ANMBPKAMKOK(T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E46570", Offset = "0x3E45370", VA = "0x183E46570")]
	public T[] BBENHIAJFCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class PIMPBGEACDF : LOFOKEEOCIG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly PIMPBGEACDF IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x68CDCD0", Offset = "0x68CCAD0", VA = "0x1868CDCD0")]
	public PIMPBGEACDF(int PFEINGBIKHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class LOFOKEEOCIG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int PFEINGBIKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object AHLIKLLBELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int ENPOKNEMOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] FDJEFGHFINC;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BF00", Offset = "0x3C2AD00", VA = "0x183C2BF00")]
	public LOFOKEEOCIG(int PFEINGBIKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BC00", Offset = "0x3C2AA00", VA = "0x183C2BC00")]
	public T[] IFBEGNAHMLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BA80", Offset = "0x3C2A880", VA = "0x183C2BA80")]
	public void CIEPIHMPBAG(T[] AAKJIOEDOGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class LOBIPGHMALA : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class GABMOGAEHDG : IComparable<GABMOGAEHDG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class DIGKHPMPDMM : IEnumerable<GABMOGAEHDG>, IEnumerable, IEnumerator<GABMOGAEHDG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private GABMOGAEHDG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public GABMOGAEHDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private GABMOGAEHDG System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
			[DebuggerHidden]
			public DIGKHPMPDMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x68BD890", Offset = "0x68BC690", VA = "0x1868BD890", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x68BD9C0", Offset = "0x68BC7C0", VA = "0x1868BD9C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x68BD910", Offset = "0x68BC710", VA = "0x1868BD910", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GABMOGAEHDG> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x68BD910", Offset = "0x68BC710", VA = "0x1868BD910", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class IMGHBLGNOEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public IMGHBLGNOEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x68B6200", Offset = "0x68B5000", VA = "0x1868B6200")]
			internal Label EJOGMKCGIJB(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x68B6200", Offset = "0x68B5000", VA = "0x1868B6200")]
			internal Label HBGBNDGNPGB(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly GABMOGAEHDG[] FJPIJCNLLPN;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] OJLMBOENOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong DIJJAKBLGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int DFPHMDCMPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string OIBJHIGOIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private GABMOGAEHDG[] HFNMPCLMADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] OAEIHDENELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int BPFMGMBDOBA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool LAGOCLCFLIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x52095D0", Offset = "0x52083D0", VA = "0x1852095D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x68C1F30", Offset = "0x68C0D30", VA = "0x1868C1F30")]
		public GABMOGAEHDG(ulong JCMGBFKGKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x68C09F0", Offset = "0x68BF7F0", VA = "0x1868C09F0")]
		public GABMOGAEHDG ANMBPKAMKOK(ulong JCMGBFKGKLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x68C0990", Offset = "0x68BF790", VA = "0x1868C0990")]
		public GABMOGAEHDG ANMBPKAMKOK(ulong JCMGBFKGKLO, int NKKIECLCEML, string OIBJHIGOIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x68C0C20", Offset = "0x68BFA20", VA = "0x1868C0C20")]
		public GABMOGAEHDG EOOLNKIJKEB(byte[] KADGOLMMJFK, int OOCJLKADJBK, int EGLKHBBMJPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x68C0900", Offset = "0x68BF700", VA = "0x1868C0900")]
		internal static int ACDEMADABHD(ulong[] AAKJIOEDOGA, int ENPOKNEMOMH, int FAPCCJLFBAA, ulong NKKIECLCEML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x68C0BF0", Offset = "0x68BF9F0", VA = "0x1868C0BF0", Slot = "4")]
		public int CompareTo(GABMOGAEHDG FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x68C1E00", Offset = "0x68C0C00", VA = "0x1868C1E00")]
		[IteratorStateMachine(typeof(DIGKHPMPDMM))]
		public IEnumerable<GABMOGAEHDG> KJOPIEBBKHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x68C0DA0", Offset = "0x68BFBA0", VA = "0x1868C0DA0")]
		public void EOPCGDKDALN(ILGenerator AOHJIEFACJL, LocalBuilder KADGOLMMJFK, LocalBuilder EGLKHBBMJPO, LocalBuilder JCMGBFKGKLO, Action<KeyValuePair<string, int>> BKCDLBHJCFH, Action OCNOMLMONDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x68C1120", Offset = "0x68BFF20", VA = "0x1868C1120")]
		private static void IOLONEOJEPE(ILGenerator AOHJIEFACJL, LocalBuilder KADGOLMMJFK, LocalBuilder EGLKHBBMJPO, LocalBuilder JCMGBFKGKLO, Action<KeyValuePair<string, int>> BKCDLBHJCFH, Action OCNOMLMONDB, GABMOGAEHDG[] HFNMPCLMADN, int BPFMGMBDOBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class AMFLIMHIOHO : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<GABMOGAEHDG> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<GABMOGAEHDG> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<GABMOGAEHDG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private GABMOGAEHDG <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA34F00", Offset = "0xA33D00", VA = "0x180A34F00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x68B7EC0", Offset = "0x68B6CC0", VA = "0x1868B7EC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1C7D340", Offset = "0x1C7C140", VA = "0x181C7D340")]
		[DebuggerHidden]
		public AMFLIMHIOHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x68B7F10", Offset = "0x68B6D10", VA = "0x1868B7F10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x68B7910", Offset = "0x68B6710", VA = "0x1868B7910", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x68B7D70", Offset = "0x68B6B70", VA = "0x1868B7D70")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x68B78C0", Offset = "0x68B66C0", VA = "0x1868B78C0")]
		private void AGDCIDILFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x68B7E70", Offset = "0x68B6C70", VA = "0x1868B7E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x68B7DC0", Offset = "0x68B6BC0", VA = "0x1868B7DC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x68B7DC0", Offset = "0x68B6BC0", VA = "0x1868B7DC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly GABMOGAEHDG ADCDJFADKCK;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x68C5390", Offset = "0x68C4190", VA = "0x1868C5390")]
	public LOBIPGHMALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x68C4D20", Offset = "0x68C3B20", VA = "0x1868C4D20")]
	public void ANMBPKAMKOK(byte[] JAHCJGGEGHK, int NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x68C4EE0", Offset = "0x68C3CE0", VA = "0x1868C4EE0")]
	public bool FMMGAEFAENP(ArraySegment<byte> JCMGBFKGKLO, [Out] int NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x68C5300", Offset = "0x68C4100", VA = "0x1868C5300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x68C5020", Offset = "0x68C3E20", VA = "0x1868C5020")]
	private static void OPDALBEIBGH(IEnumerable<GABMOGAEHDG> HFNMPCLMADN, StringBuilder KODDMLAGOPL, int OCFGNBFHNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x68C4FC0", Offset = "0x68C3DC0", VA = "0x1868C4FC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x68C4FC0", Offset = "0x68C3DC0", VA = "0x1868C4FC0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x68C4E30", Offset = "0x68C3C30", VA = "0x1868C4E30")]
	[IteratorStateMachine(typeof(AMFLIMHIOHO))]
	private static IEnumerable<KeyValuePair<string, int>> BACOKBFHKEC(IEnumerable<GABMOGAEHDG> HFNMPCLMADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x68C4EB0", Offset = "0x68C3CB0", VA = "0x1868C4EB0")]
	public void CDPOHBONAKC(ILGenerator AOHJIEFACJL, LocalBuilder KADGOLMMJFK, LocalBuilder EGLKHBBMJPO, LocalBuilder JCMGBFKGKLO, Action<KeyValuePair<string, int>> BKCDLBHJCFH, Action OCNOMLMONDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class MKFCBPBBOJO
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo MMGEMBFDKBP;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x68C8060", Offset = "0x68C6E60", VA = "0x1868C8060")]
	public static ulong NCFFBAIAEHM(byte[] JAHCJGGEGHK, int OOCJLKADJBK, int EGLKHBBMJPO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class OPGHHJCDMOL
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x68CD190", Offset = "0x68CBF90", VA = "0x1868CD190")]
	public static void FMNNOHFMJEL(byte[] JAHCJGGEGHK, int OOCJLKADJBK, int FGIKNLOFFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x68CD400", Offset = "0x68CC200", VA = "0x1868CD400")]
	public static void ONJCMKEGICM(byte[] AAKJIOEDOGA, int LLIGBPJDKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x68CD2D0", Offset = "0x68CC0D0", VA = "0x1868CD2D0")]
	public static byte[] OADFGFLOMNA(byte[] HAMFKMJEGLE, int LLIGBPJDKPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class POJLNBJFAPM
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x68CDD20", Offset = "0x68CCB20", VA = "0x1868CDD20")]
	public static bool EALKKOJBCNP(byte[] JFLILKKFEHN, int FJILIKPKNJM, int ICHKMDKOPGJ, byte[] LOFPLEAEPEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class OJGEMOLIKDK<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct NNJOJBLHGLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] DIJJAKBLGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T DFPHMDCMPIO;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E88E10", Offset = "0x3E87C10", VA = "0x183E88E10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class PDDIDJGCHKD : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public OJGEMOLIKDK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private NNJOJBLHGLN[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NNJOJBLHGLN[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA34F00", Offset = "0xA33D00", VA = "0x180A34F00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x362BAD0", Offset = "0x362A8D0", VA = "0x18362BAD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public PDDIDJGCHKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4015080", Offset = "0x4013E80", VA = "0x184015080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4015410", Offset = "0x4014210", VA = "0x184015410", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly NNJOJBLHGLN[][] LNAGANLONLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong HCLMILIBIFI;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F72F80", Offset = "0x3F71D80", VA = "0x183F72F80")]
	public OJGEMOLIKDK(int BKPALGGNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3F72EC0", Offset = "0x3F71CC0", VA = "0x183F72EC0")]
	public OJGEMOLIKDK(int BKPALGGNBEN, float OKKDNBHJDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3F6B560", Offset = "0x3F6A360", VA = "0x183F6B560")]
	public void ANMBPKAMKOK(byte[] JCMGBFKGKLO, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E3F0", Offset = "0x3F6D1F0", VA = "0x183F6E3F0")]
	private bool GCEHFAKBGHG(byte[] JCMGBFKGKLO, T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3F70E40", Offset = "0x3F6FC40", VA = "0x183F70E40")]
	public bool GNMCOJGNPDP(ArraySegment<byte> JCMGBFKGKLO, [Out] T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3F72E70", Offset = "0x3F71C70", VA = "0x183F72E70")]
	private static ulong IDEFKPGAFJH(byte[] AHPBAINPGNA, int OOCJLKADJBK, int BPFMGMBDOBA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x37A25A0", Offset = "0x37A13A0", VA = "0x1837A25A0")]
	private static int DGBKFMAMPKO(int AEBFGNNOBAK, float OKKDNBHJDFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3F72CC0", Offset = "0x3F71AC0", VA = "0x183F72CC0", Slot = "4")]
	[IteratorStateMachine(typeof(OJGEMOLIKDK<>.PDDIDJGCHKD))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x34E4AD0", Offset = "0x34E38D0", VA = "0x1834E4AD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class NEPABKMKKMO : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] FCALPGFGLKI;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] JGLPFBEOKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int EPIMODMEGPL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OJHNIFDHCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x68CA220", Offset = "0x68C9020", VA = "0x1868CA220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68CA370", Offset = "0x68C9170", VA = "0x1868CA370")]
	static NEPABKMKKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x68CA5D0", Offset = "0x68C93D0", VA = "0x1868CA5D0")]
	public NEPABKMKKMO(byte[] IDGFLLKBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x68CA270", Offset = "0x68C9070", VA = "0x1868CA270")]
	public OpCode HIGFLKHPNKJ()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct DFDEMDGNDGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid DFPHMDCMPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte JADODIDEFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte ALFGLPBGJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte ENCCEHOONKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte LIKAPNOIPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte FHMPOLPAMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte JLAPPBPPKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte KDFBJPCINBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte FJCIINPALBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte KLLJIBMOJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte CBPPCAABMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte ANPBNCHPNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte IDOMKOLKJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte BIFOHBPACDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte GPCMNOHHBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte DGDMOJPIGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte HLGCLPJGCPI;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] MGEJICANEPG;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] KCJEFOBBAID;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x68BC130", Offset = "0x68BAF30", VA = "0x1868BC130")]
	public DFDEMDGNDGM(Guid NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x68BC140", Offset = "0x68BAF40", VA = "0x1868BC140")]
	public DFDEMDGNDGM(ArraySegment<byte> AAALCGDBLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x68BBFA0", Offset = "0x68BADA0", VA = "0x1868BBFA0")]
	private static byte KNILPAIBOFM(byte[] JAHCJGGEGHK, int NBLFHJOJNKG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x68BB1D0", Offset = "0x68B9FD0", VA = "0x1868BB1D0")]
	private static byte IGIFGCONLMI(byte LGCDJBDIEJC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x68BB2F0", Offset = "0x68BA0F0", VA = "0x1868BB2F0")]
	public void KIKABBCJOMK(byte[] CDNPBOBHCMP, int OOCJLKADJBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class OAOPLMPNEGG
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x68CB960", Offset = "0x68CA760", VA = "0x1868CB960")]
	public static bool HKEEDNLAPNJ(byte JJJKOMKEIGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x68CAD70", Offset = "0x68C9B70", VA = "0x1868CAD70")]
	public static bool APAALHLMEIB(byte JJJKOMKEIGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x68CC6D0", Offset = "0x68CB4D0", VA = "0x1868CC6D0")]
	public static sbyte OKDKFEFHIJN(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x68CB640", Offset = "0x68CA440", VA = "0x1868CB640")]
	public static short HAHGKMGPFFC(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x68CC540", Offset = "0x68CB340", VA = "0x1868CC540")]
	public static int OIHFGCBJELC(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x68CC630", Offset = "0x68CB430", VA = "0x1868CC630")]
	public static long OJMBCCDCBMO(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x68CC4C0", Offset = "0x68CB2C0", VA = "0x1868CC4C0")]
	public static byte NNGMIIEDHEH(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x68CC7B0", Offset = "0x68CB5B0", VA = "0x1868CC7B0")]
	public static ushort PDCLELAAAFB(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x68CB970", Offset = "0x68CA770", VA = "0x1868CB970")]
	public static uint IKKHIIIPPBD(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x68CC3B0", Offset = "0x68CB1B0", VA = "0x1868CC3B0")]
	public static ulong NFDIGDMAKCL(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x68CB560", Offset = "0x68CA360", VA = "0x1868CB560")]
	public static float EOJCJEBOEKI(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x68CB480", Offset = "0x68CA280", VA = "0x1868CB480")]
	public static double EFLFCPELFGH(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x68CADE0", Offset = "0x68C9BE0", VA = "0x1868CADE0")]
	public static int CNBJNNPBNPD(byte[] CDNPBOBHCMP, int OOCJLKADJBK, ulong NKKIECLCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x68CB9F0", Offset = "0x68CA7F0", VA = "0x1868CB9F0")]
	public static int MJNJBHFFIAP(byte[] CDNPBOBHCMP, int OOCJLKADJBK, long NKKIECLCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x68CB730", Offset = "0x68CA530", VA = "0x1868CB730")]
	public static bool HANLEIOADCD(byte[] JAHCJGGEGHK, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class EJMMBFPKCME
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NKGJANNGACM : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public NKGJANNGACM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x68CAC40", Offset = "0x68C9A40", VA = "0x1868CAC40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x68CA6B0", Offset = "0x68C94B0", VA = "0x1868CA6B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x68CAAE0", Offset = "0x68C98E0", VA = "0x1868CAAE0")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x68CA660", Offset = "0x68C9460", VA = "0x1868CA660")]
		private void AGDCIDILFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x68CABF0", Offset = "0x68C99F0", VA = "0x1868CABF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x68CAB30", Offset = "0x68C9930", VA = "0x1868CAB30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x68CAB30", Offset = "0x68C9930", VA = "0x1868CAB30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class PHGGAEFNIMC : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public PHGGAEFNIMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x68CDB00", Offset = "0x68CC900", VA = "0x1868CDB00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x68CD570", Offset = "0x68CC370", VA = "0x1868CD570", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x68CD9A0", Offset = "0x68CC7A0", VA = "0x1868CD9A0")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x68CD520", Offset = "0x68CC320", VA = "0x1868CD520")]
		private void AGDCIDILFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x68CDAB0", Offset = "0x68CC8B0", VA = "0x1868CDAB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x68CD9F0", Offset = "0x68CC7F0", VA = "0x1868CD9F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x68CD9F0", Offset = "0x68CC7F0", VA = "0x1868CD9F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x68BEBE0", Offset = "0x68BD9E0", VA = "0x1868BEBE0")]
	public static bool IAPOENLDCNL(this TypeInfo HFFNCGFKMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x68BEAB0", Offset = "0x68BD8B0", VA = "0x1868BEAB0")]
	public static bool CLFJPLMIELH(this TypeInfo HFFNCGFKMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x68BEA30", Offset = "0x68BD830", VA = "0x1868BEA30")]
	public static IEnumerable<PropertyInfo> BGMGLLNFJGC(this Type HFFNCGFKMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x68BED20", Offset = "0x68BDB20", VA = "0x1868BED20")]
	[IteratorStateMachine(typeof(NKGJANNGACM))]
	private static IEnumerable<PropertyInfo> LHNOKAFOJLC(Type HFFNCGFKMBJ, HashSet<string> HBMHHGMMKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x68BECA0", Offset = "0x68BDAA0", VA = "0x1868BECA0")]
	public static IEnumerable<FieldInfo> KHNOIPDBGJE(this Type HFFNCGFKMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x68BEDC0", Offset = "0x68BDBC0", VA = "0x1868BEDC0")]
	[IteratorStateMachine(typeof(PHGGAEFNIMC))]
	private static IEnumerable<FieldInfo> PICBBFIKNAF(Type HFFNCGFKMBJ, HashSet<string> HBMHHGMMKHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class JIBCKPHJOEL
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding PAEKCJPPOJB;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class IMMACEKALJC
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static string ABEDJIPFMFF(string GONJIKGEFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x68C46C0", Offset = "0x68C34C0", VA = "0x1868C46C0")]
	public static string GADIBCODCDC(string GONJIKGEFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x68C4530", Offset = "0x68C3330", VA = "0x1868C4530")]
	public static string FIEHPBEGEGB(string GONJIKGEFGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class HJNOGLODLJN<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class EICLEANOAKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type DIJJAKBLGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue DFPHMDCMPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int EHCFMDFCPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public EICLEANOAKM HPALBOJMJAD;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x324A630", Offset = "0x3249430", VA = "0x18324A630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x324A4E0", Offset = "0x32492E0", VA = "0x18324A4E0")]
		private int DDMEKBICEFI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EICLEANOAKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class IFGMNHACJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IFGMNHACJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB6E440", Offset = "0xB6D240", VA = "0x180B6E440")]
		internal TValue JFEPOAPMLLJ(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private EICLEANOAKM[] LNAGANLONLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int DDGPJFNNFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object FEGJABMGAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float OKKDNBHJDFO;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x37A30B0", Offset = "0x37A1EB0", VA = "0x1837A30B0")]
	public HJNOGLODLJN(int BKPALGGNBEN = 4, float OKKDNBHJDFO = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x37A2F80", Offset = "0x37A1D80", VA = "0x1837A2F80")]
	public bool OEADEOBEAEM(Type JCMGBFKGKLO, TValue NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x37A2F40", Offset = "0x37A1D40", VA = "0x1837A2F40")]
	public bool OEADEOBEAEM(Type JCMGBFKGKLO, Func<Type, TValue> PPGIHHECDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x37A29F0", Offset = "0x37A17F0", VA = "0x1837A29F0")]
	private bool GCEHFAKBGHG(Type JCMGBFKGKLO, Func<Type, TValue> PPGIHHECDOF, [Out] TValue JAMGFCFHNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x37A2600", Offset = "0x37A1400", VA = "0x1837A2600")]
	private bool FLDCONLHEKD(EICLEANOAKM[] LNAGANLONLN, Type BBHHJMHDAAP, EICLEANOAKM LOBPOMOHBPL, Func<Type, TValue> PPGIHHECDOF, [Out] TValue JAMGFCFHNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x37A2D50", Offset = "0x37A1B50", VA = "0x1837A2D50")]
	public bool GNMCOJGNPDP(Type JCMGBFKGKLO, [Out] TValue NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x37A2E90", Offset = "0x37A1C90", VA = "0x1837A2E90")]
	public TValue JBIMBFCKBJC(Type JCMGBFKGKLO, Func<Type, TValue> PPGIHHECDOF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x37A25A0", Offset = "0x37A13A0", VA = "0x1837A25A0")]
	private static int DGBKFMAMPKO(int AEBFGNNOBAK, float OKKDNBHJDFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x37A25D0", Offset = "0x37A13D0", VA = "0x1837A25D0")]
	private static void FKPFENGMOFJ(EICLEANOAKM CBJLPIEMMPH, EICLEANOAKM NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x37A25D0", Offset = "0x37A13D0", VA = "0x1837A25D0")]
	private static void FKPFENGMOFJ(EICLEANOAKM[] CBJLPIEMMPH, EICLEANOAKM[] NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class EJAGAJBHPLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder BBBNCEOJGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder BKFCIIEMKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object AHLIKLLBELA;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x68BE820", Offset = "0x68BD620", VA = "0x1868BE820")]
	public TypeBuilder KALDPEEFPLN(string OHHBGJPCFJD, TypeAttributes GKLEFFCIKNN, Type AJKCELPHOFC, Type[] KFHGKLMHEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x68BE920", Offset = "0x68BD720", VA = "0x1868BE920")]
	public EJAGAJBHPLO(string JNOKHJAEFGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class OHHCGPPGDEL
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x68CCA00", Offset = "0x68CB800", VA = "0x1868CCA00")]
	private static MethodInfo JDABCIMIANE(LambdaExpression HKPFDELFIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2854300", Offset = "0x2853100", VA = "0x182854300")]
	public static MethodInfo HCOPFNMAKLM<T>(Expression<Func<T>> HKPFDELFIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2854300", Offset = "0x2853100", VA = "0x182854300")]
	public static MethodInfo HCOPFNMAKLM<T, TR>(Expression<Func<T, TR>> HKPFDELFIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2854300", Offset = "0x2853100", VA = "0x182854300")]
	public static MethodInfo HCOPFNMAKLM<T>(Expression<Action<T>> HKPFDELFIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2854300", Offset = "0x2853100", VA = "0x182854300")]
	public static MethodInfo HCOPFNMAKLM<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> HKPFDELFIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2854220", Offset = "0x2853020", VA = "0x182854220")]
	private static MemberInfo BAAHJEOKDNM<T>(Expression<T> DIIPJIMFFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2854310", Offset = "0x2853110", VA = "0x182854310")]
	public static PropertyInfo HOFHOMMGCOK<T, TR>(Expression<Func<T, TR>> HKPFDELFIJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct ACJKNIBDLMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int PGCIMAABPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool GNPOIIGAGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator AOHJIEFACJL;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x68B74A0", Offset = "0x68B62A0", VA = "0x1868B74A0")]
	public ACJKNIBDLMB(ILGenerator AOHJIEFACJL, int PGCIMAABPAK, bool GNPOIIGAGCA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x68B74E0", Offset = "0x68B62E0", VA = "0x1868B74E0")]
	public ACJKNIBDLMB(ILGenerator AOHJIEFACJL, int PGCIMAABPAK, Type HFFNCGFKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x68B73A0", Offset = "0x68B61A0", VA = "0x1868B73A0")]
	public void EDHJMLIGMOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class EOFGBHJGCGN
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x68BFCD0", Offset = "0x68BEAD0", VA = "0x1868BFCD0")]
	public static void LIOECIEKAME(this ILGenerator AOHJIEFACJL, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x68BFC90", Offset = "0x68BEA90", VA = "0x1868BFC90")]
	public static void LIOECIEKAME(this ILGenerator AOHJIEFACJL, LocalBuilder NGBGEMBKAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x68BF6C0", Offset = "0x68BE4C0", VA = "0x1868BF6C0")]
	public static void KNPANJBCCPE(this ILGenerator AOHJIEFACJL, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x68BF680", Offset = "0x68BE480", VA = "0x1868BF680")]
	public static void KNPANJBCCPE(this ILGenerator AOHJIEFACJL, LocalBuilder NGBGEMBKAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x68BF4A0", Offset = "0x68BE2A0", VA = "0x1868BF4A0")]
	public static void KAMMMGMAIFJ(this ILGenerator AOHJIEFACJL, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x68BF580", Offset = "0x68BE380", VA = "0x1868BF580")]
	public static void KAMMMGMAIFJ(this ILGenerator AOHJIEFACJL, LocalBuilder NGBGEMBKAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x68C0140", Offset = "0x68BEF40", VA = "0x1868C0140")]
	public static void PINGJCLJNDG(this ILGenerator AOHJIEFACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x68BF3B0", Offset = "0x68BE1B0", VA = "0x1868BF3B0")]
	public static void EHPKJPBDFAJ(this ILGenerator AOHJIEFACJL, bool NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x68BF8B0", Offset = "0x68BE6B0", VA = "0x1868BF8B0")]
	public static void LDNILEGEINB(this ILGenerator AOHJIEFACJL, int NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x68BF3C0", Offset = "0x68BE1C0", VA = "0x1868BF3C0")]
	public static void GAEALEACOAD(this ILGenerator AOHJIEFACJL, Type HFFNCGFKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x68BF030", Offset = "0x68BDE30", VA = "0x1868BF030")]
	public static void AFCMFJCCMOC(this ILGenerator AOHJIEFACJL, Type HFFNCGFKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x68BFEC0", Offset = "0x68BECC0", VA = "0x1868BFEC0")]
	public static void MINKOAPMICM(this ILGenerator AOHJIEFACJL, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x68BF0D0", Offset = "0x68BDED0", VA = "0x1868BF0D0")]
	public static void BFEBFJCCIFK(this ILGenerator AOHJIEFACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x68BF1E0", Offset = "0x68BDFE0", VA = "0x1868BF1E0")]
	public static void DDMMICNJOCM(this ILGenerator AOHJIEFACJL, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x68BF2C0", Offset = "0x68BE0C0", VA = "0x1868BF2C0")]
	public static void DNOEFPCENNP(this ILGenerator AOHJIEFACJL, MethodInfo OAKNBPEDCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x68C00B0", Offset = "0x68BEEB0", VA = "0x1868C00B0")]
	public static void NKMAGCCCILI(this ILGenerator AOHJIEFACJL, FieldInfo IEHLKFBCICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x68BF150", Offset = "0x68BDF50", VA = "0x1868BF150")]
	public static void BPNLICNPGEI(this ILGenerator AOHJIEFACJL, ulong NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class MIIAJNKAMBP
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class FMMHHJDPMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public FMMHHJDPMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x68C0620", Offset = "0x68BF420", VA = "0x1868C0620")]
		internal bool JMJBDDMOMHJ(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo KJECNPIMGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo GJNHLFPPFCA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string KLDOAIALCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NEBDBGFEPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x68C7A00", Offset = "0x68C6800", VA = "0x1868C7A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MJBLBMJGPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7ABFC0", VA = "0x1807AD1C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7ACFA0", Offset = "0x7ABDA0", VA = "0x1807ACFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DHFMANLIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EF0", Offset = "0x8BFCF0", VA = "0x1808C0EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BE0", Offset = "0x8BF9E0", VA = "0x1808C0BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type KKPIOFNDDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo HKBGFEFEJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo FILDOHNLCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7AD180", Offset = "0x7ABF80", VA = "0x1807AD180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo DDPFDPIJFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7AD130", Offset = "0x7ABF30", VA = "0x1807AD130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x68C7ED0", Offset = "0x68C6CD0", VA = "0x1868C7ED0")]
	protected MIIAJNKAMBP(Type HFFNCGFKMBJ, string OHHBGJPCFJD, string FLOOGBECIGP, bool ANNBDKGMHLL, bool AJBKNJFAPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x68C7F50", Offset = "0x68C6D50", VA = "0x1868C7F50")]
	public MIIAJNKAMBP(FieldInfo LINKNNNEGKJ, string OHHBGJPCFJD, bool IGIHBJHPHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x68C7D10", Offset = "0x68C6B10", VA = "0x1868C7D10")]
	public MIIAJNKAMBP(PropertyInfo LINKNNNEGKJ, string OHHBGJPCFJD, bool IGIHBJHPHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x68C7890", Offset = "0x68C6690", VA = "0x1868C7890")]
	private static MethodInfo FBELIICOIDE(MemberInfo LINKNNNEGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x27CF820", Offset = "0x27CE620", VA = "0x1827CF820")]
	public T JINHOIDPGBB<T>(bool OGECLOFJMGH) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x68C7B90", Offset = "0x68C6990", VA = "0x1868C7B90", Slot = "4")]
	public virtual void MLBEFANKGBP(ILGenerator AOHJIEFACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x68C7A10", Offset = "0x68C6810", VA = "0x1868C7A10", Slot = "5")]
	public virtual void LDHGHJGJKAA(ILGenerator AOHJIEFACJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class ECODNMEFJEB : MIIAJNKAMBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string IEIBEEHIDIM;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x68BDB10", Offset = "0x68BC910", VA = "0x1868BDB10")]
	public ECODNMEFJEB(string OHHBGJPCFJD, string IEIBEEHIDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x68BDA60", Offset = "0x68BC860", VA = "0x1868BDA60", Slot = "4")]
	public override void MLBEFANKGBP(ILGenerator AOHJIEFACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x68BDA10", Offset = "0x68BC810", VA = "0x1868BDA10", Slot = "5")]
	public override void LDHGHJGJKAA(ILGenerator AOHJIEFACJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class EEPKMNPLOPE : MIIAJNKAMBP
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo EHOKNJBHBBF;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo IHHDMEDOHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal ACJKNIBDLMB EIDIFCHCMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal ACJKNIBDLMB MCDICIECHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal ACJKNIBDLMB AGKHMPPAEAH;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x68BE3D0", Offset = "0x68BD1D0", VA = "0x1868BE3D0")]
	public EEPKMNPLOPE(string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x68BDE00", Offset = "0x68BCC00", VA = "0x1868BDE00", Slot = "4")]
	public override void MLBEFANKGBP(ILGenerator AOHJIEFACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x68BDDB0", Offset = "0x68BCBB0", VA = "0x1868BDDB0", Slot = "5")]
	public override void LDHGHJGJKAA(ILGenerator AOHJIEFACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x68BDBF0", Offset = "0x68BC9F0", VA = "0x1868BDBF0")]
	public void FACCNOPBJDN(ILGenerator AOHJIEFACJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class MOCOMADGEPC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type KKPIOFNDDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CKFONLIMJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x822960", Offset = "0x821760", VA = "0x180822960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3330", Offset = "0x7B2130", VA = "0x1807B3330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BEHMHHDAJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF70", Offset = "0x8BED70", VA = "0x1808BFF70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8BF310", Offset = "0x8BE110", VA = "0x1808BF310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo FDNCECMJDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public MIIAJNKAMBP[] KHBEPNINKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public MIIAJNKAMBP[] EKPFFENIKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x68C8D60", Offset = "0x68C7B60", VA = "0x1868C8D60")]
	public MOCOMADGEPC(Type HFFNCGFKMBJ, Func<string, string> GOCOJGJHEIM, bool IGIHBJHPHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x68C8C80", Offset = "0x68C7A80", VA = "0x1868C8C80")]
	private static bool HOHCJJHBBEJ(IEnumerator<ConstructorInfo> FMBONJBFOJI, ConstructorInfo PNKJAPBGFMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct OJDGOCMIHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong IFCHLPHCIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int IHEECNGJNNF;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFF60", Offset = "0x1DBED60", VA = "0x181DBFF60")]
	public OJDGOCMIHLN(ulong JDKNCKFIONG, int JMGHMGGKDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x68CCE30", Offset = "0x68CBC30", VA = "0x1868CCE30")]
	public void DGLBHADFJCL(OJDGOCMIHLN FPEEGIOMOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x68CD000", Offset = "0x68CBE00", VA = "0x1868CD000")]
	public static OJDGOCMIHLN NCDOHHGKFOL(OJDGOCMIHLN GCMDJKOKHCO, OJDGOCMIHLN LGCDJBDIEJC)
	{
		return default(OJDGOCMIHLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x68CCEE0", Offset = "0x68CBCE0", VA = "0x1868CCEE0")]
	public void ICELLCCHMOB(OJDGOCMIHLN FPEEGIOMOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x68CCE40", Offset = "0x68CBC40", VA = "0x1868CCE40")]
	public static OJDGOCMIHLN GEJJMMFKNNB(OJDGOCMIHLN GCMDJKOKHCO, OJDGOCMIHLN LGCDJBDIEJC)
	{
		return default(OJDGOCMIHLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x68CCFC0", Offset = "0x68CBDC0", VA = "0x1868CCFC0")]
	public void IIEPCGHLCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x68CCF70", Offset = "0x68CBD70", VA = "0x1868CCF70")]
	public static OJDGOCMIHLN IIEPCGHLCKN(OJDGOCMIHLN GCMDJKOKHCO)
	{
		return default(OJDGOCMIHLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct IPFOEBHEODL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] CDNPBOBHCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int OOCJLKADJBK;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x17CEC40", Offset = "0x17CDA40", VA = "0x1817CEC40")]
	public IPFOEBHEODL(byte[] CDNPBOBHCMP, int JCOIMLJCHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x68B2C20", Offset = "0x68B1A20", VA = "0x1868B2C20")]
	public void IHLPFCPJHKJ(byte BFHMEKKAMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x68C4820", Offset = "0x68C3620", VA = "0x1868C4820")]
	public void HBCBOLIAJFL(byte[] BFHMEKKAMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x68C48A0", Offset = "0x68C36A0", VA = "0x1868C48A0")]
	public void OMAOOJGFNLM(byte[] BFHMEKKAMJH, int FAPCCJLFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x68C4920", Offset = "0x68C3720", VA = "0x1868C4920")]
	public void OMAOOJGFNLM(byte[] BFHMEKKAMJH, int IFADIJDFJBM, int FAPCCJLFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x68C47A0", Offset = "0x68C35A0", VA = "0x1868C47A0")]
	public void BIHBJEJOMHO(byte JJJKOMKEIGG, int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x68C49C0", Offset = "0x68C37C0", VA = "0x1868C49C0")]
	public void PFENMKFIOHP(string BFHMEKKAMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class MDJLPCDJGKO
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum GCHNAPFJJNA
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum GJPBNPAIFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum MHCCMPCDDJB
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
	private static byte[] EBKNJKPILLM;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] DOBCELKPOEH;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] OHFMAGBMLMJ;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] KEKIFAFMEAA;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly MHCCMPCDDJB IHDJGLHMADD;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char MEHIECNMKBL;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int MFMINJBIGHB;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int KJFHENOCIBE;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] GGDGDDGAALG;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x68C6610", Offset = "0x68C5410", VA = "0x1868C6610")]
	private static byte[] HEKBCKCIDHH(int DDGPJFNNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x68C5CC0", Offset = "0x68C4AC0", VA = "0x1868C5CC0")]
	private static byte[] EPMGKCJDMHC(int DDGPJFNNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x68C7350", Offset = "0x68C6150", VA = "0x1868C7350")]
	public static int NAOBDDHEIHL(byte[] CDNPBOBHCMP, int OOCJLKADJBK, float NKKIECLCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x68C7230", Offset = "0x68C6030", VA = "0x1868C7230")]
	public static int NAOBDDHEIHL(byte[] CDNPBOBHCMP, int OOCJLKADJBK, double NKKIECLCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x68C6B60", Offset = "0x68C5960", VA = "0x1868C6B60")]
	private static bool KDHEKMFIGAN(byte[] CDNPBOBHCMP, int FAPCCJLFBAA, ulong AJBBOCNINCA, ulong NOOBAFAPPAM, ulong EGLKHBBMJPO, ulong HEEMCJFOPLK, ulong GEMDGGEFOGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x68C5690", Offset = "0x68C4490", VA = "0x1868C5690")]
	private static void BEPAICGCKKB(uint JGLMBGFBBCA, int PBNJIEPIEGP, [Out] uint KINGLFANFLJ, [Out] int IIIHOCPILAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x68C6C50", Offset = "0x68C5A50", VA = "0x1868C6C50")]
	private static bool LOIPADPCGOL(OJDGOCMIHLN GGEMDODGAOG, OJDGOCMIHLN JMEBBPBFDEK, OJDGOCMIHLN IAHNAMHBMGA, byte[] CDNPBOBHCMP, [Out] int FAPCCJLFBAA, [Out] int BANEJLKBBEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x68C66E0", Offset = "0x68C54E0", VA = "0x1868C66E0")]
	private static bool JNOHGOHDNPA(double HHLJIMLHKAO, GCHNAPFJJNA EAPOADFKJDH, byte[] CDNPBOBHCMP, [Out] int FAPCCJLFBAA, [Out] int FKMMDGGFKDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x68C5BB0", Offset = "0x68C49B0", VA = "0x1868C5BB0")]
	private static bool ENINNKMCCHG(double HHLJIMLHKAO, GCHNAPFJJNA EAPOADFKJDH, byte[] CDNPBOBHCMP, [Out] int FAPCCJLFBAA, [Out] int GKCINDIHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x68C7470", Offset = "0x68C6270", VA = "0x1868C7470")]
	private static bool NGAJGEDMIPB(double NKKIECLCEML, IPFOEBHEODL DEBKDLLJKDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x68C6130", Offset = "0x68C4F30", VA = "0x1868C6130")]
	private static bool FMGPHHPEPGD(double NKKIECLCEML, IPFOEBHEODL DEBKDLLJKDN, GJPBNPAIFNJ EAPOADFKJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x68C5DA0", Offset = "0x68C4BA0", VA = "0x1868C5DA0")]
	private static void FKPOFBOLFNO(byte[] ONJEEACOJAE, int FAPCCJLFBAA, int GKCINDIHCOB, int HJMLGIDHOIL, IPFOEBHEODL DEBKDLLJKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x68C5780", Offset = "0x68C4580", VA = "0x1868C5780")]
	private static void BJIKMLAFEJB(byte[] ONJEEACOJAE, int FAPCCJLFBAA, int JMGHMGGKDAF, IPFOEBHEODL DEBKDLLJKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x68C7040", Offset = "0x68C5E40", VA = "0x1868C7040")]
	private static bool MJBDBNPLFNC(double HHLJIMLHKAO, GJPBNPAIFNJ EAPOADFKJDH, int JFJDNAAACHG, byte[] PFJPBNGOGDE, [Out] bool HAPFJJHPKNF, [Out] int FAPCCJLFBAA, [Out] int MHCNCLONLOI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct DJCEGAKHCOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double DDIKBLEEKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong HONNCJNEBBO;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct ABFDJFCGNMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float IFCHLPHCIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint LCMIAOFPAKG;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct IEDBHMHLDKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong OLBNOABMOCD;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x68C29C0", Offset = "0x68C17C0", VA = "0x1868C29C0")]
	public IEDBHMHLDKP(double DDIKBLEEKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x68C2920", Offset = "0x68C1720", VA = "0x1868C2920")]
	public IEDBHMHLDKP(OJDGOCMIHLN DDIKBLEEKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x68C2760", Offset = "0x68C1560", VA = "0x1868C2760")]
	public OJDGOCMIHLN MBAMIBKHHDH()
	{
		return default(OJDGOCMIHLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x68C27D0", Offset = "0x68C15D0", VA = "0x1868C27D0")]
	public OJDGOCMIHLN MDHOLCPENKB()
	{
		return default(OJDGOCMIHLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
	public ulong OBMAEFMBIMO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x68C2640", Offset = "0x68C1440", VA = "0x1868C2640")]
	public double JHPLGLMKNAJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x68C26C0", Offset = "0x68C14C0", VA = "0x1868C26C0")]
	public double LGPGLKCMDCG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x68C2850", Offset = "0x68C1650", VA = "0x1868C2850")]
	public int NEEBFHLANMI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x68C28F0", Offset = "0x68C16F0", VA = "0x1868C28F0")]
	public ulong PLGANDLLGMC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x68C25A0", Offset = "0x68C13A0", VA = "0x1868C25A0")]
	public bool DFDCDBEGDCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x68C2620", Offset = "0x68C1420", VA = "0x1868C2620")]
	public bool IMOEOJIEINF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x68C2570", Offset = "0x68C1370", VA = "0x1868C2570")]
	public bool CJHJBHFEEIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x68C25C0", Offset = "0x68C13C0", VA = "0x1868C25C0")]
	public bool DKGKIKHPHOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x68C2600", Offset = "0x68C1400", VA = "0x1868C2600")]
	public int GCNIFGCLCDK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x68C2390", Offset = "0x68C1190", VA = "0x1868C2390")]
	public void ACNIILFEEHP([Out] OJDGOCMIHLN JECELDLECHG, [Out] OJDGOCMIHLN CAGLPMJKPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x68C2880", Offset = "0x68C1680", VA = "0x1868C2880")]
	public bool OONADLCMONJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A6B0", Offset = "0x2C594B0", VA = "0x182C5A6B0")]
	public double NKKIECLCEML()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x68C28D0", Offset = "0x68C16D0", VA = "0x1868C28D0")]
	public static int PANCMIAMNFH(int PHJHIIBKLAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x68C25F0", Offset = "0x68C13F0", VA = "0x1868C25F0")]
	public static double DOHOMIHNEJP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x68C24E0", Offset = "0x68C12E0", VA = "0x1868C24E0")]
	public static ulong CHOCADBNMOD(OJDGOCMIHLN LCHLGFJEGAP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct EFHAHHAIMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint GMGCJCNJOOM;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1EE2C10", Offset = "0x1EE1A10", VA = "0x181EE2C10")]
	public EFHAHHAIMAC(float IFCHLPHCIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x68BE5D0", Offset = "0x68BD3D0", VA = "0x1868BE5D0")]
	public OJDGOCMIHLN MBAMIBKHHDH()
	{
		return default(OJDGOCMIHLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0")]
	public uint PACBLGOKFIP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x68BE620", Offset = "0x68BD420", VA = "0x1868BE620")]
	public int NEEBFHLANMI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x68BE680", Offset = "0x68BD480", VA = "0x1868BE680")]
	public uint PLGANDLLGMC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x68BE5C0", Offset = "0x68BD3C0", VA = "0x1868BE5C0")]
	public bool DFDCDBEGDCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x68BE490", Offset = "0x68BD290", VA = "0x1868BE490")]
	public void ACNIILFEEHP([Out] OJDGOCMIHLN JECELDLECHG, [Out] OJDGOCMIHLN CAGLPMJKPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x68BE640", Offset = "0x68BD440", VA = "0x1868BE640")]
	public bool OONADLCMONJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct MAIPNKOFCLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong JDKNCKFIONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short BLNPCKJDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short FKMMDGGFKDF;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x68C5680", Offset = "0x68C4480", VA = "0x1868C5680")]
	public MAIPNKOFCLP(ulong JDKNCKFIONG, short BLNPCKJDLNO, short FKMMDGGFKDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class BGBNDEBHIJJ
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly MAIPNKOFCLP[] NPIIFMLCBEE;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x68B8660", Offset = "0x68B7460", VA = "0x1868B8660")]
	public static void GOAIKBDDIPC(int FOHLOPDINPP, int EJDCKGICGDA, [Out] OJDGOCMIHLN KINGLFANFLJ, [Out] int FKMMDGGFKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x68B8590", Offset = "0x68B7390", VA = "0x1868B8590")]
	public static void FLCEMDJGEEE(int KIHENEJLNPF, [Out] OJDGOCMIHLN KINGLFANFLJ, [Out] int NBJOPCDEJNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct LPPJAMGPCBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] JAHCJGGEGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int IFADIJDFJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int NPAADJKGKII;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x68C5410", Offset = "0x68C4210", VA = "0x1868C5410")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CF20", Offset = "0x3A9BD20", VA = "0x183A9CF20")]
	public LPPJAMGPCBP(byte[] JAHCJGGEGHK, int IFADIJDFJBM, int FAPCCJLFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F21980", Offset = "0x1F20780", VA = "0x181F21980")]
	public int FAPCCJLFBAA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x68C5450", Offset = "0x68C4250", VA = "0x1868C5450")]
	public LPPJAMGPCBP PNLKPMFIGHB(int EIFHACOADFO, int IDPPHHMPMLO)
	{
		return default(LPPJAMGPCBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class CMANIFMBJDK
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] CNNMAJMIEBF;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] IFEGCJJCNCA;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int ODEDOBFNOCE;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x68BA2B0", Offset = "0x68B90B0", VA = "0x1868BA2B0")]
	private static byte[] INAKCEECHCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x68BAFA0", Offset = "0x68B9DA0", VA = "0x1868BAFA0")]
	private static LPPJAMGPCBP MNIOKIBBDJC(LPPJAMGPCBP CDNPBOBHCMP)
	{
		return default(LPPJAMGPCBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x68BA390", Offset = "0x68B9190", VA = "0x1868BA390")]
	private static LPPJAMGPCBP JNIPMMEGIGI(LPPJAMGPCBP CDNPBOBHCMP)
	{
		return default(LPPJAMGPCBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x68BB080", Offset = "0x68B9E80", VA = "0x1868BB080")]
	private static void NFPGIDPKGDA(LPPJAMGPCBP CDNPBOBHCMP, int JMGHMGGKDAF, byte[] NPFODJGCNIA, [Out] int BCBPEPOMGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x68BA470", Offset = "0x68B9270", VA = "0x1868BA470")]
	private static void KJBOGGMJKFB(LPPJAMGPCBP CDNPBOBHCMP, int JMGHMGGKDAF, byte[] OACDFJFHGLN, int OLBDHAKJOPI, [Out] LPPJAMGPCBP EFLIINKFGHN, [Out] int JPLHPHGONID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x68BA100", Offset = "0x68B8F00", VA = "0x1868BA100")]
	private static ulong FPPLOHAGHPI(LPPJAMGPCBP CDNPBOBHCMP, [Out] int JJCEDNALPCA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x68B9850", Offset = "0x68B8650", VA = "0x1868B9850")]
	private static void BOKDFDCAABG(LPPJAMGPCBP CDNPBOBHCMP, [Out] OJDGOCMIHLN BGCCPJGDEGH, [Out] int OOONOCCABNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x68BA760", Offset = "0x68B9560", VA = "0x1868BA760")]
	private static bool KLECHPHNEKM(LPPJAMGPCBP EFLIINKFGHN, int JMGHMGGKDAF, [Out] double BGCCPJGDEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x68BAB30", Offset = "0x68B9930", VA = "0x1868BAB30")]
	private static OJDGOCMIHLN MACHNDGIGMA(int JMGHMGGKDAF)
	{
		return default(OJDGOCMIHLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x68B9AB0", Offset = "0x68B88B0", VA = "0x1868B9AB0")]
	private static bool EKENCDOFKHN(LPPJAMGPCBP CDNPBOBHCMP, int JMGHMGGKDAF, [Out] double BGCCPJGDEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x68B9990", Offset = "0x68B8790", VA = "0x1868B9990")]
	private static bool CDKNCOGCCFF(LPPJAMGPCBP EFLIINKFGHN, int JMGHMGGKDAF, [Out] double EEPOEODDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x68BA190", Offset = "0x68B8F90", VA = "0x1868BA190")]
	public static double? IDIKAHCOONC(LPPJAMGPCBP CDNPBOBHCMP, int JMGHMGGKDAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x68BACD0", Offset = "0x68B9AD0", VA = "0x1868BACD0")]
	public static float? MDFALPAGDGP(LPPJAMGPCBP CDNPBOBHCMP, int JMGHMGGKDAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct APNHELAOHJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] CDNPBOBHCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int OOCJLKADJBK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x68B8470", Offset = "0x68B7270", VA = "0x1868B8470")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x17CEC40", Offset = "0x17CDA40", VA = "0x1817CEC40")]
	public APNHELAOHJL(byte[] CDNPBOBHCMP, int OOCJLKADJBK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x68B84E0", Offset = "0x68B72E0", VA = "0x1868B84E0")]
	public static APNHELAOHJL JEBDCIIOONN(APNHELAOHJL CNFBJPGPBBJ)
	{
		return default(APNHELAOHJL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x68B83F0", Offset = "0x68B71F0", VA = "0x1868B83F0")]
	public static APNHELAOHJL FKIIBOICILH(APNHELAOHJL CNFBJPGPBBJ, int FAPCCJLFBAA)
	{
		return default(APNHELAOHJL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x68B83B0", Offset = "0x68B71B0", VA = "0x1868B83B0")]
	public static int AOAJJLHDPJD(APNHELAOHJL EHBONBMIDMA, APNHELAOHJL MKAKMHGMJJL)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x68B84D0", Offset = "0x68B72D0", VA = "0x1868B84D0")]
	public static bool JACCNGOPODK(APNHELAOHJL EHBONBMIDMA, APNHELAOHJL MKAKMHGMJJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x68B8580", Offset = "0x68B7380", VA = "0x1868B8580")]
	public static bool PONNJIKFNKJ(APNHELAOHJL EHBONBMIDMA, APNHELAOHJL MKAKMHGMJJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x68B84A0", Offset = "0x68B72A0", VA = "0x1868B84A0")]
	public static bool JACCNGOPODK(APNHELAOHJL EHBONBMIDMA, char MKAKMHGMJJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x68B8550", Offset = "0x68B7350", VA = "0x1868B8550")]
	public static bool PONNJIKFNKJ(APNHELAOHJL EHBONBMIDMA, char MKAKMHGMJJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x68B8550", Offset = "0x68B7350", VA = "0x1868B8550")]
	public static bool PONNJIKFNKJ(APNHELAOHJL EHBONBMIDMA, byte MKAKMHGMJJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x68B8520", Offset = "0x68B7320", VA = "0x1868B8520")]
	public static bool PDENOMLDBKA(APNHELAOHJL EHBONBMIDMA, char MKAKMHGMJJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x68B8440", Offset = "0x68B7240", VA = "0x1868B8440")]
	public static bool FPJIAFEHCNA(APNHELAOHJL EHBONBMIDMA, char MKAKMHGMJJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x68B84F0", Offset = "0x68B72F0", VA = "0x1868B84F0")]
	public static bool KPDJNFAMLAG(APNHELAOHJL EHBONBMIDMA, char MKAKMHGMJJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x68B83C0", Offset = "0x68B71C0", VA = "0x1868B83C0")]
	public static bool CLOKLIKDPJC(APNHELAOHJL EHBONBMIDMA, char MKAKMHGMJJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class IJMBHLONIMK
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] CELFGPLBOAL;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] ELOMHIOHPAM;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] OHFMAGBMLMJ;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] KEKIFAFMEAA;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] PILJIMAOBDK;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int IJAJONCGIOL;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] CEGOMNENOAL;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int FJMOAIIMMJD;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x68C2A80", Offset = "0x68C1880", VA = "0x1868C2A80")]
	private static byte[] CIKFBAMOFPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x68C3D60", Offset = "0x68C2B60", VA = "0x1868C3D60")]
	private static byte[] IABHDGAILCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x68C29D0", Offset = "0x68C17D0", VA = "0x1868C29D0")]
	public static double CAMPFPMNKBN(byte[] CDNPBOBHCMP, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x68C3E40", Offset = "0x68C2C40", VA = "0x1868C3E40")]
	public static float JKEKLPDFJEO(byte[] CDNPBOBHCMP, int OOCJLKADJBK, [Out] int GEFPHDDHEJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x68C3BD0", Offset = "0x68C29D0", VA = "0x1868C3BD0")]
	private static bool EHKACOGMLNK(int AHPBAINPGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x68C3EF0", Offset = "0x68C2CF0", VA = "0x1868C3EF0")]
	private static bool KPGKCIPPECO(APNHELAOHJL BBLKDIDBOGP, APNHELAOHJL DBFFCPMHGNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x68C3B00", Offset = "0x68C2900", VA = "0x1868C3B00")]
	private static bool DNDMAKIPCFB(APNHELAOHJL BBLKDIDBOGP, APNHELAOHJL DBFFCPMHGNC, byte[] ACPCPCPBDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x68C3D10", Offset = "0x68C2B10", VA = "0x1868C3D10")]
	private static bool EOPIHJHJGFH(APNHELAOHJL ILPNEDKPLPE, byte[] BFHMEKKAMJH, int OOCJLKADJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x68C40E0", Offset = "0x68C2EE0", VA = "0x1868C40E0")]
	private static double LLIABIJDGIK(bool HAPFJJHPKNF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x68C2B60", Offset = "0x68C1960", VA = "0x1868C2B60")]
	private static double CKLDCBGFLPG(APNHELAOHJL ECKJJAACLOE, int FAPCCJLFBAA, bool EPHAELKCLKM, [Out] int MDCHHHFEONC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class FOEDDLCBCEM<T> : FMHIBLCEFCM<T[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly LOFOKEEOCIG<T> ILPGHCJFPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly CFHHPDOLEOO FHFOPADGAKL;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3224080", Offset = "0x3222E80", VA = "0x183224080")]
	public FOEDDLCBCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
	public FOEDDLCBCEM(CFHHPDOLEOO FHFOPADGAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x35E1B60", Offset = "0x35E0960", VA = "0x1835E1B60", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x35E1790", Offset = "0x35E0590", VA = "0x1835E1790", Slot = "5")]
	public T[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class FKDHDIPBLOJ<T> : FMHIBLCEFCM<ArraySegment<T>>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly LOFOKEEOCIG<T> ILPGHCJFPDI;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x35D8BD0", Offset = "0x35D79D0", VA = "0x1835D8BD0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ArraySegment<T> NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x35D87B0", Offset = "0x35D75B0", VA = "0x1835D87B0", Slot = "5")]
	public ArraySegment<T> CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class EBBNPMIAEJC<T> : FMHIBLCEFCM<List<T>>, MAFHFNECHNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly CFHHPDOLEOO FHFOPADGAKL;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3224080", Offset = "0x3222E80", VA = "0x183224080")]
	public EBBNPMIAEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
	public EBBNPMIAEJC(CFHHPDOLEOO FHFOPADGAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x32220B0", Offset = "0x3220EB0", VA = "0x1832220B0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, List<T> NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3220EB0", Offset = "0x321FCB0", VA = "0x183220EB0", Slot = "5")]
	public List<T> CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class NMJKFHLEHNP<TElement, TIntermediate, TEnumerator, TCollection> : FMHIBLCEFCM<TCollection>, MAFHFNECHNN where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3E79B80", Offset = "0x3E78980", VA = "0x183E79B80", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, TCollection NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3E77C60", Offset = "0x3E76A60", VA = "0x183E77C60", Slot = "5")]
	public TCollection CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EDHHEEMFHOH(TCollection DIIPJIMFFMD);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate IKNJBMGGGFK();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void ANMBPKAMKOK(TIntermediate FNEIOBDLJKM, int ENPOKNEMOMH, TElement NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection GMFECOINAPH(TIntermediate BKBHNPGBGPG);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected NMJKFHLEHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class LKKHGNOGDHK<TElement, TIntermediate, TCollection> : NMJKFHLEHNP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3672910", Offset = "0x3671710", VA = "0x183672910", Slot = "6")]
	protected override IEnumerator<TElement> EDHHEEMFHOH(TCollection DIIPJIMFFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x32026B0", Offset = "0x32014B0", VA = "0x1832026B0")]
	protected LKKHGNOGDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class OPKONIGPLPE<TElement, TCollection> : LKKHGNOGDHK<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected sealed override TCollection GMFECOINAPH(TCollection BKBHNPGBGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class KNINJDKKCLJ<TElement, TCollection> : OPKONIGPLPE<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C650", Offset = "0x3B0B450", VA = "0x183B0C650", Slot = "7")]
	protected override TCollection IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C590", Offset = "0x3B0B390", VA = "0x183B0C590", Slot = "8")]
	protected override void ANMBPKAMKOK(TCollection FNEIOBDLJKM, int ENPOKNEMOMH, TElement NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class DENEHHMHDID<T> : NMJKFHLEHNP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C550", Offset = "0x3A5B350", VA = "0x183A5C550", Slot = "8")]
	protected override void ANMBPKAMKOK(LinkedList<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override LinkedList<T> GMFECOINAPH(LinkedList<T> BKBHNPGBGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override LinkedList<T> IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3691C40", Offset = "0x3690A40", VA = "0x183691C40", Slot = "6")]
	protected override LinkedList<T>.Enumerator EDHHEEMFHOH(LinkedList<T> DIIPJIMFFMD)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class LGOIBIMBBKE<T> : NMJKFHLEHNP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C550", Offset = "0x3A5B350", VA = "0x183A5C550", Slot = "8")]
	protected override void ANMBPKAMKOK(Queue<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override Queue<T> IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A010", Offset = "0x3A98E10", VA = "0x183A9A010", Slot = "6")]
	protected override Queue<T>.Enumerator EDHHEEMFHOH(Queue<T> DIIPJIMFFMD)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override Queue<T> GMFECOINAPH(Queue<T> BKBHNPGBGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class NGIHECDKKIP<T> : NMJKFHLEHNP<T, NAINONDNJOP<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x36904A0", Offset = "0x368F2A0", VA = "0x1836904A0", Slot = "8")]
	protected override void ANMBPKAMKOK(NAINONDNJOP<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x36904F0", Offset = "0x368F2F0", VA = "0x1836904F0", Slot = "7")]
	protected override NAINONDNJOP<T> IKNJBMGGGFK()
	{
		return default(NAINONDNJOP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3E6AE10", Offset = "0x3E69C10", VA = "0x183E6AE10", Slot = "6")]
	protected override Stack<T>.Enumerator EDHHEEMFHOH(Stack<T> DIIPJIMFFMD)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3E6AE70", Offset = "0x3E69C70", VA = "0x183E6AE70", Slot = "9")]
	protected override Stack<T> GMFECOINAPH(NAINONDNJOP<T> BKBHNPGBGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class KAGGEOINMDK<T> : NMJKFHLEHNP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C550", Offset = "0x3A5B350", VA = "0x183A5C550", Slot = "8")]
	protected override void ANMBPKAMKOK(HashSet<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override HashSet<T> GMFECOINAPH(HashSet<T> BKBHNPGBGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override HashSet<T> IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A010", Offset = "0x3A98E10", VA = "0x183A9A010", Slot = "6")]
	protected override HashSet<T>.Enumerator EDHHEEMFHOH(HashSet<T> DIIPJIMFFMD)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class HHLOFKBBLMG<T> : LKKHGNOGDHK<T, NAINONDNJOP<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x36904A0", Offset = "0x368F2A0", VA = "0x1836904A0", Slot = "8")]
	protected override void ANMBPKAMKOK(NAINONDNJOP<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3786890", Offset = "0x3785690", VA = "0x183786890", Slot = "9")]
	protected override ReadOnlyCollection<T> GMFECOINAPH(NAINONDNJOP<T> BKBHNPGBGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3786930", Offset = "0x3785730", VA = "0x183786930", Slot = "7")]
	protected override NAINONDNJOP<T> IKNJBMGGGFK()
	{
		return default(NAINONDNJOP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class JLIGEANHFPN<T> : LKKHGNOGDHK<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C550", Offset = "0x3A5B350", VA = "0x183A5C550", Slot = "8")]
	protected override void ANMBPKAMKOK(List<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override List<T> IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override IList<T> GMFECOINAPH(List<T> BKBHNPGBGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class OLAJFBOJFOB<T> : LKKHGNOGDHK<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C550", Offset = "0x3A5B350", VA = "0x183A5C550", Slot = "8")]
	protected override void ANMBPKAMKOK(List<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override List<T> IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override ICollection<T> GMFECOINAPH(List<T> BKBHNPGBGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class GCCCLDFCODI<T> : LKKHGNOGDHK<T, NAINONDNJOP<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x36904A0", Offset = "0x368F2A0", VA = "0x1836904A0", Slot = "8")]
	protected override void ANMBPKAMKOK(NAINONDNJOP<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x36904F0", Offset = "0x368F2F0", VA = "0x1836904F0", Slot = "7")]
	protected override NAINONDNJOP<T> IKNJBMGGGFK()
	{
		return default(NAINONDNJOP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x36904D0", Offset = "0x368F2D0", VA = "0x1836904D0", Slot = "9")]
	protected override IEnumerable<T> GMFECOINAPH(NAINONDNJOP<T> BKBHNPGBGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3210090", Offset = "0x320EE90", VA = "0x183210090")]
	public GCCCLDFCODI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class HNIJEAPAGLA<TKey, TElement> : FMHIBLCEFCM<IGrouping<TKey, TElement>>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x37B7960", Offset = "0x37B6760", VA = "0x1837B7960", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, IGrouping<TKey, TElement> NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x37B7660", Offset = "0x37B6460", VA = "0x1837B7660", Slot = "5")]
	public IGrouping<TKey, TElement> CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class BPDGOIJLFGJ<TKey, TElement> : FMHIBLCEFCM<ILookup<TKey, TElement>>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x46C1A70", Offset = "0x46C0870", VA = "0x1846C1A70", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ILookup<TKey, TElement> NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x46C1720", Offset = "0x46C0520", VA = "0x1846C1720", Slot = "5")]
	public ILookup<TKey, TElement> CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class EIKEPNKPANJ<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey JCMGBFKGKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> NKICLGBEJFP;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey DIJJAKBLGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	public EIKEPNKPANJ(TKey JCMGBFKGKLO, IEnumerable<TElement> NKICLGBEJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x324AB20", Offset = "0x3249920", VA = "0x18324AB20", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x324AB70", Offset = "0x3249970", VA = "0x18324AB70", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class HNKGJPAHIJC<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> KEIPELAHKMM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x37069E0", Offset = "0x37057E0", VA = "0x1837069E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public HNKGJPAHIJC(Dictionary<TKey, IGrouping<TKey, TElement>> KEIPELAHKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x37B7BE0", Offset = "0x37B69E0", VA = "0x1837B7BE0", Slot = "5")]
	public bool Contains(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x37B7C20", Offset = "0x37B6A20", VA = "0x1837B7C20", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x37B7C20", Offset = "0x37B6A20", VA = "0x1837B7C20", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class JLKOBCFFKPN<T> : FMHIBLCEFCM<T>, MAFHFNECHNN where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C810", Offset = "0x3A5B610", VA = "0x183A5C810", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C590", Offset = "0x3A5B390", VA = "0x183A5C590", Slot = "5")]
	public T CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JLKOBCFFKPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class OICLJDJCJIE : FMHIBLCEFCM<IEnumerable>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly FMHIBLCEFCM<IEnumerable> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x68DD4E0", Offset = "0x68DC2E0", VA = "0x1868DD4E0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, IEnumerable NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x68DD290", Offset = "0x68DC090", VA = "0x1868DD290", Slot = "5")]
	public IEnumerable CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public OICLJDJCJIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class CMDMCLFCHIF : FMHIBLCEFCM<ICollection>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly FMHIBLCEFCM<ICollection> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x68D1BC0", Offset = "0x68D09C0", VA = "0x1868D1BC0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ICollection NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x68D1970", Offset = "0x68D0770", VA = "0x1868D1970", Slot = "5")]
	public ICollection CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CMDMCLFCHIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CPBKELNDLIG : FMHIBLCEFCM<IList>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly FMHIBLCEFCM<IList> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x68D2380", Offset = "0x68D1180", VA = "0x1868D2380", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, IList NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x68D2130", Offset = "0x68D0F30", VA = "0x1868D2130", Slot = "5")]
	public IList CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CPBKELNDLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class MGJJIMMEFEO<T> : LKKHGNOGDHK<T, NAINONDNJOP<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEF00", Offset = "0x3DDDD00", VA = "0x183DDEF00", Slot = "8")]
	protected override void ANMBPKAMKOK(NAINONDNJOP<T> FNEIOBDLJKM, int ENPOKNEMOMH, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x36904F0", Offset = "0x368F2F0", VA = "0x1836904F0", Slot = "7")]
	protected override NAINONDNJOP<T> IKNJBMGGGFK()
	{
		return default(NAINONDNJOP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEF30", Offset = "0x3DDDD30", VA = "0x183DDEF30", Slot = "9")]
	protected override IReadOnlyList<T> GMFECOINAPH(NAINONDNJOP<T> BKBHNPGBGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x320FA30", Offset = "0x320E830", VA = "0x18320FA30")]
	public MGJJIMMEFEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class HJIHKGIFALB
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x68D7C80", Offset = "0x68D6A80", VA = "0x1868D7C80")]
	public static DateTime EIHCCGJHFDP(DateTime ANOAPOFJJMG)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class EDNFCFHCHFO : FMHIBLCEFCM<DateTime>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly FMHIBLCEFCM<DateTime> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x68D44F0", Offset = "0x68D32F0", VA = "0x1868D44F0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, DateTime NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x68D37E0", Offset = "0x68D25E0", VA = "0x1868D37E0", Slot = "5")]
	public DateTime CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EDNFCFHCHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class PIPINNCBJMH : FMHIBLCEFCM<DateTimeOffset>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly FMHIBLCEFCM<DateTimeOffset> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x68DE800", Offset = "0x68DD600", VA = "0x1868DE800", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, DateTimeOffset NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x68DDBE0", Offset = "0x68DC9E0", VA = "0x1868DDBE0", Slot = "5")]
	public DateTimeOffset CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public PIPINNCBJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class DJBPMEDHJAN : FMHIBLCEFCM<TimeSpan>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly FMHIBLCEFCM<TimeSpan> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] MLCOGAKOHOK;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x68D32A0", Offset = "0x68D20A0", VA = "0x1868D32A0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, TimeSpan NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x68D2990", Offset = "0x68D1790", VA = "0x1868D2990", Slot = "5")]
	public TimeSpan CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public DJBPMEDHJAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class GBFAICGCMFB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : FMHIBLCEFCM<TDictionary>, MAFHFNECHNN where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x368E6C0", Offset = "0x368D4C0", VA = "0x18368E6C0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, TDictionary NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x368BD60", Offset = "0x368AB60", VA = "0x18368BD60", Slot = "5")]
	public TDictionary CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EDHHEEMFHOH(TDictionary DIIPJIMFFMD);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate IKNJBMGGGFK();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void ANMBPKAMKOK(TIntermediate FNEIOBDLJKM, int ENPOKNEMOMH, TKey JCMGBFKGKLO, TValue NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary GMFECOINAPH(TIntermediate BKBHNPGBGPG);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected GBFAICGCMFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class AEANJHBGCNJ<TKey, TValue, TIntermediate, TDictionary> : GBFAICGCMFB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3672910", Offset = "0x3671710", VA = "0x183672910", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> EDHHEEMFHOH(TDictionary DIIPJIMFFMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class INPIBKGKJHL<TKey, TValue, TDictionary> : AEANJHBGCNJ<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override TDictionary GMFECOINAPH(TDictionary BKBHNPGBGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class GCJFJECHAIG<TKey, TValue> : GBFAICGCMFB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3691AA0", Offset = "0x36908A0", VA = "0x183691AA0", Slot = "8")]
	protected override void ANMBPKAMKOK(Dictionary<TKey, TValue> FNEIOBDLJKM, int ENPOKNEMOMH, TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override Dictionary<TKey, TValue> GMFECOINAPH(Dictionary<TKey, TValue> BKBHNPGBGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override Dictionary<TKey, TValue> IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3691BD0", Offset = "0x36909D0", VA = "0x183691BD0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator EDHHEEMFHOH(Dictionary<TKey, TValue> DIIPJIMFFMD)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x32019A0", Offset = "0x32007A0", VA = "0x1832019A0")]
	public GCJFJECHAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class CEPPPJMOENO<TKey, TValue, TDictionary> : INPIBKGKJHL<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x497C6D0", Offset = "0x497B4D0", VA = "0x18497C6D0", Slot = "8")]
	protected override void ANMBPKAMKOK(TDictionary FNEIOBDLJKM, int ENPOKNEMOMH, TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3052800", Offset = "0x3051600", VA = "0x183052800", Slot = "7")]
	protected override TDictionary IKNJBMGGGFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class IAMEINGKAEJ<TKey, TValue> : AEANJHBGCNJ<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3691990", Offset = "0x3690790", VA = "0x183691990", Slot = "8")]
	protected override void ANMBPKAMKOK(Dictionary<TKey, TValue> FNEIOBDLJKM, int ENPOKNEMOMH, TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override Dictionary<TKey, TValue> IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override IDictionary<TKey, TValue> GMFECOINAPH(Dictionary<TKey, TValue> BKBHNPGBGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class DIHMLINBEPI<TKey, TValue> : INPIBKGKJHL<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x3691990", Offset = "0x3690790", VA = "0x183691990", Slot = "8")]
	protected override void ANMBPKAMKOK(SortedList<TKey, TValue> FNEIOBDLJKM, int ENPOKNEMOMH, TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override SortedList<TKey, TValue> IKNJBMGGGFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class GCJKKICPMPN<TKey, TValue> : GBFAICGCMFB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3691990", Offset = "0x3690790", VA = "0x183691990", Slot = "8")]
	protected override void ANMBPKAMKOK(SortedDictionary<TKey, TValue> FNEIOBDLJKM, int ENPOKNEMOMH, TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x18084AC60", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> GMFECOINAPH(SortedDictionary<TKey, TValue> BKBHNPGBGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x323A120", Offset = "0x3238F20", VA = "0x18323A120", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> IKNJBMGGGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3691B60", Offset = "0x3690960", VA = "0x183691B60", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator EDHHEEMFHOH(SortedDictionary<TKey, TValue> DIIPJIMFFMD)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class BAMNENELEMK<T> : FMHIBLCEFCM<T>, MAFHFNECHNN where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x4660340", Offset = "0x465F140", VA = "0x184660340", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x46600A0", Offset = "0x465EEA0", VA = "0x1846600A0", Slot = "5")]
	public T CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public BAMNENELEMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class LGGOMDHPCOB : FMHIBLCEFCM<IDictionary>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly FMHIBLCEFCM<IDictionary> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x68DA4F0", Offset = "0x68D92F0", VA = "0x1868DA4F0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, IDictionary NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x68DA2C0", Offset = "0x68D90C0", VA = "0x1868DA2C0", Slot = "5")]
	public IDictionary CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public LGGOMDHPCOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class MOLOGOCDEMO : FMHIBLCEFCM<object>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void CODKBLNAEIH(object FPEJENLDMJM, JAENEBDBLKA HNIKDBEHAFP, object NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly HJNOGLODLJN<KeyValuePair<object, CODKBLNAEIH>> PJNMKOBPMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly MFKHLLCMIMF[] HFBFBGDLOPP;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x68DC750", Offset = "0x68DB550", VA = "0x1868DC750")]
	public MOLOGOCDEMO(params MFKHLLCMIMF[] HFBFBGDLOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x68DBD90", Offset = "0x68DAB90", VA = "0x1868DBD90", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, object NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x68DBD00", Offset = "0x68DAB00", VA = "0x1868DBD00", Slot = "5")]
	public object CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class GJJICCOICJH
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x68D68F0", Offset = "0x68D56F0", VA = "0x1868D68F0")]
	public static object LHPDBOGKMHK(Type HFFNCGFKMBJ, [Out] bool FLMPGJHDLOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x68D71E0", Offset = "0x68D5FE0", VA = "0x1868D71E0")]
	public static object PFJKHGEMPMM(Type HFFNCGFKMBJ, [Out] bool FLMPGJHDLOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class LDBCCDHAAHK<T> : FMHIBLCEFCM<T>, MAFHFNECHNN, OLKIFIEDHPJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class DIECJIJMMNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DIECJIJMMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x4F3E430", Offset = "0x4F3D230", VA = "0x184F3E430")]
		internal bool PGCDNEMFKAH(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class BAILPBOJMAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public BAILPBOJMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x465FDB0", Offset = "0x465EBB0", VA = "0x18465FDB0")]
		internal bool HBCAFPHKHHO(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class COMOJFDIDLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public IJDHFOIFIFP<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public COMOJFDIDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4A63D90", Offset = "0x4A62B90", VA = "0x184A63D90")]
		internal void OGPFFPGAAGL(JAENEBDBLKA writer, T value, MFKHLLCMIMF _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class BBOGIMMFEOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public LOFMKIPCOLK<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public BBOGIMMFEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x46611D0", Offset = "0x465FFD0", VA = "0x1846611D0")]
		internal T CDKBCEODLJN(GDGDHLJAODB reader, MFKHLLCMIMF _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly OJGEMOLIKDK<T> AJDJGMHHGDE;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> ONPBOGCGCMM;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly IJDHFOIFIFP<T> EOLANNPMPHP;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly LOFMKIPCOLK<T> IGNMIIEJMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool EKPFDGIEHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly IJDHFOIFIFP<T> AMAHBOGJMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly LOFMKIPCOLK<T> NOHDIADHGOP;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFAA0", Offset = "0x3BAE8A0", VA = "0x183BAFAA0")]
	static LDBCCDHAAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9FA0", Offset = "0x3BB8DA0", VA = "0x183BB9FA0")]
	public LDBCCDHAAHK(bool EKPFDGIEHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAB50", Offset = "0x3BA9950", VA = "0x183BAAB50", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA87C0", Offset = "0x3BA75C0", VA = "0x183BA87C0", Slot = "5")]
	public T CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3BABFD0", Offset = "0x3BAADD0", VA = "0x183BABFD0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, T NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6FE0", Offset = "0x3BA5DE0", VA = "0x183BA6FE0", Slot = "7")]
	public T ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class FIAPHLLCGGN<T> : FMHIBLCEFCM<T[,]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x35CA160", Offset = "0x35C8F60", VA = "0x1835CA160", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T[,] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x35C9E30", Offset = "0x35C8C30", VA = "0x1835C9E30", Slot = "5")]
	public T[,] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public FIAPHLLCGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class HDPEHHBCKJJ<T> : FMHIBLCEFCM<T[,,]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x37800D0", Offset = "0x377EED0", VA = "0x1837800D0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T[,,] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x377FC90", Offset = "0x377EA90", VA = "0x18377FC90", Slot = "5")]
	public T[,,] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HDPEHHBCKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class JENOEGAFLCF<T> : FMHIBLCEFCM<T[,,,]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A276F0", Offset = "0x3A264F0", VA = "0x183A276F0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T[,,,] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A271A0", Offset = "0x3A25FA0", VA = "0x183A271A0", Slot = "5")]
	public T[,,,] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JENOEGAFLCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class DMBMKLBODBG<T> : FMHIBLCEFCM<T?>, MAFHFNECHNN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x4F4DE50", Offset = "0x4F4CC50", VA = "0x184F4DE50", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x4F4DCD0", Offset = "0x4F4CAD0", VA = "0x184F4DCD0", Slot = "5")]
	public T? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public DMBMKLBODBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class KMCCMCPAPOP<T> : FMHIBLCEFCM<T?>, MAFHFNECHNN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly FMHIBLCEFCM<T> EKMBAJGABHN;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public KMCCMCPAPOP(FMHIBLCEFCM<T> EKMBAJGABHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B7E0", Offset = "0x3B0A5E0", VA = "0x183B0B7E0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, T? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3B0AEF0", Offset = "0x3B09CF0", VA = "0x183B0AEF0", Slot = "5")]
	public T? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class CEIKIOMPOKB : FMHIBLCEFCM<sbyte>, MAFHFNECHNN, OLKIFIEDHPJ<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly CEIKIOMPOKB IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x68D1110", Offset = "0x68CFF10", VA = "0x1868D1110", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, sbyte NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x68D10C0", Offset = "0x68CFEC0", VA = "0x1868D10C0", Slot = "5")]
	public sbyte CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x68D1170", Offset = "0x68CFF70", VA = "0x1868D1170", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, sbyte NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x68D1000", Offset = "0x68CFE00", VA = "0x1868D1000", Slot = "7")]
	public sbyte ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CEIKIOMPOKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class FBLEIKGIFKD : FMHIBLCEFCM<sbyte?>, MAFHFNECHNN, OLKIFIEDHPJ<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly FBLEIKGIFKD IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x68D5CD0", Offset = "0x68D4AD0", VA = "0x1868D5CD0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, sbyte? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x68D5C20", Offset = "0x68D4A20", VA = "0x1868D5C20", Slot = "5")]
	public sbyte? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x68D5D90", Offset = "0x68D4B90", VA = "0x1868D5D90", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, sbyte? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x68D5B00", Offset = "0x68D4900", VA = "0x1868D5B00", Slot = "7")]
	public sbyte? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public FBLEIKGIFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class IBFFMAHDAJG : FMHIBLCEFCM<sbyte[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly IBFFMAHDAJG IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x68D8910", Offset = "0x68D7710", VA = "0x1868D8910", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, sbyte[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x68D8780", Offset = "0x68D7580", VA = "0x1868D8780", Slot = "5")]
	public sbyte[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public IBFFMAHDAJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class ICJDPDALBNG : FMHIBLCEFCM<short>, MAFHFNECHNN, OLKIFIEDHPJ<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly ICJDPDALBNG IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x68D8BD0", Offset = "0x68D79D0", VA = "0x1868D8BD0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, short NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x68D8B80", Offset = "0x68D7980", VA = "0x1868D8B80", Slot = "5")]
	public short CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x68D8C30", Offset = "0x68D7A30", VA = "0x1868D8C30", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, short NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x68D8AC0", Offset = "0x68D78C0", VA = "0x1868D8AC0", Slot = "7")]
	public short ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public ICJDPDALBNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class EINEBGPCDPJ : FMHIBLCEFCM<short?>, MAFHFNECHNN, OLKIFIEDHPJ<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly EINEBGPCDPJ IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x68D50F0", Offset = "0x68D3EF0", VA = "0x1868D50F0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, short? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x68D5040", Offset = "0x68D3E40", VA = "0x1868D5040", Slot = "5")]
	public short? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x68D51B0", Offset = "0x68D3FB0", VA = "0x1868D51B0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, short? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x68D4F20", Offset = "0x68D3D20", VA = "0x1868D4F20", Slot = "7")]
	public short? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EINEBGPCDPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class ACEJPPKFDEK : FMHIBLCEFCM<short[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly ACEJPPKFDEK IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x68CE2F0", Offset = "0x68CD0F0", VA = "0x1868CE2F0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, short[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x68CE160", Offset = "0x68CCF60", VA = "0x1868CE160", Slot = "5")]
	public short[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public ACEJPPKFDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class HOACDAGFAHO : FMHIBLCEFCM<int>, MAFHFNECHNN, OLKIFIEDHPJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly HOACDAGFAHO IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x68D7E50", Offset = "0x68D6C50", VA = "0x1868D7E50", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, int NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x68D7E00", Offset = "0x68D6C00", VA = "0x1868D7E00", Slot = "5")]
	public int CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x68D7EB0", Offset = "0x68D6CB0", VA = "0x1868D7EB0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, int NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x68D7D40", Offset = "0x68D6B40", VA = "0x1868D7D40", Slot = "7")]
	public int ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HOACDAGFAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LDPHDLGHOID : FMHIBLCEFCM<int?>, MAFHFNECHNN, OLKIFIEDHPJ<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly LDPHDLGHOID IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x68DA0C0", Offset = "0x68D8EC0", VA = "0x1868DA0C0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, int? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x68DA010", Offset = "0x68D8E10", VA = "0x1868DA010", Slot = "5")]
	public int? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x68DA180", Offset = "0x68D8F80", VA = "0x1868DA180", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, int? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x68D9EF0", Offset = "0x68D8CF0", VA = "0x1868D9EF0", Slot = "7")]
	public int? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public LDPHDLGHOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class BJBDJGKAHHJ : FMHIBLCEFCM<int[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly BJBDJGKAHHJ IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x68D0B00", Offset = "0x68CF900", VA = "0x1868D0B00", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, int[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x68D0970", Offset = "0x68CF770", VA = "0x1868D0970", Slot = "5")]
	public int[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public BJBDJGKAHHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GGKEJCHKDHG : FMHIBLCEFCM<long>, MAFHFNECHNN, OLKIFIEDHPJ<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly GGKEJCHKDHG IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x68D67A0", Offset = "0x68D55A0", VA = "0x1868D67A0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, long NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x68D6750", Offset = "0x68D5550", VA = "0x1868D6750", Slot = "5")]
	public long CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x68D6800", Offset = "0x68D5600", VA = "0x1868D6800", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, long NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x68D6690", Offset = "0x68D5490", VA = "0x1868D6690", Slot = "7")]
	public long ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public GGKEJCHKDHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class KFOJOCKCPPN : FMHIBLCEFCM<long?>, MAFHFNECHNN, OLKIFIEDHPJ<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly KFOJOCKCPPN IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x68D97D0", Offset = "0x68D85D0", VA = "0x1868D97D0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, long? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x68D9710", Offset = "0x68D8510", VA = "0x1868D9710", Slot = "5")]
	public long? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x68D9890", Offset = "0x68D8690", VA = "0x1868D9890", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, long? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x68D95D0", Offset = "0x68D83D0", VA = "0x1868D95D0", Slot = "7")]
	public long? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public KFOJOCKCPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class BCKMOEIMKIN : FMHIBLCEFCM<long[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly BCKMOEIMKIN IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x68D07C0", Offset = "0x68CF5C0", VA = "0x1868D07C0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, long[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x68D0630", Offset = "0x68CF430", VA = "0x1868D0630", Slot = "5")]
	public long[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public BCKMOEIMKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class FAIOGDENDKM : FMHIBLCEFCM<byte>, MAFHFNECHNN, OLKIFIEDHPJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly FAIOGDENDKM IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x68D5660", Offset = "0x68D4460", VA = "0x1868D5660", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, byte NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x68D5610", Offset = "0x68D4410", VA = "0x1868D5610", Slot = "5")]
	public byte CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x68D56C0", Offset = "0x68D44C0", VA = "0x1868D56C0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, byte NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x68D5550", Offset = "0x68D4350", VA = "0x1868D5550", Slot = "7")]
	public byte ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public FAIOGDENDKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class NEKIBAGFEAH : FMHIBLCEFCM<byte?>, MAFHFNECHNN, OLKIFIEDHPJ<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly NEKIBAGFEAH IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x68DC9D0", Offset = "0x68DB7D0", VA = "0x1868DC9D0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, byte? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x68DC920", Offset = "0x68DB720", VA = "0x1868DC920", Slot = "5")]
	public byte? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x68DCA90", Offset = "0x68DB890", VA = "0x1868DCA90", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, byte? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x68DC800", Offset = "0x68DB600", VA = "0x1868DC800", Slot = "7")]
	public byte? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public NEKIBAGFEAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class HPHIDCMJNDH : FMHIBLCEFCM<ushort>, MAFHFNECHNN, OLKIFIEDHPJ<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly HPHIDCMJNDH IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x68D8310", Offset = "0x68D7110", VA = "0x1868D8310", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ushort NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x68D82C0", Offset = "0x68D70C0", VA = "0x1868D82C0", Slot = "5")]
	public ushort CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x68D8370", Offset = "0x68D7170", VA = "0x1868D8370", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, ushort NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x68D8200", Offset = "0x68D7000", VA = "0x1868D8200", Slot = "7")]
	public ushort ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HPHIDCMJNDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class CENLMAPHMIG : FMHIBLCEFCM<ushort?>, MAFHFNECHNN, OLKIFIEDHPJ<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly CENLMAPHMIG IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x68D1430", Offset = "0x68D0230", VA = "0x1868D1430", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ushort? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x68D1380", Offset = "0x68D0180", VA = "0x1868D1380", Slot = "5")]
	public ushort? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x68D14F0", Offset = "0x68D02F0", VA = "0x1868D14F0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, ushort? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x68D1260", Offset = "0x68D0060", VA = "0x1868D1260", Slot = "7")]
	public ushort? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CENLMAPHMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class CKGMPFAMIBJ : FMHIBLCEFCM<ushort[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly CKGMPFAMIBJ IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x68D17C0", Offset = "0x68D05C0", VA = "0x1868D17C0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ushort[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x68D1630", Offset = "0x68D0430", VA = "0x1868D1630", Slot = "5")]
	public ushort[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CKGMPFAMIBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class HPEFPPOAHPB : FMHIBLCEFCM<uint>, MAFHFNECHNN, OLKIFIEDHPJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly HPEFPPOAHPB IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x68D80B0", Offset = "0x68D6EB0", VA = "0x1868D80B0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, uint NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x68D8060", Offset = "0x68D6E60", VA = "0x1868D8060", Slot = "5")]
	public uint CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x68D8110", Offset = "0x68D6F10", VA = "0x1868D8110", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, uint NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x68D7FA0", Offset = "0x68D6DA0", VA = "0x1868D7FA0", Slot = "7")]
	public uint ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HPEFPPOAHPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class AMPDFNDNJHA : FMHIBLCEFCM<uint?>, MAFHFNECHNN, OLKIFIEDHPJ<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly AMPDFNDNJHA IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x68CEF40", Offset = "0x68CDD40", VA = "0x1868CEF40", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, uint? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x68CEE90", Offset = "0x68CDC90", VA = "0x1868CEE90", Slot = "5")]
	public uint? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x68CF000", Offset = "0x68CDE00", VA = "0x1868CF000", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, uint? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x68CED70", Offset = "0x68CDB70", VA = "0x1868CED70", Slot = "7")]
	public uint? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public AMPDFNDNJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class LKKLMINLLCL : FMHIBLCEFCM<uint[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly LKKLMINLLCL IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x68DAE40", Offset = "0x68D9C40", VA = "0x1868DAE40", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, uint[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x68DACB0", Offset = "0x68D9AB0", VA = "0x1868DACB0", Slot = "5")]
	public uint[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public LKKLMINLLCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class DJALNMDEOAF : FMHIBLCEFCM<ulong>, MAFHFNECHNN, OLKIFIEDHPJ<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly DJALNMDEOAF IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x68D2840", Offset = "0x68D1640", VA = "0x1868D2840", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ulong NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x68D27F0", Offset = "0x68D15F0", VA = "0x1868D27F0", Slot = "5")]
	public ulong CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x68D28A0", Offset = "0x68D16A0", VA = "0x1868D28A0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, ulong NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x68D2730", Offset = "0x68D1530", VA = "0x1868D2730", Slot = "7")]
	public ulong ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public DJALNMDEOAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class ACFPNMNMGJG : FMHIBLCEFCM<ulong?>, MAFHFNECHNN, OLKIFIEDHPJ<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly ACFPNMNMGJG IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x68CE6A0", Offset = "0x68CD4A0", VA = "0x1868CE6A0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ulong? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x68CE5E0", Offset = "0x68CD3E0", VA = "0x1868CE5E0", Slot = "5")]
	public ulong? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x68CE760", Offset = "0x68CD560", VA = "0x1868CE760", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, ulong? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x68CE4A0", Offset = "0x68CD2A0", VA = "0x1868CE4A0", Slot = "7")]
	public ulong? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public ACFPNMNMGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class KNCDNPCINAL : FMHIBLCEFCM<ulong[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly KNCDNPCINAL IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x68D9B60", Offset = "0x68D8960", VA = "0x1868D9B60", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ulong[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x68D99D0", Offset = "0x68D87D0", VA = "0x1868D99D0", Slot = "5")]
	public ulong[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public KNCDNPCINAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class MHOKFDDJKML : FMHIBLCEFCM<float>, MAFHFNECHNN, OLKIFIEDHPJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly MHOKFDDJKML IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x68DB9D0", Offset = "0x68DA7D0", VA = "0x1868DB9D0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, float NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x68DB980", Offset = "0x68DA780", VA = "0x1868DB980", Slot = "5")]
	public float CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x68DBA30", Offset = "0x68DA830", VA = "0x1868DBA30", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, float NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x68DB8C0", Offset = "0x68DA6C0", VA = "0x1868DB8C0", Slot = "7")]
	public float ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public MHOKFDDJKML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class FDILPMLDBGK : FMHIBLCEFCM<float?>, MAFHFNECHNN, OLKIFIEDHPJ<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly FDILPMLDBGK IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x68D60A0", Offset = "0x68D4EA0", VA = "0x1868D60A0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, float? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x68D5FF0", Offset = "0x68D4DF0", VA = "0x1868D5FF0", Slot = "5")]
	public float? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x68D6160", Offset = "0x68D4F60", VA = "0x1868D6160", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, float? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x68D5ED0", Offset = "0x68D4CD0", VA = "0x1868D5ED0", Slot = "7")]
	public float? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public FDILPMLDBGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class FAJPKIPEICJ : FMHIBLCEFCM<float[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly FAJPKIPEICJ IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x68D5940", Offset = "0x68D4740", VA = "0x1868D5940", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, float[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x68D57B0", Offset = "0x68D45B0", VA = "0x1868D57B0", Slot = "5")]
	public float[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public FAJPKIPEICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class EJKPOCPHPJP : FMHIBLCEFCM<double>, MAFHFNECHNN, OLKIFIEDHPJ<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly EJKPOCPHPJP IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x68D5400", Offset = "0x68D4200", VA = "0x1868D5400", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, double NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x68D53B0", Offset = "0x68D41B0", VA = "0x1868D53B0", Slot = "5")]
	public double CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x68D5460", Offset = "0x68D4260", VA = "0x1868D5460", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, double NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x68D52F0", Offset = "0x68D40F0", VA = "0x1868D52F0", Slot = "7")]
	public double ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EJKPOCPHPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class IGJJBNBKMGE : FMHIBLCEFCM<double?>, MAFHFNECHNN, OLKIFIEDHPJ<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly IGJJBNBKMGE IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x68D8F20", Offset = "0x68D7D20", VA = "0x1868D8F20", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, double? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x68D8E60", Offset = "0x68D7C60", VA = "0x1868D8E60", Slot = "5")]
	public double? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x68D8FE0", Offset = "0x68D7DE0", VA = "0x1868D8FE0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, double? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x68D8D20", Offset = "0x68D7B20", VA = "0x1868D8D20", Slot = "7")]
	public double? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public IGJJBNBKMGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class LNDLBNGAELL : FMHIBLCEFCM<double[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly LNDLBNGAELL IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x68DB180", Offset = "0x68D9F80", VA = "0x1868DB180", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, double[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x68DAFF0", Offset = "0x68D9DF0", VA = "0x1868DAFF0", Slot = "5")]
	public double[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public LNDLBNGAELL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class LILHDMALMMJ : FMHIBLCEFCM<bool>, MAFHFNECHNN, OLKIFIEDHPJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly LILHDMALMMJ IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x68DAB60", Offset = "0x68D9960", VA = "0x1868DAB60", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, bool NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x68DAB10", Offset = "0x68D9910", VA = "0x1868DAB10", Slot = "5")]
	public bool CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x68DABC0", Offset = "0x68D99C0", VA = "0x1868DABC0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, bool NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x68DAA50", Offset = "0x68D9850", VA = "0x1868DAA50", Slot = "7")]
	public bool ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public LILHDMALMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PAKGKONBILE : FMHIBLCEFCM<bool?>, MAFHFNECHNN, OLKIFIEDHPJ<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PAKGKONBILE IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x68DD9E0", Offset = "0x68DC7E0", VA = "0x1868DD9E0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, bool? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x68DD930", Offset = "0x68DC730", VA = "0x1868DD930", Slot = "5")]
	public bool? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x68DDAA0", Offset = "0x68DC8A0", VA = "0x1868DDAA0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, bool? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x68DD810", Offset = "0x68DC610", VA = "0x1868DD810", Slot = "7")]
	public bool? ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public PAKGKONBILE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class BPEAGAMLBDL : FMHIBLCEFCM<bool[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly BPEAGAMLBDL IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x68D0E40", Offset = "0x68CFC40", VA = "0x1868D0E40", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, bool[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x68D0CB0", Offset = "0x68CFAB0", VA = "0x1868D0CB0", Slot = "5")]
	public bool[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public BPEAGAMLBDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class BAENOJOHBKE : FMHIBLCEFCM<object>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly FMHIBLCEFCM<object> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> LPNBIHOBIOP;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x68CF580", Offset = "0x68CE380", VA = "0x1868CF580", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, object NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x68CF140", Offset = "0x68CDF40", VA = "0x1868CF140", Slot = "5")]
	public object CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public BAENOJOHBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class KALMBFMCPCC : FMHIBLCEFCM<byte[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly FMHIBLCEFCM<byte[]> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x68D9490", Offset = "0x68D8290", VA = "0x1868D9490", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, byte[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x68D93E0", Offset = "0x68D81E0", VA = "0x1868D93E0", Slot = "5")]
	public byte[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public KALMBFMCPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class JEPFGBNGMHF : FMHIBLCEFCM<ArraySegment<byte>>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly FMHIBLCEFCM<ArraySegment<byte>> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x68D9230", Offset = "0x68D8030", VA = "0x1868D9230", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, ArraySegment<byte> NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x68D9120", Offset = "0x68D7F20", VA = "0x1868D9120", Slot = "5")]
	public ArraySegment<byte> CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JEPFGBNGMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class MMDMBENLACB : FMHIBLCEFCM<string>, MAFHFNECHNN, OLKIFIEDHPJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly FMHIBLCEFCM<string> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x68DBBC0", Offset = "0x68DA9C0", VA = "0x1868DBBC0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, string NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x68DBB70", Offset = "0x68DA970", VA = "0x1868DBB70", Slot = "5")]
	public string CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x68DBC20", Offset = "0x68DAA20", VA = "0x1868DBC20", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, string NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x68DBB20", Offset = "0x68DA920", VA = "0x1868DBB20", Slot = "7")]
	public string ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public MMDMBENLACB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class PMOGOAAFOKH : FMHIBLCEFCM<string[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly PMOGOAAFOKH IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x68DF300", Offset = "0x68DE100", VA = "0x1868DF300", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, string[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x68DF130", Offset = "0x68DDF30", VA = "0x1868DF130", Slot = "5")]
	public string[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public PMOGOAAFOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class GMFCLDLFHBK : FMHIBLCEFCM<char>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly GMFCLDLFHBK IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x68D7B40", Offset = "0x68D6940", VA = "0x1868D7B40", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, char NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x68D7AD0", Offset = "0x68D68D0", VA = "0x1868D7AD0", Slot = "5")]
	public char CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public GMFCLDLFHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class NJBDABMAEHG : FMHIBLCEFCM<char?>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly NJBDABMAEHG IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x68DCCF0", Offset = "0x68DBAF0", VA = "0x1868DCCF0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, char? NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x68DCBD0", Offset = "0x68DB9D0", VA = "0x1868DCBD0", Slot = "5")]
	public char? CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public NJBDABMAEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class FPFKEHKAACF : FMHIBLCEFCM<char[]>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly FPFKEHKAACF IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x68D6460", Offset = "0x68D5260", VA = "0x1868D6460", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, char[] NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x68D62A0", Offset = "0x68D50A0", VA = "0x1868D62A0", Slot = "5")]
	public char[] CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public FPFKEHKAACF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class NMPGIHGPHIN : FMHIBLCEFCM<Guid>, MAFHFNECHNN, OLKIFIEDHPJ<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly FMHIBLCEFCM<Guid> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x68DCFA0", Offset = "0x68DBDA0", VA = "0x1868DCFA0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, Guid NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x68DCF10", Offset = "0x68DBD10", VA = "0x1868DCF10", Slot = "5")]
	public Guid CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x68DD0D0", Offset = "0x68DBED0", VA = "0x1868DD0D0", Slot = "6")]
	public void LLMOLNCJOLO(JAENEBDBLKA HNIKDBEHAFP, Guid NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x68DCE70", Offset = "0x68DBC70", VA = "0x1868DCE70", Slot = "7")]
	public Guid ANNPDGLNGHK(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public NMPGIHGPHIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class AGOFNJHLLMI : FMHIBLCEFCM<decimal>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly FMHIBLCEFCM<decimal> IEMILNCFJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool GBHJFIDANDG;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5178DC0", Offset = "0x5177BC0", VA = "0x185178DC0")]
	public AGOFNJHLLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x174A800", Offset = "0x1749600", VA = "0x18174A800")]
	public AGOFNJHLLMI(bool GBHJFIDANDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x68CEB40", Offset = "0x68CD940", VA = "0x1868CEB40", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, decimal NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x68CE8A0", Offset = "0x68CD6A0", VA = "0x1868CE8A0", Slot = "5")]
	public decimal CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class PODHJHCJOMC : FMHIBLCEFCM<Uri>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly FMHIBLCEFCM<Uri> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x68DF570", Offset = "0x68DE370", VA = "0x1868DF570", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, Uri NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x68DF4B0", Offset = "0x68DE2B0", VA = "0x1868DF4B0", Slot = "5")]
	public Uri CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public PODHJHCJOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class EGCDEBMDEFJ : FMHIBLCEFCM<Version>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly FMHIBLCEFCM<Version> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x68D4DE0", Offset = "0x68D3BE0", VA = "0x1868D4DE0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, Version NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x68D4D20", Offset = "0x68D3B20", VA = "0x1868D4D20", Slot = "5")]
	public Version CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EGCDEBMDEFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class NGPNGEHMHPN<TKey, TValue> : FMHIBLCEFCM<KeyValuePair<TKey, TValue>>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3E6B280", Offset = "0x3E6A080", VA = "0x183E6B280", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, KeyValuePair<TKey, TValue> NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3E6AF50", Offset = "0x3E69D50", VA = "0x183E6AF50", Slot = "5")]
	public KeyValuePair<TKey, TValue> CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class LAHEBMFLCAB : FMHIBLCEFCM<StringBuilder>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly FMHIBLCEFCM<StringBuilder> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x68D9DD0", Offset = "0x68D8BD0", VA = "0x1868D9DD0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, StringBuilder NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x68D9D10", Offset = "0x68D8B10", VA = "0x1868D9D10", Slot = "5")]
	public StringBuilder CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public LAHEBMFLCAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class IBENCDIPAPD : FMHIBLCEFCM<BitArray>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly FMHIBLCEFCM<BitArray> IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x68D85E0", Offset = "0x68D73E0", VA = "0x1868D85E0", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, BitArray NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x68D8460", Offset = "0x68D7260", VA = "0x1868D8460", Slot = "5")]
	public BitArray CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public IBENCDIPAPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class MAIIBCLKKIN : FMHIBLCEFCM<Type>, MAFHFNECHNN
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly MAIIBCLKKIN IEMILNCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex AKKEFJCGIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool MIECHLJJFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool DGIFMMABCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool ANIHCMPLMMP;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x68DB690", Offset = "0x68DA490", VA = "0x1868DB690")]
	public MAIIBCLKKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F01240", Offset = "0x5F00040", VA = "0x185F01240")]
	public MAIIBCLKKIN(bool MIECHLJJFIA, bool DGIFMMABCAL, bool ANIHCMPLMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x68DB490", Offset = "0x68DA290", VA = "0x1868DB490", Slot = "4")]
	public void FILLENIGNNA(JAENEBDBLKA HNIKDBEHAFP, Type NKKIECLCEML, MFKHLLCMIMF DLBDIANECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x68DB340", Offset = "0x68DA140", VA = "0x1868DB340", Slot = "5")]
	public Type CINNELLPCMC(GDGDHLJAODB FECOEFBKMHD, MFKHLLCMIMF DLBDIANECNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class MBGACPPPHMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] JELIOFBEKAB;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly LOBIPGHMALA DFDGNODIOPM;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x68DB6B0", Offset = "0x68DA4B0", VA = "0x1868DB6B0")]
	static MBGACPPPHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class PLLBJEDIKEN
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] MONMKBNDDBH;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly LOBIPGHMALA OGGPNBBCAKK;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x68DEF20", Offset = "0x68DDD20", VA = "0x1868DEF20")]
	static PLLBJEDIKEN()
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
