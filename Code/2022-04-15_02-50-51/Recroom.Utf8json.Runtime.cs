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
public class LLGKOOCHMHP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x526C30", Offset = "0x525A30", VA = "0x180526C30")]
	public LLGKOOCHMHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class FCJGEIJNIJG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x526C30", Offset = "0x525A30", VA = "0x180526C30")]
	public FCJGEIJNIJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class FFBHCGEGPGL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x526C30", Offset = "0x525A30", VA = "0x180526C30")]
	public FFBHCGEGPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class BCOMJIOGIKP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x526C30", Offset = "0x525A30", VA = "0x180526C30")]
	public BCOMJIOGIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class JPDIMAFNHON
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x122E210", Offset = "0x122D010", VA = "0x18122E210")]
	public static bool PAFDJIBAIGC(this TypeInfo FHJGHNDLPMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class BAMHCLDOLCG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type JLBLODDLCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] KHDHBABHEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72C190", Offset = "0x72AF90", VA = "0x18072C190")]
	public BAMHCLDOLCG(Type JNEFFEMBHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class JJJIFBDBPOM : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void JGDFFAEJJEI<T>(ref HCOBOFANPFL DEBPKKBLHIL, T FCGCDNFBIMM, FNCBDBAKIPE BELOOHBFKIF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T PIMCHFHKPFJ<T>(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE BELOOHBFKIF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MPKDLPIFHBA
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CEOCDJDEDFJ<T> : MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, T FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OIGDIDGEAPJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, T FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MBKJPDKHNJM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GBNEDFKMJDE
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x36069B0", Offset = "0x36057B0", VA = "0x1836069B0")]
	public static global::CEOCDJDEDFJ<T> CGHHBJIHOHM<T>(this FNCBDBAKIPE BELOOHBFKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xDFAEE0", Offset = "0xDF9CE0", VA = "0x180DFAEE0")]
	public static object GAIPDBCNPGK(this FNCBDBAKIPE BELOOHBFKIF, Type FHJGHNDLPMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DBBICAADHND : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xDF2F60", Offset = "0xDF1D60", VA = "0x180DF2F60")]
	public DBBICAADHND(string EPHFPFMDCAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JHAJJMFJACM
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class EPOGPLOHOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] DIHJAPMJINO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] OHADHJOFAIF;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1218CA0", Offset = "0x1217AA0", VA = "0x181218CA0")]
		public static byte[] OBLCIDAPBAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1218C10", Offset = "0x1217A10", VA = "0x181218C10")]
		public static char[] LONHHOFCIJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> LGKCONEOOGI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] LIGDFBELFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] LPHHCMJDKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int PAFBJKGCIKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool KLNMODGOOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x122CB40", Offset = "0x122B940", VA = "0x18122CB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x122D740", Offset = "0x122C540", VA = "0x18122D740")]
	public JHAJJMFJACM(byte[] LPHHCMJDKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x122D560", Offset = "0x122C360", VA = "0x18122D560")]
	public JHAJJMFJACM(byte[] LPHHCMJDKLK, int PAFBJKGCIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x122C140", Offset = "0x122AF40", VA = "0x18122C140")]
	private BCHCHNCNHMO KMAOAFHEPMJ(string EJKGJLAFGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x122B4A0", Offset = "0x122A2A0", VA = "0x18122B4A0")]
	private BCHCHNCNHMO HHAFEHIIGDH(string EPHFPFMDCAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x121A2F0", Offset = "0x12190F0", VA = "0x18121A2F0")]
	public void FCGMOHFMIJG(int PAFBJKGCIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DA290", Offset = "0x5D9090", VA = "0x1805DA290")]
	public byte[] IIDEBELJGOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DB570", Offset = "0x6DA370", VA = "0x1806DB570")]
	public int MPOFAPNPOIL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x122D2F0", Offset = "0x122C0F0", VA = "0x18122D2F0")]
	public KLHPGOJPJPN PPPNIJMKDLB()
	{
		return default(KLHPGOJPJPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x122C730", Offset = "0x122B530", VA = "0x18122C730")]
	public void OKIBEIIADLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x122BB20", Offset = "0x122A920", VA = "0x18122BB20")]
	public bool JGPFHGNLFJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x122C640", Offset = "0x122B440", VA = "0x18122C640")]
	public bool OBCDLFJAEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x122AAF0", Offset = "0x12298F0", VA = "0x18122AAF0")]
	public void AFKFKNPADCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x122AC00", Offset = "0x1229A00", VA = "0x18122AC00")]
	public bool BBAGKBCMJAJ(ref int BFNOFMOBMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x122B580", Offset = "0x122A380", VA = "0x18122B580")]
	public bool HIJMIHOHKAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x122B3B0", Offset = "0x122A1B0", VA = "0x18122B3B0")]
	public void HBEGJCADAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x122BFE0", Offset = "0x122ADE0", VA = "0x18122BFE0")]
	public bool KBFHKNGMAOM(ref int BFNOFMOBMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x122AB90", Offset = "0x1229990", VA = "0x18122AB90")]
	public bool AIKKMCKMFCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x122C070", Offset = "0x122AE70", VA = "0x18122C070")]
	public void KGFKHFOJJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x122B220", Offset = "0x122A020", VA = "0x18122B220")]
	public bool GBOKEBLABAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x122B030", Offset = "0x1229E30", VA = "0x18122B030")]
	public void EOKMFOHGLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x122CB60", Offset = "0x122B960", VA = "0x18122CB60")]
	private void PMOIBMKECJF(out byte[] IDEEDKCIDAF, out int FJKILJPAEBB, out int OBKBOAGDNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x122B9D0", Offset = "0x122A7D0", VA = "0x18122B9D0")]
	private static int JCHCMKEKNAB(char DCJNBPLJICC, char JLGJJNEIJFM, char OBNNFOCEGEI, char BHCMOACABNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x122C9F0", Offset = "0x122B7F0", VA = "0x18122C9F0")]
	private static int OMOHJIBIMON(char EIPKBLJANKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x122B0D0", Offset = "0x1229ED0", VA = "0x18122B0D0")]
	public ArraySegment<byte> FAFOCCNBJAM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x122BA80", Offset = "0x122A880", VA = "0x18122BA80")]
	public string JCLKNGCIOFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x122C110", Offset = "0x122AF10", VA = "0x18122C110")]
	public string KIILBIAGNNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x122B820", Offset = "0x122A620", VA = "0x18122B820")]
	public ArraySegment<byte> JBLNLCEHCBJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x122ACA0", Offset = "0x1229AA0", VA = "0x18122ACA0")]
	public ArraySegment<byte> CGEEMKOPHPK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x122BC40", Offset = "0x122AA40", VA = "0x18122BC40")]
	public bool JJHOAKJIINP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x122B2F0", Offset = "0x122A0F0", VA = "0x18122B2F0")]
	private static bool GMJIJPGBOOL(byte OBNNFOCEGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x122B650", Offset = "0x122A450", VA = "0x18122B650")]
	private void IMLBMKHMOJF(KLHPGOJPJPN DNBCDMIAJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x122AC90", Offset = "0x1229A90", VA = "0x18122AC90")]
	public void BLOJKPFEGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x122ACE0", Offset = "0x1229AE0", VA = "0x18122ACE0")]
	private void COHADCFNMIA(int GMKIOKBGBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x122B450", Offset = "0x122A250", VA = "0x18122B450")]
	public sbyte HEHNOHBLAFM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x122ADB0", Offset = "0x1229BB0", VA = "0x18122ADB0")]
	public short DBCLAGCBNOC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x122B290", Offset = "0x122A090", VA = "0x18122B290")]
	public int GGJEOKHAEEJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x122C6B0", Offset = "0x122B4B0", VA = "0x18122C6B0")]
	public long OIGMFIAOEAK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x122B1C0", Offset = "0x1229FC0", VA = "0x18122B1C0")]
	public byte FGLBCMDLKIJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x122C5E0", Offset = "0x122B3E0", VA = "0x18122C5E0")]
	public ushort MBIALNBGCKA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x122B5F0", Offset = "0x122A3F0", VA = "0x18122B5F0")]
	public uint ICIOAAKNMGP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x122CAC0", Offset = "0x122B8C0", VA = "0x18122CAC0")]
	public ulong OOLEPFBHOIH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x122BEA0", Offset = "0x122ACA0", VA = "0x18122BEA0")]
	public float JKFHEFHGFOM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x122AF00", Offset = "0x1229D00", VA = "0x18122AF00")]
	public double EMKNCHLOCFH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x122AE10", Offset = "0x1229C10", VA = "0x18122AE10")]
	public ArraySegment<byte> DNKGAMPBJJC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x122C870", Offset = "0x122B670", VA = "0x18122C870")]
	private static int OMEMJNCAJKE(byte[] LPHHCMJDKLK, int PAFBJKGCIKE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BCHCHNCNHMO : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference DPICFPCAFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FJNAJJOCJPF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int GEBPPECFEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xDF00B0", Offset = "0xDEEEB0", VA = "0x180DF00B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string JEGHPHCCOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x567D50", Offset = "0x566B50", VA = "0x180567D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xDF0190", Offset = "0xDEEF90", VA = "0x180DF0190")]
	public BCHCHNCNHMO(string EPHFPFMDCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xDF00C0", Offset = "0xDEEEC0", VA = "0x180DF00C0")]
	public BCHCHNCNHMO(string EPHFPFMDCAN, byte[] IFNHGDGCKOA, int PAFBJKGCIKE, int FJNAJJOCJPF, string AKDDHKLAJBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EMDCBBJOPKI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class PNAAJCMNPNF
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void MDBAJIACFMB(ref HCOBOFANPFL DEBPKKBLHIL, object FCGCDNFBIMM, FNCBDBAKIPE BELOOHBFKIF);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object BPAENGGOCBI(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE BELOOHBFKIF);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class JGMPCLNLGKK
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class IHENHJEHILK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
				public IHENHJEHILK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0xDFCBD0", Offset = "0xDFB9D0", VA = "0x180DFCBD0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0xDFCC10", Offset = "0xDFBA10", VA = "0x180DFCC10")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, FNCBDBAKIPE, byte[]> OFDIHNKAKIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, FNCBDBAKIPE> DKFPPKLDLDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly MDBAJIACFMB LKLOHBJPEGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, FNCBDBAKIPE, ArraySegment<byte>> PFMNGHJJLPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, FNCBDBAKIPE, string> IJJLLLALHAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, FNCBDBAKIPE, object> DCDOLMHMKGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, FNCBDBAKIPE, object> KCPMFAGOMBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, FNCBDBAKIPE, object> ENNECCDAGKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly BPAENGGOCBI BFNPJMPLFPI;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xDFE550", Offset = "0xDFD350", VA = "0x180DFE550")]
			public JGMPCLNLGKK(Type FHJGHNDLPMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2E41A00", Offset = "0x2E40800", VA = "0x182E41A00")]
			private static T PIABHGLAEIE<T>(DynamicMethod HKOAJNOMFDF)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xDFE360", Offset = "0xDFD160", VA = "0x180DFE360")]
			private static MethodInfo CLJOJNJBMOK(Type FHJGHNDLPMM, string OPBNEOMPEGH, Type[] BFHHOCFELDM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, JGMPCLNLGKK> EPJLBCDKDJG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::HECLDNFBCOE<JGMPCLNLGKK> GKJMLOCAPDP;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE01090", Offset = "0xDFFE90", VA = "0x180E01090")]
		static PNAAJCMNPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE00D90", Offset = "0xDFFB90", VA = "0x180E00D90")]
		private static JGMPCLNLGKK CGFNBOFGLFH(Type FHJGHNDLPMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE00E10", Offset = "0xDFFC10", VA = "0x180E00E10")]
		public static void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, object FCGCDNFBIMM, FNCBDBAKIPE BELOOHBFKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xE00F80", Offset = "0xDFFD80", VA = "0x180E00F80")]
		public static void DAIPABBOHEP(Type FHJGHNDLPMM, ref HCOBOFANPFL DEBPKKBLHIL, object FCGCDNFBIMM, FNCBDBAKIPE BELOOHBFKIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class BBGGHFGFKJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] DIHJAPMJINO;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xDEFD90", Offset = "0xDEEB90", VA = "0x180DEFD90")]
		public static byte[] OBLCIDAPBAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static FNCBDBAKIPE GNFKMIGLIAO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] POFECKDJDCD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] JKLIMKBHJNA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FNCBDBAKIPE EICHPCONGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xDF7F60", Offset = "0xDF6D60", VA = "0x180DF7F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xDF8070", Offset = "0xDF6E70", VA = "0x180DF8070")]
	public static void MJBDLDPCOPJ(FNCBDBAKIPE BELOOHBFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0B60", Offset = "0x3EDF960", VA = "0x183EE0B60")]
	public static string DLNMKKLCICI<T>(T FCGCDNFBIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0A00", Offset = "0x3EDF800", VA = "0x183EE0A00")]
	public static string DLNMKKLCICI<T>(T FCGCDNFBIMM, FNCBDBAKIPE BELOOHBFKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E39E30", Offset = "0x2E38C30", VA = "0x182E39E30")]
	public static T OHNHPKBKAFE<T>(string OIECPFFONEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E39EB0", Offset = "0x2E38CB0", VA = "0x182E39EB0")]
	public static T OHNHPKBKAFE<T>(string OIECPFFONEB, FNCBDBAKIPE BELOOHBFKIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E39C60", Offset = "0x2E38A60", VA = "0x182E39C60")]
	public static T OHNHPKBKAFE<T>(byte[] LPHHCMJDKLK, FNCBDBAKIPE BELOOHBFKIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2E39CE0", Offset = "0x2E38AE0", VA = "0x182E39CE0")]
	public static T OHNHPKBKAFE<T>(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, FNCBDBAKIPE BELOOHBFKIF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KLHPGOJPJPN : byte
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
public struct HCOBOFANPFL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] NHBGIHDDMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] DIHJAPMJINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int PAFBJKGCIKE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NJBCNDDJOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6DB570", Offset = "0x6DA370", VA = "0x1806DB570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x121A2F0", Offset = "0x12190F0", VA = "0x18121A2F0")]
	public void FCGMOHFMIJG(int PAFBJKGCIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x121ABB0", Offset = "0x12199B0", VA = "0x18121ABB0")]
	public static byte[] KKOLPAFBDFD(string LPOEHGIAEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1219FE0", Offset = "0x1218DE0", VA = "0x181219FE0")]
	public static byte[] BFNOGCKAPPL(string LPOEHGIAEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x121AD30", Offset = "0x1219B30", VA = "0x18121AD30")]
	public static byte[] MOOJBLOAAEA(string LPOEHGIAEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x121AA50", Offset = "0x1219850", VA = "0x18121AA50")]
	public static byte[] KBFNCFGHDCG(string LPOEHGIAEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x121B420", Offset = "0x121A220", VA = "0x18121B420")]
	public HCOBOFANPFL(byte[] GIPELMEBLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x121AF60", Offset = "0x1219D60", VA = "0x18121AF60")]
	public ArraySegment<byte> OBLCIDAPBAM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x121A240", Offset = "0x1219040", VA = "0x18121A240")]
	public byte[] EEFDGINFFJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x121B370", Offset = "0x121A170", VA = "0x18121B370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x121B090", Offset = "0x1219E90", VA = "0x18121B090")]
	public void PDIEKMGNCOG(int BJKAPIJPPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x121B120", Offset = "0x1219F20", VA = "0x18121B120")]
	public void PNPILJJKLNE(byte[] JEFMEPJIOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x121A330", Offset = "0x1219130", VA = "0x18121A330")]
	public void FKLLINJEDFG(byte JEFMEPJIOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x121B0D0", Offset = "0x1219ED0", VA = "0x18121B0D0")]
	public void PMBJNLPANGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x121A9D0", Offset = "0x12197D0", VA = "0x18121A9D0")]
	public void IENKOHJAOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x121B010", Offset = "0x1219E10", VA = "0x18121B010")]
	public void OCLFGNAGDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x121A110", Offset = "0x1218F10", VA = "0x18121A110")]
	public void BNEDMHBMCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x121AC90", Offset = "0x1219A90", VA = "0x18121AC90")]
	public void LIPILDMACLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x121ACE0", Offset = "0x1219AE0", VA = "0x18121ACE0")]
	public void LMNHCAPOLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x121A1E0", Offset = "0x1218FE0", VA = "0x18121A1E0")]
	public void EAOANOPHEKE(string LPOEHGIAEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x121A160", Offset = "0x1218F60", VA = "0x18121A160")]
	public void CPMEGKIDPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x121AE60", Offset = "0x1219C60", VA = "0x18121AE60")]
	public void NLLLJJONMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x121B180", Offset = "0x1219F80", VA = "0x18121B180")]
	public void POBDCCMIHJN(bool FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x121A740", Offset = "0x1219540", VA = "0x18121A740")]
	public void HALFLDBCDJC(float FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x121A890", Offset = "0x1219690", VA = "0x18121A890")]
	public void HIBNECDGALH(double FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x121B060", Offset = "0x1219E60", VA = "0x18121B060")]
	public void OCNBEOFPKNL(byte FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x121A1B0", Offset = "0x1218FB0", VA = "0x18121A1B0")]
	public void DEKJKPOLGKL(ushort FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x121A300", Offset = "0x1219100", VA = "0x18121A300")]
	public void FJOANBHIDBC(uint FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x121AA20", Offset = "0x1219820", VA = "0x18121AA20")]
	public void JCINCKJJHHH(ulong FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1219FB0", Offset = "0x1218DB0", VA = "0x181219FB0")]
	public void BBNCIANOEFL(sbyte FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x121B0A0", Offset = "0x1219EA0", VA = "0x18121B0A0")]
	public void PLDLHNKJKOH(short FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x121A2C0", Offset = "0x12190C0", VA = "0x18121A2C0")]
	public void ENACNNNACGI(int FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x121AF30", Offset = "0x1219D30", VA = "0x18121AF30")]
	public void OBCILMNOCBN(long FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x121A370", Offset = "0x1219170", VA = "0x18121A370")]
	public void GALBNNGNNPD(string FCGCDNFBIMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CHLPIPHMFPL : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class KKBCEHELIBJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x337BC00", Offset = "0x337AA00", VA = "0x18337BC00")]
		static KKBCEHELIBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private CHLPIPHMFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class OCMAEMBOKJO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> NFMFAGMLDGO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x18C1DD0", Offset = "0x18C0BD0", VA = "0x1818C1DD0")]
	static OCMAEMBOKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x18C1870", Offset = "0x18C0670", VA = "0x1818C1870")]
	internal static object KLLEBEAJFID(Type NIPEJLHCHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class APEEEDNFMNK : global::CEOCDJDEDFJ<Vector2>, MPKDLPIFHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ALIEAEPDMPO AKNKAKIEKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] EBHCIKKHABO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xDEF3A0", Offset = "0xDEE1A0", VA = "0x180DEF3A0")]
	public APEEEDNFMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xDEF100", Offset = "0xDEDF00", VA = "0x180DEF100", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Vector2 FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xDEF1B0", Offset = "0xDEDFB0", VA = "0x180DEF1B0", Slot = "5")]
	public Vector2 OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HNBBJFKBGNH : global::CEOCDJDEDFJ<Vector3>, MPKDLPIFHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly ALIEAEPDMPO AKNKAKIEKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] EBHCIKKHABO;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1227DA0", Offset = "0x1226BA0", VA = "0x181227DA0")]
	public HNBBJFKBGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1227890", Offset = "0x1226690", VA = "0x181227890", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Vector3 FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1227AA0", Offset = "0x12268A0", VA = "0x181227AA0", Slot = "5")]
	public Vector3 OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MLNNOHMHEMA : global::CEOCDJDEDFJ<Vector4>, MPKDLPIFHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly ALIEAEPDMPO AKNKAKIEKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] EBHCIKKHABO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x18BF260", Offset = "0x18BE060", VA = "0x1818BF260")]
	public MLNNOHMHEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xDF9760", Offset = "0xDF8560", VA = "0x180DF9760", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Vector4 FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x18BF030", Offset = "0x18BDE30", VA = "0x1818BF030", Slot = "5")]
	public Vector4 OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class IOIFEJBFCHI : global::CEOCDJDEDFJ<Quaternion>, MPKDLPIFHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly ALIEAEPDMPO AKNKAKIEKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] EBHCIKKHABO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x12296A0", Offset = "0x12284A0", VA = "0x1812296A0")]
	public IOIFEJBFCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x12290F0", Offset = "0x1227EF0", VA = "0x1812290F0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Quaternion FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1229360", Offset = "0x1228160", VA = "0x181229360", Slot = "5")]
	public Quaternion OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class FGBJJIFCJOI : global::CEOCDJDEDFJ<Color>, MPKDLPIFHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ALIEAEPDMPO AKNKAKIEKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] EBHCIKKHABO;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xDF9B40", Offset = "0xDF8940", VA = "0x180DF9B40")]
	public FGBJJIFCJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xDF9760", Offset = "0xDF8560", VA = "0x180DF9760", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Color FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xDF98B0", Offset = "0xDF86B0", VA = "0x180DF98B0", Slot = "5")]
	public Color OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class APNFHKFMMCO : global::CEOCDJDEDFJ<Bounds>, MPKDLPIFHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly ALIEAEPDMPO AKNKAKIEKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] EBHCIKKHABO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xDEFB80", Offset = "0xDEE980", VA = "0x180DEFB80")]
	public APNFHKFMMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xDEF610", Offset = "0xDEE410", VA = "0x180DEF610", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Bounds FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xDEF880", Offset = "0xDEE680", VA = "0x180DEF880", Slot = "5")]
	public Bounds OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class KOAIAGJMKOE : global::CEOCDJDEDFJ<Rect>, MPKDLPIFHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ALIEAEPDMPO AKNKAKIEKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] EBHCIKKHABO;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x18B82D0", Offset = "0x18B70D0", VA = "0x1818B82D0")]
	public KOAIAGJMKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x18B7F00", Offset = "0x18B6D00", VA = "0x1818B7F00", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Rect FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x18B8070", Offset = "0x18B6E70", VA = "0x1818B8070", Slot = "5")]
	public Rect OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class APGAFMKJAMI : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class PEOHGMHAKOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x37B3540", Offset = "0x37B2340", VA = "0x1837B3540")]
		static PEOHGMHAKOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private APGAFMKJAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class CGOCNJDFFEM : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class DMDDANNKCME<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x336EC00", Offset = "0x336DA00", VA = "0x18336EC00")]
		static DMDDANNKCME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class AJEBPLAECAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> LENDMJMKDHI;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xDEB6A0", Offset = "0xDEA4A0", VA = "0x180DEB6A0")]
		internal static object KLLEBEAJFID(Type NIPEJLHCHKC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private CGOCNJDFFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GBKNPNANPLE : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class GNEOPFAAJGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F9EB70", Offset = "0x3F9D970", VA = "0x183F9EB70")]
		static GNEOPFAAJGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GBKNPNANPLE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool MEHKBAHJHJL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static MPKDLPIFHBA[] IIIIPMLJNJJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static FNCBDBAKIPE[] FAAIPOKFNKF;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private GBKNPNANPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xDFAB10", Offset = "0xDF9910", VA = "0x180DFAB10")]
	public static void CNFPNHEAFHE(params FNCBDBAKIPE[] FAAIPOKFNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xDFAA50", Offset = "0xDF9850", VA = "0x180DFAA50")]
	public static void CNFPNHEAFHE(params MPKDLPIFHBA[] IIIIPMLJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xDFABD0", Offset = "0xDF99D0", VA = "0x180DFABD0")]
	public static void FHGLPNPPAPI(MPKDLPIFHBA[] IIIIPMLJNJJ, FNCBDBAKIPE[] FAAIPOKFNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class GFIINJAPDMB : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class CBKNDEHEJNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB250", Offset = "0x2FEA050", VA = "0x182FEB250")]
		static CBKNDEHEJNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private GFIINJAPDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AHJFJAPKNGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly FNCBDBAKIPE MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly FNCBDBAKIPE EBOACGMCIKG;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly FNCBDBAKIPE CAFFMIMLCKB;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly FNCBDBAKIPE FILIDHGCCFF;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly FNCBDBAKIPE HFJBPJBKMFH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FNCBDBAKIPE GDLAAELBGFG;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly FNCBDBAKIPE KFFEFJGFKMA;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly FNCBDBAKIPE GCILDIHJCBM;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly FNCBDBAKIPE OAHCMAAJPGG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly FNCBDBAKIPE ONFHEDFEJAE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly FNCBDBAKIPE COGHBKKECPI;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FNCBDBAKIPE CABIIBHOMIO;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KMGPEANDMGM
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly FNCBDBAKIPE MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly FNCBDBAKIPE KMPFMPJMBKL;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BEDNIJIEDEC
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly FNCBDBAKIPE MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FNCBDBAKIPE EBOACGMCIKG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly FNCBDBAKIPE CAFFMIMLCKB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly FNCBDBAKIPE FILIDHGCCFF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly FNCBDBAKIPE HFJBPJBKMFH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly FNCBDBAKIPE GDLAAELBGFG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly FNCBDBAKIPE KFFEFJGFKMA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly FNCBDBAKIPE GCILDIHJCBM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly FNCBDBAKIPE OAHCMAAJPGG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly FNCBDBAKIPE ONFHEDFEJAE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly FNCBDBAKIPE COGHBKKECPI;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly FNCBDBAKIPE CABIIBHOMIO;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class AFEKNGDDOEA
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> LENDMJMKDHI;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0xDE97C0", Offset = "0xDE85C0", VA = "0x180DE97C0")]
	internal static object KLLEBEAJFID(Type NIPEJLHCHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xDE9780", Offset = "0xDE8580", VA = "0x180DE9780")]
	private static object ECDEKDMFBEO(Type NCEINLJJJID, Type[] DFPFALGOAAI, params object[] BFHHOCFELDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class GAJBJMLKGDM : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class BAHJNPJCMOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F86E00", Offset = "0x3F85C00", VA = "0x183F86E00")]
		static BAHJNPJCMOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly DLOCLAMBODK CDOPHFPJIGA;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0xDFA960", Offset = "0xDF9760", VA = "0x180DFA960")]
	static GAJBJMLKGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private GAJBJMLKGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class DJMIIOBOOGN : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class DOKNHILOBHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x38320B0", Offset = "0x3830EB0", VA = "0x1838320B0")]
		static DOKNHILOBHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly DLOCLAMBODK CDOPHFPJIGA;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0xDF3060", Offset = "0xDF1E60", VA = "0x180DF3060")]
	static DJMIIOBOOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private DJMIIOBOOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class OFPAGGCCDPP : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class MCGCGGAKMCF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x374E7B0", Offset = "0x374D5B0", VA = "0x18374E7B0")]
		static MCGCGGAKMCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly DLOCLAMBODK CDOPHFPJIGA;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x18C2190", Offset = "0x18C0F90", VA = "0x1818C2190")]
	static OFPAGGCCDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private OFPAGGCCDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class GDCNGCMMHEP : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class MGDCBMMGCAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x49791B0", Offset = "0x4977FB0", VA = "0x1849791B0")]
		static MGDCBMMGCAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly DLOCLAMBODK CDOPHFPJIGA;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0xDFB020", Offset = "0xDF9E20", VA = "0x180DFB020")]
	static GDCNGCMMHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private GDCNGCMMHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class MFONHJFIJGI : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class BFJIHLKGLAK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3A77560", Offset = "0x3A76360", VA = "0x183A77560")]
		static BFJIHLKGLAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly DLOCLAMBODK CDOPHFPJIGA;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x18BECC0", Offset = "0x18BDAC0", VA = "0x1818BECC0")]
	static MFONHJFIJGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private MFONHJFIJGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class MGACEHFFGOO : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class EIIAGOPDCDM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3A78490", Offset = "0x3A77290", VA = "0x183A78490")]
		static EIIAGOPDCDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly DLOCLAMBODK CDOPHFPJIGA;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x18BEDB0", Offset = "0x18BDBB0", VA = "0x1818BEDB0")]
	static MGACEHFFGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private MGACEHFFGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class IOHOFOAHKDH : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class JIBNAAPFKFK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3898FD0", Offset = "0x3897DD0", VA = "0x183898FD0")]
		static JIBNAAPFKFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public IOHOFOAHKDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class GIAIDDPPFBH : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class GMFFDEMFEKL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2FFBA20", Offset = "0x2FFA820", VA = "0x182FFBA20")]
		static GMFFDEMFEKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public GIAIDDPPFBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class MBLDODFBDDF : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class KFFEPHAAOEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4670", Offset = "0x3EB3470", VA = "0x183EB4670")]
		static KFFEPHAAOEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public MBLDODFBDDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class KNNHIMCJIBF : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class EDLJHEHNLIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3A1C660", Offset = "0x3A1B460", VA = "0x183A1C660")]
		static EDLJHEHNLIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public KNNHIMCJIBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class GPIMGGIKCNC : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class GCHDKLFHFEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0EC0", Offset = "0x2FEFCC0", VA = "0x182FF0EC0")]
		static GCHDKLFHFEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public GPIMGGIKCNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class PPELDEJELCK : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class FKEMFEIPDNE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2DDBA60", Offset = "0x2DDA860", VA = "0x182DDBA60")]
		static FKEMFEIPDNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> KBMIOFENGNC;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool DDFJMJFCOLG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public PPELDEJELCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class HJCLHLAONHK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct NPBOOAMPEAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public PLEODAKOBLF OGDLHGIKPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder DEDKPOHMMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder GEFIPDCGFAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class NIKFBIJILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class PNJNPIHJFMG
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo MOOJBLOAAEA;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo BFNOGCKAPPL;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo KBFNCFGHDCG;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo KKOLPAFBDFD;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo NLLLJJONMGO;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo PNPILJJKLNE;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo OCLFGNAGDPN;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo BNEDMHBMCAD;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo LIPILDMACLD;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1231160", Offset = "0x122FF60", VA = "0x181231160")]
			static PNJNPIHJFMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class LLDOLLDFBPC
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo JGPFHGNLFJK;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo HBEGJCADAAE;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo KBFHKNGMAOM;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo JAMNNJFEEFI;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo BLOJKPFEGLN;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo IIDEBELJGOM;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo MPOFAPNPOIL;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x122E940", Offset = "0x122D740", VA = "0x18122E940")]
			static LLDOLLDFBPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class FMGKJAFJFBK
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo JLBLODDLCIC;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo KHDHBABHEHJ;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo HEGFCDJCLIC;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo CGHHBJIHOHM;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo IPEIKHGJMIF;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo CEHAMMBFNEK;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo IMKGDPJPCDM;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo HIMFPMEFKPD;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo EBFOPGELBBL;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo MKEGLGNMLMK;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LGOKOMOBJED;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo OGKLDDEOFNF;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo CGDNDBHJGBK;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo AOPJINAHILL;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x122F520", Offset = "0x122E320", VA = "0x18122F520")]
		public static MethodInfo DAIPABBOHEP(Type FHJGHNDLPMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x122F8D0", Offset = "0x122E6D0", VA = "0x18122F8D0")]
		public static MethodInfo OHNHPKBKAFE(Type FHJGHNDLPMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x122F7B0", Offset = "0x122E5B0", VA = "0x18122F7B0")]
		public static MethodInfo GMFKKPFCPGE(Type FHJGHNDLPMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class ADECKCBLKLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<PLEODAKOBLF, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public ADECKCBLKLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class MGPJHMECGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public ADECKCBLKLE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public MGPJHMECGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x122F440", Offset = "0x122E240", VA = "0x18122F440")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x122F480", Offset = "0x122E280", VA = "0x18122F480")]
		internal bool <BuildType>b__2(int index, PLEODAKOBLF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GKDGMHDDAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ADECKCBLKLE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public GKDGMHDDAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x12193B0", Offset = "0x12181B0", VA = "0x1812193B0")]
		internal bool <BuildType>b__3(int index, PLEODAKOBLF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OJMDBGOEMAN
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
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public OJMDBGOEMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1231100", Offset = "0x122FF00", VA = "0x181231100")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class EFONOICAIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public EFONOICAIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1218A30", Offset = "0x1217830", VA = "0x181218A30")]
		internal bool <BuildAnonymousFormatter>b__2(PLEODAKOBLF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class OCPHCCIHDOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public OJMDBGOEMAN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public OCPHCCIHDOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1230F50", Offset = "0x122FD50", VA = "0x181230F50")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1230F60", Offset = "0x122FD60", VA = "0x181230F60")]
		internal bool <BuildAnonymousFormatter>b__6(int index, PLEODAKOBLF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JIGDEBBECIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public OJMDBGOEMAN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public JIGDEBBECIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x122D750", Offset = "0x122C550", VA = "0x18122D750")]
		internal bool <BuildAnonymousFormatter>b__7(int index, PLEODAKOBLF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class IFGAKMIHICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public IFGAKMIHICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x574DF0", Offset = "0x573BF0", VA = "0x180574DF0")]
		internal Label <BuildSerialize>b__1(PLEODAKOBLF _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class KMIIFGECJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NPBOOAMPEAH[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, PLEODAKOBLF, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public HFNKAAECMNM argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HFNKAAECMNM argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public KMIIFGECJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x122E810", Offset = "0x122D610", VA = "0x18122E810")]
		internal NPBOOAMPEAH <BuildDeserialize>b__0(PLEODAKOBLF item)
		{
			return default(NPBOOAMPEAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class FMFKICADBKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public KMIIFGECJGH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public FMFKICADBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1218D20", Offset = "0x1217B20", VA = "0x181218D20")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1218FD0", Offset = "0x1217DD0", VA = "0x181218FD0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class CMFKLMHJCIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public PLEODAKOBLF item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public CMFKLMHJCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1218A10", Offset = "0x1217810", VA = "0x181218A10")]
		internal bool <EmitNewObject>b__0(NPBOOAMPEAH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class LJGHEPDEFEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public PLEODAKOBLF item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public LJGHEPDEFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1218A10", Offset = "0x1217810", VA = "0x181218A10")]
		internal bool <EmitNewObject>b__2(NPBOOAMPEAH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex LMPDHOFBJOB;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int FJAPLMOLMNK;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> IHBHJCIAMKK;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> AMJLBLCHACJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1660", Offset = "0x3EF0460", VA = "0x183EF1660")]
	public static object HKLNBBNJHOP<T>(DLOCLAMBODK CDOPHFPJIGA, FNCBDBAKIPE NJIOGADGDAB, Func<string, string> KBMIOFENGNC, bool DDFJMJFCOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6B50", Offset = "0x3EE5950", VA = "0x183EE6B50")]
	public static object FCIGBHIALOF<T>(FNCBDBAKIPE NJIOGADGDAB, Func<string, string> KBMIOFENGNC, bool DDFJMJFCOLG, bool HIJMNMBFCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1220FC0", Offset = "0x121FDC0", VA = "0x181220FC0")]
	private static TypeInfo KIBCHOMGBIC(DLOCLAMBODK CDOPHFPJIGA, Type FHJGHNDLPMM, Func<string, string> KBMIOFENGNC, bool DDFJMJFCOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x121E560", Offset = "0x121D360", VA = "0x18121E560")]
	public static object DKNAOOOJANN(Type FHJGHNDLPMM, Func<string, string> KBMIOFENGNC, bool DDFJMJFCOLG, bool HIJMNMBFCHM, bool CHMDFLHNNDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x121DF10", Offset = "0x121CD10", VA = "0x18121DF10")]
	private static Dictionary<PLEODAKOBLF, FieldInfo> DIDMBBAEIMB(TypeBuilder BNIOJKMBMHF, GIGHPNJGGAO NEJEEGBOFLB, ConstructorInfo AAJHPJONOLH, FieldBuilder MONIAPAMCFK, ILGenerator CKPKMECMPBI, bool DDFJMJFCOLG, bool HPLBDOHGIOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1224C60", Offset = "0x1223A60", VA = "0x181224C60")]
	private static Dictionary<PLEODAKOBLF, FieldInfo> OFBBNIOPIGI(TypeBuilder BNIOJKMBMHF, GIGHPNJGGAO NEJEEGBOFLB, ILGenerator CKPKMECMPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x12222D0", Offset = "0x12210D0", VA = "0x1812222D0")]
	private static void LMOAIBGIKPI(Type FHJGHNDLPMM, GIGHPNJGGAO NEJEEGBOFLB, ILGenerator CKPKMECMPBI, Action NNMONCCHEHJ, Func<int, PLEODAKOBLF, bool> KOPKIBKLKNM, bool DDFJMJFCOLG, bool HPLBDOHGIOB, int JJDIEPOGEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x121D940", Offset = "0x121C740", VA = "0x18121D940")]
	private static void ACIOLNKMGAG(TypeInfo FHJGHNDLPMM, PLEODAKOBLF DOPDKLNLOFM, ILGenerator CKPKMECMPBI, int HLONBDLBPCF, Func<int, PLEODAKOBLF, bool> KOPKIBKLKNM, HFNKAAECMNM DEBPKKBLHIL, HFNKAAECMNM HNNPHABLIMC, HFNKAAECMNM IMBDFABCKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1223990", Offset = "0x1222790", VA = "0x181223990")]
	private static void ODICJGJLJEF(Type FHJGHNDLPMM, GIGHPNJGGAO NEJEEGBOFLB, ILGenerator CKPKMECMPBI, Func<int, PLEODAKOBLF, bool> KOPKIBKLKNM, bool JNLJGPAEGHK, int JJDIEPOGEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1220B10", Offset = "0x121F910", VA = "0x181220B10")]
	private static void JNOCGLDINAL(ILGenerator CKPKMECMPBI, NPBOOAMPEAH NEJEEGBOFLB, int HLONBDLBPCF, Func<int, PLEODAKOBLF, bool> KOPKIBKLKNM, HFNKAAECMNM FLKIDPNEFDE, HFNKAAECMNM IMBDFABCKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x121FEA0", Offset = "0x121ECA0", VA = "0x18121FEA0")]
	private static LocalBuilder JMOCNPDNELL(ILGenerator CKPKMECMPBI, Type FHJGHNDLPMM, GIGHPNJGGAO NEJEEGBOFLB, NPBOOAMPEAH[] GPLFBNPLAGA, bool CJMEICLLIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1221A60", Offset = "0x1220860", VA = "0x181221A60")]
	private static bool KJNKAEGEBBI(ConstructorInfo PJDEADDOPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1222130", Offset = "0x1220F30", VA = "0x181222130")]
	private static bool LLBODDKJILA(Type FHJGHNDLPMM, out Type NCDIFGJDAGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void EKPIBAKHEGG<T>(byte[][] MONIAPAMCFK, object[] PEPIKJMLMKN, ref HCOBOFANPFL DEBPKKBLHIL, T FCGCDNFBIMM, FNCBDBAKIPE BELOOHBFKIF);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T BCJGLDNFLJJ<T>(object[] PEPIKJMLMKN, ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE BELOOHBFKIF);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class MBKOCLBMIDK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class HHPBNAOCGKA : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class PHPGOBHEKHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3F09960", Offset = "0x3F08760", VA = "0x183F09960")]
		static PHPGOBHEKHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private HHPBNAOCGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class AHHMNFOGLMI : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class DCAHODHOAGD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3BD4980", Offset = "0x3BD3780", VA = "0x183BD4980")]
		static DCAHODHOAGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private AHHMNFOGLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class AEEAKNENMOF
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly FNCBDBAKIPE[] FJNEDPMCAMI;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class EDGOCFECFFA : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class BFBBCKDGNGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x38E8020", Offset = "0x38E6E20", VA = "0x1838E8020")]
		static BFBBCKDGNGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class NPENIMNKPIP : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class AMAPJBBCNEO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x38E2BC0", Offset = "0x38E19C0", VA = "0x1838E2BC0")]
			static AMAPJBBCNEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private NPENIMNKPIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private EDGOCFECFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class LNNPDNCEEDH : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class LIFKPIJMECH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA090", Offset = "0x2CA8E90", VA = "0x182CAA090")]
		static LIFKPIJMECH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class BAEBPHFCEFD : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class PBBFIEODKFO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2CBA580", Offset = "0x2CB9380", VA = "0x182CBA580")]
			static PBBFIEODKFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private BAEBPHFCEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private LNNPDNCEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class CKLJMALIMJG : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class GFCPKBGPEOE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3375F40", Offset = "0x3374D40", VA = "0x183375F40")]
		static GFCPKBGPEOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class PMMJGCMCEBC : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class IIDNGILLBBK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3378D90", Offset = "0x3377B90", VA = "0x183378D90")]
			static IIDNGILLBBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private PMMJGCMCEBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private CKLJMALIMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class AKOBICFENOI : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class PMFMCCGKBOF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3BDE8E0", Offset = "0x3BDD6E0", VA = "0x183BDE8E0")]
		static PMFMCCGKBOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class BJLCCNLEFON : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class ILPFLFOOEBF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3BD8710", Offset = "0x3BD7510", VA = "0x183BD8710")]
			static ILPFLFOOEBF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private BJLCCNLEFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private AKOBICFENOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class PMDKAFMKDNF : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class AMMJNCMCAKD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2DCF670", Offset = "0x2DCE470", VA = "0x182DCF670")]
		static AMMJNCMCAKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class CLMHAAIPHFB : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class GFMOMEIMOGP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0940", Offset = "0x2DDF740", VA = "0x182DE0940")]
			static GFMOMEIMOGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private CLMHAAIPHFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private PMDKAFMKDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class KKBACFNHKFJ : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class OHHMDBHMJHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3A30770", Offset = "0x3A2F570", VA = "0x183A30770")]
		static OHHMDBHMJHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class KGKJPBJPBPB : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class CJOJMEAIMLF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3A1AED0", Offset = "0x3A19CD0", VA = "0x183A1AED0")]
			static CJOJMEAIMLF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private KGKJPBJPBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private KKBACFNHKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class JOBDJDPNLNC : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class ODDCLBKAKLO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F80790", Offset = "0x3F7F590", VA = "0x183F80790")]
		static ODDCLBKAKLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class EIHDBPCHEIL : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class HLBKBNAOKJM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3F6B770", Offset = "0x3F6A570", VA = "0x183F6B770")]
			static HLBKBNAOKJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private EIHDBPCHEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private JOBDJDPNLNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class FGJFAHOMCBM : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class KPOBCDONDPP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C7BB70", Offset = "0x3C7A970", VA = "0x183C7BB70")]
		static KPOBCDONDPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class IMGMFPGCFKD : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class AOJDFHJLPEB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x390D930", Offset = "0x390C730", VA = "0x18390D930")]
			static AOJDFHJLPEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private IMGMFPGCFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private FGJFAHOMCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class IMOGJICGIHL : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class FOLPBIOEDAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x388F4B0", Offset = "0x388E2B0", VA = "0x18388F4B0")]
		static FOLPBIOEDAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class JMAEGHBOODN : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class MEDLLPFCINE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x389E0D0", Offset = "0x389CED0", VA = "0x18389E0D0")]
			static MEDLLPFCINE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private JMAEGHBOODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private IMOGJICGIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class OBFFBGOMLGN : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class EGMCBMKBGLM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3747000", Offset = "0x3745E00", VA = "0x183747000")]
		static EGMCBMKBGLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class KLFJGALFIAC : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class GJECEKLAHIG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x374D3E0", Offset = "0x374C1E0", VA = "0x18374D3E0")]
			static GJECEKLAHIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private KLFJGALFIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private OBFFBGOMLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class JDBHFDLCOAJ : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class PGHNOFOLEBH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x31B87B0", Offset = "0x31B75B0", VA = "0x1831B87B0")]
		static PGHNOFOLEBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class HHPMPALLAFC : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class KKMNHAFMDML<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2FA86E0", Offset = "0x2FA74E0", VA = "0x182FA86E0")]
			static KKMNHAFMDML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private HHPMPALLAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private JDBHFDLCOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class BGJFLMJCMDP : FNCBDBAKIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class CEGMKJGOBPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x37A8A10", Offset = "0x37A7810", VA = "0x1837A8A10")]
		static CEGMKJGOBPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class KELNFNHIDJO : FNCBDBAKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class CDPKKJPNPFF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::CEOCDJDEDFJ<T> PHHKFJIEIBD;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x37A3850", Offset = "0x37A2650", VA = "0x1837A3850")]
			static CDPKKJPNPFF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly FNCBDBAKIPE OECOELJNNCK;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly FNCBDBAKIPE[] FAAIPOKFNKF;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private KELNFNHIDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
		public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly FNCBDBAKIPE OECOELJNNCK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::CEOCDJDEDFJ<object> IPDEONAPIPB;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	private BGJFLMJCMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C28460", Offset = "0x2C27260", VA = "0x182C28460", Slot = "4")]
	public global::CEOCDJDEDFJ<T> KLLEBEAJFID<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct EKPILAKLMGK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] GFKBOHIPCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int CLMEKPFJDDI;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x38F75A0", Offset = "0x38F63A0", VA = "0x1838F75A0")]
	public EKPILAKLMGK(int EKHNIFDNBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x38F71B0", Offset = "0x38F5FB0", VA = "0x1838F71B0")]
	public void ACLEHGEDHGC(T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x38F7510", Offset = "0x38F6310", VA = "0x1838F7510")]
	public T[] BIHOIADABAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class LPAFGOJEFOE : global::PJKNPKOAGND<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly LPAFGOJEFOE MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x18BDF60", Offset = "0x18BCD60", VA = "0x1818BDF60")]
	public LPAFGOJEFOE(int MEJLFLDPGJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class PJKNPKOAGND<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int MEJLFLDPGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object GENLBIKLNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int HLONBDLBPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] GPGHLNOBDCP;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3D56340", Offset = "0x3D55140", VA = "0x183D56340")]
	public PJKNPKOAGND(int MEJLFLDPGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3D54E40", Offset = "0x3D53C40", VA = "0x183D54E40")]
	public T[] LHIFBMNHPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3D54840", Offset = "0x3D53640", VA = "0x183D54840")]
	public void IPCAPBDNIKN(T[] JBGABNPCJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class ALIEAEPDMPO : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class JGMNALNDBEE : IComparable<JGMNALNDBEE>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class OCMNIGOGMOP : IEnumerable<JGMNALNDBEE>, IEnumerable, IEnumerator<JGMNALNDBEE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private JGMNALNDBEE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public JGMNALNDBEE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private JGMNALNDBEE System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA6C0", VA = "0x1807BB8C0")]
			[DebuggerHidden]
			public OCMNIGOGMOP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xE00A90", Offset = "0xDFF890", VA = "0x180E00A90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xE00BC0", Offset = "0xDFF9C0", VA = "0x180E00BC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xE00B20", Offset = "0xDFF920", VA = "0x180E00B20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JGMNALNDBEE> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xE00B20", Offset = "0xDFF920", VA = "0x180E00B20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class HACMDKIHBIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public HACMDKIHBIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x574DF0", Offset = "0x573BF0", VA = "0x180574DF0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x574DF0", Offset = "0x573BF0", VA = "0x180574DF0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly JGMNALNDBEE[] EJGGNIPFJLN;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] LCOJABMFCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong CMHEHIDHKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int PGEGKAIHDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string OGGHAHADHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private JGMNALNDBEE[] GGJLBPBFELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] PGOEEKCEMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int BFNOFMOBMGJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IPKCJEPGLIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xDFD500", Offset = "0xDFC300", VA = "0x180DFD500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xDFE2A0", Offset = "0xDFD0A0", VA = "0x180DFE2A0")]
		public JGMNALNDBEE(ulong IIIMPJEHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xDFCFE0", Offset = "0xDFBDE0", VA = "0x180DFCFE0")]
		public JGMNALNDBEE ACLEHGEDHGC(ulong IIIMPJEHMOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xDFCF90", Offset = "0xDFBD90", VA = "0x180DFCF90")]
		public JGMNALNDBEE ACLEHGEDHGC(ulong IIIMPJEHMOP, int FCGCDNFBIMM, string OGGHAHADHOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xDFD320", Offset = "0xDFC120", VA = "0x180DFD320")]
		public JGMNALNDBEE BKLIAJOBMNA(byte[] IBFKLEGHPPP, ref int PAFBJKGCIKE, ref int KLFFIHBOALM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xDFD510", Offset = "0xDFC310", VA = "0x180DFD510")]
		internal static int IGCAJFGGAFO(ulong[] JBGABNPCJKJ, int HLONBDLBPCF, int FFNDHEJLEJA, ulong FCGCDNFBIMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xDFD4D0", Offset = "0xDFC2D0", VA = "0x180DFD4D0", Slot = "4")]
		public int CompareTo(JGMNALNDBEE MDLBKDPKIHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xDFE1B0", Offset = "0xDFCFB0", VA = "0x180DFE1B0")]
		[IteratorStateMachine(typeof(OCMNIGOGMOP))]
		public IEnumerable<JGMNALNDBEE> OBDBLDHCKGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xDFD1D0", Offset = "0xDFBFD0", VA = "0x180DFD1D0")]
		public void BBBCKJJCKNB(ILGenerator CKPKMECMPBI, LocalBuilder IBFKLEGHPPP, LocalBuilder KLFFIHBOALM, LocalBuilder IIIMPJEHMOP, Action<KeyValuePair<string, int>> IEBGFFDKCKH, Action IIGAMCKNMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xDFD590", Offset = "0xDFC390", VA = "0x180DFD590")]
		private static void MHNFAOKNCFP(ILGenerator CKPKMECMPBI, LocalBuilder IBFKLEGHPPP, LocalBuilder KLFFIHBOALM, LocalBuilder IIIMPJEHMOP, Action<KeyValuePair<string, int>> IEBGFFDKCKH, Action IIGAMCKNMOO, JGMNALNDBEE[] GGJLBPBFELJ, int BFNOFMOBMGJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class IEHMLNLFHFN : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<JGMNALNDBEE> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<JGMNALNDBEE> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<JGMNALNDBEE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private JGMNALNDBEE <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x56D1A0", Offset = "0x56BFA0", VA = "0x18056D1A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xDFC9E0", Offset = "0xDFB7E0", VA = "0x180DFC9E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xCA7D10", Offset = "0xCA6B10", VA = "0x180CA7D10")]
		[DebuggerHidden]
		public IEHMLNLFHFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xDFCA30", Offset = "0xDFB830", VA = "0x180DFCA30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xDFC570", Offset = "0xDFB370", VA = "0x180DFC570", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xDFCB30", Offset = "0xDFB930", VA = "0x180DFCB30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xDFCB80", Offset = "0xDFB980", VA = "0x180DFCB80")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xDFC990", Offset = "0xDFB790", VA = "0x180DFC990", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xDFC8F0", Offset = "0xDFB6F0", VA = "0x180DFC8F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xDFC8F0", Offset = "0xDFB6F0", VA = "0x180DFC8F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly JGMNALNDBEE FEAMLIHDEIF;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xDED9A0", Offset = "0xDEC7A0", VA = "0x180DED9A0")]
	public ALIEAEPDMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xDED2C0", Offset = "0xDEC0C0", VA = "0x180DED2C0")]
	public void ACLEHGEDHGC(byte[] LPHHCMJDKLK, int FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xDED550", Offset = "0xDEC350", VA = "0x180DED550")]
	public bool IPFNCHGLKLL(ArraySegment<byte> IIIMPJEHMOP, out int FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0xDED8B0", Offset = "0xDEC6B0", VA = "0x180DED8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0xDED600", Offset = "0xDEC400", VA = "0x180DED600")]
	private static void PDABKDOCOKO(IEnumerable<JGMNALNDBEE> GGJLBPBFELJ, StringBuilder CAKACIEAOBA, int JNMLENKGGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0xDED450", Offset = "0xDEC250", VA = "0x180DED450", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0xDED450", Offset = "0xDEC250", VA = "0x180DED450", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0xDED3E0", Offset = "0xDEC1E0", VA = "0x180DED3E0")]
	[IteratorStateMachine(typeof(IEHMLNLFHFN))]
	private static IEnumerable<KeyValuePair<string, int>> GAKBFABAECP(IEnumerable<JGMNALNDBEE> GGJLBPBFELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xDED880", Offset = "0xDEC680", VA = "0x180DED880")]
	public void PHHJIMGHDPM(ILGenerator CKPKMECMPBI, LocalBuilder IBFKLEGHPPP, LocalBuilder KLFFIHBOALM, LocalBuilder IIIMPJEHMOP, Action<KeyValuePair<string, int>> IEBGFFDKCKH, Action IIGAMCKNMOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class LKFKAIFFIHL
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo HBPCHBOFLFP;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x18BCD10", Offset = "0x18BBB10", VA = "0x1818BCD10")]
	public static ulong JNPCCNJMLNA(byte[] LPHHCMJDKLK, ref int PAFBJKGCIKE, ref int KLFFIHBOALM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class BIAONECIHDG
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xDF0B40", Offset = "0xDEF940", VA = "0x180DF0B40")]
	public static void PDIEKMGNCOG(ref byte[] LPHHCMJDKLK, int PAFBJKGCIKE, int BJKAPIJPPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xDF0960", Offset = "0xDEF760", VA = "0x180DF0960")]
	public static void DOMLKGHJCMJ(ref byte[] JBGABNPCJKJ, int NJPLAFPDJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0xDF0A50", Offset = "0xDEF850", VA = "0x180DF0A50")]
	public static byte[] ENMMAEHPDMP(byte[] HGAAFEBCBKI, int NJPLAFPDJJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class DECGBCNOPJL
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0xDF2FD0", Offset = "0xDF1DD0", VA = "0x180DF2FD0")]
	public static bool FFGLJKBEKDL(byte[] OAHIACKAELH, int LMFBNIKPFCM, int HAHFNMIIJJI, byte[] LEFOIFDEGLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class LABBPEDDFPM<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct OAJLLMPBNGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] CMHEHIDHKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T PGEGKAIHDFD;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3A2BF90", Offset = "0x3A2AD90", VA = "0x183A2BF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class OMAEPJIOCIP : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::LABBPEDDFPM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private OAJLLMPBNGL[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private OAJLLMPBNGL[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2725550", Offset = "0x2724350", VA = "0x182725550", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A34FB0", Offset = "0x3A33DB0", VA = "0x183A34FB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x28DE5A0", Offset = "0x28DD3A0", VA = "0x1828DE5A0")]
		[DebuggerHidden]
		public OMAEPJIOCIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A347B0", Offset = "0x3A335B0", VA = "0x183A347B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A34E20", Offset = "0x3A33C20", VA = "0x183A34E20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly OAJLLMPBNGL[][] LCFANDDIFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong DKEMANKFIJL;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA830", Offset = "0x3BF9630", VA = "0x183BFA830")]
	public LABBPEDDFPM(int EHCNCIHFDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA770", Offset = "0x3BF9570", VA = "0x183BFA770")]
	public LABBPEDDFPM(int EHCNCIHFDGJ, float KDLJIGMJOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F490A0", Offset = "0x3F47EA0", VA = "0x183F490A0")]
	public void ACLEHGEDHGC(byte[] IIIMPJEHMOP, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F4C760", Offset = "0x3F4B560", VA = "0x183F4C760")]
	private bool AKFFNMAGJGF(byte[] IIIMPJEHMOP, T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FC30", Offset = "0x3F4EA30", VA = "0x183F4FC30")]
	public bool EIEDLFBIOLG(ArraySegment<byte> IIIMPJEHMOP, out T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA710", Offset = "0x3BF9510", VA = "0x183BFA710")]
	private static ulong NBGHPKFFIAJ(byte[] EIPKBLJANKN, int PAFBJKGCIKE, int BFNOFMOBMGJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9D10", Offset = "0x3BF8B10", VA = "0x183BF9D10")]
	private static int DIMPILAMMKN(int MKCBHGNCJCI, float KDLJIGMJOFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA5F0", Offset = "0x3BF93F0", VA = "0x183BFA5F0", Slot = "4")]
	[IteratorStateMachine(typeof(global::LABBPEDDFPM<>.OMAEPJIOCIP))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2954AA0", Offset = "0x29538A0", VA = "0x182954AA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class CIKKOEIFAFL : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] NPNNKOJCJIL;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] BLOLPLGMEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int IBBGDLJBIPO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool ECLOCHKAEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xDF2210", Offset = "0xDF1010", VA = "0x180DF2210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xDF2370", Offset = "0xDF1170", VA = "0x180DF2370")]
	static CIKKOEIFAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xDF25C0", Offset = "0xDF13C0", VA = "0x180DF25C0")]
	public CIKKOEIFAFL(byte[] ABIIBLNJDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xDF2260", Offset = "0xDF1060", VA = "0x180DF2260")]
	public OpCode GCKCCNJPKJN()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct DOIIKNELOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid PGEGKAIHDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte EAJBEOIANFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte LLLBJDAKDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte GHPPCLCKDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte EBJKLEGONGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte AEBFNDPOOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte DCJCAACKHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte LFDFLPHPGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte DDKAEKCCOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte CIGFIEOIINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte FOMMDGDLNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte KMJHFKAGENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte NMOKCKHNGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte DJBDIENOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte OJMNJMEAMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte CNPHEBPJCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte NHFIFBEALJB;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] KFEBMIFHEPK;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] MLIFDBCBIKI;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xDF50C0", Offset = "0xDF3EC0", VA = "0x180DF50C0")]
	public DOIIKNELOBP(ref Guid FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xDF4A10", Offset = "0xDF3810", VA = "0x180DF4A10")]
	public DOIIKNELOBP(ref ArraySegment<byte> HAFDDKAEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xDF48A0", Offset = "0xDF36A0", VA = "0x180DF48A0")]
	private static byte OCIFKLCCPNP(byte[] LPHHCMJDKLK, int KOJOEGBJOHA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xDF4790", Offset = "0xDF3590", VA = "0x180DF4790")]
	private static byte LGACFKLBBME(byte JLGJJNEIJFM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xDF3450", Offset = "0xDF2250", VA = "0x180DF3450")]
	public void JMBMMILMLBI(byte[] DIHJAPMJINO, int PAFBJKGCIKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class KPPNGNAIKJE
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x18B89C0", Offset = "0x18B77C0", VA = "0x1818B89C0")]
	public static bool AEKDGGEBHFP(byte OBNNFOCEGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x18BA580", Offset = "0x18B9380", VA = "0x1818BA580")]
	public static bool PHIHAPNNPNI(byte OBNNFOCEGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x18B8B90", Offset = "0x18B7990", VA = "0x1818B8B90")]
	public static sbyte HEHNOHBLAFM(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x18B89D0", Offset = "0x18B77D0", VA = "0x1818B89D0")]
	public static short DBCLAGCBNOC(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x18B8B20", Offset = "0x18B7920", VA = "0x1818B8B20")]
	public static int GGJEOKHAEEJ(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x18BA3C0", Offset = "0x18B91C0", VA = "0x1818BA3C0")]
	public static long OIGMFIAOEAK(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x18B8AB0", Offset = "0x18B78B0", VA = "0x1818B8AB0")]
	public static byte FGLBCMDLKIJ(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x18B9710", Offset = "0x18B8510", VA = "0x1818B9710")]
	public static ushort MBIALNBGCKA(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x18B8C00", Offset = "0x18B7A00", VA = "0x1818B8C00")]
	public static uint ICIOAAKNMGP(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x18BA470", Offset = "0x18B9270", VA = "0x1818BA470")]
	public static ulong OOLEPFBHOIH(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x18B96A0", Offset = "0x18B84A0", VA = "0x1818B96A0")]
	public static float JKFHEFHGFOM(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x18B8A40", Offset = "0x18B7840", VA = "0x1818B8A40")]
	public static double EMKNCHLOCFH(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x18B8C80", Offset = "0x18B7A80", VA = "0x1818B8C80")]
	public static int JCINCKJJHHH(ref byte[] DIHJAPMJINO, int PAFBJKGCIKE, ulong FCGCDNFBIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x18B9780", Offset = "0x18B8580", VA = "0x1818B9780")]
	public static int OBCILMNOCBN(ref byte[] DIHJAPMJINO, int PAFBJKGCIKE, long FCGCDNFBIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x18B9450", Offset = "0x18B8250", VA = "0x1818B9450")]
	public static bool JJHOAKJIINP(byte[] LPHHCMJDKLK, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class LJIJBBFBKBI
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class HPAGMIAHNIE : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA6C0", VA = "0x1807BB8C0")]
		[DebuggerHidden]
		public HPAGMIAHNIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x18B6F00", Offset = "0x18B5D00", VA = "0x1818B6F00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x18B6AA0", Offset = "0x18B58A0", VA = "0x1818B6AA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x18B7020", Offset = "0x18B5E20", VA = "0x1818B7020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x18B7070", Offset = "0x18B5E70", VA = "0x1818B7070")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x18B6EB0", Offset = "0x18B5CB0", VA = "0x1818B6EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x18B6E00", Offset = "0x18B5C00", VA = "0x1818B6E00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x18B6E00", Offset = "0x18B5C00", VA = "0x1818B6E00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class JFLEHKNPKBD : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA6C0", VA = "0x1807BB8C0")]
		[DebuggerHidden]
		public JFLEHKNPKBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x18B7520", Offset = "0x18B6320", VA = "0x1818B7520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x18B70C0", Offset = "0x18B5EC0", VA = "0x1818B70C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x18B7640", Offset = "0x18B6440", VA = "0x1818B7640")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x18B7690", Offset = "0x18B6490", VA = "0x1818B7690")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x18B74D0", Offset = "0x18B62D0", VA = "0x1818B74D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x18B7420", Offset = "0x18B6220", VA = "0x1818B7420", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x18B7420", Offset = "0x18B6220", VA = "0x1818B7420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x18BC980", Offset = "0x18BB780", VA = "0x1818BC980")]
	public static bool AABKEKEPCKN(this TypeInfo FHJGHNDLPMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x18BCAC0", Offset = "0x18BB8C0", VA = "0x1818BCAC0")]
	public static bool FCKDLACPBPN(this TypeInfo FHJGHNDLPMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x18BCBC0", Offset = "0x18BB9C0", VA = "0x1818BCBC0")]
	public static IEnumerable<PropertyInfo> INLHCNMBHNJ(this Type FHJGHNDLPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x18BCC20", Offset = "0x18BBA20", VA = "0x1818BCC20")]
	[IteratorStateMachine(typeof(HPAGMIAHNIE))]
	private static IEnumerable<PropertyInfo> OBLIDLFMIDF(Type FHJGHNDLPMM, HashSet<string> DMHPBMBFGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x18BCCB0", Offset = "0x18BBAB0", VA = "0x1818BCCB0")]
	public static IEnumerable<FieldInfo> PACGGGPKBJA(this Type FHJGHNDLPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x18BCA30", Offset = "0x18BB830", VA = "0x1818BCA30")]
	[IteratorStateMachine(typeof(JFLEHKNPKBD))]
	private static IEnumerable<FieldInfo> AAHJHJKIMOE(Type FHJGHNDLPMM, HashSet<string> DMHPBMBFGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class HBJGFLPPLGF
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding PJEDJGBIGOM;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class NFJADFELIEP
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5EE200", Offset = "0x5ED000", VA = "0x1805EE200")]
	public static string IIEEGEJMHJO(string FANBJFHCKPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x18BFBA0", Offset = "0x18BE9A0", VA = "0x1818BFBA0")]
	public static string GGHFOFKHDHB(string FANBJFHCKPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x18BFCB0", Offset = "0x18BEAB0", VA = "0x1818BFCB0")]
	public static string MIAEOIFFEAC(string FANBJFHCKPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class HECLDNFBCOE<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class JPIFOGJFANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type CMHEHIDHKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue PGEGKAIHDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int EBAJMBKCNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public JPIFOGJFANP AEGJDDFPAIG;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3F04CF0", Offset = "0x3F03AF0", VA = "0x183F04CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3F04CB0", Offset = "0x3F03AB0", VA = "0x183F04CB0")]
		private int KBFJPEDAEJJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public JPIFOGJFANP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class KNFJPCAHMDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public KNFJPCAHMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5DA2A0", Offset = "0x5D90A0", VA = "0x1805DA2A0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private JPIFOGJFANP[] LCFANDDIFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int NEPCFDJCABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object MMHGFHBHGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float KDLJIGMJOFL;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3F04260", Offset = "0x3F03060", VA = "0x183F04260")]
	public HECLDNFBCOE(int EHCNCIHFDGJ = 4, float KDLJIGMJOFL = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3F03440", Offset = "0x3F02240", VA = "0x183F03440")]
	public bool AMCNFHOKNDD(Type IIIMPJEHMOP, TValue FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3F03550", Offset = "0x3F02350", VA = "0x183F03550")]
	public bool AMCNFHOKNDD(Type IIIMPJEHMOP, Func<Type, TValue> FBNOBJALMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3F03140", Offset = "0x3F01F40", VA = "0x183F03140")]
	private bool AKFFNMAGJGF(Type IIIMPJEHMOP, Func<Type, TValue> FBNOBJALMJM, out TValue ADJIFDJBMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3F03EA0", Offset = "0x3F02CA0", VA = "0x183F03EA0")]
	private bool JBOPPICAPFA(JPIFOGJFANP[] LCFANDDIFAA, Type LJKGFOGKFNE, JPIFOGJFANP LGOGMKLLAJM, Func<Type, TValue> FBNOBJALMJM, out TValue ADJIFDJBMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3F03980", Offset = "0x3F02780", VA = "0x183F03980")]
	public bool EIEDLFBIOLG(Type IIIMPJEHMOP, out TValue FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3F03790", Offset = "0x3F02590", VA = "0x183F03790")]
	public TValue CGFNBOFGLFH(Type IIIMPJEHMOP, Func<Type, TValue> FBNOBJALMJM)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9D10", Offset = "0x3BF8B10", VA = "0x183BF9D10")]
	private static int DIMPILAMMKN(int MKCBHGNCJCI, float KDLJIGMJOFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3F03AD0", Offset = "0x3F028D0", VA = "0x183F03AD0")]
	private static void FCBHHJNALFK(ref JPIFOGJFANP JEJEHEHEEKA, JPIFOGJFANP FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3F03AD0", Offset = "0x3F028D0", VA = "0x183F03AD0")]
	private static void FCBHHJNALFK(ref JPIFOGJFANP[] JEJEHEHEEKA, JPIFOGJFANP[] FCGCDNFBIMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class DLOCLAMBODK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder CJOJAIHCDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder NNPJILPDOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object GENLBIKLNCE;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0xDF3150", Offset = "0xDF1F50", VA = "0x180DF3150")]
	public TypeBuilder KOHCLHOONII(string OPBNEOMPEGH, TypeAttributes CDGAFKGPNHL, Type MGDGFFLAOJF, Type[] CGDCNKDNCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0xDF3240", Offset = "0xDF2040", VA = "0x180DF3240")]
	public DLOCLAMBODK(string ADLDJEHMDOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class IJBECNOIAJC
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1228C60", Offset = "0x1227A60", VA = "0x181228C60")]
	private static MethodInfo GCDANBJJCFD(LambdaExpression IAGJOONGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8DD0", Offset = "0x3EF7BD0", VA = "0x183EF8DD0")]
	public static MethodInfo LNDANLOPLCH<T>(Expression<Func<T>> IAGJOONGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8DD0", Offset = "0x3EF7BD0", VA = "0x183EF8DD0")]
	public static MethodInfo LNDANLOPLCH<T, TR>(Expression<Func<T, TR>> IAGJOONGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8DD0", Offset = "0x3EF7BD0", VA = "0x183EF8DD0")]
	public static MethodInfo LNDANLOPLCH<T>(Expression<Action<T>> IAGJOONGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8DD0", Offset = "0x3EF7BD0", VA = "0x183EF8DD0")]
	public static MethodInfo LNDANLOPLCH<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> IAGJOONGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8DE0", Offset = "0x3EF7BE0", VA = "0x183EF8DE0")]
	private static MemberInfo MHLPPPBNKCL<T>(Expression<T> HBOGJLGKGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8D70", Offset = "0x3EF7B70", VA = "0x183EF8D70")]
	public static PropertyInfo FAJHCBDEINM<T, TR>(Expression<Func<T, TR>> IAGJOONGBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct HFNKAAECMNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int JOJIIFJCHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool IFALIGKBLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator CKPKMECMPBI;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x121CE30", Offset = "0x121BC30", VA = "0x18121CE30")]
	public HFNKAAECMNM(ILGenerator CKPKMECMPBI, int JOJIIFJCHGB, bool IFALIGKBLLK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x121CE70", Offset = "0x121BC70", VA = "0x18121CE70")]
	public HFNKAAECMNM(ILGenerator CKPKMECMPBI, int JOJIIFJCHGB, Type FHJGHNDLPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x121CE10", Offset = "0x121BC10", VA = "0x18121CE10")]
	public void IBLGHIFABKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class DONOAFNCFGM
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xDF58E0", Offset = "0xDF46E0", VA = "0x180DF58E0")]
	public static void LHAIBGAHPPA(this ILGenerator CKPKMECMPBI, int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xDF5B10", Offset = "0xDF4910", VA = "0x180DF5B10")]
	public static void LHAIBGAHPPA(this ILGenerator CKPKMECMPBI, LocalBuilder EJMKPPFHCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xDF55E0", Offset = "0xDF43E0", VA = "0x180DF55E0")]
	public static void JFIBLLMPIKN(this ILGenerator CKPKMECMPBI, int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xDF5810", Offset = "0xDF4610", VA = "0x180DF5810")]
	public static void JFIBLLMPIKN(this ILGenerator CKPKMECMPBI, LocalBuilder EJMKPPFHCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xDF50D0", Offset = "0xDF3ED0", VA = "0x180DF50D0")]
	public static void BBGLLBPOHLB(this ILGenerator CKPKMECMPBI, int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xDF51C0", Offset = "0xDF3FC0", VA = "0x180DF51C0")]
	public static void BBGLLBPOHLB(this ILGenerator CKPKMECMPBI, LocalBuilder EJMKPPFHCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0xDF54E0", Offset = "0xDF42E0", VA = "0x180DF54E0")]
	public static void GAALHNFIHCI(this ILGenerator CKPKMECMPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0xDF54D0", Offset = "0xDF42D0", VA = "0x180DF54D0")]
	public static void FHGFGPHGDOM(this ILGenerator CKPKMECMPBI, bool FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0xDF5E80", Offset = "0xDF4C80", VA = "0x180DF5E80")]
	public static void NNJFOCCMILI(this ILGenerator CKPKMECMPBI, int FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0xDF54F0", Offset = "0xDF42F0", VA = "0x180DF54F0")]
	public static void IKLNHMBGFIA(this ILGenerator CKPKMECMPBI, Type FHJGHNDLPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xDF62D0", Offset = "0xDF50D0", VA = "0x180DF62D0")]
	public static void PPDKKLADPGP(this ILGenerator CKPKMECMPBI, Type FHJGHNDLPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0xDF5B50", Offset = "0xDF4950", VA = "0x180DF5B50")]
	public static void NBHKHEGMHKP(this ILGenerator CKPKMECMPBI, int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0xDF5360", Offset = "0xDF4160", VA = "0x180DF5360")]
	public static void DIBFHJHHNPF(this ILGenerator CKPKMECMPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xDF53E0", Offset = "0xDF41E0", VA = "0x180DF53E0")]
	public static void FFBFOKJNMEF(this ILGenerator CKPKMECMPBI, int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0xDF5D80", Offset = "0xDF4B80", VA = "0x180DF5D80")]
	public static void NCKKFOAPFDG(this ILGenerator CKPKMECMPBI, MethodInfo MAKEKHGOJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0xDF5850", Offset = "0xDF4650", VA = "0x180DF5850")]
	public static void LFOAMJDKNDK(this ILGenerator CKPKMECMPBI, FieldInfo NAPCGMHMIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0xDF52D0", Offset = "0xDF40D0", VA = "0x180DF52D0")]
	public static void CNMNGGOADFJ(this ILGenerator CKPKMECMPBI, ulong FCGCDNFBIMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class PLEODAKOBLF
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class DINPFEOMABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public DINPFEOMABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x18B69A0", Offset = "0x18B57A0", VA = "0x1818B69A0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo GPCJCJPGNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo CDGCCEPILNO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string EHPHADKLFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GCAHIDHAEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x52A460", Offset = "0x529260", VA = "0x18052A460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OLLMFLIFPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x18C3230", Offset = "0x18C2030", VA = "0x1818C3230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MLAPKFPKCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x56A5D0", Offset = "0x5693D0", VA = "0x18056A5D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x56A720", Offset = "0x569520", VA = "0x18056A720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool HNEDDHBJOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x56C3D0", Offset = "0x56B1D0", VA = "0x18056C3D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x84ED70", Offset = "0x84DB70", VA = "0x18084ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type MICLAIDLOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526290", VA = "0x180527490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x54D510", Offset = "0x54C310", VA = "0x18054D510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo FNBBAAAKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x54DCB0", Offset = "0x54CAB0", VA = "0x18054DCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo MAENCCKPPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5262A0", VA = "0x1805274A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x54EB50", Offset = "0x54D950", VA = "0x18054EB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo KDJONOONHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x526800", Offset = "0x525600", VA = "0x180526800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x526880", Offset = "0x525680", VA = "0x180526880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x18C34B0", Offset = "0x18C22B0", VA = "0x1818C34B0")]
	protected PLEODAKOBLF(Type FHJGHNDLPMM, string OPBNEOMPEGH, string CEDHCNHHCEL, bool DHICGKIGCFJ, bool OICNAJAEJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x18C3530", Offset = "0x18C2330", VA = "0x1818C3530")]
	public PLEODAKOBLF(FieldInfo NEJEEGBOFLB, string OPBNEOMPEGH, bool HIJMNMBFCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x18C3300", Offset = "0x18C2100", VA = "0x1818C3300")]
	public PLEODAKOBLF(PropertyInfo NEJEEGBOFLB, string OPBNEOMPEGH, bool HIJMNMBFCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x18C3110", Offset = "0x18C1F10", VA = "0x1818C3110")]
	private static MethodInfo FBNLLLDGCCM(MemberInfo NEJEEGBOFLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2A42580", Offset = "0x2A41380", VA = "0x182A42580")]
	public T KKPMKFDNFAL<T>(bool DAFECPNGFID) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x18C3050", Offset = "0x18C1E50", VA = "0x1818C3050", Slot = "4")]
	public virtual void DPIAOIAPOHM(ILGenerator CKPKMECMPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x18C3240", Offset = "0x18C2040", VA = "0x1818C3240", Slot = "5")]
	public virtual void MCJDMIDEFOL(ILGenerator CKPKMECMPBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class POJHHOKPEPK : PLEODAKOBLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string DIALKEPLMLF;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x18C3C10", Offset = "0x18C2A10", VA = "0x1818C3C10")]
	public POJHHOKPEPK(string OPBNEOMPEGH, string DIALKEPLMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x18C3B00", Offset = "0x18C2900", VA = "0x1818C3B00", Slot = "4")]
	public override void DPIAOIAPOHM(ILGenerator CKPKMECMPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x18C3BC0", Offset = "0x18C29C0", VA = "0x1818C3BC0", Slot = "5")]
	public override void MCJDMIDEFOL(ILGenerator CKPKMECMPBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class CCBOMPIIKGH : PLEODAKOBLF
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo LFGFHHCOIDF;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo FOEIPEMFDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal HFNKAAECMNM AINOBPKPBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal HFNKAAECMNM HNNPHABLIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal HFNKAAECMNM IMBDFABCKJM;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0xDF1BF0", Offset = "0xDF09F0", VA = "0x180DF1BF0")]
	public CCBOMPIIKGH(string OPBNEOMPEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0xDF1640", Offset = "0xDF0440", VA = "0x180DF1640", Slot = "4")]
	public override void DPIAOIAPOHM(ILGenerator CKPKMECMPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0xDF1700", Offset = "0xDF0500", VA = "0x180DF1700", Slot = "5")]
	public override void MCJDMIDEFOL(ILGenerator CKPKMECMPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0xDF1530", Offset = "0xDF0330", VA = "0x180DF1530")]
	public void ANAEBABAGAJ(ILGenerator CKPKMECMPBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class GIGHPNJGGAO
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type MICLAIDLOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FAPMOPCAAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5518F0", Offset = "0x5506F0", VA = "0x1805518F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x551AE0", Offset = "0x5508E0", VA = "0x180551AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LLCPEMJNBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6B4A30", Offset = "0x6B3830", VA = "0x1806B4A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F20", Offset = "0x6B2D20", VA = "0x1806B3F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo FFLNPFLIEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x52A540", Offset = "0x529340", VA = "0x18052A540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PLEODAKOBLF[] FPIAPGNPJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526290", VA = "0x180527490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x54D510", Offset = "0x54C310", VA = "0x18054D510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public PLEODAKOBLF[] MPPDEHHHNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x54DCB0", Offset = "0x54CAB0", VA = "0x18054DCB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xDFB2F0", Offset = "0xDFA0F0", VA = "0x180DFB2F0")]
	public GIGHPNJGGAO(Type FHJGHNDLPMM, Func<string, string> FKFIGCJACOC, bool HIJMNMBFCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xDFB220", Offset = "0xDFA020", VA = "0x180DFB220")]
	private static bool FEEGOAEEDNL(IEnumerator<ConstructorInfo> DOGLLHHANGA, ref ConstructorInfo IBKPFNADGBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct IFHFNPHOEAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong ENBHOGOBGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int BNOCGDMHEJO;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1228C50", Offset = "0x1227A50", VA = "0x181228C50")]
	public IFHFNPHOEAM(ulong BIJKKGLNOCP, int PLLMDHMNDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1228B10", Offset = "0x1227910", VA = "0x181228B10")]
	public void HNFBEHPIMIB(ref IFHFNPHOEAM MDLBKDPKIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1228A30", Offset = "0x1227830", VA = "0x181228A30")]
	public static IFHFNPHOEAM AODFAHDALFN(ref IFHFNPHOEAM DCJNBPLJICC, ref IFHFNPHOEAM JLGJJNEIJFM)
	{
		return default(IFHFNPHOEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1228B20", Offset = "0x1227920", VA = "0x181228B20")]
	public void NNOHGJHEFFL(ref IFHFNPHOEAM MDLBKDPKIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1228A60", Offset = "0x1227860", VA = "0x181228A60")]
	public static IFHFNPHOEAM FHEGPCNJPDC(ref IFHFNPHOEAM DCJNBPLJICC, ref IFHFNPHOEAM JLGJJNEIJFM)
	{
		return default(IFHFNPHOEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1228BB0", Offset = "0x12279B0", VA = "0x181228BB0")]
	public void OAKCDNPFOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1228BF0", Offset = "0x12279F0", VA = "0x181228BF0")]
	public static IFHFNPHOEAM OAKCDNPFOBP(ref IFHFNPHOEAM DCJNBPLJICC)
	{
		return default(IFHFNPHOEAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct LDGOCPGDPAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] DIHJAPMJINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int PAFBJKGCIKE;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x818150", Offset = "0x816F50", VA = "0x180818150")]
	public LDGOCPGDPAF(byte[] DIHJAPMJINO, int JOOGNDBIIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x18BAEF0", Offset = "0x18B9CF0", VA = "0x1818BAEF0")]
	public void BGKNNFJMCCN(byte LPPBOIFMJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x18BB220", Offset = "0x18BA020", VA = "0x1818BB220")]
	public void KICPFJNEFGH(byte[] LPPBOIFMJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x18BAFD0", Offset = "0x18B9DD0", VA = "0x1818BAFD0")]
	public void EEFNMNCMHEI(byte[] LPPBOIFMJJI, int FFNDHEJLEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x18BB070", Offset = "0x18B9E70", VA = "0x1818BB070")]
	public void EEFNMNCMHEI(byte[] LPPBOIFMJJI, int CKKNDHPMNJM, int FFNDHEJLEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x18BAF50", Offset = "0x18B9D50", VA = "0x1818BAF50")]
	public void DIJOLELOOOA(byte OBNNFOCEGEI, int BFNOFMOBMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x18BB120", Offset = "0x18B9F20", VA = "0x1818BB120")]
	public void EKBOKMNHHNC(string LPPBOIFMJJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class HKCBILKEFFN
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum CLKJKPOMKKH
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum BFKMOGNEIOD
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum JKHJNHHAHGH
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
	private static byte[] AICJMLAIFKI;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] BAGGEGAFPAH;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] FJDAKDKGHJE;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] IBBFDANDDFJ;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly JKHJNHHAHGH OCFBOCEKCNC;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char DLNJOMJBBEF;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int NPFGGECIDDP;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int JAKOEOPAFIM;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] PDOILGPFHLE;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x12265C0", Offset = "0x12253C0", VA = "0x1812265C0")]
	private static byte[] GIKCDOMFJKF(int NEPCFDJCABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1226190", Offset = "0x1224F90", VA = "0x181226190")]
	private static byte[] ENAJDGGMMCI(int NEPCFDJCABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1225A70", Offset = "0x1224870", VA = "0x181225A70")]
	public static int BFPPBOOMIPL(ref byte[] DIHJAPMJINO, int PAFBJKGCIKE, float FCGCDNFBIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x1225B80", Offset = "0x1224980", VA = "0x181225B80")]
	public static int BFPPBOOMIPL(ref byte[] DIHJAPMJINO, int PAFBJKGCIKE, double FCGCDNFBIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1226A30", Offset = "0x1225830", VA = "0x181226A30")]
	private static bool MCLDFEFKPJJ(byte[] DIHJAPMJINO, int FFNDHEJLEJA, ulong BAHJLNIMLPP, ulong JCNFNENHGMC, ulong KLFFIHBOALM, ulong HKDHKMNICCD, ulong OEDGKDJMNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1225C90", Offset = "0x1224A90", VA = "0x181225C90")]
	private static void BMGCDJGJEAP(uint PIEOKABFFPH, int KBHGEMBPDAM, out uint JDLLAMAMFEM, out int IOJLGGAMCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1227160", Offset = "0x1225F60", VA = "0x181227160")]
	private static bool PIHHFMGNKHI(IFHFNPHOEAM MNDALHLAPPA, IFHFNPHOEAM BGFKLDGFFJD, IFHFNPHOEAM BGLLCMPPHGN, byte[] DIHJAPMJINO, out int FFNDHEJLEJA, out int CEPIKGIBEDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x1226690", Offset = "0x1225490", VA = "0x181226690")]
	private static bool JKFEOEEGKCD(double MEIJOPLHICE, CLKJKPOMKKH IFEODBIGMNO, byte[] DIHJAPMJINO, out int FFNDHEJLEJA, out int EPAAKACIHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1225DB0", Offset = "0x1224BB0", VA = "0x181225DB0")]
	private static bool BOAHNKMEBIE(double MEIJOPLHICE, CLKJKPOMKKH IFEODBIGMNO, byte[] DIHJAPMJINO, out int FFNDHEJLEJA, out int JOJECCMFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1226270", Offset = "0x1225070", VA = "0x181226270")]
	private static bool FCCFMJEPAFN(double FCGCDNFBIMM, ref LDGOCPGDPAF HEMDOCNPPEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x1226B30", Offset = "0x1225930", VA = "0x181226B30")]
	private static bool MEIHDNDPKFG(double FCGCDNFBIMM, ref LDGOCPGDPAF HEMDOCNPPEL, BFKMOGNEIOD IFEODBIGMNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x1226400", Offset = "0x1225200", VA = "0x181226400")]
	private static void FMAPAMPHLCM(byte[] GACEEMIFGHH, int FFNDHEJLEJA, int JOJECCMFFHF, int NCDOFDEIDPE, ref LDGOCPGDPAF HEMDOCNPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x1225EA0", Offset = "0x1224CA0", VA = "0x181225EA0")]
	private static void CNDLJBDNONA(byte[] GACEEMIFGHH, int FFNDHEJLEJA, int PLLMDHMNDBJ, ref LDGOCPGDPAF HEMDOCNPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1227530", Offset = "0x1226330", VA = "0x181227530")]
	private static bool POIOJAIGDED(double MEIJOPLHICE, BFKMOGNEIOD IFEODBIGMNO, int FJFEFGOLIHK, byte[] KIDHMEHDMJH, out bool CAILLGAAEEP, out int FFNDHEJLEJA, out int EILIPCLOLPL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct PAFDDCHPODB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double BHCMOACABNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong JFMKLBHIHEF;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct NFIPJAEOFKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float ENBHOGOBGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint ILPKGILJJOM;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct CJJFADNKBPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong IJPJEBHENHF;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xDF2C30", Offset = "0xDF1A30", VA = "0x180DF2C30")]
	public CJJFADNKBPE(double BHCMOACABNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xDF2C40", Offset = "0xDF1A40", VA = "0x180DF2C40")]
	public CJJFADNKBPE(IFHFNPHOEAM BHCMOACABNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0xDF27E0", Offset = "0xDF15E0", VA = "0x180DF27E0")]
	public IFHFNPHOEAM JJMGNPGOKON()
	{
		return default(IFHFNPHOEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xDF2950", Offset = "0xDF1750", VA = "0x180DF2950")]
	public IFHFNPHOEAM MBNPJEHLKEC()
	{
		return default(IFHFNPHOEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA290", Offset = "0x5D9090", VA = "0x1805DA290")]
	public ulong AOIKHLCFNHP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xDF26B0", Offset = "0xDF14B0", VA = "0x180DF26B0")]
	public double CDGKGOEAKJJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xDF2B80", Offset = "0xDF1980", VA = "0x180DF2B80")]
	public double OIFNBJOLNIJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xDF2C00", Offset = "0xDF1A00", VA = "0x180DF2C00")]
	public int PMDLOEIKOFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xDF2670", Offset = "0xDF1470", VA = "0x180DF2670")]
	public ulong BBAGNFFCCIO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0xDF2900", Offset = "0xDF1700", VA = "0x180DF2900")]
	public bool LABJEEPEKFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0xDF27C0", Offset = "0xDF15C0", VA = "0x180DF27C0")]
	public bool JCKFDKEPMFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xDF2640", Offset = "0xDF1440", VA = "0x180DF2640")]
	public bool AGIMOALDPID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xDF2920", Offset = "0xDF1720", VA = "0x180DF2920")]
	public bool LJEMGABLNNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xDF27A0", Offset = "0xDF15A0", VA = "0x180DF27A0")]
	public int ILKEFGGLAAN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xDF29F0", Offset = "0xDF17F0", VA = "0x180DF29F0")]
	public void NKDENHNHCKO(out IFHFNPHOEAM CBKHGDODOOP, out IFHFNPHOEAM KFKDFNKFFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xDF2750", Offset = "0xDF1550", VA = "0x180DF2750")]
	public bool GLCODDBOJCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xDF2740", Offset = "0xDF1540", VA = "0x180DF2740")]
	public double FCGCDNFBIMM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xDF2720", Offset = "0xDF1520", VA = "0x180DF2720")]
	public static int CJDNJIMGGPP(int CFAKEKABHLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xDF26A0", Offset = "0xDF14A0", VA = "0x180DF26A0")]
	public static double BNEBJIIGEFA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xDF2860", Offset = "0xDF1660", VA = "0x180DF2860")]
	public static ulong KMPFMHNDFIG(IFHFNPHOEAM EFGMBLNENFN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct BGGBOBMMDIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint BEAKPCECGHB;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x523480", Offset = "0x522280", VA = "0x180523480")]
	public BGGBOBMMDIE(float ENBHOGOBGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xDF0610", Offset = "0xDEF410", VA = "0x180DF0610")]
	public IFHFNPHOEAM JJMGNPGOKON()
	{
		return default(IFHFNPHOEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2D0", Offset = "0x5D90D0", VA = "0x1805DA2D0")]
	public uint NKFJNEOKIOC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xDF0800", Offset = "0xDEF600", VA = "0x180DF0800")]
	public int PMDLOEIKOFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xDF05B0", Offset = "0xDEF3B0", VA = "0x180DF05B0")]
	public uint BBAGNFFCCIO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xDF0680", Offset = "0xDEF480", VA = "0x180DF0680")]
	public bool LABJEEPEKFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xDF0690", Offset = "0xDEF490", VA = "0x180DF0690")]
	public void NKDENHNHCKO(out IFHFNPHOEAM CBKHGDODOOP, out IFHFNPHOEAM KFKDFNKFFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xDF05D0", Offset = "0xDEF3D0", VA = "0x180DF05D0")]
	public bool GLCODDBOJCM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct EFPNCKGJCAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong BIJKKGLNOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short BNNBNGBIFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short EPAAKACIHCI;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6C10", VA = "0x180DF7E10")]
	public EFPNCKGJCAP(ulong BIJKKGLNOCP, short BNNBNGBIFBK, short EPAAKACIHCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class AOANMNKMCKH
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly EFPNCKGJCAP[] LGHLEGKEIPM;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0xDEDA10", Offset = "0xDEC810", VA = "0x180DEDA10")]
	public static void JFLIPLELELG(int IOINNELKMPG, int FEGKBIGLDEP, out IFHFNPHOEAM JDLLAMAMFEM, out int EPAAKACIHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xDEDB40", Offset = "0xDEC940", VA = "0x180DEDB40")]
	public static void LDMDPNEGDCP(int NLOICCGCHDB, out IFHFNPHOEAM JDLLAMAMFEM, out int EOONBEDLILM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct NHLOELJNODI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] LPHHCMJDKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int CKKNDHPMNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int JPCEGOKKBFE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x18BFEE0", Offset = "0x18BECE0", VA = "0x1818BFEE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xFDCCA0", Offset = "0xFDBAA0", VA = "0x180FDCCA0")]
	public NHLOELJNODI(byte[] LPHHCMJDKLK, int CKKNDHPMNJM, int FFNDHEJLEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xBCF570", Offset = "0xBCE370", VA = "0x180BCF570")]
	public int FFNDHEJLEJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x18BFE80", Offset = "0x18BEC80", VA = "0x1818BFE80")]
	public NHLOELJNODI FJHFCNGAMEA(int DPBPNBKJBBE, int HLLAMGDPDKH)
	{
		return default(NHLOELJNODI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class DPHLDDEJDAC
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] JLFBPGPFLFM;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] JCHLLAALEFJ;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int AJBABPCDKBH;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xDF6E50", Offset = "0xDF5C50", VA = "0x180DF6E50")]
	private static byte[] GGFLCFCOKDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xDF6370", Offset = "0xDF5170", VA = "0x180DF6370")]
	private static NHLOELJNODI ANEALCMEHFE(NHLOELJNODI DIHJAPMJINO)
	{
		return default(NHLOELJNODI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xDF6DA0", Offset = "0xDF5BA0", VA = "0x180DF6DA0")]
	private static NHLOELJNODI FOBMINAMAGB(NHLOELJNODI DIHJAPMJINO)
	{
		return default(NHLOELJNODI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0xDF68F0", Offset = "0xDF56F0", VA = "0x180DF68F0")]
	private static void EKHCHMCBPDJ(NHLOELJNODI DIHJAPMJINO, int PLLMDHMNDBJ, byte[] PBKGGCNBIHK, out int OIONIDALODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xDF7370", Offset = "0xDF6170", VA = "0x180DF7370")]
	private static void MNJPBKDHLOI(NHLOELJNODI DIHJAPMJINO, int PLLMDHMNDBJ, byte[] FOJMMIJKCKH, int MBMMHJLNDJE, out NHLOELJNODI BGPDKJBMIGG, out int OBINCMCBBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0xDF7060", Offset = "0xDF5E60", VA = "0x180DF7060")]
	private static ulong IKBDMAJHMDM(NHLOELJNODI DIHJAPMJINO, out int KKLJBCPPOIO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xDF70F0", Offset = "0xDF5EF0", VA = "0x180DF70F0")]
	private static void INKLBKGOPHL(NHLOELJNODI DIHJAPMJINO, out IFHFNPHOEAM CKHKIPCNPPK, out int NBPHLJLCOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xDF7620", Offset = "0xDF6420", VA = "0x180DF7620")]
	private static bool NELLFNMNKBE(NHLOELJNODI BGPDKJBMIGG, int PLLMDHMNDBJ, out double CKHKIPCNPPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xDF6C40", Offset = "0xDF5A40", VA = "0x180DF6C40")]
	private static IFHFNPHOEAM FMKAGOJMODK(int PLLMDHMNDBJ)
	{
		return default(IFHFNPHOEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0xDF6420", Offset = "0xDF5220", VA = "0x180DF6420")]
	private static bool EDAEBPIICLC(NHLOELJNODI DIHJAPMJINO, int PLLMDHMNDBJ, out double CKHKIPCNPPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0xDF6F30", Offset = "0xDF5D30", VA = "0x180DF6F30")]
	private static bool HGGEJMCELNK(NHLOELJNODI BGPDKJBMIGG, int PLLMDHMNDBJ, out double FPNKHNLFMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xDF7240", Offset = "0xDF6040", VA = "0x180DF7240")]
	public static double? LDNBPNJGJHH(NHLOELJNODI DIHJAPMJINO, int PLLMDHMNDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0xDF69B0", Offset = "0xDF57B0", VA = "0x180DF69B0")]
	public static float? FADGONECHGG(NHLOELJNODI DIHJAPMJINO, int PLLMDHMNDBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct FIBJDOLEAEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] DIHJAPMJINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int PAFBJKGCIKE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte PGEGKAIHDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xDFA0D0", Offset = "0xDF8ED0", VA = "0x180DFA0D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x818150", Offset = "0x816F50", VA = "0x180818150")]
	public FIBJDOLEAEI(byte[] DIHJAPMJINO, int PAFBJKGCIKE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xDFA170", Offset = "0xDF8F70", VA = "0x180DFA170")]
	public static FIBJDOLEAEI JIFDKMKHLAD(FIBJDOLEAEI PJJIFCLGFDI)
	{
		return default(FIBJDOLEAEI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xDFA200", Offset = "0xDF9000", VA = "0x180DFA200")]
	public static FIBJDOLEAEI MNCPHEDMPDJ(FIBJDOLEAEI PJJIFCLGFDI, int FFNDHEJLEJA)
	{
		return default(FIBJDOLEAEI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xDFA1E0", Offset = "0xDF8FE0", VA = "0x180DFA1E0")]
	public static int LCOOIINHEEC(FIBJDOLEAEI JFEJNFHABLD, FIBJDOLEAEI AMFABEOMKAP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xDFA180", Offset = "0xDF8F80", VA = "0x180DFA180")]
	public static bool JJBOJGFIHPK(FIBJDOLEAEI JFEJNFHABLD, FIBJDOLEAEI AMFABEOMKAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xDFA150", Offset = "0xDF8F50", VA = "0x180DFA150")]
	public static bool GNGJDFFHDBK(FIBJDOLEAEI JFEJNFHABLD, FIBJDOLEAEI AMFABEOMKAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0xDFA1A0", Offset = "0xDF8FA0", VA = "0x180DFA1A0")]
	public static bool JJBOJGFIHPK(FIBJDOLEAEI JFEJNFHABLD, char AMFABEOMKAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0xDFA110", Offset = "0xDF8F10", VA = "0x180DFA110")]
	public static bool GNGJDFFHDBK(FIBJDOLEAEI JFEJNFHABLD, char AMFABEOMKAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xDFA110", Offset = "0xDF8F10", VA = "0x180DFA110")]
	public static bool GNGJDFFHDBK(FIBJDOLEAEI JFEJNFHABLD, byte AMFABEOMKAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xDFA320", Offset = "0xDF9120", VA = "0x180DFA320")]
	public static bool PJLNFJCJEPF(FIBJDOLEAEI JFEJNFHABLD, char AMFABEOMKAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xDFA2A0", Offset = "0xDF90A0", VA = "0x180DFA2A0")]
	public static bool OJKKJBDHGHK(FIBJDOLEAEI JFEJNFHABLD, char AMFABEOMKAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xDFA260", Offset = "0xDF9060", VA = "0x180DFA260")]
	public static bool NDKMMOGOEPE(FIBJDOLEAEI JFEJNFHABLD, char AMFABEOMKAP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xDFA2E0", Offset = "0xDF90E0", VA = "0x180DFA2E0")]
	public static bool OMHNIHPKDHA(FIBJDOLEAEI JFEJNFHABLD, char AMFABEOMKAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class HDBOKMHFHLL
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] ADPNGMOAGMB;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] AHBMEGLBCMC;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] FJDAKDKGHJE;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] IBBFDANDDFJ;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] CIJPADAAKLN;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int MBCNNOPEAFO;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] NOENAIOPDGJ;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int DLFJGECKMID;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x121CA20", Offset = "0x121B820", VA = "0x18121CA20")]
	private static byte[] OBLCIDAPBAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x121B440", Offset = "0x121A240", VA = "0x18121B440")]
	private static byte[] BGEPAINBING()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x121B520", Offset = "0x121A320", VA = "0x18121B520")]
	public static double GEANABDMDDJ(byte[] DIHJAPMJINO, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x121B5E0", Offset = "0x121A3E0", VA = "0x18121B5E0")]
	public static float GMMHNLBEKJC(byte[] DIHJAPMJINO, int PAFBJKGCIKE, out int DELJNFGCLFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x121C8A0", Offset = "0x121B6A0", VA = "0x18121C8A0")]
	private static bool NBCHHJLNAAB(int EIPKBLJANKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x121CB00", Offset = "0x121B900", VA = "0x18121CB00")]
	private static bool ONOBOPDPLFN(ref FIBJDOLEAEI PEHMHDEBBCM, FIBJDOLEAEI BPFJIKLPIND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x121B6A0", Offset = "0x121A4A0", VA = "0x18121B6A0")]
	private static bool KBAJNIPIDLJ(ref FIBJDOLEAEI PEHMHDEBBCM, FIBJDOLEAEI BPFJIKLPIND, byte[] CDEKBJPMEFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x121C850", Offset = "0x121B650", VA = "0x18121C850")]
	private static bool NAODOGHIACK(ref FIBJDOLEAEI MJPNCGJNPIH, byte[] LPPBOIFMJJI, int PAFBJKGCIKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x742990", Offset = "0x741790", VA = "0x180742990")]
	private static double BMBBBIIEKEO(bool CAILLGAAEEP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x121B7B0", Offset = "0x121A5B0", VA = "0x18121B7B0")]
	private static double LHPAFKJENFE(FIBJDOLEAEI CPLEMOFPMIH, int FFNDHEJLEJA, bool GPMJHLDEEIA, out int AMIPEEOCKHP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class MHMOJGKIPAI<T> : global::CEOCDJDEDFJ<T[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::PJKNPKOAGND<T> FGGDJFHEONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly MBKJPDKHNJM HBDODOLMPPL;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3A82B50", Offset = "0x3A81950", VA = "0x183A82B50")]
	public MHMOJGKIPAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x28DE5A0", Offset = "0x28DD3A0", VA = "0x1828DE5A0")]
	public MHMOJGKIPAI(MBKJPDKHNJM HBDODOLMPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3A80220", Offset = "0x3A7F020", VA = "0x183A80220", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, T[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3A82630", Offset = "0x3A81430", VA = "0x183A82630", Slot = "5")]
	public T[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class LMEGLBDHFAH<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::PJKNPKOAGND<T> FGGDJFHEONN;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class MABMABMDNNC<T> : global::CEOCDJDEDFJ<List<T>>, MPKDLPIFHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly MBKJPDKHNJM HBDODOLMPPL;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3A82B50", Offset = "0x3A81950", VA = "0x183A82B50")]
	public MABMABMDNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x28DE5A0", Offset = "0x28DD3A0", VA = "0x1828DE5A0")]
	public MABMABMDNNC(MBKJPDKHNJM HBDODOLMPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB88B0", Offset = "0x3EB76B0", VA = "0x183EB88B0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, List<T> FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9960", Offset = "0x3EB8760", VA = "0x183EB9960", Slot = "5")]
	public List<T> OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class AEOJOKLOCMG<TElement, TIntermediate, TEnumerator, TCollection> : global::CEOCDJDEDFJ<TCollection>, MPKDLPIFHBA where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x39DE180", Offset = "0x39DCF80", VA = "0x1839DE180", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, TCollection FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x39DEE50", Offset = "0x39DDC50", VA = "0x1839DEE50", Slot = "5")]
	public TCollection OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator CDPHCNMLGAH(TCollection HBOGJLGKGEA);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate EPOPAOGMFCF();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void ACLEHGEDHGC(ref TIntermediate HCEMDMMECCF, int HLONBDLBPCF, TElement FCGCDNFBIMM);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ELGHEPGNNBP(ref TIntermediate AMAHCAINDBA);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
	protected AEOJOKLOCMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class BKMKLHFHLFI<TElement, TIntermediate, TCollection> : global::AEOJOKLOCMG<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3621750", Offset = "0x3620550", VA = "0x183621750", Slot = "6")]
	protected override IEnumerator<TElement> CDPHCNMLGAH(TCollection HBOGJLGKGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6280", Offset = "0x2CC5080", VA = "0x182CC6280")]
	protected BKMKLHFHLFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class MPFJMNKPGAA<TElement, TCollection> : global::BKMKLHFHLFI<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected sealed override TCollection ELGHEPGNNBP(ref TCollection AMAHCAINDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class ADEPBJHKNKE<TElement, TCollection> : global::MPFJMNKPGAA<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x39DD120", Offset = "0x39DBF20", VA = "0x1839DD120", Slot = "7")]
	protected override TCollection EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x39DD040", Offset = "0x39DBE40", VA = "0x1839DD040", Slot = "8")]
	protected override void ACLEHGEDHGC(ref TCollection HCEMDMMECCF, int HLONBDLBPCF, TElement FCGCDNFBIMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class LNEHCFGCALN<T> : global::AEOJOKLOCMG<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1600", Offset = "0x2CB0400", VA = "0x182CB1600", Slot = "8")]
	protected override void ACLEHGEDHGC(ref LinkedList<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override LinkedList<T> ELGHEPGNNBP(ref LinkedList<T> AMAHCAINDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override LinkedList<T> EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1640", Offset = "0x2CB0440", VA = "0x182CB1640", Slot = "6")]
	protected override LinkedList<T>.Enumerator CDPHCNMLGAH(LinkedList<T> HBOGJLGKGEA)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class ANDLJOGDOLN<T> : global::AEOJOKLOCMG<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1600", Offset = "0x2CB0400", VA = "0x182CB1600", Slot = "8")]
	protected override void ACLEHGEDHGC(ref Queue<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override Queue<T> EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3827EF0", Offset = "0x3826CF0", VA = "0x183827EF0", Slot = "6")]
	protected override Queue<T>.Enumerator CDPHCNMLGAH(Queue<T> HBOGJLGKGEA)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override Queue<T> ELGHEPGNNBP(ref Queue<T> AMAHCAINDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DKPDJECFPCH<T> : global::AEOJOKLOCMG<T, global::EKPILAKLMGK<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD090", Offset = "0x2FFBE90", VA = "0x182FFD090", Slot = "8")]
	protected override void ACLEHGEDHGC(ref global::EKPILAKLMGK<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD0E0", Offset = "0x2FFBEE0", VA = "0x182FFD0E0", Slot = "7")]
	protected override global::EKPILAKLMGK<T> EPOPAOGMFCF()
	{
		return default(global::EKPILAKLMGK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3827EF0", Offset = "0x3826CF0", VA = "0x183827EF0", Slot = "6")]
	protected override Stack<T>.Enumerator CDPHCNMLGAH(Stack<T> HBOGJLGKGEA)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3827F40", Offset = "0x3826D40", VA = "0x183827F40", Slot = "9")]
	protected override Stack<T> ELGHEPGNNBP(ref global::EKPILAKLMGK<T> AMAHCAINDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class EFGDJGEGDDA<T> : global::AEOJOKLOCMG<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1600", Offset = "0x2CB0400", VA = "0x182CB1600", Slot = "8")]
	protected override void ACLEHGEDHGC(ref HashSet<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override HashSet<T> ELGHEPGNNBP(ref HashSet<T> AMAHCAINDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override HashSet<T> EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3827EF0", Offset = "0x3826CF0", VA = "0x183827EF0", Slot = "6")]
	protected override HashSet<T>.Enumerator CDPHCNMLGAH(HashSet<T> HBOGJLGKGEA)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class ELNPPGGBEBP<T> : global::BKMKLHFHLFI<T, global::EKPILAKLMGK<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x38F7760", Offset = "0x38F6560", VA = "0x1838F7760", Slot = "8")]
	protected override void ACLEHGEDHGC(ref global::EKPILAKLMGK<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x38F7790", Offset = "0x38F6590", VA = "0x1838F7790", Slot = "9")]
	protected override ReadOnlyCollection<T> ELGHEPGNNBP(ref global::EKPILAKLMGK<T> AMAHCAINDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x38F7820", Offset = "0x38F6620", VA = "0x1838F7820", Slot = "7")]
	protected override global::EKPILAKLMGK<T> EPOPAOGMFCF()
	{
		return default(global::EKPILAKLMGK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class DJMIBIPMIDP<T> : global::BKMKLHFHLFI<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1600", Offset = "0x2CB0400", VA = "0x182CB1600", Slot = "8")]
	protected override void ACLEHGEDHGC(ref List<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override List<T> EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override IList<T> ELGHEPGNNBP(ref List<T> AMAHCAINDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class JIBAJALGNIF<T> : global::BKMKLHFHLFI<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1600", Offset = "0x2CB0400", VA = "0x182CB1600", Slot = "8")]
	protected override void ACLEHGEDHGC(ref List<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override List<T> EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override ICollection<T> ELGHEPGNNBP(ref List<T> AMAHCAINDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class GOKDILKBFLJ<T> : global::BKMKLHFHLFI<T, global::EKPILAKLMGK<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD090", Offset = "0x2FFBE90", VA = "0x182FFD090", Slot = "8")]
	protected override void ACLEHGEDHGC(ref global::EKPILAKLMGK<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD0E0", Offset = "0x2FFBEE0", VA = "0x182FFD0E0", Slot = "7")]
	protected override global::EKPILAKLMGK<T> EPOPAOGMFCF()
	{
		return default(global::EKPILAKLMGK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD0C0", Offset = "0x2FFBEC0", VA = "0x182FFD0C0", Slot = "9")]
	protected override IEnumerable<T> ELGHEPGNNBP(ref global::EKPILAKLMGK<T> AMAHCAINDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class JDAPJJPIFAD<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class MOOAEKHOOOD<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class HCNFMOOMIKM<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class FAMDNIKCCPL : global::CEOCDJDEDFJ<IEnumerable>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::CEOCDJDEDFJ<IEnumerable> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xDF83D0", Offset = "0xDF71D0", VA = "0x180DF83D0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, IEnumerable FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xDF85C0", Offset = "0xDF73C0", VA = "0x180DF85C0", Slot = "5")]
	public IEnumerable OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public FAMDNIKCCPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class HHDADOLJPLI : global::CEOCDJDEDFJ<ICollection>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::CEOCDJDEDFJ<ICollection> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x121CF00", Offset = "0x121BD00", VA = "0x18121CF00", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, ICollection FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x121D260", Offset = "0x121C060", VA = "0x18121D260", Slot = "5")]
	public ICollection OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public HHDADOLJPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class OKMFIMHKBPL : global::CEOCDJDEDFJ<IList>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::CEOCDJDEDFJ<IList> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x18C2520", Offset = "0x18C1320", VA = "0x1818C2520", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, IList FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x18C27C0", Offset = "0x18C15C0", VA = "0x1818C27C0", Slot = "5")]
	public IList OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public OKMFIMHKBPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class LDHDBHFACDC<T> : global::BKMKLHFHLFI<T, global::EKPILAKLMGK<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3C00060", Offset = "0x3BFEE60", VA = "0x183C00060", Slot = "8")]
	protected override void ACLEHGEDHGC(ref global::EKPILAKLMGK<T> HCEMDMMECCF, int HLONBDLBPCF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD0E0", Offset = "0x2FFBEE0", VA = "0x182FFD0E0", Slot = "7")]
	protected override global::EKPILAKLMGK<T> EPOPAOGMFCF()
	{
		return default(global::EKPILAKLMGK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3C000D0", Offset = "0x3BFEED0", VA = "0x183C000D0", Slot = "9")]
	protected override IReadOnlyList<T> ELGHEPGNNBP(ref global::EKPILAKLMGK<T> AMAHCAINDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x28E5770", Offset = "0x28E4570", VA = "0x1828E5770")]
	public LDHDBHFACDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class BIEJFMFLCEC
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xDF0C60", Offset = "0xDEFA60", VA = "0x180DF0C60")]
	public static DateTime JCAADHNKHHO(DateTime CMKHILDGONB)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class LECJEKLAPPF : global::CEOCDJDEDFJ<DateTime>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::CEOCDJDEDFJ<DateTime> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x18BB2C0", Offset = "0x18BA0C0", VA = "0x1818BB2C0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, DateTime FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x18BB710", Offset = "0x18BA510", VA = "0x1818BB710", Slot = "5")]
	public DateTime OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public LECJEKLAPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class NKCFHNPMBIO : global::CEOCDJDEDFJ<DateTimeOffset>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::CEOCDJDEDFJ<DateTimeOffset> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x18BFF20", Offset = "0x18BED20", VA = "0x1818BFF20", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, DateTimeOffset FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x18C02F0", Offset = "0x18BF0F0", VA = "0x1818C02F0", Slot = "5")]
	public DateTimeOffset OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public NKCFHNPMBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class MCIDNMOKEKA : global::CEOCDJDEDFJ<TimeSpan>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::CEOCDJDEDFJ<TimeSpan> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] EEJDABHJPEO;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x18BE060", Offset = "0x18BCE60", VA = "0x1818BE060", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, TimeSpan FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x18BE320", Offset = "0x18BD120", VA = "0x1818BE320", Slot = "5")]
	public TimeSpan OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public MCIDNMOKEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class MOIGEPDKGNI<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::CEOCDJDEDFJ<TDictionary>, MPKDLPIFHBA where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AC70", Offset = "0x2C09A70", VA = "0x182C0AC70", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, TDictionary FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E3B0", Offset = "0x2C0D1B0", VA = "0x182C0E3B0", Slot = "5")]
	public TDictionary OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator CDPHCNMLGAH(TDictionary HBOGJLGKGEA);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate EPOPAOGMFCF();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void ACLEHGEDHGC(ref TIntermediate HCEMDMMECCF, int HLONBDLBPCF, TKey IIIMPJEHMOP, TValue FCGCDNFBIMM);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ELGHEPGNNBP(ref TIntermediate AMAHCAINDBA);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
	protected MOIGEPDKGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class APFOAKJPGEG<TKey, TValue, TIntermediate, TDictionary> : global::MOIGEPDKGNI<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3621750", Offset = "0x3620550", VA = "0x183621750", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> CDPHCNMLGAH(TDictionary HBOGJLGKGEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class EMOBMIHICFM<TKey, TValue, TDictionary> : global::APFOAKJPGEG<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override TDictionary ELGHEPGNNBP(ref TDictionary AMAHCAINDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class MDCBCKHFHEE<TKey, TValue> : global::MOIGEPDKGNI<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3EBD270", Offset = "0x3EBC070", VA = "0x183EBD270", Slot = "8")]
	protected override void ACLEHGEDHGC(ref Dictionary<TKey, TValue> HCEMDMMECCF, int HLONBDLBPCF, TKey IIIMPJEHMOP, TValue FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override Dictionary<TKey, TValue> ELGHEPGNNBP(ref Dictionary<TKey, TValue> AMAHCAINDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override Dictionary<TKey, TValue> EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3EBD2B0", Offset = "0x3EBC0B0", VA = "0x183EBD2B0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator CDPHCNMLGAH(Dictionary<TKey, TValue> HBOGJLGKGEA)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x28EA140", Offset = "0x28E8F40", VA = "0x1828EA140")]
	public MDCBCKHFHEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LKKKNNGCHKE<TKey, TValue, TDictionary> : global::EMOBMIHICFM<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2CB0970", Offset = "0x2CAF770", VA = "0x182CB0970", Slot = "8")]
	protected override void ACLEHGEDHGC(ref TDictionary HCEMDMMECCF, int HLONBDLBPCF, TKey IIIMPJEHMOP, TValue FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2CB09E0", Offset = "0x2CAF7E0", VA = "0x182CB09E0", Slot = "7")]
	protected override TDictionary EPOPAOGMFCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class KLEGOMFONBF<TKey, TValue> : global::APFOAKJPGEG<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2CB10D0", Offset = "0x2CAFED0", VA = "0x182CB10D0", Slot = "8")]
	protected override void ACLEHGEDHGC(ref Dictionary<TKey, TValue> HCEMDMMECCF, int HLONBDLBPCF, TKey IIIMPJEHMOP, TValue FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override Dictionary<TKey, TValue> EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override IDictionary<TKey, TValue> ELGHEPGNNBP(ref Dictionary<TKey, TValue> AMAHCAINDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class OAMNPFBALLP<TKey, TValue> : global::EMOBMIHICFM<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2CB10D0", Offset = "0x2CAFED0", VA = "0x182CB10D0", Slot = "8")]
	protected override void ACLEHGEDHGC(ref SortedList<TKey, TValue> HCEMDMMECCF, int HLONBDLBPCF, TKey IIIMPJEHMOP, TValue FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override SortedList<TKey, TValue> EPOPAOGMFCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class LMAHBCCHEAB<TKey, TValue> : global::MOIGEPDKGNI<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2CB10D0", Offset = "0x2CAFED0", VA = "0x182CB10D0", Slot = "8")]
	protected override void ACLEHGEDHGC(ref SortedDictionary<TKey, TValue> HCEMDMMECCF, int HLONBDLBPCF, TKey IIIMPJEHMOP, TValue FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8402E0", Offset = "0x83F0E0", VA = "0x1808402E0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ELGHEPGNNBP(ref SortedDictionary<TKey, TValue> AMAHCAINDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CAFF70", VA = "0x182CB1170", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> EPOPAOGMFCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1110", Offset = "0x2CAFF10", VA = "0x182CB1110", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator CDPHCNMLGAH(SortedDictionary<TKey, TValue> HBOGJLGKGEA)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class BBPPIJPNPPB<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class IELIHHFPAGD : global::CEOCDJDEDFJ<IDictionary>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::CEOCDJDEDFJ<IDictionary> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x1228000", Offset = "0x1226E00", VA = "0x181228000", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, IDictionary FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x1228490", Offset = "0x1227290", VA = "0x181228490", Slot = "5")]
	public IDictionary OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public IELIHHFPAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class LCGGLCFDIOC : global::CEOCDJDEDFJ<object>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void DGOLFHEEKAN(object LGBPHOKKDBM, ref HCOBOFANPFL DEBPKKBLHIL, object FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::HECLDNFBCOE<KeyValuePair<object, DGOLFHEEKAN>> KPFBLMDOHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly FNCBDBAKIPE[] BPLKLJCCBAA;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x18BAE50", Offset = "0x18B9C50", VA = "0x1818BAE50")]
	public LCGGLCFDIOC(params FNCBDBAKIPE[] BPLKLJCCBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x18BA5F0", Offset = "0x18B93F0", VA = "0x1818BA5F0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, object FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x18BADC0", Offset = "0x18B9BC0", VA = "0x1818BADC0", Slot = "5")]
	public object OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class FFMFOMLOOCM
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xDF87A0", Offset = "0xDF75A0", VA = "0x180DF87A0")]
	public static object FADNCKGIFCL(Type FHJGHNDLPMM, out bool LNANLGKMLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xDF8F80", Offset = "0xDF7D80", VA = "0x180DF8F80")]
	public static object GAOAHNOKAKF(Type FHJGHNDLPMM, out bool LNANLGKMLIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class ECJKNOJBPPP<T> : global::CEOCDJDEDFJ<T>, MPKDLPIFHBA, global::OIGDIDGEAPJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class ANAMNBFFOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public ANAMNBFFOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x393FF70", Offset = "0x393ED70", VA = "0x18393FF70")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class IEHANCHPBPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::JGDFFAEJJEI<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public IEHANCHPBPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3959990", Offset = "0x3958790", VA = "0x183959990")]
		internal void <.cctor>b__1(ref HCOBOFANPFL writer, T value, FNCBDBAKIPE _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class AIAOCBHGAIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::PIMCHFHKPFJ<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public AIAOCBHGAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x393E480", Offset = "0x393D280", VA = "0x18393E480")]
		internal T <.cctor>b__2(ref JHAJJMFJACM reader, FNCBDBAKIPE _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::LABBPEDDFPM<T> MILDAAOABOA;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> LPEBOPIBPMJ;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::JGDFFAEJJEI<T> PINHOFMAHJD;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::PIMCHFHKPFJ<T> AFHHJHINCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool LDAELNIHADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::JGDFFAEJJEI<T> FDAIEAIKDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::PIMCHFHKPFJ<T> APJDHDNCJCO;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3952840", Offset = "0x3951640", VA = "0x183952840")]
	static ECJKNOJBPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3957F00", Offset = "0x3956D00", VA = "0x183957F00")]
	public ECJKNOJBPPP(bool LDAELNIHADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3945420", Offset = "0x3944220", VA = "0x183945420", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, T FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x39490A0", Offset = "0x3947EA0", VA = "0x1839490A0", Slot = "5")]
	public T OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x39463F0", Offset = "0x39451F0", VA = "0x1839463F0", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, T FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3946A90", Offset = "0x3945890", VA = "0x183946A90", Slot = "7")]
	public T ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class ECNGCBJENED<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class HNMBJCMPNDE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class FOEMFHBKEAM<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class BNEHENOCDAD<T> : global::CEOCDJDEDFJ<T?>, MPKDLPIFHBA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3622500", Offset = "0x3621300", VA = "0x183622500", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, T? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3622660", Offset = "0x3621460", VA = "0x183622660", Slot = "5")]
	public T? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
	public BNEHENOCDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class EKBOHOHEION<T> : global::CEOCDJDEDFJ<T?>, MPKDLPIFHBA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::CEOCDJDEDFJ<T> FDJNHCKMLCO;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2FEEC30", Offset = "0x2FEDA30", VA = "0x182FEEC30")]
	public EKBOHOHEION(global::CEOCDJDEDFJ<T> FDJNHCKMLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x38F59E0", Offset = "0x38F47E0", VA = "0x1838F59E0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, T? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x38F6C80", Offset = "0x38F5A80", VA = "0x1838F6C80", Slot = "5")]
	public T? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class IFAHNNOJJGH : global::CEOCDJDEDFJ<sbyte>, MPKDLPIFHBA, global::OIGDIDGEAPJ<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly IFAHNNOJJGH MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x1228810", Offset = "0x1227610", VA = "0x181228810", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, sbyte FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x1228980", Offset = "0x1227780", VA = "0x181228980", Slot = "5")]
	public sbyte OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1228850", Offset = "0x1227650", VA = "0x181228850", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, sbyte FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1228910", Offset = "0x1227710", VA = "0x181228910", Slot = "7")]
	public sbyte ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public IFAHNNOJJGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class FPBGFOBAOJF : global::CEOCDJDEDFJ<sbyte?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly FPBGFOBAOJF MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0xDFA6F0", Offset = "0xDF94F0", VA = "0x180DFA6F0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, sbyte? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xDFA890", Offset = "0xDF9690", VA = "0x180DFA890", Slot = "5")]
	public sbyte? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xDFA760", Offset = "0xDF9560", VA = "0x180DFA760", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, sbyte? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xDFA7E0", Offset = "0xDF95E0", VA = "0x180DFA7E0", Slot = "7")]
	public sbyte? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public FPBGFOBAOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class PKNNNLGOLFJ : global::CEOCDJDEDFJ<sbyte[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly PKNNNLGOLFJ MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x18C2DF0", Offset = "0x18C1BF0", VA = "0x1818C2DF0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, sbyte[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x18C2EB0", Offset = "0x18C1CB0", VA = "0x1818C2EB0", Slot = "5")]
	public sbyte[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public PKNNNLGOLFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class KAIABMKPGCP : global::CEOCDJDEDFJ<short>, MPKDLPIFHBA, global::OIGDIDGEAPJ<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly KAIABMKPGCP MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x122E240", Offset = "0x122D040", VA = "0x18122E240", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, short FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x122E3B0", Offset = "0x122D1B0", VA = "0x18122E3B0", Slot = "5")]
	public short OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x122E280", Offset = "0x122D080", VA = "0x18122E280", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, short FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x122E340", Offset = "0x122D140", VA = "0x18122E340", Slot = "7")]
	public short ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public KAIABMKPGCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class CBPJHDPKEPE : global::CEOCDJDEDFJ<short?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly CBPJHDPKEPE MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0xDF12D0", Offset = "0xDF00D0", VA = "0x180DF12D0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, short? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0xDF1460", Offset = "0xDF0260", VA = "0x180DF1460", Slot = "5")]
	public short? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xDF1340", Offset = "0xDF0140", VA = "0x180DF1340", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, short? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xDF13C0", Offset = "0xDF01C0", VA = "0x180DF13C0", Slot = "7")]
	public short? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public CBPJHDPKEPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class FICEDINHCMF : global::CEOCDJDEDFJ<short[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly FICEDINHCMF MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0xDFA360", Offset = "0xDF9160", VA = "0x180DFA360", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, short[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xDFA420", Offset = "0xDF9220", VA = "0x180DFA420", Slot = "5")]
	public short[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public FICEDINHCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class KOJMALLJHHI : global::CEOCDJDEDFJ<int>, MPKDLPIFHBA, global::OIGDIDGEAPJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly KOJMALLJHHI MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x18B8860", Offset = "0x18B7660", VA = "0x1818B8860", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, int FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x18B8950", Offset = "0x18B7750", VA = "0x1818B8950", Slot = "5")]
	public int OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x18B8870", Offset = "0x18B7670", VA = "0x1818B8870", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, int FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x18B88B0", Offset = "0x18B76B0", VA = "0x1818B88B0", Slot = "7")]
	public int ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public KOJMALLJHHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JMGNMIKHNEE : global::CEOCDJDEDFJ<int?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly JMGNMIKHNEE MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x122DA70", Offset = "0x122C870", VA = "0x18122DA70", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, int? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x122DC90", Offset = "0x122CA90", VA = "0x18122DC90", Slot = "5")]
	public int? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x122DAF0", Offset = "0x122C8F0", VA = "0x18122DAF0", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, int? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x122DBF0", Offset = "0x122C9F0", VA = "0x18122DBF0", Slot = "7")]
	public int? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public JMGNMIKHNEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class GKMCNBPGLMO : global::CEOCDJDEDFJ<int[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly GKMCNBPGLMO MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1219450", Offset = "0x1218250", VA = "0x181219450", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, int[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x12195F0", Offset = "0x12183F0", VA = "0x1812195F0", Slot = "5")]
	public int[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public GKMCNBPGLMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class CMLKPJHNHMF : global::CEOCDJDEDFJ<long>, MPKDLPIFHBA, global::OIGDIDGEAPJ<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly CMLKPJHNHMF MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xDF2E20", Offset = "0xDF1C20", VA = "0x180DF2E20", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, long FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xDF2EF0", Offset = "0xDF1CF0", VA = "0x180DF2EF0", Slot = "5")]
	public long OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0xDF2E40", Offset = "0xDF1C40", VA = "0x180DF2E40", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, long FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xDF2E80", Offset = "0xDF1C80", VA = "0x180DF2E80", Slot = "7")]
	public long ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public CMLKPJHNHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class JOAAHCNOLCH : global::CEOCDJDEDFJ<long?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly JOAAHCNOLCH MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x122DDA0", Offset = "0x122CBA0", VA = "0x18122DDA0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, long? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x122DFE0", Offset = "0x122CDE0", VA = "0x18122DFE0", Slot = "5")]
	public long? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x122DE20", Offset = "0x122CC20", VA = "0x18122DE20", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, long? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x122DF20", Offset = "0x122CD20", VA = "0x18122DF20", Slot = "7")]
	public long? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public JOAAHCNOLCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class OANKGLFNOLK : global::CEOCDJDEDFJ<long[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly OANKGLFNOLK MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x18C1230", Offset = "0x18C0030", VA = "0x1818C1230", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, long[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x18C12F0", Offset = "0x18C00F0", VA = "0x1818C12F0", Slot = "5")]
	public long[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public OANKGLFNOLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class EGHDPFFPFCO : global::CEOCDJDEDFJ<byte>, MPKDLPIFHBA, global::OIGDIDGEAPJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly EGHDPFFPFCO MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xDF7E20", Offset = "0xDF6C20", VA = "0x180DF7E20", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, byte FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0xDF7EF0", Offset = "0xDF6CF0", VA = "0x180DF7EF0", Slot = "5")]
	public byte OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xDF7E40", Offset = "0xDF6C40", VA = "0x180DF7E40", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, byte FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xDF7E80", Offset = "0xDF6C80", VA = "0x180DF7E80", Slot = "7")]
	public byte ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public EGHDPFFPFCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class HJMHNAOCJHN : global::CEOCDJDEDFJ<byte?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly HJMHNAOCJHN MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1225730", Offset = "0x1224530", VA = "0x181225730", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, byte? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x1225960", Offset = "0x1224760", VA = "0x181225960", Slot = "5")]
	public byte? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x12257B0", Offset = "0x12245B0", VA = "0x1812257B0", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, byte? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x12258B0", Offset = "0x12246B0", VA = "0x1812258B0", Slot = "7")]
	public byte? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public HJMHNAOCJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class LJAHBFLIMMI : global::CEOCDJDEDFJ<ushort>, MPKDLPIFHBA, global::OIGDIDGEAPJ<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly LJAHBFLIMMI MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x18BC810", Offset = "0x18BB610", VA = "0x1818BC810", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, ushort FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x18BC910", Offset = "0x18BB710", VA = "0x1818BC910", Slot = "5")]
	public ushort OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x18BC830", Offset = "0x18BB630", VA = "0x1818BC830", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, ushort FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x18BC870", Offset = "0x18BB670", VA = "0x1818BC870", Slot = "7")]
	public ushort ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public LJAHBFLIMMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class HCBNFIOFJGC : global::CEOCDJDEDFJ<ushort?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly HCBNFIOFJGC MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1219C80", Offset = "0x1218A80", VA = "0x181219C80", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, ushort? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1219EA0", Offset = "0x1218CA0", VA = "0x181219EA0", Slot = "5")]
	public ushort? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1219D00", Offset = "0x1218B00", VA = "0x181219D00", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, ushort? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1219E00", Offset = "0x1218C00", VA = "0x181219E00", Slot = "7")]
	public ushort? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public HCBNFIOFJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class KIMBCLGODLK : global::CEOCDJDEDFJ<ushort[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly KIMBCLGODLK MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x122E470", Offset = "0x122D270", VA = "0x18122E470", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, ushort[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x122E610", Offset = "0x122D410", VA = "0x18122E610", Slot = "5")]
	public ushort[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public KIMBCLGODLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class AFOCMECIOPE : global::CEOCDJDEDFJ<uint>, MPKDLPIFHBA, global::OIGDIDGEAPJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly AFOCMECIOPE MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xDEB160", Offset = "0xDE9F60", VA = "0x180DEB160", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, uint FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xDEB220", Offset = "0xDEA020", VA = "0x180DEB220", Slot = "5")]
	public uint OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0xDEB170", Offset = "0xDE9F70", VA = "0x180DEB170", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, uint FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0xDEB1B0", Offset = "0xDE9FB0", VA = "0x180DEB1B0", Slot = "7")]
	public uint ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public AFOCMECIOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class OCDOHKCIJKM : global::CEOCDJDEDFJ<uint?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly OCDOHKCIJKM MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x18C15D0", Offset = "0x18C03D0", VA = "0x1818C15D0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, uint? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x18C17A0", Offset = "0x18C05A0", VA = "0x1818C17A0", Slot = "5")]
	public uint? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x18C1640", Offset = "0x18C0440", VA = "0x1818C1640", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, uint? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x18C16C0", Offset = "0x18C04C0", VA = "0x1818C16C0", Slot = "7")]
	public uint? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public OCDOHKCIJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class MOHLJEIEDCM : global::CEOCDJDEDFJ<uint[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly MOHLJEIEDCM MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x18BF550", Offset = "0x18BE350", VA = "0x1818BF550", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, uint[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x18BF610", Offset = "0x18BE410", VA = "0x1818BF610", Slot = "5")]
	public uint[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public MOHLJEIEDCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PPMIEDCHFKI : global::CEOCDJDEDFJ<ulong>, MPKDLPIFHBA, global::OIGDIDGEAPJ<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly PPMIEDCHFKI MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x18C3D90", Offset = "0x18C2B90", VA = "0x1818C3D90", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, ulong FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x18C3E60", Offset = "0x18C2C60", VA = "0x1818C3E60", Slot = "5")]
	public ulong OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x18C3DB0", Offset = "0x18C2BB0", VA = "0x1818C3DB0", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, ulong FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x18C3DF0", Offset = "0x18C2BF0", VA = "0x1818C3DF0", Slot = "7")]
	public ulong ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public PPMIEDCHFKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class KOGNBDBBNNF : global::CEOCDJDEDFJ<ulong?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly KOGNBDBBNNF MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x18B85C0", Offset = "0x18B73C0", VA = "0x1818B85C0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, ulong? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x18B8770", Offset = "0x18B7570", VA = "0x1818B8770", Slot = "5")]
	public ulong? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x18B8630", Offset = "0x18B7430", VA = "0x1818B8630", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, ulong? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x18B86B0", Offset = "0x18B74B0", VA = "0x1818B86B0", Slot = "7")]
	public ulong? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public KOGNBDBBNNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MPNEPJGBAMH : global::CEOCDJDEDFJ<ulong[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly MPNEPJGBAMH MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x18BF940", Offset = "0x18BE740", VA = "0x1818BF940", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, ulong[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x18BFA00", Offset = "0x18BE800", VA = "0x1818BFA00", Slot = "5")]
	public ulong[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public MPNEPJGBAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class BKAAGFEHLKB : global::CEOCDJDEDFJ<float>, MPKDLPIFHBA, global::OIGDIDGEAPJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly BKAAGFEHLKB MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xDF0E80", Offset = "0xDEFC80", VA = "0x180DF0E80", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, float FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xDF0F40", Offset = "0xDEFD40", VA = "0x180DF0F40", Slot = "5")]
	public float OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xDF0E90", Offset = "0xDEFC90", VA = "0x180DF0E90", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, float FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xDF0ED0", Offset = "0xDEFCD0", VA = "0x180DF0ED0", Slot = "7")]
	public float ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public BKAAGFEHLKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class OILCJGPAPDD : global::CEOCDJDEDFJ<float?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly OILCJGPAPDD MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x18C2280", Offset = "0x18C1080", VA = "0x1818C2280", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, float? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x18C2450", Offset = "0x18C1250", VA = "0x1818C2450", Slot = "5")]
	public float? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x18C22F0", Offset = "0x18C10F0", VA = "0x1818C22F0", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, float? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x18C2370", Offset = "0x18C1170", VA = "0x1818C2370", Slot = "7")]
	public float? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public OILCJGPAPDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class OOCOLKFCFDK : global::CEOCDJDEDFJ<float[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly OOCOLKFCFDK MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x18C29A0", Offset = "0x18C17A0", VA = "0x1818C29A0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, float[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x18C2A60", Offset = "0x18C1860", VA = "0x1818C2A60", Slot = "5")]
	public float[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public OOCOLKFCFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class FKKIDGGIJKI : global::CEOCDJDEDFJ<double>, MPKDLPIFHBA, global::OIGDIDGEAPJ<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly FKKIDGGIJKI MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xDFA5C0", Offset = "0xDF93C0", VA = "0x180DFA5C0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, double FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xDFA680", Offset = "0xDF9480", VA = "0x180DFA680", Slot = "5")]
	public double OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0xDFA5D0", Offset = "0xDF93D0", VA = "0x180DFA5D0", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, double FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0xDFA610", Offset = "0xDF9410", VA = "0x180DFA610", Slot = "7")]
	public double ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public FKKIDGGIJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class BBHDLCEIGJK : global::CEOCDJDEDFJ<double?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly BBHDLCEIGJK MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xDEFE10", Offset = "0xDEEC10", VA = "0x180DEFE10", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, double? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xDEFFC0", Offset = "0xDEEDC0", VA = "0x180DEFFC0", Slot = "5")]
	public double? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xDEFE80", Offset = "0xDEEC80", VA = "0x180DEFE80", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, double? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xDEFF00", Offset = "0xDEED00", VA = "0x180DEFF00", Slot = "7")]
	public double? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public BBHDLCEIGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class GNCJNHFCILE : global::CEOCDJDEDFJ<double[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly GNCJNHFCILE MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x12197F0", Offset = "0x12185F0", VA = "0x1812197F0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, double[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1219970", Offset = "0x1218770", VA = "0x181219970", Slot = "5")]
	public double[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public GNCJNHFCILE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class IJBIAGODHBJ : global::CEOCDJDEDFJ<bool>, MPKDLPIFHBA, global::OIGDIDGEAPJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly IJBIAGODHBJ MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1228D50", Offset = "0x1227B50", VA = "0x181228D50", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, bool FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1228E90", Offset = "0x1227C90", VA = "0x181228E90", Slot = "5")]
	public bool OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1228D70", Offset = "0x1227B70", VA = "0x181228D70", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, bool FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1228E20", Offset = "0x1227C20", VA = "0x181228E20", Slot = "7")]
	public bool ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public IJBIAGODHBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class KNOBOJCCPBJ : global::CEOCDJDEDFJ<bool?>, MPKDLPIFHBA, global::OIGDIDGEAPJ<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly KNOBOJCCPBJ MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x18B7C90", Offset = "0x18B6A90", VA = "0x1818B7C90", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, bool? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x18B7E30", Offset = "0x18B6C30", VA = "0x1818B7E30", Slot = "5")]
	public bool? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x18B7D00", Offset = "0x18B6B00", VA = "0x1818B7D00", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, bool? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x18B7D80", Offset = "0x18B6B80", VA = "0x1818B7D80", Slot = "7")]
	public bool? ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public KNOBOJCCPBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class EDPFHCHHPOP : global::CEOCDJDEDFJ<bool[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly EDPFHCHHPOP MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xDF7BA0", Offset = "0xDF69A0", VA = "0x180DF7BA0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, bool[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xDF7C70", Offset = "0xDF6A70", VA = "0x180DF7C70", Slot = "5")]
	public bool[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public EDPFHCHHPOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class JAFGBJAPLHJ : global::CEOCDJDEDFJ<object>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::CEOCDJDEDFJ<object> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> EACOCAKDNDN;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1229990", Offset = "0x1228790", VA = "0x181229990", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, object FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x122A340", Offset = "0x1229140", VA = "0x18122A340", Slot = "5")]
	public object OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public JAFGBJAPLHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class CGJCJFNACOB : global::CEOCDJDEDFJ<byte[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::CEOCDJDEDFJ<byte[]> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xDF1C90", Offset = "0xDF0A90", VA = "0x180DF1C90", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, byte[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0xDF1D20", Offset = "0xDF0B20", VA = "0x180DF1D20", Slot = "5")]
	public byte[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public CGJCJFNACOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class EPNFKGIHGFJ : global::CEOCDJDEDFJ<ArraySegment<byte>>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::CEOCDJDEDFJ<ArraySegment<byte>> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xDF8200", Offset = "0xDF7000", VA = "0x180DF8200", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, ArraySegment<byte> FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0xDF82A0", Offset = "0xDF70A0", VA = "0x180DF82A0", Slot = "5")]
	public ArraySegment<byte> OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public EPNFKGIHGFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class AEHGAJFHMIO : global::CEOCDJDEDFJ<string>, MPKDLPIFHBA, global::OIGDIDGEAPJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::CEOCDJDEDFJ<string> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xDE96F0", Offset = "0xDE84F0", VA = "0x180DE96F0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, string FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xDE9710", Offset = "0xDE8510", VA = "0x180DE9710", Slot = "5")]
	public string OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0xDE96F0", Offset = "0xDE84F0", VA = "0x180DE96F0", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, string FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xDE9710", Offset = "0xDE8510", VA = "0x180DE9710", Slot = "7")]
	public string ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public AEHGAJFHMIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class LIMGHKGAEGJ : global::CEOCDJDEDFJ<string[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly LIMGHKGAEGJ MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x18BC5B0", Offset = "0x18BB3B0", VA = "0x1818BC5B0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, string[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x18BC670", Offset = "0x18BB470", VA = "0x1818BC670", Slot = "5")]
	public string[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public LIMGHKGAEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class DMIINKBINFB : global::CEOCDJDEDFJ<char>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly DMIINKBINFB MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xDF3340", Offset = "0xDF2140", VA = "0x180DF3340", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, char FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xDF33C0", Offset = "0xDF21C0", VA = "0x180DF33C0", Slot = "5")]
	public char OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public DMIINKBINFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class PIABKJEJMAO : global::CEOCDJDEDFJ<char?>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly PIABKJEJMAO MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x18C2C00", Offset = "0x18C1A00", VA = "0x1818C2C00", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, char? FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x18C2CD0", Offset = "0x18C1AD0", VA = "0x1818C2CD0", Slot = "5")]
	public char? OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public PIABKJEJMAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class PLIJBDNCIIN : global::CEOCDJDEDFJ<char[]>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly PLIJBDNCIIN MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x18C3640", Offset = "0x18C2440", VA = "0x1818C3640", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, char[] FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x18C37C0", Offset = "0x18C25C0", VA = "0x1818C37C0", Slot = "5")]
	public char[] OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public PLIJBDNCIIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class HIPMCNCEGPL : global::CEOCDJDEDFJ<Guid>, MPKDLPIFHBA, global::OIGDIDGEAPJ<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::CEOCDJDEDFJ<Guid> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x121D690", Offset = "0x121C490", VA = "0x18121D690", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Guid FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x121D880", Offset = "0x121C680", VA = "0x18121D880", Slot = "5")]
	public Guid OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x121D850", Offset = "0x121C650", VA = "0x18121D850", Slot = "6")]
	public void MKHCGGEADPI(ref HCOBOFANPFL DEBPKKBLHIL, Guid FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x121D880", Offset = "0x121C680", VA = "0x18121D880", Slot = "7")]
	public Guid ODDOCELIFNO(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public HIPMCNCEGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class CHFNACDLDDO : global::CEOCDJDEDFJ<decimal>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::CEOCDJDEDFJ<decimal> MHNALHBMJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool DOAELBIANHJ;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6638A0", Offset = "0x6626A0", VA = "0x1806638A0")]
	public CHFNACDLDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x663870", Offset = "0x662670", VA = "0x180663870")]
	public CHFNACDLDDO(bool DOAELBIANHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xDF1E60", Offset = "0xDF0C60", VA = "0x180DF1E60", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, decimal FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0xDF1FA0", Offset = "0xDF0DA0", VA = "0x180DF1FA0", Slot = "5")]
	public decimal OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class MPMFELOGNEI : global::CEOCDJDEDFJ<Uri>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::CEOCDJDEDFJ<Uri> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x18BF7B0", Offset = "0x18BE5B0", VA = "0x1818BF7B0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Uri FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x18BF860", Offset = "0x18BE660", VA = "0x1818BF860", Slot = "5")]
	public Uri OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public MPMFELOGNEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class MHEAJEBHIIJ : global::CEOCDJDEDFJ<Version>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::CEOCDJDEDFJ<Version> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x18BEEA0", Offset = "0x18BDCA0", VA = "0x1818BEEA0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Version FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x18BEF50", Offset = "0x18BDD50", VA = "0x1818BEF50", Slot = "5")]
	public Version OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public MHEAJEBHIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class AKLGONKMPLN<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class FHBJMOJNGMI : global::CEOCDJDEDFJ<StringBuilder>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::CEOCDJDEDFJ<StringBuilder> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0xDF9FA0", Offset = "0xDF8DA0", VA = "0x180DF9FA0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, StringBuilder FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xDF9FF0", Offset = "0xDF8DF0", VA = "0x180DF9FF0", Slot = "5")]
	public StringBuilder OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public FHBJMOJNGMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class ACFKMDOICGM : global::CEOCDJDEDFJ<BitArray>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::CEOCDJDEDFJ<BitArray> MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0xDE91F0", Offset = "0xDE7FF0", VA = "0x180DE91F0", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, BitArray FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xDE9280", Offset = "0xDE8080", VA = "0x180DE9280", Slot = "5")]
	public BitArray OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public ACFKMDOICGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class AKEBILDKIFF : global::CEOCDJDEDFJ<Type>, MPKDLPIFHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly AKEBILDKIFF MHNALHBMJHB;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex LMPDHOFBJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool JMCHBAHPJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool GMKONJNHGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool PNAAEFBCDLG;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0xDED160", Offset = "0xDEBF60", VA = "0x180DED160")]
	public AKEBILDKIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0xDED110", Offset = "0xDEBF10", VA = "0x180DED110")]
	public AKEBILDKIFF(bool JMCHBAHPJII, bool GMKONJNHGCE, bool PNAAEFBCDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xDECE60", Offset = "0xDEBC60", VA = "0x180DECE60", Slot = "4")]
	public void DAIPABBOHEP(ref HCOBOFANPFL DEBPKKBLHIL, Type FCGCDNFBIMM, FNCBDBAKIPE GKLFNGEPBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0xDECF50", Offset = "0xDEBD50", VA = "0x180DECF50", Slot = "5")]
	public Type OHNHPKBKAFE(ref JHAJJMFJACM FLKIDPNEFDE, FNCBDBAKIPE GKLFNGEPBBL)
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
