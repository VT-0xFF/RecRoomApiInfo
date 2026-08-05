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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class AFAFNLKNELL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63DB460", Offset = "0x63DA260", VA = "0x1863DB460")]
	public static bool IPKCEEFKJNB(this TypeInfo PEMNIEMPPLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class OPAHLIIBABG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LJACCJKFNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DNLGDPHDCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
	public OPAHLIIBABG(Type JMBKPECJDDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class FMOKBAICOCC : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JBMCDPGAABN<T>(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T AHFDKLGEPJE<T>(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK PDDCFBMOHPA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NHMDNCPBKML
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KHFNPOBDEKJ<T> : NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LHIKEAPDNKI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KOGABNCIMMH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LDPPCIEAFLN
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2409730", Offset = "0x2408530", VA = "0x182409730")]
	public static string BOOLHBEBFEM<T>(this KHFNPOBDEKJ<T> IGPFFIIAKCH, T GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHFNPOBDEKJ<T> APDEGKGPLBA<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GANHBMKHOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x23532F0", Offset = "0x23520F0", VA = "0x1823532F0")]
	public static KHFNPOBDEKJ<T> IPFAGEKCJCA<T>(this LHGMBMDOIPK PDDCFBMOHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63E2250", Offset = "0x63E1050", VA = "0x1863E2250")]
	public static object DGLMPAAKFEH(this LHGMBMDOIPK PDDCFBMOHPA, Type PEMNIEMPPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OJKPFABKODJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63F34F0", Offset = "0x63F22F0", VA = "0x1863F34F0")]
	public OJKPFABKODJ(string JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PLNICAEBGII
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class HJLNDNOAIBH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] BKOBMCKFFFH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] PCFECAKPMDD;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63E42E0", Offset = "0x63E30E0", VA = "0x1863E42E0")]
		public static byte[] BOHCMJDGGDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63E4380", Offset = "0x63E3180", VA = "0x1863E4380")]
		public static char[] CJBHILJICJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> DFCCPFCHNND;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] BOKHDDBMPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] AFIEJCAINEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int HLAIJKBFIJH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool HAECEPCALFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63F5410", Offset = "0x63F4210", VA = "0x1863F5410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63F8200", Offset = "0x63F7000", VA = "0x1863F8200")]
	public PLNICAEBGII(byte[] AFIEJCAINEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63F80A0", Offset = "0x63F6EA0", VA = "0x1863F80A0")]
	public PLNICAEBGII(byte[] AFIEJCAINEM, int HLAIJKBFIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63F7890", Offset = "0x63F6690", VA = "0x1863F7890")]
	private PFNGAKCIHGG PDOJDDBHHGC(string AMKLAEEOILO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63F6B90", Offset = "0x63F5990", VA = "0x1863F6B90")]
	private PFNGAKCIHGG IDIDIFLJENG(string JIGBFCEILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63E8400", Offset = "0x63E7200", VA = "0x1863E8400")]
	public void PLCMOAFMFNF(int HLAIJKBFIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
	public byte[] EEOICHICDAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C3FD50", Offset = "0x1C3EB50", VA = "0x181C3FD50")]
	public int GJCFCEJFOAJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63F6500", Offset = "0x63F5300", VA = "0x1863F6500")]
	public IHIPGOPOPIJ FMHOCFCIBHM()
	{
		return default(IHIPGOPOPIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63F5540", Offset = "0x63F4340", VA = "0x1863F5540")]
	public void CLDIINDABJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63F6E60", Offset = "0x63F5C60", VA = "0x1863F6E60")]
	public bool JALEPBJJCMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63F7560", Offset = "0x63F6360", VA = "0x1863F7560")]
	public bool MPIHLGANACK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63F7EE0", Offset = "0x63F6CE0", VA = "0x1863F7EE0")]
	public void PODOBJKHMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63F54B0", Offset = "0x63F42B0", VA = "0x1863F54B0")]
	public bool CGDNOLHLAPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63F66B0", Offset = "0x63F54B0", VA = "0x1863F66B0")]
	public bool GDDJCGNGOBO(int HLFCMANHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x63F7310", Offset = "0x63F6110", VA = "0x1863F7310")]
	public bool KOKAGDKLKBI(int HLFCMANHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x63F7E50", Offset = "0x63F6C50", VA = "0x1863F7E50")]
	public bool PHJFFMGGDKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63F6F80", Offset = "0x63F5D80", VA = "0x1863F6F80")]
	public void JBFKAGADIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63F5380", Offset = "0x63F4180", VA = "0x1863F5380")]
	public bool BKAALOKJOKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63F76B0", Offset = "0x63F64B0", VA = "0x1863F76B0")]
	public bool NFHEJOGDCBB(int HLFCMANHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63F6D90", Offset = "0x63F5B90", VA = "0x1863F6D90")]
	public bool INJNPKLANKG(int HLFCMANHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63F6D00", Offset = "0x63F5B00", VA = "0x1863F6D00")]
	public bool IKHCPLJEKFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63F6460", Offset = "0x63F5260", VA = "0x1863F6460")]
	public void FIMEHECHHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63F4DD0", Offset = "0x63F3BD0", VA = "0x1863F4DD0")]
	public bool AJGAGCFNDHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63F77F0", Offset = "0x63F65F0", VA = "0x1863F77F0")]
	public void OHDPFNBKAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63F5670", Offset = "0x63F4470", VA = "0x1863F5670")]
	private void COLHKLOILNK([Out] byte[] EJELHBJNHBB, [Out] int CCCDHMOPMDC, [Out] int MDFPCCIKPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63F6780", Offset = "0x63F5580", VA = "0x1863F6780")]
	private static int GFMAGMILFFB(char MACGGKMNKNM, char JHKDDIMPPGN, char MFEFOKLBOBC, char BIGGLMECNJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63F7230", Offset = "0x63F6030", VA = "0x1863F7230")]
	private static int KNAENEMMHEK(char HOELCINBFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63F5F70", Offset = "0x63F4D70", VA = "0x1863F5F70")]
	public ArraySegment<byte> EDLECPJIFHE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63F5E10", Offset = "0x63F4C10", VA = "0x1863F5E10")]
	public string DFIDEGHLNKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63F7DE0", Offset = "0x63F6BE0", VA = "0x1863F7DE0")]
	public string PFGOPGIFHIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63F6970", Offset = "0x63F5770", VA = "0x1863F6970")]
	public ArraySegment<byte> HPLEIGIHPBE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63F7780", Offset = "0x63F6580", VA = "0x1863F7780")]
	public ArraySegment<byte> NNDJDNJKGBO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x63F6110", Offset = "0x63F4F10", VA = "0x1863F6110")]
	public bool EPMGDDANFOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x63F7020", Offset = "0x63F5E20", VA = "0x1863F7020")]
	private static bool JECKLMBAFGC(byte MFEFOKLBOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x63F5130", Offset = "0x63F3F30", VA = "0x1863F5130")]
	private void BBKLBLNOMPD(IHIPGOPOPIJ PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63F71E0", Offset = "0x63F5FE0", VA = "0x1863F71E0")]
	public void KDFEDAAELJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63F4FD0", Offset = "0x63F3DD0", VA = "0x1863F4FD0")]
	private void APNLGNOGHEA(int LKOIKNDNNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63F6C80", Offset = "0x63F5A80", VA = "0x1863F6C80")]
	public sbyte IEJFEPNMPFD()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63F68F0", Offset = "0x63F56F0", VA = "0x1863F68F0")]
	public short HLOBNBKHHFH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63F74E0", Offset = "0x63F62E0", VA = "0x1863F74E0")]
	public int MFNKFJODCOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63F75F0", Offset = "0x63F63F0", VA = "0x1863F75F0")]
	public long NBMBDNIPPID()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63F6090", Offset = "0x63F4E90", VA = "0x1863F6090")]
	public byte EMJADNLPCKD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63F5430", Offset = "0x63F4230", VA = "0x1863F5430")]
	public ushort CCNOLHDGMLM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63F5EF0", Offset = "0x63F4CF0", VA = "0x1863F5EF0")]
	public uint DOFJEBNDKJC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63F6830", Offset = "0x63F5630", VA = "0x1863F6830")]
	public ulong GNOOFOJHPDC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63F70E0", Offset = "0x63F5EE0", VA = "0x1863F70E0")]
	public float JLCFOBGFFAJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x63F6360", Offset = "0x63F5160", VA = "0x1863F6360")]
	public double FIANPOMLGCI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x63F73E0", Offset = "0x63F61E0", VA = "0x1863F73E0")]
	public ArraySegment<byte> LIELPCFAGEA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63F4E60", Offset = "0x63F3C60", VA = "0x1863F4E60")]
	private static int AKLKKICANON(byte[] AFIEJCAINEM, int HLAIJKBFIJH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PFNGAKCIHGG : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference OHCDLLOFPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int NCLOGDDEJAP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FLEHAKPGOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAE1D20", Offset = "0xAE0B20", VA = "0x180AE1D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string PKKMMHAOIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89B2F0", Offset = "0x89A0F0", VA = "0x18089B2F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63F4420", Offset = "0x63F3220", VA = "0x1863F4420")]
	public PFNGAKCIHGG(string JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x63F4480", Offset = "0x63F3280", VA = "0x1863F4480")]
	public PFNGAKCIHGG(string JIGBFCEILIK, byte[] AECHOPAPLFE, int HLAIJKBFIJH, int NCLOGDDEJAP, string LACBLBHEPEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IKKDIEHFJJL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class KJKJGPCAEIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] BKOBMCKFFFH;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63E6F50", Offset = "0x63E5D50", VA = "0x1863E6F50")]
		public static byte[] BOHCMJDGGDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class DCCKAIHHMGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void DLEJKHPMCBF(LKJMGENIDLC LCMOFCIALJC, object GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object IBOBINICMKE(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK PDDCFBMOHPA);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class MGCOPNLIFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class DBOGPMDAJCN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
				public DBOGPMDAJCN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3B28260", Offset = "0x3B27060", VA = "0x183B28260")]
				internal bool DLCJKBGCLGI(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x63E08C0", Offset = "0x63DF6C0", VA = "0x1863E08C0")]
				internal bool HKLKBPEGNCM(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, LHGMBMDOIPK, byte[]> KFIEPOEDAMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, LHGMBMDOIPK> JCAJIKCGMAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly DLEJKHPMCBF CEBLJFBFGCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, LHGMBMDOIPK, ArraySegment<byte>> GKGOCBCCKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, LHGMBMDOIPK, string> LBNMJDALIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, LHGMBMDOIPK, object> KDNIMGJKMLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, LHGMBMDOIPK, object> JBFNECNHFIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, LHGMBMDOIPK, object> IMNBLDIOMAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly IBOBINICMKE BIBOPIBAIFB;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x63F0EA0", Offset = "0x63EFCA0", VA = "0x1863F0EA0")]
			public MGCOPNLIFNJ(Type PEMNIEMPPLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x297F550", Offset = "0x297E350", VA = "0x18297F550")]
			private static T DEPPNEHBEJB<T>(DynamicMethod IEDFBPPMLBP)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x63F0C50", Offset = "0x63EFA50", VA = "0x1863F0C50")]
			private static MethodInfo JMMENIGDALD(Type PEMNIEMPPLO, string ONIBECKLJDD, Type[] KMBPIBGDPOA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, MGCOPNLIFNJ> BILHHMEFMOJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly AFPFBCGCJDO<MGCOPNLIFNJ> LDCINMILOOA;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63E0D90", Offset = "0x63DFB90", VA = "0x1863E0D90")]
		static DCCKAIHHMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63E0A80", Offset = "0x63DF880", VA = "0x1863E0A80")]
		private static MGCOPNLIFNJ BJKELHJLJDH(Type PEMNIEMPPLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63E0C10", Offset = "0x63DFA10", VA = "0x1863E0C10")]
		public static void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, object GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63E0B00", Offset = "0x63DF900", VA = "0x1863E0B00")]
		public static void GKMCGBDALGF(Type PEMNIEMPPLO, LKJMGENIDLC LCMOFCIALJC, object GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static LHGMBMDOIPK DNHNHKANKPP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] BJDNGGHFEKE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] ACCEKOOJHLO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static LHGMBMDOIPK IDDKDGGFHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63E5730", Offset = "0x63E4530", VA = "0x1863E5730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63E5830", Offset = "0x63E4630", VA = "0x1863E5830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x63E5890", Offset = "0x63E4690", VA = "0x1863E5890")]
	public static void IDFGCHJMDPP(LHGMBMDOIPK PDDCFBMOHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x23A5100", Offset = "0x23A3F00", VA = "0x1823A5100")]
	public static byte[] GKMCGBDALGF<T>(T HBDENJGMDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23A52C0", Offset = "0x23A40C0", VA = "0x1823A52C0")]
	public static byte[] GKMCGBDALGF<T>(T GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x23A5070", Offset = "0x23A3E70", VA = "0x1823A5070")]
	public static void GKMCGBDALGF<T>(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x23A4F00", Offset = "0x23A3D00", VA = "0x1823A4F00")]
	public static void GKMCGBDALGF<T>(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x23A4FE0", Offset = "0x23A3DE0", VA = "0x1823A4FE0")]
	public static void GKMCGBDALGF<T>(Stream MMGOENDACIH, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x23A5180", Offset = "0x23A3F80", VA = "0x1823A5180")]
	public static void GKMCGBDALGF<T>(Stream MMGOENDACIH, T GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23A4CE0", Offset = "0x23A3AE0", VA = "0x1823A4CE0")]
	public static ArraySegment<byte> FNAJIJMGPEK<T>(T HBDENJGMDDF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x23A4D70", Offset = "0x23A3B70", VA = "0x1823A4D70")]
	public static ArraySegment<byte> FNAJIJMGPEK<T>(T GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23A0940", Offset = "0x239F740", VA = "0x1823A0940")]
	public static string BOOLHBEBFEM<T>(T GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x23A07C0", Offset = "0x239F5C0", VA = "0x1823A07C0")]
	public static string BOOLHBEBFEM<T>(T GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x23A1A90", Offset = "0x23A0890", VA = "0x1823A1A90")]
	public static T EFHLMHLMFOG<T>(string IAIIOOGKNOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23A1B20", Offset = "0x23A0920", VA = "0x1823A1B20")]
	public static T EFHLMHLMFOG<T>(string IAIIOOGKNOF, LHGMBMDOIPK PDDCFBMOHPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23A2260", Offset = "0x23A1060", VA = "0x1823A2260")]
	public static T EFHLMHLMFOG<T>(byte[] AFIEJCAINEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x23A1A00", Offset = "0x23A0800", VA = "0x1823A1A00")]
	public static T EFHLMHLMFOG<T>(byte[] AFIEJCAINEM, LHGMBMDOIPK PDDCFBMOHPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23A2010", Offset = "0x23A0E10", VA = "0x1823A2010")]
	public static T EFHLMHLMFOG<T>(byte[] AFIEJCAINEM, int HLAIJKBFIJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x23A1C10", Offset = "0x23A0A10", VA = "0x1823A1C10")]
	public static T EFHLMHLMFOG<T>(byte[] AFIEJCAINEM, int HLAIJKBFIJH, LHGMBMDOIPK PDDCFBMOHPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23A2480", Offset = "0x23A1280", VA = "0x1823A2480")]
	public static T EFHLMHLMFOG<T>(PLNICAEBGII POOKDLGIHHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23A22E0", Offset = "0x23A10E0", VA = "0x1823A22E0")]
	public static T EFHLMHLMFOG<T>(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK PDDCFBMOHPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x23A21E0", Offset = "0x23A0FE0", VA = "0x1823A21E0")]
	public static T EFHLMHLMFOG<T>(Stream MMGOENDACIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23A20A0", Offset = "0x23A0EA0", VA = "0x1823A20A0")]
	public static T EFHLMHLMFOG<T>(Stream MMGOENDACIH, LHGMBMDOIPK PDDCFBMOHPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x63E5E20", Offset = "0x63E4C20", VA = "0x1863E5E20")]
	public static string NFDHCECDHCG(byte[] IAIIOOGKNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x63E6110", Offset = "0x63E4F10", VA = "0x1863E6110")]
	public static string NFDHCECDHCG(byte[] IAIIOOGKNOF, int HLAIJKBFIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x63E5F80", Offset = "0x63E4D80", VA = "0x1863E5F80")]
	public static string NFDHCECDHCG(string IAIIOOGKNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x63E59A0", Offset = "0x63E47A0", VA = "0x1863E59A0")]
	public static byte[] JDJMGKJGJOJ(byte[] IAIIOOGKNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x63E5B20", Offset = "0x63E4920", VA = "0x1863E5B20")]
	public static byte[] JDJMGKJGJOJ(byte[] IAIIOOGKNOF, int HLAIJKBFIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x63E5C70", Offset = "0x63E4A70", VA = "0x1863E5C70")]
	public static byte[] JDJMGKJGJOJ(string IAIIOOGKNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x63E4E60", Offset = "0x63E3C60", VA = "0x1863E4E60")]
	private static void CHNMCOFACFA(PLNICAEBGII POOKDLGIHHA, LKJMGENIDLC LCMOFCIALJC, int LHFEFLHGBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x63E5900", Offset = "0x63E4700", VA = "0x1863E5900")]
	private static int IPGNGJEFLJE(Stream ENGEPLNNBDC, byte[] BKOBMCKFFFH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IHIPGOPOPIJ : byte
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
public struct LKJMGENIDLC
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] JEGMOCAEHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] BKOBMCKFFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int HLAIJKBFIJH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HHJOOAKOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C3FD50", Offset = "0x1C3EB50", VA = "0x181C3FD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x63E8400", Offset = "0x63E7200", VA = "0x1863E8400")]
	public void PLCMOAFMFNF(int HLAIJKBFIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63E7DC0", Offset = "0x63E6BC0", VA = "0x1863E7DC0")]
	public static byte[] JIINHDJIAMG(string COPMFEAGFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x63E71A0", Offset = "0x63E5FA0", VA = "0x1863E71A0")]
	public static byte[] CIIDNMGHFNO(string COPMFEAGFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x63E8080", Offset = "0x63E6E80", VA = "0x1863E8080")]
	public static byte[] LPNFDHGCENJ(string COPMFEAGFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x63E7940", Offset = "0x63E6740", VA = "0x1863E7940")]
	public static byte[] IEILNJMLPDO(string COPMFEAGFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x526F220", Offset = "0x526E020", VA = "0x18526F220")]
	public LKJMGENIDLC(byte[] CIICGCFBEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x63E7100", Offset = "0x63E5F00", VA = "0x1863E7100")]
	public ArraySegment<byte> BOHCMJDGGDC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x63E7D50", Offset = "0x63E6B50", VA = "0x1863E7D50")]
	public byte[] JFDILHGOONH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x63E8410", Offset = "0x63E7210", VA = "0x1863E8410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63E7F30", Offset = "0x63E6D30", VA = "0x1863E7F30")]
	public void KCJNPBICOGD(int NLHGIBGJGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63E7C20", Offset = "0x63E6A20", VA = "0x1863E7C20")]
	public void INJFPAEIIGH(byte CMLFIMGILGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63E7C80", Offset = "0x63E6A80", VA = "0x1863E7C80")]
	public void INJFPAEIIGH(byte[] CMLFIMGILGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63E7EF0", Offset = "0x63E6CF0", VA = "0x1863E7EF0")]
	public void JNCMACNEJKK(byte CMLFIMGILGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63E8240", Offset = "0x63E7040", VA = "0x1863E8240")]
	public void NEGPOLIEKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x63E81F0", Offset = "0x63E6FF0", VA = "0x1863E81F0")]
	public void NAPFJNLHIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x63E7360", Offset = "0x63E6160", VA = "0x1863E7360")]
	public void DCPKIJBIPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63E74F0", Offset = "0x63E62F0", VA = "0x1863E74F0")]
	public void FMAHONBBBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63E7310", Offset = "0x63E6110", VA = "0x1863E7310")]
	public void DBLOJKJNNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x63E74A0", Offset = "0x63E62A0", VA = "0x1863E74A0")]
	public void ELMPFFPCCEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x63E7060", Offset = "0x63E5E60", VA = "0x1863E7060")]
	public void BOBCOICMLGN(string COPMFEAGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x63E83B0", Offset = "0x63E71B0", VA = "0x1863E83B0")]
	public void OMDJDKGDMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63E7F70", Offset = "0x63E6D70", VA = "0x1863E7F70")]
	public void KJEMLFJBCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x63E7AC0", Offset = "0x63E68C0", VA = "0x1863E7AC0")]
	public void INAIIGPEKOK(bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63E7420", Offset = "0x63E6220", VA = "0x1863E7420")]
	public void ECJIKLIEJHK(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63E82C0", Offset = "0x63E70C0", VA = "0x1863E82C0")]
	public void NJNNFKEFFNM(double GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x63E73B0", Offset = "0x63E61B0", VA = "0x1863E73B0")]
	public void DPKEDJEPFIH(byte GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x63E8340", Offset = "0x63E7140", VA = "0x1863E8340")]
	public void OGENKFJPICD(ushort GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63E78D0", Offset = "0x63E66D0", VA = "0x1863E78D0")]
	public void GCBCHICLGFH(uint GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x63E7F40", Offset = "0x63E6D40", VA = "0x1863E7F40")]
	public void KGIFBGJIBFJ(ulong GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x63E6FF0", Offset = "0x63E5DF0", VA = "0x1863E6FF0")]
	public void AHDDBIILIOJ(sbyte GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63E8010", Offset = "0x63E6E10", VA = "0x1863E8010")]
	public void LOCNHKNPAHA(short GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63E7CE0", Offset = "0x63E6AE0", VA = "0x1863E7CE0")]
	public void JAIKNJJHFFB(int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63E8290", Offset = "0x63E7090", VA = "0x1863E8290")]
	public void NGOEAMCGACG(long GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x63E7540", Offset = "0x63E6340", VA = "0x1863E7540")]
	public void FPMADIPKCBC(string GNLEHBFFNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CGGPILJKLJH : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class NCNABJNJLEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3BC28A0", Offset = "0x3BC16A0", VA = "0x183BC28A0")]
		static NCNABJNJLEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private CGGPILJKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class PDBFIBLDDJO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> LJGEDKAINBF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63F3F30", Offset = "0x63F2D30", VA = "0x1863F3F30")]
	static PDBFIBLDDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63F3740", Offset = "0x63F2540", VA = "0x1863F3740")]
	internal static object APDEGKGPLBA(Type MOEPCGBEMKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class DNIEPKPJNPH : KHFNPOBDEKJ<Vector2>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GGDFLHOFOKL DBOJIMEHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] JOPDACLGPLG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x63E13C0", Offset = "0x63E01C0", VA = "0x1863E13C0")]
	public DNIEPKPJNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x63E11D0", Offset = "0x63DFFD0", VA = "0x1863E11D0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Vector2 GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x63E0EE0", Offset = "0x63DFCE0", VA = "0x1863E0EE0", Slot = "5")]
	public Vector2 EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class PIDODIJNOJI : KHFNPOBDEKJ<Vector3>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GGDFLHOFOKL DBOJIMEHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] JOPDACLGPLG;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x63F4B60", Offset = "0x63F3960", VA = "0x1863F4B60")]
	public PIDODIJNOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x63F48C0", Offset = "0x63F36C0", VA = "0x1863F48C0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Vector3 GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x63F4570", Offset = "0x63F3370", VA = "0x1863F4570", Slot = "5")]
	public Vector3 EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class BBEJPCKFDHO : KHFNPOBDEKJ<Vector4>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GGDFLHOFOKL DBOJIMEHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] JOPDACLGPLG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x63DC6B0", Offset = "0x63DB4B0", VA = "0x1863DC6B0")]
	public BBEJPCKFDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x63DC370", Offset = "0x63DB170", VA = "0x1863DC370", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Vector4 GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x63DBFE0", Offset = "0x63DADE0", VA = "0x1863DBFE0", Slot = "5")]
	public Vector4 EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class IDONOMPPDBM : KHFNPOBDEKJ<Quaternion>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly GGDFLHOFOKL DBOJIMEHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] JOPDACLGPLG;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63E4AF0", Offset = "0x63E38F0", VA = "0x1863E4AF0")]
	public IDONOMPPDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63E47B0", Offset = "0x63E35B0", VA = "0x1863E47B0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Quaternion GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x63E4420", Offset = "0x63E3220", VA = "0x1863E4420", Slot = "5")]
	public Quaternion EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FICKGACDNDK : KHFNPOBDEKJ<Color>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GGDFLHOFOKL DBOJIMEHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] JOPDACLGPLG;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x63E1CF0", Offset = "0x63E0AF0", VA = "0x1863E1CF0")]
	public FICKGACDNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x63E19B0", Offset = "0x63E07B0", VA = "0x1863E19B0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Color GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x63E1620", Offset = "0x63E0420", VA = "0x1863E1620", Slot = "5")]
	public Color EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NJLNEDOLMMD : KHFNPOBDEKJ<Bounds>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GGDFLHOFOKL DBOJIMEHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] JOPDACLGPLG;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x63F3310", Offset = "0x63F2110", VA = "0x1863F3310")]
	public NJLNEDOLMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x63F2FF0", Offset = "0x63F1DF0", VA = "0x1863F2FF0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Bounds GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x63F2C10", Offset = "0x63F1A10", VA = "0x1863F2C10", Slot = "5")]
	public Bounds EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class ANFANPJLMIC : KHFNPOBDEKJ<Rect>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GGDFLHOFOKL DBOJIMEHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] JOPDACLGPLG;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x63DBBF0", Offset = "0x63DA9F0", VA = "0x1863DBBF0")]
	public ANFANPJLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x63DB880", Offset = "0x63DA680", VA = "0x1863DB880", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Rect GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x63DB490", Offset = "0x63DA290", VA = "0x1863DB490", Slot = "5")]
	public Rect EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class IFLPDCMJGCO : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class HIOOCEOMHPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3594850", Offset = "0x3593650", VA = "0x183594850")]
		static HIOOCEOMHPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private IFLPDCMJGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class EAOPGAIJJCO : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class DHKDBEIPENM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4CD9A80", Offset = "0x4CD8880", VA = "0x184CD9A80")]
		static DHKDBEIPENM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class GDCNIJMLDIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> HJJONBDOPBK;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x63E23B0", Offset = "0x63E11B0", VA = "0x1863E23B0")]
		internal static object APDEGKGPLBA(Type MOEPCGBEMKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private EAOPGAIJJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class JPLEGAKMACC : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class DNGINJIFEIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4D186F0", Offset = "0x4D174F0", VA = "0x184D186F0")]
		static DNGINJIFEIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JPLEGAKMACC GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool HMCHCNFFFEB;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static NHMDNCPBKML[] EBODFJDDDMA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static LHGMBMDOIPK[] FOMJJFDBADJ;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private JPLEGAKMACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x63E67E0", Offset = "0x63E55E0", VA = "0x1863E67E0")]
	public static void MCJJKKHGDCC(params LHGMBMDOIPK[] FOMJJFDBADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x63E68C0", Offset = "0x63E56C0", VA = "0x1863E68C0")]
	public static void MCJJKKHGDCC(params NHMDNCPBKML[] EBODFJDDDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x63E6550", Offset = "0x63E5350", VA = "0x1863E6550")]
	public static void FIDAIAKBOAH(NHMDNCPBKML[] EBODFJDDDMA, LHGMBMDOIPK[] FOMJJFDBADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class OKACCACEMCG : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class CNLINNFPGDM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B38CB0", Offset = "0x4B37AB0", VA = "0x184B38CB0")]
		static CNLINNFPGDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private OKACCACEMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LPCOFJIDGLB
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LHGMBMDOIPK BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly LHGMBMDOIPK ONABEKDFFMH;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly LHGMBMDOIPK AJLAOONEDHF;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly LHGMBMDOIPK JPNCECBKPBK;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly LHGMBMDOIPK LOEALJKDDNE;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly LHGMBMDOIPK DOLENIKAFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly LHGMBMDOIPK DFAKMOPPLMP;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly LHGMBMDOIPK DKKJHCGNOGN;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly LHGMBMDOIPK GHBKLALKFHI;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly LHGMBMDOIPK JKLHFKLMOFH;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly LHGMBMDOIPK OOEJBNIEGAH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly LHGMBMDOIPK IBIHFEKLOKB;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class BKPJGACPBIO
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly LHGMBMDOIPK BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LHGMBMDOIPK GGBHKENPDJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KDDIFFBFEAD
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly LHGMBMDOIPK BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly LHGMBMDOIPK ONABEKDFFMH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly LHGMBMDOIPK AJLAOONEDHF;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly LHGMBMDOIPK JPNCECBKPBK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly LHGMBMDOIPK LOEALJKDDNE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly LHGMBMDOIPK DOLENIKAFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly LHGMBMDOIPK DFAKMOPPLMP;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly LHGMBMDOIPK DKKJHCGNOGN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly LHGMBMDOIPK GHBKLALKFHI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly LHGMBMDOIPK JKLHFKLMOFH;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly LHGMBMDOIPK OOEJBNIEGAH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly LHGMBMDOIPK IBIHFEKLOKB;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CBOJLLFDAGF
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> HJJONBDOPBK;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x63DEA50", Offset = "0x63DD850", VA = "0x1863DEA50")]
	internal static object APDEGKGPLBA(Type MOEPCGBEMKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63E01B0", Offset = "0x63DEFB0", VA = "0x1863E01B0")]
	private static object MCGCLNAKPGJ(Type PJIPDHMFDGG, Type[] FPMFLNGDIHE, params object[] KMBPIBGDPOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BFCPKOJLHGC : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class CAPDMIMAKHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x464A8F0", Offset = "0x46496F0", VA = "0x18464A8F0")]
		static CAPDMIMAKHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly NFDEPFBGIKE BBAEHNOIGCO;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x63DE590", Offset = "0x63DD390", VA = "0x1863DE590")]
	static BFCPKOJLHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private BFCPKOJLHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JNDFDPONDGN : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class MICOOLKDEKK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FB00", Offset = "0x3B2E900", VA = "0x183B2FB00")]
		static MICOOLKDEKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly NFDEPFBGIKE BBAEHNOIGCO;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x63E63E0", Offset = "0x63E51E0", VA = "0x1863E63E0")]
	static JNDFDPONDGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private JNDFDPONDGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class FIDLPIDJFAM : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class KCMCJPKHPHK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x387C6B0", Offset = "0x387B4B0", VA = "0x18387C6B0")]
		static KCMCJPKHPHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly NFDEPFBGIKE BBAEHNOIGCO;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x63E1FE0", Offset = "0x63E0DE0", VA = "0x1863E1FE0")]
	static FIDLPIDJFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private FIDLPIDJFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class MJKDJBPGMJK : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class EPFCFJCMBDD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x308BA70", Offset = "0x308A870", VA = "0x18308BA70")]
		static EPFCFJCMBDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly NFDEPFBGIKE BBAEHNOIGCO;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x63F29A0", Offset = "0x63F17A0", VA = "0x1863F29A0")]
	static MJKDJBPGMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private MJKDJBPGMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class OOPHJADFIHA : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class GFKADHAEFPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x34AAE60", Offset = "0x34A9C60", VA = "0x1834AAE60")]
		static GFKADHAEFPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly NFDEPFBGIKE BBAEHNOIGCO;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x63F35D0", Offset = "0x63F23D0", VA = "0x1863F35D0")]
	static OOPHJADFIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private OOPHJADFIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class BOOHINIAABE : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class HBAIOOMPMFJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x355D9E0", Offset = "0x355C7E0", VA = "0x18355D9E0")]
		static HBAIOOMPMFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly NFDEPFBGIKE BBAEHNOIGCO;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x63DE8E0", Offset = "0x63DD6E0", VA = "0x1863DE8E0")]
	static BOOHINIAABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private BOOHINIAABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class CHGJJHAAIMF : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class DJCDGHICMIA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4CEAE40", Offset = "0x4CE9C40", VA = "0x184CEAE40")]
		static DJCDGHICMIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CHGJJHAAIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class HFPMNNANNIK : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class NJLDLFONIMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6910", Offset = "0x3BD5710", VA = "0x183BD6910")]
		static NJLDLFONIMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HFPMNNANNIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class BLNCLCCEMIJ : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class CNLAIDHGCAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4B34BF0", Offset = "0x4B339F0", VA = "0x184B34BF0")]
		static CNLAIDHGCAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BLNCLCCEMIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class FLEEMHIMJIJ : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class DPDFIJOOGHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4D25770", Offset = "0x4D24570", VA = "0x184D25770")]
		static DPDFIJOOGHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FLEEMHIMJIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class NELIFGPPBLF : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class JEOOCOBKMNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x381AA50", Offset = "0x3819850", VA = "0x18381AA50")]
		static JEOOCOBKMNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NELIFGPPBLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class APPHCIFOBFJ : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class KCGAIBIJKAF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x38751A0", Offset = "0x3873FA0", VA = "0x1838751A0")]
		static KCGAIBIJKAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> FHAJANJIHGA;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool BHDDDOLPNDH;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public APPHCIFOBFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class LNEIEBIGBHL
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct MOLAJBNNJHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FFMBFHIACNJ KCOLPOBBPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder HAMHBMCJDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder NGCKLCFDILN;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class BCBBJCBINPD
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class IEMECFLKMOB
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo LPNFDHGCENJ;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo CIIDNMGHFNO;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo IEILNJMLPDO;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo JIINHDJIAMG;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo KJEMLFJBCBM;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo INJFPAEIIGH;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo DCPKIJBIPDC;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo FMAHONBBBIL;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo DBLOJKJNNDI;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6401BE0", Offset = "0x64009E0", VA = "0x186401BE0")]
			static IEMECFLKMOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class DJMGJPONGKF
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo JALEPBJJCMC;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo JBFKAGADIFN;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo NFHEJOGDCBB;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo FPHGAEINJED;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo KDFEDAAELJF;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo EEOICHICDAP;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo GJCFCEJFOAJ;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x63FC150", Offset = "0x63FAF50", VA = "0x1863FC150")]
			static DJMGJPONGKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class BJICOCGDNOL
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo LJACCJKFNLM;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo DNLGDPHDCHA;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo JMIIIKCINIG;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo IPFAGEKCJCA;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo EINAOBALPHI;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo LBBKMPAPHLI;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo DCCGMALHIML;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo JIDPOCCOOGE;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo ABBEMGIGILP;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo MLIEAKEIBBF;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo GBMDIGMBEGC;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo ABJAAAGAPLJ;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo DLJEHFCABLH;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo CLHBIHDCKCD;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x63DCBE0", Offset = "0x63DB9E0", VA = "0x1863DCBE0")]
		public static MethodInfo GKMCGBDALGF(Type PEMNIEMPPLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x63DC9A0", Offset = "0x63DB7A0", VA = "0x1863DC9A0")]
		public static MethodInfo EFHLMHLMFOG(Type PEMNIEMPPLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x63DCE70", Offset = "0x63DBC70", VA = "0x1863DCE70")]
		public static MethodInfo NCJDBKLGCKA(Type PEMNIEMPPLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class DMMMGPJHOOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<FFMBFHIACNJ, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DMMMGPJHOOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LJBNDDJMLNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public DMMMGPJHOOF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LJBNDDJMLNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6407940", Offset = "0x6406740", VA = "0x186407940")]
		internal void HDDIKKCPJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x64077E0", Offset = "0x64065E0", VA = "0x1864077E0")]
		internal bool BANFJINJCCG(int index, FFMBFHIACNJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class MEBLFMNFFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public DMMMGPJHOOF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MEBLFMNFFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x64093C0", Offset = "0x64081C0", VA = "0x1864093C0")]
		internal bool PFBENKOJPOB(int index, FFMBFHIACNJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FBJHFOOIHMA
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

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public FBJHFOOIHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3B22E30", Offset = "0x3B21C30", VA = "0x183B22E30")]
		internal string OHLBMABAJLP(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class MOLJOPACPCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MOLJOPACPCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6409520", Offset = "0x6408320", VA = "0x186409520")]
		internal bool JLKMHICHHDI(FFMBFHIACNJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class GIIBBBECOIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FBJHFOOIHMA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GIIBBBECOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6400210", Offset = "0x63FF010", VA = "0x186400210")]
		internal void HBNNDNGHMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6400290", Offset = "0x63FF090", VA = "0x186400290")]
		internal bool OHLHKBBIGHN(int index, FFMBFHIACNJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class EGMKOADBHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public FBJHFOOIHMA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public EGMKOADBHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x63FD570", Offset = "0x63FC370", VA = "0x1863FD570")]
		internal bool BHGADJLBOFG(int index, FFMBFHIACNJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MOEEONLEGGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MOEEONLEGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6400800", Offset = "0x63FF600", VA = "0x186400800")]
		internal Label DJPHEBNPMMG(FFMBFHIACNJ _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FGOAADONCME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public MOLAJBNNJHN[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, FFMBFHIACNJ, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NDPEMKBFAJF argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NDPEMKBFAJF argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public FGOAADONCME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x63FEA60", Offset = "0x63FD860", VA = "0x1863FEA60")]
		internal MOLAJBNNJHN MLNHNAOGENA(FFMBFHIACNJ item)
		{
			return default(MOLAJBNNJHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KHBEKACIKJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public FGOAADONCME CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public KHBEKACIKJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x64071D0", Offset = "0x6405FD0", VA = "0x1864071D0")]
		internal void PMFOCLOBKJO(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6407130", Offset = "0x6405F30", VA = "0x186407130")]
		internal void BIHMAOLHOIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class KJFOKPNENNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public FFMBFHIACNJ item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public KJFOKPNENNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA6B640", Offset = "0xA6A440", VA = "0x180A6B640")]
		internal bool NFPJHDELKMD(MOLAJBNNJHN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class GIHOOGNJLOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FFMBFHIACNJ item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GIHOOGNJLOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA6B640", Offset = "0xA6A440", VA = "0x180A6B640")]
		internal bool BADJMMBJDJC(MOLAJBNNJHN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex BFMFLPGEHBN;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int FKNLPOKPAPG;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> JCHIDECBKEO;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> FGFCICIFBJE;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x24225B0", Offset = "0x24213B0", VA = "0x1824225B0")]
	public static object AGKDCENOOJC<T>(NFDEPFBGIKE BBAEHNOIGCO, LHGMBMDOIPK DDNGNCIHNDE, Func<string, string> FHAJANJIHGA, bool BHDDDOLPNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2430440", Offset = "0x242F240", VA = "0x182430440")]
	public static object IPLJGONIEMM<T>(LHGMBMDOIPK DDNGNCIHNDE, Func<string, string> FHAJANJIHGA, bool BHDDDOLPNDH, bool MHDDKJJOOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x63ED550", Offset = "0x63EC350", VA = "0x1863ED550")]
	private static TypeInfo JBMOKKNPAGD(NFDEPFBGIKE BBAEHNOIGCO, Type PEMNIEMPPLO, Func<string, string> FHAJANJIHGA, bool BHDDDOLPNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x63E9810", Offset = "0x63E8610", VA = "0x1863E9810")]
	public static object BIJMBLCOEAP(Type PEMNIEMPPLO, Func<string, string> FHAJANJIHGA, bool BHDDDOLPNDH, bool MHDDKJJOOFE, bool HAKIHLCHIMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x63EFA20", Offset = "0x63EE820", VA = "0x1863EFA20")]
	private static Dictionary<FFMBFHIACNJ, FieldInfo> OBJIMGMNPOF(TypeBuilder OAKGNGJJGBM, PKFEEBKJIAC NAFGFKPNMPM, ConstructorInfo CCMGHFPGKGP, FieldBuilder MAGIOIPPHCO, ILGenerator JIKPJEMPBJP, bool BHDDDOLPNDH, bool EFKKHKDKLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x63EC0D0", Offset = "0x63EAED0", VA = "0x1863EC0D0")]
	private static Dictionary<FFMBFHIACNJ, FieldInfo> EDKDDEGDDAF(TypeBuilder OAKGNGJJGBM, PKFEEBKJIAC NAFGFKPNMPM, ILGenerator JIKPJEMPBJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x63EDF70", Offset = "0x63ECD70", VA = "0x1863EDF70")]
	private static void LILGCFNLPNI(Type PEMNIEMPPLO, PKFEEBKJIAC NAFGFKPNMPM, ILGenerator JIKPJEMPBJP, Action CNPOJACGMLH, Func<int, FFMBFHIACNJ, bool> JMGLEMJBCGA, bool BHDDDOLPNDH, bool EFKKHKDKLOB, int CCLIIKIOILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x63ED010", Offset = "0x63EBE10", VA = "0x1863ED010")]
	private static void JABICLGDOEN(TypeInfo PEMNIEMPPLO, FFMBFHIACNJ KDDAFEKBGJG, ILGenerator JIKPJEMPBJP, int DOJILIOCHKM, Func<int, FFMBFHIACNJ, bool> JMGLEMJBCGA, NDPEMKBFAJF LCMOFCIALJC, NDPEMKBFAJF PKEMIGODJJH, NDPEMKBFAJF IOGIPCPDLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x63E84E0", Offset = "0x63E72E0", VA = "0x1863E84E0")]
	private static void BGCJKDKEDGH(Type PEMNIEMPPLO, PKFEEBKJIAC NAFGFKPNMPM, ILGenerator JIKPJEMPBJP, Func<int, FFMBFHIACNJ, bool> JMGLEMJBCGA, bool BNKMFIMALBI, int CCLIIKIOILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x63EF5B0", Offset = "0x63EE3B0", VA = "0x1863EF5B0")]
	private static void MBLPAKHEDOB(ILGenerator JIKPJEMPBJP, MOLAJBNNJHN NAFGFKPNMPM, int DOJILIOCHKM, Func<int, FFMBFHIACNJ, bool> JMGLEMJBCGA, NDPEMKBFAJF POOKDLGIHHA, NDPEMKBFAJF IOGIPCPDLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x63EB340", Offset = "0x63EA140", VA = "0x1863EB340")]
	private static LocalBuilder DOFFFMNLDHN(ILGenerator JIKPJEMPBJP, Type PEMNIEMPPLO, PKFEEBKJIAC NAFGFKPNMPM, MOLAJBNNJHN[] FADLMABAODN, bool ELLMFIHAFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x63EC7B0", Offset = "0x63EB5B0", VA = "0x1863EC7B0")]
	private static bool GEACIJECAEP(ConstructorInfo CBKACAGPECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x63ECE90", Offset = "0x63EBC90", VA = "0x1863ECE90")]
	private static bool HEMPHGEODHI(Type PEMNIEMPPLO, [Out] Type HMOEKOJCIJJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void AMHPBNDLOHD<T>(byte[][] MAGIOIPPHCO, object[] ICKAKOKHBME, LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK PDDCFBMOHPA);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T IONNIIJPMCI<T>(object[] ICKAKOKHBME, PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK PDDCFBMOHPA);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class DAONDOAHOEL<T> : KHFNPOBDEKJ<T>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] MAGIOIPPHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] EJOOFFOIDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] NDJJLADEHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly AMHPBNDLOHD<T> HBGELNOCAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly IONNIIJPMCI<T> JAOIAENJHCN;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1C08C60", Offset = "0x1C07A60", VA = "0x181C08C60")]
	public DAONDOAHOEL(byte[][] MAGIOIPPHCO, object[] EJOOFFOIDFF, object[] NDJJLADEHCM, AMHPBNDLOHD<T> HBGELNOCAJE, IONNIIJPMCI<T> JAOIAENJHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4CB5AC0", Offset = "0x4CB48C0", VA = "0x184CB5AC0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4CB59D0", Offset = "0x4CB47D0", VA = "0x184CB59D0", Slot = "5")]
	public T EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class AGHKICDCABD : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class CFNFIOLPAIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x481E770", Offset = "0x481D570", VA = "0x18481E770")]
		static CFNFIOLPAIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private AGHKICDCABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class OEEPPJEEFLB : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class MKDBPOJHDDE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3B48A20", Offset = "0x3B47820", VA = "0x183B48A20")]
		static MKDBPOJHDDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private OEEPPJEEFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class GNFCPHCPJCG
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly LHGMBMDOIPK[] JFHIFEMNIPE;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class FFIKMMJIEBF : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class LIIBCIHDPOF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x394BC80", Offset = "0x394AA80", VA = "0x18394BC80")]
		static LIIBCIHDPOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class AMOFPAOJEFN : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class LCHDFAKDFMI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3923D90", Offset = "0x3922B90", VA = "0x183923D90")]
			static LCHDFAKDFMI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private AMOFPAOJEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private FFIKMMJIEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class NOPIIPCPOOP : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class DDCDLACGOON<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4CD13B0", Offset = "0x4CD01B0", VA = "0x184CD13B0")]
		static DDCDLACGOON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class CKLINAGEMPJ : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class ICIBKHPPEIN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x36492B0", Offset = "0x36480B0", VA = "0x1836492B0")]
			static ICIBKHPPEIN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private CKLINAGEMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private NOPIIPCPOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class DOLFNKJIGKG : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class CIACOJFOFIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x483DB40", Offset = "0x483C940", VA = "0x18483DB40")]
		static CIACOJFOFIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class NMBNPGOKJKB : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class CJAMCOOLLOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4845A80", Offset = "0x4844880", VA = "0x184845A80")]
			static CJAMCOOLLOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private NMBNPGOKJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private DOLFNKJIGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class IGHIGGDOFML : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class CHNFLBDBFEI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x482C920", Offset = "0x482B720", VA = "0x18482C920")]
		static CHNFLBDBFEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class KDMHPNCJCID : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class EECAKPFOIIA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3026030", Offset = "0x3024E30", VA = "0x183026030")]
			static EECAKPFOIIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private KDMHPNCJCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private IGHIGGDOFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class ONEGBAKNLBJ : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class KFEFJKOPHNH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x388F220", Offset = "0x388E020", VA = "0x18388F220")]
		static KFEFJKOPHNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class ANOBJJGKFBL : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class LCHGFDEEMHI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x39275A0", Offset = "0x39263A0", VA = "0x1839275A0")]
			static LCHGFDEEMHI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private ANOBJJGKFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private ONEGBAKNLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class PHLKLFMDMGP : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class HLHKBNGLMJL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x359EF10", Offset = "0x359DD10", VA = "0x18359EF10")]
		static HLHKBNGLMJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class FCLCBPFJHAK : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class FGMIPDIDMFP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x33D3450", Offset = "0x33D2250", VA = "0x1833D3450")]
			static FGMIPDIDMFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private FCLCBPFJHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private PHLKLFMDMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class IFNPPIKGCKI : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class GMNJPIPJEKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x34D4770", Offset = "0x34D3570", VA = "0x1834D4770")]
		static GMNJPIPJEKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class LCLAAFHFNIO : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class ADJDPKGMMGN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x345D250", Offset = "0x345C050", VA = "0x18345D250")]
			static ADJDPKGMMGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private LCLAAFHFNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private IFNPPIKGCKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class JFPECOLCILB : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class FLMLKPJKDEB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x33FF4E0", Offset = "0x33FE2E0", VA = "0x1833FF4E0")]
		static FLMLKPJKDEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class OGDAFBGEPJA : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class HCJBBNLECAM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x356A340", Offset = "0x3569140", VA = "0x18356A340")]
			static HCJBBNLECAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private OGDAFBGEPJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private JFPECOLCILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class ELHOIOONKPL : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class HOLAIHMKKKM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x35B19A0", Offset = "0x35B07A0", VA = "0x1835B19A0")]
		static HOLAIHMKKKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class JLEIAEPJAPF : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class PEABGKOJDFF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2670", Offset = "0x3DD1470", VA = "0x183DD2670")]
			static PEABGKOJDFF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private JLEIAEPJAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private ELHOIOONKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class LGLJKBHMALG : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class AKMMMLBOEOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3520770", Offset = "0x351F570", VA = "0x183520770")]
		static AKMMMLBOEOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class FAKJIHMHBIE : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class PLCAMEJOEGI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3E0B860", Offset = "0x3E0A660", VA = "0x183E0B860")]
			static PLCAMEJOEGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private FAKJIHMHBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private LGLJKBHMALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class FMOMJBDEDFF : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class OHMKJIKPLLO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D21680", Offset = "0x3D20480", VA = "0x183D21680")]
		static OHMKJIKPLLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class NHFKCJLLBJP : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class DJDLFHHMMFL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4CED480", Offset = "0x4CEC280", VA = "0x184CED480")]
			static DJDLFHHMMFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private NHFKCJLLBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private FMOMJBDEDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class EMPFDNLFKAE : LHGMBMDOIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class DLCJEIHLMFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB240", Offset = "0x4CFA040", VA = "0x184CFB240")]
		static DLCJEIHLMFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class BJCCIFBFICE : LHGMBMDOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class HFENOPBNGBM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly KHFNPOBDEKJ<T> IGPFFIIAKCH;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3576030", Offset = "0x3574E30", VA = "0x183576030")]
			static HFENOPBNGBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly LHGMBMDOIPK GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly LHGMBMDOIPK[] FOMJJFDBADJ;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private BJCCIFBFICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
		public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly LHGMBMDOIPK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly KHFNPOBDEKJ<object> JIMKMIPEGBI;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	private EMPFDNLFKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x216CCC0", Offset = "0x216BAC0", VA = "0x18216CCC0", Slot = "4")]
	public KHFNPOBDEKJ<T> APDEGKGPLBA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct BIFNHDNHDBJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] LPFKOHLOGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int ALAHGBICDEI;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4442A30", Offset = "0x4441830", VA = "0x184442A30")]
	public BIFNHDNHDBJ(int NIOIHADIIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4442710", Offset = "0x4441510", VA = "0x184442710")]
	public void AAFNAGDLNDC(T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x44429A0", Offset = "0x44417A0", VA = "0x1844429A0")]
	public T[] GIICKGMKEON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class JABFFDNNKEM : BMGPCCMNGIE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly JABFFDNNKEM BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6403E50", Offset = "0x6402C50", VA = "0x186403E50")]
	public JABFFDNNKEM(int OEGINJHMGOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class BMGPCCMNGIE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int OEGINJHMGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object NFDDOMCMJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int DOJILIOCHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] FGMKDNIFJJL;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x444B060", Offset = "0x4449E60", VA = "0x18444B060")]
	public BMGPCCMNGIE(int OEGINJHMGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x444A9A0", Offset = "0x44497A0", VA = "0x18444A9A0")]
	public T[] LAJKHOJDCFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x444A820", Offset = "0x4449620", VA = "0x18444A820")]
	public void AHGLLFFGOHP(T[] FNIMPMJDPGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class GGDFLHOFOKL : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class KAPJEDCLCBL : IComparable<KAPJEDCLCBL>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class ANAHGBGJMBI : IEnumerable<KAPJEDCLCBL>, IEnumerable, IEnumerator<KAPJEDCLCBL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private KAPJEDCLCBL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public KAPJEDCLCBL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KAPJEDCLCBL System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
			[DebuggerHidden]
			public ANAHGBGJMBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B40", Offset = "0x63F7940", VA = "0x1863F8B40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C70", Offset = "0x63F7A70", VA = "0x1863F8C70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x63F8BC0", Offset = "0x63F79C0", VA = "0x1863F8BC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KAPJEDCLCBL> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x63F8BC0", Offset = "0x63F79C0", VA = "0x1863F8BC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class HMCKDFBFLDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public HMCKDFBFLDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x6400800", Offset = "0x63FF600", VA = "0x186400800")]
			internal Label CDDLJFALLGB(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x6400800", Offset = "0x63FF600", VA = "0x186400800")]
			internal Label MPMLHLAFBKK(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly KAPJEDCLCBL[] OHNHDDNCBEB;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] PCAOPPLKNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong FPPHOMLMMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int GMPOHOAMMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string HPEAADOHNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private KAPJEDCLCBL[] GJHJNCPNHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] JLDJDDCPOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int HLFCMANHPKF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool NCNOPIJJNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4FB9630", Offset = "0x4FB8430", VA = "0x184FB9630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6406DC0", Offset = "0x6405BC0", VA = "0x186406DC0")]
		public KAPJEDCLCBL(ulong JLDFGFPAIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x64057F0", Offset = "0x64045F0", VA = "0x1864057F0")]
		public KAPJEDCLCBL AAFNAGDLNDC(ulong JLDFGFPAIIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6405790", Offset = "0x6404590", VA = "0x186405790")]
		public KAPJEDCLCBL AAFNAGDLNDC(ulong JLDFGFPAIIN, int GNLEHBFFNFG, string HPEAADOHNLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6405A70", Offset = "0x6404870", VA = "0x186405A70")]
		public KAPJEDCLCBL BCFEEHFLMGJ(byte[] DPGDANDOGFG, int HLAIJKBFIJH, int EJPPONCFGNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6405FA0", Offset = "0x6404DA0", VA = "0x186405FA0")]
		internal static int KFONGKNKMNE(ulong[] FNIMPMJDPGM, int DOJILIOCHKM, int JMNJMKJAMOL, ulong GNLEHBFFNFG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6405BF0", Offset = "0x64049F0", VA = "0x186405BF0", Slot = "4")]
		public int CompareTo(KAPJEDCLCBL MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x64059F0", Offset = "0x64047F0", VA = "0x1864059F0")]
		[IteratorStateMachine(typeof(ANAHGBGJMBI))]
		public IEnumerable<KAPJEDCLCBL> BCCEAEPIOBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6405C20", Offset = "0x6404A20", VA = "0x186405C20")]
		public void DPOLIIDPMJF(ILGenerator JIKPJEMPBJP, LocalBuilder DPGDANDOGFG, LocalBuilder EJPPONCFGNB, LocalBuilder JLDFGFPAIIN, Action<KeyValuePair<string, int>> AFMENECFNNH, Action FBBMBIDFCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6406030", Offset = "0x6404E30", VA = "0x186406030")]
		private static void NHFOGJCKGLH(ILGenerator JIKPJEMPBJP, LocalBuilder DPGDANDOGFG, LocalBuilder EJPPONCFGNB, LocalBuilder JLDFGFPAIIN, Action<KeyValuePair<string, int>> AFMENECFNNH, Action FBBMBIDFCIM, KAPJEDCLCBL[] GJHJNCPNHKB, int HLFCMANHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class JAECAHBHCKP : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private IEnumerable<KAPJEDCLCBL> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<KAPJEDCLCBL> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<KAPJEDCLCBL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private KAPJEDCLCBL <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x955D30", Offset = "0x954B30", VA = "0x180955D30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x64044A0", Offset = "0x64032A0", VA = "0x1864044A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1B32A80", Offset = "0x1B31880", VA = "0x181B32A80")]
		[DebuggerHidden]
		public JAECAHBHCKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x64044F0", Offset = "0x64032F0", VA = "0x1864044F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6403EF0", Offset = "0x6402CF0", VA = "0x186403EF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6403EA0", Offset = "0x6402CA0", VA = "0x186403EA0")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6404350", Offset = "0x6403150", VA = "0x186404350")]
		private void NPKEOFGCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6404450", Offset = "0x6403250", VA = "0x186404450", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x64043A0", Offset = "0x64031A0", VA = "0x1864043A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x64043A0", Offset = "0x64031A0", VA = "0x1864043A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly KAPJEDCLCBL JKEBPOPHOPF;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6400190", Offset = "0x63FEF90", VA = "0x186400190")]
	public GGDFLHOFOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x63FFB20", Offset = "0x63FE920", VA = "0x1863FFB20")]
	public void AAFNAGDLNDC(byte[] AFIEJCAINEM, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x63FFC30", Offset = "0x63FEA30", VA = "0x1863FFC30")]
	public bool ABOGJAOFEHB(ArraySegment<byte> JLDFGFPAIIN, [Out] int GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6400100", Offset = "0x63FEF00", VA = "0x186400100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x63FFD90", Offset = "0x63FEB90", VA = "0x1863FFD90")]
	private static void GAMAEKMBIBJ(IEnumerable<KAPJEDCLCBL> GJHJNCPNHKB, StringBuilder AHDOKECFGPD, int LHFEFLHGBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6400070", Offset = "0x63FEE70", VA = "0x186400070", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6400070", Offset = "0x63FEE70", VA = "0x186400070", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x63FFD10", Offset = "0x63FEB10", VA = "0x1863FFD10")]
	[IteratorStateMachine(typeof(JAECAHBHCKP))]
	private static IEnumerable<KeyValuePair<string, int>> DGIKAMLANOK(IEnumerable<KAPJEDCLCBL> GJHJNCPNHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x64000D0", Offset = "0x63FEED0", VA = "0x1864000D0")]
	public void LPBCBDKDPID(ILGenerator JIKPJEMPBJP, LocalBuilder DPGDANDOGFG, LocalBuilder EJPPONCFGNB, LocalBuilder JLDFGFPAIIN, Action<KeyValuePair<string, int>> AFMENECFNNH, Action FBBMBIDFCIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class JOPJMIACCMA
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo HMLEHOBFBHJ;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6404B70", Offset = "0x6403970", VA = "0x186404B70")]
	public static ulong BDOKPCAKPOF(byte[] AFIEJCAINEM, int HLAIJKBFIJH, int EJPPONCFGNB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class OKJMJILOMBM
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x640D3E0", Offset = "0x640C1E0", VA = "0x18640D3E0")]
	public static void KCJNPBICOGD(byte[] AFIEJCAINEM, int HLAIJKBFIJH, int NLHGIBGJGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x640D2C0", Offset = "0x640C0C0", VA = "0x18640D2C0")]
	public static void JGPKGDADCNN(byte[] FNIMPMJDPGM, int HJIJELOHDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x640D520", Offset = "0x640C320", VA = "0x18640D520")]
	public static byte[] LKDGCDHDICP(byte[] PKELBKGJAFM, int HJIJELOHDKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class CNBBJPGPPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x63FC0E0", Offset = "0x63FAEE0", VA = "0x1863FC0E0")]
	public static bool PILEKNKGKOK(byte[] MACMHIOKKAK, int CFABCIEMPHL, int LFGOFHGKCLI, byte[] LILLDCFCJED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class AFIFOONIMKF<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct IADFLJJJPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] FPPHOMLMMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T GMPOHOAMMIO;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x363D6D0", Offset = "0x363C4D0", VA = "0x18363D6D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class KPIIJKGEKKB : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AFIFOONIMKF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private IADFLJJJPFO[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private IADFLJJJPFO[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x955D30", Offset = "0x954B30", VA = "0x180955D30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x33B8AE0", Offset = "0x33B78E0", VA = "0x1833B8AE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public KPIIJKGEKKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x38B0780", Offset = "0x38AF580", VA = "0x1838B0780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x38B22F0", Offset = "0x38B10F0", VA = "0x1838B22F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly IADFLJJJPFO[][] BDHMKLAEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong MODPCBGOBAG;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x346D350", Offset = "0x346C150", VA = "0x18346D350")]
	public AFIFOONIMKF(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x346D370", Offset = "0x346C170", VA = "0x18346D370")]
	public AFIFOONIMKF(int DECKGNHFLHF, float ABHIKELKCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3463FB0", Offset = "0x3462DB0", VA = "0x183463FB0")]
	public void AAFNAGDLNDC(byte[] JLDFGFPAIIN, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x34682D0", Offset = "0x34670D0", VA = "0x1834682D0")]
	private bool GLPKLBDCJFH(byte[] JLDFGFPAIIN, T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x346B260", Offset = "0x346A060", VA = "0x18346B260")]
	public bool PGDPBMGNNCL(ArraySegment<byte> JLDFGFPAIIN, [Out] T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x346A0D0", Offset = "0x3468ED0", VA = "0x18346A0D0")]
	private static ulong ONEJFAKABME(byte[] HOELCINBFKH, int HLAIJKBFIJH, int HLFCMANHPKF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3464EE0", Offset = "0x3463CE0", VA = "0x183464EE0")]
	private static int BDIONBGFJPD(int NAGNLNLFBJO, float ABHIKELKCNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3469F20", Offset = "0x3468D20", VA = "0x183469F20", Slot = "4")]
	[IteratorStateMachine(typeof(AFIFOONIMKF<>.KPIIJKGEKKB))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x325EF70", Offset = "0x325DD70", VA = "0x18325EF70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class APCCHMLMLDI : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] EBBOGFOGDND;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] HAPDBHBPMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int OFCMCPFHKPN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BCOBLJBHFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x63F8E90", Offset = "0x63F7C90", VA = "0x1863F8E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x63F8FE0", Offset = "0x63F7DE0", VA = "0x1863F8FE0")]
	static APCCHMLMLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x63F9240", Offset = "0x63F8040", VA = "0x1863F9240")]
	public APCCHMLMLDI(byte[] HOMIGKEJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x63F8EE0", Offset = "0x63F7CE0", VA = "0x1863F8EE0")]
	public OpCode LFOCJLNAHKB()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct CMODFOPAJLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid GMPOHOAMMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte IKFLPJMHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte IGLBCGKPOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte OOKEOOHNPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte EMNGHEANIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte HLJIGJEHJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte GINDEDIHJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte BADKNIPFMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte JGHPLGKJEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte JEKKGKJOMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte OLPKAFHHLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte PCGEBIHLLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte APJNHCFNFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte PFNJPFBAFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte AOMFPALDLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte HNHCOPEILKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte HCIFGKJDFMK;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] KLOILLJGHNL;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] NCIHNCEBDMM;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x63FA980", Offset = "0x63F9780", VA = "0x1863FA980")]
	public CMODFOPAJLA(Guid GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x63FA990", Offset = "0x63F9790", VA = "0x1863FA990")]
	public CMODFOPAJLA(ArraySegment<byte> MNEHEPHAOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x63F9A20", Offset = "0x63F8820", VA = "0x1863F9A20")]
	private static byte CIADOFOAAKB(byte[] AFIEJCAINEM, int GCEIAJODLLF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x63F9AC0", Offset = "0x63F88C0", VA = "0x1863F9AC0")]
	private static byte EINBPOJGAGH(byte JHKDDIMPPGN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63F9BE0", Offset = "0x63F89E0", VA = "0x1863F9BE0")]
	public void PNMCNOGLFIO(byte[] BKOBMCKFFFH, int HLAIJKBFIJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class PELPLGKEKDO
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x640D850", Offset = "0x640C650", VA = "0x18640D850")]
	public static bool DAPMMFNECML(byte MFEFOKLBOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x640DC00", Offset = "0x640CA00", VA = "0x18640DC00")]
	public static bool FKOBDGKDNCL(byte MFEFOKLBOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x640DE70", Offset = "0x640CC70", VA = "0x18640DE70")]
	public static sbyte IEJFEPNMPFD(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x640DD80", Offset = "0x640CB80", VA = "0x18640DD80")]
	public static short HLOBNBKHHFH(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x640E660", Offset = "0x640D460", VA = "0x18640E660")]
	public static int MFNKFJODCOH(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x640E750", Offset = "0x640D550", VA = "0x18640E750")]
	public static long NBMBDNIPPID(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x640D8E0", Offset = "0x640C6E0", VA = "0x18640D8E0")]
	public static byte EMJADNLPCKD(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x640D7D0", Offset = "0x640C5D0", VA = "0x18640D7D0")]
	public static ushort CCNOLHDGMLM(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x640D860", Offset = "0x640C660", VA = "0x18640D860")]
	public static uint DOFJEBNDKJC(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x640DC70", Offset = "0x640CA70", VA = "0x18640DC70")]
	public static ulong GNOOFOJHPDC(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x640DF50", Offset = "0x640CD50", VA = "0x18640DF50")]
	public static float JLCFOBGFFAJ(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x640DB90", Offset = "0x640C990", VA = "0x18640DB90")]
	public static double FIANPOMLGCI(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x640DFC0", Offset = "0x640CDC0", VA = "0x18640DFC0")]
	public static int KGIFBGJIBFJ(byte[] BKOBMCKFFFH, int HLAIJKBFIJH, ulong GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x640E7F0", Offset = "0x640D5F0", VA = "0x18640E7F0")]
	public static int NGOEAMCGACG(byte[] BKOBMCKFFFH, int HLAIJKBFIJH, long GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x640D960", Offset = "0x640C760", VA = "0x18640D960")]
	public static bool EPMGDDANFOH(byte[] AFIEJCAINEM, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class ECBNIDJNMPK
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class FLNLPELBBAC : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public FLNLPELBBAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x63FF160", Offset = "0x63FDF60", VA = "0x1863FF160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x63FEBD0", Offset = "0x63FD9D0", VA = "0x1863FEBD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x63FEB80", Offset = "0x63FD980", VA = "0x1863FEB80")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x63FF000", Offset = "0x63FDE00", VA = "0x1863FF000")]
		private void NPKEOFGCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x63FF110", Offset = "0x63FDF10", VA = "0x1863FF110", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x63FF050", Offset = "0x63FDE50", VA = "0x1863FF050", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x63FF050", Offset = "0x63FDE50", VA = "0x1863FF050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class GBOIIJAAGDC : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public GBOIIJAAGDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x63FF9F0", Offset = "0x63FE7F0", VA = "0x1863FF9F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x63FF460", Offset = "0x63FE260", VA = "0x1863FF460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x63FF410", Offset = "0x63FE210", VA = "0x1863FF410")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x63FF890", Offset = "0x63FE690", VA = "0x1863FF890")]
		private void NPKEOFGCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x63FF9A0", Offset = "0x63FE7A0", VA = "0x1863FF9A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x63FF8E0", Offset = "0x63FE6E0", VA = "0x1863FF8E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x63FF8E0", Offset = "0x63FE6E0", VA = "0x1863FF8E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x63FD2A0", Offset = "0x63FC0A0", VA = "0x1863FD2A0")]
	public static bool MMJGJCDHHFJ(this TypeInfo PEMNIEMPPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x63FD0D0", Offset = "0x63FBED0", VA = "0x1863FD0D0")]
	public static bool ENMNGEAJFCG(this TypeInfo PEMNIEMPPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x63FD050", Offset = "0x63FBE50", VA = "0x1863FD050")]
	public static IEnumerable<PropertyInfo> CCFHDHNJECH(this Type PEMNIEMPPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x63FD200", Offset = "0x63FC000", VA = "0x1863FD200")]
	[IteratorStateMachine(typeof(FLNLPELBBAC))]
	private static IEnumerable<PropertyInfo> HCKFKLHCHAK(Type PEMNIEMPPLO, HashSet<string> MCBBGDFLONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x63FCFD0", Offset = "0x63FBDD0", VA = "0x1863FCFD0")]
	public static IEnumerable<FieldInfo> BAEGAMONHPP(this Type PEMNIEMPPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x63FCF30", Offset = "0x63FBD30", VA = "0x1863FCF30")]
	[IteratorStateMachine(typeof(GBOIIJAAGDC))]
	private static IEnumerable<FieldInfo> APAMIAJLEIA(Type PEMNIEMPPLO, HashSet<string> MCBBGDFLONF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class HJBBEMDPENI
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding IMKIGFGBAJG;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class ICFBACBDLDA
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static string PMKLCEHBGBC(string CCHCCCAOEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6401B00", Offset = "0x6400900", VA = "0x186401B00")]
	public static string PHCDEGJGOPJ(string CCHCCCAOEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6401970", Offset = "0x6400770", VA = "0x186401970")]
	public static string HBCKLCOGCEE(string CCHCCCAOEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class AFPFBCGCJDO<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class AHOHGLGGEJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type FPPHOMLMMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue GMPOHOAMMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int GHBDBKEEOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AHOHGLGGEJJ PAJMFNOPIGC;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3514490", Offset = "0x3513290", VA = "0x183514490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3514380", Offset = "0x3513180", VA = "0x183514380")]
		private int CBILAPKHPBD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public AHOHGLGGEJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class BBECELKDIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BBECELKDIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850")]
		internal TValue HEEEAMKPBHP(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private AHOHGLGGEJJ[] BDHMKLAEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int MEDHPDICIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object KCFMMMLAJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float ABHIKELKCNM;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3487370", Offset = "0x3486170", VA = "0x183487370")]
	public AFPFBCGCJDO(int DECKGNHFLHF = 4, float ABHIKELKCNM = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3486130", Offset = "0x3484F30", VA = "0x183486130")]
	public bool GJCIIACGELM(Type JLDFGFPAIIN, TValue GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3485F70", Offset = "0x3484D70", VA = "0x183485F70")]
	public bool GJCIIACGELM(Type JLDFGFPAIIN, Func<Type, TValue> IHNPEECIHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3486260", Offset = "0x3485060", VA = "0x183486260")]
	private bool GLPKLBDCJFH(Type JLDFGFPAIIN, Func<Type, TValue> IHNPEECIHFN, [Out] TValue HDPOALAPLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3486BC0", Offset = "0x34859C0", VA = "0x183486BC0")]
	private bool PIPBIPNFHGO(AHOHGLGGEJJ[] BDHMKLAEGMK, Type CCLGKLLIPFB, AHOHGLGGEJJ OOPAJPABKLF, Func<Type, TValue> IHNPEECIHFN, [Out] TValue HDPOALAPLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3486A80", Offset = "0x3485880", VA = "0x183486A80")]
	public bool PGDPBMGNNCL(Type JLDFGFPAIIN, [Out] TValue GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3485E20", Offset = "0x3484C20", VA = "0x183485E20")]
	public TValue BJKELHJLJDH(Type JLDFGFPAIIN, Func<Type, TValue> IHNPEECIHFN)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3464EE0", Offset = "0x3463CE0", VA = "0x183464EE0")]
	private static int BDIONBGFJPD(int NAGNLNLFBJO, float ABHIKELKCNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3486920", Offset = "0x3485720", VA = "0x183486920")]
	private static void OEJDAHEAHML(AHOHGLGGEJJ CBCJKGEEGLP, AHOHGLGGEJJ GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3486920", Offset = "0x3485720", VA = "0x183486920")]
	private static void OEJDAHEAHML(AHOHGLGGEJJ[] CBCJKGEEGLP, AHOHGLGGEJJ[] GNLEHBFFNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class NFDEPFBGIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder DDKNEDBOKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder DMLMGLJMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object NFDDOMCMJNJ;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x640A740", Offset = "0x6409540", VA = "0x18640A740")]
	public TypeBuilder BODFLAFOEBJ(string ONIBECKLJDD, TypeAttributes NLJMENCIKFC, Type LBLLNFOEKNE, Type[] OCKDKKPNCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x640A840", Offset = "0x6409640", VA = "0x18640A840")]
	public NFDEPFBGIKE(string IPGLKKJDHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class KBDPJEGFCEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6406E80", Offset = "0x6405C80", VA = "0x186406E80")]
	private static MethodInfo PLJJKBEIGHK(LambdaExpression OKLOMEFNMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x23F3960", Offset = "0x23F2760", VA = "0x1823F3960")]
	public static MethodInfo EDHDPMOKIMP<T>(Expression<Func<T>> OKLOMEFNMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x23F3960", Offset = "0x23F2760", VA = "0x1823F3960")]
	public static MethodInfo EDHDPMOKIMP<T, TR>(Expression<Func<T, TR>> OKLOMEFNMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x23F3960", Offset = "0x23F2760", VA = "0x1823F3960")]
	public static MethodInfo EDHDPMOKIMP<T>(Expression<Action<T>> OKLOMEFNMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x23F3960", Offset = "0x23F2760", VA = "0x1823F3960")]
	public static MethodInfo EDHDPMOKIMP<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> OKLOMEFNMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x23F37E0", Offset = "0x23F25E0", VA = "0x1823F37E0")]
	private static MemberInfo BBCEPNKOCAO<T>(Expression<T> JIHPAFENIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x23F38C0", Offset = "0x23F26C0", VA = "0x1823F38C0")]
	public static PropertyInfo COKEOJLDEIA<T, TR>(Expression<Func<T, TR>> OKLOMEFNMJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct NDPEMKBFAJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int FJLKBMOCNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool ELBNGEMFOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator JIKPJEMPBJP;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x640A670", Offset = "0x6409470", VA = "0x18640A670")]
	public NDPEMKBFAJF(ILGenerator JIKPJEMPBJP, int FJLKBMOCNHL, bool ELBNGEMFOIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x640A6B0", Offset = "0x64094B0", VA = "0x18640A6B0")]
	public NDPEMKBFAJF(ILGenerator JIKPJEMPBJP, int FJLKBMOCNHL, Type PEMNIEMPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x640A570", Offset = "0x6409370", VA = "0x18640A570")]
	public void ANCIBPOAOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class IPODJFAGINN
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6402E40", Offset = "0x6401C40", VA = "0x186402E40")]
	public static void EHKEGEHBKLJ(this ILGenerator JIKPJEMPBJP, int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6402E00", Offset = "0x6401C00", VA = "0x186402E00")]
	public static void EHKEGEHBKLJ(this ILGenerator JIKPJEMPBJP, LocalBuilder KECAPMIHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x64032E0", Offset = "0x64020E0", VA = "0x1864032E0")]
	public static void JDADIHDNLNA(this ILGenerator JIKPJEMPBJP, int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x64032A0", Offset = "0x64020A0", VA = "0x1864032A0")]
	public static void JDADIHDNLNA(this ILGenerator JIKPJEMPBJP, LocalBuilder KECAPMIHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6403C30", Offset = "0x6402A30", VA = "0x186403C30")]
	public static void OALGHCLBAAG(this ILGenerator JIKPJEMPBJP, int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6403B30", Offset = "0x6402930", VA = "0x186403B30")]
	public static void OALGHCLBAAG(this ILGenerator JIKPJEMPBJP, LocalBuilder KECAPMIHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6403110", Offset = "0x6401F10", VA = "0x186403110")]
	public static void HACIOCKJCLB(this ILGenerator JIKPJEMPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6403740", Offset = "0x6402540", VA = "0x186403740")]
	public static void LKOMEJKOOJD(this ILGenerator JIKPJEMPBJP, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6403750", Offset = "0x6402550", VA = "0x186403750")]
	public static void NDKJNLENOFJ(this ILGenerator JIKPJEMPBJP, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6402D20", Offset = "0x6401B20", VA = "0x186402D20")]
	public static void BAHNEJOMBHG(this ILGenerator JIKPJEMPBJP, Type PEMNIEMPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6403D10", Offset = "0x6402B10", VA = "0x186403D10")]
	public static void PEKPBKPKBMC(this ILGenerator JIKPJEMPBJP, Type PEMNIEMPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6403550", Offset = "0x6402350", VA = "0x186403550")]
	public static void LAPNNJHIJEG(this ILGenerator JIKPJEMPBJP, int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x64034D0", Offset = "0x64022D0", VA = "0x1864034D0")]
	public static void KLOJANOHAGB(this ILGenerator JIKPJEMPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6403030", Offset = "0x6401E30", VA = "0x186403030")]
	public static void GKGKGGPGPND(this ILGenerator JIKPJEMPBJP, int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6403120", Offset = "0x6401F20", VA = "0x186403120")]
	public static void HINNNOOPOEC(this ILGenerator JIKPJEMPBJP, MethodInfo BNHGEOINGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6402C90", Offset = "0x6401A90", VA = "0x186402C90")]
	public static void AJLLBAJBLHL(this ILGenerator JIKPJEMPBJP, FieldInfo KMAHDJHGJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6403210", Offset = "0x6402010", VA = "0x186403210")]
	public static void HJFIKGOEOML(this ILGenerator JIKPJEMPBJP, ulong GNLEHBFFNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class FFMBFHIACNJ
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class NDOHLBDPIME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NDOHLBDPIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x640A460", Offset = "0x6409260", VA = "0x18640A460")]
		internal bool DEKKMDIJFCE(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo MEHDFNHKJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo HGNJGDADMKG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string BENCLCLKDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BLLBFKJCPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x63FE410", Offset = "0x63FD210", VA = "0x1863FE410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BMAFKHFKBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x76B180", Offset = "0x769F80", VA = "0x18076B180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x76B150", Offset = "0x769F50", VA = "0x18076B150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PDBONBADMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6F50", Offset = "0x7E5D50", VA = "0x1807E6F50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6910", Offset = "0x7E5710", VA = "0x1807E6910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type DNFOEPJPNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x768590", Offset = "0x767390", VA = "0x180768590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo ILLGKPBIDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo FINEFCHGFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x76B130", Offset = "0x769F30", VA = "0x18076B130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo BBICCFLJMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x768550", Offset = "0x767350", VA = "0x180768550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x768570", Offset = "0x767370", VA = "0x180768570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x63FE710", Offset = "0x63FD510", VA = "0x1863FE710")]
	protected FFMBFHIACNJ(Type PEMNIEMPPLO, string ONIBECKLJDD, string IIBEAJCKGMI, bool JCCJICEPDEA, bool KGKAPGNNNBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63FE950", Offset = "0x63FD750", VA = "0x1863FE950")]
	public FFMBFHIACNJ(FieldInfo NAFGFKPNMPM, string ONIBECKLJDD, bool MHDDKJJOOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63FE790", Offset = "0x63FD590", VA = "0x1863FE790")]
	public FFMBFHIACNJ(PropertyInfo NAFGFKPNMPM, string ONIBECKLJDD, bool MHDDKJJOOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63FE5A0", Offset = "0x63FD3A0", VA = "0x1863FE5A0")]
	private static MethodInfo LIMMIGOEDFF(MemberInfo NAFGFKPNMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2332DF0", Offset = "0x2331BF0", VA = "0x182332DF0")]
	public T KDNEBBMPBMI<T>(bool PCBEBKJAJFG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x63FE420", Offset = "0x63FD220", VA = "0x1863FE420", Slot = "4")]
	public virtual void GBGFOOIKKCO(ILGenerator JIKPJEMPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x63FE290", Offset = "0x63FD090", VA = "0x1863FE290", Slot = "5")]
	public virtual void CBFPKHCEFNH(ILGenerator JIKPJEMPBJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class JJFNGALBGOB : FFMBFHIACNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string KEMBNOKJABJ;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x64048C0", Offset = "0x64036C0", VA = "0x1864048C0")]
	public JJFNGALBGOB(string ONIBECKLJDD, string KEMBNOKJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6404810", Offset = "0x6403610", VA = "0x186404810", Slot = "4")]
	public override void GBGFOOIKKCO(ILGenerator JIKPJEMPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x64047C0", Offset = "0x64035C0", VA = "0x1864047C0", Slot = "5")]
	public override void CBFPKHCEFNH(ILGenerator JIKPJEMPBJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class MPGBAHAPGBM : FFMBFHIACNJ
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo BNEBDKDENBF;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo PCNEPPJCEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal NDPEMKBFAJF FOJJKFCIEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal NDPEMKBFAJF PKEMIGODJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal NDPEMKBFAJF IOGIPCPDLDB;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x640A3A0", Offset = "0x64091A0", VA = "0x18640A3A0")]
	public MPGBAHAPGBM(string ONIBECKLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6409DD0", Offset = "0x6408BD0", VA = "0x186409DD0", Slot = "4")]
	public override void GBGFOOIKKCO(ILGenerator JIKPJEMPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6409BC0", Offset = "0x64089C0", VA = "0x186409BC0", Slot = "5")]
	public override void CBFPKHCEFNH(ILGenerator JIKPJEMPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6409C10", Offset = "0x6408A10", VA = "0x186409C10")]
	public void DLKFFEFLDKH(ILGenerator JIKPJEMPBJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class PKFEEBKJIAC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type DNFOEPJPNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MLAPFACFFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x764430", Offset = "0x763230", VA = "0x180764430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool NFGMICMBDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7E60C0", Offset = "0x7E4EC0", VA = "0x1807E60C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5410", Offset = "0x7E4210", VA = "0x1807E5410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo MOCNOEDKFML
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FFMBFHIACNJ[] KOMMMCKPPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x768590", Offset = "0x767390", VA = "0x180768590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FFMBFHIACNJ[] DEJBGHNNDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x640F410", Offset = "0x640E210", VA = "0x18640F410")]
	public PKFEEBKJIAC(Type PEMNIEMPPLO, Func<string, string> NEHPIAJGNMO, bool MHDDKJJOOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x640F330", Offset = "0x640E130", VA = "0x18640F330")]
	private static bool MKIGHPKMKEL(IEnumerator<ConstructorInfo> BKAEGHCCEMH, ConstructorInfo MAMEMAEOEJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct PNJAOABCFOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong HAPHGEIIOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int LLMCFHBADKL;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1C4AF30", Offset = "0x1C49D30", VA = "0x181C4AF30")]
	public PNJAOABCFOA(ulong IDHKLLLMKAC, int BIMFEOGAHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6410AA0", Offset = "0x640F8A0", VA = "0x186410AA0")]
	public void PLNAGOJBOBM(PNJAOABCFOA MFMJJEFODHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x64108D0", Offset = "0x640F6D0", VA = "0x1864108D0")]
	public static PNJAOABCFOA DOJALLHDIFK(PNJAOABCFOA MACGGKMNKNM, PNJAOABCFOA JHKDDIMPPGN)
	{
		return default(PNJAOABCFOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6410A10", Offset = "0x640F810", VA = "0x186410A10")]
	public void NIIDLDEALNN(PNJAOABCFOA MFMJJEFODHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6410970", Offset = "0x640F770", VA = "0x186410970")]
	public static PNJAOABCFOA NHJONMFPJPP(PNJAOABCFOA MACGGKMNKNM, PNJAOABCFOA JHKDDIMPPGN)
	{
		return default(PNJAOABCFOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x64108E0", Offset = "0x640F6E0", VA = "0x1864108E0")]
	public void LIOMFFKLAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6410920", Offset = "0x640F720", VA = "0x186410920")]
	public static PNJAOABCFOA LIOMFFKLAHK(PNJAOABCFOA MACGGKMNKNM)
	{
		return default(PNJAOABCFOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct ENFAMDLBAGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] BKOBMCKFFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int HLAIJKBFIJH;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1665CC0", Offset = "0x1664AC0", VA = "0x181665CC0")]
	public ENFAMDLBAGO(byte[] BKOBMCKFFFH, int AILFIIEAPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63E7C20", Offset = "0x63E6A20", VA = "0x1863E7C20")]
	public void GHLAINDIMLP(byte BHPLNDJAMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63FDCF0", Offset = "0x63FCAF0", VA = "0x1863FDCF0")]
	public void MIJJHKIHCMK(byte[] BHPLNDJAMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x63FDBD0", Offset = "0x63FC9D0", VA = "0x1863FDBD0")]
	public void MECJCOOMHEA(byte[] BHPLNDJAMJB, int JMNJMKJAMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x63FDC50", Offset = "0x63FCA50", VA = "0x1863FDC50")]
	public void MECJCOOMHEA(byte[] BHPLNDJAMJB, int KMFMMHANJHK, int JMNJMKJAMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x63FDB50", Offset = "0x63FC950", VA = "0x1863FDB50")]
	public void KAKGEBFGJLD(byte MFEFOKLBOBC, int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x63FDA50", Offset = "0x63FC850", VA = "0x1863FDA50")]
	public void EEDIEJECLJI(string BHPLNDJAMJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class OEPLFPMJHEG
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum DBKNOEFGILL
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum JIIPECFBFCA
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum DBMAAMCOCLA
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[ThreadStatic]
	private static byte[] IOGBICEPGKB;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] BHHAKIOPPEH;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] NFBAFDCBJOL;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] PPOKEACKNGM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly DBMAAMCOCLA MFKPOLBBAME;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char MKOBPJFCJLC;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int EJANODNMFNO;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int FILBIDIADPH;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] HKNPOAKBHNH;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x640C950", Offset = "0x640B750", VA = "0x18640C950")]
	private static byte[] NIDIAJCNBIH(int MEDHPDICIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x640AFE0", Offset = "0x6409DE0", VA = "0x18640AFE0")]
	private static byte[] DCFJFBGDOIE(int MEDHPDICIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x640C2F0", Offset = "0x640B0F0", VA = "0x18640C2F0")]
	public static int KELLOFCPNGF(byte[] BKOBMCKFFFH, int HLAIJKBFIJH, float GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x640C1D0", Offset = "0x640AFD0", VA = "0x18640C1D0")]
	public static int KELLOFCPNGF(byte[] BKOBMCKFFFH, int HLAIJKBFIJH, double GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x640B0C0", Offset = "0x6409EC0", VA = "0x18640B0C0")]
	private static bool DCKNKGAPIHK(byte[] BKOBMCKFFFH, int JMNJMKJAMOL, ulong KPHNFHILNNL, ulong PMDGHBOINOC, ulong EJPPONCFGNB, ulong BBMJEEOCDOB, ulong IMNFDLMBLPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x640AEF0", Offset = "0x6409CF0", VA = "0x18640AEF0")]
	private static void AJACLEJDABD(uint OFHIAMAIFEJ, int LNECJHKEFNE, [Out] uint DLGIDCOBELP, [Out] int PAGCJDGEJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x640BA20", Offset = "0x640A820", VA = "0x18640BA20")]
	private static bool GELGNEGDBMH(PNJAOABCFOA MNEDJIGJKIM, PNJAOABCFOA LOKDBOGNGFK, PNJAOABCFOA OJMDMJBBNBD, byte[] BKOBMCKFFFH, [Out] int JMNJMKJAMOL, [Out] int KGEPHOIKHDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x640CA20", Offset = "0x640B820", VA = "0x18640CA20")]
	private static bool OLPDCHJBFPL(double PMHKKHBJKIH, DBKNOEFGILL CPGOEPLHNCL, byte[] BKOBMCKFFFH, [Out] int JMNJMKJAMOL, [Out] int CPABGKNNANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x640C410", Offset = "0x640B210", VA = "0x18640C410")]
	private static bool KMDFHMIBJAN(double PMHKKHBJKIH, DBKNOEFGILL CPGOEPLHNCL, byte[] BKOBMCKFFFH, [Out] int JMNJMKJAMOL, [Out] int COBIBIGONJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x640BE10", Offset = "0x640AC10", VA = "0x18640BE10")]
	private static bool HICGJDHGPNA(double GNLEHBFFNFG, ENFAMDLBAGO LCICJHALEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x640B1B0", Offset = "0x6409FB0", VA = "0x18640B1B0")]
	private static bool EMJDKKABFFM(double GNLEHBFFNFG, ENFAMDLBAGO LCICJHALEHF, JIIPECFBFCA CPGOEPLHNCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x640B690", Offset = "0x640A490", VA = "0x18640B690")]
	private static void EMNLDNMGJMJ(byte[] MEOAOHHGOPH, int JMNJMKJAMOL, int COBIBIGONJA, int FBKMNPDOABM, ENFAMDLBAGO LCICJHALEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x640C520", Offset = "0x640B320", VA = "0x18640C520")]
	private static void LOGPCFGGJPM(byte[] MEOAOHHGOPH, int JMNJMKJAMOL, int BIMFEOGAHKD, ENFAMDLBAGO LCICJHALEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x640BFE0", Offset = "0x640ADE0", VA = "0x18640BFE0")]
	private static bool HMFOPMOFPGM(double PMHKKHBJKIH, JIIPECFBFCA CPGOEPLHNCL, int KFBIEADHIPN, byte[] NOOGIIKHJIL, [Out] bool BJFMEHGPBDP, [Out] int JMNJMKJAMOL, [Out] int EPFKACHOOEF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct IJIICKCJCLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double BIGGLMECNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong OCLAOBGLBGH;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct BLFAGFEBBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float HAPHGEIIOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint MHCPCHCMICB;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct MPEGNKHJBGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong NBAFAMFIJMN;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6409B10", Offset = "0x6408910", VA = "0x186409B10")]
	public MPEGNKHJBGI(double BIGGLMECNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6409B20", Offset = "0x6408920", VA = "0x186409B20")]
	public MPEGNKHJBGI(PNJAOABCFOA BIGGLMECNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6409A30", Offset = "0x6408830", VA = "0x186409A30")]
	public PNJAOABCFOA LGNIMODHJEK()
	{
		return default(PNJAOABCFOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6409970", Offset = "0x6408770", VA = "0x186409970")]
	public PNJAOABCFOA GJCOALGMILH()
	{
		return default(PNJAOABCFOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
	public ulong FFIFCBPFFCM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6409580", Offset = "0x6408380", VA = "0x186409580")]
	public double AJEHMLOJCKC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6409750", Offset = "0x6408550", VA = "0x186409750")]
	public double FMIGLDNFKBA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6409AE0", Offset = "0x64088E0", VA = "0x186409AE0")]
	public int OLFGNKHKIKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6409A00", Offset = "0x6408800", VA = "0x186409A00")]
	public ulong IBOBODFDNCP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6409AA0", Offset = "0x64088A0", VA = "0x186409AA0")]
	public bool MFNDPOBEPDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6409AC0", Offset = "0x64088C0", VA = "0x186409AC0")]
	public bool NFBPPJDNOGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x64097F0", Offset = "0x64085F0", VA = "0x1864097F0")]
	public bool GGBDOBPJFPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6409620", Offset = "0x6408420", VA = "0x186409620")]
	public bool BBCJGCJGNJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6409600", Offset = "0x6408400", VA = "0x186409600")]
	public int AJPDOLLJCNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6409820", Offset = "0x6408620", VA = "0x186409820")]
	public void GHNGCJFCOMG([Out] PNJAOABCFOA ELANJBPBAPD, [Out] PNJAOABCFOA HFHILPGEIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6409700", Offset = "0x6408500", VA = "0x186409700")]
	public bool DIPBLHMMAMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x295B530", Offset = "0x295A330", VA = "0x18295B530")]
	public double GNLEHBFFNFG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x64096E0", Offset = "0x64084E0", VA = "0x1864096E0")]
	public static int DECIDOBNIJG(int HIGLKKMCPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x64099F0", Offset = "0x64087F0", VA = "0x1864099F0")]
	public static double GNDEJPKINID()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6409650", Offset = "0x6408450", VA = "0x186409650")]
	public static ulong CKONANMAKKF(PNJAOABCFOA EDHPLOFPEAC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct EGMCADOAGFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint OOAGBELMKBP;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1EF5060", Offset = "0x1EF3E60", VA = "0x181EF5060")]
	public EGMCADOAGFN(float HAPHGEIIOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x63FD4F0", Offset = "0x63FC2F0", VA = "0x1863FD4F0")]
	public PNJAOABCFOA LGNIMODHJEK()
	{
		return default(PNJAOABCFOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0")]
	public uint JJHFOLOKBEP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63FD550", Offset = "0x63FC350", VA = "0x1863FD550")]
	public int OLFGNKHKIKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x63FD4D0", Offset = "0x63FC2D0", VA = "0x1863FD4D0")]
	public uint IBOBODFDNCP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63FD540", Offset = "0x63FC340", VA = "0x1863FD540")]
	public bool MFNDPOBEPDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63FD3A0", Offset = "0x63FC1A0", VA = "0x1863FD3A0")]
	public void GHNGCJFCOMG([Out] PNJAOABCFOA ELANJBPBAPD, [Out] PNJAOABCFOA HFHILPGEIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x63FD360", Offset = "0x63FC160", VA = "0x1863FD360")]
	public bool DIPBLHMMAMO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct LIIJHBEBBNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong IDHKLLLMKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short MMAIHKOCNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short CPABGKNNANL;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x64077D0", Offset = "0x64065D0", VA = "0x1864077D0")]
	public LIIJHBEBBNE(ulong IDHKLLLMKAC, short MMAIHKOCNKI, short CPABGKNNANL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class IBIJEHBNDFD
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly LIIJHBEBBNE[] JGNPNHFHMAC;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6400900", Offset = "0x63FF700", VA = "0x186400900")]
	public static void JPFPPAPIJPC(int IGGNJCENJBE, int HJDOGOLNDHJ, [Out] PNJAOABCFOA DLGIDCOBELP, [Out] int CPABGKNNANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6400830", Offset = "0x63FF630", VA = "0x186400830")]
	public static void FOLKCAIPBBL(int COEHOMPINBI, [Out] PNJAOABCFOA DLGIDCOBELP, [Out] int LBGDEAMMBFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct EALFBANICLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] AFIEJCAINEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int KMFMMHANJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int ICCHKEKLCLE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x63FCE90", Offset = "0x63FBC90", VA = "0x1863FCE90")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x33EFE30", Offset = "0x33EEC30", VA = "0x1833EFE30")]
	public EALFBANICLB(byte[] AFIEJCAINEM, int KMFMMHANJHK, int JMNJMKJAMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F33DD0", Offset = "0x1F32BD0", VA = "0x181F33DD0")]
	public int JMNJMKJAMOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x63FCED0", Offset = "0x63FBCD0", VA = "0x1863FCED0")]
	public EALFBANICLB HNKDIJHLDHO(int AFCDMCCEPNE, int IMLAGLECAAO)
	{
		return default(EALFBANICLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class LNAGKLAINJP
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] OPEFFLGOGHM;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] BLBJCMKOBID;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int MNDDHMDPCMB;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6407DA0", Offset = "0x6406BA0", VA = "0x186407DA0")]
	private static byte[] GEJICGDCNPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x64085B0", Offset = "0x64073B0", VA = "0x1864085B0")]
	private static EALFBANICLB JGLDOMLNEFH(EALFBANICLB BKOBMCKFFFH)
	{
		return default(EALFBANICLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x64084D0", Offset = "0x64072D0", VA = "0x1864084D0")]
	private static EALFBANICLB JDEKGOBIHNJ(EALFBANICLB BKOBMCKFFFH)
	{
		return default(EALFBANICLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6408690", Offset = "0x6407490", VA = "0x186408690")]
	private static void JJHKPKPLGLP(EALFBANICLB BKOBMCKFFFH, int BIMFEOGAHKD, byte[] IILEKGBOCOD, [Out] int EJAOKLNNMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6409010", Offset = "0x6407E10", VA = "0x186409010")]
	private static void PCFNKDIFLEG(EALFBANICLB BKOBMCKFFFH, int BIMFEOGAHKD, byte[] OBLMPDEFGON, int NALMFHNHJGD, [Out] EALFBANICLB GDBEPEJBBDM, [Out] int HNJHHDLHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6407D10", Offset = "0x6406B10", VA = "0x186407D10")]
	private static ulong CEJDFNFDFOF(EALFBANICLB BKOBMCKFFFH, [Out] int IFFJNOFDAPO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x64089E0", Offset = "0x64077E0", VA = "0x1864089E0")]
	private static void LEHKKILLPAC(EALFBANICLB BKOBMCKFFFH, [Out] PNJAOABCFOA EKOLPKLNMBD, [Out] int LPJAKPJIMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6408C40", Offset = "0x6407A40", VA = "0x186408C40")]
	private static bool OABPBHFGGJG(EALFBANICLB GDBEPEJBBDM, int BIMFEOGAHKD, [Out] double EKOLPKLNMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6408840", Offset = "0x6407640", VA = "0x186408840")]
	private static PNJAOABCFOA LCPMOFDPJNH(int BIMFEOGAHKD)
	{
		return default(PNJAOABCFOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6407E80", Offset = "0x6406C80", VA = "0x186407E80")]
	private static bool GJEIDOKMIGH(EALFBANICLB BKOBMCKFFFH, int BIMFEOGAHKD, [Out] double EKOLPKLNMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6408B20", Offset = "0x6407920", VA = "0x186408B20")]
	private static bool MANBKJGHFCJ(EALFBANICLB GDBEPEJBBDM, int BIMFEOGAHKD, [Out] double MLHGPJJBMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6408720", Offset = "0x6407520", VA = "0x186408720")]
	public static double? KALOAGNKCJA(EALFBANICLB BKOBMCKFFFH, int BIMFEOGAHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6407A40", Offset = "0x6406840", VA = "0x186407A40")]
	public static float? BGABPEBCKOM(EALFBANICLB BKOBMCKFFFH, int BIMFEOGAHKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct LDNBGJFCPJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] BKOBMCKFFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int HLAIJKBFIJH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6420650", Offset = "0x641F450", VA = "0x186420650")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1665CC0", Offset = "0x1664AC0", VA = "0x181665CC0")]
	public LDNBGJFCPJK(byte[] BKOBMCKFFFH, int HLAIJKBFIJH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6420720", Offset = "0x641F520", VA = "0x186420720")]
	public static LDNBGJFCPJK JIEBEKLKKGG(LDNBGJFCPJK LNKCIHFCLHG)
	{
		return default(LDNBGJFCPJK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6420600", Offset = "0x641F400", VA = "0x186420600")]
	public static LDNBGJFCPJK ANKLPPKHJLG(LDNBGJFCPJK LNKCIHFCLHG, int JMNJMKJAMOL)
	{
		return default(LDNBGJFCPJK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6420760", Offset = "0x641F560", VA = "0x186420760")]
	public static int LNLCGFPCCBD(LDNBGJFCPJK KNEDKAAPLCI, LDNBGJFCPJK FPBOJHIIPAI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x64207A0", Offset = "0x641F5A0", VA = "0x1864207A0")]
	public static bool NOLBLOCHCOA(LDNBGJFCPJK KNEDKAAPLCI, LDNBGJFCPJK FPBOJHIIPAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6420680", Offset = "0x641F480", VA = "0x186420680")]
	public static bool BPHGJPBDHAH(LDNBGJFCPJK KNEDKAAPLCI, LDNBGJFCPJK FPBOJHIIPAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6420770", Offset = "0x641F570", VA = "0x186420770")]
	public static bool NOLBLOCHCOA(LDNBGJFCPJK KNEDKAAPLCI, char FPBOJHIIPAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6420690", Offset = "0x641F490", VA = "0x186420690")]
	public static bool BPHGJPBDHAH(LDNBGJFCPJK KNEDKAAPLCI, char FPBOJHIIPAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6420690", Offset = "0x641F490", VA = "0x186420690")]
	public static bool BPHGJPBDHAH(LDNBGJFCPJK KNEDKAAPLCI, byte FPBOJHIIPAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6420730", Offset = "0x641F530", VA = "0x186420730")]
	public static bool KKFHHDIDOAM(LDNBGJFCPJK KNEDKAAPLCI, char FPBOJHIIPAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x64206F0", Offset = "0x641F4F0", VA = "0x1864206F0")]
	public static bool DIKEOCJPPIN(LDNBGJFCPJK KNEDKAAPLCI, char FPBOJHIIPAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x64205D0", Offset = "0x641F3D0", VA = "0x1864205D0")]
	public static bool AJFHEKMJBLN(LDNBGJFCPJK KNEDKAAPLCI, char FPBOJHIIPAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x64206C0", Offset = "0x641F4C0", VA = "0x1864206C0")]
	public static bool CMMFAPMGOHC(LDNBGJFCPJK KNEDKAAPLCI, char FPBOJHIIPAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class DEANGBHGKAD
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] NPGFLDDEOIJ;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] NJHLMHFJICB;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] NFBAFDCBJOL;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] PPOKEACKNGM;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] NCONBHOEIDB;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int ECMLHIKLKPK;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] DNKJHJDPCOF;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int COOBAFGDHAE;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x64130B0", Offset = "0x6411EB0", VA = "0x1864130B0")]
	private static byte[] BOHCMJDGGDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6414340", Offset = "0x6413140", VA = "0x186414340")]
	private static byte[] NHFLFAFLPFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6414610", Offset = "0x6413410", VA = "0x186414610")]
	public static double PGDBOKNBDBO(byte[] BKOBMCKFFFH, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6413190", Offset = "0x6411F90", VA = "0x186413190")]
	public static float DEGHAPEENCC(byte[] BKOBMCKFFFH, int HLAIJKBFIJH, [Out] int JHFPNDBKPGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6414200", Offset = "0x6413000", VA = "0x186414200")]
	private static bool MMADNAAEEBE(int HOELCINBFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6414420", Offset = "0x6413220", VA = "0x186414420")]
	private static bool PFCJLPAOIDC(LDNBGJFCPJK IPNEBMFIFEG, LDNBGJFCPJK MCKBHHHCKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6413260", Offset = "0x6412060", VA = "0x186413260")]
	private static bool JDJCABALPPJ(LDNBGJFCPJK IPNEBMFIFEG, LDNBGJFCPJK MCKBHHHCKCE, byte[] BFNCCKLBJEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x64141B0", Offset = "0x6412FB0", VA = "0x1864141B0")]
	private static bool LOPFBMONDGG(LDNBGJFCPJK DOPJDCKJBAB, byte[] BHPLNDJAMJB, int HLAIJKBFIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6413240", Offset = "0x6412040", VA = "0x186413240")]
	private static double DPFFJPKDAAI(bool BJFMEHGPBDP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6413330", Offset = "0x6412130", VA = "0x186413330")]
	private static double LEPGLMEPKBH(LDNBGJFCPJK ENGEPLNNBDC, int JMNJMKJAMOL, bool FFGAPFNBAME, [Out] int IFDBNGAJDAE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class CMHCADHLBMA<T> : KHFNPOBDEKJ<T[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly BMGPCCMNGIE<T> LLJPMMKAPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly KOGABNCIMMH APKKOGNLIIE;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x33DFD10", Offset = "0x33DEB10", VA = "0x1833DFD10")]
	public CMHCADHLBMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
	public CMHCADHLBMA(KOGABNCIMMH APKKOGNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4B03120", Offset = "0x4B01F20", VA = "0x184B03120", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4B02080", Offset = "0x4B00E80", VA = "0x184B02080", Slot = "5")]
	public T[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class OEHOFCBAENO<T> : KHFNPOBDEKJ<ArraySegment<T>>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly BMGPCCMNGIE<T> LLJPMMKAPOK;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3D15410", Offset = "0x3D14210", VA = "0x183D15410", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ArraySegment<T> GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3D14FF0", Offset = "0x3D13DF0", VA = "0x183D14FF0", Slot = "5")]
	public ArraySegment<T> EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class FHOFINKLOPI<T> : KHFNPOBDEKJ<List<T>>, NHMDNCPBKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly KOGABNCIMMH APKKOGNLIIE;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x33DFD10", Offset = "0x33DEB10", VA = "0x1833DFD10")]
	public FHOFINKLOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
	public FHOFINKLOPI(KOGABNCIMMH APKKOGNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x33DEE40", Offset = "0x33DDC40", VA = "0x1833DEE40", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, List<T> GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x33DB4F0", Offset = "0x33DA2F0", VA = "0x1833DB4F0", Slot = "5")]
	public List<T> EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class HEHHHJCPLOA<TElement, TIntermediate, TEnumerator, TCollection> : KHFNPOBDEKJ<TCollection>, NHMDNCPBKML where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3574B40", Offset = "0x3573940", VA = "0x183574B40", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, TCollection GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3573220", Offset = "0x3572020", VA = "0x183573220", Slot = "5")]
	public TCollection EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator IKGPKOMIPEN(TCollection JIHPAFENIMM);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate HKJMJGOBNGA();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void AAFNAGDLNDC(TIntermediate CAMGNALCBNB, int DOJILIOCHKM, TElement GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ENKNHBEMBCD(TIntermediate NDPNBFGANEL);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected HEHHHJCPLOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class FAMLBCIFOJH<TElement, TIntermediate, TCollection> : HEHHHJCPLOA<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x33CC3C0", Offset = "0x33CB1C0", VA = "0x1833CC3C0", Slot = "6")]
	protected override IEnumerator<TElement> IKGPKOMIPEN(TCollection JIHPAFENIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2FFF2E0", Offset = "0x2FFE0E0", VA = "0x182FFF2E0")]
	protected FAMLBCIFOJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class OLHDAHADOHE<TElement, TCollection> : FAMLBCIFOJH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected sealed override TCollection ENKNHBEMBCD(TCollection NDPNBFGANEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class NOGKJCBGFPB<TElement, TCollection> : OLHDAHADOHE<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7D90", Offset = "0x3BE6B90", VA = "0x183BE7D90", Slot = "7")]
	protected override TCollection HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7CD0", Offset = "0x3BE6AD0", VA = "0x183BE7CD0", Slot = "8")]
	protected override void AAFNAGDLNDC(TCollection CAMGNALCBNB, int DOJILIOCHKM, TElement GNLEHBFFNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class KOFDIEAPICO<T> : HEHHHJCPLOA<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x33DAFD0", Offset = "0x33D9DD0", VA = "0x1833DAFD0", Slot = "8")]
	protected override void AAFNAGDLNDC(LinkedList<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override LinkedList<T> ENKNHBEMBCD(LinkedList<T> NDPNBFGANEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override LinkedList<T> HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x38ADE30", Offset = "0x38ACC30", VA = "0x1838ADE30", Slot = "6")]
	protected override LinkedList<T>.Enumerator IKGPKOMIPEN(LinkedList<T> JIHPAFENIMM)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class MJAEMLEEHPK<T> : HEHHHJCPLOA<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x33DAFD0", Offset = "0x33D9DD0", VA = "0x1833DAFD0", Slot = "8")]
	protected override void AAFNAGDLNDC(Queue<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override Queue<T> HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x33DB010", Offset = "0x33D9E10", VA = "0x1833DB010", Slot = "6")]
	protected override Queue<T>.Enumerator IKGPKOMIPEN(Queue<T> JIHPAFENIMM)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override Queue<T> ENKNHBEMBCD(Queue<T> NDPNBFGANEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class IGCONJEDOGM<T> : HEHHHJCPLOA<T, BIFNHDNHDBJ<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3659870", Offset = "0x3658670", VA = "0x183659870", Slot = "8")]
	protected override void AAFNAGDLNDC(BIFNHDNHDBJ<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3659980", Offset = "0x3658780", VA = "0x183659980", Slot = "7")]
	protected override BIFNHDNHDBJ<T> HKJMJGOBNGA()
	{
		return default(BIFNHDNHDBJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x36599C0", Offset = "0x36587C0", VA = "0x1836599C0", Slot = "6")]
	protected override Stack<T>.Enumerator IKGPKOMIPEN(Stack<T> JIHPAFENIMM)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x36598A0", Offset = "0x36586A0", VA = "0x1836598A0", Slot = "9")]
	protected override Stack<T> ENKNHBEMBCD(BIFNHDNHDBJ<T> NDPNBFGANEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class FHNMILNJMAN<T> : HEHHHJCPLOA<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x33DAFD0", Offset = "0x33D9DD0", VA = "0x1833DAFD0", Slot = "8")]
	protected override void AAFNAGDLNDC(HashSet<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override HashSet<T> ENKNHBEMBCD(HashSet<T> NDPNBFGANEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override HashSet<T> HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x33DB010", Offset = "0x33D9E10", VA = "0x1833DB010", Slot = "6")]
	protected override HashSet<T>.Enumerator IKGPKOMIPEN(HashSet<T> JIHPAFENIMM)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PBGHEEJLCMA<T> : FAMLBCIFOJH<T, BIFNHDNHDBJ<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3659870", Offset = "0x3658670", VA = "0x183659870", Slot = "8")]
	protected override void AAFNAGDLNDC(BIFNHDNHDBJ<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9B40", Offset = "0x3DC8940", VA = "0x183DC9B40", Slot = "9")]
	protected override ReadOnlyCollection<T> ENKNHBEMBCD(BIFNHDNHDBJ<T> NDPNBFGANEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9BE0", Offset = "0x3DC89E0", VA = "0x183DC9BE0", Slot = "7")]
	protected override BIFNHDNHDBJ<T> HKJMJGOBNGA()
	{
		return default(BIFNHDNHDBJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class KJFBCJFHDPG<T> : FAMLBCIFOJH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x33DAFD0", Offset = "0x33D9DD0", VA = "0x1833DAFD0", Slot = "8")]
	protected override void AAFNAGDLNDC(List<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override List<T> HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override IList<T> ENKNHBEMBCD(List<T> NDPNBFGANEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class KBAKEFGHJHK<T> : FAMLBCIFOJH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x33DAFD0", Offset = "0x33D9DD0", VA = "0x1833DAFD0", Slot = "8")]
	protected override void AAFNAGDLNDC(List<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override List<T> HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override ICollection<T> ENKNHBEMBCD(List<T> NDPNBFGANEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class IJEJFGMCNBN<T> : FAMLBCIFOJH<T, BIFNHDNHDBJ<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3659870", Offset = "0x3658670", VA = "0x183659870", Slot = "8")]
	protected override void AAFNAGDLNDC(BIFNHDNHDBJ<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3659980", Offset = "0x3658780", VA = "0x183659980", Slot = "7")]
	protected override BIFNHDNHDBJ<T> HKJMJGOBNGA()
	{
		return default(BIFNHDNHDBJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3683020", Offset = "0x3681E20", VA = "0x183683020", Slot = "9")]
	protected override IEnumerable<T> ENKNHBEMBCD(BIFNHDNHDBJ<T> NDPNBFGANEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x30094E0", Offset = "0x30082E0", VA = "0x1830094E0")]
	public IJEJFGMCNBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class AGPACGNJKIL<TKey, TElement> : KHFNPOBDEKJ<IGrouping<TKey, TElement>>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3489B50", Offset = "0x3488950", VA = "0x183489B50", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, IGrouping<TKey, TElement> GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3489850", Offset = "0x3488650", VA = "0x183489850", Slot = "5")]
	public IGrouping<TKey, TElement> EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class MMDOLPNKMKJ<TKey, TElement> : KHFNPOBDEKJ<ILookup<TKey, TElement>>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3B73B60", Offset = "0x3B72960", VA = "0x183B73B60", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ILookup<TKey, TElement> GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3B73810", Offset = "0x3B72610", VA = "0x183B73810", Slot = "5")]
	public ILookup<TKey, TElement> EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class JDMMPLGIBND<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey JLDFGFPAIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> GBGFELNIFAG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey FPPHOMLMMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
	public JDMMPLGIBND(TKey JLDFGFPAIIN, IEnumerable<TElement> GBGFELNIFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3819320", Offset = "0x3818120", VA = "0x183819320", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x30CD8A0", Offset = "0x30CC6A0", VA = "0x1830CD8A0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class OIOEPABKCLH<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> KMHLAGIODOM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x382FAD0", Offset = "0x382E8D0", VA = "0x18382FAD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public OIOEPABKCLH(Dictionary<TKey, IGrouping<TKey, TElement>> KMHLAGIODOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3822AF0", Offset = "0x38218F0", VA = "0x183822AF0", Slot = "5")]
	public bool Contains(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3D2D620", Offset = "0x3D2C420", VA = "0x183D2D620", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3D2D620", Offset = "0x3D2C420", VA = "0x183D2D620", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class NLIGPDBKIKF<T> : KHFNPOBDEKJ<T>, NHMDNCPBKML where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3CF0", Offset = "0x3BE2AF0", VA = "0x183BE3CF0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3A70", Offset = "0x3BE2870", VA = "0x183BE3A70", Slot = "5")]
	public T EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NLIGPDBKIKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class DLEGFKAEDKH : KHFNPOBDEKJ<IEnumerable>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly KHFNPOBDEKJ<IEnumerable> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6414BC0", Offset = "0x64139C0", VA = "0x186414BC0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, IEnumerable GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6414970", Offset = "0x6413770", VA = "0x186414970", Slot = "5")]
	public IEnumerable EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DLEGFKAEDKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class LLDBLMMKICN : KHFNPOBDEKJ<ICollection>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly KHFNPOBDEKJ<ICollection> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6421820", Offset = "0x6420620", VA = "0x186421820", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ICollection GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x64215D0", Offset = "0x64203D0", VA = "0x1864215D0", Slot = "5")]
	public ICollection EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LLDBLMMKICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class LBNMNBFDCFC : KHFNPOBDEKJ<IList>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly KHFNPOBDEKJ<IList> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6420220", Offset = "0x641F020", VA = "0x186420220", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, IList GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x641FFD0", Offset = "0x641EDD0", VA = "0x18641FFD0", Slot = "5")]
	public IList EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LBNMNBFDCFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class KJPHAJMAOFO<T> : FAMLBCIFOJH<T, BIFNHDNHDBJ<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x389ADD0", Offset = "0x3899BD0", VA = "0x18389ADD0", Slot = "8")]
	protected override void AAFNAGDLNDC(BIFNHDNHDBJ<T> CAMGNALCBNB, int DOJILIOCHKM, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3659980", Offset = "0x3658780", VA = "0x183659980", Slot = "7")]
	protected override BIFNHDNHDBJ<T> HKJMJGOBNGA()
	{
		return default(BIFNHDNHDBJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x389AE00", Offset = "0x3899C00", VA = "0x18389AE00", Slot = "9")]
	protected override IReadOnlyList<T> ENKNHBEMBCD(BIFNHDNHDBJ<T> NDPNBFGANEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x300D6A0", Offset = "0x300C4A0", VA = "0x18300D6A0")]
	public KJPHAJMAOFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class CJFDMIEIPBF
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6412D90", Offset = "0x6411B90", VA = "0x186412D90")]
	public static DateTime PHHPPNCILNE(DateTime NEHNDMEMBON)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class OMLKPJIGNOL : KHFNPOBDEKJ<DateTime>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly KHFNPOBDEKJ<DateTime> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x64235C0", Offset = "0x64223C0", VA = "0x1864235C0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, DateTime GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x64228B0", Offset = "0x64216B0", VA = "0x1864228B0", Slot = "5")]
	public DateTime EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public OMLKPJIGNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class GMOPIMFFBFI : KHFNPOBDEKJ<DateTimeOffset>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly KHFNPOBDEKJ<DateTimeOffset> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6418420", Offset = "0x6417220", VA = "0x186418420", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, DateTimeOffset GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6417800", Offset = "0x6416600", VA = "0x186417800", Slot = "5")]
	public DateTimeOffset EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public GMOPIMFFBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class IKEGNAABNHA : KHFNPOBDEKJ<TimeSpan>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly KHFNPOBDEKJ<TimeSpan> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] BJNNOEEFBHO;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x641B1E0", Offset = "0x6419FE0", VA = "0x18641B1E0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, TimeSpan GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x641A8D0", Offset = "0x64196D0", VA = "0x18641A8D0", Slot = "5")]
	public TimeSpan EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IKEGNAABNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class EMOLDALJPLN<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : KHFNPOBDEKJ<TDictionary>, NHMDNCPBKML where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x30687D0", Offset = "0x30675D0", VA = "0x1830687D0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, TDictionary GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3065A10", Offset = "0x3064810", VA = "0x183065A10", Slot = "5")]
	public TDictionary EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator IKGPKOMIPEN(TDictionary JIHPAFENIMM);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate HKJMJGOBNGA();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void AAFNAGDLNDC(TIntermediate CAMGNALCBNB, int DOJILIOCHKM, TKey JLDFGFPAIIN, TValue GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ENKNHBEMBCD(TIntermediate NDPNBFGANEL);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected EMOLDALJPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class CDNPLBOHDMC<TKey, TValue, TIntermediate, TDictionary> : EMOLDALJPLN<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x33CC3C0", Offset = "0x33CB1C0", VA = "0x1833CC3C0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> IKGPKOMIPEN(TDictionary JIHPAFENIMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class NCDNDMDMKAM<TKey, TValue, TDictionary> : CDNPLBOHDMC<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override TDictionary ENKNHBEMBCD(TDictionary NDPNBFGANEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class OJFGFBPMKNJ<TKey, TValue> : EMOLDALJPLN<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3D2D6E0", Offset = "0x3D2C4E0", VA = "0x183D2D6E0", Slot = "8")]
	protected override void AAFNAGDLNDC(Dictionary<TKey, TValue> CAMGNALCBNB, int DOJILIOCHKM, TKey JLDFGFPAIIN, TValue GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override Dictionary<TKey, TValue> ENKNHBEMBCD(Dictionary<TKey, TValue> NDPNBFGANEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override Dictionary<TKey, TValue> HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3D2D7B0", Offset = "0x3D2C5B0", VA = "0x183D2D7B0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator IKGPKOMIPEN(Dictionary<TKey, TValue> JIHPAFENIMM)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2FFE950", Offset = "0x2FFD750", VA = "0x182FFE950")]
	public OJFGFBPMKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class LMEHKPGJMLF<TKey, TValue, TDictionary> : NCDNDMDMKAM<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x39587D0", Offset = "0x39575D0", VA = "0x1839587D0", Slot = "8")]
	protected override void AAFNAGDLNDC(TDictionary CAMGNALCBNB, int DOJILIOCHKM, TKey JLDFGFPAIIN, TValue GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2E95560", Offset = "0x2E94360", VA = "0x182E95560", Slot = "7")]
	protected override TDictionary HKJMJGOBNGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class BFBGHMMLHKD<TKey, TValue> : CDNPLBOHDMC<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x306F5E0", Offset = "0x306E3E0", VA = "0x18306F5E0", Slot = "8")]
	protected override void AAFNAGDLNDC(Dictionary<TKey, TValue> CAMGNALCBNB, int DOJILIOCHKM, TKey JLDFGFPAIIN, TValue GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override Dictionary<TKey, TValue> HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override IDictionary<TKey, TValue> ENKNHBEMBCD(Dictionary<TKey, TValue> NDPNBFGANEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class EOCEDHLCJPA<TKey, TValue> : NCDNDMDMKAM<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x306F5E0", Offset = "0x306E3E0", VA = "0x18306F5E0", Slot = "8")]
	protected override void AAFNAGDLNDC(SortedList<TKey, TValue> CAMGNALCBNB, int DOJILIOCHKM, TKey JLDFGFPAIIN, TValue GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override SortedList<TKey, TValue> HKJMJGOBNGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class BNHOOAIKEFO<TKey, TValue> : EMOLDALJPLN<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x306F5E0", Offset = "0x306E3E0", VA = "0x18306F5E0", Slot = "8")]
	protected override void AAFNAGDLNDC(SortedDictionary<TKey, TValue> CAMGNALCBNB, int DOJILIOCHKM, TKey JLDFGFPAIIN, TValue GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xC7DBC0", Offset = "0xC7C9C0", VA = "0x180C7DBC0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ENKNHBEMBCD(SortedDictionary<TKey, TValue> NDPNBFGANEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x306F620", Offset = "0x306E420", VA = "0x18306F620", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> HKJMJGOBNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3D2D7B0", Offset = "0x3D2C5B0", VA = "0x183D2D7B0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator IKGPKOMIPEN(SortedDictionary<TKey, TValue> JIHPAFENIMM)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class ILPACOHNLLN<T> : KHFNPOBDEKJ<T>, NHMDNCPBKML where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3690900", Offset = "0x368F700", VA = "0x183690900", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3690660", Offset = "0x368F460", VA = "0x183690660", Slot = "5")]
	public T EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ILPACOHNLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class KHAIHOJBAMJ : KHFNPOBDEKJ<IDictionary>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly KHFNPOBDEKJ<IDictionary> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x641EFA0", Offset = "0x641DDA0", VA = "0x18641EFA0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, IDictionary GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x641ED70", Offset = "0x641DB70", VA = "0x18641ED70", Slot = "5")]
	public IDictionary EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KHAIHOJBAMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class JBGBFLKOAMO : KHFNPOBDEKJ<object>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void JOMIENLLANK(object HEBDEMKGEFC, LKJMGENIDLC LCMOFCIALJC, object GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly AFPFBCGCJDO<KeyValuePair<object, JOMIENLLANK>> NLFJDPDMBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly LHGMBMDOIPK[] AECKLFENDKG;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x641C3D0", Offset = "0x641B1D0", VA = "0x18641C3D0")]
	public JBGBFLKOAMO(params LHGMBMDOIPK[] AECKLFENDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x641BA10", Offset = "0x641A810", VA = "0x18641BA10", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, object GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x641B980", Offset = "0x641A780", VA = "0x18641B980", Slot = "5")]
	public object EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class JDBHHAPBAID
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x641C850", Offset = "0x641B650", VA = "0x18641C850")]
	public static object GEJJBJIJNAJ(Type PEMNIEMPPLO, [Out] bool GDHCIKKBBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x641D140", Offset = "0x641BF40", VA = "0x18641D140")]
	public static object GPDGBOJBBKM(Type PEMNIEMPPLO, [Out] bool GDHCIKKBBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class OCNLJAFONIH<T> : KHFNPOBDEKJ<T>, NHMDNCPBKML, LHIKEAPDNKI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class GKMAEJOPCCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GKMAEJOPCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x34C5570", Offset = "0x34C4370", VA = "0x1834C5570")]
		internal bool BAJIABBEJHI(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class MGCBHHNKOCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MGCBHHNKOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B28260", Offset = "0x3B27060", VA = "0x183B28260")]
		internal bool DILNFHLBIAK(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class KGIFLLLOIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public JBMCDPGAABN<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public KGIFLLLOIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x3895240", Offset = "0x3894040", VA = "0x183895240")]
		internal void PDBBDBNEKNO(LKJMGENIDLC writer, T value, LHGMBMDOIPK _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class ICLDKHBMMNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AHFDKLGEPJE<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ICLDKHBMMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x364B380", Offset = "0x364A180", VA = "0x18364B380")]
		internal T HDFNEKILJKD(PLNICAEBGII reader, LHGMBMDOIPK _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly AFIFOONIMKF<T> FMOEOHOJJIO;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> EJENINBMOAL;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly JBMCDPGAABN<T> EELLEOENFHD;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly AHFDKLGEPJE<T> EMCKBCGLCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool LIAPOOJNMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly JBMCDPGAABN<T> KFHOIEDFKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly AHFDKLGEPJE<T> GBMCCAIFMNB;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5240", Offset = "0x3CB4040", VA = "0x183CB5240")]
	static OCNLJAFONIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3CC63C0", Offset = "0x3CC51C0", VA = "0x183CC63C0")]
	public OCNLJAFONIH(bool LIAPOOJNMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F130", Offset = "0x3C9DF30", VA = "0x183C9F130", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C97670", Offset = "0x3C96470", VA = "0x183C97670", Slot = "5")]
	public T EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0310", Offset = "0x3C9F110", VA = "0x183CA0310", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, T GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3BB0", Offset = "0x3CA29B0", VA = "0x183CA3BB0", Slot = "7")]
	public T NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class ADPNMFEPAFC<T> : KHFNPOBDEKJ<T[,]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x345FC50", Offset = "0x345EA50", VA = "0x18345FC50", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T[,] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x345F920", Offset = "0x345E720", VA = "0x18345F920", Slot = "5")]
	public T[,] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ADPNMFEPAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class HIADLEGKNGC<T> : KHFNPOBDEKJ<T[,,]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3581400", Offset = "0x3580200", VA = "0x183581400", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T[,,] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3580FC0", Offset = "0x357FDC0", VA = "0x183580FC0", Slot = "5")]
	public T[,,] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HIADLEGKNGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class KLBIDKKJPMA<T> : KHFNPOBDEKJ<T[,,,]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x389DD00", Offset = "0x389CB00", VA = "0x18389DD00", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T[,,,] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x389D7B0", Offset = "0x389C5B0", VA = "0x18389D7B0", Slot = "5")]
	public T[,,,] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KLBIDKKJPMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class CJDHAMMMOKB<T> : KHFNPOBDEKJ<T?>, NHMDNCPBKML where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x490EB10", Offset = "0x490D910", VA = "0x18490EB10", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x490E990", Offset = "0x490D790", VA = "0x18490E990", Slot = "5")]
	public T? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CJDHAMMMOKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GDPIONPMLGL<T> : KHFNPOBDEKJ<T?>, NHMDNCPBKML where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly KHFNPOBDEKJ<T> IPLHGMPHCHJ;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public GDPIONPMLGL(KHFNPOBDEKJ<T> IPLHGMPHCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x34A1DC0", Offset = "0x34A0BC0", VA = "0x1834A1DC0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, T? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x34A0890", Offset = "0x349F690", VA = "0x1834A0890", Slot = "5")]
	public T? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class HGHFNKLLHKD : KHFNPOBDEKJ<sbyte>, NHMDNCPBKML, LHIKEAPDNKI<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly HGHFNKLLHKD BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6419250", Offset = "0x6418050", VA = "0x186419250", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, sbyte GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6419200", Offset = "0x6418000", VA = "0x186419200", Slot = "5")]
	public sbyte EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x64192B0", Offset = "0x64180B0", VA = "0x1864192B0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, sbyte GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6419320", Offset = "0x6418120", VA = "0x186419320", Slot = "7")]
	public sbyte NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HGHFNKLLHKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class JEGJDFIPCCH : KHFNPOBDEKJ<sbyte?>, NHMDNCPBKML, LHIKEAPDNKI<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly JEGJDFIPCCH BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x641DAE0", Offset = "0x641C8E0", VA = "0x18641DAE0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, sbyte? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x641DA30", Offset = "0x641C830", VA = "0x18641DA30", Slot = "5")]
	public sbyte? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x641DBA0", Offset = "0x641C9A0", VA = "0x18641DBA0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, sbyte? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x641DC60", Offset = "0x641CA60", VA = "0x18641DC60", Slot = "7")]
	public sbyte? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JEGJDFIPCCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class BMNKMIKLCEO : KHFNPOBDEKJ<sbyte[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly BMNKMIKLCEO BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6412BE0", Offset = "0x64119E0", VA = "0x186412BE0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, sbyte[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6412A50", Offset = "0x6411850", VA = "0x186412A50", Slot = "5")]
	public sbyte[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BMNKMIKLCEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class HNABIJHDEOD : KHFNPOBDEKJ<short>, NHMDNCPBKML, LHIKEAPDNKI<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly HNABIJHDEOD BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6419AA0", Offset = "0x64188A0", VA = "0x186419AA0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, short GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6419A50", Offset = "0x6418850", VA = "0x186419A50", Slot = "5")]
	public short EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6419B00", Offset = "0x6418900", VA = "0x186419B00", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, short GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x6419B70", Offset = "0x6418970", VA = "0x186419B70", Slot = "7")]
	public short NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HNABIJHDEOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class JCBAKIINPCJ : KHFNPOBDEKJ<short?>, NHMDNCPBKML, LHIKEAPDNKI<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly JCBAKIINPCJ BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x641C530", Offset = "0x641B330", VA = "0x18641C530", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, short? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x641C480", Offset = "0x641B280", VA = "0x18641C480", Slot = "5")]
	public short? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x641C5F0", Offset = "0x641B3F0", VA = "0x18641C5F0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, short? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x641C6B0", Offset = "0x641B4B0", VA = "0x18641C6B0", Slot = "7")]
	public short? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JCBAKIINPCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class LANIIAJDJBO : KHFNPOBDEKJ<short[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly LANIIAJDJBO BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x641FE20", Offset = "0x641EC20", VA = "0x18641FE20", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, short[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x641FC90", Offset = "0x641EA90", VA = "0x18641FC90", Slot = "5")]
	public short[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LANIIAJDJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class KMNPOCKJKFI : KHFNPOBDEKJ<int>, NHMDNCPBKML, LHIKEAPDNKI<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly KMNPOCKJKFI BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x641F550", Offset = "0x641E350", VA = "0x18641F550", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, int GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x641F500", Offset = "0x641E300", VA = "0x18641F500", Slot = "5")]
	public int EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x641F5B0", Offset = "0x641E3B0", VA = "0x18641F5B0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, int GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x641F620", Offset = "0x641E420", VA = "0x18641F620", Slot = "7")]
	public int NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KMNPOCKJKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JKIJNCHGLNH : KHFNPOBDEKJ<int?>, NHMDNCPBKML, LHIKEAPDNKI<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly JKIJNCHGLNH BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x641E5C0", Offset = "0x641D3C0", VA = "0x18641E5C0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, int? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x641E510", Offset = "0x641D310", VA = "0x18641E510", Slot = "5")]
	public int? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x641E680", Offset = "0x641D480", VA = "0x18641E680", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, int? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x641E740", Offset = "0x641D540", VA = "0x18641E740", Slot = "7")]
	public int? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JKIJNCHGLNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class HDCBJKBIJJP : KHFNPOBDEKJ<int[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly HDCBJKBIJJP BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6418CD0", Offset = "0x6417AD0", VA = "0x186418CD0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, int[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6418B40", Offset = "0x6417940", VA = "0x186418B40", Slot = "5")]
	public int[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HDCBJKBIJJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class PDFIMMNHNMG : KHFNPOBDEKJ<long>, NHMDNCPBKML, LHIKEAPDNKI<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly PDFIMMNHNMG BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6423E40", Offset = "0x6422C40", VA = "0x186423E40", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, long GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6423DF0", Offset = "0x6422BF0", VA = "0x186423DF0", Slot = "5")]
	public long EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6423EA0", Offset = "0x6422CA0", VA = "0x186423EA0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, long GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6423F10", Offset = "0x6422D10", VA = "0x186423F10", Slot = "7")]
	public long NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public PDFIMMNHNMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class ICAPEJOHPGH : KHFNPOBDEKJ<long?>, NHMDNCPBKML, LHIKEAPDNKI<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly ICAPEJOHPGH BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x641A1C0", Offset = "0x6418FC0", VA = "0x18641A1C0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, long? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x641A100", Offset = "0x6418F00", VA = "0x18641A100", Slot = "5")]
	public long? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x641A280", Offset = "0x6419080", VA = "0x18641A280", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, long? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x641A340", Offset = "0x6419140", VA = "0x18641A340", Slot = "7")]
	public long? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ICAPEJOHPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class LJKLNDIMJGK : KHFNPOBDEKJ<long[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly LJKLNDIMJGK BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6421050", Offset = "0x641FE50", VA = "0x186421050", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, long[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6420EC0", Offset = "0x641FCC0", VA = "0x186420EC0", Slot = "5")]
	public long[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LJKLNDIMJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class INECIPJLKGK : KHFNPOBDEKJ<byte>, NHMDNCPBKML, LHIKEAPDNKI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly INECIPJLKGK BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x641B770", Offset = "0x641A570", VA = "0x18641B770", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, byte GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x641B720", Offset = "0x641A520", VA = "0x18641B720", Slot = "5")]
	public byte EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x641B7D0", Offset = "0x641A5D0", VA = "0x18641B7D0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, byte GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x641B840", Offset = "0x641A640", VA = "0x18641B840", Slot = "7")]
	public byte NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public INECIPJLKGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class FFDNABFOCPO : KHFNPOBDEKJ<byte?>, NHMDNCPBKML, LHIKEAPDNKI<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly FFDNABFOCPO BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6416050", Offset = "0x6414E50", VA = "0x186416050", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, byte? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6415FA0", Offset = "0x6414DA0", VA = "0x186415FA0", Slot = "5")]
	public byte? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6416110", Offset = "0x6414F10", VA = "0x186416110", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, byte? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x64161D0", Offset = "0x6414FD0", VA = "0x1864161D0", Slot = "7")]
	public byte? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FFDNABFOCPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class NKJLCMHKLFA : KHFNPOBDEKJ<ushort>, NHMDNCPBKML, LHIKEAPDNKI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly NKJLCMHKLFA BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6422350", Offset = "0x6421150", VA = "0x186422350", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ushort GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6422300", Offset = "0x6421100", VA = "0x186422300", Slot = "5")]
	public ushort EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x64223B0", Offset = "0x64211B0", VA = "0x1864223B0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, ushort GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x6422420", Offset = "0x6421220", VA = "0x186422420", Slot = "7")]
	public ushort NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NKJLCMHKLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class ICLCMLKJLNF : KHFNPOBDEKJ<ushort?>, NHMDNCPBKML, LHIKEAPDNKI<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly ICLCMLKJLNF BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x641A5B0", Offset = "0x64193B0", VA = "0x18641A5B0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ushort? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x641A500", Offset = "0x6419300", VA = "0x18641A500", Slot = "5")]
	public ushort? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x641A670", Offset = "0x6419470", VA = "0x18641A670", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, ushort? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x641A730", Offset = "0x6419530", VA = "0x18641A730", Slot = "7")]
	public ushort? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ICLCMLKJLNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class GMMLDHHDPHK : KHFNPOBDEKJ<ushort[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly GMMLDHHDPHK BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6417650", Offset = "0x6416450", VA = "0x186417650", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ushort[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x64174C0", Offset = "0x64162C0", VA = "0x1864174C0", Slot = "5")]
	public ushort[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public GMMLDHHDPHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class CKFMDBCOGIM : KHFNPOBDEKJ<uint>, NHMDNCPBKML, LHIKEAPDNKI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly CKFMDBCOGIM BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6412EA0", Offset = "0x6411CA0", VA = "0x186412EA0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, uint GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6412E50", Offset = "0x6411C50", VA = "0x186412E50", Slot = "5")]
	public uint EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6412F00", Offset = "0x6411D00", VA = "0x186412F00", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, uint GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6412F70", Offset = "0x6411D70", VA = "0x186412F70", Slot = "7")]
	public uint NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CKFMDBCOGIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class LLCCCKOBJIH : KHFNPOBDEKJ<uint?>, NHMDNCPBKML, LHIKEAPDNKI<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly LLCCCKOBJIH BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x64212B0", Offset = "0x64200B0", VA = "0x1864212B0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, uint? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6421200", Offset = "0x6420000", VA = "0x186421200", Slot = "5")]
	public uint? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6421370", Offset = "0x6420170", VA = "0x186421370", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, uint? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6421430", Offset = "0x6420230", VA = "0x186421430", Slot = "7")]
	public uint? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LLCCCKOBJIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class LFIJKIFHNLM : KHFNPOBDEKJ<uint[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly LFIJKIFHNLM BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6420940", Offset = "0x641F740", VA = "0x186420940", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, uint[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x64207B0", Offset = "0x641F5B0", VA = "0x1864207B0", Slot = "5")]
	public uint[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LFIJKIFHNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class FGEBMJPPLPD : KHFNPOBDEKJ<ulong>, NHMDNCPBKML, LHIKEAPDNKI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly FGEBMJPPLPD BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x64163C0", Offset = "0x64151C0", VA = "0x1864163C0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ulong GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6416370", Offset = "0x6415170", VA = "0x186416370", Slot = "5")]
	public ulong EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6416420", Offset = "0x6415220", VA = "0x186416420", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, ulong GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6416490", Offset = "0x6415290", VA = "0x186416490", Slot = "7")]
	public ulong NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FGEBMJPPLPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class DMBKDDCCJEH : KHFNPOBDEKJ<ulong?>, NHMDNCPBKML, LHIKEAPDNKI<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly DMBKDDCCJEH BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6414FB0", Offset = "0x6413DB0", VA = "0x186414FB0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ulong? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6414EF0", Offset = "0x6413CF0", VA = "0x186414EF0", Slot = "5")]
	public ulong? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6415070", Offset = "0x6413E70", VA = "0x186415070", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, ulong? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6415130", Offset = "0x6413F30", VA = "0x186415130", Slot = "7")]
	public ulong? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DMBKDDCCJEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class KDOKDBDJBKG : KHFNPOBDEKJ<ulong[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly KDOKDBDJBKG BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x641EBC0", Offset = "0x641D9C0", VA = "0x18641EBC0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ulong[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x641EA30", Offset = "0x641D830", VA = "0x18641EA30", Slot = "5")]
	public ulong[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KDOKDBDJBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class MMAKGPNGHEH : KHFNPOBDEKJ<float>, NHMDNCPBKML, LHIKEAPDNKI<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly MMAKGPNGHEH BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x64220F0", Offset = "0x6420EF0", VA = "0x1864220F0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, float GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x64220A0", Offset = "0x6420EA0", VA = "0x1864220A0", Slot = "5")]
	public float EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6422150", Offset = "0x6420F50", VA = "0x186422150", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, float GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x64221C0", Offset = "0x6420FC0", VA = "0x1864221C0", Slot = "7")]
	public float NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MMAKGPNGHEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class LGBGPFLPPCF : KHFNPOBDEKJ<float?>, NHMDNCPBKML, LHIKEAPDNKI<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly LGBGPFLPPCF BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6420BA0", Offset = "0x641F9A0", VA = "0x186420BA0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, float? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6420AF0", Offset = "0x641F8F0", VA = "0x186420AF0", Slot = "5")]
	public float? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6420C60", Offset = "0x641FA60", VA = "0x186420C60", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, float? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6420D20", Offset = "0x641FB20", VA = "0x186420D20", Slot = "7")]
	public float? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LGBGPFLPPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class JILNHFNJNBH : KHFNPOBDEKJ<float[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly JILNHFNJNBH BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x641E350", Offset = "0x641D150", VA = "0x18641E350", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, float[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x641E1C0", Offset = "0x641CFC0", VA = "0x18641E1C0", Slot = "5")]
	public float[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JILNHFNJNBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class ELDHADHKNIP : KHFNPOBDEKJ<double>, NHMDNCPBKML, LHIKEAPDNKI<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly ELDHADHKNIP BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x64158F0", Offset = "0x64146F0", VA = "0x1864158F0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, double GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x64158A0", Offset = "0x64146A0", VA = "0x1864158A0", Slot = "5")]
	public double EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6415950", Offset = "0x6414750", VA = "0x186415950", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, double GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x64159C0", Offset = "0x64147C0", VA = "0x1864159C0", Slot = "7")]
	public double NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ELDHADHKNIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class HKBMMPKIKBJ : KHFNPOBDEKJ<double?>, NHMDNCPBKML, LHIKEAPDNKI<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly HKBMMPKIKBJ BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6419710", Offset = "0x6418510", VA = "0x186419710", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, double? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6419650", Offset = "0x6418450", VA = "0x186419650", Slot = "5")]
	public double? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x64197D0", Offset = "0x64185D0", VA = "0x1864197D0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, double? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6419890", Offset = "0x6418690", VA = "0x186419890", Slot = "7")]
	public double? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HKBMMPKIKBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class OFGHJCNCLAE : KHFNPOBDEKJ<double[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly OFGHJCNCLAE BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x64226F0", Offset = "0x64214F0", VA = "0x1864226F0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, double[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6422560", Offset = "0x6421360", VA = "0x186422560", Slot = "5")]
	public double[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public OFGHJCNCLAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class MKPFMGNOCCC : KHFNPOBDEKJ<bool>, NHMDNCPBKML, LHIKEAPDNKI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly MKPFMGNOCCC BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6421E90", Offset = "0x6420C90", VA = "0x186421E90", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, bool GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6421E40", Offset = "0x6420C40", VA = "0x186421E40", Slot = "5")]
	public bool EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6421EF0", Offset = "0x6420CF0", VA = "0x186421EF0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, bool GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6421F60", Offset = "0x6420D60", VA = "0x186421F60", Slot = "7")]
	public bool NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MKPFMGNOCCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class EJKIIKLJMBK : KHFNPOBDEKJ<bool?>, NHMDNCPBKML, LHIKEAPDNKI<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly EJKIIKLJMBK BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6415580", Offset = "0x6414380", VA = "0x186415580", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, bool? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x64154D0", Offset = "0x64142D0", VA = "0x1864154D0", Slot = "5")]
	public bool? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6415640", Offset = "0x6414440", VA = "0x186415640", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, bool? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6415700", Offset = "0x6414500", VA = "0x186415700", Slot = "7")]
	public bool? NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EJKIIKLJMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class BCMHNGAHBPN : KHFNPOBDEKJ<bool[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly BCMHNGAHBPN BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6411180", Offset = "0x640FF80", VA = "0x186411180", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, bool[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6410FF0", Offset = "0x640FDF0", VA = "0x186410FF0", Slot = "5")]
	public bool[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BCMHNGAHBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class BIDNAGAHKAB : KHFNPOBDEKJ<object>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly KHFNPOBDEKJ<object> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> NIKKOCOHMHJ;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x64119A0", Offset = "0x64107A0", VA = "0x1864119A0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, object GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6411560", Offset = "0x6410360", VA = "0x186411560", Slot = "5")]
	public object EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BIDNAGAHKAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class HHFMAPHPMLF : KHFNPOBDEKJ<byte[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly KHFNPOBDEKJ<byte[]> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6419510", Offset = "0x6418310", VA = "0x186419510", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, byte[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6419460", Offset = "0x6418260", VA = "0x186419460", Slot = "5")]
	public byte[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HHFMAPHPMLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class FEBPOKLKKFO : KHFNPOBDEKJ<ArraySegment<byte>>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly KHFNPOBDEKJ<ArraySegment<byte>> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6415DF0", Offset = "0x6414BF0", VA = "0x186415DF0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, ArraySegment<byte> GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6415CE0", Offset = "0x6414AE0", VA = "0x186415CE0", Slot = "5")]
	public ArraySegment<byte> EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FEBPOKLKKFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class DNIGMBDMMEM : KHFNPOBDEKJ<string>, NHMDNCPBKML, LHIKEAPDNKI<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly KHFNPOBDEKJ<string> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6415340", Offset = "0x6414140", VA = "0x186415340", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, string GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x64152F0", Offset = "0x64140F0", VA = "0x1864152F0", Slot = "5")]
	public string EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x64153A0", Offset = "0x64141A0", VA = "0x1864153A0", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, string GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6415400", Offset = "0x6414200", VA = "0x186415400", Slot = "7")]
	public string NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DNIGMBDMMEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class HEGKPHLEGHM : KHFNPOBDEKJ<string[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly HEGKPHLEGHM BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6419050", Offset = "0x6417E50", VA = "0x186419050", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, string[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6418E80", Offset = "0x6417C80", VA = "0x186418E80", Slot = "5")]
	public string[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HEGKPHLEGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class HOBIFLDIFPJ : KHFNPOBDEKJ<char>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly HOBIFLDIFPJ BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6419D20", Offset = "0x6418B20", VA = "0x186419D20", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, char GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6419CB0", Offset = "0x6418AB0", VA = "0x186419CB0", Slot = "5")]
	public char EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HOBIFLDIFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class HPKAMOBGFJF : KHFNPOBDEKJ<char?>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly HPKAMOBGFJF BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6419F80", Offset = "0x6418D80", VA = "0x186419F80", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, char? GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6419E60", Offset = "0x6418C60", VA = "0x186419E60", Slot = "5")]
	public char? EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HPKAMOBGFJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class GELPMCCCFHN : KHFNPOBDEKJ<char[]>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly GELPMCCCFHN BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6417290", Offset = "0x6416090", VA = "0x186417290", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, char[] GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x64170D0", Offset = "0x6415ED0", VA = "0x1864170D0", Slot = "5")]
	public char[] EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public GELPMCCCFHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class FOLHFILOKOA : KHFNPOBDEKJ<Guid>, NHMDNCPBKML, LHIKEAPDNKI<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly KHFNPOBDEKJ<Guid> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6416D40", Offset = "0x6415B40", VA = "0x186416D40", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Guid GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6416CB0", Offset = "0x6415AB0", VA = "0x186416CB0", Slot = "5")]
	public Guid EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6416E70", Offset = "0x6415C70", VA = "0x186416E70", Slot = "6")]
	public void JABOKKCELNH(LKJMGENIDLC LCMOFCIALJC, Guid GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6416FB0", Offset = "0x6415DB0", VA = "0x186416FB0", Slot = "7")]
	public Guid NGNBBAMFFPJ(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FOLHFILOKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class FMPNCMAGEBH : KHFNPOBDEKJ<decimal>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly KHFNPOBDEKJ<decimal> BKEFLEENBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool HJCKDFLNGEK;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F28E60", Offset = "0x4F27C60", VA = "0x184F28E60")]
	public FMPNCMAGEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x15E1C10", Offset = "0x15E0A10", VA = "0x1815E1C10")]
	public FMPNCMAGEBH(bool HJCKDFLNGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6416870", Offset = "0x6415670", VA = "0x186416870", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, decimal GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x64165D0", Offset = "0x64153D0", VA = "0x1864165D0", Slot = "5")]
	public decimal EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class BDCFMIBLBCA : KHFNPOBDEKJ<Uri>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly KHFNPOBDEKJ<Uri> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x6411400", Offset = "0x6410200", VA = "0x186411400", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Uri GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6411340", Offset = "0x6410140", VA = "0x186411340", Slot = "5")]
	public Uri EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BDCFMIBLBCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class MBMDMBGKIAE : KHFNPOBDEKJ<Version>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly KHFNPOBDEKJ<Version> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6421D00", Offset = "0x6420B00", VA = "0x186421D00", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Version GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6421C40", Offset = "0x6420A40", VA = "0x186421C40", Slot = "5")]
	public Version EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MBMDMBGKIAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class EALIGGLKCFD<TKey, TValue> : KHFNPOBDEKJ<KeyValuePair<TKey, TValue>>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x3014C90", Offset = "0x3013A90", VA = "0x183014C90", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, KeyValuePair<TKey, TValue> GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x3014960", Offset = "0x3013760", VA = "0x183014960", Slot = "5")]
	public KeyValuePair<TKey, TValue> EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class FABOGGMBBKK : KHFNPOBDEKJ<StringBuilder>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly KHFNPOBDEKJ<StringBuilder> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6415BC0", Offset = "0x64149C0", VA = "0x186415BC0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, StringBuilder GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6415B00", Offset = "0x6414900", VA = "0x186415B00", Slot = "5")]
	public StringBuilder EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FABOGGMBBKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class KPFBCHEKFEJ : KHFNPOBDEKJ<BitArray>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly KHFNPOBDEKJ<BitArray> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x641F8E0", Offset = "0x641E6E0", VA = "0x18641F8E0", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, BitArray GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x641F760", Offset = "0x641E560", VA = "0x18641F760", Slot = "5")]
	public BitArray EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KPFBCHEKFEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class JICNMJEAECP : KHFNPOBDEKJ<Type>, NHMDNCPBKML
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly JICNMJEAECP BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex BFMFLPGEHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool DOGOLFABOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool PBEPFNIHHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool BGKLKDFGJFG;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x641E1A0", Offset = "0x641CFA0", VA = "0x18641E1A0")]
	public JICNMJEAECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x641E150", Offset = "0x641CF50", VA = "0x18641E150")]
	public JICNMJEAECP(bool DOGOLFABOOG, bool PBEPFNIHHEF, bool BGKLKDFGJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x641DF50", Offset = "0x641CD50", VA = "0x18641DF50", Slot = "4")]
	public void GKMCGBDALGF(LKJMGENIDLC LCMOFCIALJC, Type GNLEHBFFNFG, LHGMBMDOIPK NJICAOABNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x641DE00", Offset = "0x641CC00", VA = "0x18641DE00", Slot = "5")]
	public Type EFHLMHLMFOG(PLNICAEBGII POOKDLGIHHA, LHGMBMDOIPK NJICAOABNOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class FOCHLEHLBGL
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] CCCKACJLEDK;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly GGDFLHOFOKL LEJPMKHIPEP;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6416AA0", Offset = "0x64158A0", VA = "0x186416AA0")]
	static FOCHLEHLBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class LAFMFFFCJOI
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] JKIFHGGCGNN;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly GGDFLHOFOKL AJFMKMLDAGK;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x641FA80", Offset = "0x641E880", VA = "0x18641FA80")]
	static LAFMFFFCJOI()
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
