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
public class JAOCPNLBGPF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
	public JAOCPNLBGPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class DDJEMGOIBKB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
	public DDJEMGOIBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IMJJJDMJDFE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
	public IMJJJDMJDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JNMGGIFPILP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
	public JNMGGIFPILP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class MHPACJDBJCH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4F16870", Offset = "0x4F15670", VA = "0x184F16870")]
	public static bool NCLOEOMJOHL(this TypeInfo NKICFHCCMMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class EMCJAAPEPMM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type EIFFJCDBAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x675F30", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DBBDPLHFPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6726F0", Offset = "0x6714F0", VA = "0x1806726F0")]
	public EMCJAAPEPMM(Type HDCINCHPFJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class PILGOHMFNLN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void LKJCMEODDFK<T>(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T LFJEGKAKEAB<T>(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA HGOBEINKIPD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface INIKLHPPANG
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JNNOLJAFELM<T> : INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HHCAMMEJFNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NEHADIAKNBK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JNNOLJAFELM<T> IMMPCOIBHEB<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BIKCHCALEIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x25E19D0", Offset = "0x25E07D0", VA = "0x1825E19D0")]
	public static global::JNNOLJAFELM<T> BJMFONPJKFC<T>(this LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x412F8F0", Offset = "0x412E6F0", VA = "0x18412F8F0")]
	public static object GHNEFKFOBND(this LOKDBPMCGHA HGOBEINKIPD, Type NKICFHCCMMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LJFBOLBAABE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F15950", Offset = "0x4F14750", VA = "0x184F15950")]
	public LJFBOLBAABE(string GOJKMEMCPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JBBAGFKBPCP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class KBENAOBGGAC
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] CLABEIKAHOI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] JMFBGBBHPGO;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x51109C0", Offset = "0x510F7C0", VA = "0x1851109C0")]
		public static byte[] OJPOPNBOHID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5110930", Offset = "0x510F730", VA = "0x185110930")]
		public static char[] MCBDKCINIBH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> LDEKGGAOBGI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] KNEHOPKFLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] HFAIGCGNPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int LBACAALGKLG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool PJAJGMCKBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4F104F0", Offset = "0x4F0F2F0", VA = "0x184F104F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4F11DB0", Offset = "0x4F10BB0", VA = "0x184F11DB0")]
	public JBBAGFKBPCP(byte[] HFAIGCGNPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F11BC0", Offset = "0x4F109C0", VA = "0x184F11BC0")]
	public JBBAGFKBPCP(byte[] HFAIGCGNPJJ, int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F030", Offset = "0x4F0DE30", VA = "0x184F0F030")]
	private PBGLHKMPJKG BAPHPGOLANA(string CHPNMHOBKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F7E0", Offset = "0x4F0E5E0", VA = "0x184F0F7E0")]
	private PBGLHKMPJKG CALGIIKIFLC(string GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F10CC0", Offset = "0x4F0FAC0", VA = "0x184F10CC0")]
	public void MHOEICFHDBD(int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
	public byte[] GMGHNENLGFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85F7C0", Offset = "0x85E5C0", VA = "0x18085F7C0")]
	public int BPONLNLGFFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FC10", Offset = "0x4F0EA10", VA = "0x184F0FC10")]
	public NMDNKBAMHJH EDBLNKKPJIK()
	{
		return default(NMDNKBAMHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4F10960", Offset = "0x4F0F760", VA = "0x184F10960")]
	public void JPJNFJDEBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F650", Offset = "0x4F0E450", VA = "0x184F0F650")]
	public bool BMGOFCHECKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4F10C60", Offset = "0x4F0FA60", VA = "0x184F10C60")]
	public bool MDPLCCEBNJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FB20", Offset = "0x4F0E920", VA = "0x184F0FB20")]
	public void DBIGCFOFHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4F10D50", Offset = "0x4F0FB50", VA = "0x184F10D50")]
	public bool MMBHAEIDKOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4F10810", Offset = "0x4F0F610", VA = "0x184F10810")]
	public bool JJLDEKOPJNA(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FD90", Offset = "0x4F0EB90", VA = "0x184F0FD90")]
	public bool EJMDIIIKDEL(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4F10540", Offset = "0x4F0F340", VA = "0x184F10540")]
	public bool IEOMCIFHNHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4F10AA0", Offset = "0x4F0F8A0", VA = "0x184F10AA0")]
	public void KKLGFJHGMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FBB0", Offset = "0x4F0E9B0", VA = "0x184F0FBB0")]
	public bool DEMHLHDDDCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4F10CD0", Offset = "0x4F0FAD0", VA = "0x184F10CD0")]
	public bool MJHFGKFLELG(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FA50", Offset = "0x4F0E850", VA = "0x184F0FA50")]
	public bool CPNPFHLHIAL(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F920", Offset = "0x4F0E720", VA = "0x184F0F920")]
	public bool CMJNBJILBOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F750", Offset = "0x4F0E550", VA = "0x184F0F750")]
	public void BPOGEGJLBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4F11A60", Offset = "0x4F10860", VA = "0x184F11A60")]
	public bool PKONGHIEMEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4F10060", Offset = "0x4F0EE60", VA = "0x184F10060")]
	public void GAEBGFBEEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4F11090", Offset = "0x4F0FE90", VA = "0x184F11090")]
	private void OMIEPDAGOAC(out byte[] EPKHMOEKGLC, out int IOFHHCKLHFO, out int KCALDLLKIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F5A0", Offset = "0x4F0E3A0", VA = "0x184F0F5A0")]
	private static int BIJBALNHBIO(char BMPDKJEHGIN, char BMMLDIMMAAK, char KDPJFGIFCOL, char NAGBPGCPEDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4F10B90", Offset = "0x4F0F990", VA = "0x184F10B90")]
	private static int MDCAOGIMPAJ(char KNMKEOOODCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4F10210", Offset = "0x4F0F010", VA = "0x184F10210")]
	public ArraySegment<byte> GMEFMBJNABC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4F10770", Offset = "0x4F0F570", VA = "0x184F10770")]
	public string JIGLGCNKCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4F10510", Offset = "0x4F0F310", VA = "0x184F10510")]
	public string ICAJOBHBLFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4F105A0", Offset = "0x4F0F3A0", VA = "0x184F105A0")]
	public ArraySegment<byte> JAPIBLJDOJH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4F10DB0", Offset = "0x4F0FBB0", VA = "0x184F10DB0")]
	public ArraySegment<byte> NEALJAMHMPD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4F10DF0", Offset = "0x4F0FBF0", VA = "0x184F10DF0")]
	public bool NKLENODONFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4F10150", Offset = "0x4F0EF50", VA = "0x184F10150")]
	private static bool GIPJAOPNMEA(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F10310", Offset = "0x4F0F110", VA = "0x184F10310")]
	private void GOLEAFIJAJB(NMDNKBAMHJH MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FB10", Offset = "0x4F0E910", VA = "0x184F0FB10")]
	public void DBEKBMHDCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F10890", Offset = "0x4F0F690", VA = "0x184F10890")]
	private void JJNKMJJELHJ(int JKILKDNNGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FE50", Offset = "0x4F0EC50", VA = "0x184F0FE50")]
	public sbyte FCAFBJELBGE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4F100F0", Offset = "0x4F0EEF0", VA = "0x184F100F0")]
	public short GBGLBFEDKLJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F8C0", Offset = "0x4F0E6C0", VA = "0x184F0F8C0")]
	public int CGCLBGFIAEF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F0EFB0", Offset = "0x4F0DDB0", VA = "0x184F0EFB0")]
	public long AKPKAJHPHND()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F540", Offset = "0x4F0E340", VA = "0x184F0F540")]
	public byte BBCKHJFHBCK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F10B30", Offset = "0x4F0F930", VA = "0x184F10B30")]
	public ushort KLFEMFLOKCA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F11030", Offset = "0x4F0FE30", VA = "0x184F11030")]
	public uint NNIEICDPABA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4F119E0", Offset = "0x4F107E0", VA = "0x184F119E0")]
	public ulong PHHJMKPOOCC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FF90", Offset = "0x4F0ED90", VA = "0x184F0FF90")]
	public float FIPEPGKAELM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F980", Offset = "0x4F0E780", VA = "0x184F0F980")]
	public double COEEEHMEAOP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FEA0", Offset = "0x4F0ECA0", VA = "0x184F0FEA0")]
	public ArraySegment<byte> FGMOAFOJOOI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4F11850", Offset = "0x4F10650", VA = "0x184F11850")]
	private static int OOFLLILPMOH(byte[] HFAIGCGNPJJ, int LBACAALGKLG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PBGLHKMPJKG : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference GLJEDGMBEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int ODCKKIHJFDC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int KLLJIHKHMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xF51350", Offset = "0xF50150", VA = "0x180F51350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KACHLMCPGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8AABC0", Offset = "0x8A99C0", VA = "0x1808AABC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5117B30", Offset = "0x5116930", VA = "0x185117B30")]
	public PBGLHKMPJKG(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5117BA0", Offset = "0x51169A0", VA = "0x185117BA0")]
	public PBGLHKMPJKG(string GOJKMEMCPDE, byte[] CJDBFEALDKN, int LBACAALGKLG, int ODCKKIHJFDC, string BHNEBHMBEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PIMEBFIFGOM
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class NGEIBPLEEMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void CPFMOICBFAL(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object IHDJNDLELGK(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA HGOBEINKIPD);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class GBENGLEELEP
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class JEIEILBPOKL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
				public JEIEILBPOKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x34B1F90", Offset = "0x34B0D90", VA = "0x1834B1F90")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x5110680", Offset = "0x510F480", VA = "0x185110680")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, LOKDBPMCGHA, byte[]> KDGJKLPBNAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, LOKDBPMCGHA> PNFLKHGALAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly CPFMOICBFAL JHEKBCLFGCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, LOKDBPMCGHA, ArraySegment<byte>> CBCIKJBENHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, LOKDBPMCGHA, string> CBLJACHIBME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, LOKDBPMCGHA, object> MDCMIAGGMFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, LOKDBPMCGHA, object> HMDFCMMDMFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, LOKDBPMCGHA, object> GFCLJMAOOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly IHDJNDLELGK OBFIPEMPABD;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x510CB10", Offset = "0x510B910", VA = "0x18510CB10")]
			public GBENGLEELEP(Type NKICFHCCMMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E84C10", Offset = "0x5E83A10", VA = "0x185E84C10")]
			private static T GMICCBEHNBC<T>(DynamicMethod CGPPEMAFIJG)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x510C8C0", Offset = "0x510B6C0", VA = "0x18510C8C0")]
			private static MethodInfo IHIIONGMOJG(Type NKICFHCCMMH, string BEMAPDNKPAD, Type[] MPBBAJCIKNG)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, GBENGLEELEP> PKBCIOMAMLP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::DIEINJJIANO<GBENGLEELEP> OACOGGNOOBO;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5113520", Offset = "0x5112320", VA = "0x185113520")]
		static NGEIBPLEEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5113490", Offset = "0x5112290", VA = "0x185113490")]
		private static GBENGLEELEP NOCCDIAEOGP(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x51131E0", Offset = "0x5111FE0", VA = "0x1851131E0")]
		public static void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5113370", Offset = "0x5112170", VA = "0x185113370")]
		public static void DGAMFOBEJMM(Type NKICFHCCMMH, ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class FEDNCBBHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] CLABEIKAHOI;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x510A8C0", Offset = "0x51096C0", VA = "0x18510A8C0")]
		public static byte[] OJPOPNBOHID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static LOKDBPMCGHA EGFLNPKIJAD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] GPCDLKJMMCL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] JLJKHHBNEFC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static LOKDBPMCGHA PPPLLABPEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51187A0", Offset = "0x51175A0", VA = "0x1851187A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FLBGIACDMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5118740", Offset = "0x5117540", VA = "0x185118740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5118960", Offset = "0x5117760", VA = "0x185118960")]
	public static void NCDFCANDEKP(LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x30A1030", Offset = "0x309FE30", VA = "0x1830A1030")]
	public static byte[] DGAMFOBEJMM<T>(T CCPIHKCBGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x30A0E40", Offset = "0x309FC40", VA = "0x1830A0E40")]
	public static byte[] DGAMFOBEJMM<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30A0FA0", Offset = "0x309FDA0", VA = "0x1830A0FA0")]
	public static void DGAMFOBEJMM<T>(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30A0D60", Offset = "0x309FB60", VA = "0x1830A0D60")]
	public static void DGAMFOBEJMM<T>(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x30A11D0", Offset = "0x309FFD0", VA = "0x1830A11D0")]
	public static void DGAMFOBEJMM<T>(Stream KCFDLMABGLC, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x30A10B0", Offset = "0x309FEB0", VA = "0x1830A10B0")]
	public static void DGAMFOBEJMM<T>(Stream KCFDLMABGLC, T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x30A0CC0", Offset = "0x309FAC0", VA = "0x1830A0CC0")]
	public static ArraySegment<byte> BKHPEFINPDB<T>(T CCPIHKCBGHF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x30A0B40", Offset = "0x309F940", VA = "0x1830A0B40")]
	public static ArraySegment<byte> BKHPEFINPDB<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x30A2680", Offset = "0x30A1480", VA = "0x1830A2680")]
	public static string LDBAPCDBCDE<T>(T IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x30A2700", Offset = "0x30A1500", VA = "0x1830A2700")]
	public static string LDBAPCDBCDE<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30A1BC0", Offset = "0x30A09C0", VA = "0x1830A1BC0")]
	public static T HJFKJCGGCHL<T>(string IKGKCMLCBEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x30A1E60", Offset = "0x30A0C60", VA = "0x1830A1E60")]
	public static T HJFKJCGGCHL<T>(string IKGKCMLCBEH, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x30A23F0", Offset = "0x30A11F0", VA = "0x1830A23F0")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x30A1C60", Offset = "0x30A0A60", VA = "0x1830A1C60")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x30A2470", Offset = "0x30A1270", VA = "0x1830A2470")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, int LBACAALGKLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x30A1D00", Offset = "0x30A0B00", VA = "0x1830A1D00")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, int LBACAALGKLG, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x30A2160", Offset = "0x30A0F60", VA = "0x1830A2160")]
	public static T HJFKJCGGCHL<T>(ref JBBAGFKBPCP ANKKMEDLEHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x30A1F50", Offset = "0x30A0D50", VA = "0x1830A1F50")]
	public static T HJFKJCGGCHL<T>(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x30A2580", Offset = "0x30A1380", VA = "0x1830A2580")]
	public static T HJFKJCGGCHL<T>(Stream KCFDLMABGLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x30A21E0", Offset = "0x30A0FE0", VA = "0x1830A21E0")]
	public static T HJFKJCGGCHL<T>(Stream KCFDLMABGLC, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51180C0", Offset = "0x5116EC0", VA = "0x1851180C0")]
	public static string BADPDEGNDFN(byte[] IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x51181A0", Offset = "0x5116FA0", VA = "0x1851181A0")]
	public static string BADPDEGNDFN(byte[] IKGKCMLCBEH, int LBACAALGKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5117FF0", Offset = "0x5116DF0", VA = "0x185117FF0")]
	public static string BADPDEGNDFN(string IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x51189D0", Offset = "0x51177D0", VA = "0x1851189D0")]
	public static byte[] NLNJOHGDHLI(byte[] IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5118B80", Offset = "0x5117980", VA = "0x185118B80")]
	public static byte[] NLNJOHGDHLI(byte[] IKGKCMLCBEH, int LBACAALGKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5118AB0", Offset = "0x51178B0", VA = "0x185118AB0")]
	public static byte[] NLNJOHGDHLI(string IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5118250", Offset = "0x5117050", VA = "0x185118250")]
	private static void DJAPCJDBINP(ref JBBAGFKBPCP ANKKMEDLEHC, ref KOGPHPAEDLF MLMFBHHJDGG, int MOLGFCBNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51188C0", Offset = "0x51176C0", VA = "0x1851188C0")]
	private static int NAFFKJCBMOH(Stream GGHGPHKIOAE, ref byte[] CLABEIKAHOI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NMDNKBAMHJH : byte
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
public struct KOGPHPAEDLF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] ILLKIHFEFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] CLABEIKAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int LBACAALGKLG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IGPFIOMICDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C0", Offset = "0x85E5C0", VA = "0x18085F7C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4F10CC0", Offset = "0x4F0FAC0", VA = "0x184F10CC0")]
	public void MHOEICFHDBD(int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4F14E00", Offset = "0x4F13C00", VA = "0x184F14E00")]
	public static byte[] PFFPMGLMNKM(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4F143F0", Offset = "0x4F131F0", VA = "0x184F143F0")]
	public static byte[] HMMNKHOIIGI(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4F14CC0", Offset = "0x4F13AC0", VA = "0x184F14CC0")]
	public static byte[] OPMEIJFJIMK(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4F14150", Offset = "0x4F12F50", VA = "0x184F14150")]
	public static byte[] FNNMDLAEGOA(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xB703B0", Offset = "0xB6F1B0", VA = "0x180B703B0")]
	public KOGPHPAEDLF(byte[] JALDPIKJPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4F14C10", Offset = "0x4F13A10", VA = "0x184F14C10")]
	public ArraySegment<byte> OJPOPNBOHID()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4F14370", Offset = "0x4F13170", VA = "0x184F14370")]
	public byte[] HEFOPHLAPJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4F14F80", Offset = "0x4F13D80", VA = "0x184F14F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4F14960", Offset = "0x4F13760", VA = "0x184F14960")]
	public void JHOPBBOOCLA(int GIDHOGLCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4F128C0", Offset = "0x4F116C0", VA = "0x184F128C0")]
	public void NMHKAPAJACH(byte GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4F14BB0", Offset = "0x4F139B0", VA = "0x184F14BB0")]
	public void NMHKAPAJACH(byte[] GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4F14B10", Offset = "0x4F13910", VA = "0x184F14B10")]
	public void MOLJKIMFMPH(byte GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4F14A90", Offset = "0x4F13890", VA = "0x184F14A90")]
	public void LDMMPHGOIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4F14020", Offset = "0x4F12E20", VA = "0x184F14020")]
	public void EEFEAAAPEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4F14A40", Offset = "0x4F13840", VA = "0x184F14A40")]
	public void LBNNBDPCDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4F14F30", Offset = "0x4F13D30", VA = "0x184F14F30")]
	public void PPKOCOLAHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4F14EE0", Offset = "0x4F13CE0", VA = "0x184F14EE0")]
	public void PMPLPLANEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4F13FA0", Offset = "0x4F12DA0", VA = "0x184F13FA0")]
	public void CPBAKJNJINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F14070", Offset = "0x4F12E70", VA = "0x184F14070")]
	public void EILJLMDMNKK(string JLHBKPIPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4F14320", Offset = "0x4F13120", VA = "0x184F14320")]
	public void GHGOIIJGNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4F14970", Offset = "0x4F13770", VA = "0x184F14970")]
	public void KGAKMFFKNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F13DB0", Offset = "0x4F12BB0", VA = "0x184F13DB0")]
	public void CHFDGNHALIE(bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4F142A0", Offset = "0x4F130A0", VA = "0x184F142A0")]
	public void FNOGHMDBDEL(float IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F140D0", Offset = "0x4F12ED0", VA = "0x184F140D0")]
	public void EPBJIIIEMKA(double IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F13D50", Offset = "0x4F12B50", VA = "0x184F13D50")]
	public void BKGDHPNPAMF(byte IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F13D80", Offset = "0x4F12B80", VA = "0x184F13D80")]
	public void CEALBOJAPHG(ushort IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F14900", Offset = "0x4F13700", VA = "0x184F14900")]
	public void IDNCAIDOKMG(uint IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F13FF0", Offset = "0x4F12DF0", VA = "0x184F13FF0")]
	public void DBMGIHAEODI(ulong IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F14AE0", Offset = "0x4F138E0", VA = "0x184F14AE0")]
	public void LNJJBAFCKCP(sbyte IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4F14930", Offset = "0x4F13730", VA = "0x184F14930")]
	public void IPFPLOLDINI(short IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4F14B50", Offset = "0x4F13950", VA = "0x184F14B50")]
	public void NDLKPLAIPFH(int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4F14B80", Offset = "0x4F13980", VA = "0x184F14B80")]
	public void NJBGPAHMPKF(long IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4F14530", Offset = "0x4F13330", VA = "0x184F14530")]
	public void HNAAGPLPIGJ(string IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FPJKPJCPPNG : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class FLNNKMACJBH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x266E3C0", Offset = "0x266D1C0", VA = "0x18266E3C0")]
		static FLNNKMACJBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private FPJKPJCPPNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class EDPMACDGMLG
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> OMMBLPLAPFA;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4136A50", Offset = "0x4135850", VA = "0x184136A50")]
	static EDPMACDGMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4136340", Offset = "0x4135140", VA = "0x184136340")]
	internal static object IMMPCOIBHEB(Type MGEGOIPHNMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GBGIFKGBGBH : global::JNNOLJAFELM<Vector2>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LEFEBFDEKGG ELHFHNGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] MJBFKMMMMMF;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4F08940", Offset = "0x4F07740", VA = "0x184F08940")]
	public GBGIFKGBGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4F08440", Offset = "0x4F07240", VA = "0x184F08440", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector2 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4F085F0", Offset = "0x4F073F0", VA = "0x184F085F0", Slot = "5")]
	public Vector2 HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BHGNPGKFCBA : global::JNNOLJAFELM<Vector3>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LEFEBFDEKGG ELHFHNGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] MJBFKMMMMMF;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x412F650", Offset = "0x412E450", VA = "0x18412F650")]
	public BHGNPGKFCBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x412F370", Offset = "0x412E170", VA = "0x18412F370", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector3 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x412F490", Offset = "0x412E290", VA = "0x18412F490", Slot = "5")]
	public Vector3 HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BFGOMBAKMOO : global::JNNOLJAFELM<Vector4>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly LEFEBFDEKGG ELHFHNGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] MJBFKMMMMMF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x412EC60", Offset = "0x412DA60", VA = "0x18412EC60")]
	public BFGOMBAKMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x412E8F0", Offset = "0x412D6F0", VA = "0x18412E8F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector4 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x412EA40", Offset = "0x412D840", VA = "0x18412EA40", Slot = "5")]
	public Vector4 HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CMIMAJPBIAG : global::JNNOLJAFELM<Quaternion>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LEFEBFDEKGG ELHFHNGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] MJBFKMMMMMF;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4131820", Offset = "0x4130620", VA = "0x184131820")]
	public CMIMAJPBIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x412E8F0", Offset = "0x412D6F0", VA = "0x18412E8F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Quaternion IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4131600", Offset = "0x4130400", VA = "0x184131600", Slot = "5")]
	public Quaternion HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class IFDHKELCIII : global::JNNOLJAFELM<Color>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LEFEBFDEKGG ELHFHNGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] MJBFKMMMMMF;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D090", Offset = "0x4F0BE90", VA = "0x184F0D090")]
	public IFDHKELCIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F0C950", Offset = "0x4F0B750", VA = "0x184F0C950", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Color IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F0CCB0", Offset = "0x4F0BAB0", VA = "0x184F0CCB0", Slot = "5")]
	public Color HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class GMLJBDBIOKK : global::JNNOLJAFELM<Bounds>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LEFEBFDEKGG ELHFHNGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] MJBFKMMMMMF;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F0ABC0", Offset = "0x4F099C0", VA = "0x184F0ABC0")]
	public GMLJBDBIOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F0A4F0", Offset = "0x4F092F0", VA = "0x184F0A4F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Bounds IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F0A740", Offset = "0x4F09540", VA = "0x184F0A740", Slot = "5")]
	public Bounds HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class CGBFCOIADGE : global::JNNOLJAFELM<Rect>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly LEFEBFDEKGG ELHFHNGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] MJBFKMMMMMF;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4130C70", Offset = "0x412FA70", VA = "0x184130C70")]
	public CGBFCOIADGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x41308C0", Offset = "0x412F6C0", VA = "0x1841308C0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Rect IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4130A30", Offset = "0x412F830", VA = "0x184130A30", Slot = "5")]
	public Rect HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class PCFPBNIHFNA : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class FONALAEPIBE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x41D62D0", Offset = "0x41D50D0", VA = "0x1841D62D0")]
		static FONALAEPIBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private PCFPBNIHFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class GGCCKGJOEED : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class ECANEDMGLEJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2040", Offset = "0x1AC0E40", VA = "0x181AC2040")]
		static ECANEDMGLEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class FOBHCPCLKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> DDKOCHNDDPB;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x510A950", Offset = "0x5109750", VA = "0x18510A950")]
		internal static object IMMPCOIBHEB(Type MGEGOIPHNMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private GGCCKGJOEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class OFECBDCGBEB : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class BAOOLEILIBH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5162B10", Offset = "0x5161910", VA = "0x185162B10")]
		static BAOOLEILIBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly OFECBDCGBEB JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool PDNCCKLDGGC;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static INIKLHPPANG[] FHKOFGFBOGO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static LOKDBPMCGHA[] OEHGGFHFBON;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private OFECBDCGBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F1E730", Offset = "0x4F1D530", VA = "0x184F1E730")]
	public static void PJHBAIJLMNC(params LOKDBPMCGHA[] OEHGGFHFBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F1E810", Offset = "0x4F1D610", VA = "0x184F1E810")]
	public static void PJHBAIJLMNC(params INIKLHPPANG[] FHKOFGFBOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F1E4A0", Offset = "0x4F1D2A0", VA = "0x184F1E4A0")]
	public static void NEEJJIGHCDA(INIKLHPPANG[] FHKOFGFBOGO, LOKDBPMCGHA[] OEHGGFHFBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class AECIOAJJJCA : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class KKGOJDGNJCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3118230", Offset = "0x3117030", VA = "0x183118230")]
		static KKGOJDGNJCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private AECIOAJJJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AFEPFPICDPA
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LOKDBPMCGHA FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly LOKDBPMCGHA DIJAGNFDNJG;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly LOKDBPMCGHA FGEIKKFKICL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly LOKDBPMCGHA KAJHKJGCJMP;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly LOKDBPMCGHA BKKDNFFFBEL;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly LOKDBPMCGHA NIMBNAKANFD;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly LOKDBPMCGHA LMIBLOEMIJD;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly LOKDBPMCGHA FGEEANLFHGF;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly LOKDBPMCGHA DMCALEGFKPP;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly LOKDBPMCGHA KFCFHNNLNMH;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly LOKDBPMCGHA LJEAGCAPHHP;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly LOKDBPMCGHA PJEDMDHJIJF;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CNCADPJPMKP
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly LOKDBPMCGHA FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LOKDBPMCGHA BJHGNBHAOND;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class GDONDAOEAJD
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly LOKDBPMCGHA FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly LOKDBPMCGHA DIJAGNFDNJG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly LOKDBPMCGHA FGEIKKFKICL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly LOKDBPMCGHA KAJHKJGCJMP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly LOKDBPMCGHA BKKDNFFFBEL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly LOKDBPMCGHA NIMBNAKANFD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly LOKDBPMCGHA LMIBLOEMIJD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly LOKDBPMCGHA FGEEANLFHGF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly LOKDBPMCGHA DMCALEGFKPP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly LOKDBPMCGHA KFCFHNNLNMH;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly LOKDBPMCGHA LJEAGCAPHHP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly LOKDBPMCGHA PJEDMDHJIJF;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class FCNMJEKJNKJ
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> DDKOCHNDDPB;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4140310", Offset = "0x413F110", VA = "0x184140310")]
	internal static object IMMPCOIBHEB(Type MGEGOIPHNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4141C70", Offset = "0x4140A70", VA = "0x184141C70")]
	private static object NMGHAMNLLMF(Type DBEOOLAFEEI, Type[] MEBLGPBILPJ, params object[] MPBBAJCIKNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class MPNMGKLJFCH : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class FPLHOLMNFGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x29D5A80", Offset = "0x29D4880", VA = "0x1829D5A80")]
		static FPLHOLMNFGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly ODAALDAPPKD DDEFJEHCKHG;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4F17350", Offset = "0x4F16150", VA = "0x184F17350")]
	static MPNMGKLJFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private MPNMGKLJFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class LCMGKPOECNK : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class EOPEOIIPNHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1ADC4A0", Offset = "0x1ADB2A0", VA = "0x181ADC4A0")]
		static EOPEOIIPNHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly ODAALDAPPKD DDEFJEHCKHG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4F15040", Offset = "0x4F13E40", VA = "0x184F15040")]
	static LCMGKPOECNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private LCMGKPOECNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class FBIKMDGBHHH : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PGHCGMEBJMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x316C520", Offset = "0x316B320", VA = "0x18316C520")]
		static PGHCGMEBJMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly ODAALDAPPKD DDEFJEHCKHG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x413FF80", Offset = "0x413ED80", VA = "0x18413FF80")]
	static FBIKMDGBHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private FBIKMDGBHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class MPEOCIFCKPF : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class NIIPDOIPMMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB8D0", Offset = "0x2DFA6D0", VA = "0x182DFB8D0")]
		static NIIPDOIPMMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly ODAALDAPPKD DDEFJEHCKHG;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4F17220", Offset = "0x4F16020", VA = "0x184F17220")]
	static MPEOCIFCKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private MPEOCIFCKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class EKFDEAHHJBH : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class HEDKFGINPED<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2917DB0", Offset = "0x2916BB0", VA = "0x182917DB0")]
		static HEDKFGINPED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly ODAALDAPPKD DDEFJEHCKHG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4137480", Offset = "0x4136280", VA = "0x184137480")]
	static EKFDEAHHJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private EKFDEAHHJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class KINIHMJJGBF : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class JILOBDCNFCI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2D87BD0", Offset = "0x2D869D0", VA = "0x182D87BD0")]
		static JILOBDCNFCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly ODAALDAPPKD DDEFJEHCKHG;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4F133C0", Offset = "0x4F121C0", VA = "0x184F133C0")]
	static KINIHMJJGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private KINIHMJJGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class ICBGDOFGHMD : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class APCEMFAOIDJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x23CECF0", Offset = "0x23CDAF0", VA = "0x1823CECF0")]
		static APCEMFAOIDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ICBGDOFGHMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class MJAKGJLBBEI : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class ANGANGBMAHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x23CA500", Offset = "0x23C9300", VA = "0x1823CA500")]
		static ANGANGBMAHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public MJAKGJLBBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JKDDEKDFBLL : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class BKKEDAEBNIO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2500DD0", Offset = "0x24FFBD0", VA = "0x182500DD0")]
		static BKKEDAEBNIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public JKDDEKDFBLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class OFJOFDFAOEF : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class HKILILKDHNB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2D02F50", Offset = "0x2D01D50", VA = "0x182D02F50")]
		static HKILILKDHNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OFJOFDFAOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class MGHKIFOMFPD : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class CPCGMPMOKGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x260B3C0", Offset = "0x260A1C0", VA = "0x18260B3C0")]
		static CPCGMPMOKGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public MGHKIFOMFPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class DNKGOEJLGEC : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class EJOGCCIIAJN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3070", Offset = "0x1AD1E70", VA = "0x181AD3070")]
		static EJOGCCIIAJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> CMANJFKFPCG;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool EPFFAOOEBIK;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public DNKGOEJLGEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class FAFCNJPCCKN
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct AIBNMNAFNCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CPHKEJEHFFI ADDMFPEGMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder ADNPHFPNKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder AMBAJJOGMMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class MBJGANDKLHL
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class POOEKJAGCOM
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo OPMEIJFJIMK;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo HMMNKHOIIGI;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo FNNMDLAEGOA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo PFFPMGLMNKM;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo KGAKMFFKNAB;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo NMHKAPAJACH;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo LBNNBDPCDCJ;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo PPKOCOLAHAM;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo PMPLPLANEBL;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x5118E10", Offset = "0x5117C10", VA = "0x185118E10")]
			static POOEKJAGCOM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class JDLBFLDHGJC
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo BMGOFCHECKP;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo KKLGFJHGMFL;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo MJHFGKFLELG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo CCCEEGKOJMJ;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo DBEKBMHDCHD;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo GMGHNENLGFB;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo BPONLNLGFFC;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x510FA90", Offset = "0x510E890", VA = "0x18510FA90")]
			static JDLBFLDHGJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class LHIPNDMOMNF
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo EIFFJCDBAIN;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo DBBDPLHFPHD;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo LCEFCHCALNO;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo BJMFONPJKFC;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo DAHAFDFFELK;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo APMBJPAGDAJ;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo AGDFJAELGLJ;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo AAFLCIPNPFF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo DOBNHEPMFFE;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo LOPDIBKAFMH;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo OPCMEFFGEGA;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo KHONGKGNAGH;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo GHIJCFDIPHN;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo JPOOGCJMNDA;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5110FC0", Offset = "0x510FDC0", VA = "0x185110FC0")]
		public static MethodInfo DGAMFOBEJMM(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x51113D0", Offset = "0x51101D0", VA = "0x1851113D0")]
		public static MethodInfo HJFKJCGGCHL(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5111290", Offset = "0x5110090", VA = "0x185111290")]
		public static MethodInfo FGPNCJBFAHA(Type NKICFHCCMMH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class DINACBIIBHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<CPHKEJEHFFI, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DINACBIIBHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class IADCEBCEGMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public DINACBIIBHP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public IADCEBCEGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x510F370", Offset = "0x510E170", VA = "0x18510F370")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x510F3B0", Offset = "0x510E1B0", VA = "0x18510F3B0")]
		internal bool <BuildType>b__2(int index, CPHKEJEHFFI member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class AMCJPCCKCKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public DINACBIIBHP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public AMCJPCCKCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5109530", Offset = "0x5108330", VA = "0x185109530")]
		internal bool <BuildType>b__3(int index, CPHKEJEHFFI member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class EIGLOLGFOBA
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public EIGLOLGFOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x510A6A0", Offset = "0x51094A0", VA = "0x18510A6A0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HJILECBAOPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HJILECBAOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x510ED20", Offset = "0x510DB20", VA = "0x18510ED20")]
		internal bool <BuildAnonymousFormatter>b__2(CPHKEJEHFFI x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LFMBAHPIGOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EIGLOLGFOBA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public LFMBAHPIGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5110A50", Offset = "0x510F850", VA = "0x185110A50")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5110A60", Offset = "0x510F860", VA = "0x185110A60")]
		internal bool <BuildAnonymousFormatter>b__6(int index, CPHKEJEHFFI member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class EGCLHDEEMPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public EIGLOLGFOBA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public EGCLHDEEMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x510A390", Offset = "0x5109190", VA = "0x18510A390")]
		internal bool <BuildAnonymousFormatter>b__7(int index, CPHKEJEHFFI member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HCDINGGJEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HCDINGGJEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x681FD0", Offset = "0x680DD0", VA = "0x180681FD0")]
		internal Label <BuildSerialize>b__1(CPHKEJEHFFI _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IAHHECMJGEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AIBNMNAFNCM[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, CPHKEJEHFFI, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public DCCIMLEJMHH argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DCCIMLEJMHH argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public IAHHECMJGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x510F450", Offset = "0x510E250", VA = "0x18510F450")]
		internal AIBNMNAFNCM <BuildDeserialize>b__0(CPHKEJEHFFI item)
		{
			return default(AIBNMNAFNCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GKNHCDNKEFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IAHHECMJGEL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public GKNHCDNKEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x510E9D0", Offset = "0x510D7D0", VA = "0x18510E9D0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x510EC80", Offset = "0x510DA80", VA = "0x18510EC80")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class JBIOEJEIPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CPHKEJEHFFI item;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public JBIOEJEIPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1045E20", Offset = "0x1044C20", VA = "0x181045E20")]
		internal bool <EmitNewObject>b__0(AIBNMNAFNCM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class KJOFOODCOKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CPHKEJEHFFI item;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public KJOFOODCOKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x1045E20", Offset = "0x1044C20", VA = "0x181045E20")]
		internal bool <EmitNewObject>b__2(AIBNMNAFNCM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex LGFFIHFBJJO;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int BFAGFPIMBIG;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> OKFPPNJGEAM;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> JAHDNNBFGKN;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2C51F50", Offset = "0x2C50D50", VA = "0x182C51F50")]
	public static object JHFDGOLFHCA<T>(ODAALDAPPKD DDEFJEHCKHG, LOKDBPMCGHA HAGKKODIIII, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2C47590", Offset = "0x2C46390", VA = "0x182C47590")]
	public static object COCGOEDNNGF<T>(LOKDBPMCGHA HAGKKODIIII, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK, bool BOAEPGJEDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x413C7A0", Offset = "0x413B5A0", VA = "0x18413C7A0")]
	private static TypeInfo INOHNGCOMJI(ODAALDAPPKD DDEFJEHCKHG, Type NKICFHCCMMH, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x413ABA0", Offset = "0x41399A0", VA = "0x18413ABA0")]
	public static object HIMKGIIFCGO(Type NKICFHCCMMH, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK, bool BOAEPGJEDHO, bool NPFLMHNGGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4138C80", Offset = "0x4137A80", VA = "0x184138C80")]
	private static Dictionary<CPHKEJEHFFI, FieldInfo> BIIIFMOAALF(TypeBuilder CAKAKLGNBLD, OGNLOCKLBCO JENKMGOKHPL, ConstructorInfo MFMGKGDAPJB, FieldBuilder NLBCEPDPEFF, ILGenerator BNJPLGFLIAJ, bool EPFFAOOEBIK, bool AFKBMADDCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x413F2C0", Offset = "0x413E0C0", VA = "0x18413F2C0")]
	private static Dictionary<CPHKEJEHFFI, FieldInfo> PBBEJKFBHPM(TypeBuilder CAKAKLGNBLD, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4139360", Offset = "0x4138160", VA = "0x184139360")]
	private static void BIMPNHPDBKC(Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ, Action ICNCKAKELMF, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, bool EPFFAOOEBIK, bool AFKBMADDCEC, int LOHGOPDMHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4138540", Offset = "0x4137340", VA = "0x184138540")]
	private static void AICGJENGIME(TypeInfo NKICFHCCMMH, CPHKEJEHFFI KHAAONOKIMB, ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, DCCIMLEJMHH MLMFBHHJDGG, DCCIMLEJMHH JBHOHKLEENF, DCCIMLEJMHH FPBPADHDMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x413DE80", Offset = "0x413CC80", VA = "0x18413DE80")]
	private static void ODJGGHNOEPM(Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, bool DHDCDPCPHMO, int LOHGOPDMHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x413D230", Offset = "0x413C030", VA = "0x18413D230")]
	private static void JLHDIJGLJDI(ILGenerator BNJPLGFLIAJ, AIBNMNAFNCM JENKMGOKHPL, int AIPHGHFENPJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, DCCIMLEJMHH ANKKMEDLEHC, DCCIMLEJMHH FPBPADHDMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4137890", Offset = "0x4136690", VA = "0x184137890")]
	private static LocalBuilder AGKGPBPIMDB(ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, AIBNMNAFNCM[] OEKDHDGKNIJ, bool FOPIGMBNEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x413D780", Offset = "0x413C580", VA = "0x18413D780")]
	private static bool LJCEKNKDABK(ConstructorInfo KEMDDJPADGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x413A9F0", Offset = "0x41397F0", VA = "0x18413A9F0")]
	private static bool HAGILGDPABB(Type NKICFHCCMMH, out Type PKFGKHCJGAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void DHFBONEBMAN<T>(byte[][] NLBCEPDPEFF, object[] ACNNMBPIMED, ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T GACMKDJBDLB<T>(object[] ACNNMBPIMED, ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA HGOBEINKIPD);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class OHCOAOGFFMP<T> : global::JNNOLJAFELM<T>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] NLBCEPDPEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] NNAJOCDFKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] JNANILGLAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::DHFBONEBMAN<T> NHGODJCEDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::GACMKDJBDLB<T> HEEJCHPDFDL;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x28F2A20", Offset = "0x28F1820", VA = "0x1828F2A20")]
	public OHCOAOGFFMP(byte[][] NLBCEPDPEFF, object[] NNAJOCDFKGN, object[] JNANILGLAGM, global::DHFBONEBMAN<T> NHGODJCEDDK, global::GACMKDJBDLB<T> HEEJCHPDFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x300DF90", Offset = "0x300CD90", VA = "0x18300DF90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x300E070", Offset = "0x300CE70", VA = "0x18300E070", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class NHMDKOJMPHP : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class NIFOIMLPMFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF77A0", Offset = "0x2DF65A0", VA = "0x182DF77A0")]
		static NIFOIMLPMFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private NHMDKOJMPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class PLGJBPIIGAP : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class PFDPDCJHJHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x315BCD0", Offset = "0x315AAD0", VA = "0x18315BCD0")]
		static PFDPDCJHJHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private PLGJBPIIGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class IAIOLCGABOK
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly LOKDBPMCGHA[] MFJKCKAOFBH;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class OJGKJBIIILJ : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class PODNMCJIDGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x35F0680", Offset = "0x35EF480", VA = "0x1835F0680")]
		static PODNMCJIDGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class GJAGDDOOIGB : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class AGBCCLGNMHA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x23BFE90", Offset = "0x23BEC90", VA = "0x1823BFE90")]
			static AGBCCLGNMHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private GJAGDDOOIGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private OJGKJBIIILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class EFNMFAPIKOL : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class KBLBADELLAF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2D3CFC0", Offset = "0x2D3BDC0", VA = "0x182D3CFC0")]
		static KBLBADELLAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class NANBDBICHIG : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class LMLGOHNCAOH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x2E9F710", Offset = "0x2E9E510", VA = "0x182E9F710")]
			static LMLGOHNCAOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private NANBDBICHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private EFNMFAPIKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class ONAMNPOMKOO : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class MMPJLIDFMNB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x277EA20", Offset = "0x277D820", VA = "0x18277EA20")]
		static MMPJLIDFMNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class ELFLPGMAPFC : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class LAHJHKFCDOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3B05580", Offset = "0x3B04380", VA = "0x183B05580")]
			static LAHJHKFCDOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private ELFLPGMAPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private ONAMNPOMKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class OPNDONGIHIK : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class LNHLJLGKMIC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2EA03C0", Offset = "0x2E9F1C0", VA = "0x182EA03C0")]
		static LNHLJLGKMIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class BAPBGFPHFBK : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class HLAAMGOAKNO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x2D1B8E0", Offset = "0x2D1A6E0", VA = "0x182D1B8E0")]
			static HLAAMGOAKNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private BAPBGFPHFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private OPNDONGIHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class PFMMLNKGMHD : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class DAPNJMFJLPI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x31A4AE0", Offset = "0x31A38E0", VA = "0x1831A4AE0")]
		static DAPNJMFJLPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class AFEPIEBMHDA : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class MCDCILNPIEC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x2E45550", Offset = "0x2E44350", VA = "0x182E45550")]
			static MCDCILNPIEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private AFEPIEBMHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private PFMMLNKGMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class LMALOAECNMK : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class CIJPMAILOLF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x25FA550", Offset = "0x25F9350", VA = "0x1825FA550")]
		static CIJPMAILOLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class CBHPGKCLJPI : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class PDOJGJOLGIG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2FECDD0", Offset = "0x2FEBBD0", VA = "0x182FECDD0")]
			static PDOJGJOLGIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private CBHPGKCLJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private LMALOAECNMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class FMOBBBPOAIE : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class KMDNPJBMNPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x311D290", Offset = "0x311C090", VA = "0x18311D290")]
		static KMDNPJBMNPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class MPDMCIPCILH : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class KAGNCNBLIMJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D39BF0", Offset = "0x2D389F0", VA = "0x182D39BF0")]
			static KAGNCNBLIMJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private MPDMCIPCILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private FMOBBBPOAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class KDGOIEKLNKO : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class KHNMPLGHMDC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x31077F0", Offset = "0x31065F0", VA = "0x1831077F0")]
		static KHNMPLGHMDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class INDOHLPBKBN : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class JNKKDEGCIHL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2D90610", Offset = "0x2D8F410", VA = "0x182D90610")]
			static JNKKDEGCIHL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private INDOHLPBKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private KDGOIEKLNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class ONLIBBOOLDI : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class CBKGALNMKHB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3405B70", Offset = "0x3404970", VA = "0x183405B70")]
		static CBKGALNMKHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class NGCOOAIBJOG : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class JHFBIBKPIHK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x32D6880", Offset = "0x32D5680", VA = "0x1832D6880")]
			static JHFBIBKPIHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private NGCOOAIBJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private ONLIBBOOLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class JCNGDHHCIFP : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class HGPLCCALNJG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2920B90", Offset = "0x291F990", VA = "0x182920B90")]
		static HGPLCCALNJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class EALEFALAMEN : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class CMEGECDDPEL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2606A00", Offset = "0x2605800", VA = "0x182606A00")]
			static CMEGECDDPEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private EALEFALAMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private JCNGDHHCIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class CCPPKCGFGGK : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class HJBMPNPMCIN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x29293B0", Offset = "0x29281B0", VA = "0x1829293B0")]
		static HJBMPNPMCIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class ODDFHJDFAPA : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class DENOGIFGKAP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x26FC7A0", Offset = "0x26FB5A0", VA = "0x1826FC7A0")]
			static DENOGIFGKAP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private ODDFHJDFAPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private CCPPKCGFGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class ECAABBFCBGH : LOKDBPMCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class MFMMOCEDHIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2E4E7B0", Offset = "0x2E4D5B0", VA = "0x182E4E7B0")]
		static MFMMOCEDHIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class JCOCGCAPBAM : LOKDBPMCGHA
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class FGFJDOHEBDG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::JNNOLJAFELM<T> AGDDNALGBCH;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x259E540", Offset = "0x259D340", VA = "0x18259E540")]
			static FGFJDOHEBDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		private JCOCGCAPBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
		public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::JNNOLJAFELM<object> CKGCMFCDCNJ;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	private ECAABBFCBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A360", Offset = "0x1F19160", VA = "0x181F1A360", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct PFFGLIOAFFG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] ABGNLPNEPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int PANMOHPAPDK;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x315FE60", Offset = "0x315EC60", VA = "0x18315FE60")]
	public PFFGLIOAFFG(int AIGDDFDNOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x315FCE0", Offset = "0x315EAE0", VA = "0x18315FCE0")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x315FDD0", Offset = "0x315EBD0", VA = "0x18315FDD0")]
	public T[] JEAKIKGHNCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class JLFGDAHEIGG : global::KEFICJEPPGO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly JLFGDAHEIGG FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F12080", Offset = "0x4F10E80", VA = "0x184F12080")]
	public JLFGDAHEIGG(int FMGFIHODCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class KEFICJEPPGO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int FMGFIHODCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object MGHNELKPIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int AIPHGHFENPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] AAPNPMPOEHH;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3101E30", Offset = "0x3100C30", VA = "0x183101E30")]
	public KEFICJEPPGO(int FMGFIHODCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3101B80", Offset = "0x3100980", VA = "0x183101B80")]
	public T[] ACAAPGHKAHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3101100", Offset = "0x30FFF00", VA = "0x183101100")]
	public void AANHKIFALNP(T[] DEJEDNNJILK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class LEFEBFDEKGG : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class AHENJGGJBFD : IComparable<AHENJGGJBFD>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class EHFOANLNPOE : IEnumerable<AHENJGGJBFD>, IEnumerable, IEnumerator<AHENJGGJBFD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private AHENJGGJBFD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public AHENJGGJBFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private AHENJGGJBFD System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
			[DebuggerHidden]
			public EHFOANLNPOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x510A530", Offset = "0x5109330", VA = "0x18510A530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x510A660", Offset = "0x5109460", VA = "0x18510A660", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x510A5C0", Offset = "0x51093C0", VA = "0x18510A5C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AHENJGGJBFD> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x510A5C0", Offset = "0x51093C0", VA = "0x18510A5C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class APBNGAIOKMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
			public APBNGAIOKMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x681FD0", Offset = "0x680DD0", VA = "0x180681FD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x681FD0", Offset = "0x680DD0", VA = "0x180681FD0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly AHENJGGJBFD[] OOOMHFCIFJI;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] KCFLHPLHJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong HJHOJEFKDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int AAFFKFKIJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string MGKBPDDPAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private AHENJGGJBFD[] CCMIPADPMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] HAMOKNLMNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int KOHJDBBJEKM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IJJEOPMEJDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xBDA1B0", Offset = "0xBD8FB0", VA = "0x180BDA1B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5109470", Offset = "0x5108270", VA = "0x185109470")]
		public AHENJGGJBFD(ulong CCJNKBLKLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x51080C0", Offset = "0x5106EC0", VA = "0x1851080C0")]
		public AHENJGGJBFD HEFJCCLOLGO(ulong CCJNKBLKLDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5108070", Offset = "0x5106E70", VA = "0x185108070")]
		public AHENJGGJBFD HEFJCCLOLGO(ulong CCJNKBLKLDJ, int IGJPNMBCJPK, string MGKBPDDPAGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5109070", Offset = "0x5107E70", VA = "0x185109070")]
		public AHENJGGJBFD KODACLNEAKH(byte[] JOLHNMOCKDJ, ref int LBACAALGKLG, ref int NCJHPIDHIAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5109360", Offset = "0x5108160", VA = "0x185109360")]
		internal static int MIFBMIGANDK(ulong[] DEJEDNNJILK, int AIPHGHFENPJ, int GKPOMAIMOAK, ulong IGJPNMBCJPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5108040", Offset = "0x5106E40", VA = "0x185108040", Slot = "4")]
		public int CompareTo(AHENJGGJBFD HNOJKNGFFBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5107FD0", Offset = "0x5106DD0", VA = "0x185107FD0")]
		[IteratorStateMachine(typeof(EHFOANLNPOE))]
		public IEnumerable<AHENJGGJBFD> BLJCNLIHGCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5109220", Offset = "0x5108020", VA = "0x185109220")]
		public void MGBOALHDBNH(ILGenerator BNJPLGFLIAJ, LocalBuilder JOLHNMOCKDJ, LocalBuilder NCJHPIDHIAK, LocalBuilder CCJNKBLKLDJ, Action<KeyValuePair<string, int>> EOLLFGFOCNE, Action HOHJLGNLOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5108380", Offset = "0x5107180", VA = "0x185108380")]
		private static void IJBHIIIGILC(ILGenerator BNJPLGFLIAJ, LocalBuilder JOLHNMOCKDJ, LocalBuilder NCJHPIDHIAK, LocalBuilder CCJNKBLKLDJ, Action<KeyValuePair<string, int>> EOLLFGFOCNE, Action HOHJLGNLOFC, AHENJGGJBFD[] CCMIPADPMIA, int KOHJDBBJEKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class NMLCLJAJEPL : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<AHENJGGJBFD> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<AHENJGGJBFD> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<AHENJGGJBFD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private AHENJGGJBFD <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5113BA0", Offset = "0x51129A0", VA = "0x185113BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9DE010", Offset = "0x9DCE10", VA = "0x1809DE010")]
		[DebuggerHidden]
		public NMLCLJAJEPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5113BF0", Offset = "0x51129F0", VA = "0x185113BF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5113660", Offset = "0x5112460", VA = "0x185113660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5113CD0", Offset = "0x5112AD0", VA = "0x185113CD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5113D20", Offset = "0x5112B20", VA = "0x185113D20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5113B60", Offset = "0x5112960", VA = "0x185113B60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5113AC0", Offset = "0x51128C0", VA = "0x185113AC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5113AC0", Offset = "0x51128C0", VA = "0x185113AC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly AHENJGGJBFD KOJLKBNIDFO;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4F157D0", Offset = "0x4F145D0", VA = "0x184F157D0")]
	public LEFEBFDEKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F15290", Offset = "0x4F14090", VA = "0x184F15290")]
	public void HEFJCCLOLGO(byte[] HFAIGCGNPJJ, int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F153B0", Offset = "0x4F141B0", VA = "0x184F153B0")]
	public bool IFNCCANGCPM(ArraySegment<byte> CCJNKBLKLDJ, out int IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F15740", Offset = "0x4F14540", VA = "0x184F15740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F154A0", Offset = "0x4F142A0", VA = "0x184F154A0")]
	private static void PPPIDEIAKDM(IEnumerable<AHENJGGJBFD> CCMIPADPMIA, StringBuilder NHDKHCEFNFI, int MOLGFCBNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F151E0", Offset = "0x4F13FE0", VA = "0x184F151E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F151E0", Offset = "0x4F13FE0", VA = "0x184F151E0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F15170", Offset = "0x4F13F70", VA = "0x184F15170")]
	[IteratorStateMachine(typeof(NMLCLJAJEPL))]
	private static IEnumerable<KeyValuePair<string, int>> FIODJCALBMH(IEnumerable<AHENJGGJBFD> CCMIPADPMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F15470", Offset = "0x4F14270", VA = "0x184F15470")]
	public void ODIJKEACLBG(ILGenerator BNJPLGFLIAJ, LocalBuilder JOLHNMOCKDJ, LocalBuilder NCJHPIDHIAK, LocalBuilder CCJNKBLKLDJ, Action<KeyValuePair<string, int>> EOLLFGFOCNE, Action HOHJLGNLOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class APCPCIMKLMJ
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo ODHBILMDFME;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x412D4C0", Offset = "0x412C2C0", VA = "0x18412D4C0")]
	public static ulong GHADMMGMIIG(byte[] HFAIGCGNPJJ, ref int LBACAALGKLG, ref int NCJHPIDHIAK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class BOFKLCAIDMC
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x412FF30", Offset = "0x412ED30", VA = "0x18412FF30")]
	public static void JHOPBBOOCLA(ref byte[] HFAIGCGNPJJ, int LBACAALGKLG, int GIDHOGLCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4130070", Offset = "0x412EE70", VA = "0x184130070")]
	public static void ONKELFNAKMD(ref byte[] DEJEDNNJILK, int EPOAMOEJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x412FE10", Offset = "0x412EC10", VA = "0x18412FE10")]
	public static byte[] DEPPCLKCHBF(byte[] ICAAAENIBKC, int EPOAMOEJPAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class BHBJCDJCMNC
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x412F2E0", Offset = "0x412E0E0", VA = "0x18412F2E0")]
	public static bool CHHJCFLIPIC(byte[] BHJIICJLDBJ, int EMEOLFFOALB, int EIDJGFOIKBJ, byte[] OLFNPBDJMJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class JDGGAPLDNFH<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct GDOAAEAAJKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] HJHOJEFKDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T AAFFKFKIJDJ;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x23021A0", Offset = "0x2300FA0", VA = "0x1823021A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class DCPBCPGEPJF : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::JDGGAPLDNFH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GDOAAEAAJKJ[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private GDOAAEAAJKJ[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x26F6910", Offset = "0x26F5710", VA = "0x1826F6910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA2D0", Offset = "0x1FF90D0", VA = "0x181FFA2D0")]
		[DebuggerHidden]
		public DCPBCPGEPJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x31A7FB0", Offset = "0x31A6DB0", VA = "0x1831A7FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x31A84A0", Offset = "0x31A72A0", VA = "0x1831A84A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GDOAAEAAJKJ[][] BINDDLEDHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong PAJPFIKKJDL;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x35FE660", Offset = "0x35FD460", VA = "0x1835FE660")]
	public JDGGAPLDNFH(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x35FE5A0", Offset = "0x35FD3A0", VA = "0x1835FE5A0")]
	public JDGGAPLDNFH(int CHMDLBBFMNF, float FLHOHCCGGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x35FDF70", Offset = "0x35FCD70", VA = "0x1835FDF70")]
	public void HEFJCCLOLGO(byte[] CCJNKBLKLDJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x35FC950", Offset = "0x35FB750", VA = "0x1835FC950")]
	private bool FGMLDBJKNBM(byte[] CCJNKBLKLDJ, T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x35FA250", Offset = "0x35F9050", VA = "0x1835FA250")]
	public bool CECEMJJAJEO(ArraySegment<byte> CCJNKBLKLDJ, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x35FDA00", Offset = "0x35FC800", VA = "0x1835FDA00")]
	private static ulong GJIHLCDPCGO(byte[] KNMKEOOODCL, int LBACAALGKLG, int KOHJDBBJEKM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x35FE570", Offset = "0x35FD370", VA = "0x1835FE570")]
	private static int MCHGIMDMKJF(int EOHIDHOLHCB, float FLHOHCCGGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x35FDAF0", Offset = "0x35FC8F0", VA = "0x1835FDAF0", Slot = "4")]
	[IteratorStateMachine(typeof(global::JDGGAPLDNFH<>.DCPBCPGEPJF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x26084C0", Offset = "0x26072C0", VA = "0x1826084C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class NLBDDAGFCEM : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] PNJIKEEOEDJ;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] OPAHPAMGLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int KDLKHOKKFBK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MONEOHDAHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4F17D60", Offset = "0x4F16B60", VA = "0x184F17D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4F17ED0", Offset = "0x4F16CD0", VA = "0x184F17ED0")]
	static NLBDDAGFCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4F18150", Offset = "0x4F16F50", VA = "0x184F18150")]
	public NLBDDAGFCEM(byte[] EHDMHONDOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4F17DB0", Offset = "0x4F16BB0", VA = "0x184F17DB0")]
	public OpCode NLNOADAGOKD()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct ODHCMGIBAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid AAFFKFKIJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte PCJILPBCMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte AHGIMLDMOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte CBDELHJNOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte BFNNAOHHOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte OHMGANHBOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte LNKOBOCLMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte GMPABJJCBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte LGOCJOJFOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte KIEIKGNNPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte JFNKAMHPJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte NLNILBACJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte ICGICGGCCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte GJDLKEHHPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte NABLNCKGCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte FCCMJNDKIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte JHENGEOAHJM;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] OLAKPCMCBBB;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] CMGPLDEBKLM;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4F1E060", Offset = "0x4F1CE60", VA = "0x184F1E060")]
	public ODHCMGIBAIG(ref Guid IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4F1CC10", Offset = "0x4F1BA10", VA = "0x184F1CC10")]
	public ODHCMGIBAIG(ref ArraySegment<byte> APMMOIAIFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4F1B620", Offset = "0x4F1A420", VA = "0x184F1B620")]
	private static byte CGCLCMEAHFG(byte[] HFAIGCGNPJJ, int IDILNIFMOPD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4F1CA30", Offset = "0x4F1B830", VA = "0x184F1CA30")]
	private static byte KOIBBIEFGGE(byte BMMLDIMMAAK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4F1B6E0", Offset = "0x4F1A4E0", VA = "0x184F1B6E0")]
	public void FJGIJIFMICL(byte[] CLABEIKAHOI, int LBACAALGKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class OLMHCAFJHFJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5115990", Offset = "0x5114790", VA = "0x185115990")]
	public static bool BCLLAJPEGNE(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x51159A0", Offset = "0x51147A0", VA = "0x1851159A0")]
	public static bool BEGGFPCIAKB(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x51162C0", Offset = "0x51150C0", VA = "0x1851162C0")]
	public static sbyte FCAFBJELBGE(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x51163A0", Offset = "0x51151A0", VA = "0x1851163A0")]
	public static short GBGLBFEDKLJ(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5115A10", Offset = "0x5114810", VA = "0x185115A10")]
	public static int CGCLBGFIAEF(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5115870", Offset = "0x5114670", VA = "0x185115870")]
	public static long AKPKAJHPHND(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5115920", Offset = "0x5114720", VA = "0x185115920")]
	public static byte BBCKHJFHBCK(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5116410", Offset = "0x5115210", VA = "0x185116410")]
	public static ushort KLFEMFLOKCA(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5117320", Offset = "0x5116120", VA = "0x185117320")]
	public static uint NNIEICDPABA(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x51173A0", Offset = "0x51161A0", VA = "0x1851173A0")]
	public static ulong PHHJMKPOOCC(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5116330", Offset = "0x5115130", VA = "0x185116330")]
	public static float FIPEPGKAELM(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5115A80", Offset = "0x5114880", VA = "0x185115A80")]
	public static double COEEEHMEAOP(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5115AF0", Offset = "0x51148F0", VA = "0x185115AF0")]
	public static int DBMGIHAEODI(ref byte[] CLABEIKAHOI, int LBACAALGKLG, ulong IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5116480", Offset = "0x5115280", VA = "0x185116480")]
	public static int NJBGPAHMPKF(ref byte[] CLABEIKAHOI, int LBACAALGKLG, long IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x51170B0", Offset = "0x5115EB0", VA = "0x1851170B0")]
	public static bool NKLENODONFE(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class DKGKICBCEFP
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class HKPLMCLJINN : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
		[DebuggerHidden]
		public HKPLMCLJINN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x510F1E0", Offset = "0x510DFE0", VA = "0x18510F1E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x510ED80", Offset = "0x510DB80", VA = "0x18510ED80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x510F2D0", Offset = "0x510E0D0", VA = "0x18510F2D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x510F320", Offset = "0x510E120", VA = "0x18510F320")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x510F1A0", Offset = "0x510DFA0", VA = "0x18510F1A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x510F0F0", Offset = "0x510DEF0", VA = "0x18510F0F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x510F0F0", Offset = "0x510DEF0", VA = "0x18510F0F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class BJDICECIMCG : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
		[DebuggerHidden]
		public BJDICECIMCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5109BF0", Offset = "0x51089F0", VA = "0x185109BF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5109790", Offset = "0x5108590", VA = "0x185109790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5109CE0", Offset = "0x5108AE0", VA = "0x185109CE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5109D30", Offset = "0x5108B30", VA = "0x185109D30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5109BB0", Offset = "0x51089B0", VA = "0x185109BB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5109B00", Offset = "0x5108900", VA = "0x185109B00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5109B00", Offset = "0x5108900", VA = "0x185109B00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4135510", Offset = "0x4134310", VA = "0x184135510")]
	public static bool EBDPBJNODHF(this TypeInfo NKICFHCCMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x4135730", Offset = "0x4134530", VA = "0x184135730")]
	public static bool NKMPCKAKMFA(this TypeInfo NKICFHCCMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x41358E0", Offset = "0x41346E0", VA = "0x1841358E0")]
	public static IEnumerable<PropertyInfo> OGCLJNMGCPK(this Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x41356A0", Offset = "0x41344A0", VA = "0x1841356A0")]
	[IteratorStateMachine(typeof(HKPLMCLJINN))]
	private static IEnumerable<PropertyInfo> JJMEBKKINAO(Type NKICFHCCMMH, HashSet<string> BNCEPBFPPIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x41355D0", Offset = "0x41343D0", VA = "0x1841355D0")]
	public static IEnumerable<FieldInfo> EKMIJLCFOOM(this Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x4135850", Offset = "0x4134650", VA = "0x184135850")]
	[IteratorStateMachine(typeof(BJDICECIMCG))]
	private static IEnumerable<FieldInfo> OBJCPAMOGGJ(Type NKICFHCCMMH, HashSet<string> BNCEPBFPPIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class HFCLDEDBKJB
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding EDFBBEDNAEE;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class KKHCDMMFINL
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x735E40", VA = "0x180737040")]
	public static string PKBMJFALMOK(string JELKAOENNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4F134F0", Offset = "0x4F122F0", VA = "0x184F134F0")]
	public static string EEOGDNNBLDD(string JELKAOENNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4F13600", Offset = "0x4F12400", VA = "0x184F13600")]
	public static string NFOOJFLICLN(string JELKAOENNOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class DIEINJJIANO<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class BNIKACKJNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type HJHOJEFKDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue AAFFKFKIJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int BNFCAOHBBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public BNIKACKJNKP KCJGEAHJJCN;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2507070", Offset = "0x2505E70", VA = "0x182507070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2506FF0", Offset = "0x2505DF0", VA = "0x182506FF0")]
		private int MNCJKLLDCNE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public BNIKACKJNKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class NMAHKMCIBFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public NMAHKMCIBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xE11EB0", Offset = "0xE10CB0", VA = "0x180E11EB0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private BNIKACKJNKP[] BINDDLEDHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int MNKEEJPGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object MMDGJAOBAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float FLHOHCCGGBP;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x45705F0", Offset = "0x456F3F0", VA = "0x1845705F0")]
	public DIEINJJIANO(int CHMDLBBFMNF = 4, float FLHOHCCGGBP = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x456F9B0", Offset = "0x456E7B0", VA = "0x18456F9B0")]
	public bool LHAEMCGIOMO(Type CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x456FB00", Offset = "0x456E900", VA = "0x18456FB00")]
	public bool LHAEMCGIOMO(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x456F3E0", Offset = "0x456E1E0", VA = "0x18456F3E0")]
	private bool FGMLDBJKNBM(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO, out TValue PNFHPOBCPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x456FC50", Offset = "0x456EA50", VA = "0x18456FC50")]
	private bool MKEGPABBLJI(BNIKACKJNKP[] BINDDLEDHON, Type PJEADMGHKIL, BNIKACKJNKP KNPOBLIOELK, Func<Type, TValue> BOHBMFGICDO, out TValue PNFHPOBCPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x456F290", Offset = "0x456E090", VA = "0x18456F290")]
	public bool CECEMJJAJEO(Type CCJNKBLKLDJ, out TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x45703B0", Offset = "0x456F1B0", VA = "0x1845703B0")]
	public TValue NOCCDIAEOGP(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x35FE570", Offset = "0x35FD370", VA = "0x1835FE570")]
	private static int MCHGIMDMKJF(int EOHIDHOLHCB, float FLHOHCCGGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x456F980", Offset = "0x456E780", VA = "0x18456F980")]
	private static void LGCDJLBFEOG(ref BNIKACKJNKP DEHOGNNECIF, BNIKACKJNKP IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x456F980", Offset = "0x456E780", VA = "0x18456F980")]
	private static void LGCDJLBFEOG(ref BNIKACKJNKP[] DEHOGNNECIF, BNIKACKJNKP[] IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class ODAALDAPPKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder HKGBKPKDNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder FOJFGBCDGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object MGHNELKPIGP;

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x4F1B020", Offset = "0x4F19E20", VA = "0x184F1B020")]
	public TypeBuilder FAKEPLAFAMN(string BEMAPDNKPAD, TypeAttributes ACIANFKCINM, Type ADECAOLBLPJ, Type[] HBAHBAGNFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x4F1B0F0", Offset = "0x4F19EF0", VA = "0x184F1B0F0")]
	public ODAALDAPPKD(string LKBDENNFFEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class DINIDBMPFMB
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4135440", Offset = "0x4134240", VA = "0x184135440")]
	private static MethodInfo COPNDAHKOKA(LambdaExpression INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x24A3870", Offset = "0x24A2670", VA = "0x1824A3870")]
	public static MethodInfo EKPOHGDIGNJ<T>(Expression<Func<T>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x24A3870", Offset = "0x24A2670", VA = "0x1824A3870")]
	public static MethodInfo EKPOHGDIGNJ<T, TR>(Expression<Func<T, TR>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x24A3870", Offset = "0x24A2670", VA = "0x1824A3870")]
	public static MethodInfo EKPOHGDIGNJ<T>(Expression<Action<T>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x24A3870", Offset = "0x24A2670", VA = "0x1824A3870")]
	public static MethodInfo EKPOHGDIGNJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x24A3880", Offset = "0x24A2680", VA = "0x1824A3880")]
	private static MemberInfo ELHFDECGBEO<T>(Expression<T> IKPEGPHMIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x24A3810", Offset = "0x24A2610", VA = "0x1824A3810")]
	public static PropertyInfo APBGAJBKLAD<T, TR>(Expression<Func<T, TR>> INLHKOCHCMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct DCCIMLEJMHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int HLAPKJLCEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool KGPNFOGGFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator BNJPLGFLIAJ;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4133F60", Offset = "0x4132D60", VA = "0x184133F60")]
	public DCCIMLEJMHH(ILGenerator BNJPLGFLIAJ, int HLAPKJLCEDC, bool KGPNFOGGFDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4133ED0", Offset = "0x4132CD0", VA = "0x184133ED0")]
	public DCCIMLEJMHH(ILGenerator BNJPLGFLIAJ, int HLAPKJLCEDC, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4133EB0", Offset = "0x4132CB0", VA = "0x184133EB0")]
	public void NPFEGMBBAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class IHKLPGNLPGD
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DB20", Offset = "0x4F0C920", VA = "0x184F0DB20")]
	public static void IAKIHNPGLMM(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DAE0", Offset = "0x4F0C8E0", VA = "0x184F0DAE0")]
	public static void IAKIHNPGLMM(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DF10", Offset = "0x4F0CD10", VA = "0x184F0DF10")]
	public static void MHEHNDFBLFF(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DED0", Offset = "0x4F0CCD0", VA = "0x184F0DED0")]
	public static void MHEHNDFBLFF(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D7D0", Offset = "0x4F0C5D0", VA = "0x184F0D7D0")]
	public static void FEPBJPBPFGA(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D6C0", Offset = "0x4F0C4C0", VA = "0x184F0D6C0")]
	public static void FEPBJPBPFGA(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4F0E140", Offset = "0x4F0CF40", VA = "0x184F0E140")]
	public static void MKOFPOGIEJE(this ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4F0E250", Offset = "0x4F0D050", VA = "0x184F0E250")]
	public static void OJCINDEKKBB(this ILGenerator BNJPLGFLIAJ, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4F0E260", Offset = "0x4F0D060", VA = "0x184F0E260")]
	public static void PFHIEDGBLKN(this ILGenerator BNJPLGFLIAJ, int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DDE0", Offset = "0x4F0CBE0", VA = "0x184F0DDE0")]
	public static void KECCPPHAMND(this ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D940", Offset = "0x4F0C740", VA = "0x184F0D940")]
	public static void FHNJGMJIFEM(this ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D490", Offset = "0x4F0C290", VA = "0x184F0D490")]
	public static void DAJDJDJAPAE(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D8C0", Offset = "0x4F0C6C0", VA = "0x184F0D8C0")]
	public static void FGEFJHEMAOJ(this ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D9F0", Offset = "0x4F0C7F0", VA = "0x184F0D9F0")]
	public static void FOJJIHBCHFI(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4F0E150", Offset = "0x4F0CF50", VA = "0x184F0E150")]
	public static void OBKNFOMFJIE(this ILGenerator BNJPLGFLIAJ, MethodInfo MKNJAKNCPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DD50", Offset = "0x4F0CB50", VA = "0x184F0DD50")]
	public static void IBJJLGAIEOE(this ILGenerator BNJPLGFLIAJ, FieldInfo LJNGIPHLJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D400", Offset = "0x4F0C200", VA = "0x184F0D400")]
	public static void ANCFLIHMCCN(this ILGenerator BNJPLGFLIAJ, ulong IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class CPHKEJEHFFI
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class JCPIBIIPIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public JCPIBIIPIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x510F980", Offset = "0x510E780", VA = "0x18510F980")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo HLJCMOKPAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo JLELOCAGEMC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string CKOMIBKPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x675F30", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string GKGPGJHPFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x675F40", VA = "0x180677140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MHDKIMHMKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4133660", Offset = "0x4132460", VA = "0x184133660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BGKNHKLPBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6723D0", Offset = "0x6711D0", VA = "0x1806723D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1D0", Offset = "0x8DAFD0", VA = "0x1808DC1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DFGCAAIFPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x6711E0", VA = "0x1806723E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xC3C260", Offset = "0xC3B060", VA = "0x180C3C260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x697FC0", VA = "0x1806991C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo GPCNMDPLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EE8E0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo HPOEGHCFBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D370", VA = "0x18065E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D390", VA = "0x18065E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo KBFGBFIFGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x65E580", Offset = "0x65D380", VA = "0x18065E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x65E5A0", Offset = "0x65D3A0", VA = "0x18065E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4133AB0", Offset = "0x41328B0", VA = "0x184133AB0")]
	protected CPHKEJEHFFI(Type NKICFHCCMMH, string BEMAPDNKPAD, string NNNOJJMLEJC, bool OIGNCOPLCNN, bool JNEIHELLFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x41339A0", Offset = "0x41327A0", VA = "0x1841339A0")]
	public CPHKEJEHFFI(FieldInfo JENKMGOKHPL, string BEMAPDNKPAD, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x41337F0", Offset = "0x41325F0", VA = "0x1841337F0")]
	public CPHKEJEHFFI(PropertyInfo JENKMGOKHPL, string BEMAPDNKPAD, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x41334F0", Offset = "0x41322F0", VA = "0x1841334F0")]
	private static MethodInfo CDJPIALPBDP(MemberInfo JENKMGOKHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x20C4210", Offset = "0x20C3010", VA = "0x1820C4210")]
	public T CLMCKOPCBOH<T>(bool ODPKDODHNDF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4133670", Offset = "0x4132470", VA = "0x184133670", Slot = "4")]
	public virtual void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4133730", Offset = "0x4132530", VA = "0x184133730", Slot = "5")]
	public virtual void NNPPNMEPLJK(ILGenerator BNJPLGFLIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class LNIOBANDANN : CPHKEJEHFFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string BGHBALDEJKA;

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4F16180", Offset = "0x4F14F80", VA = "0x184F16180")]
	public LNIOBANDANN(string BEMAPDNKPAD, string BGHBALDEJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4F16080", Offset = "0x4F14E80", VA = "0x184F16080", Slot = "4")]
	public override void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4F16140", Offset = "0x4F14F40", VA = "0x184F16140", Slot = "5")]
	public override void NNPPNMEPLJK(ILGenerator BNJPLGFLIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class AFCJBCIFGFM : CPHKEJEHFFI
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo DFAAHOHCLOP;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo PNAELEKHFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal DCCIMLEJMHH PFBPGFFOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal DCCIMLEJMHH JBHOHKLEENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal DCCIMLEJMHH FPBPADHDMKM;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4129590", Offset = "0x4128390", VA = "0x184129590")]
	public AFCJBCIFGFM(string BEMAPDNKPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4128F30", Offset = "0x4127D30", VA = "0x184128F30", Slot = "4")]
	public override void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4129000", Offset = "0x4127E00", VA = "0x184129000", Slot = "5")]
	public override void NNPPNMEPLJK(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4128DE0", Offset = "0x4127BE0", VA = "0x184128DE0")]
	public void LLEFOJHKPHE(ILGenerator BNJPLGFLIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class OGNLOCKLBCO
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x675F30", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IHJKHNKCKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6718D0", Offset = "0x6706D0", VA = "0x1806718D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x693000", Offset = "0x691E00", VA = "0x180693000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FMKOEAAGOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x73B7F0", Offset = "0x73A5F0", VA = "0x18073B7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x73B800", Offset = "0x73A600", VA = "0x18073B800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo DNIMABPHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CPHKEJEHFFI[] EIAFCALOOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x697FC0", VA = "0x1806991C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CPHKEJEHFFI[] IPLHAKIFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EE8E0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5114020", Offset = "0x5112E20", VA = "0x185114020")]
	public OGNLOCKLBCO(Type NKICFHCCMMH, Func<string, string> HMKJPMFPIEE, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5113F30", Offset = "0x5112D30", VA = "0x185113F30")]
	private static bool FOBEGBLBDAO(IEnumerator<ConstructorInfo> DJDFCEELKJA, ref ConstructorInfo BHBCFMDHKGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct MCKOGFAAPEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong ACDBJHBECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int BKGIODDNKLG;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E770D0", Offset = "0x1E75ED0", VA = "0x181E770D0")]
	public MCKOGFAAPEO(ulong OLKMBLPMENH, int MAJAOEBPCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4F16370", Offset = "0x4F15170", VA = "0x184F16370")]
	public void HPPMEINDINK(ref MCKOGFAAPEO HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4F16380", Offset = "0x4F15180", VA = "0x184F16380")]
	public static MCKOGFAAPEO KLGDEBEOEEG(ref MCKOGFAAPEO BMPDKJEHGIN, ref MCKOGFAAPEO BMMLDIMMAAK)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F16240", Offset = "0x4F15040", VA = "0x184F16240")]
	public void HBKIGLGNGGK(ref MCKOGFAAPEO HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4F162D0", Offset = "0x4F150D0", VA = "0x184F162D0")]
	public static MCKOGFAAPEO HPCAGJGHFCC(ref MCKOGFAAPEO BMPDKJEHGIN, ref MCKOGFAAPEO BMMLDIMMAAK)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4F163E0", Offset = "0x4F151E0", VA = "0x184F163E0")]
	public void PIDPECDHIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4F16390", Offset = "0x4F15190", VA = "0x184F16390")]
	public static MCKOGFAAPEO PIDPECDHIGL(ref MCKOGFAAPEO BMPDKJEHGIN)
	{
		return default(MCKOGFAAPEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct KBDAPDCFLAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] CLABEIKAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int LBACAALGKLG;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x9DFB70", Offset = "0x9DE970", VA = "0x1809DFB70")]
	public KBDAPDCFLAC(byte[] CLABEIKAHOI, int EIIEKPIPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F128C0", Offset = "0x4F116C0", VA = "0x184F128C0")]
	public void KNMCHABHDGK(byte JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F127A0", Offset = "0x4F115A0", VA = "0x184F127A0")]
	public void ANNLPGCBPFJ(byte[] JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F12650", Offset = "0x4F11450", VA = "0x184F12650")]
	public void AANBBHIJCGF(byte[] JNFDLMOFJOO, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F126F0", Offset = "0x4F114F0", VA = "0x184F126F0")]
	public void AANBBHIJCGF(byte[] JNFDLMOFJOO, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F12840", Offset = "0x4F11640", VA = "0x184F12840")]
	public void FGKBCOEHMKB(byte KDPJFGIFCOL, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F12920", Offset = "0x4F11720", VA = "0x184F12920")]
	public void POCOHCHDCNB(string JNFDLMOFJOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class AMEHHLKKHFN
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum BAFKPIKAHOE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum JHIAIDKOECC
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum JFMOGKDKAKB
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
	private static byte[] LJCGAFOBHPK;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] JCOOIGOIIHG;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] PKIDIFDKILK;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] CNEODMBHNLH;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly JFMOGKDKAKB IDCJDBCIIGN;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char AEOIJPEFMNP;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int JOKGODINOPP;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int BNMNEGEHHFH;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] HHHJILPBCDH;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x412B300", Offset = "0x412A100", VA = "0x18412B300")]
	private static byte[] DENDMDEOIEF(int MNKEEJPGFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x412C3C0", Offset = "0x412B1C0", VA = "0x18412C3C0")]
	private static byte[] KNKAFADDMNC(int MNKEEJPGFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x412BBF0", Offset = "0x412A9F0", VA = "0x18412BBF0")]
	public static int FMAJACAKGLG(ref byte[] CLABEIKAHOI, int LBACAALGKLG, float IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x412BD10", Offset = "0x412AB10", VA = "0x18412BD10")]
	public static int FMAJACAKGLG(ref byte[] CLABEIKAHOI, int LBACAALGKLG, double IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x412C9C0", Offset = "0x412B7C0", VA = "0x18412C9C0")]
	private static bool NPBHHOBBNHH(byte[] CLABEIKAHOI, int GKPOMAIMOAK, ulong PMPHKPPDOJC, ulong BCPLKCMOHKM, ulong NCJHPIDHIAK, ulong NPOGEPMNLAA, ulong MHKGIFOFBOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x412B1E0", Offset = "0x4129FE0", VA = "0x18412B1E0")]
	private static void BCNPPMPAPCL(uint IGDINCONBGD, int FNAGAAEAGLL, out uint ONBODKODHNJ, out int FONFFOECJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x412C4A0", Offset = "0x412B2A0", VA = "0x18412C4A0")]
	private static bool LEEOIBBLNPL(MCKOGFAAPEO MCDGEBBILIJ, MCKOGFAAPEO KKGHEBDDELA, MCKOGFAAPEO ILAOCNGHFLG, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int FMPGCHGBDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x412C120", Offset = "0x412AF20", VA = "0x18412C120")]
	private static bool JILABDDABEE(double HFMHCLGICNJ, BAFKPIKAHOE CIJCIMPGNPO, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int KAKDIMEDOFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x412C010", Offset = "0x412AE10", VA = "0x18412C010")]
	private static bool IDCMKILOJPD(double HFMHCLGICNJ, BAFKPIKAHOE CIJCIMPGNPO, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int MFEBBMOCEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x412B050", Offset = "0x4129E50", VA = "0x18412B050")]
	private static bool AFLDOJPDIED(double IGJPNMBCJPK, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x412B3E0", Offset = "0x412A1E0", VA = "0x18412B3E0")]
	private static bool DKHFMDGCBGD(double IGJPNMBCJPK, ref KBDAPDCFLAC CAGCFAOHBGH, JHIAIDKOECC CIJCIMPGNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x412BE30", Offset = "0x412AC30", VA = "0x18412BE30")]
	private static void GILALFMFGMN(byte[] JEBACMJJMOF, int GKPOMAIMOAK, int MFEBBMOCEMA, int FCECNJBELMF, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x412CAC0", Offset = "0x412B8C0", VA = "0x18412CAC0")]
	private static void PBIDELMGLLI(byte[] JEBACMJJMOF, int GKPOMAIMOAK, int MAJAOEBPCPC, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x412BA40", Offset = "0x412A840", VA = "0x18412BA40")]
	private static bool FGBADDHLHIJ(double HFMHCLGICNJ, JHIAIDKOECC CIJCIMPGNPO, int ICNEDAHEEGD, byte[] ALDGKOFAGMG, out bool FHFLCMPABME, out int GKPOMAIMOAK, out int EFCGBFLJIDP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct EMEPPDKJCOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double NAGBPGCPEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong NHIOCCFHHMN;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct EAHJKDFEBFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float ACDBJHBECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint ELHPMPNOIDO;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct OFMMJKGGOIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong EJEJPBBIONP;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F1F120", Offset = "0x4F1DF20", VA = "0x184F1F120")]
	public OFMMJKGGOIM(double NAGBPGCPEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F1F080", Offset = "0x4F1DE80", VA = "0x184F1F080")]
	public OFMMJKGGOIM(MCKOGFAAPEO NAGBPGCPEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EAD0", Offset = "0x4F1D8D0", VA = "0x184F1EAD0")]
	public MCKOGFAAPEO BPIMNDEHAPO()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F1ECB0", Offset = "0x4F1DAB0", VA = "0x184F1ECB0")]
	public MCKOGFAAPEO GEPPNEBKBOJ()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
	public ulong HCIJEIGLJKD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4F1ED40", Offset = "0x4F1DB40", VA = "0x184F1ED40")]
	public double GOOCLIIJOMI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EFA0", Offset = "0x4F1DDA0", VA = "0x184F1EFA0")]
	public double OKEODFPJMBI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EB50", Offset = "0x4F1D950", VA = "0x184F1EB50")]
	public int CKACGJLIEFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EC80", Offset = "0x4F1DA80", VA = "0x184F1EC80")]
	public ulong GCAODMKHGBH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EC60", Offset = "0x4F1DA60", VA = "0x184F1EC60")]
	public bool GAENBIJHMEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EAB0", Offset = "0x4F1D8B0", VA = "0x184F1EAB0")]
	public bool AFLFHJHNEJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EF70", Offset = "0x4F1DD70", VA = "0x184F1EF70")]
	public bool OFOHPOFOPBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EDF0", Offset = "0x4F1DBF0", VA = "0x184F1EDF0")]
	public bool LOIHEJDIILG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EC40", Offset = "0x4F1DA40", VA = "0x184F1EC40")]
	public int DKKNBAHFPKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EE20", Offset = "0x4F1DC20", VA = "0x184F1EE20")]
	public void OCGOJNINOMO(out MCKOGFAAPEO HFEEKHKDPKI, out MCKOGFAAPEO ICKHFGECKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4F1F030", Offset = "0x4F1DE30", VA = "0x184F1F030")]
	public bool PJICEADNPEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EDD0", Offset = "0x4F1DBD0", VA = "0x184F1EDD0")]
	public double IGJPNMBCJPK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EB80", Offset = "0x4F1D980", VA = "0x184F1EB80")]
	public static int CLFFFIHJIKC(int DHFODKLLKIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EDE0", Offset = "0x4F1DBE0", VA = "0x184F1EDE0")]
	public static double JMPCNHFGBNP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EBA0", Offset = "0x4F1D9A0", VA = "0x184F1EBA0")]
	public static ulong DCOGCODPIBI(MCKOGFAAPEO DHDMKLOLPME)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct FDCBCLHMBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint EJDEMKGDMPG;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A72B40", Offset = "0x2A71940", VA = "0x182A72B40")]
	public FDCBCLHMBJG(float ACDBJHBECNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4F05830", Offset = "0x4F04630", VA = "0x184F05830")]
	public MCKOGFAAPEO BPIMNDEHAPO()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707C20", VA = "0x180708E20")]
	public uint LBFONAAGEAJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4F05890", Offset = "0x4F04690", VA = "0x184F05890")]
	public int CKACGJLIEFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4F058C0", Offset = "0x4F046C0", VA = "0x184F058C0")]
	public uint GCAODMKHGBH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4F058B0", Offset = "0x4F046B0", VA = "0x184F058B0")]
	public bool GAENBIJHMEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4F058E0", Offset = "0x4F046E0", VA = "0x184F058E0")]
	public void OCGOJNINOMO(out MCKOGFAAPEO HFEEKHKDPKI, out MCKOGFAAPEO ICKHFGECKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4F05A10", Offset = "0x4F04810", VA = "0x184F05A10")]
	public bool PJICEADNPEB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct BIOBMBIODIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong OLKMBLPMENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short JONPFNEBMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short KAKDIMEDOFI;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x412FA60", Offset = "0x412E860", VA = "0x18412FA60")]
	public BIOBMBIODIM(ulong OLKMBLPMENH, short JONPFNEBMGJ, short KAKDIMEDOFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class FOELPOEECLH
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly BIOBMBIODIM[] MDEKMAFJPBC;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4F05DB0", Offset = "0x4F04BB0", VA = "0x184F05DB0")]
	public static void DOAJIIIOBDK(int FELOCCIEGCP, int OHGMGEJBFEL, out MCKOGFAAPEO ONBODKODHNJ, out int KAKDIMEDOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F05EE0", Offset = "0x4F04CE0", VA = "0x184F05EE0")]
	public static void OEAPNKNFACA(int HDHAOIHOFFC, out MCKOGFAAPEO ONBODKODHNJ, out int CAJKBPDOJCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct EBAINEELELO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] HFAIGCGNPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int FOACNEHDHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int NDIIJIEFDAN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x4136010", Offset = "0x4134E10", VA = "0x184136010")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xB712D0", Offset = "0xB700D0", VA = "0x180B712D0")]
	public EBAINEELELO(byte[] HFAIGCGNPJJ, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x85F7D0", Offset = "0x85E5D0", VA = "0x18085F7D0")]
	public int GKPOMAIMOAK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4135FB0", Offset = "0x4134DB0", VA = "0x184135FB0")]
	public EBAINEELELO HFIPBIMBDKK(int DOOFIFHOCKH, int JBFIBBGJOJJ)
	{
		return default(EBAINEELELO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class COOIPHMMFDO
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] NIPAGFOKFGM;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] AOBLMOFKIFP;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int HNECFNBPCMA;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4131E40", Offset = "0x4130C40", VA = "0x184131E40")]
	private static byte[] CDOFLEPMFIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4131D60", Offset = "0x4130B60", VA = "0x184131D60")]
	private static EBAINEELELO BCILANKJMOK(EBAINEELELO CLABEIKAHOI)
	{
		return default(EBAINEELELO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4132D00", Offset = "0x4131B00", VA = "0x184132D00")]
	private static EBAINEELELO OJHNFDKLIKB(EBAINEELELO CLABEIKAHOI)
	{
		return default(EBAINEELELO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4132AA0", Offset = "0x41318A0", VA = "0x184132AA0")]
	private static void JBBBIEKJKME(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, byte[] CFJGAKCNFDK, out int LMHMLHKDHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4132780", Offset = "0x4131580", VA = "0x184132780")]
	private static void HNGNEJMPDIB(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, byte[] JEILGJFMLBK, int PKPOJMGKFCM, out EBAINEELELO AFJBKCCDGCI, out int OPKBEOHPDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x41326F0", Offset = "0x41314F0", VA = "0x1841326F0")]
	private static ulong GIAFBECHNCD(EBAINEELELO CLABEIKAHOI, out int NHNOEHFLLBP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4131F30", Offset = "0x4130D30", VA = "0x184131F30")]
	private static void COHKBGFCGBB(EBAINEELELO CLABEIKAHOI, out MCKOGFAAPEO BBLJKOEKFJI, out int AALPGFHIAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4132DE0", Offset = "0x4131BE0", VA = "0x184132DE0")]
	private static bool ONNDIKPEIDC(EBAINEELELO AFJBKCCDGCI, int MAJAOEBPCPC, out double BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4132B50", Offset = "0x4131950", VA = "0x184132B50")]
	private static MCKOGFAAPEO LFHILEHJIBF(int MAJAOEBPCPC)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x41320C0", Offset = "0x4130EC0", VA = "0x1841320C0")]
	private static bool FJLBJFGKHPL(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, out double BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4131C20", Offset = "0x4130A20", VA = "0x184131C20")]
	private static bool BCDALGHMIEM(EBAINEELELO AFJBKCCDGCI, int MAJAOEBPCPC, out double LADILAJMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x41325D0", Offset = "0x41313D0", VA = "0x1841325D0")]
	public static double? GAKKOOHBACE(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x4133260", Offset = "0x4132060", VA = "0x184133260")]
	public static float? PAJEDGNHBKL(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct NINNIJFNFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] CLABEIKAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int LBACAALGKLG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x4F178F0", Offset = "0x4F166F0", VA = "0x184F178F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x9DFB70", Offset = "0x9DE970", VA = "0x1809DFB70")]
	public NINNIJFNFLD(byte[] CLABEIKAHOI, int LBACAALGKLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x4F17710", Offset = "0x4F16510", VA = "0x184F17710")]
	public static NINNIJFNFLD CGPJMKBEIBP(NINNIJFNFLD CFFPEBFKEAC)
	{
		return default(NINNIJFNFLD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4F17850", Offset = "0x4F16650", VA = "0x184F17850")]
	public static NINNIJFNFLD KFDPIIJCIIP(NINNIJFNFLD CFFPEBFKEAC, int GKPOMAIMOAK)
	{
		return default(NINNIJFNFLD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4F17980", Offset = "0x4F16780", VA = "0x184F17980")]
	public static int MPKLCJPFEHE(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4F17720", Offset = "0x4F16520", VA = "0x184F17720")]
	public static bool CJJJLAGEFIA(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4F177E0", Offset = "0x4F165E0", VA = "0x184F177E0")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x4F17740", Offset = "0x4F16540", VA = "0x184F17740")]
	public static bool CJJJLAGEFIA(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4F17790", Offset = "0x4F16590", VA = "0x184F17790")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4F17790", Offset = "0x4F16590", VA = "0x184F17790")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, byte PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4F17800", Offset = "0x4F16600", VA = "0x184F17800")]
	public static bool JGGBLBMCIBK(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4F178A0", Offset = "0x4F166A0", VA = "0x184F178A0")]
	public static bool LHGNIHDBGAI(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4F17930", Offset = "0x4F16730", VA = "0x184F17930")]
	public static bool MIELMPPJAGE(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4F179A0", Offset = "0x4F167A0", VA = "0x184F179A0")]
	public static bool NNLCHNKHAPB(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class AEALFIONALK
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] MBIOAAHMBGD;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] KNEMEDJOGDL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] PKIDIFDKILK;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] CNEODMBHNLH;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] KOHDBIMNFNM;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int KONDKKMJCOE;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] LADPKMANCDD;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int MDMOJFDAJHF;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4128850", Offset = "0x4127650", VA = "0x184128850")]
	private static byte[] OJPOPNBOHID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x41285C0", Offset = "0x41273C0", VA = "0x1841285C0")]
	private static byte[] LJHGCDKIJLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x4127030", Offset = "0x4125E30", VA = "0x184127030")]
	public static double CIDIKAMMPKI(byte[] CLABEIKAHOI, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4128940", Offset = "0x4127740", VA = "0x184128940")]
	public static float OOPLEAAMOGO(byte[] CLABEIKAHOI, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x41286B0", Offset = "0x41274B0", VA = "0x1841286B0")]
	private static bool NEHJKMMMHMI(int KNMKEOOODCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x4128A00", Offset = "0x4127800", VA = "0x184128A00")]
	private static bool PFHCHJONCGI(ref NINNIJFNFLD MGGGHPDHPFB, NINNIJFNFLD CBNJCJLIEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4127130", Offset = "0x4125F30", VA = "0x184127130")]
	private static bool HNFJAKPMCCN(ref NINNIJFNFLD MGGGHPDHPFB, NINNIJFNFLD CBNJCJLIEMJ, byte[] IFBJOHKDNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x41270E0", Offset = "0x4125EE0", VA = "0x1841270E0")]
	private static bool FGJGBFPKIFD(ref NINNIJFNFLD KFEOAOMEMDH, byte[] JNFDLMOFJOO, int LBACAALGKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4128830", Offset = "0x4127630", VA = "0x184128830")]
	private static double NIBONLNAFOI(bool FHFLCMPABME)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4127240", Offset = "0x4126040", VA = "0x184127240")]
	private static double IAHFECMHIDI(NINNIJFNFLD GGHGPHKIOAE, int GKPOMAIMOAK, bool HGHFDMNMEGB, out int OINEIGBKJPE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class NKDCBHJFMAC<T> : global::JNNOLJAFELM<T[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::KEFICJEPPGO<T> GPMJNKBDCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly NEHADIAKNBK CPICKMCHCFM;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2778E10", Offset = "0x2777C10", VA = "0x182778E10")]
	public NKDCBHJFMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA2D0", Offset = "0x1FF90D0", VA = "0x181FFA2D0")]
	public NKDCBHJFMAC(NEHADIAKNBK CPICKMCHCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2C98B30", Offset = "0x2C97930", VA = "0x182C98B30", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2C991A0", Offset = "0x2C97FA0", VA = "0x182C991A0", Slot = "5")]
	public T[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class IBCAOCCJOFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::KEFICJEPPGO<T> GPMJNKBDCON;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class MMJNKBLAMPL<T> : global::JNNOLJAFELM<List<T>>, INIKLHPPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly NEHADIAKNBK CPICKMCHCFM;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2778E10", Offset = "0x2777C10", VA = "0x182778E10")]
	public MMJNKBLAMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA2D0", Offset = "0x1FF90D0", VA = "0x181FFA2D0")]
	public MMJNKBLAMPL(NEHADIAKNBK CPICKMCHCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2777640", Offset = "0x2776440", VA = "0x182777640", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, List<T> IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2778870", Offset = "0x2777670", VA = "0x182778870", Slot = "5")]
	public List<T> HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class FAPDHICOOBP<TElement, TIntermediate, TEnumerator, TCollection> : global::JNNOLJAFELM<TCollection>, INIKLHPPANG where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2592F10", Offset = "0x2591D10", VA = "0x182592F10", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TCollection IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2593C20", Offset = "0x2592A20", VA = "0x182593C20", Slot = "5")]
	public TCollection HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator PKBDEGDPEIJ(TCollection IKPEGPHMIII);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DAKLFHBAJIH();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HEFJCCLOLGO(ref TIntermediate FLHDOCMLBEH, int AIPHGHFENPJ, TElement IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection NBKICENBLEL(ref TIntermediate MMMBPDPBONG);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	protected FAPDHICOOBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class INMMIKOAELK<TElement, TIntermediate, TCollection> : global::FAPDHICOOBP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x227D5A0", Offset = "0x227C3A0", VA = "0x18227D5A0", Slot = "6")]
	protected override IEnumerator<TElement> PKBDEGDPEIJ(TCollection IKPEGPHMIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x227D5F0", Offset = "0x227C3F0", VA = "0x18227D5F0")]
	protected INMMIKOAELK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class GICLBPKPKOJ<TElement, TCollection> : global::INMMIKOAELK<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected sealed override TCollection NBKICENBLEL(ref TCollection MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class NGCFCLLFAIG<TElement, TCollection> : global::GICLBPKPKOJ<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x25949C0", Offset = "0x25937C0", VA = "0x1825949C0", Slot = "7")]
	protected override TCollection DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA2F0", Offset = "0x2DE90F0", VA = "0x182DEA2F0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref TCollection FLHDOCMLBEH, int AIPHGHFENPJ, TElement IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class BJHBELBNLHA<T> : global::FAPDHICOOBP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x24F4C10", Offset = "0x24F3A10", VA = "0x1824F4C10", Slot = "8")]
	protected override void HEFJCCLOLGO(ref LinkedList<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override LinkedList<T> NBKICENBLEL(ref LinkedList<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override LinkedList<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x24F4C50", Offset = "0x24F3A50", VA = "0x1824F4C50", Slot = "6")]
	protected override LinkedList<T>.Enumerator PKBDEGDPEIJ(LinkedList<T> IKPEGPHMIII)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PDBNBLCPABN<T> : global::FAPDHICOOBP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x24F4C10", Offset = "0x24F3A10", VA = "0x1824F4C10", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Queue<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override Queue<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2D899E0", Offset = "0x2D887E0", VA = "0x182D899E0", Slot = "6")]
	protected override Queue<T>.Enumerator PKBDEGDPEIJ(Queue<T> IKPEGPHMIII)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override Queue<T> NBKICENBLEL(ref Queue<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class JKPPNIDGHBL<T> : global::FAPDHICOOBP<T, global::PFFGLIOAFFG<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x266DBD0", Offset = "0x266C9D0", VA = "0x18266DBD0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x276EC50", Offset = "0x276DA50", VA = "0x18276EC50", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2D899E0", Offset = "0x2D887E0", VA = "0x182D899E0", Slot = "6")]
	protected override Stack<T>.Enumerator PKBDEGDPEIJ(Stack<T> IKPEGPHMIII)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2D89900", Offset = "0x2D88700", VA = "0x182D89900", Slot = "9")]
	protected override Stack<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class DBGJNMOMPBM<T> : global::FAPDHICOOBP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x24F4C10", Offset = "0x24F3A10", VA = "0x1824F4C10", Slot = "8")]
	protected override void HEFJCCLOLGO(ref HashSet<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override HashSet<T> NBKICENBLEL(ref HashSet<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override HashSet<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2D899E0", Offset = "0x2D887E0", VA = "0x182D899E0", Slot = "6")]
	protected override HashSet<T>.Enumerator PKBDEGDPEIJ(HashSet<T> IKPEGPHMIII)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class FLNAEEBJCMN<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x266DBD0", Offset = "0x266C9D0", VA = "0x18266DBD0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x266DC00", Offset = "0x266CA00", VA = "0x18266DC00", Slot = "9")]
	protected override ReadOnlyCollection<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x266DB90", Offset = "0x266C990", VA = "0x18266DB90", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class PIHNMDPAGPH<T> : global::INMMIKOAELK<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x24F4C10", Offset = "0x24F3A10", VA = "0x1824F4C10", Slot = "8")]
	protected override void HEFJCCLOLGO(ref List<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override List<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override IList<T> NBKICENBLEL(ref List<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class PPMCIAMAKEF<T> : global::INMMIKOAELK<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x24F4C10", Offset = "0x24F3A10", VA = "0x1824F4C10", Slot = "8")]
	protected override void HEFJCCLOLGO(ref List<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override List<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override ICollection<T> NBKICENBLEL(ref List<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class MIPDBMINNMM<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x266DBD0", Offset = "0x266C9D0", VA = "0x18266DBD0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x276EC50", Offset = "0x276DA50", VA = "0x18276EC50", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x276EC90", Offset = "0x276DA90", VA = "0x18276EC90", Slot = "9")]
	protected override IEnumerable<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class JMGJIMAKIBJ<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class NAKPFCGCDAF<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class BNJJIIPGIPD<T> : global::JNNOLJAFELM<T>, INIKLHPPANG where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x25071F0", Offset = "0x2505FF0", VA = "0x1825071F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x25074B0", Offset = "0x25062B0", VA = "0x1825074B0", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	public BNJJIIPGIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class CJJMJBKEAIA : global::JNNOLJAFELM<IEnumerable>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::JNNOLJAFELM<IEnumerable> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4130FA0", Offset = "0x412FDA0", VA = "0x184130FA0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IEnumerable IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4131190", Offset = "0x412FF90", VA = "0x184131190", Slot = "5")]
	public IEnumerable HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public CJJMJBKEAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class ANNONOKIDMD : global::JNNOLJAFELM<ICollection>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::JNNOLJAFELM<ICollection> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x412CFF0", Offset = "0x412BDF0", VA = "0x18412CFF0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ICollection IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x412D2B0", Offset = "0x412C0B0", VA = "0x18412D2B0", Slot = "5")]
	public ICollection HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ANNONOKIDMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class MLMJMJDLKID : global::JNNOLJAFELM<IList>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::JNNOLJAFELM<IList> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x4F16980", Offset = "0x4F15780", VA = "0x184F16980", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IList IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4F16CF0", Offset = "0x4F15AF0", VA = "0x184F16CF0", Slot = "5")]
	public IList HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public MLMJMJDLKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KDHCNBFMNJO<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2D42190", Offset = "0x2D40F90", VA = "0x182D42190", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x276EC50", Offset = "0x276DA50", VA = "0x18276EC50", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2D421C0", Offset = "0x2D40FC0", VA = "0x182D421C0", Slot = "9")]
	protected override IReadOnlyList<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x1ABFDC0", Offset = "0x1ABEBC0", VA = "0x181ABFDC0")]
	public KDHCNBFMNJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class AHFAOLEGJPA
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x4129AA0", Offset = "0x41288A0", VA = "0x184129AA0")]
	public static DateTime HKMLOKGLOKK(DateTime EIAOKCLINIO)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class OANJOLOCEMN : global::JNNOLJAFELM<DateTime>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::JNNOLJAFELM<DateTime> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x4F19050", Offset = "0x4F17E50", VA = "0x184F19050", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, DateTime IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4F19CF0", Offset = "0x4F18AF0", VA = "0x184F19CF0", Slot = "5")]
	public DateTime HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OANJOLOCEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class AIENEPLPNCO : global::JNNOLJAFELM<DateTimeOffset>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::JNNOLJAFELM<DateTimeOffset> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4129CD0", Offset = "0x4128AD0", VA = "0x184129CD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, DateTimeOffset IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x412A0B0", Offset = "0x4128EB0", VA = "0x18412A0B0", Slot = "5")]
	public DateTimeOffset HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public AIENEPLPNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class GFFIHBDONOF : global::JNNOLJAFELM<TimeSpan>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::JNNOLJAFELM<TimeSpan> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] NFHJMOMJEHC;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x4F08FD0", Offset = "0x4F07DD0", VA = "0x184F08FD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TimeSpan IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4F09480", Offset = "0x4F08280", VA = "0x184F09480", Slot = "5")]
	public TimeSpan HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public GFFIHBDONOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class BKBMJHPOIAP<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::JNNOLJAFELM<TDictionary>, INIKLHPPANG where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x24F9480", Offset = "0x24F8280", VA = "0x1824F9480", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TDictionary IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x24FA9D0", Offset = "0x24F97D0", VA = "0x1824FA9D0", Slot = "5")]
	public TDictionary HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator PKBDEGDPEIJ(TDictionary IKPEGPHMIII);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DAKLFHBAJIH();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HEFJCCLOLGO(ref TIntermediate FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary NBKICENBLEL(ref TIntermediate MMMBPDPBONG);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	protected BKBMJHPOIAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class MPHILAFAGJN<TKey, TValue, TIntermediate, TDictionary> : global::BKBMJHPOIAP<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x227D5A0", Offset = "0x227C3A0", VA = "0x18227D5A0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> PKBDEGDPEIJ(TDictionary IKPEGPHMIII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class LKHIFENEGPH<TKey, TValue, TDictionary> : global::MPHILAFAGJN<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override TDictionary NBKICENBLEL(ref TDictionary MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class PNLOKENDAFC<TKey, TValue> : global::BKBMJHPOIAP<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x35EE7F0", Offset = "0x35ED5F0", VA = "0x1835EE7F0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Dictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override Dictionary<TKey, TValue> NBKICENBLEL(ref Dictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override Dictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x35EE830", Offset = "0x35ED630", VA = "0x1835EE830", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator PKBDEGDPEIJ(Dictionary<TKey, TValue> IKPEGPHMIII)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xEA69C0", Offset = "0xEA57C0", VA = "0x180EA69C0")]
	public PNLOKENDAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LDMBIACGPCA<TKey, TValue, TDictionary> : global::LKHIFENEGPH<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E3F0", Offset = "0x2E1D1F0", VA = "0x182E1E3F0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref TDictionary FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE590", Offset = "0x1FFD390", VA = "0x181FFE590", Slot = "7")]
	protected override TDictionary DAKLFHBAJIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class FONMAJJEAKJ<TKey, TValue> : global::MPHILAFAGJN<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x27683B0", Offset = "0x27671B0", VA = "0x1827683B0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Dictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override Dictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override IDictionary<TKey, TValue> NBKICENBLEL(ref Dictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class MHPLNBNNPCH<TKey, TValue> : global::LKHIFENEGPH<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x27683B0", Offset = "0x27671B0", VA = "0x1827683B0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref SortedList<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override SortedList<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class DBJBDNLCFFM<TKey, TValue> : global::BKBMJHPOIAP<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x27683B0", Offset = "0x27671B0", VA = "0x1827683B0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref SortedDictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0xF1BCA0", Offset = "0xF1AAA0", VA = "0x180F1BCA0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NBKICENBLEL(ref SortedDictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BB0", Offset = "0x24F39B0", VA = "0x1824F4BB0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x31A7BA0", Offset = "0x31A69A0", VA = "0x1831A7BA0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator PKBDEGDPEIJ(SortedDictionary<TKey, TValue> IKPEGPHMIII)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NNHEBMEDJPP<T> : global::JNNOLJAFELM<T>, INIKLHPPANG where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1E70", Offset = "0x2CA0C70", VA = "0x182CA1E70", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2220", Offset = "0x2CA1020", VA = "0x182CA2220", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	public NNHEBMEDJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class CDNJKIKCCNP : global::JNNOLJAFELM<IDictionary>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::JNNOLJAFELM<IDictionary> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x41302E0", Offset = "0x412F0E0", VA = "0x1841302E0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IDictionary IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x4130690", Offset = "0x412F490", VA = "0x184130690", Slot = "5")]
	public IDictionary HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public CDNJKIKCCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class OADKHBBMIBJ : global::JNNOLJAFELM<object>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void JPNIBPKKDJN(object PGMDEEIILGO, ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::DIEINJJIANO<KeyValuePair<object, JPNIBPKKDJN>> NIGMPMDPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly LOKDBPMCGHA[] BHDPJLDLLKI;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x4F18FB0", Offset = "0x4F17DB0", VA = "0x184F18FB0")]
	public OADKHBBMIBJ(params LOKDBPMCGHA[] BHDPJLDLLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4F181D0", Offset = "0x4F16FD0", VA = "0x184F181D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4F18F10", Offset = "0x4F17D10", VA = "0x184F18F10", Slot = "5")]
	public object HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class DHMEDDBBKOC
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4134B20", Offset = "0x4133920", VA = "0x184134B20")]
	public static object EPBJHGHLNPD(Type NKICFHCCMMH, out bool OBFKAKNHGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4134200", Offset = "0x4133000", VA = "0x184134200")]
	public static object EJKLHHGKLAO(Type NKICFHCCMMH, out bool OBFKAKNHGMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class FOKEMEJJPEK<T> : global::JNNOLJAFELM<T>, INIKLHPPANG, global::HHCAMMEJFNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class NEJGELLMPNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public NEJGELLMPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2DE88D0", Offset = "0x2DE76D0", VA = "0x182DE88D0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class LLCJHLMFDCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::LKJCMEODDFK<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public LLCJHLMFDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2E9A0B0", Offset = "0x2E98EB0", VA = "0x182E9A0B0")]
		internal void <.cctor>b__1(ref KOGPHPAEDLF writer, T value, LOKDBPMCGHA _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class OGPEOGCMCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::LFJEGKAKEAB<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public OGPEOGCMCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2F88050", Offset = "0x2F86E50", VA = "0x182F88050")]
		internal T <.cctor>b__2(ref JBBAGFKBPCP reader, LOKDBPMCGHA _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::JDGGAPLDNFH<T> PMIONDOIKNF;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> ICCNCKGDFLK;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::LKJCMEODDFK<T> JENCPLCEPLA;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::LFJEGKAKEAB<T> DACFEALDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool NLMEIKOHBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::LKJCMEODDFK<T> KGABKMJIGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::LFJEGKAKEAB<T> HGGFMPAJJON;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x267BFE0", Offset = "0x267ADE0", VA = "0x18267BFE0")]
	static FOKEMEJJPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2682BF0", Offset = "0x26819F0", VA = "0x182682BF0")]
	public FOKEMEJJPEK(bool NLMEIKOHBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x26776A0", Offset = "0x26764A0", VA = "0x1826776A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2678270", Offset = "0x2677070", VA = "0x182678270", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2676870", Offset = "0x2675670", VA = "0x182676870", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2679900", Offset = "0x2678700", VA = "0x182679900", Slot = "7")]
	public T MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class BLLADHHJOOG<T> : global::JNNOLJAFELM<T[,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2501D00", Offset = "0x2500B00", VA = "0x182501D00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2501EB0", Offset = "0x2500CB0", VA = "0x182501EB0", Slot = "5")]
	public T[,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	public BLLADHHJOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class AGPOBCKCLDF<T> : global::JNNOLJAFELM<T[,,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x23C1760", Offset = "0x23C0560", VA = "0x1823C1760", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x23C1970", Offset = "0x23C0770", VA = "0x1823C1970", Slot = "5")]
	public T[,,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	public AGPOBCKCLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LMCLGPMBMBI<T> : global::JNNOLJAFELM<T[,,,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2E9B750", Offset = "0x2E9A550", VA = "0x182E9B750", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,,,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2E9B9F0", Offset = "0x2E9A7F0", VA = "0x182E9B9F0", Slot = "5")]
	public T[,,,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	public LMCLGPMBMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class PLFDCJPPELA<T> : global::JNNOLJAFELM<T?>, INIKLHPPANG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x3172CB0", Offset = "0x3171AB0", VA = "0x183172CB0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x31730C0", Offset = "0x3171EC0", VA = "0x1831730C0", Slot = "5")]
	public T? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	public PLFDCJPPELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class HOPJKNANKFP<T> : global::JNNOLJAFELM<T?>, INIKLHPPANG where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::JNNOLJAFELM<T> ONFFLAMPLNM;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x17ABF10", Offset = "0x17AAD10", VA = "0x1817ABF10")]
	public HOPJKNANKFP(global::JNNOLJAFELM<T> ONFFLAMPLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D24690", Offset = "0x2D23490", VA = "0x182D24690")]
	public HOPJKNANKFP(Type HDCINCHPFJA, object[] ONLKLCKDLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D239D0", Offset = "0x2D227D0", VA = "0x182D239D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D24530", Offset = "0x2D23330", VA = "0x182D24530", Slot = "5")]
	public T? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class KCPBPFHDKBE : global::JNNOLJAFELM<sbyte>, INIKLHPPANG, global::HHCAMMEJFNJ<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly KCPBPFHDKBE FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x4F12AE0", Offset = "0x4F118E0", VA = "0x184F12AE0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F12B20", Offset = "0x4F11920", VA = "0x184F12B20", Slot = "5")]
	public sbyte HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F12A20", Offset = "0x4F11820", VA = "0x184F12A20", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F12B70", Offset = "0x4F11970", VA = "0x184F12B70", Slot = "7")]
	public sbyte MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KCPBPFHDKBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class OAPBOJMHBFN : global::JNNOLJAFELM<sbyte?>, INIKLHPPANG, global::HHCAMMEJFNJ<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly OAPBOJMHBFN FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4F1ADC0", Offset = "0x4F19BC0", VA = "0x184F1ADC0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F1AE50", Offset = "0x4F19C50", VA = "0x184F1AE50", Slot = "5")]
	public sbyte? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F1ACB0", Offset = "0x4F19AB0", VA = "0x184F1ACB0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F1AF00", Offset = "0x4F19D00", VA = "0x184F1AF00", Slot = "7")]
	public sbyte? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OAPBOJMHBFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class KHNEBOLBMEL : global::JNNOLJAFELM<sbyte[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly KHNEBOLBMEL FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F12F90", Offset = "0x4F11D90", VA = "0x184F12F90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F13130", Offset = "0x4F11F30", VA = "0x184F13130", Slot = "5")]
	public sbyte[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KHNEBOLBMEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class FOOMNEJBMJI : global::JNNOLJAFELM<short>, INIKLHPPANG, global::HHCAMMEJFNJ<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly FOOMNEJBMJI FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F07E50", Offset = "0x4F06C50", VA = "0x184F07E50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F07E90", Offset = "0x4F06C90", VA = "0x184F07E90", Slot = "5")]
	public short HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F07D90", Offset = "0x4F06B90", VA = "0x184F07D90", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, short IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F07EF0", Offset = "0x4F06CF0", VA = "0x184F07EF0", Slot = "7")]
	public short MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public FOOMNEJBMJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class DODMPLALPPA : global::JNNOLJAFELM<short?>, INIKLHPPANG, global::HHCAMMEJFNJ<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly DODMPLALPPA FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x4135DA0", Offset = "0x4134BA0", VA = "0x184135DA0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4135E20", Offset = "0x4134C20", VA = "0x184135E20", Slot = "5")]
	public short? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4135D20", Offset = "0x4134B20", VA = "0x184135D20", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, short? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4135E90", Offset = "0x4134C90", VA = "0x184135E90", Slot = "7")]
	public short? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public DODMPLALPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class PADFOFLPNPD : global::JNNOLJAFELM<short[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly PADFOFLPNPD FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x51178D0", Offset = "0x51166D0", VA = "0x1851178D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5117990", Offset = "0x5116790", VA = "0x185117990", Slot = "5")]
	public short[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public PADFOFLPNPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class NDOBPFMFPPG : global::JNNOLJAFELM<int>, INIKLHPPANG, global::HHCAMMEJFNJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly NDOBPFMFPPG FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4F17540", Offset = "0x4F16340", VA = "0x184F17540", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4F17570", Offset = "0x4F16370", VA = "0x184F17570", Slot = "5")]
	public int HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4F17480", Offset = "0x4F16280", VA = "0x184F17480", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, int IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4F175D0", Offset = "0x4F163D0", VA = "0x184F175D0", Slot = "7")]
	public int MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public NDOBPFMFPPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class MHMNLIPCABE : global::JNNOLJAFELM<int?>, INIKLHPPANG, global::HHCAMMEJFNJ<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly MHMNLIPCABE FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4F16610", Offset = "0x4F15410", VA = "0x184F16610", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F166A0", Offset = "0x4F154A0", VA = "0x184F166A0", Slot = "5")]
	public int? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F16500", Offset = "0x4F15300", VA = "0x184F16500", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, int? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F16750", Offset = "0x4F15550", VA = "0x184F16750", Slot = "7")]
	public int? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public MHMNLIPCABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class GIEBMHECCJB : global::JNNOLJAFELM<int[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly GIEBMHECCJB FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4F0A0C0", Offset = "0x4F08EC0", VA = "0x184F0A0C0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F0A260", Offset = "0x4F09060", VA = "0x184F0A260", Slot = "5")]
	public int[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public GIEBMHECCJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class PCFGDCJHOHL : global::JNNOLJAFELM<long>, INIKLHPPANG, global::HHCAMMEJFNJ<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly PCFGDCJHOHL FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x5117CC0", Offset = "0x5116AC0", VA = "0x185117CC0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5117CE0", Offset = "0x5116AE0", VA = "0x185117CE0", Slot = "5")]
	public long HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5117C80", Offset = "0x5116A80", VA = "0x185117C80", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, long IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5117CF0", Offset = "0x5116AF0", VA = "0x185117CF0", Slot = "7")]
	public long MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public PCFGDCJHOHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class PPIGKNAOFLB : global::JNNOLJAFELM<long?>, INIKLHPPANG, global::HHCAMMEJFNJ<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly PPIGKNAOFLB FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5119C80", Offset = "0x5118A80", VA = "0x185119C80", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5119D00", Offset = "0x5118B00", VA = "0x185119D00", Slot = "5")]
	public long? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5119BF0", Offset = "0x51189F0", VA = "0x185119BF0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, long? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5119D90", Offset = "0x5118B90", VA = "0x185119D90", Slot = "7")]
	public long? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public PPIGKNAOFLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class FCHHACNIAAH : global::JNNOLJAFELM<long[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly FCHHACNIAAH FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x41400B0", Offset = "0x413EEB0", VA = "0x1841400B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4140170", Offset = "0x413EF70", VA = "0x184140170", Slot = "5")]
	public long[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public FCHHACNIAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class MOMIOIFMECA : global::JNNOLJAFELM<byte>, INIKLHPPANG, global::HHCAMMEJFNJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly MOMIOIFMECA FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x4F170A0", Offset = "0x4F15EA0", VA = "0x184F170A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x4F170E0", Offset = "0x4F15EE0", VA = "0x184F170E0", Slot = "5")]
	public byte HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4F16FE0", Offset = "0x4F15DE0", VA = "0x184F16FE0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, byte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4F17140", Offset = "0x4F15F40", VA = "0x184F17140", Slot = "7")]
	public byte MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public MOMIOIFMECA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class NKMHDBAEFCG : global::JNNOLJAFELM<byte?>, INIKLHPPANG, global::HHCAMMEJFNJ<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly NKMHDBAEFCG FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4F17B00", Offset = "0x4F16900", VA = "0x184F17B00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4F17B90", Offset = "0x4F16990", VA = "0x184F17B90", Slot = "5")]
	public byte? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4F179F0", Offset = "0x4F167F0", VA = "0x184F179F0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, byte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4F17C40", Offset = "0x4F16A40", VA = "0x184F17C40", Slot = "7")]
	public byte? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public NKMHDBAEFCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class LKNNPMGNEHN : global::JNNOLJAFELM<ushort>, INIKLHPPANG, global::HHCAMMEJFNJ<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly LKNNPMGNEHN FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x4F15A80", Offset = "0x4F14880", VA = "0x184F15A80", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4F15AC0", Offset = "0x4F148C0", VA = "0x184F15AC0", Slot = "5")]
	public ushort HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4F159C0", Offset = "0x4F147C0", VA = "0x184F159C0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ushort IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4F15B20", Offset = "0x4F14920", VA = "0x184F15B20", Slot = "7")]
	public ushort MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public LKNNPMGNEHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class APIBBGAMLDJ : global::JNNOLJAFELM<ushort?>, INIKLHPPANG, global::HHCAMMEJFNJ<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly APIBBGAMLDJ FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x412E5A0", Offset = "0x412D3A0", VA = "0x18412E5A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x412E620", Offset = "0x412D420", VA = "0x18412E620", Slot = "5")]
	public ushort? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x412E520", Offset = "0x412D320", VA = "0x18412E520", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ushort? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x412E690", Offset = "0x412D490", VA = "0x18412E690", Slot = "7")]
	public ushort? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public APIBBGAMLDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class DHGDKFPLMGJ : global::JNNOLJAFELM<ushort[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly DHGDKFPLMGJ FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x4133FA0", Offset = "0x4132DA0", VA = "0x184133FA0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4134060", Offset = "0x4132E60", VA = "0x184134060", Slot = "5")]
	public ushort[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public DHGDKFPLMGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class BCAJFAFFHIL : global::JNNOLJAFELM<uint>, INIKLHPPANG, global::HHCAMMEJFNJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly BCAJFAFFHIL FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x412E7F0", Offset = "0x412D5F0", VA = "0x18412E7F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x412E800", Offset = "0x412D600", VA = "0x18412E800", Slot = "5")]
	public uint HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x412E7B0", Offset = "0x412D5B0", VA = "0x18412E7B0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, uint IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x412E810", Offset = "0x412D610", VA = "0x18412E810", Slot = "7")]
	public uint MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public BCAJFAFFHIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class HOKLIALELJK : global::JNNOLJAFELM<uint?>, INIKLHPPANG, global::HHCAMMEJFNJ<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly HOKLIALELJK FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x4F0C2B0", Offset = "0x4F0B0B0", VA = "0x184F0C2B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4F0C340", Offset = "0x4F0B140", VA = "0x184F0C340", Slot = "5")]
	public uint? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4F0C1A0", Offset = "0x4F0AFA0", VA = "0x184F0C1A0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, uint? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4F0C3F0", Offset = "0x4F0B1F0", VA = "0x184F0C3F0", Slot = "7")]
	public uint? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public HOKLIALELJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class CKDHNKHGOOH : global::JNNOLJAFELM<uint[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly CKDHNKHGOOH FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x41313A0", Offset = "0x41301A0", VA = "0x1841313A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4131460", Offset = "0x4130260", VA = "0x184131460", Slot = "5")]
	public uint[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public CKDHNKHGOOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class KEIJFLAPPHI : global::JNNOLJAFELM<ulong>, INIKLHPPANG, global::HHCAMMEJFNJ<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly KEIJFLAPPHI FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x4F12E70", Offset = "0x4F11C70", VA = "0x184F12E70", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x4F12EA0", Offset = "0x4F11CA0", VA = "0x184F12EA0", Slot = "5")]
	public ulong HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4F12DB0", Offset = "0x4F11BB0", VA = "0x184F12DB0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ulong IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4F12EB0", Offset = "0x4F11CB0", VA = "0x184F12EB0", Slot = "7")]
	public ulong MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KEIJFLAPPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class ENKDIAELHNA : global::JNNOLJAFELM<ulong?>, INIKLHPPANG, global::HHCAMMEJFNJ<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly ENKDIAELHNA FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x4137640", Offset = "0x4136440", VA = "0x184137640", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x41376C0", Offset = "0x41364C0", VA = "0x1841376C0", Slot = "5")]
	public ulong? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x41375B0", Offset = "0x41363B0", VA = "0x1841375B0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ulong? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4137750", Offset = "0x4136550", VA = "0x184137750", Slot = "7")]
	public ulong? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ENKDIAELHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class OEBPKGBCBPC : global::JNNOLJAFELM<ulong[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly OEBPKGBCBPC FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x4F1E070", Offset = "0x4F1CE70", VA = "0x184F1E070", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4F1E210", Offset = "0x4F1D010", VA = "0x184F1E210", Slot = "5")]
	public ulong[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OEBPKGBCBPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class BMMIIEFCDKK : global::JNNOLJAFELM<float>, INIKLHPPANG, global::HHCAMMEJFNJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly BMMIIEFCDKK FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x412FD10", Offset = "0x412EB10", VA = "0x18412FD10", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x412FD20", Offset = "0x412EB20", VA = "0x18412FD20", Slot = "5")]
	public float HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x412FCD0", Offset = "0x412EAD0", VA = "0x18412FCD0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, float IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x412FD30", Offset = "0x412EB30", VA = "0x18412FD30", Slot = "7")]
	public float MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public BMMIIEFCDKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class KNNCDPMFNHC : global::JNNOLJAFELM<float?>, INIKLHPPANG, global::HHCAMMEJFNJ<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly KNNCDPMFNHC FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4F13AB0", Offset = "0x4F128B0", VA = "0x184F13AB0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x4F13B30", Offset = "0x4F12930", VA = "0x184F13B30", Slot = "5")]
	public float? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x4F139B0", Offset = "0x4F127B0", VA = "0x184F139B0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, float? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4F13BA0", Offset = "0x4F129A0", VA = "0x184F13BA0", Slot = "7")]
	public float? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KNNCDPMFNHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class BKGGGBNPBNA : global::JNNOLJAFELM<float[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly BKGGGBNPBNA FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x412FA70", Offset = "0x412E870", VA = "0x18412FA70", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x412FB30", Offset = "0x412E930", VA = "0x18412FB30", Slot = "5")]
	public float[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public BKGGGBNPBNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class LLPOOEKMAOE : global::JNNOLJAFELM<double>, INIKLHPPANG, global::HHCAMMEJFNJ<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly LLPOOEKMAOE FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x4F15CB0", Offset = "0x4F14AB0", VA = "0x184F15CB0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x4F15CC0", Offset = "0x4F14AC0", VA = "0x184F15CC0", Slot = "5")]
	public double HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4F15C00", Offset = "0x4F14A00", VA = "0x184F15C00", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, double IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4F15CD0", Offset = "0x4F14AD0", VA = "0x184F15CD0", Slot = "7")]
	public double MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public LLPOOEKMAOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class OIOEJMKILPC : global::JNNOLJAFELM<double?>, INIKLHPPANG, global::HHCAMMEJFNJ<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly OIOEJMKILPC FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5115490", Offset = "0x5114290", VA = "0x185115490", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5115510", Offset = "0x5114310", VA = "0x185115510", Slot = "5")]
	public double? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5115400", Offset = "0x5114200", VA = "0x185115400", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, double? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x51155A0", Offset = "0x51143A0", VA = "0x1851155A0", Slot = "7")]
	public double? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OIOEJMKILPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class IPMAHCDNHPB : global::JNNOLJAFELM<double[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly IPMAHCDNHPB FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4F0EB40", Offset = "0x4F0D940", VA = "0x184F0EB40", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4F0ED20", Offset = "0x4F0DB20", VA = "0x184F0ED20", Slot = "5")]
	public double[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public IPMAHCDNHPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class KLDKNKEEEKL : global::JNNOLJAFELM<bool>, INIKLHPPANG, global::HHCAMMEJFNJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly KLDKNKEEEKL FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4F138A0", Offset = "0x4F126A0", VA = "0x184F138A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4F138C0", Offset = "0x4F126C0", VA = "0x184F138C0", Slot = "5")]
	public bool HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4F137F0", Offset = "0x4F125F0", VA = "0x184F137F0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, bool IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4F138D0", Offset = "0x4F126D0", VA = "0x184F138D0", Slot = "7")]
	public bool MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KLDKNKEEEKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class DNLNKNBBGMO : global::JNNOLJAFELM<bool?>, INIKLHPPANG, global::HHCAMMEJFNJ<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly DNLNKNBBGMO FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4135B10", Offset = "0x4134910", VA = "0x184135B10", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x4135B90", Offset = "0x4134990", VA = "0x184135B90", Slot = "5")]
	public bool? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x4135A90", Offset = "0x4134890", VA = "0x184135A90", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, bool? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4135C00", Offset = "0x4134A00", VA = "0x184135C00", Slot = "7")]
	public bool? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public DNLNKNBBGMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class FOOOJOLIBNM : global::JNNOLJAFELM<bool[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly FOOOJOLIBNM FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4F07FD0", Offset = "0x4F06DD0", VA = "0x184F07FD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4F08150", Offset = "0x4F06F50", VA = "0x184F08150", Slot = "5")]
	public bool[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public FOOOJOLIBNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GPJLKJGHOLE : global::JNNOLJAFELM<object>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::JNNOLJAFELM<object> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> KJPOHEOKLCF;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4F0AE00", Offset = "0x4F09C00", VA = "0x184F0AE00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4F0B8D0", Offset = "0x4F0A6D0", VA = "0x184F0B8D0", Slot = "5")]
	public object HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public GPJLKJGHOLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class LNAPDHNOCMK : global::JNNOLJAFELM<byte[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::JNNOLJAFELM<byte[]> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x4F15F10", Offset = "0x4F14D10", VA = "0x184F15F10", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4F15FA0", Offset = "0x4F14DA0", VA = "0x184F15FA0", Slot = "5")]
	public byte[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public LNAPDHNOCMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class FGJIHKHCIJC : global::JNNOLJAFELM<ArraySegment<byte>>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::JNNOLJAFELM<ArraySegment<byte>> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x4F05A50", Offset = "0x4F04850", VA = "0x184F05A50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ArraySegment<byte> IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4F05B10", Offset = "0x4F04910", VA = "0x184F05B10", Slot = "5")]
	public ArraySegment<byte> HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public FGJIHKHCIJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class KODMDJJNLNF : global::JNNOLJAFELM<string>, INIKLHPPANG, global::HHCAMMEJFNJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::JNNOLJAFELM<string> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x4F13CC0", Offset = "0x4F12AC0", VA = "0x184F13CC0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, string IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4F13CE0", Offset = "0x4F12AE0", VA = "0x184F13CE0", Slot = "5")]
	public string HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4F13CC0", Offset = "0x4F12AC0", VA = "0x184F13CC0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, string IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4F13CE0", Offset = "0x4F12AE0", VA = "0x184F13CE0", Slot = "7")]
	public string MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KODMDJJNLNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class ODCGBLDANKH : global::JNNOLJAFELM<string[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly ODCGBLDANKH FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4F1B1F0", Offset = "0x4F19FF0", VA = "0x184F1B1F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, string[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4F1B360", Offset = "0x4F1A160", VA = "0x184F1B360", Slot = "5")]
	public string[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ODCGBLDANKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class LFHFKJBNAGE : global::JNNOLJAFELM<char>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly LFHFKJBNAGE FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4F15840", Offset = "0x4F14640", VA = "0x184F15840", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4F158C0", Offset = "0x4F146C0", VA = "0x184F158C0", Slot = "5")]
	public char HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public LFHFKJBNAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class JLPLPGMJOJF : global::JNNOLJAFELM<char?>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly JLPLPGMJOJF FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4F120D0", Offset = "0x4F10ED0", VA = "0x184F120D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4F121C0", Offset = "0x4F10FC0", VA = "0x184F121C0", Slot = "5")]
	public char? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public JLPLPGMJOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class INEMAFEKBLP : global::JNNOLJAFELM<char[]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly INEMAFEKBLP FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x4F0E6B0", Offset = "0x4F0D4B0", VA = "0x184F0E6B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4F0E8F0", Offset = "0x4F0D6F0", VA = "0x184F0E8F0", Slot = "5")]
	public char[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public INEMAFEKBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class DBOHMHENIOG : global::JNNOLJAFELM<Guid>, INIKLHPPANG, global::HHCAMMEJFNJ<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::JNNOLJAFELM<Guid> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x4133D30", Offset = "0x4132B30", VA = "0x184133D30", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Guid IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x4133E00", Offset = "0x4132C00", VA = "0x184133E00", Slot = "5")]
	public Guid HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x4133C60", Offset = "0x4132A60", VA = "0x184133C60", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, Guid IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x4133E00", Offset = "0x4132C00", VA = "0x184133E00", Slot = "7")]
	public Guid MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public DBOHMHENIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class EKEGCAPCFCA : global::JNNOLJAFELM<decimal>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::JNNOLJAFELM<decimal> FOBBLKPOGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool IBJNOEDEBDG;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xD5AAF0", Offset = "0xD598F0", VA = "0x180D5AAF0")]
	public EKEGCAPCFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x11F8BF0", Offset = "0x11F79F0", VA = "0x1811F8BF0")]
	public EKEGCAPCFCA(bool IBJNOEDEBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x41370A0", Offset = "0x4135EA0", VA = "0x1841370A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, decimal IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x41371F0", Offset = "0x4135FF0", VA = "0x1841371F0", Slot = "5")]
	public decimal HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class ECDFIIHKANH : global::JNNOLJAFELM<Uri>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::JNNOLJAFELM<Uri> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x41361B0", Offset = "0x4134FB0", VA = "0x1841361B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Uri IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4136260", Offset = "0x4135060", VA = "0x184136260", Slot = "5")]
	public Uri HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ECDFIIHKANH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class AHFCHFOOIAB : global::JNNOLJAFELM<Version>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::JNNOLJAFELM<Version> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x4129B40", Offset = "0x4128940", VA = "0x184129B40", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Version IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4129BF0", Offset = "0x41289F0", VA = "0x184129BF0", Slot = "5")]
	public Version HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public AHFCHFOOIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class OJIIFPFGHMJ<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class DADHEDJLMIB : global::JNNOLJAFELM<StringBuilder>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::JNNOLJAFELM<StringBuilder> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4133B30", Offset = "0x4132930", VA = "0x184133B30", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, StringBuilder IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4133B80", Offset = "0x4132980", VA = "0x184133B80", Slot = "5")]
	public StringBuilder HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public DADHEDJLMIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class JMFNCIECAPD : global::JNNOLJAFELM<BitArray>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::JNNOLJAFELM<BitArray> FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4F122F0", Offset = "0x4F110F0", VA = "0x184F122F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, BitArray IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4F123F0", Offset = "0x4F111F0", VA = "0x184F123F0", Slot = "5")]
	public BitArray HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public JMFNCIECAPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class BGOLDOIGOAD : global::JNNOLJAFELM<Type>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly BGOLDOIGOAD FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex LGFFIHFBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool IOMMIHKILIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool PAMAECJHBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool KOCNBEFBMEI;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x412F2C0", Offset = "0x412E0C0", VA = "0x18412F2C0")]
	public BGOLDOIGOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x412F270", Offset = "0x412E070", VA = "0x18412F270")]
	public BGOLDOIGOAD(bool IOMMIHKILIP, bool PAMAECJHBBM, bool KOCNBEFBMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x412EF90", Offset = "0x412DD90", VA = "0x18412EF90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Type IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x412F080", Offset = "0x412DE80", VA = "0x18412F080", Slot = "5")]
	public Type HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
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
