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
public class MDHMJCHBDFG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
	public MDHMJCHBDFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class ANAJFEBPCGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
	public ANAJFEBPCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OOEMDNHAJCB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
	public OOEMDNHAJCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JCEMCPMLABC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
	public JCEMCPMLABC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class NNMHEMPPHJE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x366A330", Offset = "0x3668B30", VA = "0x18366A330")]
	public static bool FCOAEMLFDFB(this TypeInfo BKDBLJPNPPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class ILAAOCIGACH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type DAADMNDNNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] MAEFELADPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xCB5DB0", Offset = "0xCB45B0", VA = "0x180CB5DB0")]
	public ILAAOCIGACH(Type LOFHDMOIPNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class GCPHBKFNHBI : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void KFCLCAGODGO<T>(ref FDFDFLKINMJ HELLEMCMMHJ, T CJMMBFLIBMO, KMJPBNOKBLE DPKMGFEILJN);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T ELHCLKOEDFH<T>(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE DPKMGFEILJN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GLLCIPEHDNF
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EBPKMMEFPKF<T> : GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, T CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EBKMAPBBMKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, T CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ACBHEFGEMFO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ADJDCFLNOMK
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x13CF7C0", Offset = "0x13CDFC0", VA = "0x1813CF7C0")]
	public static global::EBPKMMEFPKF<T> CBINBJBJHOF<T>(this KMJPBNOKBLE DPKMGFEILJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D5FDF0", Offset = "0x1D5E5F0", VA = "0x181D5FDF0")]
	public static object EAIGDKIMEHK(this KMJPBNOKBLE DPKMGFEILJN, Type BKDBLJPNPPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class POFINBFFKEJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x366F8E0", Offset = "0x366E0E0", VA = "0x18366F8E0")]
	public POFINBFFKEJ(string MEKFJFMIPGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HMLHAIACJAH
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class KBMKMLIECLM
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] POKOCMHLPLN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] PBDJKJBIEME;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x238BD10", Offset = "0x238A510", VA = "0x18238BD10")]
		public static byte[] COBMIGELNEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x238BD90", Offset = "0x238A590", VA = "0x18238BD90")]
		public static char[] EHCNLEANKHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> NPMACOICEKH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] EFMDPACAKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] FCDIIMLAMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int IBIPCEJMDGF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool NFLAGPCGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2383BD0", Offset = "0x23823D0", VA = "0x182383BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x23851C0", Offset = "0x23839C0", VA = "0x1823851C0")]
	public HMLHAIACJAH(byte[] FCDIIMLAMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x23851D0", Offset = "0x23839D0", VA = "0x1823851D0")]
	public HMLHAIACJAH(byte[] FCDIIMLAMIO, int IBIPCEJMDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2383C70", Offset = "0x2382470", VA = "0x182383C70")]
	private HIJGIECNDBA IJOJGNPCOHC(string LOJNPGFNJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2384820", Offset = "0x2383020", VA = "0x182384820")]
	private HIJGIECNDBA MILGBNJELOE(string MEKFJFMIPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1D73850", Offset = "0x1D72050", VA = "0x181D73850")]
	public void JDNKNBAJIKK(int IBIPCEJMDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
	public byte[] CCDAIHBHDAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xAECF60", Offset = "0xAEB760", VA = "0x180AECF60")]
	public int EEGOIENMJHI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2384E10", Offset = "0x2383610", VA = "0x182384E10")]
	public KJKAIFPPMBP OLPNKEJNAME()
	{
		return default(KJKAIFPPMBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2384110", Offset = "0x2382910", VA = "0x182384110")]
	public void INACELOBBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2384A80", Offset = "0x2383280", VA = "0x182384A80")]
	public bool NHKAFEFKHLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2384900", Offset = "0x2383100", VA = "0x182384900")]
	public bool NAOICFCGJCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2384FA0", Offset = "0x23837A0", VA = "0x182384FA0")]
	public void PDIBAIPHAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2384C40", Offset = "0x2383440", VA = "0x182384C40")]
	public bool OAALINPDAJO(ref int FKDPJOHPNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2384CD0", Offset = "0x23834D0", VA = "0x182384CD0")]
	public bool ODHCNCGIGEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2383750", Offset = "0x2381F50", VA = "0x182383750")]
	public void GKIHHCILIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2384320", Offset = "0x2382B20", VA = "0x182384320")]
	public bool JBEMJODAEOI(ref int FKDPJOHPNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2384DA0", Offset = "0x23835A0", VA = "0x182384DA0")]
	public bool OJGGLKIACEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2384BA0", Offset = "0x23833A0", VA = "0x182384BA0")]
	public void NODLGPGIPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2383350", Offset = "0x2381B50", VA = "0x182383350")]
	public bool FEEMCPIFIAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2385040", Offset = "0x2383840", VA = "0x182385040")]
	public void PFPDJBPPHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2382B60", Offset = "0x2381360", VA = "0x182382B60")]
	private void DONEKHMAGJC(out byte[] LFLFFLCAFHJ, out int HOJDJCPOCFE, out int BKOALMNIAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2382870", Offset = "0x2381070", VA = "0x182382870")]
	private static int BFJKAGBKPEO(char DKLHMFCLOAB, char FLEBMPFFCAA, char AFHPHPIIHBD, char PEAOIEMLDCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2384410", Offset = "0x2382C10", VA = "0x182384410")]
	private static int KBCCNLABIBM(char FGCAOGJDCFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x23829D0", Offset = "0x23811D0", VA = "0x1823829D0")]
	public ArraySegment<byte> DFMMFJFLIMC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2382AC0", Offset = "0x23812C0", VA = "0x182382AC0")]
	public string DLADADMNAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2382840", Offset = "0x2381040", VA = "0x182382840")]
	public string ANGONBELOHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x23833C0", Offset = "0x2381BC0", VA = "0x1823833C0")]
	public ArraySegment<byte> FKGAKFLFOGO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2384600", Offset = "0x2382E00", VA = "0x182384600")]
	public ArraySegment<byte> LCFCGNKEMGC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2383970", Offset = "0x2382170", VA = "0x182383970")]
	public bool GPMJKGMEHOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2384760", Offset = "0x2382F60", VA = "0x182384760")]
	private static bool LEMHKKHNCPM(byte AFHPHPIIHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2383580", Offset = "0x2381D80", VA = "0x182383580")]
	private void GJHMPNPHFDN(KJKAIFPPMBP HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2383570", Offset = "0x2381D70", VA = "0x182383570")]
	public void GDICKJJIEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2384250", Offset = "0x2382A50", VA = "0x182384250")]
	private void JAEIPBKNBNA(int IHEPLPEPEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2382920", Offset = "0x2381120", VA = "0x182382920")]
	public sbyte BGCKMCGIEJE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2382970", Offset = "0x2381170", VA = "0x182382970")]
	public short BPJJEJAHBIF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23832F0", Offset = "0x2381AF0", VA = "0x1823832F0")]
	public int EAAIMFPOALE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2384970", Offset = "0x2383170", VA = "0x182384970")]
	public long NBBMMPIFDGI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2384D40", Offset = "0x2383540", VA = "0x182384D40")]
	public byte OEODIDOILHE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x23845A0", Offset = "0x2382DA0", VA = "0x1823845A0")]
	public ushort KFAPBEALDII()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23843B0", Offset = "0x2382BB0", VA = "0x1823843B0")]
	public uint JIDDPEKDBAH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2383BF0", Offset = "0x23823F0", VA = "0x182383BF0")]
	public ulong IHDMMIAMHAG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2382780", Offset = "0x2380F80", VA = "0x182382780")]
	public float AEDCNNGGIGD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x23844E0", Offset = "0x2382CE0", VA = "0x1823844E0")]
	public double KEPMJCGHGKC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2384640", Offset = "0x2382E40", VA = "0x182384640")]
	public ArraySegment<byte> LELJDJJFEFC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x23837F0", Offset = "0x2381FF0", VA = "0x1823837F0")]
	private static int GKJEEGNDDOB(byte[] FCDIIMLAMIO, int IBIPCEJMDGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HIJGIECNDBA : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference OFICPLKDJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int MIOEJBDGNLN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int CDFFNBPOAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x909C30", Offset = "0x908430", VA = "0x180909C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string PCFCGHHIMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6089C0", Offset = "0x6071C0", VA = "0x1806089C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2382640", Offset = "0x2380E40", VA = "0x182382640")]
	public HIJGIECNDBA(string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x23826B0", Offset = "0x2380EB0", VA = "0x1823826B0")]
	public HIJGIECNDBA(string MEKFJFMIPGK, byte[] HOCJJLFEFHL, int IBIPCEJMDGF, int MIOEJBDGNLN, string LIDDOAJDDJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GHDODINKGLE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class LIAMOIJGDLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void FLOIGJIBBKI(ref FDFDFLKINMJ HELLEMCMMHJ, object CJMMBFLIBMO, KMJPBNOKBLE DPKMGFEILJN);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object FDPICLMMDBP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE DPKMGFEILJN);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class HDILGFOKGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class GODFKFFMPGM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
				public GODFKFFMPGM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x237D9E0", Offset = "0x237C1E0", VA = "0x18237D9E0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x237DA20", Offset = "0x237C220", VA = "0x18237DA20")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, KMJPBNOKBLE, byte[]> OHOCAOIGDHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, KMJPBNOKBLE> PKHBMCOOAGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly FLOIGJIBBKI HAAGBCEEJIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, KMJPBNOKBLE, ArraySegment<byte>> EEIEBPABLMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, KMJPBNOKBLE, string> DDJEPDHPFJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, KMJPBNOKBLE, object> MMDBJJOBFOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, KMJPBNOKBLE, object> NFACMOCCKMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, KMJPBNOKBLE, object> NDPKOCJADAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly FDPICLMMDBP ODOIMOIBGHA;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x237E880", Offset = "0x237D080", VA = "0x18237E880")]
			public HDILGFOKGPJ(Type BKDBLJPNPPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1C36030", Offset = "0x1C34830", VA = "0x181C36030")]
			private static T JPKGDNANBHF<T>(DynamicMethod PNJEOIIACOH)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x237E690", Offset = "0x237CE90", VA = "0x18237E690")]
			private static MethodInfo BPAIBOHLAPM(Type BKDBLJPNPPJ, string JNAACNJBHOF, Type[] PHLFHLMOLBI)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, HDILGFOKGPJ> CEIBBGIFEPN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::PJOGIOBAPNH<HDILGFOKGPJ> DDABACOFMJC;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x238D650", Offset = "0x238BE50", VA = "0x18238D650")]
		static LIAMOIJGDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x238D5D0", Offset = "0x238BDD0", VA = "0x18238D5D0")]
		private static HDILGFOKGPJ MNIGICDMADL(Type BKDBLJPNPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x238D350", Offset = "0x238BB50", VA = "0x18238D350")]
		public static void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, object CJMMBFLIBMO, KMJPBNOKBLE DPKMGFEILJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x238D4C0", Offset = "0x238BCC0", VA = "0x18238D4C0")]
		public static void BAGHAKDDGPK(Type BKDBLJPNPPJ, ref FDFDFLKINMJ HELLEMCMMHJ, object CJMMBFLIBMO, KMJPBNOKBLE DPKMGFEILJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class BIKDLOELECA
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] POKOCMHLPLN;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2377500", Offset = "0x2375D00", VA = "0x182377500")]
		public static byte[] COBMIGELNEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KMJPBNOKBLE GMGIDPLCPNA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] AGOJALIGEPM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] GMLCAPLMCDL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KMJPBNOKBLE GJMLHAJNIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x237BA50", Offset = "0x237A250", VA = "0x18237BA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x237B9F0", Offset = "0x237A1F0", VA = "0x18237B9F0")]
	public static void APFMBPPDCLA(KMJPBNOKBLE DPKMGFEILJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4F5A8E0", Offset = "0x4F590E0", VA = "0x184F5A8E0")]
	public static string ENMPICCIKNP<T>(T CJMMBFLIBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4F5A960", Offset = "0x4F59160", VA = "0x184F5A960")]
	public static string ENMPICCIKNP<T>(T CJMMBFLIBMO, KMJPBNOKBLE DPKMGFEILJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1C34800", Offset = "0x1C33000", VA = "0x181C34800")]
	public static T JDKEMADGCJE<T>(string OAHCLBJCMLP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C34A50", Offset = "0x1C33250", VA = "0x181C34A50")]
	public static T JDKEMADGCJE<T>(string OAHCLBJCMLP, KMJPBNOKBLE DPKMGFEILJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1C349D0", Offset = "0x1C331D0", VA = "0x181C349D0")]
	public static T JDKEMADGCJE<T>(byte[] FCDIIMLAMIO, KMJPBNOKBLE DPKMGFEILJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1C34880", Offset = "0x1C33080", VA = "0x181C34880")]
	public static T JDKEMADGCJE<T>(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, KMJPBNOKBLE DPKMGFEILJN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KJKAIFPPMBP : byte
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
public struct FDFDFLKINMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] KLFHDELEGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] POKOCMHLPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int IBIPCEJMDGF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GFHIFFGAODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xAECF60", Offset = "0xAEB760", VA = "0x180AECF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D73850", Offset = "0x1D72050", VA = "0x181D73850")]
	public void JDNKNBAJIKK(int IBIPCEJMDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D74230", Offset = "0x1D72A30", VA = "0x181D74230")]
	public static byte[] ONEPJADAHJI(string EMMPAJPIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D73710", Offset = "0x1D71F10", VA = "0x181D73710")]
	public static byte[] FNIJBEGFBEO(string EMMPAJPIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D73E80", Offset = "0x1D72680", VA = "0x181D73E80")]
	public static byte[] MGJAGNCGLBI(string EMMPAJPIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D73210", Offset = "0x1D71A10", VA = "0x181D73210")]
	public static byte[] DFOAJFACMCL(string EMMPAJPIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D743C0", Offset = "0x1D72BC0", VA = "0x181D743C0")]
	public FDFDFLKINMJ(byte[] MJPHONHALML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D73160", Offset = "0x1D71960", VA = "0x181D73160")]
	public ArraySegment<byte> COBMIGELNEA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1D73690", Offset = "0x1D71E90", VA = "0x181D73690")]
	public byte[] FJBHPCHHMNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D74310", Offset = "0x1D72B10", VA = "0x181D74310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1D73840", Offset = "0x1D72040", VA = "0x181D73840")]
	public void IOHKIBCLCNA(int INFPKHAGHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1D73A50", Offset = "0x1D72250", VA = "0x181D73A50")]
	public void MCAKLKJOKOM(byte[] LONHGGNEBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1D73A10", Offset = "0x1D72210", VA = "0x181D73A10")]
	public void MAADICIGPJL(byte LONHGGNEBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1D73860", Offset = "0x1D72060", VA = "0x181D73860")]
	public void JFMODOIMIDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1D73640", Offset = "0x1D71E40", VA = "0x181D73640")]
	public void FAECINMFIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D74060", Offset = "0x1D72860", VA = "0x181D74060")]
	public void NBMCHPDGBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D73110", Offset = "0x1D71910", VA = "0x181D73110")]
	public void BMBLCJAOMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D74010", Offset = "0x1D72810", VA = "0x181D74010")]
	public void MPBMAPADKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D73960", Offset = "0x1D72160", VA = "0x181D73960")]
	public void KOPMBPAOKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D73FB0", Offset = "0x1D727B0", VA = "0x181D73FB0")]
	public void MNNKBJGKGDB(string EMMPAJPIILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D738E0", Offset = "0x1D720E0", VA = "0x181D738E0")]
	public void KJFGGLCLJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1D74130", Offset = "0x1D72930", VA = "0x181D74130")]
	public void NLCEHIMJKFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1D73420", Offset = "0x1D71C20", VA = "0x181D73420")]
	public void EFCPHFGEILC(bool CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1D73370", Offset = "0x1D71B70", VA = "0x181D73370")]
	public void EAEDNFHPBCF(float CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1D740B0", Offset = "0x1D728B0", VA = "0x181D740B0")]
	public void NDDMCDGKOHO(double CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1D73930", Offset = "0x1D72130", VA = "0x181D73930")]
	public void KMMDPHHDJBO(byte CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1D73610", Offset = "0x1D71E10", VA = "0x181D73610")]
	public void EOPANKCAJLA(ushort CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1D74200", Offset = "0x1D72A00", VA = "0x181D74200")]
	public void OMAOJNGEAFB(uint CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1D739E0", Offset = "0x1D721E0", VA = "0x181D739E0")]
	public void LMGKHDLFBEE(ulong CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1D739B0", Offset = "0x1D721B0", VA = "0x181D739B0")]
	public void LJNEOBDDCGL(sbyte CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1D733F0", Offset = "0x1D71BF0", VA = "0x181D733F0")]
	public void EEBCBNCGNLH(short CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1D738B0", Offset = "0x1D720B0", VA = "0x181D738B0")]
	public void KGHGEMGEJPI(int CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1D730E0", Offset = "0x1D718E0", VA = "0x181D730E0")]
	public void AHNBBEAHIFJ(long CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1D73AB0", Offset = "0x1D722B0", VA = "0x181D73AB0")]
	public void MDAJMKNACGL(string CJMMBFLIBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HENHMDHNFHH : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class BAOGCLJAKFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5551080", Offset = "0x554F880", VA = "0x185551080")]
		static BAOGCLJAKFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private HENHMDHNFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class INNGNKDDEOO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> EACIGABFBHK;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2387580", Offset = "0x2385D80", VA = "0x182387580")]
	static INNGNKDDEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2387020", Offset = "0x2385820", VA = "0x182387020")]
	internal static object PMDCCPHLOJJ(Type JFBIOCFAFEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NNNMAMHIBFM : global::EBPKMMEFPKF<Vector2>, GLLCIPEHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NBBPAMBALEM BLKOJJEACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] LJGPACNNLMO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x366A600", Offset = "0x3668E00", VA = "0x18366A600")]
	public NNNMAMHIBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x366A360", Offset = "0x3668B60", VA = "0x18366A360", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Vector2 CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x366A410", Offset = "0x3668C10", VA = "0x18366A410", Slot = "5")]
	public Vector2 JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GIJODKKFJBN : global::EBPKMMEFPKF<Vector3>, GLLCIPEHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NBBPAMBALEM BLKOJJEACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] LJGPACNNLMO;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x237C370", Offset = "0x237AB70", VA = "0x18237C370")]
	public GIJODKKFJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x237BF50", Offset = "0x237A750", VA = "0x18237BF50", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Vector3 CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x237C070", Offset = "0x237A870", VA = "0x18237C070", Slot = "5")]
	public Vector3 JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IGMHOMJMIHE : global::EBPKMMEFPKF<Vector4>, GLLCIPEHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NBBPAMBALEM BLKOJJEACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] LJGPACNNLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x23867E0", Offset = "0x2384FE0", VA = "0x1823867E0")]
	public IGMHOMJMIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2386350", Offset = "0x2384B50", VA = "0x182386350", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Vector4 CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x23864A0", Offset = "0x2384CA0", VA = "0x1823864A0", Slot = "5")]
	public Vector4 JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JIFGAMIPFPP : global::EBPKMMEFPKF<Quaternion>, GLLCIPEHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NBBPAMBALEM BLKOJJEACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] LJGPACNNLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x238A000", Offset = "0x2388800", VA = "0x18238A000")]
	public JIFGAMIPFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2386350", Offset = "0x2384B50", VA = "0x182386350", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Quaternion CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2389CC0", Offset = "0x23884C0", VA = "0x182389CC0", Slot = "5")]
	public Quaternion JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KOOIHKIKMKA : global::EBPKMMEFPKF<Color>, GLLCIPEHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NBBPAMBALEM BLKOJJEACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] LJGPACNNLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x238C890", Offset = "0x238B090", VA = "0x18238C890")]
	public KOOIHKIKMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2386350", Offset = "0x2384B50", VA = "0x182386350", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Color CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x238C550", Offset = "0x238AD50", VA = "0x18238C550", Slot = "5")]
	public Color JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class CFOBADBDEGI : global::EBPKMMEFPKF<Bounds>, GLLCIPEHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NBBPAMBALEM BLKOJJEACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] LJGPACNNLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1D66580", Offset = "0x1D64D80", VA = "0x181D66580")]
	public CFOBADBDEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D65FE0", Offset = "0x1D647E0", VA = "0x181D65FE0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Bounds CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1D662E0", Offset = "0x1D64AE0", VA = "0x181D662E0", Slot = "5")]
	public Bounds JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class LBEEJBAFIID : global::EBPKMMEFPKF<Rect>, GLLCIPEHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NBBPAMBALEM BLKOJJEACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] LJGPACNNLMO;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x238D060", Offset = "0x238B860", VA = "0x18238D060")]
	public LBEEJBAFIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x238CB80", Offset = "0x238B380", VA = "0x18238CB80", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Rect CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x238CCF0", Offset = "0x238B4F0", VA = "0x18238CCF0", Slot = "5")]
	public Rect JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class KLEDFALAKAL : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class GCGLIMAIKEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x56C92D0", Offset = "0x56C7AD0", VA = "0x1856C92D0")]
		static GCGLIMAIKEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private KLEDFALAKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class JHAIMIANFGF : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class GLIEPHJBKOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x536E4C0", Offset = "0x536CCC0", VA = "0x18536E4C0")]
		static GLIEPHJBKOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class NGAFANNKLDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> GNPJKLJHOLP;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x238D8C0", Offset = "0x238C0C0", VA = "0x18238D8C0")]
		internal static object PMDCCPHLOJJ(Type JFBIOCFAFEC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private JHAIMIANFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class HNMINMNOPAK : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class ODPINPHPMPJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5699470", Offset = "0x5697C70", VA = "0x185699470")]
		static ODPINPHPMPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly HNMINMNOPAK AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool JFPCJFJHEDJ;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static GLLCIPEHDNF[] MMDNNHIGDIE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static KMJPBNOKBLE[] HPCMFADDLFM;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private HNMINMNOPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2385470", Offset = "0x2383C70", VA = "0x182385470")]
	public static void DAFBLBFDDID(params KMJPBNOKBLE[] HPCMFADDLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x23853B0", Offset = "0x2383BB0", VA = "0x1823853B0")]
	public static void DAFBLBFDDID(params GLLCIPEHDNF[] MMDNNHIGDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2385530", Offset = "0x2383D30", VA = "0x182385530")]
	public static void IHBOHJDEFDA(GLLCIPEHDNF[] MMDNNHIGDIE, KMJPBNOKBLE[] HPCMFADDLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class AJCFNFPEBDC : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class KCCCEMHDPGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x540AEF0", Offset = "0x54096F0", VA = "0x18540AEF0")]
		static KCCCEMHDPGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private AJCFNFPEBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DKIBFBBLIBN
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly KMJPBNOKBLE JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly KMJPBNOKBLE MPCKCCIMCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly KMJPBNOKBLE NCLGDDIHPMB;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly KMJPBNOKBLE DABAGDACODD;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly KMJPBNOKBLE DIBNONENCHM;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly KMJPBNOKBLE BGNLAHMCCHC;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly KMJPBNOKBLE DGLGNOGKGPD;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly KMJPBNOKBLE NMLLPMPKEHB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly KMJPBNOKBLE OJDOHEHPMFN;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly KMJPBNOKBLE AODEHLEDLCC;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly KMJPBNOKBLE DAEOGGNIJLA;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KMJPBNOKBLE BEOPLCEJGKM;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MDHCCILBLAP
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly KMJPBNOKBLE JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly KMJPBNOKBLE MKEDLMKEPAD;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class GIMOEDPBBNG
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly KMJPBNOKBLE JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly KMJPBNOKBLE MPCKCCIMCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly KMJPBNOKBLE NCLGDDIHPMB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly KMJPBNOKBLE DABAGDACODD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly KMJPBNOKBLE DIBNONENCHM;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly KMJPBNOKBLE BGNLAHMCCHC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly KMJPBNOKBLE DGLGNOGKGPD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly KMJPBNOKBLE NMLLPMPKEHB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly KMJPBNOKBLE OJDOHEHPMFN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly KMJPBNOKBLE AODEHLEDLCC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly KMJPBNOKBLE DAEOGGNIJLA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly KMJPBNOKBLE BEOPLCEJGKM;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class JFPGGGHFPOG
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> GNPJKLJHOLP;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x23882C0", Offset = "0x2386AC0", VA = "0x1823882C0")]
	internal static object PMDCCPHLOJJ(Type JFBIOCFAFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2388280", Offset = "0x2386A80", VA = "0x182388280")]
	private static object BIBDABOPDGI(Type OELHBMEGOEO, Type[] FODCGIDFLJE, params object[] PHLFHLMOLBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class OALOCCNDONP : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class BGOBDFOJGJP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x57A8AC0", Offset = "0x57A72C0", VA = "0x1857A8AC0")]
		static BGOBDFOJGJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly LHDBLIFOCEI HMFMDEEBMHJ;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x366A9D0", Offset = "0x36691D0", VA = "0x18366A9D0")]
	static OALOCCNDONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private OALOCCNDONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class DIJOCBMBNAH : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class AEOHNJMANKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x52CC8E0", Offset = "0x52CB0E0", VA = "0x1852CC8E0")]
		static AEOHNJMANKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly LHDBLIFOCEI HMFMDEEBMHJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1D67D00", Offset = "0x1D66500", VA = "0x181D67D00")]
	static DIJOCBMBNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private DIJOCBMBNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class MGMONJPLDEF : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class IIPADDELDLD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x543FF60", Offset = "0x543E760", VA = "0x18543FF60")]
		static IIPADDELDLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly LHDBLIFOCEI HMFMDEEBMHJ;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3667690", Offset = "0x3665E90", VA = "0x183667690")]
	static MGMONJPLDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private MGMONJPLDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class OAPOHJNHKCH : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class HLKDPPGNCNC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x55003F0", Offset = "0x54FEBF0", VA = "0x1855003F0")]
		static HLKDPPGNCNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly LHDBLIFOCEI HMFMDEEBMHJ;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x366AAC0", Offset = "0x36692C0", VA = "0x18366AAC0")]
	static OAPOHJNHKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private OAPOHJNHKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class ILNFFLJDCGI : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class DKCFHHBKNMG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x50F5D00", Offset = "0x50F4500", VA = "0x1850F5D00")]
		static DKCFHHBKNMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly LHDBLIFOCEI HMFMDEEBMHJ;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2386D70", Offset = "0x2385570", VA = "0x182386D70")]
	static ILNFFLJDCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private ILNFFLJDCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class KGBDKACPDPN : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class LLBOCIMLDHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x55EC2A0", Offset = "0x55EAAA0", VA = "0x1855EC2A0")]
		static LLBOCIMLDHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly LHDBLIFOCEI HMFMDEEBMHJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x238BE20", Offset = "0x238A620", VA = "0x18238BE20")]
	static KGBDKACPDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private KGBDKACPDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class LDMEEGGCGIA : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class GPIILHHKLDG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5576460", Offset = "0x5574C60", VA = "0x185576460")]
		static GPIILHHKLDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LDMEEGGCGIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class CEDGBFLBOEF : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class BMHKBGHAPAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x56118E0", Offset = "0x56100E0", VA = "0x1856118E0")]
		static BMHKBGHAPAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CEDGBFLBOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DDONEFPMKJP : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class FIPBCOCCMOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x52DE060", Offset = "0x52DC860", VA = "0x1852DE060")]
		static FIPBCOCCMOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public DDONEFPMKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class IJNOLCJPJCL : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class NKAJHPFAPJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x54B0690", Offset = "0x54AEE90", VA = "0x1854B0690")]
		static NKAJHPFAPJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IJNOLCJPJCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class ILEFCHABJFD : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class PBDGGMNFPLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x54BAC00", Offset = "0x54B9400", VA = "0x1854BAC00")]
		static PBDGGMNFPLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public ILEFCHABJFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class OGDIPNEMFDD : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class HKMAFNGMHMH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x54FB510", Offset = "0x54F9D10", VA = "0x1854FB510")]
		static HKMAFNGMHMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> AGLABOEJILP;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool KAKHEMGHOKC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public OGDIPNEMFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class EMMLILJNOLM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct CPMKHIIAIIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public EPJDHMIMGDB PELDAHDOKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder HLCELOLGNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder OANEAJLAIOA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class GCLHOLEFBKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class KHGPCGIPKFA
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo MGJAGNCGLBI;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo FNIJBEGFBEO;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo DFOAJFACMCL;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo ONEPJADAHJI;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo NLCEHIMJKFM;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo MCAKLKJOKOM;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo NBMCHPDGBAN;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo BMBLCJAOMJD;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo MPBMAPADKCP;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1D768C0", Offset = "0x1D750C0", VA = "0x181D768C0")]
			static KHGPCGIPKFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class ACFHFIFOIAB
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo NHKAFEFKHLJ;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo GKIHHCILIGK;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo JBEMJODAEOI;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo MEKJCADJEDK;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo GDICKJJIEJG;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo CCDAIHBHDAJ;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo EEGOIENMJHI;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x1D5F2F0", Offset = "0x1D5DAF0", VA = "0x181D5F2F0")]
			static ACFHFIFOIAB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class AKPKGBJKLFL
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo DAADMNDNNAG;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo MAEFELADPJP;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo AGKOPHOPLPM;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo CBINBJBJHOF;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo ADLFOIJLCEG;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo KADIIDLBKOA;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo KEFMDEIANHI;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo KHLDPMBIJFJ;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo BFFMGKJJBJD;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo BBOIIBHICKI;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo PPNONGLDJAF;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo LJNKMJPBOLB;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo FKLMHBNPBOD;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo CNCJFMONBNB;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1D743E0", Offset = "0x1D72BE0", VA = "0x181D743E0")]
		public static MethodInfo BAGHAKDDGPK(Type BKDBLJPNPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1D74790", Offset = "0x1D72F90", VA = "0x181D74790")]
		public static MethodInfo JDKEMADGCJE(Type BKDBLJPNPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1D74670", Offset = "0x1D72E70", VA = "0x181D74670")]
		public static MethodInfo EOJECFCNLLH(Type BKDBLJPNPPJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class LBDPPGIICAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<EPJDHMIMGDB, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public LBDPPGIICAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CNADFBGNKJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public LBDPPGIICAG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public CNADFBGNKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1D67090", Offset = "0x1D65890", VA = "0x181D67090")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1D670D0", Offset = "0x1D658D0", VA = "0x181D670D0")]
		internal bool <BuildType>b__2(int index, EPJDHMIMGDB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class IEAGPFOGDJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public LBDPPGIICAG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IEAGPFOGDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1D763B0", Offset = "0x1D74BB0", VA = "0x181D763B0")]
		internal bool <BuildType>b__3(int index, EPJDHMIMGDB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class IHPJNNLJNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IHPJNNLJNEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1D76450", Offset = "0x1D74C50", VA = "0x181D76450")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IOJINKFANCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IOJINKFANCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1D765E0", Offset = "0x1D74DE0", VA = "0x181D765E0")]
		internal bool <BuildAnonymousFormatter>b__2(EPJDHMIMGDB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class HLCAODONADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IHPJNNLJNEF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HLCAODONADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1D76130", Offset = "0x1D74930", VA = "0x181D76130")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1D761B0", Offset = "0x1D749B0", VA = "0x181D761B0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, EPJDHMIMGDB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OOLDGDKDEMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public IHPJNNLJNEF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public OOLDGDKDEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1D77C80", Offset = "0x1D76480", VA = "0x181D77C80")]
		internal bool <BuildAnonymousFormatter>b__7(int index, EPJDHMIMGDB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class KCAAKFGFEHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KCAAKFGFEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB2EA10", Offset = "0xB2D210", VA = "0x180B2EA10")]
		internal Label <BuildSerialize>b__1(EPJDHMIMGDB _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IJKNFPMJLKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CPMKHIIAIIO[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, EPJDHMIMGDB, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public CBIFEOJLFLK argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CBIFEOJLFLK argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IJKNFPMJLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1D764B0", Offset = "0x1D74CB0", VA = "0x181D764B0")]
		internal CPMKHIIAIIO <BuildDeserialize>b__0(EPJDHMIMGDB item)
		{
			return default(CPMKHIIAIIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class NGFEDHKFGBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IJKNFPMJLKP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NGFEDHKFGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1D77780", Offset = "0x1D75F80", VA = "0x181D77780")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1D77A60", Offset = "0x1D76260", VA = "0x181D77A60")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class HDCNLBCBAII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public EPJDHMIMGDB item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HDCNLBCBAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1D75E10", Offset = "0x1D74610", VA = "0x181D75E10")]
		internal bool <EmitNewObject>b__0(CPMKHIIAIIO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class GLCMJCIKLBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public EPJDHMIMGDB item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public GLCMJCIKLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1D75E10", Offset = "0x1D74610", VA = "0x181D75E10")]
		internal bool <EmitNewObject>b__2(CPMKHIIAIIO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex JPDKMOGBKAM;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int NBMPMMDJJGI;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> NPGLGMIDKEP;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> KAJDOBDHABC;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1AB4380", Offset = "0x1AB2B80", VA = "0x181AB4380")]
	public static object EIGBDFMCCMG<T>(LHDBLIFOCEI HMFMDEEBMHJ, KMJPBNOKBLE JCHAICEPCFI, Func<string, string> AGLABOEJILP, bool KAKHEMGHOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1ABE410", Offset = "0x1ABCC10", VA = "0x181ABE410")]
	public static object EOKJLJMAOHN<T>(KMJPBNOKBLE JCHAICEPCFI, Func<string, string> AGLABOEJILP, bool KAKHEMGHOKC, bool KDJIKCIFPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1D6CDC0", Offset = "0x1D6B5C0", VA = "0x181D6CDC0")]
	private static TypeInfo KIILCEBNBEI(LHDBLIFOCEI HMFMDEEBMHJ, Type BKDBLJPNPPJ, Func<string, string> AGLABOEJILP, bool KAKHEMGHOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1D69810", Offset = "0x1D68010", VA = "0x181D69810")]
	public static object DOPHPPKHKGN(Type BKDBLJPNPPJ, Func<string, string> AGLABOEJILP, bool KAKHEMGHOKC, bool KDJIKCIFPGD, bool AGANJGMIDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1D703D0", Offset = "0x1D6EBD0", VA = "0x181D703D0")]
	private static Dictionary<EPJDHMIMGDB, FieldInfo> MKLOBLNKMKC(TypeBuilder BJLKOAJDOAH, FCDKELICFKM FPMMADBNIOC, ConstructorInfo HGELFNKJAAI, FieldBuilder EILHIPCCHDG, ILGenerator DOMNOIMHJOO, bool KAKHEMGHOKC, bool NJKJCJAMOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1D69240", Offset = "0x1D67A40", VA = "0x181D69240")]
	private static Dictionary<EPJDHMIMGDB, FieldInfo> CPIEAACMPMM(TypeBuilder BJLKOAJDOAH, FCDKELICFKM FPMMADBNIOC, ILGenerator DOMNOIMHJOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B2F0", Offset = "0x1D69AF0", VA = "0x181D6B2F0")]
	private static void FNJKEHOEMDH(Type BKDBLJPNPPJ, FCDKELICFKM FPMMADBNIOC, ILGenerator DOMNOIMHJOO, Action AFFOFKKPCAC, Func<int, EPJDHMIMGDB, bool> EEIEHIDJIPJ, bool KAKHEMGHOKC, bool NJKJCJAMOKN, int BNBPJFIABDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C8D0", Offset = "0x1D6B0D0", VA = "0x181D6C8D0")]
	private static void IHAACDMOPNE(TypeInfo BKDBLJPNPPJ, EPJDHMIMGDB CMMNNJBFAHO, ILGenerator DOMNOIMHJOO, int AKLHCIJHJKB, Func<int, EPJDHMIMGDB, bool> EEIEHIDJIPJ, CBIFEOJLFLK HELLEMCMMHJ, CBIFEOJLFLK PKCAAKGPIPK, CBIFEOJLFLK HOHGKBDBINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1D6EC10", Offset = "0x1D6D410", VA = "0x181D6EC10")]
	private static void LLBMNBOPMLC(Type BKDBLJPNPPJ, FCDKELICFKM FPMMADBNIOC, ILGenerator DOMNOIMHJOO, Func<int, EPJDHMIMGDB, bool> EEIEHIDJIPJ, bool FKIGMHMOGNF, int BNBPJFIABDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1D6FFB0", Offset = "0x1D6E7B0", VA = "0x181D6FFB0")]
	private static void LPECEPJFHKO(ILGenerator DOMNOIMHJOO, CPMKHIIAIIO FPMMADBNIOC, int AKLHCIJHJKB, Func<int, EPJDHMIMGDB, bool> EEIEHIDJIPJ, CBIFEOJLFLK AMCNLEFBMOK, CBIFEOJLFLK HOHGKBDBINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1D6DF30", Offset = "0x1D6C730", VA = "0x181D6DF30")]
	private static LocalBuilder LCNCHEELCAG(ILGenerator DOMNOIMHJOO, Type BKDBLJPNPPJ, FCDKELICFKM FPMMADBNIOC, CPMKHIIAIIO[] ABKJFGJEICM, bool BIHEDHJAOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D860", Offset = "0x1D6C060", VA = "0x181D6D860")]
	private static bool KMIBFMDEJON(ConstructorInfo PBMKFKDNAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B150", Offset = "0x1D69950", VA = "0x181D6B150")]
	private static bool EIIFINMMBPI(Type BKDBLJPNPPJ, out Type HOEGGKLCIDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void MBOJBCJODNL<T>(byte[][] EILHIPCCHDG, object[] PHLKAHEIFNL, ref FDFDFLKINMJ HELLEMCMMHJ, T CJMMBFLIBMO, KMJPBNOKBLE DPKMGFEILJN);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T OLDOFBPGBHB<T>(object[] PHLKAHEIFNL, ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE DPKMGFEILJN);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class BJKDAJOHAIE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class POBEGNHCGKK : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class NALFEJIHCCL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x57A0370", Offset = "0x579EB70", VA = "0x1857A0370")]
		static NALFEJIHCCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private POBEGNHCGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class LFMMLAAOADO : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class ILFKHFDEEPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5578D00", Offset = "0x5577500", VA = "0x185578D00")]
		static ILFKHFDEEPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private LFMMLAAOADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class GAJOMLFLKGH
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly KMJPBNOKBLE[] EEODCGKNKCF;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class JFCGFIJOBJK : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class ECBDGNBNCNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x50F7E70", Offset = "0x50F6670", VA = "0x1850F7E70")]
		static ECBDGNBNCNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class OAPJJMACAKG : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class JPLGJFMAHFO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x5108E00", Offset = "0x5107600", VA = "0x185108E00")]
			static JPLGJFMAHFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private OAPJJMACAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private JFCGFIJOBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class NLIBIDINDGF : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class DFDIMDHKPDK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x54C14B0", Offset = "0x54BFCB0", VA = "0x1854C14B0")]
		static DFDIMDHKPDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class MAKOPFPCAFD : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class ADJIBIGKDFO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x54BF220", Offset = "0x54BDA20", VA = "0x1854BF220")]
			static ADJIBIGKDFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private MAKOPFPCAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private NLIBIDINDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class COGMLNELOMC : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class IFHOIAOGONL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5651F20", Offset = "0x5650720", VA = "0x185651F20")]
		static IFHOIAOGONL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class EOAJHPJOBPB : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class IKNGMKFEACC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x55AABF0", Offset = "0x55A93F0", VA = "0x1855AABF0")]
			static IKNGMKFEACC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private EOAJHPJOBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private COGMLNELOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class FCNJIHFFFMB : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class CBKAFMBFKMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x56310E0", Offset = "0x562F8E0", VA = "0x1856310E0")]
		static CBKAFMBFKMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class LCNOPMNCMGG : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class LADELOBABBA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x545F310", Offset = "0x545DB10", VA = "0x18545F310")]
			static LADELOBABBA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private LCNOPMNCMGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private FCNJIHFFFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class FDADHAPOAHP : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class AOJCPMADNNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x54469B0", Offset = "0x54451B0", VA = "0x1854469B0")]
		static AOJCPMADNNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class HKMDMIKBDMA : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class FKPFBJIHHOG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x545CD90", Offset = "0x545B590", VA = "0x18545CD90")]
			static FKPFBJIHHOG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private HKMDMIKBDMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private FDADHAPOAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class IJLFGJDNNDD : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class OPCHKPMEHJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x54B44F0", Offset = "0x54B2CF0", VA = "0x1854B44F0")]
		static OPCHKPMEHJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class LPHEEEBDCBH : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class KJCJHFHFFIO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x54AE900", Offset = "0x54AD100", VA = "0x1854AE900")]
			static KJCJHFHFFIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private LPHEEEBDCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private IJLFGJDNNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class OOAIADODBON : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class MAMHEGDNDKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x58588A0", Offset = "0x58570A0", VA = "0x1858588A0")]
		static MAMHEGDNDKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class PNCLKDLGPMB : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class DFAMKOICGOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5850010", Offset = "0x584E810", VA = "0x185850010")]
			static DFAMKOICGOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private PNCLKDLGPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private OOAIADODBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class HCAJKFDOHOE : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class MLGCJFFLFBC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x56AE820", Offset = "0x56AD020", VA = "0x1856AE820")]
		static MLGCJFFLFBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class AAAAKKIMLOK : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class BALLNKDGHMA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x57FF2C0", Offset = "0x57FDAC0", VA = "0x1857FF2C0")]
			static BALLNKDGHMA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private AAAAKKIMLOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private HCAJKFDOHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class NCKEAMPEJEN : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class ALHJIFCIPGO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x576D160", Offset = "0x576B960", VA = "0x18576D160")]
		static ALHJIFCIPGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class CCPELNJOGMF : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class EDLBJIJEOJH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5772490", Offset = "0x5770C90", VA = "0x185772490")]
			static EDLBJIJEOJH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private CCPELNJOGMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private NCKEAMPEJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class FBDOJNEGMKN : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class NBMKGBNKGDI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x563F040", Offset = "0x563D840", VA = "0x18563F040")]
		static NBMKGBNKGDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class HDEJANEKHFD : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class OGANBMJDPEM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x56458C0", Offset = "0x56440C0", VA = "0x1856458C0")]
			static OGANBMJDPEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private HDEJANEKHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private FBDOJNEGMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class FBNLPLKAENN : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class KKADOPLHPEO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x563C7E0", Offset = "0x563AFE0", VA = "0x18563C7E0")]
		static KKADOPLHPEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class OIOLAAFIPGJ : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class OPNGHMAANBC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5648C70", Offset = "0x5647470", VA = "0x185648C70")]
			static OPNGHMAANBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private OIOLAAFIPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private FBNLPLKAENN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class EPGNKDDJGMH : KMJPBNOKBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class IKCDIPDCCCF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5682DE0", Offset = "0x56815E0", VA = "0x185682DE0")]
		static IKCDIPDCCCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class JBFCMIHNNDF : KMJPBNOKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class HIAPMBKNIJI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::EBPKMMEFPKF<T> MDMOPDAODGE;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x567D2B0", Offset = "0x567BAB0", VA = "0x18567D2B0")]
			static HIAPMBKNIJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly KMJPBNOKBLE AAMGPJBHPCK;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly KMJPBNOKBLE[] HPCMFADDLFM;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		private JBFCMIHNNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
		public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly KMJPBNOKBLE AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::EBPKMMEFPKF<object> FHKIECBLGDA;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	private EPGNKDDJGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE80", Offset = "0x13CB680", VA = "0x1813CCE80", Slot = "4")]
	public global::EBPKMMEFPKF<T> PMDCCPHLOJJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct KMIIFDBIHOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] JCBOBPDDPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int JKPGEJFPGLG;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x56D7000", Offset = "0x56D5800", VA = "0x1856D7000")]
	public KMIIFDBIHOK(int MAADOFIJONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x56D6E60", Offset = "0x56D5660", VA = "0x1856D6E60")]
	public void NLKJJINIDJF(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x56D6C20", Offset = "0x56D5420", VA = "0x1856D6C20")]
	public T[] JKBLAANMFMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class HOLAOEFOEND : global::KMNBIGGENNG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly HOLAOEFOEND JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x23858C0", Offset = "0x23840C0", VA = "0x1823858C0")]
	public HOLAOEFOEND(int EJLNKHIJKJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class KMNBIGGENNG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int EJLNKHIJKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object KFFLCPKMNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int AKLHCIJHJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] CAEPPMNFANN;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x56D9300", Offset = "0x56D7B00", VA = "0x1856D9300")]
	public KMNBIGGENNG(int EJLNKHIJKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x56D7E00", Offset = "0x56D6600", VA = "0x1856D7E00")]
	public T[] MNABCOFHPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x56D7800", Offset = "0x56D6000", VA = "0x1856D7800")]
	public void KMMHDPALFML(T[] FPMNAPBFAMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class NBBPAMBALEM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class KGNPLCNHCCF : IComparable<KGNPLCNHCCF>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class AGMIGPGDECC : IEnumerable<KGNPLCNHCCF>, IEnumerable, IEnumerator<KGNPLCNHCCF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private KGNPLCNHCCF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public KGNPLCNHCCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private KGNPLCNHCCF System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
			[DebuggerHidden]
			public AGMIGPGDECC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3661BA0", Offset = "0x36603A0", VA = "0x183661BA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x3661CD0", Offset = "0x36604D0", VA = "0x183661CD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x3661C30", Offset = "0x3660430", VA = "0x183661C30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KGNPLCNHCCF> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x3661C30", Offset = "0x3660430", VA = "0x183661C30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class OANHAMKCMIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public OANHAMKCMIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xB2EA10", Offset = "0xB2D210", VA = "0x180B2EA10")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB2EA10", Offset = "0xB2D210", VA = "0x180B2EA10")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly KGNPLCNHCCF[] COKEMILNHJL;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] NCOFAKIJADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong HMKHOIFGHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int EJFMLMNCFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string CPALLOOENKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private KGNPLCNHCCF[] PLNKKBHNNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] FBMCJPHCGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int FKDPJOHPNNG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EIBFCDPOKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2C97D10", Offset = "0x2C96510", VA = "0x182C97D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x36643E0", Offset = "0x3662BE0", VA = "0x1836643E0")]
		public KGNPLCNHCCF(ulong BAGMDNPKAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3663FC0", Offset = "0x36627C0", VA = "0x183663FC0")]
		public KGNPLCNHCCF NLKJJINIDJF(ulong BAGMDNPKAJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3663F70", Offset = "0x3662770", VA = "0x183663F70")]
		public KGNPLCNHCCF NLKJJINIDJF(ulong BAGMDNPKAJL, int CJMMBFLIBMO, string CPALLOOENKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x36641B0", Offset = "0x36629B0", VA = "0x1836641B0")]
		public KGNPLCNHCCF PCBNGMJAAII(byte[] CKNEEGNOOIB, ref int IBIPCEJMDGF, ref int PELCDPEPAED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3663140", Offset = "0x3661940", VA = "0x183663140")]
		internal static int CDCJFDCGCBK(ulong[] FPMNAPBFAMJ, int AKLHCIJHJKB, int ABGIPDMABIG, ulong CJMMBFLIBMO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x36631C0", Offset = "0x36619C0", VA = "0x1836631C0", Slot = "4")]
		public int CompareTo(KGNPLCNHCCF ALBOAABJIJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3663F00", Offset = "0x3662700", VA = "0x183663F00")]
		[IteratorStateMachine(typeof(AGMIGPGDECC))]
		public IEnumerable<KGNPLCNHCCF> MFPOHNFABCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x36631F0", Offset = "0x36619F0", VA = "0x1836631F0")]
		public void FBOKLLHHFIK(ILGenerator DOMNOIMHJOO, LocalBuilder CKNEEGNOOIB, LocalBuilder PELCDPEPAED, LocalBuilder BAGMDNPKAJL, Action<KeyValuePair<string, int>> NOAAJBBLMGF, Action PEFGAPLIFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3663320", Offset = "0x3661B20", VA = "0x183663320")]
		private static void GMOIPJNDJBG(ILGenerator DOMNOIMHJOO, LocalBuilder CKNEEGNOOIB, LocalBuilder PELCDPEPAED, LocalBuilder BAGMDNPKAJL, Action<KeyValuePair<string, int>> NOAAJBBLMGF, Action PEFGAPLIFCL, KGNPLCNHCCF[] PLNKKBHNNGE, int FKDPJOHPNNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class JHHPJBHGLKD : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private IEnumerable<KGNPLCNHCCF> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<KGNPLCNHCCF> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<KGNPLCNHCCF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KGNPLCNHCCF <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3662F50", Offset = "0x3661750", VA = "0x183662F50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xE4C760", Offset = "0xE4AF60", VA = "0x180E4C760")]
		[DebuggerHidden]
		public JHHPJBHGLKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3662FA0", Offset = "0x36617A0", VA = "0x183662FA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3662AE0", Offset = "0x36612E0", VA = "0x183662AE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x36630A0", Offset = "0x36618A0", VA = "0x1836630A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x36630F0", Offset = "0x36618F0", VA = "0x1836630F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3662F00", Offset = "0x3661700", VA = "0x183662F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3662E60", Offset = "0x3661660", VA = "0x183662E60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3662E60", Offset = "0x3661660", VA = "0x183662E60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly KGNPLCNHCCF JLGIFIFDIOJ;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3669DE0", Offset = "0x36685E0", VA = "0x183669DE0")]
	public NBBPAMBALEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3669BE0", Offset = "0x36683E0", VA = "0x183669BE0")]
	public void NLKJJINIDJF(byte[] FCDIIMLAMIO, int CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3669B30", Offset = "0x3668330", VA = "0x183669B30")]
	public bool KFBAEBOEJIK(ArraySegment<byte> BAGMDNPKAJL, out int CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3669CF0", Offset = "0x36684F0", VA = "0x183669CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3669710", Offset = "0x3667F10", VA = "0x183669710")]
	private static void BGFLCPGLLEJ(IEnumerable<KGNPLCNHCCF> PLNKKBHNNGE, StringBuilder FPIABMPEEMH, int MFPEABLOEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3669A00", Offset = "0x3668200", VA = "0x183669A00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3669A00", Offset = "0x3668200", VA = "0x183669A00", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3669990", Offset = "0x3668190", VA = "0x183669990")]
	[IteratorStateMachine(typeof(JHHPJBHGLKD))]
	private static IEnumerable<KeyValuePair<string, int>> FOOHHLGLBLM(IEnumerable<KGNPLCNHCCF> PLNKKBHNNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3669B00", Offset = "0x3668300", VA = "0x183669B00")]
	public void JKNFLGGIHHG(ILGenerator DOMNOIMHJOO, LocalBuilder CKNEEGNOOIB, LocalBuilder PELCDPEPAED, LocalBuilder BAGMDNPKAJL, Action<KeyValuePair<string, int>> NOAAJBBLMGF, Action PEFGAPLIFCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class MMGFAGHEONG
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo DAIMJHKIEBM;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3668680", Offset = "0x3666E80", VA = "0x183668680")]
	public static ulong PPDMKGCFHPE(byte[] FCDIIMLAMIO, ref int IBIPCEJMDGF, ref int PELCDPEPAED)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class LBINHPHHKHB
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3664590", Offset = "0x3662D90", VA = "0x183664590")]
	public static void IOHKIBCLCNA(ref byte[] FCDIIMLAMIO, int IBIPCEJMDGF, int INFPKHAGHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x36644A0", Offset = "0x3662CA0", VA = "0x1836644A0")]
	public static void DBEAMLBGMOK(ref byte[] FPMNAPBFAMJ, int LPHOEMHGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x36646B0", Offset = "0x3662EB0", VA = "0x1836646B0")]
	public static byte[] KODAIDLMBKN(byte[] HOIDFJHLMNC, int LPHOEMHGGLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class JKMLKPJLBMI
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x238A590", Offset = "0x2388D90", VA = "0x18238A590")]
	public static bool OIFFJDEDINI(byte[] NBJGJCOCEHI, int FOCIDOFLPPJ, int MOENLHDBKNI, byte[] NBMKIFMOLEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class JIEHFPLPGOC<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct MJEABCMDIPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] HMKHOIFGHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T EJFMLMNCFJG;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x537ED30", Offset = "0x537D530", VA = "0x18537ED30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class FJELNIBGOCF : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::JIEHFPLPGOC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private MJEABCMDIPL[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private MJEABCMDIPL[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xECAF20", Offset = "0xEC9720", VA = "0x180ECAF20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x28192C0", Offset = "0x2817AC0", VA = "0x1828192C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xE31E30", Offset = "0xE30630", VA = "0x180E31E30")]
		[DebuggerHidden]
		public FJELNIBGOCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x536CD90", Offset = "0x536B590", VA = "0x18536CD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x536D500", Offset = "0x536BD00", VA = "0x18536D500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly MJEABCMDIPL[][] FGNFNHCKNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong KFPIJHAPAJN;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5376E90", Offset = "0x5375690", VA = "0x185376E90")]
	public JIEHFPLPGOC(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5376DD0", Offset = "0x53755D0", VA = "0x185376DD0")]
	public JIEHFPLPGOC(int JPMPKCEDKPJ, float ANLIJGHOBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5375A30", Offset = "0x5374230", VA = "0x185375A30")]
	public void NLKJJINIDJF(byte[] BAGMDNPKAJL, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5374500", Offset = "0x5372D00", VA = "0x185374500")]
	private bool LPDNHCJOPDC(byte[] BAGMDNPKAJL, T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5376330", Offset = "0x5374B30", VA = "0x185376330")]
	public bool PJOHNGKNBEM(ArraySegment<byte> BAGMDNPKAJL, out T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5372D40", Offset = "0x5371540", VA = "0x185372D40")]
	private static ulong ICPFGEMBKCD(byte[] FGCAOGJDCFC, int IBIPCEJMDGF, int FKDPJOHPNNG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F99640", Offset = "0x4F97E40", VA = "0x184F99640")]
	private static int KEFKGOLNHFM(int CKPNGKNDKII, float ANLIJGHOBBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5372C20", Offset = "0x5371420", VA = "0x185372C20", Slot = "4")]
	[IteratorStateMachine(typeof(global::JIEHFPLPGOC<>.FJELNIBGOCF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0xE30D10", Offset = "0xE2F510", VA = "0x180E30D10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class IOEOIJDFOKF : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] LHOHKDIBKGP;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] GMCCAHHHIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int BLMHGMEGNGC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool FPJGGJGHCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2387940", Offset = "0x2386140", VA = "0x182387940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2387AA0", Offset = "0x23862A0", VA = "0x182387AA0")]
	static IOEOIJDFOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2387CF0", Offset = "0x23864F0", VA = "0x182387CF0")]
	public IOEOIJDFOKF(byte[] FAENLALBJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2387990", Offset = "0x2386190", VA = "0x182387990")]
	public OpCode ONNKEOEGDCO()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct HFACLFBLEIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid EJFMLMNCFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte OEHBHFKAECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte HKGNFJHAHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte GDNAMHHMBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte LIEOGOLPOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte HNEGEIBOFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte MNKHOLBIEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte MPGJLECMLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte DHGBKNCOPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte BHNHDJOFMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte MAIMNICIGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte OODBLFLFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte IILDLBLPCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte OLKJKAALPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte APFKBMEJAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte GOCNBGKFFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte JCALOMBGILD;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] PAFHLIJEFAL;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] MCJHOHIEAEF;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2381A30", Offset = "0x2380230", VA = "0x182381A30")]
	public HFACLFBLEIP(ref Guid CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2381A40", Offset = "0x2380240", VA = "0x182381A40")]
	public HFACLFBLEIP(ref ArraySegment<byte> FKHDCMPLLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x23818C0", Offset = "0x23800C0", VA = "0x1823818C0")]
	private static byte OGCCNENEBOD(byte[] FCDIIMLAMIO, int BBJAGDMIBOP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x23817B0", Offset = "0x237FFB0", VA = "0x1823817B0")]
	private static byte NJKOLIBCAKC(byte FLEBMPFFCAA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2380470", Offset = "0x237EC70", VA = "0x182380470")]
	public void HEIFACBBJFA(byte[] POKOCMHLPLN, int IBIPCEJMDGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class GGFLCNMOCCF
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x237AE80", Offset = "0x2379680", VA = "0x18237AE80")]
	public static bool HDLLIBHIDDH(byte AFHPHPIIHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x237ABC0", Offset = "0x23793C0", VA = "0x18237ABC0")]
	public static bool GLMDBGIMAIF(byte AFHPHPIIHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x237AA70", Offset = "0x2379270", VA = "0x18237AA70")]
	public static sbyte BGCKMCGIEJE(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x237AAE0", Offset = "0x23792E0", VA = "0x18237AAE0")]
	public static short BPJJEJAHBIF(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x237AB50", Offset = "0x2379350", VA = "0x18237AB50")]
	public static int EAAIMFPOALE(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x237B8D0", Offset = "0x237A0D0", VA = "0x18237B8D0")]
	public static long NBBMMPIFDGI(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x237B980", Offset = "0x237A180", VA = "0x18237B980")]
	public static byte OEODIDOILHE(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x237B090", Offset = "0x2379890", VA = "0x18237B090")]
	public static ushort KFAPBEALDII(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x237AFA0", Offset = "0x23797A0", VA = "0x18237AFA0")]
	public static uint JIDDPEKDBAH(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x237AE90", Offset = "0x2379690", VA = "0x18237AE90")]
	public static ulong IHDMMIAMHAG(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2379DC0", Offset = "0x23785C0", VA = "0x182379DC0")]
	public static float AEDCNNGGIGD(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x237B020", Offset = "0x2379820", VA = "0x18237B020")]
	public static double KEPMJCGHGKC(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x237B100", Offset = "0x2379900", VA = "0x18237B100")]
	public static int LMGKHDLFBEE(ref byte[] POKOCMHLPLN, int IBIPCEJMDGF, ulong CJMMBFLIBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2379E30", Offset = "0x2378630", VA = "0x182379E30")]
	public static int AHNBBEAHIFJ(ref byte[] POKOCMHLPLN, int IBIPCEJMDGF, long CJMMBFLIBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x237AC30", Offset = "0x2379430", VA = "0x18237AC30")]
	public static bool GPMJKGMEHOI(byte[] FCDIIMLAMIO, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class PLOBKADODKA
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class FAMIGGKKOMD : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
		[DebuggerHidden]
		public FAMIGGKKOMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3662920", Offset = "0x3661120", VA = "0x183662920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x36624C0", Offset = "0x3660CC0", VA = "0x1836624C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3662A40", Offset = "0x3661240", VA = "0x183662A40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3662A90", Offset = "0x3661290", VA = "0x183662A90")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x36628D0", Offset = "0x36610D0", VA = "0x1836628D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3662820", Offset = "0x3661020", VA = "0x183662820", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3662820", Offset = "0x3661020", VA = "0x183662820", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class CNEDOHIFJNB : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
		[DebuggerHidden]
		public CNEDOHIFJNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3662300", Offset = "0x3660B00", VA = "0x183662300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3661EA0", Offset = "0x36606A0", VA = "0x183661EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3662420", Offset = "0x3660C20", VA = "0x183662420")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3662470", Offset = "0x3660C70", VA = "0x183662470")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x36622B0", Offset = "0x3660AB0", VA = "0x1836622B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3662200", Offset = "0x3660A00", VA = "0x183662200", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3662200", Offset = "0x3660A00", VA = "0x183662200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x366F550", Offset = "0x366DD50", VA = "0x18366F550")]
	public static bool IDAOAMFOHFL(this TypeInfo BKDBLJPNPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x366F600", Offset = "0x366DE00", VA = "0x18366F600")]
	public static bool NOJDHMGEBEI(this TypeInfo BKDBLJPNPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x366F490", Offset = "0x366DC90", VA = "0x18366F490")]
	public static IEnumerable<PropertyInfo> EMFBJADHKMM(this Type BKDBLJPNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x366F400", Offset = "0x366DC00", VA = "0x18366F400")]
	[IteratorStateMachine(typeof(FAMIGGKKOMD))]
	private static IEnumerable<PropertyInfo> BBIAOGEKHPD(Type BKDBLJPNPPJ, HashSet<string> HBAIOEIOKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x366F4F0", Offset = "0x366DCF0", VA = "0x18366F4F0")]
	public static IEnumerable<FieldInfo> GCINELPKIJO(this Type BKDBLJPNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x366F370", Offset = "0x366DB70", VA = "0x18366F370")]
	[IteratorStateMachine(typeof(CNEDOHIFJNB))]
	private static IEnumerable<FieldInfo> ALEGIKDDDED(Type BKDBLJPNPPJ, HashSet<string> HBAIOEIOKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class LNHMJOCLJFN
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding EEKFIIDCPBD;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class MBBMDAMGFGP
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x86BBC0", Offset = "0x86A3C0", VA = "0x18086BBC0")]
	public static string OIJCLCGNKFJ(string IEEOBFIBOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3667080", Offset = "0x3665880", VA = "0x183667080")]
	public static string BJNEICDICFJ(string IEEOBFIBOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3667190", Offset = "0x3665990", VA = "0x183667190")]
	public static string MIKBJKLFGBH(string IEEOBFIBOGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class PJOGIOBAPNH<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class HIGOHCJNGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type HMKHOIFGHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue EJFMLMNCFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int HCHDGHPPNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public HIGOHCJNGKN BDDFGPIEACK;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4F92EF0", Offset = "0x4F916F0", VA = "0x184F92EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4F92E70", Offset = "0x4F91670", VA = "0x184F92E70")]
		private int KKHILPEBPDN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public HIGOHCJNGKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class FCHDJFFKHJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public FCHDJFFKHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC0", Offset = "0x6AA6C0", VA = "0x1806ABEC0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private HIGOHCJNGKN[] FGNFNHCKNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int OCAKIKBDFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object HGOHJBPCDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float ANLIJGHOBBF;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A7F0", Offset = "0x4F98FF0", VA = "0x184F9A7F0")]
	public PJOGIOBAPNH(int JPMPKCEDKPJ = 4, float ANLIJGHOBBF = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4F99530", Offset = "0x4F97D30", VA = "0x184F99530")]
	public bool JLDJGOPCJNK(Type BAGMDNPKAJL, TValue CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x4F994F0", Offset = "0x4F97CF0", VA = "0x184F994F0")]
	public bool JLDJGOPCJNK(Type BAGMDNPKAJL, Func<Type, TValue> LPMPIDHBCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A0D0", Offset = "0x4F988D0", VA = "0x184F9A0D0")]
	private bool LPDNHCJOPDC(Type BAGMDNPKAJL, Func<Type, TValue> LPMPIDHBCPH, out TValue AHDDNJHHOOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x4F99670", Offset = "0x4F97E70", VA = "0x184F99670")]
	private bool KJNEPBPKNPN(HIGOHCJNGKN[] FGNFNHCKNHJ, Type OABHHBLEEOG, HIGOHCJNGKN BEEIPALPGHG, Func<Type, TValue> LPMPIDHBCPH, out TValue AHDDNJHHOOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A6A0", Offset = "0x4F98EA0", VA = "0x184F9A6A0")]
	public bool PJOHNGKNBEM(Type BAGMDNPKAJL, out TValue CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A480", Offset = "0x4F98C80", VA = "0x184F9A480")]
	public TValue MNIGICDMADL(Type BAGMDNPKAJL, Func<Type, TValue> LPMPIDHBCPH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x4F99640", Offset = "0x4F97E40", VA = "0x184F99640")]
	private static int KEFKGOLNHFM(int CKPNGKNDKII, float ANLIJGHOBBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A520", Offset = "0x4F98D20", VA = "0x184F9A520")]
	private static void NFNCCKKCEEP(ref HIGOHCJNGKN KAJJJBBCCND, HIGOHCJNGKN CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A520", Offset = "0x4F98D20", VA = "0x184F9A520")]
	private static void NFNCCKKCEEP(ref HIGOHCJNGKN[] KAJJJBBCCND, HIGOHCJNGKN[] CJMMBFLIBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class LHDBLIFOCEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder PPBOKMOBJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder OIALDKFCBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object KFFLCPKMNCL;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x36668D0", Offset = "0x36650D0", VA = "0x1836668D0")]
	public TypeBuilder KCELPDEBKGE(string JNAACNJBHOF, TypeAttributes NFFBHBMHPBA, Type CELKNCFBAOE, Type[] PKIPKMJJOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x36669C0", Offset = "0x36651C0", VA = "0x1836669C0")]
	public LHDBLIFOCEI(string OOCHAHGACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class CLEBEIHJNJK
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1D66C80", Offset = "0x1D65480", VA = "0x181D66C80")]
	private static MethodInfo MAJELDCMAAG(LambdaExpression ELLGNDKAAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1AAC2E0", Offset = "0x1AAAAE0", VA = "0x181AAC2E0")]
	public static MethodInfo OMFMMLDOGGL<T>(Expression<Func<T>> ELLGNDKAAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1AAC2E0", Offset = "0x1AAAAE0", VA = "0x181AAC2E0")]
	public static MethodInfo OMFMMLDOGGL<T, TR>(Expression<Func<T, TR>> ELLGNDKAAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1AAC2E0", Offset = "0x1AAAAE0", VA = "0x181AAC2E0")]
	public static MethodInfo OMFMMLDOGGL<T>(Expression<Action<T>> ELLGNDKAAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1AAC2E0", Offset = "0x1AAAAE0", VA = "0x181AAC2E0")]
	public static MethodInfo OMFMMLDOGGL<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> ELLGNDKAAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1AAC240", Offset = "0x1AAAA40", VA = "0x181AAC240")]
	private static MemberInfo LEKNDDJOMGE<T>(Expression<T> MOLPKNIJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x1AAC2F0", Offset = "0x1AAAAF0", VA = "0x181AAC2F0")]
	public static PropertyInfo PFDNELKDNHG<T, TR>(Expression<Func<T, TR>> ELLGNDKAAGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct CBIFEOJLFLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int GDBELOJNNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool EEOECPODDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator DOMNOIMHJOO;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1D65B60", Offset = "0x1D64360", VA = "0x181D65B60")]
	public CBIFEOJLFLK(ILGenerator DOMNOIMHJOO, int GDBELOJNNFN, bool EEOECPODDHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x1D65BA0", Offset = "0x1D643A0", VA = "0x181D65BA0")]
	public CBIFEOJLFLK(ILGenerator DOMNOIMHJOO, int GDBELOJNNFN, Type BKDBLJPNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x1D65A50", Offset = "0x1D64250", VA = "0x181D65A50")]
	public void JFHIJJBGDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class AOHNBHLDHKB
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1D62720", Offset = "0x1D60F20", VA = "0x181D62720")]
	public static void ABHPJGIMDLK(this ILGenerator DOMNOIMHJOO, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1D626E0", Offset = "0x1D60EE0", VA = "0x181D626E0")]
	public static void ABHPJGIMDLK(this ILGenerator DOMNOIMHJOO, LocalBuilder FOBDBADKPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1D62D20", Offset = "0x1D61520", VA = "0x181D62D20")]
	public static void DFHGMGDBHOF(this ILGenerator DOMNOIMHJOO, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1D62CE0", Offset = "0x1D614E0", VA = "0x181D62CE0")]
	public static void DFHGMGDBHOF(this ILGenerator DOMNOIMHJOO, LocalBuilder FOBDBADKPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1D62AE0", Offset = "0x1D612E0", VA = "0x181D62AE0")]
	public static void BKLNBNAOEPA(this ILGenerator DOMNOIMHJOO, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1D62BD0", Offset = "0x1D613D0", VA = "0x181D62BD0")]
	public static void BKLNBNAOEPA(this ILGenerator DOMNOIMHJOO, LocalBuilder FOBDBADKPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1D62AD0", Offset = "0x1D612D0", VA = "0x181D62AD0")]
	public static void AODFEMBGIIK(this ILGenerator DOMNOIMHJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1D62FF0", Offset = "0x1D617F0", VA = "0x181D62FF0")]
	public static void HGGACCKBNLI(this ILGenerator DOMNOIMHJOO, bool CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1D63080", Offset = "0x1D61880", VA = "0x181D63080")]
	public static void IPMNDOFPJKE(this ILGenerator DOMNOIMHJOO, int CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1D63890", Offset = "0x1D62090", VA = "0x181D63890")]
	public static void MMFCLPBCNJJ(this ILGenerator DOMNOIMHJOO, Type BKDBLJPNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1D62F50", Offset = "0x1D61750", VA = "0x181D62F50")]
	public static void DIOPECNMJPN(this ILGenerator DOMNOIMHJOO, Type BKDBLJPNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1D63660", Offset = "0x1D61E60", VA = "0x181D63660")]
	public static void MGGMMLIIPOG(this ILGenerator DOMNOIMHJOO, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1D63000", Offset = "0x1D61800", VA = "0x181D63000")]
	public static void IDCMICICNHL(this ILGenerator DOMNOIMHJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1D629E0", Offset = "0x1D611E0", VA = "0x181D629E0")]
	public static void AMDKMDBGKLF(this ILGenerator DOMNOIMHJOO, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1D63560", Offset = "0x1D61D60", VA = "0x181D63560")]
	public static void LJKAJIHMBKP(this ILGenerator DOMNOIMHJOO, MethodInfo PDKOMFIINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1D634D0", Offset = "0x1D61CD0", VA = "0x181D634D0")]
	public static void JLJBLDJECBM(this ILGenerator DOMNOIMHJOO, FieldInfo EIHLAGIFGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1D62950", Offset = "0x1D61150", VA = "0x181D62950")]
	public static void ACEAJGMHEFL(this ILGenerator DOMNOIMHJOO, ulong CJMMBFLIBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class EPJDHMIMGDB
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class JJDKFONHLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public JJDKFONHLPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1D767C0", Offset = "0x1D74FC0", VA = "0x181D767C0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo NALEHGHOMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo BFPLMIMEGEA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string JMBPOHFOGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string CJJHKEIBBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PDPGHIOCPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1D71480", Offset = "0x1D6FC80", VA = "0x181D71480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IIAIBHKHLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5F6F80", Offset = "0x5F5780", VA = "0x1805F6F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6F70", Offset = "0x5F5770", VA = "0x1805F6F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CCFPAAHNLAI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF90", Offset = "0x6EC790", VA = "0x1806EDF90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC10", Offset = "0x6EC410", VA = "0x1806EDC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type JFKJECAFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo CPNCHABPGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo JOAODMJIDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5F99A0", Offset = "0x5F81A0", VA = "0x1805F99A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6D6440", Offset = "0x6D4C40", VA = "0x1806D6440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo GJNDEGGHOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5F9990", Offset = "0x5F8190", VA = "0x1805F9990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5F9350", Offset = "0x5F7B50", VA = "0x1805F9350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1D71660", Offset = "0x1D6FE60", VA = "0x181D71660")]
	protected EPJDHMIMGDB(Type BKDBLJPNPPJ, string JNAACNJBHOF, string KLCEMPILFNJ, bool JNJDGOKPHNN, bool BEAMPKAHBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1D71550", Offset = "0x1D6FD50", VA = "0x181D71550")]
	public EPJDHMIMGDB(FieldInfo FPMMADBNIOC, string JNAACNJBHOF, bool KDJIKCIFPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1D716E0", Offset = "0x1D6FEE0", VA = "0x181D716E0")]
	public EPJDHMIMGDB(PropertyInfo FPMMADBNIOC, string JNAACNJBHOF, bool KDJIKCIFPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1D71360", Offset = "0x1D6FB60", VA = "0x181D71360")]
	private static MethodInfo EMHKAFFKMDF(MemberInfo FPMMADBNIOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1C33F90", Offset = "0x1C32790", VA = "0x181C33F90")]
	public T OFEALLLJLEA<T>(bool OMAEBFCHJKP) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1D712A0", Offset = "0x1D6FAA0", VA = "0x181D712A0", Slot = "4")]
	public virtual void ECLLMACLLAM(ILGenerator DOMNOIMHJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1D71490", Offset = "0x1D6FC90", VA = "0x181D71490", Slot = "5")]
	public virtual void ICGEHCHNDPO(ILGenerator DOMNOIMHJOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class NPPPJNACPAN : EPJDHMIMGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string AKEEIINOPKK;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x366A920", Offset = "0x3669120", VA = "0x18366A920")]
	public NPPPJNACPAN(string JNAACNJBHOF, string AKEEIINOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x366A810", Offset = "0x3669010", VA = "0x18366A810", Slot = "4")]
	public override void ECLLMACLLAM(ILGenerator DOMNOIMHJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x366A8D0", Offset = "0x36690D0", VA = "0x18366A8D0", Slot = "5")]
	public override void ICGEHCHNDPO(ILGenerator DOMNOIMHJOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class PHDLJLENCFD : EPJDHMIMGDB
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo JFBDDDFPEBO;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo CFHCDBLHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal CBIFEOJLFLK LFHOMOPKDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal CBIFEOJLFLK PKCAAKGPIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal CBIFEOJLFLK HOHGKBDBINL;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x366F070", Offset = "0x366D870", VA = "0x18366F070")]
	public PHDLJLENCFD(string JNAACNJBHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x366E9B0", Offset = "0x366D1B0", VA = "0x18366E9B0", Slot = "4")]
	public override void ECLLMACLLAM(ILGenerator DOMNOIMHJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x366EA70", Offset = "0x366D270", VA = "0x18366EA70", Slot = "5")]
	public override void ICGEHCHNDPO(ILGenerator DOMNOIMHJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x366EAC0", Offset = "0x366D2C0", VA = "0x18366EAC0")]
	public void OBJCBEIIMJG(ILGenerator DOMNOIMHJOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class FCDKELICFKM
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type JFKJECAFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EODMKIOFGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCD0", Offset = "0x6AB4D0", VA = "0x1806ACCD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6E09B0", Offset = "0x6DF1B0", VA = "0x1806E09B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JBOFJBLKPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8D7340", Offset = "0x8D5B40", VA = "0x1808D7340")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8D7350", Offset = "0x8D5B50", VA = "0x1808D7350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo EDDKLNPJHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EPJDHMIMGDB[] EBCLIIOLPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EPJDHMIMGDB[] ICEGPAJHLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1D71BE0", Offset = "0x1D703E0", VA = "0x181D71BE0")]
	public FCDKELICFKM(Type BKDBLJPNPPJ, Func<string, string> KHEDOLOEJEH, bool KDJIKCIFPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1D71B10", Offset = "0x1D70310", VA = "0x181D71B10")]
	private static bool AKAKLLMABAC(IEnumerator<ConstructorInfo> CDEOMENLNBB, ref ConstructorInfo ODKKCJGHLED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct DGKIFAAOJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong ICAHHELCHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int HFHIFPILNEP;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xECD9A0", Offset = "0xECC1A0", VA = "0x180ECD9A0")]
	public DGKIFAAOJBG(ulong ENEIMPMMELE, int PBADJOBJDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1D67B70", Offset = "0x1D66370", VA = "0x181D67B70")]
	public void GMHOGOLGDLO(ref DGKIFAAOJBG ALBOAABJIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1D67CD0", Offset = "0x1D664D0", VA = "0x181D67CD0")]
	public static DGKIFAAOJBG PHDLADMOAJH(ref DGKIFAAOJBG DKLHMFCLOAB, ref DGKIFAAOJBG FLEBMPFFCAA)
	{
		return default(DGKIFAAOJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1D67AE0", Offset = "0x1D662E0", VA = "0x181D67AE0")]
	public void CDEJCEICLNN(ref DGKIFAAOJBG ALBOAABJIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1D67B80", Offset = "0x1D66380", VA = "0x181D67B80")]
	public static DGKIFAAOJBG HIGHCGOMFEJ(ref DGKIFAAOJBG DKLHMFCLOAB, ref DGKIFAAOJBG FLEBMPFFCAA)
	{
		return default(DGKIFAAOJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1D67C90", Offset = "0x1D66490", VA = "0x181D67C90")]
	public void JPLDOGGMKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1D67C30", Offset = "0x1D66430", VA = "0x181D67C30")]
	public static DGKIFAAOJBG JPLDOGGMKDF(ref DGKIFAAOJBG DKLHMFCLOAB)
	{
		return default(DGKIFAAOJBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct GMGDCAEOAFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] POKOCMHLPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int IBIPCEJMDGF;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x650EA0", Offset = "0x64F6A0", VA = "0x180650EA0")]
	public GMGDCAEOAFJ(byte[] POKOCMHLPLN, int BAFCICKIIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x237D610", Offset = "0x237BE10", VA = "0x18237D610")]
	public void ABMMKDMIKND(byte KHFJLLEIAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x237D6F0", Offset = "0x237BEF0", VA = "0x18237D6F0")]
	public void HCAHKDNCDGC(byte[] KHFJLLEIAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x237D890", Offset = "0x237C090", VA = "0x18237D890")]
	public void KJPOINPNFBH(byte[] KHFJLLEIAPP, int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x237D930", Offset = "0x237C130", VA = "0x18237D930")]
	public void KJPOINPNFBH(byte[] KHFJLLEIAPP, int MMECDMIFJKL, int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x237D670", Offset = "0x237BE70", VA = "0x18237D670")]
	public void EIJGBHPJCDI(byte AFHPHPIIHBD, int FKDPJOHPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x237D790", Offset = "0x237BF90", VA = "0x18237D790")]
	public void KCPMMCKAKFH(string KHFJLLEIAPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class LFKNEGILALK
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum DCOPCONIMPC
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum HEOICELLFFG
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum KHMLCLEBNJN
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[ThreadStatic]
	private static byte[] JJMBFIMHGOG;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] OLDBIPGDCGM;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] AKGPCEJJHGJ;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] JGLFAOPDOFP;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly KHMLCLEBNJN HPNNNAANEFE;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char KBFALMDPOBD;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int JECJPIBHIOL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int FEFCIACGCPC;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] AOAPIHHBPNK;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x36664B0", Offset = "0x3664CB0", VA = "0x1836664B0")]
	private static byte[] MCNAPDGOKDO(int OCAKIKBDFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x3665A30", Offset = "0x3664230", VA = "0x183665A30")]
	private static byte[] HCGICAGCKFC(int OCAKIKBDFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3666070", Offset = "0x3664870", VA = "0x183666070")]
	public static int JGAKBPNNFJC(ref byte[] POKOCMHLPLN, int IBIPCEJMDGF, float CJMMBFLIBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3665F60", Offset = "0x3664760", VA = "0x183665F60")]
	public static int JGAKBPNNFJC(ref byte[] POKOCMHLPLN, int IBIPCEJMDGF, double CJMMBFLIBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3664AB0", Offset = "0x36632B0", VA = "0x183664AB0")]
	private static bool AEBNDJDJONN(byte[] POKOCMHLPLN, int ABGIPDMABIG, ulong MODPNHKCINC, ulong BKMMLELHCEN, ulong PELCDPEPAED, ulong DBDHFHACDDG, ulong DOCMKMEKDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3664BB0", Offset = "0x36633B0", VA = "0x183664BB0")]
	private static void AKMOIMKELIK(uint CBBFMKNFMAK, int KCHNCBPJGFB, out uint BBPILCLEDNK, out int LLAFDMIKDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3665B10", Offset = "0x3664310", VA = "0x183665B10")]
	private static bool HCKNLNAPJFN(DGKIFAAOJBG BENIBFODIJE, DGKIFAAOJBG JCMJAPLEPMJ, DGKIFAAOJBG FIKJHPNBBPI, byte[] POKOCMHLPLN, out int ABGIPDMABIG, out int NHOOOEPAMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3665300", Offset = "0x3663B00", VA = "0x183665300")]
	private static bool CFEGJHNMHIF(double BKEAIPINHOO, DCOPCONIMPC CHFDMDJDKMA, byte[] POKOCMHLPLN, out int ABGIPDMABIG, out int PONDNIFEHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3666580", Offset = "0x3664D80", VA = "0x183666580")]
	private static bool MOLGMILLNHA(double BKEAIPINHOO, DCOPCONIMPC CHFDMDJDKMA, byte[] POKOCMHLPLN, out int ABGIPDMABIG, out int MIJFPOOLKOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3666320", Offset = "0x3664B20", VA = "0x183666320")]
	private static bool JJGLFBEKJLB(double CJMMBFLIBMO, ref GMGDCAEOAFJ HMBIPBGMJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3664CD0", Offset = "0x36634D0", VA = "0x183664CD0")]
	private static bool BGJHCFGHFDA(double CJMMBFLIBMO, ref GMGDCAEOAFJ HMBIPBGMJDI, HEOICELLFFG CHFDMDJDKMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3665870", Offset = "0x3664070", VA = "0x183665870")]
	private static void GNPDOAOIDDB(byte[] LBBOIADDFCO, int ABGIPDMABIG, int MIJFPOOLKOD, int CEMAHJDELHC, ref GMGDCAEOAFJ HMBIPBGMJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3665580", Offset = "0x3663D80", VA = "0x183665580")]
	private static void CGIKBHKGHOE(byte[] LBBOIADDFCO, int ABGIPDMABIG, int PBADJOBJDKA, ref GMGDCAEOAFJ HMBIPBGMJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3666180", Offset = "0x3664980", VA = "0x183666180")]
	private static bool JJBHKALLOCP(double BKEAIPINHOO, HEOICELLFFG CHFDMDJDKMA, int OBCCBIOOGJK, byte[] EMBHCFHAOFA, out bool EJANIFDGMJM, out int ABGIPDMABIG, out int DLEJHBBJLMH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct JMAGFLPKHGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double PEAOIEMLDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong NBPFCMLEPIK;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct MDKJHOLMKFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float ICAHHELCHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint COKFOKMBCNB;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct AKLGEDIJEMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong FNNCKBOAOOI;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D60960", Offset = "0x1D5F160", VA = "0x181D60960")]
	public AKLGEDIJEMB(double PEAOIEMLDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D60970", Offset = "0x1D5F170", VA = "0x181D60970")]
	public AKLGEDIJEMB(DGKIFAAOJBG PEAOIEMLDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D603D0", Offset = "0x1D5EBD0", VA = "0x181D603D0")]
	public DGKIFAAOJBG CAKKFKKAIBP()
	{
		return default(DGKIFAAOJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D60830", Offset = "0x1D5F030", VA = "0x181D60830")]
	public DGKIFAAOJBG NIMELIJNLLN()
	{
		return default(DGKIFAAOJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
	public ulong HGKJADFFNDG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D608F0", Offset = "0x1D5F0F0", VA = "0x181D608F0")]
	public double PKLNMELIEDJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x1D606F0", Offset = "0x1D5EEF0", VA = "0x181D606F0")]
	public double JKDKKCLKKFF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1D60510", Offset = "0x1D5ED10", VA = "0x181D60510")]
	public int EFPGPIGGFLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x1D608C0", Offset = "0x1D5F0C0", VA = "0x181D608C0")]
	public ulong OPCBDOANOMN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D60470", Offset = "0x1D5EC70", VA = "0x181D60470")]
	public bool CDECAKECNNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D60450", Offset = "0x1D5EC50", VA = "0x181D60450")]
	public bool CBIALBJBMHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x1D60540", Offset = "0x1D5ED40", VA = "0x181D60540")]
	public bool GHJAOFNGFED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D606C0", Offset = "0x1D5EEC0", VA = "0x181D606C0")]
	public bool HGEMCDGLFJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D60770", Offset = "0x1D5EF70", VA = "0x181D60770")]
	public int KDBNPLFANIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D60570", Offset = "0x1D5ED70", VA = "0x181D60570")]
	public void HCEDGHODMKJ(out DGKIFAAOJBG ABFDHIEOOGM, out DGKIFAAOJBG AAPDPNIEFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1D604C0", Offset = "0x1D5ECC0", VA = "0x181D604C0")]
	public bool EFKMBFKOMOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D60490", Offset = "0x1D5EC90", VA = "0x181D60490")]
	public double CJMMBFLIBMO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D604A0", Offset = "0x1D5ECA0", VA = "0x181D604A0")]
	public static int DBDLEFFKNEI(int EIFHBNFLNPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D603C0", Offset = "0x1D5EBC0", VA = "0x181D603C0")]
	public static double ABKCLOAMFBE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D60790", Offset = "0x1D5EF90", VA = "0x181D60790")]
	public static ulong KMMEKHDHOON(DGKIFAAOJBG ENOGKDOPGIG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct HHCJNHHIJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint AFDHIPBFPGO;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAABB80", Offset = "0xAAA380", VA = "0x180AABB80")]
	public HHCJNHHIJEA(float ICAHHELCHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x23823D0", Offset = "0x2380BD0", VA = "0x1823823D0")]
	public DGKIFAAOJBG CAKKFKKAIBP()
	{
		return default(DGKIFAAOJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0")]
	public uint BIKOOIMBFJM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2382490", Offset = "0x2380C90", VA = "0x182382490")]
	public int EFPGPIGGFLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2382620", Offset = "0x2380E20", VA = "0x182382620")]
	public uint OPCBDOANOMN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2382440", Offset = "0x2380C40", VA = "0x182382440")]
	public bool CDECAKECNNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x23824B0", Offset = "0x2380CB0", VA = "0x1823824B0")]
	public void HCEDGHODMKJ(out DGKIFAAOJBG ABFDHIEOOGM, out DGKIFAAOJBG AAPDPNIEFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2382450", Offset = "0x2380C50", VA = "0x182382450")]
	public bool EFKMBFKOMOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct HAKCLGLHOOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong ENEIMPMMELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short BEHOABCPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short PONDNIFEHPN;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x237E540", Offset = "0x237CD40", VA = "0x18237E540")]
	public HAKCLGLHOOP(ulong ENEIMPMMELE, short BEHOABCPLEI, short PONDNIFEHPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class JKOPAPDKFMM
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly HAKCLGLHOOP[] POOKBJMLPGK;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x238A620", Offset = "0x2388E20", VA = "0x18238A620")]
	public static void EBNPDHLFDGJ(int EGALADMJDCO, int NHONMAEEKKI, out DGKIFAAOJBG BBPILCLEDNK, out int PONDNIFEHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x238A750", Offset = "0x2388F50", VA = "0x18238A750")]
	public static void NAJBILJNKAE(int GCBGPHAEFON, out DGKIFAAOJBG BBPILCLEDNK, out int OPINNCJGIDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct GAKMMPIOICL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] FCDIIMLAMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int MMECDMIFJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int GNDAPKCPMCK;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2378A10", Offset = "0x2377210", VA = "0x182378A10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x15909C0", Offset = "0x158F1C0", VA = "0x1815909C0")]
	public GAKMMPIOICL(byte[] FCDIIMLAMIO, int MMECDMIFJKL, int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1182330", Offset = "0x1180B30", VA = "0x181182330")]
	public int ABGIPDMABIG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2378A50", Offset = "0x2377250", VA = "0x182378A50")]
	public GAKMMPIOICL JOAAIFJNDBN(int GLKAGFOBJCF, int DBLPJHCGOKC)
	{
		return default(GAKMMPIOICL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class ALEFJGECCHN
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] PHGGOMLIJGG;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] AKGDALGMGHH;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int GKCCFDPIGOI;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1D615E0", Offset = "0x1D5FDE0", VA = "0x181D615E0")]
	private static byte[] HOIPCEHNEAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1D623C0", Offset = "0x1D60BC0", VA = "0x181D623C0")]
	private static GAKMMPIOICL PBBLCPMHIHG(GAKMMPIOICL POKOCMHLPLN)
	{
		return default(GAKMMPIOICL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1D610E0", Offset = "0x1D5F8E0", VA = "0x181D610E0")]
	private static GAKMMPIOICL GCIBHAHLHOB(GAKMMPIOICL POKOCMHLPLN)
	{
		return default(GAKMMPIOICL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1D62300", Offset = "0x1D60B00", VA = "0x181D62300")]
	private static void NBBGKLACGJD(GAKMMPIOICL POKOCMHLPLN, int PBADJOBJDKA, byte[] GHKFGGNNMPK, out int NNHFNJCNKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D61190", Offset = "0x1D5F990", VA = "0x181D61190")]
	private static void GNBCGKAGNOO(GAKMMPIOICL POKOCMHLPLN, int PBADJOBJDKA, byte[] DOLPPDEFOAK, int HKPHAKEDEAD, out GAKMMPIOICL DJNGLFMNMFD, out int ADAAOMEMFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1D61EC0", Offset = "0x1D606C0", VA = "0x181D61EC0")]
	private static ulong LPEJBNJPLJC(GAKMMPIOICL POKOCMHLPLN, out int DFLGEEKJFCD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D60FB0", Offset = "0x1D5F7B0", VA = "0x181D60FB0")]
	private static void DDIEBGNEAOF(GAKMMPIOICL POKOCMHLPLN, out DGKIFAAOJBG FNPLEFBJGJC, out int FFKAGLKJEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1D61F50", Offset = "0x1D60750", VA = "0x181D61F50")]
	private static bool NAGLELDCDBG(GAKMMPIOICL DJNGLFMNMFD, int PBADJOBJDKA, out double FNPLEFBJGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1D61440", Offset = "0x1D5FC40", VA = "0x181D61440")]
	private static DGKIFAAOJBG HGOLIMHNEFF(int PBADJOBJDKA)
	{
		return default(DGKIFAAOJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1D61950", Offset = "0x1D60150", VA = "0x181D61950")]
	private static bool KHDFMIIICFG(GAKMMPIOICL POKOCMHLPLN, int PBADJOBJDKA, out double FNPLEFBJGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1D60D50", Offset = "0x1D5F550", VA = "0x181D60D50")]
	private static bool BLHAODNKOAH(GAKMMPIOICL DJNGLFMNMFD, int PBADJOBJDKA, out double AMPLLCEMLCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D60E80", Offset = "0x1D5F680", VA = "0x181D60E80")]
	public static double? BMELKKBLLIB(GAKMMPIOICL POKOCMHLPLN, int PBADJOBJDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D616C0", Offset = "0x1D5FEC0", VA = "0x181D616C0")]
	public static float? JNDDCALHNGI(GAKMMPIOICL POKOCMHLPLN, int PBADJOBJDKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct OLJECEBKBGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] POKOCMHLPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int IBIPCEJMDGF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte EJFMLMNCFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x366E010", Offset = "0x366C810", VA = "0x18366E010")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x650EA0", Offset = "0x64F6A0", VA = "0x180650EA0")]
	public OLJECEBKBGM(byte[] POKOCMHLPLN, int IBIPCEJMDGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x366E1F0", Offset = "0x366C9F0", VA = "0x18366E1F0")]
	public static OLJECEBKBGM MDOODPMJMBC(OLJECEBKBGM KBMECNBEFEN)
	{
		return default(OLJECEBKBGM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x366E090", Offset = "0x366C890", VA = "0x18366E090")]
	public static OLJECEBKBGM GAHCJAADICN(OLJECEBKBGM KBMECNBEFEN, int ABGIPDMABIG)
	{
		return default(OLJECEBKBGM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x366E130", Offset = "0x366C930", VA = "0x18366E130")]
	public static int KKLEEKEHGNM(OLJECEBKBGM MEHHMGBDHKJ, OLJECEBKBGM MLOFKBADEJB)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x366E150", Offset = "0x366C950", VA = "0x18366E150")]
	public static bool LLPKNBIICCC(OLJECEBKBGM MEHHMGBDHKJ, OLJECEBKBGM MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x366E240", Offset = "0x366CA40", VA = "0x18366E240")]
	public static bool PNNBKKFLHKP(OLJECEBKBGM MEHHMGBDHKJ, OLJECEBKBGM MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x366E170", Offset = "0x366C970", VA = "0x18366E170")]
	public static bool LLPKNBIICCC(OLJECEBKBGM MEHHMGBDHKJ, char MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x366E200", Offset = "0x366CA00", VA = "0x18366E200")]
	public static bool PNNBKKFLHKP(OLJECEBKBGM MEHHMGBDHKJ, char MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x366E200", Offset = "0x366CA00", VA = "0x18366E200")]
	public static bool PNNBKKFLHKP(OLJECEBKBGM MEHHMGBDHKJ, byte MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x366E050", Offset = "0x366C850", VA = "0x18366E050")]
	public static bool DLJMDCHHJOD(OLJECEBKBGM MEHHMGBDHKJ, char MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x366E1B0", Offset = "0x366C9B0", VA = "0x18366E1B0")]
	public static bool MBIHLLPGACH(OLJECEBKBGM MEHHMGBDHKJ, char MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x366DFD0", Offset = "0x366C7D0", VA = "0x18366DFD0")]
	public static bool BACIKFOILMM(OLJECEBKBGM MEHHMGBDHKJ, char MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x366E0F0", Offset = "0x366C8F0", VA = "0x18366E0F0")]
	public static bool HEDODOAEMMK(OLJECEBKBGM MEHHMGBDHKJ, char MLOFKBADEJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class OFFMEHGNAPC
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] FKHBPCHJIPJ;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] DFHJHFNLFEG;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] AKGPCEJJHGJ;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] JGLFAOPDOFP;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] ALBJNOGIDHJ;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int BELIEJMKFAH;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] ALMEPBPOKDG;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int ELOJKLJDBGN;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x366BF60", Offset = "0x366A760", VA = "0x18366BF60")]
	private static byte[] COBMIGELNEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x366C410", Offset = "0x366AC10", VA = "0x18366C410")]
	private static byte[] HNMEDMBGFHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x366D750", Offset = "0x366BF50", VA = "0x18366D750")]
	public static double OBOCDHHNKCC(byte[] POKOCMHLPLN, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x366C550", Offset = "0x366AD50", VA = "0x18366C550")]
	public static float MDOGKGNFKFN(byte[] POKOCMHLPLN, int IBIPCEJMDGF, out int EMNMPBFKDKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x366C160", Offset = "0x366A960", VA = "0x18366C160")]
	private static bool ENDJKBFIJKC(int FGCAOGJDCFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x366C2E0", Offset = "0x366AAE0", VA = "0x18366C2E0")]
	private static bool GOGCPINEPID(ref OLJECEBKBGM DIFGCKNOINJ, OLJECEBKBGM NOOMMODKENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x366C040", Offset = "0x366A840", VA = "0x18366C040")]
	private static bool DDLKNPFABPH(ref OLJECEBKBGM DIFGCKNOINJ, OLJECEBKBGM NOOMMODKENI, byte[] HPLEDCENCFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x366C4F0", Offset = "0x366ACF0", VA = "0x18366C4F0")]
	private static bool MBFHGOFJMPO(ref OLJECEBKBGM LHFIBEBJAHH, byte[] KHFJLLEIAPP, int IBIPCEJMDGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x81E9A0", Offset = "0x81D1A0", VA = "0x18081E9A0")]
	private static double CMEJNBODPLM(bool EJANIFDGMJM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x366C610", Offset = "0x366AE10", VA = "0x18366C610")]
	private static double NEFDLLCMBDL(OLJECEBKBGM KMABBNINIEC, int ABGIPDMABIG, bool HGONPBCICEO, out int NCBHPOLJDNC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class KHCDCCCBKHG<T> : global::EBPKMMEFPKF<T[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::KMNBIGGENNG<T> IDMJINOAFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly ACBHEFGEMFO BPDBPMBKHFF;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3406720", Offset = "0x3404F20", VA = "0x183406720")]
	public KHCDCCCBKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xE31E30", Offset = "0xE30630", VA = "0x180E31E30")]
	public KHCDCCCBKHG(ACBHEFGEMFO BPDBPMBKHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x55E5720", Offset = "0x55E3F20", VA = "0x1855E5720", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, T[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x55E7B30", Offset = "0x55E6330", VA = "0x1855E7B30", Slot = "5")]
	public T[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class MGHPFKDHAJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::KMNBIGGENNG<T> IDMJINOAFIF;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class EKOLEFJLOAF<T> : global::EBPKMMEFPKF<List<T>>, GLLCIPEHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly ACBHEFGEMFO BPDBPMBKHFF;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3406720", Offset = "0x3404F20", VA = "0x183406720")]
	public EKOLEFJLOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xE31E30", Offset = "0xE30630", VA = "0x180E31E30")]
	public EKOLEFJLOAF(ACBHEFGEMFO BPDBPMBKHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5667550", Offset = "0x5665D50", VA = "0x185667550", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, List<T> CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5668400", Offset = "0x5666C00", VA = "0x185668400", Slot = "5")]
	public List<T> JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class GECDEIBGEOA<TElement, TIntermediate, TEnumerator, TCollection> : global::EBPKMMEFPKF<TCollection>, GLLCIPEHDNF where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5750850", Offset = "0x574F050", VA = "0x185750850", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, TCollection CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5751E60", Offset = "0x5750660", VA = "0x185751E60", Slot = "5")]
	public TCollection JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator GBFIDJIMKKM(TCollection MOLPKNIJMDK);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate BHNJDAHDLKD();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void NLKJJINIDJF(ref TIntermediate MGCOKKBNFPI, int AKLHCIJHJKB, TElement CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection DOLHECDOMGA(ref TIntermediate OGDAIJMCLHG);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
	protected GECDEIBGEOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class NCFHNMIDBMA<TElement, TIntermediate, TCollection> : global::GECDEIBGEOA<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5664540", Offset = "0x5662D40", VA = "0x185664540", Slot = "6")]
	protected override IEnumerator<TElement> GBFIDJIMKKM(TCollection MOLPKNIJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x17344A0", Offset = "0x1732CA0", VA = "0x1817344A0")]
	protected NCFHNMIDBMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class BNDOLHJLDGI<TElement, TCollection> : global::NCFHNMIDBMA<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected sealed override TCollection DOLHECDOMGA(ref TCollection OGDAIJMCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class LEMGDJBKLAM<TElement, TCollection> : global::BNDOLHJLDGI<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0E60", Offset = "0x4F9F660", VA = "0x184FA0E60", Slot = "7")]
	protected override TCollection BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5584CB0", Offset = "0x55834B0", VA = "0x185584CB0", Slot = "8")]
	protected override void NLKJJINIDJF(ref TCollection MGCOKKBNFPI, int AKLHCIJHJKB, TElement CJMMBFLIBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class KILGLJNAPBO<T> : global::GECDEIBGEOA<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E3D0", Offset = "0x4F9CBD0", VA = "0x184F9E3D0", Slot = "8")]
	protected override void NLKJJINIDJF(ref LinkedList<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override LinkedList<T> DOLHECDOMGA(ref LinkedList<T> OGDAIJMCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override LinkedList<T> BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x518A7F0", Offset = "0x5188FF0", VA = "0x18518A7F0", Slot = "6")]
	protected override LinkedList<T>.Enumerator GBFIDJIMKKM(LinkedList<T> MOLPKNIJMDK)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PKIDLFCGFBC<T> : global::GECDEIBGEOA<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E3D0", Offset = "0x4F9CBD0", VA = "0x184F9E3D0", Slot = "8")]
	protected override void NLKJJINIDJF(ref Queue<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override Queue<T> BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E380", Offset = "0x4F9CB80", VA = "0x184F9E380", Slot = "6")]
	protected override Queue<T>.Enumerator GBFIDJIMKKM(Queue<T> MOLPKNIJMDK)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override Queue<T> DOLHECDOMGA(ref Queue<T> OGDAIJMCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class KALEMNCMBAJ<T> : global::GECDEIBGEOA<T, global::KMIIFDBIHOK<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x4F972A0", Offset = "0x4F95AA0", VA = "0x184F972A0", Slot = "8")]
	protected override void NLKJJINIDJF(ref global::KMIIFDBIHOK<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x4F971B0", Offset = "0x4F959B0", VA = "0x184F971B0", Slot = "7")]
	protected override global::KMIIFDBIHOK<T> BHNJDAHDLKD()
	{
		return default(global::KMIIFDBIHOK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E380", Offset = "0x4F9CB80", VA = "0x184F9E380", Slot = "6")]
	protected override Stack<T>.Enumerator GBFIDJIMKKM(Stack<T> MOLPKNIJMDK)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x518E4D0", Offset = "0x518CCD0", VA = "0x18518E4D0", Slot = "9")]
	protected override Stack<T> DOLHECDOMGA(ref global::KMIIFDBIHOK<T> OGDAIJMCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class LPPKFDCDAOO<T> : global::GECDEIBGEOA<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E3D0", Offset = "0x4F9CBD0", VA = "0x184F9E3D0", Slot = "8")]
	protected override void NLKJJINIDJF(ref HashSet<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override HashSet<T> DOLHECDOMGA(ref HashSet<T> OGDAIJMCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override HashSet<T> BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E380", Offset = "0x4F9CB80", VA = "0x184F9E380", Slot = "6")]
	protected override HashSet<T>.Enumerator GBFIDJIMKKM(HashSet<T> MOLPKNIJMDK)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class GBLDOIMCANF<T> : global::NCFHNMIDBMA<T, global::KMIIFDBIHOK<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4F972A0", Offset = "0x4F95AA0", VA = "0x184F972A0", Slot = "8")]
	protected override void NLKJJINIDJF(ref global::KMIIFDBIHOK<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5715840", Offset = "0x5714040", VA = "0x185715840", Slot = "9")]
	protected override ReadOnlyCollection<T> DOLHECDOMGA(ref global::KMIIFDBIHOK<T> OGDAIJMCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x57157F0", Offset = "0x5713FF0", VA = "0x1857157F0", Slot = "7")]
	protected override global::KMIIFDBIHOK<T> BHNJDAHDLKD()
	{
		return default(global::KMIIFDBIHOK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class IAMECECOGKB<T> : global::NCFHNMIDBMA<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E3D0", Offset = "0x4F9CBD0", VA = "0x184F9E3D0", Slot = "8")]
	protected override void NLKJJINIDJF(ref List<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override List<T> BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override IList<T> DOLHECDOMGA(ref List<T> OGDAIJMCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class EPICJDPHCMP<T> : global::NCFHNMIDBMA<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E3D0", Offset = "0x4F9CBD0", VA = "0x184F9E3D0", Slot = "8")]
	protected override void NLKJJINIDJF(ref List<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override List<T> BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override ICollection<T> DOLHECDOMGA(ref List<T> OGDAIJMCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class FILBJBIIKHC<T> : global::NCFHNMIDBMA<T, global::KMIIFDBIHOK<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x4F972A0", Offset = "0x4F95AA0", VA = "0x184F972A0", Slot = "8")]
	protected override void NLKJJINIDJF(ref global::KMIIFDBIHOK<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4F971B0", Offset = "0x4F959B0", VA = "0x184F971B0", Slot = "7")]
	protected override global::KMIIFDBIHOK<T> BHNJDAHDLKD()
	{
		return default(global::KMIIFDBIHOK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5098DD0", Offset = "0x50975D0", VA = "0x185098DD0", Slot = "9")]
	protected override IEnumerable<T> DOLHECDOMGA(ref global::KMIIFDBIHOK<T> OGDAIJMCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class CMENFKIFGBO<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class DJFDANCCCCH<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class KDLIKGGCGNL<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class DBFLNNLCKNA : global::EBPKMMEFPKF<IEnumerable>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::EBPKMMEFPKF<IEnumerable> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1D675F0", Offset = "0x1D65DF0", VA = "0x181D675F0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, IEnumerable CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x1D67850", Offset = "0x1D66050", VA = "0x181D67850", Slot = "5")]
	public IEnumerable JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public DBFLNNLCKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class BINGGEJCLPO : global::EBPKMMEFPKF<ICollection>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::EBPKMMEFPKF<ICollection> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1D65330", Offset = "0x1D63B30", VA = "0x181D65330", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, ICollection CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1D65690", Offset = "0x1D63E90", VA = "0x181D65690", Slot = "5")]
	public ICollection JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public BINGGEJCLPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class GPCJMADAOBF : global::EBPKMMEFPKF<IList>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::EBPKMMEFPKF<IList> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x237E050", Offset = "0x237C850", VA = "0x18237E050", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, IList CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x237E2F0", Offset = "0x237CAF0", VA = "0x18237E2F0", Slot = "5")]
	public IList JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GPCJMADAOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class PFIFNCLGGFD<T> : global::NCFHNMIDBMA<T, global::KMIIFDBIHOK<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x4F97270", Offset = "0x4F95A70", VA = "0x184F97270", Slot = "8")]
	protected override void NLKJJINIDJF(ref global::KMIIFDBIHOK<T> MGCOKKBNFPI, int AKLHCIJHJKB, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x4F971B0", Offset = "0x4F959B0", VA = "0x184F971B0", Slot = "7")]
	protected override global::KMIIFDBIHOK<T> BHNJDAHDLKD()
	{
		return default(global::KMIIFDBIHOK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x4F97200", Offset = "0x4F95A00", VA = "0x184F97200", Slot = "9")]
	protected override IReadOnlyList<T> DOLHECDOMGA(ref global::KMIIFDBIHOK<T> OGDAIJMCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0xE30DE0", Offset = "0xE2F5E0", VA = "0x180E30DE0")]
	public PFIFNCLGGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class JDKFLEBOKGP
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x23880A0", Offset = "0x23868A0", VA = "0x1823880A0")]
	public static DateTime BNICDNACBGH(DateTime KEONOLGEFML)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class ODILBDBMBIM : global::EBPKMMEFPKF<DateTime>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::EBPKMMEFPKF<DateTime> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x366ABB0", Offset = "0x36693B0", VA = "0x18366ABB0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, DateTime CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x366B000", Offset = "0x3669800", VA = "0x18366B000", Slot = "5")]
	public DateTime JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public ODILBDBMBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class GFIPELIIEDF : global::EBPKMMEFPKF<DateTimeOffset>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::EBPKMMEFPKF<DateTimeOffset> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2378AB0", Offset = "0x23772B0", VA = "0x182378AB0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, DateTimeOffset CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2378E80", Offset = "0x2377680", VA = "0x182378E80", Slot = "5")]
	public DateTimeOffset JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GFIPELIIEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class GKMCPKODEMN : global::EBPKMMEFPKF<TimeSpan>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::EBPKMMEFPKF<TimeSpan> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] DEKFNKBBBBL;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x237C980", Offset = "0x237B180", VA = "0x18237C980", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, TimeSpan CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x237CC40", Offset = "0x237B440", VA = "0x18237CC40", Slot = "5")]
	public TimeSpan JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GKMCPKODEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class CEFMOAPBOJK<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::EBPKMMEFPKF<TDictionary>, GLLCIPEHDNF where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x559D360", Offset = "0x559BB60", VA = "0x18559D360", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, TDictionary CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x55A03C0", Offset = "0x559EBC0", VA = "0x1855A03C0", Slot = "5")]
	public TDictionary JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator GBFIDJIMKKM(TDictionary MOLPKNIJMDK);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate BHNJDAHDLKD();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void NLKJJINIDJF(ref TIntermediate MGCOKKBNFPI, int AKLHCIJHJKB, TKey BAGMDNPKAJL, TValue CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary DOLHECDOMGA(ref TIntermediate OGDAIJMCLHG);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
	protected CEFMOAPBOJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class EHAGIGOACAH<TKey, TValue, TIntermediate, TDictionary> : global::CEFMOAPBOJK<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5664540", Offset = "0x5662D40", VA = "0x185664540", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> GBFIDJIMKKM(TDictionary MOLPKNIJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class PBEMMDPJJHP<TKey, TValue, TDictionary> : global::EHAGIGOACAH<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override TDictionary DOLHECDOMGA(ref TDictionary OGDAIJMCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class JNOPPHJOIMC<TKey, TValue> : global::CEFMOAPBOJK<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x518A8A0", Offset = "0x51890A0", VA = "0x18518A8A0", Slot = "8")]
	protected override void NLKJJINIDJF(ref Dictionary<TKey, TValue> MGCOKKBNFPI, int AKLHCIJHJKB, TKey BAGMDNPKAJL, TValue CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override Dictionary<TKey, TValue> DOLHECDOMGA(ref Dictionary<TKey, TValue> OGDAIJMCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override Dictionary<TKey, TValue> BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x518A850", Offset = "0x5189050", VA = "0x18518A850", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator GBFIDJIMKKM(Dictionary<TKey, TValue> MOLPKNIJMDK)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2554F70", Offset = "0x2553770", VA = "0x182554F70")]
	public JNOPPHJOIMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class KAEGOLPANEA<TKey, TValue, TDictionary> : global::PBEMMDPJJHP<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x518E1F0", Offset = "0x518C9F0", VA = "0x18518E1F0", Slot = "8")]
	protected override void NLKJJINIDJF(ref TDictionary MGCOKKBNFPI, int AKLHCIJHJKB, TKey BAGMDNPKAJL, TValue CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x25BD9A0", Offset = "0x25BC1A0", VA = "0x1825BD9A0", Slot = "7")]
	protected override TDictionary BHNJDAHDLKD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class IDFIIJMOMLM<TKey, TValue> : global::EHAGIGOACAH<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x4F98800", Offset = "0x4F97000", VA = "0x184F98800", Slot = "8")]
	protected override void NLKJJINIDJF(ref Dictionary<TKey, TValue> MGCOKKBNFPI, int AKLHCIJHJKB, TKey BAGMDNPKAJL, TValue CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override Dictionary<TKey, TValue> BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override IDictionary<TKey, TValue> DOLHECDOMGA(ref Dictionary<TKey, TValue> OGDAIJMCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class LHIOFICCLJA<TKey, TValue> : global::PBEMMDPJJHP<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x4F98800", Offset = "0x4F97000", VA = "0x184F98800", Slot = "8")]
	protected override void NLKJJINIDJF(ref SortedList<TKey, TValue> MGCOKKBNFPI, int AKLHCIJHJKB, TKey BAGMDNPKAJL, TValue CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override SortedList<TKey, TValue> BHNJDAHDLKD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class PJHNEMPBLCO<TKey, TValue> : global::CEFMOAPBOJK<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x4F98800", Offset = "0x4F97000", VA = "0x184F98800", Slot = "8")]
	protected override void NLKJJINIDJF(ref SortedDictionary<TKey, TValue> MGCOKKBNFPI, int AKLHCIJHJKB, TKey BAGMDNPKAJL, TValue CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xAEC6B0", Offset = "0xAEAEB0", VA = "0x180AEC6B0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> DOLHECDOMGA(ref SortedDictionary<TKey, TValue> OGDAIJMCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4F98740", Offset = "0x4F96F40", VA = "0x184F98740", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> BHNJDAHDLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x4F987A0", Offset = "0x4F96FA0", VA = "0x184F987A0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator GBFIDJIMKKM(SortedDictionary<TKey, TValue> MOLPKNIJMDK)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NBPGDFIGDPO<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class IFINFAMEDIG : global::EBPKMMEFPKF<IDictionary>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::EBPKMMEFPKF<IDictionary> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2385BE0", Offset = "0x23843E0", VA = "0x182385BE0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, IDictionary CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2385FD0", Offset = "0x23847D0", VA = "0x182385FD0", Slot = "5")]
	public IDictionary JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IFINFAMEDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class FLJPEDLLLDI : global::EBPKMMEFPKF<object>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void APOGILMNJJP(object DEOBOPBCANB, ref FDFDFLKINMJ HELLEMCMMHJ, object CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::PJOGIOBAPNH<KeyValuePair<object, APOGILMNJJP>> NEDLOHNFGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly KMJPBNOKBLE[] PPMFDCEHFIK;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2378100", Offset = "0x2376900", VA = "0x182378100")]
	public FLJPEDLLLDI(params KMJPBNOKBLE[] PPMFDCEHFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x23778A0", Offset = "0x23760A0", VA = "0x1823778A0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, object CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2378070", Offset = "0x2376870", VA = "0x182378070", Slot = "5")]
	public object JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class BCNAABKIGGE
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x1D64490", Offset = "0x1D62C90", VA = "0x181D64490")]
	public static object PCPLHCGBLID(Type BKDBLJPNPPJ, out bool BNLHDJFKCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1D63CB0", Offset = "0x1D624B0", VA = "0x181D63CB0")]
	public static object DOOCGHLHAPD(Type BKDBLJPNPPJ, out bool BNLHDJFKCAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class OGMIDCJDGGP<T> : global::EBPKMMEFPKF<T>, GLLCIPEHDNF, global::EBKMAPBBMKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class GPLJPNIODFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public GPLJPNIODFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x54FA7A0", Offset = "0x54F8FA0", VA = "0x1854FA7A0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class AFCOFPDEBNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::KFCLCAGODGO<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public AFCOFPDEBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x54F1C70", Offset = "0x54F0470", VA = "0x1854F1C70")]
		internal void <.cctor>b__1(ref FDFDFLKINMJ writer, T value, KMJPBNOKBLE _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class EMDIEJDFEBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::ELHCLKOEDFH<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public EMDIEJDFEBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x54F63C0", Offset = "0x54F4BC0", VA = "0x1854F63C0")]
		internal T <.cctor>b__2(ref HMLHAIACJAH reader, KMJPBNOKBLE _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::JIEHFPLPGOC<T> HOAHDLJKDFN;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> CNEKLNJEMFE;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::KFCLCAGODGO<T> IIKAMGCLINM;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::ELHCLKOEDFH<T> GFJHHCKMEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool AJAKOMGHLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::KFCLCAGODGO<T> NEENMKGGGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::ELHCLKOEDFH<T> FJPBPEBHGJL;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x55080B0", Offset = "0x55068B0", VA = "0x1855080B0")]
	static OGMIDCJDGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5509DB0", Offset = "0x55085B0", VA = "0x185509DB0")]
	public OGMIDCJDGGP(bool AJAKOMGHLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5505180", Offset = "0x5503980", VA = "0x185505180", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, T CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5505350", Offset = "0x5503B50", VA = "0x185505350", Slot = "5")]
	public T JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5506050", Offset = "0x5504850", VA = "0x185506050", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, T CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5504810", Offset = "0x5503010", VA = "0x185504810", Slot = "7")]
	public T AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class NLAMONHNOPM<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class AINGIIPFBJD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class IMADFAJCJLA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class NPDGCNKKLDI<T> : global::EBPKMMEFPKF<T?>, GLLCIPEHDNF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x54D10D0", Offset = "0x54CF8D0", VA = "0x1854D10D0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, T? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x54D14B0", Offset = "0x54CFCB0", VA = "0x1854D14B0", Slot = "5")]
	public T? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
	public NPDGCNKKLDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class EMGDOKPKBEG<T> : global::EBPKMMEFPKF<T?>, GLLCIPEHDNF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::EBPKMMEFPKF<T> HHFCMEAOCFC;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0xE2F290", Offset = "0xE2DA90", VA = "0x180E2F290")]
	public EMGDOKPKBEG(global::EBPKMMEFPKF<T> HHFCMEAOCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5672CA0", Offset = "0x56714A0", VA = "0x185672CA0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, T? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x5673510", Offset = "0x5671D10", VA = "0x185673510", Slot = "5")]
	public T? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class BLGMNCOHFPP : global::EBPKMMEFPKF<sbyte>, GLLCIPEHDNF, global::EBKMAPBBMKM<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly BLGMNCOHFPP JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x1D658E0", Offset = "0x1D640E0", VA = "0x181D658E0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, sbyte CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x1D65920", Offset = "0x1D64120", VA = "0x181D65920", Slot = "5")]
	public sbyte JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1D65930", Offset = "0x1D64130", VA = "0x181D65930", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, sbyte CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D65870", Offset = "0x1D64070", VA = "0x181D65870", Slot = "7")]
	public sbyte AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public BLGMNCOHFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class CDMJKCOBMHA : global::EBPKMMEFPKF<sbyte?>, GLLCIPEHDNF, global::EBKMAPBBMKM<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly CDMJKCOBMHA JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x1D65CE0", Offset = "0x1D644E0", VA = "0x181D65CE0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, sbyte? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x1D65D60", Offset = "0x1D64560", VA = "0x181D65D60", Slot = "5")]
	public sbyte? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1D65DD0", Offset = "0x1D645D0", VA = "0x181D65DD0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, sbyte? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x1D65C30", Offset = "0x1D64430", VA = "0x181D65C30", Slot = "7")]
	public sbyte? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CDMJKCOBMHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class CNIGIGEOMEC : global::EBPKMMEFPKF<sbyte[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly CNIGIGEOMEC JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D67170", Offset = "0x1D65970", VA = "0x181D67170", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, sbyte[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D67310", Offset = "0x1D65B10", VA = "0x181D67310", Slot = "5")]
	public sbyte[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CNIGIGEOMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class LKKDFFBNCHD : global::EBPKMMEFPKF<short>, GLLCIPEHDNF, global::EBKMAPBBMKM<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly LKKDFFBNCHD JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3666B30", Offset = "0x3665330", VA = "0x183666B30", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, short CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3666B50", Offset = "0x3665350", VA = "0x183666B50", Slot = "5")]
	public short JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3666B60", Offset = "0x3665360", VA = "0x183666B60", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, short CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3666AC0", Offset = "0x36652C0", VA = "0x183666AC0", Slot = "7")]
	public short AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LKKDFFBNCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class EEEMAHHHCGN : global::EBPKMMEFPKF<short?>, GLLCIPEHDNF, global::EBKMAPBBMKM<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly EEEMAHHHCGN JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D68560", Offset = "0x1D66D60", VA = "0x181D68560", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, short? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D685E0", Offset = "0x1D66DE0", VA = "0x181D685E0", Slot = "5")]
	public short? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D68650", Offset = "0x1D66E50", VA = "0x181D68650", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, short? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D684C0", Offset = "0x1D66CC0", VA = "0x181D684C0", Slot = "7")]
	public short? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public EEEMAHHHCGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class LFEFIICADPO : global::EBPKMMEFPKF<short[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly LFEFIICADPO JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x3664850", Offset = "0x3663050", VA = "0x183664850", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, short[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x3664910", Offset = "0x3663110", VA = "0x183664910", Slot = "5")]
	public short[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LFEFIICADPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class LMKEOAKEDPJ : global::EBPKMMEFPKF<int>, GLLCIPEHDNF, global::EBKMAPBBMKM<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly LMKEOAKEDPJ JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3666C70", Offset = "0x3665470", VA = "0x183666C70", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, int CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3666C80", Offset = "0x3665480", VA = "0x183666C80", Slot = "5")]
	public int JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3666C90", Offset = "0x3665490", VA = "0x183666C90", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, int CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3666C00", Offset = "0x3665400", VA = "0x183666C00", Slot = "7")]
	public int AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LMKEOAKEDPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class FOJECDCKAKM : global::EBPKMMEFPKF<int?>, GLLCIPEHDNF, global::EBKMAPBBMKM<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly FOJECDCKAKM JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2378500", Offset = "0x2376D00", VA = "0x182378500", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, int? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2378570", Offset = "0x2376D70", VA = "0x182378570", Slot = "5")]
	public int? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2378620", Offset = "0x2376E20", VA = "0x182378620", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, int? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2378430", Offset = "0x2376C30", VA = "0x182378430", Slot = "7")]
	public int? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public FOJECDCKAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class PKBJNLOGLNM : global::EBPKMMEFPKF<int[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly PKBJNLOGLNM JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x366F110", Offset = "0x366D910", VA = "0x18366F110", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, int[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x366F1D0", Offset = "0x366D9D0", VA = "0x18366F1D0", Slot = "5")]
	public int[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PKBJNLOGLNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class CLCAJEMKEIC : global::EBPKMMEFPKF<long>, GLLCIPEHDNF, global::EBKMAPBBMKM<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly CLCAJEMKEIC JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D66B20", Offset = "0x1D65320", VA = "0x181D66B20", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, long CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D66B50", Offset = "0x1D65350", VA = "0x181D66B50", Slot = "5")]
	public long JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D66B60", Offset = "0x1D65360", VA = "0x181D66B60", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, long CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D66AB0", Offset = "0x1D652B0", VA = "0x181D66AB0", Slot = "7")]
	public long AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CLCAJEMKEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class BAJCOALHENJ : global::EBPKMMEFPKF<long?>, GLLCIPEHDNF, global::EBKMAPBBMKM<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly BAJCOALHENJ JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x1D63A40", Offset = "0x1D62240", VA = "0x181D63A40", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, long? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x1D63AC0", Offset = "0x1D622C0", VA = "0x181D63AC0", Slot = "5")]
	public long? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x1D63B50", Offset = "0x1D62350", VA = "0x181D63B50", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, long? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1D63980", Offset = "0x1D62180", VA = "0x181D63980", Slot = "7")]
	public long? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public BAJCOALHENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class PEPPGMGCLOI : global::EBPKMMEFPKF<long[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly PEPPGMGCLOI JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x366E750", Offset = "0x366CF50", VA = "0x18366E750", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, long[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x366E810", Offset = "0x366D010", VA = "0x18366E810", Slot = "5")]
	public long[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PEPPGMGCLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class ANFKBINAPIC : global::EBPKMMEFPKF<byte>, GLLCIPEHDNF, global::EBKMAPBBMKM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly ANFKBINAPIC JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x1D62570", Offset = "0x1D60D70", VA = "0x181D62570", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, byte CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D625B0", Offset = "0x1D60DB0", VA = "0x181D625B0", Slot = "5")]
	public byte JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x1D625C0", Offset = "0x1D60DC0", VA = "0x181D625C0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, byte CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D62500", Offset = "0x1D60D00", VA = "0x181D62500", Slot = "7")]
	public byte AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public ANFKBINAPIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class AIJLGJMGNMJ : global::EBPKMMEFPKF<byte?>, GLLCIPEHDNF, global::EBKMAPBBMKM<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly AIJLGJMGNMJ JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1D5FFE0", Offset = "0x1D5E7E0", VA = "0x181D5FFE0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, byte? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x1D60060", Offset = "0x1D5E860", VA = "0x181D60060", Slot = "5")]
	public byte? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D600D0", Offset = "0x1D5E8D0", VA = "0x181D600D0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, byte? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D5FF30", Offset = "0x1D5E730", VA = "0x181D5FF30", Slot = "7")]
	public byte? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public AIJLGJMGNMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class INAMFMKEOKO : global::EBPKMMEFPKF<ushort>, GLLCIPEHDNF, global::EBKMAPBBMKM<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly INAMFMKEOKO JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2386F00", Offset = "0x2385700", VA = "0x182386F00", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, ushort CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2386F20", Offset = "0x2385720", VA = "0x182386F20", Slot = "5")]
	public ushort JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2386F80", Offset = "0x2385780", VA = "0x182386F80", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, ushort CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2386E60", Offset = "0x2385660", VA = "0x182386E60", Slot = "7")]
	public ushort AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public INAMFMKEOKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class IELAFDODIPD : global::EBPKMMEFPKF<ushort?>, GLLCIPEHDNF, global::EBKMAPBBMKM<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly IELAFDODIPD JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x23859E0", Offset = "0x23841E0", VA = "0x1823859E0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, ushort? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2385A50", Offset = "0x2384250", VA = "0x182385A50", Slot = "5")]
	public ushort? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2385B00", Offset = "0x2384300", VA = "0x182385B00", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, ushort? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2385910", Offset = "0x2384110", VA = "0x182385910", Slot = "7")]
	public ushort? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IELAFDODIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class KLJFKDDCNMP : global::EBPKMMEFPKF<ushort[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly KLJFKDDCNMP JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x238C290", Offset = "0x238AA90", VA = "0x18238C290", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, ushort[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x238C350", Offset = "0x238AB50", VA = "0x18238C350", Slot = "5")]
	public ushort[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public KLJFKDDCNMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class PEMKKIPOPMA : global::EBPKMMEFPKF<uint>, GLLCIPEHDNF, global::EBKMAPBBMKM<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly PEMKKIPOPMA JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x366E690", Offset = "0x366CE90", VA = "0x18366E690", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, uint CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x366E6A0", Offset = "0x366CEA0", VA = "0x18366E6A0", Slot = "5")]
	public uint JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x366E6B0", Offset = "0x366CEB0", VA = "0x18366E6B0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, uint CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x366E620", Offset = "0x366CE20", VA = "0x18366E620", Slot = "7")]
	public uint AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PEMKKIPOPMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class HGFKCENJAFM : global::EBPKMMEFPKF<uint?>, GLLCIPEHDNF, global::EBKMAPBBMKM<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly HGFKCENJAFM JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x23821D0", Offset = "0x23809D0", VA = "0x1823821D0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, uint? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2382240", Offset = "0x2380A40", VA = "0x182382240", Slot = "5")]
	public uint? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x23822F0", Offset = "0x2380AF0", VA = "0x1823822F0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, uint? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x23820F0", Offset = "0x23808F0", VA = "0x1823820F0", Slot = "7")]
	public uint? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public HGFKCENJAFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class GIDNHKLMBBJ : global::EBPKMMEFPKF<uint[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly GIDNHKLMBBJ JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x237BC90", Offset = "0x237A490", VA = "0x18237BC90", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, uint[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x237BD50", Offset = "0x237A550", VA = "0x18237BD50", Slot = "5")]
	public uint[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GIDNHKLMBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class CILLJDKFDEE : global::EBPKMMEFPKF<ulong>, GLLCIPEHDNF, global::EBKMAPBBMKM<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly CILLJDKFDEE JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1D667C0", Offset = "0x1D64FC0", VA = "0x181D667C0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, ulong CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1D667F0", Offset = "0x1D64FF0", VA = "0x181D667F0", Slot = "5")]
	public ulong JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1D66800", Offset = "0x1D65000", VA = "0x181D66800", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, ulong CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1D66750", Offset = "0x1D64F50", VA = "0x181D66750", Slot = "7")]
	public ulong AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CILLJDKFDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class JJFCMMMBBJJ : global::EBPKMMEFPKF<ulong?>, GLLCIPEHDNF, global::EBKMAPBBMKM<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly JJFCMMMBBJJ JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x238A3B0", Offset = "0x2388BB0", VA = "0x18238A3B0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, ulong? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x238A420", Offset = "0x2388C20", VA = "0x18238A420", Slot = "5")]
	public ulong? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x238A4B0", Offset = "0x2388CB0", VA = "0x18238A4B0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, ulong? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x238A2F0", Offset = "0x2388AF0", VA = "0x18238A2F0", Slot = "7")]
	public ulong? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public JJFCMMMBBJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class ABJDDBNBHOC : global::EBPKMMEFPKF<ulong[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly ABJDDBNBHOC JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EFB0", Offset = "0x1D5D7B0", VA = "0x181D5EFB0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, ulong[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1D5F150", Offset = "0x1D5D950", VA = "0x181D5F150", Slot = "5")]
	public ulong[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public ABJDDBNBHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class BHCFGEAJMEH : global::EBPKMMEFPKF<float>, GLLCIPEHDNF, global::EBKMAPBBMKM<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly BHCFGEAJMEH JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x1D64E80", Offset = "0x1D63680", VA = "0x181D64E80", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, float CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x1D64E90", Offset = "0x1D63690", VA = "0x181D64E90", Slot = "5")]
	public float JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x1D64EA0", Offset = "0x1D636A0", VA = "0x181D64EA0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, float CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x1D64E10", Offset = "0x1D63610", VA = "0x181D64E10", Slot = "7")]
	public float AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public BHCFGEAJMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class GOFDMDGJILF : global::EBPKMMEFPKF<float?>, GLLCIPEHDNF, global::EBKMAPBBMKM<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly GOFDMDGJILF JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x237DD00", Offset = "0x237C500", VA = "0x18237DD00", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, float? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x237DD70", Offset = "0x237C570", VA = "0x18237DD70", Slot = "5")]
	public float? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x237DDE0", Offset = "0x237C5E0", VA = "0x18237DDE0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, float? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x237DC20", Offset = "0x237C420", VA = "0x18237DC20", Slot = "7")]
	public float? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GOFDMDGJILF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class NNLDPMHLOLB : global::EBPKMMEFPKF<float[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly NNLDPMHLOLB JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x366A0D0", Offset = "0x36688D0", VA = "0x18366A0D0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, float[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x366A190", Offset = "0x3668990", VA = "0x18366A190", Slot = "5")]
	public float[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public NNLDPMHLOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class BFLJDKABHDI : global::EBPKMMEFPKF<double>, GLLCIPEHDNF, global::EBKMAPBBMKM<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly BFLJDKABHDI JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x1D64CE0", Offset = "0x1D634E0", VA = "0x181D64CE0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, double CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1D64CF0", Offset = "0x1D634F0", VA = "0x181D64CF0", Slot = "5")]
	public double JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x1D64D00", Offset = "0x1D63500", VA = "0x181D64D00", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, double CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x1D64C70", Offset = "0x1D63470", VA = "0x181D64C70", Slot = "7")]
	public double AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public BFLJDKABHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class CMAKHIADJCC : global::EBPKMMEFPKF<double?>, GLLCIPEHDNF, global::EBKMAPBBMKM<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly CMAKHIADJCC JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1D66E30", Offset = "0x1D65630", VA = "0x181D66E30", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, double? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1D66EA0", Offset = "0x1D656A0", VA = "0x181D66EA0", Slot = "5")]
	public double? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1D66F30", Offset = "0x1D65730", VA = "0x181D66F30", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, double? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1D66D70", Offset = "0x1D65570", VA = "0x181D66D70", Slot = "7")]
	public double? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CMAKHIADJCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class BIKJACGCILM : global::EBPKMMEFPKF<double[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly BIKJACGCILM JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1D64FB0", Offset = "0x1D637B0", VA = "0x181D64FB0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, double[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1D65190", Offset = "0x1D63990", VA = "0x181D65190", Slot = "5")]
	public double[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public BIKJACGCILM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class IOMOEGKJJEL : global::EBPKMMEFPKF<bool>, GLLCIPEHDNF, global::EBKMAPBBMKM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly IOMOEGKJJEL JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2387DE0", Offset = "0x23865E0", VA = "0x182387DE0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, bool CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2387E00", Offset = "0x2386600", VA = "0x182387E00", Slot = "5")]
	public bool JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2387E10", Offset = "0x2386610", VA = "0x182387E10", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, bool CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2387D70", Offset = "0x2386570", VA = "0x182387D70", Slot = "7")]
	public bool AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IOMOEGKJJEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class OHBDLPMPNKI : global::EBPKMMEFPKF<bool?>, GLLCIPEHDNF, global::EBKMAPBBMKM<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly OHBDLPMPNKI JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x366DE10", Offset = "0x366C610", VA = "0x18366DE10", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, bool? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x366DE80", Offset = "0x366C680", VA = "0x18366DE80", Slot = "5")]
	public bool? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x366DEF0", Offset = "0x366C6F0", VA = "0x18366DEF0", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, bool? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x366DD60", Offset = "0x366C560", VA = "0x18366DD60", Slot = "7")]
	public bool? AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public OHBDLPMPNKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class MCGDAPFJPJP : global::EBPKMMEFPKF<bool[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly MCGDAPFJPJP JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x3667360", Offset = "0x3665B60", VA = "0x183667360", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, bool[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x3667430", Offset = "0x3665C30", VA = "0x183667430", Slot = "5")]
	public bool[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public MCGDAPFJPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class MGPFBDJIGIJ : global::EBPKMMEFPKF<object>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::EBPKMMEFPKF<object> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> JPGBCPBAJDP;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x3667780", Offset = "0x3665F80", VA = "0x183667780", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, object CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x36680D0", Offset = "0x36668D0", VA = "0x1836680D0", Slot = "5")]
	public object JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public MGPFBDJIGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class LOJOCALDKNP : global::EBPKMMEFPKF<byte[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::EBPKMMEFPKF<byte[]> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x3666D90", Offset = "0x3665590", VA = "0x183666D90", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, byte[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x3666E20", Offset = "0x3665620", VA = "0x183666E20", Slot = "5")]
	public byte[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LOJOCALDKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class EELHCCEDONI : global::EBPKMMEFPKF<ArraySegment<byte>>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::EBPKMMEFPKF<ArraySegment<byte>> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1D687B0", Offset = "0x1D66FB0", VA = "0x181D687B0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, ArraySegment<byte> CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1D68850", Offset = "0x1D67050", VA = "0x181D68850", Slot = "5")]
	public ArraySegment<byte> JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public EELHCCEDONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class OMCFGDMJEHK : global::EBPKMMEFPKF<string>, GLLCIPEHDNF, global::EBKMAPBBMKM<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::EBPKMMEFPKF<string> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x366E270", Offset = "0x366CA70", VA = "0x18366E270", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, string CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x366E260", Offset = "0x366CA60", VA = "0x18366E260", Slot = "5")]
	public string JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x366E270", Offset = "0x366CA70", VA = "0x18366E270", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, string CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x366E260", Offset = "0x366CA60", VA = "0x18366E260", Slot = "7")]
	public string AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public OMCFGDMJEHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class EBMPLOFHKDK : global::EBPKMMEFPKF<string[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly EBMPLOFHKDK JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x1D681A0", Offset = "0x1D669A0", VA = "0x181D681A0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, string[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x1D68320", Offset = "0x1D66B20", VA = "0x181D68320", Slot = "5")]
	public string[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public EBMPLOFHKDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class EHHAGAKALBB : global::EBPKMMEFPKF<char>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly EHHAGAKALBB JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x1D68980", Offset = "0x1D67180", VA = "0x181D68980", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, char CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1D68A00", Offset = "0x1D67200", VA = "0x181D68A00", Slot = "5")]
	public char JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public EHHAGAKALBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class IPOOKELDMBG : global::EBPKMMEFPKF<char?>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly IPOOKELDMBG JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2387EB0", Offset = "0x23866B0", VA = "0x182387EB0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, char? CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2387F80", Offset = "0x2386780", VA = "0x182387F80", Slot = "5")]
	public char? JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IPOOKELDMBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class EIAJGAJGLBG : global::EBPKMMEFPKF<char[]>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly EIAJGAJGLBG JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x1D68A90", Offset = "0x1D67290", VA = "0x181D68A90", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, char[] CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1D68CD0", Offset = "0x1D674D0", VA = "0x181D68CD0", Slot = "5")]
	public char[] JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public EIAJGAJGLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class OGBIODAFJOP : global::EBPKMMEFPKF<Guid>, GLLCIPEHDNF, global::EBKMAPBBMKM<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::EBPKMMEFPKF<Guid> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x366DA90", Offset = "0x366C290", VA = "0x18366DA90", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Guid CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x366DA30", Offset = "0x366C230", VA = "0x18366DA30", Slot = "5")]
	public Guid JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x366DB70", Offset = "0x366C370", VA = "0x18366DB70", Slot = "6")]
	public void KHPLCFLJFBH(ref FDFDFLKINMJ HELLEMCMMHJ, Guid CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x366DA30", Offset = "0x366C230", VA = "0x18366DA30", Slot = "7")]
	public Guid AHHGLGBBMLP(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public OGBIODAFJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class ELMJJFPKCIO : global::EBPKMMEFPKF<decimal>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::EBPKMMEFPKF<decimal> JBGJKCAJAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool OALHBODGJAP;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xEDCD00", Offset = "0xEDB500", VA = "0x180EDCD00")]
	public ELMJJFPKCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x63BF00", Offset = "0x63A700", VA = "0x18063BF00")]
	public ELMJJFPKCIO(bool OALHBODGJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x1D68EC0", Offset = "0x1D676C0", VA = "0x181D68EC0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, decimal CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1D69030", Offset = "0x1D67830", VA = "0x181D69030", Slot = "5")]
	public decimal JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class CKNJBFIIEBI : global::EBPKMMEFPKF<Uri>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::EBPKMMEFPKF<Uri> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1D66920", Offset = "0x1D65120", VA = "0x181D66920", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Uri CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1D669D0", Offset = "0x1D651D0", VA = "0x181D669D0", Slot = "5")]
	public Uri JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CKNJBFIIEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class GPBAFHPBGPF : global::EBPKMMEFPKF<Version>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::EBPKMMEFPKF<Version> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x237DEC0", Offset = "0x237C6C0", VA = "0x18237DEC0", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Version CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x237DF70", Offset = "0x237C770", VA = "0x18237DF70", Slot = "5")]
	public Version JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GPBAFHPBGPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class KOCDLJIDKHD<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class AKENPNEEJGN : global::EBPKMMEFPKF<StringBuilder>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::EBPKMMEFPKF<StringBuilder> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1D60290", Offset = "0x1D5EA90", VA = "0x181D60290", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, StringBuilder CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1D602E0", Offset = "0x1D5EAE0", VA = "0x181D602E0", Slot = "5")]
	public StringBuilder JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public AKENPNEEJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class PCPJFLIICJO : global::EBPKMMEFPKF<BitArray>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::EBPKMMEFPKF<BitArray> JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x366E430", Offset = "0x366CC30", VA = "0x18366E430", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, BitArray CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x366E4C0", Offset = "0x366CCC0", VA = "0x18366E4C0", Slot = "5")]
	public BitArray JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PCPJFLIICJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class KHIDDGNPDOI : global::EBPKMMEFPKF<Type>, GLLCIPEHDNF
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly KHIDDGNPDOI JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex JPDKMOGBKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool DNCHOBBGOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool OEEKHPNAKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool AJPFAMGGDCD;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x238C1C0", Offset = "0x238A9C0", VA = "0x18238C1C0")]
	public KHIDDGNPDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x238C1E0", Offset = "0x238A9E0", VA = "0x18238C1E0")]
	public KHIDDGNPDOI(bool DNCHOBBGOHC, bool OEEKHPNAKFC, bool AJPFAMGGDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x238BF10", Offset = "0x238A710", VA = "0x18238BF10", Slot = "4")]
	public void BAGHAKDDGPK(ref FDFDFLKINMJ HELLEMCMMHJ, Type CJMMBFLIBMO, KMJPBNOKBLE PKKIHFLKMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x238C000", Offset = "0x238A800", VA = "0x18238C000", Slot = "5")]
	public Type JDKEMADGCJE(ref HMLHAIACJAH AMCNLEFBMOK, KMJPBNOKBLE PKKIHFLKMJJ)
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
