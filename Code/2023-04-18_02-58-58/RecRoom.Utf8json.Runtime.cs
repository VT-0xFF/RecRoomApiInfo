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
internal static class CFCGCEOBPDK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x53018A0", Offset = "0x5300AA0", VA = "0x1853018A0")]
	public static bool BDNDDLPGAGL(this TypeInfo NIFOGEBEDNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class JMDBGACNFGG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type HHDLLHEOEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] MGKGIPJMOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
	public JMDBGACNFGG(Type JENAKJODMEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor)]
public class LFKACEMKADP : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void AMOHMLHBBDA<T>(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T FAJIJCGCKEK<T>(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB BDEGGEFECLH);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CMMCGLEIHLB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MJFBLDENKJM<T> : CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PPHMOPOCDGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum PJFOAADHAFM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MJFBLDENKJM<T> KLMPKJMNLEL<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OKLPFOFEOOF
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2055B20", Offset = "0x2054D20", VA = "0x182055B20")]
	public static global::MJFBLDENKJM<T> IKHCIMADKPH<T>(this IGFJLJHHKLB BDEGGEFECLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4142F90", Offset = "0x4142190", VA = "0x184142F90")]
	public static object HHCJJMLDJJO(this IGFJLJHHKLB BDEGGEFECLH, Type NIFOGEBEDNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LKNOCPMFGDG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x413D040", Offset = "0x413C240", VA = "0x18413D040")]
	public LKNOCPMFGDG(string OFCFPGACNJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FJHDMMGBDPE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class KLOFOOODGLA
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] ACMMHKGMFIC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] KEEMDIOOFAC;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5B357B0", Offset = "0x5B349B0", VA = "0x185B357B0")]
		public static byte[] DEFDNCHMIIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5B35840", Offset = "0x5B34A40", VA = "0x185B35840")]
		public static char[] HBJDDJFHIEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> MJHPJCGOEFB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] BGCAAPKOOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] ODBGNNDKAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int MOHMCFDNHKH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool LMLNOEADEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53087F0", Offset = "0x53079F0", VA = "0x1853087F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x530A1D0", Offset = "0x53093D0", VA = "0x18530A1D0")]
	public FJHDMMGBDPE(byte[] ODBGNNDKAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5309FE0", Offset = "0x53091E0", VA = "0x185309FE0")]
	public FJHDMMGBDPE(byte[] ODBGNNDKAMK, int MOHMCFDNHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5309310", Offset = "0x5308510", VA = "0x185309310")]
	private HJAELLKNEND KHJPJHIBBBP(string NAABJGGIBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5307640", Offset = "0x5306840", VA = "0x185307640")]
	private HJAELLKNEND ANOOKIIDJDJ(string OFCFPGACNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x53036C0", Offset = "0x53028C0", VA = "0x1853036C0")]
	public void LBELJKHMMJA(int MOHMCFDNHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
	public byte[] ACJNNEMGDIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1448B70", Offset = "0x1447D70", VA = "0x181448B70")]
	public int BAPOKMDAAAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5307370", Offset = "0x5306570", VA = "0x185307370")]
	public PDOJGHBFIAK ALKLJINEAEH()
	{
		return default(PDOJGHBFIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5308B40", Offset = "0x5307D40", VA = "0x185308B40")]
	public void FPGOKPDCKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5308C80", Offset = "0x5307E80", VA = "0x185308C80")]
	public bool GFODJNFMMIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x53091C0", Offset = "0x53083C0", VA = "0x1853091C0")]
	public bool KGEFAMJBGCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5309280", Offset = "0x5308480", VA = "0x185309280")]
	public void KHEHCBJFFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5309220", Offset = "0x5308420", VA = "0x185309220")]
	public bool KGINHEJKPKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5309B20", Offset = "0x5308D20", VA = "0x185309B20")]
	public bool MFPGALJAPEC(ref int BFFJHKFEFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5309E20", Offset = "0x5309020", VA = "0x185309E20")]
	public bool PNLPLNKIKEO(ref int BFFJHKFEFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5309BA0", Offset = "0x5308DA0", VA = "0x185309BA0")]
	public bool MHLMLFFIDLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5307A80", Offset = "0x5306C80", VA = "0x185307A80")]
	public void BEAKBJPECOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5309D60", Offset = "0x5308F60", VA = "0x185309D60")]
	public bool PKHKKJIGIOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5307CD0", Offset = "0x5306ED0", VA = "0x185307CD0")]
	public bool CNJMGLEPDKP(ref int BFFJHKFEFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5309C00", Offset = "0x5308E00", VA = "0x185309C00")]
	public bool NFKNIDMNFBC(ref int BFFJHKFEFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5307A20", Offset = "0x5306C20", VA = "0x185307A20")]
	public bool BCLKCLGNBKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5308F50", Offset = "0x5308150", VA = "0x185308F50")]
	public void JENFBLBELHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5309160", Offset = "0x5308360", VA = "0x185309160")]
	public bool KENNMNGLKOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x53072E0", Offset = "0x53064E0", VA = "0x1853072E0")]
	public void AJGHGGLJJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5307D50", Offset = "0x5306F50", VA = "0x185307D50")]
	private void DJAFBEFONAL(out byte[] OCMDOHFOPPG, out int KOMIIPBIOGE, out int EOGMBBJNPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5308810", Offset = "0x5307A10", VA = "0x185308810")]
	private static int FCCKGODJODD(char NNMPJECKECI, char EFNJCAIBDLA, char DHNNLHJMKIH, char ENDFPEOPAIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5307770", Offset = "0x5306970", VA = "0x185307770")]
	private static int BBBCEJJPHPB(char FCCGDNMAHPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5307B10", Offset = "0x5306D10", VA = "0x185307B10")]
	public ArraySegment<byte> BECDKKDBNJL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5308750", Offset = "0x5307950", VA = "0x185308750")]
	public string EEDIIACAMJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5309D30", Offset = "0x5308F30", VA = "0x185309D30")]
	public string PDIGJHGLDFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5309880", Offset = "0x5308A80", VA = "0x185309880")]
	public ArraySegment<byte> MBJDPBHNIDP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5308FE0", Offset = "0x53081E0", VA = "0x185308FE0")]
	public ArraySegment<byte> JHBOIHCALGB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5308510", Offset = "0x5307710", VA = "0x185308510")]
	public bool DKOIACAANKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5309020", Offset = "0x5308220", VA = "0x185309020")]
	private static bool JJFMPHBHHJG(byte DHNNLHJMKIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5307840", Offset = "0x5306A40", VA = "0x185307840")]
	private void BBHJMPDJOIP(PDOJGHBFIAK IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5309D20", Offset = "0x5308F20", VA = "0x185309D20")]
	public void OKMBPONNPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5309A50", Offset = "0x5308C50", VA = "0x185309A50")]
	private void MCCCACBHOJB(int HKMGGJBAIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5307720", Offset = "0x5306920", VA = "0x185307720")]
	public sbyte AOIPIMOPOPL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5309DC0", Offset = "0x5308FC0", VA = "0x185309DC0")]
	public short PLGGLDEDBIC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5309CC0", Offset = "0x5308EC0", VA = "0x185309CC0")]
	public int NLNCMJCKKOA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5308ED0", Offset = "0x53080D0", VA = "0x185308ED0")]
	public long HHOEMGILLNG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5307C10", Offset = "0x5306E10", VA = "0x185307C10")]
	public byte BIMHFEKANEE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5307C70", Offset = "0x5306E70", VA = "0x185307C70")]
	public ushort BJPHMCADDFA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5309820", Offset = "0x5308A20", VA = "0x185309820")]
	public uint KJEAGNNNHNK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x53090E0", Offset = "0x53082E0", VA = "0x1853090E0")]
	public ulong JKJEKKDKBKJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x53074F0", Offset = "0x53066F0", VA = "0x1853074F0")]
	public float ANAELJCBNBC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5308D80", Offset = "0x5307F80", VA = "0x185308D80")]
	public double GMMGKJKLPBM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5308A50", Offset = "0x5307C50", VA = "0x185308A50")]
	public ArraySegment<byte> FMJEOGKAHAO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x53088C0", Offset = "0x5307AC0", VA = "0x1853088C0")]
	private static int FKCAMPGPODM(byte[] ODBGNNDKAMK, int MOHMCFDNHKH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HJAELLKNEND : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference KCGGHICFGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int CKKJBLGGKKM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DPPCOOILPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x16996C0", Offset = "0x16988C0", VA = "0x1816996C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string JMIELDPPHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x91E5B0", Offset = "0x91D7B0", VA = "0x18091E5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4132550", Offset = "0x4131750", VA = "0x184132550")]
	public HJAELLKNEND(string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4132470", Offset = "0x4131670", VA = "0x184132470")]
	public HJAELLKNEND(string OFCFPGACNJB, byte[] EAIDPNOHPGE, int MOHMCFDNHKH, int CKKJBLGGKKM, string CCGKPHKJIBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KIIINOPMMME
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class PFBGGJEAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private delegate void HEFGMOPIAMJ(ref DDGHBCECKPK KOODAEDNKIK, object IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private delegate object BIAEKHNIGDP(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB BDEGGEFECLH);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class BHDCJJBNKIC
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class ANKFDDDHMIF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
				public ANKFDDDHMIF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x34B6950", Offset = "0x34B5B50", VA = "0x1834B6950")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x5B2C440", Offset = "0x5B2B640", VA = "0x185B2C440")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, IGFJLJHHKLB, byte[]> LIPDMMACDIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, IGFJLJHHKLB> BABDLCFLGHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly HEFGMOPIAMJ MHJCHMHBDEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, IGFJLJHHKLB, ArraySegment<byte>> CCKJDJLMHME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, IGFJLJHHKLB, string> GLKOHIBNLGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, IGFJLJHHKLB, object> NINCAGJHCGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, IGFJLJHHKLB, object> HNJDGIALFIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, IGFJLJHHKLB, object> JFAPMNEEBGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly BIAEKHNIGDP MGICPEJACKL;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5B2C890", Offset = "0x5B2BA90", VA = "0x185B2C890")]
			public BHDCJJBNKIC(Type NIFOGEBEDNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x67970C0", Offset = "0x67962C0", VA = "0x1867970C0")]
			private static T FNNHDDKNODK<T>(DynamicMethod HNMKMNMOACM)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5B2C640", Offset = "0x5B2B840", VA = "0x185B2C640")]
			private static MethodInfo ACNOGFAHKCB(Type NIFOGEBEDNG, string KNOPFGAGMCN, Type[] INOAEEAJEDE)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, BHDCJJBNKIC> NBOJPHIJKGP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::MMJCLDFMIOC<BHDCJJBNKIC> DOIAJIOECEN;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5B39870", Offset = "0x5B38A70", VA = "0x185B39870")]
		static PFBGGJEAKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5B39530", Offset = "0x5B38730", VA = "0x185B39530")]
		private static BHDCJJBNKIC GFMNNFCLLJF(Type NIFOGEBEDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5B395C0", Offset = "0x5B387C0", VA = "0x185B395C0")]
		public static void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, object IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5B39750", Offset = "0x5B38950", VA = "0x185B39750")]
		public static void IIADKJHBOIN(Type NIFOGEBEDNG, ref DDGHBCECKPK KOODAEDNKIK, object IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class BKDAGAOMIGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] ACMMHKGMFIC;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5B2E620", Offset = "0x5B2D820", VA = "0x185B2E620")]
		public static byte[] DEFDNCHMIIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static IGFJLJHHKLB HBNJBKCGKCK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] ICKCGEDGCLI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] FDNDGIJBHKF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static IGFJLJHHKLB LPMBFEFOIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x41397C0", Offset = "0x41389C0", VA = "0x1841397C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KKKHNMGIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4139490", Offset = "0x4138690", VA = "0x184139490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41394F0", Offset = "0x41386F0", VA = "0x1841394F0")]
	public static void FHAEENPLODD(IGFJLJHHKLB BDEGGEFECLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x12F6590", Offset = "0x12F5790", VA = "0x1812F6590")]
	public static byte[] IIADKJHBOIN<T>(T ICHBECDKHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x12F6430", Offset = "0x12F5630", VA = "0x1812F6430")]
	public static byte[] IIADKJHBOIN<T>(T IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x12F63A0", Offset = "0x12F55A0", VA = "0x1812F63A0")]
	public static void IIADKJHBOIN<T>(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x21F95B0", Offset = "0x21F87B0", VA = "0x1821F95B0")]
	public static void IIADKJHBOIN<T>(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x21F9400", Offset = "0x21F8600", VA = "0x1821F9400")]
	public static void IIADKJHBOIN<T>(Stream EDIGAFOKGOJ, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21F9490", Offset = "0x21F8690", VA = "0x1821F9490")]
	public static void IIADKJHBOIN<T>(Stream EDIGAFOKGOJ, T IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x12F6180", Offset = "0x12F5380", VA = "0x1812F6180")]
	public static ArraySegment<byte> GLNPDLLNFLN<T>(T ICHBECDKHOJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x12F6220", Offset = "0x12F5420", VA = "0x1812F6220")]
	public static ArraySegment<byte> GLNPDLLNFLN<T>(T IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x21F97F0", Offset = "0x21F89F0", VA = "0x1821F97F0")]
	public static string POEPMJIMMHH<T>(T IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x21F9690", Offset = "0x21F8890", VA = "0x1821F9690")]
	public static string POEPMJIMMHH<T>(T IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x12F57B0", Offset = "0x12F49B0", VA = "0x1812F57B0")]
	public static T BBCFAILGGHN<T>(string EDEOADKJLJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x12F56C0", Offset = "0x12F48C0", VA = "0x1812F56C0")]
	public static T BBCFAILGGHN<T>(string EDEOADKJLJK, IGFJLJHHKLB BDEGGEFECLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x12F5A50", Offset = "0x12F4C50", VA = "0x1812F5A50")]
	public static T BBCFAILGGHN<T>(byte[] ODBGNNDKAMK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x12F59B0", Offset = "0x12F4BB0", VA = "0x1812F59B0")]
	public static T BBCFAILGGHN<T>(byte[] ODBGNNDKAMK, IGFJLJHHKLB BDEGGEFECLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12F5C80", Offset = "0x12F4E80", VA = "0x1812F5C80")]
	public static T BBCFAILGGHN<T>(byte[] ODBGNNDKAMK, int MOHMCFDNHKH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x12F5850", Offset = "0x12F4A50", VA = "0x1812F5850")]
	public static T BBCFAILGGHN<T>(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, IGFJLJHHKLB BDEGGEFECLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x12F5E10", Offset = "0x12F5010", VA = "0x1812F5E10")]
	public static T BBCFAILGGHN<T>(ref FJHDMMGBDPE EFKJIOEDNFB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x12F5AD0", Offset = "0x12F4CD0", VA = "0x1812F5AD0")]
	public static T BBCFAILGGHN<T>(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB BDEGGEFECLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x12F6100", Offset = "0x12F5300", VA = "0x1812F6100")]
	public static T BBCFAILGGHN<T>(Stream EDIGAFOKGOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x12F5FD0", Offset = "0x12F51D0", VA = "0x1812F5FD0")]
	public static T BBCFAILGGHN<T>(Stream EDIGAFOKGOJ, IGFJLJHHKLB BDEGGEFECLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x41396E0", Offset = "0x41388E0", VA = "0x1841396E0")]
	public static string FIMGMCIMPPI(byte[] EDEOADKJLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4139630", Offset = "0x4138830", VA = "0x184139630")]
	public static string FIMGMCIMPPI(byte[] EDEOADKJLJK, int MOHMCFDNHKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4139560", Offset = "0x4138760", VA = "0x184139560")]
	public static string FIMGMCIMPPI(string EDEOADKJLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4139A60", Offset = "0x4138C60", VA = "0x184139A60")]
	public static byte[] NIPFCFCMGKG(byte[] EDEOADKJLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41398E0", Offset = "0x4138AE0", VA = "0x1841398E0")]
	public static byte[] NIPFCFCMGKG(byte[] EDEOADKJLJK, int MOHMCFDNHKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4139990", Offset = "0x4138B90", VA = "0x184139990")]
	public static byte[] NIPFCFCMGKG(string EDEOADKJLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4138FA0", Offset = "0x41381A0", VA = "0x184138FA0")]
	private static void DIDFGNDDKAD(ref FJHDMMGBDPE EFKJIOEDNFB, ref DDGHBCECKPK KOODAEDNKIK, int GADEOBMPDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4138F00", Offset = "0x4138100", VA = "0x184138F00")]
	private static int BHONKLDLHNO(Stream KAEDAICECGN, ref byte[] ACMMHKGMFIC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum PDOJGHBFIAK : byte
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
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DDGHBCECKPK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] ADOHJOFJMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] ACMMHKGMFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int MOHMCFDNHKH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BLLBGKOFNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1448B70", Offset = "0x1447D70", VA = "0x181448B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x53036C0", Offset = "0x53028C0", VA = "0x1853036C0")]
	public void LBELJKHMMJA(int MOHMCFDNHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5302F50", Offset = "0x5302150", VA = "0x185302F50")]
	public static byte[] GKHCFALAKJA(string OPCKJKNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5302C70", Offset = "0x5301E70", VA = "0x185302C70")]
	public static byte[] EAOLPJNFBGJ(string OPCKJKNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5303A90", Offset = "0x5302C90", VA = "0x185303A90")]
	public static byte[] PJJHMLBBBOK(string OPCKJKNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53038E0", Offset = "0x5302AE0", VA = "0x1853038E0")]
	public static byte[] OFKHBICFODC(string OPCKJKNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5303C90", Offset = "0x5302E90", VA = "0x185303C90")]
	public DDGHBCECKPK(byte[] HEILCMKDEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5302BC0", Offset = "0x5301DC0", VA = "0x185302BC0")]
	public ArraySegment<byte> DEFDNCHMIIM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5303640", Offset = "0x5302840", VA = "0x185303640")]
	public byte[] LAMBLDLDEKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5303BD0", Offset = "0x5302DD0", VA = "0x185303BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5302E80", Offset = "0x5302080", VA = "0x185302E80")]
	public void ENLOKNJJMLM(int GKOCPEHLLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5302840", Offset = "0x5301A40", VA = "0x185302840")]
	public void BJCAJCOFMMN(byte GMLDEHJHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x53028A0", Offset = "0x5301AA0", VA = "0x1853028A0")]
	public void BJCAJCOFMMN(byte[] GMLDEHJHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5302EC0", Offset = "0x53020C0", VA = "0x185302EC0")]
	public void FAGGJIENKMN(byte GMLDEHJHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5303890", Offset = "0x5302A90", VA = "0x185303890")]
	public void OCIDGKAIPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5303590", Offset = "0x5302790", VA = "0x185303590")]
	public void HMFNGNFKJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5302900", Offset = "0x5301B00", VA = "0x185302900")]
	public void CIBANBIIOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5302F00", Offset = "0x5302100", VA = "0x185302F00")]
	public void GHIFDCEHDHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5302E30", Offset = "0x5302030", VA = "0x185302E30")]
	public void ENLHJEHCAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5302950", Offset = "0x5301B50", VA = "0x185302950")]
	public void CLPKIGFNGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5303830", Offset = "0x5302A30", VA = "0x185303830")]
	public void NBCILLIKFAG(string OPCKJKNEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5302DE0", Offset = "0x5301FE0", VA = "0x185302DE0")]
	public void ELEDCGBOOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5302770", Offset = "0x5301970", VA = "0x185302770")]
	public void BHPOPIHHDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x53029D0", Offset = "0x5301BD0", VA = "0x1853029D0")]
	public void CPCEPGNDOGD(bool IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5303030", Offset = "0x5302230", VA = "0x185303030")]
	public void HANPLHEIKPL(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x53036D0", Offset = "0x53028D0", VA = "0x1853036D0")]
	public void LFOJKNNDKIJ(double IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x53029A0", Offset = "0x5301BA0", VA = "0x1853029A0")]
	public void CNBPKIKPGBK(byte IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5303610", Offset = "0x5302810", VA = "0x185303610")]
	public void JLLDOKBDEBM(ushort IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5303A30", Offset = "0x5302C30", VA = "0x185303A30")]
	public void OLHJKFCNLBO(uint IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5302DB0", Offset = "0x5301FB0", VA = "0x185302DB0")]
	public void EEHEDLGLNOK(ulong IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x53035E0", Offset = "0x53027E0", VA = "0x1853035E0")]
	public void JCCELFBACPO(sbyte IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5303A60", Offset = "0x5302C60", VA = "0x185303A60")]
	public void ONFGILKNEBI(short IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5303190", Offset = "0x5302390", VA = "0x185303190")]
	public void HKLKJGKHBMO(int IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5302E90", Offset = "0x5302090", VA = "0x185302E90")]
	public void EPIDINPINFB(long IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x53031C0", Offset = "0x53023C0", VA = "0x1853031C0")]
	public void HLFCIKOBDNI(string IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EFIPNBCAOJO : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private static class EJNCJHPIBNI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x27E9530", Offset = "0x27E8730", VA = "0x1827E9530")]
		static EJNCJHPIBNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private EFIPNBCAOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class IBLNBKELOPM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> KIDBANHGEAC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4135710", Offset = "0x4134910", VA = "0x184135710")]
	static IBLNBKELOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4135000", Offset = "0x4134200", VA = "0x184135000")]
	internal static object KLMPKJMNLEL(Type IHPJCBCPLCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class MPOHBEGLOOL : global::MJFBLDENKJM<Vector2>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KIDNBPBMGMO NDPCKELFFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] DLPJHHIHOLN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4140C70", Offset = "0x413FE70", VA = "0x184140C70")]
	public MPOHBEGLOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4140BC0", Offset = "0x413FDC0", VA = "0x184140BC0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Vector2 IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x41409C0", Offset = "0x413FBC0", VA = "0x1841409C0", Slot = "5")]
	public Vector2 BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class NMMHIEJKMKA : global::MJFBLDENKJM<Vector3>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KIDNBPBMGMO NDPCKELFFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] DLPJHHIHOLN;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4142090", Offset = "0x4141290", VA = "0x184142090")]
	public NMMHIEJKMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4141F70", Offset = "0x4141170", VA = "0x184141F70", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Vector3 IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4141D40", Offset = "0x4140F40", VA = "0x184141D40", Slot = "5")]
	public Vector3 BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class OOEJBIOKILP : global::MJFBLDENKJM<Vector4>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly KIDNBPBMGMO NDPCKELFFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] DLPJHHIHOLN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4143550", Offset = "0x4142750", VA = "0x184143550")]
	public OOEJBIOKILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4131930", Offset = "0x4130B30", VA = "0x184131930", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Vector4 IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x41432C0", Offset = "0x41424C0", VA = "0x1841432C0", Slot = "5")]
	public Vector4 BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class HBPFCANFNPH : global::MJFBLDENKJM<Quaternion>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly KIDNBPBMGMO NDPCKELFFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] DLPJHHIHOLN;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4131A80", Offset = "0x4130C80", VA = "0x184131A80")]
	public HBPFCANFNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4131930", Offset = "0x4130B30", VA = "0x184131930", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Quaternion IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x41316A0", Offset = "0x41308A0", VA = "0x1841316A0", Slot = "5")]
	public Quaternion BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FIILLJCAKBI : global::MJFBLDENKJM<Color>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly KIDNBPBMGMO NDPCKELFFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] DLPJHHIHOLN;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5306E90", Offset = "0x5306090", VA = "0x185306E90")]
	public FIILLJCAKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5306C20", Offset = "0x5305E20", VA = "0x185306C20", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Color IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x53068A0", Offset = "0x5305AA0", VA = "0x1853068A0", Slot = "5")]
	public Color BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MOMNHKOOCDB : global::MJFBLDENKJM<Bounds>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly KIDNBPBMGMO NDPCKELFFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] DLPJHHIHOLN;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x41406B0", Offset = "0x413F8B0", VA = "0x1841406B0")]
	public MOMNHKOOCDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4140510", Offset = "0x413F710", VA = "0x184140510", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Bounds IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x41401E0", Offset = "0x413F3E0", VA = "0x1841401E0", Slot = "5")]
	public Bounds BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OPBMFCEFEBO : global::MJFBLDENKJM<Rect>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly KIDNBPBMGMO NDPCKELFFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] DLPJHHIHOLN;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4143CE0", Offset = "0x4142EE0", VA = "0x184143CE0")]
	public OPBMFCEFEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4143B70", Offset = "0x4142D70", VA = "0x184143B70", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Rect IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x41438C0", Offset = "0x4142AC0", VA = "0x1841438C0", Slot = "5")]
	public Rect BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class KOICFLMPDEI : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class HNJLNDOINEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BBA0", Offset = "0x2C7ADA0", VA = "0x182C7BBA0")]
		static HNJLNDOINEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private KOICFLMPDEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class IPEEHCGGIGD : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class PDMGLFFNKDO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x30C2190", Offset = "0x30C1390", VA = "0x1830C2190")]
		static PDMGLFFNKDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class PDOKHJDFAPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> IEGIBIPDPGD;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B37460", Offset = "0x5B36660", VA = "0x185B37460")]
		internal static object KLMPKJMNLEL(Type IHPJCBCPLCM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private IPEEHCGGIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class BKBNBINCIBO : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class PEOCDOCAELE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x30CC5E0", Offset = "0x30CB7E0", VA = "0x1830CC5E0")]
		static PEOCDOCAELE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BKBNBINCIBO OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool MOKJGOFNACD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static CMMCGLEIHLB[] ALAMHENIEGC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static IGFJLJHHKLB[] HJCMBBKEBGJ;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private BKBNBINCIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x52FC9F0", Offset = "0x52FBBF0", VA = "0x1852FC9F0")]
	public static void BNAKCAAHHPA(params IGFJLJHHKLB[] HJCMBBKEBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x52FC910", Offset = "0x52FBB10", VA = "0x1852FC910")]
	public static void BNAKCAAHHPA(params CMMCGLEIHLB[] ALAMHENIEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x52FCAD0", Offset = "0x52FBCD0", VA = "0x1852FCAD0")]
	public static void JCANOIKBDMF(CMMCGLEIHLB[] ALAMHENIEGC, IGFJLJHHKLB[] HJCMBBKEBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class CAKCKDAOPPM : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class INDFIOBIBGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1B417E0", Offset = "0x1B409E0", VA = "0x181B417E0")]
		static INDFIOBIBGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private CAKCKDAOPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class APHKDMMBDHB
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly IGFJLJHHKLB FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly IGFJLJHHKLB GHLLGDPAHAO;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly IGFJLJHHKLB JPLMMKLKNLJ;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IGFJLJHHKLB DAJPNLDOPDC;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly IGFJLJHHKLB CCEBOAEKBKF;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly IGFJLJHHKLB PAMONOLNMIJ;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly IGFJLJHHKLB FCDOJHDMLNC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly IGFJLJHHKLB EIFADKJHJDC;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly IGFJLJHHKLB NLACNLGFOHD;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly IGFJLJHHKLB ANHKPNBDHJP;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly IGFJLJHHKLB JBFLNIJEJOA;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IGFJLJHHKLB LECMJJKCJBK;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PDLMBBJGBNM
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly IGFJLJHHKLB FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IGFJLJHHKLB GPMBCEHDPGM;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NPMMGCNHLOE
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly IGFJLJHHKLB FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly IGFJLJHHKLB GHLLGDPAHAO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IGFJLJHHKLB JPLMMKLKNLJ;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly IGFJLJHHKLB DAJPNLDOPDC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IGFJLJHHKLB CCEBOAEKBKF;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly IGFJLJHHKLB PAMONOLNMIJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly IGFJLJHHKLB FCDOJHDMLNC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly IGFJLJHHKLB EIFADKJHJDC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly IGFJLJHHKLB NLACNLGFOHD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IGFJLJHHKLB ANHKPNBDHJP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly IGFJLJHHKLB JBFLNIJEJOA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly IGFJLJHHKLB LECMJJKCJBK;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class GHMGLMHKPDN
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> IEGIBIPDPGD;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x530C8D0", Offset = "0x530BAD0", VA = "0x18530C8D0")]
	internal static object KLMPKJMNLEL(Type IHPJCBCPLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x530C890", Offset = "0x530BA90", VA = "0x18530C890")]
	private static object BDHEJHFGHEN(Type GPLHBBFDLGO, Type[] HCMGHCHPMKB, params object[] INOAEEAJEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PMPHMHEAIIP : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private static class ADPLKEKOLKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1BAFFE0", Offset = "0x1BAF1E0", VA = "0x181BAFFE0")]
		static ADPLKEKOLKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly GCHJEGHPOFH BLKAGIDAFMH;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AFF0", Offset = "0x5B3A1F0", VA = "0x185B3AFF0")]
	static PMPHMHEAIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private PMPHMHEAIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EHOMINFKPFI : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class MDDPAEMEFAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x261BAA0", Offset = "0x261ACA0", VA = "0x18261BAA0")]
		static MDDPAEMEFAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly GCHJEGHPOFH BLKAGIDAFMH;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5305160", Offset = "0x5304360", VA = "0x185305160")]
	static EHOMINFKPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private EHOMINFKPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class DFGIOBLMMGL : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class OEEGDOACCAD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D840", Offset = "0x2A2CA40", VA = "0x182A2D840")]
		static OEEGDOACCAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly GCHJEGHPOFH BLKAGIDAFMH;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5303CB0", Offset = "0x5302EB0", VA = "0x185303CB0")]
	static DFGIOBLMMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private DFGIOBLMMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class DOOOCBPJIKC : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class HJEIJCGMFBD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C63550", Offset = "0x2C62750", VA = "0x182C63550")]
		static HJEIJCGMFBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly GCHJEGHPOFH BLKAGIDAFMH;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x53046A0", Offset = "0x53038A0", VA = "0x1853046A0")]
	static DOOOCBPJIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private DOOOCBPJIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class JKABDODKMIF : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class CHCBILLNKAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C20560", Offset = "0x2C1F760", VA = "0x182C20560")]
		static CHCBILLNKAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly GCHJEGHPOFH BLKAGIDAFMH;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4137160", Offset = "0x4136360", VA = "0x184137160")]
	static JKABDODKMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private JKABDODKMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class GKBGFINHECN : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class DFLKIHIIBMK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2071E20", Offset = "0x2071020", VA = "0x182071E20")]
		static DFLKIHIIBMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly GCHJEGHPOFH BLKAGIDAFMH;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x530E7A0", Offset = "0x530D9A0", VA = "0x18530E7A0")]
	static GKBGFINHECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private GKBGFINHECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class NGKNDJLMEPD : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class HONBEIGMAMF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2C81160", Offset = "0x2C80360", VA = "0x182C81160")]
		static HONBEIGMAMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NGKNDJLMEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class EIJFGCCPFAH : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class MDLBGIBNDJL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x26200D0", Offset = "0x261F2D0", VA = "0x1826200D0")]
		static MDLBGIBNDJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EIJFGCCPFAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class KGMNINFPOBC : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class AFKIDJFBPFG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x29E93F0", Offset = "0x29E85F0", VA = "0x1829E93F0")]
		static AFKIDJFBPFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public KGMNINFPOBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class IHHNOABHIAM : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class EGBPCMAMGKE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2397A00", Offset = "0x2396C00", VA = "0x182397A00")]
		static EGBPCMAMGKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public IHHNOABHIAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class GEFHHAAMGLK : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class GKJBJLLPIGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x23B4CE0", Offset = "0x23B3EE0", VA = "0x1823B4CE0")]
		static GKJBJLLPIGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public GEFHHAAMGLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class JOIGFEFDMEN : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class BLOKPJAOBKB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3220", Offset = "0x1EB2420", VA = "0x181EB3220")]
		static BLOKPJAOBKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> JGDHDFIDFCL;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool HFLMIOMPICI;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public JOIGFEFDMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class PAIMLKHBAJH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct ADLPKGKIMJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BLHGAMPKFIL LNANMCNHEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder IEGOPMBPEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder CBKDOPOKOJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class JJHELEMHJGF
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		internal static class JNJCMMBLIEA
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo PJJHMLBBBOK;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo EAOLPJNFBGJ;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo OFKHBICFODC;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo GKHCFALAKJA;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo BHPOPIHHDKD;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo BJCAJCOFMMN;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo CIBANBIIOBL;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo GHIFDCEHDHN;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo ENLHJEHCAEA;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5B33370", Offset = "0x5B32570", VA = "0x185B33370")]
			static JNJCMMBLIEA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class KCPPEEMMLAB
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo GFODJNFMMIK;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo BEAKBJPECOF;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo CNJMGLEPDKP;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo IHGIJOIBAGL;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo OKMBPONNPEF;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo ACJNNEMGDIN;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo BAPOKMDAAAO;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x5B34150", Offset = "0x5B33350", VA = "0x185B34150")]
			static KCPPEEMMLAB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class NAICGIOPJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo HHDLLHEOEPH;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo MGKGIPJMOPK;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo OMLGIENHMDI;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo IKHCIMADKPH;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo DGOMIJGGLFG;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo BDMCKEJDCAP;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo FMFFHBDKMJB;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo JCIECOMBLFA;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo ALGIEKIEOLM;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo CJCIBIBJLNO;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo ODJDANBENHP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo HKJANMEEGME;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo AEGGAPGDKAF;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo MHFGJAADLMK;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5B31900", Offset = "0x5B30B00", VA = "0x185B31900")]
		public static MethodInfo IIADKJHBOIN(Type NIFOGEBEDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5B31690", Offset = "0x5B30890", VA = "0x185B31690")]
		public static MethodInfo BBCFAILGGHN(Type NIFOGEBEDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5B31BD0", Offset = "0x5B30DD0", VA = "0x185B31BD0")]
		public static MethodInfo MPDAHCKBEIK(Type NIFOGEBEDNG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class JIMFHHKNMOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<BLHGAMPKFIL, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public JIMFHHKNMOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class NFNGOOGCPFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public JIMFHHKNMOG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NFNGOOGCPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5B367C0", Offset = "0x5B359C0", VA = "0x185B367C0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5B36800", Offset = "0x5B35A00", VA = "0x185B36800")]
		internal bool <BuildType>b__2(int index, BLHGAMPKFIL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class OACNGDIOODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JIMFHHKNMOG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public OACNGDIOODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5B369C0", Offset = "0x5B35BC0", VA = "0x185B369C0")]
		internal bool <BuildType>b__3(int index, BLHGAMPKFIL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EMIHEIGOKLI
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

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public EMIHEIGOKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F800", Offset = "0x5B2EA00", VA = "0x185B2F800")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class EHIHCOHOAND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public EHIHCOHOAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F7A0", Offset = "0x5B2E9A0", VA = "0x185B2F7A0")]
		internal bool <BuildAnonymousFormatter>b__2(BLHGAMPKFIL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class JHFEIEJECNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EMIHEIGOKLI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public JHFEIEJECNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5B314E0", Offset = "0x5B306E0", VA = "0x185B314E0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5B314F0", Offset = "0x5B306F0", VA = "0x185B314F0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, BLHGAMPKFIL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class KEIMBADIGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public EMIHEIGOKLI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public KEIMBADIGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5B34D40", Offset = "0x5B33F40", VA = "0x185B34D40")]
		internal bool <BuildAnonymousFormatter>b__7(int index, BLHGAMPKFIL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class NJACOAPANHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NJACOAPANHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3044CA0", Offset = "0x3043EA0", VA = "0x183044CA0")]
		internal Label <BuildSerialize>b__1(BLHGAMPKFIL _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class NLNIALFOLID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ADLPKGKIMJC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, BLHGAMPKFIL, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AKPPANKCLAO argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AKPPANKCLAO argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NLNIALFOLID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5B368A0", Offset = "0x5B35AA0", VA = "0x185B368A0")]
		internal ADLPKGKIMJC <BuildDeserialize>b__0(BLHGAMPKFIL item)
		{
			return default(ADLPKGKIMJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CKLJEHEPMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public NLNIALFOLID CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CKLJEHEPMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5B2EA30", Offset = "0x5B2DC30", VA = "0x185B2EA30")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5B2ECE0", Offset = "0x5B2DEE0", VA = "0x185B2ECE0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class ALNNAGFNGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BLHGAMPKFIL item;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ALNNAGFNGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D30", Offset = "0x8D6F30", VA = "0x1808D7D30")]
		internal bool <EmitNewObject>b__0(ADLPKGKIMJC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class CLNJEPDMCCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BLHGAMPKFIL item;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CLNJEPDMCCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D30", Offset = "0x8D6F30", VA = "0x1808D7D30")]
		internal bool <EmitNewObject>b__2(ADLPKGKIMJC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex OAECAACHEJE;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int CCBGLLEPNLF;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> FDMONBMHLMK;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> FMPPBBEAOIG;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x20642F0", Offset = "0x20634F0", VA = "0x1820642F0")]
	public static object ALIFNHOOHKI<T>(GCHJEGHPOFH BLKAGIDAFMH, IGFJLJHHKLB HGJFFILPCJJ, Func<string, string> JGDHDFIDFCL, bool HFLMIOMPICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2E81020", Offset = "0x2E80220", VA = "0x182E81020")]
	public static object OFKDKMKJEOG<T>(IGFJLJHHKLB HGJFFILPCJJ, Func<string, string> JGDHDFIDFCL, bool HFLMIOMPICI, bool OOEAGKMIPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4149040", Offset = "0x4148240", VA = "0x184149040")]
	private static TypeInfo KIHBLACBNKO(GCHJEGHPOFH BLKAGIDAFMH, Type NIFOGEBEDNG, Func<string, string> JGDHDFIDFCL, bool HFLMIOMPICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x414AF10", Offset = "0x414A110", VA = "0x18414AF10")]
	public static object PPKCBPJKEJA(Type NIFOGEBEDNG, Func<string, string> JGDHDFIDFCL, bool HFLMIOMPICI, bool OOEAGKMIPHE, bool FDJIKBEIBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4144CC0", Offset = "0x4143EC0", VA = "0x184144CC0")]
	private static Dictionary<BLHGAMPKFIL, FieldInfo> CPCINOCINPD(TypeBuilder BKJILEGEHCG, PHAJDNGFDBP AKOKILEPANJ, ConstructorInfo PNMOPCJFNHG, FieldBuilder ADEBDLCPADI, ILGenerator DOHNFGHLEGL, bool HFLMIOMPICI, bool LGBPGCLDIMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x41474A0", Offset = "0x41466A0", VA = "0x1841474A0")]
	private static Dictionary<BLHGAMPKFIL, FieldInfo> JBKNKACKOIH(TypeBuilder BKJILEGEHCG, PHAJDNGFDBP AKOKILEPANJ, ILGenerator DOHNFGHLEGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4147B20", Offset = "0x4146D20", VA = "0x184147B20")]
	private static void KEAIKEFNMFP(Type NIFOGEBEDNG, PHAJDNGFDBP AKOKILEPANJ, ILGenerator DOHNFGHLEGL, Action AANFLDKEBIP, Func<int, BLHGAMPKFIL, bool> AFFNKPBAGID, bool HFLMIOMPICI, bool LGBPGCLDIMC, int BFNAEKPGFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x414A9C0", Offset = "0x4149BC0", VA = "0x18414A9C0")]
	private static void POGOGLGCBOE(TypeInfo NIFOGEBEDNG, BLHGAMPKFIL BNDKFIDJNBM, ILGenerator DOHNFGHLEGL, int GMEHLIHLGEH, Func<int, BLHGAMPKFIL, bool> AFFNKPBAGID, AKPPANKCLAO KOODAEDNKIK, AKPPANKCLAO DINIGNHLJAB, AKPPANKCLAO EIFCKEKENGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4146050", Offset = "0x4145250", VA = "0x184146050")]
	private static void IOOJFMCECFI(Type NIFOGEBEDNG, PHAJDNGFDBP AKOKILEPANJ, ILGenerator DOHNFGHLEGL, Func<int, BLHGAMPKFIL, bool> AFFNKPBAGID, bool OEBFANJOHIF, int BFNAEKPGFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4149AD0", Offset = "0x4148CD0", VA = "0x184149AD0")]
	private static void LKIEICDNOHD(ILGenerator DOHNFGHLEGL, ADLPKGKIMJC AKOKILEPANJ, int GMEHLIHLGEH, Func<int, BLHGAMPKFIL, bool> AFFNKPBAGID, AKPPANKCLAO EFKJIOEDNFB, AKPPANKCLAO EIFCKEKENGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x41453A0", Offset = "0x41445A0", VA = "0x1841453A0")]
	private static LocalBuilder EMLBOIJMHNB(ILGenerator DOHNFGHLEGL, Type NIFOGEBEDNG, PHAJDNGFDBP AKOKILEPANJ, ADLPKGKIMJC[] PDKEEPCDMEE, bool AHJEMKBPBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4149F90", Offset = "0x4149190", VA = "0x184149F90")]
	private static bool LKMPHLJFBGE(ConstructorInfo PDMHDPDOFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x414A810", Offset = "0x4149A10", VA = "0x18414A810")]
	private static bool PACEPNKMFAP(Type NIFOGEBEDNG, out Type CCHCMBPPHJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal delegate void AJIELHJIEJI<T>(byte[][] ADEBDLCPADI, object[] BIOICHBNHFI, ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB BDEGGEFECLH);
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate T JINAFAGPELE<T>(object[] BIOICHBNHFI, ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB BDEGGEFECLH);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class HEBNHPOLGBN<T> : global::MJFBLDENKJM<T>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] ADEBDLCPADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] NLIJGPEIMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] NIDANHLPPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::AJIELHJIEJI<T> KIKLHFEKHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::JINAFAGPELE<T> EOAFKONFEGL;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3370", Offset = "0x2FF2570", VA = "0x182FF3370")]
	public HEBNHPOLGBN(byte[][] ADEBDLCPADI, object[] NLIJGPEIMBL, object[] NIDANHLPPIL, global::AJIELHJIEJI<T> KIKLHFEKHND, global::JINAFAGPELE<T> EOAFKONFEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3677800", Offset = "0x3676A00", VA = "0x183677800", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3677730", Offset = "0x3676930", VA = "0x183677730", Slot = "5")]
	public T BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class JKBPDCHMDFL : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class OFEOHBPALMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2023D90", Offset = "0x2022F90", VA = "0x182023D90")]
		static OFEOHBPALMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private JKBPDCHMDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class EAJBLEGJBOB : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class OOLHMDNFIDC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x437AC70", Offset = "0x4379E70", VA = "0x18437AC70")]
		static OOLHMDNFIDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private EAJBLEGJBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class LADDKFLGPPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly IGFJLJHHKLB[] GHGHNEAGHPI;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class NFNLLFEBNOK : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private static class KBGNCEOMNNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x215B330", Offset = "0x215A530", VA = "0x18215B330")]
		static KBGNCEOMNNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class LBNGAODDAHP : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private static class KFMMNOIGOEK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1FBD5A0", Offset = "0x1FBC7A0", VA = "0x181FBD5A0")]
			static KFMMNOIGOEK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private LBNGAODDAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private NFNLLFEBNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class DLGPDCBAMDC : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class OAOEDFBBJFN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E210", Offset = "0x2A1D410", VA = "0x182A1E210")]
		static OAOEDFBBJFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class OBJEJLDNGHI : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class NAKGEENGDIL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x24AC1E0", Offset = "0x24AB3E0", VA = "0x1824AC1E0")]
			static NAKGEENGDIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private OBJEJLDNGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private DLGPDCBAMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class PEKMIMPOEGC : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class JMNAADNPNJF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x234A220", Offset = "0x2349420", VA = "0x18234A220")]
		static JMNAADNPNJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class CCKPIKGBENA : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class EOIGLFDFNEL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x88F4E0", Offset = "0x88E6E0", VA = "0x18088F4E0")]
			static EOIGLFDFNEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private CCKPIKGBENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private PEKMIMPOEGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class NBMNLLHFNCE : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class POMOAOBMIEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2464880", Offset = "0x2463A80", VA = "0x182464880")]
		static POMOAOBMIEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class GENLCDEBJCC : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class AFODIJCLKDD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x29F08B0", Offset = "0x29EFAB0", VA = "0x1829F08B0")]
			static AFODIJCLKDD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private GENLCDEBJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private NBMNLLHFNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class DLHAGPPPBDN : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class DFFGLFGJCJK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x206A990", Offset = "0x2069B90", VA = "0x18206A990")]
		static DFFGLFGJCJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class IFFALLJLEJH : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class IJDKGBEOCKA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x1B361F0", Offset = "0x1B353F0", VA = "0x181B361F0")]
			static IJDKGBEOCKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private IFFALLJLEJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private DLHAGPPPBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class PDDLEOKEMHG : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class EAFFGNINKFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2389670", Offset = "0x2388870", VA = "0x182389670")]
		static EAFFGNINKFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class KIBOAIHBKPM : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class FJAEOFILHFE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2F3F5C0", Offset = "0x2F3E7C0", VA = "0x182F3F5C0")]
			static FJAEOFILHFE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private KIBOAIHBKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private PDDLEOKEMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class PIMCAEFELDN : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class GJLKHJICNGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4C60", Offset = "0x2FF3E60", VA = "0x182FF4C60")]
		static GJLKHJICNGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class CLEFDEJELGG : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class OBIHBAJBCAL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A25FD0", Offset = "0x2A251D0", VA = "0x182A25FD0")]
			static OBIHBAJBCAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private CLEFDEJELGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private PIMCAEFELDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class EJILNLMBPIN : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class BEIHLCPKDOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x21B4E00", Offset = "0x21B4000", VA = "0x1821B4E00")]
		static BEIHLCPKDOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class BLPNHPDCHIK : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class GFJJEGHGBAD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2FEE000", Offset = "0x2FED200", VA = "0x182FEE000")]
			static GFJJEGHGBAD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private BLPNHPDCHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private EJILNLMBPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class DJPNAFHCHAB : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class CLBAEJCLIDK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C358A0", Offset = "0x2C34AA0", VA = "0x182C358A0")]
		static CLBAEJCLIDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class MLCJGMAODGH : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class IAMJFAPINHM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x192B9E0", Offset = "0x192ABE0", VA = "0x18192B9E0")]
			static IAMJFAPINHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private MLCJGMAODGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private DJPNAFHCHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class HAEGCMNCNJE : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class CJHCEKOFOAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C30960", Offset = "0x2C2FB60", VA = "0x182C30960")]
		static CJHCEKOFOAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class DFOOBHFJAOM : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class AEJKGINOFKK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x29DEF30", Offset = "0x29DE130", VA = "0x1829DEF30")]
			static AEJKGINOFKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private DFOOBHFJAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private HAEGCMNCNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class PPCDOAHLKDA : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class GBJBNAIEDNF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2FE43F0", Offset = "0x2FE35F0", VA = "0x182FE43F0")]
		static GBJBNAIEDNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class PBJHCAIJDHM : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class HJCAJOPFOOM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x4012A00", Offset = "0x4011C00", VA = "0x184012A00")]
			static HJCAJOPFOOM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private PBJHCAIJDHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private PPCDOAHLKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class MECBDNMGPJM : IGFJLJHHKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class HDODENBBIBF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3676EA0", Offset = "0x36760A0", VA = "0x183676EA0")]
		static HDODENBBIBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class NABJGCPBKIF : IGFJLJHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class NPMOFGJLOGD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::MJFBLDENKJM<T> KEKOJAMDJMK;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x47B4CB0", Offset = "0x47B3EB0", VA = "0x1847B4CB0")]
			static NPMOFGJLOGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly IGFJLJHHKLB OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly IGFJLJHHKLB[] HJCMBBKEBGJ;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private NABJGCPBKIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
		public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly IGFJLJHHKLB OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::MJFBLDENKJM<object> NKPEHIABIPK;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private MECBDNMGPJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1150F40", Offset = "0x1150140", VA = "0x181150F40", Slot = "4")]
	public global::MJFBLDENKJM<T> KLMPKJMNLEL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct MJEACALHAIH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] BOGGOBNBGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int HEIPHEGLBIF;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x26298B0", Offset = "0x2628AB0", VA = "0x1826298B0")]
	public MJEACALHAIH(int OILBNELDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x26293E0", Offset = "0x26285E0", VA = "0x1826293E0")]
	public void CPCILMEHKPA(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2629820", Offset = "0x2628A20", VA = "0x182629820")]
	public T[] LBKAIIPADDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal sealed class NAGCHBFJAOD : global::CAMPPCJALEO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly NAGCHBFJAOD FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4141210", Offset = "0x4140410", VA = "0x184141210")]
	public NAGCHBFJAOD(int HBDHCFMEALK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class CAMPPCJALEO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int HBDHCFMEALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object FEPKPBKGOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int GMEHLIHLGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] LHJNOFNBMHG;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3F69CA0", Offset = "0x3F68EA0", VA = "0x183F69CA0")]
	public CAMPPCJALEO(int HBDHCFMEALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3F688E0", Offset = "0x3F67AE0", VA = "0x183F688E0")]
	public T[] CBBMJHCHKAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3F68AD0", Offset = "0x3F67CD0", VA = "0x183F68AD0")]
	public void LLJPIMIFODB(T[] HAHPMNMCEBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class KIDNBPBMGMO : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class JDBEPIHEGJE : IComparable<JDBEPIHEGJE>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class ODODDAOLOFH : IEnumerable<JDBEPIHEGJE>, IEnumerable, IEnumerator<JDBEPIHEGJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private JDBEPIHEGJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public JDBEPIHEGJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private JDBEPIHEGJE System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
			[DebuggerHidden]
			public ODODDAOLOFH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x5B36C20", Offset = "0x5B35E20", VA = "0x185B36C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x5B36D50", Offset = "0x5B35F50", VA = "0x185B36D50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x5B36CB0", Offset = "0x5B35EB0", VA = "0x185B36CB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JDBEPIHEGJE> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x5B36CB0", Offset = "0x5B35EB0", VA = "0x185B36CB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class ANBECGMGPOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public ANBECGMGPOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x3044CA0", Offset = "0x3043EA0", VA = "0x183044CA0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x3044CA0", Offset = "0x3043EA0", VA = "0x183044CA0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly JDBEPIHEGJE[] IBGAPOPEBKP;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] HFPGCFGAKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong EGJKFMADELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int LKDHJKNGKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string MNGFJFCEHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private JDBEPIHEGJE[] FPDKEMKJIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] GMGBAEPHIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int BFFJHKFEFPP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GIFOGKHOLIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x59FF860", Offset = "0x59FEA60", VA = "0x1859FF860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B31420", Offset = "0x5B30620", VA = "0x185B31420")]
		public JDBEPIHEGJE(ulong FDAIMOMOHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5B30040", Offset = "0x5B2F240", VA = "0x185B30040")]
		public JDBEPIHEGJE CPCILMEHKPA(ulong FDAIMOMOHIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5B2FFF0", Offset = "0x5B2F1F0", VA = "0x185B2FFF0")]
		public JDBEPIHEGJE CPCILMEHKPA(ulong FDAIMOMOHIG, int IPMIIEAGJKC, string MNGFJFCEHCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5B30330", Offset = "0x5B2F530", VA = "0x185B30330")]
		public JDBEPIHEGJE DLFALEAKACB(byte[] COLMAMKJPJE, ref int MOHMCFDNHKH, ref int KOOIBPGHFNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B304E0", Offset = "0x5B2F6E0", VA = "0x185B304E0")]
		internal static int FKHNDMKDFAG(ulong[] HAHPMNMCEBD, int GMEHLIHLGEH, int MNKGPEKFPKK, ulong IPMIIEAGJKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5B30300", Offset = "0x5B2F500", VA = "0x185B30300", Slot = "4")]
		public int CompareTo(JDBEPIHEGJE HNPEBINPOBO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5B2FF80", Offset = "0x5B2F180", VA = "0x185B2FF80")]
		[IteratorStateMachine(typeof(ODODDAOLOFH))]
		public IEnumerable<JDBEPIHEGJE> BJOBINAIBGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5B30560", Offset = "0x5B2F760", VA = "0x185B30560")]
		public void GJOFCHEEJDB(ILGenerator DOHNFGHLEGL, LocalBuilder COLMAMKJPJE, LocalBuilder KOOIBPGHFNH, LocalBuilder FDAIMOMOHIG, Action<KeyValuePair<string, int>> LDKKLOBLMIJ, Action EJBDEDJLCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5B306A0", Offset = "0x5B2F8A0", VA = "0x185B306A0")]
		private static void PFKJFMEAFAK(ILGenerator DOHNFGHLEGL, LocalBuilder COLMAMKJPJE, LocalBuilder KOOIBPGHFNH, LocalBuilder FDAIMOMOHIG, Action<KeyValuePair<string, int>> LDKKLOBLMIJ, Action EJBDEDJLCDJ, JDBEPIHEGJE[] FPDKEMKJIIA, int BFFJHKFEFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class KKCIPGKHPML : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<JDBEPIHEGJE> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<JDBEPIHEGJE> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<JDBEPIHEGJE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private JDBEPIHEGJE <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x5B355E0", Offset = "0x5B347E0", VA = "0x185B355E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1E99350", Offset = "0x1E98550", VA = "0x181E99350")]
		[DebuggerHidden]
		public KKCIPGKHPML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5B35630", Offset = "0x5B34830", VA = "0x185B35630", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5B350A0", Offset = "0x5B342A0", VA = "0x185B350A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B35710", Offset = "0x5B34910", VA = "0x185B35710")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5B35760", Offset = "0x5B34960", VA = "0x185B35760")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5B355A0", Offset = "0x5B347A0", VA = "0x185B355A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5B35500", Offset = "0x5B34700", VA = "0x185B35500", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5B35500", Offset = "0x5B34700", VA = "0x185B35500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly JDBEPIHEGJE KPDGHDGLMHO;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4138E90", Offset = "0x4138090", VA = "0x184138E90")]
	public KIDNBPBMGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4138830", Offset = "0x4137A30", VA = "0x184138830")]
	public void CPCILMEHKPA(byte[] ODBGNNDKAMK, int IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4138D10", Offset = "0x4137F10", VA = "0x184138D10")]
	public bool LNMPMODNHBL(ArraySegment<byte> FDAIMOMOHIG, out int IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4138E00", Offset = "0x4138000", VA = "0x184138E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4138950", Offset = "0x4137B50", VA = "0x184138950")]
	private static void DCIHDGDKLKA(IEnumerable<JDBEPIHEGJE> FPDKEMKJIIA, StringBuilder NOPIEJEEOPP, int GADEOBMPDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4138BF0", Offset = "0x4137DF0", VA = "0x184138BF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4138BF0", Offset = "0x4137DF0", VA = "0x184138BF0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4138CA0", Offset = "0x4137EA0", VA = "0x184138CA0")]
	[IteratorStateMachine(typeof(KKCIPGKHPML))]
	private static IEnumerable<KeyValuePair<string, int>> IJCAGELBOEG(IEnumerable<JDBEPIHEGJE> FPDKEMKJIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4138DD0", Offset = "0x4137FD0", VA = "0x184138DD0")]
	public void PJDKLPLKCNK(ILGenerator DOHNFGHLEGL, LocalBuilder COLMAMKJPJE, LocalBuilder KOOIBPGHFNH, LocalBuilder FDAIMOMOHIG, Action<KeyValuePair<string, int>> LDKKLOBLMIJ, Action EJBDEDJLCDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class BEMJEBAIOOC
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo AHHFOBAJLIP;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x52FB8B0", Offset = "0x52FAAB0", VA = "0x1852FB8B0")]
	public static ulong DGKPOACLPOP(byte[] ODBGNNDKAMK, ref int MOHMCFDNHKH, ref int KOOIBPGHFNH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class LNAAEBCDHCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x413D1D0", Offset = "0x413C3D0", VA = "0x18413D1D0")]
	public static void ENLOKNJJMLM(ref byte[] ODBGNNDKAMK, int MOHMCFDNHKH, int GKOCPEHLLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x413D310", Offset = "0x413C510", VA = "0x18413D310")]
	public static void IKDEDFNKLCG(ref byte[] HAHPMNMCEBD, int NOCCMAIOCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x413D0B0", Offset = "0x413C2B0", VA = "0x18413D0B0")]
	public static byte[] BDCDEKGBIBG(byte[] CKOEFCDNGOI, int NOCCMAIOCDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class MMJDDGLGDMO
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x413FE80", Offset = "0x413F080", VA = "0x18413FE80")]
	public static bool OFPEIHMPLIL(byte[] OOGALOMEHGA, int MKFMLILLDDO, int JDONFOCDIPD, byte[] IBDCDOCDCCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class APHIADOPKHC<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct MABBKPHPJOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] EGJKFMADELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T LKDHJKNGKHD;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB510", Offset = "0x2DCA710", VA = "0x182DCB510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class KMPDDBPOLKN : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::APHIADOPKHC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private MABBKPHPJOO[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private MABBKPHPJOO[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1FC7D60", Offset = "0x1FC6F60", VA = "0x181FC7D60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1721F60", Offset = "0x1721160", VA = "0x181721F60")]
		[DebuggerHidden]
		public KMPDDBPOLKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7400", Offset = "0x1FC6600", VA = "0x181FC7400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7C20", Offset = "0x1FC6E20", VA = "0x181FC7C20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly MABBKPHPJOO[][] FCHNEPPEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong KKGCMAHDCFL;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x31ECB50", Offset = "0x31EBD50", VA = "0x1831ECB50")]
	public APHIADOPKHC(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x31ECA90", Offset = "0x31EBC90", VA = "0x1831ECA90")]
	public APHIADOPKHC(int FAPOEIDOLFP, float KIMNMKEKHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x31E7270", Offset = "0x31E6470", VA = "0x1831E7270")]
	public void CPCILMEHKPA(byte[] FDAIMOMOHIG, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x31E8440", Offset = "0x31E7640", VA = "0x1831E8440")]
	private bool HMJMIAHJDKG(byte[] FDAIMOMOHIG, T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x31EC2E0", Offset = "0x31EB4E0", VA = "0x1831EC2E0")]
	public bool HOAIDNCFMEI(ArraySegment<byte> FDAIMOMOHIG, out T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x31ECA30", Offset = "0x31EBC30", VA = "0x1831ECA30")]
	private static ulong LLNKMCBDICB(byte[] FCCGDNMAHPA, int MOHMCFDNHKH, int BFFJHKFEFPP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x26350E0", Offset = "0x26342E0", VA = "0x1826350E0")]
	private static int ONIGBOAEABH(int CCONLBPOBKN, float KIMNMKEKHHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x31E75A0", Offset = "0x31E67A0", VA = "0x1831E75A0", Slot = "4")]
	[IteratorStateMachine(typeof(global::APHIADOPKHC<>.KMPDDBPOLKN))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C490", Offset = "0x1F1B690", VA = "0x181F1C490", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class HOIJMNHONPA : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] MDAANPHCILL;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] MAAGIMJHAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int MNPAGIJPEBB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OCPNJLLBDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4134B80", Offset = "0x4133D80", VA = "0x184134B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4134BD0", Offset = "0x4133DD0", VA = "0x184134BD0")]
	static HOIJMNHONPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4134E50", Offset = "0x4134050", VA = "0x184134E50")]
	public HOIJMNHONPA(byte[] EIJJFHBLBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4134A60", Offset = "0x4133C60", VA = "0x184134A60")]
	public OpCode LLOMEMFCBNK()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct GPMFNPFBHDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid LKDHJKNGKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte COFAGHFJJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte ELMJJKIOMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte KOBGMJHJIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte OLHEPOJHBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte GLEKCMELENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte LGCNKHJGPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte OKLBBGMEHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte MIJAJJJPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte AILIHMFJAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte IKDEPPPGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte BCCLIGPOCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte OOMFCJIFDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte NBBFBAFELLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte OIGHNIJKKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte HEFBHOIPPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte KMBPBCMHPMC;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] EGHADKPMIDP;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] FMKGCJBLLHM;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x53125C0", Offset = "0x53117C0", VA = "0x1853125C0")]
	public GPMFNPFBHDP(ref Guid IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5311170", Offset = "0x5310370", VA = "0x185311170")]
	public GPMFNPFBHDP(ref ArraySegment<byte> LGLLJGPJLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5310FE0", Offset = "0x53101E0", VA = "0x185310FE0")]
	private static byte MPMKBDINMNK(byte[] ODBGNNDKAMK, int JGGJKOEDJFK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5310ED0", Offset = "0x53100D0", VA = "0x185310ED0")]
	private static byte KKNFLPKBHNK(byte EFNJCAIBDLA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x530FB80", Offset = "0x530ED80", VA = "0x18530FB80")]
	public void DNHNFLEJEFG(byte[] ACMMHKGMFIC, int MOHMCFDNHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class LNBOBPGEPID
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x413D420", Offset = "0x413C620", VA = "0x18413D420")]
	public static bool AKLMKAINBDA(byte DHNNLHJMKIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x413ECD0", Offset = "0x413DED0", VA = "0x18413ECD0")]
	public static bool GOKGPGACFOO(byte DHNNLHJMKIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x413D4A0", Offset = "0x413C6A0", VA = "0x18413D4A0")]
	public static sbyte AOIPIMOPOPL(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x413EFF0", Offset = "0x413E1F0", VA = "0x18413EFF0")]
	public static short PLGGLDEDBIC(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x413EF80", Offset = "0x413E180", VA = "0x18413EF80")]
	public static int NLNCMJCKKOA(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x413ED40", Offset = "0x413DF40", VA = "0x18413ED40")]
	public static long HHOEMGILLNG(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x413D510", Offset = "0x413C710", VA = "0x18413D510")]
	public static byte BIMHFEKANEE(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x413D580", Offset = "0x413C780", VA = "0x18413D580")]
	public static ushort BJPHMCADDFA(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x413EF00", Offset = "0x413E100", VA = "0x18413EF00")]
	public static uint KJEAGNNNHNK(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x413EDF0", Offset = "0x413DFF0", VA = "0x18413EDF0")]
	public static ulong JKJEKKDKBKJ(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x413D430", Offset = "0x413C630", VA = "0x18413D430")]
	public static float ANAELJCBNBC(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x413EC60", Offset = "0x413DE60", VA = "0x18413EC60")]
	public static double GMMGKJKLPBM(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x413D860", Offset = "0x413CA60", VA = "0x18413D860")]
	public static int EEHEDLGLNOK(ref byte[] ACMMHKGMFIC, int MOHMCFDNHKH, ulong IPMIIEAGJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x413E030", Offset = "0x413D230", VA = "0x18413E030")]
	public static int EPIDINPINFB(ref byte[] ACMMHKGMFIC, int MOHMCFDNHKH, long IPMIIEAGJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x413D5F0", Offset = "0x413C7F0", VA = "0x18413D5F0")]
	public static bool DKOIACAANKI(byte[] ODBGNNDKAMK, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class KEMALBLNDCN
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class LJJDHAHIIJB : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
		[DebuggerHidden]
		public LJJDHAHIIJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5B35EF0", Offset = "0x5B350F0", VA = "0x185B35EF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5B35A90", Offset = "0x5B34C90", VA = "0x185B35A90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5B35FE0", Offset = "0x5B351E0", VA = "0x185B35FE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5B36030", Offset = "0x5B35230", VA = "0x185B36030")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5B35EB0", Offset = "0x5B350B0", VA = "0x185B35EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5B35E00", Offset = "0x5B35000", VA = "0x185B35E00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5B35E00", Offset = "0x5B35000", VA = "0x185B35E00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class EEGJFGPAJBI : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
		[DebuggerHidden]
		public EEGJFGPAJBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F610", Offset = "0x5B2E810", VA = "0x185B2F610", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F1B0", Offset = "0x5B2E3B0", VA = "0x185B2F1B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F700", Offset = "0x5B2E900", VA = "0x185B2F700")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F750", Offset = "0x5B2E950", VA = "0x185B2F750")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F5D0", Offset = "0x5B2E7D0", VA = "0x185B2F5D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F520", Offset = "0x5B2E720", VA = "0x185B2F520", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F520", Offset = "0x5B2E720", VA = "0x185B2F520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x41381C0", Offset = "0x41373C0", VA = "0x1841381C0")]
	public static bool ENGKGFFCIBI(this TypeInfo NIFOGEBEDNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x41383E0", Offset = "0x41375E0", VA = "0x1841383E0")]
	public static bool OEHLKJLBOCB(this TypeInfo NIFOGEBEDNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4138280", Offset = "0x4137480", VA = "0x184138280")]
	public static IEnumerable<PropertyInfo> FDFNNACEJAI(this Type NIFOGEBEDNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4138350", Offset = "0x4137550", VA = "0x184138350")]
	[IteratorStateMachine(typeof(LJJDHAHIIJB))]
	private static IEnumerable<PropertyInfo> MAAJPJIMIFG(Type NIFOGEBEDNG, HashSet<string> FKFCMHLDODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4138500", Offset = "0x4137700", VA = "0x184138500")]
	public static IEnumerable<FieldInfo> OOJEKJMOEHD(this Type NIFOGEBEDNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x4138130", Offset = "0x4137330", VA = "0x184138130")]
	[IteratorStateMachine(typeof(EEGJFGPAJBI))]
	private static IEnumerable<FieldInfo> EINKLCMBBIH(Type NIFOGEBEDNG, HashSet<string> FKFCMHLDODK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class FKMLACAANHC
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding NHEMJKLOFGF;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class ENMOFEPECNM
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	public static string GKJNAPIPPIM(string IBALDFBGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x53057B0", Offset = "0x53049B0", VA = "0x1853057B0")]
	public static string BPAIOMNLNPM(string IBALDFBGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x53058C0", Offset = "0x5304AC0", VA = "0x1853058C0")]
	public static string EIMFJALLDFA(string IBALDFBGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class MMJCLDFMIOC<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class AEELJMJABLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type EGJKFMADELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue LKDHJKNGKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int BBLMHDBLHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AEELJMJABLF EDOFMOHMNAN;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x29DEA90", Offset = "0x29DDC90", VA = "0x1829DEA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x29DEA10", Offset = "0x29DDC10", VA = "0x1829DEA10")]
		private int BPIIJGBNBGB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public AEELJMJABLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class KDEOIKNGIEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public KDEOIKNGIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2E0", Offset = "0x7D94E0", VA = "0x1807DA2E0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private AEELJMJABLF[] FCHNEPPEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int CAPKFCHDLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object LIPDNAKMDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float KIMNMKEKHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2635200", Offset = "0x2634400", VA = "0x182635200")]
	public MMJCLDFMIOC(int FAPOEIDOLFP = 4, float KIMNMKEKHHJ = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2634E80", Offset = "0x2634080", VA = "0x182634E80")]
	public bool OIACEIIALAO(Type FDAIMOMOHIG, TValue IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2634E40", Offset = "0x2634040", VA = "0x182634E40")]
	public bool OIACEIIALAO(Type FDAIMOMOHIG, Func<Type, TValue> FKFOMPDBNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x26345D0", Offset = "0x26337D0", VA = "0x1826345D0")]
	private bool HMJMIAHJDKG(Type FDAIMOMOHIG, Func<Type, TValue> FKFOMPDBNJK, out TValue FPOGKJJCKOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x26340C0", Offset = "0x26332C0", VA = "0x1826340C0")]
	private bool BCGJKEIMBCO(AEELJMJABLF[] FCHNEPPEDFM, Type MNLGFMJNFKO, AEELJMJABLF CIFILPONPHG, Func<Type, TValue> FKFOMPDBNJK, out TValue FPOGKJJCKOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2634CC0", Offset = "0x2633EC0", VA = "0x182634CC0")]
	public bool HOAIDNCFMEI(Type FDAIMOMOHIG, out TValue IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2634520", Offset = "0x2633720", VA = "0x182634520")]
	public TValue GFMNNFCLLJF(Type FDAIMOMOHIG, Func<Type, TValue> FKFOMPDBNJK)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x26350E0", Offset = "0x26342E0", VA = "0x1826350E0")]
	private static int ONIGBOAEABH(int CCONLBPOBKN, float KIMNMKEKHHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2634E10", Offset = "0x2634010", VA = "0x182634E10")]
	private static void NPOBHCAIIMO(ref AEELJMJABLF KJAPODOABPN, AEELJMJABLF IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2634E10", Offset = "0x2634010", VA = "0x182634E10")]
	private static void NPOBHCAIIMO(ref AEELJMJABLF[] KJAPODOABPN, AEELJMJABLF[] IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class GCHJEGHPOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder CKDKPOINMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder PNLLCKNFCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object FEPKPBKGOLD;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x530B8A0", Offset = "0x530AAA0", VA = "0x18530B8A0")]
	public TypeBuilder JEHKILBBOIO(string KNOPFGAGMCN, TypeAttributes FMHOLFFFCCC, Type HHFDFFDPCGO, Type[] PMFPCFBCBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x530B970", Offset = "0x530AB70", VA = "0x18530B970")]
	public GCHJEGHPOFH(string LBDHOAACKNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class MOMNMNDABAA
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x41408F0", Offset = "0x413FAF0", VA = "0x1841408F0")]
	private static MethodInfo GDFAGMONCJE(LambdaExpression CAFFCFENIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x13C14D0", Offset = "0x13C06D0", VA = "0x1813C14D0")]
	public static MethodInfo MFFKIEDABCM<T>(Expression<Func<T>> CAFFCFENIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x13C14D0", Offset = "0x13C06D0", VA = "0x1813C14D0")]
	public static MethodInfo MFFKIEDABCM<T, TR>(Expression<Func<T, TR>> CAFFCFENIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x13C14D0", Offset = "0x13C06D0", VA = "0x1813C14D0")]
	public static MethodInfo MFFKIEDABCM<T>(Expression<Action<T>> CAFFCFENIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x13C14D0", Offset = "0x13C06D0", VA = "0x1813C14D0")]
	public static MethodInfo MFFKIEDABCM<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> CAFFCFENIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x13C14E0", Offset = "0x13C06E0", VA = "0x1813C14E0")]
	private static MemberInfo NAOJJBADBCM<T>(Expression<T> GLLFHCCFIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x13C1470", Offset = "0x13C0670", VA = "0x1813C1470")]
	public static PropertyInfo GHDIHIGCIJG<T, TR>(Expression<Func<T, TR>> CAFFCFENIPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct AKPPANKCLAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int MLECAGAJCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool KOOLKGONOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator DOHNFGHLEGL;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x52FB390", Offset = "0x52FA590", VA = "0x1852FB390")]
	public AKPPANKCLAO(ILGenerator DOHNFGHLEGL, int MLECAGAJCGO, bool KOOLKGONOLI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x52FB3D0", Offset = "0x52FA5D0", VA = "0x1852FB3D0")]
	public AKPPANKCLAO(ILGenerator DOHNFGHLEGL, int MLECAGAJCGO, Type NIFOGEBEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x52FB270", Offset = "0x52FA470", VA = "0x1852FB270")]
	public void EBFOKAOGKLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class GPFPHLCFFDG
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x530F840", Offset = "0x530EA40", VA = "0x18530F840")]
	public static void MENOGFPOOLP(this ILGenerator DOHNFGHLEGL, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x530F800", Offset = "0x530EA00", VA = "0x18530F800")]
	public static void MENOGFPOOLP(this ILGenerator DOHNFGHLEGL, LocalBuilder MDENLPJHHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x530F390", Offset = "0x530E590", VA = "0x18530F390")]
	public static void DEAGGCOLAFN(this ILGenerator DOHNFGHLEGL, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x530F5C0", Offset = "0x530E7C0", VA = "0x18530F5C0")]
	public static void DEAGGCOLAFN(this ILGenerator DOHNFGHLEGL, LocalBuilder MDENLPJHHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x530E9E0", Offset = "0x530DBE0", VA = "0x18530E9E0")]
	public static void AHEOFJDIFJJ(this ILGenerator DOHNFGHLEGL, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x530E8D0", Offset = "0x530DAD0", VA = "0x18530E8D0")]
	public static void AHEOFJDIFJJ(this ILGenerator DOHNFGHLEGL, LocalBuilder MDENLPJHHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x530EAD0", Offset = "0x530DCD0", VA = "0x18530EAD0")]
	public static void AJOJMPKFFHM(this ILGenerator DOHNFGHLEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x530F600", Offset = "0x530E800", VA = "0x18530F600")]
	public static void IPONCOELDHH(this ILGenerator DOHNFGHLEGL, bool IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x530EDC0", Offset = "0x530DFC0", VA = "0x18530EDC0")]
	public static void BGHPAHCKFCI(this ILGenerator DOHNFGHLEGL, int IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x530F210", Offset = "0x530E410", VA = "0x18530F210")]
	public static void BHKDNCPHDFE(this ILGenerator DOHNFGHLEGL, Type NIFOGEBEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x530EAE0", Offset = "0x530DCE0", VA = "0x18530EAE0")]
	public static void ALDGNLNGPBL(this ILGenerator DOHNFGHLEGL, Type NIFOGEBEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x530EB90", Offset = "0x530DD90", VA = "0x18530EB90")]
	public static void APBIPDEMCAJ(this ILGenerator DOHNFGHLEGL, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x530FB00", Offset = "0x530ED00", VA = "0x18530FB00")]
	public static void PINJLEJJBOG(this ILGenerator DOHNFGHLEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x530F610", Offset = "0x530E810", VA = "0x18530F610")]
	public static void JBNNKAEBMFO(this ILGenerator DOHNFGHLEGL, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x530F700", Offset = "0x530E900", VA = "0x18530F700")]
	public static void LKJIPKAAPNO(this ILGenerator DOHNFGHLEGL, MethodInfo PEENOKCMOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x530F300", Offset = "0x530E500", VA = "0x18530F300")]
	public static void BNBLNFIEGCH(this ILGenerator DOHNFGHLEGL, FieldInfo AELBGKGIMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x530FA70", Offset = "0x530EC70", VA = "0x18530FA70")]
	public static void NPANIJPAPAN(this ILGenerator DOHNFGHLEGL, ulong IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class BLHGAMPKFIL
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class GIBKPEJDJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GIBKPEJDJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5B2FA20", Offset = "0x5B2EC20", VA = "0x185B2FA20")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo NCPNJMCFHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo HDBLIOIGIKO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string PALADLMJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string CCMIDANBDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JJLBAHBOJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x52FD7A0", Offset = "0x52FC9A0", VA = "0x1852FD7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool APJCFIPJPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8297A0", Offset = "0x8289A0", VA = "0x1808297A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x829910", Offset = "0x828B10", VA = "0x180829910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool ODJAKBLCICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xC4A880", Offset = "0xC49A80", VA = "0x180C4A880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x17C16B0", Offset = "0x17C08B0", VA = "0x1817C16B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MMMENNAAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo DEGGDPNPDLB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo ODBFODJFMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo NJPEFEILOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x814E30", Offset = "0x814030", VA = "0x180814E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x52FDA70", Offset = "0x52FCC70", VA = "0x1852FDA70")]
	protected BLHGAMPKFIL(Type NIFOGEBEDNG, string KNOPFGAGMCN, string NCEHLECBNMM, bool NIKDJLJJKEJ, bool JKMNLLIEDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x52FD7B0", Offset = "0x52FC9B0", VA = "0x1852FD7B0")]
	public BLHGAMPKFIL(FieldInfo AKOKILEPANJ, string KNOPFGAGMCN, bool OOEAGKMIPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x52FD8C0", Offset = "0x52FCAC0", VA = "0x1852FD8C0")]
	public BLHGAMPKFIL(PropertyInfo AKOKILEPANJ, string KNOPFGAGMCN, bool OOEAGKMIPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x52FD570", Offset = "0x52FC770", VA = "0x1852FD570")]
	private static MethodInfo MOMNIKFLKEF(MemberInfo AKOKILEPANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x217BF40", Offset = "0x217B140", VA = "0x18217BF40")]
	public T HODCPDOGGJA<T>(bool OHAPEDEFGOB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x52FD4B0", Offset = "0x52FC6B0", VA = "0x1852FD4B0", Slot = "4")]
	public virtual void CBECHJHCNLA(ILGenerator DOHNFGHLEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x52FD6E0", Offset = "0x52FC8E0", VA = "0x1852FD6E0", Slot = "5")]
	public virtual void NMOPGBJNNPC(ILGenerator DOHNFGHLEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class OLCLMNAHEDE : BLHGAMPKFIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string DHLADAPBDNF;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4143200", Offset = "0x4142400", VA = "0x184143200")]
	public OLCLMNAHEDE(string KNOPFGAGMCN, string DHLADAPBDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4143100", Offset = "0x4142300", VA = "0x184143100", Slot = "4")]
	public override void CBECHJHCNLA(ILGenerator DOHNFGHLEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x41431C0", Offset = "0x41423C0", VA = "0x1841431C0", Slot = "5")]
	public override void NMOPGBJNNPC(ILGenerator DOHNFGHLEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class GEPKHPCLOKD : BLHGAMPKFIL
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo APIEJEBLHNG;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo HADOGPHNPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal AKPPANKCLAO IABIBFALJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal AKPPANKCLAO DINIGNHLJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal AKPPANKCLAO EIFCKEKENGB;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x530C3A0", Offset = "0x530B5A0", VA = "0x18530C3A0")]
	public GEPKHPCLOKD(string KNOPFGAGMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x530BB50", Offset = "0x530AD50", VA = "0x18530BB50", Slot = "4")]
	public override void CBECHJHCNLA(ILGenerator DOHNFGHLEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x530BE10", Offset = "0x530B010", VA = "0x18530BE10", Slot = "5")]
	public override void NMOPGBJNNPC(ILGenerator DOHNFGHLEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x530BC20", Offset = "0x530AE20", VA = "0x18530BC20")]
	public void KICCKNCKKPP(ILGenerator DOHNFGHLEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class PHAJDNGFDBP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type MMMENNAAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ANEOAIPGNBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E47C0", Offset = "0x7E39C0", VA = "0x1807E47C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JCKHCAPNMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC460", Offset = "0x8CB660", VA = "0x1808CC460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC450", Offset = "0x8CB650", VA = "0x1808CC450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo LPEJEBBKKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BLHGAMPKFIL[] KPCBPMMOPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BLHGAMPKFIL[] MOALAOFHKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B39AB0", Offset = "0x5B38CB0", VA = "0x185B39AB0")]
	public PHAJDNGFDBP(Type NIFOGEBEDNG, Func<string, string> LMBHNDELFLD, bool OOEAGKMIPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5B399C0", Offset = "0x5B38BC0", VA = "0x185B399C0")]
	private static bool PBKDKJKAHMB(IEnumerator<ConstructorInfo> MELNBKIICGE, ref ConstructorInfo DKFLIAILIKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct MGLKGJAGMCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong IAKGPAAHECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int GCBHEJANCJK;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1BF9F60", Offset = "0x1BF9160", VA = "0x181BF9F60")]
	public MGLKGJAGMCB(ulong FOBPNDEHEBK, int LMAPBJLOGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x413FB20", Offset = "0x413ED20", VA = "0x18413FB20")]
	public void ECPDFDAEFHF(ref MGLKGJAGMCB HNPEBINPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x413FBD0", Offset = "0x413EDD0", VA = "0x18413FBD0")]
	public static MGLKGJAGMCB JOOOGDGNNDO(ref MGLKGJAGMCB NNMPJECKECI, ref MGLKGJAGMCB EFNJCAIBDLA)
	{
		return default(MGLKGJAGMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x413FA90", Offset = "0x413EC90", VA = "0x18413FA90")]
	public void APHGPFMDGMK(ref MGLKGJAGMCB HNPEBINPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x413FB30", Offset = "0x413ED30", VA = "0x18413FB30")]
	public static MGLKGJAGMCB JJHIAKKGPNN(ref MGLKGJAGMCB NNMPJECKECI, ref MGLKGJAGMCB EFNJCAIBDLA)
	{
		return default(MGLKGJAGMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x413FC30", Offset = "0x413EE30", VA = "0x18413FC30")]
	public void MKLPJOJPEGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x413FBE0", Offset = "0x413EDE0", VA = "0x18413FBE0")]
	public static MGLKGJAGMCB MKLPJOJPEGC(ref MGLKGJAGMCB NNMPJECKECI)
	{
		return default(MGLKGJAGMCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct FCOPNPNOAEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] ACMMHKGMFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int MOHMCFDNHKH;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x176D4C0", Offset = "0x176C6C0", VA = "0x18176D4C0")]
	public FCOPNPNOAEK(byte[] ACMMHKGMFIC, int INLGLHIPOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5302840", Offset = "0x5301A40", VA = "0x185302840")]
	public void BKEDFLGLFKI(byte EIBIHJOIINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x53064D0", Offset = "0x53056D0", VA = "0x1853064D0")]
	public void MHAJNEAIJLJ(byte[] EIBIHJOIINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5306380", Offset = "0x5305580", VA = "0x185306380")]
	public void DIKGNDKNHKF(byte[] EIBIHJOIINF, int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5306420", Offset = "0x5305620", VA = "0x185306420")]
	public void DIKGNDKNHKF(byte[] EIBIHJOIINF, int EBEICGFALNG, int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5306670", Offset = "0x5305870", VA = "0x185306670")]
	public void PKCHAKNICNC(byte DHNNLHJMKIH, int BFFJHKFEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5306570", Offset = "0x5305770", VA = "0x185306570")]
	public void ONDAAMJMNGL(string EIBIHJOIINF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class AAPBCFKBHBD
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private enum NCHKHEKONEN
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum OILNNDKFPBE
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum KNHMJIJMLIM
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
	private static byte[] PGPMOOIFLEE;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] OKMKCDBEMMP;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] GJCLDIGDLEJ;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] HAFPDOBBNOG;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly KNHMJIJMLIM DIGLADKDEJD;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char LEDCJNJJHKM;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int KKDIBLONGHC;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int AODIPGDFJOA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] NDCDGCPCPMK;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x52F89A0", Offset = "0x52F7BA0", VA = "0x1852F89A0")]
	private static byte[] FIBOHNJNCHF(int CAPKFCHDLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x52F90A0", Offset = "0x52F82A0", VA = "0x1852F90A0")]
	private static byte[] JOPDNIPNMEC(int CAPKFCHDLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x52F7910", Offset = "0x52F6B10", VA = "0x1852F7910")]
	public static int BANDGAMINIE(ref byte[] ACMMHKGMFIC, int MOHMCFDNHKH, float IPMIIEAGJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x52F7A30", Offset = "0x52F6C30", VA = "0x1852F7A30")]
	public static int BANDGAMINIE(ref byte[] ACMMHKGMFIC, int MOHMCFDNHKH, double IPMIIEAGJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x52F8A80", Offset = "0x52F7C80", VA = "0x1852F8A80")]
	private static bool GBGMOEFFKIF(byte[] ACMMHKGMFIC, int MNKGPEKFPKK, ulong FOJMKKOMGJJ, ulong NIBOGMMALNG, ulong KOOIBPGHFNH, ulong IKJJPBNAEJP, ulong PHIGIMEIKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x52F97E0", Offset = "0x52F89E0", VA = "0x1852F97E0")]
	private static void MHHJBICPMAI(uint IDDLLNPENBK, int EHBMFJLKAMB, out uint BEPGIAGKDOB, out int MEOKMDOGIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x52F8B80", Offset = "0x52F7D80", VA = "0x1852F8B80")]
	private static bool HBDMHEBACLG(MGLKGJAGMCB HHAMCCIBMIF, MGLKGJAGMCB NHEDGPECFAM, MGLKGJAGMCB KEDILBKNLIM, byte[] ACMMHKGMFIC, out int MNKGPEKFPKK, out int LBHMDFBAAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x52F7B50", Offset = "0x52F6D50", VA = "0x1852F7B50")]
	private static bool BODPONEEMMI(double MLIPDLAHDHI, NCHKHEKONEN DNLPIHIBJDP, byte[] ACMMHKGMFIC, out int MNKGPEKFPKK, out int LINEADEGGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x52F9900", Offset = "0x52F8B00", VA = "0x1852F9900")]
	private static bool OFOMHHFCAIJ(double MLIPDLAHDHI, NCHKHEKONEN DNLPIHIBJDP, byte[] ACMMHKGMFIC, out int MNKGPEKFPKK, out int DMHKDFBHHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x52F9A10", Offset = "0x52F8C10", VA = "0x1852F9A10")]
	private static bool ONBLOONKGOL(double IPMIIEAGJKC, ref FCOPNPNOAEK BIGIJLPCLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x52F9180", Offset = "0x52F8380", VA = "0x1852F9180")]
	private static bool KKCPOGGAGDO(double IPMIIEAGJKC, ref FCOPNPNOAEK BIGIJLPCLOE, OILNNDKFPBE DNLPIHIBJDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x52F7DF0", Offset = "0x52F6FF0", VA = "0x1852F7DF0")]
	private static void CHBCHGPMJDL(byte[] FFAPCLDLDCB, int MNKGPEKFPKK, int DMHKDFBHHPL, int GNLOJKLHDNM, ref FCOPNPNOAEK BIGIJLPCLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x52F8470", Offset = "0x52F7670", VA = "0x1852F8470")]
	private static void EDBHCFPHICB(byte[] FFAPCLDLDCB, int MNKGPEKFPKK, int LMAPBJLOGJK, ref FCOPNPNOAEK BIGIJLPCLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x52F82C0", Offset = "0x52F74C0", VA = "0x1852F82C0")]
	private static bool DMHBIEKJJKE(double MLIPDLAHDHI, OILNNDKFPBE DNLPIHIBJDP, int BPGBBLOJLEE, byte[] JMIGJNODJGE, out bool NIBAMCDBJAB, out int MNKGPEKFPKK, out int PDFEDMAOMNH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal struct KLLIANKLMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double ENDFPEOPAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong AFFACKKFOND;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct LDKHOOBCBPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float IAKGPAAHECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint PGCCGKDIAHN;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct NONHEFHGEEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong EAPPIKBMCMP;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4142A90", Offset = "0x4141C90", VA = "0x184142A90")]
	public NONHEFHGEEP(double ENDFPEOPAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4142AA0", Offset = "0x4141CA0", VA = "0x184142AA0")]
	public NONHEFHGEEP(MGLKGJAGMCB ENDFPEOPAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4142630", Offset = "0x4141830", VA = "0x184142630")]
	public MGLKGJAGMCB HPODONCFEAP()
	{
		return default(MGLKGJAGMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4142930", Offset = "0x4141B30", VA = "0x184142930")]
	public MGLKGJAGMCB MNGELILGNJK()
	{
		return default(MGLKGJAGMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
	public ulong MMLNHDNNAJM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x41428A0", Offset = "0x4141AA0", VA = "0x1841428A0")]
	public double MMJEEGIIJKO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x41425A0", Offset = "0x41417A0", VA = "0x1841425A0")]
	public double HJDFEFEEBPB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4142570", Offset = "0x4141770", VA = "0x184142570")]
	public int GEPFPFPIGEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4142530", Offset = "0x4141730", VA = "0x184142530")]
	public ulong DDLBODCOAMJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x41424F0", Offset = "0x41416F0", VA = "0x1841424F0")]
	public bool BAAKIJOFFMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x41426E0", Offset = "0x41418E0", VA = "0x1841426E0")]
	public bool KEKFBEHOLJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x41429C0", Offset = "0x4141BC0", VA = "0x1841429C0")]
	public bool NHEINPECELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x41424C0", Offset = "0x41416C0", VA = "0x1841424C0")]
	public bool ADDAPCBKDHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x41426B0", Offset = "0x41418B0", VA = "0x1841426B0")]
	public int IBEKOKGJMCA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4142700", Offset = "0x4141900", VA = "0x184142700")]
	public void LHJIBDPGGJJ(out MGLKGJAGMCB NONBBCHHJEI, out MGLKGJAGMCB MIMHCCENBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4142850", Offset = "0x4141A50", VA = "0x184142850")]
	public bool LNACPOFMDHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x41426D0", Offset = "0x41418D0", VA = "0x1841426D0")]
	public double IPMIIEAGJKC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4142510", Offset = "0x4141710", VA = "0x184142510")]
	public static int BEFLCIDJOJB(int MHAKGFHBBPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4142560", Offset = "0x4141760", VA = "0x184142560")]
	public static double FEBEOABHOKL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x41429F0", Offset = "0x4141BF0", VA = "0x1841429F0")]
	public static ulong PLADGLIHPOF(MGLKGJAGMCB JKAMKCGBHEI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct NFBIPANPPKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint FEPAFLADHGH;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x22DE450", Offset = "0x22DD650", VA = "0x1822DE450")]
	public NFBIPANPPKI(float IAKGPAAHECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4141410", Offset = "0x4140610", VA = "0x184141410")]
	public MGLKGJAGMCB HPODONCFEAP()
	{
		return default(MGLKGJAGMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360")]
	public uint NLJIKBLKLBL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x41413F0", Offset = "0x41405F0", VA = "0x1841413F0")]
	public int GEPFPFPIGEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x41413D0", Offset = "0x41405D0", VA = "0x1841413D0")]
	public uint DDLBODCOAMJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x41413C0", Offset = "0x41405C0", VA = "0x1841413C0")]
	public bool BAAKIJOFFMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4141470", Offset = "0x4140670", VA = "0x184141470")]
	public void LHJIBDPGGJJ(out MGLKGJAGMCB NONBBCHHJEI, out MGLKGJAGMCB MIMHCCENBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x41415A0", Offset = "0x41407A0", VA = "0x1841415A0")]
	public bool LNACPOFMDHG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct PFKMJLBMDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong FOBPNDEHEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short EAGCADOBDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short LINEADEGGHD;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B399B0", Offset = "0x5B38BB0", VA = "0x185B399B0")]
	public PFKMJLBMDMG(ulong FOBPNDEHEBK, short EAGCADOBDJJ, short LINEADEGGHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class HNILBLBCIFG
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly PFKMJLBMDMG[] PLKOEAJMAIG;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4132B70", Offset = "0x4131D70", VA = "0x184132B70")]
	public static void LFHEEDAEFLF(int PINJGBDFMBF, int LLHIMEDJMLH, out MGLKGJAGMCB BEPGIAGKDOB, out int LINEADEGGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4132A80", Offset = "0x4131C80", VA = "0x184132A80")]
	public static void DGOLAFPIDNO(int DGJALPAJKFN, out MGLKGJAGMCB BEPGIAGKDOB, out int MMCCEDHLKKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
internal struct MHHCAJILNPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] ODBGNNDKAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int EBEICGFALNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int JGJHJNIAKPA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x413FCD0", Offset = "0x413EED0", VA = "0x18413FCD0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x24A0360", Offset = "0x249F560", VA = "0x1824A0360")]
	public MHHCAJILNPH(byte[] ODBGNNDKAMK, int EBEICGFALNG, int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x12CFDA0", Offset = "0x12CEFA0", VA = "0x1812CFDA0")]
	public int MNKGPEKFPKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x413FC70", Offset = "0x413EE70", VA = "0x18413FC70")]
	public MHHCAJILNPH CBCNBJKEKGL(int PGGPDMLNFLP, int FKGDJKOLCNN)
	{
		return default(MHHCAJILNPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class CEGEGAGOOJE
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] IDAKOJBHNDE;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] PKOHLMJLGCH;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int AJMBDCKFPKM;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x53010E0", Offset = "0x53002E0", VA = "0x1853010E0")]
	private static byte[] KKPIHFFAHNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x53011D0", Offset = "0x53003D0", VA = "0x1853011D0")]
	private static MHHCAJILNPH KMDKFFLNHPA(MHHCAJILNPH ACMMHKGMFIC)
	{
		return default(MHHCAJILNPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5300AB0", Offset = "0x52FFCB0", VA = "0x185300AB0")]
	private static MHHCAJILNPH GGLIOGOABLJ(MHHCAJILNPH ACMMHKGMFIC)
	{
		return default(MHHCAJILNPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5300B60", Offset = "0x52FFD60", VA = "0x185300B60")]
	private static void HJEMODIGNBB(MHHCAJILNPH ACMMHKGMFIC, int LMAPBJLOGJK, byte[] FJCLPBKLGGO, out int COPJDIFOMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x53001C0", Offset = "0x52FF3C0", VA = "0x1853001C0")]
	private static void DELLKAKNGBD(MHHCAJILNPH ACMMHKGMFIC, int LMAPBJLOGJK, byte[] LOAPDLCEOIC, int LKGDNCHEFDC, out MHHCAJILNPH DDLIJPJOBKM, out int FMGPAPJKGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5301460", Offset = "0x5300660", VA = "0x185301460")]
	private static ulong LFHLFNFBIPB(MHHCAJILNPH ACMMHKGMFIC, out int BOCNJOCLMPI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x53014F0", Offset = "0x53006F0", VA = "0x1853014F0")]
	private static void NJCLIEJABPG(MHHCAJILNPH ACMMHKGMFIC, out MGLKGJAGMCB CDNLFEOBNKB, out int PEHFNBHOCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x53006C0", Offset = "0x52FF8C0", VA = "0x1853006C0")]
	private static bool GFFJPJDNLIC(MHHCAJILNPH DDLIJPJOBKM, int LMAPBJLOGJK, out double CDNLFEOBNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5301640", Offset = "0x5300840", VA = "0x185301640")]
	private static MGLKGJAGMCB OLIFLLLLHJE(int LMAPBJLOGJK)
	{
		return default(MGLKGJAGMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5300C20", Offset = "0x52FFE20", VA = "0x185300C20")]
	private static bool JBAGAPGIHBJ(MHHCAJILNPH ACMMHKGMFIC, int LMAPBJLOGJK, out double CDNLFEOBNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5300580", Offset = "0x52FF780", VA = "0x185300580")]
	private static bool FMCOFMMPMCP(MHHCAJILNPH DDLIJPJOBKM, int LMAPBJLOGJK, out double KPMFFEKJHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5300460", Offset = "0x52FF660", VA = "0x185300460")]
	public static double? FDGLFLCKHMN(MHHCAJILNPH ACMMHKGMFIC, int LMAPBJLOGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5301280", Offset = "0x5300480", VA = "0x185301280")]
	public static float? LDBCHFMKCLL(MHHCAJILNPH ACMMHKGMFIC, int LMAPBJLOGJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct ELCOPKMHABJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] ACMMHKGMFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int MOHMCFDNHKH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x5305520", Offset = "0x5304720", VA = "0x185305520")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x176D4C0", Offset = "0x176C6C0", VA = "0x18176D4C0")]
	public ELCOPKMHABJ(byte[] ACMMHKGMFIC, int MOHMCFDNHKH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5305560", Offset = "0x5304760", VA = "0x185305560")]
	public static ELCOPKMHABJ ANIDJAHJKFM(ELCOPKMHABJ DIJPFIMLAFB)
	{
		return default(ELCOPKMHABJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x53056F0", Offset = "0x53048F0", VA = "0x1853056F0")]
	public static ELCOPKMHABJ IOPGNDIMCDO(ELCOPKMHABJ DIJPFIMLAFB, int MNKGPEKFPKK)
	{
		return default(ELCOPKMHABJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5305740", Offset = "0x5304940", VA = "0x185305740")]
	public static int NNBLJOMEMGD(ELCOPKMHABJ BLFKABPCHLN, ELCOPKMHABJ NPFMAENOPCH)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5305630", Offset = "0x5304830", VA = "0x185305630")]
	public static bool IGOCGGBJBII(ELCOPKMHABJ BLFKABPCHLN, ELCOPKMHABJ NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5305570", Offset = "0x5304770", VA = "0x185305570")]
	public static bool BHBKJCPJNJN(ELCOPKMHABJ BLFKABPCHLN, ELCOPKMHABJ NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5305650", Offset = "0x5304850", VA = "0x185305650")]
	public static bool IGOCGGBJBII(ELCOPKMHABJ BLFKABPCHLN, char NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5305590", Offset = "0x5304790", VA = "0x185305590")]
	public static bool BHBKJCPJNJN(ELCOPKMHABJ BLFKABPCHLN, char NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5305590", Offset = "0x5304790", VA = "0x185305590")]
	public static bool BHBKJCPJNJN(ELCOPKMHABJ BLFKABPCHLN, byte NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5305760", Offset = "0x5304960", VA = "0x185305760")]
	public static bool PFAPHMMMKDE(ELCOPKMHABJ BLFKABPCHLN, char NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x53056A0", Offset = "0x53048A0", VA = "0x1853056A0")]
	public static bool IODJPGCEDHP(ELCOPKMHABJ BLFKABPCHLN, char NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x53054D0", Offset = "0x53046D0", VA = "0x1853054D0")]
	public static bool AELEAFGMCMA(ELCOPKMHABJ BLFKABPCHLN, char NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x53055E0", Offset = "0x53047E0", VA = "0x1853055E0")]
	public static bool EFJDJIGNCKC(ELCOPKMHABJ BLFKABPCHLN, char NPFMAENOPCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class CDNHJBDLPEG
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] KIOFDPNBEJA;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] HEKODOEFBGI;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] GJCLDIGDLEJ;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] HAFPDOBBNOG;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] KIPNMPCKCLK;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int CMJDIJHHLCJ;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] ECIIJNDAFKL;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int NNECNDGLLGN;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x52FE640", Offset = "0x52FD840", VA = "0x1852FE640")]
	private static byte[] DEFDNCHMIIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x52FE730", Offset = "0x52FD930", VA = "0x1852FE730")]
	private static byte[] DJFFEMDCKIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x52FE580", Offset = "0x52FD780", VA = "0x1852FE580")]
	public static double CPNFBBNJPOK(byte[] ACMMHKGMFIC, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x52FFB30", Offset = "0x52FED30", VA = "0x1852FFB30")]
	public static float MJINLKHPPFC(byte[] ACMMHKGMFIC, int MOHMCFDNHKH, out int OKKFJCOMNDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x52FE820", Offset = "0x52FDA20", VA = "0x1852FE820")]
	private static bool DPAOFGPGJEL(int FCCGDNMAHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x52FFBF0", Offset = "0x52FEDF0", VA = "0x1852FFBF0")]
	private static bool NNMCAELOCEC(ref ELCOPKMHABJ IJHMKEIOKHN, ELCOPKMHABJ OGINPOLMPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x52FE9C0", Offset = "0x52FDBC0", VA = "0x1852FE9C0")]
	private static bool GBPFMEABKGI(ref ELCOPKMHABJ IJHMKEIOKHN, ELCOPKMHABJ OGINPOLMPBC, byte[] IEKEBCJIKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x52FFD10", Offset = "0x52FEF10", VA = "0x1852FFD10")]
	private static bool PPGLBABDFGI(ref ELCOPKMHABJ KFPKAJFOPDK, byte[] EIBIHJOIINF, int MOHMCFDNHKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x52FE9A0", Offset = "0x52FDBA0", VA = "0x1852FE9A0")]
	private static double FMOOLCFLOIA(bool NIBAMCDBJAB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x52FEAE0", Offset = "0x52FDCE0", VA = "0x1852FEAE0")]
	private static double GLPDNLODEHF(ELCOPKMHABJ KAEDAICECGN, int MNKGPEKFPKK, bool CELPFBOEFPI, out int FOCFFNABOKN)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class HGCDHGNGGPA<T> : global::MJFBLDENKJM<T[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::CAMPPCJALEO<T> GEDKACPPOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly PJFOAADHAFM FKPHGJEJPDE;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1B2E640", Offset = "0x1B2D840", VA = "0x181B2E640")]
	public HGCDHGNGGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1721F60", Offset = "0x1721160", VA = "0x181721F60")]
	public HGCDHGNGGPA(PJFOAADHAFM FKPHGJEJPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7E20", Offset = "0x3FF7020", VA = "0x183FF7E20", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6100", Offset = "0x3FF5300", VA = "0x183FF6100", Slot = "5")]
	public T[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class HOLJHCCEGHC<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::CAMPPCJALEO<T> GEDKACPPOLD;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class CCGABKOJOHO<T> : global::MJFBLDENKJM<List<T>>, CMMCGLEIHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly PJFOAADHAFM FKPHGJEJPDE;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1B2E640", Offset = "0x1B2D840", VA = "0x181B2E640")]
	public CCGABKOJOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1721F60", Offset = "0x1721160", VA = "0x181721F60")]
	public CCGABKOJOHO(PJFOAADHAFM FKPHGJEJPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x26E7660", Offset = "0x26E6860", VA = "0x1826E7660", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, List<T> IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x26E64D0", Offset = "0x26E56D0", VA = "0x1826E64D0", Slot = "5")]
	public List<T> BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class NMBOFCCBGAC<TElement, TIntermediate, TEnumerator, TCollection> : global::MJFBLDENKJM<TCollection>, CMMCGLEIHLB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x23EB370", Offset = "0x23EA570", VA = "0x1823EB370", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, TCollection IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x23EAD90", Offset = "0x23E9F90", VA = "0x1823EAD90", Slot = "5")]
	public TCollection BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator KHMEOGJJAHD(TCollection GLLFHCCFIGK);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GPGHDDABLEF();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CPCILMEHKPA(ref TIntermediate HJHCHKNIJAF, int GMEHLIHLGEH, TElement IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ANFOOJOGONB(ref TIntermediate HGOIFJNPMDP);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	protected NMBOFCCBGAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class IKFCNHLKGLO<TElement, TIntermediate, TCollection> : global::NMBOFCCBGAC<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x1B39FA0", Offset = "0x1B391A0", VA = "0x181B39FA0", Slot = "6")]
	protected override IEnumerator<TElement> KHMEOGJJAHD(TCollection GLLFHCCFIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xD75B50", Offset = "0xD74D50", VA = "0x180D75B50")]
	protected IKFCNHLKGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class BPDKOGEDBFP<TElement, TCollection> : global::IKFCNHLKGLO<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected sealed override TCollection ANFOOJOGONB(ref TCollection HGOIFJNPMDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class MFJLNGGCGBM<TElement, TCollection> : global::BPDKOGEDBFP<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2626660", Offset = "0x2625860", VA = "0x182626660", Slot = "7")]
	protected override TCollection GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x26265F0", Offset = "0x26257F0", VA = "0x1826265F0", Slot = "8")]
	protected override void CPCILMEHKPA(ref TCollection HJHCHKNIJAF, int GMEHLIHLGEH, TElement IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class LDJLKLIOJCB<T> : global::NMBOFCCBGAC<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF400", Offset = "0x1FBE600", VA = "0x181FBF400", Slot = "8")]
	protected override void CPCILMEHKPA(ref LinkedList<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override LinkedList<T> ANFOOJOGONB(ref LinkedList<T> HGOIFJNPMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override LinkedList<T> GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x219FB50", Offset = "0x219ED50", VA = "0x18219FB50", Slot = "6")]
	protected override LinkedList<T>.Enumerator KHMEOGJJAHD(LinkedList<T> GLLFHCCFIGK)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class DBBDOHAFEED<T> : global::NMBOFCCBGAC<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF400", Offset = "0x1FBE600", VA = "0x181FBF400", Slot = "8")]
	protected override void CPCILMEHKPA(ref Queue<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override Queue<T> GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x20BACA0", Offset = "0x20B9EA0", VA = "0x1820BACA0", Slot = "6")]
	protected override Queue<T>.Enumerator KHMEOGJJAHD(Queue<T> GLLFHCCFIGK)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override Queue<T> ANFOOJOGONB(ref Queue<T> HGOIFJNPMDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class BKNHJPKPDDF<T> : global::NMBOFCCBGAC<T, global::MJEACALHAIH<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x1B5F1C0", Offset = "0x1B5E3C0", VA = "0x181B5F1C0", Slot = "8")]
	protected override void CPCILMEHKPA(ref global::MJEACALHAIH<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x21C6310", Offset = "0x21C5510", VA = "0x1821C6310", Slot = "7")]
	protected override global::MJEACALHAIH<T> GPGHDDABLEF()
	{
		return default(global::MJEACALHAIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x20BACA0", Offset = "0x20B9EA0", VA = "0x1820BACA0", Slot = "6")]
	protected override Stack<T>.Enumerator KHMEOGJJAHD(Stack<T> GLLFHCCFIGK)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x21C6230", Offset = "0x21C5430", VA = "0x1821C6230", Slot = "9")]
	protected override Stack<T> ANFOOJOGONB(ref global::MJEACALHAIH<T> HGOIFJNPMDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class ONINNMACMIM<T> : global::NMBOFCCBGAC<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF400", Offset = "0x1FBE600", VA = "0x181FBF400", Slot = "8")]
	protected override void CPCILMEHKPA(ref HashSet<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override HashSet<T> ANFOOJOGONB(ref HashSet<T> HGOIFJNPMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override HashSet<T> GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x20BACA0", Offset = "0x20B9EA0", VA = "0x1820BACA0", Slot = "6")]
	protected override HashSet<T>.Enumerator KHMEOGJJAHD(HashSet<T> GLLFHCCFIGK)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class FEEDLHIGKEP<T> : global::IKFCNHLKGLO<T, global::MJEACALHAIH<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1B5F1C0", Offset = "0x1B5E3C0", VA = "0x181B5F1C0", Slot = "8")]
	protected override void CPCILMEHKPA(ref global::MJEACALHAIH<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1B5F130", Offset = "0x1B5E330", VA = "0x181B5F130", Slot = "9")]
	protected override ReadOnlyCollection<T> ANFOOJOGONB(ref global::MJEACALHAIH<T> HGOIFJNPMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1B5F1F0", Offset = "0x1B5E3F0", VA = "0x181B5F1F0", Slot = "7")]
	protected override global::MJEACALHAIH<T> GPGHDDABLEF()
	{
		return default(global::MJEACALHAIH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class KGCDJAMAJPD<T> : global::IKFCNHLKGLO<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF400", Offset = "0x1FBE600", VA = "0x181FBF400", Slot = "8")]
	protected override void CPCILMEHKPA(ref List<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override List<T> GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override IList<T> ANFOOJOGONB(ref List<T> HGOIFJNPMDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class GIAHIOOFEJO<T> : global::IKFCNHLKGLO<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF400", Offset = "0x1FBE600", VA = "0x181FBF400", Slot = "8")]
	protected override void CPCILMEHKPA(ref List<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override List<T> GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override ICollection<T> ANFOOJOGONB(ref List<T> HGOIFJNPMDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class MCHBKHGBBKA<T> : global::IKFCNHLKGLO<T, global::MJEACALHAIH<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1B5F1C0", Offset = "0x1B5E3C0", VA = "0x181B5F1C0", Slot = "8")]
	protected override void CPCILMEHKPA(ref global::MJEACALHAIH<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x21C6310", Offset = "0x21C5510", VA = "0x1821C6310", Slot = "7")]
	protected override global::MJEACALHAIH<T> GPGHDDABLEF()
	{
		return default(global::MJEACALHAIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3400", Offset = "0x2DD2600", VA = "0x182DD3400", Slot = "9")]
	protected override IEnumerable<T> ANFOOJOGONB(ref global::MJEACALHAIH<T> HGOIFJNPMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xD66070", Offset = "0xD65270", VA = "0x180D66070")]
	public MCHBKHGBBKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class OLMBPCLLFGB<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class IDBAMDANCBF<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class GMBLPEEJNNH<T> : global::MJFBLDENKJM<T>, CMMCGLEIHLB where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x23B9F20", Offset = "0x23B9120", VA = "0x1823B9F20", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x23B9D10", Offset = "0x23B8F10", VA = "0x1823B9D10", Slot = "5")]
	public T BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	public GMBLPEEJNNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class FBCDKJFOODD : global::MJFBLDENKJM<IEnumerable>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::MJFBLDENKJM<IEnumerable> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5305D40", Offset = "0x5304F40", VA = "0x185305D40", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, IEnumerable IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5305AB0", Offset = "0x5304CB0", VA = "0x185305AB0", Slot = "5")]
	public IEnumerable BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public FBCDKJFOODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class BKFPIAAKJJI : global::MJFBLDENKJM<ICollection>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::MJFBLDENKJM<ICollection> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x52FD0D0", Offset = "0x52FC2D0", VA = "0x1852FD0D0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, ICollection IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x52FCE40", Offset = "0x52FC040", VA = "0x1852FCE40", Slot = "5")]
	public ICollection BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public BKFPIAAKJJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class CANCGBHJBMI : global::MJFBLDENKJM<IList>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::MJFBLDENKJM<IList> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x52FE020", Offset = "0x52FD220", VA = "0x1852FE020", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, IList IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x52FDD90", Offset = "0x52FCF90", VA = "0x1852FDD90", Slot = "5")]
	public IList BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CANCGBHJBMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class MKIDMFPNKLE<T> : global::IKFCNHLKGLO<T, global::MJEACALHAIH<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x262B010", Offset = "0x262A210", VA = "0x18262B010", Slot = "8")]
	protected override void CPCILMEHKPA(ref global::MJEACALHAIH<T> HJHCHKNIJAF, int GMEHLIHLGEH, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x262B0A0", Offset = "0x262A2A0", VA = "0x18262B0A0", Slot = "7")]
	protected override global::MJEACALHAIH<T> GPGHDDABLEF()
	{
		return default(global::MJEACALHAIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x262AF90", Offset = "0x262A190", VA = "0x18262AF90", Slot = "9")]
	protected override IReadOnlyList<T> ANFOOJOGONB(ref global::MJEACALHAIH<T> HGOIFJNPMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFDE0", Offset = "0x1FBEFE0", VA = "0x181FBFDE0")]
	public MKIDMFPNKLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class KDAAPGBAGKB
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x4137DD0", Offset = "0x4136FD0", VA = "0x184137DD0")]
	public static DateTime JLLFAGPMEIC(DateTime LEDKEEFMDDC)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class LDJGOEGNNDA : global::MJFBLDENKJM<DateTime>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::MJFBLDENKJM<DateTime> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x413B610", Offset = "0x413A810", VA = "0x18413B610", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, DateTime IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x413A730", Offset = "0x4139930", VA = "0x18413A730", Slot = "5")]
	public DateTime BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LDJGOEGNNDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class LGDLPOPDHLD : global::MJFBLDENKJM<DateTimeOffset>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::MJFBLDENKJM<DateTimeOffset> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x413C9A0", Offset = "0x413BBA0", VA = "0x18413C9A0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, DateTimeOffset IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x413BAD0", Offset = "0x413ACD0", VA = "0x18413BAD0", Slot = "5")]
	public DateTimeOffset BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LGDLPOPDHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JHONJNJJCMH : global::MJFBLDENKJM<TimeSpan>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::MJFBLDENKJM<TimeSpan> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] KOMPMCPODJM;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4136AE0", Offset = "0x4135CE0", VA = "0x184136AE0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, TimeSpan IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x4136220", Offset = "0x4135420", VA = "0x184136220", Slot = "5")]
	public TimeSpan BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public JHONJNJJCMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class OJPCNCCJNHL<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::MJFBLDENKJM<TDictionary>, CMMCGLEIHLB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2033990", Offset = "0x2032B90", VA = "0x182033990", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, TDictionary IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2030D20", Offset = "0x202FF20", VA = "0x182030D20", Slot = "5")]
	public TDictionary BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator KHMEOGJJAHD(TDictionary GLLFHCCFIGK);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GPGHDDABLEF();

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CPCILMEHKPA(ref TIntermediate HJHCHKNIJAF, int GMEHLIHLGEH, TKey FDAIMOMOHIG, TValue IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ANFOOJOGONB(ref TIntermediate HGOIFJNPMDP);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	protected OJPCNCCJNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class KGCBBPINOGB<TKey, TValue, TIntermediate, TDictionary> : global::OJPCNCCJNHL<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x1B39FA0", Offset = "0x1B391A0", VA = "0x181B39FA0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> KHMEOGJJAHD(TDictionary GLLFHCCFIGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class GLOBDMNDMMK<TKey, TValue, TDictionary> : global::KGCBBPINOGB<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override TDictionary ANFOOJOGONB(ref TDictionary HGOIFJNPMDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class PBCPPEFKPBM<TKey, TValue> : global::OJPCNCCJNHL<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x29B84B0", Offset = "0x29B76B0", VA = "0x1829B84B0", Slot = "8")]
	protected override void CPCILMEHKPA(ref Dictionary<TKey, TValue> HJHCHKNIJAF, int GMEHLIHLGEH, TKey FDAIMOMOHIG, TValue IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override Dictionary<TKey, TValue> ANFOOJOGONB(ref Dictionary<TKey, TValue> HGOIFJNPMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override Dictionary<TKey, TValue> GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x29B8540", Offset = "0x29B7740", VA = "0x1829B8540", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator KHMEOGJJAHD(Dictionary<TKey, TValue> GLLFHCCFIGK)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0xD66070", Offset = "0xD65270", VA = "0x180D66070")]
	public PBCPPEFKPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class CBCHHMHPCFP<TKey, TValue, TDictionary> : global::GLOBDMNDMMK<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x3F69E10", Offset = "0x3F69010", VA = "0x183F69E10", Slot = "8")]
	protected override void CPCILMEHKPA(ref TDictionary HJHCHKNIJAF, int GMEHLIHLGEH, TKey FDAIMOMOHIG, TValue IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x17276D0", Offset = "0x17268D0", VA = "0x1817276D0", Slot = "7")]
	protected override TDictionary GPGHDDABLEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class KBNHJFDIJDN<TKey, TValue> : global::KGCBBPINOGB<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2162150", Offset = "0x2161350", VA = "0x182162150", Slot = "8")]
	protected override void CPCILMEHKPA(ref Dictionary<TKey, TValue> HJHCHKNIJAF, int GMEHLIHLGEH, TKey FDAIMOMOHIG, TValue IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override Dictionary<TKey, TValue> GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override IDictionary<TKey, TValue> ANFOOJOGONB(ref Dictionary<TKey, TValue> HGOIFJNPMDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class HIKLKIGFDBE<TKey, TValue> : global::GLOBDMNDMMK<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2162150", Offset = "0x2161350", VA = "0x182162150", Slot = "8")]
	protected override void CPCILMEHKPA(ref SortedList<TKey, TValue> HJHCHKNIJAF, int GMEHLIHLGEH, TKey FDAIMOMOHIG, TValue IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override SortedList<TKey, TValue> GPGHDDABLEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class CJMGBGFKNID<TKey, TValue> : global::OJPCNCCJNHL<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2162150", Offset = "0x2161350", VA = "0x182162150", Slot = "8")]
	protected override void CPCILMEHKPA(ref SortedDictionary<TKey, TValue> HJHCHKNIJAF, int GMEHLIHLGEH, TKey FDAIMOMOHIG, TValue IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ANFOOJOGONB(ref SortedDictionary<TKey, TValue> HGOIFJNPMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF440", Offset = "0x1FBE640", VA = "0x181FBF440", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> GPGHDDABLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x29B8540", Offset = "0x29B7740", VA = "0x1829B8540", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator KHMEOGJJAHD(SortedDictionary<TKey, TValue> GLLFHCCFIGK)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class BIGNJOANFIM<T> : global::MJFBLDENKJM<T>, CMMCGLEIHLB where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x21C3C70", Offset = "0x21C2E70", VA = "0x1821C3C70", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x21C3A40", Offset = "0x21C2C40", VA = "0x1821C3A40", Slot = "5")]
	public T BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	public BIGNJOANFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class MENEHIFILIK : global::MJFBLDENKJM<IDictionary>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::MJFBLDENKJM<IDictionary> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x413F5F0", Offset = "0x413E7F0", VA = "0x18413F5F0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, IDictionary IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x413F420", Offset = "0x413E620", VA = "0x18413F420", Slot = "5")]
	public IDictionary BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MENEHIFILIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class PAGIOEHEEOJ : global::MJFBLDENKJM<object>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private delegate void DLPANKBICLD(object PNPKCHGONFK, ref DDGHBCECKPK KOODAEDNKIK, object IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::MMJCLDFMIOC<KeyValuePair<object, DLPANKBICLD>> LBBGMEJFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly IGFJLJHHKLB[] GBACNBKGIKG;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x4144C20", Offset = "0x4143E20", VA = "0x184144C20")]
	public PAGIOEHEEOJ(params IGFJLJHHKLB[] GBACNBKGIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x41440F0", Offset = "0x41432F0", VA = "0x1841440F0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, object IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x4144050", Offset = "0x4143250", VA = "0x184144050", Slot = "5")]
	public object BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class FNDPAOPBHKP
{
	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x530AF80", Offset = "0x530A180", VA = "0x18530AF80")]
	public static object OJDDKIKJLFL(Type NIFOGEBEDNG, out bool GLAOMAEGHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x530A660", Offset = "0x5309860", VA = "0x18530A660")]
	public static object ALBHMPCIABE(Type NIFOGEBEDNG, out bool GLAOMAEGHCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class BPLEEGPOJBK<T> : global::MJFBLDENKJM<T>, CMMCGLEIHLB, global::PPHMOPOCDGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class HMOBNAICLOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public HMOBNAICLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C763F0", Offset = "0x2C755F0", VA = "0x182C763F0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class BHJAMKLLJPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::AMOHMLHBBDA<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public BHJAMKLLJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x21C1EB0", Offset = "0x21C10B0", VA = "0x1821C1EB0")]
		internal void <.cctor>b__1(ref DDGHBCECKPK writer, T value, IGFJLJHHKLB _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class KBLNHLLALPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::FAJIJCGCKEK<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public KBLNHLLALPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2161750", Offset = "0x2160950", VA = "0x182161750")]
		internal T <.cctor>b__2(ref FJHDMMGBDPE reader, IGFJLJHHKLB _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::APHIADOPKHC<T> BKLCGICOKLP;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> HMCOJBGMKDF;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::AMOHMLHBBDA<T> PLILGKMCLPN;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::FAJIJCGCKEK<T> IGOEBDPPDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool FPBIINGDHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::AMOHMLHBBDA<T> OAMDHEIOGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::FAJIJCGCKEK<T> MIADHGFDDKK;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF680", Offset = "0x1ECE880", VA = "0x181ECF680")]
	static BPLEEGPOJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x1ED05D0", Offset = "0x1ECF7D0", VA = "0x181ED05D0")]
	public BPLEEGPOJBK(bool FPBIINGDHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA0B0", Offset = "0x1EC92B0", VA = "0x181ECA0B0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x1EC83B0", Offset = "0x1EC75B0", VA = "0x181EC83B0", Slot = "5")]
	public T BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9870", Offset = "0x1EC8A70", VA = "0x181EC9870", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, T IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA5D0", Offset = "0x1EC97D0", VA = "0x181ECA5D0", Slot = "7")]
	public T NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class NAFLFKDPONK<T> : global::MJFBLDENKJM<T[,]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x24A9630", Offset = "0x24A8830", VA = "0x1824A9630", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T[,] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x24A9360", Offset = "0x24A8560", VA = "0x1824A9360", Slot = "5")]
	public T[,] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	public NAFLFKDPONK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class KCHPGBIEICC<T> : global::MJFBLDENKJM<T[,,]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x21633A0", Offset = "0x21625A0", VA = "0x1821633A0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T[,,] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2162FC0", Offset = "0x21621C0", VA = "0x182162FC0", Slot = "5")]
	public T[,,] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	public KCHPGBIEICC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class CMAKPDKOEEC<T> : global::MJFBLDENKJM<T[,,,]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AA80", Offset = "0x2C39C80", VA = "0x182C3AA80", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T[,,,] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A580", Offset = "0x2C39780", VA = "0x182C3A580", Slot = "5")]
	public T[,,,] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	public CMAKPDKOEEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class FGCMOIENNOC<T> : global::MJFBLDENKJM<T?>, CMMCGLEIHLB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x1B61050", Offset = "0x1B60250", VA = "0x181B61050", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x1B60E50", Offset = "0x1B60050", VA = "0x181B60E50", Slot = "5")]
	public T? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	public FGCMOIENNOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class DFDDAPOFKIP<T> : global::MJFBLDENKJM<T?>, CMMCGLEIHLB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::MJFBLDENKJM<T> KNIEGGOJBFF;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x1B3B7F0", Offset = "0x1B3A9F0", VA = "0x181B3B7F0")]
	public DFDDAPOFKIP(global::MJFBLDENKJM<T> KNIEGGOJBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x20C9190", Offset = "0x20C8390", VA = "0x1820C9190")]
	public DFDDAPOFKIP(Type JENAKJODMEN, object[] JCPIEGOJLKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x20C8950", Offset = "0x20C7B50", VA = "0x1820C8950", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, T? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x20C7DA0", Offset = "0x20C6FA0", VA = "0x1820C7DA0", Slot = "5")]
	public T? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class KHAGGALPNOB : global::MJFBLDENKJM<sbyte>, CMMCGLEIHLB, global::PPHMOPOCDGD<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly KHAGGALPNOB FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x4138700", Offset = "0x4137900", VA = "0x184138700", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, sbyte IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x41386B0", Offset = "0x41378B0", VA = "0x1841386B0", Slot = "5")]
	public sbyte BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x41386C0", Offset = "0x41378C0", VA = "0x1841386C0", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, sbyte IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x4138720", Offset = "0x4137920", VA = "0x184138720", Slot = "7")]
	public sbyte NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public KHAGGALPNOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class MNNFNNEJACI : global::MJFBLDENKJM<sbyte?>, CMMCGLEIHLB, global::PPHMOPOCDGD<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly MNNFNNEJACI FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4140000", Offset = "0x413F200", VA = "0x184140000", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, sbyte? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x413FF10", Offset = "0x413F110", VA = "0x18413FF10", Slot = "5")]
	public sbyte? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x413FF80", Offset = "0x413F180", VA = "0x18413FF80", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, sbyte? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4140080", Offset = "0x413F280", VA = "0x184140080", Slot = "7")]
	public sbyte? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MNNFNNEJACI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class COFFCFBADJD : global::MJFBLDENKJM<sbyte[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly COFFCFBADJD FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5302140", Offset = "0x5301340", VA = "0x185302140", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, sbyte[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5301F10", Offset = "0x5301110", VA = "0x185301F10", Slot = "5")]
	public sbyte[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public COFFCFBADJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class CMJADOKELFN : global::MJFBLDENKJM<short>, CMMCGLEIHLB, global::PPHMOPOCDGD<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly CMJADOKELFN FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5301DF0", Offset = "0x5300FF0", VA = "0x185301DF0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, short IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5301CD0", Offset = "0x5300ED0", VA = "0x185301CD0", Slot = "5")]
	public short BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5301D30", Offset = "0x5300F30", VA = "0x185301D30", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, short IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5301E30", Offset = "0x5301030", VA = "0x185301E30", Slot = "7")]
	public short NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CMJADOKELFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class ECFCJEGFJIF : global::MJFBLDENKJM<short?>, CMMCGLEIHLB, global::PPHMOPOCDGD<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly ECFCJEGFJIF FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x53049F0", Offset = "0x5303BF0", VA = "0x1853049F0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, short? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5304830", Offset = "0x5303A30", VA = "0x185304830", Slot = "5")]
	public short? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x53048E0", Offset = "0x5303AE0", VA = "0x1853048E0", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, short? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5304A80", Offset = "0x5303C80", VA = "0x185304A80", Slot = "7")]
	public short? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ECFCJEGFJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class CPADCMPLFOO : global::MJFBLDENKJM<short[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly CPADCMPLFOO FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5302570", Offset = "0x5301770", VA = "0x185302570", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, short[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5302340", Offset = "0x5301540", VA = "0x185302340", Slot = "5")]
	public short[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CPADCMPLFOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class MJBMEDMIMCJ : global::MJFBLDENKJM<int>, CMMCGLEIHLB, global::PPHMOPOCDGD<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly MJBMEDMIMCJ FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x413FD60", Offset = "0x413EF60", VA = "0x18413FD60", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, int IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x413FD10", Offset = "0x413EF10", VA = "0x18413FD10", Slot = "5")]
	public int BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x413FD20", Offset = "0x413EF20", VA = "0x18413FD20", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, int IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x413FD70", Offset = "0x413EF70", VA = "0x18413FD70", Slot = "7")]
	public int NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MJBMEDMIMCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class NMKHBNNMEMN : global::MJFBLDENKJM<int?>, CMMCGLEIHLB, global::PPHMOPOCDGD<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly NMKHBNNMEMN FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4141B80", Offset = "0x4140D80", VA = "0x184141B80", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, int? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4141A90", Offset = "0x4140C90", VA = "0x184141A90", Slot = "5")]
	public int? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4141B00", Offset = "0x4140D00", VA = "0x184141B00", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, int? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4141BF0", Offset = "0x4140DF0", VA = "0x184141BF0", Slot = "7")]
	public int? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NMKHBNNMEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class MCHMKLFKCNK : global::MJFBLDENKJM<int[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly MCHMKLFKCNK FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x413F1A0", Offset = "0x413E3A0", VA = "0x18413F1A0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, int[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x413F060", Offset = "0x413E260", VA = "0x18413F060", Slot = "5")]
	public int[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MCHMKLFKCNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class HEPCLNFCIOK : global::MJFBLDENKJM<long>, CMMCGLEIHLB, global::PPHMOPOCDGD<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly HEPCLNFCIOK FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x41321A0", Offset = "0x41313A0", VA = "0x1841321A0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, long IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x4132150", Offset = "0x4131350", VA = "0x184132150", Slot = "5")]
	public long BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x4132160", Offset = "0x4131360", VA = "0x184132160", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, long IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x41321C0", Offset = "0x41313C0", VA = "0x1841321C0", Slot = "7")]
	public long NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HEPCLNFCIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class JMGFLFCNGJI : global::MJFBLDENKJM<long?>, CMMCGLEIHLB, global::PPHMOPOCDGD<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly JMGFLFCNGJI FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x4137410", Offset = "0x4136610", VA = "0x184137410", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, long? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x41372F0", Offset = "0x41364F0", VA = "0x1841372F0", Slot = "5")]
	public long? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x4137380", Offset = "0x4136580", VA = "0x184137380", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, long? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x4137490", Offset = "0x4136690", VA = "0x184137490", Slot = "7")]
	public long? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public JMGFLFCNGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class LHKOHNKMKNN : global::MJFBLDENKJM<long[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly LHKOHNKMKNN FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x413CF20", Offset = "0x413C120", VA = "0x18413CF20", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, long[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x413CDE0", Offset = "0x413BFE0", VA = "0x18413CDE0", Slot = "5")]
	public long[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LHKOHNKMKNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class BNFJJLJCDOC : global::MJFBLDENKJM<byte>, CMMCGLEIHLB, global::PPHMOPOCDGD<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly BNFJJLJCDOC FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x52FDC10", Offset = "0x52FCE10", VA = "0x1852FDC10", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, byte IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x52FDAF0", Offset = "0x52FCCF0", VA = "0x1852FDAF0", Slot = "5")]
	public byte BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x52FDB50", Offset = "0x52FCD50", VA = "0x1852FDB50", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, byte IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x52FDC50", Offset = "0x52FCE50", VA = "0x1852FDC50", Slot = "7")]
	public byte NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public BNFJJLJCDOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class LCDEJLCHLMJ : global::MJFBLDENKJM<byte?>, CMMCGLEIHLB, global::PPHMOPOCDGD<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly LCDEJLCHLMJ FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x413A2F0", Offset = "0x41394F0", VA = "0x18413A2F0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, byte? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x413A200", Offset = "0x4139400", VA = "0x18413A200", Slot = "5")]
	public byte? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x413A270", Offset = "0x4139470", VA = "0x18413A270", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, byte? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x413A370", Offset = "0x4139570", VA = "0x18413A370", Slot = "7")]
	public byte? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LCDEJLCHLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class KMFOEPGBCOM : global::MJFBLDENKJM<ushort>, CMMCGLEIHLB, global::PPHMOPOCDGD<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly KMFOEPGBCOM FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4139D10", Offset = "0x4138F10", VA = "0x184139D10", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, ushort IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x4139CC0", Offset = "0x4138EC0", VA = "0x184139CC0", Slot = "5")]
	public ushort BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x4139CD0", Offset = "0x4138ED0", VA = "0x184139CD0", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, ushort IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x4139D30", Offset = "0x4138F30", VA = "0x184139D30", Slot = "7")]
	public ushort NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public KMFOEPGBCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class KDGDKBLINCA : global::MJFBLDENKJM<ushort?>, CMMCGLEIHLB, global::PPHMOPOCDGD<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly KDGDKBLINCA FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4137F60", Offset = "0x4137160", VA = "0x184137F60", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, ushort? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x4137E70", Offset = "0x4137070", VA = "0x184137E70", Slot = "5")]
	public ushort? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x4137EE0", Offset = "0x41370E0", VA = "0x184137EE0", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, ushort? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x4137FE0", Offset = "0x41371E0", VA = "0x184137FE0", Slot = "7")]
	public ushort? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public KDGDKBLINCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class JMJBDKGPGAH : global::MJFBLDENKJM<ushort[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly JMJBDKGPGAH FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4137780", Offset = "0x4136980", VA = "0x184137780", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, ushort[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4137640", Offset = "0x4136840", VA = "0x184137640", Slot = "5")]
	public ushort[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public JMJBDKGPGAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class HNFNKHIALOB : global::MJFBLDENKJM<uint>, CMMCGLEIHLB, global::PPHMOPOCDGD<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly HNFNKHIALOB FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4132960", Offset = "0x4131B60", VA = "0x184132960", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, uint IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x4132910", Offset = "0x4131B10", VA = "0x184132910", Slot = "5")]
	public uint BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x4132920", Offset = "0x4131B20", VA = "0x184132920", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, uint IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x4132970", Offset = "0x4131B70", VA = "0x184132970", Slot = "7")]
	public uint NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HNFNKHIALOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class FCNCEEOIOLL : global::MJFBLDENKJM<uint?>, CMMCGLEIHLB, global::PPHMOPOCDGD<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly FCNCEEOIOLL FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x53061D0", Offset = "0x53053D0", VA = "0x1853061D0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, uint? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5306010", Offset = "0x5305210", VA = "0x185306010", Slot = "5")]
	public uint? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x53060C0", Offset = "0x53052C0", VA = "0x1853060C0", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, uint? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5306260", Offset = "0x5305460", VA = "0x185306260", Slot = "7")]
	public uint? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public FCNCEEOIOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class GFHHANKEHGG : global::MJFBLDENKJM<uint[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly GFHHANKEHGG FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x530C690", Offset = "0x530B890", VA = "0x18530C690", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, uint[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x530C460", Offset = "0x530B660", VA = "0x18530C460", Slot = "5")]
	public uint[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public GFHHANKEHGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class CEFCHKPOGNG : global::MJFBLDENKJM<ulong>, CMMCGLEIHLB, global::PPHMOPOCDGD<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly CEFCHKPOGNG FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x53000B0", Offset = "0x52FF2B0", VA = "0x1853000B0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, ulong IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x52FFFE0", Offset = "0x52FF1E0", VA = "0x1852FFFE0", Slot = "5")]
	public ulong BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x52FFFF0", Offset = "0x52FF1F0", VA = "0x1852FFFF0", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, ulong IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x53000E0", Offset = "0x52FF2E0", VA = "0x1853000E0", Slot = "7")]
	public ulong NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CEFCHKPOGNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class NAFOGIIEMLI : global::MJFBLDENKJM<ulong?>, CMMCGLEIHLB, global::PPHMOPOCDGD<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly NAFOGIIEMLI FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4140FD0", Offset = "0x41401D0", VA = "0x184140FD0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, ulong? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x4140EB0", Offset = "0x41400B0", VA = "0x184140EB0", Slot = "5")]
	public ulong? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x4140F40", Offset = "0x4140140", VA = "0x184140F40", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, ulong? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x4141050", Offset = "0x4140250", VA = "0x184141050", Slot = "7")]
	public ulong? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NAFOGIIEMLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class JIELOAMFDPC : global::MJFBLDENKJM<ulong[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly JIELOAMFDPC FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4137040", Offset = "0x4136240", VA = "0x184137040", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, ulong[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x4136F00", Offset = "0x4136100", VA = "0x184136F00", Slot = "5")]
	public ulong[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public JIELOAMFDPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class HGCFHOPKOEJ : global::MJFBLDENKJM<float>, CMMCGLEIHLB, global::PPHMOPOCDGD<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly HGCFHOPKOEJ FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4132350", Offset = "0x4131550", VA = "0x184132350", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, float IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x4132300", Offset = "0x4131500", VA = "0x184132300", Slot = "5")]
	public float BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x4132310", Offset = "0x4131510", VA = "0x184132310", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, float IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x4132360", Offset = "0x4131560", VA = "0x184132360", Slot = "7")]
	public float NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HGCFHOPKOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class JPKJHELLDKN : global::MJFBLDENKJM<float?>, CMMCGLEIHLB, global::PPHMOPOCDGD<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly JPKJHELLDKN FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4137A70", Offset = "0x4136C70", VA = "0x184137A70", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, float? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x4137980", Offset = "0x4136B80", VA = "0x184137980", Slot = "5")]
	public float? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x41379F0", Offset = "0x4136BF0", VA = "0x1841379F0", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, float? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4137AF0", Offset = "0x4136CF0", VA = "0x184137AF0", Slot = "7")]
	public float? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public JPKJHELLDKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class CMEJCDLCIGD : global::MJFBLDENKJM<float[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly CMEJCDLCIGD FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5301B00", Offset = "0x5300D00", VA = "0x185301B00", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, float[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x53018D0", Offset = "0x5300AD0", VA = "0x1853018D0", Slot = "5")]
	public float[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CMEJCDLCIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class FDILMGJJMMB : global::MJFBLDENKJM<double>, CMMCGLEIHLB, global::PPHMOPOCDGD<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly FDILMGJJMMB FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x53067B0", Offset = "0x53059B0", VA = "0x1853067B0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, double IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x53066F0", Offset = "0x53058F0", VA = "0x1853066F0", Slot = "5")]
	public double BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5306700", Offset = "0x5305900", VA = "0x185306700", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, double IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x53067C0", Offset = "0x53059C0", VA = "0x1853067C0", Slot = "7")]
	public double NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public FDILMGJJMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class PBFMBENGCFD : global::MJFBLDENKJM<double?>, CMMCGLEIHLB, global::PPHMOPOCDGD<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly PBFMBENGCFD FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5B36EB0", Offset = "0x5B360B0", VA = "0x185B36EB0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, double? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5B36D90", Offset = "0x5B35F90", VA = "0x185B36D90", Slot = "5")]
	public double? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5B36E20", Offset = "0x5B36020", VA = "0x185B36E20", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, double? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5B36F30", Offset = "0x5B36130", VA = "0x185B36F30", Slot = "7")]
	public double? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public PBFMBENGCFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class LDAPKNGPDJC : global::MJFBLDENKJM<double[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly LDAPKNGPDJC FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x413A610", Offset = "0x4139810", VA = "0x18413A610", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, double[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x413A4D0", Offset = "0x41396D0", VA = "0x18413A4D0", Slot = "5")]
	public double[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LDAPKNGPDJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class NMMNIECAOPC : global::MJFBLDENKJM<bool>, CMMCGLEIHLB, global::PPHMOPOCDGD<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly NMMNIECAOPC FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x41423C0", Offset = "0x41415C0", VA = "0x1841423C0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, bool IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x4142370", Offset = "0x4141570", VA = "0x184142370", Slot = "5")]
	public bool BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x4142380", Offset = "0x4141580", VA = "0x184142380", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, bool IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x41423E0", Offset = "0x41415E0", VA = "0x1841423E0", Slot = "7")]
	public bool NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NMMNIECAOPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class IHPOMLNJKLP : global::MJFBLDENKJM<bool?>, CMMCGLEIHLB, global::PPHMOPOCDGD<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly IHPOMLNJKLP FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4135DD0", Offset = "0x4134FD0", VA = "0x184135DD0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, bool? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x4135CE0", Offset = "0x4134EE0", VA = "0x184135CE0", Slot = "5")]
	public bool? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x4135D50", Offset = "0x4134F50", VA = "0x184135D50", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, bool? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4135E50", Offset = "0x4135050", VA = "0x184135E50", Slot = "7")]
	public bool? NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public IHPOMLNJKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class NIBCCMHBIHM : global::MJFBLDENKJM<bool[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly NIBCCMHBIHM FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4141960", Offset = "0x4140B60", VA = "0x184141960", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, bool[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x4141820", Offset = "0x4140A20", VA = "0x184141820", Slot = "5")]
	public bool[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NIBCCMHBIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class AIGHGLMODFK : global::MJFBLDENKJM<object>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::MJFBLDENKJM<object> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> LLKGCEBNFNJ;

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x52FA240", Offset = "0x52F9440", VA = "0x1852FA240", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, object IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x52F9DD0", Offset = "0x52F8FD0", VA = "0x1852F9DD0", Slot = "5")]
	public object BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public AIGHGLMODFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class AJIHMNBLBEM : global::MJFBLDENKJM<byte[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::MJFBLDENKJM<byte[]> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x52FB180", Offset = "0x52FA380", VA = "0x1852FB180", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, byte[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x52FB100", Offset = "0x52FA300", VA = "0x1852FB100", Slot = "5")]
	public byte[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public AJIHMNBLBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class EDLEPDMBEIK : global::MJFBLDENKJM<ArraySegment<byte>>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::MJFBLDENKJM<ArraySegment<byte>> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5304C80", Offset = "0x5303E80", VA = "0x185304C80", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, ArraySegment<byte> IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5304BA0", Offset = "0x5303DA0", VA = "0x185304BA0", Slot = "5")]
	public ArraySegment<byte> BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EDLEPDMBEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class MGJBGEPNGJK : global::MJFBLDENKJM<string>, CMMCGLEIHLB, global::PPHMOPOCDGD<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::MJFBLDENKJM<string> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x413FA10", Offset = "0x413EC10", VA = "0x18413FA10", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, string IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x413FA00", Offset = "0x413EC00", VA = "0x18413FA00", Slot = "5")]
	public string BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x413FA10", Offset = "0x413EC10", VA = "0x18413FA10", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, string IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x413FA00", Offset = "0x413EC00", VA = "0x18413FA00", Slot = "7")]
	public string NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MGJBGEPNGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class AAJMKALDDMA : global::MJFBLDENKJM<string[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly AAJMKALDDMA FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x52F7740", Offset = "0x52F6940", VA = "0x1852F7740", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, string[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x52F74E0", Offset = "0x52F66E0", VA = "0x1852F74E0", Slot = "5")]
	public string[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public AAJMKALDDMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class HCIKECCOGMB : global::MJFBLDENKJM<char>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly HCIKECCOGMB FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4131E20", Offset = "0x4131020", VA = "0x184131E20", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, char IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x4131DF0", Offset = "0x4130FF0", VA = "0x184131DF0", Slot = "5")]
	public char BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HCIKECCOGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class ILMEPGNIBIO : global::MJFBLDENKJM<char?>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly ILMEPGNIBIO FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4136040", Offset = "0x4135240", VA = "0x184136040", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, char? IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x4135F70", Offset = "0x4135170", VA = "0x184135F70", Slot = "5")]
	public char? BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ILMEPGNIBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class DJBACMMMAPM : global::MJFBLDENKJM<char[]>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly DJBACMMMAPM FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x5303FE0", Offset = "0x53031E0", VA = "0x185303FE0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, char[] IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5303DE0", Offset = "0x5302FE0", VA = "0x185303DE0", Slot = "5")]
	public char[] BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public DJBACMMMAPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class HCJFEJFBLJF : global::MJFBLDENKJM<Guid>, CMMCGLEIHLB, global::PPHMOPOCDGD<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::MJFBLDENKJM<Guid> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4132020", Offset = "0x4131220", VA = "0x184132020", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Guid IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x4131F00", Offset = "0x4131100", VA = "0x184131F00", Slot = "5")]
	public Guid BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x4131F50", Offset = "0x4131150", VA = "0x184131F50", Slot = "6")]
	public void HLHIKLNMOKC(ref DDGHBCECKPK KOODAEDNKIK, Guid IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x4131F00", Offset = "0x4131100", VA = "0x184131F00", Slot = "7")]
	public Guid NPOOICGEONB(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HCJFEJFBLJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class FKKDDMEHOGH : global::MJFBLDENKJM<decimal>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::MJFBLDENKJM<decimal> FBJHBFFDBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool GOOAOBJADKN;

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D2ACC0", Offset = "0x3D29EC0", VA = "0x183D2ACC0")]
	public FKKDDMEHOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x15FF2D0", Offset = "0x15FE4D0", VA = "0x1815FF2D0")]
	public FKKDDMEHOGH(bool GOOAOBJADKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x530A410", Offset = "0x5309610", VA = "0x18530A410", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, decimal IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x530A1E0", Offset = "0x53093E0", VA = "0x18530A1E0", Slot = "5")]
	public decimal BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class CDMMJMACDFH : global::MJFBLDENKJM<Uri>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::MJFBLDENKJM<Uri> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x52FE470", Offset = "0x52FD670", VA = "0x1852FE470", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Uri IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x52FE3F0", Offset = "0x52FD5F0", VA = "0x1852FE3F0", Slot = "5")]
	public Uri BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CDMMJMACDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class KABJGLGPHMH : global::MJFBLDENKJM<Version>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::MJFBLDENKJM<Version> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4137CC0", Offset = "0x4136EC0", VA = "0x184137CC0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Version IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x4137C40", Offset = "0x4136E40", VA = "0x184137C40", Slot = "5")]
	public Version BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public KABJGLGPHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class LMMLDMIGJMF<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class IADKBIPBJJN : global::MJFBLDENKJM<StringBuilder>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::MJFBLDENKJM<StringBuilder> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4134F50", Offset = "0x4134150", VA = "0x184134F50", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, StringBuilder IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x4134ED0", Offset = "0x41340D0", VA = "0x184134ED0", Slot = "5")]
	public StringBuilder BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public IADKBIPBJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class EFIHPFNJGDF : global::MJFBLDENKJM<BitArray>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::MJFBLDENKJM<BitArray> FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5304FA0", Offset = "0x53041A0", VA = "0x185304FA0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, BitArray IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5304DA0", Offset = "0x5303FA0", VA = "0x185304DA0", Slot = "5")]
	public BitArray BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EFIHPFNJGDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class HKKHBPCMDEM : global::MJFBLDENKJM<Type>, CMMCGLEIHLB
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly HKKHBPCMDEM FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex OAECAACHEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool EIBKODEGIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool HLKOLMEFAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool HCMLGGANJOE;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x41328A0", Offset = "0x4131AA0", VA = "0x1841328A0")]
	public HKKHBPCMDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x41328C0", Offset = "0x4131AC0", VA = "0x1841328C0")]
	public HKKHBPCMDEM(bool EIBKODEGIAP, bool HLKOLMEFAJN, bool HCMLGGANJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x41326F0", Offset = "0x41318F0", VA = "0x1841326F0", Slot = "4")]
	public void IIADKJHBOIN(ref DDGHBCECKPK KOODAEDNKIK, Type IPMIIEAGJKC, IGFJLJHHKLB NCFFNPEHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x41325C0", Offset = "0x41317C0", VA = "0x1841325C0", Slot = "5")]
	public Type BBCFAILGGHN(ref FJHDMMGBDPE EFKJIOEDNFB, IGFJLJHHKLB NCFFNPEHMPE)
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
