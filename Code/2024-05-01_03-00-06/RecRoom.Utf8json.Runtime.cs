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
internal static class LFHNGCPLHCL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E980", Offset = "0x6B3D780", VA = "0x186B3E980")]
	public static bool INPKCPMGDGP(this TypeInfo DDEINLAGLLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class HGNFHCNOAFC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type HCOCHJBMEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] BEOEAENJKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
	public HGNFHCNOAFC(Type JMPFAMNCFEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class CECOEHOGEDF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FLCCHIECBOA<T>(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T APOIHKLIHJK<T>(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC HHCIAIAKKNK);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DMCDFIKKPEH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GADLOFCICAN<T> : DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ALDOCCHDDIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GJOCIAENDBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CNDJMCKFBMP
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2719120", Offset = "0x2717F20", VA = "0x182719120")]
	public static string ALAJNAFGDBG<T>(this GADLOFCICAN<T> IBBCDCOGNIO, T DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GADLOFCICAN<T> DMAAHLAMJCF<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JKNELCCHKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2931AF0", Offset = "0x29308F0", VA = "0x182931AF0")]
	public static GADLOFCICAN<T> KBPDPPJEPOK<T>(this BHPKKFEEGEC HHCIAIAKKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CEE0", Offset = "0x6B3BCE0", VA = "0x186B3CEE0")]
	public static object KMCALIICGCP(this BHPKKFEEGEC HHCIAIAKKNK, Type DDEINLAGLLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PDGCMNENFHF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F9A0", Offset = "0x6B3E7A0", VA = "0x186B3F9A0")]
	public PDGCMNENFHF(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FHJFMOGBEPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class EEGDCBMOPDN
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] GGBNILIIFNK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] KABLEAFJNNL;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B34C50", Offset = "0x6B33A50", VA = "0x186B34C50")]
		public static byte[] KCJMIOPEJKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B34CF0", Offset = "0x6B33AF0", VA = "0x186B34CF0")]
		public static char[] KODIJMCPEML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> LMIBOPJHOLD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] GCDHLKEOIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] KKAMOMBNLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int PJPGJICIKPG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FEGJJPCFABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B36BC0", Offset = "0x6B359C0", VA = "0x186B36BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B38240", Offset = "0x6B37040", VA = "0x186B38240")]
	public FHJFMOGBEPJ(byte[] KKAMOMBNLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B382A0", Offset = "0x6B370A0", VA = "0x186B382A0")]
	public FHJFMOGBEPJ(byte[] KKAMOMBNLOJ, int PJPGJICIKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B35B70", Offset = "0x6B34970", VA = "0x186B35B70")]
	private DJEMAGLLICA CCOJJMJFKFA(string CAMFMONNIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B35A80", Offset = "0x6B34880", VA = "0x186B35A80")]
	private DJEMAGLLICA BLMLPKLIFEE(string HPJAAILCALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B31850", Offset = "0x6B30650", VA = "0x186B31850")]
	public void JCMGNCHBNIB(int PJPGJICIKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
	public byte[] KKFEIFGKPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F0B0", Offset = "0x1E4DEB0", VA = "0x181E4F0B0")]
	public int NAPNOLCNGMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B36E80", Offset = "0x6B35C80", VA = "0x186B36E80")]
	public CLNDOOPDFLJ HNGEFKDNJBE()
	{
		return default(CLNDOOPDFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B37610", Offset = "0x6B36410", VA = "0x186B37610")]
	public void KILBBONMCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B36930", Offset = "0x6B35730", VA = "0x186B36930")]
	public bool GANPBEHPHAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B37490", Offset = "0x6B36290", VA = "0x186B37490")]
	public bool INAOMADACNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B378A0", Offset = "0x6B366A0", VA = "0x186B378A0")]
	public void LJEGKAMGNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B350B0", Offset = "0x6B33EB0", VA = "0x186B350B0")]
	public bool AMCLOOPKMOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B37740", Offset = "0x6B36540", VA = "0x186B37740")]
	public bool LCBHEEBKKMO(int NJKDAMEBDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B371F0", Offset = "0x6B35FF0", VA = "0x186B371F0")]
	public bool IKANCNNBLID(int NJKDAMEBDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B368A0", Offset = "0x6B356A0", VA = "0x186B368A0")]
	public bool EPJGHHCGPFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B35010", Offset = "0x6B33E10", VA = "0x186B35010")]
	public void AFKOKNACDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B37810", Offset = "0x6B36610", VA = "0x186B37810")]
	public bool LDPMCEBHJBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B373C0", Offset = "0x6B361C0", VA = "0x186B373C0")]
	public bool IMGJNBBHLGF(int NJKDAMEBDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B35140", Offset = "0x6B33F40", VA = "0x186B35140")]
	public bool BAJNNJIJPBF(int NJKDAMEBDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B34F80", Offset = "0x6B33D80", VA = "0x186B34F80")]
	public bool ACELDJOGIIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B37AA0", Offset = "0x6B368A0", VA = "0x186B37AA0")]
	public void NPDMEHECFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B361F0", Offset = "0x6B34FF0", VA = "0x186B361F0")]
	public bool DGNBLBACNCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B37570", Offset = "0x6B36370", VA = "0x186B37570")]
	public void JDCOPFEAPNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B352F0", Offset = "0x6B340F0", VA = "0x186B352F0")]
	private void BGJJPEBMCBL([Out] byte[] GJCHEGIGKBC, [Out] int KBHEOBJKPFL, [Out] int FFFAKIPABPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B363E0", Offset = "0x6B351E0", VA = "0x186B363E0")]
	private static int EAALKDHNNFH(char CGAHKNIFIAB, char CJOKOOBKDLJ, char JJPJCHPNNMP, char OIDDJANNCDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B36BE0", Offset = "0x6B359E0", VA = "0x186B36BE0")]
	private static int GCPPLILKMOM(char FCLAAGLFIOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B360D0", Offset = "0x6B34ED0", VA = "0x186B360D0")]
	public ArraySegment<byte> CJJHNEJAIGM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B35210", Offset = "0x6B34010", VA = "0x186B35210")]
	public string BDEMKIIFHOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B379C0", Offset = "0x6B367C0", VA = "0x186B379C0")]
	public string MFLHHLCINGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B37E10", Offset = "0x6B36C10", VA = "0x186B37E10")]
	public ArraySegment<byte> PGMMGJFGKNP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B37A30", Offset = "0x6B36830", VA = "0x186B37A30")]
	public ArraySegment<byte> MHLHDBPBJOL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B36510", Offset = "0x6B35310", VA = "0x186B36510")]
	public bool EFMBFIKACIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B36D40", Offset = "0x6B35B40", VA = "0x186B36D40")]
	private static bool HEKDBLFDDKO(byte JJPJCHPNNMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B37B40", Offset = "0x6B36940", VA = "0x186B37B40")]
	private void ODGNNICKIIM(CLNDOOPDFLJ ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B37520", Offset = "0x6B36320", VA = "0x186B37520")]
	public void INLLLJCKLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B36280", Offset = "0x6B35080", VA = "0x186B36280")]
	private void DIEOKDICAPD(int CNDDJICJBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B36490", Offset = "0x6B35290", VA = "0x186B36490")]
	public sbyte EFKKJALFIDJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B37D90", Offset = "0x6B36B90", VA = "0x186B37D90")]
	public short OEOGPINAHBP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B37940", Offset = "0x6B36740", VA = "0x186B37940")]
	public int LJPJJPGIHHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B37130", Offset = "0x6B35F30", VA = "0x186B37130")]
	public long IDNLGCMGLKB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B36CC0", Offset = "0x6B35AC0", VA = "0x186B36CC0")]
	public byte GOGMDGINEMI()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B36E00", Offset = "0x6B35C00", VA = "0x186B36E00")]
	public ushort HKAJCJMHKBI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6B36760", Offset = "0x6B35560", VA = "0x186B36760")]
	public uint EHPMGHMFMPN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B367E0", Offset = "0x6B355E0", VA = "0x186B367E0")]
	public ulong ENCBBIDBOIL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B37030", Offset = "0x6B35E30", VA = "0x186B37030")]
	public float IAILMIPHOFM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B372C0", Offset = "0x6B360C0", VA = "0x186B372C0")]
	public double IKCHHKLCHDL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B38030", Offset = "0x6B36E30", VA = "0x186B38030")]
	public ArraySegment<byte> PIACOPECACL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B36A50", Offset = "0x6B35850", VA = "0x186B36A50")]
	private static int GAPHFFHJGOA(byte[] KKAMOMBNLOJ, int PJPGJICIKPG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DJEMAGLLICA : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference HKCFMNGIGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int AEBGODJKKNC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int AKOMBCBOHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC62200", Offset = "0xC61000", VA = "0x180C62200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string OFAMONHNHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x879D10", Offset = "0x878B10", VA = "0x180879D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6B32AB0", Offset = "0x6B318B0", VA = "0x186B32AB0")]
	public DJEMAGLLICA(string HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6B32B10", Offset = "0x6B31910", VA = "0x186B32B10")]
	public DJEMAGLLICA(string HPJAAILCALJ, byte[] GGFBENMIGFF, int PJPGJICIKPG, int AEBGODJKKNC, string KCBHFFKOLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LBNBGJKKBMD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class FBMJBCOEBJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] GGBNILIIFNK;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B34EE0", Offset = "0x6B33CE0", VA = "0x186B34EE0")]
		public static byte[] KCJMIOPEJKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class CAEAAAJPOLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void BKLEGMNMHIC(CDEIOEGMOCO DFHABBFDBND, object DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object GMAMNKHNPBE(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC HHCIAIAKKNK);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class BFECKFHBBFH
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class PAFIOGBJBPI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
				public PAFIOGBJBPI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3925630", Offset = "0x3924430", VA = "0x183925630")]
				internal bool PJIHLALFJBI(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6B3F7E0", Offset = "0x6B3E5E0", VA = "0x186B3F7E0")]
				internal bool IMJOHGEIONL(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, BHPKKFEEGEC, byte[]> NDMEIJENHBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, BHPKKFEEGEC> FKPAFLOLMMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly BKLEGMNMHIC MILCAJLDGJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, BHPKKFEEGEC, ArraySegment<byte>> EIEJJGENJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, BHPKKFEEGEC, string> FBAKJDDNBBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, BHPKKFEEGEC, object> ANPPJBCPPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, BHPKKFEEGEC, object> JOMJFCONNDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, BHPKKFEEGEC, object> GCJGLDLACMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly GMAMNKHNPBE HMOCHIBOCLK;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6B263B0", Offset = "0x6B251B0", VA = "0x186B263B0")]
			public BFECKFHBBFH(Type DDEINLAGLLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2EDCFE0", Offset = "0x2EDBDE0", VA = "0x182EDCFE0")]
			private static T MFJLILEFBMA<T>(DynamicMethod HDKNAOCDOPL)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6B26160", Offset = "0x6B24F60", VA = "0x186B26160")]
			private static MethodInfo NELGEPAMPGC(Type DDEINLAGLLL, string PHEKPMAPPHM, Type[] MLBJBAMBDEM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, BFECKFHBBFH> HKGPJEELLDC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly NGDBOPCBONO<BFECKFHBBFH> JABCKDILPNB;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B28DB0", Offset = "0x6B27BB0", VA = "0x186B28DB0")]
		static CAEAAAJPOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B28AB0", Offset = "0x6B278B0", VA = "0x186B28AB0")]
		private static BFECKFHBBFH CADCEJNBBBA(Type DDEINLAGLLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B28B30", Offset = "0x6B27930", VA = "0x186B28B30")]
		public static void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, object DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B28CB0", Offset = "0x6B27AB0", VA = "0x186B28CB0")]
		public static void JPFDICAGNEF(Type DDEINLAGLLL, CDEIOEGMOCO DFHABBFDBND, object DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BHPKKFEEGEC BHINDDPMJCF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] CFEBFKDMFJC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] CEGGHDIJCAA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static BHPKKFEEGEC FEMOFPHBAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E250", Offset = "0x6B3D050", VA = "0x186B3E250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HLCDKGLKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E340", Offset = "0x6B3D140", VA = "0x186B3E340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E1E0", Offset = "0x6B3CFE0", VA = "0x186B3E1E0")]
	public static void FELKHDFMDPG(BHPKKFEEGEC HHCIAIAKKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x295B410", Offset = "0x295A210", VA = "0x18295B410")]
	public static byte[] JPFDICAGNEF<T>(T EIFMADKIHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x295B2A0", Offset = "0x295A0A0", VA = "0x18295B2A0")]
	public static byte[] JPFDICAGNEF<T>(T DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x295B880", Offset = "0x295A680", VA = "0x18295B880")]
	public static void JPFDICAGNEF<T>(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x295B480", Offset = "0x295A280", VA = "0x18295B480")]
	public static void JPFDICAGNEF<T>(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x295B900", Offset = "0x295A700", VA = "0x18295B900")]
	public static void JPFDICAGNEF<T>(Stream MEDEAOCENEP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x295B740", Offset = "0x295A540", VA = "0x18295B740")]
	public static void JPFDICAGNEF<T>(Stream MEDEAOCENEP, T DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2959AA0", Offset = "0x29588A0", VA = "0x182959AA0")]
	public static ArraySegment<byte> AABHPEFINHJ<T>(T EIFMADKIHON)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2959B30", Offset = "0x2958930", VA = "0x182959B30")]
	public static ArraySegment<byte> AABHPEFINHJ<T>(T DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2959CC0", Offset = "0x2958AC0", VA = "0x182959CC0")]
	public static string ALAJNAFGDBG<T>(T DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2959D30", Offset = "0x2958B30", VA = "0x182959D30")]
	public static string ALAJNAFGDBG<T>(T DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x295A980", Offset = "0x2959780", VA = "0x18295A980")]
	public static T FPNHMAJLCHC<T>(string DGENKJIDIMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x295A890", Offset = "0x2959690", VA = "0x18295A890")]
	public static T FPNHMAJLCHC<T>(string DGENKJIDIMJ, BHPKKFEEGEC HHCIAIAKKNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x295AC90", Offset = "0x2959A90", VA = "0x18295AC90")]
	public static T FPNHMAJLCHC<T>(byte[] KKAMOMBNLOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x295A800", Offset = "0x2959600", VA = "0x18295A800")]
	public static T FPNHMAJLCHC<T>(byte[] KKAMOMBNLOJ, BHPKKFEEGEC HHCIAIAKKNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x295AF40", Offset = "0x2959D40", VA = "0x18295AF40")]
	public static T FPNHMAJLCHC<T>(byte[] KKAMOMBNLOJ, int PJPGJICIKPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x295AA10", Offset = "0x2959810", VA = "0x18295AA10")]
	public static T FPNHMAJLCHC<T>(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, BHPKKFEEGEC HHCIAIAKKNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x295AD00", Offset = "0x2959B00", VA = "0x18295AD00")]
	public static T FPNHMAJLCHC<T>(FHJFMOGBEPJ HGAPEJGOMLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x295B090", Offset = "0x2959E90", VA = "0x18295B090")]
	public static T FPNHMAJLCHC<T>(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC HHCIAIAKKNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x295AD70", Offset = "0x2959B70", VA = "0x18295AD70")]
	public static T FPNHMAJLCHC<T>(Stream MEDEAOCENEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x295B160", Offset = "0x2959F60", VA = "0x18295B160")]
	public static T FPNHMAJLCHC<T>(Stream MEDEAOCENEP, BHPKKFEEGEC HHCIAIAKKNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D460", Offset = "0x6B3C260", VA = "0x186B3D460")]
	public static string CIJAJBMLIJO(byte[] DGENKJIDIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D750", Offset = "0x6B3C550", VA = "0x186B3D750")]
	public static string CIJAJBMLIJO(byte[] DGENKJIDIMJ, int PJPGJICIKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D5C0", Offset = "0x6B3C3C0", VA = "0x186B3D5C0")]
	public static string CIJAJBMLIJO(string DGENKJIDIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E4E0", Offset = "0x6B3D2E0", VA = "0x186B3E4E0")]
	public static byte[] MMPMABFDFKJ(byte[] DGENKJIDIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E390", Offset = "0x6B3D190", VA = "0x186B3E390")]
	public static byte[] MMPMABFDFKJ(byte[] DGENKJIDIMJ, int PJPGJICIKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E650", Offset = "0x6B3D450", VA = "0x186B3E650")]
	public static byte[] MMPMABFDFKJ(string DGENKJIDIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D890", Offset = "0x6B3C690", VA = "0x186B3D890")]
	private static void DNDMPPLLDGI(FHJFMOGBEPJ HGAPEJGOMLD, CDEIOEGMOCO DFHABBFDBND, int ECOGAHLMAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E140", Offset = "0x6B3CF40", VA = "0x186B3E140")]
	private static int DNNEKGHCNOE(Stream PGOKJJEIBMC, byte[] GGBNILIIFNK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CLNDOOPDFLJ : byte
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
public struct CDEIOEGMOCO
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] PANELFMKOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] GGBNILIIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int PJPGJICIKPG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JJDMHHDOLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E4F0B0", Offset = "0x1E4DEB0", VA = "0x181E4F0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B31850", Offset = "0x6B30650", VA = "0x186B31850")]
	public void JCMGNCHBNIB(int PJPGJICIKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B322B0", Offset = "0x6B310B0", VA = "0x186B322B0")]
	public static byte[] OLFHGHEBJGF(string OOFPAAIKGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B31C70", Offset = "0x6B30A70", VA = "0x186B31C70")]
	public static byte[] LHIJEJMKAKK(string OOFPAAIKGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B314A0", Offset = "0x6B302A0", VA = "0x186B314A0")]
	public static byte[] HEBAPNDEMLM(string OOFPAAIKGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B31AF0", Offset = "0x6B308F0", VA = "0x186B31AF0")]
	public static byte[] LEPCNBGFENG(string OOFPAAIKGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56DAB40", Offset = "0x56D9940", VA = "0x1856DAB40")]
	public CDEIOEGMOCO(byte[] IHGNEJBOOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B318D0", Offset = "0x6B306D0", VA = "0x186B318D0")]
	public ArraySegment<byte> KCJMIOPEJKN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B324B0", Offset = "0x6B312B0", VA = "0x186B324B0")]
	public byte[] PMKOGNJEGFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6B32580", Offset = "0x6B31380", VA = "0x186B32580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B32520", Offset = "0x6B31320", VA = "0x186B32520")]
	public void PNPLHLGJHDO(int HMDEEAIOBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B319D0", Offset = "0x6B307D0", VA = "0x186B319D0")]
	public void KEFMHEEGABK(byte NALEJAGIHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B31970", Offset = "0x6B30770", VA = "0x186B31970")]
	public void KEFMHEEGABK(byte[] NALEJAGIHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6B31460", Offset = "0x6B30260", VA = "0x186B31460")]
	public void GPKHCMELPMD(byte NALEJAGIHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B312D0", Offset = "0x6B300D0", VA = "0x186B312D0")]
	public void ECKNBCLNMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B31160", Offset = "0x6B2FF60", VA = "0x186B31160")]
	public void AOPHICFIIKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B31AA0", Offset = "0x6B308A0", VA = "0x186B31AA0")]
	public void KMNPPCOJHEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B32530", Offset = "0x6B31330", VA = "0x186B32530")]
	public void POCCAGNLMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B313A0", Offset = "0x6B301A0", VA = "0x186B313A0")]
	public void FFNNGCJOOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B31DE0", Offset = "0x6B30BE0", VA = "0x186B31DE0")]
	public void LLIPKOFINAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6B31230", Offset = "0x6B30030", VA = "0x186B31230")]
	public void CEBCHMACMBG(string OOFPAAIKGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B321C0", Offset = "0x6B30FC0", VA = "0x186B321C0")]
	public void NFPFELHNMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6B32410", Offset = "0x6B31210", VA = "0x186B32410")]
	public void PHCNKMLFJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B31610", Offset = "0x6B30410", VA = "0x186B31610")]
	public void HFNIPHJGNFA(bool DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6B31320", Offset = "0x6B30120", VA = "0x186B31320")]
	public void FDLIFOHHGOB(float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6B311B0", Offset = "0x6B2FFB0", VA = "0x186B311B0")]
	public void CAPOHENADDH(double DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6B313F0", Offset = "0x6B301F0", VA = "0x186B313F0")]
	public void GJFDICDLMKN(byte DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6B31770", Offset = "0x6B30570", VA = "0x186B31770")]
	public void IGOCJFGEIBO(ushort DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6B317E0", Offset = "0x6B305E0", VA = "0x186B317E0")]
	public void IJMADJCGEEH(uint DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6B323E0", Offset = "0x6B311E0", VA = "0x186B323E0")]
	public void PAMNEPHAPOE(ulong DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6B31860", Offset = "0x6B30660", VA = "0x186B31860")]
	public void KCEGKOPBOEJ(sbyte DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B31A30", Offset = "0x6B30830", VA = "0x186B31A30")]
	public void KLHJFKOKOKJ(short DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B32240", Offset = "0x6B31040", VA = "0x186B32240")]
	public void OAIGOEMDHGA(int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B32210", Offset = "0x6B31010", VA = "0x186B32210")]
	public void NKPPCCBLIBF(long DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B31E30", Offset = "0x6B30C30", VA = "0x186B31E30")]
	public void MDECFHDPFFN(string DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class HPJDLGDAAOJ : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class OMLMMDNCKEJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4127080", Offset = "0x4125E80", VA = "0x184127080")]
		static OMLMMDNCKEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private HPJDLGDAAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class IHBAIKKCMME : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class MHGIMHKCNIC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F9E8B0", Offset = "0x3F9D6B0", VA = "0x183F9E8B0")]
		static MHGIMHKCNIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class HBBMJECCAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> FLBDAOIHPHA;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6B38B60", Offset = "0x6B37960", VA = "0x186B38B60")]
		internal static object DMAAHLAMJCF(Type HKJAKBPEJHH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private IHBAIKKCMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class FJDALCOEKOH : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class GMHBFODLPOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3958570", Offset = "0x3957370", VA = "0x183958570")]
		static GMHBFODLPOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly FJDALCOEKOH LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool GDLCMKMPBIA;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static DMCDFIKKPEH[] CAHPNLKGJKG;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static BHPKKFEEGEC[] HBKAJFOAEDA;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private FJDALCOEKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B383F0", Offset = "0x6B371F0", VA = "0x186B383F0")]
	public static void GEBEKKCKBFI(params BHPKKFEEGEC[] HBKAJFOAEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B384D0", Offset = "0x6B372D0", VA = "0x186B384D0")]
	public static void GEBEKKCKBFI(params DMCDFIKKPEH[] CAHPNLKGJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B385B0", Offset = "0x6B373B0", VA = "0x186B385B0")]
	public static void NLKENMCFMIK(DMCDFIKKPEH[] CAHPNLKGJKG, BHPKKFEEGEC[] HBKAJFOAEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MNCBNLFODLB : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class JHNENJBGIAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C303D0", Offset = "0x3C2F1D0", VA = "0x183C303D0")]
		static JHNENJBGIAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private MNCBNLFODLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class OONABCCAECO
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly BHPKKFEEGEC NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly BHPKKFEEGEC AJIJIKNKHDL;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly BHPKKFEEGEC HAHGDKOLMCE;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly BHPKKFEEGEC KPLKLBDCHGG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly BHPKKFEEGEC MAKFHHBEONP;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly BHPKKFEEGEC IILDFBDFGDM;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly BHPKKFEEGEC LDKHKOALLAF;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly BHPKKFEEGEC DIPLPKGFDMD;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly BHPKKFEEGEC BABOCKADKDG;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly BHPKKFEEGEC OOGMKODEGEK;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BHPKKFEEGEC MKFPKDCGGAH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly BHPKKFEEGEC CNKJMPOAHBA;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LJFCOCFPNBK
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly BHPKKFEEGEC NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly BHPKKFEEGEC DMKJCFPLGPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class JHMEFCBMMDK
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly BHPKKFEEGEC NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BHPKKFEEGEC AJIJIKNKHDL;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly BHPKKFEEGEC HAHGDKOLMCE;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly BHPKKFEEGEC KPLKLBDCHGG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly BHPKKFEEGEC MAKFHHBEONP;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly BHPKKFEEGEC IILDFBDFGDM;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly BHPKKFEEGEC LDKHKOALLAF;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly BHPKKFEEGEC DIPLPKGFDMD;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly BHPKKFEEGEC BABOCKADKDG;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly BHPKKFEEGEC OOGMKODEGEK;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly BHPKKFEEGEC MKFPKDCGGAH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly BHPKKFEEGEC CNKJMPOAHBA;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class JJJPKEMNCDI
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> FLBDAOIHPHA;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B260", Offset = "0x6B3A060", VA = "0x186B3B260")]
	internal static object DMAAHLAMJCF(Type HKJAKBPEJHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B220", Offset = "0x6B3A020", VA = "0x186B3B220")]
	private static object DHNJLIGLNCO(Type OOEOMJNBJDB, Type[] DMMMMJOFAMC, params object[] MLBJBAMBDEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class MAFILEGJEOA : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class NKKGBADHKKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40362D0", Offset = "0x40350D0", VA = "0x1840362D0")]
		static NKKGBADHKKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly GAFDLCINAGH PGJEDMLFOBK;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EA80", Offset = "0x6B3D880", VA = "0x186B3EA80")]
	static MAFILEGJEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private MAFILEGJEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class EBCLAJIMMJP : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class GMCGLEHLGBL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x39514D0", Offset = "0x39502D0", VA = "0x1839514D0")]
		static GMCGLEHLGBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly GAFDLCINAGH PGJEDMLFOBK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B34B00", Offset = "0x6B33900", VA = "0x186B34B00")]
	static EBCLAJIMMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private EBCLAJIMMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class EJIKBDKEPOO : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class KLIFKBNNLPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D16340", Offset = "0x3D15140", VA = "0x183D16340")]
		static KLIFKBNNLPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly GAFDLCINAGH PGJEDMLFOBK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B34D90", Offset = "0x6B33B90", VA = "0x186B34D90")]
	static EJIKBDKEPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private EJIKBDKEPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class DJBPHKDGAHH : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class BMGIOFDEKMM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4880920", Offset = "0x487F720", VA = "0x184880920")]
		static BMGIOFDEKMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly GAFDLCINAGH PGJEDMLFOBK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B32960", Offset = "0x6B31760", VA = "0x186B32960")]
	static DJBPHKDGAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private DJBPHKDGAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class AOKIHLKEMEI : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class IFBCPFMDMCL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A747E0", Offset = "0x3A735E0", VA = "0x183A747E0")]
		static IFBCPFMDMCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly GAFDLCINAGH PGJEDMLFOBK;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B26010", Offset = "0x6B24E10", VA = "0x186B26010")]
	static AOKIHLKEMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private AOKIHLKEMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class FJFANJPNKKF : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class NIJJLKPMJFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x402A470", Offset = "0x4029270", VA = "0x18402A470")]
		static NIJJLKPMJFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly GAFDLCINAGH PGJEDMLFOBK;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B38920", Offset = "0x6B37720", VA = "0x186B38920")]
	static FJFANJPNKKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private FJFANJPNKKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class PIACONNDEDP : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class COBHIIEEMLB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4E04480", Offset = "0x4E03280", VA = "0x184E04480")]
		static COBHIIEEMLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public PIACONNDEDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class PFHDNIKKHFO : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class ANIMGFCBAFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x391F850", Offset = "0x391E650", VA = "0x18391F850")]
		static ANIMGFCBAFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public PFHDNIKKHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HGJMKJIFPAL : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class MBJFLPJDNNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F9B0", Offset = "0x3F6E7B0", VA = "0x183F6F9B0")]
		static MBJFLPJDNNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public HGJMKJIFPAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class JILCMDIALMN : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class JMBKIKNHIIL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C507B0", Offset = "0x3C4F5B0", VA = "0x183C507B0")]
		static JMBKIKNHIIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public JILCMDIALMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class HDEDDPHIMOO : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class JIPLFNENABP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D270", Offset = "0x3C3C070", VA = "0x183C3D270")]
		static JIPLFNENABP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public HDEDDPHIMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class GIIKOIEGMJF : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class LGNAIDCPOKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7A40", Offset = "0x3DB6840", VA = "0x183DB7A40")]
		static LGNAIDCPOKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> MPKHEINEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool CAEFNDLIOLO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GIIKOIEGMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class CBPHJBKKDCB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct HKHHGENIIJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public ENLKJAAEDMC KHGAGKCPBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder LFLPMLLGHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder AGCFMGKALEP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class DPEPDMKBION
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class PEPIJIBFOOD
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo HEBAPNDEMLM;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo LHIJEJMKAKK;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo LEPCNBGFENG;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo OLFHGHEBJGF;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo PHCNKMLFJFF;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo KEFMHEEGABK;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo KMNPPCOJHEN;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo POCCAGNLMLH;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo FFNNGCJOOJO;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6B3FA00", Offset = "0x6B3E800", VA = "0x186B3FA00")]
			static PEPIJIBFOOD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class CADJODBAGDF
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo GANPBEHPHAI;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo AFKOKNACDGF;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo IMGJNBBHLGF;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo HNHCEFCAEHO;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo INLLLJCKLBA;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo KKFEIFGKPJC;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo NAPNOLCNGMK;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6B27F00", Offset = "0x6B26D00", VA = "0x186B27F00")]
			static CADJODBAGDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class JPOCEHDKBGE
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo HCOCHJBMEAO;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo BEOEAENJKOF;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo DCNMMMDJNHL;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo KBPDPPJEPOK;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo LGPNLKLOBJB;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo NNKKDCMAEPL;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo DEGNAFABABE;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo LLGHMKHLJIB;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo JDCMELFCLJC;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo ALGDLPKPECD;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo COPMIHOBHBO;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo MABFNABMMNK;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo KMAFPLCMDEN;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo KDBFBIPABMP;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6B330B0", Offset = "0x6B31EB0", VA = "0x186B330B0")]
		public static MethodInfo JPFDICAGNEF(Type DDEINLAGLLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6B32E70", Offset = "0x6B31C70", VA = "0x186B32E70")]
		public static MethodInfo FPNHMAJLCHC(Type DDEINLAGLLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6B33340", Offset = "0x6B32140", VA = "0x186B33340")]
		public static MethodInfo LNEDGINNIDK(Type DDEINLAGLLL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class HLCKLCIHHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<ENLKJAAEDMC, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HLCKLCIHHGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class MFGFOHIJLFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public HLCKLCIHHGG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MFGFOHIJLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6B3ECA0", Offset = "0x6B3DAA0", VA = "0x186B3ECA0")]
		internal void PDMAJDMFAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6B3EC00", Offset = "0x6B3DA00", VA = "0x186B3EC00")]
		internal bool ABPOHMLONPF(int index, ENLKJAAEDMC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DPHHHBGILNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public HLCKLCIHHGG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DPHHHBGILNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6B34A60", Offset = "0x6B33860", VA = "0x186B34A60")]
		internal bool MJNPMHOONEB(int index, ENLKJAAEDMC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OCMLLMLEJFG
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
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OCMLLMLEJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x38594D0", Offset = "0x38582D0", VA = "0x1838594D0")]
		internal string PPEMPFIMFCG(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MJGCPLHNMGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MJGCPLHNMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6B3EFD0", Offset = "0x6B3DDD0", VA = "0x186B3EFD0")]
		internal bool GAGJNIKEOEO(ENLKJAAEDMC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class NFOGONPHGLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public OCMLLMLEJFG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NFOGONPHGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F220", Offset = "0x6B3E020", VA = "0x186B3F220")]
		internal void ICFHIKHJLDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F0A0", Offset = "0x6B3DEA0", VA = "0x186B3F0A0")]
		internal bool CGMABCPAJCD(int index, ENLKJAAEDMC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class MJBODIGBIHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public OCMLLMLEJFG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MJBODIGBIHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3EE50", Offset = "0x6B3DC50", VA = "0x186B3EE50")]
		internal bool DPJPBACFFMG(int index, ENLKJAAEDMC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class MAOKLHLILMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MAOKLHLILMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6B3EBD0", Offset = "0x6B3D9D0", VA = "0x186B3EBD0")]
		internal Label JLLFJNAACNF(ENLKJAAEDMC _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class NICPOMEOEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public HKHHGENIIJG[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, ENLKJAAEDMC, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public BDKJMMHGIGI argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public BDKJMMHGIGI argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NICPOMEOEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F230", Offset = "0x6B3E030", VA = "0x186B3F230")]
		internal HKHHGENIIJG IHBECCPNMIF(ENLKJAAEDMC item)
		{
			return default(HKHHGENIIJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CFMHBKLMCFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NICPOMEOEKJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CFMHBKLMCFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6B326D0", Offset = "0x6B314D0", VA = "0x186B326D0")]
		internal void NGHILMHCJAJ(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6B32640", Offset = "0x6B31440", VA = "0x186B32640")]
		internal void FFKLGBEMBLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class ANAGKOGICBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public ENLKJAAEDMC item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ANAGKOGICBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xBB0C90", Offset = "0xBAFA90", VA = "0x180BB0C90")]
		internal bool CKNMKHCEOKO(HKHHGENIIJG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class LFJJIDNBBDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public ENLKJAAEDMC item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public LFJJIDNBBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xBB0C90", Offset = "0xBAFA90", VA = "0x180BB0C90")]
		internal bool HFFINJDAHGH(HKHHGENIIJG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex GCFMJLEJFNP;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int LCOKIOMFIJH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> IDCNEGNMPAC;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> PGGMKIGPCFG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2700D60", Offset = "0x26FFB60", VA = "0x182700D60")]
	public static object GEBNNOIACPI<T>(GAFDLCINAGH PGJEDMLFOBK, BHPKKFEEGEC JAEKMGLHAIA, Func<string, string> MPKHEINEHCC, bool CAEFNDLIOLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x270D7E0", Offset = "0x270C5E0", VA = "0x18270D7E0")]
	public static object IFIDJIEGBEL<T>(BHPKKFEEGEC JAEKMGLHAIA, Func<string, string> MPKHEINEHCC, bool CAEFNDLIOLO, bool JKGPFCDBGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C3D0", Offset = "0x6B2B1D0", VA = "0x186B2C3D0")]
	private static TypeInfo GLAKMNLPOJN(GAFDLCINAGH PGJEDMLFOBK, Type DDEINLAGLLL, Func<string, string> MPKHEINEHCC, bool CAEFNDLIOLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EA90", Offset = "0x6B2D890", VA = "0x186B2EA90")]
	public static object LJKBOLDELPF(Type DDEINLAGLLL, Func<string, string> MPKHEINEHCC, bool CAEFNDLIOLO, bool JKGPFCDBGKK, bool DPPIJPMLLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BCE0", Offset = "0x6B2AAE0", VA = "0x186B2BCE0")]
	private static Dictionary<ENLKJAAEDMC, FieldInfo> GGNODDGOOMD(TypeBuilder OMNKPBHJKFA, COKJLPAIMEE KPBCFHJKPGG, ConstructorInfo JBMNJPFPMLM, FieldBuilder MPDDNCIIGNG, ILGenerator CAGMICGDAKD, bool CAEFNDLIOLO, bool BCDCMGJOPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B050", Offset = "0x6B29E50", VA = "0x186B2B050")]
	private static Dictionary<ENLKJAAEDMC, FieldInfo> BHPOBEHFIAB(TypeBuilder OMNKPBHJKFA, COKJLPAIMEE KPBCFHJKPGG, ILGenerator CAGMICGDAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D4B0", Offset = "0x6B2C2B0", VA = "0x186B2D4B0")]
	private static void HODMFAKFLFB(Type DDEINLAGLLL, COKJLPAIMEE KPBCFHJKPGG, ILGenerator CAGMICGDAKD, Action GFAAIDDEEIH, Func<int, ENLKJAAEDMC, bool> ABMAGLNNEOO, bool CAEFNDLIOLO, bool BCDCMGJOPAE, int MKLCCILADHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B305D0", Offset = "0x6B2F3D0", VA = "0x186B305D0")]
	private static void PJGBFNPBNHF(TypeInfo DDEINLAGLLL, ENLKJAAEDMC IOMGENKIEKD, ILGenerator CAGMICGDAKD, int AELAKOMEEDP, Func<int, ENLKJAAEDMC, bool> ABMAGLNNEOO, BDKJMMHGIGI DFHABBFDBND, BDKJMMHGIGI CAIAPCGIBAC, BDKJMMHGIGI HHJKJHPIBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6B28EF0", Offset = "0x6B27CF0", VA = "0x186B28EF0")]
	private static void AENAKHIMPND(Type DDEINLAGLLL, COKJLPAIMEE KPBCFHJKPGG, ILGenerator CAGMICGDAKD, Func<int, ENLKJAAEDMC, bool> ABMAGLNNEOO, bool NAIAMDLJGPH, int MKLCCILADHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B700", Offset = "0x6B2A500", VA = "0x186B2B700")]
	private static void CIEBNDNKFIN(ILGenerator CAGMICGDAKD, HKHHGENIIJG KPBCFHJKPGG, int AELAKOMEEDP, Func<int, ENLKJAAEDMC, bool> ABMAGLNNEOO, BDKJMMHGIGI HGAPEJGOMLD, BDKJMMHGIGI HHJKJHPIBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A330", Offset = "0x6B29130", VA = "0x186B2A330")]
	private static LocalBuilder BGPHMPEFPBO(ILGenerator CAGMICGDAKD, Type DDEINLAGLLL, COKJLPAIMEE KPBCFHJKPGG, HKHHGENIIJG[] GCELBAILLLD, bool KHBELOBLEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CDF0", Offset = "0x6B2BBF0", VA = "0x186B2CDF0")]
	private static bool HLIBEFMMFEC(ConstructorInfo OGGFJKKOCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BB60", Offset = "0x6B2A960", VA = "0x186B2BB60")]
	private static bool GFGCGFJHJLD(Type DDEINLAGLLL, [Out] Type GMOANAHBHEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void HACMALBANJF<T>(byte[][] MPDDNCIIGNG, object[] ABADOKDOBCE, CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC HHCIAIAKKNK);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T PAGGPFDIJHK<T>(object[] ABADOKDOBCE, FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC HHCIAIAKKNK);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class EELBJKMABJO<T> : GADLOFCICAN<T>, DMCDFIKKPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] MPDDNCIIGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] HNOMOICLLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] IILLAJIEMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly HACMALBANJF<T> JGFNLGDLEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly PAGGPFDIJHK<T> ONAAMMOLNKP;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FB50", Offset = "0x1E0E950", VA = "0x181E0FB50")]
	public EELBJKMABJO(byte[][] MPDDNCIIGNG, object[] HNOMOICLLNG, object[] IILLAJIEMFC, HACMALBANJF<T> JGFNLGDLEAM, PAGGPFDIJHK<T> ONAAMMOLNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x34797F0", Offset = "0x34785F0", VA = "0x1834797F0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3479710", Offset = "0x3478510", VA = "0x183479710", Slot = "5")]
	public T FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class OLGFMHIDALJ : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class BPDGOGAEDEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x497C5F0", Offset = "0x497B3F0", VA = "0x18497C5F0")]
		static BPDGOGAEDEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private OLGFMHIDALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class KLANHOIAGAO : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class KNHOFNJDEIA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3D24A80", Offset = "0x3D23880", VA = "0x183D24A80")]
		static KNHOFNJDEIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private KLANHOIAGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class DNKIKDBOLHO
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly BHPKKFEEGEC[] HAGGHCEFCFP;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class MIEIKHBLOBP : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class NOOPGDECCCJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4051A40", Offset = "0x4050840", VA = "0x184051A40")]
		static NOOPGDECCCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class PGKIAOENOHC : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class BMODGHOFMMM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4887D60", Offset = "0x4886B60", VA = "0x184887D60")]
			static BMODGHOFMMM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private PGKIAOENOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private MIEIKHBLOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class HMHIGLBMPCB : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class FACANFMPHOI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3805480", Offset = "0x3804280", VA = "0x183805480")]
		static FACANFMPHOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class BEDDMBKCFBG : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class HEEKDEDFAID<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x39B8190", Offset = "0x39B6F90", VA = "0x1839B8190")]
			static HEEKDEDFAID()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private BEDDMBKCFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private HMHIGLBMPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class DJJIHAOHOJA : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class PAJEBDCJBIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x41BE760", Offset = "0x41BD560", VA = "0x1841BE760")]
		static PAJEBDCJBIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class JPEKBHABCJI : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class HCKBMJOHPAF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x39B4300", Offset = "0x39B3100", VA = "0x1839B4300")]
			static HCKBMJOHPAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private JPEKBHABCJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private DJJIHAOHOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class IFDFOLLOHEA : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class NCMAIGCKGHO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3FFC240", Offset = "0x3FFB040", VA = "0x183FFC240")]
		static NCMAIGCKGHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class EDGNEPOCGAB : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class MDOPDALEEDH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3F7DBC0", Offset = "0x3F7C9C0", VA = "0x183F7DBC0")]
			static MDOPDALEEDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private EDGNEPOCGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private IFDFOLLOHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class OACBHGDKDGF : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class MEKPGDNLDNB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3F81080", Offset = "0x3F7FE80", VA = "0x183F81080")]
		static MEKPGDNLDNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class FMJEPCGIPAC : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class OGJNFAILHEC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4108BF0", Offset = "0x41079F0", VA = "0x184108BF0")]
			static OGJNFAILHEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private FMJEPCGIPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private OACBHGDKDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class CHEKBKJFIKO : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class EMKBDIHFEEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x34C24C0", Offset = "0x34C12C0", VA = "0x1834C24C0")]
		static EMKBDIHFEEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class NGEHHAPJKDE : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class JBPNLFJDLGL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3C19BA0", Offset = "0x3C189A0", VA = "0x183C19BA0")]
			static JBPNLFJDLGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private NGEHHAPJKDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private CHEKBKJFIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class NFMPDLCFGAG : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class CCPIJMMBEGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4C3FBE0", Offset = "0x4C3E9E0", VA = "0x184C3FBE0")]
		static CCPIJMMBEGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class PCFGAKIGJNG : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class KDMNAOMEJHP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3CE2D00", Offset = "0x3CE1B00", VA = "0x183CE2D00")]
			static KDMNAOMEJHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private PCFGAKIGJNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private NFMPDLCFGAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class LBBAEFKCFJJ : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class HGBCHOPALNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x39BF460", Offset = "0x39BE260", VA = "0x1839BF460")]
		static HGBCHOPALNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class DBGFLFELLOE : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class GAOPPLNFPGC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x38F9160", Offset = "0x38F7F60", VA = "0x1838F9160")]
			static GAOPPLNFPGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private DBGFLFELLOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private LBBAEFKCFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class HINBOEMAANM : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class NKENFAFDMAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4034130", Offset = "0x4032F30", VA = "0x184034130")]
		static NKENFAFDMAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class EOIFOOCNAAK : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class OPFFDFHMLDI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x412CFF0", Offset = "0x412BDF0", VA = "0x18412CFF0")]
			static OPFFDFHMLDI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private EOIFOOCNAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private HINBOEMAANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class DPFKCADFBKA : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class OKFBEGIAGLK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4114A70", Offset = "0x4113870", VA = "0x184114A70")]
		static OKFBEGIAGLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class KPENGHMNIAL : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class EOCEELFIEHD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x34C60A0", Offset = "0x34C4EA0", VA = "0x1834C60A0")]
			static EOCEELFIEHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private KPENGHMNIAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private DPFKCADFBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class OJLODHHLAEJ : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class HBKOMOLNJFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x39A9160", Offset = "0x39A7F60", VA = "0x1839A9160")]
		static HBKOMOLNJFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class GKGLMBCPIKF : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class HPMDLPIMMAG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x39E20B0", Offset = "0x39E0EB0", VA = "0x1839E20B0")]
			static HPMDLPIMMAG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private GKGLMBCPIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private OJLODHHLAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class KNMDGHIDCEA : BHPKKFEEGEC
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class KDGKBCJDPKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF230", Offset = "0x3CDE030", VA = "0x183CDF230")]
		static KDGKBCJDPKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class HHMNFDCDLGF : BHPKKFEEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class KNMPEJGAKAP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly GADLOFCICAN<T> IBBCDCOGNIO;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3D30E30", Offset = "0x3D2FC30", VA = "0x183D30E30")]
			static KNMPEJGAKAP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly BHPKKFEEGEC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly BHPKKFEEGEC[] HBKAJFOAEDA;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private HHMNFDCDLGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
		public GADLOFCICAN<T> DMAAHLAMJCF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly BHPKKFEEGEC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly GADLOFCICAN<object> LHECLCKJGLG;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	private KNMDGHIDCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	public GADLOFCICAN<T> DMAAHLAMJCF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct IMNMGFAPOLP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] BNIPLOBKGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int EDOPLBKMBBH;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A91F50", Offset = "0x3A90D50", VA = "0x183A91F50")]
	public IMNMGFAPOLP(int FNGLAKCPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A91BF0", Offset = "0x3A909F0", VA = "0x183A91BF0")]
	public void HDCMKJKDALC(T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A91A90", Offset = "0x3A90890", VA = "0x183A91A90")]
	public T[] AOOJMGHGKDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class FMKEMPKCKMJ : FAEDAFFIODI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly FMKEMPKCKMJ NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B47980", Offset = "0x6B46780", VA = "0x186B47980")]
	public FMKEMPKCKMJ(int NNGGBDBHKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class FAEDAFFIODI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int NNGGBDBHKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object FIGDGPACLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int AELAKOMEEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] CDIJJOHLFHL;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x380B540", Offset = "0x380A340", VA = "0x18380B540")]
	public FAEDAFFIODI(int NNGGBDBHKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x380AF50", Offset = "0x3809D50", VA = "0x18380AF50")]
	public T[] EJBJILKOMKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x380B300", Offset = "0x380A100", VA = "0x18380B300")]
	public void PLJMLNHBLJA(T[] OKLABKDOFAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class DBHNEIOGFAA : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class GPMIPHGOMAB : IComparable<GPMIPHGOMAB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class GDGAHFJPHML : IEnumerable<GPMIPHGOMAB>, IEnumerable, IEnumerator<GPMIPHGOMAB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private GPMIPHGOMAB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public GPMIPHGOMAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private GPMIPHGOMAB System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
			[DebuggerHidden]
			public GDGAHFJPHML(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6B47CC0", Offset = "0x6B46AC0", VA = "0x186B47CC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6B47DF0", Offset = "0x6B46BF0", VA = "0x186B47DF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6B47D40", Offset = "0x6B46B40", VA = "0x186B47D40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GPMIPHGOMAB> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6B47D40", Offset = "0x6B46B40", VA = "0x186B47D40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class MCDNMOCJHMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public MCDNMOCJHMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6B3EBD0", Offset = "0x6B3D9D0", VA = "0x186B3EBD0")]
			internal Label JHEOLPBCNJI(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6B3EBD0", Offset = "0x6B3D9D0", VA = "0x186B3EBD0")]
			internal Label GEBGFLLDJHM(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly GPMIPHGOMAB[] CILJKBAMOMP;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] BPJALHAGBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong AAPIPDGMADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int ACOGNAIJGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string IMJLCMIBDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private GPMIPHGOMAB[] DGDEDFDHHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] HEKILBHFEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int NJKDAMEBDBN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool EIPPPPJMEJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5402900", Offset = "0x5401700", VA = "0x185402900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6B49CF0", Offset = "0x6B48AF0", VA = "0x186B49CF0")]
		public GPMIPHGOMAB(ulong OBPLDLNDJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6B48DA0", Offset = "0x6B47BA0", VA = "0x186B48DA0")]
		public GPMIPHGOMAB HDCMKJKDALC(ulong OBPLDLNDJLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B48D40", Offset = "0x6B47B40", VA = "0x186B48D40")]
		public GPMIPHGOMAB HDCMKJKDALC(ulong OBPLDLNDJLE, int DIBNBLEEFNN, string IMJLCMIBDLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B48710", Offset = "0x6B47510", VA = "0x186B48710")]
		public GPMIPHGOMAB AHLIEAEIBHG(byte[] OKKFAPHNPBN, int PJPGJICIKPG, int AADPJCBNKPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B48940", Offset = "0x6B47740", VA = "0x186B48940")]
		internal static int DOELGNJNDBF(ulong[] OKLABKDOFAF, int AELAKOMEEDP, int PDCHCFIOJCE, ulong DIBNBLEEFNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6B48890", Offset = "0x6B47690", VA = "0x186B48890", Slot = "4")]
		public int CompareTo(GPMIPHGOMAB GGINNHLAMLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6B488C0", Offset = "0x6B476C0", VA = "0x186B488C0")]
		[IteratorStateMachine(typeof(GDGAHFJPHML))]
		public IEnumerable<GPMIPHGOMAB> DEEGOONNLPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B489D0", Offset = "0x6B477D0", VA = "0x186B489D0")]
		public void GJKNFBDDMEG(ILGenerator CAGMICGDAKD, LocalBuilder OKKFAPHNPBN, LocalBuilder AADPJCBNKPA, LocalBuilder OBPLDLNDJLE, Action<KeyValuePair<string, int>> IDOKFOFHJOC, Action FFNOLNJFKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6B48FA0", Offset = "0x6B47DA0", VA = "0x186B48FA0")]
		private static void OEGFJBCEBEC(ILGenerator CAGMICGDAKD, LocalBuilder OKKFAPHNPBN, LocalBuilder AADPJCBNKPA, LocalBuilder OBPLDLNDJLE, Action<KeyValuePair<string, int>> IDOKFOFHJOC, Action FFNOLNJFKBJ, GPMIPHGOMAB[] DGDEDFDHHCC, int NJKDAMEBDBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class DMLDOCGOHIL : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<GPMIPHGOMAB> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<GPMIPHGOMAB> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<GPMIPHGOMAB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private GPMIPHGOMAB <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DB0", Offset = "0xAD4BB0", VA = "0x180AD5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B45120", Offset = "0x6B43F20", VA = "0x186B45120", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CCF0", Offset = "0x1D1BAF0", VA = "0x181D1CCF0")]
		[DebuggerHidden]
		public DMLDOCGOHIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6B45170", Offset = "0x6B43F70", VA = "0x186B45170", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6B44BC0", Offset = "0x6B439C0", VA = "0x186B44BC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6B44B20", Offset = "0x6B43920", VA = "0x186B44B20")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6B44B70", Offset = "0x6B43970", VA = "0x186B44B70")]
		private void MHENGEIGMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6B450D0", Offset = "0x6B43ED0", VA = "0x186B450D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B45020", Offset = "0x6B43E20", VA = "0x186B45020", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B45020", Offset = "0x6B43E20", VA = "0x186B45020", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly GPMIPHGOMAB GDOPFEEANMP;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B44090", Offset = "0x6B42E90", VA = "0x186B44090")]
	public DBHNEIOGFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B43E40", Offset = "0x6B42C40", VA = "0x186B43E40")]
	public void HDCMKJKDALC(byte[] KKAMOMBNLOJ, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B43A20", Offset = "0x6B42820", VA = "0x186B43A20")]
	public bool AAHKONMNGPP(ArraySegment<byte> OBPLDLNDJLE, [Out] int DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B44000", Offset = "0x6B42E00", VA = "0x186B44000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B43B60", Offset = "0x6B42960", VA = "0x186B43B60")]
	private static void HBAJEOBNJAG(IEnumerable<GPMIPHGOMAB> DGDEDFDHHCC, StringBuilder GKBILPPEBAF, int ECOGAHLMAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B43B00", Offset = "0x6B42900", VA = "0x186B43B00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B43B00", Offset = "0x6B42900", VA = "0x186B43B00", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B43F50", Offset = "0x6B42D50", VA = "0x186B43F50")]
	[IteratorStateMachine(typeof(DMLDOCGOHIL))]
	private static IEnumerable<KeyValuePair<string, int>> NEANCAFPLIC(IEnumerable<GPMIPHGOMAB> DGDEDFDHHCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B43FD0", Offset = "0x6B42DD0", VA = "0x186B43FD0")]
	public void OLNCLOCDINJ(ILGenerator CAGMICGDAKD, LocalBuilder OKKFAPHNPBN, LocalBuilder AADPJCBNKPA, LocalBuilder OBPLDLNDJLE, Action<KeyValuePair<string, int>> IDOKFOFHJOC, Action FFNOLNJFKBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class PPBLBGCMJDC
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo PNIBEPFFLOI;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B56B40", Offset = "0x6B55940", VA = "0x186B56B40")]
	public static ulong JHMFMPKPDHA(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, int AADPJCBNKPA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class JGNNNDKCHBN
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B4F5C0", Offset = "0x6B4E3C0", VA = "0x186B4F5C0")]
	public static void PNPLHLGJHDO(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, int HMDEEAIOBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6B4F370", Offset = "0x6B4E170", VA = "0x186B4F370")]
	public static void JJDJMDBOCLJ(byte[] OKLABKDOFAF, int BHALBPKOEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B4F490", Offset = "0x6B4E290", VA = "0x186B4F490")]
	public static byte[] PNFMHBHIOAN(byte[] EKLFCLOPJMB, int BHALBPKOEHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class BFMJAJIKHLL
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B41E40", Offset = "0x6B40C40", VA = "0x186B41E40")]
	public static bool GPOBLKCLAFD(byte[] KFEGAIHDBJN, int DHOOOFIBMMI, int AFGLABHAFGG, byte[] JMPEFFNLJOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class CFPLPDKJBHA<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct BANAONELOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] AAPIPDGMADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T ACOGNAIJGCD;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x482F620", Offset = "0x482E420", VA = "0x18482F620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class FENHNGPIAAM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public CFPLPDKJBHA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private BANAONELOKI[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private BANAONELOKI[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DB0", Offset = "0xAD4BB0", VA = "0x180AD5DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3832360", Offset = "0x3831160", VA = "0x183832360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public FENHNGPIAAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x38309B0", Offset = "0x382F7B0", VA = "0x1838309B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3832310", Offset = "0x3831110", VA = "0x183832310", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly BANAONELOKI[][] HIBFCDNIGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong IMOBOHFDFPO;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E190", Offset = "0x4D1CF90", VA = "0x184D1E190")]
	public CFPLPDKJBHA(int GIOLCDOMFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E1B0", Offset = "0x4D1CFB0", VA = "0x184D1E1B0")]
	public CFPLPDKJBHA(int GIOLCDOMFDF, float ANBAOPNDDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D12F10", Offset = "0x4D11D10", VA = "0x184D12F10")]
	public void HDCMKJKDALC(byte[] OBPLDLNDJLE, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D139F0", Offset = "0x4D127F0", VA = "0x184D139F0")]
	private bool JAAONGNLNOC(byte[] OBPLDLNDJLE, T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D0D0", Offset = "0x4D1BED0", VA = "0x184D1D0D0")]
	public bool JJGGEGPCFME(ArraySegment<byte> OBPLDLNDJLE, [Out] T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D116A0", Offset = "0x4D104A0", VA = "0x184D116A0")]
	private static ulong ECCIOBLMEEK(byte[] FCLAAGLFIOD, int PJPGJICIKPG, int NJKDAMEBDBN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x401DFB0", Offset = "0x401CDB0", VA = "0x18401DFB0")]
	private static int ALHIDFLGFCP(int JPINIIMJPPI, float ANBAOPNDDMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D116F0", Offset = "0x4D104F0", VA = "0x184D116F0", Slot = "4")]
	[IteratorStateMachine(typeof(CFPLPDKJBHA<>.FENHNGPIAAM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x37DEA20", Offset = "0x37DD820", VA = "0x1837DEA20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class EGENJNHNBGG : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] NNGLGDLAOCP;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] BGJHMDNHMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int HCKBMLKMFNC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HFEHPMHIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6B46730", Offset = "0x6B45530", VA = "0x186B46730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B46870", Offset = "0x6B45670", VA = "0x186B46870")]
	static EGENJNHNBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B46AC0", Offset = "0x6B458C0", VA = "0x186B46AC0")]
	public EGENJNHNBGG(byte[] JCBCLKBMLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B46780", Offset = "0x6B45580", VA = "0x186B46780")]
	public OpCode FHEHDHBDKHH()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct IIFGKDBFJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid ACOGNAIJGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte KBBJGPHKJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte NDMPEJFCLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte PDEGGINFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte DKKBAHGFCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte CHKIBGIHEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte IDIGEEKEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte IGJPCNCGOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte GIOIOEFHDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte ACFJEPOAHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte OOOPGJCBPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte KNLCGOEJEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte APHJDAIPCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte ONFHCOCOFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte KDFGKCBJFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte EOPDCKECLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte EOBAPGPGNBB;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] PCLJKGLHDAO;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] PJELLGKLGKM;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B4BA70", Offset = "0x6B4A870", VA = "0x186B4BA70")]
	public IIFGKDBFJJC(Guid DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B4BA80", Offset = "0x6B4A880", VA = "0x186B4BA80")]
	public IIFGKDBFJJC(ArraySegment<byte> AMEGKFFAICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B4ABC0", Offset = "0x6B499C0", VA = "0x186B4ABC0")]
	private static byte HGKCGLCBECA(byte[] KKAMOMBNLOJ, int DLPGPIGFHBE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B4B870", Offset = "0x6B4A670", VA = "0x186B4B870")]
	private static byte MAHAFOIJJHA(byte CJOKOOBKDLJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B4AC60", Offset = "0x6B49A60", VA = "0x186B4AC60")]
	public void JHIMPLGLBKB(byte[] GGBNILIIFNK, int PJPGJICIKPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class NODCIAMICJD
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6B552D0", Offset = "0x6B540D0", VA = "0x186B552D0")]
	public static bool IDCMIFOLFAC(byte JJPJCHPNNMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6B54BE0", Offset = "0x6B539E0", VA = "0x186B54BE0")]
	public static bool CKNKIJFFNOL(byte JJPJCHPNNMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6B54C50", Offset = "0x6B53A50", VA = "0x186B54C50")]
	public static sbyte EFKKJALFIDJ(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6B55F10", Offset = "0x6B54D10", VA = "0x186B55F10")]
	public static short OEOGPINAHBP(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6B55460", Offset = "0x6B54260", VA = "0x186B55460")]
	public static int LJPJJPGIHHM(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6B552E0", Offset = "0x6B540E0", VA = "0x186B552E0")]
	public static long IDNLGCMGLKB(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6B550F0", Offset = "0x6B53EF0", VA = "0x186B550F0")]
	public static byte GOGMDGINEMI(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6B55170", Offset = "0x6B53F70", VA = "0x186B55170")]
	public static ushort HKAJCJMHKBI(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6B54F60", Offset = "0x6B53D60", VA = "0x186B54F60")]
	public static uint EHPMGHMFMPN(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6B54FE0", Offset = "0x6B53DE0", VA = "0x186B54FE0")]
	public static ulong ENCBBIDBOIL(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6B551F0", Offset = "0x6B53FF0", VA = "0x186B551F0")]
	public static float IAILMIPHOFM(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6B55380", Offset = "0x6B54180", VA = "0x186B55380")]
	public static double IKCHHKLCHDL(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6B56000", Offset = "0x6B54E00", VA = "0x186B56000")]
	public static int PAMNEPHAPOE(byte[] GGBNILIIFNK, int PJPGJICIKPG, ulong DIBNBLEEFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6B55550", Offset = "0x6B54350", VA = "0x186B55550")]
	public static int NKPPCCBLIBF(byte[] GGBNILIIFNK, int PJPGJICIKPG, long DIBNBLEEFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6B54D30", Offset = "0x6B53B30", VA = "0x186B54D30")]
	public static bool EFMBFIKACIA(byte[] KKAMOMBNLOJ, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class PPLHEOFLOCA
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class GPHLGAACFDI : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
		[DebuggerHidden]
		public GPHLGAACFDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6B485E0", Offset = "0x6B473E0", VA = "0x186B485E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6B480A0", Offset = "0x6B46EA0", VA = "0x186B480A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6B48000", Offset = "0x6B46E00", VA = "0x186B48000")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6B48050", Offset = "0x6B46E50", VA = "0x186B48050")]
		private void MHENGEIGMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6B48590", Offset = "0x6B47390", VA = "0x186B48590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6B484D0", Offset = "0x6B472D0", VA = "0x186B484D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6B484D0", Offset = "0x6B472D0", VA = "0x186B484D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class NMIEIPLKGKI : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
		[DebuggerHidden]
		public NMIEIPLKGKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6B54AB0", Offset = "0x6B538B0", VA = "0x186B54AB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6B54570", Offset = "0x6B53370", VA = "0x186B54570", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6B544D0", Offset = "0x6B532D0", VA = "0x186B544D0")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6B54520", Offset = "0x6B53320", VA = "0x186B54520")]
		private void MHENGEIGMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6B54A60", Offset = "0x6B53860", VA = "0x186B54A60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6B549A0", Offset = "0x6B537A0", VA = "0x186B549A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6B549A0", Offset = "0x6B537A0", VA = "0x186B549A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6B57A40", Offset = "0x6B56840", VA = "0x186B57A40")]
	public static bool PDPHLALJNCO(this TypeInfo DDEINLAGLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6B57870", Offset = "0x6B56670", VA = "0x186B57870")]
	public static bool DBHBGNPHKIK(this TypeInfo DDEINLAGLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6B57B00", Offset = "0x6B56900", VA = "0x186B57B00")]
	public static IEnumerable<PropertyInfo> PGJLEKPFMDN(this Type DDEINLAGLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6B579A0", Offset = "0x6B567A0", VA = "0x186B579A0")]
	[IteratorStateMachine(typeof(GPHLGAACFDI))]
	private static IEnumerable<PropertyInfo> IEBDHMPMLOI(Type DDEINLAGLLL, HashSet<string> GDCLPCMCINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6B577F0", Offset = "0x6B565F0", VA = "0x186B577F0")]
	public static IEnumerable<FieldInfo> BEBEDGJJBNA(this Type DDEINLAGLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6B57750", Offset = "0x6B56550", VA = "0x186B57750")]
	[IteratorStateMachine(typeof(NMIEIPLKGKI))]
	private static IEnumerable<FieldInfo> BCNPHDEGPJP(Type DDEINLAGLLL, HashSet<string> GDCLPCMCINM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class FAKABLDMFBB
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding CBGIEBDGBMC;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class HOCLLKMPAEA
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static string MLLFLAPFHDI(string FEOMCLKJGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A0D0", Offset = "0x6B48ED0", VA = "0x186B4A0D0")]
	public static string NFBNIMOIDOP(string FEOMCLKJGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A1B0", Offset = "0x6B48FB0", VA = "0x186B4A1B0")]
	public static string PIHCDNHJPGA(string FEOMCLKJGBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class NGDBOPCBONO<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class IJOGFHBEONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type AAPIPDGMADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue ACOGNAIJGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int DABKJBCMBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public IJOGFHBEONF HFBNPFMLIOA;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3A88270", Offset = "0x3A87070", VA = "0x183A88270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3A881F0", Offset = "0x3A86FF0", VA = "0x183A881F0")]
		private int BLPIMLOHMJK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public IJOGFHBEONF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class ADEMKEELJDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ADEMKEELJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x83F660", Offset = "0x83E460", VA = "0x18083F660")]
		internal TValue PHKKDIHFEGM(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private IJOGFHBEONF[] HIBFCDNIGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int CGDBKIJPKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object GBJFGKDCNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float ANBAOPNDDMF;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x401F530", Offset = "0x401E330", VA = "0x18401F530")]
	public NGDBOPCBONO(int GIOLCDOMFDF = 4, float ANBAOPNDDMF = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x401F200", Offset = "0x401E000", VA = "0x18401F200")]
	public bool NPFFPDIACNA(Type OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x401F180", Offset = "0x401DF80", VA = "0x18401F180")]
	public bool NPFFPDIACNA(Type OBPLDLNDJLE, Func<Type, TValue> HGJPAFCBHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x401EBB0", Offset = "0x401D9B0", VA = "0x18401EBB0")]
	private bool JAAONGNLNOC(Type OBPLDLNDJLE, Func<Type, TValue> HGJPAFCBHEC, [Out] TValue BCNBEAMNICM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x401E130", Offset = "0x401CF30", VA = "0x18401E130")]
	private bool DJCJJFGHGMI(IJOGFHBEONF[] HIBFCDNIGOA, Type FACCDBBGFDF, IJOGFHBEONF PDFGAPKMGFF, Func<Type, TValue> HGJPAFCBHEC, [Out] TValue BCNBEAMNICM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x401F010", Offset = "0x401DE10", VA = "0x18401F010")]
	public bool JJGGEGPCFME(Type OBPLDLNDJLE, [Out] TValue DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x401DFE0", Offset = "0x401CDE0", VA = "0x18401DFE0")]
	public TValue CADCEJNBBBA(Type OBPLDLNDJLE, Func<Type, TValue> HGJPAFCBHEC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x401DFB0", Offset = "0x401CDB0", VA = "0x18401DFB0")]
	private static int ALHIDFLGFCP(int JPINIIMJPPI, float ANBAOPNDDMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x401F150", Offset = "0x401DF50", VA = "0x18401F150")]
	private static void NOKJIOEILJE(IJOGFHBEONF LIAKDIHFADF, IJOGFHBEONF DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x401F150", Offset = "0x401DF50", VA = "0x18401F150")]
	private static void NOKJIOEILJE(IJOGFHBEONF[] LIAKDIHFADF, IJOGFHBEONF[] DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class GAFDLCINAGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder CINNBALCBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder PEEJLIEMEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object FIGDGPACLLB;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6B47AB0", Offset = "0x6B468B0", VA = "0x186B47AB0")]
	public TypeBuilder NDLBOIFBFOM(string PHEKPMAPPHM, TypeAttributes GCHGJBOIBNG, Type OGCHMLDLLMJ, Type[] CHKKONBIFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6B47BB0", Offset = "0x6B469B0", VA = "0x186B47BB0")]
	public GAFDLCINAGH(string BGNOGNFPHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class GACNOLOFFGD
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6B479D0", Offset = "0x6B467D0", VA = "0x186B479D0")]
	private static MethodInfo EEMNMGLAHDB(LambdaExpression MMFHHPCHCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x28C02A0", Offset = "0x28BF0A0", VA = "0x1828C02A0")]
	public static MethodInfo JIMPFPGBPPD<T>(Expression<Func<T>> MMFHHPCHCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x28C02A0", Offset = "0x28BF0A0", VA = "0x1828C02A0")]
	public static MethodInfo JIMPFPGBPPD<T, TR>(Expression<Func<T, TR>> MMFHHPCHCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x28C02A0", Offset = "0x28BF0A0", VA = "0x1828C02A0")]
	public static MethodInfo JIMPFPGBPPD<T>(Expression<Action<T>> MMFHHPCHCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x28C02A0", Offset = "0x28BF0A0", VA = "0x1828C02A0")]
	public static MethodInfo JIMPFPGBPPD<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> MMFHHPCHCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x28C0120", Offset = "0x28BEF20", VA = "0x1828C0120")]
	private static MemberInfo FODIIGGOAGB<T>(Expression<T> PFNKIIMPMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x28C0200", Offset = "0x28BF000", VA = "0x1828C0200")]
	public static PropertyInfo JCMHOIECHKJ<T, TR>(Expression<Func<T, TR>> MMFHHPCHCGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct BDKJMMHGIGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int GJPDNBKOLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool AAJKBCIMAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator CAGMICGDAKD;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6B41C40", Offset = "0x6B40A40", VA = "0x186B41C40")]
	public BDKJMMHGIGI(ILGenerator CAGMICGDAKD, int GJPDNBKOLHF, bool AAJKBCIMAEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6B41BB0", Offset = "0x6B409B0", VA = "0x186B41BB0")]
	public BDKJMMHGIGI(ILGenerator CAGMICGDAKD, int GJPDNBKOLHF, Type DDEINLAGLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6B41AB0", Offset = "0x6B408B0", VA = "0x186B41AB0")]
	public void LLFDHKKBLDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class LKLCEAAEBBA
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6B51FC0", Offset = "0x6B50DC0", VA = "0x186B51FC0")]
	public static void IMGMPBMBAOK(this ILGenerator CAGMICGDAKD, int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6B521A0", Offset = "0x6B50FA0", VA = "0x186B521A0")]
	public static void IMGMPBMBAOK(this ILGenerator CAGMICGDAKD, LocalBuilder OCFLKCJANOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6B523C0", Offset = "0x6B511C0", VA = "0x186B523C0")]
	public static void OOKOFDMJJGE(this ILGenerator CAGMICGDAKD, int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6B525A0", Offset = "0x6B513A0", VA = "0x186B525A0")]
	public static void OOKOFDMJJGE(this ILGenerator CAGMICGDAKD, LocalBuilder OCFLKCJANOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6B521E0", Offset = "0x6B50FE0", VA = "0x186B521E0")]
	public static void KNEKJPHAFCH(this ILGenerator CAGMICGDAKD, int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6B522C0", Offset = "0x6B510C0", VA = "0x186B522C0")]
	public static void KNEKJPHAFCH(this ILGenerator CAGMICGDAKD, LocalBuilder OCFLKCJANOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6B51B20", Offset = "0x6B50920", VA = "0x186B51B20")]
	public static void FPKALLIDKMP(this ILGenerator CAGMICGDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6B51B10", Offset = "0x6B50910", VA = "0x186B51B10")]
	public static void FLGDHPLLLKI(this ILGenerator CAGMICGDAKD, bool DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6B51C00", Offset = "0x6B50A00", VA = "0x186B51C00")]
	public static void IFACBMPPLCE(this ILGenerator CAGMICGDAKD, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6B519B0", Offset = "0x6B507B0", VA = "0x186B519B0")]
	public static void DBPFAJONNEP(this ILGenerator CAGMICGDAKD, Type DDEINLAGLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6B525E0", Offset = "0x6B513E0", VA = "0x186B525E0")]
	public static void PCNENBPIEPA(this ILGenerator CAGMICGDAKD, Type DDEINLAGLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6B517D0", Offset = "0x6B505D0", VA = "0x186B517D0")]
	public static void CPNJBLEAEPL(this ILGenerator CAGMICGDAKD, int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6B516D0", Offset = "0x6B504D0", VA = "0x186B516D0")]
	public static void BEHOPLLGAHF(this ILGenerator CAGMICGDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6B51B30", Offset = "0x6B50930", VA = "0x186B51B30")]
	public static void IBMEPBMFIJK(this ILGenerator CAGMICGDAKD, int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6B52680", Offset = "0x6B51480", VA = "0x186B52680")]
	public static void PEJBJIIOHLA(this ILGenerator CAGMICGDAKD, MethodInfo FPPGEGCPFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6B51A80", Offset = "0x6B50880", VA = "0x186B51A80")]
	public static void FDBEBIJBBDB(this ILGenerator CAGMICGDAKD, FieldInfo CNBIEPDILJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6B51740", Offset = "0x6B50540", VA = "0x186B51740")]
	public static void CJFAJFILDJI(this ILGenerator CAGMICGDAKD, ulong DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class ENLKJAAEDMC
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class CHFJDEPAOFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CHFJDEPAOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6B42200", Offset = "0x6B41000", VA = "0x186B42200")]
		internal bool BPKEGFNJGOH(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo ACNKIEGLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo OIFGMJBBGFA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string KBIODCNMMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MCMDCAGJKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6B46E30", Offset = "0x6B45C30", VA = "0x186B46E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GHALICLECME
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA880", Offset = "0x7B9680", VA = "0x1807BA880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA890", Offset = "0x7B9690", VA = "0x1807BA890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KCNDPDJHBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x929A90", Offset = "0x928890", VA = "0x180929A90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x929780", Offset = "0x928580", VA = "0x180929780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type LNPLBOHLOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo BHLDGBHNKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo LHLGGCGMMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8A0", Offset = "0x7B96A0", VA = "0x1807BA8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo CNLKJBCCMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F00", Offset = "0x7B0D00", VA = "0x1807B1F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7B20D0", Offset = "0x7B0ED0", VA = "0x1807B20D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6B46FB0", Offset = "0x6B45DB0", VA = "0x186B46FB0")]
	protected ENLKJAAEDMC(Type DDEINLAGLLL, string PHEKPMAPPHM, string LMGMGDENENC, bool BFCBGONFEPB, bool PHIDJMJJBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6B471F0", Offset = "0x6B45FF0", VA = "0x186B471F0")]
	public ENLKJAAEDMC(FieldInfo KPBCFHJKPGG, string PHEKPMAPPHM, bool JKGPFCDBGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6B47030", Offset = "0x6B45E30", VA = "0x186B47030")]
	public ENLKJAAEDMC(PropertyInfo KPBCFHJKPGG, string PHEKPMAPPHM, bool JKGPFCDBGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6B46B50", Offset = "0x6B45950", VA = "0x186B46B50")]
	private static MethodInfo APOAIHJHJEO(MemberInfo KPBCFHJKPGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2773B30", Offset = "0x2772930", VA = "0x182773B30")]
	public T PDOKJOMAIHM<T>(bool LEBFEGHHLMA) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6B46CC0", Offset = "0x6B45AC0", VA = "0x186B46CC0", Slot = "4")]
	public virtual void BAHGCBPDPJL(ILGenerator CAGMICGDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6B46E40", Offset = "0x6B45C40", VA = "0x186B46E40", Slot = "5")]
	public virtual void LHLDFLGBJBC(ILGenerator CAGMICGDAKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class FBANPMNDBHM : ENLKJAAEDMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string BMEJKGILDPM;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6B47640", Offset = "0x6B46440", VA = "0x186B47640")]
	public FBANPMNDBHM(string PHEKPMAPPHM, string BMEJKGILDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6B47540", Offset = "0x6B46340", VA = "0x186B47540", Slot = "4")]
	public override void BAHGCBPDPJL(ILGenerator CAGMICGDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6B475F0", Offset = "0x6B463F0", VA = "0x186B475F0", Slot = "5")]
	public override void LHLDFLGBJBC(ILGenerator CAGMICGDAKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class DHAAAAPBNCC : ENLKJAAEDMC
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo LINHGDODDOI;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo GFDHPAMHOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal BDKJMMHGIGI HOIJNJOKNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal BDKJMMHGIGI CAIAPCGIBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal BDKJMMHGIGI HHJKJHPIBBA;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6B448F0", Offset = "0x6B436F0", VA = "0x186B448F0")]
	public DHAAAAPBNCC(string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6B44110", Offset = "0x6B42F10", VA = "0x186B44110", Slot = "4")]
	public override void BAHGCBPDPJL(ILGenerator CAGMICGDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6B441D0", Offset = "0x6B42FD0", VA = "0x186B441D0", Slot = "5")]
	public override void LHLDFLGBJBC(ILGenerator CAGMICGDAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6B44220", Offset = "0x6B43020", VA = "0x186B44220")]
	public void OFOLNHNMMAE(ILGenerator CAGMICGDAKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class COKJLPAIMEE
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type LNPLBOHLOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GHOFKFCCGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x81E8A0", Offset = "0x81D6A0", VA = "0x18081E8A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D50", Offset = "0x7B6B50", VA = "0x1807B7D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool DDPPDKDGIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x81E950", Offset = "0x81D750", VA = "0x18081E950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9283A0", Offset = "0x9271A0", VA = "0x1809283A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo EHFKJIKHDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ENLKJAAEDMC[] NBNLAILHAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ENLKJAAEDMC[] BGMEKJOPICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6B423F0", Offset = "0x6B411F0", VA = "0x186B423F0")]
	public COKJLPAIMEE(Type DDEINLAGLLL, Func<string, string> GHLMBBLIKNI, bool JKGPFCDBGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6B42310", Offset = "0x6B41110", VA = "0x186B42310")]
	private static bool MAHDBHICLFN(IEnumerator<ConstructorInfo> IEDMGNGKEIF, ConstructorInfo AAHLDMJPJJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct BNKFGKKGHDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong DCIDEDOMNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int CCDENENMPHG;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CF50", Offset = "0x1E1BD50", VA = "0x181E1CF50")]
	public BNKFGKKGHDJ(ulong PJDCCGAAEAE, int GJKPCIMBDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6B41F50", Offset = "0x6B40D50", VA = "0x186B41F50")]
	public void EMPGIJPCBFN(BNKFGKKGHDJ GGINNHLAMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6B41EB0", Offset = "0x6B40CB0", VA = "0x186B41EB0")]
	public static BNKFGKKGHDJ CJKGBABAAPI(BNKFGKKGHDJ CGAHKNIFIAB, BNKFGKKGHDJ CJOKOOBKDLJ)
	{
		return default(BNKFGKKGHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6B42000", Offset = "0x6B40E00", VA = "0x186B42000")]
	public void LKEDIFIDJCI(BNKFGKKGHDJ GGINNHLAMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6B41F60", Offset = "0x6B40D60", VA = "0x186B41F60")]
	public static BNKFGKKGHDJ GGEEOECNFAM(BNKFGKKGHDJ CGAHKNIFIAB, BNKFGKKGHDJ CJOKOOBKDLJ)
	{
		return default(BNKFGKKGHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6B41F10", Offset = "0x6B40D10", VA = "0x186B41F10")]
	public void DHFMOPDCODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6B41EC0", Offset = "0x6B40CC0", VA = "0x186B41EC0")]
	public static BNKFGKKGHDJ DHFMOPDCODL(BNKFGKKGHDJ CGAHKNIFIAB)
	{
		return default(BNKFGKKGHDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct IBEKBCFNPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] GGBNILIIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int PJPGJICIKPG;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x18EBE50", Offset = "0x18EAC50", VA = "0x1818EBE50")]
	public IBEKBCFNPAM(byte[] GGBNILIIFNK, int JPLKOMKCHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6B319D0", Offset = "0x6B307D0", VA = "0x186B319D0")]
	public void ADIJGGLHGDL(byte INOMBDBKIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A6D0", Offset = "0x6B494D0", VA = "0x186B4A6D0")]
	public void BLJPKKHIKKG(byte[] INOMBDBKIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A750", Offset = "0x6B49550", VA = "0x186B4A750")]
	public void LJPKOBAJLBF(byte[] INOMBDBKIKO, int PDCHCFIOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A7D0", Offset = "0x6B495D0", VA = "0x186B4A7D0")]
	public void LJPKOBAJLBF(byte[] INOMBDBKIKO, int GJACDHHHCDB, int PDCHCFIOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A550", Offset = "0x6B49350", VA = "0x186B4A550")]
	public void AMGDNKLNNBD(byte JJPJCHPNNMP, int NJKDAMEBDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A5D0", Offset = "0x6B493D0", VA = "0x186B4A5D0")]
	public void AMIEALCKEHE(string INOMBDBKIKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class JGBMHOKNKPJ
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum DIDIENKKDFL
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum CJJJHNCFKFC
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum KDFFPLKLIAA
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
	private static byte[] PPPHJOBEDCE;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] GCBCHEHCBJJ;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] NICHHNFHAGH;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] PKNCHGOPGGO;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly KDFFPLKLIAA BPDDDMMDMAP;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char PMIJHLKAEDP;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int HEOKHJMGCBM;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int PMKBDGGIJNN;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] IJMGBEDMDLH;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6B4E610", Offset = "0x6B4D410", VA = "0x186B4E610")]
	private static byte[] LBNKPIDNBOM(int CGDBKIJPKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B4D1D0", Offset = "0x6B4BFD0", VA = "0x186B4D1D0")]
	private static byte[] AMPEGNGBELM(int CGDBKIJPKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B4E4F0", Offset = "0x6B4D2F0", VA = "0x186B4E4F0")]
	public static int JCJJDEGGCBM(byte[] GGBNILIIFNK, int PJPGJICIKPG, float DIBNBLEEFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B4E3D0", Offset = "0x6B4D1D0", VA = "0x186B4E3D0")]
	public static int JCJJDEGGCBM(byte[] GGBNILIIFNK, int PJPGJICIKPG, double DIBNBLEEFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B4D2B0", Offset = "0x6B4C0B0", VA = "0x186B4D2B0")]
	private static bool CBPMGDLEKIF(byte[] GGBNILIIFNK, int PDCHCFIOJCE, ulong OBCALNGEIJG, ulong KPMDLHACOGH, ulong AADPJCBNKPA, ulong CFPKJMGJLFA, ulong GFEJNICJPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B4F050", Offset = "0x6B4DE50", VA = "0x186B4F050")]
	private static void PMFHFKEPDIJ(uint DOKLDGJKBHB, int BKAEMHFLEOM, [Out] uint BHMNOELAIEO, [Out] int CDAGAFDAFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B4D4B0", Offset = "0x6B4C2B0", VA = "0x186B4D4B0")]
	private static bool EEEBDFGDAND(BNKFGKKGHDJ IEIIKODCIFL, BNKFGKKGHDJ EEKLJBLGCEC, BNKFGKKGHDJ LMHCCJGCMOF, byte[] GGBNILIIFNK, [Out] int PDCHCFIOJCE, [Out] int IKOBHIGCCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B4DF50", Offset = "0x6B4CD50", VA = "0x186B4DF50")]
	private static bool IBGMHKCHJCA(double ALCIJOKMJPM, DIDIENKKDFL JLLJLOICEHP, byte[] GGBNILIIFNK, [Out] int PDCHCFIOJCE, [Out] int FLGGCDNEGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B4D3A0", Offset = "0x6B4C1A0", VA = "0x186B4D3A0")]
	private static bool CGCMHDKCLIE(double ALCIJOKMJPM, DIDIENKKDFL JLLJLOICEHP, byte[] GGBNILIIFNK, [Out] int PDCHCFIOJCE, [Out] int BHFLKLEAJAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B4E6E0", Offset = "0x6B4D4E0", VA = "0x186B4E6E0")]
	private static bool LDDAOHODKLF(double DIBNBLEEFNN, IBEKBCFNPAM CCGABAKBPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B4DA80", Offset = "0x6B4C880", VA = "0x186B4DA80")]
	private static bool HANKNAIFGAO(double DIBNBLEEFNN, IBEKBCFNPAM CCGABAKBPPC, CJJJHNCFKFC JLLJLOICEHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B4ECC0", Offset = "0x6B4DAC0", VA = "0x186B4ECC0")]
	private static void OAIIGHFAKCA(byte[] AFMLILFPEDI, int PDCHCFIOJCE, int BHFLKLEAJAK, int FGEJJMPOKMI, IBEKBCFNPAM CCGABAKBPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B4E8A0", Offset = "0x6B4D6A0", VA = "0x186B4E8A0")]
	private static void LIKAGACMOHN(byte[] AFMLILFPEDI, int PDCHCFIOJCE, int GJKPCIMBDHH, IBEKBCFNPAM CCGABAKBPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B4D890", Offset = "0x6B4C690", VA = "0x186B4D890")]
	private static bool EIKNIFMNDCA(double ALCIJOKMJPM, CJJJHNCFKFC JLLJLOICEHP, int DHIEOOJGNJF, byte[] BIODAAJEIPN, [Out] bool BADLNCAGEAD, [Out] int PDCHCFIOJCE, [Out] int NJLPKKMGOKN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct FNGNFLLNJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double OIDDJANNCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong DFNDCDAJPBK;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct DEAAPHOLFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float DCIDEDOMNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint GKPNPMHFOHH;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct APEGAPPEMLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong JKGJINJNBEF;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B41AA0", Offset = "0x6B408A0", VA = "0x186B41AA0")]
	public APEGAPPEMLJ(double OIDDJANNCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B41A00", Offset = "0x6B40800", VA = "0x186B41A00")]
	public APEGAPPEMLJ(BNKFGKKGHDJ OIDDJANNCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B418B0", Offset = "0x6B406B0", VA = "0x186B418B0")]
	public BNKFGKKGHDJ LDBCGLBAHDO()
	{
		return default(BNKFGKKGHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B41470", Offset = "0x6B40270", VA = "0x186B41470")]
	public BNKFGKKGHDJ BEDIMNAOEFC()
	{
		return default(BNKFGKKGHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
	public ulong LHKHCAPJKPL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B41630", Offset = "0x6B40430", VA = "0x186B41630")]
	public double EHIHNEJEHOP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B41920", Offset = "0x6B40720", VA = "0x186B41920")]
	public double NLHCACMLDCG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B41600", Offset = "0x6B40400", VA = "0x186B41600")]
	public int DGDDGFJFHNE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B414F0", Offset = "0x6B402F0", VA = "0x186B414F0")]
	public ulong BENCDHCNMKO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B41520", Offset = "0x6B40320", VA = "0x186B41520")]
	public bool BHFHKDNKHFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B41890", Offset = "0x6B40690", VA = "0x186B41890")]
	public bool JHFGFLEJPFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B41860", Offset = "0x6B40660", VA = "0x186B41860")]
	public bool JDHKCCJLHNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B41540", Offset = "0x6B40340", VA = "0x186B41540")]
	public bool BHJCNNMANDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B419E0", Offset = "0x6B407E0", VA = "0x186B419E0")]
	public int OIOPOMFPMPP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B41710", Offset = "0x6B40510", VA = "0x186B41710")]
	public void GHCGDMNFDGK([Out] BNKFGKKGHDJ BANGKNILJML, [Out] BNKFGKKGHDJ NNLEDPKNPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B416C0", Offset = "0x6B404C0", VA = "0x186B416C0")]
	public bool GEGOCKDEOKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2E9EA30", Offset = "0x2E9D830", VA = "0x182E9EA30")]
	public double DIBNBLEEFNN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6B419C0", Offset = "0x6B407C0", VA = "0x186B419C0")]
	public static int OHDPIGPGHKB(int LJPKGNEIEIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B416B0", Offset = "0x6B404B0", VA = "0x186B416B0")]
	public static double FLLJNFEOBBL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B41570", Offset = "0x6B40370", VA = "0x186B41570")]
	public static ulong CPONPOFGHNM(BNKFGKKGHDJ BMJPLOAFNHA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct HPAHNHEJLMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint AHKMGENIHFE;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFFE0", Offset = "0x1FCEDE0", VA = "0x181FCFFE0")]
	public HPAHNHEJLMK(float DCIDEDOMNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A500", Offset = "0x6B49300", VA = "0x186B4A500")]
	public BNKFGKKGHDJ LDBCGLBAHDO()
	{
		return default(BNKFGKKGHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0")]
	public uint EEIAKAMNCIF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A370", Offset = "0x6B49170", VA = "0x186B4A370")]
	public int DGDDGFJFHNE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A340", Offset = "0x6B49140", VA = "0x186B4A340")]
	public uint BENCDHCNMKO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A360", Offset = "0x6B49160", VA = "0x186B4A360")]
	public bool BHFHKDNKHFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A3D0", Offset = "0x6B491D0", VA = "0x186B4A3D0")]
	public void GHCGDMNFDGK([Out] BNKFGKKGHDJ BANGKNILJML, [Out] BNKFGKKGHDJ NNLEDPKNPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A390", Offset = "0x6B49190", VA = "0x186B4A390")]
	public bool GEGOCKDEOKG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct KPBHNICIKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong PJDCCGAAEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short OGHJPJBKAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short FLGGCDNEGOP;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B4FA30", Offset = "0x6B4E830", VA = "0x186B4FA30")]
	public KPBHNICIKPI(ulong PJDCCGAAEAE, short OGHJPJBKAGP, short FLGGCDNEGOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class EBFEIOJEDOA
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly KPBHNICIKPI[] IHGKCIHJHPP;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B45500", Offset = "0x6B44300", VA = "0x186B45500")]
	public static void LOEFPHPKEOP(int OJLEGOILABG, int JGIIIPLIEKE, [Out] BNKFGKKGHDJ BHMNOELAIEO, [Out] int FLGGCDNEGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B45430", Offset = "0x6B44230", VA = "0x186B45430")]
	public static void FFPKKLOIIEM(int EMIOCBIKJKC, [Out] BNKFGKKGHDJ BHMNOELAIEO, [Out] int BPKIGENCLJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct LPMGBOLMPLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] KKAMOMBNLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int GJACDHHHCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int DBMCJHFBIKF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6B52770", Offset = "0x6B51570", VA = "0x186B52770")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F640", Offset = "0x3C3E440", VA = "0x183C3F640")]
	public LPMGBOLMPLA(byte[] KKAMOMBNLOJ, int GJACDHHHCDB, int PDCHCFIOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2014900", Offset = "0x2013700", VA = "0x182014900")]
	public int PDCHCFIOJCE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B527B0", Offset = "0x6B515B0", VA = "0x186B527B0")]
	public LPMGBOLMPLA MNELDMEEIBN(int FEAFHENKEAJ, int CALLEFILHJM)
	{
		return default(LPMGBOLMPLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class LDPDELGDODB
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] JGKBPBMHAMK;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] NJFIMIKFKIJ;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int DBHGCHDFFFL;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B51460", Offset = "0x6B50260", VA = "0x186B51460")]
	private static byte[] NMHCFGLBPNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B51540", Offset = "0x6B50340", VA = "0x186B51540")]
	private static LPMGBOLMPLA OHHADHHGPNB(LPMGBOLMPLA GGBNILIIFNK)
	{
		return default(LPMGBOLMPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B51380", Offset = "0x6B50180", VA = "0x186B51380")]
	private static LPMGBOLMPLA MLPDFEDHLBO(LPMGBOLMPLA GGBNILIIFNK)
	{
		return default(LPMGBOLMPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B50C20", Offset = "0x6B4FA20", VA = "0x186B50C20")]
	private static void HKMLCKFPPDD(LPMGBOLMPLA GGBNILIIFNK, int GJKPCIMBDHH, byte[] CADGMMJLBKF, [Out] int NDGOLDOHNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B4FD70", Offset = "0x6B4EB70", VA = "0x186B4FD70")]
	private static void CFOKBNMDFJE(LPMGBOLMPLA GGBNILIIFNK, int GJKPCIMBDHH, byte[] JCBBOHDCLNN, int MLCLMILADLL, [Out] LPMGBOLMPLA LPNLGGELPPN, [Out] int BDJFNPPEBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B50060", Offset = "0x6B4EE60", VA = "0x186B50060")]
	private static ulong DFLDOHNHINC(LPMGBOLMPLA GGBNILIIFNK, [Out] int MDHHGMLBAIG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B51240", Offset = "0x6B50040", VA = "0x186B51240")]
	private static void MICEBKHLJCD(LPMGBOLMPLA GGBNILIIFNK, [Out] BNKFGKKGHDJ FJMMLPMLLGC, [Out] int PNDNFCFMMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B50860", Offset = "0x6B4F660", VA = "0x186B50860")]
	private static bool FMAAHNHOJHJ(LPMGBOLMPLA LPNLGGELPPN, int GJKPCIMBDHH, [Out] double FJMMLPMLLGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B50CB0", Offset = "0x6B4FAB0", VA = "0x186B50CB0")]
	private static BNKFGKKGHDJ IACMLACOFPE(int GJKPCIMBDHH)
	{
		return default(BNKFGKKGHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B50210", Offset = "0x6B4F010", VA = "0x186B50210")]
	private static bool FJCMEDMOGGJ(LPMGBOLMPLA GGBNILIIFNK, int GJKPCIMBDHH, [Out] double FJMMLPMLLGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B500F0", Offset = "0x6B4EEF0", VA = "0x186B500F0")]
	private static bool DMCACHDONMD(LPMGBOLMPLA LPNLGGELPPN, int GJKPCIMBDHH, [Out] double IMLEIFGINAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B51120", Offset = "0x6B4FF20", VA = "0x186B51120")]
	public static double? LJFKNGEDHCN(LPMGBOLMPLA GGBNILIIFNK, int GJKPCIMBDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B50E50", Offset = "0x6B4FC50", VA = "0x186B50E50")]
	public static float? LCFLGKPLNOI(LPMGBOLMPLA GGBNILIIFNK, int GJKPCIMBDHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct IFCILAGKOMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] GGBNILIIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int PJPGJICIKPG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B4A920", Offset = "0x6B49720", VA = "0x186B4A920")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x18EBE50", Offset = "0x18EAC50", VA = "0x1818EBE50")]
	public IFCILAGKOMM(byte[] GGBNILIIFNK, int PJPGJICIKPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A910", Offset = "0x6B49710", VA = "0x186B4A910")]
	public static IFCILAGKOMM HCFPBGMMFKO(IFCILAGKOMM ILACEKALGJH)
	{
		return default(IFCILAGKOMM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A990", Offset = "0x6B49790", VA = "0x186B4A990")]
	public static IFCILAGKOMM MDKBEJFMOHK(IFCILAGKOMM ILACEKALGJH, int PDCHCFIOJCE)
	{
		return default(IFCILAGKOMM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A950", Offset = "0x6B49750", VA = "0x186B4A950")]
	public static int JJLLPGIMNIC(IFCILAGKOMM MAEINFGKCEL, IFCILAGKOMM FLBFHNBPNFN)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B4AA40", Offset = "0x6B49840", VA = "0x186B4AA40")]
	public static bool OFKPFEHPLBH(IFCILAGKOMM MAEINFGKCEL, IFCILAGKOMM FLBFHNBPNFN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A8D0", Offset = "0x6B496D0", VA = "0x186B4A8D0")]
	public static bool CAAJBKCJNPA(IFCILAGKOMM MAEINFGKCEL, IFCILAGKOMM FLBFHNBPNFN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B4AA10", Offset = "0x6B49810", VA = "0x186B4AA10")]
	public static bool OFKPFEHPLBH(IFCILAGKOMM MAEINFGKCEL, char FLBFHNBPNFN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A8E0", Offset = "0x6B496E0", VA = "0x186B4A8E0")]
	public static bool CAAJBKCJNPA(IFCILAGKOMM MAEINFGKCEL, char FLBFHNBPNFN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A8E0", Offset = "0x6B496E0", VA = "0x186B4A8E0")]
	public static bool CAAJBKCJNPA(IFCILAGKOMM MAEINFGKCEL, byte FLBFHNBPNFN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A960", Offset = "0x6B49760", VA = "0x186B4A960")]
	public static bool KKGOMPLFEFI(IFCILAGKOMM MAEINFGKCEL, char FLBFHNBPNFN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A9E0", Offset = "0x6B497E0", VA = "0x186B4A9E0")]
	public static bool NCBFOPPKJJH(IFCILAGKOMM MAEINFGKCEL, char FLBFHNBPNFN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A870", Offset = "0x6B49670", VA = "0x186B4A870")]
	public static bool AFAJILKDGGA(IFCILAGKOMM MAEINFGKCEL, char FLBFHNBPNFN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B4A8A0", Offset = "0x6B496A0", VA = "0x186B4A8A0")]
	public static bool BJFDHOHLHLK(IFCILAGKOMM MAEINFGKCEL, char FLBFHNBPNFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class NEECKENMAJJ
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] CGOOBOMLBOK;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] OCOGBPDDBCH;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] NICHHNFHAGH;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] PKNCHGOPGGO;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] NPCFPEDGCJC;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int AEJIPIKAFPN;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] LCJHNKIENCM;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int DBGGDHFCGPJ;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B52AF0", Offset = "0x6B518F0", VA = "0x186B52AF0")]
	private static byte[] KCJMIOPEJKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B53E10", Offset = "0x6B52C10", VA = "0x186B53E10")]
	private static byte[] PLFONNDKHEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B52990", Offset = "0x6B51790", VA = "0x186B52990")]
	public static double ECENCEFIKBC(byte[] GGBNILIIFNK, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B52A40", Offset = "0x6B51840", VA = "0x186B52A40")]
	public static float KBOBOKENCMG(byte[] GGBNILIIFNK, int PJPGJICIKPG, [Out] int JNEEFNIOFMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B52860", Offset = "0x6B51660", VA = "0x186B52860")]
	private static bool DBFDEJKJNLK(int FCLAAGLFIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B53C30", Offset = "0x6B52A30", VA = "0x186B53C30")]
	private static bool NFFNDIGDHGO(IFCILAGKOMM COAMIPFEHEA, IFCILAGKOMM NFJLMFFPDDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B53B60", Offset = "0x6B52960", VA = "0x186B53B60")]
	private static bool MHKDOBLACCJ(IFCILAGKOMM COAMIPFEHEA, IFCILAGKOMM NFJLMFFPDDM, byte[] CDGOMGJHKCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B52810", Offset = "0x6B51610", VA = "0x186B52810")]
	private static bool BHICENIHMAP(IFCILAGKOMM IHBPIJFDMPJ, byte[] INOMBDBKIKO, int PJPGJICIKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6B53EF0", Offset = "0x6B52CF0", VA = "0x186B53EF0")]
	private static double PMDFNHCKKGL(bool BADLNCAGEAD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B52BD0", Offset = "0x6B519D0", VA = "0x186B52BD0")]
	private static double KHKMGIDOGPM(IFCILAGKOMM PGOKJJEIBMC, int PDCHCFIOJCE, bool GKHIAINFCAL, [Out] int ANCMLGOOMJB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class GAHOILFJCCI<T> : GADLOFCICAN<T[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly FAEDAFFIODI<T> BFGHJGHFGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly GJOCIAENDBJ JHDNCMHJPPF;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x38F78E0", Offset = "0x38F66E0", VA = "0x1838F78E0")]
	public GAHOILFJCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
	public GAHOILFJCCI(GJOCIAENDBJ JHDNCMHJPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x38F7580", Offset = "0x38F6380", VA = "0x1838F7580", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x38F71D0", Offset = "0x38F5FD0", VA = "0x1838F71D0", Slot = "5")]
	public T[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class EMMNJNMGPLG<T> : GADLOFCICAN<ArraySegment<T>>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly FAEDAFFIODI<T> BFGHJGHFGMN;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x34C32E0", Offset = "0x34C20E0", VA = "0x1834C32E0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ArraySegment<T> DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x34C2EE0", Offset = "0x34C1CE0", VA = "0x1834C2EE0", Slot = "5")]
	public ArraySegment<T> FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class DLICFIIOCBL<T> : GADLOFCICAN<List<T>>, DMCDFIKKPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly GJOCIAENDBJ JHDNCMHJPPF;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x38F78E0", Offset = "0x38F66E0", VA = "0x1838F78E0")]
	public DLICFIIOCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
	public DLICFIIOCBL(GJOCIAENDBJ JHDNCMHJPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x515BF20", Offset = "0x515AD20", VA = "0x18515BF20", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, List<T> DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5159CC0", Offset = "0x5158AC0", VA = "0x185159CC0", Slot = "5")]
	public List<T> FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class MFNMHDAJAAA<TElement, TIntermediate, TEnumerator, TCollection> : GADLOFCICAN<TCollection>, DMCDFIKKPEH where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3F8A360", Offset = "0x3F89160", VA = "0x183F8A360", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, TCollection DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3F88B70", Offset = "0x3F87970", VA = "0x183F88B70", Slot = "5")]
	public TCollection FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DJAPJEMLEHI(TCollection PFNKIIMPMKG);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate ANGJMEBBFOG();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HDCMKJKDALC(TIntermediate EAMMFGNDJAM, int AELAKOMEEDP, TElement DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection AFNFFFKBJBI(TIntermediate OPHJCLCOPLP);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected MFNMHDAJAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class KNMKLMLHMMH<TElement, TIntermediate, TCollection> : MFNMHDAJAAA<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FA30", Offset = "0x3D2E830", VA = "0x183D2FA30", Slot = "6")]
	protected override IEnumerator<TElement> DJAPJEMLEHI(TCollection PFNKIIMPMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3458490", Offset = "0x3457290", VA = "0x183458490")]
	protected KNMKLMLHMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class DLDDBHJMKOG<TElement, TCollection> : KNMKLMLHMMH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected sealed override TCollection AFNFFFKBJBI(TCollection OPHJCLCOPLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class HMDOBNHOJFE<TElement, TCollection> : DLDDBHJMKOG<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x39CDD20", Offset = "0x39CCB20", VA = "0x1839CDD20", Slot = "7")]
	protected override TCollection ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x39CDD40", Offset = "0x39CCB40", VA = "0x1839CDD40", Slot = "8")]
	protected override void HDCMKJKDALC(TCollection EAMMFGNDJAM, int AELAKOMEEDP, TElement DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class PPDJPBLFMMK<T> : MFNMHDAJAAA<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x394C7E0", Offset = "0x394B5E0", VA = "0x18394C7E0", Slot = "8")]
	protected override void HDCMKJKDALC(LinkedList<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override LinkedList<T> AFNFFFKBJBI(LinkedList<T> OPHJCLCOPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override LinkedList<T> ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3A84210", Offset = "0x3A83010", VA = "0x183A84210", Slot = "6")]
	protected override LinkedList<T>.Enumerator DJAPJEMLEHI(LinkedList<T> PFNKIIMPMKG)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class IJOOEILFBLJ<T> : MFNMHDAJAAA<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x394C7E0", Offset = "0x394B5E0", VA = "0x18394C7E0", Slot = "8")]
	protected override void HDCMKJKDALC(Queue<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override Queue<T> ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x394C780", Offset = "0x394B580", VA = "0x18394C780", Slot = "6")]
	protected override Queue<T>.Enumerator DJAPJEMLEHI(Queue<T> PFNKIIMPMKG)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override Queue<T> AFNFFFKBJBI(Queue<T> OPHJCLCOPLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class JFOICLAFJKG<T> : MFNMHDAJAAA<T, IMNMGFAPOLP<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3C20150", Offset = "0x3C1EF50", VA = "0x183C20150", Slot = "8")]
	protected override void HDCMKJKDALC(IMNMGFAPOLP<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3C200C0", Offset = "0x3C1EEC0", VA = "0x183C200C0", Slot = "7")]
	protected override IMNMGFAPOLP<T> ANGJMEBBFOG()
	{
		return default(IMNMGFAPOLP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3C200F0", Offset = "0x3C1EEF0", VA = "0x183C200F0", Slot = "6")]
	protected override Stack<T>.Enumerator DJAPJEMLEHI(Stack<T> PFNKIIMPMKG)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1FFE0", Offset = "0x3C1EDE0", VA = "0x183C1FFE0", Slot = "9")]
	protected override Stack<T> AFNFFFKBJBI(IMNMGFAPOLP<T> OPHJCLCOPLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class GJEJINHFNMN<T> : MFNMHDAJAAA<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x394C7E0", Offset = "0x394B5E0", VA = "0x18394C7E0", Slot = "8")]
	protected override void HDCMKJKDALC(HashSet<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override HashSet<T> AFNFFFKBJBI(HashSet<T> OPHJCLCOPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override HashSet<T> ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x394C780", Offset = "0x394B580", VA = "0x18394C780", Slot = "6")]
	protected override HashSet<T>.Enumerator DJAPJEMLEHI(HashSet<T> PFNKIIMPMKG)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class PPNCCEILJHJ<T> : KNMKLMLHMMH<T, IMNMGFAPOLP<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3C20150", Offset = "0x3C1EF50", VA = "0x183C20150", Slot = "8")]
	protected override void HDCMKJKDALC(IMNMGFAPOLP<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x42417C0", Offset = "0x42405C0", VA = "0x1842417C0", Slot = "9")]
	protected override ReadOnlyCollection<T> AFNFFFKBJBI(IMNMGFAPOLP<T> OPHJCLCOPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x4241850", Offset = "0x4240650", VA = "0x184241850", Slot = "7")]
	protected override IMNMGFAPOLP<T> ANGJMEBBFOG()
	{
		return default(IMNMGFAPOLP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class JMHOOFKCMPM<T> : KNMKLMLHMMH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x394C7E0", Offset = "0x394B5E0", VA = "0x18394C7E0", Slot = "8")]
	protected override void HDCMKJKDALC(List<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override List<T> ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override IList<T> AFNFFFKBJBI(List<T> OPHJCLCOPLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class KBBAMFGBEGN<T> : KNMKLMLHMMH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x394C7E0", Offset = "0x394B5E0", VA = "0x18394C7E0", Slot = "8")]
	protected override void HDCMKJKDALC(List<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override List<T> ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override ICollection<T> AFNFFFKBJBI(List<T> OPHJCLCOPLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class CHHFIFIAPAI<T> : KNMKLMLHMMH<T, IMNMGFAPOLP<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3C20150", Offset = "0x3C1EF50", VA = "0x183C20150", Slot = "8")]
	protected override void HDCMKJKDALC(IMNMGFAPOLP<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3C200C0", Offset = "0x3C1EEC0", VA = "0x183C200C0", Slot = "7")]
	protected override IMNMGFAPOLP<T> ANGJMEBBFOG()
	{
		return default(IMNMGFAPOLP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4D22570", Offset = "0x4D21370", VA = "0x184D22570", Slot = "9")]
	protected override IEnumerable<T> AFNFFFKBJBI(IMNMGFAPOLP<T> OPHJCLCOPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3466190", Offset = "0x3464F90", VA = "0x183466190")]
	public CHHFIFIAPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class HHLEOBCJNLJ<TKey, TElement> : GADLOFCICAN<IGrouping<TKey, TElement>>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x39C1B90", Offset = "0x39C0990", VA = "0x1839C1B90", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, IGrouping<TKey, TElement> DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x39C18A0", Offset = "0x39C06A0", VA = "0x1839C18A0", Slot = "5")]
	public IGrouping<TKey, TElement> FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class KDHLIFPHGBP<TKey, TElement> : GADLOFCICAN<ILookup<TKey, TElement>>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2250", Offset = "0x3CE1050", VA = "0x183CE2250", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ILookup<TKey, TElement> DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1F30", Offset = "0x3CE0D30", VA = "0x183CE1F30", Slot = "5")]
	public ILookup<TKey, TElement> FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class GCMBNEHPOJC<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey OBPLDLNDJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> LAIKHCJLDKC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey AAPIPDGMADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
	public GCMBNEHPOJC(TKey OBPLDLNDJLE, IEnumerable<TElement> LAIKHCJLDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x38FEB80", Offset = "0x38FD980", VA = "0x1838FEB80", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3510190", Offset = "0x350EF90", VA = "0x183510190", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class NPIFJCDBEHO<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> JEBGMCNGPBH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3852B80", Offset = "0x3851980", VA = "0x183852B80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public NPIFJCDBEHO(Dictionary<TKey, IGrouping<TKey, TElement>> JEBGMCNGPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x4053A60", Offset = "0x4052860", VA = "0x184053A60", Slot = "5")]
	public bool Contains(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x4053AA0", Offset = "0x40528A0", VA = "0x184053AA0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4053AA0", Offset = "0x40528A0", VA = "0x184053AA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class NBIBFGFIBKM<T> : GADLOFCICAN<T>, DMCDFIKKPEH where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2FA0", Offset = "0x3FF1DA0", VA = "0x183FF2FA0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2D30", Offset = "0x3FF1B30", VA = "0x183FF2D30", Slot = "5")]
	public T FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NBIBFGFIBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class BPMNFNLEONF : GADLOFCICAN<IEnumerable>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly GADLOFCICAN<IEnumerable> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6B585C0", Offset = "0x6B573C0", VA = "0x186B585C0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, IEnumerable DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6B58370", Offset = "0x6B57170", VA = "0x186B58370", Slot = "5")]
	public IEnumerable FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public BPMNFNLEONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class GGJJEGBACOC : GADLOFCICAN<ICollection>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly GADLOFCICAN<ICollection> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C820", Offset = "0x6B5B620", VA = "0x186B5C820", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ICollection DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C5D0", Offset = "0x6B5B3D0", VA = "0x186B5C5D0", Slot = "5")]
	public ICollection FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GGJJEGBACOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class MJKOPKGGNMN : GADLOFCICAN<IList>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly GADLOFCICAN<IList> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6B65F60", Offset = "0x6B64D60", VA = "0x186B65F60", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, IList DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6B65D10", Offset = "0x6B64B10", VA = "0x186B65D10", Slot = "5")]
	public IList FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MJKOPKGGNMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NDONGPKNNJD<T> : KNMKLMLHMMH<T, IMNMGFAPOLP<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x4016500", Offset = "0x4015300", VA = "0x184016500", Slot = "8")]
	protected override void HDCMKJKDALC(IMNMGFAPOLP<T> EAMMFGNDJAM, int AELAKOMEEDP, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3C200C0", Offset = "0x3C1EEC0", VA = "0x183C200C0", Slot = "7")]
	protected override IMNMGFAPOLP<T> ANGJMEBBFOG()
	{
		return default(IMNMGFAPOLP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4016490", Offset = "0x4015290", VA = "0x184016490", Slot = "9")]
	protected override IReadOnlyList<T> AFNFFFKBJBI(IMNMGFAPOLP<T> OPHJCLCOPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x3465B60", Offset = "0x3464960", VA = "0x183465B60")]
	public NDONGPKNNJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class PEELFNCIAKL
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6B68E60", Offset = "0x6B67C60", VA = "0x186B68E60")]
	public static DateTime HAPICMPGAEI(DateTime MPABHNEAILG)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class MGIAANENKHH : GADLOFCICAN<DateTime>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly GADLOFCICAN<DateTime> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6B654F0", Offset = "0x6B642F0", VA = "0x186B654F0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, DateTime DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6B647E0", Offset = "0x6B635E0", VA = "0x186B647E0", Slot = "5")]
	public DateTime FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MGIAANENKHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class KFIPIJKHBGP : GADLOFCICAN<DateTimeOffset>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly GADLOFCICAN<DateTimeOffset> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6B60B40", Offset = "0x6B5F940", VA = "0x186B60B40", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, DateTimeOffset DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FF20", Offset = "0x6B5ED20", VA = "0x186B5FF20", Slot = "5")]
	public DateTimeOffset FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public KFIPIJKHBGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class PAOOCPPONGO : GADLOFCICAN<TimeSpan>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly GADLOFCICAN<TimeSpan> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] BMFALMEONLO;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6B686E0", Offset = "0x6B674E0", VA = "0x186B686E0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, TimeSpan DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6B67DD0", Offset = "0x6B66BD0", VA = "0x186B67DD0", Slot = "5")]
	public TimeSpan FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public PAOOCPPONGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class NLLCONFOLFM<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : GADLOFCICAN<TDictionary>, DMCDFIKKPEH where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x4046E60", Offset = "0x4045C60", VA = "0x184046E60", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, TDictionary DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4043B00", Offset = "0x4042900", VA = "0x184043B00", Slot = "5")]
	public TDictionary FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DJAPJEMLEHI(TDictionary PFNKIIMPMKG);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate ANGJMEBBFOG();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HDCMKJKDALC(TIntermediate EAMMFGNDJAM, int AELAKOMEEDP, TKey OBPLDLNDJLE, TValue DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary AFNFFFKBJBI(TIntermediate OPHJCLCOPLP);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected NLLCONFOLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class PEKAHKAMBNJ<TKey, TValue, TIntermediate, TDictionary> : NLLCONFOLFM<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FA30", Offset = "0x3D2E830", VA = "0x183D2FA30", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> DJAPJEMLEHI(TDictionary PFNKIIMPMKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class CKMJAGNKJKB<TKey, TValue, TDictionary> : PEKAHKAMBNJ<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override TDictionary AFNFFFKBJBI(TDictionary OPHJCLCOPLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class IIJLGMGKGCK<TKey, TValue> : NLLCONFOLFM<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3A84420", Offset = "0x3A83220", VA = "0x183A84420", Slot = "8")]
	protected override void HDCMKJKDALC(Dictionary<TKey, TValue> EAMMFGNDJAM, int AELAKOMEEDP, TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override Dictionary<TKey, TValue> AFNFFFKBJBI(Dictionary<TKey, TValue> OPHJCLCOPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override Dictionary<TKey, TValue> ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3A84270", Offset = "0x3A83070", VA = "0x183A84270", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator DJAPJEMLEHI(Dictionary<TKey, TValue> PFNKIIMPMKG)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3457790", Offset = "0x3456590", VA = "0x183457790")]
	public IIJLGMGKGCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class OECMECNCPPG<TKey, TValue, TDictionary> : CKMJAGNKJKB<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x4106850", Offset = "0x4105650", VA = "0x184106850", Slot = "8")]
	protected override void HDCMKJKDALC(TDictionary EAMMFGNDJAM, int AELAKOMEEDP, TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x327AA20", Offset = "0x3279820", VA = "0x18327AA20", Slot = "7")]
	protected override TDictionary ANGJMEBBFOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class NEHJCIOJLGM<TKey, TValue> : PEKAHKAMBNJ<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x39B1F00", Offset = "0x39B0D00", VA = "0x1839B1F00", Slot = "8")]
	protected override void HDCMKJKDALC(Dictionary<TKey, TValue> EAMMFGNDJAM, int AELAKOMEEDP, TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override Dictionary<TKey, TValue> ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override IDictionary<TKey, TValue> AFNFFFKBJBI(Dictionary<TKey, TValue> OPHJCLCOPLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class HCIDFEAMJMF<TKey, TValue> : CKMJAGNKJKB<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x39B1F00", Offset = "0x39B0D00", VA = "0x1839B1F00", Slot = "8")]
	protected override void HDCMKJKDALC(SortedList<TKey, TValue> EAMMFGNDJAM, int AELAKOMEEDP, TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override SortedList<TKey, TValue> ANGJMEBBFOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class CKDPCECKIOB<TKey, TValue> : NLLCONFOLFM<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x39B1F00", Offset = "0x39B0D00", VA = "0x1839B1F00", Slot = "8")]
	protected override void HDCMKJKDALC(SortedDictionary<TKey, TValue> EAMMFGNDJAM, int AELAKOMEEDP, TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> AFNFFFKBJBI(SortedDictionary<TKey, TValue> OPHJCLCOPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x394C710", Offset = "0x394B510", VA = "0x18394C710", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> ANGJMEBBFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3A84340", Offset = "0x3A83140", VA = "0x183A84340", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator DJAPJEMLEHI(SortedDictionary<TKey, TValue> PFNKIIMPMKG)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class NEKBEBGNHHE<T> : GADLOFCICAN<T>, DMCDFIKKPEH where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x4019C10", Offset = "0x4018A10", VA = "0x184019C10", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x4019970", Offset = "0x4018770", VA = "0x184019970", Slot = "5")]
	public T FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NEKBEBGNHHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class NEJMBKFKAKH : GADLOFCICAN<IDictionary>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly GADLOFCICAN<IDictionary> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6B66F10", Offset = "0x6B65D10", VA = "0x186B66F10", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, IDictionary DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6B66CE0", Offset = "0x6B65AE0", VA = "0x186B66CE0", Slot = "5")]
	public IDictionary FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NEJMBKFKAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class GLCEIEPEBFP : GADLOFCICAN<object>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void CIPAAJEEIGO(object BKKLDFLKNPD, CDEIOEGMOCO DFHABBFDBND, object DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly NGDBOPCBONO<KeyValuePair<object, CIPAAJEEIGO>> LNJHEBCPKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly BHPKKFEEGEC[] OKGDDLOONDD;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6B5DC10", Offset = "0x6B5CA10", VA = "0x186B5DC10")]
	public GLCEIEPEBFP(params BHPKKFEEGEC[] OKGDDLOONDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D240", Offset = "0x6B5C040", VA = "0x186B5D240", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, object DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D1B0", Offset = "0x6B5BFB0", VA = "0x186B5D1B0", Slot = "5")]
	public object FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class FDKOEKPIAPA
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A890", Offset = "0x6B59690", VA = "0x186B5A890")]
	public static object LCFHHEIJNLF(Type DDEINLAGLLL, [Out] bool MILIBFBKLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B120", Offset = "0x6B59F20", VA = "0x186B5B120")]
	public static object OIBAHLHPAPL(Type DDEINLAGLLL, [Out] bool MILIBFBKLNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class JOACPJEPCNJ<T> : GADLOFCICAN<T>, DMCDFIKKPEH, ALDOCCHDDIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class AOFPDPIIEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AOFPDPIIEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3924AF0", Offset = "0x39238F0", VA = "0x183924AF0")]
		internal bool MNPEJEOOAFF(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class APFNAECCHIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public APFNAECCHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x3925630", Offset = "0x3924430", VA = "0x183925630")]
		internal bool CKHJNNHDGCD(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class AGNPDFIKIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public FLCCHIECBOA<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AGNPDFIKIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x390D790", Offset = "0x390C590", VA = "0x18390D790")]
		internal void JPBKFIOANHI(CDEIOEGMOCO writer, T value, BHPKKFEEGEC _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class HKAPADANMFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public APOIHKLIHJK<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HKAPADANMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x39C9210", Offset = "0x39C8010", VA = "0x1839C9210")]
		internal T KLNKCMCADGP(FHJFMOGBEPJ reader, BHPKKFEEGEC _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly CFPLPDKJBHA<T> BLDMFDNAAHB;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> BOODIIALJGG;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly FLCCHIECBOA<T> FKGABCGAEKN;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly APOIHKLIHJK<T> DHEHHMBGFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool MFKEINNGOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly FLCCHIECBOA<T> KKHEAADLANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly APOIHKLIHJK<T> DEPHHBGKDGK;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3C64A60", Offset = "0x3C63860", VA = "0x183C64A60")]
	static JOACPJEPCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3C85150", Offset = "0x3C83F50", VA = "0x183C85150")]
	public JOACPJEPCNJ(bool MFKEINNGOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3C60800", Offset = "0x3C5F600", VA = "0x183C60800", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A650", Offset = "0x3C59450", VA = "0x183C5A650", Slot = "5")]
	public T FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3C5C380", Offset = "0x3C5B180", VA = "0x183C5C380", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, T DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FA60", Offset = "0x3C5E860", VA = "0x183C5FA60", Slot = "7")]
	public T HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class LMALBIKANLO<T> : GADLOFCICAN<T[,]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA180", Offset = "0x3DC8F80", VA = "0x183DCA180", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T[,] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9E70", Offset = "0x3DC8C70", VA = "0x183DC9E70", Slot = "5")]
	public T[,] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LMALBIKANLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class NHBKAKOGJIP<T> : GADLOFCICAN<T[,,]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4025A20", Offset = "0x4024820", VA = "0x184025A20", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T[,,] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4025610", Offset = "0x4024410", VA = "0x184025610", Slot = "5")]
	public T[,,] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NHBKAKOGJIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class FFFIPIILNJK<T> : GADLOFCICAN<T[,,,]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3833570", Offset = "0x3832370", VA = "0x183833570", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T[,,,] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3833040", Offset = "0x3831E40", VA = "0x183833040", Slot = "5")]
	public T[,,,] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public FFFIPIILNJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class DEIDCPFFGOP<T> : GADLOFCICAN<T?>, DMCDFIKKPEH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x51393C0", Offset = "0x51381C0", VA = "0x1851393C0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5138EC0", Offset = "0x5137CC0", VA = "0x185138EC0", Slot = "5")]
	public T? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public DEIDCPFFGOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class LOJOIHHGIIE<T> : GADLOFCICAN<T?>, DMCDFIKKPEH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly GADLOFCICAN<T> MLEKCIMOGDK;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public LOJOIHHGIIE(GADLOFCICAN<T> MLEKCIMOGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE250", Offset = "0x3DCD050", VA = "0x183DCE250", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, T? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDE00", Offset = "0x3DCCC00", VA = "0x183DCDE00", Slot = "5")]
	public T? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class JMFNCLKDBOF : GADLOFCICAN<sbyte>, DMCDFIKKPEH, ALDOCCHDDIF<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly JMFNCLKDBOF NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F4E0", Offset = "0x6B5E2E0", VA = "0x186B5F4E0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, sbyte DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F360", Offset = "0x6B5E160", VA = "0x186B5F360", Slot = "5")]
	public sbyte FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F3B0", Offset = "0x6B5E1B0", VA = "0x186B5F3B0", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, sbyte DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F420", Offset = "0x6B5E220", VA = "0x186B5F420", Slot = "7")]
	public sbyte HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public JMFNCLKDBOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class KHENKONLOAB : GADLOFCICAN<sbyte?>, DMCDFIKKPEH, ALDOCCHDDIF<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly KHENKONLOAB NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B614E0", Offset = "0x6B602E0", VA = "0x186B614E0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, sbyte? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B61250", Offset = "0x6B60050", VA = "0x186B61250", Slot = "5")]
	public sbyte? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B61300", Offset = "0x6B60100", VA = "0x186B61300", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, sbyte? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B613C0", Offset = "0x6B601C0", VA = "0x186B613C0", Slot = "7")]
	public sbyte? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public KHENKONLOAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class GJHAJBCHFFN : GADLOFCICAN<sbyte[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly GJHAJBCHFFN NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D010", Offset = "0x6B5BE10", VA = "0x186B5D010", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, sbyte[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5CE80", Offset = "0x6B5BC80", VA = "0x186B5CE80", Slot = "5")]
	public sbyte[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GJHAJBCHFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class KENLIAIEKAL : GADLOFCICAN<short>, DMCDFIKKPEH, ALDOCCHDDIF<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly KENLIAIEKAL NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FE50", Offset = "0x6B5EC50", VA = "0x186B5FE50", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, short DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FCD0", Offset = "0x6B5EAD0", VA = "0x186B5FCD0", Slot = "5")]
	public short FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FD20", Offset = "0x6B5EB20", VA = "0x186B5FD20", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, short DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FD90", Offset = "0x6B5EB90", VA = "0x186B5FD90", Slot = "7")]
	public short HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public KENLIAIEKAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class FLFMLCOADEJ : GADLOFCICAN<short?>, DMCDFIKKPEH, ALDOCCHDDIF<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly FLFMLCOADEJ NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C250", Offset = "0x6B5B050", VA = "0x186B5C250", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, short? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BFC0", Offset = "0x6B5ADC0", VA = "0x186B5BFC0", Slot = "5")]
	public short? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C070", Offset = "0x6B5AE70", VA = "0x186B5C070", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, short? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C130", Offset = "0x6B5AF30", VA = "0x186B5C130", Slot = "7")]
	public short? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public FLFMLCOADEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class IJDLEPCCOGL : GADLOFCICAN<short[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly IJDLEPCCOGL NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B5EC70", Offset = "0x6B5DA70", VA = "0x186B5EC70", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, short[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5EAE0", Offset = "0x6B5D8E0", VA = "0x186B5EAE0", Slot = "5")]
	public short[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public IJDLEPCCOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class PCBBKBBIHDC : GADLOFCICAN<int>, DMCDFIKKPEH, ALDOCCHDDIF<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly PCBBKBBIHDC NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B68D90", Offset = "0x6B67B90", VA = "0x186B68D90", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, int DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B68C10", Offset = "0x6B67A10", VA = "0x186B68C10", Slot = "5")]
	public int FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B68C60", Offset = "0x6B67A60", VA = "0x186B68C60", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, int DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B68CD0", Offset = "0x6B67AD0", VA = "0x186B68CD0", Slot = "7")]
	public int HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public PCBBKBBIHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class FFNAPMAPOCD : GADLOFCICAN<int?>, DMCDFIKKPEH, ALDOCCHDDIF<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly FFNAPMAPOCD NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BC40", Offset = "0x6B5AA40", VA = "0x186B5BC40", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, int? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B9B0", Offset = "0x6B5A7B0", VA = "0x186B5B9B0", Slot = "5")]
	public int? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BA60", Offset = "0x6B5A860", VA = "0x186B5BA60", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, int? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BB20", Offset = "0x6B5A920", VA = "0x186B5BB20", Slot = "7")]
	public int? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public FFNAPMAPOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class OLFGJLLCMHG : GADLOFCICAN<int[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly OLFGJLLCMHG NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B67C30", Offset = "0x6B66A30", VA = "0x186B67C30", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, int[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6B67AA0", Offset = "0x6B668A0", VA = "0x186B67AA0", Slot = "5")]
	public int[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OLFGJLLCMHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GCJECNDLEDC : GADLOFCICAN<long>, DMCDFIKKPEH, ALDOCCHDDIF<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly GCJECNDLEDC NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C500", Offset = "0x6B5B300", VA = "0x186B5C500", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, long DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C380", Offset = "0x6B5B180", VA = "0x186B5C380", Slot = "5")]
	public long FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C3D0", Offset = "0x6B5B1D0", VA = "0x186B5C3D0", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, long DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C440", Offset = "0x6B5B240", VA = "0x186B5C440", Slot = "7")]
	public long HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GCJECNDLEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class LGKLMLDJMLB : GADLOFCICAN<long?>, DMCDFIKKPEH, ALDOCCHDDIF<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly LGKLMLDJMLB NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B624D0", Offset = "0x6B612D0", VA = "0x186B624D0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, long? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B62210", Offset = "0x6B61010", VA = "0x186B62210", Slot = "5")]
	public long? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B622D0", Offset = "0x6B610D0", VA = "0x186B622D0", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, long? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B62390", Offset = "0x6B61190", VA = "0x186B62390", Slot = "7")]
	public long? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LGKLMLDJMLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class HGLNGBLDLDK : GADLOFCICAN<long[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly HGLNGBLDLDK NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E600", Offset = "0x6B5D400", VA = "0x186B5E600", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, long[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E470", Offset = "0x6B5D270", VA = "0x186B5E470", Slot = "5")]
	public long[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public HGLNGBLDLDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class FHOFFABKEBM : GADLOFCICAN<byte>, DMCDFIKKPEH, ALDOCCHDDIF<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly FHOFFABKEBM NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BEF0", Offset = "0x6B5ACF0", VA = "0x186B5BEF0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, byte DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BD70", Offset = "0x6B5AB70", VA = "0x186B5BD70", Slot = "5")]
	public byte FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BDC0", Offset = "0x6B5ABC0", VA = "0x186B5BDC0", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, byte DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BE30", Offset = "0x6B5AC30", VA = "0x186B5BE30", Slot = "7")]
	public byte HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public FHOFFABKEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class NAIDHCOJEGL : GADLOFCICAN<byte?>, DMCDFIKKPEH, ALDOCCHDDIF<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly NAIDHCOJEGL NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B66BB0", Offset = "0x6B659B0", VA = "0x186B66BB0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, byte? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B66920", Offset = "0x6B65720", VA = "0x186B66920", Slot = "5")]
	public byte? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B669D0", Offset = "0x6B657D0", VA = "0x186B669D0", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, byte? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B66A90", Offset = "0x6B65890", VA = "0x186B66A90", Slot = "7")]
	public byte? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NAIDHCOJEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class GICKPBIOMOC : GADLOFCICAN<ushort>, DMCDFIKKPEH, ALDOCCHDDIF<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly GICKPBIOMOC NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6B5CDB0", Offset = "0x6B5BBB0", VA = "0x186B5CDB0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ushort DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6B5CC30", Offset = "0x6B5BA30", VA = "0x186B5CC30", Slot = "5")]
	public ushort FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6B5CC80", Offset = "0x6B5BA80", VA = "0x186B5CC80", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, ushort DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6B5CCF0", Offset = "0x6B5BAF0", VA = "0x186B5CCF0", Slot = "7")]
	public ushort HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GICKPBIOMOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class CELKFCJNHLB : GADLOFCICAN<ushort?>, DMCDFIKKPEH, ALDOCCHDDIF<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly CELKFCJNHLB NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6B59360", Offset = "0x6B58160", VA = "0x186B59360", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ushort? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6B590D0", Offset = "0x6B57ED0", VA = "0x186B590D0", Slot = "5")]
	public ushort? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6B59180", Offset = "0x6B57F80", VA = "0x186B59180", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, ushort? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6B59240", Offset = "0x6B58040", VA = "0x186B59240", Slot = "7")]
	public ushort? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CELKFCJNHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class LOEKLLMACOP : GADLOFCICAN<ushort[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly LOEKLLMACOP NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6B62C70", Offset = "0x6B61A70", VA = "0x186B62C70", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ushort[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6B62AE0", Offset = "0x6B618E0", VA = "0x186B62AE0", Slot = "5")]
	public ushort[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LOEKLLMACOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class CIFNILLPCGF : GADLOFCICAN<uint>, DMCDFIKKPEH, ALDOCCHDDIF<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly CIFNILLPCGF NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6B59610", Offset = "0x6B58410", VA = "0x186B59610", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, uint DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6B59490", Offset = "0x6B58290", VA = "0x186B59490", Slot = "5")]
	public uint FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6B594E0", Offset = "0x6B582E0", VA = "0x186B594E0", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, uint DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6B59550", Offset = "0x6B58350", VA = "0x186B59550", Slot = "7")]
	public uint HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CIFNILLPCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class JPODEBPNBMB : GADLOFCICAN<uint?>, DMCDFIKKPEH, ALDOCCHDDIF<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly JPODEBPNBMB NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F840", Offset = "0x6B5E640", VA = "0x186B5F840", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, uint? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F5B0", Offset = "0x6B5E3B0", VA = "0x186B5F5B0", Slot = "5")]
	public uint? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F660", Offset = "0x6B5E460", VA = "0x186B5F660", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, uint? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F720", Offset = "0x6B5E520", VA = "0x186B5F720", Slot = "7")]
	public uint? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public JPODEBPNBMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class LAILHKOLCHG : GADLOFCICAN<uint[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly LAILHKOLCHG NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6B619B0", Offset = "0x6B607B0", VA = "0x186B619B0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, uint[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6B61820", Offset = "0x6B60620", VA = "0x186B61820", Slot = "5")]
	public uint[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LAILHKOLCHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class NLOMENIBCPA : GADLOFCICAN<ulong>, DMCDFIKKPEH, ALDOCCHDDIF<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly NLOMENIBCPA NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x6B675E0", Offset = "0x6B663E0", VA = "0x186B675E0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ulong DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6B67460", Offset = "0x6B66260", VA = "0x186B67460", Slot = "5")]
	public ulong FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6B674B0", Offset = "0x6B662B0", VA = "0x186B674B0", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, ulong DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6B67520", Offset = "0x6B66320", VA = "0x186B67520", Slot = "7")]
	public ulong HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NLOMENIBCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class OJKNNCDNPCJ : GADLOFCICAN<ulong?>, DMCDFIKKPEH, ALDOCCHDDIF<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly OJKNNCDNPCJ NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6B67970", Offset = "0x6B66770", VA = "0x186B67970", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ulong? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6B676B0", Offset = "0x6B664B0", VA = "0x186B676B0", Slot = "5")]
	public ulong? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6B67770", Offset = "0x6B66570", VA = "0x186B67770", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, ulong? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6B67830", Offset = "0x6B66630", VA = "0x186B67830", Slot = "7")]
	public ulong? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OJKNNCDNPCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class ECLOFKCPGCA : GADLOFCICAN<ulong[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly ECLOFKCPGCA NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A130", Offset = "0x6B58F30", VA = "0x186B5A130", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ulong[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6B59FA0", Offset = "0x6B58DA0", VA = "0x186B59FA0", Slot = "5")]
	public ulong[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public ECLOFKCPGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class AIPBIMMCGPD : GADLOFCICAN<float>, DMCDFIKKPEH, ALDOCCHDDIF<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly AIPBIMMCGPD NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6B57F30", Offset = "0x6B56D30", VA = "0x186B57F30", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, float DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6B57DB0", Offset = "0x6B56BB0", VA = "0x186B57DB0", Slot = "5")]
	public float FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6B57E00", Offset = "0x6B56C00", VA = "0x186B57E00", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, float DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6B57E70", Offset = "0x6B56C70", VA = "0x186B57E70", Slot = "7")]
	public float HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public AIPBIMMCGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class MOAPFNBCNGO : GADLOFCICAN<float?>, DMCDFIKKPEH, ALDOCCHDDIF<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly MOAPFNBCNGO NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6B667F0", Offset = "0x6B655F0", VA = "0x186B667F0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, float? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6B66560", Offset = "0x6B65360", VA = "0x186B66560", Slot = "5")]
	public float? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6B66610", Offset = "0x6B65410", VA = "0x186B66610", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, float? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6B666D0", Offset = "0x6B654D0", VA = "0x186B666D0", Slot = "7")]
	public float? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MOAPFNBCNGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class DEJBNCCGPID : GADLOFCICAN<float[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly DEJBNCCGPID NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6B59BA0", Offset = "0x6B589A0", VA = "0x186B59BA0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, float[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6B59A10", Offset = "0x6B58810", VA = "0x186B59A10", Slot = "5")]
	public float[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public DEJBNCCGPID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class EGLHNMLOOJF : GADLOFCICAN<double>, DMCDFIKKPEH, ALDOCCHDDIF<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly EGLHNMLOOJF NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A7C0", Offset = "0x6B595C0", VA = "0x186B5A7C0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, double DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A640", Offset = "0x6B59440", VA = "0x186B5A640", Slot = "5")]
	public double FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A690", Offset = "0x6B59490", VA = "0x186B5A690", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, double DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A700", Offset = "0x6B59500", VA = "0x186B5A700", Slot = "7")]
	public double HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public EGLHNMLOOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class GMBMFMHFECK : GADLOFCICAN<double?>, DMCDFIKKPEH, ALDOCCHDDIF<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly GMBMFMHFECK NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6B5DF80", Offset = "0x6B5CD80", VA = "0x186B5DF80", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, double? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6B5DCC0", Offset = "0x6B5CAC0", VA = "0x186B5DCC0", Slot = "5")]
	public double? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6B5DD80", Offset = "0x6B5CB80", VA = "0x186B5DD80", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, double? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6B5DE40", Offset = "0x6B5CC40", VA = "0x186B5DE40", Slot = "7")]
	public double? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GMBMFMHFECK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class IGIGONMKPNL : GADLOFCICAN<double[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly IGIGONMKPNL NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E930", Offset = "0x6B5D730", VA = "0x186B5E930", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, double[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E7A0", Offset = "0x6B5D5A0", VA = "0x186B5E7A0", Slot = "5")]
	public double[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public IGIGONMKPNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class DKIMKHFMAOI : GADLOFCICAN<bool>, DMCDFIKKPEH, ALDOCCHDDIF<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly DKIMKHFMAOI NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6B59ED0", Offset = "0x6B58CD0", VA = "0x186B59ED0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, bool DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6B59D50", Offset = "0x6B58B50", VA = "0x186B59D50", Slot = "5")]
	public bool FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6B59DA0", Offset = "0x6B58BA0", VA = "0x186B59DA0", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, bool DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6B59E10", Offset = "0x6B58C10", VA = "0x186B59E10", Slot = "7")]
	public bool HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public DKIMKHFMAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class GOOBMDEIIBD : GADLOFCICAN<bool?>, DMCDFIKKPEH, ALDOCCHDDIF<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly GOOBMDEIIBD NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E340", Offset = "0x6B5D140", VA = "0x186B5E340", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, bool? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E0B0", Offset = "0x6B5CEB0", VA = "0x186B5E0B0", Slot = "5")]
	public bool? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E160", Offset = "0x6B5CF60", VA = "0x186B5E160", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, bool? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E220", Offset = "0x6B5D020", VA = "0x186B5E220", Slot = "7")]
	public bool? HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GOOBMDEIIBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class JDCLNBBBOIC : GADLOFCICAN<bool[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly JDCLNBBBOIC NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6B5EFA0", Offset = "0x6B5DDA0", VA = "0x186B5EFA0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, bool[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6B5EE10", Offset = "0x6B5DC10", VA = "0x186B5EE10", Slot = "5")]
	public bool[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public JDCLNBBBOIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MBKAOAMNPLF : GADLOFCICAN<object>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly GADLOFCICAN<object> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> FALBGDDLEMN;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6B63440", Offset = "0x6B62240", VA = "0x186B63440", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, object DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6B63000", Offset = "0x6B61E00", VA = "0x186B63000", Slot = "5")]
	public object FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MBKAOAMNPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CPKDMFGGCDF : GADLOFCICAN<byte[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly GADLOFCICAN<byte[]> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6B598E0", Offset = "0x6B586E0", VA = "0x186B598E0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, byte[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6B59830", Offset = "0x6B58630", VA = "0x186B59830", Slot = "5")]
	public byte[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CPKDMFGGCDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class MCNLOBEMIMD : GADLOFCICAN<ArraySegment<byte>>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GADLOFCICAN<ArraySegment<byte>> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6B64640", Offset = "0x6B63440", VA = "0x186B64640", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, ArraySegment<byte> DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6B64530", Offset = "0x6B63330", VA = "0x186B64530", Slot = "5")]
	public ArraySegment<byte> FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MCNLOBEMIMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class LLNMBIHIPHL : GADLOFCICAN<string>, DMCDFIKKPEH, ALDOCCHDDIF<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly GADLOFCICAN<string> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6B62A10", Offset = "0x6B61810", VA = "0x186B62A10", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, string DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6B62910", Offset = "0x6B61710", VA = "0x186B62910", Slot = "5")]
	public string FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6B62960", Offset = "0x6B61760", VA = "0x186B62960", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, string DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6B629C0", Offset = "0x6B617C0", VA = "0x186B629C0", Slot = "7")]
	public string HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LLNMBIHIPHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class EENPEIMPMHO : GADLOFCICAN<string[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly EENPEIMPMHO NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A4A0", Offset = "0x6B592A0", VA = "0x186B5A4A0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, string[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A2D0", Offset = "0x6B590D0", VA = "0x186B5A2D0", Slot = "5")]
	public string[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public EENPEIMPMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class AKCHIPPFIDL : GADLOFCICAN<char>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly AKCHIPPFIDL NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6B58070", Offset = "0x6B56E70", VA = "0x186B58070", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, char DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6B58000", Offset = "0x6B56E00", VA = "0x186B58000", Slot = "5")]
	public char FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public AKCHIPPFIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class MLPFNNAENDL : GADLOFCICAN<char?>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly MLPFNNAENDL NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6B663F0", Offset = "0x6B651F0", VA = "0x186B663F0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, char? DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6B662E0", Offset = "0x6B650E0", VA = "0x186B662E0", Slot = "5")]
	public char? FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MLPFNNAENDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class CDPCJGICECD : GADLOFCICAN<char[]>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly CDPCJGICECD NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6B58EB0", Offset = "0x6B57CB0", VA = "0x186B58EB0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, char[] DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6B58CF0", Offset = "0x6B57AF0", VA = "0x186B58CF0", Slot = "5")]
	public char[] FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CDPCJGICECD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class BPOFBPMIPNG : GADLOFCICAN<Guid>, DMCDFIKKPEH, ALDOCCHDDIF<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly GADLOFCICAN<Guid> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6B58B50", Offset = "0x6B57950", VA = "0x186B58B50", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, Guid DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6B588E0", Offset = "0x6B576E0", VA = "0x186B588E0", Slot = "5")]
	public Guid FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6B58970", Offset = "0x6B57770", VA = "0x186B58970", Slot = "6")]
	public void GOIEMPHAINO(CDEIOEGMOCO DFHABBFDBND, Guid DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6B58AB0", Offset = "0x6B578B0", VA = "0x186B58AB0", Slot = "7")]
	public Guid HMDCFDJECMF(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public BPOFBPMIPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class LCNFBLEFKAN : GADLOFCICAN<decimal>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly GADLOFCICAN<decimal> NGIMMBPCNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool HLMOGOALEIO;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x53726A0", Offset = "0x53714A0", VA = "0x1853726A0")]
	public LCNFBLEFKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1876420", Offset = "0x1875220", VA = "0x181876420")]
	public LCNFBLEFKAN(bool HLMOGOALEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6B61FF0", Offset = "0x6B60DF0", VA = "0x186B61FF0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, decimal DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6B61D60", Offset = "0x6B60B60", VA = "0x186B61D60", Slot = "5")]
	public decimal FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class KPJIBNECOOO : GADLOFCICAN<Uri>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly GADLOFCICAN<Uri> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6B616D0", Offset = "0x6B604D0", VA = "0x186B616D0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, Uri DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6B61610", Offset = "0x6B60410", VA = "0x186B61610", Slot = "5")]
	public Uri FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public KPJIBNECOOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class LOJPEOIOJPC : GADLOFCICAN<Version>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly GADLOFCICAN<Version> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6B62ED0", Offset = "0x6B61CD0", VA = "0x186B62ED0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, Version DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6B62E10", Offset = "0x6B61C10", VA = "0x186B62E10", Slot = "5")]
	public Version FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LOJPEOIOJPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class JGLEJGDJGCD<TKey, TValue> : GADLOFCICAN<KeyValuePair<TKey, TValue>>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3C29B00", Offset = "0x3C28900", VA = "0x183C29B00", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, KeyValuePair<TKey, TValue> DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3C297F0", Offset = "0x3C285F0", VA = "0x183C297F0", Slot = "5")]
	public KeyValuePair<TKey, TValue> FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class BFJOJODCHDA : GADLOFCICAN<StringBuilder>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly GADLOFCICAN<StringBuilder> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6B58260", Offset = "0x6B57060", VA = "0x186B58260", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, StringBuilder DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6B581A0", Offset = "0x6B56FA0", VA = "0x186B581A0", Slot = "5")]
	public StringBuilder FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public BFJOJODCHDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class LLMFIBNNGDL : GADLOFCICAN<BitArray>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly GADLOFCICAN<BitArray> NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6B62780", Offset = "0x6B61580", VA = "0x186B62780", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, BitArray DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6B62600", Offset = "0x6B61400", VA = "0x186B62600", Slot = "5")]
	public BitArray FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LLMFIBNNGDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class KDFMOFLFMEG : GADLOFCICAN<Type>, DMCDFIKKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly KDFMOFLFMEG NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex GCFMJLEJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool JNFKNAHHGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool MBOMINKCLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool BPMKNOAEPGH;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FCB0", Offset = "0x6B5EAB0", VA = "0x186B5FCB0")]
	public KDFMOFLFMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6107FA0", Offset = "0x6106DA0", VA = "0x186107FA0")]
	public KDFMOFLFMEG(bool JNFKNAHHGHC, bool MBOMINKCLHF, bool BPMKNOAEPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FAC0", Offset = "0x6B5E8C0", VA = "0x186B5FAC0", Slot = "4")]
	public void JPFDICAGNEF(CDEIOEGMOCO DFHABBFDBND, Type DIBNBLEEFNN, BHPKKFEEGEC OHOIMHKAKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F970", Offset = "0x6B5E770", VA = "0x186B5F970", Slot = "5")]
	public Type FPNHMAJLCHC(FHJFMOGBEPJ HGAPEJGOMLD, BHPKKFEEGEC OHOIMHKAKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class LBMMDLBDLIL
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] PAAIECKMIPN;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly DBHNEIOGFAA APBCFMANNPA;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B61B50", Offset = "0x6B60950", VA = "0x186B61B50")]
	static LBMMDLBDLIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class JJCEKCINDMG
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] NHENBMEJPNJ;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly DBHNEIOGFAA POCIHKBCCEH;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F150", Offset = "0x6B5DF50", VA = "0x186B5F150")]
	static JJCEKCINDMG()
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
