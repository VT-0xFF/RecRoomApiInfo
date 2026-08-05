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
public class JFBOLDPMDFM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	public JFBOLDPMDFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class DOBHJILOOOD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	public DOBHJILOOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CHKHLAICJNJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	public CHKHLAICJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class MFOCPICJCOC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	public MFOCPICJCOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class KKNCLFDMOJL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E490", Offset = "0x4B7D490", VA = "0x184B7E490")]
	public static bool GMAHDHNJBLO(this TypeInfo IGEIBCJNCHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class PFLMJBJPFOD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type HEDCAMCHEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69E130", Offset = "0x69D130", VA = "0x18069E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] LKDNMFKNBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6996F0", Offset = "0x6986F0", VA = "0x1806996F0")]
	public PFLMJBJPFOD(Type APEBNIBGLGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class FJJBONICGCG : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void KOIGGKEGCNJ<T>(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T KNFFAHGKNBH<T>(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG OHIDBDNDNIA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CDJJKNODMKB
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KBIOLGDHIDG<T> : CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NKJJGAMHDGI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FFOJCCDENBP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NBBPOLMOGFI
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2EA89E0", Offset = "0x2EA79E0", VA = "0x182EA89E0")]
	public static global::KBIOLGDHIDG<T> DPCKLAFOJEE<T>(this CDAHFIMKBKG OHIDBDNDNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E704A0", Offset = "0x4E6F4A0", VA = "0x184E704A0")]
	public static object OGFENLKMDAH(this CDAHFIMKBKG OHIDBDNDNIA, Type IGEIBCJNCHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KIACBADABBP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C0A0", Offset = "0x4B7B0A0", VA = "0x184B7C0A0")]
	public KIACBADABBP(string LMLMHJKGDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HJNHIBNNFEE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class PGGACBAHHGD
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] FAHBHODOFIG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] ANOHAAJJMPC;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4E73180", Offset = "0x4E72180", VA = "0x184E73180")]
		public static byte[] KDIMAKIMIBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4E730F0", Offset = "0x4E720F0", VA = "0x184E730F0")]
		public static char[] BJFIEAPEJEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> IDOEOMGHOGE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] OPHLMAKBHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] CCFMJPPGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int PNKNABOKANH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool NGDCOGJBDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4B71D10", Offset = "0x4B70D10", VA = "0x184B71D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B72440", Offset = "0x4B71440", VA = "0x184B72440")]
	public HJNHIBNNFEE(byte[] CCFMJPPGPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B72250", Offset = "0x4B71250", VA = "0x184B72250")]
	public HJNHIBNNFEE(byte[] CCFMJPPGPDK, int PNKNABOKANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B709F0", Offset = "0x4B6F9F0", VA = "0x184B709F0")]
	private KJJEPECLPAG HONJCJJFGOJ(string MPNBEECGANP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F5D0", Offset = "0x4B6E5D0", VA = "0x184B6F5D0")]
	private KJJEPECLPAG BCACCFGCBPD(string LMLMHJKGDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B72040", Offset = "0x4B71040", VA = "0x184B72040")]
	public void NCNNCIMJDEL(int PNKNABOKANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67E000", Offset = "0x67D000", VA = "0x18067E000")]
	public byte[] OCGCLACNCPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77D5E0", Offset = "0x77C5E0", VA = "0x18077D5E0")]
	public int JMGKDDIDBEG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B70600", Offset = "0x4B6F600", VA = "0x184B70600")]
	public FDHIMNDNOFP GBMAFOAPGIH()
	{
		return default(FDHIMNDNOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4B6FF50", Offset = "0x4B6EF50", VA = "0x184B6FF50")]
	public void EKMBEIPLMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B6FDF0", Offset = "0x4B6EDF0", VA = "0x184B6FDF0")]
	public bool DMPKDDCHJEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B71280", Offset = "0x4B70280", VA = "0x184B71280")]
	public bool LCOKPENLLIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4B703E0", Offset = "0x4B6F3E0", VA = "0x184B703E0")]
	public void FNKHLAKKDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4B70840", Offset = "0x4B6F840", VA = "0x184B70840")]
	public bool HJFAPGOKCCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4B6FB50", Offset = "0x4B6EB50", VA = "0x184B6FB50")]
	public bool CJEGICBADDF(ref int MIOCJKOOLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F780", Offset = "0x4B6E780", VA = "0x184B6F780")]
	public bool BKLHBEIIGMP(ref int MIOCJKOOLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4B6FD90", Offset = "0x4B6ED90", VA = "0x184B6FD90")]
	public bool DEHHEGBCOBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F540", Offset = "0x4B6E540", VA = "0x184B6F540")]
	public void BBBKDHEIDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B711F0", Offset = "0x4B701F0", VA = "0x184B711F0")]
	public bool LCDOMMDONOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B70970", Offset = "0x4B6F970", VA = "0x184B70970")]
	public bool HNDCLIHGIJK(ref int MIOCJKOOLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B70780", Offset = "0x4B6F780", VA = "0x184B70780")]
	public bool GEKFIMANEIM(ref int MIOCJKOOLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B70F00", Offset = "0x4B6FF00", VA = "0x184B70F00")]
	public bool IANHIDCLPMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F4B0", Offset = "0x4B6E4B0", VA = "0x184B6F4B0")]
	public void AKNLBGMMIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B71F20", Offset = "0x4B70F20", VA = "0x184B71F20")]
	public bool MBOCLFIJAPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4B714C0", Offset = "0x4B704C0", VA = "0x184B714C0")]
	public void LJJBKHIKJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4B71550", Offset = "0x4B70550", VA = "0x184B71550")]
	private void LMDDHBAGLGA(out byte[] DOGEDEBJECM, out int JNCINBDIODL, out int KPGAHJGDDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4B6FCE0", Offset = "0x4B6ECE0", VA = "0x184B6FCE0")]
	private static int DDPBPGOBCNC(char NCNGLFNLPAG, char OPGAGDBKIDA, char NKNPGFCGIPO, char LNMAPJNBGLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F6B0", Offset = "0x4B6E6B0", VA = "0x184B6F6B0")]
	private static int BJFBPCBEJGM(char JMDPDGBMGAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4B702E0", Offset = "0x4B6F2E0", VA = "0x184B702E0")]
	public ArraySegment<byte> FKHIIIOBNCP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4B71E80", Offset = "0x4B70E80", VA = "0x184B71E80")]
	public string MBCPHMOOCCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4B71250", Offset = "0x4B70250", VA = "0x184B71250")]
	public string LCHIDLJBJNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F980", Offset = "0x4B6E980", VA = "0x184B6F980")]
	public ArraySegment<byte> CDLCGNBEIDI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4B72050", Offset = "0x4B71050", VA = "0x184B72050")]
	public ArraySegment<byte> NPKFAELDBON()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B70090", Offset = "0x4B6F090", VA = "0x184B70090")]
	public bool FDNFEKDOMEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B72090", Offset = "0x4B71090", VA = "0x184B72090")]
	private static bool OKCMCLONCAG(byte NKNPGFCGIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B712E0", Offset = "0x4B702E0", VA = "0x184B712E0")]
	private void LGCCJCEAOJF(FDHIMNDNOFP KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4B702D0", Offset = "0x4B6F2D0", VA = "0x184B702D0")]
	public void FFCOHGHEJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B708A0", Offset = "0x4B6F8A0", VA = "0x184B708A0")]
	private void HMBBJPBBKEN(int FDHHJEIMKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4B711A0", Offset = "0x4B701A0", VA = "0x184B711A0")]
	public sbyte LAFKMEOBIMG()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F8C0", Offset = "0x4B6E8C0", VA = "0x184B6F8C0")]
	public short BMBFOFJNBJO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4B6FEF0", Offset = "0x4B6EEF0", VA = "0x184B6FEF0")]
	public int ECLOENBFOKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4B710A0", Offset = "0x4B700A0", VA = "0x184B710A0")]
	public long KEKOIEHBMDK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F920", Offset = "0x4B6E920", VA = "0x184B6F920")]
	public byte BMNPLFFBDHN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B71F80", Offset = "0x4B70F80", VA = "0x184B71F80")]
	public ushort MMJEBNKOFCI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4B71FE0", Offset = "0x4B70FE0", VA = "0x184B71FE0")]
	public uint NBPDHMKLDBI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F840", Offset = "0x4B6E840", VA = "0x184B6F840")]
	public ulong BLIHAKGCIJH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4B71D30", Offset = "0x4B70D30", VA = "0x184B71D30")]
	public float LPPGONDOCEI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4B70F60", Offset = "0x4B6FF60", VA = "0x184B70F60")]
	public double INAHBHNOCMF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4B6FBD0", Offset = "0x4B6EBD0", VA = "0x184B6FBD0")]
	public ArraySegment<byte> CPLHODALPBC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B70470", Offset = "0x4B6F470", VA = "0x184B70470")]
	private static int FPBJHOPIHCH(byte[] CCFMJPPGPDK, int PNKNABOKANH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KJJEPECLPAG : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference ECMPKIAJCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int JKBADKCAACF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int INEGPIPFIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x18367A0", Offset = "0x18357A0", VA = "0x1818367A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string BGBNGLFENPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x885170", Offset = "0x884170", VA = "0x180885170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C680", Offset = "0x4B7B680", VA = "0x184B7C680")]
	public KJJEPECLPAG(string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C6F0", Offset = "0x4B7B6F0", VA = "0x184B7C6F0")]
	public KJJEPECLPAG(string LMLMHJKGDCH, byte[] LDANIHEGLCF, int PNKNABOKANH, int JKBADKCAACF, string AHCBGDFHABF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MHFOACICCBC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BHIPANHOAAG
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void LGBPHLEPHIM(ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object AMNHHOAJLJB(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG OHIDBDNDNIA);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class KBKDLHAIKNE
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class HGDIEBMAKKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
				public HGDIEBMAKKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x37005C0", Offset = "0x36FF5C0", VA = "0x1837005C0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4E68990", Offset = "0x4E67990", VA = "0x184E68990")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, CDAHFIMKBKG, byte[]> NEJAPGLCMMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, CDAHFIMKBKG> ELEMBPDNCGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly LGBPHLEPHIM MMMPFPDMGLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, CDAHFIMKBKG, ArraySegment<byte>> NGIDIBMLDKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, CDAHFIMKBKG, string> CDIOGEAKMMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, CDAHFIMKBKG, object> GHEFBMJOAPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, CDAHFIMKBKG, object> IJNGKKLIHNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, CDAHFIMKBKG, object> KAJFIBKGNOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly AMNHHOAJLJB EKDJCJLKGEA;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4E6AC30", Offset = "0x4E69C30", VA = "0x184E6AC30")]
			public KBKDLHAIKNE(Type IGEIBCJNCHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x611CD30", Offset = "0x611BD30", VA = "0x18611CD30")]
			private static T DAOCMHMDJDH<T>(DynamicMethod GOHPCNPKGLO)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4E6A9E0", Offset = "0x4E699E0", VA = "0x184E6A9E0")]
			private static MethodInfo ELAAIPGLNHI(Type IGEIBCJNCHF, string IADPDEAGFAB, Type[] NGACEPLFOCA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, KBKDLHAIKNE> CIOHJEMPDBF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::KLLFKEKDHGC<KBKDLHAIKNE> MBBKEHPDGBE;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4E62F30", Offset = "0x4E61F30", VA = "0x184E62F30")]
		static BHIPANHOAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4E62BF0", Offset = "0x4E61BF0", VA = "0x184E62BF0")]
		private static KBKDLHAIKNE FEAMCPOBIKK(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4E62DA0", Offset = "0x4E61DA0", VA = "0x184E62DA0")]
		public static void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4E62C80", Offset = "0x4E61C80", VA = "0x184E62C80")]
		public static void PNKNJNLKBEB(Type IGEIBCJNCHF, ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class BMHCPBEKNFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] FAHBHODOFIG;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4E63230", Offset = "0x4E62230", VA = "0x184E63230")]
		public static byte[] KDIMAKIMIBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CDAHFIMKBKG JFLCCKMKHGG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] MMILAMMAGCG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] PIJBOOJMJOH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CDAHFIMKBKG ACCDOGDPLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EE10", Offset = "0x4E6DE10", VA = "0x184E6EE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool ANGKCDCBMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E6F720", Offset = "0x4E6E720", VA = "0x184E6F720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F780", Offset = "0x4E6E780", VA = "0x184E6F780")]
	public static void PFLNFLDGKGH(CDAHFIMKBKG OHIDBDNDNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x249C230", Offset = "0x249B230", VA = "0x18249C230")]
	public static byte[] PNKNJNLKBEB<T>(T GKCPJCKCENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x249C2B0", Offset = "0x249B2B0", VA = "0x18249C2B0")]
	public static byte[] PNKNJNLKBEB<T>(T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x249C4A0", Offset = "0x249B4A0", VA = "0x18249C4A0")]
	public static void PNKNJNLKBEB<T>(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x249C150", Offset = "0x249B150", VA = "0x18249C150")]
	public static void PNKNJNLKBEB<T>(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x249C410", Offset = "0x249B410", VA = "0x18249C410")]
	public static void PNKNJNLKBEB<T>(Stream KJHFBEBKBIB, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x249C530", Offset = "0x249B530", VA = "0x18249C530")]
	public static void PNKNJNLKBEB<T>(Stream KJHFBEBKBIB, T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x249BD50", Offset = "0x249AD50", VA = "0x18249BD50")]
	public static ArraySegment<byte> KIACAMHNNMN<T>(T GKCPJCKCENH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x249BDF0", Offset = "0x249ADF0", VA = "0x18249BDF0")]
	public static ArraySegment<byte> KIACAMHNNMN<T>(T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x249BF70", Offset = "0x249AF70", VA = "0x18249BF70")]
	public static string NNIDKDPOPLG<T>(T DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x249BFF0", Offset = "0x249AFF0", VA = "0x18249BFF0")]
	public static string NNIDKDPOPLG<T>(T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x249B380", Offset = "0x249A380", VA = "0x18249B380")]
	public static T CJKIJAOEIBM<T>(string CNJAPFNEOCK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x249B290", Offset = "0x249A290", VA = "0x18249B290")]
	public static T CJKIJAOEIBM<T>(string CNJAPFNEOCK, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x249BA50", Offset = "0x249AA50", VA = "0x18249BA50")]
	public static T CJKIJAOEIBM<T>(byte[] CCFMJPPGPDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x249B580", Offset = "0x249A580", VA = "0x18249B580")]
	public static T CJKIJAOEIBM<T>(byte[] CCFMJPPGPDK, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x249B6A0", Offset = "0x249A6A0", VA = "0x18249B6A0")]
	public static T CJKIJAOEIBM<T>(byte[] CCFMJPPGPDK, int PNKNABOKANH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x249B420", Offset = "0x249A420", VA = "0x18249B420")]
	public static T CJKIJAOEIBM<T>(byte[] CCFMJPPGPDK, int PNKNABOKANH, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x249B620", Offset = "0x249A620", VA = "0x18249B620")]
	public static T CJKIJAOEIBM<T>(ref HJNHIBNNFEE NINBMPMOGGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x249BC80", Offset = "0x249AC80", VA = "0x18249BC80")]
	public static T CJKIJAOEIBM<T>(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x249BC00", Offset = "0x249AC00", VA = "0x18249BC00")]
	public static T CJKIJAOEIBM<T>(Stream KJHFBEBKBIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x249BAD0", Offset = "0x249AAD0", VA = "0x18249BAD0")]
	public static T CJKIJAOEIBM<T>(Stream KJHFBEBKBIB, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F590", Offset = "0x4E6E590", VA = "0x184E6F590")]
	public static string LDLPNAEFLDJ(byte[] CNJAPFNEOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F670", Offset = "0x4E6E670", VA = "0x184E6F670")]
	public static string LDLPNAEFLDJ(byte[] CNJAPFNEOCK, int PNKNABOKANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F4C0", Offset = "0x4E6E4C0", VA = "0x184E6F4C0")]
	public static string LDLPNAEFLDJ(string CNJAPFNEOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EC60", Offset = "0x4E6DC60", VA = "0x184E6EC60")]
	public static byte[] BPGNPAMIIFP(byte[] CNJAPFNEOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EBB0", Offset = "0x4E6DBB0", VA = "0x184E6EBB0")]
	public static byte[] BPGNPAMIIFP(byte[] CNJAPFNEOCK, int PNKNABOKANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E6ED40", Offset = "0x4E6DD40", VA = "0x184E6ED40")]
	public static byte[] BPGNPAMIIFP(string CNJAPFNEOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EF30", Offset = "0x4E6DF30", VA = "0x184E6EF30")]
	private static void FMIEPBAIAIN(ref HJNHIBNNFEE NINBMPMOGGB, ref IPBPHIELIHL GAKCPFEFIJJ, int HFAPDGCFEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F420", Offset = "0x4E6E420", VA = "0x184E6F420")]
	private static int JNEENMBMEJP(Stream GIEOCCOFGEG, ref byte[] FAHBHODOFIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum FDHIMNDNOFP : byte
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
public struct IPBPHIELIHL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] DLHMHOHLBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int PNKNABOKANH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PLCJJHLICHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x77D5E0", Offset = "0x77C5E0", VA = "0x18077D5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4B72040", Offset = "0x4B71040", VA = "0x184B72040")]
	public void NCNNCIMJDEL(int PNKNABOKANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4B76E30", Offset = "0x4B75E30", VA = "0x184B76E30")]
	public static byte[] ACGFANIMLLF(string AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4B77C60", Offset = "0x4B76C60", VA = "0x184B77C60")]
	public static byte[] LCEEOJLNJKB(string AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4B771C0", Offset = "0x4B761C0", VA = "0x184B771C0")]
	public static byte[] ECGNOGMJIHL(string AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4B77770", Offset = "0x4B76770", VA = "0x184B77770")]
	public static byte[] HCGOJFHGJMA(string AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xBB3500", Offset = "0xBB2500", VA = "0x180BB3500")]
	public IPBPHIELIHL(byte[] IBGMACJPNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4B77BB0", Offset = "0x4B76BB0", VA = "0x184B77BB0")]
	public ArraySegment<byte> KDIMAKIMIBI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4B76F90", Offset = "0x4B75F90", VA = "0x184B76F90")]
	public byte[] CHBHKKPBAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4B78020", Offset = "0x4B77020", VA = "0x184B78020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4B76EB0", Offset = "0x4B75EB0", VA = "0x184B76EB0")]
	public void AGBJIBCDJKP(int PLINPOKNGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4B76870", Offset = "0x4B75870", VA = "0x184B76870")]
	public void DOLBMMDCGFI(byte GNOIOELLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4B77160", Offset = "0x4B76160", VA = "0x184B77160")]
	public void DOLBMMDCGFI(byte[] GNOIOELLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4B77E90", Offset = "0x4B76E90", VA = "0x184B77E90")]
	public void ONJKCDJCNGF(byte GNOIOELLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4B76F40", Offset = "0x4B75F40", VA = "0x184B76F40")]
	public void CBJNMMHHLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4B77B30", Offset = "0x4B76B30", VA = "0x184B77B30")]
	public void KAJAJCNAFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4B76EC0", Offset = "0x4B75EC0", VA = "0x184B76EC0")]
	public void BKHBHOFPCJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4B77FD0", Offset = "0x4B76FD0", VA = "0x184B77FD0")]
	public void PMDNJADPMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4B77AE0", Offset = "0x4B76AE0", VA = "0x184B77AE0")]
	public void JDDGMFKNGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4B77F00", Offset = "0x4B76F00", VA = "0x184B77F00")]
	public void PKOIFAILKPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4B77310", Offset = "0x4B76310", VA = "0x184B77310")]
	public void EONCOBMPLIP(string AOKAOIOMMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4B77110", Offset = "0x4B76110", VA = "0x184B77110")]
	public void CPHLBFGACFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4B77D90", Offset = "0x4B76D90", VA = "0x184B77D90")]
	public void NKCDOFJGNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B778F0", Offset = "0x4B768F0", VA = "0x184B778F0")]
	public void IDPDMDABECK(bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B77F50", Offset = "0x4B76F50", VA = "0x184B77F50")]
	public void PLPBNFMFHPL(float DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B77290", Offset = "0x4B76290", VA = "0x184B77290")]
	public void ECJPJCHIGNP(double DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4B77D30", Offset = "0x4B76D30", VA = "0x184B77D30")]
	public void LDMBDFDPJCA(byte DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4B77B80", Offset = "0x4B76B80", VA = "0x184B77B80")]
	public void KCMHLBEPECO(ushort DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4B778C0", Offset = "0x4B768C0", VA = "0x184B778C0")]
	public void HGPPNMAJPGM(uint DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4B76F10", Offset = "0x4B75F10", VA = "0x184B76F10")]
	public void CBADJNLAMOA(ulong DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4B77E60", Offset = "0x4B76E60", VA = "0x184B77E60")]
	public void OEGDIEIEEMF(sbyte DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4B77ED0", Offset = "0x4B76ED0", VA = "0x184B77ED0")]
	public void PKMOFIEFAEP(short DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4B77740", Offset = "0x4B76740", VA = "0x184B77740")]
	public void GBNNIMAMIPK(int DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4B77D60", Offset = "0x4B76D60", VA = "0x184B77D60")]
	public void MOGMCLNCFEO(long DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4B77370", Offset = "0x4B76370", VA = "0x184B77370")]
	public void FDPPJFKIGGP(string DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PEGMDEAMIDA : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class FEPBANIKLIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x23B20C0", Offset = "0x23B10C0", VA = "0x1823B20C0")]
		static FEPBANIKLIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private PEGMDEAMIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class ALKJMEFPFAH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> AEMIIPGJBJC;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B022F0", Offset = "0x4B012F0", VA = "0x184B022F0")]
	static ALKJMEFPFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4B01BE0", Offset = "0x4B00BE0", VA = "0x184B01BE0")]
	internal static object EIKOHJLJIFP(Type PHLICBNKKOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CHDKCBDKCLF : global::KBIOLGDHIDG<Vector2>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4B08970", Offset = "0x4B07970", VA = "0x184B08970")]
	public CHDKCBDKCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4B088C0", Offset = "0x4B078C0", VA = "0x184B088C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Vector2 DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4B086C0", Offset = "0x4B076C0", VA = "0x184B086C0", Slot = "5")]
	public Vector2 CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HDMAGDDGJPA : global::KBIOLGDHIDG<Vector3>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E590", Offset = "0x4B6D590", VA = "0x184B6E590")]
	public HDMAGDDGJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E2F0", Offset = "0x4B6D2F0", VA = "0x184B6E2F0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Vector3 DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4B6DFD0", Offset = "0x4B6CFD0", VA = "0x184B6DFD0", Slot = "5")]
	public Vector3 CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NDHMJLADLIA : global::KBIOLGDHIDG<Vector4>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4E70830", Offset = "0x4E6F830", VA = "0x184E70830")]
	public NDHMJLADLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E800", Offset = "0x4B0D800", VA = "0x184B0E800", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Vector4 DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E70610", Offset = "0x4E6F610", VA = "0x184E70610", Slot = "5")]
	public Vector4 CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MDJFDPFCFAK : global::KBIOLGDHIDG<Quaternion>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4B83230", Offset = "0x4B82230", VA = "0x184B83230")]
	public MDJFDPFCFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B82ED0", Offset = "0x4B81ED0", VA = "0x184B82ED0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Quaternion DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4B82B50", Offset = "0x4B81B50", VA = "0x184B82B50", Slot = "5")]
	public Quaternion CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class EFJCEBLMOPH : global::KBIOLGDHIDG<Color>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E950", Offset = "0x4B0D950", VA = "0x184B0E950")]
	public EFJCEBLMOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E800", Offset = "0x4B0D800", VA = "0x184B0E800", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Color DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E570", Offset = "0x4B0D570", VA = "0x184B0E570", Slot = "5")]
	public Color CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class CFJGHHIDFKB : global::KBIOLGDHIDG<Bounds>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B08480", Offset = "0x4B07480", VA = "0x184B08480")]
	public CFJGHHIDFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B082E0", Offset = "0x4B072E0", VA = "0x184B082E0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Bounds DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B07FB0", Offset = "0x4B06FB0", VA = "0x184B07FB0", Slot = "5")]
	public Bounds CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class KCHNFICOBGG : global::KBIOLGDHIDG<Rect>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B770", Offset = "0x4B7A770", VA = "0x184B7B770")]
	public KCHNFICOBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B3C0", Offset = "0x4B7A3C0", VA = "0x184B7B3C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Rect DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B010", Offset = "0x4B7A010", VA = "0x184B7B010", Slot = "5")]
	public Rect CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class BLDHJOCFMKI : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class KCGNNLCGFOC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2806190", Offset = "0x2805190", VA = "0x182806190")]
		static KCGNNLCGFOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private BLDHJOCFMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class HCDAEMPJJEB : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class DCGMAOPICJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x288B1A0", Offset = "0x288A1A0", VA = "0x18288B1A0")]
		static DCGMAOPICJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class GDAOEFFGPPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> JHIBEHPKCIO;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4E64B80", Offset = "0x4E63B80", VA = "0x184E64B80")]
		internal static object EIKOHJLJIFP(Type PHLICBNKKOO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private HCDAEMPJJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GGNGBILKMFO : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class MFOONCMNNPA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2F704B0", Offset = "0x2F6F4B0", VA = "0x182F704B0")]
		static MFOONCMNNPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GGNGBILKMFO JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool LBEEBEHJLLO;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static CDJJKNODMKB[] PIENADLFNJC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CDAHFIMKBKG[] JLABIGIAGBJ;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private GGNGBILKMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B6C250", Offset = "0x4B6B250", VA = "0x184B6C250")]
	public static void MNFGPLMIANE(params CDAHFIMKBKG[] JLABIGIAGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B6C330", Offset = "0x4B6B330", VA = "0x184B6C330")]
	public static void MNFGPLMIANE(params CDJJKNODMKB[] PIENADLFNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B6BFC0", Offset = "0x4B6AFC0", VA = "0x184B6BFC0")]
	public static void LJMIBIDPLGA(CDJJKNODMKB[] PIENADLFNJC, CDAHFIMKBKG[] JLABIGIAGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class ODLHOIMEGHG : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class PKIPCNEFLKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D90100", Offset = "0x2D8F100", VA = "0x182D90100")]
		static PKIPCNEFLKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private ODLHOIMEGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AGJMJOBEIKL
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly CDAHFIMKBKG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly CDAHFIMKBKG JHKEGNNFECH;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CDAHFIMKBKG BCKLHKHKBJP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly CDAHFIMKBKG IKNHFNAAPBN;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly CDAHFIMKBKG OAHKBKDIJOH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CDAHFIMKBKG OKJJEOFCIAP;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly CDAHFIMKBKG CFKANGOLLFE;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly CDAHFIMKBKG DIFHJDAIBNO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly CDAHFIMKBKG KNLFFEFDIJO;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly CDAHFIMKBKG ALABHLGHDIB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly CDAHFIMKBKG FLMGCLOLJEH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CDAHFIMKBKG DKKJHHJBMHP;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class ECOLPANJCNL
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly CDAHFIMKBKG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly CDAHFIMKBKG ODBEBMBOKMA;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NJBFENCIDEJ
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CDAHFIMKBKG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly CDAHFIMKBKG JHKEGNNFECH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly CDAHFIMKBKG BCKLHKHKBJP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CDAHFIMKBKG IKNHFNAAPBN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly CDAHFIMKBKG OAHKBKDIJOH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly CDAHFIMKBKG OKJJEOFCIAP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CDAHFIMKBKG CFKANGOLLFE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly CDAHFIMKBKG DIFHJDAIBNO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly CDAHFIMKBKG KNLFFEFDIJO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly CDAHFIMKBKG ALABHLGHDIB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly CDAHFIMKBKG FLMGCLOLJEH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CDAHFIMKBKG DKKJHHJBMHP;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class BGLLJGGAMHC
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> JHIBEHPKCIO;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4B02F10", Offset = "0x4B01F10", VA = "0x184B02F10")]
	internal static object EIKOHJLJIFP(Type PHLICBNKKOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4B02ED0", Offset = "0x4B01ED0", VA = "0x184B02ED0")]
	private static object BGPGCJBAIFG(Type ACPIPFHPMJO, Type[] IGMAMEINBIE, params object[] NGACEPLFOCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class CJPKFMLJIEE : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class LGJPJLKPHKF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2086040", Offset = "0x2085040", VA = "0x182086040")]
		static LGJPJLKPHKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B08BB0", Offset = "0x4B07BB0", VA = "0x184B08BB0")]
	static CJPKFMLJIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private CJPKFMLJIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class FJLBDHABGHJ : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class CGECFOAGJEP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FCC0", Offset = "0x3E9ECC0", VA = "0x183E9FCC0")]
		static CGECFOAGJEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B69D50", Offset = "0x4B68D50", VA = "0x184B69D50")]
	static FJLBDHABGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private FJLBDHABGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class FBPKBLEIIFO : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class JBLLGFFBHPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F260B0", Offset = "0x2F250B0", VA = "0x182F260B0")]
		static JBLLGFFBHPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B1A110", Offset = "0x4B19110", VA = "0x184B1A110")]
	static FBPKBLEIIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private FBPKBLEIIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class KNJPNBBDAEK : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class JAMOHAPOAMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2F22CD0", Offset = "0x2F21CD0", VA = "0x182F22CD0")]
		static JAMOHAPOAMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E5B0", Offset = "0x4B7D5B0", VA = "0x184B7E5B0")]
	static KNJPNBBDAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private KNJPNBBDAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class KHJPPMNELLF : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class PJLKGPDHBCG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C030", Offset = "0x2D8B030", VA = "0x182D8C030")]
		static PJLKGPDHBCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BF70", Offset = "0x4B7AF70", VA = "0x184B7BF70")]
	static KHJPPMNELLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private KHJPPMNELLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class MDJOHNFJFHG : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class MGBLGEIMBLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x24B6B70", Offset = "0x24B5B70", VA = "0x1824B6B70")]
		static MGBLGEIMBLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E9A0", Offset = "0x4E6D9A0", VA = "0x184E6E9A0")]
	static MDJOHNFJFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private MDJOHNFJFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class CECPGEIAPNF : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class NOMKHHGAIGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x46256E0", Offset = "0x46246E0", VA = "0x1846256E0")]
		static NOMKHHGAIGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CECPGEIAPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class GLODEEBEBII : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class ILFFANBJIBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1E26010", Offset = "0x1E25010", VA = "0x181E26010")]
		static ILFFANBJIBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GLODEEBEBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class BGCLDIGJJHB : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class MKKPAGGPMGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x24CA4B0", Offset = "0x24C94B0", VA = "0x1824CA4B0")]
		static MKKPAGGPMGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public BGCLDIGJJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class HHOMMOMADNJ : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class MOMAENBEGOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2C97140", Offset = "0x2C96140", VA = "0x182C97140")]
		static MOMAENBEGOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public HHOMMOMADNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class CMOIFPEHMBK : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class GHNIFJPMEMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x284DAA0", Offset = "0x284CAA0", VA = "0x18284DAA0")]
		static GHNIFJPMEMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CMOIFPEHMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class LEDLFMHEEGL : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class IEGFPBEKHOF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2250C40", Offset = "0x224FC40", VA = "0x182250C40")]
		static IEGFPBEKHOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LEDLFMHEEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class EFJDNHIOLDH
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct DGGCCEPMDKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CBFDBJMKKPC JOOFEAOMDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder DOGHAALBHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder PHGJGNCCNKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class GOMOHFMOGEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class KOBIIKJCLEI
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo ECGNOGMJIHL;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo LCEEOJLNJKB;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo HCGOJFHGJMA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo ACGFANIMLLF;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo NKCDOFJGNPN;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo DOLBMMDCGFI;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo BKHBHOFPCJF;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo PMDNJADPMLN;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo JDDGMFKNGNB;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x4E6CB80", Offset = "0x4E6BB80", VA = "0x184E6CB80")]
			static KOBIIKJCLEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class MCOANKHDEKO
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo DMPKDDCHJEK;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo BBBKDHEIDDK;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo HNDCLIHGIJK;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo AADBJEAGBMM;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo FFCOHGHEJCL;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo OCGCLACNCPH;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo JMGKDDIDBEG;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DDB0", Offset = "0x4E6CDB0", VA = "0x184E6DDB0")]
			static MCOANKHDEKO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class FOFAFHMBCFE
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo HEDCAMCHEDF;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo LKDNMFKNBEI;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo GIEBOFOEIAH;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo DPCKLAFOJEE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo FLBCJNPNFPH;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo HGOMKJGKBLP;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GPDDHMFHDGG;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo NOCFGHALDIF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo MPIKNOCDJFH;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo MPAHOFFIHCE;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo JJEFOBAJOJI;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo DBIGAILGJAI;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo DDBGBMCBFAG;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo NNGPBPJAHBB;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4E67060", Offset = "0x4E66060", VA = "0x184E67060")]
		public static MethodInfo PNKNJNLKBEB(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4E66CB0", Offset = "0x4E65CB0", VA = "0x184E66CB0")]
		public static MethodInfo CJKIJAOEIBM(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4E66F20", Offset = "0x4E65F20", VA = "0x184E66F20")]
		public static MethodInfo FBNJCJLNKHJ(Type IGEIBCJNCHF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FMOPIOLPFPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<CBFDBJMKKPC, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FMOPIOLPFPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KFAKIIKLPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FMOPIOLPFPK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public KFAKIIKLPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C930", Offset = "0x4E6B930", VA = "0x184E6C930")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C970", Offset = "0x4E6B970", VA = "0x184E6C970")]
		internal bool <BuildType>b__2(int index, CBFDBJMKKPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class MHHKLKADNDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FMOPIOLPFPK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MHHKLKADNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4E6F970", Offset = "0x4E6E970", VA = "0x184E6F970")]
		internal bool <BuildType>b__3(int index, CBFDBJMKKPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class PNDBIIMJNNA
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

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PNDBIIMJNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4E73AF0", Offset = "0x4E72AF0", VA = "0x184E73AF0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JDCKILEFKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JDCKILEFKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A7C0", Offset = "0x4E697C0", VA = "0x184E6A7C0")]
		internal bool <BuildAnonymousFormatter>b__2(CBFDBJMKKPC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class AMNKGLPIKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public PNDBIIMJNNA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public AMNKGLPIKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4E62A40", Offset = "0x4E61A40", VA = "0x184E62A40")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4E62A50", Offset = "0x4E61A50", VA = "0x184E62A50")]
		internal bool <BuildAnonymousFormatter>b__6(int index, CBFDBJMKKPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CPIFPAPGGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public PNDBIIMJNNA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CPIFPAPGGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4E632C0", Offset = "0x4E622C0", VA = "0x184E632C0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, CBFDBJMKKPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HGIGEBGKJMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public HGIGEBGKJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FD0", Offset = "0x6A7FD0", VA = "0x1806A8FD0")]
		internal Label <BuildSerialize>b__1(CBFDBJMKKPC _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class EPLOINHIGOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DGGCCEPMDKG[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, CBFDBJMKKPC, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public PJJOBJKEALJ argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PJJOBJKEALJ argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EPLOINHIGOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4E63EF0", Offset = "0x4E62EF0", VA = "0x184E63EF0")]
		internal DGGCCEPMDKG <BuildDeserialize>b__0(CBFDBJMKKPC item)
		{
			return default(DGGCCEPMDKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class HNEDLNLDLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EPLOINHIGOD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public HNEDLNLDLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4E68D50", Offset = "0x4E67D50", VA = "0x184E68D50")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4E69000", Offset = "0x4E68000", VA = "0x184E69000")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class JFGNABILADP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CBFDBJMKKPC item;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JFGNABILADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xF851B0", Offset = "0xF841B0", VA = "0x180F851B0")]
		internal bool <EmitNewObject>b__0(DGGCCEPMDKG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class JPEGOAALFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CBFDBJMKKPC item;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JPEGOAALFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xF851B0", Offset = "0xF841B0", VA = "0x180F851B0")]
		internal bool <EmitNewObject>b__2(DGGCCEPMDKG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex MFDKAAMIIMA;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int EONJGOCKLGC;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> LHEBNCEKONA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> GGPHIDOFABB;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3947E60", Offset = "0x3946E60", VA = "0x183947E60")]
	public static object IJPOKECMDKG<T>(PIHKFLFDJIM DICGHOMBDEC, CDAHFIMKBKG IILLNBABLOM, Func<string, string> OIIGLIFPNHJ, bool AGBBGFGAMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x25BF750", Offset = "0x25BE750", VA = "0x1825BF750")]
	public static object DPLNNNNKBBM<T>(CDAHFIMKBKG IILLNBABLOM, Func<string, string> OIIGLIFPNHJ, bool AGBBGFGAMEG, bool HJBKCEHLOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4B0F570", Offset = "0x4B0E570", VA = "0x184B0F570")]
	private static TypeInfo FLFEKAMFFLD(PIHKFLFDJIM DICGHOMBDEC, Type IGEIBCJNCHF, Func<string, string> OIIGLIFPNHJ, bool AGBBGFGAMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4B10C50", Offset = "0x4B0FC50", VA = "0x184B10C50")]
	public static object GKJCAGGOCLM(Type IGEIBCJNCHF, Func<string, string> OIIGLIFPNHJ, bool AGBBGFGAMEG, bool HJBKCEHLOIL, bool ANDBLJMMEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4B14C40", Offset = "0x4B13C40", VA = "0x184B14C40")]
	private static Dictionary<CBFDBJMKKPC, FieldInfo> LNMMELHJCEK(TypeBuilder CAPKONDANCB, LIAFLHMCAMO FEPBBMGBAMP, ConstructorInfo JONBJLGFOKN, FieldBuilder OMIOLIFDAGC, ILGenerator GMOLGNOIGAN, bool AGBBGFGAMEG, bool PNBDNLNLJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4B10000", Offset = "0x4B0F000", VA = "0x184B10000")]
	private static Dictionary<CBFDBJMKKPC, FieldInfo> GILCJJHNGMA(TypeBuilder CAPKONDANCB, LIAFLHMCAMO FEPBBMGBAMP, ILGenerator GMOLGNOIGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4B16500", Offset = "0x4B15500", VA = "0x184B16500")]
	private static void NGGDNOAHCJD(Type IGEIBCJNCHF, LIAFLHMCAMO FEPBBMGBAMP, ILGenerator GMOLGNOIGAN, Action FAKADEDHFNJ, Func<int, CBFDBJMKKPC, bool> ALNECDIBMGI, bool AGBBGFGAMEG, bool PNBDNLNLJJM, int CIPCKOFIFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4B14220", Offset = "0x4B13220", VA = "0x184B14220")]
	private static void IOPGECPBKMA(TypeInfo IGEIBCJNCHF, CBFDBJMKKPC LBEKFHGAHGE, ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK, Func<int, CBFDBJMKKPC, bool> ALNECDIBMGI, PJJOBJKEALJ GAKCPFEFIJJ, PJJOBJKEALJ KJEDNAOJNLJ, PJJOBJKEALJ NEGCAAGBPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4B127D0", Offset = "0x4B117D0", VA = "0x184B127D0")]
	private static void GNBLKMBBIJF(Type IGEIBCJNCHF, LIAFLHMCAMO FEPBBMGBAMP, ILGenerator GMOLGNOIGAN, Func<int, CBFDBJMKKPC, bool> ALNECDIBMGI, bool CKMKBFKEKIL, int CIPCKOFIFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4B14770", Offset = "0x4B13770", VA = "0x184B14770")]
	private static void JEAIIHBBHKJ(ILGenerator GMOLGNOIGAN, DGGCCEPMDKG FEPBBMGBAMP, int NPDGHPHAKDK, Func<int, CBFDBJMKKPC, bool> ALNECDIBMGI, PJJOBJKEALJ NINBMPMOGGB, PJJOBJKEALJ NEGCAAGBPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4B15590", Offset = "0x4B14590", VA = "0x184B15590")]
	private static LocalBuilder MACLACDLIJE(ILGenerator GMOLGNOIGAN, Type IGEIBCJNCHF, LIAFLHMCAMO FEPBBMGBAMP, DGGCCEPMDKG[] CGIFNFBKLIF, bool FMKHDCDJHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4B0EE70", Offset = "0x4B0DE70", VA = "0x184B0EE70")]
	private static bool EPJFGLIMFCI(ConstructorInfo FHLIEOMAOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4B0ECC0", Offset = "0x4B0DCC0", VA = "0x184B0ECC0")]
	private static bool EDKKCHJBMKH(Type IGEIBCJNCHF, out Type FKBLILCIFMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void GIDIOLFHIME<T>(byte[][] OMIOLIFDAGC, object[] CHFGFHNKBDM, ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T PLNPNMGJDNN<T>(object[] CHFGFHNKBDM, ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG OHIDBDNDNIA);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class ACPMJLPHJPI<T> : global::KBIOLGDHIDG<T>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] OMIOLIFDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] LLBMAHJCIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] MPLALGKPMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::GIDIOLFHIME<T> GFCAPLHGOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::PLNPNMGJDNN<T> CODKEDJGDDE;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x29509E0", Offset = "0x294F9E0", VA = "0x1829509E0")]
	public ACPMJLPHJPI(byte[][] OMIOLIFDAGC, object[] LLBMAHJCIKM, object[] MPLALGKPMJL, global::GIDIOLFHIME<T> GFCAPLHGOPK, global::PLNPNMGJDNN<T> CODKEDJGDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2950900", Offset = "0x294F900", VA = "0x182950900", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2950830", Offset = "0x294F830", VA = "0x182950830", Slot = "5")]
	public T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class KFFBKOPBLEG : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class EKAAGPLAEAD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2010A00", Offset = "0x200FA00", VA = "0x182010A00")]
		static EKAAGPLAEAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private KFFBKOPBLEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class KLLNGKPOECJ : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class JEJIMJOIPDK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3247320", Offset = "0x3246320", VA = "0x183247320")]
		static JEJIMJOIPDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private KLLNGKPOECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class HBAHMBDALEH
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly CDAHFIMKBKG[] ANDNFDGCKFC;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class GNEBIFLNHFD : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class COPAFAFMCAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x36EB6C0", Offset = "0x36EA6C0", VA = "0x1836EB6C0")]
		static COPAFAFMCAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class LJGNDLMNFDN : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class PFMAFLOAAKP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x346F9D0", Offset = "0x346E9D0", VA = "0x18346F9D0")]
			static PFMAFLOAAKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private LJGNDLMNFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private GNEBIFLNHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class ODBFHJMKEBH : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class OPMKCMACNHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x47BC230", Offset = "0x47BB230", VA = "0x1847BC230")]
		static OPMKCMACNHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class MKCIHGFPPBG : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class ALJPBLHIALB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x2F8DC10", Offset = "0x2F8CC10", VA = "0x182F8DC10")]
			static ALJPBLHIALB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private MKCIHGFPPBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private ODBFHJMKEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class PPENPNGBGBD : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class DEOFKMOKBPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x288EC90", Offset = "0x288DC90", VA = "0x18288EC90")]
		static DEOFKMOKBPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class GDOLMALLAHA : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class OLFCIJBBPLI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x25FE100", Offset = "0x25FD100", VA = "0x1825FE100")]
			static OLFCIJBBPLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private GDOLMALLAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private PPENPNGBGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class LDDDILGNKMF : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class FIGKMCBBOFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x304F520", Offset = "0x304E520", VA = "0x18304F520")]
		static FIGKMCBBOFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class IHOIEDEKMCD : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class CKHCMANDEHJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x36D2C50", Offset = "0x36D1C50", VA = "0x1836D2C50")]
			static CKHCMANDEHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private IHOIEDEKMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private LDDDILGNKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class JLHNAEDKOJL : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class MODJBPEPNDF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2C91110", Offset = "0x2C90110", VA = "0x182C91110")]
		static MODJBPEPNDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class PLBGDGHKHIA : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class MCDCBGBBJKL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x2F62B80", Offset = "0x2F61B80", VA = "0x182F62B80")]
			static MCDCBGBBJKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private PLBGDGHKHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private JLHNAEDKOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class BHKGDDMEEAL : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class FJJCMEGDCGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x30564C0", Offset = "0x30554C0", VA = "0x1830564C0")]
		static FJJCMEGDCGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class JMMKCJHEIEK : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class KMDJJLDGLPK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2D58DC0", Offset = "0x2D57DC0", VA = "0x182D58DC0")]
			static KMDJJLDGLPK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private JMMKCJHEIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private BHKGDDMEEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class DGHHNPLNPDO : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class NAKGEBHCAAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x23908B0", Offset = "0x238F8B0", VA = "0x1823908B0")]
		static NAKGEBHCAAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class HJBJEPNMCON : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class OJOAKPANKCI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x25F23B0", Offset = "0x25F13B0", VA = "0x1825F23B0")]
			static OJOAKPANKCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private HJBJEPNMCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private DGHHNPLNPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class FJDHAHKOENG : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class IFLJHHJHEKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x39A53D0", Offset = "0x39A43D0", VA = "0x1839A53D0")]
		static IFLJHHJHEKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class PMJDKPDGLEL : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class OOOBNFNGLIC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2603FA0", Offset = "0x2602FA0", VA = "0x182603FA0")]
			static OOOBNFNGLIC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private PMJDKPDGLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private FJDHAHKOENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class HCCKNHLJDIN : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class EPLDELMLBLG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2019780", Offset = "0x2018780", VA = "0x182019780")]
		static EPLDELMLBLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class BMALJEEGFBG : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class MFMLLAAOKGK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2F6AF80", Offset = "0x2F69F80", VA = "0x182F6AF80")]
			static MFMLLAAOKGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private BMALJEEGFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private HCCKNHLJDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class BFBFLAJFEOC : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class FOBCMGHKIFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2E0DA90", Offset = "0x2E0CA90", VA = "0x182E0DA90")]
		static FOBCMGHKIFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class FCBFKIMJJMA : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class IBHLMNCHNGD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x45241B0", Offset = "0x45231B0", VA = "0x1845241B0")]
			static IBHLMNCHNGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private FCBFKIMJJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private BFBFLAJFEOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class GDJFJAGPDED : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class AIJHJCKGKLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2965AB0", Offset = "0x2964AB0", VA = "0x182965AB0")]
		static AIJHJCKGKLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class OFBABBOEIJP : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class ODCNABPPEGP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x26FFA60", Offset = "0x26FEA60", VA = "0x1826FFA60")]
			static ODCNABPPEGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private OFBABBOEIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private GDJFJAGPDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class GOCHKKMAAJM : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class KCHIKLKJJFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x280E050", Offset = "0x280D050", VA = "0x18280E050")]
		static KCHIKLKJJFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class ELGMOAKMBDE : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class JJLECOOIHBO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x364FD60", Offset = "0x364ED60", VA = "0x18364FD60")]
			static JJLECOOIHBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		private ELGMOAKMBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	private GOCHKKMAAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2257450", Offset = "0x2256450", VA = "0x182257450", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct GJFGIFNNEBL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] CNDDJJHKADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int FGDMPDNAJLP;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x28564D0", Offset = "0x28554D0", VA = "0x1828564D0")]
	public GJFGIFNNEBL(int KDNFGAPAIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2856160", Offset = "0x2855160", VA = "0x182856160")]
	public void HMNAIPBHJIK(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2856000", Offset = "0x2855000", VA = "0x182856000")]
	public T[] CCDPKGMDNKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class LJKNBFDOLJK : global::AJCIIEGBJNM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly LJKNBFDOLJK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B808E0", Offset = "0x4B7F8E0", VA = "0x184B808E0")]
	public LJKNBFDOLJK(int DBLELDNIPAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class AJCIIEGBJNM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int DBLELDNIPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object DHIAMAJOONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int NPDGHPHAKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] OJCECCMMNMI;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x296BA20", Offset = "0x296AA20", VA = "0x18296BA20")]
	public AJCIIEGBJNM(int DBLELDNIPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x296B470", Offset = "0x296A470", VA = "0x18296B470")]
	public T[] LLOOOOJPPGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x296AB40", Offset = "0x2969B40", VA = "0x18296AB40")]
	public void JKLJAMMNEFN(T[] DBOPJMNFJMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class CMMEILIOKNM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class IHGODOLCLPH : IComparable<IHGODOLCLPH>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class KHKLBGOACFO : IEnumerable<IHGODOLCLPH>, IEnumerable, IEnumerator<IHGODOLCLPH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private IHGODOLCLPH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public IHGODOLCLPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private IHGODOLCLPH System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
			[DebuggerHidden]
			public KHKLBGOACFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x4E6CA10", Offset = "0x4E6BA10", VA = "0x184E6CA10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4E6CB40", Offset = "0x4E6BB40", VA = "0x184E6CB40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x4E6CAA0", Offset = "0x4E6BAA0", VA = "0x184E6CAA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IHGODOLCLPH> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x4E6CAA0", Offset = "0x4E6BAA0", VA = "0x184E6CAA0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class GHHIMKFDFIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public GHHIMKFDFIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x6A8FD0", Offset = "0x6A7FD0", VA = "0x1806A8FD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x6A8FD0", Offset = "0x6A7FD0", VA = "0x1806A8FD0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly IHGODOLCLPH[] LPNNJLEHNKA;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] KNDOBIAOGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int FBCEGMCNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string MGOAODFOCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IHGODOLCLPH[] OAEMGMMPBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] EKAICALIKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int MIOCJKOOLBL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool FMCJMLDEIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xC36F70", Offset = "0xC35F70", VA = "0x180C36F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A540", Offset = "0x4E69540", VA = "0x184E6A540")]
		public IHGODOLCLPH(ulong PIIJMEAKDGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4E69FE0", Offset = "0x4E68FE0", VA = "0x184E69FE0")]
		public IHGODOLCLPH HMNAIPBHJIK(ulong PIIJMEAKDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A2A0", Offset = "0x4E692A0", VA = "0x184E6A2A0")]
		public IHGODOLCLPH HMNAIPBHJIK(ulong PIIJMEAKDGO, int DFEOJBAFBHE, string MGOAODFOCMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4E69DC0", Offset = "0x4E68DC0", VA = "0x184E69DC0")]
		public IHGODOLCLPH GMIKDGHMNKA(byte[] ONINKGDNEEG, ref int PNKNABOKANH, ref int CMJGLNDNCNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A2F0", Offset = "0x4E692F0", VA = "0x184E6A2F0")]
		internal static int KCLJJJFFICB(ulong[] DBOPJMNFJMA, int NPDGHPHAKDK, int MFAHIHFAKKH, ulong DFEOJBAFBHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4E690A0", Offset = "0x4E680A0", VA = "0x184E690A0", Slot = "4")]
		public int CompareTo(IHGODOLCLPH KICLNADFIEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4E69F70", Offset = "0x4E68F70", VA = "0x184E69F70")]
		[IteratorStateMachine(typeof(KHKLBGOACFO))]
		public IEnumerable<IHGODOLCLPH> GNFHEEJAEGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A370", Offset = "0x4E69370", VA = "0x184E6A370")]
		public void KDEABOMAKCB(ILGenerator GMOLGNOIGAN, LocalBuilder ONINKGDNEEG, LocalBuilder CMJGLNDNCNL, LocalBuilder PIIJMEAKDGO, Action<KeyValuePair<string, int>> JPJILGHCBKO, Action GEPHKHMEKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4E690D0", Offset = "0x4E680D0", VA = "0x184E690D0")]
		private static void DCPLLKKNDDE(ILGenerator GMOLGNOIGAN, LocalBuilder ONINKGDNEEG, LocalBuilder CMJGLNDNCNL, LocalBuilder PIIJMEAKDGO, Action<KeyValuePair<string, int>> JPJILGHCBKO, Action GEPHKHMEKID, IHGODOLCLPH[] OAEMGMMPBNA, int MIOCJKOOLBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class EJDADOFHLCO : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<IHGODOLCLPH> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<IHGODOLCLPH> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<IHGODOLCLPH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private IHGODOLCLPH <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x4E639A0", Offset = "0x4E629A0", VA = "0x184E639A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1FA61C0", Offset = "0x1FA51C0", VA = "0x181FA61C0")]
		[DebuggerHidden]
		public EJDADOFHLCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4E639F0", Offset = "0x4E629F0", VA = "0x184E639F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4E63460", Offset = "0x4E62460", VA = "0x184E63460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4E63AD0", Offset = "0x4E62AD0", VA = "0x184E63AD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4E63B20", Offset = "0x4E62B20", VA = "0x184E63B20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x4E63960", Offset = "0x4E62960", VA = "0x184E63960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4E638C0", Offset = "0x4E628C0", VA = "0x184E638C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4E638C0", Offset = "0x4E628C0", VA = "0x184E638C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly IHGODOLCLPH JMLKLPJONJN;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C8D0", Offset = "0x4B0B8D0", VA = "0x184B0C8D0")]
	public CMMEILIOKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C3E0", Offset = "0x4B0B3E0", VA = "0x184B0C3E0")]
	public void HMNAIPBHJIK(byte[] CCFMJPPGPDK, int DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C270", Offset = "0x4B0B270", VA = "0x184B0C270")]
	public bool BGHOFGEILHM(ArraySegment<byte> PIIJMEAKDGO, out int DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C840", Offset = "0x4B0B840", VA = "0x184B0C840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C500", Offset = "0x4B0B500", VA = "0x184B0C500")]
	private static void JKCDCNPMDPD(IEnumerable<IHGODOLCLPH> OAEMGMMPBNA, StringBuilder FMGHJPGOLOC, int HFAPDGCFEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C330", Offset = "0x4B0B330", VA = "0x184B0C330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C330", Offset = "0x4B0B330", VA = "0x184B0C330", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C7D0", Offset = "0x4B0B7D0", VA = "0x184B0C7D0")]
	[IteratorStateMachine(typeof(EJDADOFHLCO))]
	private static IEnumerable<KeyValuePair<string, int>> PKOEPJJOFPL(IEnumerable<IHGODOLCLPH> OAEMGMMPBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C7A0", Offset = "0x4B0B7A0", VA = "0x184B0C7A0")]
	public void LAKJFDLOJDN(ILGenerator GMOLGNOIGAN, LocalBuilder ONINKGDNEEG, LocalBuilder CMJGLNDNCNL, LocalBuilder PIIJMEAKDGO, Action<KeyValuePair<string, int>> JPJILGHCBKO, Action GEPHKHMEKID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class HLJPGHGJHHM
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo FPINLFOFPGF;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4B72930", Offset = "0x4B71930", VA = "0x184B72930")]
	public static ulong KBKJCHLIDOC(byte[] CCFMJPPGPDK, ref int PNKNABOKANH, ref int CMJGLNDNCNL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class JONHBIDNLNI
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7ACA0", Offset = "0x4B79CA0", VA = "0x184B7ACA0")]
	public static void AGBJIBCDJKP(ref byte[] CCFMJPPGPDK, int PNKNABOKANH, int PLINPOKNGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AF00", Offset = "0x4B79F00", VA = "0x184B7AF00")]
	public static void OKOKMCKMGCK(ref byte[] DBOPJMNFJMA, int AODBOJHBLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7ADE0", Offset = "0x4B79DE0", VA = "0x184B7ADE0")]
	public static byte[] HHIPDOBHHEA(byte[] PPLEFHADAKM, int AODBOJHBLIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class KMLAGGFFAMP
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E520", Offset = "0x4B7D520", VA = "0x184B7E520")]
	public static bool NOHLHLNDIHM(byte[] OBEOMBGDJFP, int IPNAKKGEBOA, int FGHAGODBCCI, byte[] CKLCCOABNHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class BMGANMGKAHN<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct GJFAGGGEGGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T FBCEGMCNEND;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2851270", Offset = "0x2850270", VA = "0x182851270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NEBBINDBHLP : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::BMGANMGKAHN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GJFAGGGEGGG[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private GJFAGGGEGGG[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x323A900", Offset = "0x3239900", VA = "0x18323A900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C420", Offset = "0x1E2B420", VA = "0x181E2C420")]
		[DebuggerHidden]
		public NEBBINDBHLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x323A480", Offset = "0x3239480", VA = "0x18323A480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x323A830", Offset = "0x3239830", VA = "0x18323A830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GJFAGGGEGGG[][] MINCIBHBDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong PEJKBIJBOOK;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x240B6C0", Offset = "0x240A6C0", VA = "0x18240B6C0")]
	public BMGANMGKAHN(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x240B600", Offset = "0x240A600", VA = "0x18240B600")]
	public BMGANMGKAHN(int CIMAPKKBLKM, float AIAJNIBFPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x41DB7D0", Offset = "0x41DA7D0", VA = "0x1841DB7D0")]
	public void HMNAIPBHJIK(byte[] PIIJMEAKDGO, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x41DD230", Offset = "0x41DC230", VA = "0x1841DD230")]
	private bool OAKJNCACAHH(byte[] PIIJMEAKDGO, T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x41D6FC0", Offset = "0x41D5FC0", VA = "0x1841D6FC0")]
	public bool HADOILGNPLN(ArraySegment<byte> PIIJMEAKDGO, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x240AEB0", Offset = "0x2409EB0", VA = "0x18240AEB0")]
	private static ulong CKBNHOHNGGM(byte[] JMDPDGBMGAA, int PNKNABOKANH, int MIOCJKOOLBL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x240AF10", Offset = "0x2409F10", VA = "0x18240AF10")]
	private static int FHAJNIKHOMP(int DIICGEKFLNM, float AIAJNIBFPHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x41D6A70", Offset = "0x41D5A70", VA = "0x1841D6A70", Slot = "4")]
	[IteratorStateMachine(typeof(global::BMGANMGKAHN<>.NEBBINDBHLP))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x23AF600", Offset = "0x23AE600", VA = "0x1823AF600", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class FOLFFOLONFM : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] JGAIELANPLI;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] MMKKHLEKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int NLLEBPMJKKL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HAFGDHNCMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A210", Offset = "0x4B69210", VA = "0x184B6A210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4B6A260", Offset = "0x4B69260", VA = "0x184B6A260")]
	static FOLFFOLONFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4B6A4E0", Offset = "0x4B694E0", VA = "0x184B6A4E0")]
	public FOLFFOLONFM(byte[] FCMKMKJKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4B6A0F0", Offset = "0x4B690F0", VA = "0x184B6A0F0")]
	public OpCode COOKDKDCEGO()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct PNNMAEBOONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid FBCEGMCNEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte EBDMPKONBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte FPPNMDBBAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte NBONHCOJKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte LOBAGBFJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte ECHJDNDEOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte BAILJHKEKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte KIPJAIDEFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte HNLNKNMFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte PHILEKNLDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte AFGGAPPOJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte FCNBNDCBLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte BMPPKAFLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte GNDFOHEKAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte JEKDLEADDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte HHFILOAEGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte AJHBLINCLCL;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] GKNIOHIKKEH;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] HAPOEMBPMPD;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4E76590", Offset = "0x4E75590", VA = "0x184E76590")]
	public PNNMAEBOONA(ref Guid DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4E75140", Offset = "0x4E74140", VA = "0x184E75140")]
	public PNNMAEBOONA(ref ArraySegment<byte> DHPOKLJGCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4E73B50", Offset = "0x4E72B50", VA = "0x184E73B50")]
	private static byte ANPDMILEAAN(byte[] CCFMJPPGPDK, int EOOBEEOOCPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4E74F60", Offset = "0x4E73F60", VA = "0x184E74F60")]
	private static byte FBHALDBJLMA(byte OPGAGDBKIDA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4E73C10", Offset = "0x4E72C10", VA = "0x184E73C10")]
	public void AOMBALNDCDK(byte[] FAHBHODOFIG, int PNKNABOKANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class KKLLMHLNJII
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D610", Offset = "0x4B7C610", VA = "0x184B7D610")]
	public static bool KFBKCOLFCKC(byte NKNPGFCGIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D690", Offset = "0x4B7C690", VA = "0x184B7D690")]
	public static bool LOBLHDAKKHD(byte NKNPGFCGIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D620", Offset = "0x4B7C620", VA = "0x184B7D620")]
	public static sbyte LAFKMEOBIMG(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C8E0", Offset = "0x4B7B8E0", VA = "0x184B7C8E0")]
	public static short BMBFOFJNBJO(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D190", Offset = "0x4B7C190", VA = "0x184B7D190")]
	public static int ECLOENBFOKD(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D560", Offset = "0x4B7C560", VA = "0x184B7D560")]
	public static long KEKOIEHBMDK(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C950", Offset = "0x4B7B950", VA = "0x184B7C950")]
	public static byte BMNPLFFBDHN(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D770", Offset = "0x4B7C770", VA = "0x184B7D770")]
	public static ushort MMJEBNKOFCI(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E410", Offset = "0x4B7D410", VA = "0x184B7E410")]
	public static uint NBPDHMKLDBI(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C7D0", Offset = "0x4B7B7D0", VA = "0x184B7C7D0")]
	public static ulong BLIHAKGCIJH(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D700", Offset = "0x4B7C700", VA = "0x184B7D700")]
	public static float LPPGONDOCEI(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D470", Offset = "0x4B7C470", VA = "0x184B7D470")]
	public static double INAHBHNOCMF(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C9C0", Offset = "0x4B7B9C0", VA = "0x184B7C9C0")]
	public static int CBADJNLAMOA(ref byte[] FAHBHODOFIG, int PNKNABOKANH, ulong DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D7E0", Offset = "0x4B7C7E0", VA = "0x184B7D7E0")]
	public static int MOGMCLNCFEO(ref byte[] FAHBHODOFIG, int PNKNABOKANH, long DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D200", Offset = "0x4B7C200", VA = "0x184B7D200")]
	public static bool FDNFEKDOMEM(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class HAEFKEOONCG
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class GBGDAPLFLEB : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public GBGDAPLFLEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4E649F0", Offset = "0x4E639F0", VA = "0x184E649F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4E64590", Offset = "0x4E63590", VA = "0x184E64590", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4E64AE0", Offset = "0x4E63AE0", VA = "0x184E64AE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4E64B30", Offset = "0x4E63B30", VA = "0x184E64B30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4E649B0", Offset = "0x4E639B0", VA = "0x184E649B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4E64900", Offset = "0x4E63900", VA = "0x184E64900", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x4E64900", Offset = "0x4E63900", VA = "0x184E64900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class OEEMAPLNAPG : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public OEEMAPLNAPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4E72130", Offset = "0x4E71130", VA = "0x184E72130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x4E71CD0", Offset = "0x4E70CD0", VA = "0x184E71CD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4E72220", Offset = "0x4E71220", VA = "0x184E72220")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4E72270", Offset = "0x4E71270", VA = "0x184E72270")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4E720F0", Offset = "0x4E710F0", VA = "0x184E720F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4E72040", Offset = "0x4E71040", VA = "0x184E72040", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4E72040", Offset = "0x4E71040", VA = "0x184E72040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D9F0", Offset = "0x4B6C9F0", VA = "0x184B6D9F0")]
	public static bool PLDJOPFIMLL(this TypeInfo IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D610", Offset = "0x4B6C610", VA = "0x184B6D610")]
	public static bool DPNNMOPPIEF(this TypeInfo IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D890", Offset = "0x4B6C890", VA = "0x184B6D890")]
	public static IEnumerable<PropertyInfo> NGOHJEPMOND(this Type IGEIBCJNCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D800", Offset = "0x4B6C800", VA = "0x184B6D800")]
	[IteratorStateMachine(typeof(GBGDAPLFLEB))]
	private static IEnumerable<PropertyInfo> LEEJKPABABN(Type IGEIBCJNCHF, HashSet<string> ANGADFNDOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D730", Offset = "0x4B6C730", VA = "0x184B6D730")]
	public static IEnumerable<FieldInfo> JOFGLNPDLDN(this Type IGEIBCJNCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D960", Offset = "0x4B6C960", VA = "0x184B6D960")]
	[IteratorStateMachine(typeof(OEEMAPLNAPG))]
	private static IEnumerable<FieldInfo> OANFLKMDLIG(Type IGEIBCJNCHF, HashSet<string> ANGADFNDOON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class EFPPKBBLEJO
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding GBCOGIOICMC;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class JGCLDCOFAMM
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x77B500", Offset = "0x77A500", VA = "0x18077B500")]
	public static string BHJJFJECEKN(string EEDIAOMNBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4B78820", Offset = "0x4B77820", VA = "0x184B78820")]
	public static string NAJBNLDKMOP(string EEDIAOMNBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4B78630", Offset = "0x4B77630", VA = "0x184B78630")]
	public static string LKABFLDJDEN(string EEDIAOMNBHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class KLLFKEKDHGC<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class BNHBKLACBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue FBCEGMCNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int EOAMFFNMMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public BNHBKLACBEC DEAMFGIIJDN;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x240B820", Offset = "0x240A820", VA = "0x18240B820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x240B7A0", Offset = "0x240A7A0", VA = "0x18240B7A0")]
		private int BCBDBMHFMFJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public BNHBKLACBEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class OGHBFBMCBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public OGHBFBMCBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xC39000", Offset = "0xC38000", VA = "0x180C39000")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private BNHBKLACBEC[] MINCIBHBDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int BDHBBDMMOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object HKIJJDEGPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float AIAJNIBFPHN;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2D56F30", Offset = "0x2D55F30", VA = "0x182D56F30")]
	public KLLFKEKDHGC(int CIMAPKKBLKM = 4, float AIAJNIBFPHN = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2D56C20", Offset = "0x2D55C20", VA = "0x182D56C20")]
	public bool PICFJGOPDMI(Type PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2D56BE0", Offset = "0x2D55BE0", VA = "0x182D56BE0")]
	public bool PICFJGOPDMI(Type PIIJMEAKDGO, Func<Type, TValue> MIJKOGKPCJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2D565D0", Offset = "0x2D555D0", VA = "0x182D565D0")]
	private bool OAKJNCACAHH(Type PIIJMEAKDGO, Func<Type, TValue> MIJKOGKPCJC, out TValue OPFPPHNBBOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2D55BD0", Offset = "0x2D54BD0", VA = "0x182D55BD0")]
	private bool FFONNINPLNB(BNHBKLACBEC[] MINCIBHBDDD, Type LCCAAEMJGBP, BNHBKLACBEC IKLFFKAOEKH, Func<Type, TValue> MIJKOGKPCJC, out TValue OPFPPHNBBOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2D56480", Offset = "0x2D55480", VA = "0x182D56480")]
	public bool HADOILGNPLN(Type PIIJMEAKDGO, out TValue DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2D55B20", Offset = "0x2D54B20", VA = "0x182D55B20")]
	public TValue FEAMCPOBIKK(Type PIIJMEAKDGO, Func<Type, TValue> MIJKOGKPCJC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x240AF10", Offset = "0x2409F10", VA = "0x18240AF10")]
	private static int FHAJNIKHOMP(int DIICGEKFLNM, float AIAJNIBFPHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2D56B70", Offset = "0x2D55B70", VA = "0x182D56B70")]
	private static void OIBBDLAEFLD(ref BNHBKLACBEC PJOJLPDBEPN, BNHBKLACBEC DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2D56B70", Offset = "0x2D55B70", VA = "0x182D56B70")]
	private static void OIBBDLAEFLD(ref BNHBKLACBEC[] PJOJLPDBEPN, BNHBKLACBEC[] DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class PIHKFLFDJIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder IDFCHCAGDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder IOLFHHHGMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object DHIAMAJOONL;

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x4E734A0", Offset = "0x4E724A0", VA = "0x184E734A0")]
	public TypeBuilder AFKGNFIGDJP(string IADPDEAGFAB, TypeAttributes JLINONDCKCL, Type ICMEPOIJCJO, Type[] ENDOBJKFNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x4E73570", Offset = "0x4E72570", VA = "0x184E73570")]
	public PIHKFLFDJIM(string EHDPGGDPGCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class ICFGJHHLKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4B74430", Offset = "0x4B73430", VA = "0x184B74430")]
	private static MethodInfo AALOPPLEGOI(LambdaExpression IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x226A620", Offset = "0x2269620", VA = "0x18226A620")]
	public static MethodInfo PBHKIJBOAFA<T>(Expression<Func<T>> IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x226A620", Offset = "0x2269620", VA = "0x18226A620")]
	public static MethodInfo PBHKIJBOAFA<T, TR>(Expression<Func<T, TR>> IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x226A620", Offset = "0x2269620", VA = "0x18226A620")]
	public static MethodInfo PBHKIJBOAFA<T>(Expression<Action<T>> IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x226A620", Offset = "0x2269620", VA = "0x18226A620")]
	public static MethodInfo PBHKIJBOAFA<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x226A570", Offset = "0x2269570", VA = "0x18226A570")]
	private static MemberInfo HKHFCFFPJAP<T>(Expression<T> JFBGEPNCFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x226A510", Offset = "0x2269510", VA = "0x18226A510")]
	public static PropertyInfo GGHCLBCGLMI<T, TR>(Expression<Func<T, TR>> IIEIBJJHBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct PJJOBJKEALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int MNBBHFLLBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool NOBCFKAKHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator GMOLGNOIGAN;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4E73690", Offset = "0x4E72690", VA = "0x184E73690")]
	public PJJOBJKEALJ(ILGenerator GMOLGNOIGAN, int MNBBHFLLBID, bool NOBCFKAKHAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4E736D0", Offset = "0x4E726D0", VA = "0x184E736D0")]
	public PJJOBJKEALJ(ILGenerator GMOLGNOIGAN, int MNBBHFLLBID, Type IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4E73670", Offset = "0x4E72670", VA = "0x184E73670")]
	public void GCKEIIFFAFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class FAKCNOKBJJA
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4B194C0", Offset = "0x4B184C0", VA = "0x184B194C0")]
	public static void FJKBMHKDGEF(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4B19480", Offset = "0x4B18480", VA = "0x184B19480")]
	public static void FJKBMHKDGEF(this ILGenerator GMOLGNOIGAN, LocalBuilder BAAMAKMIJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4B19AE0", Offset = "0x4B18AE0", VA = "0x184B19AE0")]
	public static void KOODKKFAIBB(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4B19D10", Offset = "0x4B18D10", VA = "0x184B19D10")]
	public static void KOODKKFAIBB(this ILGenerator GMOLGNOIGAN, LocalBuilder BAAMAKMIJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4B198E0", Offset = "0x4B188E0", VA = "0x184B198E0")]
	public static void JFKOJKPIGGG(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4B199D0", Offset = "0x4B189D0", VA = "0x184B199D0")]
	public static void JFKOJKPIGGG(this ILGenerator GMOLGNOIGAN, LocalBuilder BAAMAKMIJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4B19D60", Offset = "0x4B18D60", VA = "0x184B19D60")]
	public static void NENKKDLBGMM(this ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4B19D50", Offset = "0x4B18D50", VA = "0x184B19D50")]
	public static void MGHBOEHIAAI(this ILGenerator GMOLGNOIGAN, bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4B18CF0", Offset = "0x4B17CF0", VA = "0x184B18CF0")]
	public static void ANOOKKEHDOC(this ILGenerator GMOLGNOIGAN, int DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4B197F0", Offset = "0x4B187F0", VA = "0x184B197F0")]
	public static void HFJDFNNPIFG(this ILGenerator GMOLGNOIGAN, Type IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4B19D70", Offset = "0x4B18D70", VA = "0x184B19D70")]
	public static void PNBINKDIPJM(this ILGenerator GMOLGNOIGAN, Type IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4B191D0", Offset = "0x4B181D0", VA = "0x184B191D0")]
	public static void BBIMMGPPGNA(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4B19400", Offset = "0x4B18400", VA = "0x184B19400")]
	public static void DABCEAPDFNB(this ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4B18C00", Offset = "0x4B17C00", VA = "0x184B18C00")]
	public static void AGELOAGBAKI(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4B196F0", Offset = "0x4B186F0", VA = "0x184B196F0")]
	public static void GEBKHOPCNNP(this ILGenerator GMOLGNOIGAN, MethodInfo FHLIGJBMGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4B19140", Offset = "0x4B18140", VA = "0x184B19140")]
	public static void BAEMJBDEPON(this ILGenerator GMOLGNOIGAN, FieldInfo FFKIAKKCLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4B19E20", Offset = "0x4B18E20", VA = "0x184B19E20")]
	public static void POJFCOLAENO(this ILGenerator GMOLGNOIGAN, ulong DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class CBFDBJMKKPC
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class EMPEGLCIDFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EMPEGLCIDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4E63DE0", Offset = "0x4E62DE0", VA = "0x184E63DE0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo JJCEAAGKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo MEOHJPOADNM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x69E130", Offset = "0x69D130", VA = "0x18069E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string DNHPIJKCCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x69E140", Offset = "0x69D140", VA = "0x18069E140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CFMHDJECHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4B07390", Offset = "0x4B06390", VA = "0x184B07390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MMCOECBBLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6993D0", Offset = "0x6983D0", VA = "0x1806993D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x78A640", Offset = "0x789640", VA = "0x18078A640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool CIOJGGHGMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6993E0", Offset = "0x6983E0", VA = "0x1806993E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xCB5360", Offset = "0xCB4360", VA = "0x180CB5360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6C01C0", Offset = "0x6BF1C0", VA = "0x1806C01C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo MEAPFJDLCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x716AE0", Offset = "0x715AE0", VA = "0x180716AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo CHMIOKINBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x685570", Offset = "0x684570", VA = "0x180685570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x685590", Offset = "0x684590", VA = "0x180685590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo DJFCJHIPIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x685580", Offset = "0x684580", VA = "0x180685580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6855A0", Offset = "0x6845A0", VA = "0x1806855A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4B07950", Offset = "0x4B06950", VA = "0x184B07950")]
	protected CBFDBJMKKPC(Type IGEIBCJNCHF, string IADPDEAGFAB, string DEEBFFICGIP, bool KHJHMGKFDOE, bool KNEGKJAPIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4B07690", Offset = "0x4B06690", VA = "0x184B07690")]
	public CBFDBJMKKPC(FieldInfo FEPBBMGBAMP, string IADPDEAGFAB, bool HJBKCEHLOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4B077A0", Offset = "0x4B067A0", VA = "0x184B077A0")]
	public CBFDBJMKKPC(PropertyInfo FEPBBMGBAMP, string IADPDEAGFAB, bool HJBKCEHLOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x4B07520", Offset = "0x4B06520", VA = "0x184B07520")]
	private static MethodInfo MIKBOOFGKHL(MemberInfo FEPBBMGBAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x22E2120", Offset = "0x22E1120", VA = "0x1822E2120")]
	public T KLEPCOMHCKJ<T>(bool ONMFLAHIEKK) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4B073A0", Offset = "0x4B063A0", VA = "0x184B073A0", Slot = "4")]
	public virtual void HKPKHPNPJBA(ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4B07460", Offset = "0x4B06460", VA = "0x184B07460", Slot = "5")]
	public virtual void LBKMFOAJLFG(ILGenerator GMOLGNOIGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class GEALPFJJLIO : CBFDBJMKKPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string CBMFMCFOKHC;

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4B6BAF0", Offset = "0x4B6AAF0", VA = "0x184B6BAF0")]
	public GEALPFJJLIO(string IADPDEAGFAB, string CBMFMCFOKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4B6B9F0", Offset = "0x4B6A9F0", VA = "0x184B6B9F0", Slot = "4")]
	public override void HKPKHPNPJBA(ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4B6BAB0", Offset = "0x4B6AAB0", VA = "0x184B6BAB0", Slot = "5")]
	public override void LBKMFOAJLFG(ILGenerator GMOLGNOIGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class JLENBDJFNAL : CBFDBJMKKPC
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo BBEEPEAJIMJ;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo PFIFEKALGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal PJJOBJKEALJ KIBGKEPNOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal PJJOBJKEALJ KJEDNAOJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal PJJOBJKEALJ NEGCAAGBPBK;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A690", Offset = "0x4B79690", VA = "0x184B7A690")]
	public JLENBDJFNAL(string IADPDEAGFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4B79F10", Offset = "0x4B78F10", VA = "0x184B79F10", Slot = "4")]
	public override void HKPKHPNPJBA(ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4B79FE0", Offset = "0x4B78FE0", VA = "0x184B79FE0", Slot = "5")]
	public override void LBKMFOAJLFG(ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A020", Offset = "0x4B79020", VA = "0x184B7A020")]
	public void MHGIPLELPEO(ILGenerator GMOLGNOIGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class LIAFLHMCAMO
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x69E130", Offset = "0x69D130", VA = "0x18069E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GHNJFHLPGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6988D0", Offset = "0x6978D0", VA = "0x1806988D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6BA000", Offset = "0x6B9000", VA = "0x1806BA000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AOHPFJIFOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4730", Offset = "0x7F3730", VA = "0x1807F4730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xBC5D30", Offset = "0xBC4D30", VA = "0x180BC5D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo OIFKIKPAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CBFDBJMKKPC[] FBODCMNBCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C01C0", Offset = "0x6BF1C0", VA = "0x1806C01C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CBFDBJMKKPC[] PLHBEBJKIPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x716AE0", Offset = "0x715AE0", VA = "0x180716AE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F270", Offset = "0x4B7E270", VA = "0x184B7F270")]
	public LIAFLHMCAMO(Type IGEIBCJNCHF, Func<string, string> NPPCGIKENOB, bool HJBKCEHLOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F180", Offset = "0x4B7E180", VA = "0x184B7F180")]
	private static bool AEDAKOGALHI(IEnumerator<ConstructorInfo> AEGMLMBMHDO, ref ConstructorInfo LPAMELJINII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct JCGNAICPMFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong ENHNHFJMKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int PBDFKDHMIEL;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x20782B0", Offset = "0x20772B0", VA = "0x1820782B0")]
	public JCGNAICPMFE(ulong OEABHAKKCIB, int PEBIEFMKNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4B782B0", Offset = "0x4B772B0", VA = "0x184B782B0")]
	public void PHKPNLNPCJD(ref JCGNAICPMFE KICLNADFIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4B78200", Offset = "0x4B77200", VA = "0x184B78200")]
	public static JCGNAICPMFE KNJFJANOBDD(ref JCGNAICPMFE NCNGLFNLPAG, ref JCGNAICPMFE OPGAGDBKIDA)
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B780E0", Offset = "0x4B770E0", VA = "0x184B780E0")]
	public void HAECAAHDANK(ref JCGNAICPMFE KICLNADFIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4B78210", Offset = "0x4B77210", VA = "0x184B78210")]
	public static JCGNAICPMFE ONJOCOBFODK(ref JCGNAICPMFE NCNGLFNLPAG, ref JCGNAICPMFE OPGAGDBKIDA)
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B78170", Offset = "0x4B77170", VA = "0x184B78170")]
	public void IMEJDEMJNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4B781B0", Offset = "0x4B771B0", VA = "0x184B781B0")]
	public static JCGNAICPMFE IMEJDEMJNFI(ref JCGNAICPMFE NCNGLFNLPAG)
	{
		return default(JCGNAICPMFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct IIPHMCMNDJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int PNKNABOKANH;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77C5B0", VA = "0x18077D5B0")]
	public IIPHMCMNDJH(byte[] FAHBHODOFIG, int IJBELJOFGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B76870", Offset = "0x4B75870", VA = "0x184B76870")]
	public void MLFCKGFJJEL(byte HCJLPANMOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4B76500", Offset = "0x4B75500", VA = "0x184B76500")]
	public void CHJJFAFCBLE(byte[] HCJLPANMOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B76720", Offset = "0x4B75720", VA = "0x184B76720")]
	public void HJKJKFMLGJB(byte[] HCJLPANMOCK, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B767C0", Offset = "0x4B757C0", VA = "0x184B767C0")]
	public void HJKJKFMLGJB(byte[] HCJLPANMOCK, int FHGIIAKFJFF, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B766A0", Offset = "0x4B756A0", VA = "0x184B766A0")]
	public void HIJLCCGKAJB(byte NKNPGFCGIPO, int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4B765A0", Offset = "0x4B755A0", VA = "0x184B765A0")]
	public void DKOHLMMDNFI(string HCJLPANMOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class CAHJNLPJDFE
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum OLFGNONFEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum MMFMKNKLBAE
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum JIOFFAOJGDD
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
	private static byte[] FOOENGIJFLN;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] DNLHENAGNBC;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] JEPOIPEDKDJ;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] OJCJCPNPPKD;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly JIOFFAOJGDD KAOBEOKFALE;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char ALOLGIDLAMP;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int BDBPCIMNKAK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int AJGKHFLBGFA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] EDHCLLKGIHP;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4B06BC0", Offset = "0x4B05BC0", VA = "0x184B06BC0")]
	private static byte[] PKBGLIKIKNB(int BDHBBDMMOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B05BD0", Offset = "0x4B04BD0", VA = "0x184B05BD0")]
	private static byte[] HOLFBHEJFAH(int BDHBBDMMOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B066B0", Offset = "0x4B056B0", VA = "0x184B066B0")]
	public static int KPJAFBEEOCO(ref byte[] FAHBHODOFIG, int PNKNABOKANH, float DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B067D0", Offset = "0x4B057D0", VA = "0x184B067D0")]
	public static int KPJAFBEEOCO(ref byte[] FAHBHODOFIG, int PNKNABOKANH, double DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4B05310", Offset = "0x4B04310", VA = "0x184B05310")]
	private static bool CIEEAFONCPM(byte[] FAHBHODOFIG, int MFAHIHFAKKH, ulong DGOMCCHJOLL, ulong OFMOPGMGDKL, ulong CMJGLNDNCNL, ulong HMHDLKCBANC, ulong LBDLDNKLKFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4B068F0", Offset = "0x4B058F0", VA = "0x184B068F0")]
	private static void ONJMJDLJDJA(uint KOCCBGHFMNN, int MCEJIFGFOFH, out uint MGNPKBLNOBI, out int GEBKHFGPNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B056B0", Offset = "0x4B046B0", VA = "0x184B056B0")]
	private static bool GBOAKKJGBMB(JCGNAICPMFE MKBCDJFFMOJ, JCGNAICPMFE AOJLCLDDLKO, JCGNAICPMFE FLCJEMLMJJC, byte[] FAHBHODOFIG, out int MFAHIHFAKKH, out int LEKMIGPFNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4B06310", Offset = "0x4B05310", VA = "0x184B06310")]
	private static bool JOLIEHHDOGB(double BGLBBPFJJCJ, OLFGNONFEJJ HOEJODOFJHI, byte[] FAHBHODOFIG, out int MFAHIHFAKKH, out int BPMINMKOLFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4B055A0", Offset = "0x4B045A0", VA = "0x184B055A0")]
	private static bool DNPOOCGBGGA(double BGLBBPFJJCJ, OLFGNONFEJJ HOEJODOFJHI, byte[] FAHBHODOFIG, out int MFAHIHFAKKH, out int FHIHCIHKKAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B05410", Offset = "0x4B04410", VA = "0x184B05410")]
	private static bool DMJHOOOCMGI(double DFEOJBAFBHE, ref IIPHMCMNDJH BCIDINGHJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B05CB0", Offset = "0x4B04CB0", VA = "0x184B05CB0")]
	private static bool IPCDAKIKILM(double DFEOJBAFBHE, ref IIPHMCMNDJH BCIDINGHJNK, MMFMKNKLBAE HOEJODOFJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B06CA0", Offset = "0x4B05CA0", VA = "0x184B06CA0")]
	private static void POLFOHNOKLK(byte[] MEDICKCMHGL, int MFAHIHFAKKH, int FHIHCIHKKAG, int JDINDDMJOML, ref IIPHMCMNDJH BCIDINGHJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4B05010", Offset = "0x4B04010", VA = "0x184B05010")]
	private static void BPDPPDBEJEL(byte[] MEDICKCMHGL, int MFAHIHFAKKH, int PEBIEFMKNOB, ref IIPHMCMNDJH BCIDINGHJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B06A10", Offset = "0x4B05A10", VA = "0x184B06A10")]
	private static bool PDDPLJKABFM(double BGLBBPFJJCJ, MMFMKNKLBAE HOEJODOFJHI, int JDEAOOPDDDN, byte[] JBEKHEJIENA, out bool CMIILGJLNCN, out int MFAHIHFAKKH, out int LMABBBKCION)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct EFKFPPNADMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double LNMAPJNBGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong AGCGBJBHNHE;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct BFMENMBNFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float ENHNHFJMKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint KAGGLOMJPGB;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct PFCOGLMCLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong EOBCEFOOLAN;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E72F00", Offset = "0x4E71F00", VA = "0x184E72F00")]
	public PFCOGLMCLNJ(double LNMAPJNBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E72F10", Offset = "0x4E71F10", VA = "0x184E72F10")]
	public PFCOGLMCLNJ(JCGNAICPMFE LNMAPJNBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E72980", Offset = "0x4E71980", VA = "0x184E72980")]
	public JCGNAICPMFE CBOFBLKKKKN()
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E72A70", Offset = "0x4E71A70", VA = "0x184E72A70")]
	public JCGNAICPMFE EPNILAHAOHB()
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x67E000", Offset = "0x67D000", VA = "0x18067E000")]
	public ulong KOBJMIOLGNM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E72DF0", Offset = "0x4E71DF0", VA = "0x184E72DF0")]
	public double LBJIPDLDAEJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E72BD0", Offset = "0x4E71BD0", VA = "0x184E72BD0")]
	public double IFENOBNFNPJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E72E80", Offset = "0x4E71E80", VA = "0x184E72E80")]
	public int LNFMGNCFDKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E72A30", Offset = "0x4E71A30", VA = "0x184E72A30")]
	public ulong DOFFJINBGAO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E72A00", Offset = "0x4E71A00", VA = "0x184E72A00")]
	public bool DEPHDENCGHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E72EB0", Offset = "0x4E71EB0", VA = "0x184E72EB0")]
	public bool NDFKIECFNJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E72BA0", Offset = "0x4E71BA0", VA = "0x184E72BA0")]
	public bool FHCMJOKPCJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E72ED0", Offset = "0x4E71ED0", VA = "0x184E72ED0")]
	public bool PPJLFFMPIPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E72960", Offset = "0x4E71960", VA = "0x184E72960")]
	public int BNMMHBHKLMG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E72C60", Offset = "0x4E71C60", VA = "0x184E72C60")]
	public void JOADOBPMNJI(out JCGNAICPMFE LFPFOPOGLOK, out JCGNAICPMFE LILCFDPBBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4E72910", Offset = "0x4E71910", VA = "0x184E72910")]
	public bool BEADLCHEJPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4E72A20", Offset = "0x4E71A20", VA = "0x184E72A20")]
	public double DFEOJBAFBHE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4E72DD0", Offset = "0x4E71DD0", VA = "0x184E72DD0")]
	public static int KGGFFGKDNBI(int AGFBKKLEANA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4E72A60", Offset = "0x4E71A60", VA = "0x184E72A60")]
	public static double EIDNGFEEDLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4E72B00", Offset = "0x4E71B00", VA = "0x184E72B00")]
	public static ulong FBNCJBDFPPL(JCGNAICPMFE OMKGAALHLFD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct BDOJCHBHPKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint EIFGJPNOMJN;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2480", Offset = "0x2BC1480", VA = "0x182BC2480")]
	public BDOJCHBHPKN(float ENHNHFJMKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4B02A70", Offset = "0x4B01A70", VA = "0x184B02A70")]
	public JCGNAICPMFE CBOFBLKKKKN()
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20")]
	public uint LDAPFODAHIB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4B02C70", Offset = "0x4B01C70", VA = "0x184B02C70")]
	public int LNFMGNCFDKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4B02AF0", Offset = "0x4B01AF0", VA = "0x184B02AF0")]
	public uint DOFFJINBGAO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B02AE0", Offset = "0x4B01AE0", VA = "0x184B02AE0")]
	public bool DEPHDENCGHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B02B10", Offset = "0x4B01B10", VA = "0x184B02B10")]
	public void JOADOBPMNJI(out JCGNAICPMFE LFPFOPOGLOK, out JCGNAICPMFE LILCFDPBBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B02A30", Offset = "0x4B01A30", VA = "0x184B02A30")]
	public bool BEADLCHEJPA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct PLNLCPEALKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong OEABHAKKCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short BJHPKBPPJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short BPMINMKOLFA;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E73920", Offset = "0x4E72920", VA = "0x184E73920")]
	public PLNLCPEALKJ(ulong OEABHAKKCIB, short BJHPKBPPJNM, short BPMINMKOLFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class CKMOKIJCKKB
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly PLNLCPEALKJ[] EKDAEIKLDFH;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4B08CE0", Offset = "0x4B07CE0", VA = "0x184B08CE0")]
	public static void AGFEJFAEEOO(int AKDLHNJKEOI, int OOIPJFIKNEG, out JCGNAICPMFE MGNPKBLNOBI, out int BPMINMKOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B08E20", Offset = "0x4B07E20", VA = "0x184B08E20")]
	public static void MBFKPFOIPBM(int DPGJKFFAADN, out JCGNAICPMFE MGNPKBLNOBI, out int NKCDPGLIEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct CADCBDKIGIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] CCFMJPPGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int FHGIIAKFJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int NNDKDNDGKOH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x4B04F70", Offset = "0x4B03F70", VA = "0x184B04F70")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xBB4410", Offset = "0xBB3410", VA = "0x180BB4410")]
	public CADCBDKIGIP(byte[] CCFMJPPGPDK, int FHGIIAKFJFF, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x776A40", Offset = "0x775A40", VA = "0x180776A40")]
	public int MFAHIHFAKKH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4B04FB0", Offset = "0x4B03FB0", VA = "0x184B04FB0")]
	public CADCBDKIGIP GLFJGHMCJGK(int LLJOHLBBLLB, int FOPGHCLMOAD)
	{
		return default(CADCBDKIGIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class MCIBGHFPJCD
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] GHCJPLLGJPN;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] GMKCMFEHCED;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int APIJILEJFGO;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4B822F0", Offset = "0x4B812F0", VA = "0x184B822F0")]
	private static byte[] MAEPPHIELIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4B82600", Offset = "0x4B81600", VA = "0x184B82600")]
	private static CADCBDKIGIP OPGGGLIFAPJ(CADCBDKIGIP FAHBHODOFIG)
	{
		return default(CADCBDKIGIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4B81AB0", Offset = "0x4B80AB0", VA = "0x184B81AB0")]
	private static CADCBDKIGIP BBPGGCIGKPK(CADCBDKIGIP FAHBHODOFIG)
	{
		return default(CADCBDKIGIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4B81C80", Offset = "0x4B80C80", VA = "0x184B81C80")]
	private static void CCPKKDDAHEG(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB, byte[] MNDCHFJCCCI, out int DHBIDAHHAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4B82050", Offset = "0x4B81050", VA = "0x184B82050")]
	private static void LDPLKODGEFP(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB, byte[] MHNFDLMDGJB, int MPPPBDBHLAH, out CADCBDKIGIP IIFMMGGIPKK, out int HNAAIJKMKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4B823E0", Offset = "0x4B813E0", VA = "0x184B823E0")]
	private static ulong OCEPFKKPGIA(CADCBDKIGIP FAHBHODOFIG, out int HEFAEGMDCHC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4B81F20", Offset = "0x4B80F20", VA = "0x184B81F20")]
	private static void JENCBLJLAFA(CADCBDKIGIP FAHBHODOFIG, out JCGNAICPMFE MMPEAFKIOCN, out int LNLFHCGCMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4B826B0", Offset = "0x4B816B0", VA = "0x184B826B0")]
	private static bool PKDPMCGKNEL(CADCBDKIGIP IIFMMGGIPKK, int PEBIEFMKNOB, out double MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4B82470", Offset = "0x4B81470", VA = "0x184B82470")]
	private static JCGNAICPMFE ODMNAKILJCF(int PEBIEFMKNOB)
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x4B81590", Offset = "0x4B80590", VA = "0x184B81590")]
	private static bool ANOOADAICOE(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB, out double MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4B81450", Offset = "0x4B80450", VA = "0x184B81450")]
	private static bool ABEKPOBHJFJ(CADCBDKIGIP IIFMMGGIPKK, int PEBIEFMKNOB, out double FNPDEDNGDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4B81B60", Offset = "0x4B80B60", VA = "0x184B81B60")]
	public static double? BOAGCMJCDKN(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x4B81D40", Offset = "0x4B80D40", VA = "0x184B81D40")]
	public static float? HNBMEOIBFAK(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct CAPLPJGNJOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int PNKNABOKANH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x4B07270", Offset = "0x4B06270", VA = "0x184B07270")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77C5B0", VA = "0x18077D5B0")]
	public CAPLPJGNJOG(byte[] FAHBHODOFIG, int PNKNABOKANH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x4B07210", Offset = "0x4B06210", VA = "0x184B07210")]
	public static CAPLPJGNJOG GBONAKDPJMP(CAPLPJGNJOG BLHHJNENDMO)
	{
		return default(CAPLPJGNJOG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4B072B0", Offset = "0x4B062B0", VA = "0x184B072B0")]
	public static CAPLPJGNJOG LGHBHOPGAGF(CAPLPJGNJOG BLHHJNENDMO, int MFAHIHFAKKH)
	{
		return default(CAPLPJGNJOG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4B07370", Offset = "0x4B06370", VA = "0x184B07370")]
	public static int OOOBHHMAEMO(CAPLPJGNJOG JCHPGJLCOCJ, CAPLPJGNJOG GHMOJHOMMOK)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4B071A0", Offset = "0x4B061A0", VA = "0x184B071A0")]
	public static bool FHCNBCDBOFI(CAPLPJGNJOG JCHPGJLCOCJ, CAPLPJGNJOG GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4B07350", Offset = "0x4B06350", VA = "0x184B07350")]
	public static bool LIEIJOJMABA(CAPLPJGNJOG JCHPGJLCOCJ, CAPLPJGNJOG GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x4B071C0", Offset = "0x4B061C0", VA = "0x184B071C0")]
	public static bool FHCNBCDBOFI(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4B07300", Offset = "0x4B06300", VA = "0x184B07300")]
	public static bool LIEIJOJMABA(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4B07300", Offset = "0x4B06300", VA = "0x184B07300")]
	public static bool LIEIJOJMABA(CAPLPJGNJOG JCHPGJLCOCJ, byte GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4B07150", Offset = "0x4B06150", VA = "0x184B07150")]
	public static bool DMAOELLFPEE(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4B07100", Offset = "0x4B06100", VA = "0x184B07100")]
	public static bool BLBLPHALPKB(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4B070B0", Offset = "0x4B060B0", VA = "0x184B070B0")]
	public static bool BKICIBGHAMO(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4B07220", Offset = "0x4B06220", VA = "0x184B07220")]
	public static bool HPOJALLLMGD(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class IFCLFJAEJFO
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] GKKKNCBOFGA;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] PGEFNACIKFL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] JEPOIPEDKDJ;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] OJCJCPNPPKD;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] GGKMCIDGJGP;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int ILOPHOFFGMJ;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] NAMPNJJOILA;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int LNBGKCAKHIF;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4B74F10", Offset = "0x4B73F10", VA = "0x184B74F10")]
	private static byte[] KDIMAKIMIBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x4B748A0", Offset = "0x4B738A0", VA = "0x184B748A0")]
	private static byte[] BPLHEBBMGIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x4B74D50", Offset = "0x4B73D50", VA = "0x184B74D50")]
	public static double HEJJCJMCNIB(byte[] FAHBHODOFIG, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4B74C70", Offset = "0x4B73C70", VA = "0x184B74C70")]
	public static float DBIIMGMIGNM(byte[] FAHBHODOFIG, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x4B74AA0", Offset = "0x4B73AA0", VA = "0x184B74AA0")]
	private static bool CKDMBKECMDL(int JMDPDGBMGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x4B74E00", Offset = "0x4B73E00", VA = "0x184B74E00")]
	private static bool IGHOAMIKNAD(ref CAPLPJGNJOG JFKHJAJODDL, CAPLPJGNJOG APIEJLBIMAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4B74990", Offset = "0x4B73990", VA = "0x184B74990")]
	private static bool CICGDIAGDNE(ref CAPLPJGNJOG JFKHJAJODDL, CAPLPJGNJOG APIEJLBIMAO, byte[] GKDHDKEHOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4B74C20", Offset = "0x4B73C20", VA = "0x184B74C20")]
	private static bool DAJLIDBEAGO(ref CAPLPJGNJOG PBLHANHGPII, byte[] HCJLPANMOCK, int PNKNABOKANH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4B74D30", Offset = "0x4B73D30", VA = "0x184B74D30")]
	private static double GJCBEBIMAFH(bool CMIILGJLNCN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4B75000", Offset = "0x4B74000", VA = "0x184B75000")]
	private static double OIBKFBHJHND(CAPLPJGNJOG GIEOCCOFGEG, int MFAHIHFAKKH, bool FGKKIDLAAKO, out int EPKJKKFBOBG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class CHAHKCEPFPL<T> : global::KBIOLGDHIDG<T[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::AJCIIEGBJNM<T> FGONAFOACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly FFOJCCDENBP CLPHJBHPIHI;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x34669A0", Offset = "0x34659A0", VA = "0x1834669A0")]
	public CHAHKCEPFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C420", Offset = "0x1E2B420", VA = "0x181E2C420")]
	public CHAHKCEPFPL(FFOJCCDENBP CLPHJBHPIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9220", Offset = "0x3EA8220", VA = "0x183EA9220", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6AC0", Offset = "0x3EA5AC0", VA = "0x183EA6AC0", Slot = "5")]
	public T[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class KEANDGNMNOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::AJCIIEGBJNM<T> FGONAFOACAH;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class PBNPNNODMPI<T> : global::KBIOLGDHIDG<List<T>>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly FFOJCCDENBP CLPHJBHPIHI;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x34669A0", Offset = "0x34659A0", VA = "0x1834669A0")]
	public PBNPNNODMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C420", Offset = "0x1E2B420", VA = "0x181E2C420")]
	public PBNPNNODMPI(FFOJCCDENBP CLPHJBHPIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3465EE0", Offset = "0x3464EE0", VA = "0x183465EE0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, List<T> DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x34654B0", Offset = "0x34644B0", VA = "0x1834654B0", Slot = "5")]
	public List<T> CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class JGABEFMIFJJ<TElement, TIntermediate, TEnumerator, TCollection> : global::KBIOLGDHIDG<TCollection>, CDJJKNODMKB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3252C20", Offset = "0x3251C20", VA = "0x183252C20", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, TCollection DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3251BD0", Offset = "0x3250BD0", VA = "0x183251BD0", Slot = "5")]
	public TCollection CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DFFMHNIAILL(TCollection JFBGEPNCFEC);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate HJNGNBALKKN();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HMNAIPBHJIK(ref TIntermediate GLNLHJNNDLD, int NPDGHPHAKDK, TElement DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection NNHOADFEBDJ(ref TIntermediate BGKOPHJCJAG);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	protected JGABEFMIFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class OMDBGHJBFMI<TElement, TIntermediate, TCollection> : global::JGABEFMIFJJ<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1E2F090", Offset = "0x1E2E090", VA = "0x181E2F090", Slot = "6")]
	protected override IEnumerator<TElement> DFFMHNIAILL(TCollection JFBGEPNCFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x22CD240", Offset = "0x22CC240", VA = "0x1822CD240")]
	protected OMDBGHJBFMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class GFOJMJFEHMJ<TElement, TCollection> : global::OMDBGHJBFMI<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected sealed override TCollection NNHOADFEBDJ(ref TCollection BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class EBECEFOGDNN<TElement, TCollection> : global::GFOJMJFEHMJ<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x272C0D0", Offset = "0x272B0D0", VA = "0x18272C0D0", Slot = "7")]
	protected override TCollection HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x272C0F0", Offset = "0x272B0F0", VA = "0x18272C0F0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref TCollection GLNLHJNNDLD, int NPDGHPHAKDK, TElement DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class IMPJCBEPEFE<T> : global::JGABEFMIFJJ<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B840", Offset = "0x1E2A840", VA = "0x181E2B840", Slot = "8")]
	protected override void HMNAIPBHJIK(ref LinkedList<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override LinkedList<T> NNHOADFEBDJ(ref LinkedList<T> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override LinkedList<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B780", Offset = "0x1E2A780", VA = "0x181E2B780", Slot = "6")]
	protected override LinkedList<T>.Enumerator DFFMHNIAILL(LinkedList<T> JFBGEPNCFEC)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class GJIOGPMIPAI<T> : global::JGABEFMIFJJ<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B840", Offset = "0x1E2A840", VA = "0x181E2B840", Slot = "8")]
	protected override void HMNAIPBHJIK(ref Queue<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override Queue<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2856550", Offset = "0x2855550", VA = "0x182856550", Slot = "6")]
	protected override Queue<T>.Enumerator DFFMHNIAILL(Queue<T> JFBGEPNCFEC)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override Queue<T> NNHOADFEBDJ(ref Queue<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CDNFJPCLBEP<T> : global::JGABEFMIFJJ<T, global::GJFGIFNNEBL<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x29C5DE0", Offset = "0x29C4DE0", VA = "0x1829C5DE0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref global::GJFGIFNNEBL<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x29C5DA0", Offset = "0x29C4DA0", VA = "0x1829C5DA0", Slot = "7")]
	protected override global::GJFGIFNNEBL<T> HJNGNBALKKN()
	{
		return default(global::GJFGIFNNEBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2856550", Offset = "0x2855550", VA = "0x182856550", Slot = "6")]
	protected override Stack<T>.Enumerator DFFMHNIAILL(Stack<T> JFBGEPNCFEC)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x29C5E10", Offset = "0x29C4E10", VA = "0x1829C5E10", Slot = "9")]
	protected override Stack<T> NNHOADFEBDJ(ref global::GJFGIFNNEBL<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NFDKCPOCEML<T> : global::JGABEFMIFJJ<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B840", Offset = "0x1E2A840", VA = "0x181E2B840", Slot = "8")]
	protected override void HMNAIPBHJIK(ref HashSet<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override HashSet<T> NNHOADFEBDJ(ref HashSet<T> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override HashSet<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2856550", Offset = "0x2855550", VA = "0x182856550", Slot = "6")]
	protected override HashSet<T>.Enumerator DFFMHNIAILL(HashSet<T> JFBGEPNCFEC)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class IAFGCDGOCDO<T> : global::OMDBGHJBFMI<T, global::GJFGIFNNEBL<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x29C5DE0", Offset = "0x29C4DE0", VA = "0x1829C5DE0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref global::GJFGIFNNEBL<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x451EC20", Offset = "0x451DC20", VA = "0x18451EC20", Slot = "9")]
	protected override ReadOnlyCollection<T> NNHOADFEBDJ(ref global::GJFGIFNNEBL<T> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x451EBE0", Offset = "0x451DBE0", VA = "0x18451EBE0", Slot = "7")]
	protected override global::GJFGIFNNEBL<T> HJNGNBALKKN()
	{
		return default(global::GJFGIFNNEBL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class MPAAADODCOE<T> : global::OMDBGHJBFMI<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B840", Offset = "0x1E2A840", VA = "0x181E2B840", Slot = "8")]
	protected override void HMNAIPBHJIK(ref List<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override List<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override IList<T> NNHOADFEBDJ(ref List<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class CLBBNJFBMAH<T> : global::OMDBGHJBFMI<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B840", Offset = "0x1E2A840", VA = "0x181E2B840", Slot = "8")]
	protected override void HMNAIPBHJIK(ref List<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override List<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override ICollection<T> NNHOADFEBDJ(ref List<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class POJAJBLGMLJ<T> : global::OMDBGHJBFMI<T, global::GJFGIFNNEBL<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x29C5DE0", Offset = "0x29C4DE0", VA = "0x1829C5DE0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref global::GJFGIFNNEBL<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x29C5DA0", Offset = "0x29C4DA0", VA = "0x1829C5DA0", Slot = "7")]
	protected override global::GJFGIFNNEBL<T> HJNGNBALKKN()
	{
		return default(global::GJFGIFNNEBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D130", Offset = "0x2D9C130", VA = "0x182D9D130", Slot = "9")]
	protected override IEnumerable<T> NNHOADFEBDJ(ref global::GJFGIFNNEBL<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class OJGJDGBMDOI<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class GFKGEAHJJLP<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class EDGPCALOHNP<T> : global::KBIOLGDHIDG<T>, CDJJKNODMKB where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x272F650", Offset = "0x272E650", VA = "0x18272F650", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x272F440", Offset = "0x272E440", VA = "0x18272F440", Slot = "5")]
	public T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	public EDGPCALOHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class INOAPNDKPGJ : global::KBIOLGDHIDG<IEnumerable>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::KBIOLGDHIDG<IEnumerable> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4B76B60", Offset = "0x4B75B60", VA = "0x184B76B60", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, IEnumerable DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4B768D0", Offset = "0x4B758D0", VA = "0x184B768D0", Slot = "5")]
	public IEnumerable CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public INOAPNDKPGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class OCPOGFLFAKM : global::KBIOLGDHIDG<ICollection>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::KBIOLGDHIDG<ICollection> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4E71750", Offset = "0x4E70750", VA = "0x184E71750", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ICollection DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x4E715A0", Offset = "0x4E705A0", VA = "0x184E715A0", Slot = "5")]
	public ICollection CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public OCPOGFLFAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class LGFDLOFKBOB : global::KBIOLGDHIDG<IList>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::KBIOLGDHIDG<IList> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EDB0", Offset = "0x4B7DDB0", VA = "0x184B7EDB0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, IList DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EB20", Offset = "0x4B7DB20", VA = "0x184B7EB20", Slot = "5")]
	public IList CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LGFDLOFKBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class MEEHIKDOHAM<T> : global::OMDBGHJBFMI<T, global::GJFGIFNNEBL<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2F68720", Offset = "0x2F67720", VA = "0x182F68720", Slot = "8")]
	protected override void HMNAIPBHJIK(ref global::GJFGIFNNEBL<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x29C5DA0", Offset = "0x29C4DA0", VA = "0x1829C5DA0", Slot = "7")]
	protected override global::GJFGIFNNEBL<T> HJNGNBALKKN()
	{
		return default(global::GJFGIFNNEBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2F68750", Offset = "0x2F67750", VA = "0x182F68750", Slot = "9")]
	protected override IReadOnlyList<T> NNHOADFEBDJ(ref global::GJFGIFNNEBL<T> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x20194A0", Offset = "0x20184A0", VA = "0x1820194A0")]
	public MEEHIKDOHAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class OEEIIAHBNNL
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x4E71C30", Offset = "0x4E70C30", VA = "0x184E71C30")]
	public static DateTime OFNDHADAMHG(DateTime GGCDGBAICJE)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class DBMPHKMKOKM : global::KBIOLGDHIDG<DateTime>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::KBIOLGDHIDG<DateTime> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DBE0", Offset = "0x4B0CBE0", VA = "0x184B0DBE0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, DateTime DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CC80", Offset = "0x4B0BC80", VA = "0x184B0CC80", Slot = "5")]
	public DateTime CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public DBMPHKMKOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class CLNIMHCGMGL : global::KBIOLGDHIDG<DateTimeOffset>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::KBIOLGDHIDG<DateTimeOffset> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4B0BE30", Offset = "0x4B0AE30", VA = "0x184B0BE30", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, DateTimeOffset DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4B0AEF0", Offset = "0x4B09EF0", VA = "0x184B0AEF0", Slot = "5")]
	public DateTimeOffset CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CLNIMHCGMGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class ABNKIELHCGM : global::KBIOLGDHIDG<TimeSpan>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::KBIOLGDHIDG<TimeSpan> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] LGHIJOHOEOH;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x4B010F0", Offset = "0x4B000F0", VA = "0x184B010F0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, TimeSpan DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4B00710", Offset = "0x4AFF710", VA = "0x184B00710", Slot = "5")]
	public TimeSpan CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public ABNKIELHCGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class LMBODJBLMOI<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::KBIOLGDHIDG<TDictionary>, CDJJKNODMKB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3A517A0", Offset = "0x3A507A0", VA = "0x183A517A0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, TDictionary DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F8F0", Offset = "0x3A4E8F0", VA = "0x183A4F8F0", Slot = "5")]
	public TDictionary CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DFFMHNIAILL(TDictionary JFBGEPNCFEC);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate HJNGNBALKKN();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HMNAIPBHJIK(ref TIntermediate GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary NNHOADFEBDJ(ref TIntermediate BGKOPHJCJAG);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	protected LMBODJBLMOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class IONJMAHMDHB<TKey, TValue, TIntermediate, TDictionary> : global::LMBODJBLMOI<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2F090", Offset = "0x1E2E090", VA = "0x181E2F090", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> DFFMHNIAILL(TDictionary JFBGEPNCFEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class GMLPBAICJGP<TKey, TValue, TDictionary> : global::IONJMAHMDHB<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override TDictionary NNHOADFEBDJ(ref TDictionary BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class PBNCGBPILEE<TKey, TValue> : global::LMBODJBLMOI<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3464D30", Offset = "0x3463D30", VA = "0x183464D30", Slot = "8")]
	protected override void HMNAIPBHJIK(ref Dictionary<TKey, TValue> GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override Dictionary<TKey, TValue> NNHOADFEBDJ(ref Dictionary<TKey, TValue> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override Dictionary<TKey, TValue> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3464CE0", Offset = "0x3463CE0", VA = "0x183464CE0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator DFFMHNIAILL(Dictionary<TKey, TValue> JFBGEPNCFEC)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2455BF0", Offset = "0x2454BF0", VA = "0x182455BF0")]
	public PBNCGBPILEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class JHAABICEMEB<TKey, TValue, TDictionary> : global::GMLPBAICJGP<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3254270", Offset = "0x3253270", VA = "0x183254270", Slot = "8")]
	protected override void HMNAIPBHJIK(ref TDictionary GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1E5ACF0", Offset = "0x1E59CF0", VA = "0x181E5ACF0", Slot = "7")]
	protected override TDictionary HJNGNBALKKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class INPGABIGFGD<TKey, TValue> : global::IONJMAHMDHB<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C450", Offset = "0x1E2B450", VA = "0x181E2C450", Slot = "8")]
	protected override void HMNAIPBHJIK(ref Dictionary<TKey, TValue> GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override Dictionary<TKey, TValue> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override IDictionary<TKey, TValue> NNHOADFEBDJ(ref Dictionary<TKey, TValue> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class LPMMELOOABJ<TKey, TValue> : global::GMLPBAICJGP<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C450", Offset = "0x1E2B450", VA = "0x181E2C450", Slot = "8")]
	protected override void HMNAIPBHJIK(ref SortedList<TKey, TValue> GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override SortedList<TKey, TValue> HJNGNBALKKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class MBOELMMPELH<TKey, TValue> : global::LMBODJBLMOI<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C450", Offset = "0x1E2B450", VA = "0x181E2C450", Slot = "8")]
	protected override void HMNAIPBHJIK(ref SortedDictionary<TKey, TValue> GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1087320", Offset = "0x1086320", VA = "0x181087320", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NNHOADFEBDJ(ref SortedDictionary<TKey, TValue> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7E0", Offset = "0x1E2A7E0", VA = "0x181E2B7E0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2F62490", Offset = "0x2F61490", VA = "0x182F62490", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator DFFMHNIAILL(SortedDictionary<TKey, TValue> JFBGEPNCFEC)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class GDLPGAOEJHK<T> : global::KBIOLGDHIDG<T>, CDJJKNODMKB where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x39E8B00", Offset = "0x39E7B00", VA = "0x1839E8B00", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x39E88D0", Offset = "0x39E78D0", VA = "0x1839E88D0", Slot = "5")]
	public T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	public GDLPGAOEJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class GIACFELFEKJ : global::KBIOLGDHIDG<IDictionary>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::KBIOLGDHIDG<IDictionary> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x4B6C890", Offset = "0x4B6B890", VA = "0x184B6C890", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, IDictionary DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x4B6C4F0", Offset = "0x4B6B4F0", VA = "0x184B6C4F0", Slot = "5")]
	public IDictionary CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GIACFELFEKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class HIPBHLDEGGC : global::KBIOLGDHIDG<object>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void EMBEIAEDKFJ(object PNPKJCNPONA, ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::KLLFKEKDHGC<KeyValuePair<object, EMBEIAEDKFJ>> BMNJABIDNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly CDAHFIMKBKG[] LOOLELJHFAD;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F410", Offset = "0x4B6E410", VA = "0x184B6F410")]
	public HIPBHLDEGGC(params CDAHFIMKBKG[] LOOLELJHFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E9B0", Offset = "0x4B6D9B0", VA = "0x184B6E9B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E910", Offset = "0x4B6D910", VA = "0x184B6E910", Slot = "5")]
	public object CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class JGOFCCDBAPJ
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4B78CD0", Offset = "0x4B77CD0", VA = "0x184B78CD0")]
	public static object FJFIPBKEMNM(Type IGEIBCJNCHF, out bool NMAELJGCAME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4B795F0", Offset = "0x4B785F0", VA = "0x184B795F0")]
	public static object PJPGPBOBFFD(Type IGEIBCJNCHF, out bool NMAELJGCAME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class CFEANDEOONP<T> : global::KBIOLGDHIDG<T>, CDJJKNODMKB, global::NKJJGAMHDGI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class GEILLDECEFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public GEILLDECEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2843AA0", Offset = "0x2842AA0", VA = "0x182843AA0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class IJCPMMJKGLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::KOIGGKEGCNJ<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public IJCPMMJKGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B970", Offset = "0x1E1A970", VA = "0x181E1B970")]
		internal void <.cctor>b__1(ref IPBPHIELIHL writer, T value, CDAHFIMKBKG _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class HGPPFACCGOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::KNFFAHGKNBH<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public HGPPFACCGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3187AE0", Offset = "0x3186AE0", VA = "0x183187AE0")]
		internal T <.cctor>b__2(ref HJNHIBNNFEE reader, CDAHFIMKBKG _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::BMGANMGKAHN<T> GCEFIFGMJJM;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> JICLFNOBGPA;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::KOIGGKEGCNJ<T> FDMOLCODLGA;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::KNFFAHGKNBH<T> MPPFKFAJIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool IIIKGJKIMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::KOIGGKEGCNJ<T> ONJOOEIKDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::KNFFAHGKNBH<T> ECNOMAALFDK;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x29CBF40", Offset = "0x29CAF40", VA = "0x1829CBF40")]
	static CFEANDEOONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x29CDDE0", Offset = "0x29CCDE0", VA = "0x1829CDDE0")]
	public CFEANDEOONP(bool IIIKGJKIMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x29C88D0", Offset = "0x29C78D0", VA = "0x1829C88D0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x29C7360", Offset = "0x29C6360", VA = "0x1829C7360", Slot = "5")]
	public T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x29C8750", Offset = "0x29C7750", VA = "0x1829C8750", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x29C83C0", Offset = "0x29C73C0", VA = "0x1829C83C0", Slot = "7")]
	public T CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class FGLLCADMNPP<T> : global::KBIOLGDHIDG<T[,]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x304C950", Offset = "0x304B950", VA = "0x18304C950", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T[,] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x304C680", Offset = "0x304B680", VA = "0x18304C680", Slot = "5")]
	public T[,] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	public FGLLCADMNPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DIKCHKIELPC<T> : global::KBIOLGDHIDG<T[,,]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x28D5370", Offset = "0x28D4370", VA = "0x1828D5370", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T[,,] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x28D4F90", Offset = "0x28D3F90", VA = "0x1828D4F90", Slot = "5")]
	public T[,,] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	public DIKCHKIELPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class KEAIHAGCPEJ<T> : global::KBIOLGDHIDG<T[,,,]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x347F1B0", Offset = "0x347E1B0", VA = "0x18347F1B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T[,,,] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x347ECB0", Offset = "0x347DCB0", VA = "0x18347ECB0", Slot = "5")]
	public T[,,,] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	public KEAIHAGCPEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class HJDLPFHNJPM<T> : global::KBIOLGDHIDG<T?>, CDJJKNODMKB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2E43E90", Offset = "0x2E42E90", VA = "0x182E43E90", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2E43BE0", Offset = "0x2E42BE0", VA = "0x182E43BE0", Slot = "5")]
	public T? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	public HJDLPFHNJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class IFFPMBNEBGM<T> : global::KBIOLGDHIDG<T?>, CDJJKNODMKB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::KBIOLGDHIDG<T> JDECILKNLKP;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E22D40", Offset = "0x1E21D40", VA = "0x181E22D40")]
	public IFFPMBNEBGM(global::KBIOLGDHIDG<T> JDECILKNLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x22538D0", Offset = "0x22528D0", VA = "0x1822538D0")]
	public IFFPMBNEBGM(Type APEBNIBGLGL, object[] JCAEACPDBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2252DF0", Offset = "0x2251DF0", VA = "0x182252DF0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x22527F0", Offset = "0x22517F0", VA = "0x1822527F0", Slot = "5")]
	public T? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class EDNEICAOPLN : global::KBIOLGDHIDG<sbyte>, CDJJKNODMKB, global::NKJJGAMHDGI<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly EDNEICAOPLN DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E4F0", Offset = "0x4B0D4F0", VA = "0x184B0E4F0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E420", Offset = "0x4B0D420", VA = "0x184B0E420", Slot = "5")]
	public sbyte CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E4B0", Offset = "0x4B0D4B0", VA = "0x184B0E4B0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E430", Offset = "0x4B0D430", VA = "0x184B0E430", Slot = "7")]
	public sbyte CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public EDNEICAOPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class NJOOPAOMNCD : global::KBIOLGDHIDG<sbyte?>, CDJJKNODMKB, global::NKJJGAMHDGI<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly NJOOPAOMNCD DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E71380", Offset = "0x4E70380", VA = "0x184E71380", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4E711D0", Offset = "0x4E701D0", VA = "0x184E711D0", Slot = "5")]
	public sbyte? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4E71300", Offset = "0x4E70300", VA = "0x184E71300", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E71240", Offset = "0x4E70240", VA = "0x184E71240", Slot = "7")]
	public sbyte? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public NJOOPAOMNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class MHJKMLHCLBG : global::KBIOLGDHIDG<sbyte[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly MHJKMLHCLBG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FB50", Offset = "0x4E6EB50", VA = "0x184E6FB50", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FA10", Offset = "0x4E6EA10", VA = "0x184E6FA10", Slot = "5")]
	public sbyte[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MHJKMLHCLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class MJMMJGIOKLE : global::KBIOLGDHIDG<short>, CDJJKNODMKB, global::NKJJGAMHDGI<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly MJMMJGIOKLE DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FD40", Offset = "0x4E6ED40", VA = "0x184E6FD40", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, short DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FC70", Offset = "0x4E6EC70", VA = "0x184E6FC70", Slot = "5")]
	public short CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FD00", Offset = "0x4E6ED00", VA = "0x184E6FD00", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, short DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FC80", Offset = "0x4E6EC80", VA = "0x184E6FC80", Slot = "7")]
	public short CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MJMMJGIOKLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class IENCAAFOJJE : global::KBIOLGDHIDG<short?>, CDJJKNODMKB, global::NKJJGAMHDGI<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly IENCAAFOJJE DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x4B747B0", Offset = "0x4B737B0", VA = "0x184B747B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, short? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4B74500", Offset = "0x4B73500", VA = "0x184B74500", Slot = "5")]
	public short? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4B746A0", Offset = "0x4B736A0", VA = "0x184B746A0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, short? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4B745B0", Offset = "0x4B735B0", VA = "0x184B745B0", Slot = "7")]
	public short? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public IENCAAFOJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class IAPODJNOLFK : global::KBIOLGDHIDG<short[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly IAPODJNOLFK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x4B74230", Offset = "0x4B73230", VA = "0x184B74230", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, short[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4B74000", Offset = "0x4B73000", VA = "0x184B74000", Slot = "5")]
	public short[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public IAPODJNOLFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class AMNCIOLBIKO : global::KBIOLGDHIDG<int>, CDJJKNODMKB, global::NKJJGAMHDGI<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly AMNCIOLBIKO DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4B028B0", Offset = "0x4B018B0", VA = "0x184B028B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, int DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4B027E0", Offset = "0x4B017E0", VA = "0x184B027E0", Slot = "5")]
	public int CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B02870", Offset = "0x4B01870", VA = "0x184B02870", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, int DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B027F0", Offset = "0x4B017F0", VA = "0x184B027F0", Slot = "7")]
	public int CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public AMNCIOLBIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JGCOBBIIIJP : global::KBIOLGDHIDG<int?>, CDJJKNODMKB, global::NKJJGAMHDGI<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly JGCOBBIIIJP DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4B78BE0", Offset = "0x4B77BE0", VA = "0x184B78BE0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, int? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B78930", Offset = "0x4B77930", VA = "0x184B78930", Slot = "5")]
	public int? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4B78AD0", Offset = "0x4B77AD0", VA = "0x184B78AD0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, int? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4B789E0", Offset = "0x4B779E0", VA = "0x184B789E0", Slot = "7")]
	public int? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public JGCOBBIIIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class HOMBJPGGDNP : global::KBIOLGDHIDG<int[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly HOMBJPGGDNP DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4B73BC0", Offset = "0x4B72BC0", VA = "0x184B73BC0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, int[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4B73990", Offset = "0x4B72990", VA = "0x184B73990", Slot = "5")]
	public int[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public HOMBJPGGDNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class IAHICOEHPGE : global::KBIOLGDHIDG<long>, CDJJKNODMKB, global::NKJJGAMHDGI<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly IAHICOEHPGE DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x4B73F70", Offset = "0x4B72F70", VA = "0x184B73F70", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, long DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x4B73DC0", Offset = "0x4B72DC0", VA = "0x184B73DC0", Slot = "5")]
	public long CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x4B73EB0", Offset = "0x4B72EB0", VA = "0x184B73EB0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, long DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x4B73DD0", Offset = "0x4B72DD0", VA = "0x184B73DD0", Slot = "7")]
	public long CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public IAHICOEHPGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class LMCJPFKJFOK : global::KBIOLGDHIDG<long?>, CDJJKNODMKB, global::NKJJGAMHDGI<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly LMCJPFKJFOK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x4B80EC0", Offset = "0x4B7FEC0", VA = "0x184B80EC0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, long? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x4B80BD0", Offset = "0x4B7FBD0", VA = "0x184B80BD0", Slot = "5")]
	public long? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x4B80DB0", Offset = "0x4B7FDB0", VA = "0x184B80DB0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, long? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x4B80C60", Offset = "0x4B7FC60", VA = "0x184B80C60", Slot = "7")]
	public long? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LMCJPFKJFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class FBMFKHKNAMI : global::KBIOLGDHIDG<long[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly FBMFKHKNAMI DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x4B19FF0", Offset = "0x4B18FF0", VA = "0x184B19FF0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, long[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4B19EB0", Offset = "0x4B18EB0", VA = "0x184B19EB0", Slot = "5")]
	public long[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FBMFKHKNAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class FKLNOPBIHIK : global::KBIOLGDHIDG<byte>, CDJJKNODMKB, global::NKJJGAMHDGI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly FKLNOPBIHIK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x4B6A050", Offset = "0x4B69050", VA = "0x184B6A050", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, byte DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x4B69E80", Offset = "0x4B68E80", VA = "0x184B69E80", Slot = "5")]
	public byte CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4B69F90", Offset = "0x4B68F90", VA = "0x184B69F90", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, byte DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4B69EE0", Offset = "0x4B68EE0", VA = "0x184B69EE0", Slot = "7")]
	public byte CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FKLNOPBIHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class MMJKNOEPHFH : global::KBIOLGDHIDG<byte?>, CDJJKNODMKB, global::NKJJGAMHDGI<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly MMJKNOEPHFH DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4E703C0", Offset = "0x4E6F3C0", VA = "0x184E703C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, byte? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4E70210", Offset = "0x4E6F210", VA = "0x184E70210", Slot = "5")]
	public byte? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4E70340", Offset = "0x4E6F340", VA = "0x184E70340", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, byte? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4E70280", Offset = "0x4E6F280", VA = "0x184E70280", Slot = "7")]
	public byte? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MMJKNOEPHFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class CCMEODLFNPD : global::KBIOLGDHIDG<ushort>, CDJJKNODMKB, global::NKJJGAMHDGI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly CCMEODLFNPD DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x4B07D00", Offset = "0x4B06D00", VA = "0x184B07D00", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ushort DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4B07C30", Offset = "0x4B06C30", VA = "0x184B07C30", Slot = "5")]
	public ushort CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4B07CC0", Offset = "0x4B06CC0", VA = "0x184B07CC0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, ushort DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4B07C40", Offset = "0x4B06C40", VA = "0x184B07C40", Slot = "7")]
	public ushort CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CCMEODLFNPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class MLMKAEEIJIN : global::KBIOLGDHIDG<ushort?>, CDJJKNODMKB, global::NKJJGAMHDGI<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly MLMKAEEIJIN DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x4E70130", Offset = "0x4E6F130", VA = "0x184E70130", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ushort? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FF80", Offset = "0x4E6EF80", VA = "0x184E6FF80", Slot = "5")]
	public ushort? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4E700B0", Offset = "0x4E6F0B0", VA = "0x184E700B0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, ushort? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FFF0", Offset = "0x4E6EFF0", VA = "0x184E6FFF0", Slot = "7")]
	public ushort? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MLMKAEEIJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class CBKNLIDJADJ : global::KBIOLGDHIDG<ushort[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly CBKNLIDJADJ DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x4B07B10", Offset = "0x4B06B10", VA = "0x184B07B10", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ushort[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4B079D0", Offset = "0x4B069D0", VA = "0x184B079D0", Slot = "5")]
	public ushort[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CBKNLIDJADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class PADKJPKAKON : global::KBIOLGDHIDG<uint>, CDJJKNODMKB, global::NKJJGAMHDGI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly PADKJPKAKON DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x4E72840", Offset = "0x4E71840", VA = "0x184E72840", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, uint DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4E72770", Offset = "0x4E71770", VA = "0x184E72770", Slot = "5")]
	public uint CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4E72800", Offset = "0x4E71800", VA = "0x184E72800", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, uint DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4E72780", Offset = "0x4E71780", VA = "0x184E72780", Slot = "7")]
	public uint CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public PADKJPKAKON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class AGPGDKNEPAO : global::KBIOLGDHIDG<uint?>, CDJJKNODMKB, global::NKJJGAMHDGI<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly AGPGDKNEPAO DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x4B01B10", Offset = "0x4B00B10", VA = "0x184B01B10", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, uint? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4B01960", Offset = "0x4B00960", VA = "0x184B01960", Slot = "5")]
	public uint? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4B01A90", Offset = "0x4B00A90", VA = "0x184B01A90", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, uint? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4B019D0", Offset = "0x4B009D0", VA = "0x184B019D0", Slot = "7")]
	public uint? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public AGPGDKNEPAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class CNOGOHIGMCI : global::KBIOLGDHIDG<uint[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly CNOGOHIGMCI DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CB60", Offset = "0x4B0BB60", VA = "0x184B0CB60", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, uint[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CA20", Offset = "0x4B0BA20", VA = "0x184B0CA20", Slot = "5")]
	public uint[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CNOGOHIGMCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class DCCKCCPDOHN : global::KBIOLGDHIDG<ulong>, CDJJKNODMKB, global::NKJJGAMHDGI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly DCCKCCPDOHN DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E170", Offset = "0x4B0D170", VA = "0x184B0E170", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ulong DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E0A0", Offset = "0x4B0D0A0", VA = "0x184B0E0A0", Slot = "5")]
	public ulong CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E130", Offset = "0x4B0D130", VA = "0x184B0E130", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, ulong DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E0B0", Offset = "0x4B0D0B0", VA = "0x184B0E0B0", Slot = "7")]
	public ulong CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public DCCKCCPDOHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class JDPEFOGPFOJ : global::KBIOLGDHIDG<ulong?>, CDJJKNODMKB, global::NKJJGAMHDGI<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly JDPEFOGPFOJ DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x4B78540", Offset = "0x4B77540", VA = "0x184B78540", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ulong? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x4B782C0", Offset = "0x4B772C0", VA = "0x184B782C0", Slot = "5")]
	public ulong? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x4B78430", Offset = "0x4B77430", VA = "0x184B78430", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, ulong? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4B78350", Offset = "0x4B77350", VA = "0x184B78350", Slot = "7")]
	public ulong? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public JDPEFOGPFOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class EIAANOBEJPD : global::KBIOLGDHIDG<ulong[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly EIAANOBEJPD DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x4B18AE0", Offset = "0x4B17AE0", VA = "0x184B18AE0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ulong[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4B189A0", Offset = "0x4B179A0", VA = "0x184B189A0", Slot = "5")]
	public ulong[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public EIAANOBEJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class OCCBHAOIDLK : global::KBIOLGDHIDG<float>, CDJJKNODMKB, global::NKJJGAMHDGI<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly OCCBHAOIDLK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x4E71530", Offset = "0x4E70530", VA = "0x184E71530", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, float DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x4E71460", Offset = "0x4E70460", VA = "0x184E71460", Slot = "5")]
	public float CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x4E714F0", Offset = "0x4E704F0", VA = "0x184E714F0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, float DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4E71470", Offset = "0x4E70470", VA = "0x184E71470", Slot = "7")]
	public float CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public OCCBHAOIDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class GKFFMICIECH : global::KBIOLGDHIDG<float?>, CDJJKNODMKB, global::NKJJGAMHDGI<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly GKFFMICIECH DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D000", Offset = "0x4B6C000", VA = "0x184B6D000", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, float? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x4B6CDA0", Offset = "0x4B6BDA0", VA = "0x184B6CDA0", Slot = "5")]
	public float? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x4B6CF00", Offset = "0x4B6BF00", VA = "0x184B6CF00", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, float? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4B6CE10", Offset = "0x4B6BE10", VA = "0x184B6CE10", Slot = "7")]
	public float? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GKFFMICIECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class OPHFILKIOFK : global::KBIOLGDHIDG<float[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly OPHFILKIOFK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x4E72650", Offset = "0x4E71650", VA = "0x184E72650", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, float[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4E72510", Offset = "0x4E71510", VA = "0x184E72510", Slot = "5")]
	public float[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public OPHFILKIOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class PFKCJCFEEDI : global::KBIOLGDHIDG<double>, CDJJKNODMKB, global::NKJJGAMHDGI<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly PFKCJCFEEDI DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x4E73080", Offset = "0x4E72080", VA = "0x184E73080", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, double DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x4E72FB0", Offset = "0x4E71FB0", VA = "0x184E72FB0", Slot = "5")]
	public double CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4E73040", Offset = "0x4E72040", VA = "0x184E73040", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, double DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4E72FC0", Offset = "0x4E71FC0", VA = "0x184E72FC0", Slot = "7")]
	public double CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public PFKCJCFEEDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class GGEAEEBMCMA : global::KBIOLGDHIDG<double?>, CDJJKNODMKB, global::NKJJGAMHDGI<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly GGEAEEBMCMA DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x4B6BEE0", Offset = "0x4B6AEE0", VA = "0x184B6BEE0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, double? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x4B6BBB0", Offset = "0x4B6ABB0", VA = "0x184B6BBB0", Slot = "5")]
	public double? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x4B6BDD0", Offset = "0x4B6ADD0", VA = "0x184B6BDD0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, double? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x4B6BC40", Offset = "0x4B6AC40", VA = "0x184B6BC40", Slot = "7")]
	public double? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GGEAEEBMCMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class KDBBEOBGEAG : global::KBIOLGDHIDG<double[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly KDBBEOBGEAG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BCD0", Offset = "0x4B7ACD0", VA = "0x184B7BCD0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, double[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BAA0", Offset = "0x4B7AAA0", VA = "0x184B7BAA0", Slot = "5")]
	public double[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KDBBEOBGEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class CFCEFGJKNFK : global::KBIOLGDHIDG<bool>, CDJJKNODMKB, global::NKJJGAMHDGI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly CFCEFGJKNFK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4B07F30", Offset = "0x4B06F30", VA = "0x184B07F30", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, bool DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4B07E60", Offset = "0x4B06E60", VA = "0x184B07E60", Slot = "5")]
	public bool CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4B07EF0", Offset = "0x4B06EF0", VA = "0x184B07EF0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, bool DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4B07E70", Offset = "0x4B06E70", VA = "0x184B07E70", Slot = "7")]
	public bool CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CFCEFGJKNFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class KIECLGEDMMF : global::KBIOLGDHIDG<bool?>, CDJJKNODMKB, global::NKJJGAMHDGI<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly KIECLGEDMMF DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C340", Offset = "0x4B7B340", VA = "0x184B7C340", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, bool? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C110", Offset = "0x4B7B110", VA = "0x184B7C110", Slot = "5")]
	public bool? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C240", Offset = "0x4B7B240", VA = "0x184B7C240", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, bool? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C180", Offset = "0x4B7B180", VA = "0x184B7C180", Slot = "7")]
	public bool? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KIECLGEDMMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class JLKHOJGAILI : global::KBIOLGDHIDG<bool[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly JLKHOJGAILI DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AAC0", Offset = "0x4B79AC0", VA = "0x184B7AAC0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, bool[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A890", Offset = "0x4B79890", VA = "0x184B7A890", Slot = "5")]
	public bool[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public JLKHOJGAILI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GBPKEEACNAN : global::KBIOLGDHIDG<object>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::KBIOLGDHIDG<object> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> PMDNOMEDOFK;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4B6A9D0", Offset = "0x4B699D0", VA = "0x184B6A9D0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4B6A560", Offset = "0x4B69560", VA = "0x184B6A560", Slot = "5")]
	public object CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GBPKEEACNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class LKNNIAJDCBA : global::KBIOLGDHIDG<byte[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::KBIOLGDHIDG<byte[]> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x4B809B0", Offset = "0x4B7F9B0", VA = "0x184B809B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, byte[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4B80930", Offset = "0x4B7F930", VA = "0x184B80930", Slot = "5")]
	public byte[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LKNNIAJDCBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class LFANCPLPPNF : global::KBIOLGDHIDG<ArraySegment<byte>>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::KBIOLGDHIDG<ArraySegment<byte>> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EA00", Offset = "0x4B7DA00", VA = "0x184B7EA00", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ArraySegment<byte> DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E920", Offset = "0x4B7D920", VA = "0x184B7E920", Slot = "5")]
	public ArraySegment<byte> CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LFANCPLPPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class OJOAHCLPCOF : global::KBIOLGDHIDG<string>, CDJJKNODMKB, global::NKJJGAMHDGI<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::KBIOLGDHIDG<string> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x4E72490", Offset = "0x4E71490", VA = "0x184E72490", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, string DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4E72480", Offset = "0x4E71480", VA = "0x184E72480", Slot = "5")]
	public string CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4E72490", Offset = "0x4E71490", VA = "0x184E72490", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, string DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4E72480", Offset = "0x4E71480", VA = "0x184E72480", Slot = "7")]
	public string CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public OJOAHCLPCOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class PGJLBADOMPO : global::KBIOLGDHIDG<string[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly PGJLBADOMPO DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4E73380", Offset = "0x4E72380", VA = "0x184E73380", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, string[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4E73210", Offset = "0x4E72210", VA = "0x184E73210", Slot = "5")]
	public string[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public PGJLBADOMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class BCBBPNLGOPB : global::KBIOLGDHIDG<char>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly BCBBPNLGOPB DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4B02950", Offset = "0x4B01950", VA = "0x184B02950", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, char DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4B02920", Offset = "0x4B01920", VA = "0x184B02920", Slot = "5")]
	public char CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public BCBBPNLGOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class NJLHLLFNLFD : global::KBIOLGDHIDG<char?>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly NJLHLLFNLFD DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4E71080", Offset = "0x4E70080", VA = "0x184E71080", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, char? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4E70FB0", Offset = "0x4E6FFB0", VA = "0x184E70FB0", Slot = "5")]
	public char? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public NJLHLLFNLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class MAAGJDNFKND : global::KBIOLGDHIDG<char[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly MAAGJDNFKND DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x4B811B0", Offset = "0x4B801B0", VA = "0x184B811B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, char[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4B80FB0", Offset = "0x4B7FFB0", VA = "0x184B80FB0", Slot = "5")]
	public char[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MAAGJDNFKND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class KJCCOIBPJLO : global::KBIOLGDHIDG<Guid>, CDJJKNODMKB, global::NKJJGAMHDGI<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::KBIOLGDHIDG<Guid> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C4A0", Offset = "0x4B7B4A0", VA = "0x184B7C4A0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Guid DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C420", Offset = "0x4B7B420", VA = "0x184B7C420", Slot = "5")]
	public Guid CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C470", Offset = "0x4B7B470", VA = "0x184B7C470", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, Guid DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C420", Offset = "0x4B7B420", VA = "0x184B7C420", Slot = "7")]
	public Guid CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJCCOIBPJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class PPKCBIFPLLP : global::KBIOLGDHIDG<decimal>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::KBIOLGDHIDG<decimal> DCLACCPOJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool GCEJMIBDCMF;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x84CBF0", Offset = "0x84BBF0", VA = "0x18084CBF0")]
	public PPKCBIFPLLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x14C89C0", Offset = "0x14C79C0", VA = "0x1814C89C0")]
	public PPKCBIFPLLP(bool GCEJMIBDCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x4E76930", Offset = "0x4E75930", VA = "0x184E76930", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, decimal DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x4E76700", Offset = "0x4E75700", VA = "0x184E76700", Slot = "5")]
	public decimal CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class GKLOANBOMOG : global::KBIOLGDHIDG<Uri>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::KBIOLGDHIDG<Uri> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D160", Offset = "0x4B6C160", VA = "0x184B6D160", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Uri DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D0E0", Offset = "0x4B6C0E0", VA = "0x184B6D0E0", Slot = "5")]
	public Uri CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GKLOANBOMOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class HKCHCHBKLJH : global::KBIOLGDHIDG<Version>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::KBIOLGDHIDG<Version> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x4B72820", Offset = "0x4B71820", VA = "0x184B72820", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Version DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4B727A0", Offset = "0x4B717A0", VA = "0x184B727A0", Slot = "5")]
	public Version CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public HKCHCHBKLJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class NKICGLOMIPE<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class LMCCLJPIHFB : global::KBIOLGDHIDG<StringBuilder>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::KBIOLGDHIDG<StringBuilder> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B80B20", Offset = "0x4B7FB20", VA = "0x184B80B20", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, StringBuilder DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B80AA0", Offset = "0x4B7FAA0", VA = "0x184B80AA0", Slot = "5")]
	public StringBuilder CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LMCCLJPIHFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class CLMEAFLOCKF : global::KBIOLGDHIDG<BitArray>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::KBIOLGDHIDG<BitArray> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B0AE00", Offset = "0x4B09E00", VA = "0x184B0AE00", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, BitArray DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4B0ACE0", Offset = "0x4B09CE0", VA = "0x184B0ACE0", Slot = "5")]
	public BitArray CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CLMEAFLOCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class HKBKJLOILLP : global::KBIOLGDHIDG<Type>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly HKBKJLOILLP DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex MFDKAAMIIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool BOKGFINFPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool KGKEOGACIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool NPBFACFCDLB;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x4B72780", Offset = "0x4B71780", VA = "0x184B72780")]
	public HKBKJLOILLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B72730", Offset = "0x4B71730", VA = "0x184B72730")]
	public HKBKJLOILLP(bool BOKGFINFPNG, bool KGKEOGACIGB, bool NPBFACFCDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x4B72580", Offset = "0x4B71580", VA = "0x184B72580", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Type DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x4B72450", Offset = "0x4B71450", VA = "0x184B72450", Slot = "5")]
	public Type CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
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
