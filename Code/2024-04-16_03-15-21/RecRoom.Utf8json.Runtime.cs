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
internal static class EDCBHPDIFJC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A486E0", Offset = "0x6A478E0", VA = "0x186A486E0")]
	public static bool EHLLAMLMCIC(this TypeInfo MJMAEGDPBNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class ODFGDBPDPHO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type IHIJCALMCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DCJEOBGJHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
	public ODFGDBPDPHO(Type KKHJKOPGALE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class LKAFHDAEAAN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KJHJKMAAMHF<T>(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T JNJOLJHEMPK<T>(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ JFBDCMDHJCP);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LCGLHBCBKDI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GHLIBNINOHA<T> : LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NJDONPFLFOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MCNGMCOFFLN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class KIONHIAIMNM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2901670", Offset = "0x2900870", VA = "0x182901670")]
	public static string EFGJHKPECNN<T>(this GHLIBNINOHA<T> IEFIHALHGHN, T EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GHLIBNINOHA<T> MJEGOEMHFJG<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ILDHOAGMINK
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28BEB10", Offset = "0x28BDD10", VA = "0x1828BEB10")]
	public static GHLIBNINOHA<T> LALAPJGCIME<T>(this LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D980", Offset = "0x6A4CB80", VA = "0x186A4D980")]
	public static object FBHKMEKPHML(this LCLOMAPDCGJ JFBDCMDHJCP, Type MJMAEGDPBNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DMIODGOGOPI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A48410", Offset = "0x6A47610", VA = "0x186A48410")]
	public DMIODGOGOPI(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BBNFHGAEBCH
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class MJKOJPBAEJI
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] ENIOLEEEFGI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] PBGACNNFIOK;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F740", Offset = "0x6A4E940", VA = "0x186A4F740")]
		public static byte[] FOCDGNBOPDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F7E0", Offset = "0x6A4E9E0", VA = "0x186A4F7E0")]
		public static char[] KJOGDEOFAGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> BLBNJBGMMEP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] JINCFLKNKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] GNPAJENJDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int BMIAFODFMCE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool EKFEDMDJLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A39D10", Offset = "0x6A38F10", VA = "0x186A39D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C8D0", Offset = "0x6A3BAD0", VA = "0x186A3C8D0")]
	public BBNFHGAEBCH(byte[] GNPAJENJDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C780", Offset = "0x6A3B980", VA = "0x186A3C780")]
	public BBNFHGAEBCH(byte[] GNPAJENJDCN, int BMIAFODFMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AE10", Offset = "0x6A3A010", VA = "0x186A3AE10")]
	private ADHABINBLPA KFDCDFJMOGF(string JJGOIJENEOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A940", Offset = "0x6A39B40", VA = "0x186A3A940")]
	private ADHABINBLPA IGPFHABPOEA(string FFDOAJJEAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AE00", Offset = "0x6A3A000", VA = "0x186A3AE00")]
	public void JJNJAIKBEDK(int BMIAFODFMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
	public byte[] HLPOKOIDCBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20")]
	public int NOJOHCEDCJP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B360", Offset = "0x6A3A560", VA = "0x186A3B360")]
	public FELDBBLPKOI KIMNEPKLHDH()
	{
		return default(FELDBBLPKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AC50", Offset = "0x6A39E50", VA = "0x186A3AC50")]
	public void JCGCMIPDMHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A5E0", Offset = "0x6A397E0", VA = "0x186A3A5E0")]
	public bool GHGODEFNMHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BB10", Offset = "0x6A3AD10", VA = "0x186A3BB10")]
	public bool NIPNBFHLMEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A8A0", Offset = "0x6A39AA0", VA = "0x186A3A8A0")]
	public void ICJCBKLAMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A090", Offset = "0x6A39290", VA = "0x186A3A090")]
	public bool EJLJKIKJKJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BA40", Offset = "0x6A3AC40", VA = "0x186A3BA40")]
	public bool NGGFEJKAPLK(int KMJOEPJMADC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A39940", Offset = "0x6A38B40", VA = "0x186A39940")]
	public bool DCHBHNBBOLO(int KMJOEPJMADC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A398B0", Offset = "0x6A38AB0", VA = "0x186A398B0")]
	public bool DADMKMBGAPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A700", Offset = "0x6A39900", VA = "0x186A3A700")]
	public void HCMPMHAHLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A397A0", Offset = "0x6A389A0", VA = "0x186A397A0")]
	public bool CCPFKOBKODB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C5A0", Offset = "0x6A3B7A0", VA = "0x186A3C5A0")]
	public bool PPMBFEEMFHK(int KMJOEPJMADC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A120", Offset = "0x6A39320", VA = "0x186A3A120")]
	public bool FDMCJCENNHC(int KMJOEPJMADC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A39540", Offset = "0x6A38740", VA = "0x186A39540")]
	public bool AMNCBJNADLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A39640", Offset = "0x6A38840", VA = "0x186A39640")]
	public void CAAKGAGPBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A39F80", Offset = "0x6A39180", VA = "0x186A39F80")]
	public bool EFFOMIECHJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A39B10", Offset = "0x6A38D10", VA = "0x186A39B10")]
	public void DDJOKDCAGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BBF0", Offset = "0x6A3ADF0", VA = "0x186A3BBF0")]
	private void OJFDAHNDHMA([Out] byte[] KEDHKNFHKAB, [Out] int IHOHMOEIKFB, [Out] int IMPGHGANOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ABA0", Offset = "0x6A39DA0", VA = "0x186A3ABA0")]
	private static int JAPHCDJAMIC(char LLLCBODKBAN, char HIOEJKGFIKI, char PHDOOEGGBGI, char PCLNGBGMCCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B680", Offset = "0x6A3A880", VA = "0x186A3B680")]
	private static int MMHOPHLOLCL(char EFCGILCAOIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B920", Offset = "0x6A3AB20", VA = "0x186A3B920")]
	public ArraySegment<byte> NGBHKJGHHLL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A1F0", Offset = "0x6A393F0", VA = "0x186A3A1F0")]
	public string FKCGDIBHMKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AA30", Offset = "0x6A39C30", VA = "0x186A3AA30")]
	public string IKCBECJFPGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C380", Offset = "0x6A3B580", VA = "0x186A3C380")]
	public ArraySegment<byte> POPFPECGFFB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A395D0", Offset = "0x6A387D0", VA = "0x186A395D0")]
	public ArraySegment<byte> BFAPLAHOCNH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A39D30", Offset = "0x6A38F30", VA = "0x186A39D30")]
	public bool EBIFFLLLAHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A396E0", Offset = "0x6A388E0", VA = "0x186A396E0")]
	private static bool CBLEPBFOGOE(byte PHDOOEGGBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A2D0", Offset = "0x6A394D0", VA = "0x186A3A2D0")]
	private void FPDIPAGELAK(FELDBBLPKOI GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BBA0", Offset = "0x6A3ADA0", VA = "0x186A3BBA0")]
	public void NPKODBMKKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A39BB0", Offset = "0x6A38DB0", VA = "0x186A39BB0")]
	private void DNCFMFKOLEA(int IEGFECJLDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A7A0", Offset = "0x6A399A0", VA = "0x186A3A7A0")]
	public sbyte HHLIJGJLGPO()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A820", Offset = "0x6A39A20", VA = "0x186A3A820")]
	public short HHLKDKPJDPJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AD80", Offset = "0x6A39F80", VA = "0x186A3AD80")]
	public int JILANOEAHIJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B860", Offset = "0x6A3AA60", VA = "0x186A3B860")]
	public long NDNBPGFBGEH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A394C0", Offset = "0x6A386C0", VA = "0x186A394C0")]
	public byte ADNFEKAPELJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A010", Offset = "0x6A39210", VA = "0x186A3A010")]
	public ushort EGDDPMONBKB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A39830", Offset = "0x6A38A30", VA = "0x186A39830")]
	public uint CNONGJDLDPM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A520", Offset = "0x6A39720", VA = "0x186A3A520")]
	public ulong GAECNBIMPFG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B760", Offset = "0x6A3A960", VA = "0x186A3B760")]
	public float MOCBNMLOLCD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AAA0", Offset = "0x6A39CA0", VA = "0x186A3AAA0")]
	public double IOBCNMBIOPI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A39A10", Offset = "0x6A38C10", VA = "0x186A39A10")]
	public ArraySegment<byte> DDGLEAIJLLM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B510", Offset = "0x6A3A710", VA = "0x186A3B510")]
	private static int MLKCPEFGMDD(byte[] GNPAJENJDCN, int BMIAFODFMCE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ADHABINBLPA : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference LOFEBCFOBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int IIKCELJPBPP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int IPHPHPNFFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC61EB0", Offset = "0xC610B0", VA = "0x180C61EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string LNIGLKLFDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x87F5C0", Offset = "0x87E7C0", VA = "0x18087F5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A39460", Offset = "0x6A38660", VA = "0x186A39460")]
	public ADHABINBLPA(string FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A39370", Offset = "0x6A38570", VA = "0x186A39370")]
	public ADHABINBLPA(string FFDOAJJEAOK, byte[] HKPKFCFOLDM, int BMIAFODFMCE, int IIKCELJPBPP, string PEGLDCJMCPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CLKGCFNKGOA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class BDONFJNJHHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] ENIOLEEEFGI;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C930", Offset = "0x6A3BB30", VA = "0x186A3C930")]
		public static byte[] FOCDGNBOPDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class HDDCHBIOKHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void CPDIDJHNGHF(LCCLEIDENAE IBOFEJJMDAD, object EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object MLJIOOBBOAD(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ JFBDCMDHJCP);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class IJBKOEPKCPH
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class NNICJPHKDOK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
				public NNICJPHKDOK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x47F2020", Offset = "0x47F1220", VA = "0x1847F2020")]
				internal bool DFMPLMDDBFO(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6A50100", Offset = "0x6A4F300", VA = "0x186A50100")]
				internal bool LAHBDNANKOG(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, LCLOMAPDCGJ, byte[]> OCCGFAGMOHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, LCLOMAPDCGJ> LNBPGMNPIGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly CPDIDJHNGHF KBLKMFFNPJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, LCLOMAPDCGJ, ArraySegment<byte>> PKGICGKHKIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, LCLOMAPDCGJ, string> JPPHOIDCDCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, LCLOMAPDCGJ, object> KAPAOCCKECJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, LCLOMAPDCGJ, object> BEDNLGBFMKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, LCLOMAPDCGJ, object> KJMBMHOIEOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly MLJIOOBBOAD NKOENKDLFLE;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6A4BEA0", Offset = "0x6A4B0A0", VA = "0x186A4BEA0")]
			public IJBKOEPKCPH(Type MJMAEGDPBNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2E86E00", Offset = "0x2E86000", VA = "0x182E86E00")]
			private static T EHFMPPKIMAI<T>(DynamicMethod GBEHCOIFHNJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6A4BC50", Offset = "0x6A4AE50", VA = "0x186A4BC50")]
			private static MethodInfo OBJMECBLENI(Type MJMAEGDPBNJ, string MPENHPFDCDK, Type[] DIDDCGGEMIP)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, IJBKOEPKCPH> GFPMMHGFDIO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly KMNKKAIHKNB<IJBKOEPKCPH> HEKPLAINPKG;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B990", Offset = "0x6A4AB90", VA = "0x186A4B990")]
		static HDDCHBIOKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B690", Offset = "0x6A4A890", VA = "0x186A4B690")]
		private static IJBKOEPKCPH BEPGFLIMGIM(Type MJMAEGDPBNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B810", Offset = "0x6A4AA10", VA = "0x186A4B810")]
		public static void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, object EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B710", Offset = "0x6A4A910", VA = "0x186A4B710")]
		public static void JCBMCDNAHJB(Type MJMAEGDPBNJ, LCCLEIDENAE IBOFEJJMDAD, object EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static LCLOMAPDCGJ BJICEFLOKHO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] MAPFDCDHBBA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] ANPPJCDOHDN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static LCLOMAPDCGJ BCPACIGKKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F360", Offset = "0x6A3E560", VA = "0x186A3F360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HKJFMKICGME
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FD00", Offset = "0x6A3EF00", VA = "0x186A3FD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F2F0", Offset = "0x6A3E4F0", VA = "0x186A3F2F0")]
	public static void JLHOAEGECGF(LCLOMAPDCGJ JFBDCMDHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x26CBD00", Offset = "0x26CAF00", VA = "0x1826CBD00")]
	public static byte[] JCBMCDNAHJB<T>(T GLMGCMELGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x26CBD70", Offset = "0x26CAF70", VA = "0x1826CBD70")]
	public static byte[] JCBMCDNAHJB<T>(T EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26CC360", Offset = "0x26CB560", VA = "0x1826CC360")]
	public static void JCBMCDNAHJB<T>(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26CC210", Offset = "0x26CB410", VA = "0x1826CC210")]
	public static void JCBMCDNAHJB<T>(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26CBEE0", Offset = "0x26CB0E0", VA = "0x1826CBEE0")]
	public static void JCBMCDNAHJB<T>(Stream DBPNOPAPBJE, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26CBF60", Offset = "0x26CB160", VA = "0x1826CBF60")]
	public static void JCBMCDNAHJB<T>(Stream DBPNOPAPBJE, T EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26CC570", Offset = "0x26CB770", VA = "0x1826CC570")]
	public static ArraySegment<byte> JPNJAAPBKIN<T>(T GLMGCMELGFD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26CC3E0", Offset = "0x26CB5E0", VA = "0x1826CC3E0")]
	public static ArraySegment<byte> JPNJAAPBKIN<T>(T EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26CBC90", Offset = "0x26CAE90", VA = "0x1826CBC90")]
	public static string EFGJHKPECNN<T>(T EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26CBB20", Offset = "0x26CAD20", VA = "0x1826CBB20")]
	public static string EFGJHKPECNN<T>(T EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26CD2A0", Offset = "0x26CC4A0", VA = "0x1826CD2A0")]
	public static T MAOCPLNNJJM<T>(string KCFAOHEBNMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26CD120", Offset = "0x26CC320", VA = "0x1826CD120")]
	public static T MAOCPLNNJJM<T>(string KCFAOHEBNMJ, LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26CD730", Offset = "0x26CC930", VA = "0x1826CD730")]
	public static T MAOCPLNNJJM<T>(byte[] GNPAJENJDCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26CD210", Offset = "0x26CC410", VA = "0x1826CD210")]
	public static T MAOCPLNNJJM<T>(byte[] GNPAJENJDCN, LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x26CD640", Offset = "0x26CC840", VA = "0x1826CD640")]
	public static T MAOCPLNNJJM<T>(byte[] GNPAJENJDCN, int BMIAFODFMCE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x26CCF90", Offset = "0x26CC190", VA = "0x1826CCF90")]
	public static T MAOCPLNNJJM<T>(byte[] GNPAJENJDCN, int BMIAFODFMCE, LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26CD6C0", Offset = "0x26CC8C0", VA = "0x1826CD6C0")]
	public static T MAOCPLNNJJM<T>(BBNFHGAEBCH GILMBCDEMDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26CD330", Offset = "0x26CC530", VA = "0x1826CD330")]
	public static T MAOCPLNNJJM<T>(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26CD7A0", Offset = "0x26CC9A0", VA = "0x1826CD7A0")]
	public static T MAOCPLNNJJM<T>(Stream DBPNOPAPBJE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x26CD900", Offset = "0x26CCB00", VA = "0x1826CD900")]
	public static T MAOCPLNNJJM<T>(Stream DBPNOPAPBJE, LCLOMAPDCGJ JFBDCMDHJCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F0F0", Offset = "0x6A3E2F0", VA = "0x186A3F0F0")]
	public static string HDCGBMDPDGJ(byte[] KCFAOHEBNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EFB0", Offset = "0x6A3E1B0", VA = "0x186A3EFB0")]
	public static string HDCGBMDPDGJ(byte[] KCFAOHEBNMJ, int BMIAFODFMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EE20", Offset = "0x6A3E020", VA = "0x186A3EE20")]
	public static string HDCGBMDPDGJ(string KCFAOHEBNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ECB0", Offset = "0x6A3DEB0", VA = "0x186A3ECB0")]
	public static byte[] CAMEKCEGACC(byte[] KCFAOHEBNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E9B0", Offset = "0x6A3DBB0", VA = "0x186A3E9B0")]
	public static byte[] CAMEKCEGACC(byte[] KCFAOHEBNMJ, int BMIAFODFMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EB00", Offset = "0x6A3DD00", VA = "0x186A3EB00")]
	public static byte[] CAMEKCEGACC(string KCFAOHEBNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F450", Offset = "0x6A3E650", VA = "0x186A3F450")]
	private static void NBIHGKENLHH(BBNFHGAEBCH GILMBCDEMDA, LCCLEIDENAE IBOFEJJMDAD, int ADINCKCGEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F250", Offset = "0x6A3E450", VA = "0x186A3F250")]
	private static int IFOGJMEKOBH(Stream BHCBEHDFPNA, byte[] ENIOLEEEFGI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum FELDBBLPKOI : byte
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
public struct LCCLEIDENAE
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] NGCEPDFOLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] ENIOLEEEFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int BMIAFODFMCE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CKOKOGDEJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AE00", Offset = "0x6A3A000", VA = "0x186A3AE00")]
	public void JJNJAIKBEDK(int BMIAFODFMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E160", Offset = "0x6A4D360", VA = "0x186A4E160")]
	public static byte[] DFGDDPJMALP(string CCKNMJLGCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E450", Offset = "0x6A4D650", VA = "0x186A4E450")]
	public static byte[] FECBPILFMOO(string CCKNMJLGCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EFD0", Offset = "0x6A4E1D0", VA = "0x186A4EFD0")]
	public static byte[] NCKBHOMGGJC(string CCKNMJLGCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DF00", Offset = "0x6A4D100", VA = "0x186A4DF00")]
	public static byte[] AHBHGCHEPBP(string CCKNMJLGCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x561AFE0", Offset = "0x561A1E0", VA = "0x18561AFE0")]
	public LCCLEIDENAE(byte[] JPEICKPKHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E630", Offset = "0x6A4D830", VA = "0x186A4E630")]
	public ArraySegment<byte> FOCDGNBOPDH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EE30", Offset = "0x6A4E030", VA = "0x186A4EE30")]
	public byte[] MMKEPOKGELM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F2C0", Offset = "0x6A4E4C0", VA = "0x186A4F2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EBD0", Offset = "0x6A4DDD0", VA = "0x186A4EBD0")]
	public void KEBPPKLCJLB(int AKPNOHLPMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EF10", Offset = "0x6A4E110", VA = "0x186A4EF10")]
	public void NALNPEFPHHN(byte FHAHMKJIIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EF70", Offset = "0x6A4E170", VA = "0x186A4EF70")]
	public void NALNPEFPHHN(byte[] FHAHMKJIIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F280", Offset = "0x6A4E480", VA = "0x186A4F280")]
	public void PDGMDCBMDIK(byte FHAHMKJIIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F140", Offset = "0x6A4E340", VA = "0x186A4F140")]
	public void NDGJNGMCKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EAE0", Offset = "0x6A4DCE0", VA = "0x186A4EAE0")]
	public void JNOJOFDACPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EC80", Offset = "0x6A4DE80", VA = "0x186A4EC80")]
	public void MDAHBGAHACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E400", Offset = "0x6A4D600", VA = "0x186A4E400")]
	public void FBINAAHELEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DEB0", Offset = "0x6A4D0B0", VA = "0x186A4DEB0")]
	public void ABOBNKFKBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E290", Offset = "0x6A4D490", VA = "0x186A4E290")]
	public void EJGKOJDGPIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E2E0", Offset = "0x6A4D4E0", VA = "0x186A4E2E0")]
	public void ELOFPKIFCFJ(string CCKNMJLGCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E6D0", Offset = "0x6A4D8D0", VA = "0x186A4E6D0")]
	public void HNMOOEILPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EB30", Offset = "0x6A4DD30", VA = "0x186A4EB30")]
	public void JPCEDHMKFEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A4ECD0", Offset = "0x6A4DED0", VA = "0x186A4ECD0")]
	public void MGFFPJDKNOJ(bool EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E380", Offset = "0x6A4D580", VA = "0x186A4E380")]
	public void ELOLIIKOMCN(float EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F200", Offset = "0x6A4E400", VA = "0x186A4F200")]
	public void OIIEPLJFKIM(double EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E080", Offset = "0x6A4D280", VA = "0x186A4E080")]
	public void BHNIKEMIIJH(byte EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EEA0", Offset = "0x6A4E0A0", VA = "0x186A4EEA0")]
	public void MMNLJOMLFOJ(ushort EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E0F0", Offset = "0x6A4D2F0", VA = "0x186A4E0F0")]
	public void CEIPACNKNAO(uint EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EC50", Offset = "0x6A4DE50", VA = "0x186A4EC50")]
	public void LIOFBINJFDA(ulong EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E5C0", Offset = "0x6A4D7C0", VA = "0x186A4E5C0")]
	public void FGGAEOCEJDN(sbyte EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EBE0", Offset = "0x6A4DDE0", VA = "0x186A4EBE0")]
	public void KOGEMMGAFAM(short EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F190", Offset = "0x6A4E390", VA = "0x186A4F190")]
	public void NPBPJONLOHM(int EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E720", Offset = "0x6A4D920", VA = "0x186A4E720")]
	public void IHNBLCMDCGJ(long EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E750", Offset = "0x6A4D950", VA = "0x186A4E750")]
	public void JDCFJAGKLHI(string EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class DHHNGHKMCNM : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class FKLJEFABFJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x37BCA00", Offset = "0x37BBC00", VA = "0x1837BCA00")]
		static FKLJEFABFJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private DHHNGHKMCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class EBNLDLKEGDD : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class FOBHDPJHFOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x37C75E0", Offset = "0x37C67E0", VA = "0x1837C75E0")]
		static FOBHDPJHFOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class FOLJKCCBLNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> GHBHCACLFLD;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A48D70", Offset = "0x6A47F70", VA = "0x186A48D70")]
		internal static object MJEGOEMHFJG(Type EEEPNFLJEFK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private EBNLDLKEGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class GNDHJNPCGBL : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class IHAMIGFOLLJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A41320", Offset = "0x3A40520", VA = "0x183A41320")]
		static IHAMIGFOLLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly GNDHJNPCGBL EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool ECFFFLINDMJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static LCGLHBCBKDI[] FLPNFHCNOCK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static LCLOMAPDCGJ[] NLFMLKMBCGP;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private GNDHJNPCGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B3C0", Offset = "0x6A4A5C0", VA = "0x186A4B3C0")]
	public static void OEPCKJDAMHI(params LCLOMAPDCGJ[] NLFMLKMBCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B2E0", Offset = "0x6A4A4E0", VA = "0x186A4B2E0")]
	public static void OEPCKJDAMHI(params LCGLHBCBKDI[] FLPNFHCNOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B070", Offset = "0x6A4A270", VA = "0x186A4B070")]
	public static void IHFOKICBAMJ(LCGLHBCBKDI[] FLPNFHCNOCK, LCLOMAPDCGJ[] NLFMLKMBCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class EDJFLDFLFCD : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class CBJMCGIKEDP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x492DDB0", Offset = "0x492CFB0", VA = "0x18492DDB0")]
		static CBJMCGIKEDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private EDJFLDFLFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CBFFEKMEENI
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly LCLOMAPDCGJ LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly LCLOMAPDCGJ EEMHLFDCPFG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly LCLOMAPDCGJ AHMOCJJPEGF;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly LCLOMAPDCGJ AFBKGGLFPKD;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly LCLOMAPDCGJ FDJJJEEEFMN;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly LCLOMAPDCGJ NHLFODMPLLB;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly LCLOMAPDCGJ OHPPIAEJMHP;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LCLOMAPDCGJ NBDCKFBFNBI;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly LCLOMAPDCGJ EJEPJNHMDPB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly LCLOMAPDCGJ JMDHDONCHOK;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly LCLOMAPDCGJ AHCOHLGJEAN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly LCLOMAPDCGJ POGABLPENLL;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class KAGGCAGDLHL
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly LCLOMAPDCGJ LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly LCLOMAPDCGJ JNJHILNJIGO;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MOOINLFCIFN
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly LCLOMAPDCGJ LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LCLOMAPDCGJ EEMHLFDCPFG;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly LCLOMAPDCGJ AHMOCJJPEGF;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LCLOMAPDCGJ AFBKGGLFPKD;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly LCLOMAPDCGJ FDJJJEEEFMN;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly LCLOMAPDCGJ NHLFODMPLLB;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly LCLOMAPDCGJ OHPPIAEJMHP;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly LCLOMAPDCGJ NBDCKFBFNBI;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly LCLOMAPDCGJ EJEPJNHMDPB;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly LCLOMAPDCGJ JMDHDONCHOK;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly LCLOMAPDCGJ AHCOHLGJEAN;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly LCLOMAPDCGJ POGABLPENLL;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class OODGOODJNOP
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> GHBHCACLFLD;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A504C0", Offset = "0x6A4F6C0", VA = "0x186A504C0")]
	internal static object MJEGOEMHFJG(Type EEEPNFLJEFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A50480", Offset = "0x6A4F680", VA = "0x186A50480")]
	private static object JLDGNENGFJP(Type LOFIHMKIELI, Type[] KMBIHNOOMCN, params object[] DIDDCGGEMIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class FKGGEIPFIHJ : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class DMINPMFAADB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x50A7720", Offset = "0x50A6920", VA = "0x1850A7720")]
		static DMINPMFAADB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly FAKNGPCBNNB HEGOCPEDELO;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A48C20", Offset = "0x6A47E20", VA = "0x186A48C20")]
	static FKGGEIPFIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private FKGGEIPFIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class IHOKGFIGCJO : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class BKGMGOKBKFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x47CEB50", Offset = "0x47CDD50", VA = "0x1847CEB50")]
		static BKGMGOKBKFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly FAKNGPCBNNB HEGOCPEDELO;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BB00", Offset = "0x6A4AD00", VA = "0x186A4BB00")]
	static IHOKGFIGCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private IHOKGFIGCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BPBHGHFCKOJ : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class LGCAHKLJKMD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F460", Offset = "0x3D5E660", VA = "0x183D5F460")]
		static LGCAHKLJKMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly FAKNGPCBNNB HEGOCPEDELO;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E440", Offset = "0x6A3D640", VA = "0x186A3E440")]
	static BPBHGHFCKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private BPBHGHFCKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JNEPGPMBDHA : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class FBFPEIOHHKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x375D630", Offset = "0x375C830", VA = "0x18375D630")]
		static FBFPEIOHHKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly FAKNGPCBNNB HEGOCPEDELO;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DC20", Offset = "0x6A4CE20", VA = "0x186A4DC20")]
	static JNEPGPMBDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private JNEPGPMBDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class DKPMIGIBDJD : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class PCPLPDFHMLD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4195D80", Offset = "0x4194F80", VA = "0x184195D80")]
		static PCPLPDFHMLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly FAKNGPCBNNB HEGOCPEDELO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A482C0", Offset = "0x6A474C0", VA = "0x186A482C0")]
	static DKPMIGIBDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private DKPMIGIBDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class JBMENEIPBNN : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class MLNNAAKPKAH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3F45030", Offset = "0x3F44230", VA = "0x183F45030")]
		static MLNNAAKPKAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly FAKNGPCBNNB HEGOCPEDELO;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DAD0", Offset = "0x6A4CCD0", VA = "0x186A4DAD0")]
	static JBMENEIPBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private JBMENEIPBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class BKMHCBDLMFN : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class MGKACKFJMGO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F174D0", Offset = "0x3F166D0", VA = "0x183F174D0")]
		static MGKACKFJMGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BKMHCBDLMFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class NGDJIFKPOGG : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class EIDDOJNHOIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3424640", Offset = "0x3423840", VA = "0x183424640")]
		static EIDDOJNHOIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public NGDJIFKPOGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class GCPNABNMIAK : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class BCBNDKFIJKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x47AD030", Offset = "0x47AC230", VA = "0x1847AD030")]
		static BCBNDKFIJKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GCPNABNMIAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class HCKBFMBFNPG : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class CAAMEPEAKLO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4850C70", Offset = "0x484FE70", VA = "0x184850C70")]
		static CAAMEPEAKLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HCKBFMBFNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class LOGEHADAGJP : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class EAECLOBCIOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x33FA840", Offset = "0x33F9A40", VA = "0x1833FA840")]
		static EAECLOBCIOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public LOGEHADAGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class GIGHJFEODLH : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class OGIAFDGICEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x40FBEB0", Offset = "0x40FB0B0", VA = "0x1840FBEB0")]
		static OGIAFDGICEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> JGCFHKPGAFA;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool AGMIBPJMHPF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GIGHJFEODLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class CMFIBJDABAG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct MEFHGHMEGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public DCELOEBFDPO EPFEFNDDEJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder LGFEMDPPAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder ONAHPBDDCMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class OOHLFKNBANB
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class BIKDBANNPHM
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo NCKBHOMGGJC;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo FECBPILFMOO;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo AHBHGCHEPBP;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo DFGDDPJMALP;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo JPCEDHMKFEO;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo NALNPEFPHHN;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo MDAHBGAHACG;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo FBINAAHELEO;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo ABOBNKFKBHD;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6A3CA70", Offset = "0x6A3BC70", VA = "0x186A3CA70")]
			static BIKDBANNPHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class BNHGBIALILE
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo GHGODEFNMHI;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo HCMPMHAHLNO;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo PPMBFEEMFHK;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo MKKFCLANBAM;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo NPKODBMKKOD;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo HLPOKOIDCBL;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo NOJOHCEDCJP;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6A3D8C0", Offset = "0x6A3CAC0", VA = "0x186A3D8C0")]
			static BNHGBIALILE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class GEGOADOOCHO
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo IHIJCALMCGK;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo DCJEOBGJHNF;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo DNPPKFNPFMM;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo LALAPJGCIME;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo AAEEPOLGLGD;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo CAAFKGAJOLM;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo OPFJAPHMKGI;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo HPJCLJEKPNH;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo DNLDPPLPMBD;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo PMMMKMIGGMN;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo CKILANNLJOM;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo FKBLJGGFNCD;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo APPFCDGHOAG;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo EFGBPBDOINN;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A52110", Offset = "0x6A51310", VA = "0x186A52110")]
		public static MethodInfo JCBMCDNAHJB(Type MJMAEGDPBNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A524D0", Offset = "0x6A516D0", VA = "0x186A524D0")]
		public static MethodInfo MAOCPLNNJJM(Type MJMAEGDPBNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A523A0", Offset = "0x6A515A0", VA = "0x186A523A0")]
		public static MethodInfo JDOJJBPHIEI(Type MJMAEGDPBNJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class KOBDBGNGGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<DCELOEBFDPO, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public KOBDBGNGGOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class MMLCHBHGMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public KOBDBGNGGOG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public MMLCHBHGMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F920", Offset = "0x6A4EB20", VA = "0x186A4F920")]
		internal void IOJHOHEGJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F880", Offset = "0x6A4EA80", VA = "0x186A4F880")]
		internal bool CPFPNLAEKAK(int index, DCELOEBFDPO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class BHKLLLGAMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public KOBDBGNGGOG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public BHKLLLGAMPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C9D0", Offset = "0x6A3BBD0", VA = "0x186A3C9D0")]
		internal bool HGOAPIHNJME(int index, DCELOEBFDPO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class DKPDCFPEEML
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
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public DKPDCFPEEML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A890", Offset = "0x3A49A90", VA = "0x183A4A890")]
		internal string IELMBOPCFPD(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class LMLAANKJKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public LMLAANKJKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F5F0", Offset = "0x6A4E7F0", VA = "0x186A4F5F0")]
		internal bool ILDNJFJPECC(DCELOEBFDPO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EDBLJPIFEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public DKPDCFPEEML CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public EDBLJPIFEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6A486D0", Offset = "0x6A478D0", VA = "0x186A486D0")]
		internal void IEGNMCAKKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6A48550", Offset = "0x6A47750", VA = "0x186A48550")]
		internal bool ELIKAEFPPJN(int index, DCELOEBFDPO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class ENDFPPLCJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public DKPDCFPEEML CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public ENDFPPLCJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A48780", Offset = "0x6A47980", VA = "0x186A48780")]
		internal bool ALFBMPNPIFL(int index, DCELOEBFDPO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class HHPKAPHNFOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public HHPKAPHNFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BAD0", Offset = "0x6A4ACD0", VA = "0x186A4BAD0")]
		internal Label KHMBHKCLMPM(DCELOEBFDPO _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class MPLAJMGLKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public MEFHGHMEGFC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, DCELOEBFDPO, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public ELKNOPNPCII argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public ELKNOPNPCII argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public MPLAJMGLKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FD80", Offset = "0x6A4EF80", VA = "0x186A4FD80")]
		internal MEFHGHMEGFC ICPLFOHBMOH(DCELOEBFDPO item)
		{
			return default(MEFHGHMEGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FIIMDIDKGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public MPLAJMGLKPO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FIIMDIDKGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6A48990", Offset = "0x6A47B90", VA = "0x186A48990")]
		internal void NKIMJBOMEBB(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A48900", Offset = "0x6A47B00", VA = "0x186A48900")]
		internal void HBIDNHJNIPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class APGBIKKMBGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public DCELOEBFDPO item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public APGBIKKMBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xBB16C0", Offset = "0xBB08C0", VA = "0x180BB16C0")]
		internal bool ICHLHENFBBN(MEFHGHMEGFC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class ELDOMAHHNIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public DCELOEBFDPO item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public ELDOMAHHNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xBB16C0", Offset = "0xBB08C0", VA = "0x180BB16C0")]
		internal bool HKHNOGKEBHI(MEFHGHMEGFC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex HEIICDGFEIO;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int EEIDCDEGIGH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> DFGHKONCALL;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> KCIOOBDHHMP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x26EC660", Offset = "0x26EB860", VA = "0x1826EC660")]
	public static object MHEJMOOFOBN<T>(FAKNGPCBNNB HEGOCPEDELO, LCLOMAPDCGJ FCJBOEGFAIL, Func<string, string> JGCFHKPGAFA, bool AGMIBPJMHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x26F5670", Offset = "0x26F4870", VA = "0x1826F5670")]
	public static object OAFGABIMCAO<T>(LCLOMAPDCGJ FCJBOEGFAIL, Func<string, string> JGCFHKPGAFA, bool AGMIBPJMHPF, bool EBIHLBBJDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A45310", Offset = "0x6A44510", VA = "0x186A45310")]
	private static TypeInfo JDJDLFLEKOF(FAKNGPCBNNB HEGOCPEDELO, Type MJMAEGDPBNJ, Func<string, string> JGCFHKPGAFA, bool AGMIBPJMHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A405C0", Offset = "0x6A3F7C0", VA = "0x186A405C0")]
	public static object FGKPHPCJAON(Type MJMAEGDPBNJ, Func<string, string> JGCFHKPGAFA, bool AGMIBPJMHPF, bool EBIHLBBJDPL, bool MDNAKDPBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FED0", Offset = "0x6A3F0D0", VA = "0x186A3FED0")]
	private static Dictionary<DCELOEBFDPO, FieldInfo> AKADPIJHJLF(TypeBuilder LJDFDGFCKMG, MMJBDOANMHH JCFIBHGAALP, ConstructorInfo MGEGKLPMAHA, FieldBuilder PKNJOJPIFAB, ILGenerator KENOIOJMPFG, bool AGMIBPJMHPF, bool PKHFNEECHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A43820", Offset = "0x6A42A20", VA = "0x186A43820")]
	private static Dictionary<DCELOEBFDPO, FieldInfo> IOGMHMJOJJH(TypeBuilder LJDFDGFCKMG, MMJBDOANMHH JCFIBHGAALP, ILGenerator KENOIOJMPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A42240", Offset = "0x6A41440", VA = "0x186A42240")]
	private static void FOEPFOKLCII(Type MJMAEGDPBNJ, MMJBDOANMHH JCFIBHGAALP, ILGenerator KENOIOJMPFG, Action JANKPHIHFGI, Func<int, DCELOEBFDPO, bool> PNLGFJCENPH, bool AGMIBPJMHPF, bool PKHFNEECHCL, int FJENBKBALJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A46170", Offset = "0x6A45370", VA = "0x186A46170")]
	private static void LOMKDFHEAAP(TypeInfo MJMAEGDPBNJ, DCELOEBFDPO ALLPJHPBKGA, ILGenerator KENOIOJMPFG, int MBGANDEDPDN, Func<int, DCELOEBFDPO, bool> PNLGFJCENPH, ELKNOPNPCII IBOFEJJMDAD, ELKNOPNPCII ENJDLNKIOCF, ELKNOPNPCII LOHJFGMMHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A43ED0", Offset = "0x6A430D0", VA = "0x186A43ED0")]
	private static void IPOOIJIAOMP(Type MJMAEGDPBNJ, MMJBDOANMHH JCFIBHGAALP, ILGenerator KENOIOJMPFG, Func<int, DCELOEBFDPO, bool> PNLGFJCENPH, bool CMHKMBHHIKJ, int FJENBKBALJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A45D20", Offset = "0x6A44F20", VA = "0x186A45D20")]
	private static void LGJKMFANMOG(ILGenerator KENOIOJMPFG, MEFHGHMEGFC JCFIBHGAALP, int MBGANDEDPDN, Func<int, DCELOEBFDPO, bool> PNLGFJCENPH, ELKNOPNPCII GILMBCDEMDA, ELKNOPNPCII LOHJFGMMHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A46690", Offset = "0x6A45890", VA = "0x186A46690")]
	private static LocalBuilder MCOCAIILFGO(ILGenerator KENOIOJMPFG, Type MJMAEGDPBNJ, MMJBDOANMHH JCFIBHGAALP, MEFHGHMEGFC[] ODFPAGFPDBH, bool LBPMNDIOINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A473C0", Offset = "0x6A465C0", VA = "0x186A473C0")]
	private static bool MEKKLAAFIPC(ConstructorInfo OIDHBFPDHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A420C0", Offset = "0x6A412C0", VA = "0x186A420C0")]
	private static bool FMCOKKLIJNE(Type MJMAEGDPBNJ, [Out] Type PEHPEKPDAEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void DHKPCPKGKGH<T>(byte[][] PKNJOJPIFAB, object[] NGHPFDCNJAK, LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ JFBDCMDHJCP);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T DPNIAAGHJEK<T>(object[] NGHPFDCNJAK, BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ JFBDCMDHJCP);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class PPIFMHNGDKC<T> : GHLIBNINOHA<T>, LCGLHBCBKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] PKNJOJPIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] LAAABPNECKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] KAECAAECJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly DHKPCPKGKGH<T> CNLPIFCKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly DPNIAAGHJEK<T> LMJENICIKHM;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5C40", Offset = "0x1DE4E40", VA = "0x181DE5C40")]
	public PPIFMHNGDKC(byte[][] PKNJOJPIFAB, object[] LAAABPNECKE, object[] KAECAAECJMC, DHKPCPKGKGH<T> CNLPIFCKOFE, DPNIAAGHJEK<T> LMJENICIKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x41D4B40", Offset = "0x41D3D40", VA = "0x1841D4B40", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x41D4C30", Offset = "0x41D3E30", VA = "0x1841D4C30", Slot = "5")]
	public T MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class EADPKLHIBFP : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class NMAOCCIMFGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3FFEEB0", Offset = "0x3FFE0B0", VA = "0x183FFEEB0")]
		static NMAOCCIMFGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private EADPKLHIBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class KJGAKDDMOCE : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class EFJGOBPOEED<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3414F20", Offset = "0x3414120", VA = "0x183414F20")]
		static EFJGOBPOEED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private KJGAKDDMOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class LCHFKHPIION
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly LCLOMAPDCGJ[] EDGODPKADKF;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class DGHGJKBEDAP : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class NOOPHKNBLOG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x401D3B0", Offset = "0x401C5B0", VA = "0x18401D3B0")]
		static NOOPHKNBLOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class OBJJNGGOPEE : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class KHLEEFEFKHL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4E00", Offset = "0x3CB4000", VA = "0x183CB4E00")]
			static KHLEEFEFKHL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private OBJJNGGOPEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private DGHGJKBEDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class NKCHDIOCKKA : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class EFFJCLHOKAD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3411420", Offset = "0x3410620", VA = "0x183411420")]
		static EFFJCLHOKAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class HAFONBCLKEK : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class HMPACBOOOHO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x39830F0", Offset = "0x39822F0", VA = "0x1839830F0")]
			static HMPACBOOOHO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private HAFONBCLKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private NKCHDIOCKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class APKFAKMLEGD : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class IPNLIJOHCJN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5FDA0", Offset = "0x3A5EFA0", VA = "0x183A5FDA0")]
		static IPNLIJOHCJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class IMPINNJCELO : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class AEDEKHNNABE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x383BC00", Offset = "0x383AE00", VA = "0x18383BC00")]
			static AEDEKHNNABE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private IMPINNJCELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private APKFAKMLEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class BINGCCDOPNC : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class JCCBMGJMIFN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3BE9C70", Offset = "0x3BE8E70", VA = "0x183BE9C70")]
		static JCCBMGJMIFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class FEPMPONNEFD : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class GPBHIIOKCHA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x389D730", Offset = "0x389C930", VA = "0x18389D730")]
			static GPBHIIOKCHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private FEPMPONNEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private BINGCCDOPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class EFGBNJDHALE : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class NHLIAFAMLED<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFEC0", Offset = "0x3FEF0C0", VA = "0x183FEFEC0")]
		static NHLIAFAMLED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class LOAICMCDNAP : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class CGIJEFMBMOH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4A1C100", Offset = "0x4A1B300", VA = "0x184A1C100")]
			static CGIJEFMBMOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private LOAICMCDNAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private EFGBNJDHALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class AGNMCLFFJLJ : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class ABCGJBLLMOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x382D620", Offset = "0x382C820", VA = "0x18382D620")]
		static ABCGJBLLMOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class BDFDCBECCJP : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class NNGCDNHECMN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4009370", Offset = "0x4008570", VA = "0x184009370")]
			static NNGCDNHECMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private BDFDCBECCJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private AGNMCLFFJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class DADNBGCNFOH : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class AOGNNKNFFCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x38C1B10", Offset = "0x38C0D10", VA = "0x1838C1B10")]
		static AOGNNKNFFCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class BKPINMCPNGA : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class BHFKCOMANEI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x47C1310", Offset = "0x47C0510", VA = "0x1847C1310")]
			static BHFKCOMANEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private BKPINMCPNGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private DADNBGCNFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class ELEKIKBHFOO : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class KOICALIADJB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3CD21F0", Offset = "0x3CD13F0", VA = "0x183CD21F0")]
		static KOICALIADJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class PCFCHOGOJBI : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class GJFECKDLHJK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3877970", Offset = "0x3876B70", VA = "0x183877970")]
			static GJFECKDLHJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private PCFCHOGOJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private ELEKIKBHFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class PEJAMELCAAI : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class BKGNEBFKNMB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x47D0C30", Offset = "0x47CFE30", VA = "0x1847D0C30")]
		static BKGNEBFKNMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class ILPKGGHMBNM : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class DDAJKDGOIDF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x5088130", Offset = "0x5087330", VA = "0x185088130")]
			static DDAJKDGOIDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private ILPKGGHMBNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private PEJAMELCAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class DOHDCKJMIEK : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class KODEKPLFAAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB3E0", Offset = "0x3CCA5E0", VA = "0x183CCB3E0")]
		static KODEKPLFAAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class OOCKOBOPEMA : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class KKMHPLNBCPO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3CBF4D0", Offset = "0x3CBE6D0", VA = "0x183CBF4D0")]
			static KKMHPLNBCPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private OOCKOBOPEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private DOHDCKJMIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class MBHFFHEMELP : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class AGHKMMAJADO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x38A7240", Offset = "0x38A6440", VA = "0x1838A7240")]
		static AGHKMMAJADO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class BKHNMMLMOKG : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class HNIKGCFCOMC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3988850", Offset = "0x3987A50", VA = "0x183988850")]
			static HNIKGCFCOMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private BKHNMMLMOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private MBHFFHEMELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class IENBKIIIOGN : LCLOMAPDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class JIOOIKNEBDI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C1F370", Offset = "0x3C1E570", VA = "0x183C1F370")]
		static JIOOIKNEBDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class FBJILMAJHKK : LCLOMAPDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class GMIOMHCIJBC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly GHLIBNINOHA<T> IEFIHALHGHN;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x388D4D0", Offset = "0x388C6D0", VA = "0x18388D4D0")]
			static GMIOMHCIJBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly LCLOMAPDCGJ EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly LCLOMAPDCGJ[] NLFMLKMBCGP;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private FBJILMAJHKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
		public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly LCLOMAPDCGJ EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly GHLIBNINOHA<object> GHFAONNOFJI;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	private IENBKIIIOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	public GHLIBNINOHA<T> MJEGOEMHFJG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct KAPEFACCAGP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] CIBDPBCCDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int ODOBGAEOPBA;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3CA6320", Offset = "0x3CA5520", VA = "0x183CA6320")]
	public KAPEFACCAGP(int BIDOPCCDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CA5E60", Offset = "0x3CA5060", VA = "0x183CA5E60")]
	public void GHBEENLPKLN(T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3CA6290", Offset = "0x3CA5490", VA = "0x183CA6290")]
	public T[] JHLIOFHFCFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class CFMOKFLKMMP : NFPLJLLADBL<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly CFMOKFLKMMP LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A55590", Offset = "0x6A54790", VA = "0x186A55590")]
	public CFMOKFLKMMP(int KBLPHDONBGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class NFPLJLLADBL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int KBLPHDONBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object LJAPFIPOHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int MBGANDEDPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] CBHNFIEGPHH;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3FCDBB0", Offset = "0x3FCCDB0", VA = "0x183FCDBB0")]
	public NFPLJLLADBL(int KBLPHDONBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD8C0", Offset = "0x3FCCAC0", VA = "0x183FCD8C0")]
	public T[] KAKGOGKEKNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD740", Offset = "0x3FCC940", VA = "0x183FCD740")]
	public void BPIIOODEMJH(T[] BLGDAGLONDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class FFABBHCJNBA : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class DABIFHELMGB : IComparable<DABIFHELMGB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class EJAFOIMPKHE : IEnumerable<DABIFHELMGB>, IEnumerable, IEnumerator<DABIFHELMGB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private DABIFHELMGB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public DABIFHELMGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private DABIFHELMGB System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
			[DebuggerHidden]
			public EJAFOIMPKHE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6A5E5B0", Offset = "0x6A5D7B0", VA = "0x186A5E5B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6A5E6E0", Offset = "0x6A5D8E0", VA = "0x186A5E6E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6A5E630", Offset = "0x6A5D830", VA = "0x186A5E630", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DABIFHELMGB> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6A5E630", Offset = "0x6A5D830", VA = "0x186A5E630", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class IGJDMNLDLCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public IGJDMNLDLCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6A4BAD0", Offset = "0x6A4ACD0", VA = "0x186A4BAD0")]
			internal Label BAPJELELHPI(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6A4BAD0", Offset = "0x6A4ACD0", VA = "0x186A4BAD0")]
			internal Label BNLCHKPDGFA(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly DABIFHELMGB[] JMMNOFILJOB;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] GEJOGOKBPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong NFEHEBDHPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int LJLHDNLHLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string DKCGEDOEIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private DABIFHELMGB[] KOOPJBPLKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] LMHKFFKKMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int KMJOEPJMADC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool AHFMHILKMPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5344940", Offset = "0x5343B40", VA = "0x185344940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A58EF0", Offset = "0x6A580F0", VA = "0x186A58EF0")]
		public DABIFHELMGB(ulong GHBNLDGJPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A58760", Offset = "0x6A57960", VA = "0x186A58760")]
		public DABIFHELMGB GHBEENLPKLN(ulong GHBNLDGJPCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A58700", Offset = "0x6A57900", VA = "0x186A58700")]
		public DABIFHELMGB GHBEENLPKLN(ulong GHBNLDGJPCB, int EKDDCPALANJ, string DKCGEDOEIJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A58CD0", Offset = "0x6A57ED0", VA = "0x186A58CD0")]
		public DABIFHELMGB PHHALJCLLFN(byte[] HIFBGLLPLPJ, int BMIAFODFMCE, int KBMOLOOENMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A579C0", Offset = "0x6A56BC0", VA = "0x186A579C0")]
		internal static int DPNMJNLCFOG(ulong[] BLGDAGLONDD, int MBGANDEDPDN, int EAMNBPDOIFO, ulong EKDDCPALANJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A57910", Offset = "0x6A56B10", VA = "0x186A57910", Slot = "4")]
		public int CompareTo(DABIFHELMGB MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A57940", Offset = "0x6A56B40", VA = "0x186A57940")]
		[IteratorStateMachine(typeof(EJAFOIMPKHE))]
		public IEnumerable<DABIFHELMGB> DNJKMMJIMLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A58960", Offset = "0x6A57B60", VA = "0x186A58960")]
		public void PBBHEDGKGON(ILGenerator KENOIOJMPFG, LocalBuilder HIFBGLLPLPJ, LocalBuilder KBMOLOOENMJ, LocalBuilder GHBNLDGJPCB, Action<KeyValuePair<string, int>> BAMIEJJHCPB, Action HLJCJPHAIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A57A50", Offset = "0x6A56C50", VA = "0x186A57A50")]
		private static void FCMNEKKOHFB(ILGenerator KENOIOJMPFG, LocalBuilder HIFBGLLPLPJ, LocalBuilder KBMOLOOENMJ, LocalBuilder GHBNLDGJPCB, Action<KeyValuePair<string, int>> BAMIEJJHCPB, Action HLJCJPHAIHP, DABIFHELMGB[] KOOPJBPLKNI, int KMJOEPJMADC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class OCIDONICMCG : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<DABIFHELMGB> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<DABIFHELMGB> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<DABIFHELMGB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private DABIFHELMGB <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xAD72C0", Offset = "0xAD64C0", VA = "0x180AD72C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A68C60", Offset = "0x6A67E60", VA = "0x186A68C60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CFADB0", Offset = "0x1CF9FB0", VA = "0x181CFADB0")]
		[DebuggerHidden]
		public OCIDONICMCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6A68CB0", Offset = "0x6A67EB0", VA = "0x186A68CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6A68700", Offset = "0x6A67900", VA = "0x186A68700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A686B0", Offset = "0x6A678B0", VA = "0x186A686B0")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A68660", Offset = "0x6A67860", VA = "0x186A68660")]
		private void KEKJABDJFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6A68C10", Offset = "0x6A67E10", VA = "0x186A68C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A68B60", Offset = "0x6A67D60", VA = "0x186A68B60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6A68B60", Offset = "0x6A67D60", VA = "0x186A68B60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly DABIFHELMGB MFIBAFBMCBA;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F850", Offset = "0x6A5EA50", VA = "0x186A5F850")]
	public FFABBHCJNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F340", Offset = "0x6A5E540", VA = "0x186A5F340")]
	public void GHBEENLPKLN(byte[] GNPAJENJDCN, int EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F260", Offset = "0x6A5E460", VA = "0x186A5F260")]
	public bool EDDKMEFIBMI(ArraySegment<byte> GHBNLDGJPCB, [Out] int EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F7C0", Offset = "0x6A5E9C0", VA = "0x186A5F7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F4E0", Offset = "0x6A5E6E0", VA = "0x186A5F4E0")]
	private static void ODJILAILKMI(IEnumerable<DABIFHELMGB> KOOPJBPLKNI, StringBuilder MEPJNPBNIEI, int ADINCKCGEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F450", Offset = "0x6A5E650", VA = "0x186A5F450", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F450", Offset = "0x6A5E650", VA = "0x186A5F450", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F1E0", Offset = "0x6A5E3E0", VA = "0x186A5F1E0")]
	[IteratorStateMachine(typeof(OCIDONICMCG))]
	private static IEnumerable<KeyValuePair<string, int>> ALIIBLLMPBK(IEnumerable<DABIFHELMGB> KOOPJBPLKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F4B0", Offset = "0x6A5E6B0", VA = "0x186A5F4B0")]
	public void MFKGBOPNAEK(ILGenerator KENOIOJMPFG, LocalBuilder HIFBGLLPLPJ, LocalBuilder KBMOLOOENMJ, LocalBuilder GHBNLDGJPCB, Action<KeyValuePair<string, int>> BAMIEJJHCPB, Action HLJCJPHAIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class DGPMAACBOPN
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo NAMGJGGALLF;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A598C0", Offset = "0x6A58AC0", VA = "0x186A598C0")]
	public static ulong GEBCNEAIJBJ(byte[] GNPAJENJDCN, int BMIAFODFMCE, int KBMOLOOENMJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class CPDODDLPELO
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A55E70", Offset = "0x6A55070", VA = "0x186A55E70")]
	public static void KEBPPKLCJLB(byte[] GNPAJENJDCN, int BMIAFODFMCE, int AKPNOHLPMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A55D50", Offset = "0x6A54F50", VA = "0x186A55D50")]
	public static void JCDIPHBFAFJ(byte[] BLGDAGLONDD, int HKOEPOIJDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A55C20", Offset = "0x6A54E20", VA = "0x186A55C20")]
	public static byte[] CPOJHONBOMI(byte[] NGGIHAOFJPD, int HKOEPOIJDGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class BFFGCLGBDBP
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A54A60", Offset = "0x6A53C60", VA = "0x186A54A60")]
	public static bool DJFDNBCEPNE(byte[] APFHMJMPDKG, int EHDPODGEDDN, int PHHGAJBGHIN, byte[] EPJLKMAJPOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class IOEIEMEKKBA<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct PBCGGNHCNGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] NFEHEBDHPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T LJLHDNLHLNB;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4192010", Offset = "0x4191210", VA = "0x184192010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class CALAKHONDFO : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public IOEIEMEKKBA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private PBCGGNHCNGA[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private PBCGGNHCNGA[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xAD72C0", Offset = "0xAD64C0", VA = "0x180AD72C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F6840", Offset = "0x37F5A40", VA = "0x1837F6840", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public CALAKHONDFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4927650", Offset = "0x4926850", VA = "0x184927650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4928350", Offset = "0x4927550", VA = "0x184928350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly PBCGGNHCNGA[][] ABMEHOBOLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong CLCHMGBPEKF;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D190", Offset = "0x3A5C390", VA = "0x183A5D190")]
	public IOEIEMEKKBA(int ONEEJBCNCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D1B0", Offset = "0x3A5C3B0", VA = "0x183A5D1B0")]
	public IOEIEMEKKBA(int ONEEJBCNCKG, float KKKLHDDGCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3A51570", Offset = "0x3A50770", VA = "0x183A51570")]
	public void GHBEENLPKLN(byte[] GHBNLDGJPCB, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A58630", Offset = "0x3A57830", VA = "0x183A58630")]
	private bool OMMDJLONPIL(byte[] GHBNLDGJPCB, T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A53E20", Offset = "0x3A53020", VA = "0x183A53E20")]
	public bool JNNFGFKBPPN(ArraySegment<byte> GHBNLDGJPCB, [Out] T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A52190", Offset = "0x3A51390", VA = "0x183A52190")]
	private static ulong GKNCEGENEKI(byte[] EFCGILCAOIA, int BMIAFODFMCE, int KMJOEPJMADC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3A50750", Offset = "0x3A4F950", VA = "0x183A50750")]
	private static int FCFDHIGNGBP(int NOJDNFKOGJM, float KKKLHDDGCCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A52270", Offset = "0x3A51470", VA = "0x183A52270", Slot = "4")]
	[IteratorStateMachine(typeof(IOEIEMEKKBA<>.CALAKHONDFO))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x36542C0", Offset = "0x36534C0", VA = "0x1836542C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class MPKOEPLFEBK : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] KFHNOIALKIH;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] CMKGDNEAJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int KFPLHEPBBFC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool CMIFDCEENLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A65B40", Offset = "0x6A64D40", VA = "0x186A65B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A65B90", Offset = "0x6A64D90", VA = "0x186A65B90")]
	static MPKOEPLFEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A65DD0", Offset = "0x6A64FD0", VA = "0x186A65DD0")]
	public MPKOEPLFEBK(byte[] GDGLIIGEPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A65A50", Offset = "0x6A64C50", VA = "0x186A65A50")]
	public OpCode MGHEOPKGDBL()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct NFEGCCKOBHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid LJLHDNLHLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte EFDBNEIJGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte FDHGJMGIKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte CKAHBJJPFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte IOIHLBPEDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte IEJCFGMCCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte CIMKABBEHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte NFAAJCLJILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte PGANPCBICII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte ONNFCHOKHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte GLMDABDKHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte CFHPCDGNOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte LGIDEFBCDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte AIAGMMKCFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte HBJFMEDBODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte JBEBOCIDPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte NMCFKNBBPLM;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] AGHNGJKDFFF;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] ONANGMHCALA;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A66EF0", Offset = "0x6A660F0", VA = "0x186A66EF0")]
	public NFEGCCKOBHE(Guid EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A66F00", Offset = "0x6A66100", VA = "0x186A66F00")]
	public NFEGCCKOBHE(ArraySegment<byte> CFMJHIBKNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A66160", Offset = "0x6A65360", VA = "0x186A66160")]
	private static byte NLHKNGCDNAE(byte[] GNPAJENJDCN, int PADBMLPAFGF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A66040", Offset = "0x6A65240", VA = "0x186A66040")]
	private static byte EEPAJGEDEEP(byte HIOEJKGFIKI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A66200", Offset = "0x6A65400", VA = "0x186A66200")]
	public void PFJFMDMNKPF(byte[] ENIOLEEEFGI, int BMIAFODFMCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class IBCFHPBPFAA
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6A60290", Offset = "0x6A5F490", VA = "0x186A60290")]
	public static bool FICPIJCBOED(byte PHDOOEGGBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6A617B0", Offset = "0x6A609B0", VA = "0x186A617B0")]
	public static bool MKGJEFPABIJ(byte PHDOOEGGBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6A603B0", Offset = "0x6A5F5B0", VA = "0x186A603B0")]
	public static sbyte HHLIJGJLGPO(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6A60490", Offset = "0x6A5F690", VA = "0x186A60490")]
	public static short HHLKDKPJDPJ(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6A61020", Offset = "0x6A60220", VA = "0x186A61020")]
	public static int JILANOEAHIJ(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6A61900", Offset = "0x6A60B00", VA = "0x186A61900")]
	public static long NDNBPGFBGEH(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FEE0", Offset = "0x6A5F0E0", VA = "0x186A5FEE0")]
	public static byte ADNFEKAPELJ(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6A60210", Offset = "0x6A5F410", VA = "0x186A60210")]
	public static ushort EGDDPMONBKB(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FF60", Offset = "0x6A5F160", VA = "0x186A5FF60")]
	public static uint CNONGJDLDPM(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6A602A0", Offset = "0x6A5F4A0", VA = "0x186A602A0")]
	public static ulong GAECNBIMPFG(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6A61820", Offset = "0x6A60A20", VA = "0x186A61820")]
	public static float MOCBNMLOLCD(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6A60F40", Offset = "0x6A60140", VA = "0x186A60F40")]
	public static double IOBCNMBIOPI(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6A61110", Offset = "0x6A60310", VA = "0x186A61110")]
	public static int LIOFBINJFDA(byte[] ENIOLEEEFGI, int BMIAFODFMCE, ulong EKDDCPALANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6A60580", Offset = "0x6A5F780", VA = "0x186A60580")]
	public static int IHNBLCMDCGJ(byte[] ENIOLEEEFGI, int BMIAFODFMCE, long EKDDCPALANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FFE0", Offset = "0x6A5F1E0", VA = "0x186A5FFE0")]
	public static bool EBIFFLLLAHN(byte[] GNPAJENJDCN, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class DKKBEEKKJMG
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class EHHFHIECLJE : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
		[DebuggerHidden]
		public EHHFHIECLJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E480", Offset = "0x6A5D680", VA = "0x186A5E480", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6A5DF40", Offset = "0x6A5D140", VA = "0x186A5DF40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6A5DEF0", Offset = "0x6A5D0F0", VA = "0x186A5DEF0")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6A5DEA0", Offset = "0x6A5D0A0", VA = "0x186A5DEA0")]
		private void KEKJABDJFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E430", Offset = "0x6A5D630", VA = "0x186A5E430", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E370", Offset = "0x6A5D570", VA = "0x186A5E370", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E370", Offset = "0x6A5D570", VA = "0x186A5E370", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class JKMPCDNIEPI : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
		[DebuggerHidden]
		public JKMPCDNIEPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6A62470", Offset = "0x6A61670", VA = "0x186A62470", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6A61F30", Offset = "0x6A61130", VA = "0x186A61F30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6A61EE0", Offset = "0x6A610E0", VA = "0x186A61EE0")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6A61E90", Offset = "0x6A61090", VA = "0x186A61E90")]
		private void KEKJABDJFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6A62420", Offset = "0x6A61620", VA = "0x186A62420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6A62360", Offset = "0x6A61560", VA = "0x186A62360", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6A62360", Offset = "0x6A61560", VA = "0x186A62360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A6A0", Offset = "0x6A598A0", VA = "0x186A5A6A0")]
	public static bool EECDICNEEPL(this TypeInfo MJMAEGDPBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A4D0", Offset = "0x6A596D0", VA = "0x186A5A4D0")]
	public static bool CICKKGBGMHD(this TypeInfo MJMAEGDPBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A880", Offset = "0x6A59A80", VA = "0x186A5A880")]
	public static IEnumerable<PropertyInfo> JFMOOGCFMEN(this Type MJMAEGDPBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A600", Offset = "0x6A59800", VA = "0x186A5A600")]
	[IteratorStateMachine(typeof(EHHFHIECLJE))]
	private static IEnumerable<PropertyInfo> DBHGBJIPECP(Type MJMAEGDPBNJ, HashSet<string> FAJMMBPMBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A800", Offset = "0x6A59A00", VA = "0x186A5A800")]
	public static IEnumerable<FieldInfo> IELPDBPAANC(this Type MJMAEGDPBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A760", Offset = "0x6A59960", VA = "0x186A5A760")]
	[IteratorStateMachine(typeof(JKMPCDNIEPI))]
	private static IEnumerable<FieldInfo> EIIMDLJBEND(Type MJMAEGDPBNJ, HashSet<string> FAJMMBPMBJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class DPLFCBGMLLD
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding JMHNDIKCACM;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class GGFKPFPKPMJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static string PBABBLKBEMB(string PBPEKHGBDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F8D0", Offset = "0x6A5EAD0", VA = "0x186A5F8D0")]
	public static string BBHKDDNNNLM(string PBPEKHGBDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F9B0", Offset = "0x6A5EBB0", VA = "0x186A5F9B0")]
	public static string LMAAMGKCGNP(string PBPEKHGBDMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class KMNKKAIHKNB<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class DBOAEEMKGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type NFEHEBDHPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue LJLHDNLHLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int CFDMOEHFJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public DBOAEEMKGLM CECLBNHPHAI;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5086670", Offset = "0x5085870", VA = "0x185086670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5086630", Offset = "0x5085830", VA = "0x185086630")]
		private int GIHIJMKOGEP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public DBOAEEMKGLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class MGOACJJNHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public MGOACJJNHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0")]
		internal TValue DPKPFDCPAHK(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private DBOAEEMKGLM[] ABMEHOBOLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int ANCJPCFOHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object LBBBKMGNFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float KKKLHDDGCCK;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2C90", Offset = "0x3CC1E90", VA = "0x183CC2C90")]
	public KMNKKAIHKNB(int ONEEJBCNCKG = 4, float KKKLHDDGCCK = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC29F0", Offset = "0x3CC1BF0", VA = "0x183CC29F0")]
	public bool PLJNONPJNEA(Type GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2B50", Offset = "0x3CC1D50", VA = "0x183CC2B50")]
	public bool PLJNONPJNEA(Type GHBNLDGJPCB, Func<Type, TValue> IMEMIFKABGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3CC25B0", Offset = "0x3CC17B0", VA = "0x183CC25B0")]
	private bool OMMDJLONPIL(Type GHBNLDGJPCB, Func<Type, TValue> IMEMIFKABGB, [Out] TValue LEKKAAEHOII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1C50", Offset = "0x3CC0E50", VA = "0x183CC1C50")]
	private bool FLLCHCBNBOP(DBOAEEMKGLM[] ABMEHOBOLNM, Type DKFDNCKGPCO, DBOAEEMKGLM CFMDICDCMPC, Func<Type, TValue> IMEMIFKABGB, [Out] TValue LEKKAAEHOII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2010", Offset = "0x3CC1210", VA = "0x183CC2010")]
	public bool JNNFGFKBPPN(Type GHBNLDGJPCB, [Out] TValue EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3CC17E0", Offset = "0x3CC09E0", VA = "0x183CC17E0")]
	public TValue BEPGFLIMGIM(Type GHBNLDGJPCB, Func<Type, TValue> IMEMIFKABGB)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3A50750", Offset = "0x3A4F950", VA = "0x183A50750")]
	private static int FCFDHIGNGBP(int NOJDNFKOGJM, float KKKLHDDGCCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1890", Offset = "0x3CC0A90", VA = "0x183CC1890")]
	private static void BLDDPNJPEFG(DBOAEEMKGLM HAOPDGKHCCB, DBOAEEMKGLM EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1890", Offset = "0x3CC0A90", VA = "0x183CC1890")]
	private static void BLDDPNJPEFG(DBOAEEMKGLM[] HAOPDGKHCCB, DBOAEEMKGLM[] EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class FAKNGPCBNNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder DDMMKNCCJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder POEECGDNHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object LJAPFIPOHLC;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5EC50", Offset = "0x6A5DE50", VA = "0x186A5EC50")]
	public TypeBuilder JKHBOGHPBOG(string MPENHPFDCDK, TypeAttributes HBCKMALNDAD, Type DLAKBCKOLFN, Type[] AFPCDEINOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5ED50", Offset = "0x6A5DF50", VA = "0x186A5ED50")]
	public FAKNGPCBNNB(string GGHLPBFKIFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class MFCMNKPMCIJ
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6A64410", Offset = "0x6A63610", VA = "0x186A64410")]
	private static MethodInfo KGJGNPFLHIB(LambdaExpression CLIIDHKLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x293BA40", Offset = "0x293AC40", VA = "0x18293BA40")]
	public static MethodInfo CNOBAKPKLPH<T>(Expression<Func<T>> CLIIDHKLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x293BA40", Offset = "0x293AC40", VA = "0x18293BA40")]
	public static MethodInfo CNOBAKPKLPH<T, TR>(Expression<Func<T, TR>> CLIIDHKLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x293BA40", Offset = "0x293AC40", VA = "0x18293BA40")]
	public static MethodInfo CNOBAKPKLPH<T>(Expression<Action<T>> CLIIDHKLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x293BA40", Offset = "0x293AC40", VA = "0x18293BA40")]
	public static MethodInfo CNOBAKPKLPH<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> CLIIDHKLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x293B960", Offset = "0x293AB60", VA = "0x18293B960")]
	private static MemberInfo CKIILCNNDND<T>(Expression<T> HEEIDJMADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x293BA50", Offset = "0x293AC50", VA = "0x18293BA50")]
	public static PropertyInfo IJAMCKOODNB<T, TR>(Expression<Func<T, TR>> CLIIDHKLDCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct ELKNOPNPCII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int IBNKLDKLAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool NILCGLBLBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator KENOIOJMPFG;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6A5EB80", Offset = "0x6A5DD80", VA = "0x186A5EB80")]
	public ELKNOPNPCII(ILGenerator KENOIOJMPFG, int IBNKLDKLAGI, bool NILCGLBLBLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6A5EBC0", Offset = "0x6A5DDC0", VA = "0x186A5EBC0")]
	public ELKNOPNPCII(ILGenerator KENOIOJMPFG, int IBNKLDKLAGI, Type MJMAEGDPBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6A5EA80", Offset = "0x6A5DC80", VA = "0x186A5EA80")]
	public void ONGOEIMINHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class EEEIDKDDJBO
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D440", Offset = "0x6A5C640", VA = "0x186A5D440")]
	public static void KOPDGGMFKEL(this ILGenerator KENOIOJMPFG, int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D620", Offset = "0x6A5C820", VA = "0x186A5D620")]
	public static void KOPDGGMFKEL(this ILGenerator KENOIOJMPFG, LocalBuilder OPIBIHDFCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D0F0", Offset = "0x6A5C2F0", VA = "0x186A5D0F0")]
	public static void IMKBADOFDAL(this ILGenerator KENOIOJMPFG, int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D0B0", Offset = "0x6A5C2B0", VA = "0x186A5D0B0")]
	public static void IMKBADOFDAL(this ILGenerator KENOIOJMPFG, LocalBuilder OPIBIHDFCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D790", Offset = "0x6A5C990", VA = "0x186A5D790")]
	public static void ONBFHDDCLOM(this ILGenerator KENOIOJMPFG, int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D870", Offset = "0x6A5CA70", VA = "0x186A5D870")]
	public static void ONBFHDDCLOM(this ILGenerator KENOIOJMPFG, LocalBuilder OPIBIHDFCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D3A0", Offset = "0x6A5C5A0", VA = "0x186A5D3A0")]
	public static void JKAEKFHKNIE(this ILGenerator KENOIOJMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CF40", Offset = "0x6A5C140", VA = "0x186A5CF40")]
	public static void HAKPACJLBGO(this ILGenerator KENOIOJMPFG, bool EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D970", Offset = "0x6A5CB70", VA = "0x186A5D970")]
	public static void ONPGLABKGHN(this ILGenerator KENOIOJMPFG, int EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D2D0", Offset = "0x6A5C4D0", VA = "0x186A5D2D0")]
	public static void JDEIHDPHHKK(this ILGenerator KENOIOJMPFG, Type MJMAEGDPBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D660", Offset = "0x6A5C860", VA = "0x186A5D660")]
	public static void MFFHKFKEONC(this ILGenerator KENOIOJMPFG, Type MJMAEGDPBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CD60", Offset = "0x6A5BF60", VA = "0x186A5CD60")]
	public static void GLIHLIBOPEG(this ILGenerator KENOIOJMPFG, int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D040", Offset = "0x6A5C240", VA = "0x186A5D040")]
	public static void HHCLANBJKON(this ILGenerator KENOIOJMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CC90", Offset = "0x6A5BE90", VA = "0x186A5CC90")]
	public static void ADLONEALMBK(this ILGenerator KENOIOJMPFG, int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CF50", Offset = "0x6A5C150", VA = "0x186A5CF50")]
	public static void HGFEPCGGIPL(this ILGenerator KENOIOJMPFG, MethodInfo BIGFJMCEMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D3B0", Offset = "0x6A5C5B0", VA = "0x186A5D3B0")]
	public static void KDIBMFLJNAH(this ILGenerator KENOIOJMPFG, FieldInfo IGEICPIDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D700", Offset = "0x6A5C900", VA = "0x186A5D700")]
	public static void OJEEJLHEECJ(this ILGenerator KENOIOJMPFG, ulong EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class DCELOEBFDPO
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class KHNHOKELNKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public KHNHOKELNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6A63F30", Offset = "0x6A63130", VA = "0x186A63F30")]
		internal bool MIGKOAICLJI(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo NPBDJNCDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo GIKKGNLGMOL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string CLGFFCFOCCO
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GCEGGPAGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6A59110", Offset = "0x6A58310", VA = "0x186A59110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LHIPCLLNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7B77B0", Offset = "0x7B69B0", VA = "0x1807B77B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7540", Offset = "0x7B6740", VA = "0x1807B7540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DBAIMNNCICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x92D0A0", Offset = "0x92C2A0", VA = "0x18092D0A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x92CAB0", Offset = "0x92BCB0", VA = "0x18092CAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MEBDELDBDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7B4150", Offset = "0x7B3350", VA = "0x1807B4150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo AOOGGDODHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo KDIEDBEMDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B6730", VA = "0x1807B7530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo ELFECODHJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7BF640", Offset = "0x7BE840", VA = "0x1807BF640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7B77C0", Offset = "0x7B69C0", VA = "0x1807B77C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A59840", Offset = "0x6A58A40", VA = "0x186A59840")]
	protected DCELOEBFDPO(Type MJMAEGDPBNJ, string MPENHPFDCDK, string POJGHHABGKD, bool EAFCCLPFFKA, bool FJKMMOJLBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A59730", Offset = "0x6A58930", VA = "0x186A59730")]
	public DCELOEBFDPO(FieldInfo JCFIBHGAALP, string MPENHPFDCDK, bool EBIHLBBJDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A59570", Offset = "0x6A58770", VA = "0x186A59570")]
	public DCELOEBFDPO(PropertyInfo JCFIBHGAALP, string MPENHPFDCDK, bool EBIHLBBJDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6A59400", Offset = "0x6A58600", VA = "0x186A59400")]
	private static MethodInfo OJNDICNBCPF(MemberInfo JCFIBHGAALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x271D860", Offset = "0x271CA60", VA = "0x18271D860")]
	public T DBIKFPGPMMD<T>(bool INELNOHHGHN) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6A59120", Offset = "0x6A58320", VA = "0x186A59120", Slot = "4")]
	public virtual void FEIEMFMKFFG(ILGenerator KENOIOJMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6A59290", Offset = "0x6A58490", VA = "0x186A59290", Slot = "5")]
	public virtual void LMCMDPAAFNE(ILGenerator KENOIOJMPFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class ELBDNGKIPHI : DCELOEBFDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string NPHGJAAKDNL;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E830", Offset = "0x6A5DA30", VA = "0x186A5E830")]
	public ELBDNGKIPHI(string MPENHPFDCDK, string NPHGJAAKDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E730", Offset = "0x6A5D930", VA = "0x186A5E730", Slot = "4")]
	public override void FEIEMFMKFFG(ILGenerator KENOIOJMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E7E0", Offset = "0x6A5D9E0", VA = "0x186A5E7E0", Slot = "5")]
	public override void LMCMDPAAFNE(ILGenerator KENOIOJMPFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class OLBIBKIPDJJ : DCELOEBFDPO
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo GAMHBDFEHKL;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo HEMJFCFKBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal ELKNOPNPCII GLHDNJNEJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal ELKNOPNPCII ENJDLNKIOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal ELKNOPNPCII LOHJFGMMHID;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6A695C0", Offset = "0x6A687C0", VA = "0x186A695C0")]
	public OLBIBKIPDJJ(string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6A68E00", Offset = "0x6A68000", VA = "0x186A68E00", Slot = "4")]
	public override void FEIEMFMKFFG(ILGenerator KENOIOJMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6A69070", Offset = "0x6A68270", VA = "0x186A69070", Slot = "5")]
	public override void LMCMDPAAFNE(ILGenerator KENOIOJMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6A68EC0", Offset = "0x6A680C0", VA = "0x186A68EC0")]
	public void HGJAKLKPFFE(ILGenerator KENOIOJMPFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class MMJBDOANMHH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type MEBDELDBDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KEFGDHGBNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x82DA00", Offset = "0x82CC00", VA = "0x18082DA00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA590", Offset = "0x7B9790", VA = "0x1807BA590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FAMFAIHHPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x82D8B0", Offset = "0x82CAB0", VA = "0x18082D8B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x92B250", Offset = "0x92A450", VA = "0x18092B250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo FLLBLLDGIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public DCELOEBFDPO[] AJGEPIAIDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7B4150", Offset = "0x7B3350", VA = "0x1807B4150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DCELOEBFDPO[] IFFMHJKMBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6A645D0", Offset = "0x6A637D0", VA = "0x186A645D0")]
	public MMJBDOANMHH(Type MJMAEGDPBNJ, Func<string, string> DHOJEIKJGBB, bool EBIHLBBJDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6A644F0", Offset = "0x6A636F0", VA = "0x186A644F0")]
	private static bool OCHLDHDMKFA(IEnumerator<ConstructorInfo> FCANAHAHMLB, ConstructorInfo HLBJMMDBAMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct HIPCDIEOICO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong LKBCFKGJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int OGMFBLJMCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1E4CD40", Offset = "0x1E4BF40", VA = "0x181E4CD40")]
	public HIPCDIEOICO(ulong OLOMENAMAEG, int FKOEOOAPFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FED0", Offset = "0x6A5F0D0", VA = "0x186A5FED0")]
	public void LAEJPLCMDJE(HIPCDIEOICO MEJMHKPOODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FD00", Offset = "0x6A5EF00", VA = "0x186A5FD00")]
	public static HIPCDIEOICO AKFHELKOFKD(HIPCDIEOICO LLLCBODKBAN, HIPCDIEOICO HIOEJKGFIKI)
	{
		return default(HIPCDIEOICO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FDB0", Offset = "0x6A5EFB0", VA = "0x186A5FDB0")]
	public void HCAMIIKHCJI(HIPCDIEOICO MEJMHKPOODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FD10", Offset = "0x6A5EF10", VA = "0x186A5FD10")]
	public static HIPCDIEOICO CFBBCLBIIMN(HIPCDIEOICO LLLCBODKBAN, HIPCDIEOICO HIOEJKGFIKI)
	{
		return default(HIPCDIEOICO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FE90", Offset = "0x6A5F090", VA = "0x186A5FE90")]
	public void HFMGONIDILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FE40", Offset = "0x6A5F040", VA = "0x186A5FE40")]
	public static HIPCDIEOICO HFMGONIDILA(HIPCDIEOICO LLLCBODKBAN)
	{
		return default(HIPCDIEOICO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct BLINLGKNLII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] ENIOLEEEFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int BMIAFODFMCE;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x18D3A40", Offset = "0x18D2C40", VA = "0x1818D3A40")]
	public BLINLGKNLII(byte[] ENIOLEEEFGI, int JCMPCLFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EF10", Offset = "0x6A4E110", VA = "0x186A4EF10")]
	public void JCBCJLINOBD(byte DMCHJABNPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6A55470", Offset = "0x6A54670", VA = "0x186A55470")]
	public void LLJHJIMKBHP(byte[] DMCHJABNPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A55350", Offset = "0x6A54550", VA = "0x186A55350")]
	public void LHMAOFJFPJF(byte[] DMCHJABNPHL, int EAMNBPDOIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A553D0", Offset = "0x6A545D0", VA = "0x186A553D0")]
	public void LHMAOFJFPJF(byte[] DMCHJABNPHL, int GGLMJACONBL, int EAMNBPDOIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A551D0", Offset = "0x6A543D0", VA = "0x186A551D0")]
	public void CLLAFIKJLGH(byte PHDOOEGGBGI, int KMJOEPJMADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6A55250", Offset = "0x6A54450", VA = "0x186A55250")]
	public void FHBHDMICKAO(string DMCHJABNPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class DOHCEKNFFHK
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum FGPLGMLPLPL
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum BEHOLJNNCBO
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum ICJMPMDHOJD
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
	private static byte[] OGEICELJOCO;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] CFBLBBNGPFD;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] DKDAEFBCDBN;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] GAPIAJEMAKD;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly ICJMPMDHOJD DAHKCBHMBNN;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char JCMKIIHJBLL;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int NJKMDCIGHBI;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int NJCONBKNGJC;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] CICPGDGLODF;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AD80", Offset = "0x6A59F80", VA = "0x186A5AD80")]
	private static byte[] EGIMOPCGHAA(int ANCJPCFOHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B180", Offset = "0x6A5A380", VA = "0x186A5B180")]
	private static byte[] GDOKJIMPFEG(int ANCJPCFOHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AE50", Offset = "0x6A5A050", VA = "0x186A5AE50")]
	public static int EGPPBBFDFED(byte[] ENIOLEEEFGI, int BMIAFODFMCE, float EKDDCPALANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AF70", Offset = "0x6A5A170", VA = "0x186A5AF70")]
	public static int EGPPBBFDFED(byte[] ENIOLEEEFGI, int BMIAFODFMCE, double EKDDCPALANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B090", Offset = "0x6A5A290", VA = "0x186A5B090")]
	private static bool FDNMBJDBNEL(byte[] ENIOLEEEFGI, int EAMNBPDOIFO, ulong AIANFFFODFG, ulong ECHIPMPEBEG, ulong KBMOLOOENMJ, ulong EKAMDCJLJJE, ulong BIMPCEDADHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BDC0", Offset = "0x6A5AFC0", VA = "0x186A5BDC0")]
	private static void NONOJBEDLHD(uint MNDAKOCHFGN, int PHECOHBHGIO, [Out] uint LJJLAJFAILD, [Out] int MIBBNEGCJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BEB0", Offset = "0x6A5B0B0", VA = "0x186A5BEB0")]
	private static bool OKCIGFGNOJP(HIPCDIEOICO GDLNMEBGBMB, HIPCDIEOICO HDJLHPPJJLL, HIPCDIEOICO JECMFCPANHL, byte[] ENIOLEEEFGI, [Out] int EAMNBPDOIFO, [Out] int ICCPOHBPIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A900", Offset = "0x6A59B00", VA = "0x186A5A900")]
	private static bool AFFGMJAPLFI(double EACOJHAMHEA, FGPLGMLPLPL PAIKDKBMDIL, byte[] ENIOLEEEFGI, [Out] int EAMNBPDOIFO, [Out] int NLMJAOAHAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C760", Offset = "0x6A5B960", VA = "0x186A5C760")]
	private static bool PNIHMAOGKJG(double EACOJHAMHEA, FGPLGMLPLPL PAIKDKBMDIL, byte[] ENIOLEEEFGI, [Out] int EAMNBPDOIFO, [Out] int AOAHNINLBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B260", Offset = "0x6A5A460", VA = "0x186A5B260")]
	private static bool GJLDGAPBEBC(double EKDDCPALANJ, BLINLGKNLII OHACGJLBDKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C290", Offset = "0x6A5B490", VA = "0x186A5C290")]
	private static bool PLOILLENPBB(double EKDDCPALANJ, BLINLGKNLII OHACGJLBDKE, BEHOLJNNCBO PAIKDKBMDIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BA30", Offset = "0x6A5AC30", VA = "0x186A5BA30")]
	private static void JJADNAECMHD(byte[] CDMHKPOMIKC, int EAMNBPDOIFO, int AOAHNINLBGI, int NHDCMPBAMHN, BLINLGKNLII OHACGJLBDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B420", Offset = "0x6A5A620", VA = "0x186A5B420")]
	private static void HMHGPKIPPLF(byte[] CDMHKPOMIKC, int EAMNBPDOIFO, int FKOEOOAPFCJ, BLINLGKNLII OHACGJLBDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B840", Offset = "0x6A5AA40", VA = "0x186A5B840")]
	private static bool IJNFICDFCFN(double EACOJHAMHEA, BEHOLJNNCBO PAIKDKBMDIL, int KAJCLGKDOJG, byte[] KGKIOAJBCGA, [Out] bool NNCIFOHFGMO, [Out] int EAMNBPDOIFO, [Out] int EBFLKLNOENC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct LBFCDOLNFEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double PCLNGBGMCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong LHFHMPAIEMA;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct IJADEGFMMHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float LKBCFKGJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint IHNONGIOKKE;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct CMAEFHHAGJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong FJLCLCGNDEF;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A55C10", Offset = "0x6A54E10", VA = "0x186A55C10")]
	public CMAEFHHAGJM(double PCLNGBGMCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A55B70", Offset = "0x6A54D70", VA = "0x186A55B70")]
	public CMAEFHHAGJM(HIPCDIEOICO PCLNGBGMCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A55730", Offset = "0x6A54930", VA = "0x186A55730")]
	public HIPCDIEOICO HEINMEKOKNL()
	{
		return default(HIPCDIEOICO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A55AF0", Offset = "0x6A54CF0", VA = "0x186A55AF0")]
	public HIPCDIEOICO PPKMLHBDMIM()
	{
		return default(HIPCDIEOICO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
	public ulong CEFNLOAFJHJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A55630", Offset = "0x6A54830", VA = "0x186A55630")]
	public double GHHLBAIFAOO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A55940", Offset = "0x6A54B40", VA = "0x186A55940")]
	public double JKHGADPFDCP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A555E0", Offset = "0x6A547E0", VA = "0x186A555E0")]
	public int AOGBAIAAHHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A55A90", Offset = "0x6A54C90", VA = "0x186A55A90")]
	public ulong MBFAOAHAFFM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A55610", Offset = "0x6A54810", VA = "0x186A55610")]
	public bool EGAAHAIJCDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A55AC0", Offset = "0x6A54CC0", VA = "0x186A55AC0")]
	public bool MEMKKNDGGIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A55700", Offset = "0x6A54900", VA = "0x186A55700")]
	public bool GMDMKPGPOGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A55910", Offset = "0x6A54B10", VA = "0x186A55910")]
	public bool IJMGOMEKGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A55A70", Offset = "0x6A54C70", VA = "0x186A55A70")]
	public int LEJPLBJOKNC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A557C0", Offset = "0x6A549C0", VA = "0x186A557C0")]
	public void HMDDNLIMBLM([Out] HIPCDIEOICO JEMLDACCOGL, [Out] HIPCDIEOICO BCMNNGDBBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A556B0", Offset = "0x6A548B0", VA = "0x186A556B0")]
	public bool GHJFJNILGGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2E43F10", Offset = "0x2E43110", VA = "0x182E43F10")]
	public double EKDDCPALANJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A557A0", Offset = "0x6A549A0", VA = "0x186A557A0")]
	public static int HGIJHDGNPCK(int OEKPIFMKKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A55AE0", Offset = "0x6A54CE0", VA = "0x186A55AE0")]
	public static double PPBNGALCIFC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A559E0", Offset = "0x6A54BE0", VA = "0x186A559E0")]
	public static ulong KEFDHLAOOGK(HIPCDIEOICO PMCEICPOLOA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct BHIMFGKJDDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint BFMCKCEFAAK;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2F00", Offset = "0x1FB2100", VA = "0x181FB2F00")]
	public BHIMFGKJDDP(float LKBCFKGJILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A54B40", Offset = "0x6A53D40", VA = "0x186A54B40")]
	public HIPCDIEOICO HEINMEKOKNL()
	{
		return default(HIPCDIEOICO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0")]
	public uint MGKGJOLOABF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A54AD0", Offset = "0x6A53CD0", VA = "0x186A54AD0")]
	public int AOGBAIAAHHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A54CC0", Offset = "0x6A53EC0", VA = "0x186A54CC0")]
	public uint MBFAOAHAFFM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A54AF0", Offset = "0x6A53CF0", VA = "0x186A54AF0")]
	public bool EGAAHAIJCDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A54B90", Offset = "0x6A53D90", VA = "0x186A54B90")]
	public void HMDDNLIMBLM([Out] HIPCDIEOICO JEMLDACCOGL, [Out] HIPCDIEOICO BCMNNGDBBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A54B00", Offset = "0x6A53D00", VA = "0x186A54B00")]
	public bool GHJFJNILGGA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct NMFGGPKBKPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong OLOMENAMAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short OCENADMFOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short NLMJAOAHAJP;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A68650", Offset = "0x6A67850", VA = "0x186A68650")]
	public NMFGGPKBKPP(ulong OLOMENAMAEG, short OCENADMFOJL, short NLMJAOAHAJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class ONGPNKNNGBE
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly NMFGGPKBKPP[] MKCDHAPCFOC;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A69750", Offset = "0x6A68950", VA = "0x186A69750")]
	public static void GOPEMBJNMNI(int PPELALGFJHM, int MBPDPDOJLEC, [Out] HIPCDIEOICO LJJLAJFAILD, [Out] int NLMJAOAHAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A69680", Offset = "0x6A68880", VA = "0x186A69680")]
	public static void COIBNNIENON(int MJEPGPAFODK, [Out] HIPCDIEOICO LJJLAJFAILD, [Out] int IAFNCHIDOHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct MBFMCPLBGPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] GNPAJENJDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int GGLMJACONBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int HEJBJNFDLGJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A64260", Offset = "0x6A63460", VA = "0x186A64260")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x38387F0", Offset = "0x38379F0", VA = "0x1838387F0")]
	public MBFMCPLBGPM(byte[] GNPAJENJDCN, int GGLMJACONBL, int EAMNBPDOIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB410", Offset = "0x1FDA610", VA = "0x181FDB410")]
	public int EAMNBPDOIFO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A64200", Offset = "0x6A63400", VA = "0x186A64200")]
	public MBFMCPLBGPM MMNFAEFBPBJ(int BOAMPKDFKLM, int JFGPAIHHEJK)
	{
		return default(MBFMCPLBGPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class CPMMBAFKLNH
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] PPENEGIPBIM;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] KNBFKKNLFGK;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int MNJDOCGBCJB;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A57780", Offset = "0x6A56980", VA = "0x186A57780")]
	private static byte[] PIHCOELOCFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A56F10", Offset = "0x6A56110", VA = "0x186A56F10")]
	private static MBFMCPLBGPM OBDFOPLEONF(MBFMCPLBGPM ENIOLEEEFGI)
	{
		return default(MBFMCPLBGPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A572E0", Offset = "0x6A564E0", VA = "0x186A572E0")]
	private static MBFMCPLBGPM OKGFAOJLJAK(MBFMCPLBGPM ENIOLEEEFGI)
	{
		return default(MBFMCPLBGPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A564D0", Offset = "0x6A556D0", VA = "0x186A564D0")]
	private static void LCFAFIDFLGF(MBFMCPLBGPM ENIOLEEEFGI, int FKOEOOAPFCJ, byte[] EADCGNJLDBK, [Out] int HEMFPAPGEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A56FF0", Offset = "0x6A561F0", VA = "0x186A56FF0")]
	private static void OEDAGJAKLNG(MBFMCPLBGPM ENIOLEEEFGI, int FKOEOOAPFCJ, byte[] HHHGCKJAGIA, int KPHEJMAMGJE, [Out] MBFMCPLBGPM KBDJCDNLLDC, [Out] int IGOJNAIHDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A56BB0", Offset = "0x6A55DB0", VA = "0x186A56BB0")]
	private static ulong MEIMOGKOLMC(MBFMCPLBGPM ENIOLEEEFGI, [Out] int NAPGOFKIGOP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A56270", Offset = "0x6A55470", VA = "0x186A56270")]
	private static void HNLOAKLPCLH(MBFMCPLBGPM ENIOLEEEFGI, [Out] HIPCDIEOICO IFJGEIAONPI, [Out] int FAGJGBPPLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A573C0", Offset = "0x6A565C0", VA = "0x186A573C0")]
	private static bool PBMBMELOIJJ(MBFMCPLBGPM KBDJCDNLLDC, int FKOEOOAPFCJ, [Out] double IFJGEIAONPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A560D0", Offset = "0x6A552D0", VA = "0x186A560D0")]
	private static HIPCDIEOICO FCOHCLEFBCC(int FKOEOOAPFCJ)
	{
		return default(HIPCDIEOICO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A56560", Offset = "0x6A55760", VA = "0x186A56560")]
	private static bool LNNNBHKFNOJ(MBFMCPLBGPM ENIOLEEEFGI, int FKOEOOAPFCJ, [Out] double IFJGEIAONPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A55FB0", Offset = "0x6A551B0", VA = "0x186A55FB0")]
	private static bool EOENIIPEHHF(MBFMCPLBGPM KBDJCDNLLDC, int FKOEOOAPFCJ, [Out] double NDFNJIEKPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A563B0", Offset = "0x6A555B0", VA = "0x186A563B0")]
	public static double? JBHCBHDIBLF(MBFMCPLBGPM ENIOLEEEFGI, int FKOEOOAPFCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A56C40", Offset = "0x6A55E40", VA = "0x186A56C40")]
	public static float? NKLMNKBLGHF(MBFMCPLBGPM ENIOLEEEFGI, int FKOEOOAPFCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct NEFLNIFPHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] ENIOLEEEFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int BMIAFODFMCE;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A65F50", Offset = "0x6A65150", VA = "0x186A65F50")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x18D3A40", Offset = "0x18D2C40", VA = "0x1818D3A40")]
	public NEFLNIFPHPA(byte[] ENIOLEEEFGI, int BMIAFODFMCE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A65F10", Offset = "0x6A65110", VA = "0x186A65F10")]
	public static NEFLNIFPHPA GFACCPEAGLE(NEFLNIFPHPA AOFIGDLFNLH)
	{
		return default(NEFLNIFPHPA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A65FF0", Offset = "0x6A651F0", VA = "0x186A65FF0")]
	public static NEFLNIFPHPA OLHFJEIKJLB(NEFLNIFPHPA AOFIGDLFNLH, int EAMNBPDOIFO)
	{
		return default(NEFLNIFPHPA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A65E60", Offset = "0x6A65060", VA = "0x186A65E60")]
	public static int BCJDOINJGCB(NEFLNIFPHPA DEHAFGPDPHM, NEFLNIFPHPA FAFKEFEMLFH)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A65ED0", Offset = "0x6A650D0", VA = "0x186A65ED0")]
	public static bool FPIEKNKMEBM(NEFLNIFPHPA DEHAFGPDPHM, NEFLNIFPHPA FAFKEFEMLFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A65FB0", Offset = "0x6A651B0", VA = "0x186A65FB0")]
	public static bool LEBDJINPIPG(NEFLNIFPHPA DEHAFGPDPHM, NEFLNIFPHPA FAFKEFEMLFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A65EE0", Offset = "0x6A650E0", VA = "0x186A65EE0")]
	public static bool FPIEKNKMEBM(NEFLNIFPHPA DEHAFGPDPHM, char FAFKEFEMLFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A65F80", Offset = "0x6A65180", VA = "0x186A65F80")]
	public static bool LEBDJINPIPG(NEFLNIFPHPA DEHAFGPDPHM, char FAFKEFEMLFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A65F80", Offset = "0x6A65180", VA = "0x186A65F80")]
	public static bool LEBDJINPIPG(NEFLNIFPHPA DEHAFGPDPHM, byte FAFKEFEMLFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A65FC0", Offset = "0x6A651C0", VA = "0x186A65FC0")]
	public static bool MEDCODNFMOO(NEFLNIFPHPA DEHAFGPDPHM, char FAFKEFEMLFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A65F20", Offset = "0x6A65120", VA = "0x186A65F20")]
	public static bool GGEIKHBFPLB(NEFLNIFPHPA DEHAFGPDPHM, char FAFKEFEMLFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A65EA0", Offset = "0x6A650A0", VA = "0x186A65EA0")]
	public static bool BNKNCLACICD(NEFLNIFPHPA DEHAFGPDPHM, char FAFKEFEMLFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A65E70", Offset = "0x6A65070", VA = "0x186A65E70")]
	public static bool BJLFKHFAHFD(NEFLNIFPHPA DEHAFGPDPHM, char FAFKEFEMLFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class KFOKEABNNPC
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] GNPEAJDBJNP;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] PIPOKNMEACB;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] DKDAEFBCDBN;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] GAPIAJEMAKD;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] LKHKBFOANMK;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int AMIKKKLNJPL;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] HMOFLHEEDBL;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int LFBCLPLAIOM;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A63630", Offset = "0x6A62830", VA = "0x186A63630")]
	private static byte[] FOCDGNBOPDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A63BC0", Offset = "0x6A62DC0", VA = "0x186A63BC0")]
	private static byte[] PNACHOPJILD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A63530", Offset = "0x6A62730", VA = "0x186A63530")]
	public static double FEGLMBPJBOK(byte[] ENIOLEEEFGI, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A639E0", Offset = "0x6A62BE0", VA = "0x186A639E0")]
	public static float MHFGGDDHLPO(byte[] ENIOLEEEFGI, int BMIAFODFMCE, [Out] int LDDDBBDIFKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A63A90", Offset = "0x6A62C90", VA = "0x186A63A90")]
	private static bool OBOLCMKHBDN(int EFCGILCAOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A63710", Offset = "0x6A62910", VA = "0x186A63710")]
	private static bool IDIKBDNAACL(NEFLNIFPHPA EBJNEJIIOMI, NEFLNIFPHPA HOMODAIKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A63910", Offset = "0x6A62B10", VA = "0x186A63910")]
	private static bool JNIPHFMCCNN(NEFLNIFPHPA EBJNEJIIOMI, NEFLNIFPHPA HOMODAIKDLJ, byte[] PDGILFPPEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A635E0", Offset = "0x6A627E0", VA = "0x186A635E0")]
	private static bool FLKCKDHBJPB(NEFLNIFPHPA PHNCGFCJFPM, byte[] DMCHJABNPHL, int BMIAFODFMCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A638F0", Offset = "0x6A62AF0", VA = "0x186A638F0")]
	private static double JJIEJJHFCEC(bool NNCIFOHFGMO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A625A0", Offset = "0x6A617A0", VA = "0x186A625A0")]
	private static double CLEJCOIHBJJ(NEFLNIFPHPA BHCBEHDFPNA, int EAMNBPDOIFO, bool CIJFMGJKCJH, [Out] int CGMKGFLLAFC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class JODHPFDAHMI<T> : GHLIBNINOHA<T[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly NFPLJLLADBL<T> NJELNIGFDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly MCNGMCOFFLN NKFHKGNCAHF;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D310", Offset = "0x3A5C510", VA = "0x183A5D310")]
	public JODHPFDAHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
	public JODHPFDAHMI(MCNGMCOFFLN NKFHKGNCAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F40", Offset = "0x3C54140", VA = "0x183C54F40", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C55180", Offset = "0x3C54380", VA = "0x183C55180", Slot = "5")]
	public T[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class DFDGELLLDAG<T> : GHLIBNINOHA<ArraySegment<T>>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly NFPLJLLADBL<T> NJELNIGFDEK;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x508DDF0", Offset = "0x508CFF0", VA = "0x18508DDF0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ArraySegment<T> EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x508E0F0", Offset = "0x508D2F0", VA = "0x18508E0F0", Slot = "5")]
	public ArraySegment<T> MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class JKCNBAJBBKA<T> : GHLIBNINOHA<List<T>>, LCGLHBCBKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly MCNGMCOFFLN NKFHKGNCAHF;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D310", Offset = "0x3A5C510", VA = "0x183A5D310")]
	public JKCNBAJBBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
	public JKCNBAJBBKA(MCNGMCOFFLN NKFHKGNCAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x3C304E0", Offset = "0x3C2F6E0", VA = "0x183C304E0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, List<T> EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3C33000", Offset = "0x3C32200", VA = "0x183C33000", Slot = "5")]
	public List<T> MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class MBNANKIGKGN<TElement, TIntermediate, TEnumerator, TCollection> : GHLIBNINOHA<TCollection>, LCGLHBCBKDI where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3F09C20", Offset = "0x3F08E20", VA = "0x183F09C20", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, TCollection EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3F0AAF0", Offset = "0x3F09CF0", VA = "0x183F0AAF0", Slot = "5")]
	public TCollection MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator PMOLKIANDPE(TCollection HEEIDJMADFG);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DMOLILFLBFL();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void GHBEENLPKLN(TIntermediate HDHGOBOIDNG, int MBGANDEDPDN, TElement EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection MHOCMODHEJI(TIntermediate PLKOEPABEEG);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected MBNANKIGKGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class HBCCOBBKDCH<TElement, TIntermediate, TCollection> : MBNANKIGKGN<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x393F1F0", Offset = "0x393E3F0", VA = "0x18393F1F0", Slot = "6")]
	protected override IEnumerator<TElement> PMOLKIANDPE(TCollection HEEIDJMADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x33E2BF0", Offset = "0x33E1DF0", VA = "0x1833E2BF0")]
	protected HBCCOBBKDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class OAPMFANNPLA<TElement, TCollection> : HBCCOBBKDCH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected sealed override TCollection MHOCMODHEJI(TCollection PLKOEPABEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class JOFHHDIIJNH<TElement, TCollection> : OAPMFANNPLA<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3C55650", Offset = "0x3C54850", VA = "0x183C55650", Slot = "7")]
	protected override TCollection DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3C55670", Offset = "0x3C54870", VA = "0x183C55670", Slot = "8")]
	protected override void GHBEENLPKLN(TCollection HDHGOBOIDNG, int MBGANDEDPDN, TElement EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class AHGLHENFDOP<T> : MBNANKIGKGN<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x342BCF0", Offset = "0x342AEF0", VA = "0x18342BCF0", Slot = "8")]
	protected override void GHBEENLPKLN(LinkedList<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override LinkedList<T> MHOCMODHEJI(LinkedList<T> PLKOEPABEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override LinkedList<T> DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x38AEC90", Offset = "0x38ADE90", VA = "0x1838AEC90", Slot = "6")]
	protected override LinkedList<T>.Enumerator PMOLKIANDPE(LinkedList<T> HEEIDJMADFG)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class CJGJJELGILL<T> : MBNANKIGKGN<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x342BCF0", Offset = "0x342AEF0", VA = "0x18342BCF0", Slot = "8")]
	protected override void GHBEENLPKLN(Queue<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override Queue<T> DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x342BD30", Offset = "0x342AF30", VA = "0x18342BD30", Slot = "6")]
	protected override Queue<T>.Enumerator PMOLKIANDPE(Queue<T> HEEIDJMADFG)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override Queue<T> MHOCMODHEJI(Queue<T> PLKOEPABEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class MANGHKJGOGI<T> : MBNANKIGKGN<T, KAPEFACCAGP<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x38643F0", Offset = "0x38635F0", VA = "0x1838643F0", Slot = "8")]
	protected override void GHBEENLPKLN(KAPEFACCAGP<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x38643C0", Offset = "0x38635C0", VA = "0x1838643C0", Slot = "7")]
	protected override KAPEFACCAGP<T> DMOLILFLBFL()
	{
		return default(KAPEFACCAGP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3F04F00", Offset = "0x3F04100", VA = "0x183F04F00", Slot = "6")]
	protected override Stack<T>.Enumerator PMOLKIANDPE(Stack<T> HEEIDJMADFG)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3F04E20", Offset = "0x3F04020", VA = "0x183F04E20", Slot = "9")]
	protected override Stack<T> MHOCMODHEJI(KAPEFACCAGP<T> PLKOEPABEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class ELFPDCNACOF<T> : MBNANKIGKGN<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x342BCF0", Offset = "0x342AEF0", VA = "0x18342BCF0", Slot = "8")]
	protected override void GHBEENLPKLN(HashSet<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override HashSet<T> MHOCMODHEJI(HashSet<T> PLKOEPABEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override HashSet<T> DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x342BD30", Offset = "0x342AF30", VA = "0x18342BD30", Slot = "6")]
	protected override HashSet<T>.Enumerator PMOLKIANDPE(HashSet<T> HEEIDJMADFG)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class LKPGBLODIEI<T> : HBCCOBBKDCH<T, KAPEFACCAGP<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x38643F0", Offset = "0x38635F0", VA = "0x1838643F0", Slot = "8")]
	protected override void GHBEENLPKLN(KAPEFACCAGP<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3D62AC0", Offset = "0x3D61CC0", VA = "0x183D62AC0", Slot = "9")]
	protected override ReadOnlyCollection<T> MHOCMODHEJI(KAPEFACCAGP<T> PLKOEPABEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3D62A90", Offset = "0x3D61C90", VA = "0x183D62A90", Slot = "7")]
	protected override KAPEFACCAGP<T> DMOLILFLBFL()
	{
		return default(KAPEFACCAGP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class NPOKFEIOMEJ<T> : HBCCOBBKDCH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x342BCF0", Offset = "0x342AEF0", VA = "0x18342BCF0", Slot = "8")]
	protected override void GHBEENLPKLN(List<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override List<T> DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override IList<T> MHOCMODHEJI(List<T> PLKOEPABEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class MOFEAJHEKPA<T> : HBCCOBBKDCH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x342BCF0", Offset = "0x342AEF0", VA = "0x18342BCF0", Slot = "8")]
	protected override void GHBEENLPKLN(List<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override List<T> DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override ICollection<T> MHOCMODHEJI(List<T> PLKOEPABEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class GHGKMCMKGAG<T> : HBCCOBBKDCH<T, KAPEFACCAGP<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x38643F0", Offset = "0x38635F0", VA = "0x1838643F0", Slot = "8")]
	protected override void GHBEENLPKLN(KAPEFACCAGP<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x38643C0", Offset = "0x38635C0", VA = "0x1838643C0", Slot = "7")]
	protected override KAPEFACCAGP<T> DMOLILFLBFL()
	{
		return default(KAPEFACCAGP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3864410", Offset = "0x3863610", VA = "0x183864410", Slot = "9")]
	protected override IEnumerable<T> MHOCMODHEJI(KAPEFACCAGP<T> PLKOEPABEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x33F0970", Offset = "0x33EFB70", VA = "0x1833F0970")]
	public GHGKMCMKGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class FAJJJBDNOKD<TKey, TElement> : GHLIBNINOHA<IGrouping<TKey, TElement>>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3759750", Offset = "0x3758950", VA = "0x183759750", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, IGrouping<TKey, TElement> EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x37599B0", Offset = "0x3758BB0", VA = "0x1837599B0", Slot = "5")]
	public IGrouping<TKey, TElement> MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class OGPDKLMHICL<TKey, TElement> : GHLIBNINOHA<ILookup<TKey, TElement>>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x40FECC0", Offset = "0x40FDEC0", VA = "0x1840FECC0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ILookup<TKey, TElement> EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x40FEDE0", Offset = "0x40FDFE0", VA = "0x1840FEDE0", Slot = "5")]
	public ILookup<TKey, TElement> MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class CEMFJKEMBPK<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey GHBNLDGJPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> JNKAEOBAPMA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey NFEHEBDHPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7B8ED0", Offset = "0x7B80D0", VA = "0x1807B8ED0")]
	public CEMFJKEMBPK(TKey GHBNLDGJPCB, IEnumerable<TElement> JNKAEOBAPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4A13E60", Offset = "0x4A13060", VA = "0x184A13E60", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x347A500", Offset = "0x3479700", VA = "0x18347A500", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class IBLNANHAPGJ<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> DIDLBAHENEE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x38BF420", Offset = "0x38BE620", VA = "0x1838BF420", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public IBLNANHAPGJ(Dictionary<TKey, IGrouping<TKey, TElement>> DIDLBAHENEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x37C9740", Offset = "0x37C8940", VA = "0x1837C9740", Slot = "5")]
	public bool Contains(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3A19C10", Offset = "0x3A18E10", VA = "0x183A19C10", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3A19C10", Offset = "0x3A18E10", VA = "0x183A19C10", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BMPHJDGPPLO<T> : GHLIBNINOHA<T>, LCGLHBCBKDI where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x47D6110", Offset = "0x47D5310", VA = "0x1847D6110", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x47D6420", Offset = "0x47D5620", VA = "0x1847D6420", Slot = "5")]
	public T MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BMPHJDGPPLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class IBPGPEIFAOI : GHLIBNINOHA<IEnumerable>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly GHLIBNINOHA<IEnumerable> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6A72FE0", Offset = "0x6A721E0", VA = "0x186A72FE0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, IEnumerable EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6A73290", Offset = "0x6A72490", VA = "0x186A73290", Slot = "5")]
	public IEnumerable MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public IBPGPEIFAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class LFCKLEFLKNM : GHLIBNINOHA<ICollection>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly GHLIBNINOHA<ICollection> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6A792B0", Offset = "0x6A784B0", VA = "0x186A792B0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ICollection EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6A79650", Offset = "0x6A78850", VA = "0x186A79650", Slot = "5")]
	public ICollection MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public LFCKLEFLKNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class BHJBNPNHDOE : GHLIBNINOHA<IList>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly GHLIBNINOHA<IList> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CC80", Offset = "0x6A6BE80", VA = "0x186A6CC80", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, IList EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CF90", Offset = "0x6A6C190", VA = "0x186A6CF90", Slot = "5")]
	public IList MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BHJBNPNHDOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class HAOOPLDOGIJ<T> : HBCCOBBKDCH<T, KAPEFACCAGP<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x393EB90", Offset = "0x393DD90", VA = "0x18393EB90", Slot = "8")]
	protected override void GHBEENLPKLN(KAPEFACCAGP<T> HDHGOBOIDNG, int MBGANDEDPDN, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x38643C0", Offset = "0x38635C0", VA = "0x1838643C0", Slot = "7")]
	protected override KAPEFACCAGP<T> DMOLILFLBFL()
	{
		return default(KAPEFACCAGP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x393EBD0", Offset = "0x393DDD0", VA = "0x18393EBD0", Slot = "9")]
	protected override IReadOnlyList<T> MHOCMODHEJI(KAPEFACCAGP<T> PLKOEPABEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x33F02C0", Offset = "0x33EF4C0", VA = "0x1833F02C0")]
	public HAOOPLDOGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class NEEIBIAGLIK
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A610", Offset = "0x6A79810", VA = "0x186A7A610")]
	public static DateTime PHEMHGCJNON(DateTime ANHKAIAHPKD)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class JKICMLKMMOJ : GHLIBNINOHA<DateTime>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly GHLIBNINOHA<DateTime> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6A75270", Offset = "0x6A74470", VA = "0x186A75270", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, DateTime EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6A75A20", Offset = "0x6A74C20", VA = "0x186A75A20", Slot = "5")]
	public DateTime MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public JKICMLKMMOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class JIBFBJOCKLH : GHLIBNINOHA<DateTimeOffset>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly GHLIBNINOHA<DateTimeOffset> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6A73F40", Offset = "0x6A73140", VA = "0x186A73F40", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, DateTimeOffset EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6A745E0", Offset = "0x6A737E0", VA = "0x186A745E0", Slot = "5")]
	public DateTimeOffset MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public JIBFBJOCKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class AAIHKMNLCBN : GHLIBNINOHA<TimeSpan>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly GHLIBNINOHA<TimeSpan> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] PMGOKPADKPL;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AEE0", Offset = "0x6A6A0E0", VA = "0x186A6AEE0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, TimeSpan EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2C0", Offset = "0x6A6A4C0", VA = "0x186A6B2C0", Slot = "5")]
	public TimeSpan MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public AAIHKMNLCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class ODIEJPPPJEL<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : GHLIBNINOHA<TDictionary>, LCGLHBCBKDI where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x40EAE70", Offset = "0x40EA070", VA = "0x1840EAE70", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, TDictionary EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x40EDDA0", Offset = "0x40ECFA0", VA = "0x1840EDDA0", Slot = "5")]
	public TDictionary MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator PMOLKIANDPE(TDictionary HEEIDJMADFG);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DMOLILFLBFL();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void GHBEENLPKLN(TIntermediate HDHGOBOIDNG, int MBGANDEDPDN, TKey GHBNLDGJPCB, TValue EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary MHOCMODHEJI(TIntermediate PLKOEPABEEG);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected ODIEJPPPJEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class DBIBCJPLMML<TKey, TValue, TIntermediate, TDictionary> : ODIEJPPPJEL<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x393F1F0", Offset = "0x393E3F0", VA = "0x18393F1F0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> PMOLKIANDPE(TDictionary HEEIDJMADFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class KOHILGGBFGI<TKey, TValue, TDictionary> : DBIBCJPLMML<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override TDictionary MHOCMODHEJI(TDictionary PLKOEPABEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class KNKENPKJMID<TKey, TValue> : ODIEJPPPJEL<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2FA0", Offset = "0x3CC21A0", VA = "0x183CC2FA0", Slot = "8")]
	protected override void GHBEENLPKLN(Dictionary<TKey, TValue> HDHGOBOIDNG, int MBGANDEDPDN, TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override Dictionary<TKey, TValue> MHOCMODHEJI(Dictionary<TKey, TValue> PLKOEPABEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override Dictionary<TKey, TValue> DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3040", Offset = "0x3CC2240", VA = "0x183CC3040", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator PMOLKIANDPE(Dictionary<TKey, TValue> HEEIDJMADFG)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x33E1EF0", Offset = "0x33E10F0", VA = "0x1833E1EF0")]
	public KNKENPKJMID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class AIJJANKKNOJ<TKey, TValue, TDictionary> : KOHILGGBFGI<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x38AF950", Offset = "0x38AEB50", VA = "0x1838AF950", Slot = "8")]
	protected override void GHBEENLPKLN(TDictionary HDHGOBOIDNG, int MBGANDEDPDN, TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3225460", Offset = "0x3224660", VA = "0x183225460", Slot = "7")]
	protected override TDictionary DMOLILFLBFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class HIDOLIAGMDI<TKey, TValue> : DBIBCJPLMML<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x393F370", Offset = "0x393E570", VA = "0x18393F370", Slot = "8")]
	protected override void GHBEENLPKLN(Dictionary<TKey, TValue> HDHGOBOIDNG, int MBGANDEDPDN, TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override Dictionary<TKey, TValue> DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override IDictionary<TKey, TValue> MHOCMODHEJI(Dictionary<TKey, TValue> PLKOEPABEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KFAENFAFBEJ<TKey, TValue> : KOHILGGBFGI<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x393F370", Offset = "0x393E570", VA = "0x18393F370", Slot = "8")]
	protected override void GHBEENLPKLN(SortedList<TKey, TValue> HDHGOBOIDNG, int MBGANDEDPDN, TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override SortedList<TKey, TValue> DMOLILFLBFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class HBMOHCKPPBN<TKey, TValue> : ODIEJPPPJEL<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x393F370", Offset = "0x393E570", VA = "0x18393F370", Slot = "8")]
	protected override void GHBEENLPKLN(SortedDictionary<TKey, TValue> HDHGOBOIDNG, int MBGANDEDPDN, TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> MHOCMODHEJI(SortedDictionary<TKey, TValue> PLKOEPABEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x342BC80", Offset = "0x342AE80", VA = "0x18342BC80", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> DMOLILFLBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x393F3B0", Offset = "0x393E5B0", VA = "0x18393F3B0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator PMOLKIANDPE(SortedDictionary<TKey, TValue> HEEIDJMADFG)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class ONMBMNKIGEH<T> : GHLIBNINOHA<T>, LCGLHBCBKDI where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x410BC00", Offset = "0x410AE00", VA = "0x18410BC00", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x410C0D0", Offset = "0x410B2D0", VA = "0x18410C0D0", Slot = "5")]
	public T MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ONMBMNKIGEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class CBCKKJJIGBI : GHLIBNINOHA<IDictionary>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly GHLIBNINOHA<IDictionary> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DF90", Offset = "0x6A6D190", VA = "0x186A6DF90", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, IDictionary EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E460", Offset = "0x6A6D660", VA = "0x186A6E460", Slot = "5")]
	public IDictionary MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public CBCKKJJIGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class KKLDGKIAAKN : GHLIBNINOHA<object>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void GGMPNDKALJF(object GANADNNKOHA, LCCLEIDENAE IBOFEJJMDAD, object EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly KMNKKAIHKNB<KeyValuePair<object, GGMPNDKALJF>> ACADNCOBJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly LCLOMAPDCGJ[] CBBEABKPALE;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6A78ED0", Offset = "0x6A780D0", VA = "0x186A78ED0")]
	public KKLDGKIAAKN(params LCLOMAPDCGJ[] CBBEABKPALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6A78480", Offset = "0x6A77680", VA = "0x186A78480", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, object EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6A78E40", Offset = "0x6A78040", VA = "0x186A78E40", Slot = "5")]
	public object MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class FEFBACNIAFD
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F900", Offset = "0x6A6EB00", VA = "0x186A6F900")]
	public static object KEBDKBHCOLH(Type MJMAEGDPBNJ, [Out] bool BGICEMAOGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6A70190", Offset = "0x6A6F390", VA = "0x186A70190")]
	public static object KHPLODNKOBE(Type MJMAEGDPBNJ, [Out] bool BGICEMAOGBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class NAIHMKLPNHB<T> : GHLIBNINOHA<T>, LCGLHBCBKDI, NJDONPFLFOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class BGMLMJAAELJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public BGMLMJAAELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x47BF1D0", Offset = "0x47BE3D0", VA = "0x1847BF1D0")]
		internal bool DFNPMBGGNDA(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class BPNBJEHPFAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public BPNBJEHPFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x47F2020", Offset = "0x47F1220", VA = "0x1847F2020")]
		internal bool FDDIGMPFGGP(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class KEJCIPLBNEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public KJHJKMAAMHF<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public KEJCIPLBNEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CAB4F0", Offset = "0x3CAA6F0", VA = "0x183CAB4F0")]
		internal void FIBPMFKIDII(LCCLEIDENAE writer, T value, LCLOMAPDCGJ _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class NDHMNDOMEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public JNJOLJHEMPK<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public NDHMNDOMEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3FC7B30", Offset = "0x3FC6D30", VA = "0x183FC7B30")]
		internal T LLHPKFEHLDE(BBNFHGAEBCH reader, LCLOMAPDCGJ _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly IOEIEMEKKBA<T> FEDIECOGPPI;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> KOBHBLEKKNM;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly KJHJKMAAMHF<T> EEKMCDFHJPM;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly JNJOLJHEMPK<T> CNLPPBGMAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool LIIAICHEMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly KJHJKMAAMHF<T> MJMDIAAEJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly JNJOLJHEMPK<T> EMGJFDGBHDF;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3F845F0", Offset = "0x3F837F0", VA = "0x183F845F0")]
	static NAIHMKLPNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3F8A010", Offset = "0x3F89210", VA = "0x183F8A010")]
	public NAIHMKLPNHB(bool LIIAICHEMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3F7FC80", Offset = "0x3F7EE80", VA = "0x183F7FC80", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3F80940", Offset = "0x3F7FB40", VA = "0x183F80940", Slot = "5")]
	public T MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3F802E0", Offset = "0x3F7F4E0", VA = "0x183F802E0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, T EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3F7F650", Offset = "0x3F7E850", VA = "0x183F7F650", Slot = "7")]
	public T FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class KBHPHGEJDEM<T> : GHLIBNINOHA<T[,]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CA6770", Offset = "0x3CA5970", VA = "0x183CA6770", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T[,] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CA69E0", Offset = "0x3CA5BE0", VA = "0x183CA69E0", Slot = "5")]
	public T[,] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KBHPHGEJDEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class POMKGEGGBEG<T> : GHLIBNINOHA<T[,,]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x41C0350", Offset = "0x41BF550", VA = "0x1841C0350", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T[,,] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x41C0670", Offset = "0x41BF870", VA = "0x1841C0670", Slot = "5")]
	public T[,,] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public POMKGEGGBEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class EBOFBMDGPDP<T> : GHLIBNINOHA<T[,,,]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x33FF790", Offset = "0x33FE990", VA = "0x1833FF790", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T[,,,] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x33FFB60", Offset = "0x33FED60", VA = "0x1833FFB60", Slot = "5")]
	public T[,,,] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public EBOFBMDGPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class OLDGLDMEEFK<T> : GHLIBNINOHA<T?>, LCGLHBCBKDI where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x41079C0", Offset = "0x4106BC0", VA = "0x1841079C0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x4107B30", Offset = "0x4106D30", VA = "0x184107B30", Slot = "5")]
	public T? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public OLDGLDMEEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class DBJPOCMIDPJ<T> : GHLIBNINOHA<T?>, LCGLHBCBKDI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly GHLIBNINOHA<T> MPFFFCKIJOO;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public DBJPOCMIDPJ(GHLIBNINOHA<T> MPFFFCKIJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5083C80", Offset = "0x5082E80", VA = "0x185083C80", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, T? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5084070", Offset = "0x5083270", VA = "0x185084070", Slot = "5")]
	public T? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class PHPEEDKCLPP : GHLIBNINOHA<sbyte>, LCGLHBCBKDI, NJDONPFLFOA<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly PHPEEDKCLPP LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BE20", Offset = "0x6A7B020", VA = "0x186A7BE20", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, sbyte EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BEF0", Offset = "0x6A7B0F0", VA = "0x186A7BEF0", Slot = "5")]
	public sbyte MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BE80", Offset = "0x6A7B080", VA = "0x186A7BE80", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, sbyte EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BD60", Offset = "0x6A7AF60", VA = "0x186A7BD60", Slot = "7")]
	public sbyte FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public PHPEEDKCLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class HCFCNCKELAC : GHLIBNINOHA<sbyte?>, LCGLHBCBKDI, NJDONPFLFOA<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly HCFCNCKELAC LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A71E20", Offset = "0x6A71020", VA = "0x186A71E20", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, sbyte? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A71FA0", Offset = "0x6A711A0", VA = "0x186A71FA0", Slot = "5")]
	public sbyte? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A71EE0", Offset = "0x6A710E0", VA = "0x186A71EE0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, sbyte? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A71D00", Offset = "0x6A70F00", VA = "0x186A71D00", Slot = "7")]
	public sbyte? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HCFCNCKELAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class PFCAONALIFD : GHLIBNINOHA<sbyte[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly PFCAONALIFD LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B830", Offset = "0x6A7AA30", VA = "0x186A7B830", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, sbyte[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B960", Offset = "0x6A7AB60", VA = "0x186A7B960", Slot = "5")]
	public sbyte[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public PFCAONALIFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class HJCJCOPICKA : GHLIBNINOHA<short>, LCGLHBCBKDI, NJDONPFLFOA<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly HJCJCOPICKA LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A90", Offset = "0x6A71C90", VA = "0x186A72A90", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, short EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A72B60", Offset = "0x6A71D60", VA = "0x186A72B60", Slot = "5")]
	public short MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A72AF0", Offset = "0x6A71CF0", VA = "0x186A72AF0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, short EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A729D0", Offset = "0x6A71BD0", VA = "0x186A729D0", Slot = "7")]
	public short FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HJCJCOPICKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class EEGMDBOGCIP : GHLIBNINOHA<short?>, LCGLHBCBKDI, NJDONPFLFOA<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly EEGMDBOGCIP LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F660", Offset = "0x6A6E860", VA = "0x186A6F660", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, short? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F7E0", Offset = "0x6A6E9E0", VA = "0x186A6F7E0", Slot = "5")]
	public short? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F720", Offset = "0x6A6E920", VA = "0x186A6F720", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, short? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F540", Offset = "0x6A6E740", VA = "0x186A6F540", Slot = "7")]
	public short? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public EEGMDBOGCIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class DNBBNIGDGIC : GHLIBNINOHA<short[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly DNBBNIGDGIC LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6ED70", Offset = "0x6A6DF70", VA = "0x186A6ED70", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, short[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EEA0", Offset = "0x6A6E0A0", VA = "0x186A6EEA0", Slot = "5")]
	public short[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public DNBBNIGDGIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class MNBCAPNKGNM : GHLIBNINOHA<int>, LCGLHBCBKDI, NJDONPFLFOA<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly MNBCAPNKGNM LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A480", Offset = "0x6A79680", VA = "0x186A7A480", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, int EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A550", Offset = "0x6A79750", VA = "0x186A7A550", Slot = "5")]
	public int MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A4E0", Offset = "0x6A796E0", VA = "0x186A7A4E0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, int EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A3C0", Offset = "0x6A795C0", VA = "0x186A7A3C0", Slot = "7")]
	public int FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public MNBCAPNKGNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class IOFIPNEHEKJ : GHLIBNINOHA<int?>, LCGLHBCBKDI, NJDONPFLFOA<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly IOFIPNEHEKJ LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A73670", Offset = "0x6A72870", VA = "0x186A73670", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, int? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A737F0", Offset = "0x6A729F0", VA = "0x186A737F0", Slot = "5")]
	public int? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A73730", Offset = "0x6A72930", VA = "0x186A73730", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, int? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A73550", Offset = "0x6A72750", VA = "0x186A73550", Slot = "7")]
	public int? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public IOFIPNEHEKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class DGDDGLFAIGP : GHLIBNINOHA<int[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly DGDDGLFAIGP LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EA40", Offset = "0x6A6DC40", VA = "0x186A6EA40", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, int[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EB70", Offset = "0x6A6DD70", VA = "0x186A6EB70", Slot = "5")]
	public int[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public DGDDGLFAIGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GPEHLAPALLP : GHLIBNINOHA<long>, LCGLHBCBKDI, NJDONPFLFOA<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly GPEHLAPALLP LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A71840", Offset = "0x6A70A40", VA = "0x186A71840", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, long EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A71910", Offset = "0x6A70B10", VA = "0x186A71910", Slot = "5")]
	public long MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A718A0", Offset = "0x6A70AA0", VA = "0x186A718A0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, long EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A71780", Offset = "0x6A70980", VA = "0x186A71780", Slot = "7")]
	public long FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GPEHLAPALLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class HEFEBJFLEHB : GHLIBNINOHA<long?>, LCGLHBCBKDI, NJDONPFLFOA<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly HEFEBJFLEHB LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A72200", Offset = "0x6A71400", VA = "0x186A72200", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, long? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A72380", Offset = "0x6A71580", VA = "0x186A72380", Slot = "5")]
	public long? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A722C0", Offset = "0x6A714C0", VA = "0x186A722C0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, long? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A720C0", Offset = "0x6A712C0", VA = "0x186A720C0", Slot = "7")]
	public long? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HEFEBJFLEHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class HIBAFHAKAEL : GHLIBNINOHA<long[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly HIBAFHAKAEL LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A726A0", Offset = "0x6A718A0", VA = "0x186A726A0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, long[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A727D0", Offset = "0x6A719D0", VA = "0x186A727D0", Slot = "5")]
	public long[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HIBAFHAKAEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class GMDBBGCBLDA : GHLIBNINOHA<byte>, LCGLHBCBKDI, NJDONPFLFOA<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly GMDBBGCBLDA LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A713E0", Offset = "0x6A705E0", VA = "0x186A713E0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, byte EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A714B0", Offset = "0x6A706B0", VA = "0x186A714B0", Slot = "5")]
	public byte MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A71440", Offset = "0x6A70640", VA = "0x186A71440", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, byte EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A71320", Offset = "0x6A70520", VA = "0x186A71320", Slot = "7")]
	public byte FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GMDBBGCBLDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class GDJONKHNJME : GHLIBNINOHA<byte?>, LCGLHBCBKDI, NJDONPFLFOA<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly GDJONKHNJME LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A70F30", Offset = "0x6A70130", VA = "0x186A70F30", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, byte? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A710B0", Offset = "0x6A702B0", VA = "0x186A710B0", Slot = "5")]
	public byte? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A70FF0", Offset = "0x6A701F0", VA = "0x186A70FF0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, byte? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A70E10", Offset = "0x6A70010", VA = "0x186A70E10", Slot = "7")]
	public byte? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GDJONKHNJME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class MBNBCJCGLEL : GHLIBNINOHA<ushort>, LCGLHBCBKDI, NJDONPFLFOA<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly MBNBCJCGLEL LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6A79FE0", Offset = "0x6A791E0", VA = "0x186A79FE0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ushort EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A0B0", Offset = "0x6A792B0", VA = "0x186A7A0B0", Slot = "5")]
	public ushort MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A040", Offset = "0x6A79240", VA = "0x186A7A040", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, ushort EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6A79F20", Offset = "0x6A79120", VA = "0x186A79F20", Slot = "7")]
	public ushort FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public MBNBCJCGLEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class HMDEHECMELL : GHLIBNINOHA<ushort?>, LCGLHBCBKDI, NJDONPFLFOA<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly HMDEHECMELL LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6A72D40", Offset = "0x6A71F40", VA = "0x186A72D40", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ushort? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6A72EC0", Offset = "0x6A720C0", VA = "0x186A72EC0", Slot = "5")]
	public ushort? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6A72E00", Offset = "0x6A72000", VA = "0x186A72E00", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, ushort? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6A72C20", Offset = "0x6A71E20", VA = "0x186A72C20", Slot = "7")]
	public ushort? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HMDEHECMELL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class LEHHKHCHBLE : GHLIBNINOHA<ushort[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly LEHHKHCHBLE LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6A78F80", Offset = "0x6A78180", VA = "0x186A78F80", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ushort[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6A790B0", Offset = "0x6A782B0", VA = "0x186A790B0", Slot = "5")]
	public ushort[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public LEHHKHCHBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class MILGFBNMLLM : GHLIBNINOHA<uint>, LCGLHBCBKDI, NJDONPFLFOA<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly MILGFBNMLLM LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A230", Offset = "0x6A79430", VA = "0x186A7A230", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, uint EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A300", Offset = "0x6A79500", VA = "0x186A7A300", Slot = "5")]
	public uint MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A290", Offset = "0x6A79490", VA = "0x186A7A290", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, uint EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A170", Offset = "0x6A79370", VA = "0x186A7A170", Slot = "7")]
	public uint FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public MILGFBNMLLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class MACEFFLDKEC : GHLIBNINOHA<uint?>, LCGLHBCBKDI, NJDONPFLFOA<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly MACEFFLDKEC LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6A79C80", Offset = "0x6A78E80", VA = "0x186A79C80", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, uint? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6A79E00", Offset = "0x6A79000", VA = "0x186A79E00", Slot = "5")]
	public uint? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6A79D40", Offset = "0x6A78F40", VA = "0x186A79D40", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, uint? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6A79B60", Offset = "0x6A78D60", VA = "0x186A79B60", Slot = "7")]
	public uint? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public MACEFFLDKEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class BOGPEBGAFGI : GHLIBNINOHA<uint[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly BOGPEBGAFGI LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D5C0", Offset = "0x6A6C7C0", VA = "0x186A6D5C0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, uint[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D6F0", Offset = "0x6A6C8F0", VA = "0x186A6D6F0", Slot = "5")]
	public uint[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BOGPEBGAFGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class JBJAHOMCDFK : GHLIBNINOHA<ulong>, LCGLHBCBKDI, NJDONPFLFOA<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly JBJAHOMCDFK LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x6A73DB0", Offset = "0x6A72FB0", VA = "0x186A73DB0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ulong EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6A73E80", Offset = "0x6A73080", VA = "0x186A73E80", Slot = "5")]
	public ulong MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6A73E10", Offset = "0x6A73010", VA = "0x186A73E10", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, ulong EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6A73CF0", Offset = "0x6A72EF0", VA = "0x186A73CF0", Slot = "7")]
	public ulong FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public JBJAHOMCDFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class FHNMNAMMNFD : GHLIBNINOHA<ulong?>, LCGLHBCBKDI, NJDONPFLFOA<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly FHNMNAMMNFD LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6A70B60", Offset = "0x6A6FD60", VA = "0x186A70B60", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ulong? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6A70CE0", Offset = "0x6A6FEE0", VA = "0x186A70CE0", Slot = "5")]
	public ulong? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6A70C20", Offset = "0x6A6FE20", VA = "0x186A70C20", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, ulong? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6A70A20", Offset = "0x6A6FC20", VA = "0x186A70A20", Slot = "7")]
	public ulong? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public FHNMNAMMNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class HAIPHLFAEDL : GHLIBNINOHA<ulong[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly HAIPHLFAEDL LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6A719D0", Offset = "0x6A70BD0", VA = "0x186A719D0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ulong[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6A71B00", Offset = "0x6A70D00", VA = "0x186A71B00", Slot = "5")]
	public ulong[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HAIPHLFAEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class EBHLAPMEABI : GHLIBNINOHA<float>, LCGLHBCBKDI, NJDONPFLFOA<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly EBHLAPMEABI LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F3B0", Offset = "0x6A6E5B0", VA = "0x186A6F3B0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, float EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F480", Offset = "0x6A6E680", VA = "0x186A6F480", Slot = "5")]
	public float MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F410", Offset = "0x6A6E610", VA = "0x186A6F410", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, float EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F2F0", Offset = "0x6A6E4F0", VA = "0x186A6F2F0", Slot = "7")]
	public float FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public EBHLAPMEABI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class ACFGCFELHJE : GHLIBNINOHA<float?>, LCGLHBCBKDI, NJDONPFLFOA<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly ACFGCFELHJE LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BE40", Offset = "0x6A6B040", VA = "0x186A6BE40", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, float? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BFC0", Offset = "0x6A6B1C0", VA = "0x186A6BFC0", Slot = "5")]
	public float? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BF00", Offset = "0x6A6B100", VA = "0x186A6BF00", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, float? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BD20", Offset = "0x6A6AF20", VA = "0x186A6BD20", Slot = "7")]
	public float? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ACFGCFELHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class APIEBPEONJK : GHLIBNINOHA<float[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly APIEBPEONJK LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C2C0", Offset = "0x6A6B4C0", VA = "0x186A6C2C0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, float[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C400", Offset = "0x6A6B600", VA = "0x186A6C400", Slot = "5")]
	public float[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public APIEBPEONJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class LKKLGMELOPL : GHLIBNINOHA<double>, LCGLHBCBKDI, NJDONPFLFOA<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly LKKLGMELOPL LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6A799D0", Offset = "0x6A78BD0", VA = "0x186A799D0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, double EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6A79AA0", Offset = "0x6A78CA0", VA = "0x186A79AA0", Slot = "5")]
	public double MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6A79A30", Offset = "0x6A78C30", VA = "0x186A79A30", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, double EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6A79910", Offset = "0x6A78B10", VA = "0x186A79910", Slot = "7")]
	public double FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public LKKLGMELOPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class JNKDGCJMGIJ : GHLIBNINOHA<double?>, LCGLHBCBKDI, NJDONPFLFOA<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly JNKDGCJMGIJ LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6A768E0", Offset = "0x6A75AE0", VA = "0x186A768E0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, double? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6A76A60", Offset = "0x6A75C60", VA = "0x186A76A60", Slot = "5")]
	public double? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6A769A0", Offset = "0x6A75BA0", VA = "0x186A769A0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, double? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6A767A0", Offset = "0x6A759A0", VA = "0x186A767A0", Slot = "7")]
	public double? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public JNKDGCJMGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class DFMPEJNBKDC : GHLIBNINOHA<double[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly DFMPEJNBKDC LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E700", Offset = "0x6A6D900", VA = "0x186A6E700", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, double[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E840", Offset = "0x6A6DA40", VA = "0x186A6E840", Slot = "5")]
	public double[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public DFMPEJNBKDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class EANGOIMDLNG : GHLIBNINOHA<bool>, LCGLHBCBKDI, NJDONPFLFOA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly EANGOIMDLNG LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F160", Offset = "0x6A6E360", VA = "0x186A6F160", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, bool EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F230", Offset = "0x6A6E430", VA = "0x186A6F230", Slot = "5")]
	public bool MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F1C0", Offset = "0x6A6E3C0", VA = "0x186A6F1C0", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, bool EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F0A0", Offset = "0x6A6E2A0", VA = "0x186A6F0A0", Slot = "7")]
	public bool FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public EANGOIMDLNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class OMOKKDNGFKN : GHLIBNINOHA<bool?>, LCGLHBCBKDI, NJDONPFLFOA<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly OMOKKDNGFKN LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B590", Offset = "0x6A7A790", VA = "0x186A7B590", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, bool? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B710", Offset = "0x6A7A910", VA = "0x186A7B710", Slot = "5")]
	public bool? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B650", Offset = "0x6A7A850", VA = "0x186A7B650", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, bool? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B470", Offset = "0x6A7A670", VA = "0x186A7B470", Slot = "7")]
	public bool? FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public OMOKKDNGFKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class CACAOKLHCBM : GHLIBNINOHA<bool[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly CACAOKLHCBM LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DC50", Offset = "0x6A6CE50", VA = "0x186A6DC50", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, bool[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DD90", Offset = "0x6A6CF90", VA = "0x186A6DD90", Slot = "5")]
	public bool[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public CACAOKLHCBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class KCPPAFGGHPN : GHLIBNINOHA<object>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly GHLIBNINOHA<object> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> HNPKNIDEGDE;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6A76B90", Offset = "0x6A75D90", VA = "0x186A76B90", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, object EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6A77820", Offset = "0x6A76A20", VA = "0x186A77820", Slot = "5")]
	public object MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KCPPAFGGHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class ADOHAFEPBGA : GHLIBNINOHA<byte[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly GHLIBNINOHA<byte[]> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C0E0", Offset = "0x6A6B2E0", VA = "0x186A6C0E0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, byte[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C1A0", Offset = "0x6A6B3A0", VA = "0x186A6C1A0", Slot = "5")]
	public byte[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ADOHAFEPBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class BDHMJCKNNOK : GHLIBNINOHA<ArraySegment<byte>>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GHLIBNINOHA<ArraySegment<byte>> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C800", Offset = "0x6A6BA00", VA = "0x186A6C800", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, ArraySegment<byte> EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C930", Offset = "0x6A6BB30", VA = "0x186A6C930", Slot = "5")]
	public ArraySegment<byte> MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BDHMJCKNNOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class NJNONAOAICL : GHLIBNINOHA<string>, LCGLHBCBKDI, NJDONPFLFOA<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly GHLIBNINOHA<string> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AFE0", Offset = "0x6A7A1E0", VA = "0x186A7AFE0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, string EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B0A0", Offset = "0x6A7A2A0", VA = "0x186A7B0A0", Slot = "5")]
	public string MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B040", Offset = "0x6A7A240", VA = "0x186A7B040", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, string EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AF90", Offset = "0x6A7A190", VA = "0x186A7AF90", Slot = "7")]
	public string FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public NJNONAOAICL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class BKGKIODCCOG : GHLIBNINOHA<string[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly BKGKIODCCOG LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D250", Offset = "0x6A6C450", VA = "0x186A6D250", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, string[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D380", Offset = "0x6A6C580", VA = "0x186A6D380", Slot = "5")]
	public string[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BKGKIODCCOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class KGODAADMNEL : GHLIBNINOHA<char>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly KGODAADMNEL LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6A782E0", Offset = "0x6A774E0", VA = "0x186A782E0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, char EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6A783A0", Offset = "0x6A775A0", VA = "0x186A783A0", Slot = "5")]
	public char MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KGODAADMNEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class KEIANCDFKBK : GHLIBNINOHA<char?>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly KEIANCDFKBK LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6A78060", Offset = "0x6A77260", VA = "0x186A78060", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, char? EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6A78160", Offset = "0x6A77360", VA = "0x186A78160", Slot = "5")]
	public char? MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KEIANCDFKBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class JAAHMOGCIHA : GHLIBNINOHA<char[]>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly JAAHMOGCIHA LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6A73910", Offset = "0x6A72B10", VA = "0x186A73910", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, char[] EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6A73AC0", Offset = "0x6A72CC0", VA = "0x186A73AC0", Slot = "5")]
	public char[] MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public JAAHMOGCIHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class NGNGKGKINFA : GHLIBNINOHA<Guid>, LCGLHBCBKDI, NJDONPFLFOA<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly GHLIBNINOHA<Guid> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AC20", Offset = "0x6A79E20", VA = "0x186A7AC20", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, Guid EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AE90", Offset = "0x6A7A090", VA = "0x186A7AE90", Slot = "5")]
	public Guid MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AD50", Offset = "0x6A79F50", VA = "0x186A7AD50", Slot = "6")]
	public void JGKIBAEJPBC(LCCLEIDENAE IBOFEJJMDAD, Guid EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AB80", Offset = "0x6A79D80", VA = "0x186A7AB80", Slot = "7")]
	public Guid FGNPFNLLBHB(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public NGNGKGKINFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class NFPBMKGIIJF : GHLIBNINOHA<decimal>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly GHLIBNINOHA<decimal> LMPCLGLBJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool MFOPAGGLDEH;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x52B4AA0", Offset = "0x52B3CA0", VA = "0x1852B4AA0")]
	public NFPBMKGIIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x185D6D0", Offset = "0x185C8D0", VA = "0x18185D6D0")]
	public NFPBMKGIIJF(bool MFOPAGGLDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A6D0", Offset = "0x6A798D0", VA = "0x186A7A6D0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, decimal EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A880", Offset = "0x6A79A80", VA = "0x186A7A880", Slot = "5")]
	public decimal MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GMEFCILOJGJ : GHLIBNINOHA<Uri>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly GHLIBNINOHA<Uri> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6A71570", Offset = "0x6A70770", VA = "0x186A71570", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, Uri EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6A71650", Offset = "0x6A70850", VA = "0x186A71650", Slot = "5")]
	public Uri MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GMEFCILOJGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class HHCECMIICHA : GHLIBNINOHA<Version>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly GHLIBNINOHA<Version> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6A724B0", Offset = "0x6A716B0", VA = "0x186A724B0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, Version EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6A72570", Offset = "0x6A71770", VA = "0x186A72570", Slot = "5")]
	public Version MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HHCECMIICHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class LBGDCNJIMEA<TKey, TValue> : GHLIBNINOHA<KeyValuePair<TKey, TValue>>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D410", Offset = "0x3D4C610", VA = "0x183D4D410", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, KeyValuePair<TKey, TValue> EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D5F0", Offset = "0x3D4C7F0", VA = "0x183D4D5F0", Slot = "5")]
	public KeyValuePair<TKey, TValue> MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class BFKFGKMDOJE : GHLIBNINOHA<StringBuilder>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly GHLIBNINOHA<StringBuilder> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CAB0", Offset = "0x6A6BCB0", VA = "0x186A6CAB0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, StringBuilder EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CB50", Offset = "0x6A6BD50", VA = "0x186A6CB50", Slot = "5")]
	public StringBuilder MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BFKFGKMDOJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class NKMBFGFNGKI : GHLIBNINOHA<BitArray>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly GHLIBNINOHA<BitArray> LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B160", Offset = "0x6A7A360", VA = "0x186A7B160", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, BitArray EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B280", Offset = "0x6A7A480", VA = "0x186A7B280", Slot = "5")]
	public BitArray MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public NKMBFGFNGKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class BOJPIFEEIAN : GHLIBNINOHA<Type>, LCGLHBCBKDI
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly BOJPIFEEIAN LMPCLGLBJMP;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex HEIICDGFEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool IDCIIGMMKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool HCEKAKIDOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool IINMBBBPAHJ;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DC30", Offset = "0x6A6CE30", VA = "0x186A6DC30")]
	public BOJPIFEEIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x603A780", Offset = "0x6039980", VA = "0x18603A780")]
	public BOJPIFEEIAN(bool IDCIIGMMKKC, bool HCEKAKIDOMC, bool IINMBBBPAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D8F0", Offset = "0x6A6CAF0", VA = "0x186A6D8F0", Slot = "4")]
	public void JCBMCDNAHJB(LCCLEIDENAE IBOFEJJMDAD, Type EKDDCPALANJ, LCLOMAPDCGJ HADCNGBCPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DA00", Offset = "0x6A6CC00", VA = "0x186A6DA00", Slot = "5")]
	public Type MAOCPLNNJJM(BBNFHGAEBCH GILMBCDEMDA, LCLOMAPDCGJ HADCNGBCPKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class BBDDIDCPDEB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] EDEOFGBHLKE;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly FFABBHCJNBA ICGLANJABGN;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C600", Offset = "0x6A6B800", VA = "0x186A6C600")]
	static BBDDIDCPDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class PHILLBIAOPO
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] CNIAFLDOEFG;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly FFABBHCJNBA KGJMFFFJGDC;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BB60", Offset = "0x6A7AD60", VA = "0x186A7BB60")]
	static PHILLBIAOPO()
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
