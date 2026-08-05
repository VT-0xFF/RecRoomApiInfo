using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NCHAHPEJOHP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x573C00", Offset = "0x572200", VA = "0x180573C00")]
	public NCHAHPEJOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JMPOMOEHBEK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x573C00", Offset = "0x572200", VA = "0x180573C00")]
	public JMPOMOEHBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PECAOIMMBMK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x573C00", Offset = "0x572200", VA = "0x180573C00")]
	public PECAOIMMBMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class KLODLGJJEHG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x573C00", Offset = "0x572200", VA = "0x180573C00")]
	public KLODLGJJEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class ICDFOBBGFMO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1380C70", Offset = "0x137F270", VA = "0x181380C70")]
	public static bool EKJAPEIKIOO(this TypeInfo JOBKDGGGOHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class JLAHNCCJADE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type ENCEIDLBBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] FBHNBBKIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xAEE150", Offset = "0xAEC750", VA = "0x180AEE150")]
	public JLAHNCCJADE(Type AKOFFEIFEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class PMHHLNDKAMI : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void EEMFCFNOAAO<T>(ref BMPIEHNPJPN HDBDALLEDMH, T JKOBKIEBPCF, FHMJHOEAOJN PFKPALHDKBE);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T KKELLOHBMEP<T>(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN PFKPALHDKBE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CMAFIOMAECA
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CIMPKNEDLLC<T> : CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, T JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GNDMFBGILML<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, T JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ELNHALMMBPB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CIMPKNEDLLC<T> OHOCFLIKECK<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CHOBKHAHBPM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x412DCE0", Offset = "0x412C2E0", VA = "0x18412DCE0")]
	public static global::CIMPKNEDLLC<T> MOHPIBBMMKF<T>(this FHMJHOEAOJN PFKPALHDKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1634550", Offset = "0x1632B50", VA = "0x181634550")]
	public static object FDNEAALJOHN(this FHMJHOEAOJN PFKPALHDKBE, Type JOBKDGGGOHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MHPKLHIFGMG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3084030", Offset = "0x3082630", VA = "0x183084030")]
	public MHPKLHIFGMG(string MIKDPIOIEJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NFEFKHAFCLC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class ACDAKENNILC
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] LFIKNNODPFA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] CNNIFJCBAGH;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x307FC40", Offset = "0x307E240", VA = "0x18307FC40")]
		public static byte[] OHCPAAMGGIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x307FCC0", Offset = "0x307E2C0", VA = "0x18307FCC0")]
		public static char[] PNMMMPBLHHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> BGJLHOFJOJG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] HNPGHDELEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] FBEAOBEALBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int MPKAJNKONAC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool NJBDBBAIOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3088B50", Offset = "0x3087150", VA = "0x183088B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3089EC0", Offset = "0x30884C0", VA = "0x183089EC0")]
	public NFEFKHAFCLC(byte[] FBEAOBEALBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3089CE0", Offset = "0x30882E0", VA = "0x183089CE0")]
	public NFEFKHAFCLC(byte[] FBEAOBEALBD, int MPKAJNKONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3088110", Offset = "0x3086710", VA = "0x183088110")]
	private AGIOKPGGHEA EBOOABEDCPN(string JJBAPHDLOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3089230", Offset = "0x3087830", VA = "0x183089230")]
	private AGIOKPGGHEA JMJJMPDMFHM(string MIKDPIOIEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x162F040", Offset = "0x162D640", VA = "0x18162F040")]
	public void PFMDNFNIPIC(int MPKAJNKONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB50", Offset = "0x5AC150", VA = "0x1805ADB50")]
	public byte[] KAEDKNMBJBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA1E980", Offset = "0xA1CF80", VA = "0x180A1E980")]
	public int EOOBAEBHHHJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3089930", Offset = "0x3087F30", VA = "0x183089930")]
	public HOJOLMAPEMA ONNPBINBBPN()
	{
		return default(HOJOLMAPEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3089AC0", Offset = "0x30880C0", VA = "0x183089AC0")]
	public void OOKILJMMAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x30895B0", Offset = "0x3087BB0", VA = "0x1830895B0")]
	public bool OABOEFJCDPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3089540", Offset = "0x3087B40", VA = "0x183089540")]
	public bool NNIGMBJDCEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30872A0", Offset = "0x30858A0", VA = "0x1830872A0")]
	public void ADNJJFIDNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3088E40", Offset = "0x3087440", VA = "0x183088E40")]
	public bool INKAOJKHLGJ(ref int JKKHOEKMJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30880A0", Offset = "0x30866A0", VA = "0x1830880A0")]
	public bool DLNHLBKNKHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3088DA0", Offset = "0x30873A0", VA = "0x183088DA0")]
	public void HPAIJIJNKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3087E90", Offset = "0x3086490", VA = "0x183087E90")]
	public bool DFAEPBAFEBH(ref int JKKHOEKMJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3088AE0", Offset = "0x30870E0", VA = "0x183088AE0")]
	public bool GMPOHILBBDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x30888F0", Offset = "0x3086EF0", VA = "0x1830888F0")]
	public void GJGMLCALFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30891C0", Offset = "0x30877C0", VA = "0x1830891C0")]
	public bool JEOBGHLBDHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3087DF0", Offset = "0x30863F0", VA = "0x183087DF0")]
	public void CHFIHLIHBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30875A0", Offset = "0x3085BA0", VA = "0x1830875A0")]
	private void BCMCDDAMFLF(out byte[] GBHJBGDHENJ, out int NENFINIKPEL, out int HKDKBNAICIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3087D40", Offset = "0x3086340", VA = "0x183087D40")]
	private static int BLCBLIKDMLO(char LFCBLKFDHFN, char BFBDMMHDNGP, char NJEFHOCCNNG, char GFFIMIPBJKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3088CD0", Offset = "0x30872D0", VA = "0x183088CD0")]
	private static int HOAFMNAFFKE(char AEIHHPIDBGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3088990", Offset = "0x3086F90", VA = "0x183088990")]
	public ArraySegment<byte> GLMHCAACOLH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3088730", Offset = "0x3086D30", VA = "0x183088730")]
	public string EPIANOJOGDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3089900", Offset = "0x3087F00", VA = "0x183089900")]
	public string OMIONBEIGIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3089010", Offset = "0x3087610", VA = "0x183089010")]
	public ArraySegment<byte> JENNCPKGJHO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3088C90", Offset = "0x3087290", VA = "0x183088C90")]
	public ArraySegment<byte> HMOHONIDKLB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3087340", Offset = "0x3085940", VA = "0x183087340")]
	public bool BBGIBFCGDGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3088670", Offset = "0x3086C70", VA = "0x183088670")]
	private static bool EONOKAABMOG(byte NJEFHOCCNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x30896D0", Offset = "0x3087CD0", VA = "0x1830896D0")]
	private void OECBHBGEHLP(HOJOLMAPEMA GAAIDBMHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3087D30", Offset = "0x3086330", VA = "0x183087D30")]
	public void BFODLDIKOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3088820", Offset = "0x3086E20", VA = "0x183088820")]
	private void GIENGKAOAPD(int HKDJAEGMFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30887D0", Offset = "0x3086DD0", VA = "0x1830887D0")]
	public sbyte GGDJDDMJAMI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30885B0", Offset = "0x3086BB0", VA = "0x1830885B0")]
	public short EENONJNKJGP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3088A80", Offset = "0x3087080", VA = "0x183088A80")]
	public int GLNDAHNMBMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3089430", Offset = "0x3087A30", VA = "0x183089430")]
	public long LDJMHDNNJGD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3088610", Offset = "0x3086C10", VA = "0x183088610")]
	public byte EGJBKMPKKPH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x30893D0", Offset = "0x30879D0", VA = "0x1830893D0")]
	public ushort KEGINFANPIO()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x30898A0", Offset = "0x3087EA0", VA = "0x1830898A0")]
	public uint OKHIKEJNOHN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3088ED0", Offset = "0x30874D0", VA = "0x183088ED0")]
	public ulong JAIHKIPPPFB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3089310", Offset = "0x3087910", VA = "0x183089310")]
	public float KDINPMDENPF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3088F50", Offset = "0x3087550", VA = "0x183088F50")]
	public double JEGJMDEACHO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3088B70", Offset = "0x3087170", VA = "0x183088B70")]
	public ArraySegment<byte> HMBAMPEFHJM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3087F20", Offset = "0x3086520", VA = "0x183087F20")]
	private static int DLBKIHLCBLN(byte[] FBEAOBEALBD, int MPKAJNKONAC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AGIOKPGGHEA : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference OIOFENPLKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int JCLPFALKIOI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int MJLHDGOFPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x162A4D0", Offset = "0x1628AD0", VA = "0x18162A4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DGCBNEMDAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8F3600", Offset = "0x8F1C00", VA = "0x1808F3600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x162A4E0", Offset = "0x1628AE0", VA = "0x18162A4E0")]
	public AGIOKPGGHEA(string MIKDPIOIEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x162A550", Offset = "0x1628B50", VA = "0x18162A550")]
	public AGIOKPGGHEA(string MIKDPIOIEJH, byte[] LCHBLBHCCPM, int MPKAJNKONAC, int JCLPFALKIOI, string EECJMNBMIKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MFHBINBPILI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class PAIHGFDFECM
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void AFFFAPBLOAN(ref BMPIEHNPJPN HDBDALLEDMH, object JKOBKIEBPCF, FHMJHOEAOJN PFKPALHDKBE);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object GOKHEKGJNNP(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN PFKPALHDKBE);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class CFNIFLLKFID
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class FEDDCGOGMMF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
				public FEDDCGOGMMF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x306B0C0", Offset = "0x30696C0", VA = "0x18306B0C0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x3082320", Offset = "0x3080920", VA = "0x183082320")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, FHMJHOEAOJN, byte[]> NPKHOKJGCMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, FHMJHOEAOJN> AHNKLAHKEDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly AFFFAPBLOAN OFAHJMPGHBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, FHMJHOEAOJN, ArraySegment<byte>> EEDHMOAGFJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, FHMJHOEAOJN, string> MHPDHOMOEIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, FHMJHOEAOJN, object> EDIPDFJKKDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, FHMJHOEAOJN, object> LPNKEIBPBDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, FHMJHOEAOJN, object> NEKMNHCJDLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly GOKHEKGJNNP PGCAEGCEMKM;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x30801D0", Offset = "0x307E7D0", VA = "0x1830801D0")]
			public CFNIFLLKFID(Type JOBKDGGGOHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x402A200", Offset = "0x4028800", VA = "0x18402A200")]
			private static T HKHFCCDGOHF<T>(DynamicMethod OIBFDJMKGDP)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x307FFE0", Offset = "0x307E5E0", VA = "0x18307FFE0")]
			private static MethodInfo LAGNJDKONNI(Type JOBKDGGGOHC, string EIBLJOLNOMI, Type[] KIINFILDMBP)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, CFNIFLLKFID> AHJKEOPEGKM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::FGFFMNAANKL<CFNIFLLKFID> KAMFNDFFCJH;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x308B9B0", Offset = "0x3089FB0", VA = "0x18308B9B0")]
		static PAIHGFDFECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x308B930", Offset = "0x3089F30", VA = "0x18308B930")]
		private static CFNIFLLKFID IFJNNJONMOF(Type JOBKDGGGOHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x308B7C0", Offset = "0x3089DC0", VA = "0x18308B7C0")]
		public static void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, object JKOBKIEBPCF, FHMJHOEAOJN PFKPALHDKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x308B6B0", Offset = "0x3089CB0", VA = "0x18308B6B0")]
		public static void HINACFMEGJE(Type JOBKDGGGOHC, ref BMPIEHNPJPN HDBDALLEDMH, object JKOBKIEBPCF, FHMJHOEAOJN PFKPALHDKBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class MCMMJLHFEID
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] LFIKNNODPFA;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x30828D0", Offset = "0x3080ED0", VA = "0x1830828D0")]
		public static byte[] OHCPAAMGGIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static FHMJHOEAOJN IPONFLLOGEG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] MDBDNEJHOIL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] IMJKEHNNAFL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FHMJHOEAOJN AMEOJMAPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3082A40", Offset = "0x3081040", VA = "0x183082A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x484AF60", Offset = "0x4849560", VA = "0x18484AF60")]
	public static string LJIKAAAGAOL<T>(T JKOBKIEBPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x484AFE0", Offset = "0x48495E0", VA = "0x18484AFE0")]
	public static string LJIKAAAGAOL<T>(T JKOBKIEBPCF, FHMJHOEAOJN PFKPALHDKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x40386E0", Offset = "0x4036CE0", VA = "0x1840386E0")]
	public static T BJFPGPPGGLJ<T>(string NMOCOBJFOHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x40387E0", Offset = "0x4036DE0", VA = "0x1840387E0")]
	public static T BJFPGPPGGLJ<T>(string NMOCOBJFOHM, FHMJHOEAOJN PFKPALHDKBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4038760", Offset = "0x4036D60", VA = "0x184038760")]
	public static T BJFPGPPGGLJ<T>(byte[] FBEAOBEALBD, FHMJHOEAOJN PFKPALHDKBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40388B0", Offset = "0x4036EB0", VA = "0x1840388B0")]
	public static T BJFPGPPGGLJ<T>(byte[] FBEAOBEALBD, int MPKAJNKONAC, FHMJHOEAOJN PFKPALHDKBE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HOJOLMAPEMA : byte
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
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BMPIEHNPJPN
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] ALEBFHPBNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] LFIKNNODPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int MPKAJNKONAC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JBDLJELDDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1E980", Offset = "0xA1CF80", VA = "0x180A1E980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x162F040", Offset = "0x162D640", VA = "0x18162F040")]
	public void PFMDNFNIPIC(int MPKAJNKONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x162E1D0", Offset = "0x162C7D0", VA = "0x18162E1D0")]
	public static byte[] FIHBGEIBAHK(string LHCFNFMPBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x162EC40", Offset = "0x162D240", VA = "0x18162EC40")]
	public static byte[] OBIICGNMIDA(string LHCFNFMPBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x162E480", Offset = "0x162CA80", VA = "0x18162E480")]
	public static byte[] KGJMGIHLEEK(string LHCFNFMPBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x162DFC0", Offset = "0x162C5C0", VA = "0x18162DFC0")]
	public static byte[] CLNCJOPKLIO(string LHCFNFMPBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x162F110", Offset = "0x162D710", VA = "0x18162F110")]
	public BMPIEHNPJPN(byte[] PINNKCCEHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x162EE20", Offset = "0x162D420", VA = "0x18162EE20")]
	public ArraySegment<byte> OHCPAAMGGIH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x162E7A0", Offset = "0x162CDA0", VA = "0x18162E7A0")]
	public byte[] LJEKJBFPMNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x162F060", Offset = "0x162D660", VA = "0x18162F060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x162F050", Offset = "0x162D650", VA = "0x18162F050")]
	public void PKCAIMEKGBP(int LFIPBHFFNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x162DF60", Offset = "0x162C560", VA = "0x18162DF60")]
	public void CKMEPDODHHC(byte[] DLJCFKCPNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x162E3C0", Offset = "0x162C9C0", VA = "0x18162E3C0")]
	public void JCOLEEGNHOG(byte DLJCFKCPNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x162E430", Offset = "0x162CA30", VA = "0x18162E430")]
	public void JPBEPLGDHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x162E120", Offset = "0x162C720", VA = "0x18162E120")]
	public void CNOFFAEMHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x162DF10", Offset = "0x162C510", VA = "0x18162DF10")]
	public void CKKCDMNCDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x162E820", Offset = "0x162CE20", VA = "0x18162E820")]
	public void MHGGHKPIFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x162EED0", Offset = "0x162D4D0", VA = "0x18162EED0")]
	public void OKKOKIHHKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x162DEC0", Offset = "0x162C4C0", VA = "0x18162DEC0")]
	public void BOPDCJJEKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x162DE60", Offset = "0x162C460", VA = "0x18162DE60")]
	public void ABDLGMPAKIA(string LHCFNFMPBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x162EF20", Offset = "0x162D520", VA = "0x18162EF20")]
	public void OKPCPJOBBHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x162EF70", Offset = "0x162D570", VA = "0x18162EF70")]
	public void PAKECHICCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x162E5B0", Offset = "0x162CBB0", VA = "0x18162E5B0")]
	public void LDKNNFCEBHH(bool JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x162E2E0", Offset = "0x162C8E0", VA = "0x18162E2E0")]
	public void HDJIKMMNHDP(float JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x162EDA0", Offset = "0x162D3A0", VA = "0x18162EDA0")]
	public void OGNFJNFOHOP(double JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x162E170", Offset = "0x162C770", VA = "0x18162E170")]
	public void DGIKGJMKEOI(byte JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x162E360", Offset = "0x162C960", VA = "0x18162E360")]
	public void HJKLHEEJNLL(ushort JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x162E2B0", Offset = "0x162C8B0", VA = "0x18162E2B0")]
	public void GCGAJBJGCKJ(uint JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x162E1A0", Offset = "0x162C7A0", VA = "0x18162E1A0")]
	public void EJCEKMCCAGG(ulong JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x162E400", Offset = "0x162CA00", VA = "0x18162E400")]
	public void JGLNAPEFECL(sbyte JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x162E390", Offset = "0x162C990", VA = "0x18162E390")]
	public void IONOLHOMHNN(short JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x162ED70", Offset = "0x162D370", VA = "0x18162ED70")]
	public void ODNAKLMIOOF(int JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x162DE30", Offset = "0x162C430", VA = "0x18162DE30")]
	public void AADHHBPOHBG(long JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x162E870", Offset = "0x162CE70", VA = "0x18162E870")]
	public void MKIPJJGLFKJ(string JKOBKIEBPCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ENNNFLMDKAL : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class NKNIPDKIGGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E5C2C0", Offset = "0x1E5A8C0", VA = "0x181E5C2C0")]
		static NKNIPDKIGGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private ENNNFLMDKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class EFHJNLHFGCO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> DFCLEMJOGDC;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x13786D0", Offset = "0x1376CD0", VA = "0x1813786D0")]
	static EFHJNLHFGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1378170", Offset = "0x1376770", VA = "0x181378170")]
	internal static object OHOCFLIKECK(Type DNABKMDOJNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GJBBAJGNFOC : global::CIMPKNEDLLC<Vector2>, CMAFIOMAECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LMHOAIBICCD FOLFPJIALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] BGMOEBDDPKL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x137C3E0", Offset = "0x137A9E0", VA = "0x18137C3E0")]
	public GJBBAJGNFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x137C330", Offset = "0x137A930", VA = "0x18137C330", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Vector2 JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x137C140", Offset = "0x137A740", VA = "0x18137C140", Slot = "5")]
	public Vector2 BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class INKGFDLPFLO : global::CIMPKNEDLLC<Vector3>, CMAFIOMAECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LMHOAIBICCD FOLFPJIALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] BGMOEBDDPKL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1383530", Offset = "0x1381B30", VA = "0x181383530")]
	public INKGFDLPFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1383410", Offset = "0x1381A10", VA = "0x181383410", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Vector3 JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x13831D0", Offset = "0x13817D0", VA = "0x1813831D0", Slot = "5")]
	public Vector3 BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HHIOPGDFIOL : global::CIMPKNEDLLC<Vector4>, CMAFIOMAECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly LMHOAIBICCD FOLFPJIALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] BGMOEBDDPKL;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x137CD10", Offset = "0x137B310", VA = "0x18137CD10")]
	public HHIOPGDFIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1379470", Offset = "0x1377A70", VA = "0x181379470", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Vector4 JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x137CA80", Offset = "0x137B080", VA = "0x18137CA80", Slot = "5")]
	public Vector4 BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class EKCHMFCPIAF : global::CIMPKNEDLLC<Quaternion>, CMAFIOMAECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LMHOAIBICCD FOLFPJIALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] BGMOEBDDPKL;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x13795C0", Offset = "0x1377BC0", VA = "0x1813795C0")]
	public EKCHMFCPIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1379470", Offset = "0x1377A70", VA = "0x181379470", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Quaternion JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x13791E0", Offset = "0x13777E0", VA = "0x1813791E0", Slot = "5")]
	public Quaternion BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class AJEOEINDIDG : global::CIMPKNEDLLC<Color>, CMAFIOMAECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LMHOAIBICCD FOLFPJIALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] BGMOEBDDPKL;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x162AE10", Offset = "0x1629410", VA = "0x18162AE10")]
	public AJEOEINDIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x162ABA0", Offset = "0x16291A0", VA = "0x18162ABA0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Color JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x162A970", Offset = "0x1628F70", VA = "0x18162A970", Slot = "5")]
	public Color BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class PNELCIMLPDC : global::CIMPKNEDLLC<Bounds>, CMAFIOMAECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LMHOAIBICCD FOLFPJIALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] BGMOEBDDPKL;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x308CBA0", Offset = "0x308B1A0", VA = "0x18308CBA0")]
	public PNELCIMLPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x308C930", Offset = "0x308AF30", VA = "0x18308C930", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Bounds JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x308C580", Offset = "0x308AB80", VA = "0x18308C580", Slot = "5")]
	public Bounds BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class LPJPDPFOPMI : global::CIMPKNEDLLC<Rect>, CMAFIOMAECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly LMHOAIBICCD FOLFPJIALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] BGMOEBDDPKL;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x138CA10", Offset = "0x138B010", VA = "0x18138CA10")]
	public LPJPDPFOPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x138C8A0", Offset = "0x138AEA0", VA = "0x18138C8A0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Rect JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x138C5F0", Offset = "0x138ABF0", VA = "0x18138C5F0", Slot = "5")]
	public Rect BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class MHLOIBCJFGN : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class GFBLDABGPJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x21CD7B0", Offset = "0x21CBDB0", VA = "0x1821CD7B0")]
		static GFBLDABGPJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private MHLOIBCJFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class BOEGHFJICHC : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class EIMBONHADMM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2133CC0", Offset = "0x21322C0", VA = "0x182133CC0")]
		static EIMBONHADMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class CCMKOLPFFGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> AAKDDGCPNCL;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1632630", Offset = "0x1630C30", VA = "0x181632630")]
		internal static object OHOCFLIKECK(Type DNABKMDOJNG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private BOEGHFJICHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class PEEJKJCDHOP : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class OIINEPHLGLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x47EB710", Offset = "0x47E9D10", VA = "0x1847EB710")]
		static OIINEPHLGLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private PEEJKJCDHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NAOGLPMDHLO
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly FHMJHOEAOJN PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly FHMJHOEAOJN OAGIBBDIEAL;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly FHMJHOEAOJN DKHALJJMENM;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly FHMJHOEAOJN DOKKGDKBFCM;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly FHMJHOEAOJN POKBIGLDHKG;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly FHMJHOEAOJN BBCKHJDKBGE;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly FHMJHOEAOJN IDMGOBAMJEG;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly FHMJHOEAOJN FDKEMKLHBEP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly FHMJHOEAOJN PIOILJHAONL;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly FHMJHOEAOJN PNNMMOGNKKB;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FHMJHOEAOJN LFGLIMHEEIE;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly FHMJHOEAOJN AGHDLBECCND;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class IHALHLOGAIC
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly FHMJHOEAOJN PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly FHMJHOEAOJN FCIKNEONGCL;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PKAGOCLDFAE
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly FHMJHOEAOJN PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly FHMJHOEAOJN OAGIBBDIEAL;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FHMJHOEAOJN DKHALJJMENM;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly FHMJHOEAOJN DOKKGDKBFCM;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly FHMJHOEAOJN POKBIGLDHKG;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly FHMJHOEAOJN BBCKHJDKBGE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FHMJHOEAOJN IDMGOBAMJEG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly FHMJHOEAOJN FDKEMKLHBEP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly FHMJHOEAOJN PIOILJHAONL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly FHMJHOEAOJN PNNMMOGNKKB;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly FHMJHOEAOJN LFGLIMHEEIE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly FHMJHOEAOJN AGHDLBECCND;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class HOMDGAKLDKG
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly Dictionary<Type, Type> AAKDDGCPNCL;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x137EC40", Offset = "0x137D240", VA = "0x18137EC40")]
	internal static object OHOCFLIKECK(Type DNABKMDOJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x137EC00", Offset = "0x137D200", VA = "0x18137EC00")]
	private static object CEEPKIANMDM(Type HBMDNAPNMCL, Type[] BKFGGFDNAGC, params object[] KIINFILDMBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MFBNOKEPMPP : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class OCHHJGLLEEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x21E4660", Offset = "0x21E2C60", VA = "0x1821E4660")]
		static OCHHJGLLEEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly CBFPIFNGLMD PGODECFKBFH;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3082950", Offset = "0x3080F50", VA = "0x183082950")]
	static MFBNOKEPMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private MFBNOKEPMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class JKGGDFGDOKC : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class HJAEOIKPDOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x13C4AF0", Offset = "0x13C30F0", VA = "0x1813C4AF0")]
		static HJAEOIKPDOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly CBFPIFNGLMD PGODECFKBFH;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x13860D0", Offset = "0x13846D0", VA = "0x1813860D0")]
	static JKGGDFGDOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private JKGGDFGDOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class FEOLFOGKGJG : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class KHIMBFGABAI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x46984C0", Offset = "0x4696AC0", VA = "0x1846984C0")]
		static KHIMBFGABAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly CBFPIFNGLMD PGODECFKBFH;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x137A430", Offset = "0x1378A30", VA = "0x18137A430")]
	static FEOLFOGKGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private FEOLFOGKGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class FMJHDILEJMK : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PLLLFCLADGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x24D6770", Offset = "0x24D4D70", VA = "0x1824D6770")]
		static PLLLFCLADGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly CBFPIFNGLMD PGODECFKBFH;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x137AA90", Offset = "0x1379090", VA = "0x18137AA90")]
	static FMJHDILEJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private FMJHDILEJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class EMMKJCFJJDF : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class GMJDHLCHLLO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E59C70", Offset = "0x1E58270", VA = "0x181E59C70")]
		static GMJDHLCHLLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly CBFPIFNGLMD PGODECFKBFH;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1379A20", Offset = "0x1378020", VA = "0x181379A20")]
	static EMMKJCFJJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private EMMKJCFJJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class LIEMHCKOBAM : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class AJNCCDKNMJL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1D56FD0", Offset = "0x1D555D0", VA = "0x181D56FD0")]
		static AJNCCDKNMJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly CBFPIFNGLMD PGODECFKBFH;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1389610", Offset = "0x1387C10", VA = "0x181389610")]
	static LIEMHCKOBAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private LIEMHCKOBAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class LBNOFEOJPMB : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class PPPPNPCKGEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x40E4D20", Offset = "0x40E3320", VA = "0x1840E4D20")]
		static PPPPNPCKGEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public LBNOFEOJPMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class DMCAODODCDE : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class NAGFHBLILND<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x171ACD0", Offset = "0x17192D0", VA = "0x18171ACD0")]
		static NAGFHBLILND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public DMCAODODCDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class DGCFKHJMHJD : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class DEFODNEPOLM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x40FD7A0", Offset = "0x40FBDA0", VA = "0x1840FD7A0")]
		static DEFODNEPOLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public DGCFKHJMHJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DMCBGFDAFMJ : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class IENNCCLBMPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x17162C0", Offset = "0x17148C0", VA = "0x1817162C0")]
		static IENNCCLBMPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public DMCBGFDAFMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class HKLHCOLDMCC : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class JPKHOMCFELK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1571A90", Offset = "0x1570090", VA = "0x181571A90")]
		static JPKHOMCFELK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public HKLHCOLDMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class MGJOHOLNCBJ : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class CKFBABLDLAM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x21C93B0", Offset = "0x21C79B0", VA = "0x1821C93B0")]
		static CKFBABLDLAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static readonly Func<string, string> NMHJPDCJOCH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly bool GGHBPHGPPAK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public MGJOHOLNCBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class DGAPKKHFPCG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct KEEGOKMNBMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public ALHNBMBLPFF FEKIAAAHJBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LocalBuilder BJPANFBMMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public LocalBuilder AFBCAMOAOFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class OMEOFNCNCNL
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class PEMJFNHPPIA
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo KGJMGIHLEEK;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo OBIICGNMIDA;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo CLNCJOPKLIO;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo FIHBGEIBAHK;

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly MethodInfo PAKECHICCJL;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo CKMEPDODHHC;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo CKKCDMNCDNI;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo MHGGHKPIFND;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo OKKOKIHHKIP;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x138E1E0", Offset = "0x138C7E0", VA = "0x18138E1E0")]
			static PEMJFNHPPIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class MJHLMMAMAMB
		{
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo OABOEFJCDPO;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo HPAIJIJNKHK;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo DFAEPBAFEBH;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo HAFJHJBIJJC;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo BFODLDIKOJE;

			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo KAEDKNMBJBJ;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo EOOBAEBHHHJ;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x163E930", Offset = "0x163CF30", VA = "0x18163E930")]
			static MJHLMMAMAMB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class BHDOKAPDAPD
		{
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			internal static readonly MethodInfo ENCEIDLBBJB;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			internal static readonly MethodInfo FBHNBBKIDFM;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly ConstructorInfo IEDCDPPBBMF;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly MethodInfo MOHPIBBMMKF;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly ConstructorInfo OELGJNKDDBM;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly MethodInfo FLJMGFJBFGI;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly MethodInfo GCILLMDBJOI;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly MethodInfo LJAALNHCPDD;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo PNDNMFFLJFC;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly MethodInfo CAAKBCMNEOK;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo FIENAIDDHLJ;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo INCKOGDBPKE;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo BIOFPDDNPHM;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo AMIAICGEEPB;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x163FAB0", Offset = "0x163E0B0", VA = "0x18163FAB0")]
		public static MethodInfo HINACFMEGJE(Type JOBKDGGGOHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x163F760", Offset = "0x163DD60", VA = "0x18163F760")]
		public static MethodInfo BJFPGPPGGLJ(Type JOBKDGGGOHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x163F990", Offset = "0x163DF90", VA = "0x18163F990")]
		public static MethodInfo DIDMLKCNNHB(Type JOBKDGGGOHC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class ONHEJEINHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Dictionary<ALHNBMBLPFF, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public ONHEJEINHHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class OOIGKJFPIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public ONHEJEINHHJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public OOIGKJFPIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x138E100", Offset = "0x138C700", VA = "0x18138E100")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x138E140", Offset = "0x138C740", VA = "0x18138E140")]
		internal bool <BuildType>b__2(int index, ALHNBMBLPFF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class ADJLKGLFJCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ONHEJEINHHJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public ADJLKGLFJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x162A340", Offset = "0x1628940", VA = "0x18162A340")]
		internal bool <BuildType>b__3(int index, ALHNBMBLPFF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DHFHFGJHLMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public DHFHFGJHLMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x163DAB0", Offset = "0x163C0B0", VA = "0x18163DAB0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class JLIPMDBCAEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public JLIPMDBCAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x163E580", Offset = "0x163CB80", VA = "0x18163E580")]
		internal bool <BuildAnonymousFormatter>b__2(ALHNBMBLPFF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class NFENBCMLDND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public DHFHFGJHLMK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public NFENBCMLDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x163F5B0", Offset = "0x163DBB0", VA = "0x18163F5B0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x163F5C0", Offset = "0x163DBC0", VA = "0x18163F5C0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, ALHNBMBLPFF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AMGCLDDFLAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public DHFHFGJHLMK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public AMGCLDDFLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x162B6F0", Offset = "0x1629CF0", VA = "0x18162B6F0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, ALHNBMBLPFF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IHANLLNEBEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public IHANLLNEBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC50", Offset = "0x7ED250", VA = "0x1807EEC50")]
		internal Label <BuildSerialize>b__1(ALHNBMBLPFF _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class DKFHCLOKPFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public KEEGOKMNBMN[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Func<int, ALHNBMBLPFF, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public OEMOADEINOO argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public OEMOADEINOO argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public DKFHCLOKPFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x163DB10", Offset = "0x163C110", VA = "0x18163DB10")]
		internal KEEGOKMNBMN <BuildDeserialize>b__0(ALHNBMBLPFF item)
		{
			return default(KEEGOKMNBMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class KCDNHEINNEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public DKFHCLOKPFB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public KCDNHEINNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x163E5E0", Offset = "0x163CBE0", VA = "0x18163E5E0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x163E890", Offset = "0x163CE90", VA = "0x18163E890")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IGEILAEFAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public ALHNBMBLPFF item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public IGEILAEFAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x163DDC0", Offset = "0x163C3C0", VA = "0x18163DDC0")]
		internal bool <EmitNewObject>b__0(KEEGOKMNBMN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class FBKPHDOKHAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public ALHNBMBLPFF item;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public FBKPHDOKHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x163DDC0", Offset = "0x163C3C0", VA = "0x18163DDC0")]
		internal bool <EmitNewObject>b__2(KEEGOKMNBMN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly Regex KPLKBGFGEEO;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int GAPHCEOBEBM;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static HashSet<Type> ONAODBAAJGG;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static HashSet<Type> GJCAGAOODMB;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4843B10", Offset = "0x4842110", VA = "0x184843B10")]
	public static object MCICPJKDJAI<T>(CBFPIFNGLMD PGODECFKBFH, FHMJHOEAOJN JAIFLFOOHFA, Func<string, string> NMHJPDCJOCH, bool GGHBPHGPPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x416FAA0", Offset = "0x416E0A0", VA = "0x18416FAA0")]
	public static object LHAJENELENH<T>(FHMJHOEAOJN JAIFLFOOHFA, Func<string, string> NMHJPDCJOCH, bool GGHBPHGPPAK, bool JKCAFBJFPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x163B190", Offset = "0x1639790", VA = "0x18163B190")]
	private static TypeInfo LGHLOCMONDJ(CBFPIFNGLMD PGODECFKBFH, Type JOBKDGGGOHC, Func<string, string> NMHJPDCJOCH, bool GGHBPHGPPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1637230", Offset = "0x1635830", VA = "0x181637230")]
	public static object CPPOPNDANFM(Type JOBKDGGGOHC, Func<string, string> NMHJPDCJOCH, bool GGHBPHGPPAK, bool JKCAFBJFPKG, bool BEBMNPHKLEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1636630", Offset = "0x1634C30", VA = "0x181636630")]
	private static Dictionary<ALHNBMBLPFF, FieldInfo> CHCMMJNEEDJ(TypeBuilder IMKCEJHFGFA, LCFIHFGIHFD FEJBJJDFPDK, ConstructorInfo DPABGOFAHHO, FieldBuilder ENGLGJMBOAK, ILGenerator HIKPPJAFGEA, bool GGHBPHGPPAK, bool FOMJMDPCLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1635EC0", Offset = "0x16344C0", VA = "0x181635EC0")]
	private static Dictionary<ALHNBMBLPFF, FieldInfo> BKDAJIOINHJ(TypeBuilder IMKCEJHFGFA, LCFIHFGIHFD FEJBJJDFPDK, ILGenerator HIKPPJAFGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x163C040", Offset = "0x163A640", VA = "0x18163C040")]
	private static void OPJKEEIOBEF(Type JOBKDGGGOHC, LCFIHFGIHFD FEJBJJDFPDK, ILGenerator HIKPPJAFGEA, Action HJKPIEOGDEJ, Func<int, ALHNBMBLPFF, bool> ANMJDADHKLB, bool GGHBPHGPPAK, bool FOMJMDPCLKO, int AMMGBKIIBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1636C80", Offset = "0x1635280", VA = "0x181636C80")]
	private static void CHPFLHHDCEI(TypeInfo JOBKDGGGOHC, ALHNBMBLPFF BLCFJHCKAGL, ILGenerator HIKPPJAFGEA, int OEELHFBMNBJ, Func<int, ALHNBMBLPFF, bool> ANMJDADHKLB, OEMOADEINOO HDBDALLEDMH, OEMOADEINOO LCJHKPJGBCA, OEMOADEINOO GMMDNAOAEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1638BF0", Offset = "0x16371F0", VA = "0x181638BF0")]
	private static void DBIGLPNKMNA(Type JOBKDGGGOHC, LCFIHFGIHFD FEJBJJDFPDK, ILGenerator HIKPPJAFGEA, Func<int, ALHNBMBLPFF, bool> ANMJDADHKLB, bool LHDGBAKPBNN, int AMMGBKIIBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x163BC30", Offset = "0x163A230", VA = "0x18163BC30")]
	private static void MPBAANJFHJL(ILGenerator HIKPPJAFGEA, KEEGOKMNBMN FEJBJJDFPDK, int OEELHFBMNBJ, Func<int, ALHNBMBLPFF, bool> ANMJDADHKLB, OEMOADEINOO MDFCOIBMJJO, OEMOADEINOO GMMDNAOAEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x163A520", Offset = "0x1638B20", VA = "0x18163A520")]
	private static LocalBuilder HOBDKNJBACD(ILGenerator HIKPPJAFGEA, Type JOBKDGGGOHC, LCFIHFGIHFD FEJBJJDFPDK, KEEGOKMNBMN[] PNGDCGMPPJD, bool FMMGNHDOKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1639E50", Offset = "0x1638450", VA = "0x181639E50")]
	private static bool GLLDFAJDEPL(ConstructorInfo JFIDJOGPLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1636490", Offset = "0x1634A90", VA = "0x181636490")]
	private static bool BLEJOEAKFED(Type JOBKDGGGOHC, out Type KKPEEMHIDIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate void KFJIOMNHFIG<T>(byte[][] ENGLGJMBOAK, object[] HBDOEPMIGIP, ref BMPIEHNPJPN HDBDALLEDMH, T JKOBKIEBPCF, FHMJHOEAOJN PFKPALHDKBE);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal delegate T PBHOFICFMJN<T>(object[] HBDOEPMIGIP, ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN PFKPALHDKBE);
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class BDGLPOGFAEH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class IGDIHFDHPHJ : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class JCOKABCIDAM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7CB280", Offset = "0x7C9880", VA = "0x1807CB280")]
		static JCOKABCIDAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private IGDIHFDHPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class COFJNGNPMMI : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class IEJCKCGKIML<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1A70F40", Offset = "0x1A6F540", VA = "0x181A70F40")]
		static IEJCKCGKIML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private COFJNGNPMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal static class GLJNMLJAPJG
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal static readonly FHMJHOEAOJN[] LHJCKMDLAPE;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class KIMLPMJIIFF : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private static class BIANDHMFMKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xAB6F50", Offset = "0xAB5550", VA = "0x180AB6F50")]
		static BIANDHMFMKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private sealed class HLGPFCHHAJK : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private static class DHMHPFLGDDD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xAB9900", Offset = "0xAB7F00", VA = "0x180AB9900")]
			static DHMHPFLGDDD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private HLGPFCHHAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private KIMLPMJIIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal sealed class DEAAOFNHPCD : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private static class BPJAJBFOJGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x40F8B90", Offset = "0x40F7190", VA = "0x1840F8B90")]
		static BPJAJBFOJGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private sealed class EHPIHBCKAEO : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private static class JBPJLICAPGA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x410E050", Offset = "0x410C650", VA = "0x18410E050")]
			static JBPJLICAPGA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private EHPIHBCKAEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private DEAAOFNHPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal sealed class DJAGFBAOMLE : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private static class IGGNDBDMPKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4108800", Offset = "0x4106E00", VA = "0x184108800")]
		static IGGNDBDMPKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class FEGJCCKIDLJ : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private static class ODKPBJLGPLD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4110880", Offset = "0x410EE80", VA = "0x184110880")]
			static ODKPBJLGPLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private FEGJCCKIDLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private DJAGFBAOMLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class EMFPFCCIGAD : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private static class HFNKGBOHHAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1AE47A0", Offset = "0x1AE2DA0", VA = "0x181AE47A0")]
		static HFNKGBOHHAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class PKPACEOGKPL : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		private static class JOLNOKCCBON<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x1AEA1A0", Offset = "0x1AE87A0", VA = "0x181AEA1A0")]
			static JOLNOKCCBON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private PKPACEOGKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private EMFPFCCIGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class ODIIMFJBCBC : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private static class BFONJKFEDGB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x233F480", Offset = "0x233DA80", VA = "0x18233F480")]
		static BFONJKFEDGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class EJOAIFCOJKF : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		private static class MLHPEDEPHNN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2342F00", Offset = "0x2341500", VA = "0x182342F00")]
			static MLHPEDEPHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private EJOAIFCOJKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private ODIIMFJBCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal sealed class KAGCMPMFPFH : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private static class GOKLPEKLEGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x23744A0", Offset = "0x2372AA0", VA = "0x1823744A0")]
		static GOKLPEKLEGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private sealed class GPMMKHFEAEA : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		private static class LOAIOKHNEMG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x23885A0", Offset = "0x2386BA0", VA = "0x1823885A0")]
			static LOAIOKHNEMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private GPMMKHFEAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private KAGCMPMFPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal sealed class CGBBMMKMENO : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private static class DNKPMJOGHFB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x212F690", Offset = "0x212DC90", VA = "0x18212F690")]
		static DNKPMJOGHFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private sealed class FDDAAOBEIAE : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		private static class AJDAEOPMIHD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x2122D30", Offset = "0x2121330", VA = "0x182122D30")]
			static AJDAEOPMIHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private FDDAAOBEIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private CGBBMMKMENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
internal sealed class FDGPNOLHHNN : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private static class MKKOPPMKLGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x46A3900", Offset = "0x46A1F00", VA = "0x1846A3900")]
		static MKKOPPMKLGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private sealed class FKNCNBGPKNB : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private static class PGAEHLCOOLE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x46A6B50", Offset = "0x46A5150", VA = "0x1846A6B50")]
			static PGAEHLCOOLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private FKNCNBGPKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private FDGPNOLHHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal sealed class GBAHAFCONAI : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private static class MAKOBCABMPN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x47BFA40", Offset = "0x47BE040", VA = "0x1847BFA40")]
		static MAKOBCABMPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private sealed class LPBAJMJLDFA : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private static class AJCGDCHOCHM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x24C3240", Offset = "0x24C1840", VA = "0x1824C3240")]
			static AJCGDCHOCHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private LPBAJMJLDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private GBAHAFCONAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal sealed class KBIJOPCKOMM : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private static class JFKLHFNEPJP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2379F30", Offset = "0x2378530", VA = "0x182379F30")]
		static JFKLHFNEPJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private sealed class KKDCMLLDMEA : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		private static class NGOJDICEDBE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2389B60", Offset = "0x2388160", VA = "0x182389B60")]
			static NGOJDICEDBE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private KKDCMLLDMEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private KBIJOPCKOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal sealed class CKCAJCBHBPP : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private static class OGDOHPMDFEO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x47D7F20", Offset = "0x47D6520", VA = "0x1847D7F20")]
		static OGDOHPMDFEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class MOPHHKDDKIB : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private static class LHCEPEJPKPL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x47D2300", Offset = "0x47D0900", VA = "0x1847D2300")]
			static LHCEPEJPKPL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private MOPHHKDDKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private CKCAJCBHBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
internal sealed class ABEALMJELHA : FHMJHOEAOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private static class EKGIAMDMFFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2641440", Offset = "0x263FA40", VA = "0x182641440")]
		static EKGIAMDMFFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class AHEDPAMDKIC : FHMJHOEAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private static class BCPHEIMIMKM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public static readonly global::CIMPKNEDLLC<T> GBGHBKPDJOO;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x263C0C0", Offset = "0x263A6C0", VA = "0x18263C0C0")]
			static BCPHEIMIMKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly FHMJHOEAOJN EJBAJGKCNOF;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static readonly FHMJHOEAOJN[] MKFKAILIBNG;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private AHEDPAMDKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
		public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static readonly FHMJHOEAOJN EJBAJGKCNOF;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly global::CIMPKNEDLLC<object> GLKKGCACMKJ;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	private ABEALMJELHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3EB97B0", Offset = "0x3EB7DB0", VA = "0x183EB97B0", Slot = "4")]
	public global::CIMPKNEDLLC<T> OHOCFLIKECK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct CKMHPHCFEGC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public T[] AODIMJHBHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public int LOLCIANACDE;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x47CE700", Offset = "0x47CCD00", VA = "0x1847CE700")]
	public CKMHPHCFEGC(int JHODDLFHNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x47CE3A0", Offset = "0x47CC9A0", VA = "0x1847CE3A0")]
	public void OAKCALBAGFG(T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x47CE310", Offset = "0x47CC910", VA = "0x1847CE310")]
	public T[] MFEACMAADLG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal sealed class NMNIHFAFOPM : global::DPHMMLIGFGP<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static readonly NMNIHFAFOPM PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x308A690", Offset = "0x3088C90", VA = "0x18308A690")]
	public NMNIHFAFOPM(int KFEPIDLHAGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal class DPHMMLIGFGP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly int KFEPIDLHAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly object IFMFPFMCKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int OEELHFBMNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private T[][] ONJHKHIGKHI;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2006200", Offset = "0x2004800", VA = "0x182006200")]
	public DPHMMLIGFGP(int KFEPIDLHAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2004040", Offset = "0x2002640", VA = "0x182004040")]
	public T[] BBFHNJJJCLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x20053C0", Offset = "0x20039C0", VA = "0x1820053C0")]
	public void PALBBKNPIIA(T[] CDIMPGOIPOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class LMHOAIBICCD : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class GEJIMECCPAF : IComparable<GEJIMECCPAF>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class EDEAPLNHDLA : IEnumerable<GEJIMECCPAF>, IEnumerable, IEnumerator<GEJIMECCPAF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private GEJIMECCPAF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public GEJIMECCPAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private GEJIMECCPAF System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x63CDC0", Offset = "0x63B3C0", VA = "0x18063CDC0")]
			[DebuggerHidden]
			public EDEAPLNHDLA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1377C30", Offset = "0x1376230", VA = "0x181377C30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1377D60", Offset = "0x1376360", VA = "0x181377D60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1377CC0", Offset = "0x13762C0", VA = "0x181377CC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GEJIMECCPAF> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1377CC0", Offset = "0x13762C0", VA = "0x181377CC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class IOPAAELONDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public IOPAAELONDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x7EEC50", Offset = "0x7ED250", VA = "0x1807EEC50")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7EEC50", Offset = "0x7ED250", VA = "0x1807EEC50")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly GEJIMECCPAF[] MJGDDDHPELL;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static readonly ulong[] KNNIEEHLBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public ulong EOAEJCJEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int OFOOFEJCCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public string KLMGEHHFEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private GEJIMECCPAF[] PEKAMHAFHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ulong[] BECEEKOECLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int JKKHOEKMJBA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IJFLOLNHPHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x137BDB0", Offset = "0x137A3B0", VA = "0x18137BDB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x137C080", Offset = "0x137A680", VA = "0x18137C080")]
		public GEJIMECCPAF(ulong CAOGILCCJKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x137BE10", Offset = "0x137A410", VA = "0x18137BE10")]
		public GEJIMECCPAF OAKCALBAGFG(ulong CAOGILCCJKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x137BDC0", Offset = "0x137A3C0", VA = "0x18137BDC0")]
		public GEJIMECCPAF OAKCALBAGFG(ulong CAOGILCCJKA, int JKOBKIEBPCF, string KLMGEHHFEAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x137AEF0", Offset = "0x13794F0", VA = "0x18137AEF0")]
		public GEJIMECCPAF DIJMBCIDPPE(byte[] CLOKCOIHLHE, ref int MPKAJNKONAC, ref int KKDOLHLEPKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x137ADD0", Offset = "0x13793D0", VA = "0x18137ADD0")]
		internal static int CJLLAEIKOJB(ulong[] CDIMPGOIPOL, int OEELHFBMNBJ, int DLLECELLJJB, ulong JKOBKIEBPCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x137AE50", Offset = "0x1379450", VA = "0x18137AE50", Slot = "4")]
		public int CompareTo(GEJIMECCPAF HJALGMGCNFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x137AE80", Offset = "0x1379480", VA = "0x18137AE80")]
		[IteratorStateMachine(typeof(EDEAPLNHDLA))]
		public IEnumerable<GEJIMECCPAF> DIDHJGCAJHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x137B0A0", Offset = "0x13796A0", VA = "0x18137B0A0")]
		public void ELEJCFLNMHN(ILGenerator HIKPPJAFGEA, LocalBuilder CLOKCOIHLHE, LocalBuilder KKDOLHLEPKC, LocalBuilder CAOGILCCJKA, Action<KeyValuePair<string, int>> LLDGDDMLANH, Action FCGMFLPKCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x137B1D0", Offset = "0x13797D0", VA = "0x18137B1D0")]
		private static void NEKBIGINBDA(ILGenerator HIKPPJAFGEA, LocalBuilder CLOKCOIHLHE, LocalBuilder KKDOLHLEPKC, LocalBuilder CAOGILCCJKA, Action<KeyValuePair<string, int>> LLDGDDMLANH, Action FCGMFLPKCAH, GEJIMECCPAF[] PEKAMHAFHEN, int JKKHOEKMJBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class IBINKIALICD : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private IEnumerable<GEJIMECCPAF> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public IEnumerable<GEJIMECCPAF> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private IEnumerator<GEJIMECCPAF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private GEJIMECCPAF <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x70A290", Offset = "0x708890", VA = "0x18070A290", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1380A80", Offset = "0x137F080", VA = "0x181380A80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x12D0A50", Offset = "0x12CF050", VA = "0x1812D0A50")]
		[DebuggerHidden]
		public IBINKIALICD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1380AD0", Offset = "0x137F0D0", VA = "0x181380AD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1380610", Offset = "0x137EC10", VA = "0x181380610", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1380BD0", Offset = "0x137F1D0", VA = "0x181380BD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1380C20", Offset = "0x137F220", VA = "0x181380C20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1380A30", Offset = "0x137F030", VA = "0x181380A30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1380990", Offset = "0x137EF90", VA = "0x181380990", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1380990", Offset = "0x137EF90", VA = "0x181380990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly GEJIMECCPAF MKDDPCAJMGN;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x138A1A0", Offset = "0x13887A0", VA = "0x18138A1A0")]
	public LMHOAIBICCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1389F30", Offset = "0x1388530", VA = "0x181389F30")]
	public void OAKCALBAGFG(byte[] FBEAOBEALBD, int JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1389E80", Offset = "0x1388480", VA = "0x181389E80")]
	public bool MPGEFIHHANH(ArraySegment<byte> CAOGILCCJKA, out int JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x138A0B0", Offset = "0x13886B0", VA = "0x18138A0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1389AD0", Offset = "0x13880D0", VA = "0x181389AD0")]
	private static void DOFDHEJDFCH(IEnumerable<GEJIMECCPAF> PEKAMHAFHEN, StringBuilder DGFFNEDPECE, int AFOOALBCHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1389D50", Offset = "0x1388350", VA = "0x181389D50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1389D50", Offset = "0x1388350", VA = "0x181389D50", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x138A040", Offset = "0x1388640", VA = "0x18138A040")]
	[IteratorStateMachine(typeof(IBINKIALICD))]
	private static IEnumerable<KeyValuePair<string, int>> PFDOGCIJHII(IEnumerable<GEJIMECCPAF> PEKAMHAFHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1389E50", Offset = "0x1388450", VA = "0x181389E50")]
	public void MKOLMEAILCI(ILGenerator HIKPPJAFGEA, LocalBuilder CLOKCOIHLHE, LocalBuilder KKDOLHLEPKC, LocalBuilder CAOGILCCJKA, Action<KeyValuePair<string, int>> LLDGDDMLANH, Action FCGMFLPKCAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class JLLCPIBEPAH
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static readonly MethodInfo LENLJBMPODH;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1386260", Offset = "0x1384860", VA = "0x181386260")]
	public static ulong CEBNBAHCBCA(byte[] FBEAOBEALBD, ref int MPKAJNKONAC, ref int KKDOLHLEPKC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class JKALHOPKNEB
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1385FB0", Offset = "0x13845B0", VA = "0x181385FB0")]
	public static void PKCAIMEKGBP(ref byte[] FBEAOBEALBD, int MPKAJNKONAC, int LFIPBHFFNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1385EC0", Offset = "0x13844C0", VA = "0x181385EC0")]
	public static void PHJMFPLOMKK(ref byte[] CDIMPGOIPOL, int KEHBCMCDGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1385DD0", Offset = "0x13843D0", VA = "0x181385DD0")]
	public static byte[] HMIMNAKMJJO(byte[] CBCKLNMDLJB, int KEHBCMCDGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class MCHBMIHNOLK
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3082840", Offset = "0x3080E40", VA = "0x183082840")]
	public static bool GPFFGOHIBEM(byte[] DFDIMLLBPLB, int MFIJDOAPEHF, int DNFJFNOIDGD, byte[] FOLELEBCIOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class DNFPLEHFLPI<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private struct EKLANDLDMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public byte[] EOAEJCJEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public T OFOOFEJCCGA;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1711DE0", Offset = "0x17103E0", VA = "0x181711DE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class ADDOEDPJKNL : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public global::DNFPLEHFLPI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private EKLANDLDMFB[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private EKLANDLDMFB[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x7B7960", Offset = "0x7B5F60", VA = "0x1807B7960", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1708EE0", Offset = "0x17074E0", VA = "0x181708EE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x11268A0", Offset = "0x1124EA0", VA = "0x1811268A0")]
		[DebuggerHidden]
		public ADDOEDPJKNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1707370", Offset = "0x1705970", VA = "0x181707370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1708710", Offset = "0x1706D10", VA = "0x181708710", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly EKLANDLDMFB[][] JMECAJGKGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly ulong KAKFCFHINMJ;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x170EDF0", Offset = "0x170D3F0", VA = "0x18170EDF0")]
	public DNFPLEHFLPI(int PNGOPGJMFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x170ED30", Offset = "0x170D330", VA = "0x18170ED30")]
	public DNFPLEHFLPI(int PNGOPGJMFFI, float AEMIBHBNHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x170E710", Offset = "0x170CD10", VA = "0x18170E710")]
	public void OAKCALBAGFG(byte[] CAOGILCCJKA, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x170B440", Offset = "0x1709A40", VA = "0x18170B440")]
	private bool ANONMPKLGJF(byte[] CAOGILCCJKA, T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x170D560", Offset = "0x170BB60", VA = "0x18170D560")]
	public bool BHCEMEACFLD(ArraySegment<byte> CAOGILCCJKA, out T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x170ECA0", Offset = "0x170D2A0", VA = "0x18170ECA0")]
	private static ulong ODGDMCIKGLI(byte[] AEIHHPIDBGN, int MPKAJNKONAC, int JKKHOEKMJBA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x170E490", Offset = "0x170CA90", VA = "0x18170E490")]
	private static int KECDKLNJCNC(int BJDHCEKNAKC, float AEMIBHBNHCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x170E2E0", Offset = "0x170C8E0", VA = "0x18170E2E0", Slot = "4")]
	[IteratorStateMachine(typeof(global::DNFPLEHFLPI<>.ADDOEDPJKNL))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x170ED00", Offset = "0x170D300", VA = "0x18170ED00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class IKKAKNJKHIP : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static readonly OpCode[] PMCKMAAMFHK;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static readonly OpCode[] NGGIEPAKNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int LIMMNOHFMCE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool AHKJNLCGNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1382DA0", Offset = "0x13813A0", VA = "0x181382DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1382F00", Offset = "0x1381500", VA = "0x181382F00")]
	static IKKAKNJKHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1383150", Offset = "0x1381750", VA = "0x181383150")]
	public IKKAKNJKHIP(byte[] MDKIOFPDBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1382DF0", Offset = "0x13813F0", VA = "0x181382DF0")]
	public OpCode KDDCJHOGIEO()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal struct ABBOLNFKAJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly Guid OFOOFEJCCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte FPNDBKFJNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte GBODECDBLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte FGNCBJIINCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte MJELFODLLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte JCLICHJNEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte KEIJMNNJPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte DCMIPKHKKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte JACIBOLJEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte LADHOGDBNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte DJFFDCMABCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte JMOELMDDAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte LEOBPIOFBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte ODJMIHJCHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte MHLAHMEALDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte NEIFFFMKFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte NKGCLMIDKJL;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static byte[] MPMBJMEANAA;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static byte[] ILENLMFCDFN;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1629B40", Offset = "0x1628140", VA = "0x181629B40")]
	public ABBOLNFKAJK(ref Guid JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1629B50", Offset = "0x1628150", VA = "0x181629B50")]
	public ABBOLNFKAJK(ref ArraySegment<byte> GNOEFIDEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x16298C0", Offset = "0x1627EC0", VA = "0x1816298C0")]
	private static byte JMGFFFBLCGF(byte[] FBEAOBEALBD, int NIFDJBAPJJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1629980", Offset = "0x1627F80", VA = "0x181629980")]
	private static byte LODGEMAKKFP(byte BFBDMMHDNGP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1628580", Offset = "0x1626B80", VA = "0x181628580")]
	public void CDOKKMBLEAB(byte[] LFIKNNODPFA, int MPKAJNKONAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class MIAIMDJMNIG
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3085CC0", Offset = "0x30842C0", VA = "0x183085CC0")]
	public static bool PDAOAELNKHP(byte NJEFHOCCNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3085BD0", Offset = "0x30841D0", VA = "0x183085BD0")]
	public static bool OCAINADECFA(byte NJEFHOCCNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x30857E0", Offset = "0x3083DE0", VA = "0x1830857E0")]
	public static sbyte GGDJDDMJAMI(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3084F30", Offset = "0x3083530", VA = "0x183084F30")]
	public static short EENONJNKJGP(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3085850", Offset = "0x3083E50", VA = "0x183085850")]
	public static int GLNDAHNMBMO(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3085B20", Offset = "0x3084120", VA = "0x183085B20")]
	public static long LDJMHDNNJGD(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3084FA0", Offset = "0x30835A0", VA = "0x183084FA0")]
	public static byte EGJBKMPKKPH(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3085AB0", Offset = "0x30840B0", VA = "0x183085AB0")]
	public static ushort KEGINFANPIO(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3085C40", Offset = "0x3084240", VA = "0x183085C40")]
	public static uint OKHIKEJNOHN(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x30858C0", Offset = "0x3083EC0", VA = "0x1830858C0")]
	public static ulong JAIHKIPPPFB(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3085A40", Offset = "0x3084040", VA = "0x183085A40")]
	public static float KDINPMDENPF(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x30859D0", Offset = "0x3083FD0", VA = "0x1830859D0")]
	public static double JEGJMDEACHO(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3085010", Offset = "0x3083610", VA = "0x183085010")]
	public static int EJCEKMCCAGG(ref byte[] LFIKNNODPFA, int MPKAJNKONAC, ulong JKOBKIEBPCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x30840A0", Offset = "0x30826A0", VA = "0x1830840A0")]
	public static int AADHHBPOHBG(ref byte[] LFIKNNODPFA, int MPKAJNKONAC, long JKOBKIEBPCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3084CE0", Offset = "0x30832E0", VA = "0x183084CE0")]
	public static bool BBGIBFCGDGG(byte[] FBEAOBEALBD, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class DFOEBBFKLID
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class JKIOFNPNPOA : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x63CDC0", Offset = "0x63B3C0", VA = "0x18063CDC0")]
		[DebuggerHidden]
		public JKIOFNPNPOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x163E3C0", Offset = "0x163C9C0", VA = "0x18163E3C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x163DF60", Offset = "0x163C560", VA = "0x18163DF60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x163E4E0", Offset = "0x163CAE0", VA = "0x18163E4E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x163E530", Offset = "0x163CB30", VA = "0x18163E530")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x163E370", Offset = "0x163C970", VA = "0x18163E370", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x163E2C0", Offset = "0x163C8C0", VA = "0x18163E2C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x163E2C0", Offset = "0x163C8C0", VA = "0x18163E2C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class AADLKAJPMPB : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x63CDC0", Offset = "0x63B3C0", VA = "0x18063CDC0")]
		[DebuggerHidden]
		public AADLKAJPMPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x16283C0", Offset = "0x16269C0", VA = "0x1816283C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1627F60", Offset = "0x1626560", VA = "0x181627F60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x16284E0", Offset = "0x1626AE0", VA = "0x1816284E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1628530", Offset = "0x1626B30", VA = "0x181628530")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1628370", Offset = "0x1626970", VA = "0x181628370", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x16282C0", Offset = "0x16268C0", VA = "0x1816282C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x16282C0", Offset = "0x16268C0", VA = "0x1816282C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x1635A20", Offset = "0x1634020", VA = "0x181635A20")]
	public static bool MAFNPGDLODN(this TypeInfo JOBKDGGGOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x1635AD0", Offset = "0x16340D0", VA = "0x181635AD0")]
	public static bool NAPMAKHOHEF(this TypeInfo JOBKDGGGOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1635840", Offset = "0x1633E40", VA = "0x181635840")]
	public static IEnumerable<PropertyInfo> BGBGEKBJAGN(this Type JOBKDGGGOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x1635990", Offset = "0x1633F90", VA = "0x181635990")]
	[IteratorStateMachine(typeof(JKIOFNPNPOA))]
	private static IEnumerable<PropertyInfo> KONHKAGGJBJ(Type JOBKDGGGOHC, HashSet<string> JAJDLKCAMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x16358A0", Offset = "0x1633EA0", VA = "0x1816358A0")]
	public static IEnumerable<FieldInfo> EJPDLLGNJEE(this Type JOBKDGGGOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x1635900", Offset = "0x1633F00", VA = "0x181635900")]
	[IteratorStateMachine(typeof(AADLKAJPMPB))]
	private static IEnumerable<FieldInfo> JMNGPHIJLGC(Type JOBKDGGGOHC, HashSet<string> JAJDLKCAMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class NOIDHJMOLPH
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public static readonly Encoding INDHDPFKODL;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal static class CDMOEOAKAKA
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x531600", Offset = "0x52FC00", VA = "0x180531600")]
	public static string EEAPNJGLLNI(string NOGJILFDNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1633DF0", Offset = "0x16323F0", VA = "0x181633DF0")]
	public static string CIEAGDAAINO(string NOGJILFDNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1633F00", Offset = "0x1632500", VA = "0x181633F00")]
	public static string PAIGBCJLOEB(string NOGJILFDNDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class FGFFMNAANKL<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class LLOGMKLBJKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Type EOAEJCJEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public TValue OFOOFEJCCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int BMNJOODMCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public LLOGMKLBJKL LDBGJBFEIIB;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x469ED10", Offset = "0x469D310", VA = "0x18469ED10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x469EC90", Offset = "0x469D290", VA = "0x18469EC90")]
		private int JLOOKCACPHA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public LLOGMKLBJKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class LGIGBDMMLFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public LGIGBDMMLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x704100", Offset = "0x702700", VA = "0x180704100")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private LLOGMKLBJKL[] JMECAJGKGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int OGHBEIMLJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly object KDFNOEGAPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly float AEMIBHBNHCM;

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4695350", Offset = "0x4693950", VA = "0x184695350")]
	public FGFFMNAANKL(int PNGOPGJMFFI = 4, float AEMIBHBNHCM = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4694AA0", Offset = "0x46930A0", VA = "0x184694AA0")]
	public bool JOHNOICNCIN(Type CAOGILCCJKA, TValue JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4694950", Offset = "0x4692F50", VA = "0x184694950")]
	public bool JOHNOICNCIN(Type CAOGILCCJKA, Func<Type, TValue> AOPFGBKOOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4694260", Offset = "0x4692860", VA = "0x184694260")]
	private bool ANONMPKLGJF(Type CAOGILCCJKA, Func<Type, TValue> AOPFGBKOOKK, out TValue PLENNIPHLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x4694F90", Offset = "0x4693590", VA = "0x184694F90")]
	private bool LHANGLKPBCL(LLOGMKLBJKL[] JMECAJGKGJP, Type MEOIHCFCCLE, LLOGMKLBJKL LNGAAGJPLLN, Func<Type, TValue> AOPFGBKOOKK, out TValue PLENNIPHLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4694560", Offset = "0x4692B60", VA = "0x184694560")]
	public bool BHCEMEACFLD(Type CAOGILCCJKA, out TValue JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4694800", Offset = "0x4692E00", VA = "0x184694800")]
	public TValue IFJNNJONMOF(Type CAOGILCCJKA, Func<Type, TValue> AOPFGBKOOKK)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x170E490", Offset = "0x170CA90", VA = "0x18170E490")]
	private static int KECDKLNJCNC(int BJDHCEKNAKC, float AEMIBHBNHCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4693F30", Offset = "0x4692530", VA = "0x184693F30")]
	private static void AAHFPEGJNLB(ref LLOGMKLBJKL JNCKHALCHHG, LLOGMKLBJKL JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4693F30", Offset = "0x4692530", VA = "0x184693F30")]
	private static void AAHFPEGJNLB(ref LLOGMKLBJKL[] JNCKHALCHHG, LLOGMKLBJKL[] JKOBKIEBPCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class CBFPIFNGLMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly AssemblyBuilder PEPBJINEKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly ModuleBuilder IELHGCNNMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly object IFMFPFMCKFH;

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x1632440", Offset = "0x1630A40", VA = "0x181632440")]
	public TypeBuilder JJKKMEPGHAD(string EIBLJOLNOMI, TypeAttributes BBCGGHKGJLL, Type IJHBOGOHCCC, Type[] BHFCDOJCFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x1632530", Offset = "0x1630B30", VA = "0x181632530")]
	public CBFPIFNGLMD(string HBBIBJCCOKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class AEEHCDHIDEO
{
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x162A3E0", Offset = "0x16289E0", VA = "0x18162A3E0")]
	private static MethodInfo FHMBFCDAGHJ(LambdaExpression CNGHEAJBLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x4834490", Offset = "0x4832A90", VA = "0x184834490")]
	public static MethodInfo DNJMFJDLJDL<T>(Expression<Func<T>> CNGHEAJBLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x4834490", Offset = "0x4832A90", VA = "0x184834490")]
	public static MethodInfo DNJMFJDLJDL<T, TR>(Expression<Func<T, TR>> CNGHEAJBLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x4834490", Offset = "0x4832A90", VA = "0x184834490")]
	public static MethodInfo DNJMFJDLJDL<T>(Expression<Action<T>> CNGHEAJBLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x4834490", Offset = "0x4832A90", VA = "0x184834490")]
	public static MethodInfo DNJMFJDLJDL<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> CNGHEAJBLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x48343F0", Offset = "0x48329F0", VA = "0x1848343F0")]
	private static MemberInfo DAAABEEMCHB<T>(Expression<T> IHKGCBCIIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x4834390", Offset = "0x4832990", VA = "0x184834390")]
	public static PropertyInfo ADHGILDGGPP<T, TR>(Expression<Func<T, TR>> CNGHEAJBLBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal struct OEMOADEINOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int BFJPGBKBCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly bool JGPGIIIFCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly ILGenerator HIKPPJAFGEA;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x308AA00", Offset = "0x3089000", VA = "0x18308AA00")]
	public OEMOADEINOO(ILGenerator HIKPPJAFGEA, int BFJPGBKBCMP, bool JGPGIIIFCCL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x308AA40", Offset = "0x3089040", VA = "0x18308AA40")]
	public OEMOADEINOO(ILGenerator HIKPPJAFGEA, int BFJPGBKBCMP, Type JOBKDGGGOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x308A8F0", Offset = "0x3088EF0", VA = "0x18308A8F0")]
	public void NPCMGIONIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class MFOAJNPAOFE
{
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3083800", Offset = "0x3081E00", VA = "0x183083800")]
	public static void LJFCJFPDEDC(this ILGenerator HIKPPJAFGEA, int OEELHFBMNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x30837C0", Offset = "0x3081DC0", VA = "0x1830837C0")]
	public static void LJFCJFPDEDC(this ILGenerator HIKPPJAFGEA, LocalBuilder PMOKOCHOPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3083000", Offset = "0x3081600", VA = "0x183083000")]
	public static void GDOMJKLHEKP(this ILGenerator HIKPPJAFGEA, int OEELHFBMNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3082FC0", Offset = "0x30815C0", VA = "0x183082FC0")]
	public static void GDOMJKLHEKP(this ILGenerator HIKPPJAFGEA, LocalBuilder PMOKOCHOPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3083E20", Offset = "0x3082420", VA = "0x183083E20")]
	public static void MPAELADKGIB(this ILGenerator HIKPPJAFGEA, int OEELHFBMNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3083D10", Offset = "0x3082310", VA = "0x183083D10")]
	public static void MPAELADKGIB(this ILGenerator HIKPPJAFGEA, LocalBuilder PMOKOCHOPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3083F10", Offset = "0x3082510", VA = "0x183083F10")]
	public static void OKHHDDOKPLJ(this ILGenerator HIKPPJAFGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x30832C0", Offset = "0x30818C0", VA = "0x1830832C0")]
	public static void IPBJCGPKCHK(this ILGenerator HIKPPJAFGEA, bool JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x30832D0", Offset = "0x30818D0", VA = "0x1830832D0")]
	public static void KFFLKNOBMCG(this ILGenerator HIKPPJAFGEA, int JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3083B30", Offset = "0x3082130", VA = "0x183083B30")]
	public static void MDBPPJOOJAO(this ILGenerator HIKPPJAFGEA, Type JOBKDGGGOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3083720", Offset = "0x3081D20", VA = "0x183083720")]
	public static void LBOKJDIFNGI(this ILGenerator HIKPPJAFGEA, Type JOBKDGGGOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3082C80", Offset = "0x3081280", VA = "0x183082C80")]
	public static void DAKDHHDGEJO(this ILGenerator HIKPPJAFGEA, int OEELHFBMNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3082F40", Offset = "0x3081540", VA = "0x183082F40")]
	public static void EFLKHFCKGBK(this ILGenerator HIKPPJAFGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3083C20", Offset = "0x3082220", VA = "0x183083C20")]
	public static void MGDEBACPENP(this ILGenerator HIKPPJAFGEA, int OEELHFBMNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3083A30", Offset = "0x3082030", VA = "0x183083A30")]
	public static void LKGJGKMAFDI(this ILGenerator HIKPPJAFGEA, MethodInfo ALFFOMEHBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3083230", Offset = "0x3081830", VA = "0x183083230")]
	public static void IOCFPHAEOLI(this ILGenerator HIKPPJAFGEA, FieldInfo MJOLONHLPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3082EB0", Offset = "0x30814B0", VA = "0x183082EB0")]
	public static void DMHFEDNHLDM(this ILGenerator HIKPPJAFGEA, ulong JKOBKIEBPCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class ALHNBMBLPFF
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class PHKHNJAGDDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public PHKHNJAGDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1641190", Offset = "0x163F790", VA = "0x181641190")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private MethodInfo DGFHMBBODNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private MethodInfo GJOJIIMJLLB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string HJBLNLINMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string FFCEGJGHMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x56B740", Offset = "0x569D40", VA = "0x18056B740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DLLKLNJAPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x162B280", Offset = "0x1629880", VA = "0x18162B280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FLOGAEMCLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x70A2A0", Offset = "0x7088A0", VA = "0x18070A2A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x70A2B0", Offset = "0x7088B0", VA = "0x18070A2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ICOFFFHECAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7E62C0", Offset = "0x7E48C0", VA = "0x1807E62C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCC0", Offset = "0x8EE2C0", VA = "0x1808EFCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type EKOGCOMENII
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5135E0", Offset = "0x511BE0", VA = "0x1805135E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x56D4E0", Offset = "0x56BAE0", VA = "0x18056D4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo JDJAIBMMFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x50DAE0", Offset = "0x50C0E0", VA = "0x18050DAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo JBNIPAEIDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x57F1A0", Offset = "0x57D7A0", VA = "0x18057F1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x58A2A0", Offset = "0x5888A0", VA = "0x18058A2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo HHGBHBDGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x521D80", Offset = "0x520380", VA = "0x180521D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x56D470", Offset = "0x56BA70", VA = "0x18056D470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x162B3B0", Offset = "0x16299B0", VA = "0x18162B3B0")]
	protected ALHNBMBLPFF(Type JOBKDGGGOHC, string EIBLJOLNOMI, string MFFCAKPOIHF, bool PMHGCHAIMBF, bool CMBMMEBKEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x162B430", Offset = "0x1629A30", VA = "0x18162B430")]
	public ALHNBMBLPFF(FieldInfo FEJBJJDFPDK, string EIBLJOLNOMI, bool JKCAFBJFPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x162B540", Offset = "0x1629B40", VA = "0x18162B540")]
	public ALHNBMBLPFF(PropertyInfo FEJBJJDFPDK, string EIBLJOLNOMI, bool JKCAFBJFPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x162B290", Offset = "0x1629890", VA = "0x18162B290")]
	private static MethodInfo PLONKIJHMEB(MemberInfo FEJBJJDFPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4014E40", Offset = "0x4013440", VA = "0x184014E40")]
	public T OFKLLHGJKGN<T>(bool EEFDILFHKCO) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x162B100", Offset = "0x1629700", VA = "0x18162B100", Slot = "4")]
	public virtual void APPJHHBILOI(ILGenerator HIKPPJAFGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x162B1C0", Offset = "0x16297C0", VA = "0x18162B1C0", Slot = "5")]
	public virtual void CBECFCFEGMO(ILGenerator HIKPPJAFGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class JGGHPMMKDBH : ALHNBMBLPFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly string JFPACKNKIFN;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1385AC0", Offset = "0x13840C0", VA = "0x181385AC0")]
	public JGGHPMMKDBH(string EIBLJOLNOMI, string JFPACKNKIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x13859B0", Offset = "0x1383FB0", VA = "0x1813859B0", Slot = "4")]
	public override void APPJHHBILOI(ILGenerator HIKPPJAFGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1385A70", Offset = "0x1384070", VA = "0x181385A70", Slot = "5")]
	public override void CBECFCFEGMO(ILGenerator HIKPPJAFGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class CNOGOJDBDDM : ALHNBMBLPFF
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly MethodInfo GHDHPMAOKHH;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly MethodInfo DMOJMFLGDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	internal OEMOADEINOO BNGJHADCOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	internal OEMOADEINOO LCJHKPJGBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	internal OEMOADEINOO GMMDNAOAEJL;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1634FC0", Offset = "0x16335C0", VA = "0x181634FC0")]
	public CNOGOJDBDDM(string EIBLJOLNOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1634900", Offset = "0x1632F00", VA = "0x181634900", Slot = "4")]
	public override void APPJHHBILOI(ILGenerator HIKPPJAFGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x16349C0", Offset = "0x1632FC0", VA = "0x1816349C0", Slot = "5")]
	public override void CBECFCFEGMO(ILGenerator HIKPPJAFGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1634A10", Offset = "0x1633010", VA = "0x181634A10")]
	public void ENNCDBNOBAP(ILGenerator HIKPPJAFGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class LCFIHFGIHFD
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type EKOGCOMENII
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BLFCPHKGKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5B1040", Offset = "0x5AF640", VA = "0x1805B1040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5B1000", Offset = "0x5AF600", VA = "0x1805B1000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PAHDKKIKLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xB1F040", Offset = "0xB1D640", VA = "0x180B1F040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xDFE540", Offset = "0xDFCB40", VA = "0x180DFE540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo CIHJLLJOKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x50DD90", Offset = "0x50C390", VA = "0x18050DD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5395F0", Offset = "0x537BF0", VA = "0x1805395F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ALHNBMBLPFF[] HFPKEGADJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5135E0", Offset = "0x511BE0", VA = "0x1805135E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x56D4E0", Offset = "0x56BAE0", VA = "0x18056D4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ALHNBMBLPFF[] IMOBNBHLLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x50DAE0", Offset = "0x50C0E0", VA = "0x18050DAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1388390", Offset = "0x1386990", VA = "0x181388390")]
	public LCFIHFGIHFD(Type JOBKDGGGOHC, Func<string, string> ADNFMKABIDE, bool JKCAFBJFPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x13882C0", Offset = "0x13868C0", VA = "0x1813882C0")]
	private static bool OBAJALDPPCD(IEnumerator<ConstructorInfo> LGCIMNPJACB, ref ConstructorInfo PJFPLHIBKKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct PBFANBIPMLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public ulong KGBHKICNDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public int KGONAAJAECB;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0xA1DC10", Offset = "0xA1C210", VA = "0x180A1DC10")]
	public PBFANBIPMLI(ulong KCPFAFPJHPP, int DCJCGPJDGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x308BB30", Offset = "0x308A130", VA = "0x18308BB30")]
	public void ANBHPIGKIGE(ref PBFANBIPMLI HJALGMGCNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x308BB40", Offset = "0x308A140", VA = "0x18308BB40")]
	public static PBFANBIPMLI CFLNHLCILHE(ref PBFANBIPMLI LFCBLKFDHFN, ref PBFANBIPMLI BFBDMMHDNGP)
	{
		return default(PBFANBIPMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x308BAA0", Offset = "0x308A0A0", VA = "0x18308BAA0")]
	public void ACLNLJCJHPG(ref PBFANBIPMLI HJALGMGCNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x308BC10", Offset = "0x308A210", VA = "0x18308BC10")]
	public static PBFANBIPMLI PPKEAIHINDN(ref PBFANBIPMLI LFCBLKFDHFN, ref PBFANBIPMLI BFBDMMHDNGP)
	{
		return default(PBFANBIPMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x308BB70", Offset = "0x308A170", VA = "0x18308BB70")]
	public void OIJPMHBMJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x308BBB0", Offset = "0x308A1B0", VA = "0x18308BBB0")]
	public static PBFANBIPMLI OIJPMHBMJHK(ref PBFANBIPMLI LFCBLKFDHFN)
	{
		return default(PBFANBIPMLI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct LLKKEILJCJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public byte[] LFIKNNODPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public int MPKAJNKONAC;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0xA1E0F0", Offset = "0xA1C6F0", VA = "0x180A1E0F0")]
	public LLKKEILJCJD(byte[] LFIKNNODPFA, int ADGNDOLJLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1389A70", Offset = "0x1388070", VA = "0x181389A70")]
	public void JOKIICIJKAF(byte LPGAJGGCIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1389700", Offset = "0x1387D00", VA = "0x181389700")]
	public void CCFFEIMCHAJ(byte[] LPGAJGGCIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x13899D0", Offset = "0x1387FD0", VA = "0x1813899D0")]
	public void JGGCOBAKOIK(byte[] LPGAJGGCIPH, int DLLECELLJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1389920", Offset = "0x1387F20", VA = "0x181389920")]
	public void JGGCOBAKOIK(byte[] LPGAJGGCIPH, int JBMPAJCMLGB, int DLLECELLJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x13898A0", Offset = "0x1387EA0", VA = "0x1813898A0")]
	public void IBFBKBHIMNH(byte NJEFHOCCNNG, int JKKHOEKMJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x13897A0", Offset = "0x1387DA0", VA = "0x1813897A0")]
	public void CHLNJGJAKNL(string LPGAJGGCIPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class LNLMLKACHNP
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum EDINLGPGODN
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum OLILFHPBGCP
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum HJDEKPKDELK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	[ThreadStatic]
	private static byte[] PPLNIECFJJA;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	[ThreadStatic]
	private static byte[] DHJJEOGGOCD;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly byte[] HACHELIJGBC;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly byte[] ALKKNCDBBCK;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly HJDEKPKDELK JAOFMGKBNML;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly char DMKAEFNCGGM;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly int DJMNJHMJOFG;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly int FJOECCJFKKN;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly uint[] BBJGIMFJJKC;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x138B2B0", Offset = "0x13898B0", VA = "0x18138B2B0")]
	private static byte[] JFPILOAAJCG(int OGHBEIMLJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x138C1D0", Offset = "0x138A7D0", VA = "0x18138C1D0")]
	private static byte[] PMMOEBOMCAH(int OGHBEIMLJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x138A560", Offset = "0x1388B60", VA = "0x18138A560")]
	public static int CLEFDFIJJHB(ref byte[] LFIKNNODPFA, int MPKAJNKONAC, float JKOBKIEBPCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x138A670", Offset = "0x1388C70", VA = "0x18138A670")]
	public static int CLEFDFIJJHB(ref byte[] LFIKNNODPFA, int MPKAJNKONAC, double JKOBKIEBPCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x138AD60", Offset = "0x1389360", VA = "0x18138AD60")]
	private static bool FLLHKAKNBCH(byte[] LFIKNNODPFA, int DLLECELLJJB, ulong KMPDJHNFHNC, ulong DJPHGOBEMPI, ulong KKDOLHLEPKC, ulong HANLFGPJNIC, ulong OFADJILLAFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x138BB50", Offset = "0x138A150", VA = "0x18138BB50")]
	private static void PADKMOHCNPK(uint EAFICBADDLP, int LMJIEPDCDDO, out uint JOLBFOKIOFD, out int OOIICHFNEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x138A910", Offset = "0x1388F10", VA = "0x18138A910")]
	private static bool FAGOONGPDDB(PBFANBIPMLI BOEBKNHKDKL, PBFANBIPMLI GOEGACBKPPH, PBFANBIPMLI MGIDHFENBBJ, byte[] LFIKNNODPFA, out int DLLECELLJJB, out int CNDFGGPDKKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x138BC70", Offset = "0x138A270", VA = "0x18138BC70")]
	private static bool PJBAGEGDFPO(double AIOIIBBMMDB, EDINLGPGODN KIBPEKJHLBO, byte[] LFIKNNODPFA, out int DLLECELLJJB, out int CLMDDOFCIDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x138A470", Offset = "0x1388A70", VA = "0x18138A470")]
	private static bool BOOKPEEBNFI(double AIOIIBBMMDB, EDINLGPGODN KIBPEKJHLBO, byte[] LFIKNNODPFA, out int DLLECELLJJB, out int DIPOCLNLMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x138A780", Offset = "0x1388D80", VA = "0x18138A780")]
	private static bool ELFPPOKOFGH(double JKOBKIEBPCF, ref LLKKEILJCJD IOJGAGKDCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x138B520", Offset = "0x1389B20", VA = "0x18138B520")]
	private static bool NMFIJKHALOA(double JKOBKIEBPCF, ref LLKKEILJCJD IOJGAGKDCNF, OLILFHPBGCP KIBPEKJHLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x138BEF0", Offset = "0x138A4F0", VA = "0x18138BEF0")]
	private static void PMLJPEIBALA(byte[] NCLCAFKOMMF, int DLLECELLJJB, int DIPOCLNLMAJ, int ALPFANHHMPP, ref LLKKEILJCJD IOJGAGKDCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x138AE60", Offset = "0x1389460", VA = "0x18138AE60")]
	private static void ILGHEOGOLKM(byte[] NCLCAFKOMMF, int DLLECELLJJB, int DCJCGPJDGFK, ref LLKKEILJCJD IOJGAGKDCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x138B380", Offset = "0x1389980", VA = "0x18138B380")]
	private static bool LOBIKFEIBCE(double AIOIIBBMMDB, OLILFHPBGCP KIBPEKJHLBO, int FAHINIKKJME, byte[] AIDHEGMOOLE, out bool BAANHDLEGBL, out int DLLECELLJJB, out int AHEIOLGHMND)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct NMHPIHDODII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public double GFFIMIPBJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public ulong OHGPIIFCBGK;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct NJHACJGMOLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public float KGBHKICNDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public uint EFLKNLFKBAG;
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct BILHONCJCPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private ulong PGJBLJMPAEG;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x162D930", Offset = "0x162BF30", VA = "0x18162D930")]
	public BILHONCJCPN(double GFFIMIPBJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x162D890", Offset = "0x162BE90", VA = "0x18162D890")]
	public BILHONCJCPN(PBFANBIPMLI GFFIMIPBJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x162D740", Offset = "0x162BD40", VA = "0x18162D740")]
	public PBFANBIPMLI ICJEMIADIBL()
	{
		return default(PBFANBIPMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x162D650", Offset = "0x162BC50", VA = "0x18162D650")]
	public PBFANBIPMLI GGKKMDCJAFE()
	{
		return default(PBFANBIPMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB50", Offset = "0x5AC150", VA = "0x1805ADB50")]
	public ulong AFMFLMIGHFJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x162D450", Offset = "0x162BA50", VA = "0x18162D450")]
	public double GDKEEKOPLNO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x162D810", Offset = "0x162BE10", VA = "0x18162D810")]
	public double PNMNBDKCHJB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x162D360", Offset = "0x162B960", VA = "0x18162D360")]
	public int DGHKLFLCBFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x162D300", Offset = "0x162B900", VA = "0x18162D300")]
	public ulong DAHMOHFBKDL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x162D2B0", Offset = "0x162B8B0", VA = "0x18162D2B0")]
	public bool CCJIPPCCAKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x162D7D0", Offset = "0x162BDD0", VA = "0x18162D7D0")]
	public bool KDLBBIPBIFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x162D2D0", Offset = "0x162B8D0", VA = "0x18162D2D0")]
	public bool CIDLMNMMNFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x162D330", Offset = "0x162B930", VA = "0x18162D330")]
	public bool DFGMAHKEKOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x162D7F0", Offset = "0x162BDF0", VA = "0x18162D7F0")]
	public int NAMIHENFJLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x162D4C0", Offset = "0x162BAC0", VA = "0x18162D4C0")]
	public void GFFKINMCGKP(out PBFANBIPMLI BEAAMAACEIN, out PBFANBIPMLI GLENGBGLJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x162D6F0", Offset = "0x162BCF0", VA = "0x18162D6F0")]
	public bool GJBHIHAPGBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x162D7C0", Offset = "0x162BDC0", VA = "0x18162D7C0")]
	public double JKOBKIEBPCF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x162D390", Offset = "0x162B990", VA = "0x18162D390")]
	public static int FAODGAPMBND(int KDMNPEGEJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x162D2A0", Offset = "0x162B8A0", VA = "0x18162D2A0")]
	public static double BHEOMOPKCLO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x162D3B0", Offset = "0x162B9B0", VA = "0x18162D3B0")]
	public static ulong FDMDNLKCIFN(PBFANBIPMLI NIACCDHHGCM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct PBFCECEEIPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private uint GLENDAIFINF;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xBA8F90", Offset = "0xBA7590", VA = "0x180BA8F90")]
	public PBFCECEEIPO(float KGBHKICNDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x308BE80", Offset = "0x308A480", VA = "0x18308BE80")]
	public PBFANBIPMLI ICJEMIADIBL()
	{
		return default(PBFANBIPMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x71AFF0", Offset = "0x7195F0", VA = "0x18071AFF0")]
	public uint NJPALLGHKGC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x308BCF0", Offset = "0x308A2F0", VA = "0x18308BCF0")]
	public int DGHKLFLCBFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x308BCD0", Offset = "0x308A2D0", VA = "0x18308BCD0")]
	public uint DAHMOHFBKDL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x308BCC0", Offset = "0x308A2C0", VA = "0x18308BCC0")]
	public bool CCJIPPCCAKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x308BD10", Offset = "0x308A310", VA = "0x18308BD10")]
	public void GFFKINMCGKP(out PBFANBIPMLI BEAAMAACEIN, out PBFANBIPMLI GLENGBGLJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x308BE40", Offset = "0x308A440", VA = "0x18308BE40")]
	public bool GJBHIHAPGBI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct JCPIHBLIHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly ulong KCPFAFPJHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly short ECHOEMJEHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly short CLMDDOFCIDO;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1384390", Offset = "0x1382990", VA = "0x181384390")]
	public JCPIHBLIHFC(ulong KCPFAFPJHPP, short ECHOEMJEHOC, short CLMDDOFCIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class CAHGIKABCHB
{
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static readonly JCPIHBLIHFC[] KEOFAOKBLLP;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x162F360", Offset = "0x162D960", VA = "0x18162F360")]
	public static void LGNDCJECMJA(int PKIMMHKCNNN, int IFOIBLJDHNL, out PBFANBIPMLI JOLBFOKIOFD, out int CLMDDOFCIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x162F490", Offset = "0x162DA90", VA = "0x18162F490")]
	public static void MKHLCMNCHLE(int MCKDHLBIKAN, out PBFANBIPMLI JOLBFOKIOFD, out int CGFPNNMCPEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[DefaultMember("Item")]
internal struct JLHHIODFJJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public readonly byte[] FBEAOBEALBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly int JBMPAJCMLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly int KADCMKHLKID;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte IDICDLOAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1386220", Offset = "0x1384820", VA = "0x181386220")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xB8BCA0", Offset = "0xB8A2A0", VA = "0x180B8BCA0")]
	public JLHHIODFJJK(byte[] FBEAOBEALBD, int JBMPAJCMLGB, int DLLECELLJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xA1EA10", Offset = "0xA1D010", VA = "0x180A1EA10")]
	public int DLLECELLJJB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x13861C0", Offset = "0x13847C0", VA = "0x1813861C0")]
	public JLHHIODFJJK DCEOLOFMAPH(int IHEGBEFKJJK, int DGOHLMHAAGM)
	{
		return default(JLHHIODFJJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class HJHDDDCFALA
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[ThreadStatic]
	private static byte[] HHJHLPHGCIJ;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly double[] CHOMOMNIGHJ;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly int MCAECKDBJFA;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x137D220", Offset = "0x137B820", VA = "0x18137D220")]
	private static byte[] DMPCIHPMNBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x137E070", Offset = "0x137C670", VA = "0x18137E070")]
	private static JLHHIODFJJK NHDNABFJCLH(JLHHIODFJJK LFIKNNODPFA)
	{
		return default(JLHHIODFJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x137D300", Offset = "0x137B900", VA = "0x18137D300")]
	private static JLHHIODFJJK ENFFGNPLCCA(JLHHIODFJJK LFIKNNODPFA)
	{
		return default(JLHHIODFJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x137D9E0", Offset = "0x137BFE0", VA = "0x18137D9E0")]
	private static void IOFCKHPENGK(JLHHIODFJJK LFIKNNODPFA, int DCJCGPJDGFK, byte[] GFAIECBFDNH, out int OKNCDOJOCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x137D6C0", Offset = "0x137BCC0", VA = "0x18137D6C0")]
	private static void IELACIKLJBG(JLHHIODFJJK LFIKNNODPFA, int DCJCGPJDGFK, byte[] GMDONPHAHDE, int PLBMEGBNIGN, out JLHHIODFJJK ENCICIJEGCL, out int ODIGNBJGOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x137D190", Offset = "0x137B790", VA = "0x18137D190")]
	private static ulong CIKAAACHADB(JLHHIODFJJK LFIKNNODPFA, out int CDDDMDMPGNG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x137D520", Offset = "0x137BB20", VA = "0x18137D520")]
	private static void FNGEOGMEMJM(JLHHIODFJJK LFIKNNODPFA, out PBFANBIPMLI BGLDGHJKFKH, out int BPHMBFGOPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x137E150", Offset = "0x137C750", VA = "0x18137E150")]
	private static bool OCAKDBKFECM(JLHHIODFJJK ENCICIJEGCL, int DCJCGPJDGFK, out double BGLDGHJKFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x137D030", Offset = "0x137B630", VA = "0x18137D030")]
	private static PBFANBIPMLI BPJMODLNKML(int DCJCGPJDGFK)
	{
		return default(PBFANBIPMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x137DA90", Offset = "0x137C090", VA = "0x18137DA90")]
	private static bool JJHNCFDIPIA(JLHHIODFJJK LFIKNNODPFA, int DCJCGPJDGFK, out double BGLDGHJKFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x137D3E0", Offset = "0x137B9E0", VA = "0x18137D3E0")]
	private static bool FLFPGAJLKGP(JLHHIODFJJK ENCICIJEGCL, int DCJCGPJDGFK, out double ODGIFBIKINK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x137E5A0", Offset = "0x137CBA0", VA = "0x18137E5A0")]
	public static double? PBABEONGEIB(JLHHIODFJJK LFIKNNODPFA, int DCJCGPJDGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x137DE90", Offset = "0x137C490", VA = "0x18137DE90")]
	public static float? LMIHPKCOKJA(JLHHIODFJJK LFIKNNODPFA, int DCJCGPJDGFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal struct OFAADMIACJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private byte[] LFIKNNODPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int MPKAJNKONAC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte OFOOFEJCCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x308AC80", Offset = "0x3089280", VA = "0x18308AC80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xA1E0F0", Offset = "0xA1C6F0", VA = "0x180A1E0F0")]
	public OFAADMIACJD(byte[] LFIKNNODPFA, int MPKAJNKONAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x308ABD0", Offset = "0x30891D0", VA = "0x18308ABD0")]
	public static OFAADMIACJD EPAGNIHLNBB(OFAADMIACJD PHPJHDBOBNP)
	{
		return default(OFAADMIACJD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x308ABE0", Offset = "0x30891E0", VA = "0x18308ABE0")]
	public static OFAADMIACJD GCGGNBECFPF(OFAADMIACJD PHPJHDBOBNP, int DLLECELLJJB)
	{
		return default(OFAADMIACJD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x308ABB0", Offset = "0x30891B0", VA = "0x18308ABB0")]
	public static int DHCFNADEJLB(OFAADMIACJD PKBENFANEJD, OFAADMIACJD BOFJBOMFIJG)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x308AB10", Offset = "0x3089110", VA = "0x18308AB10")]
	public static bool BCOOHGHKKGE(OFAADMIACJD PKBENFANEJD, OFAADMIACJD BOFJBOMFIJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x308AD00", Offset = "0x3089300", VA = "0x18308AD00")]
	public static bool LOFNBOFJDCD(OFAADMIACJD PKBENFANEJD, OFAADMIACJD BOFJBOMFIJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x308AB30", Offset = "0x3089130", VA = "0x18308AB30")]
	public static bool BCOOHGHKKGE(OFAADMIACJD PKBENFANEJD, char BOFJBOMFIJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x308ACC0", Offset = "0x30892C0", VA = "0x18308ACC0")]
	public static bool LOFNBOFJDCD(OFAADMIACJD PKBENFANEJD, char BOFJBOMFIJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x308ACC0", Offset = "0x30892C0", VA = "0x18308ACC0")]
	public static bool LOFNBOFJDCD(OFAADMIACJD PKBENFANEJD, byte BOFJBOMFIJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x308AB70", Offset = "0x3089170", VA = "0x18308AB70")]
	public static bool DFHPCCHOKNI(OFAADMIACJD PKBENFANEJD, char BOFJBOMFIJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x308AD20", Offset = "0x3089320", VA = "0x18308AD20")]
	public static bool PDHFGGLALJI(OFAADMIACJD PKBENFANEJD, char BOFJBOMFIJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x308AAD0", Offset = "0x30890D0", VA = "0x18308AAD0")]
	public static bool ACGADLFJNLD(OFAADMIACJD PKBENFANEJD, char BOFJBOMFIJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x308AC40", Offset = "0x3089240", VA = "0x18308AC40")]
	public static bool HLGIDJABEDO(OFAADMIACJD PKBENFANEJD, char BOFJBOMFIJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class IEMLBIFHCJI
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] EKMGNHLNJOO;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[ThreadStatic]
	private static byte[] NCLAOAHEKED;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly byte[] HACHELIJGBC;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly byte[] ALKKNCDBBCK;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly byte[] DLHFBLIODGG;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly int LABFCCGLBFD;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ushort[] FKJIJDPFKGC;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int AHEAPBABCKE;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1382360", Offset = "0x1380960", VA = "0x181382360")]
	private static byte[] OHCPAAMGGIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1382280", Offset = "0x1380880", VA = "0x181382280")]
	private static byte[] LOPIKGKJNFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1380E70", Offset = "0x137F470", VA = "0x181380E70")]
	public static double GGABBDBPACA(byte[] LFIKNNODPFA, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1380CA0", Offset = "0x137F2A0", VA = "0x181380CA0")]
	public static float DDDAIHBONCK(byte[] LFIKNNODPFA, int MPKAJNKONAC, out int ADAEPGMHMLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1382440", Offset = "0x1380A40", VA = "0x181382440")]
	private static bool PHLIGGDMNJE(int AEIHHPIDBGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1380F30", Offset = "0x137F530", VA = "0x181380F30")]
	private static bool IBJIHMDGFHN(ref OFAADMIACJD NFNIAFBOPAB, OFAADMIACJD LPDEFDFDBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1380D60", Offset = "0x137F360", VA = "0x181380D60")]
	private static bool DDFILHDJJIA(ref OFAADMIACJD NFNIAFBOPAB, OFAADMIACJD LPDEFDFDBMN, byte[] JNDLFAMJOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1381050", Offset = "0x137F650", VA = "0x181381050")]
	private static bool IKBCLPCBLNK(ref OFAADMIACJD OELGEHDLKNP, byte[] LPGAJGGCIPH, int MPKAJNKONAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD260", Offset = "0x6FB860", VA = "0x1806FD260")]
	private static double OBMGPMBOLMB(bool BAANHDLEGBL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x13810A0", Offset = "0x137F6A0", VA = "0x1813810A0")]
	private static double LMPEFOJCBCO(OFAADMIACJD ONALIHFMHLP, int DLLECELLJJB, bool OMNFMKFHCKO, out int ECGMNIPBDNM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class OGLKHFMCKAB<T> : global::CIMPKNEDLLC<T[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly global::DPHMMLIGFGP<T> KKFOKBHLOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly ELNHALMMBPB HFBAOLFJFBI;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1832DB0", Offset = "0x18313B0", VA = "0x181832DB0")]
	public OGLKHFMCKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x11268A0", Offset = "0x1124EA0", VA = "0x1811268A0")]
	public OGLKHFMCKAB(ELNHALMMBPB HFBAOLFJFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2353DB0", Offset = "0x23523B0", VA = "0x182353DB0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, T[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2353750", Offset = "0x2351D50", VA = "0x182353750", Slot = "5")]
	public T[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class EAMLAOOLLGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly global::DPHMMLIGFGP<T> KKFOKBHLOID;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class AIJOLNLFPGH<T> : global::CIMPKNEDLLC<List<T>>, CMAFIOMAECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly ELNHALMMBPB HFBAOLFJFBI;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1832DB0", Offset = "0x18313B0", VA = "0x181832DB0")]
	public AIJOLNLFPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x11268A0", Offset = "0x1124EA0", VA = "0x1811268A0")]
	public AIJOLNLFPGH(ELNHALMMBPB HFBAOLFJFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1832530", Offset = "0x1830B30", VA = "0x181832530", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, List<T> JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x18315C0", Offset = "0x182FBC0", VA = "0x1818315C0", Slot = "5")]
	public List<T> BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class IFFIKABFNBD<TElement, TIntermediate, TEnumerator, TCollection> : global::CIMPKNEDLLC<TCollection>, CMAFIOMAECA where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x21C5350", Offset = "0x21C3950", VA = "0x1821C5350", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, TCollection JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x21C4D00", Offset = "0x21C3300", VA = "0x1821C4D00", Slot = "5")]
	public TCollection BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator FCPLPHICHGP(TCollection IHKGCBCIIAK);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate NIBKLGLBMIL();

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void OAKCALBAGFG(ref TIntermediate CDFNNALLIOJ, int OEELHFBMNBJ, TElement JKOBKIEBPCF);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection JCIBKDPCAKO(ref TIntermediate CACALPNJEKC);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
	protected IFFIKABFNBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class NOLNGCDDCOJ<TElement, TIntermediate, TCollection> : global::IFFIKABFNBD<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x22BE4E0", Offset = "0x22BCAE0", VA = "0x1822BE4E0", Slot = "6")]
	protected override IEnumerator<TElement> FCPLPHICHGP(TCollection IHKGCBCIIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0xABAF20", Offset = "0xAB9520", VA = "0x180ABAF20")]
	protected NOLNGCDDCOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class AMBKDPKKFDN<TElement, TCollection> : global::NOLNGCDDCOJ<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected sealed override TCollection JCIBKDPCAKO(ref TCollection CACALPNJEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class NJIODIGFHLF<TElement, TCollection> : global::AMBKDPKKFDN<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1348490", Offset = "0x1346A90", VA = "0x181348490", Slot = "7")]
	protected override TCollection NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x13484B0", Offset = "0x1346AB0", VA = "0x1813484B0", Slot = "8")]
	protected override void OAKCALBAGFG(ref TCollection CDFNNALLIOJ, int OEELHFBMNBJ, TElement JKOBKIEBPCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class IEEOGFFCDBN<T> : global::IFFIKABFNBD<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x13D30E0", Offset = "0x13D16E0", VA = "0x1813D30E0", Slot = "8")]
	protected override void OAKCALBAGFG(ref LinkedList<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override LinkedList<T> JCIBKDPCAKO(ref LinkedList<T> CACALPNJEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override LinkedList<T> NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x21BCFC0", Offset = "0x21BB5C0", VA = "0x1821BCFC0", Slot = "6")]
	protected override LinkedList<T>.Enumerator FCPLPHICHGP(LinkedList<T> IHKGCBCIIAK)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class PJIEMKNCALA<T> : global::IFFIKABFNBD<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x13D30E0", Offset = "0x13D16E0", VA = "0x1813D30E0", Slot = "8")]
	protected override void OAKCALBAGFG(ref Queue<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override Queue<T> NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2636D20", Offset = "0x2635320", VA = "0x182636D20", Slot = "6")]
	protected override Queue<T>.Enumerator FCPLPHICHGP(Queue<T> IHKGCBCIIAK)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override Queue<T> JCIBKDPCAKO(ref Queue<T> CACALPNJEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class KLJFHECKGFC<T> : global::IFFIKABFNBD<T, global::CKMHPHCFEGC<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2123B90", Offset = "0x2122190", VA = "0x182123B90", Slot = "8")]
	protected override void OAKCALBAGFG(ref global::CKMHPHCFEGC<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2123B10", Offset = "0x2122110", VA = "0x182123B10", Slot = "7")]
	protected override global::CKMHPHCFEGC<T> NIBKLGLBMIL()
	{
		return default(global::CKMHPHCFEGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2636D20", Offset = "0x2635320", VA = "0x182636D20", Slot = "6")]
	protected override Stack<T>.Enumerator FCPLPHICHGP(Stack<T> IHKGCBCIIAK)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x40DB490", Offset = "0x40D9A90", VA = "0x1840DB490", Slot = "9")]
	protected override Stack<T> JCIBKDPCAKO(ref global::CKMHPHCFEGC<T> CACALPNJEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class ABKGJNBJOLF<T> : global::IFFIKABFNBD<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x13D30E0", Offset = "0x13D16E0", VA = "0x1813D30E0", Slot = "8")]
	protected override void OAKCALBAGFG(ref HashSet<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override HashSet<T> JCIBKDPCAKO(ref HashSet<T> CACALPNJEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override HashSet<T> NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2636D20", Offset = "0x2635320", VA = "0x182636D20", Slot = "6")]
	protected override HashSet<T>.Enumerator FCPLPHICHGP(HashSet<T> IHKGCBCIIAK)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class NPNLMIJCJJC<T> : global::NOLNGCDDCOJ<T, global::CKMHPHCFEGC<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2123B90", Offset = "0x2122190", VA = "0x182123B90", Slot = "8")]
	protected override void OAKCALBAGFG(ref global::CKMHPHCFEGC<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x22BE530", Offset = "0x22BCB30", VA = "0x1822BE530", Slot = "9")]
	protected override ReadOnlyCollection<T> JCIBKDPCAKO(ref global::CKMHPHCFEGC<T> CACALPNJEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x22BE5C0", Offset = "0x22BCBC0", VA = "0x1822BE5C0", Slot = "7")]
	protected override global::CKMHPHCFEGC<T> NIBKLGLBMIL()
	{
		return default(global::CKMHPHCFEGC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class PCIDEAHNNGM<T> : global::NOLNGCDDCOJ<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x13D30E0", Offset = "0x13D16E0", VA = "0x1813D30E0", Slot = "8")]
	protected override void OAKCALBAGFG(ref List<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override List<T> NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override IList<T> JCIBKDPCAKO(ref List<T> CACALPNJEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class JFMPPKJMMGJ<T> : global::NOLNGCDDCOJ<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x13D30E0", Offset = "0x13D16E0", VA = "0x1813D30E0", Slot = "8")]
	protected override void OAKCALBAGFG(ref List<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override List<T> NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override ICollection<T> JCIBKDPCAKO(ref List<T> CACALPNJEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class EIENLKALGLB<T> : global::NOLNGCDDCOJ<T, global::CKMHPHCFEGC<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2123B90", Offset = "0x2122190", VA = "0x182123B90", Slot = "8")]
	protected override void OAKCALBAGFG(ref global::CKMHPHCFEGC<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2123B10", Offset = "0x2122110", VA = "0x182123B10", Slot = "7")]
	protected override global::CKMHPHCFEGC<T> NIBKLGLBMIL()
	{
		return default(global::CKMHPHCFEGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x25C8530", Offset = "0x25C6B30", VA = "0x1825C8530", Slot = "9")]
	protected override IEnumerable<T> JCIBKDPCAKO(ref global::CKMHPHCFEGC<T> CACALPNJEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class BFHIGOOLCEF<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class NEOBDBJPJEJ<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class ANDFOEMLNOL<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class ONDMFBEHLEO : global::CIMPKNEDLLC<IEnumerable>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly global::CIMPKNEDLLC<IEnumerable> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x308B460", Offset = "0x3089A60", VA = "0x18308B460", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, IEnumerable JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x308B270", Offset = "0x3089870", VA = "0x18308B270", Slot = "5")]
	public IEnumerable BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ONDMFBEHLEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class NJGBBCKHGHK : global::CIMPKNEDLLC<ICollection>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly global::CIMPKNEDLLC<ICollection> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x308A0C0", Offset = "0x30886C0", VA = "0x18308A0C0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, ICollection JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3089ED0", Offset = "0x30884D0", VA = "0x183089ED0", Slot = "5")]
	public ICollection BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public NJGBBCKHGHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class KGOOHANMFHG : global::CIMPKNEDLLC<IList>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public static readonly global::CIMPKNEDLLC<IList> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1387820", Offset = "0x1385E20", VA = "0x181387820", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, IList JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x13876A0", Offset = "0x1385CA0", VA = "0x1813876A0", Slot = "5")]
	public IList BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public KGOOHANMFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class BODHPBOHFHB<T> : global::NOLNGCDDCOJ<T, global::CKMHPHCFEGC<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2123BC0", Offset = "0x21221C0", VA = "0x182123BC0", Slot = "8")]
	protected override void OAKCALBAGFG(ref global::CKMHPHCFEGC<T> CDFNNALLIOJ, int OEELHFBMNBJ, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2123B10", Offset = "0x2122110", VA = "0x182123B10", Slot = "7")]
	protected override global::CKMHPHCFEGC<T> NIBKLGLBMIL()
	{
		return default(global::CKMHPHCFEGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2123AD0", Offset = "0x21220D0", VA = "0x182123AD0", Slot = "9")]
	protected override IReadOnlyList<T> JCIBKDPCAKO(ref global::CKMHPHCFEGC<T> CACALPNJEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x9D8A80", Offset = "0x9D7080", VA = "0x1809D8A80")]
	public BODHPBOHFHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public static class OJBIELMFIHO
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x308B1D0", Offset = "0x30897D0", VA = "0x18308B1D0")]
	public static DateTime AGHNDIAFBCP(DateTime KBHHOOKNKFP)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JEGMNKNIEOB : global::CIMPKNEDLLC<DateTime>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly global::CIMPKNEDLLC<DateTime> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x1385500", Offset = "0x1383B00", VA = "0x181385500", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, DateTime JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1384600", Offset = "0x1382C00", VA = "0x181384600", Slot = "5")]
	public DateTime BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public JEGMNKNIEOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class LPNLPCENJBE : global::CIMPKNEDLLC<DateTimeOffset>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly global::CIMPKNEDLLC<DateTimeOffset> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x138DCD0", Offset = "0x138C2D0", VA = "0x18138DCD0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, DateTimeOffset JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x138CD30", Offset = "0x138B330", VA = "0x18138CD30", Slot = "5")]
	public DateTimeOffset BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public LPNLPCENJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class CALFAPFMLPD : global::CIMPKNEDLLC<TimeSpan>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::CIMPKNEDLLC<TimeSpan> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static byte[] AEELMIOAKMF;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1631E70", Offset = "0x1630470", VA = "0x181631E70", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, TimeSpan JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1631510", Offset = "0x162FB10", VA = "0x181631510", Slot = "5")]
	public TimeSpan BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public CALFAPFMLPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class JDIEPCDDDMG<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::CIMPKNEDLLC<TDictionary>, CMAFIOMAECA where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x13CC840", Offset = "0x13CAE40", VA = "0x1813CC840", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, TDictionary JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x13CC4D0", Offset = "0x13CAAD0", VA = "0x1813CC4D0", Slot = "5")]
	public TDictionary BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator FCPLPHICHGP(TDictionary IHKGCBCIIAK);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate NIBKLGLBMIL();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void OAKCALBAGFG(ref TIntermediate CDFNNALLIOJ, int OEELHFBMNBJ, TKey CAOGILCCJKA, TValue JKOBKIEBPCF);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary JCIBKDPCAKO(ref TIntermediate CACALPNJEKC);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
	protected JDIEPCDDDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class FFNFHBJOPAL<TKey, TValue, TIntermediate, TDictionary> : global::JDIEPCDDDMG<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x4693430", Offset = "0x4691A30", VA = "0x184693430", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> FCPLPHICHGP(TDictionary IHKGCBCIIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class PCJDDBBCDDK<TKey, TValue, TDictionary> : global::FFNFHBJOPAL<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override TDictionary JCIBKDPCAKO(ref TDictionary CACALPNJEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class BEDPBBAMDAL<TKey, TValue> : global::JDIEPCDDDMG<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x435F060", Offset = "0x435D660", VA = "0x18435F060", Slot = "8")]
	protected override void OAKCALBAGFG(ref Dictionary<TKey, TValue> CDFNNALLIOJ, int OEELHFBMNBJ, TKey CAOGILCCJKA, TValue JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override Dictionary<TKey, TValue> JCIBKDPCAKO(ref Dictionary<TKey, TValue> CACALPNJEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override Dictionary<TKey, TValue> NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x435F010", Offset = "0x435D610", VA = "0x18435F010", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator FCPLPHICHGP(Dictionary<TKey, TValue> IHKGCBCIIAK)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x816660", Offset = "0x814C60", VA = "0x180816660")]
	public BEDPBBAMDAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class CBKOGFDFOPN<TKey, TValue, TDictionary> : global::PCJDDBBCDDK<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x212A670", Offset = "0x2128C70", VA = "0x18212A670", Slot = "8")]
	protected override void OAKCALBAGFG(ref TDictionary CDFNNALLIOJ, int OEELHFBMNBJ, TKey CAOGILCCJKA, TValue JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x212A650", Offset = "0x2128C50", VA = "0x18212A650", Slot = "7")]
	protected override TDictionary NIBKLGLBMIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class GNOBLFNJIEM<TKey, TValue> : global::FFNFHBJOPAL<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x13D3C60", Offset = "0x13D2260", VA = "0x1813D3C60", Slot = "8")]
	protected override void OAKCALBAGFG(ref Dictionary<TKey, TValue> CDFNNALLIOJ, int OEELHFBMNBJ, TKey CAOGILCCJKA, TValue JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override Dictionary<TKey, TValue> NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override IDictionary<TKey, TValue> JCIBKDPCAKO(ref Dictionary<TKey, TValue> CACALPNJEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LGKECNOKANJ<TKey, TValue> : global::PCJDDBBCDDK<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x13D3C60", Offset = "0x13D2260", VA = "0x1813D3C60", Slot = "8")]
	protected override void OAKCALBAGFG(ref SortedList<TKey, TValue> CDFNNALLIOJ, int OEELHFBMNBJ, TKey CAOGILCCJKA, TValue JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override SortedList<TKey, TValue> NIBKLGLBMIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class JMBGGFEFAAN<TKey, TValue> : global::JDIEPCDDDMG<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x13D3C60", Offset = "0x13D2260", VA = "0x1813D3C60", Slot = "8")]
	protected override void OAKCALBAGFG(ref SortedDictionary<TKey, TValue> CDFNNALLIOJ, int OEELHFBMNBJ, TKey CAOGILCCJKA, TValue JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C50", Offset = "0x5B2250", VA = "0x1805B3C50", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> JCIBKDPCAKO(ref SortedDictionary<TKey, TValue> CACALPNJEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x13D3080", Offset = "0x13D1680", VA = "0x1813D3080", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> NIBKLGLBMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x13D3C00", Offset = "0x13D2200", VA = "0x1813D3C00", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator FCPLPHICHGP(SortedDictionary<TKey, TValue> IHKGCBCIIAK)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class DCCMCPJBPEA<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class EIIEJGMKKLH : global::CIMPKNEDLLC<IDictionary>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::CIMPKNEDLLC<IDictionary> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1378C30", Offset = "0x1377230", VA = "0x181378C30", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, IDictionary JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1378A90", Offset = "0x1377090", VA = "0x181378A90", Slot = "5")]
	public IDictionary BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public EIIEJGMKKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class MOJBAJLPKJN : global::CIMPKNEDLLC<object>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private delegate void EPOHKBHMJNK(object LAJOCGDGKGM, ref BMPIEHNPJPN HDBDALLEDMH, object JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly global::FGFFMNAANKL<KeyValuePair<object, EPOHKBHMJNK>> EGMPDNPDEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly FHMJHOEAOJN[] IEOMJCIOGCK;

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3086B90", Offset = "0x3085190", VA = "0x183086B90")]
	public MOJBAJLPKJN(params FHMJHOEAOJN[] IEOMJCIOGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x30862D0", Offset = "0x30848D0", VA = "0x1830862D0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, object JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3086240", Offset = "0x3084840", VA = "0x183086240", Slot = "5")]
	public object BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class APIDDGHOIPP
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x162BA80", Offset = "0x162A080", VA = "0x18162BA80")]
	public static object GKPIMKMFCBI(Type JOBKDGGGOHC, out bool HOHDFKLPJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x162C260", Offset = "0x162A860", VA = "0x18162C260")]
	public static object JLEACNGNKOB(Type JOBKDGGGOHC, out bool HOHDFKLPJDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public class ABLHMMEFDOD<T> : global::CIMPKNEDLLC<T>, CMAFIOMAECA, global::GNDMFBGILML<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class PNFNNBJNDEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public PNFNNBJNDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2645180", Offset = "0x2643780", VA = "0x182645180")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class NMOHBDIJJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public global::EEMFCFNOAAO<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public NMOHBDIJJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x26433D0", Offset = "0x26419D0", VA = "0x1826433D0")]
		internal void <.cctor>b__1(ref BMPIEHNPJPN writer, T value, FHMJHOEAOJN _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class DKHGLJDOCCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public global::KKELLOHBMEP<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public DKHGLJDOCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x263C8B0", Offset = "0x263AEB0", VA = "0x18263C8B0")]
		internal T <.cctor>b__2(ref NFEFKHAFCLC reader, FHMJHOEAOJN _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly global::DNFPLEHFLPI<T> EEBDNOCABLP;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly Dictionary<T, string> OKMIDJMENGI;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly global::EEMFCFNOAAO<T> OHDFJLMDFNP;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly global::KKELLOHBMEP<T> BIBMPHOMCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private readonly bool LDPMLNPAFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly global::EEMFCFNOAAO<T> AAJONOOMOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly global::KKELLOHBMEP<T> ADGENOEIPFF;

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2638990", Offset = "0x2636F90", VA = "0x182638990")]
	static ABLHMMEFDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x25481B0", Offset = "0x25467B0", VA = "0x1825481B0")]
	public ABLHMMEFDOD(bool LDPMLNPAFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x26376A0", Offset = "0x2635CA0", VA = "0x1826376A0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, T JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2636D70", Offset = "0x2635370", VA = "0x182636D70", Slot = "5")]
	public T BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2637400", Offset = "0x2635A00", VA = "0x182637400", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, T JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x26379C0", Offset = "0x2635FC0", VA = "0x1826379C0", Slot = "7")]
	public T MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class CKAFNCBKEDA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class ODHLMFOHIFL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class KAFDGOCFDCO<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class MICCNPFFOHP<T> : global::CIMPKNEDLLC<T?>, CMAFIOMAECA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x1D50120", Offset = "0x1D4E720", VA = "0x181D50120", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, T? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FE20", Offset = "0x1D4E420", VA = "0x181D4FE20", Slot = "5")]
	public T? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
	public MICCNPFFOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class OBIIBIMODMI<T> : global::CIMPKNEDLLC<T?>, CMAFIOMAECA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::CIMPKNEDLLC<T> BIKBEJAHDIL;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x13437C0", Offset = "0x1341DC0", VA = "0x1813437C0")]
	public OBIIBIMODMI(global::CIMPKNEDLLC<T> BIKBEJAHDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x296D6F0", Offset = "0x296BCF0", VA = "0x18296D6F0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, T? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x296BFE0", Offset = "0x296A5E0", VA = "0x18296BFE0", Slot = "5")]
	public T? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class BDAELFLDFCM : global::CIMPKNEDLLC<sbyte>, CMAFIOMAECA, global::GNDMFBGILML<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly BDAELFLDFCM PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x162CB10", Offset = "0x162B110", VA = "0x18162CB10", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, sbyte JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x162CA40", Offset = "0x162B040", VA = "0x18162CA40", Slot = "5")]
	public sbyte BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x162CA50", Offset = "0x162B050", VA = "0x18162CA50", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, sbyte JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x162CB50", Offset = "0x162B150", VA = "0x18162CB50", Slot = "7")]
	public sbyte MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public BDAELFLDFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class CPKJDAADBOA : global::CIMPKNEDLLC<sbyte?>, CMAFIOMAECA, global::GNDMFBGILML<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly CPKJDAADBOA PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1635240", Offset = "0x1633840", VA = "0x181635240", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, sbyte? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x16350D0", Offset = "0x16336D0", VA = "0x1816350D0", Slot = "5")]
	public sbyte? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x1635140", Offset = "0x1633740", VA = "0x181635140", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, sbyte? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x16352C0", Offset = "0x16338C0", VA = "0x1816352C0", Slot = "7")]
	public sbyte? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public CPKJDAADBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class LNAPMGGLEKN : global::CIMPKNEDLLC<sbyte[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly LNAPMGGLEKN PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x138A350", Offset = "0x1388950", VA = "0x18138A350", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, sbyte[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x138A210", Offset = "0x1388810", VA = "0x18138A210", Slot = "5")]
	public sbyte[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public LNAPMGGLEKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class BIMINMIFCNP : global::CIMPKNEDLLC<short>, CMAFIOMAECA, global::GNDMFBGILML<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly BIMINMIFCNP PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x162DA10", Offset = "0x162C010", VA = "0x18162DA10", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, short JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x162D940", Offset = "0x162BF40", VA = "0x18162D940", Slot = "5")]
	public short BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x162D950", Offset = "0x162BF50", VA = "0x18162D950", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, short JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x162DA50", Offset = "0x162C050", VA = "0x18162DA50", Slot = "7")]
	public short MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public BIMINMIFCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class DGAMDPKOMBO : global::CIMPKNEDLLC<short?>, CMAFIOMAECA, global::GNDMFBGILML<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly DGAMDPKOMBO PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x1635D40", Offset = "0x1634340", VA = "0x181635D40", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, short? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x1635BD0", Offset = "0x16341D0", VA = "0x181635BD0", Slot = "5")]
	public short? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x1635C40", Offset = "0x1634240", VA = "0x181635C40", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, short? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x1635DC0", Offset = "0x16343C0", VA = "0x181635DC0", Slot = "7")]
	public short? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public DGAMDPKOMBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class JEGFMPAMELP : global::CIMPKNEDLLC<short[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly JEGFMPAMELP PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x13844E0", Offset = "0x1382AE0", VA = "0x1813844E0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, short[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x13843A0", Offset = "0x13829A0", VA = "0x1813843A0", Slot = "5")]
	public short[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public JEGFMPAMELP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class MKBCMMBFJII : global::CIMPKNEDLLC<int>, CMAFIOMAECA, global::GNDMFBGILML<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly MKBCMMBFJII PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3085D70", Offset = "0x3084370", VA = "0x183085D70", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, int JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3085CD0", Offset = "0x30842D0", VA = "0x183085CD0", Slot = "5")]
	public int BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x3085D30", Offset = "0x3084330", VA = "0x183085D30", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, int JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x3085D80", Offset = "0x3084380", VA = "0x183085D80", Slot = "7")]
	public int MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public MKBCMMBFJII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class JAIJDFLPGHH : global::CIMPKNEDLLC<int?>, CMAFIOMAECA, global::GNDMFBGILML<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly JAIJDFLPGHH PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x1383950", Offset = "0x1381F50", VA = "0x181383950", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, int? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x1383860", Offset = "0x1381E60", VA = "0x181383860", Slot = "5")]
	public int? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x13838D0", Offset = "0x1381ED0", VA = "0x1813838D0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, int? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x13839C0", Offset = "0x1381FC0", VA = "0x1813839C0", Slot = "7")]
	public int? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public JAIJDFLPGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class OJAGANFDPLN : global::CIMPKNEDLLC<int[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly OJAGANFDPLN PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x308B0B0", Offset = "0x30896B0", VA = "0x18308B0B0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, int[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x308AF10", Offset = "0x3089510", VA = "0x18308AF10", Slot = "5")]
	public int[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public OJAGANFDPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class AGJJBCNGFMH : global::CIMPKNEDLLC<long>, CMAFIOMAECA, global::GNDMFBGILML<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly AGJJBCNGFMH PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x162A6F0", Offset = "0x1628CF0", VA = "0x18162A6F0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, long JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x162A620", Offset = "0x1628C20", VA = "0x18162A620", Slot = "5")]
	public long BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x162A630", Offset = "0x1628C30", VA = "0x18162A630", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, long JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x162A720", Offset = "0x1628D20", VA = "0x18162A720", Slot = "7")]
	public long MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public AGJJBCNGFMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class PFKECOHFBGK : global::CIMPKNEDLLC<long?>, CMAFIOMAECA, global::GNDMFBGILML<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly PFKECOHFBGK PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x308C040", Offset = "0x308A640", VA = "0x18308C040", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, long? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x308BF30", Offset = "0x308A530", VA = "0x18308BF30", Slot = "5")]
	public long? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x308BFC0", Offset = "0x308A5C0", VA = "0x18308BFC0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, long? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x308C0B0", Offset = "0x308A6B0", VA = "0x18308C0B0", Slot = "7")]
	public long? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public PFKECOHFBGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class BFKLBMHGCCJ : global::CIMPKNEDLLC<long[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly BFKLBMHGCCJ PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x162CD60", Offset = "0x162B360", VA = "0x18162CD60", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, long[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x162CC20", Offset = "0x162B220", VA = "0x18162CC20", Slot = "5")]
	public long[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public BFKLBMHGCCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class POKOAGEEEEJ : global::CIMPKNEDLLC<byte>, CMAFIOMAECA, global::GNDMFBGILML<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly POKOAGEEEEJ PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x308CE10", Offset = "0x308B410", VA = "0x18308CE10", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, byte JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x308CD70", Offset = "0x308B370", VA = "0x18308CD70", Slot = "5")]
	public byte BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x308CDD0", Offset = "0x308B3D0", VA = "0x18308CDD0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, byte JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x308CE30", Offset = "0x308B430", VA = "0x18308CE30", Slot = "7")]
	public byte MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public POKOAGEEEEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class HLGECCBLLGB : global::CIMPKNEDLLC<byte?>, CMAFIOMAECA, global::GNDMFBGILML<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly HLGECCBLLGB PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x137E900", Offset = "0x137CF00", VA = "0x18137E900", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, byte? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x137E810", Offset = "0x137CE10", VA = "0x18137E810", Slot = "5")]
	public byte? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x137E880", Offset = "0x137CE80", VA = "0x18137E880", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, byte? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x137E970", Offset = "0x137CF70", VA = "0x18137E970", Slot = "7")]
	public byte? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public HLGECCBLLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class EDGEFJFHKND : global::CIMPKNEDLLC<ushort>, CMAFIOMAECA, global::GNDMFBGILML<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly EDGEFJFHKND PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x1377E00", Offset = "0x1376400", VA = "0x181377E00", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, ushort JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x1377DB0", Offset = "0x13763B0", VA = "0x181377DB0", Slot = "5")]
	public ushort BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1377DC0", Offset = "0x13763C0", VA = "0x181377DC0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, ushort JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x1377E20", Offset = "0x1376420", VA = "0x181377E20", Slot = "7")]
	public ushort MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public EDGEFJFHKND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class ENNDEILHACE : global::CIMPKNEDLLC<ushort?>, CMAFIOMAECA, global::GNDMFBGILML<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly ENNDEILHACE PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x1379C00", Offset = "0x1378200", VA = "0x181379C00", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, ushort? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1379B10", Offset = "0x1378110", VA = "0x181379B10", Slot = "5")]
	public ushort? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1379B80", Offset = "0x1378180", VA = "0x181379B80", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, ushort? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x1379C70", Offset = "0x1378270", VA = "0x181379C70", Slot = "7")]
	public ushort? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ENNDEILHACE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class CHHNBJNCKJF : global::CIMPKNEDLLC<ushort[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly CHHNBJNCKJF PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1634350", Offset = "0x1632950", VA = "0x181634350", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, ushort[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1634210", Offset = "0x1632810", VA = "0x181634210", Slot = "5")]
	public ushort[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public CHHNBJNCKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class OIEDLABNFLD : global::CIMPKNEDLLC<uint>, CMAFIOMAECA, global::GNDMFBGILML<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly OIEDLABNFLD PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x308AE00", Offset = "0x3089400", VA = "0x18308AE00", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, uint JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x308AD60", Offset = "0x3089360", VA = "0x18308AD60", Slot = "5")]
	public uint BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x308ADC0", Offset = "0x30893C0", VA = "0x18308ADC0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, uint JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x308AE10", Offset = "0x3089410", VA = "0x18308AE10", Slot = "7")]
	public uint MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public OIEDLABNFLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class JIBDDCGFHFO : global::CIMPKNEDLLC<uint?>, CMAFIOMAECA, global::GNDMFBGILML<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly JIBDDCGFHFO PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1385C60", Offset = "0x1384260", VA = "0x181385C60", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, uint? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1385B70", Offset = "0x1384170", VA = "0x181385B70", Slot = "5")]
	public uint? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x1385BE0", Offset = "0x13841E0", VA = "0x181385BE0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, uint? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x1385CD0", Offset = "0x13842D0", VA = "0x181385CD0", Slot = "7")]
	public uint? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public JIBDDCGFHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class JBGIOMEEFAG : global::CIMPKNEDLLC<uint[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly JBGIOMEEFAG PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1383F50", Offset = "0x1382550", VA = "0x181383F50", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, uint[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1383E10", Offset = "0x1382410", VA = "0x181383E10", Slot = "5")]
	public uint[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public JBGIOMEEFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class BNOPIIMDBGM : global::CIMPKNEDLLC<ulong>, CMAFIOMAECA, global::GNDMFBGILML<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly BNOPIIMDBGM PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x162F200", Offset = "0x162D800", VA = "0x18162F200", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, ulong JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x162F130", Offset = "0x162D730", VA = "0x18162F130", Slot = "5")]
	public ulong BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x162F140", Offset = "0x162D740", VA = "0x18162F140", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, ulong JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x162F230", Offset = "0x162D830", VA = "0x18162F230", Slot = "7")]
	public ulong MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public BNOPIIMDBGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class DADDCCNINBI : global::CIMPKNEDLLC<ulong?>, CMAFIOMAECA, global::GNDMFBGILML<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly DADDCCNINBI PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1635560", Offset = "0x1633B60", VA = "0x181635560", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, ulong? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x16353D0", Offset = "0x16339D0", VA = "0x1816353D0", Slot = "5")]
	public ulong? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1635460", Offset = "0x1633A60", VA = "0x181635460", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, ulong? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x16355E0", Offset = "0x1633BE0", VA = "0x1816355E0", Slot = "7")]
	public ulong? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public DADDCCNINBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class IGINDKNGMJJ : global::CIMPKNEDLLC<ulong[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly IGINDKNGMJJ PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1382950", Offset = "0x1380F50", VA = "0x181382950", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, ulong[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x1382810", Offset = "0x1380E10", VA = "0x181382810", Slot = "5")]
	public ulong[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public IGINDKNGMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class BKHAKPOHCDK : global::CIMPKNEDLLC<float>, CMAFIOMAECA, global::GNDMFBGILML<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly BKHAKPOHCDK PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x162DBE0", Offset = "0x162C1E0", VA = "0x18162DBE0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, float JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x162DB20", Offset = "0x162C120", VA = "0x18162DB20", Slot = "5")]
	public float BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x162DB30", Offset = "0x162C130", VA = "0x18162DB30", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, float JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x162DBF0", Offset = "0x162C1F0", VA = "0x18162DBF0", Slot = "7")]
	public float MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public BKHAKPOHCDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class FKPEFMAFOKD : global::CIMPKNEDLLC<float?>, CMAFIOMAECA, global::GNDMFBGILML<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly FKPEFMAFOKD PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x137A920", Offset = "0x1378F20", VA = "0x18137A920", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, float? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x137A830", Offset = "0x1378E30", VA = "0x18137A830", Slot = "5")]
	public float? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x137A8A0", Offset = "0x1378EA0", VA = "0x18137A8A0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, float? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x137A990", Offset = "0x1378F90", VA = "0x18137A990", Slot = "7")]
	public float? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public FKPEFMAFOKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class FCDKBDHMADH : global::CIMPKNEDLLC<float[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly FCDKBDHMADH PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x137A050", Offset = "0x1378650", VA = "0x18137A050", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, float[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x1379F10", Offset = "0x1378510", VA = "0x181379F10", Slot = "5")]
	public float[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public FCDKBDHMADH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class KGHMNMGEBEG : global::CIMPKNEDLLC<double>, CMAFIOMAECA, global::GNDMFBGILML<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly KGHMNMGEBEG PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x13875C0", Offset = "0x1385BC0", VA = "0x1813875C0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, double JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1387570", Offset = "0x1385B70", VA = "0x181387570", Slot = "5")]
	public double BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x1387580", Offset = "0x1385B80", VA = "0x181387580", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, double JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x13875D0", Offset = "0x1385BD0", VA = "0x1813875D0", Slot = "7")]
	public double MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public KGHMNMGEBEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class KIPHAHNDOHI : global::CIMPKNEDLLC<double?>, CMAFIOMAECA, global::GNDMFBGILML<double?>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly KIPHAHNDOHI PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x1387D70", Offset = "0x1386370", VA = "0x181387D70", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, double? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x1387C60", Offset = "0x1386260", VA = "0x181387C60", Slot = "5")]
	public double? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x1387CF0", Offset = "0x13862F0", VA = "0x181387CF0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, double? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1387DE0", Offset = "0x13863E0", VA = "0x181387DE0", Slot = "7")]
	public double? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public KIPHAHNDOHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class EANJBAGPOFJ : global::CIMPKNEDLLC<double[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly EANJBAGPOFJ PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x1376BB0", Offset = "0x13751B0", VA = "0x181376BB0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, double[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x1376A70", Offset = "0x1375070", VA = "0x181376A70", Slot = "5")]
	public double[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public EANJBAGPOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class EOBOBDLJECN : global::CIMPKNEDLLC<bool>, CMAFIOMAECA, global::GNDMFBGILML<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly EOBOBDLJECN PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1379E20", Offset = "0x1378420", VA = "0x181379E20", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, bool JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1379DD0", Offset = "0x13783D0", VA = "0x181379DD0", Slot = "5")]
	public bool BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1379DE0", Offset = "0x13783E0", VA = "0x181379DE0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, bool JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1379E40", Offset = "0x1378440", VA = "0x181379E40", Slot = "7")]
	public bool MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public EOBOBDLJECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class IKJDIAMPNPJ : global::CIMPKNEDLLC<bool?>, CMAFIOMAECA, global::GNDMFBGILML<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly IKJDIAMPNPJ PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1382C20", Offset = "0x1381220", VA = "0x181382C20", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, bool? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1382B30", Offset = "0x1381130", VA = "0x181382B30", Slot = "5")]
	public bool? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1382BA0", Offset = "0x13811A0", VA = "0x181382BA0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, bool? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1382C90", Offset = "0x1381290", VA = "0x181382C90", Slot = "7")]
	public bool? MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public IKJDIAMPNPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class DMPAJIBIBFC : global::CIMPKNEDLLC<bool[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly DMPAJIBIBFC PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1376940", Offset = "0x1374F40", VA = "0x181376940", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, bool[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1376800", Offset = "0x1374E00", VA = "0x181376800", Slot = "5")]
	public bool[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public DMPAJIBIBFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class EBHLAKMJMML : global::CIMPKNEDLLC<object>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly global::CIMPKNEDLLC<object> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly Dictionary<Type, int> OCDIHBEBJDO;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1376F70", Offset = "0x1375570", VA = "0x181376F70", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, object JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1376CD0", Offset = "0x13752D0", VA = "0x181376CD0", Slot = "5")]
	public object BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public EBHLAKMJMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class BKNFNAMNCCD : global::CIMPKNEDLLC<byte[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly global::CIMPKNEDLLC<byte[]> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x162DD40", Offset = "0x162C340", VA = "0x18162DD40", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, byte[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x162DCC0", Offset = "0x162C2C0", VA = "0x18162DCC0", Slot = "5")]
	public byte[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public BKNFNAMNCCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class EIOJHEPBFEC : global::CIMPKNEDLLC<ArraySegment<byte>>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly global::CIMPKNEDLLC<ArraySegment<byte>> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x13790E0", Offset = "0x13776E0", VA = "0x1813790E0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, ArraySegment<byte> JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1379010", Offset = "0x1377610", VA = "0x181379010", Slot = "5")]
	public ArraySegment<byte> BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public EIOJHEPBFEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class IOFIKNIPCPD : global::CIMPKNEDLLC<string>, CMAFIOMAECA, global::GNDMFBGILML<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly global::CIMPKNEDLLC<string> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x13837E0", Offset = "0x1381DE0", VA = "0x1813837E0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, string JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x13837D0", Offset = "0x1381DD0", VA = "0x1813837D0", Slot = "5")]
	public string BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x13837E0", Offset = "0x1381DE0", VA = "0x1813837E0", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, string JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x13837D0", Offset = "0x1381DD0", VA = "0x1813837D0", Slot = "7")]
	public string MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public IOFIKNIPCPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class NBPNBFHHKLA : global::CIMPKNEDLLC<string[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly NBPNBFHHKLA PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x3087180", Offset = "0x3085780", VA = "0x183087180", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, string[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x3086FE0", Offset = "0x30855E0", VA = "0x183086FE0", Slot = "5")]
	public string[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public NBPNBFHHKLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class GBKBHFHELCO : global::CIMPKNEDLLC<char>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly GBKBHFHELCO PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x137ACF0", Offset = "0x13792F0", VA = "0x18137ACF0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, char JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x137ACC0", Offset = "0x13792C0", VA = "0x18137ACC0", Slot = "5")]
	public char BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public GBKBHFHELCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class AOKFHIJPENL : global::CIMPKNEDLLC<char?>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly AOKFHIJPENL PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x162B950", Offset = "0x1629F50", VA = "0x18162B950", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, char? JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x162B890", Offset = "0x1629E90", VA = "0x18162B890", Slot = "5")]
	public char? BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public AOKFHIJPENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class MKLAENMLBGE : global::CIMPKNEDLLC<char[]>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly MKLAENMLBGE PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x3086060", Offset = "0x3084660", VA = "0x183086060", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, char[] JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x3085E80", Offset = "0x3084480", VA = "0x183085E80", Slot = "5")]
	public char[] BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public MKLAENMLBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class EEGEBNFFOCH : global::CIMPKNEDLLC<Guid>, CMAFIOMAECA, global::GNDMFBGILML<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::CIMPKNEDLLC<Guid> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1378030", Offset = "0x1376630", VA = "0x181378030", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Guid JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1377EF0", Offset = "0x13764F0", VA = "0x181377EF0", Slot = "5")]
	public Guid BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x1377F50", Offset = "0x1376550", VA = "0x181377F50", Slot = "6")]
	public void FACBNEJJACD(ref BMPIEHNPJPN HDBDALLEDMH, Guid JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x1377EF0", Offset = "0x13764F0", VA = "0x181377EF0", Slot = "7")]
	public Guid MFKIODDDBLB(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public EEGEBNFFOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class JBFCKHPBJPA : global::CIMPKNEDLLC<decimal>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::CIMPKNEDLLC<decimal> PLAPLAPINBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly bool NKPPBLPCDKO;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xC49890", Offset = "0xC47E90", VA = "0x180C49890")]
	public JBFCKHPBJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xC49860", Offset = "0xC47E60", VA = "0x180C49860")]
	public JBFCKHPBJPA(bool NKPPBLPCDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x1383C70", Offset = "0x1382270", VA = "0x181383C70", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, decimal JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x1383AC0", Offset = "0x13820C0", VA = "0x181383AC0", Slot = "5")]
	public decimal BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class KLOADHAGOAH : global::CIMPKNEDLLC<Uri>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::CIMPKNEDLLC<Uri> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x1388100", Offset = "0x1386700", VA = "0x181388100", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Uri JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x1388080", Offset = "0x1386680", VA = "0x181388080", Slot = "5")]
	public Uri BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public KLOADHAGOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class FHNAMGAKCJJ : global::CIMPKNEDLLC<Version>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::CIMPKNEDLLC<Version> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x137A5A0", Offset = "0x1378BA0", VA = "0x18137A5A0", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Version JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x137A520", Offset = "0x1378B20", VA = "0x18137A520", Slot = "5")]
	public Version BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public FHNAMGAKCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class DCNNAACHAPC<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class CMKIBGCBIBH : global::CIMPKNEDLLC<StringBuilder>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::CIMPKNEDLLC<StringBuilder> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1634850", Offset = "0x1632E50", VA = "0x181634850", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, StringBuilder JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x16347D0", Offset = "0x1632DD0", VA = "0x1816347D0", Slot = "5")]
	public StringBuilder BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public CMKIBGCBIBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class NKFBJGGMOGJ : global::CIMPKNEDLLC<BitArray>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::CIMPKNEDLLC<BitArray> PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x308A520", Offset = "0x3088B20", VA = "0x18308A520", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, BitArray JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x308A3C0", Offset = "0x30889C0", VA = "0x18308A3C0", Slot = "5")]
	public BitArray BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public NKFBJGGMOGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class JBIEJNINFHO : global::CIMPKNEDLLC<Type>, CMAFIOMAECA
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly JBIEJNINFHO PLAPLAPINBF;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly Regex KPLKBGFGEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private bool MGEHGBIPFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private bool CKKNEIGEECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private bool GOONDFPCPDB;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1384320", Offset = "0x1382920", VA = "0x181384320")]
	public JBIEJNINFHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1384340", Offset = "0x1382940", VA = "0x181384340")]
	public JBIEJNINFHO(bool MGEHGBIPFBF, bool CKKNEIGEECN, bool GOONDFPCPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1384190", Offset = "0x1382790", VA = "0x181384190", Slot = "4")]
	public void HINACFMEGJE(ref BMPIEHNPJPN HDBDALLEDMH, Type JKOBKIEBPCF, FHMJHOEAOJN CEPCCKJNDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1384070", Offset = "0x1382670", VA = "0x181384070", Slot = "5")]
	public Type BJFPGPPGGLJ(ref NFEFKHAFCLC MDFCOIBMJJO, FHMJHOEAOJN CEPCCKJNDFK)
	{
		return null;
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
