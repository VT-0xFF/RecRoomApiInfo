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
internal static class BGENGPKBBEC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7264CF0", Offset = "0x72638F0", VA = "0x187264CF0")]
	public static bool BDONGAPAHKG(this TypeInfo NCNNODEFPOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class EAKGIEHOOID : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FGFHGOGOBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] JDMCFOPNGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
	public EAKGIEHOOID(Type PNAEOHDFNID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class AEEGMFGLBAN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void CDFDPPKODEP<T>(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T PKJNLJHOELC<T>(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL OMPFDPJMJHN);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NKAPOBPAPKD
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DLJMBCMBIMD<T> : NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FCAPBILFKFE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IKOCBLBDMIC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HPJFNGGJODB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B22B30", Offset = "0x2B21730", VA = "0x182B22B30")]
	public static string GFLFADDCEOI<T>(this DLJMBCMBIMD<T> MDPDLHLOLLL, T GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLJMBCMBIMD<T> GMNOPCIBNEG<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PKLLIKKAAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2CEFFF0", Offset = "0x2CEEBF0", VA = "0x182CEFFF0")]
	public static DLJMBCMBIMD<T> OGLPNIEDIPP<T>(this MODONKLHHGL OMPFDPJMJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x727D8A0", Offset = "0x727C4A0", VA = "0x18727D8A0")]
	public static object LMFEAKEGHDL(this MODONKLHHGL OMPFDPJMJHN, Type NCNNODEFPOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PJODGONMIFJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x727D840", Offset = "0x727C440", VA = "0x18727D840")]
	public PJODGONMIFJ(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KKCIDLEELDC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class JFMLJEININN
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] BKHGNPANPPB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] LHMHIKKJBDG;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72699D0", Offset = "0x72685D0", VA = "0x1872699D0")]
		public static byte[] GEGJGIDDCPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7269A70", Offset = "0x7268670", VA = "0x187269A70")]
		public static char[] JPFKGNOIOPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> FHBHNGAKFHH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] IDHNLJBNBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] HNGDLLNOPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int MANKJHLJMBO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool JKNIDJBNNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x726B830", Offset = "0x726A430", VA = "0x18726B830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x726D3A0", Offset = "0x726BFA0", VA = "0x18726D3A0")]
	public KKCIDLEELDC(byte[] HNGDLLNOPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x726D400", Offset = "0x726C000", VA = "0x18726D400")]
	public KKCIDLEELDC(byte[] HNGDLLNOPEB, int MANKJHLJMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x726C240", Offset = "0x726AE40", VA = "0x18726C240")]
	private AHCBCMBPCED KJKJKNKHEHA(string NBCBLAAHNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x726BA00", Offset = "0x726A600", VA = "0x18726BA00")]
	private AHCBCMBPCED HFHCKAJIGFP(string JIMAFLGJGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x726A980", Offset = "0x7269580", VA = "0x18726A980")]
	public void CAGPJILBNBC(int MANKJHLJMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
	public byte[] IDOFBFIDNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0")]
	public int LKPJOKJIENA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x726BAF0", Offset = "0x726A6F0", VA = "0x18726BAF0")]
	public AGHDMKLGNNG HGBNNJKDDEN()
	{
		return default(AGHDMKLGNNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x726C110", Offset = "0x726AD10", VA = "0x18726C110")]
	public void KFKJFBMMIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x726CDF0", Offset = "0x726B9F0", VA = "0x18726CDF0")]
	public bool NPCNBLNKCHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x726C7A0", Offset = "0x726B3A0", VA = "0x18726C7A0")]
	public bool LEHCEGDFEHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x726C070", Offset = "0x726AC70", VA = "0x18726C070")]
	public void KECHMHKMAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x726CAD0", Offset = "0x726B6D0", VA = "0x18726CAD0")]
	public bool NABPDNONJLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x726D100", Offset = "0x726BD00", VA = "0x18726D100")]
	public bool PKJNDGDKLEB(int HDFABDCMCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x726ACD0", Offset = "0x72698D0", VA = "0x18726ACD0")]
	public bool DDPBHBLEIAG(int HDFABDCMCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x726B970", Offset = "0x726A570", VA = "0x18726B970")]
	public bool HFEGDCGPHKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x726A610", Offset = "0x7269210", VA = "0x18726A610")]
	public void BHJIBPJGFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x726C8B0", Offset = "0x726B4B0", VA = "0x18726C8B0")]
	public bool LFPEOCBPBEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x726AA60", Offset = "0x7269660", VA = "0x18726AA60")]
	public bool CKNKPIIMEMP(int HDFABDCMCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x726A990", Offset = "0x7269590", VA = "0x18726A990")]
	public bool CEPLNCECEJO(int HDFABDCMCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x726D070", Offset = "0x726BC70", VA = "0x18726D070")]
	public bool PKFMMLLEIOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x726B790", Offset = "0x726A390", VA = "0x18726B790")]
	public void FJGCHNCAAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x726C940", Offset = "0x726B540", VA = "0x18726C940")]
	public bool LHMHBOIKBBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x726AB30", Offset = "0x7269730", VA = "0x18726AB30")]
	public void CNLONBALNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x726ADA0", Offset = "0x72699A0", VA = "0x18726ADA0")]
	private void EBGIJIOGMEI([Out] byte[] JEGAHKDBGGM, [Out] int HOBFMOLEJHD, [Out] int OEPGEOLNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x726D1D0", Offset = "0x726BDD0", VA = "0x18726D1D0")]
	private static int PLBEDBOJCMK(char NABHBOMGBNH, char EIKHFLMLKJH, char PIIKINJOJMJ, char BKMPOHCPCGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x726BCA0", Offset = "0x726A8A0", VA = "0x18726BCA0")]
	private static int HIGFJMAAODF(char KNFDPFPHEON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x726B850", Offset = "0x726A450", VA = "0x18726B850")]
	public ArraySegment<byte> GHGPAIECBPA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x726A2C0", Offset = "0x7268EC0", VA = "0x18726A2C0")]
	public string AIJPGCEGFJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x726C000", Offset = "0x726AC00", VA = "0x18726C000")]
	public string KDDEFLPGFDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x726CBD0", Offset = "0x726B7D0", VA = "0x18726CBD0")]
	public ArraySegment<byte> NMBBLJAHKMH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x726CB60", Offset = "0x726B760", VA = "0x18726CB60")]
	public ArraySegment<byte> NCFGANBHIJG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x726B540", Offset = "0x726A140", VA = "0x18726B540")]
	public bool FHBHLKOMLBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x726A200", Offset = "0x7268E00", VA = "0x18726A200")]
	private static bool AEBPKMGMKOJ(byte PIIKINJOJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x726A6B0", Offset = "0x72692B0", VA = "0x18726A6B0")]
	private void BIPEACEHGGC(AGHDMKLGNNG FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x726A1B0", Offset = "0x7268DB0", VA = "0x18726A1B0")]
	public void ADBBMICCGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x726CF10", Offset = "0x726BB10", VA = "0x18726CF10")]
	private void OIJJGIOKAMM(int IJIAFPHBEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x726BD80", Offset = "0x726A980", VA = "0x18726BD80")]
	public sbyte IBFFOOHFHGC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x726C830", Offset = "0x726B430", VA = "0x18726C830")]
	public short LFLDOABBOIE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x726CA50", Offset = "0x726B650", VA = "0x18726CA50")]
	public int MKPKJCAKKJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x726BF40", Offset = "0x726AB40", VA = "0x18726BF40")]
	public long KAJMOJJDEBI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x726A900", Offset = "0x7269500", VA = "0x18726A900")]
	public byte BLAAIEEJICA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x726BE00", Offset = "0x726AA00", VA = "0x18726BE00")]
	public ushort JHEBFCOCKFD()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x726C9D0", Offset = "0x726B5D0", VA = "0x18726C9D0")]
	public uint MEEMEJMKKGO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x726BE80", Offset = "0x726AA80", VA = "0x18726BE80")]
	public ulong JKDGEFHGBGO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x726A0B0", Offset = "0x7268CB0", VA = "0x18726A0B0")]
	public float ACPNKPDHJKL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x726A510", Offset = "0x7269110", VA = "0x18726A510")]
	public double BEBJOABJOKD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x726ABD0", Offset = "0x72697D0", VA = "0x18726ABD0")]
	public ArraySegment<byte> DAKJGGIKCFJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x726A3A0", Offset = "0x7268FA0", VA = "0x18726A3A0")]
	private static int ANPBNKKHBGH(byte[] HNGDLLNOPEB, int MANKJHLJMBO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AHCBCMBPCED : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference CLKKGFDPOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int IALAMEGJHGE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int OPIIJFJCLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDB48F0", Offset = "0xDB34F0", VA = "0x180DB48F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string GBHCJIBDNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9B0300", Offset = "0x9AEF00", VA = "0x1809B0300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72628E0", Offset = "0x72614E0", VA = "0x1872628E0")]
	public AHCBCMBPCED(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7262940", Offset = "0x7261540", VA = "0x187262940")]
	public AHCBCMBPCED(string JIMAFLGJGFB, byte[] DODKBLIOAAA, int MANKJHLJMBO, int IALAMEGJHGE, string JCEFDMLEBDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OIOCCPHABEP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class IHENEBIFLOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] BKHGNPANPPB;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7268BD0", Offset = "0x72677D0", VA = "0x187268BD0")]
		public static byte[] GEGJGIDDCPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ODEKNHGKGPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void HBPNIPANOGK(OKKKEEDEAED AKHHKFNOJLO, object GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object CMEDOCJCDCO(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL OMPFDPJMJHN);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class ANCNONKMIKP
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class FJLICCBCAJM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
				public FJLICCBCAJM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3C9C040", Offset = "0x3C9AC40", VA = "0x183C9C040")]
				internal bool CDCPFPIIAFG(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7267B30", Offset = "0x7266730", VA = "0x187267B30")]
				internal bool PAFIIIOKHML(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, MODONKLHHGL, byte[]> OLEEALNNBDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, MODONKLHHGL> KHPMJOOBCMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly HBPNIPANOGK IHFAPGKLOHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, MODONKLHHGL, ArraySegment<byte>> CNJJCDHBCAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, MODONKLHHGL, string> GDHLBDPANBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, MODONKLHHGL, object> BKOEEDFHENI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, MODONKLHHGL, object> CIDEJHPFPGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, MODONKLHHGL, object> PJLADBNJADN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly CMEDOCJCDCO IAFGJJDMCHH;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7262C80", Offset = "0x7261880", VA = "0x187262C80")]
			public ANCNONKMIKP(Type NCNNODEFPOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x31B3DF0", Offset = "0x31B29F0", VA = "0x1831B3DF0")]
			private static T CFHAPIMACHK<T>(DynamicMethod KFCGDOMJFKC)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7262A30", Offset = "0x7261630", VA = "0x187262A30")]
			private static MethodInfo GDHIGLNEDCC(Type NCNNODEFPOG, string GFLNGGKHEOH, Type[] APOINAMEDEL)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, ANCNONKMIKP> NMLIHPGIGBB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly PHCICKCOHEP<ANCNONKMIKP> OKCMNKHIFGK;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x727AB10", Offset = "0x7279710", VA = "0x18727AB10")]
		static ODEKNHGKGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x727A800", Offset = "0x7279400", VA = "0x18727A800")]
		private static ANCNONKMIKP ENOIPAMOKHG(Type NCNNODEFPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x727A990", Offset = "0x7279590", VA = "0x18727A990")]
		public static void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, object GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x727A880", Offset = "0x7279480", VA = "0x18727A880")]
		public static void PLFEAILJDFE(Type NCNNODEFPOG, OKKKEEDEAED AKHHKFNOJLO, object GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MODONKLHHGL CNBDPKOGOFE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] DFPEIIDOAOP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] LHDMOPPJALE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static MODONKLHHGL GJHMKMCFCBG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x727AC60", Offset = "0x7279860", VA = "0x18727AC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x727AD60", Offset = "0x7279960", VA = "0x18727AD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x727BBB0", Offset = "0x727A7B0", VA = "0x18727BBB0")]
	public static void OFIBCOOPBMI(MODONKLHHGL OMPFDPJMJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAC30", Offset = "0x2CD9830", VA = "0x182CDAC30")]
	public static byte[] PLFEAILJDFE<T>(T HAHECKLGOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CDACD0", Offset = "0x2CD98D0", VA = "0x182CDACD0")]
	public static byte[] PLFEAILJDFE<T>(T GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAFB0", Offset = "0x2CD9BB0", VA = "0x182CDAFB0")]
	public static void PLFEAILJDFE<T>(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB180", Offset = "0x2CD9D80", VA = "0x182CDB180")]
	public static void PLFEAILJDFE<T>(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB0E0", Offset = "0x2CD9CE0", VA = "0x182CDB0E0")]
	public static void PLFEAILJDFE<T>(Stream DMCHAOHIHNE, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAE60", Offset = "0x2CD9A60", VA = "0x182CDAE60")]
	public static void PLFEAILJDFE<T>(Stream DMCHAOHIHNE, T GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9640", Offset = "0x2CD8240", VA = "0x182CD9640")]
	public static ArraySegment<byte> DCIFIMKFHOO<T>(T HAHECKLGOJC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2CD94A0", Offset = "0x2CD80A0", VA = "0x182CD94A0")]
	public static ArraySegment<byte> DCIFIMKFHOO<T>(T GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAA10", Offset = "0x2CD9610", VA = "0x182CDAA10")]
	public static string GFLFADDCEOI<T>(T GLMEMJNJKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAAA0", Offset = "0x2CD96A0", VA = "0x182CDAAA0")]
	public static string GFLFADDCEOI<T>(T GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA7D0", Offset = "0x2CD93D0", VA = "0x182CDA7D0")]
	public static T EGCBEAACMHC<T>(string MEIOPBDHBLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA650", Offset = "0x2CD9250", VA = "0x182CDA650")]
	public static T EGCBEAACMHC<T>(string MEIOPBDHBLD, MODONKLHHGL OMPFDPJMJHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA150", Offset = "0x2CD8D50", VA = "0x182CDA150")]
	public static T EGCBEAACMHC<T>(byte[] HNGDLLNOPEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9F00", Offset = "0x2CD8B00", VA = "0x182CD9F00")]
	public static T EGCBEAACMHC<T>(byte[] HNGDLLNOPEB, MODONKLHHGL OMPFDPJMJHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA730", Offset = "0x2CD9330", VA = "0x182CDA730")]
	public static T EGCBEAACMHC<T>(byte[] HNGDLLNOPEB, int MANKJHLJMBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9FB0", Offset = "0x2CD8BB0", VA = "0x182CD9FB0")]
	public static T EGCBEAACMHC<T>(byte[] HNGDLLNOPEB, int MANKJHLJMBO, MODONKLHHGL OMPFDPJMJHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA8F0", Offset = "0x2CD94F0", VA = "0x182CDA8F0")]
	public static T EGCBEAACMHC<T>(KKCIDLEELDC GGPHPLOPODB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA290", Offset = "0x2CD8E90", VA = "0x182CDA290")]
	public static T EGCBEAACMHC<T>(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL OMPFDPJMJHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA200", Offset = "0x2CD8E00", VA = "0x182CDA200")]
	public static T EGCBEAACMHC<T>(Stream DMCHAOHIHNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA500", Offset = "0x2CD9100", VA = "0x182CDA500")]
	public static T EGCBEAACMHC<T>(Stream DMCHAOHIHNE, MODONKLHHGL OMPFDPJMJHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x727BD60", Offset = "0x727A960", VA = "0x18727BD60")]
	public static string OLALPALOIFL(byte[] MEIOPBDHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x727BC20", Offset = "0x727A820", VA = "0x18727BC20")]
	public static string OLALPALOIFL(byte[] MEIOPBDHBLD, int MANKJHLJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x727BEC0", Offset = "0x727AAC0", VA = "0x18727BEC0")]
	public static string OLALPALOIFL(string MEIOPBDHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x727AFB0", Offset = "0x7279BB0", VA = "0x18727AFB0")]
	public static byte[] LDGCEELLMNI(byte[] MEIOPBDHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x727AE60", Offset = "0x7279A60", VA = "0x18727AE60")]
	public static byte[] LDGCEELLMNI(byte[] MEIOPBDHBLD, int MANKJHLJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x727B130", Offset = "0x7279D30", VA = "0x18727B130")]
	public static byte[] LDGCEELLMNI(string MEIOPBDHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x727B2E0", Offset = "0x7279EE0", VA = "0x18727B2E0")]
	private static void NHMPCMIPPBE(KKCIDLEELDC GGPHPLOPODB, OKKKEEDEAED AKHHKFNOJLO, int PPFCFICLEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x727ADC0", Offset = "0x72799C0", VA = "0x18727ADC0")]
	private static int KFGOPFHJFKG(Stream HJNPKADFMMO, byte[] BKHGNPANPPB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum AGHDMKLGNNG : byte
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
public struct OKKKEEDEAED
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] MCHKLDGJIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] BKHGNPANPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int MANKJHLJMBO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IJOHLGEFKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x726A980", Offset = "0x7269580", VA = "0x18726A980")]
	public void CAGPJILBNBC(int MANKJHLJMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x727C760", Offset = "0x727B360", VA = "0x18727C760")]
	public static byte[] CNNFIEKMLLE(string ALMPCPBBOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x727C590", Offset = "0x727B190", VA = "0x18727C590")]
	public static byte[] CECPLHFPBOI(string ALMPCPBBOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x727CD20", Offset = "0x727B920", VA = "0x18727CD20")]
	public static byte[] IMIDGDNOHLA(string ALMPCPBBOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x727C340", Offset = "0x727AF40", VA = "0x18727C340")]
	public static byte[] ANEIPBBIIPG(string ALMPCPBBOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D75AF0", Offset = "0x5D746F0", VA = "0x185D75AF0")]
	public OKKKEEDEAED(byte[] IABNFPELGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x727C9A0", Offset = "0x727B5A0", VA = "0x18727C9A0")]
	public ArraySegment<byte> GEGJGIDDCPJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x727CAB0", Offset = "0x727B6B0", VA = "0x18727CAB0")]
	public byte[] GGJNBIANDOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x727D5F0", Offset = "0x727C1F0", VA = "0x18727D5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x727C750", Offset = "0x727B350", VA = "0x18727C750")]
	public void CFJLBIBDBCN(int EOINLPBLINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x727CC60", Offset = "0x727B860", VA = "0x18727CC60")]
	public void IBIMOLEDOCN(byte INCCIBDMFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x727CCC0", Offset = "0x727B8C0", VA = "0x18727CCC0")]
	public void IBIMOLEDOCN(byte[] INCCIBDMFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x727CA70", Offset = "0x727B670", VA = "0x18727CA70")]
	public void GFLOHDJKLJC(byte INCCIBDMFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x727C700", Offset = "0x727B300", VA = "0x18727C700")]
	public void CFCIHGOCLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x727D530", Offset = "0x727C130", VA = "0x18727D530")]
	public void OCEFMIFMABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x727D400", Offset = "0x727C000", VA = "0x18727D400")]
	public void LOFNFMOIOHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x727C900", Offset = "0x727B500", VA = "0x18727C900")]
	public void EPPNJGMPHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x727D3B0", Offset = "0x727BFB0", VA = "0x18727D3B0")]
	public void LJHNEKGLJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x727C950", Offset = "0x727B550", VA = "0x18727C950")]
	public void FCFFMDEPLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x727CBC0", Offset = "0x727B7C0", VA = "0x18727CBC0")]
	public void HHGHFAABEFP(string ALMPCPBBOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x727C4C0", Offset = "0x727B0C0", VA = "0x18727C4C0")]
	public void AOPBDFHEGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x727CB20", Offset = "0x727B720", VA = "0x18727CB20")]
	public void GMJIDADONPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x727C1E0", Offset = "0x727ADE0", VA = "0x18727C1E0")]
	public void AMNGAHFCJKC(bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x727D290", Offset = "0x727BE90", VA = "0x18727D290")]
	public void KOKGPADJLEK(float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x727C510", Offset = "0x727B110", VA = "0x18727C510")]
	public void BOMDBILGKGJ(double GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x727D450", Offset = "0x727C050", VA = "0x18727D450")]
	public void MLIPGBIKEPI(byte GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x727CE90", Offset = "0x727BA90", VA = "0x18727CE90")]
	public void JMFIGOBPPKD(ushort GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x727D310", Offset = "0x727BF10", VA = "0x18727D310")]
	public void LBFMPNBOLHL(uint GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x727CA40", Offset = "0x727B640", VA = "0x18727CA40")]
	public void GEMJMFHKNFG(ulong GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x727D580", Offset = "0x727C180", VA = "0x18727D580")]
	public void ODJFEILMEBB(sbyte GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x727C890", Offset = "0x727B490", VA = "0x18727C890")]
	public void DIPPPIKPAKL(short GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x727D4C0", Offset = "0x727C0C0", VA = "0x18727D4C0")]
	public void NFHHOMMJGBA(int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x727D380", Offset = "0x727BF80", VA = "0x18727D380")]
	public void LIJHCCIHLJA(long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x727CF00", Offset = "0x727BB00", VA = "0x18727CF00")]
	public void KIFDPEKGPEC(string GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class GNDMDINGKGL : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class PIMELIODCNI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x476C630", Offset = "0x476B230", VA = "0x18476C630")]
		static PIMELIODCNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private GNDMDINGKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GADEMBNHGEF : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class CFKDGMAJOKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x51B1670", Offset = "0x51B0270", VA = "0x1851B1670")]
		static CFKDGMAJOKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class LFBMHLHOLPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> FGGNALNHGPI;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x726D6D0", Offset = "0x726C2D0", VA = "0x18726D6D0")]
		internal static object GMNOPCIBNEG(Type NEAJEANMBOG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private GADEMBNHGEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class GAOPLONEPIN : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class KNIHBDADHEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x415F560", Offset = "0x415E160", VA = "0x18415F560")]
		static KNIHBDADHEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly GAOPLONEPIN GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool FPPNNOBKEKC;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static NKAPOBPAPKD[] IDOHGLBAEHA;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static MODONKLHHGL[] MJHCCOAADEE;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private GAOPLONEPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7267E50", Offset = "0x7266A50", VA = "0x187267E50")]
	public static void FHCDBNBHAOK(params MODONKLHHGL[] MJHCCOAADEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7267D70", Offset = "0x7266970", VA = "0x187267D70")]
	public static void FHCDBNBHAOK(params NKAPOBPAPKD[] IDOHGLBAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7267F30", Offset = "0x7266B30", VA = "0x187267F30")]
	public static void MIKDEEENAKL(NKAPOBPAPKD[] IDOHGLBAEHA, MODONKLHHGL[] MJHCCOAADEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MBFGJOEDIDC : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class LBFGMEKBHIL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x41EA010", Offset = "0x41E8C10", VA = "0x1841EA010")]
		static LBFGMEKBHIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private MBFGJOEDIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class IHIEJHAPNNJ
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly MODONKLHHGL IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly MODONKLHHGL JBGAKOPIDIE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly MODONKLHHGL NNEKLAJNKHF;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly MODONKLHHGL AHMLAICKBMO;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly MODONKLHHGL FMCHICHDNGO;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly MODONKLHHGL BALIGIMGIMC;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly MODONKLHHGL LNCMEDJJFEB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly MODONKLHHGL NHILHBDAAJO;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly MODONKLHHGL DMBEFLBOKGK;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly MODONKLHHGL DMFCBPADMLL;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MODONKLHHGL OLJDCJBMHHM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly MODONKLHHGL HBKHJIHABPA;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GEMMKOKLBII
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly MODONKLHHGL IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly MODONKLHHGL IAKOFKCJKKO;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IIIBMIPKGOI
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly MODONKLHHGL IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly MODONKLHHGL JBGAKOPIDIE;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly MODONKLHHGL NNEKLAJNKHF;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly MODONKLHHGL AHMLAICKBMO;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly MODONKLHHGL FMCHICHDNGO;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly MODONKLHHGL BALIGIMGIMC;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly MODONKLHHGL LNCMEDJJFEB;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly MODONKLHHGL NHILHBDAAJO;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly MODONKLHHGL DMBEFLBOKGK;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly MODONKLHHGL DMFCBPADMLL;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly MODONKLHHGL OLJDCJBMHHM;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly MODONKLHHGL HBKHJIHABPA;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class DLLLBALDNMA
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> FGGNALNHGPI;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7265CF0", Offset = "0x72648F0", VA = "0x187265CF0")]
	internal static object GMNOPCIBNEG(Type NEAJEANMBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7267480", Offset = "0x7266080", VA = "0x187267480")]
	private static object IEFMFMGDEOH(Type IFBOFOAJBPC, Type[] KBNBKCLJCDG, params object[] APOINAMEDEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class KMFNKMPAEKC : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class NEHNIFIHHJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4488F40", Offset = "0x4487B40", VA = "0x184488F40")]
		static NEHNIFIHHJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly LDPJAIHDHFO EGHLKFAFNGB;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x726D560", Offset = "0x726C160", VA = "0x18726D560")]
	static KMFNKMPAEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private KMFNKMPAEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class KEFDNEKPALF : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class MPJANLJHBBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4441AE0", Offset = "0x44406E0", VA = "0x184441AE0")]
		static MPJANLJHBBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly LDPJAIHDHFO EGHLKFAFNGB;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7269CB0", Offset = "0x72688B0", VA = "0x187269CB0")]
	static KEFDNEKPALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private KEFDNEKPALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class ABMICCBLMBP : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class EOJKCONDONH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3814BB0", Offset = "0x38137B0", VA = "0x183814BB0")]
		static EOJKCONDONH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly LDPJAIHDHFO EGHLKFAFNGB;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7262770", Offset = "0x7261370", VA = "0x187262770")]
	static ABMICCBLMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private ABMICCBLMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class GBIFKMAKGHM : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class IHOALIFBPOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E2DE40", Offset = "0x3E2CA40", VA = "0x183E2DE40")]
		static IHOALIFBPOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly LDPJAIHDHFO EGHLKFAFNGB;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72682E0", Offset = "0x7266EE0", VA = "0x1872682E0")]
	static GBIFKMAKGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private GBIFKMAKGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class ANOPKBEAJCL : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class AEPFFHKKDAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9640", Offset = "0x3CC8240", VA = "0x183CC9640")]
		static AEPFFHKKDAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly LDPJAIHDHFO EGHLKFAFNGB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72647F0", Offset = "0x72633F0", VA = "0x1872647F0")]
	static ANOPKBEAJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private ANOPKBEAJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HAOEOMGGBLP : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class PCIMCNFLGHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x46EE510", Offset = "0x46ED110", VA = "0x1846EE510")]
		static PCIMCNFLGHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly LDPJAIHDHFO EGHLKFAFNGB;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7268A60", Offset = "0x7267660", VA = "0x187268A60")]
	static HAOEOMGGBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private HAOEOMGGBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LLLLFPNCLHM : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class FNJDCDPEJDE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3BDAA20", Offset = "0x3BD9620", VA = "0x183BDAA20")]
		static FNJDCDPEJDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LLLLFPNCLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class GBLPCCJDHMP : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class MLFFKPAJNJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x44133E0", Offset = "0x4411FE0", VA = "0x1844133E0")]
		static MLFFKPAJNJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GBLPCCJDHMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class LMEDCDENAKJ : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class JGKNNHOJHIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4037B30", Offset = "0x4036730", VA = "0x184037B30")]
		static JGKNNHOJHIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LMEDCDENAKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class PCGKJBLGCON : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class EJKHELHJENE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x37FFAA0", Offset = "0x37FE6A0", VA = "0x1837FFAA0")]
		static EJKHELHJENE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PCGKJBLGCON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class KBGCDPDGEBE : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class NHJMBEJNPCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4490810", Offset = "0x448F410", VA = "0x184490810")]
		static NHJMBEJNPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public KBGCDPDGEBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class CKBPEODGEOG : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class OMIMODLPEKK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4642010", Offset = "0x4640C10", VA = "0x184642010")]
		static OMIMODLPEKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> BOFIKELAKNE;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool NKILKMIGDPL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public CKBPEODGEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class MBLCFLOIOLD
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct NMCHKEOLALI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FOIIBAGBBOB MANDEJPICDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder EJJJKLIPHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder NLJGEFOGLCK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class MCIMMHHHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class MLFHLEGLJCG
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo IMIDGDNOHLA;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo CECPLHFPBOI;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo ANEIPBBIIPG;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo CNNFIEKMLLE;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo GMJIDADONPB;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo IBIMOLEDOCN;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo LOFNFMOIOHF;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo EPPNJGMPHOC;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo LJHNEKGLJBJ;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7279890", Offset = "0x7278490", VA = "0x187279890")]
			static MLFHLEGLJCG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class DJGJLNPLFCO
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo NPCNBLNKCHJ;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo BHJIBPJGFED;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo CKNKPIIMEMP;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo GKKCCLPDJEL;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo ADBBMICCGBH;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo IDOFBFIDNIA;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo LKPJOKJIENA;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7265120", Offset = "0x7263D20", VA = "0x187265120")]
			static DJGJLNPLFCO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class GHMBFMBIGKB
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo FGFHGOGOBMJ;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo JDMCFOPNGJG;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo PHMBGHOBOLF;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo OGLPNIEDIPP;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo FOPOPFEPNOH;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo OPKBLNEEPKK;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo OFPIAHNGCNN;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo JCJAAFHIPCD;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo NMNEHLKGCAL;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo BJFFDFLAHCB;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo IMABMCEPKJN;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo OHJJKIJFHJM;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo CAOOKFJEGEM;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo JONFLHHMABH;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7277FF0", Offset = "0x7276BF0", VA = "0x187277FF0")]
		public static MethodInfo PLFEAILJDFE(Type NCNNODEFPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7277C70", Offset = "0x7276870", VA = "0x187277C70")]
		public static MethodInfo EGCBEAACMHC(Type NCNNODEFPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7277EB0", Offset = "0x7276AB0", VA = "0x187277EB0")]
		public static MethodInfo NHJLNFGINII(Type NCNNODEFPOG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class BPMFPCLBAGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<FOIIBAGBBOB, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BPMFPCLBAGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class IMNIPODNIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BPMFPCLBAGN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IMNIPODNIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x72697C0", Offset = "0x72683C0", VA = "0x1872697C0")]
		internal void FAPNKMHBLOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7269720", Offset = "0x7268320", VA = "0x187269720")]
		internal bool BJOKOHMHGIF(int index, FOIIBAGBBOB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JLDLBAMFLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public BPMFPCLBAGN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JLDLBAMFLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7269B10", Offset = "0x7268710", VA = "0x187269B10")]
		internal bool GGNACBKNJJD(int index, FOIIBAGBBOB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class DJPDHFOAOMM
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
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public DJPDHFOAOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C090", Offset = "0x3E1AC90", VA = "0x183E1C090")]
		internal string LIIAGOMFECN(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BDMAEKLAEIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BDMAEKLAEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7264C90", Offset = "0x7263890", VA = "0x187264C90")]
		internal bool HABPPEOCGIE(FOIIBAGBBOB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class IJAKIOJAPMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public DJPDHFOAOMM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IJAKIOJAPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7269590", Offset = "0x7268190", VA = "0x187269590")]
		internal void LFFONHOGDDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x72695A0", Offset = "0x72681A0", VA = "0x1872695A0")]
		internal bool MBGKNMPDOMP(int index, FOIIBAGBBOB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class CODDJBCFONP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public DJPDHFOAOMM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CODDJBCFONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7264FA0", Offset = "0x7263BA0", VA = "0x187264FA0")]
		internal bool BJAHMJGLKMG(int index, FOIIBAGBBOB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class NINKBOLCIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NINKBOLCIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x727A7D0", Offset = "0x72793D0", VA = "0x18727A7D0")]
		internal Label HGACBFGDBKB(FOIIBAGBBOB _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class EDGMNLBFODM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public NMCHKEOLALI[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, FOIIBAGBBOB, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public BNOKAKIBBNJ argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public BNOKAKIBBNJ argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EDGMNLBFODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7267A10", Offset = "0x7266610", VA = "0x187267A10")]
		internal NMCHKEOLALI OOBMLBAHENM(FOIIBAGBBOB item)
		{
			return default(NMCHKEOLALI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class BAKMOEBDEIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public EDGMNLBFODM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BAKMOEBDEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7264960", Offset = "0x7263560", VA = "0x187264960")]
		internal void CJGEPNHAJLE(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7264BF0", Offset = "0x72637F0", VA = "0x187264BF0")]
		internal void HADKEGHHFEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HGMMJNFIGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public FOIIBAGBBOB item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HGMMJNFIGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xD19E50", Offset = "0xD18A50", VA = "0x180D19E50")]
		internal bool FCCPCMBONEM(NMCHKEOLALI x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JDHKGDPJBKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public FOIIBAGBBOB item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JDHKGDPJBKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xD19E50", Offset = "0xD18A50", VA = "0x180D19E50")]
		internal bool IEJJCNIELJB(NMCHKEOLALI x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex MKNEDNJFCIB;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int KLLKJMPJPHB;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> JKBHHIGPOGB;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> CCGBKCAACPJ;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C24920", Offset = "0x2C23520", VA = "0x182C24920")]
	public static object KEABHFMEFHC<T>(LDPJAIHDHFO EGHLKFAFNGB, MODONKLHHGL HLPFCMGFEEE, Func<string, string> BOFIKELAKNE, bool NKILKMIGDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BA70", Offset = "0x2C1A670", VA = "0x182C1BA70")]
	public static object HBNEGKPJGGK<T>(MODONKLHHGL HLPFCMGFEEE, Func<string, string> BOFIKELAKNE, bool NKILKMIGDPL, bool DHJCKJBPGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7272AA0", Offset = "0x72716A0", VA = "0x187272AA0")]
	private static TypeInfo IAJCEMBPEJN(LDPJAIHDHFO EGHLKFAFNGB, Type NCNNODEFPOG, Func<string, string> BOFIKELAKNE, bool NKILKMIGDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7275240", Offset = "0x7273E40", VA = "0x187275240")]
	public static object OIGLLNOHBOE(Type NCNNODEFPOG, Func<string, string> BOFIKELAKNE, bool NKILKMIGDPL, bool DHJCKJBPGLG, bool CMCFHDDCALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x72734D0", Offset = "0x72720D0", VA = "0x1872734D0")]
	private static Dictionary<FOIIBAGBBOB, FieldInfo> KLIPIMFOBFA(TypeBuilder LGGJGKBOPGB, NMFPKGGJEDC KONMDJKGHML, ConstructorInfo AEGDCAADINA, FieldBuilder GBHJGMEJPJC, ILGenerator FJKNCOLKKEL, bool NKILKMIGDPL, bool AGMAKGGEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7276F20", Offset = "0x7275B20", VA = "0x187276F20")]
	private static Dictionary<FOIIBAGBBOB, FieldInfo> PJGPDNPAJAD(TypeBuilder LGGJGKBOPGB, NMFPKGGJEDC KONMDJKGHML, ILGenerator FJKNCOLKKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7273C00", Offset = "0x7272800", VA = "0x187273C00")]
	private static void MCANABBGKFK(Type NCNNODEFPOG, NMFPKGGJEDC KONMDJKGHML, ILGenerator FJKNCOLKKEL, Action ENOBFNGCFFF, Func<int, FOIIBAGBBOB, bool> PDFELINKBPN, bool NKILKMIGDPL, bool AGMAKGGEJAG, int JAANGHOFDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x726F800", Offset = "0x726E400", VA = "0x18726F800")]
	private static void CCOAGAHLBMM(TypeInfo NCNNODEFPOG, FOIIBAGBBOB CIKBDIENODJ, ILGenerator FJKNCOLKKEL, int OPDMGNJCACB, Func<int, FOIIBAGBBOB, bool> PDFELINKBPN, BNOKAKIBBNJ AKHHKFNOJLO, BNOKAKIBBNJ GNBAEJJKBPI, BNOKAKIBBNJ NAOCBHILMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7271600", Offset = "0x7270200", VA = "0x187271600")]
	private static void GPCNEBHPAGC(Type NCNNODEFPOG, NMFPKGGJEDC KONMDJKGHML, ILGenerator FJKNCOLKKEL, Func<int, FOIIBAGBBOB, bool> PDFELINKBPN, bool CBBDIEAKKMP, int JAANGHOFDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7270420", Offset = "0x726F020", VA = "0x187270420")]
	private static void CKKLLAELAMC(ILGenerator FJKNCOLKKEL, NMCHKEOLALI KONMDJKGHML, int OPDMGNJCACB, Func<int, FOIIBAGBBOB, bool> PDFELINKBPN, BNOKAKIBBNJ GGPHPLOPODB, BNOKAKIBBNJ NAOCBHILMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7270890", Offset = "0x726F490", VA = "0x187270890")]
	private static LocalBuilder EKJOAPKKCML(ILGenerator FJKNCOLKKEL, Type NCNNODEFPOG, NMFPKGGJEDC KONMDJKGHML, NMCHKEOLALI[] LMAAMPKBIPD, bool AJNEFFJIELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x726FD40", Offset = "0x726E940", VA = "0x18726FD40")]
	private static bool CHCDILCLCOL(ConstructorInfo OIEJMIPIBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7276DA0", Offset = "0x72759A0", VA = "0x187276DA0")]
	private static bool PIGHECDABMJ(Type NCNNODEFPOG, [Out] Type IMMHBKJKNMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void GMEDJOKDKIM<T>(byte[][] GBHJGMEJPJC, object[] GNOFBHHEDBL, OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL OMPFDPJMJHN);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T HHKEFHLIODO<T>(object[] GNOFBHHEDBL, KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL OMPFDPJMJHN);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class FEBKHDFLEEJ<T> : DLJMBCMBIMD<T>, NKAPOBPAPKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] GBHJGMEJPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] NKOENONOEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] PNCJABODFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly GMEDJOKDKIM<T> CCHKIEFGMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly HHKEFHLIODO<T> NAKJHGIAHLA;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1F58980", Offset = "0x1F57580", VA = "0x181F58980")]
	public FEBKHDFLEEJ(byte[][] GBHJGMEJPJC, object[] NKOENONOEEO, object[] PNCJABODFLD, GMEDJOKDKIM<T> CCHKIEFGMAE, HHKEFHLIODO<T> NAKJHGIAHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3B96B70", Offset = "0x3B95770", VA = "0x183B96B70", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3B96A80", Offset = "0x3B95680", VA = "0x183B96A80", Slot = "5")]
	public T EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class LGDPGEMMKCJ : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class AGLLGMCLHGO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5470", Offset = "0x3CD4070", VA = "0x183CD5470")]
		static AGLLGMCLHGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private LGDPGEMMKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class OLIIBJIAJDH : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class DBEBFHCEJPC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x57C1280", Offset = "0x57BFE80", VA = "0x1857C1280")]
		static DBEBFHCEJPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private OLIIBJIAJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class KIIFAHLGELK
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly MODONKLHHGL[] HLMKAHNHLIF;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class NEIEFGLPKMN : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class MDJBBIKDEHL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x43ED300", Offset = "0x43EBF00", VA = "0x1843ED300")]
		static MDJBBIKDEHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class JEOEEMKCHOM : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class LLCEDKAPJHH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4215340", Offset = "0x4213F40", VA = "0x184215340")]
			static LLCEDKAPJHH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private JEOEEMKCHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private NEIEFGLPKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class BLMABJNJPPI : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class LIOHBOJFLLP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4205C60", Offset = "0x4204860", VA = "0x184205C60")]
		static LIOHBOJFLLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class LPMPGIMMBKP : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class KNPCBLDCHNA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4167C40", Offset = "0x4166840", VA = "0x184167C40")]
			static KNPCBLDCHNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private LPMPGIMMBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private BLMABJNJPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class HADMAPKOGLB : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class FGHOCOCOOFB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3B9FD80", Offset = "0x3B9E980", VA = "0x183B9FD80")]
		static FGHOCOCOOFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class HBKLPBKDNHP : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class EKNCFCIJDLI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3807D50", Offset = "0x3806950", VA = "0x183807D50")]
			static EKNCFCIJDLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private HBKLPBKDNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private HADMAPKOGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class EJEMAJKFPPJ : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class HJNMBGCBDBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3D50C40", Offset = "0x3D4F840", VA = "0x183D50C40")]
		static HJNMBGCBDBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class OOJHHMOJJBB : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class INBNFCDFECP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3E758D0", Offset = "0x3E744D0", VA = "0x183E758D0")]
			static INBNFCDFECP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private OOJHHMOJJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private EJEMAJKFPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class BPAFOIHAJGF : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class JEPNLIFPGIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4022790", Offset = "0x4021390", VA = "0x184022790")]
		static JEPNLIFPGIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class CNOEHHMMFPB : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class LLMDDILDAHM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4218110", Offset = "0x4216D10", VA = "0x184218110")]
			static LLMDDILDAHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private CNOEHHMMFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private BPAFOIHAJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class PNOKBHNPKHF : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class BCKGAOCFPNH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4E25D70", Offset = "0x4E24970", VA = "0x184E25D70")]
		static BCKGAOCFPNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class AMBLHBGFJMF : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class HOCBPEDMHOI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3D62A70", Offset = "0x3D61670", VA = "0x183D62A70")]
			static HOCBPEDMHOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private AMBLHBGFJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private PNOKBHNPKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class GHANGBEJCMF : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class HDFJBMJNNGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3D27540", Offset = "0x3D26140", VA = "0x183D27540")]
		static HDFJBMJNNGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class GFEHFLFBADF : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class JKCLFAAIDIE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x406B660", Offset = "0x406A260", VA = "0x18406B660")]
			static JKCLFAAIDIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private GFEHFLFBADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private GHANGBEJCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class HCFHHCADFLF : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class IOBCNLHNILO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3E77830", Offset = "0x3E76430", VA = "0x183E77830")]
		static IOBCNLHNILO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class PLEGEEKLAEC : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class JABCJFHACEB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4004740", Offset = "0x4003340", VA = "0x184004740")]
			static JABCJFHACEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private PLEGEEKLAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private HCFHHCADFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class GPGIMDKINHI : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class LGOEJJPILAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x41FCAE0", Offset = "0x41FB6E0", VA = "0x1841FCAE0")]
		static LGOEJJPILAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class OBCADBCPLHJ : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class ODLDJEGMENK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4575710", Offset = "0x4574310", VA = "0x184575710")]
			static ODLDJEGMENK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private OBCADBCPLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private GPGIMDKINHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class PPBBMMMBBAG : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class BNCPCGNAHAL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C590", Offset = "0x4E6B190", VA = "0x184E6C590")]
		static BNCPCGNAHAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class MLLPGNNGOAK : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class MFMFLPBBNOK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x43F2AA0", Offset = "0x43F16A0", VA = "0x1843F2AA0")]
			static MFMFLPBBNOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private MLLPGNNGOAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private PPBBMMMBBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class DJIJJCJPCAP : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class HCFMAFIAJFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CBE0", Offset = "0x3D1B7E0", VA = "0x183D1CBE0")]
		static HCFMAFIAJFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class LGJFPDIHOLP : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class GIJKBIPOCBC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3CA4F40", Offset = "0x3CA3B40", VA = "0x183CA4F40")]
			static GIJKBIPOCBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private LGJFPDIHOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private DJIJJCJPCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class ILNHPOGIJJD : MODONKLHHGL
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class EPDIOPDEMAF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x381FD70", Offset = "0x381E970", VA = "0x18381FD70")]
		static EPDIOPDEMAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class EMPLFKNCGGA : MODONKLHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class KFAKJFBAONH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly DLJMBCMBIMD<T> MDPDLHLOLLL;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4142680", Offset = "0x4141280", VA = "0x184142680")]
			static KFAKJFBAONH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly MODONKLHHGL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly MODONKLHHGL[] MJHCCOAADEE;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private EMPLFKNCGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
		public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly MODONKLHHGL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly DLJMBCMBIMD<object> FIPGAPPFHJD;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	private ILNHPOGIJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	public DLJMBCMBIMD<T> GMNOPCIBNEG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct CDOHGKGBFBD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] NGCJJAABDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int LBOCLAHFPED;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x51A9C70", Offset = "0x51A8870", VA = "0x1851A9C70")]
	public CDOHGKGBFBD(int JPDKFFOGAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x51A98D0", Offset = "0x51A84D0", VA = "0x1851A98D0")]
	public void MPFJKDGCCNN(T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x51A9760", Offset = "0x51A8360", VA = "0x1851A9760")]
	public T[] KFDCBPFLHKE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class FGNAFDHNAGJ : GPGFCAODBEH<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly FGNAFDHNAGJ IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7283A20", Offset = "0x7282620", VA = "0x187283A20")]
	public FGNAFDHNAGJ(int MPDJAOJEAGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class GPGFCAODBEH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int MPDJAOJEAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object KPDGPKJEHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int OPDMGNJCACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] LELCCOEJCCD;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7EE0", Offset = "0x3CE6AE0", VA = "0x183CE7EE0")]
	public GPGFCAODBEH(int MPDJAOJEAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7BE0", Offset = "0x3CE67E0", VA = "0x183CE7BE0")]
	public T[] EJGDLLMPHFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CE78E0", Offset = "0x3CE64E0", VA = "0x183CE78E0")]
	public void DMIOJMDKDEP(T[] CHPEIOMPEEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class PIFENEHKMJH : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class HNMIELCAEFA : IComparable<HNMIELCAEFA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class LHOBODFPGDF : IEnumerable<HNMIELCAEFA>, IEnumerable, IEnumerator<HNMIELCAEFA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private HNMIELCAEFA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public HNMIELCAEFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private HNMIELCAEFA System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
			[DebuggerHidden]
			public LHOBODFPGDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x72909A0", Offset = "0x728F5A0", VA = "0x1872909A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x7290AD0", Offset = "0x728F6D0", VA = "0x187290AD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7290A20", Offset = "0x728F620", VA = "0x187290A20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HNMIELCAEFA> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x7290A20", Offset = "0x728F620", VA = "0x187290A20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class PIFJFLBEDAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public PIFJFLBEDAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x727A7D0", Offset = "0x72793D0", VA = "0x18727A7D0")]
			internal Label NDAJDFPAAEF(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x727A7D0", Offset = "0x72793D0", VA = "0x18727A7D0")]
			internal Label KEIEPDJLJJM(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly HNMIELCAEFA[] FNMJPBDFKCK;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] EAODGAANAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong NEMDOAJKGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int EPAONLOANJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string KNGEIFIBLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private HNMIELCAEFA[] IAMIMPBDKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] EGJIEBHBNOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int HDFABDCMCAG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool EEMOOLAJAGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5A88F70", Offset = "0x5A87B70", VA = "0x185A88F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x72897F0", Offset = "0x72883F0", VA = "0x1872897F0")]
		public HNMIELCAEFA(ulong DPHIOKCFMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7288770", Offset = "0x7287370", VA = "0x187288770")]
		public HNMIELCAEFA MPFJKDGCCNN(ulong DPHIOKCFMFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7288970", Offset = "0x7287570", VA = "0x187288970")]
		public HNMIELCAEFA MPFJKDGCCNN(ulong DPHIOKCFMFC, int GLMEMJNJKAN, string KNGEIFIBLDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7288270", Offset = "0x7286E70", VA = "0x187288270")]
		public HNMIELCAEFA KAPAKBBABIB(byte[] GEBOGBKBFPH, int MANKJHLJMBO, int HLFNIJJHJDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x72896B0", Offset = "0x72882B0", VA = "0x1872896B0")]
		internal static int OMHMLLHACCB(ulong[] CHPEIOMPEEH, int OPDMGNJCACB, int JKBHNDINMGD, ulong GLMEMJNJKAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7288240", Offset = "0x7286E40", VA = "0x187288240", Slot = "4")]
		public int CompareTo(HNMIELCAEFA OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x72881C0", Offset = "0x7286DC0", VA = "0x1872881C0")]
		[IteratorStateMachine(typeof(LHOBODFPGDF))]
		public IEnumerable<HNMIELCAEFA> BMGBKEDJHLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x72883F0", Offset = "0x7286FF0", VA = "0x1872883F0")]
		public void LNLHOJCCLGJ(ILGenerator FJKNCOLKKEL, LocalBuilder GEBOGBKBFPH, LocalBuilder HLFNIJJHJDM, LocalBuilder DPHIOKCFMFC, Action<KeyValuePair<string, int>> BHHEFKJPEPP, Action EFCHIKFEALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x72889D0", Offset = "0x72875D0", VA = "0x1872889D0")]
		private static void NCNGGICDBAA(ILGenerator FJKNCOLKKEL, LocalBuilder GEBOGBKBFPH, LocalBuilder HLFNIJJHJDM, LocalBuilder DPHIOKCFMFC, Action<KeyValuePair<string, int>> BHHEFKJPEPP, Action EFCHIKFEALM, HNMIELCAEFA[] IAMIMPBDKKJ, int HDFABDCMCAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class ECAKJLPJEGG : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<HNMIELCAEFA> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<HNMIELCAEFA> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<HNMIELCAEFA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private HNMIELCAEFA <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xC225E0", Offset = "0xC211E0", VA = "0x180C225E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7283050", Offset = "0x7281C50", VA = "0x187283050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E67020", Offset = "0x1E65C20", VA = "0x181E67020")]
		[DebuggerHidden]
		public ECAKJLPJEGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x72830A0", Offset = "0x7281CA0", VA = "0x1872830A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7282AF0", Offset = "0x72816F0", VA = "0x187282AF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7282AA0", Offset = "0x72816A0", VA = "0x187282AA0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7282A50", Offset = "0x7281650", VA = "0x187282A50")]
		private void CJOPDLOOCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7283000", Offset = "0x7281C00", VA = "0x187283000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7282F50", Offset = "0x7281B50", VA = "0x187282F50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7282F50", Offset = "0x7281B50", VA = "0x187282F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly HNMIELCAEFA BLPDMPJLPPJ;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x72946A0", Offset = "0x72932A0", VA = "0x1872946A0")]
	public PIFENEHKMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7294500", Offset = "0x7293100", VA = "0x187294500")]
	public void MPFJKDGCCNN(byte[] HNGDLLNOPEB, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x72940E0", Offset = "0x7292CE0", VA = "0x1872940E0")]
	public bool FCHJBKLNGFJ(ArraySegment<byte> DPHIOKCFMFC, [Out] int GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7294610", Offset = "0x7293210", VA = "0x187294610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x72941C0", Offset = "0x7292DC0", VA = "0x1872941C0")]
	private static void GIBBLDPFBPI(IEnumerable<HNMIELCAEFA> IAMIMPBDKKJ, StringBuilder NBPCAOJAPOF, int PPFCFICLEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x72944A0", Offset = "0x72930A0", VA = "0x1872944A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x72944A0", Offset = "0x72930A0", VA = "0x1872944A0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7294030", Offset = "0x7292C30", VA = "0x187294030")]
	[IteratorStateMachine(typeof(ECAKJLPJEGG))]
	private static IEnumerable<KeyValuePair<string, int>> ADKCJBHJHAL(IEnumerable<HNMIELCAEFA> IAMIMPBDKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x72940B0", Offset = "0x7292CB0", VA = "0x1872940B0")]
	public void CODKJKBFOKH(ILGenerator FJKNCOLKKEL, LocalBuilder GEBOGBKBFPH, LocalBuilder HLFNIJJHJDM, LocalBuilder DPHIOKCFMFC, Action<KeyValuePair<string, int>> BHHEFKJPEPP, Action EFCHIKFEALM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class BHOPEAEEAPA
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo NDMGGNPLIKP;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x727F680", Offset = "0x727E280", VA = "0x18727F680")]
	public static ulong KINMLGGJOOD(byte[] HNGDLLNOPEB, int MANKJHLJMBO, int HLFNIJJHJDM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class KOMPKICHCKI
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x72900D0", Offset = "0x728ECD0", VA = "0x1872900D0")]
	public static void CFJLBIBDBCN(byte[] HNGDLLNOPEB, int MANKJHLJMBO, int EOINLPBLINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x728FFB0", Offset = "0x728EBB0", VA = "0x18728FFB0")]
	public static void BBHJNNEBPPA(byte[] CHPEIOMPEEH, int DKJJICELCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7290210", Offset = "0x728EE10", VA = "0x187290210")]
	public static byte[] PIGGGKOFMIH(byte[] AIFEMCDFFGN, int DKJJICELCNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class IIOCBFJACBC
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72898B0", Offset = "0x72884B0", VA = "0x1872898B0")]
	public static bool NKPGMPOIHJL(byte[] IOLBJPAOGCO, int APCELMMHONA, int HMENIMGIIHN, byte[] KNBNFMMCJLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class CHFKKLFIFFL<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct GAMJNEKLCEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] NEMDOAJKGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T EPAONLOANJK;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C2A0", Offset = "0x3C6AEA0", VA = "0x183C6C2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class CJEDEBBPFHK : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public CHFKKLFIFFL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private GAMJNEKLCEL[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private GAMJNEKLCEL[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xC225E0", Offset = "0xC211E0", VA = "0x180C225E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B930C0", Offset = "0x3B91CC0", VA = "0x183B930C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public CJEDEBBPFHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x529B6E0", Offset = "0x529A2E0", VA = "0x18529B6E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x529C2D0", Offset = "0x529AED0", VA = "0x18529C2D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly GAMJNEKLCEL[][] FLFKFNKANKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong NDGJKMHECEI;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x51BCF20", Offset = "0x51BBB20", VA = "0x1851BCF20")]
	public CHFKKLFIFFL(int ECCOECALPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x51BCF60", Offset = "0x51BBB60", VA = "0x1851BCF60")]
	public CHFKKLFIFFL(int ECCOECALPKO, float ECCPMAJMGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x51BC510", Offset = "0x51BB110", VA = "0x1851BC510")]
	public void MPFJKDGCCNN(byte[] DPHIOKCFMFC, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x51B8AE0", Offset = "0x51B76E0", VA = "0x1851B8AE0")]
	private bool BFJHLHBCIFH(byte[] DPHIOKCFMFC, T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x51BAEB0", Offset = "0x51B9AB0", VA = "0x1851BAEB0")]
	public bool CMBHFEACNLN(ArraySegment<byte> DPHIOKCFMFC, [Out] T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x51BCED0", Offset = "0x51BBAD0", VA = "0x1851BCED0")]
	private static ulong OGBGJOLBLGL(byte[] KNFDPFPHEON, int MANKJHLJMBO, int HDFABDCMCAG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x46FF150", Offset = "0x46FDD50", VA = "0x1846FF150")]
	private static int NGKENGEKHFE(int FCFJKJAGIKL, float ECCPMAJMGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x51BC240", Offset = "0x51BAE40", VA = "0x1851BC240", Slot = "4")]
	[IteratorStateMachine(typeof(CHFKKLFIFFL<>.CJEDEBBPFHK))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A50F60", Offset = "0x3A4FB60", VA = "0x183A50F60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class FDEMDAPBNCB : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] MAKCFHCNHFG;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] JGIMILPIFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int JEHAFHOMMHO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DGGBFMCMIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7283540", Offset = "0x7282140", VA = "0x187283540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7283690", Offset = "0x7282290", VA = "0x187283690")]
	static FDEMDAPBNCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72838F0", Offset = "0x72824F0", VA = "0x1872838F0")]
	public FDEMDAPBNCB(byte[] GGIKHOHKHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7283590", Offset = "0x7282190", VA = "0x187283590")]
	public OpCode DLCPJAMIABM()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct KECLFENOLPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid EPAONLOANJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte HEOPMBNNPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte FPIBKAKGCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte CECJDJNPAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte NBMKAOMKENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte BKNOFNKFGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte GGGOAEAECOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte INEJDLMCLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte LPBHCKBMOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte CBLLCDPCIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte FEBJOLCCGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte EMLIHKIDNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte AJIDHHAPINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte MAGHCALBBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte IENKJFJGOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte JBFAGMBBPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte JCJCINEPJNI;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] OHGJOHJEJLH;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] ABPJMPHBHOO;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x728FFA0", Offset = "0x728EBA0", VA = "0x18728FFA0")]
	public KECLFENOLPO(Guid GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x728E850", Offset = "0x728D450", VA = "0x18728E850")]
	public KECLFENOLPO(ArraySegment<byte> PJHJKGEJNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x728E6C0", Offset = "0x728D2C0", VA = "0x18728E6C0")]
	private static byte LNHLNOKPCEJ(byte[] HNGDLLNOPEB, int NODPNIJJKGA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x728D8F0", Offset = "0x728C4F0", VA = "0x18728D8F0")]
	private static byte LEAECJMOBBN(byte EIKHFLMLKJH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x728DA10", Offset = "0x728C610", VA = "0x18728DA10")]
	public void LLMINMLBJFM(byte[] BKHGNPANPPB, int MANKJHLJMBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class BKOJDAIJCLI
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7280F10", Offset = "0x727FB10", VA = "0x187280F10")]
	public static bool JDLIANLHMAJ(byte PIIKINJOJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x72804F0", Offset = "0x727F0F0", VA = "0x1872804F0")]
	public static bool CKJIEPKAACK(byte PIIKINJOJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7280E30", Offset = "0x727FA30", VA = "0x187280E30")]
	public static sbyte IBFFOOHFHGC(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7281150", Offset = "0x727FD50", VA = "0x187281150")]
	public static short LFLDOABBOIE(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7281C80", Offset = "0x7280880", VA = "0x187281C80")]
	public static int MKPKJCAKKJN(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x72810B0", Offset = "0x727FCB0", VA = "0x1872810B0")]
	public static long KAJMOJJDEBI(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7280470", Offset = "0x727F070", VA = "0x187280470")]
	public static byte BLAAIEEJICA(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7280F20", Offset = "0x727FB20", VA = "0x187280F20")]
	public static ushort JHEBFCOCKFD(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7281C00", Offset = "0x7280800", VA = "0x187281C00")]
	public static uint MEEMEJMKKGO(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7280FA0", Offset = "0x727FBA0", VA = "0x187280FA0")]
	public static ulong JKDGEFHGBGO(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x72802B0", Offset = "0x727EEB0", VA = "0x1872802B0")]
	public static float ACPNKPDHJKL(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7280390", Offset = "0x727EF90", VA = "0x187280390")]
	public static double BEBJOABJOKD(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7280790", Offset = "0x727F390", VA = "0x187280790")]
	public static int GEMJMFHKNFG(byte[] BKHGNPANPPB, int MANKJHLJMBO, ulong GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7281240", Offset = "0x727FE40", VA = "0x187281240")]
	public static int LIJHCCIHLJA(byte[] BKHGNPANPPB, int MANKJHLJMBO, long GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7280560", Offset = "0x727F160", VA = "0x187280560")]
	public static bool FHBHLKOMLBO(byte[] HNGDLLNOPEB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class NAPIOLODJCM
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class HJGLDBJCDNH : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
		[DebuggerHidden]
		public HJGLDBJCDNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7287980", Offset = "0x7286580", VA = "0x187287980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7287440", Offset = "0x7286040", VA = "0x187287440", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x72873F0", Offset = "0x7285FF0", VA = "0x1872873F0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x72873A0", Offset = "0x7285FA0", VA = "0x1872873A0")]
		private void CJOPDLOOCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7287930", Offset = "0x7286530", VA = "0x187287930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7287870", Offset = "0x7286470", VA = "0x187287870", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7287870", Offset = "0x7286470", VA = "0x187287870", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class HNIAAAINAIL : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
		[DebuggerHidden]
		public HNIAAAINAIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7288090", Offset = "0x7286C90", VA = "0x187288090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7287B50", Offset = "0x7286750", VA = "0x187287B50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7287B00", Offset = "0x7286700", VA = "0x187287B00")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7287AB0", Offset = "0x72866B0", VA = "0x187287AB0")]
		private void CJOPDLOOCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7288040", Offset = "0x7286C40", VA = "0x187288040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7287F80", Offset = "0x7286B80", VA = "0x187287F80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7287F80", Offset = "0x7286B80", VA = "0x187287F80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7291230", Offset = "0x728FE30", VA = "0x187291230")]
	public static bool OCINGGAPIHA(this TypeInfo NCNNODEFPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7290EC0", Offset = "0x728FAC0", VA = "0x187290EC0")]
	public static bool DKAMLBIAEBK(this TypeInfo NCNNODEFPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x72911B0", Offset = "0x728FDB0", VA = "0x1872911B0")]
	public static IEnumerable<PropertyInfo> MAGFDJMFJLK(this Type NCNNODEFPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7290FF0", Offset = "0x728FBF0", VA = "0x187290FF0")]
	[IteratorStateMachine(typeof(HJGLDBJCDNH))]
	private static IEnumerable<PropertyInfo> EMPFEHPLDDA(Type NCNNODEFPOG, HashSet<string> KBIIHGIHICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7291090", Offset = "0x728FC90", VA = "0x187291090")]
	public static IEnumerable<FieldInfo> FHFJFPEHIDI(this Type NCNNODEFPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7291110", Offset = "0x728FD10", VA = "0x187291110")]
	[IteratorStateMachine(typeof(HNIAAAINAIL))]
	private static IEnumerable<FieldInfo> JEIJBNAECNA(Type NCNNODEFPOG, HashSet<string> KBIIHGIHICL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class GJPEHJIPBAF
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding GOGJNJACKHJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class IPKECJMKNOJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static string EABAKJNGLKO(string AOENKIEOODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x728B610", Offset = "0x728A210", VA = "0x18728B610")]
	public static string CFHONJPOIAA(string AOENKIEOODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x728B480", Offset = "0x728A080", VA = "0x18728B480")]
	public static string AJFGKELBOOJ(string AOENKIEOODJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class PHCICKCOHEP<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class NLADCKOAKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type NEMDOAJKGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue EPAONLOANJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int EMLOEPPMHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public NLADCKOAKHI FKLDIJDCIAH;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x449B900", Offset = "0x449A500", VA = "0x18449B900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x449B8C0", Offset = "0x449A4C0", VA = "0x18449B8C0")]
		private int FPIENNPNDKO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NLADCKOAKHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class CLGFINPGDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CLGFINPGDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0")]
		internal TValue PPCNKCONHMB(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private NLADCKOAKHI[] FLFKFNKANKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int AEOJMEBJNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object OEOAOAKNDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float ECCPMAJMGPG;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x46FFAD0", Offset = "0x46FE6D0", VA = "0x1846FFAD0")]
	public PHCICKCOHEP(int ECCOECALPKO = 4, float ECCPMAJMGPG = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x46FEFD0", Offset = "0x46FDBD0", VA = "0x1846FEFD0")]
	public bool GOFOFMOGKHH(Type DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x46FEF80", Offset = "0x46FDB80", VA = "0x1846FEF80")]
	public bool GOFOFMOGKHH(Type DPHIOKCFMFC, Func<Type, TValue> GCIEPOGGOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x46FE650", Offset = "0x46FD250", VA = "0x1846FE650")]
	private bool BFJHLHBCIFH(Type DPHIOKCFMFC, Func<Type, TValue> GCIEPOGGOBE, [Out] TValue FNHIIJJJDDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x46FF180", Offset = "0x46FDD80", VA = "0x1846FF180")]
	private bool NOEBLIFFFJP(NLADCKOAKHI[] FLFKFNKANKD, Type HNNKOFCEECL, NLADCKOAKHI PDMNMOONMFL, Func<Type, TValue> GCIEPOGGOBE, [Out] TValue FNHIIJJJDDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x46FE9E0", Offset = "0x46FD5E0", VA = "0x1846FE9E0")]
	public bool CMBHFEACNLN(Type DPHIOKCFMFC, [Out] TValue GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x46FED10", Offset = "0x46FD910", VA = "0x1846FED10")]
	public TValue ENOIPAMOKHG(Type DPHIOKCFMFC, Func<Type, TValue> GCIEPOGGOBE)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x46FF150", Offset = "0x46FDD50", VA = "0x1846FF150")]
	private static int NGKENGEKHFE(int FCFJKJAGIKL, float ECCPMAJMGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x46FF120", Offset = "0x46FDD20", VA = "0x1846FF120")]
	private static void KELNELBOOOF(NLADCKOAKHI KOINAPBFLMG, NLADCKOAKHI GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x46FF120", Offset = "0x46FDD20", VA = "0x1846FF120")]
	private static void KELNELBOOOF(NLADCKOAKHI[] KOINAPBFLMG, NLADCKOAKHI[] GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class LDPJAIHDHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder NBJPCELPBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder HPJFEBKMKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object KPDGPKJEHHG;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7290340", Offset = "0x728EF40", VA = "0x187290340")]
	public TypeBuilder ILNHIMGLOHB(string GFLNGGKHEOH, TypeAttributes LNDLJLLLJKF, Type GPMGJNAOOEP, Type[] LPKMBLJLDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7290440", Offset = "0x728F040", VA = "0x187290440")]
	public LDPJAIHDHFO(string NNCNKENGDBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class NFGOKHPOHFC
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x72912F0", Offset = "0x728FEF0", VA = "0x1872912F0")]
	private static MethodInfo IIJLKKMEENC(LambdaExpression LGMJEDJKCOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2C9EA90", Offset = "0x2C9D690", VA = "0x182C9EA90")]
	public static MethodInfo BMEIKAGOBNI<T>(Expression<Func<T>> LGMJEDJKCOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2C9EA90", Offset = "0x2C9D690", VA = "0x182C9EA90")]
	public static MethodInfo BMEIKAGOBNI<T, TR>(Expression<Func<T, TR>> LGMJEDJKCOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2C9EA90", Offset = "0x2C9D690", VA = "0x182C9EA90")]
	public static MethodInfo BMEIKAGOBNI<T>(Expression<Action<T>> LGMJEDJKCOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2C9EA90", Offset = "0x2C9D690", VA = "0x182C9EA90")]
	public static MethodInfo BMEIKAGOBNI<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> LGMJEDJKCOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2C9EB50", Offset = "0x2C9D750", VA = "0x182C9EB50")]
	private static MemberInfo KPMKAOOEEGH<T>(Expression<T> OGOLDJHPDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2C9EAA0", Offset = "0x2C9D6A0", VA = "0x182C9EAA0")]
	public static PropertyInfo HPPHGPDOKPF<T, TR>(Expression<Func<T, TR>> LGMJEDJKCOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct BNOKAKIBBNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int EKELKKECGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool KBDIMBONLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator FJKNCOLKKEL;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7281F00", Offset = "0x7280B00", VA = "0x187281F00")]
	public BNOKAKIBBNJ(ILGenerator FJKNCOLKKEL, int EKELKKECGGF, bool KBDIMBONLDA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7281E70", Offset = "0x7280A70", VA = "0x187281E70")]
	public BNOKAKIBBNJ(ILGenerator FJKNCOLKKEL, int EKELKKECGGF, Type NCNNODEFPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7281D70", Offset = "0x7280970", VA = "0x187281D70")]
	public void ADHLIOOBLPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class AKMKPAIJNOF
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x727EBC0", Offset = "0x727D7C0", VA = "0x18727EBC0")]
	public static void ENAFGEJFFGM(this ILGenerator FJKNCOLKKEL, int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x727EDB0", Offset = "0x727D9B0", VA = "0x18727EDB0")]
	public static void ENAFGEJFFGM(this ILGenerator FJKNCOLKKEL, LocalBuilder BOIPJNFGHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x727EE90", Offset = "0x727DA90", VA = "0x18727EE90")]
	public static void IEMFMPJMCLG(this ILGenerator FJKNCOLKKEL, int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x727F080", Offset = "0x727DC80", VA = "0x18727F080")]
	public static void IEMFMPJMCLG(this ILGenerator FJKNCOLKKEL, LocalBuilder BOIPJNFGHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x727E950", Offset = "0x727D550", VA = "0x18727E950")]
	public static void CGPBKHFOADM(this ILGenerator FJKNCOLKKEL, int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x727EA30", Offset = "0x727D630", VA = "0x18727EA30")]
	public static void CGPBKHFOADM(this ILGenerator FJKNCOLKKEL, LocalBuilder BOIPJNFGHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x727EB30", Offset = "0x727D730", VA = "0x18727EB30")]
	public static void CNJNEGMEHCN(this ILGenerator FJKNCOLKKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x727EDF0", Offset = "0x727D9F0", VA = "0x18727EDF0")]
	public static void FJBLEFNGOMG(this ILGenerator FJKNCOLKKEL, bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x727E380", Offset = "0x727CF80", VA = "0x18727E380")]
	public static void ADBJACIEJOM(this ILGenerator FJKNCOLKKEL, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x727F0C0", Offset = "0x727DCC0", VA = "0x18727F0C0")]
	public static void KADGNODKPJK(this ILGenerator FJKNCOLKKEL, Type NCNNODEFPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x727F400", Offset = "0x727E000", VA = "0x18727F400")]
	public static void PLJPFCKOIHP(this ILGenerator FJKNCOLKKEL, Type NCNNODEFPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x727E760", Offset = "0x727D360", VA = "0x18727E760")]
	public static void CBNECGKEFNJ(this ILGenerator FJKNCOLKKEL, int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x727EB40", Offset = "0x727D740", VA = "0x18727EB40")]
	public static void DHDJFDBHMNN(this ILGenerator FJKNCOLKKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x727F1A0", Offset = "0x727DDA0", VA = "0x18727F1A0")]
	public static void KBJPDKMDMEC(this ILGenerator FJKNCOLKKEL, int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x727F310", Offset = "0x727DF10", VA = "0x18727F310")]
	public static void PBJHEENDHLL(this ILGenerator FJKNCOLKKEL, MethodInfo FNCMANLIHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x727F280", Offset = "0x727DE80", VA = "0x18727F280")]
	public static void KIOJINGJMOG(this ILGenerator FJKNCOLKKEL, FieldInfo MLHEFKGHNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x727EE00", Offset = "0x727DA00", VA = "0x18727EE00")]
	public static void FMFDGPLLPIB(this ILGenerator FJKNCOLKKEL, ulong GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class FOIIBAGBBOB
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class FICJJOBCPCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public FICJJOBCPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7283A70", Offset = "0x7282670", VA = "0x187283A70")]
		internal bool OBBOGPNLNFH(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo NMGDANFKDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo OFAHBHCGIIM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string NGMMEOLPMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GBKEPBFKMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7283CF0", Offset = "0x72828F0", VA = "0x187283CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool APEBLJAKNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x843300", Offset = "0x841F00", VA = "0x180843300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8431F0", Offset = "0x841DF0", VA = "0x1808431F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JOIBJCIBDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA8A910", Offset = "0xA89510", VA = "0x180A8A910")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA8A300", Offset = "0xA88F00", VA = "0x180A8A300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type AJCKJIKGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo HOEHHPDLEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo CLFBIAAONCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x843310", Offset = "0x841F10", VA = "0x180843310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo EPJDMHDMPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x843230", Offset = "0x841E30", VA = "0x180843230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7284110", Offset = "0x7282D10", VA = "0x187284110")]
	protected FOIIBAGBBOB(Type NCNNODEFPOG, string GFLNGGKHEOH, string CPPGNGCGNIK, bool EJODPKLMKBE, bool CNEIGLIFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7284000", Offset = "0x7282C00", VA = "0x187284000")]
	public FOIIBAGBBOB(FieldInfo KONMDJKGHML, string GFLNGGKHEOH, bool DHJCKJBPGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7284190", Offset = "0x7282D90", VA = "0x187284190")]
	public FOIIBAGBBOB(PropertyInfo KONMDJKGHML, string GFLNGGKHEOH, bool DHJCKJBPGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7283B80", Offset = "0x7282780", VA = "0x187283B80")]
	private static MethodInfo CAIAECADGAL(MemberInfo KONMDJKGHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC0F0", Offset = "0x2AFACF0", VA = "0x182AFC0F0")]
	public T OBPMKALEONO<T>(bool PJHFMPBBDAA) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7283E80", Offset = "0x7282A80", VA = "0x187283E80", Slot = "4")]
	public virtual void LBJDLHGFPCK(ILGenerator FJKNCOLKKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7283D00", Offset = "0x7282900", VA = "0x187283D00", Slot = "5")]
	public virtual void GBFNIMMBBLI(ILGenerator FJKNCOLKKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class LFMFLHCJBNP : FOIIBAGBBOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string BNLOIFBNHCM;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x72906F0", Offset = "0x728F2F0", VA = "0x1872906F0")]
	public LFMFLHCJBNP(string GFLNGGKHEOH, string BNLOIFBNHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7290640", Offset = "0x728F240", VA = "0x187290640", Slot = "4")]
	public override void LBJDLHGFPCK(ILGenerator FJKNCOLKKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x72905F0", Offset = "0x728F1F0", VA = "0x1872905F0", Slot = "5")]
	public override void GBFNIMMBBLI(ILGenerator FJKNCOLKKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class GFOCPDJNHGJ : FOIIBAGBBOB
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo KNCEGIMHENO;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo KLALDDOJPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal BNOKAKIBBNJ EGODBFKFKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal BNOKAKIBBNJ GNBAEJJKBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal BNOKAKIBBNJ NAOCBHILMGG;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7284D10", Offset = "0x7283910", VA = "0x187284D10")]
	public GFOCPDJNHGJ(string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7284730", Offset = "0x7283330", VA = "0x187284730", Slot = "4")]
	public override void LBJDLHGFPCK(ILGenerator FJKNCOLKKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x72846E0", Offset = "0x72832E0", VA = "0x1872846E0", Slot = "5")]
	public override void GBFNIMMBBLI(ILGenerator FJKNCOLKKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7284520", Offset = "0x7283120", VA = "0x187284520")]
	public void APJJCIMFCGL(ILGenerator FJKNCOLKKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class NMFPKGGJEDC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type AJCKJIKGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LFLNKNLOLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x90BF40", Offset = "0x90AB40", VA = "0x18090BF40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x852F20", Offset = "0x851B20", VA = "0x180852F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EJHENAOLJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9666A0", Offset = "0x9652A0", VA = "0x1809666A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA89160", Offset = "0xA87D60", VA = "0x180A89160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo IGAIOADLJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FOIIBAGBBOB[] MHJGBLKKCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FOIIBAGBBOB[] FBKGBGFCJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x72914B0", Offset = "0x72900B0", VA = "0x1872914B0")]
	public NMFPKGGJEDC(Type NCNNODEFPOG, Func<string, string> GKPLOCPMKLB, bool DHJCKJBPGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x72913D0", Offset = "0x728FFD0", VA = "0x1872913D0")]
	private static bool PGPOLFMBPNO(IEnumerator<ConstructorInfo> AFDBOKPGBMG, ConstructorInfo DKDBLFGLBID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct PHJJGLBLEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong DIOFPOHOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int INCJNHFIGKH;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EB20", Offset = "0x1F7D720", VA = "0x181F7EB20")]
	public PHJJGLBLEAJ(ulong MNKNCPHMLCC, int NJFHIJLOCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7293EE0", Offset = "0x7292AE0", VA = "0x187293EE0")]
	public void FFCAOJGJMIE(PHJJGLBLEAJ OCNJFCPHJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7293F80", Offset = "0x7292B80", VA = "0x187293F80")]
	public static PHJJGLBLEAJ KAAAHGIAIGN(PHJJGLBLEAJ NABHBOMGBNH, PHJJGLBLEAJ EIKHFLMLKJH)
	{
		return default(PHJJGLBLEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7293E50", Offset = "0x7292A50", VA = "0x187293E50")]
	public void DGFMHNDKPLE(PHJJGLBLEAJ OCNJFCPHJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7293F90", Offset = "0x7292B90", VA = "0x187293F90")]
	public static PHJJGLBLEAJ PIPLKMABEFF(PHJJGLBLEAJ NABHBOMGBNH, PHJJGLBLEAJ EIKHFLMLKJH)
	{
		return default(PHJJGLBLEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7293EF0", Offset = "0x7292AF0", VA = "0x187293EF0")]
	public void GHIIBMKKPFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7293F30", Offset = "0x7292B30", VA = "0x187293F30")]
	public static PHJJGLBLEAJ GHIIBMKKPFD(PHJJGLBLEAJ NABHBOMGBNH)
	{
		return default(PHJJGLBLEAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct PMAANKHLDGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] BKHGNPANPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int MANKJHLJMBO;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1A95FF0", Offset = "0x1A94BF0", VA = "0x181A95FF0")]
	public PMAANKHLDGO(byte[] BKHGNPANPPB, int DFPHDEDIHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x727CC60", Offset = "0x727B860", VA = "0x18727CC60")]
	public void IBKIIDAHCED(byte OGFFIPCKAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x72948F0", Offset = "0x72934F0", VA = "0x1872948F0")]
	public void EGFDMIMPFGG(byte[] OGFFIPCKAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7294970", Offset = "0x7293570", VA = "0x187294970")]
	public void IBPOINDEJDL(byte[] OGFFIPCKAML, int JKBHNDINMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x72949F0", Offset = "0x72935F0", VA = "0x1872949F0")]
	public void IBPOINDEJDL(byte[] OGFFIPCKAML, int BGCAJHMJIFE, int JKBHNDINMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7294B90", Offset = "0x7293790", VA = "0x187294B90")]
	public void MLIBKGAFFNC(byte PIIKINJOJMJ, int HDFABDCMCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7294A90", Offset = "0x7293690", VA = "0x187294A90")]
	public void MHPOILMFKHI(string OGFFIPCKAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class JFACADPEBDE
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum AFLKCBPPMIG
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum FLFMEEPFGHO
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum PCHHKDFEJNH
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
	private static byte[] MCIFPJPEOFI;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] NDPOMLKFEDD;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] OFCLJKOEBGO;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] HEEMGDPCAMN;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly PCHHKDFEJNH LCEGHOGEOGH;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char IJMDKBDFCEB;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int KFGLHOMDJBM;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int CMDIBCCLPKG;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] NIEBMOEPOIB;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x728C7A0", Offset = "0x728B3A0", VA = "0x18728C7A0")]
	private static byte[] FBOKOEMELII(int AEOJMEBJNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x728C6C0", Offset = "0x728B2C0", VA = "0x18728C6C0")]
	private static byte[] EGOLLDPMHFI(int AEOJMEBJNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x728B7E0", Offset = "0x728A3E0", VA = "0x18728B7E0")]
	public static int AOBKNKHMIPC(byte[] BKHGNPANPPB, int MANKJHLJMBO, float GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x728B900", Offset = "0x728A500", VA = "0x18728B900")]
	public static int AOBKNKHMIPC(byte[] BKHGNPANPPB, int MANKJHLJMBO, double GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x728C980", Offset = "0x728B580", VA = "0x18728C980")]
	private static bool MKMNOHKJDIC(byte[] BKHGNPANPPB, int JKBHNDINMGD, ulong OGJLNGIGOIK, ulong MIBIPNDCPOO, ulong HLFNIJJHJDM, ulong DOKAIAPPFKJ, ulong DOGJGAFFNJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x728B6F0", Offset = "0x728A2F0", VA = "0x18728B6F0")]
	private static void AJBMBMGAOPA(uint LOENGGJKFDK, int NPBJBDFNEMP, [Out] uint PLCDGNDKJGN, [Out] int LMLMLFLFOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x728D0C0", Offset = "0x728BCC0", VA = "0x18728D0C0")]
	private static bool NOIAIHCNKPO(PHJJGLBLEAJ JDPMIJELLLH, PHJJGLBLEAJ NLPLEHNHDEH, PHJJGLBLEAJ FMJNAPNCMON, byte[] BKHGNPANPPB, [Out] int JKBHNDINMGD, [Out] int JPMOKAHJBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x728CC40", Offset = "0x728B840", VA = "0x18728CC40")]
	private static bool NMMJFKLLKEH(double BGNEHGMDHMD, AFLKCBPPMIG CMLBPDKMHGL, byte[] BKHGNPANPPB, [Out] int JKBHNDINMGD, [Out] int NKOABKINILO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x728C870", Offset = "0x728B470", VA = "0x18728C870")]
	private static bool JEPNOKGPNOI(double BGNEHGMDHMD, AFLKCBPPMIG CMLBPDKMHGL, byte[] BKHGNPANPPB, [Out] int JKBHNDINMGD, [Out] int BNMLNMIHCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x728CA70", Offset = "0x728B670", VA = "0x18728CA70")]
	private static bool MPADBJJDGHL(double GLMEMJNJKAN, PMAANKHLDGO NABNLFGGNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x728C1E0", Offset = "0x728ADE0", VA = "0x18728C1E0")]
	private static bool CGNIJJFDMMK(double GLMEMJNJKAN, PMAANKHLDGO NABNLFGGNEJ, FLFMEEPFGHO CMLBPDKMHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x728BA20", Offset = "0x728A620", VA = "0x18728BA20")]
	private static void BLAODPGLIDK(byte[] CIEGBLEEOAP, int JKBHNDINMGD, int BNMLNMIHCMH, int DEKAPOPMKOJ, PMAANKHLDGO NABNLFGGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x728BDB0", Offset = "0x728A9B0", VA = "0x18728BDB0")]
	private static void CFCCBJCJHOJ(byte[] CIEGBLEEOAP, int JKBHNDINMGD, int NJFHIJLOCCI, PMAANKHLDGO NABNLFGGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x728D4B0", Offset = "0x728C0B0", VA = "0x18728D4B0")]
	private static bool OJNHLEJDKEE(double BGNEHGMDHMD, FLFMEEPFGHO CMLBPDKMHGL, int LGPOBOFBGJJ, byte[] FDDDOEFBAEI, [Out] bool CIBCKNDPOPG, [Out] int JKBHNDINMGD, [Out] int EJEEODBGEBC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct KPDAFANJBAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double BKMPOHCPCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong DCNKFFEGPJB;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct BDANPAKJDOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float DIOFPOHOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint GKOPMAPPNJP;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct DFLCEECHOJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong ADAJJMKNKMD;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x72828C0", Offset = "0x72814C0", VA = "0x1872828C0")]
	public DFLCEECHOJJ(double BKMPOHCPCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7282820", Offset = "0x7281420", VA = "0x187282820")]
	public DFLCEECHOJJ(PHJJGLBLEAJ BKMPOHCPCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x72825D0", Offset = "0x72811D0", VA = "0x1872825D0")]
	public PHJJGLBLEAJ GECKIBCMPOL()
	{
		return default(PHJJGLBLEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7282290", Offset = "0x7280E90", VA = "0x187282290")]
	public PHJJGLBLEAJ AGKHDFMPGPK()
	{
		return default(PHJJGLBLEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
	public ulong BDIPPBCPKBF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7282480", Offset = "0x7281080", VA = "0x187282480")]
	public double DDCMFOFHCCJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7282690", Offset = "0x7281290", VA = "0x187282690")]
	public double KCHJFKBHOIH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7282520", Offset = "0x7281120", VA = "0x187282520")]
	public int EFKKHBOODNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7282550", Offset = "0x7281150", VA = "0x187282550")]
	public ulong EKBAANBOFMG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7282460", Offset = "0x7281060", VA = "0x187282460")]
	public bool BGIMFOBHOBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7282670", Offset = "0x7281270", VA = "0x187282670")]
	public bool ICLCKKBEKAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7282730", Offset = "0x7281330", VA = "0x187282730")]
	public bool MCOILMNILNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7282640", Offset = "0x7281240", VA = "0x187282640")]
	public bool HHIMFKDBELP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7282760", Offset = "0x7281360", VA = "0x187282760")]
	public int MEANDIFHHMP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7282310", Offset = "0x7280F10", VA = "0x187282310")]
	public void BBPLIIJHBOE([Out] PHJJGLBLEAJ MDNLABAAEKK, [Out] PHJJGLBLEAJ DDIOFHJOKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7282580", Offset = "0x7281180", VA = "0x187282580")]
	public bool GBNKOCHCOOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x317F6E0", Offset = "0x317E2E0", VA = "0x18317F6E0")]
	public double GLMEMJNJKAN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7282500", Offset = "0x7281100", VA = "0x187282500")]
	public static int DMDKIHDMMAH(int MMANKKFGKMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7282810", Offset = "0x7281410", VA = "0x187282810")]
	public static double NNJJMMLBMMH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7282780", Offset = "0x7281380", VA = "0x187282780")]
	public static ulong MPJPOMJBPLI(PHJJGLBLEAJ CFILHDIIAJL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct GINPKLFDNOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint DICONBJDALH;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x21469F0", Offset = "0x21455F0", VA = "0x1821469F0")]
	public GINPKLFDNOO(float DIOFPOHOGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7285110", Offset = "0x7283D10", VA = "0x187285110")]
	public PHJJGLBLEAJ GECKIBCMPOL()
	{
		return default(PHJJGLBLEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
	public uint OLBCJFEJALK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7285090", Offset = "0x7283C90", VA = "0x187285090")]
	public int EFKKHBOODNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x72850B0", Offset = "0x7283CB0", VA = "0x1872850B0")]
	public uint EKBAANBOFMG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7285080", Offset = "0x7283C80", VA = "0x187285080")]
	public bool BGIMFOBHOBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7284F50", Offset = "0x7283B50", VA = "0x187284F50")]
	public void BBPLIIJHBOE([Out] PHJJGLBLEAJ MDNLABAAEKK, [Out] PHJJGLBLEAJ DDIOFHJOKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x72850D0", Offset = "0x7283CD0", VA = "0x1872850D0")]
	public bool GBNKOCHCOOM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct AMOJJLGHMPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong MNKNCPHMLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short NGNAEEHKJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short NKOABKINILO;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x727F670", Offset = "0x727E270", VA = "0x18727F670")]
	public AMOJJLGHMPK(ulong MNKNCPHMLCC, short NGNAEEHKJBF, short NKOABKINILO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class NPFGBNNCOJH
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly AMOJJLGHMPK[] LCEICCEAKII;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7292A40", Offset = "0x7291640", VA = "0x187292A40")]
	public static void MPDNMNEBFHG(int LBHEJINDHND, int JMJCHFLABNI, [Out] PHJJGLBLEAJ PLCDGNDKJGN, [Out] int NKOABKINILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7292970", Offset = "0x7291570", VA = "0x187292970")]
	public static void CHFOBNLKPIH(int HJIKIFMAGEF, [Out] PHJJGLBLEAJ PLCDGNDKJGN, [Out] int NEFHKCLHJLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct LFAGIJABODH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] HNGDLLNOPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int BGCAJHMJIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int BBFGEFMDDFL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7290550", Offset = "0x728F150", VA = "0x187290550")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D4ED60", Offset = "0x3D4D960", VA = "0x183D4ED60")]
	public LFAGIJABODH(byte[] HNGDLLNOPEB, int BGCAJHMJIFE, int JKBHNDINMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2191D70", Offset = "0x2190970", VA = "0x182191D70")]
	public int JKBHNDINMGD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7290590", Offset = "0x728F190", VA = "0x187290590")]
	public LFAGIJABODH OFMBAMHGFBC(int FODGPLAKPJP, int PJFHHDPNDJM)
	{
		return default(LFAGIJABODH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class HIEMJEMGIPO
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] NPNNLLOCOGD;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] KGBGJDHLGAM;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int LHFMHJKHOEH;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7287200", Offset = "0x7285E00", VA = "0x187287200")]
	private static byte[] NLEJLGHFDFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7286580", Offset = "0x7285180", VA = "0x187286580")]
	private static LFAGIJABODH GBEFFINCBEA(LFAGIJABODH BKHGNPANPPB)
	{
		return default(LFAGIJABODH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7286BD0", Offset = "0x72857D0", VA = "0x187286BD0")]
	private static LFAGIJABODH JDCAHKFNBNJ(LFAGIJABODH BKHGNPANPPB)
	{
		return default(LFAGIJABODH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7285A20", Offset = "0x7284620", VA = "0x187285A20")]
	private static void ANCFCEOCDKG(LFAGIJABODH BKHGNPANPPB, int NJFHIJLOCCI, byte[] FNBMDIIAHNJ, [Out] int HHJFMHKHHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7286CB0", Offset = "0x72858B0", VA = "0x187286CB0")]
	private static void KNOKFGIDLBM(LFAGIJABODH BKHGNPANPPB, int NJFHIJLOCCI, byte[] HFDMFCKGPDE, int FEDJEDJGLLD, [Out] LFAGIJABODH IIGHJPOGMAD, [Out] int COGALIMCKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7286100", Offset = "0x7284D00", VA = "0x187286100")]
	private static ulong BEELABHHLBL(LFAGIJABODH BKHGNPANPPB, [Out] int ICMFMIOOLOB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7286FA0", Offset = "0x7285BA0", VA = "0x187286FA0")]
	private static void LOOCLHJEICP(LFAGIJABODH BKHGNPANPPB, [Out] PHJJGLBLEAJ JFBAIGMLPKE, [Out] int JMDIHBDCNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7286660", Offset = "0x7285260", VA = "0x187286660")]
	private static bool GKJBCMDBMMB(LFAGIJABODH IIGHJPOGMAD, int NJFHIJLOCCI, [Out] double JFBAIGMLPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7286A30", Offset = "0x7285630", VA = "0x187286A30")]
	private static PHJJGLBLEAJ GOENNIEEFNB(int NJFHIJLOCCI)
	{
		return default(PHJJGLBLEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7285AB0", Offset = "0x72846B0", VA = "0x187285AB0")]
	private static bool AOFMOOJGBBP(LFAGIJABODH BKHGNPANPPB, int NJFHIJLOCCI, [Out] double JFBAIGMLPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7286190", Offset = "0x7284D90", VA = "0x187286190")]
	private static bool BHBGPPHFOAM(LFAGIJABODH IIGHJPOGMAD, int NJFHIJLOCCI, [Out] double BIDFAJAHMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x72870E0", Offset = "0x7285CE0", VA = "0x1872870E0")]
	public static double? NAOJALBOHMP(LFAGIJABODH BKHGNPANPPB, int NJFHIJLOCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x72862B0", Offset = "0x7284EB0", VA = "0x1872862B0")]
	public static float? FNJCODJGLNO(LFAGIJABODH BKHGNPANPPB, int NJFHIJLOCCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct GLPOFMBDDAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] BKHGNPANPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int MANKJHLJMBO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7285220", Offset = "0x7283E20", VA = "0x187285220")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1A95FF0", Offset = "0x1A94BF0", VA = "0x181A95FF0")]
	public GLPOFMBDDAJ(byte[] BKHGNPANPPB, int MANKJHLJMBO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7285350", Offset = "0x7283F50", VA = "0x187285350")]
	public static GLPOFMBDDAJ ONBIPDGOMJM(GLPOFMBDDAJ HNFMOHFACKF)
	{
		return default(GLPOFMBDDAJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7285250", Offset = "0x7283E50", VA = "0x187285250")]
	public static GLPOFMBDDAJ DGBGNIFIBBK(GLPOFMBDDAJ HNFMOHFACKF, int JKBHNDINMGD)
	{
		return default(GLPOFMBDDAJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x72852D0", Offset = "0x7283ED0", VA = "0x1872852D0")]
	public static int HHHBBILIKNK(GLPOFMBDDAJ HLHDFJDLHFM, GLPOFMBDDAJ GIHDHONABPM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x72852E0", Offset = "0x7283EE0", VA = "0x1872852E0")]
	public static bool NBAHCGFACIA(GLPOFMBDDAJ HLHDFJDLHFM, GLPOFMBDDAJ GIHDHONABPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7285390", Offset = "0x7283F90", VA = "0x187285390")]
	public static bool OONFJEHFBJE(GLPOFMBDDAJ HLHDFJDLHFM, GLPOFMBDDAJ GIHDHONABPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x72852F0", Offset = "0x7283EF0", VA = "0x1872852F0")]
	public static bool NBAHCGFACIA(GLPOFMBDDAJ HLHDFJDLHFM, char GIHDHONABPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7285360", Offset = "0x7283F60", VA = "0x187285360")]
	public static bool OONFJEHFBJE(GLPOFMBDDAJ HLHDFJDLHFM, char GIHDHONABPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7285360", Offset = "0x7283F60", VA = "0x187285360")]
	public static bool OONFJEHFBJE(GLPOFMBDDAJ HLHDFJDLHFM, byte GIHDHONABPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x72851F0", Offset = "0x7283DF0", VA = "0x1872851F0")]
	public static bool AOLCAPIMEFO(GLPOFMBDDAJ HLHDFJDLHFM, char GIHDHONABPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x72852A0", Offset = "0x7283EA0", VA = "0x1872852A0")]
	public static bool FEBJHEHIAAC(GLPOFMBDDAJ HLHDFJDLHFM, char GIHDHONABPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7285320", Offset = "0x7283F20", VA = "0x187285320")]
	public static bool NJPCCEDOPLP(GLPOFMBDDAJ HLHDFJDLHFM, char GIHDHONABPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x72853A0", Offset = "0x7283FA0", VA = "0x1872853A0")]
	public static bool PNGLBFPCAHN(GLPOFMBDDAJ HLHDFJDLHFM, char GIHDHONABPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class ILMFMKCLIMK
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] DLOLKDMHJAI;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] ILMGMHHHELJ;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] OFCLJKOEBGO;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] HEEMGDPCAMN;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] LOFHHGAEGJA;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int EIMAEIEFLHG;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] KLGOJIHOCBE;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int LCJKCAAHIJL;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x728ABF0", Offset = "0x72897F0", VA = "0x18728ABF0")]
	private static byte[] GEGJGIDDCPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x728AEA0", Offset = "0x7289AA0", VA = "0x18728AEA0")]
	private static byte[] LKBFPIKKMMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x728ACD0", Offset = "0x72898D0", VA = "0x18728ACD0")]
	public static double HIGOPDHHALK(byte[] BKHGNPANPPB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x728ADF0", Offset = "0x72899F0", VA = "0x18728ADF0")]
	public static float LAJDOLKOLKL(byte[] BKHGNPANPPB, int MANKJHLJMBO, [Out] int EEKGNFKNJFA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7289B10", Offset = "0x7288710", VA = "0x187289B10")]
	private static bool CECGFGGCFNC(int KNFDPFPHEON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7289920", Offset = "0x7288520", VA = "0x187289920")]
	private static bool ANOKIOFPGEP(GLPOFMBDDAJ JEGHDCOJDAN, GLPOFMBDDAJ JPLEPBDKKLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x728AF80", Offset = "0x7289B80", VA = "0x18728AF80")]
	private static bool LNCGJKDLIJD(GLPOFMBDDAJ JEGHDCOJDAN, GLPOFMBDDAJ JPLEPBDKKLH, byte[] HMJLHMBDFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x728ADA0", Offset = "0x72899A0", VA = "0x18728ADA0")]
	private static bool KBJCNENFBOL(GLPOFMBDDAJ OJIHOABBLKN, byte[] OGFFIPCKAML, int MANKJHLJMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x728AD80", Offset = "0x7289980", VA = "0x18728AD80")]
	private static double IELDEJENLOA(bool CIBCKNDPOPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7289C50", Offset = "0x7288850", VA = "0x187289C50")]
	private static double FKJHMKJCIFF(GLPOFMBDDAJ HJNPKADFMMO, int JKBHNDINMGD, bool DPONDAHFNEG, [Out] int KIKHNMLMLOJ)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class JIPKICEILHE<T> : DLJMBCMBIMD<T[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly GPGFCAODBEH<T> OKMKHGEOJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly IKOCBLBDMIC FOPKJAMJBNC;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x380A330", Offset = "0x3808F30", VA = "0x18380A330")]
	public JIPKICEILHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
	public JIPKICEILHE(IKOCBLBDMIC FOPKJAMJBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4064C90", Offset = "0x4063890", VA = "0x184064C90", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x40648C0", Offset = "0x40634C0", VA = "0x1840648C0", Slot = "5")]
	public T[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class GFKBNACFBMA<T> : DLJMBCMBIMD<ArraySegment<T>>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly GPGFCAODBEH<T> OKMKHGEOJJD;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3C993A0", Offset = "0x3C97FA0", VA = "0x183C993A0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ArraySegment<T> GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3C98F70", Offset = "0x3C97B70", VA = "0x183C98F70", Slot = "5")]
	public ArraySegment<T> EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class PMPPPEBNIKL<T> : DLJMBCMBIMD<List<T>>, NKAPOBPAPKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly IKOCBLBDMIC FOPKJAMJBNC;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x380A330", Offset = "0x3808F30", VA = "0x18380A330")]
	public PMPPPEBNIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
	public PMPPPEBNIKL(IKOCBLBDMIC FOPKJAMJBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x477E1F0", Offset = "0x477CDF0", VA = "0x18477E1F0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, List<T> GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x477BD30", Offset = "0x477A930", VA = "0x18477BD30", Slot = "5")]
	public List<T> EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class MGBGMHMNMOM<TElement, TIntermediate, TEnumerator, TCollection> : DLJMBCMBIMD<TCollection>, NKAPOBPAPKD where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x43F7880", Offset = "0x43F6480", VA = "0x1843F7880", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, TCollection GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x43F61E0", Offset = "0x43F4DE0", VA = "0x1843F61E0", Slot = "5")]
	public TCollection EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator NDCAOOPEPAC(TCollection OGOLDJHPDFA);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GADNMLFOLLL();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void MPFJKDGCCNN(TIntermediate KHFMAIAPCOA, int OPDMGNJCACB, TElement GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection IKNIENNEJLD(TIntermediate GPOIHCIBDEE);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected MGBGMHMNMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class LLAKNOGJFDF<TElement, TIntermediate, TCollection> : MGBGMHMNMOM<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x4214690", Offset = "0x4213290", VA = "0x184214690", Slot = "6")]
	protected override IEnumerator<TElement> NDCAOOPEPAC(TCollection OGOLDJHPDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3784140", Offset = "0x3782D40", VA = "0x183784140")]
	protected LLAKNOGJFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class EFGKOGLBOBG<TElement, TCollection> : LLAKNOGJFDF<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected sealed override TCollection IKNIENNEJLD(TCollection GPOIHCIBDEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class BHJBOABMNEG<TElement, TCollection> : EFGKOGLBOBG<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4E5B240", Offset = "0x4E59E40", VA = "0x184E5B240", Slot = "7")]
	protected override TCollection GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4E5B270", Offset = "0x4E59E70", VA = "0x184E5B270", Slot = "8")]
	protected override void MPFJKDGCCNN(TCollection KHFMAIAPCOA, int OPDMGNJCACB, TElement GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class JGOAHBGDAOJ<T> : MGBGMHMNMOM<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2D30", Offset = "0x3BD1930", VA = "0x183BD2D30", Slot = "8")]
	protected override void MPFJKDGCCNN(LinkedList<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override LinkedList<T> IKNIENNEJLD(LinkedList<T> GPOIHCIBDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override LinkedList<T> GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x403F400", Offset = "0x403E000", VA = "0x18403F400", Slot = "6")]
	protected override LinkedList<T>.Enumerator NDCAOOPEPAC(LinkedList<T> OGOLDJHPDFA)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class FNFKHJMGICK<T> : MGBGMHMNMOM<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2D30", Offset = "0x3BD1930", VA = "0x183BD2D30", Slot = "8")]
	protected override void MPFJKDGCCNN(Queue<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override Queue<T> GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2D90", Offset = "0x3BD1990", VA = "0x183BD2D90", Slot = "6")]
	protected override Queue<T>.Enumerator NDCAOOPEPAC(Queue<T> OGOLDJHPDFA)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override Queue<T> IKNIENNEJLD(Queue<T> GPOIHCIBDEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class NELLAPLOONN<T> : MGBGMHMNMOM<T, CDOHGKGBFBD<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD150", Offset = "0x3CBBD50", VA = "0x183CBD150", Slot = "8")]
	protected override void MPFJKDGCCNN(CDOHGKGBFBD<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x440FEE0", Offset = "0x440EAE0", VA = "0x18440FEE0", Slot = "7")]
	protected override CDOHGKGBFBD<T> GADNMLFOLLL()
	{
		return default(CDOHGKGBFBD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x448C750", Offset = "0x448B350", VA = "0x18448C750", Slot = "6")]
	protected override Stack<T>.Enumerator NDCAOOPEPAC(Stack<T> OGOLDJHPDFA)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x448C650", Offset = "0x448B250", VA = "0x18448C650", Slot = "9")]
	protected override Stack<T> IKNIENNEJLD(CDOHGKGBFBD<T> GPOIHCIBDEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class CAGBCHOCHDC<T> : MGBGMHMNMOM<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2D30", Offset = "0x3BD1930", VA = "0x183BD2D30", Slot = "8")]
	protected override void MPFJKDGCCNN(HashSet<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override HashSet<T> IKNIENNEJLD(HashSet<T> GPOIHCIBDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override HashSet<T> GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2D90", Offset = "0x3BD1990", VA = "0x183BD2D90", Slot = "6")]
	protected override HashSet<T>.Enumerator NDCAOOPEPAC(HashSet<T> OGOLDJHPDFA)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class ABDKNOONAIM<T> : LLAKNOGJFDF<T, CDOHGKGBFBD<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD150", Offset = "0x3CBBD50", VA = "0x183CBD150", Slot = "8")]
	protected override void MPFJKDGCCNN(CDOHGKGBFBD<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD0A0", Offset = "0x3CBBCA0", VA = "0x183CBD0A0", Slot = "9")]
	protected override ReadOnlyCollection<T> IKNIENNEJLD(CDOHGKGBFBD<T> GPOIHCIBDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD070", Offset = "0x3CBBC70", VA = "0x183CBD070", Slot = "7")]
	protected override CDOHGKGBFBD<T> GADNMLFOLLL()
	{
		return default(CDOHGKGBFBD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class IIACOOPDNCM<T> : LLAKNOGJFDF<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2D30", Offset = "0x3BD1930", VA = "0x183BD2D30", Slot = "8")]
	protected override void MPFJKDGCCNN(List<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override List<T> GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override IList<T> IKNIENNEJLD(List<T> GPOIHCIBDEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class KOPLAFEDBOG<T> : LLAKNOGJFDF<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2D30", Offset = "0x3BD1930", VA = "0x183BD2D30", Slot = "8")]
	protected override void MPFJKDGCCNN(List<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override List<T> GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override ICollection<T> IKNIENNEJLD(List<T> GPOIHCIBDEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class ONFFKAHHMME<T> : LLAKNOGJFDF<T, CDOHGKGBFBD<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD150", Offset = "0x3CBBD50", VA = "0x183CBD150", Slot = "8")]
	protected override void MPFJKDGCCNN(CDOHGKGBFBD<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x440FEE0", Offset = "0x440EAE0", VA = "0x18440FEE0", Slot = "7")]
	protected override CDOHGKGBFBD<T> GADNMLFOLLL()
	{
		return default(CDOHGKGBFBD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4650F10", Offset = "0x464FB10", VA = "0x184650F10", Slot = "9")]
	protected override IEnumerable<T> IKNIENNEJLD(CDOHGKGBFBD<T> GPOIHCIBDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x379C8C0", Offset = "0x379B4C0", VA = "0x18379C8C0")]
	public ONFFKAHHMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class DHFOPLIMCFO<TKey, TElement> : DLJMBCMBIMD<IGrouping<TKey, TElement>>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x57D5BD0", Offset = "0x57D47D0", VA = "0x1857D5BD0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, IGrouping<TKey, TElement> GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x57D58D0", Offset = "0x57D44D0", VA = "0x1857D58D0", Slot = "5")]
	public IGrouping<TKey, TElement> EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class FHMDGMIGCEK<TKey, TElement> : DLJMBCMBIMD<ILookup<TKey, TElement>>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5080", Offset = "0x3BA3C80", VA = "0x183BA5080", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ILookup<TKey, TElement> GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4D20", Offset = "0x3BA3920", VA = "0x183BA4D20", Slot = "5")]
	public ILookup<TKey, TElement> EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class POKKGIKDMDP<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey DPHIOKCFMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> KPAOLMPLIAP;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey NEMDOAJKGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
	public POKKGIKDMDP(TKey DPHIOKCFMFC, IEnumerable<TElement> KPAOLMPLIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x47835A0", Offset = "0x47821A0", VA = "0x1847835A0", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x386BB30", Offset = "0x386A730", VA = "0x18386BB30", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class CIGHCBKKCFL<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> ONPDFGHDCBN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3C683A0", Offset = "0x3C66FA0", VA = "0x183C683A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public CIGHCBKKCFL(Dictionary<TKey, IGrouping<TKey, TElement>> ONPDFGHDCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x26D2720", Offset = "0x26D1320", VA = "0x1826D2720", Slot = "5")]
	public bool Contains(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x5297390", Offset = "0x5295F90", VA = "0x185297390", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5297390", Offset = "0x5295F90", VA = "0x185297390", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BDCAFCFMELG<T> : DLJMBCMBIMD<T>, NKAPOBPAPKD where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4E29700", Offset = "0x4E28300", VA = "0x184E29700", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x4E29490", Offset = "0x4E28090", VA = "0x184E29490", Slot = "5")]
	public T EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BDCAFCFMELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class BOMOCCPBJDB : DLJMBCMBIMD<IEnumerable>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly DLJMBCMBIMD<IEnumerable> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7297660", Offset = "0x7296260", VA = "0x187297660", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, IEnumerable GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x72973F0", Offset = "0x7295FF0", VA = "0x1872973F0", Slot = "5")]
	public IEnumerable EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BOMOCCPBJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class AEEGPHIIOOC : DLJMBCMBIMD<ICollection>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly DLJMBCMBIMD<ICollection> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7296980", Offset = "0x7295580", VA = "0x187296980", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ICollection GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7296710", Offset = "0x7295310", VA = "0x187296710", Slot = "5")]
	public ICollection EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public AEEGPHIIOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class OLMBIIKLMCA : DLJMBCMBIMD<IList>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly DLJMBCMBIMD<IList> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x72A41A0", Offset = "0x72A2DA0", VA = "0x1872A41A0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, IList GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x72A3F30", Offset = "0x72A2B30", VA = "0x1872A3F30", Slot = "5")]
	public IList EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OLMBIIKLMCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class MKFGEHPCIHF<T> : LLAKNOGJFDF<T, CDOHGKGBFBD<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x440FF70", Offset = "0x440EB70", VA = "0x18440FF70", Slot = "8")]
	protected override void MPFJKDGCCNN(CDOHGKGBFBD<T> KHFMAIAPCOA, int OPDMGNJCACB, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x440FEE0", Offset = "0x440EAE0", VA = "0x18440FEE0", Slot = "7")]
	protected override CDOHGKGBFBD<T> GADNMLFOLLL()
	{
		return default(CDOHGKGBFBD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x440FF10", Offset = "0x440EB10", VA = "0x18440FF10", Slot = "9")]
	protected override IReadOnlyList<T> IKNIENNEJLD(CDOHGKGBFBD<T> GPOIHCIBDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x379C170", Offset = "0x379AD70", VA = "0x18379C170")]
	public MKFGEHPCIHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class MEOKDPBHAEB
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x72A0DA0", Offset = "0x729F9A0", VA = "0x1872A0DA0")]
	public static DateTime JLMDAAHIEBI(DateTime BJLJAPCDCJC)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class OBLAHMCOHAJ : DLJMBCMBIMD<DateTime>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly DLJMBCMBIMD<DateTime> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x72A2540", Offset = "0x72A1140", VA = "0x1872A2540", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, DateTime GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x72A1830", Offset = "0x72A0430", VA = "0x1872A1830", Slot = "5")]
	public DateTime EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OBLAHMCOHAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class INDMDGDFNCH : DLJMBCMBIMD<DateTimeOffset>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly DLJMBCMBIMD<DateTimeOffset> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x729E360", Offset = "0x729CF60", VA = "0x18729E360", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, DateTimeOffset GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x729D740", Offset = "0x729C340", VA = "0x18729D740", Slot = "5")]
	public DateTimeOffset EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public INDMDGDFNCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class IBLMDFIKELG : DLJMBCMBIMD<TimeSpan>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly DLJMBCMBIMD<TimeSpan> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] BIDBIBPOGHD;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x729CD00", Offset = "0x729B900", VA = "0x18729CD00", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, TimeSpan GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x729C3F0", Offset = "0x729AFF0", VA = "0x18729C3F0", Slot = "5")]
	public TimeSpan EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public IBLMDFIKELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class GLDPKHFHKCO<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : DLJMBCMBIMD<TDictionary>, NKAPOBPAPKD where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC780", Offset = "0x3CBB380", VA = "0x183CBC780", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, TDictionary GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9D80", Offset = "0x3CB8980", VA = "0x183CB9D80", Slot = "5")]
	public TDictionary EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator NDCAOOPEPAC(TDictionary OGOLDJHPDFA);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GADNMLFOLLL();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void MPFJKDGCCNN(TIntermediate KHFMAIAPCOA, int OPDMGNJCACB, TKey DPHIOKCFMFC, TValue GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary IKNIENNEJLD(TIntermediate GPOIHCIBDEE);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected GLDPKHFHKCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class PGEMCNDPDLH<TKey, TValue, TIntermediate, TDictionary> : GLDPKHFHKCO<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x4214690", Offset = "0x4213290", VA = "0x184214690", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> NDCAOOPEPAC(TDictionary OGOLDJHPDFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class POPAJLJDHFL<TKey, TValue, TDictionary> : PGEMCNDPDLH<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override TDictionary IKNIENNEJLD(TDictionary GPOIHCIBDEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class JPDHBDJJBMM<TKey, TValue> : GLDPKHFHKCO<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x4078B00", Offset = "0x4077700", VA = "0x184078B00", Slot = "8")]
	protected override void MPFJKDGCCNN(Dictionary<TKey, TValue> KHFMAIAPCOA, int OPDMGNJCACB, TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override Dictionary<TKey, TValue> IKNIENNEJLD(Dictionary<TKey, TValue> GPOIHCIBDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override Dictionary<TKey, TValue> GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x4078C50", Offset = "0x4077850", VA = "0x184078C50", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator NDCAOOPEPAC(Dictionary<TKey, TValue> OGOLDJHPDFA)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x37832C0", Offset = "0x3781EC0", VA = "0x1837832C0")]
	public JPDHBDJJBMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class CAMBNPGDJPD<TKey, TValue, TDictionary> : POPAJLJDHFL<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x50C13D0", Offset = "0x50BFFD0", VA = "0x1850C13D0", Slot = "8")]
	protected override void MPFJKDGCCNN(TDictionary KHFMAIAPCOA, int OPDMGNJCACB, TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x35472F0", Offset = "0x3545EF0", VA = "0x1835472F0", Slot = "7")]
	protected override TDictionary GADNMLFOLLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class DLANJCGJINF<TKey, TValue> : PGEMCNDPDLH<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3010", Offset = "0x3BA1C10", VA = "0x183BA3010", Slot = "8")]
	protected override void MPFJKDGCCNN(Dictionary<TKey, TValue> KHFMAIAPCOA, int OPDMGNJCACB, TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override Dictionary<TKey, TValue> GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override IDictionary<TKey, TValue> IKNIENNEJLD(Dictionary<TKey, TValue> GPOIHCIBDEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class FHBFNEOBJJB<TKey, TValue> : POPAJLJDHFL<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3010", Offset = "0x3BA1C10", VA = "0x183BA3010", Slot = "8")]
	protected override void MPFJKDGCCNN(SortedList<TKey, TValue> KHFMAIAPCOA, int OPDMGNJCACB, TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override SortedList<TKey, TValue> GADNMLFOLLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class OLCMPEOHCFF<TKey, TValue> : GLDPKHFHKCO<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3010", Offset = "0x3BA1C10", VA = "0x183BA3010", Slot = "8")]
	protected override void MPFJKDGCCNN(SortedDictionary<TKey, TValue> KHFMAIAPCOA, int OPDMGNJCACB, TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> IKNIENNEJLD(SortedDictionary<TKey, TValue> GPOIHCIBDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1B90", VA = "0x183BA2F90", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> GADNMLFOLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x4078BE0", Offset = "0x40777E0", VA = "0x184078BE0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator NDCAOOPEPAC(SortedDictionary<TKey, TValue> OGOLDJHPDFA)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class LOBJPHADMPG<T> : DLJMBCMBIMD<T>, NKAPOBPAPKD where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x42274B0", Offset = "0x42260B0", VA = "0x1842274B0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x4227200", Offset = "0x4225E00", VA = "0x184227200", Slot = "5")]
	public T EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LOBJPHADMPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class FDPIPPEAJNC : DLJMBCMBIMD<IDictionary>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly DLJMBCMBIMD<IDictionary> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7299170", Offset = "0x7297D70", VA = "0x187299170", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, IDictionary GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7298F40", Offset = "0x7297B40", VA = "0x187298F40", Slot = "5")]
	public IDictionary EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public FDPIPPEAJNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class OLEOKOGKLCC : DLJMBCMBIMD<object>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void FGLILDHEHNL(object PHJMGMHAKDL, OKKKEEDEAED AKHHKFNOJLO, object GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly PHCICKCOHEP<KeyValuePair<object, FGLILDHEHNL>> FBADKFEMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly MODONKLHHGL[] HMCCEGNLECJ;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x72A3E80", Offset = "0x72A2A80", VA = "0x1872A3E80")]
	public OLEOKOGKLCC(params MODONKLHHGL[] HMCCEGNLECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x72A34B0", Offset = "0x72A20B0", VA = "0x1872A34B0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, object GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x72A3420", Offset = "0x72A2020", VA = "0x1872A3420", Slot = "5")]
	public object EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class AAJHMIOCAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7295160", Offset = "0x7293D60", VA = "0x187295160")]
	public static object JINJPLMLOID(Type NCNNODEFPOG, [Out] bool DJEOOMFAOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7295A50", Offset = "0x7294650", VA = "0x187295A50")]
	public static object KLDGJJOLDFB(Type NCNNODEFPOG, [Out] bool DJEOOMFAOFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class IKCOFIFAPKD<T> : DLJMBCMBIMD<T>, NKAPOBPAPKD, FCAPBILFKFE<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class CAOGLDILEJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CAOGLDILEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x50C17A0", Offset = "0x50C03A0", VA = "0x1850C17A0")]
		internal bool NGBKKDKAFJN(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class GGLHHHNNEFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public GGLHHHNNEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C040", Offset = "0x3C9AC40", VA = "0x183C9C040")]
		internal bool JJDCKHFFANC(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class BNDFKKCOMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public CDFDPPKODEP<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BNDFKKCOMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4E6FAB0", Offset = "0x4E6E6B0", VA = "0x184E6FAB0")]
		internal void KGCOOFDKDBI(OKKKEEDEAED writer, T value, MODONKLHHGL _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class EGGCCBCNPCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public PKJNLJHOELC<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EGGCCBCNPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x37EE740", Offset = "0x37ED340", VA = "0x1837EE740")]
		internal T DPCBBOPKDJG(KKCIDLEELDC reader, MODONKLHHGL _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly CHFKKLFIFFL<T> PFEOGMAGCBF;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> GPINFEHNCKA;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly CDFDPPKODEP<T> JIPEEAEKLBN;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly PKJNLJHOELC<T> FJGNNPGLIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool PPILIMBBMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly CDFDPPKODEP<T> KBGCOCIBGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly PKJNLJHOELC<T> GLMCOCKKABK;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3E48CB0", Offset = "0x3E478B0", VA = "0x183E48CB0")]
	static IKCOFIFAPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D590", Offset = "0x3E5C190", VA = "0x183E5D590")]
	public IKCOFIFAPKD(bool PPILIMBBMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3E41F00", Offset = "0x3E40B00", VA = "0x183E41F00", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3E3CBD0", Offset = "0x3E3B7D0", VA = "0x183E3CBD0", Slot = "5")]
	public T EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E4B0", Offset = "0x3E3D0B0", VA = "0x183E3E4B0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, T GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F9D0", Offset = "0x3E3E5D0", VA = "0x183E3F9D0", Slot = "7")]
	public T JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class ANLHHLOPLKC<T> : DLJMBCMBIMD<T[,]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DEEEB0", Offset = "0x3DEDAB0", VA = "0x183DEEEB0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T[,] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3DEEB90", Offset = "0x3DED790", VA = "0x183DEEB90", Slot = "5")]
	public T[,] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public ANLHHLOPLKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class AEHJIIIDHFP<T> : DLJMBCMBIMD<T[,,]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8710", Offset = "0x3CC7310", VA = "0x183CC8710", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T[,,] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3CC82F0", Offset = "0x3CC6EF0", VA = "0x183CC82F0", Slot = "5")]
	public T[,,] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public AEHJIIIDHFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class NAFEIKHLGNI<T> : DLJMBCMBIMD<T[,,,]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x447C370", Offset = "0x447AF70", VA = "0x18447C370", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T[,,,] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x447BE30", Offset = "0x447AA30", VA = "0x18447BE30", Slot = "5")]
	public T[,,,] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NAFEIKHLGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class NGMNFPIMCKP<T> : DLJMBCMBIMD<T?>, NKAPOBPAPKD where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x448F3E0", Offset = "0x448DFE0", VA = "0x18448F3E0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x448F070", Offset = "0x448DC70", VA = "0x18448F070", Slot = "5")]
	public T? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NGMNFPIMCKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class PLLGFBLDJLJ<T> : DLJMBCMBIMD<T?>, NKAPOBPAPKD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly DLJMBCMBIMD<T> CBILELKPMJC;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public PLLGFBLDJLJ(DLJMBCMBIMD<T> CBILELKPMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x477AE80", Offset = "0x4779A80", VA = "0x18477AE80", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, T? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x477A6C0", Offset = "0x47792C0", VA = "0x18477A6C0", Slot = "5")]
	public T? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class OGMEDOFFAHJ : DLJMBCMBIMD<sbyte>, NKAPOBPAPKD, FCAPBILFKFE<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly OGMEDOFFAHJ IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x72A3150", Offset = "0x72A1D50", VA = "0x1872A3150", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, sbyte GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x72A2FD0", Offset = "0x72A1BD0", VA = "0x1872A2FD0", Slot = "5")]
	public sbyte EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x72A3020", Offset = "0x72A1C20", VA = "0x1872A3020", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, sbyte GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x72A3090", Offset = "0x72A1C90", VA = "0x1872A3090", Slot = "7")]
	public sbyte JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OGMEDOFFAHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class LBOGEOKBKBI : DLJMBCMBIMD<sbyte?>, NKAPOBPAPKD, FCAPBILFKFE<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly LBOGEOKBKBI IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x72A06E0", Offset = "0x729F2E0", VA = "0x1872A06E0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, sbyte? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x72A0450", Offset = "0x729F050", VA = "0x1872A0450", Slot = "5")]
	public sbyte? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x72A0500", Offset = "0x729F100", VA = "0x1872A0500", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, sbyte? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x72A05C0", Offset = "0x729F1C0", VA = "0x1872A05C0", Slot = "7")]
	public sbyte? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LBOGEOKBKBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class HOGKLJPHBID : DLJMBCMBIMD<sbyte[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly HOGKLJPHBID IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x729BF00", Offset = "0x729AB00", VA = "0x18729BF00", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, sbyte[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x729BD70", Offset = "0x729A970", VA = "0x18729BD70", Slot = "5")]
	public sbyte[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public HOGKLJPHBID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class NFONLBPPDLA : DLJMBCMBIMD<short>, NKAPOBPAPKD, FCAPBILFKFE<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly NFONLBPPDLA IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x72A1350", Offset = "0x729FF50", VA = "0x1872A1350", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, short GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x72A11D0", Offset = "0x729FDD0", VA = "0x1872A11D0", Slot = "5")]
	public short EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x72A1220", Offset = "0x729FE20", VA = "0x1872A1220", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, short GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x72A1290", Offset = "0x729FE90", VA = "0x1872A1290", Slot = "7")]
	public short JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NFONLBPPDLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class HIMGFGFMOGA : DLJMBCMBIMD<short?>, NKAPOBPAPKD, FCAPBILFKFE<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly HIMGFGFMOGA IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x729B600", Offset = "0x729A200", VA = "0x18729B600", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, short? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x729B370", Offset = "0x7299F70", VA = "0x18729B370", Slot = "5")]
	public short? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x729B420", Offset = "0x729A020", VA = "0x18729B420", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, short? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x729B4E0", Offset = "0x729A0E0", VA = "0x18729B4E0", Slot = "7")]
	public short? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public HIMGFGFMOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class JGGJIBKIIOL : DLJMBCMBIMD<short[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly JGGJIBKIIOL IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x729EE70", Offset = "0x729DA70", VA = "0x18729EE70", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, short[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x729ECE0", Offset = "0x729D8E0", VA = "0x18729ECE0", Slot = "5")]
	public short[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JGGJIBKIIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class OEBABAFAOLO : DLJMBCMBIMD<int>, NKAPOBPAPKD, FCAPBILFKFE<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly OEBABAFAOLO IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x72A2EF0", Offset = "0x72A1AF0", VA = "0x1872A2EF0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, int GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x72A2D70", Offset = "0x72A1970", VA = "0x1872A2D70", Slot = "5")]
	public int EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x72A2DC0", Offset = "0x72A19C0", VA = "0x1872A2DC0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, int GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x72A2E30", Offset = "0x72A1A30", VA = "0x1872A2E30", Slot = "7")]
	public int JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OEBABAFAOLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class DAHFEJFMGAK : DLJMBCMBIMD<int?>, NKAPOBPAPKD, FCAPBILFKFE<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly DAHFEJFMGAK IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x7298450", Offset = "0x7297050", VA = "0x187298450", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, int? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x72981C0", Offset = "0x7296DC0", VA = "0x1872981C0", Slot = "5")]
	public int? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7298270", Offset = "0x7296E70", VA = "0x187298270", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, int? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7298330", Offset = "0x7296F30", VA = "0x187298330", Slot = "7")]
	public int? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public DAHFEJFMGAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class JPFGODEHGFE : DLJMBCMBIMD<int[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly JPFGODEHGFE IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x729FB20", Offset = "0x729E720", VA = "0x18729FB20", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, int[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x729F990", Offset = "0x729E590", VA = "0x18729F990", Slot = "5")]
	public int[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JPFGODEHGFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class JCMCELJJAIK : DLJMBCMBIMD<long>, NKAPOBPAPKD, FCAPBILFKFE<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly JCMCELJJAIK IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x729EC00", Offset = "0x729D800", VA = "0x18729EC00", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, long GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x729EA80", Offset = "0x729D680", VA = "0x18729EA80", Slot = "5")]
	public long EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x729EAD0", Offset = "0x729D6D0", VA = "0x18729EAD0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, long GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x729EB40", Offset = "0x729D740", VA = "0x18729EB40", Slot = "7")]
	public long JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JCMCELJJAIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class PCHEALGHBLP : DLJMBCMBIMD<long?>, NKAPOBPAPKD, FCAPBILFKFE<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly PCHEALGHBLP IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x72A4A60", Offset = "0x72A3660", VA = "0x1872A4A60", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, long? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x72A47A0", Offset = "0x72A33A0", VA = "0x1872A47A0", Slot = "5")]
	public long? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x72A4860", Offset = "0x72A3460", VA = "0x1872A4860", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, long? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x72A4920", Offset = "0x72A3520", VA = "0x1872A4920", Slot = "7")]
	public long? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PCHEALGHBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class IBJBGCEKDEF : DLJMBCMBIMD<long[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly IBJBGCEKDEF IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x729C240", Offset = "0x729AE40", VA = "0x18729C240", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, long[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x729C0B0", Offset = "0x729ACB0", VA = "0x18729C0B0", Slot = "5")]
	public long[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public IBJBGCEKDEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class PGICHACFFKA : DLJMBCMBIMD<byte>, NKAPOBPAPKD, FCAPBILFKFE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly PGICHACFFKA IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x72A4D20", Offset = "0x72A3920", VA = "0x1872A4D20", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, byte GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x72A4BA0", Offset = "0x72A37A0", VA = "0x1872A4BA0", Slot = "5")]
	public byte EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x72A4BF0", Offset = "0x72A37F0", VA = "0x1872A4BF0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, byte GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x72A4C60", Offset = "0x72A3860", VA = "0x1872A4C60", Slot = "7")]
	public byte JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PGICHACFFKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class HODGKGDJHDJ : DLJMBCMBIMD<byte?>, NKAPOBPAPKD, FCAPBILFKFE<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly HODGKGDJHDJ IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x729BC30", Offset = "0x729A830", VA = "0x18729BC30", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, byte? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x729B9A0", Offset = "0x729A5A0", VA = "0x18729B9A0", Slot = "5")]
	public byte? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x729BA50", Offset = "0x729A650", VA = "0x18729BA50", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, byte? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x729BB10", Offset = "0x729A710", VA = "0x18729BB10", Slot = "7")]
	public byte? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public HODGKGDJHDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class HFAMECCKOCD : DLJMBCMBIMD<ushort>, NKAPOBPAPKD, FCAPBILFKFE<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly HFAMECCKOCD IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x729B290", Offset = "0x7299E90", VA = "0x18729B290", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ushort GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x729B110", Offset = "0x7299D10", VA = "0x18729B110", Slot = "5")]
	public ushort EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x729B160", Offset = "0x7299D60", VA = "0x18729B160", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, ushort GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x729B1D0", Offset = "0x7299DD0", VA = "0x18729B1D0", Slot = "7")]
	public ushort JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public HFAMECCKOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class CPKAIKAEAGH : DLJMBCMBIMD<ushort?>, NKAPOBPAPKD, FCAPBILFKFE<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly CPKAIKAEAGH IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x7298080", Offset = "0x7296C80", VA = "0x187298080", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ushort? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7297DF0", Offset = "0x72969F0", VA = "0x187297DF0", Slot = "5")]
	public ushort? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7297EA0", Offset = "0x7296AA0", VA = "0x187297EA0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, ushort? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7297F60", Offset = "0x7296B60", VA = "0x187297F60", Slot = "7")]
	public ushort? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public CPKAIKAEAGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class GEGICIFAAPD : DLJMBCMBIMD<ushort[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly GEGICIFAAPD IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x729ACC0", Offset = "0x72998C0", VA = "0x18729ACC0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ushort[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x729AB30", Offset = "0x7299730", VA = "0x18729AB30", Slot = "5")]
	public ushort[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GEGICIFAAPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class ONIDFNNJAHO : DLJMBCMBIMD<uint>, NKAPOBPAPKD, FCAPBILFKFE<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly ONIDFNNJAHO IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x72A46C0", Offset = "0x72A32C0", VA = "0x1872A46C0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, uint GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x72A4540", Offset = "0x72A3140", VA = "0x1872A4540", Slot = "5")]
	public uint EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x72A4590", Offset = "0x72A3190", VA = "0x1872A4590", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, uint GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x72A4600", Offset = "0x72A3200", VA = "0x1872A4600", Slot = "7")]
	public uint JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public ONIDFNNJAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class MCGJEPAAPOL : DLJMBCMBIMD<uint?>, NKAPOBPAPKD, FCAPBILFKFE<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly MCGJEPAAPOL IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x72A0C60", Offset = "0x729F860", VA = "0x1872A0C60", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, uint? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x72A09D0", Offset = "0x729F5D0", VA = "0x1872A09D0", Slot = "5")]
	public uint? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x72A0A80", Offset = "0x729F680", VA = "0x1872A0A80", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, uint? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x72A0B40", Offset = "0x729F740", VA = "0x1872A0B40", Slot = "7")]
	public uint? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MCGJEPAAPOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class GCCDBKHFJNH : DLJMBCMBIMD<uint[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly GCCDBKHFJNH IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x729A630", Offset = "0x7299230", VA = "0x18729A630", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, uint[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x729A4A0", Offset = "0x72990A0", VA = "0x18729A4A0", Slot = "5")]
	public uint[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GCCDBKHFJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class BIPLKNMDJIK : DLJMBCMBIMD<ulong>, NKAPOBPAPKD, FCAPBILFKFE<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly BIPLKNMDJIK IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7297310", Offset = "0x7295F10", VA = "0x187297310", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ulong GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7297190", Offset = "0x7295D90", VA = "0x187297190", Slot = "5")]
	public ulong EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x72971E0", Offset = "0x7295DE0", VA = "0x1872971E0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, ulong GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7297250", Offset = "0x7295E50", VA = "0x187297250", Slot = "7")]
	public ulong JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BIPLKNMDJIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class JPKMOOGDNPI : DLJMBCMBIMD<ulong?>, NKAPOBPAPKD, FCAPBILFKFE<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly JPKMOOGDNPI IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x729FF90", Offset = "0x729EB90", VA = "0x18729FF90", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ulong? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x729FCD0", Offset = "0x729E8D0", VA = "0x18729FCD0", Slot = "5")]
	public ulong? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x729FD90", Offset = "0x729E990", VA = "0x18729FD90", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, ulong? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x729FE50", Offset = "0x729EA50", VA = "0x18729FE50", Slot = "7")]
	public ulong? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JPKMOOGDNPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class JIIEEGKFBDO : DLJMBCMBIMD<ulong[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly JIIEEGKFBDO IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x729F3C0", Offset = "0x729DFC0", VA = "0x18729F3C0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ulong[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x729F230", Offset = "0x729DE30", VA = "0x18729F230", Slot = "5")]
	public ulong[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JIIEEGKFBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class BPNICGDCEPJ : DLJMBCMBIMD<float>, NKAPOBPAPKD, FCAPBILFKFE<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly BPNICGDCEPJ IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7297B10", Offset = "0x7296710", VA = "0x187297B10", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, float GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7297990", Offset = "0x7296590", VA = "0x187297990", Slot = "5")]
	public float EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x72979E0", Offset = "0x72965E0", VA = "0x1872979E0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, float GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7297A50", Offset = "0x7296650", VA = "0x187297A50", Slot = "7")]
	public float JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BPNICGDCEPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class FKPFBNBECGP : DLJMBCMBIMD<float?>, NKAPOBPAPKD, FCAPBILFKFE<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly FKPFBNBECGP IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7299CC0", Offset = "0x72988C0", VA = "0x187299CC0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, float? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7299A30", Offset = "0x7298630", VA = "0x187299A30", Slot = "5")]
	public float? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7299AE0", Offset = "0x72986E0", VA = "0x187299AE0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, float? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7299BA0", Offset = "0x72987A0", VA = "0x187299BA0", Slot = "7")]
	public float? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public FKPFBNBECGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class FLHAOOJLOBB : DLJMBCMBIMD<float[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly FLHAOOJLOBB IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x729A2E0", Offset = "0x7298EE0", VA = "0x18729A2E0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, float[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x729A150", Offset = "0x7298D50", VA = "0x18729A150", Slot = "5")]
	public float[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public FLHAOOJLOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class HJNBLLJNJKO : DLJMBCMBIMD<double>, NKAPOBPAPKD, FCAPBILFKFE<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly HJNBLLJNJKO IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x729B8C0", Offset = "0x729A4C0", VA = "0x18729B8C0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, double GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x729B740", Offset = "0x729A340", VA = "0x18729B740", Slot = "5")]
	public double EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x729B790", Offset = "0x729A390", VA = "0x18729B790", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, double GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x729B800", Offset = "0x729A400", VA = "0x18729B800", Slot = "7")]
	public double JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public HJNBLLJNJKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class NPDEONDEHCL : DLJMBCMBIMD<double?>, NKAPOBPAPKD, FCAPBILFKFE<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly NPDEONDEHCL IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x72A16F0", Offset = "0x72A02F0", VA = "0x1872A16F0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, double? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x72A1430", Offset = "0x72A0030", VA = "0x1872A1430", Slot = "5")]
	public double? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x72A14F0", Offset = "0x72A00F0", VA = "0x1872A14F0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, double? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x72A15B0", Offset = "0x72A01B0", VA = "0x1872A15B0", Slot = "7")]
	public double? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NPDEONDEHCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class GDOBLEDEFAA : DLJMBCMBIMD<double[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly GDOBLEDEFAA IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x729A970", Offset = "0x7299570", VA = "0x18729A970", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, double[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x729A7E0", Offset = "0x72993E0", VA = "0x18729A7E0", Slot = "5")]
	public double[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GDOBLEDEFAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class PJJFIJKDCGC : DLJMBCMBIMD<bool>, NKAPOBPAPKD, FCAPBILFKFE<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly PJJFIJKDCGC IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x72A4F80", Offset = "0x72A3B80", VA = "0x1872A4F80", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, bool GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x72A4E00", Offset = "0x72A3A00", VA = "0x1872A4E00", Slot = "5")]
	public bool EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x72A4E50", Offset = "0x72A3A50", VA = "0x1872A4E50", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, bool GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x72A4EC0", Offset = "0x72A3AC0", VA = "0x1872A4EC0", Slot = "7")]
	public bool JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PJJFIJKDCGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class AANFBNKOBJE : DLJMBCMBIMD<bool?>, NKAPOBPAPKD, FCAPBILFKFE<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly AANFBNKOBJE IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x72965D0", Offset = "0x72951D0", VA = "0x1872965D0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, bool? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7296340", Offset = "0x7294F40", VA = "0x187296340", Slot = "5")]
	public bool? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x72963F0", Offset = "0x7294FF0", VA = "0x1872963F0", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, bool? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x72964B0", Offset = "0x72950B0", VA = "0x1872964B0", Slot = "7")]
	public bool? JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public AANFBNKOBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class FLCEMNPEIKO : DLJMBCMBIMD<bool[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly FLCEMNPEIKO IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7299F90", Offset = "0x7298B90", VA = "0x187299F90", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, bool[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7299E00", Offset = "0x7298A00", VA = "0x187299E00", Slot = "5")]
	public bool[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public FLCEMNPEIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class PNPIHLHMIOC : DLJMBCMBIMD<object>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly DLJMBCMBIMD<object> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> MJBCHIOMLDE;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x72A56B0", Offset = "0x72A42B0", VA = "0x1872A56B0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, object GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x72A5240", Offset = "0x72A3E40", VA = "0x1872A5240", Slot = "5")]
	public object EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PNPIHLHMIOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class OKLKCEGHPHE : DLJMBCMBIMD<byte[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly DLJMBCMBIMD<byte[]> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x72A32E0", Offset = "0x72A1EE0", VA = "0x1872A32E0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, byte[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x72A3230", Offset = "0x72A1E30", VA = "0x1872A3230", Slot = "5")]
	public byte[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OKLKCEGHPHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class EENOIIFHFFO : DLJMBCMBIMD<ArraySegment<byte>>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly DLJMBCMBIMD<ArraySegment<byte>> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7298D90", Offset = "0x7297990", VA = "0x187298D90", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, ArraySegment<byte> GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x7298C80", Offset = "0x7297880", VA = "0x187298C80", Slot = "5")]
	public ArraySegment<byte> EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public EENOIIFHFFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class IDHAPMMHANJ : DLJMBCMBIMD<string>, NKAPOBPAPKD, FCAPBILFKFE<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly DLJMBCMBIMD<string> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x729D340", Offset = "0x729BF40", VA = "0x18729D340", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, string GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x729D240", Offset = "0x729BE40", VA = "0x18729D240", Slot = "5")]
	public string EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x729D290", Offset = "0x729BE90", VA = "0x18729D290", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, string GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x729D2F0", Offset = "0x729BEF0", VA = "0x18729D2F0", Slot = "7")]
	public string JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public IDHAPMMHANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class KAMLHBKKDNN : DLJMBCMBIMD<string[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly KAMLHBKKDNN IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x72A02A0", Offset = "0x729EEA0", VA = "0x1872A02A0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, string[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x72A00D0", Offset = "0x729ECD0", VA = "0x1872A00D0", Slot = "5")]
	public string[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public KAMLHBKKDNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class LKJPCFIKMIM : DLJMBCMBIMD<char>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LKJPCFIKMIM IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x72A0890", Offset = "0x729F490", VA = "0x1872A0890", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, char GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x72A0820", Offset = "0x729F420", VA = "0x1872A0820", Slot = "5")]
	public char EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LKJPCFIKMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class GFPOJGGDCJH : DLJMBCMBIMD<char?>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly GFPOJGGDCJH IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x729AF90", Offset = "0x7299B90", VA = "0x18729AF90", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, char? GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x729AE70", Offset = "0x7299A70", VA = "0x18729AE70", Slot = "5")]
	public char? EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GFPOJGGDCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class AMIKNAHFGAO : DLJMBCMBIMD<char[]>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly AMIKNAHFGAO IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x7296F60", Offset = "0x7295B60", VA = "0x187296F60", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, char[] GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x7296DA0", Offset = "0x72959A0", VA = "0x187296DA0", Slot = "5")]
	public char[] EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public AMIKNAHFGAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class JNBAFAFMLLI : DLJMBCMBIMD<Guid>, NKAPOBPAPKD, FCAPBILFKFE<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly DLJMBCMBIMD<Guid> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x729F7E0", Offset = "0x729E3E0", VA = "0x18729F7E0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, Guid GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x729F570", Offset = "0x729E170", VA = "0x18729F570", Slot = "5")]
	public Guid EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x729F600", Offset = "0x729E200", VA = "0x18729F600", Slot = "6")]
	public void HBFNHIADEHK(OKKKEEDEAED AKHHKFNOJLO, Guid GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x729F740", Offset = "0x729E340", VA = "0x18729F740", Slot = "7")]
	public Guid JDHGKMNJGDP(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JNBAFAFMLLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class EAEHPIGPCMI : DLJMBCMBIMD<decimal>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly DLJMBCMBIMD<decimal> IOGFCHMIMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool BFIBAFHHKKE;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x59F8600", Offset = "0x59F7200", VA = "0x1859F8600")]
	public EAEHPIGPCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1A3A400", Offset = "0x1A39000", VA = "0x181A3A400")]
	public EAEHPIGPCMI(bool BFIBAFHHKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x7298A50", Offset = "0x7297650", VA = "0x187298A50", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, decimal GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x72987B0", Offset = "0x72973B0", VA = "0x1872987B0", Slot = "5")]
	public decimal EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class DDLHGEHPGJM : DLJMBCMBIMD<Uri>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly DLJMBCMBIMD<Uri> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7298650", Offset = "0x7297250", VA = "0x187298650", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, Uri GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7298590", Offset = "0x7297190", VA = "0x187298590", Slot = "5")]
	public Uri EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public DDLHGEHPGJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class CAEAGFGAAPG : DLJMBCMBIMD<Version>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly DLJMBCMBIMD<Version> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x7297CB0", Offset = "0x72968B0", VA = "0x187297CB0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, Version GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x7297BF0", Offset = "0x72967F0", VA = "0x187297BF0", Slot = "5")]
	public Version EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public CAEAGFGAAPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class LFMCOIMLGOI<TKey, TValue> : DLJMBCMBIMD<KeyValuePair<TKey, TValue>>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x41F6140", Offset = "0x41F4D40", VA = "0x1841F6140", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, KeyValuePair<TKey, TValue> GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x41F5E10", Offset = "0x41F4A10", VA = "0x1841F5E10", Slot = "5")]
	public KeyValuePair<TKey, TValue> EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class PJPEMCPPINM : DLJMBCMBIMD<StringBuilder>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly DLJMBCMBIMD<StringBuilder> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x72A5120", Offset = "0x72A3D20", VA = "0x1872A5120", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, StringBuilder GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x72A5060", Offset = "0x72A3C60", VA = "0x1872A5060", Slot = "5")]
	public StringBuilder EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PJPEMCPPINM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class IIMCOGHCIIL : DLJMBCMBIMD<BitArray>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly DLJMBCMBIMD<BitArray> IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x729D5A0", Offset = "0x729C1A0", VA = "0x18729D5A0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, BitArray GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x729D420", Offset = "0x729C020", VA = "0x18729D420", Slot = "5")]
	public BitArray EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public IIMCOGHCIIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class MOEFBJOIJNC : DLJMBCMBIMD<Type>, NKAPOBPAPKD
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly MOEFBJOIJNC IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex MKNEDNJFCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool FLHJIOILFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool NKHPCCKFJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool CDEFAKOLJCI;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x72A11B0", Offset = "0x729FDB0", VA = "0x1872A11B0")]
	public MOEFBJOIJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x67B72C0", Offset = "0x67B5EC0", VA = "0x1867B72C0")]
	public MOEFBJOIJNC(bool FLHJIOILFNA, bool NKHPCCKFJNN, bool CDEFAKOLJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x72A0FB0", Offset = "0x729FBB0", VA = "0x1872A0FB0", Slot = "4")]
	public void PLFEAILJDFE(OKKKEEDEAED AKHHKFNOJLO, Type GLMEMJNJKAN, MODONKLHHGL IHOLHBOPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x72A0E60", Offset = "0x729FA60", VA = "0x1872A0E60", Slot = "5")]
	public Type EGCBEAACMHC(KKCIDLEELDC GGPHPLOPODB, MODONKLHHGL IHOLHBOPION)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class JIDKAGDHKAF
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] KKAONHCMMEI;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly PIFENEHKMJH DHKJAMKCGOE;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x729F020", Offset = "0x729DC20", VA = "0x18729F020")]
	static JIDKAGDHKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class FIPKMFCOFMA
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] OIKMGFLDOEE;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly PIFENEHKMJH CMBIABBCFHC;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x7299820", Offset = "0x7298420", VA = "0x187299820")]
	static FIPKMFCOFMA()
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
