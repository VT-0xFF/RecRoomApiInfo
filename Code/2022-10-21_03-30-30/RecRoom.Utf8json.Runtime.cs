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
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
	public JAOCPNLBGPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class DDJEMGOIBKB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
	public DDJEMGOIBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IMJJJDMJDFE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
	public IMJJJDMJDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JNMGGIFPILP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
	public JNMGGIFPILP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class MHPACJDBJCH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF770", Offset = "0x4EEE570", VA = "0x184EEF770")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DBBDPLHFPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65C090", Offset = "0x65AE90", VA = "0x18065C090")]
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
	[Cpp2IlInjected.Address(RVA = "0x24A05A0", Offset = "0x249F3A0", VA = "0x1824A05A0")]
	public static global::JNNOLJAFELM<T> BJMFONPJKFC<T>(this LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4134B00", Offset = "0x4133900", VA = "0x184134B00")]
	public static object GHNEFKFOBND(this LOKDBPMCGHA HGOBEINKIPD, Type NKICFHCCMMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LJFBOLBAABE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE850", Offset = "0x4EED650", VA = "0x184EEE850")]
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
		[Cpp2IlInjected.Address(RVA = "0x50E98C0", Offset = "0x50E86C0", VA = "0x1850E98C0")]
		public static byte[] OJPOPNBOHID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x50E9830", Offset = "0x50E8630", VA = "0x1850E9830")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EE93F0", Offset = "0x4EE81F0", VA = "0x184EE93F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4EEACB0", Offset = "0x4EE9AB0", VA = "0x184EEACB0")]
	public JBBAGFKBPCP(byte[] HFAIGCGNPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAAC0", Offset = "0x4EE98C0", VA = "0x184EEAAC0")]
	public JBBAGFKBPCP(byte[] HFAIGCGNPJJ, int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7F30", Offset = "0x4EE6D30", VA = "0x184EE7F30")]
	private PBGLHKMPJKG BAPHPGOLANA(string CHPNMHOBKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE86E0", Offset = "0x4EE74E0", VA = "0x184EE86E0")]
	private PBGLHKMPJKG CALGIIKIFLC(string GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9BC0", Offset = "0x4EE89C0", VA = "0x184EE9BC0")]
	public void MHOEICFHDBD(int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0")]
	public byte[] GMGHNENLGFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73E080", Offset = "0x73CE80", VA = "0x18073E080")]
	public int BPONLNLGFFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8B10", Offset = "0x4EE7910", VA = "0x184EE8B10")]
	public NMDNKBAMHJH EDBLNKKPJIK()
	{
		return default(NMDNKBAMHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9860", Offset = "0x4EE8660", VA = "0x184EE9860")]
	public void JPJNFJDEBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8550", Offset = "0x4EE7350", VA = "0x184EE8550")]
	public bool BMGOFCHECKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9B60", Offset = "0x4EE8960", VA = "0x184EE9B60")]
	public bool MDPLCCEBNJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8A20", Offset = "0x4EE7820", VA = "0x184EE8A20")]
	public void DBIGCFOFHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9C50", Offset = "0x4EE8A50", VA = "0x184EE9C50")]
	public bool MMBHAEIDKOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9710", Offset = "0x4EE8510", VA = "0x184EE9710")]
	public bool JJLDEKOPJNA(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8C90", Offset = "0x4EE7A90", VA = "0x184EE8C90")]
	public bool EJMDIIIKDEL(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9440", Offset = "0x4EE8240", VA = "0x184EE9440")]
	public bool IEOMCIFHNHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4EE99A0", Offset = "0x4EE87A0", VA = "0x184EE99A0")]
	public void KKLGFJHGMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8AB0", Offset = "0x4EE78B0", VA = "0x184EE8AB0")]
	public bool DEMHLHDDDCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9BD0", Offset = "0x4EE89D0", VA = "0x184EE9BD0")]
	public bool MJHFGKFLELG(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8950", Offset = "0x4EE7750", VA = "0x184EE8950")]
	public bool CPNPFHLHIAL(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8820", Offset = "0x4EE7620", VA = "0x184EE8820")]
	public bool CMJNBJILBOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8650", Offset = "0x4EE7450", VA = "0x184EE8650")]
	public void BPOGEGJLBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4EEA960", Offset = "0x4EE9760", VA = "0x184EEA960")]
	public bool PKONGHIEMEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8F60", Offset = "0x4EE7D60", VA = "0x184EE8F60")]
	public void GAEBGFBEEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9F90", Offset = "0x4EE8D90", VA = "0x184EE9F90")]
	private void OMIEPDAGOAC(out byte[] EPKHMOEKGLC, out int IOFHHCKLHFO, out int KCALDLLKIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4EE84A0", Offset = "0x4EE72A0", VA = "0x184EE84A0")]
	private static int BIJBALNHBIO(char BMPDKJEHGIN, char BMMLDIMMAAK, char KDPJFGIFCOL, char NAGBPGCPEDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9A90", Offset = "0x4EE8890", VA = "0x184EE9A90")]
	private static int MDCAOGIMPAJ(char KNMKEOOODCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9110", Offset = "0x4EE7F10", VA = "0x184EE9110")]
	public ArraySegment<byte> GMEFMBJNABC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9670", Offset = "0x4EE8470", VA = "0x184EE9670")]
	public string JIGLGCNKCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9410", Offset = "0x4EE8210", VA = "0x184EE9410")]
	public string ICAJOBHBLFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4EE94A0", Offset = "0x4EE82A0", VA = "0x184EE94A0")]
	public ArraySegment<byte> JAPIBLJDOJH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9CB0", Offset = "0x4EE8AB0", VA = "0x184EE9CB0")]
	public ArraySegment<byte> NEALJAMHMPD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9CF0", Offset = "0x4EE8AF0", VA = "0x184EE9CF0")]
	public bool NKLENODONFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9050", Offset = "0x4EE7E50", VA = "0x184EE9050")]
	private static bool GIPJAOPNMEA(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9210", Offset = "0x4EE8010", VA = "0x184EE9210")]
	private void GOLEAFIJAJB(NMDNKBAMHJH MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8A10", Offset = "0x4EE7810", VA = "0x184EE8A10")]
	public void DBEKBMHDCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9790", Offset = "0x4EE8590", VA = "0x184EE9790")]
	private void JJNKMJJELHJ(int JKILKDNNGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8D50", Offset = "0x4EE7B50", VA = "0x184EE8D50")]
	public sbyte FCAFBJELBGE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8FF0", Offset = "0x4EE7DF0", VA = "0x184EE8FF0")]
	public short GBGLBFEDKLJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4EE87C0", Offset = "0x4EE75C0", VA = "0x184EE87C0")]
	public int CGCLBGFIAEF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7EB0", Offset = "0x4EE6CB0", VA = "0x184EE7EB0")]
	public long AKPKAJHPHND()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8440", Offset = "0x4EE7240", VA = "0x184EE8440")]
	public byte BBCKHJFHBCK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9A30", Offset = "0x4EE8830", VA = "0x184EE9A30")]
	public ushort KLFEMFLOKCA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9F30", Offset = "0x4EE8D30", VA = "0x184EE9F30")]
	public uint NNIEICDPABA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4EEA8E0", Offset = "0x4EE96E0", VA = "0x184EEA8E0")]
	public ulong PHHJMKPOOCC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8E90", Offset = "0x4EE7C90", VA = "0x184EE8E90")]
	public float FIPEPGKAELM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8880", Offset = "0x4EE7680", VA = "0x184EE8880")]
	public double COEEEHMEAOP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8DA0", Offset = "0x4EE7BA0", VA = "0x184EE8DA0")]
	public ArraySegment<byte> FGMOAFOJOOI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4EEA750", Offset = "0x4EE9550", VA = "0x184EEA750")]
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
		[Cpp2IlInjected.Address(RVA = "0xE0F690", Offset = "0xE0E490", VA = "0x180E0F690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KACHLMCPGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x77FE30", Offset = "0x77EC30", VA = "0x18077FE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x50F0A30", Offset = "0x50EF830", VA = "0x1850F0A30")]
	public PBGLHKMPJKG(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x50F0AA0", Offset = "0x50EF8A0", VA = "0x1850F0AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
				public JEIEILBPOKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x33CB760", Offset = "0x33CA560", VA = "0x1833CB760")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x50E9580", Offset = "0x50E8380", VA = "0x1850E9580")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E5A10", Offset = "0x50E4810", VA = "0x1850E5A10")]
			public GBENGLEELEP(Type NKICFHCCMMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E82F90", Offset = "0x5E81D90", VA = "0x185E82F90")]
			private static T GMICCBEHNBC<T>(DynamicMethod CGPPEMAFIJG)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x50E57C0", Offset = "0x50E45C0", VA = "0x1850E57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50EC420", Offset = "0x50EB220", VA = "0x1850EC420")]
		static NGEIBPLEEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x50EC390", Offset = "0x50EB190", VA = "0x1850EC390")]
		private static GBENGLEELEP NOCCDIAEOGP(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x50EC0E0", Offset = "0x50EAEE0", VA = "0x1850EC0E0")]
		public static void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x50EC270", Offset = "0x50EB070", VA = "0x1850EC270")]
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
		[Cpp2IlInjected.Address(RVA = "0x50E37C0", Offset = "0x50E25C0", VA = "0x1850E37C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50F16A0", Offset = "0x50F04A0", VA = "0x1850F16A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FLBGIACDMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x50F1640", Offset = "0x50F0440", VA = "0x1850F1640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x50F1860", Offset = "0x50F0660", VA = "0x1850F1860")]
	public static void NCDFCANDEKP(LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2F75420", Offset = "0x2F74220", VA = "0x182F75420")]
	public static byte[] DGAMFOBEJMM<T>(T CCPIHKCBGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2F75230", Offset = "0x2F74030", VA = "0x182F75230")]
	public static byte[] DGAMFOBEJMM<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2F75390", Offset = "0x2F74190", VA = "0x182F75390")]
	public static void DGAMFOBEJMM<T>(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F75150", Offset = "0x2F73F50", VA = "0x182F75150")]
	public static void DGAMFOBEJMM<T>(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2F755C0", Offset = "0x2F743C0", VA = "0x182F755C0")]
	public static void DGAMFOBEJMM<T>(Stream KCFDLMABGLC, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2F754A0", Offset = "0x2F742A0", VA = "0x182F754A0")]
	public static void DGAMFOBEJMM<T>(Stream KCFDLMABGLC, T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2F750B0", Offset = "0x2F73EB0", VA = "0x182F750B0")]
	public static ArraySegment<byte> BKHPEFINPDB<T>(T CCPIHKCBGHF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2F74F30", Offset = "0x2F73D30", VA = "0x182F74F30")]
	public static ArraySegment<byte> BKHPEFINPDB<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2F76A70", Offset = "0x2F75870", VA = "0x182F76A70")]
	public static string LDBAPCDBCDE<T>(T IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2F76AF0", Offset = "0x2F758F0", VA = "0x182F76AF0")]
	public static string LDBAPCDBCDE<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F75FB0", Offset = "0x2F74DB0", VA = "0x182F75FB0")]
	public static T HJFKJCGGCHL<T>(string IKGKCMLCBEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2F76250", Offset = "0x2F75050", VA = "0x182F76250")]
	public static T HJFKJCGGCHL<T>(string IKGKCMLCBEH, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2F767E0", Offset = "0x2F755E0", VA = "0x182F767E0")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2F76050", Offset = "0x2F74E50", VA = "0x182F76050")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2F76860", Offset = "0x2F75660", VA = "0x182F76860")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, int LBACAALGKLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2F760F0", Offset = "0x2F74EF0", VA = "0x182F760F0")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, int LBACAALGKLG, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2F76550", Offset = "0x2F75350", VA = "0x182F76550")]
	public static T HJFKJCGGCHL<T>(ref JBBAGFKBPCP ANKKMEDLEHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2F76340", Offset = "0x2F75140", VA = "0x182F76340")]
	public static T HJFKJCGGCHL<T>(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2F76970", Offset = "0x2F75770", VA = "0x182F76970")]
	public static T HJFKJCGGCHL<T>(Stream KCFDLMABGLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2F765D0", Offset = "0x2F753D0", VA = "0x182F765D0")]
	public static T HJFKJCGGCHL<T>(Stream KCFDLMABGLC, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x50F0FC0", Offset = "0x50EFDC0", VA = "0x1850F0FC0")]
	public static string BADPDEGNDFN(byte[] IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x50F10A0", Offset = "0x50EFEA0", VA = "0x1850F10A0")]
	public static string BADPDEGNDFN(byte[] IKGKCMLCBEH, int LBACAALGKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x50F0EF0", Offset = "0x50EFCF0", VA = "0x1850F0EF0")]
	public static string BADPDEGNDFN(string IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x50F18D0", Offset = "0x50F06D0", VA = "0x1850F18D0")]
	public static byte[] NLNJOHGDHLI(byte[] IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x50F1A80", Offset = "0x50F0880", VA = "0x1850F1A80")]
	public static byte[] NLNJOHGDHLI(byte[] IKGKCMLCBEH, int LBACAALGKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x50F19B0", Offset = "0x50F07B0", VA = "0x1850F19B0")]
	public static byte[] NLNJOHGDHLI(string IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x50F1150", Offset = "0x50EFF50", VA = "0x1850F1150")]
	private static void DJAPCJDBINP(ref JBBAGFKBPCP ANKKMEDLEHC, ref KOGPHPAEDLF MLMFBHHJDGG, int MOLGFCBNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x50F17C0", Offset = "0x50F05C0", VA = "0x1850F17C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73E080", Offset = "0x73CE80", VA = "0x18073E080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9BC0", Offset = "0x4EE89C0", VA = "0x184EE9BC0")]
	public void MHOEICFHDBD(int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDD00", Offset = "0x4EECB00", VA = "0x184EEDD00")]
	public static byte[] PFFPMGLMNKM(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4EED2F0", Offset = "0x4EEC0F0", VA = "0x184EED2F0")]
	public static byte[] HMMNKHOIIGI(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDBC0", Offset = "0x4EEC9C0", VA = "0x184EEDBC0")]
	public static byte[] OPMEIJFJIMK(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4EED050", Offset = "0x4EEBE50", VA = "0x184EED050")]
	public static byte[] FNNMDLAEGOA(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xB8E7F0", Offset = "0xB8D5F0", VA = "0x180B8E7F0")]
	public KOGPHPAEDLF(byte[] JALDPIKJPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDB10", Offset = "0x4EEC910", VA = "0x184EEDB10")]
	public ArraySegment<byte> OJPOPNBOHID()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4EED270", Offset = "0x4EEC070", VA = "0x184EED270")]
	public byte[] HEFOPHLAPJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDE80", Offset = "0x4EECC80", VA = "0x184EEDE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4EED860", Offset = "0x4EEC660", VA = "0x184EED860")]
	public void JHOPBBOOCLA(int GIDHOGLCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB7C0", Offset = "0x4EEA5C0", VA = "0x184EEB7C0")]
	public void NMHKAPAJACH(byte GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDAB0", Offset = "0x4EEC8B0", VA = "0x184EEDAB0")]
	public void NMHKAPAJACH(byte[] GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDA10", Offset = "0x4EEC810", VA = "0x184EEDA10")]
	public void MOLJKIMFMPH(byte GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4EED990", Offset = "0x4EEC790", VA = "0x184EED990")]
	public void LDMMPHGOIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4EECF20", Offset = "0x4EEBD20", VA = "0x184EECF20")]
	public void EEFEAAAPEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4EED940", Offset = "0x4EEC740", VA = "0x184EED940")]
	public void LBNNBDPCDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDE30", Offset = "0x4EECC30", VA = "0x184EEDE30")]
	public void PPKOCOLAHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDDE0", Offset = "0x4EECBE0", VA = "0x184EEDDE0")]
	public void PMPLPLANEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4EECEA0", Offset = "0x4EEBCA0", VA = "0x184EECEA0")]
	public void CPBAKJNJINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4EECF70", Offset = "0x4EEBD70", VA = "0x184EECF70")]
	public void EILJLMDMNKK(string JLHBKPIPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4EED220", Offset = "0x4EEC020", VA = "0x184EED220")]
	public void GHGOIIJGNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4EED870", Offset = "0x4EEC670", VA = "0x184EED870")]
	public void KGAKMFFKNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EECCB0", Offset = "0x4EEBAB0", VA = "0x184EECCB0")]
	public void CHFDGNHALIE(bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4EED1A0", Offset = "0x4EEBFA0", VA = "0x184EED1A0")]
	public void FNOGHMDBDEL(float IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4EECFD0", Offset = "0x4EEBDD0", VA = "0x184EECFD0")]
	public void EPBJIIIEMKA(double IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4EECC50", Offset = "0x4EEBA50", VA = "0x184EECC50")]
	public void BKGDHPNPAMF(byte IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4EECC80", Offset = "0x4EEBA80", VA = "0x184EECC80")]
	public void CEALBOJAPHG(ushort IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4EED800", Offset = "0x4EEC600", VA = "0x184EED800")]
	public void IDNCAIDOKMG(uint IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4EECEF0", Offset = "0x4EEBCF0", VA = "0x184EECEF0")]
	public void DBMGIHAEODI(ulong IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4EED9E0", Offset = "0x4EEC7E0", VA = "0x184EED9E0")]
	public void LNJJBAFCKCP(sbyte IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4EED830", Offset = "0x4EEC630", VA = "0x184EED830")]
	public void IPFPLOLDINI(short IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDA50", Offset = "0x4EEC850", VA = "0x184EEDA50")]
	public void NDLKPLAIPFH(int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDA80", Offset = "0x4EEC880", VA = "0x184EEDA80")]
	public void NJBGPAHMPKF(long IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EED430", Offset = "0x4EEC230", VA = "0x184EED430")]
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
		[Cpp2IlInjected.Address(RVA = "0x252CFF0", Offset = "0x252BDF0", VA = "0x18252CFF0")]
		static FLNNKMACJBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private FPJKPJCPPNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x413BC60", Offset = "0x413AA60", VA = "0x18413BC60")]
	static EDPMACDGMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x413B550", Offset = "0x413A350", VA = "0x18413B550")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE1840", Offset = "0x4EE0640", VA = "0x184EE1840")]
	public GBGIFKGBGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4EE1340", Offset = "0x4EE0140", VA = "0x184EE1340", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector2 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4EE14F0", Offset = "0x4EE02F0", VA = "0x184EE14F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4134860", Offset = "0x4133660", VA = "0x184134860")]
	public BHGNPGKFCBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4134580", Offset = "0x4133380", VA = "0x184134580", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector3 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x41346A0", Offset = "0x41334A0", VA = "0x1841346A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4133E70", Offset = "0x4132C70", VA = "0x184133E70")]
	public BFGOMBAKMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4133B00", Offset = "0x4132900", VA = "0x184133B00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector4 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4133C50", Offset = "0x4132A50", VA = "0x184133C50", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4136A30", Offset = "0x4135830", VA = "0x184136A30")]
	public CMIMAJPBIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4133B00", Offset = "0x4132900", VA = "0x184133B00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Quaternion IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4136810", Offset = "0x4135610", VA = "0x184136810", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE5F90", Offset = "0x4EE4D90", VA = "0x184EE5F90")]
	public IFDHKELCIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5850", Offset = "0x4EE4650", VA = "0x184EE5850", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Color IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5BB0", Offset = "0x4EE49B0", VA = "0x184EE5BB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE3AC0", Offset = "0x4EE28C0", VA = "0x184EE3AC0")]
	public GMLJBDBIOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4EE33F0", Offset = "0x4EE21F0", VA = "0x184EE33F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Bounds IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3640", Offset = "0x4EE2440", VA = "0x184EE3640", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4135E80", Offset = "0x4134C80", VA = "0x184135E80")]
	public CGBFCOIADGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4135AD0", Offset = "0x41348D0", VA = "0x184135AD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Rect IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4135C40", Offset = "0x4134A40", VA = "0x184135C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x41DB500", Offset = "0x41DA300", VA = "0x1841DB500")]
		static FONALAEPIBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private PCFPBNIHFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1981390", Offset = "0x1980190", VA = "0x181981390")]
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
		[Cpp2IlInjected.Address(RVA = "0x50E3850", Offset = "0x50E2650", VA = "0x1850E3850")]
		internal static object IMMPCOIBHEB(Type MGEGOIPHNMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private GGCCKGJOEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x513BA10", Offset = "0x513A810", VA = "0x18513BA10")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private OFECBDCGBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7630", Offset = "0x4EF6430", VA = "0x184EF7630")]
	public static void PJHBAIJLMNC(params LOKDBPMCGHA[] OEHGGFHFBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7710", Offset = "0x4EF6510", VA = "0x184EF7710")]
	public static void PJHBAIJLMNC(params INIKLHPPANG[] FHKOFGFBOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4EF73A0", Offset = "0x4EF61A0", VA = "0x184EF73A0")]
	public static void NEEJJIGHCDA(INIKLHPPANG[] FHKOFGFBOGO, LOKDBPMCGHA[] OEHGGFHFBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x300D800", Offset = "0x300C600", VA = "0x18300D800")]
		static KKGOJDGNJCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private AECIOAJJJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4145520", Offset = "0x4144320", VA = "0x184145520")]
	internal static object IMMPCOIBHEB(Type MGEGOIPHNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4146E80", Offset = "0x4145C80", VA = "0x184146E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x28946C0", Offset = "0x28934C0", VA = "0x1828946C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF0250", Offset = "0x4EEF050", VA = "0x184EF0250")]
	static MPNMGKLJFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private MPNMGKLJFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x199B660", Offset = "0x199A460", VA = "0x18199B660")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEDF40", Offset = "0x4EECD40", VA = "0x184EEDF40")]
	static LCMGKPOECNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private LCMGKPOECNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3061AF0", Offset = "0x30608F0", VA = "0x183061AF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4145190", Offset = "0x4143F90", VA = "0x184145190")]
	static FBIKMDGBHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private FBIKMDGBHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CB9CF0", Offset = "0x2CB8AF0", VA = "0x182CB9CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF0120", Offset = "0x4EEEF20", VA = "0x184EF0120")]
	static MPEOCIFCKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private MPEOCIFCKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D69F0", Offset = "0x27D57F0", VA = "0x1827D69F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x413C690", Offset = "0x413B490", VA = "0x18413C690")]
	static EKFDEAHHJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private EKFDEAHHJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C45FF0", Offset = "0x2C44DF0", VA = "0x182C45FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEC2C0", Offset = "0x4EEB0C0", VA = "0x184EEC2C0")]
	static KINIHMJJGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private KINIHMJJGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x228DF90", Offset = "0x228CD90", VA = "0x18228DF90")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x22897A0", Offset = "0x22885A0", VA = "0x1822897A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x23C01A0", Offset = "0x23BEFA0", VA = "0x1823C01A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC1380", Offset = "0x2BC0180", VA = "0x182BC1380")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C9F70", Offset = "0x24C8D70", VA = "0x1824C9F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x19923C0", Offset = "0x19911C0", VA = "0x1819923C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x50F1D10", Offset = "0x50F0B10", VA = "0x1850F1D10")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E8990", Offset = "0x50E7790", VA = "0x1850E8990")]
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
		[Cpp2IlInjected.Address(RVA = "0x50E9EC0", Offset = "0x50E8CC0", VA = "0x1850E9EC0")]
		public static MethodInfo DGAMFOBEJMM(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x50EA2D0", Offset = "0x50E90D0", VA = "0x1850EA2D0")]
		public static MethodInfo HJFKJCGGCHL(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x50EA190", Offset = "0x50E8F90", VA = "0x1850EA190")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public IADCEBCEGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x50E8270", Offset = "0x50E7070", VA = "0x1850E8270")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x50E82B0", Offset = "0x50E70B0", VA = "0x1850E82B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public AMCJPCCKCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x50E2430", Offset = "0x50E1230", VA = "0x1850E2430")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public EIGLOLGFOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x50E35A0", Offset = "0x50E23A0", VA = "0x1850E35A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HJILECBAOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x50E7C20", Offset = "0x50E6A20", VA = "0x1850E7C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public LFMBAHPIGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x50E9950", Offset = "0x50E8750", VA = "0x1850E9950")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x50E9960", Offset = "0x50E8760", VA = "0x1850E9960")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public EGCLHDEEMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x50E3290", Offset = "0x50E2090", VA = "0x1850E3290")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HCDINGGJEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x66BA10", Offset = "0x66A810", VA = "0x18066BA10")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public IAHHECMJGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x50E8350", Offset = "0x50E7150", VA = "0x1850E8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public GKNHCDNKEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x50E78D0", Offset = "0x50E66D0", VA = "0x1850E78D0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x50E7B80", Offset = "0x50E6980", VA = "0x1850E7B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public JBIOEJEIPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xF049A0", Offset = "0xF037A0", VA = "0x180F049A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public KJOFOODCOKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xF049A0", Offset = "0xF037A0", VA = "0x180F049A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B102D0", Offset = "0x2B0F0D0", VA = "0x182B102D0")]
	public static object JHFDGOLFHCA<T>(ODAALDAPPKD DDEFJEHCKHG, LOKDBPMCGHA HAGKKODIIII, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2B05910", Offset = "0x2B04710", VA = "0x182B05910")]
	public static object COCGOEDNNGF<T>(LOKDBPMCGHA HAGKKODIIII, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK, bool BOAEPGJEDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x41419B0", Offset = "0x41407B0", VA = "0x1841419B0")]
	private static TypeInfo INOHNGCOMJI(ODAALDAPPKD DDEFJEHCKHG, Type NKICFHCCMMH, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x413FDB0", Offset = "0x413EBB0", VA = "0x18413FDB0")]
	public static object HIMKGIIFCGO(Type NKICFHCCMMH, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK, bool BOAEPGJEDHO, bool NPFLMHNGGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x413DE90", Offset = "0x413CC90", VA = "0x18413DE90")]
	private static Dictionary<CPHKEJEHFFI, FieldInfo> BIIIFMOAALF(TypeBuilder CAKAKLGNBLD, OGNLOCKLBCO JENKMGOKHPL, ConstructorInfo MFMGKGDAPJB, FieldBuilder NLBCEPDPEFF, ILGenerator BNJPLGFLIAJ, bool EPFFAOOEBIK, bool AFKBMADDCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x41444D0", Offset = "0x41432D0", VA = "0x1841444D0")]
	private static Dictionary<CPHKEJEHFFI, FieldInfo> PBBEJKFBHPM(TypeBuilder CAKAKLGNBLD, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x413E570", Offset = "0x413D370", VA = "0x18413E570")]
	private static void BIMPNHPDBKC(Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ, Action ICNCKAKELMF, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, bool EPFFAOOEBIK, bool AFKBMADDCEC, int LOHGOPDMHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x413D750", Offset = "0x413C550", VA = "0x18413D750")]
	private static void AICGJENGIME(TypeInfo NKICFHCCMMH, CPHKEJEHFFI KHAAONOKIMB, ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, DCCIMLEJMHH MLMFBHHJDGG, DCCIMLEJMHH JBHOHKLEENF, DCCIMLEJMHH FPBPADHDMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4143090", Offset = "0x4141E90", VA = "0x184143090")]
	private static void ODJGGHNOEPM(Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, bool DHDCDPCPHMO, int LOHGOPDMHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4142440", Offset = "0x4141240", VA = "0x184142440")]
	private static void JLHDIJGLJDI(ILGenerator BNJPLGFLIAJ, AIBNMNAFNCM JENKMGOKHPL, int AIPHGHFENPJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, DCCIMLEJMHH ANKKMEDLEHC, DCCIMLEJMHH FPBPADHDMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x413CAA0", Offset = "0x413B8A0", VA = "0x18413CAA0")]
	private static LocalBuilder AGKGPBPIMDB(ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, AIBNMNAFNCM[] OEKDHDGKNIJ, bool FOPIGMBNEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4142990", Offset = "0x4141790", VA = "0x184142990")]
	private static bool LJCEKNKDABK(ConstructorInfo KEMDDJPADGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x413FC00", Offset = "0x413EA00", VA = "0x18413FC00")]
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
	[Cpp2IlInjected.Address(RVA = "0x27B1640", Offset = "0x27B0440", VA = "0x1827B1640")]
	public OHCOAOGFFMP(byte[][] NLBCEPDPEFF, object[] NNAJOCDFKGN, object[] JNANILGLAGM, global::DHFBONEBMAN<T> NHGODJCEDDK, global::GACMKDJBDLB<T> HEEJCHPDFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2EE1C20", Offset = "0x2EE0A20", VA = "0x182EE1C20", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2EE1D00", Offset = "0x2EE0B00", VA = "0x182EE1D00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CB5BC0", Offset = "0x2CB49C0", VA = "0x182CB5BC0")]
		static NIFOIMLPMFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private NHMDKOJMPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x30512A0", Offset = "0x30500A0", VA = "0x1830512A0")]
		static PFDPDCJHJHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private PLGJBPIIGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3509EC0", Offset = "0x3508CC0", VA = "0x183509EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x227F130", Offset = "0x227DF30", VA = "0x18227F130")]
			static AGBCCLGNMHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private GJAGDDOOIGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private OJGKJBIIILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BFB3F0", Offset = "0x2BFA1F0", VA = "0x182BFB3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D5DB10", Offset = "0x2D5C910", VA = "0x182D5DB10")]
			static LMLGOHNCAOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private NANBDBICHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private EFNMFAPIKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x263D600", Offset = "0x263C400", VA = "0x18263D600")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A89F80", Offset = "0x3A88D80", VA = "0x183A89F80")]
			static LAHJHKFCDOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private ELFLPGMAPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private ONAMNPOMKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D5E7C0", Offset = "0x2D5D5C0", VA = "0x182D5E7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BD9D10", Offset = "0x2BD8B10", VA = "0x182BD9D10")]
			static HLAAMGOAKNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private BAPBGFPHFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private OPNDONGIHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x309A0E0", Offset = "0x3098EE0", VA = "0x18309A0E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D03970", Offset = "0x2D02770", VA = "0x182D03970")]
			static MCDCILNPIEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private AFEPIEBMHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private PFMMLNKGMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x24B9100", Offset = "0x24B7F00", VA = "0x1824B9100")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EC0A60", Offset = "0x2EBF860", VA = "0x182EC0A60")]
			static PDOJGJOLGIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private CBHPGKCLJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private LMALOAECNMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3012860", Offset = "0x3011660", VA = "0x183012860")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BF8020", Offset = "0x2BF6E20", VA = "0x182BF8020")]
			static KAGNCNBLIMJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private MPDMCIPCILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private FMOBBBPOAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FFCE20", Offset = "0x2FFBC20", VA = "0x182FFCE20")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C4EA30", Offset = "0x2C4D830", VA = "0x182C4EA30")]
			static JNKKDEGCIHL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private INDOHLPBKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private KDGOIEKLNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x331F100", Offset = "0x331DF00", VA = "0x18331F100")]
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
			[Cpp2IlInjected.Address(RVA = "0x31CC1E0", Offset = "0x31CAFE0", VA = "0x1831CC1E0")]
			static JHFBIBKPIHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private NGCOOAIBJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private ONLIBBOOLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x27DF7D0", Offset = "0x27DE5D0", VA = "0x1827DF7D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x24C55B0", Offset = "0x24C43B0", VA = "0x1824C55B0")]
			static CMEGECDDPEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private EALEFALAMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private JCNGDHHCIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x27E7FF0", Offset = "0x27E6DF0", VA = "0x1827E7FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x25BB3B0", Offset = "0x25BA1B0", VA = "0x1825BB3B0")]
			static DENOGIFGKAP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private ODDFHJDFAPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private CCPPKCGFGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D0CBD0", Offset = "0x2D0B9D0", VA = "0x182D0CBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x245D110", Offset = "0x245BF10", VA = "0x18245D110")]
			static FGFJDOHEBDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private JCOCGCAPBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	private ECAABBFCBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9970", Offset = "0x1DD8770", VA = "0x181DD9970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3055430", Offset = "0x3054230", VA = "0x183055430")]
	public PFFGLIOAFFG(int AIGDDFDNOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x30552B0", Offset = "0x30540B0", VA = "0x1830552B0")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x30553A0", Offset = "0x30541A0", VA = "0x1830553A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEAF80", Offset = "0x4EE9D80", VA = "0x184EEAF80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2FF7460", Offset = "0x2FF6260", VA = "0x182FF7460")]
	public KEFICJEPPGO(int FMGFIHODCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2FF71B0", Offset = "0x2FF5FB0", VA = "0x182FF71B0")]
	public T[] ACAAPGHKAHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FF6730", Offset = "0x2FF5530", VA = "0x182FF6730")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
			[DebuggerHidden]
			public EHFOANLNPOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x50E3430", Offset = "0x50E2230", VA = "0x1850E3430", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x50E3560", Offset = "0x50E2360", VA = "0x1850E3560", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x50E34C0", Offset = "0x50E22C0", VA = "0x1850E34C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AHENJGGJBFD> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x50E34C0", Offset = "0x50E22C0", VA = "0x1850E34C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public APBNGAIOKMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x66BA10", Offset = "0x66A810", VA = "0x18066BA10")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x66BA10", Offset = "0x66A810", VA = "0x18066BA10")]
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
			[Cpp2IlInjected.Address(RVA = "0xABF030", Offset = "0xABDE30", VA = "0x180ABF030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x50E2370", Offset = "0x50E1170", VA = "0x1850E2370")]
		public AHENJGGJBFD(ulong CCJNKBLKLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x50E0FC0", Offset = "0x50DFDC0", VA = "0x1850E0FC0")]
		public AHENJGGJBFD HEFJCCLOLGO(ulong CCJNKBLKLDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x50E0F70", Offset = "0x50DFD70", VA = "0x1850E0F70")]
		public AHENJGGJBFD HEFJCCLOLGO(ulong CCJNKBLKLDJ, int IGJPNMBCJPK, string MGKBPDDPAGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x50E1F70", Offset = "0x50E0D70", VA = "0x1850E1F70")]
		public AHENJGGJBFD KODACLNEAKH(byte[] JOLHNMOCKDJ, ref int LBACAALGKLG, ref int NCJHPIDHIAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x50E2260", Offset = "0x50E1060", VA = "0x1850E2260")]
		internal static int MIFBMIGANDK(ulong[] DEJEDNNJILK, int AIPHGHFENPJ, int GKPOMAIMOAK, ulong IGJPNMBCJPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x50E0F40", Offset = "0x50DFD40", VA = "0x1850E0F40", Slot = "4")]
		public int CompareTo(AHENJGGJBFD HNOJKNGFFBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x50E0ED0", Offset = "0x50DFCD0", VA = "0x1850E0ED0")]
		[IteratorStateMachine(typeof(EHFOANLNPOE))]
		public IEnumerable<AHENJGGJBFD> BLJCNLIHGCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x50E2120", Offset = "0x50E0F20", VA = "0x1850E2120")]
		public void MGBOALHDBNH(ILGenerator BNJPLGFLIAJ, LocalBuilder JOLHNMOCKDJ, LocalBuilder NCJHPIDHIAK, LocalBuilder CCJNKBLKLDJ, Action<KeyValuePair<string, int>> EOLLFGFOCNE, Action HOHJLGNLOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x50E1280", Offset = "0x50E0080", VA = "0x1850E1280")]
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
			[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x50ECAA0", Offset = "0x50EB8A0", VA = "0x1850ECAA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8B3770", Offset = "0x8B2570", VA = "0x1808B3770")]
		[DebuggerHidden]
		public NMLCLJAJEPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x50ECAF0", Offset = "0x50EB8F0", VA = "0x1850ECAF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x50EC560", Offset = "0x50EB360", VA = "0x1850EC560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x50ECBD0", Offset = "0x50EB9D0", VA = "0x1850ECBD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x50ECC20", Offset = "0x50EBA20", VA = "0x1850ECC20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x50ECA60", Offset = "0x50EB860", VA = "0x1850ECA60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x50EC9C0", Offset = "0x50EB7C0", VA = "0x1850EC9C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x50EC9C0", Offset = "0x50EB7C0", VA = "0x1850EC9C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEE6D0", Offset = "0x4EED4D0", VA = "0x184EEE6D0")]
	public LEFEBFDEKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE190", Offset = "0x4EECF90", VA = "0x184EEE190")]
	public void HEFJCCLOLGO(byte[] HFAIGCGNPJJ, int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE2B0", Offset = "0x4EED0B0", VA = "0x184EEE2B0")]
	public bool IFNCCANGCPM(ArraySegment<byte> CCJNKBLKLDJ, out int IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE640", Offset = "0x4EED440", VA = "0x184EEE640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE3A0", Offset = "0x4EED1A0", VA = "0x184EEE3A0")]
	private static void PPPIDEIAKDM(IEnumerable<AHENJGGJBFD> CCMIPADPMIA, StringBuilder NHDKHCEFNFI, int MOLGFCBNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE0E0", Offset = "0x4EECEE0", VA = "0x184EEE0E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE0E0", Offset = "0x4EECEE0", VA = "0x184EEE0E0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE070", Offset = "0x4EECE70", VA = "0x184EEE070")]
	[IteratorStateMachine(typeof(NMLCLJAJEPL))]
	private static IEnumerable<KeyValuePair<string, int>> FIODJCALBMH(IEnumerable<AHENJGGJBFD> CCMIPADPMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE370", Offset = "0x4EED170", VA = "0x184EEE370")]
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
	[Cpp2IlInjected.Address(RVA = "0x41326D0", Offset = "0x41314D0", VA = "0x1841326D0")]
	public static ulong GHADMMGMIIG(byte[] HFAIGCGNPJJ, ref int LBACAALGKLG, ref int NCJHPIDHIAK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class BOFKLCAIDMC
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4135140", Offset = "0x4133F40", VA = "0x184135140")]
	public static void JHOPBBOOCLA(ref byte[] HFAIGCGNPJJ, int LBACAALGKLG, int GIDHOGLCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4135280", Offset = "0x4134080", VA = "0x184135280")]
	public static void ONKELFNAKMD(ref byte[] DEJEDNNJILK, int EPOAMOEJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4135020", Offset = "0x4133E20", VA = "0x184135020")]
	public static byte[] DEPPCLKCHBF(byte[] ICAAAENIBKC, int EPOAMOEJPAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class BHBJCDJCMNC
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x41344F0", Offset = "0x41332F0", VA = "0x1841344F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x21C1420", Offset = "0x21C0220", VA = "0x1821C1420", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x25B5520", Offset = "0x25B4320", VA = "0x1825B5520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1EB9940", Offset = "0x1EB8740", VA = "0x181EB9940")]
		[DebuggerHidden]
		public DCPBCPGEPJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x309D5B0", Offset = "0x309C3B0", VA = "0x18309D5B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x309DAA0", Offset = "0x309C8A0", VA = "0x18309DAA0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3517EA0", Offset = "0x3516CA0", VA = "0x183517EA0")]
	public JDGGAPLDNFH(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3517DE0", Offset = "0x3516BE0", VA = "0x183517DE0")]
	public JDGGAPLDNFH(int CHMDLBBFMNF, float FLHOHCCGGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x35177B0", Offset = "0x35165B0", VA = "0x1835177B0")]
	public void HEFJCCLOLGO(byte[] CCJNKBLKLDJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3516190", Offset = "0x3514F90", VA = "0x183516190")]
	private bool FGMLDBJKNBM(byte[] CCJNKBLKLDJ, T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3513A90", Offset = "0x3512890", VA = "0x183513A90")]
	public bool CECEMJJAJEO(ArraySegment<byte> CCJNKBLKLDJ, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3517240", Offset = "0x3516040", VA = "0x183517240")]
	private static ulong GJIHLCDPCGO(byte[] KNMKEOOODCL, int LBACAALGKLG, int KOHJDBBJEKM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3517DB0", Offset = "0x3516BB0", VA = "0x183517DB0")]
	private static int MCHGIMDMKJF(int EOHIDHOLHCB, float FLHOHCCGGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3517330", Offset = "0x3516130", VA = "0x183517330", Slot = "4")]
	[IteratorStateMachine(typeof(global::JDGGAPLDNFH<>.DCPBCPGEPJF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x24C7070", Offset = "0x24C5E70", VA = "0x1824C7070", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EF0C60", Offset = "0x4EEFA60", VA = "0x184EF0C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0DD0", Offset = "0x4EEFBD0", VA = "0x184EF0DD0")]
	static NLBDDAGFCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4EF1050", Offset = "0x4EEFE50", VA = "0x184EF1050")]
	public NLBDDAGFCEM(byte[] EHDMHONDOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0CB0", Offset = "0x4EEFAB0", VA = "0x184EF0CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF6F60", Offset = "0x4EF5D60", VA = "0x184EF6F60")]
	public ODHCMGIBAIG(ref Guid IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4EF5B10", Offset = "0x4EF4910", VA = "0x184EF5B10")]
	public ODHCMGIBAIG(ref ArraySegment<byte> APMMOIAIFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4520", Offset = "0x4EF3320", VA = "0x184EF4520")]
	private static byte CGCLCMEAHFG(byte[] HFAIGCGNPJJ, int IDILNIFMOPD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4EF5930", Offset = "0x4EF4730", VA = "0x184EF5930")]
	private static byte KOIBBIEFGGE(byte BMMLDIMMAAK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4EF45E0", Offset = "0x4EF33E0", VA = "0x184EF45E0")]
	public void FJGIJIFMICL(byte[] CLABEIKAHOI, int LBACAALGKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class OLMHCAFJHFJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x50EE890", Offset = "0x50ED690", VA = "0x1850EE890")]
	public static bool BCLLAJPEGNE(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x50EE8A0", Offset = "0x50ED6A0", VA = "0x1850EE8A0")]
	public static bool BEGGFPCIAKB(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x50EF1C0", Offset = "0x50EDFC0", VA = "0x1850EF1C0")]
	public static sbyte FCAFBJELBGE(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x50EF2A0", Offset = "0x50EE0A0", VA = "0x1850EF2A0")]
	public static short GBGLBFEDKLJ(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x50EE910", Offset = "0x50ED710", VA = "0x1850EE910")]
	public static int CGCLBGFIAEF(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x50EE770", Offset = "0x50ED570", VA = "0x1850EE770")]
	public static long AKPKAJHPHND(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x50EE820", Offset = "0x50ED620", VA = "0x1850EE820")]
	public static byte BBCKHJFHBCK(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x50EF310", Offset = "0x50EE110", VA = "0x1850EF310")]
	public static ushort KLFEMFLOKCA(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x50F0220", Offset = "0x50EF020", VA = "0x1850F0220")]
	public static uint NNIEICDPABA(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x50F02A0", Offset = "0x50EF0A0", VA = "0x1850F02A0")]
	public static ulong PHHJMKPOOCC(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x50EF230", Offset = "0x50EE030", VA = "0x1850EF230")]
	public static float FIPEPGKAELM(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x50EE980", Offset = "0x50ED780", VA = "0x1850EE980")]
	public static double COEEEHMEAOP(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x50EE9F0", Offset = "0x50ED7F0", VA = "0x1850EE9F0")]
	public static int DBMGIHAEODI(ref byte[] CLABEIKAHOI, int LBACAALGKLG, ulong IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x50EF380", Offset = "0x50EE180", VA = "0x1850EF380")]
	public static int NJBGPAHMPKF(ref byte[] CLABEIKAHOI, int LBACAALGKLG, long IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x50EFFB0", Offset = "0x50EEDB0", VA = "0x1850EFFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
		[DebuggerHidden]
		public HKPLMCLJINN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x50E80E0", Offset = "0x50E6EE0", VA = "0x1850E80E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x50E7C80", Offset = "0x50E6A80", VA = "0x1850E7C80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x50E81D0", Offset = "0x50E6FD0", VA = "0x1850E81D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x50E8220", Offset = "0x50E7020", VA = "0x1850E8220")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x50E80A0", Offset = "0x50E6EA0", VA = "0x1850E80A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x50E7FF0", Offset = "0x50E6DF0", VA = "0x1850E7FF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x50E7FF0", Offset = "0x50E6DF0", VA = "0x1850E7FF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
		[DebuggerHidden]
		public BJDICECIMCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x50E2AF0", Offset = "0x50E18F0", VA = "0x1850E2AF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x50E2690", Offset = "0x50E1490", VA = "0x1850E2690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x50E2BE0", Offset = "0x50E19E0", VA = "0x1850E2BE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x50E2C30", Offset = "0x50E1A30", VA = "0x1850E2C30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x50E2AB0", Offset = "0x50E18B0", VA = "0x1850E2AB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x50E2A00", Offset = "0x50E1800", VA = "0x1850E2A00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x50E2A00", Offset = "0x50E1800", VA = "0x1850E2A00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x413A720", Offset = "0x4139520", VA = "0x18413A720")]
	public static bool EBDPBJNODHF(this TypeInfo NKICFHCCMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x413A940", Offset = "0x4139740", VA = "0x18413A940")]
	public static bool NKMPCKAKMFA(this TypeInfo NKICFHCCMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x413AAF0", Offset = "0x41398F0", VA = "0x18413AAF0")]
	public static IEnumerable<PropertyInfo> OGCLJNMGCPK(this Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x413A8B0", Offset = "0x41396B0", VA = "0x18413A8B0")]
	[IteratorStateMachine(typeof(HKPLMCLJINN))]
	private static IEnumerable<PropertyInfo> JJMEBKKINAO(Type NKICFHCCMMH, HashSet<string> BNCEPBFPPIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x413A7E0", Offset = "0x41395E0", VA = "0x18413A7E0")]
	public static IEnumerable<FieldInfo> EKMIJLCFOOM(this Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x413AA60", Offset = "0x4139860", VA = "0x18413AA60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	public static string PKBMJFALMOK(string JELKAOENNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC3F0", Offset = "0x4EEB1F0", VA = "0x184EEC3F0")]
	public static string EEOGDNNBLDD(string JELKAOENNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC500", Offset = "0x4EEB300", VA = "0x184EEC500")]
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
		[Cpp2IlInjected.Address(RVA = "0x23C6440", Offset = "0x23C5240", VA = "0x1823C6440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x23C63C0", Offset = "0x23C51C0", VA = "0x1823C63C0")]
		private int MNCJKLLDCNE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
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
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public NMAHKMCIBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xAC10F0", Offset = "0xABFEF0", VA = "0x180AC10F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4558240", Offset = "0x4557040", VA = "0x184558240")]
	public DIEINJJIANO(int CHMDLBBFMNF = 4, float FLHOHCCGGBP = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4557600", Offset = "0x4556400", VA = "0x184557600")]
	public bool LHAEMCGIOMO(Type CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4557750", Offset = "0x4556550", VA = "0x184557750")]
	public bool LHAEMCGIOMO(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4557030", Offset = "0x4555E30", VA = "0x184557030")]
	private bool FGMLDBJKNBM(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO, out TValue PNFHPOBCPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x45578A0", Offset = "0x45566A0", VA = "0x1845578A0")]
	private bool MKEGPABBLJI(BNIKACKJNKP[] BINDDLEDHON, Type PJEADMGHKIL, BNIKACKJNKP KNPOBLIOELK, Func<Type, TValue> BOHBMFGICDO, out TValue PNFHPOBCPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4556EE0", Offset = "0x4555CE0", VA = "0x184556EE0")]
	public bool CECEMJJAJEO(Type CCJNKBLKLDJ, out TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4558000", Offset = "0x4556E00", VA = "0x184558000")]
	public TValue NOCCDIAEOGP(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3517DB0", Offset = "0x3516BB0", VA = "0x183517DB0")]
	private static int MCHGIMDMKJF(int EOHIDHOLHCB, float FLHOHCCGGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x45575D0", Offset = "0x45563D0", VA = "0x1845575D0")]
	private static void LGCDJLBFEOG(ref BNIKACKJNKP DEHOGNNECIF, BNIKACKJNKP IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x45575D0", Offset = "0x45563D0", VA = "0x1845575D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF3F20", Offset = "0x4EF2D20", VA = "0x184EF3F20")]
	public TypeBuilder FAKEPLAFAMN(string BEMAPDNKPAD, TypeAttributes ACIANFKCINM, Type ADECAOLBLPJ, Type[] HBAHBAGNFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x4EF3FF0", Offset = "0x4EF2DF0", VA = "0x184EF3FF0")]
	public ODAALDAPPKD(string LKBDENNFFEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class DINIDBMPFMB
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x413A650", Offset = "0x4139450", VA = "0x18413A650")]
	private static MethodInfo COPNDAHKOKA(LambdaExpression INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2362C40", Offset = "0x2361A40", VA = "0x182362C40")]
	public static MethodInfo EKPOHGDIGNJ<T>(Expression<Func<T>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2362C40", Offset = "0x2361A40", VA = "0x182362C40")]
	public static MethodInfo EKPOHGDIGNJ<T, TR>(Expression<Func<T, TR>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2362C40", Offset = "0x2361A40", VA = "0x182362C40")]
	public static MethodInfo EKPOHGDIGNJ<T>(Expression<Action<T>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2362C40", Offset = "0x2361A40", VA = "0x182362C40")]
	public static MethodInfo EKPOHGDIGNJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x2362C50", Offset = "0x2361A50", VA = "0x182362C50")]
	private static MemberInfo ELHFDECGBEO<T>(Expression<T> IKPEGPHMIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2362BE0", Offset = "0x23619E0", VA = "0x182362BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4139170", Offset = "0x4137F70", VA = "0x184139170")]
	public DCCIMLEJMHH(ILGenerator BNJPLGFLIAJ, int HLAPKJLCEDC, bool KGPNFOGGFDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x41390E0", Offset = "0x4137EE0", VA = "0x1841390E0")]
	public DCCIMLEJMHH(ILGenerator BNJPLGFLIAJ, int HLAPKJLCEDC, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x41390C0", Offset = "0x4137EC0", VA = "0x1841390C0")]
	public void NPFEGMBBAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class IHKLPGNLPGD
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6A20", Offset = "0x4EE5820", VA = "0x184EE6A20")]
	public static void IAKIHNPGLMM(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4EE69E0", Offset = "0x4EE57E0", VA = "0x184EE69E0")]
	public static void IAKIHNPGLMM(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6E10", Offset = "0x4EE5C10", VA = "0x184EE6E10")]
	public static void MHEHNDFBLFF(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6DD0", Offset = "0x4EE5BD0", VA = "0x184EE6DD0")]
	public static void MHEHNDFBLFF(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4EE66D0", Offset = "0x4EE54D0", VA = "0x184EE66D0")]
	public static void FEPBJPBPFGA(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4EE65C0", Offset = "0x4EE53C0", VA = "0x184EE65C0")]
	public static void FEPBJPBPFGA(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7040", Offset = "0x4EE5E40", VA = "0x184EE7040")]
	public static void MKOFPOGIEJE(this ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7150", Offset = "0x4EE5F50", VA = "0x184EE7150")]
	public static void OJCINDEKKBB(this ILGenerator BNJPLGFLIAJ, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7160", Offset = "0x4EE5F60", VA = "0x184EE7160")]
	public static void PFHIEDGBLKN(this ILGenerator BNJPLGFLIAJ, int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6CE0", Offset = "0x4EE5AE0", VA = "0x184EE6CE0")]
	public static void KECCPPHAMND(this ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6840", Offset = "0x4EE5640", VA = "0x184EE6840")]
	public static void FHNJGMJIFEM(this ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6390", Offset = "0x4EE5190", VA = "0x184EE6390")]
	public static void DAJDJDJAPAE(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4EE67C0", Offset = "0x4EE55C0", VA = "0x184EE67C0")]
	public static void FGEFJHEMAOJ(this ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4EE68F0", Offset = "0x4EE56F0", VA = "0x184EE68F0")]
	public static void FOJJIHBCHFI(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7050", Offset = "0x4EE5E50", VA = "0x184EE7050")]
	public static void OBKNFOMFJIE(this ILGenerator BNJPLGFLIAJ, MethodInfo MKNJAKNCPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6C50", Offset = "0x4EE5A50", VA = "0x184EE6C50")]
	public static void IBJJLGAIEOE(this ILGenerator BNJPLGFLIAJ, FieldInfo LJNGIPHLJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6300", Offset = "0x4EE5100", VA = "0x184EE6300")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public JCPIBIIPIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x50E8880", Offset = "0x50E7680", VA = "0x1850E8880")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string GKGPGJHPFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x660AF0", Offset = "0x65F8F0", VA = "0x180660AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MHDKIMHMKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4138870", Offset = "0x4137670", VA = "0x184138870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BGKNHKLPBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x65BD70", Offset = "0x65AB70", VA = "0x18065BD70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7B1470", Offset = "0x7B0270", VA = "0x1807B1470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DFGCAAIFPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x65BD80", Offset = "0x65AB80", VA = "0x18065BD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xB3CE20", Offset = "0xB3BC20", VA = "0x180B3CE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6B19E0", Offset = "0x6B07E0", VA = "0x1806B19E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo GPCNMDPLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6B19F0", Offset = "0x6B07F0", VA = "0x1806B19F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo HPOEGHCFBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x661A10", Offset = "0x660810", VA = "0x180661A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x661A20", Offset = "0x660820", VA = "0x180661A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo KBFGBFIFGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x67EA40", Offset = "0x67D840", VA = "0x18067EA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x67EB70", Offset = "0x67D970", VA = "0x18067EB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4138CC0", Offset = "0x4137AC0", VA = "0x184138CC0")]
	protected CPHKEJEHFFI(Type NKICFHCCMMH, string BEMAPDNKPAD, string NNNOJJMLEJC, bool OIGNCOPLCNN, bool JNEIHELLFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4138BB0", Offset = "0x41379B0", VA = "0x184138BB0")]
	public CPHKEJEHFFI(FieldInfo JENKMGOKHPL, string BEMAPDNKPAD, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4138A00", Offset = "0x4137800", VA = "0x184138A00")]
	public CPHKEJEHFFI(PropertyInfo JENKMGOKHPL, string BEMAPDNKPAD, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x4138700", Offset = "0x4137500", VA = "0x184138700")]
	private static MethodInfo CDJPIALPBDP(MemberInfo JENKMGOKHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1F83880", Offset = "0x1F82680", VA = "0x181F83880")]
	public T CLMCKOPCBOH<T>(bool ODPKDODHNDF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4138880", Offset = "0x4137680", VA = "0x184138880", Slot = "4")]
	public virtual void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4138940", Offset = "0x4137740", VA = "0x184138940", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEF080", Offset = "0x4EEDE80", VA = "0x184EEF080")]
	public LNIOBANDANN(string BEMAPDNKPAD, string BGHBALDEJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEF80", Offset = "0x4EEDD80", VA = "0x184EEEF80", Slot = "4")]
	public override void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF040", Offset = "0x4EEDE40", VA = "0x184EEF040", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x412E7A0", Offset = "0x412D5A0", VA = "0x18412E7A0")]
	public AFCJBCIFGFM(string BEMAPDNKPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x412E140", Offset = "0x412CF40", VA = "0x18412E140", Slot = "4")]
	public override void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x412E210", Offset = "0x412D010", VA = "0x18412E210", Slot = "5")]
	public override void NNPPNMEPLJK(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x412DFF0", Offset = "0x412CDF0", VA = "0x18412DFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IHJKHNKCKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x65B260", Offset = "0x65A060", VA = "0x18065B260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x776830", Offset = "0x775630", VA = "0x180776830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FMKOEAAGOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xDCFBC0", Offset = "0xDCE9C0", VA = "0x180DCFBC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xC46840", Offset = "0xC45640", VA = "0x180C46840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo DNIMABPHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CPHKEJEHFFI[] EIAFCALOOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6B19E0", Offset = "0x6B07E0", VA = "0x1806B19E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CPHKEJEHFFI[] IPLHAKIFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6B19F0", Offset = "0x6B07F0", VA = "0x1806B19F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x50ECF20", Offset = "0x50EBD20", VA = "0x1850ECF20")]
	public OGNLOCKLBCO(Type NKICFHCCMMH, Func<string, string> HMKJPMFPIEE, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x50ECE30", Offset = "0x50EBC30", VA = "0x1850ECE30")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D366F0", Offset = "0x1D354F0", VA = "0x181D366F0")]
	public MCKOGFAAPEO(ulong OLKMBLPMENH, int MAJAOEBPCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF270", Offset = "0x4EEE070", VA = "0x184EEF270")]
	public void HPPMEINDINK(ref MCKOGFAAPEO HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF280", Offset = "0x4EEE080", VA = "0x184EEF280")]
	public static MCKOGFAAPEO KLGDEBEOEEG(ref MCKOGFAAPEO BMPDKJEHGIN, ref MCKOGFAAPEO BMMLDIMMAAK)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF140", Offset = "0x4EEDF40", VA = "0x184EEF140")]
	public void HBKIGLGNGGK(ref MCKOGFAAPEO HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF1D0", Offset = "0x4EEDFD0", VA = "0x184EEF1D0")]
	public static MCKOGFAAPEO HPCAGJGHFCC(ref MCKOGFAAPEO BMPDKJEHGIN, ref MCKOGFAAPEO BMMLDIMMAAK)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF2E0", Offset = "0x4EEE0E0", VA = "0x184EEF2E0")]
	public void PIDPECDHIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF290", Offset = "0x4EEE090", VA = "0x184EEF290")]
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
	[Cpp2IlInjected.Address(RVA = "0x8B52D0", Offset = "0x8B40D0", VA = "0x1808B52D0")]
	public KBDAPDCFLAC(byte[] CLABEIKAHOI, int EIIEKPIPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB7C0", Offset = "0x4EEA5C0", VA = "0x184EEB7C0")]
	public void KNMCHABHDGK(byte JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB6A0", Offset = "0x4EEA4A0", VA = "0x184EEB6A0")]
	public void ANNLPGCBPFJ(byte[] JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB550", Offset = "0x4EEA350", VA = "0x184EEB550")]
	public void AANBBHIJCGF(byte[] JNFDLMOFJOO, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB5F0", Offset = "0x4EEA3F0", VA = "0x184EEB5F0")]
	public void AANBBHIJCGF(byte[] JNFDLMOFJOO, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB740", Offset = "0x4EEA540", VA = "0x184EEB740")]
	public void FGKBCOEHMKB(byte KDPJFGIFCOL, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB820", Offset = "0x4EEA620", VA = "0x184EEB820")]
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
	[Cpp2IlInjected.Address(RVA = "0x4130510", Offset = "0x412F310", VA = "0x184130510")]
	private static byte[] DENDMDEOIEF(int MNKEEJPGFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x41315D0", Offset = "0x41303D0", VA = "0x1841315D0")]
	private static byte[] KNKAFADDMNC(int MNKEEJPGFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4130E00", Offset = "0x412FC00", VA = "0x184130E00")]
	public static int FMAJACAKGLG(ref byte[] CLABEIKAHOI, int LBACAALGKLG, float IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4130F20", Offset = "0x412FD20", VA = "0x184130F20")]
	public static int FMAJACAKGLG(ref byte[] CLABEIKAHOI, int LBACAALGKLG, double IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4131BD0", Offset = "0x41309D0", VA = "0x184131BD0")]
	private static bool NPBHHOBBNHH(byte[] CLABEIKAHOI, int GKPOMAIMOAK, ulong PMPHKPPDOJC, ulong BCPLKCMOHKM, ulong NCJHPIDHIAK, ulong NPOGEPMNLAA, ulong MHKGIFOFBOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x41303F0", Offset = "0x412F1F0", VA = "0x1841303F0")]
	private static void BCNPPMPAPCL(uint IGDINCONBGD, int FNAGAAEAGLL, out uint ONBODKODHNJ, out int FONFFOECJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x41316B0", Offset = "0x41304B0", VA = "0x1841316B0")]
	private static bool LEEOIBBLNPL(MCKOGFAAPEO MCDGEBBILIJ, MCKOGFAAPEO KKGHEBDDELA, MCKOGFAAPEO ILAOCNGHFLG, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int FMPGCHGBDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4131330", Offset = "0x4130130", VA = "0x184131330")]
	private static bool JILABDDABEE(double HFMHCLGICNJ, BAFKPIKAHOE CIJCIMPGNPO, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int KAKDIMEDOFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4131220", Offset = "0x4130020", VA = "0x184131220")]
	private static bool IDCMKILOJPD(double HFMHCLGICNJ, BAFKPIKAHOE CIJCIMPGNPO, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int MFEBBMOCEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4130260", Offset = "0x412F060", VA = "0x184130260")]
	private static bool AFLDOJPDIED(double IGJPNMBCJPK, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x41305F0", Offset = "0x412F3F0", VA = "0x1841305F0")]
	private static bool DKHFMDGCBGD(double IGJPNMBCJPK, ref KBDAPDCFLAC CAGCFAOHBGH, JHIAIDKOECC CIJCIMPGNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4131040", Offset = "0x412FE40", VA = "0x184131040")]
	private static void GILALFMFGMN(byte[] JEBACMJJMOF, int GKPOMAIMOAK, int MFEBBMOCEMA, int FCECNJBELMF, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4131CD0", Offset = "0x4130AD0", VA = "0x184131CD0")]
	private static void PBIDELMGLLI(byte[] JEBACMJJMOF, int GKPOMAIMOAK, int MAJAOEBPCPC, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4130C50", Offset = "0x412FA50", VA = "0x184130C50")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF8020", Offset = "0x4EF6E20", VA = "0x184EF8020")]
	public OFMMJKGGOIM(double NAGBPGCPEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7F80", Offset = "0x4EF6D80", VA = "0x184EF7F80")]
	public OFMMJKGGOIM(MCKOGFAAPEO NAGBPGCPEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4EF79D0", Offset = "0x4EF67D0", VA = "0x184EF79D0")]
	public MCKOGFAAPEO BPIMNDEHAPO()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7BB0", Offset = "0x4EF69B0", VA = "0x184EF7BB0")]
	public MCKOGFAAPEO GEPPNEBKBOJ()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0")]
	public ulong HCIJEIGLJKD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7C40", Offset = "0x4EF6A40", VA = "0x184EF7C40")]
	public double GOOCLIIJOMI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7EA0", Offset = "0x4EF6CA0", VA = "0x184EF7EA0")]
	public double OKEODFPJMBI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7A50", Offset = "0x4EF6850", VA = "0x184EF7A50")]
	public int CKACGJLIEFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7B80", Offset = "0x4EF6980", VA = "0x184EF7B80")]
	public ulong GCAODMKHGBH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7B60", Offset = "0x4EF6960", VA = "0x184EF7B60")]
	public bool GAENBIJHMEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4EF79B0", Offset = "0x4EF67B0", VA = "0x184EF79B0")]
	public bool AFLFHJHNEJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7E70", Offset = "0x4EF6C70", VA = "0x184EF7E70")]
	public bool OFOHPOFOPBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7CF0", Offset = "0x4EF6AF0", VA = "0x184EF7CF0")]
	public bool LOIHEJDIILG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7B40", Offset = "0x4EF6940", VA = "0x184EF7B40")]
	public int DKKNBAHFPKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7D20", Offset = "0x4EF6B20", VA = "0x184EF7D20")]
	public void OCGOJNINOMO(out MCKOGFAAPEO HFEEKHKDPKI, out MCKOGFAAPEO ICKHFGECKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7F30", Offset = "0x4EF6D30", VA = "0x184EF7F30")]
	public bool PJICEADNPEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7CD0", Offset = "0x4EF6AD0", VA = "0x184EF7CD0")]
	public double IGJPNMBCJPK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7A80", Offset = "0x4EF6880", VA = "0x184EF7A80")]
	public static int CLFFFIHJIKC(int DHFODKLLKIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7CE0", Offset = "0x4EF6AE0", VA = "0x184EF7CE0")]
	public static double JMPCNHFGBNP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7AA0", Offset = "0x4EF68A0", VA = "0x184EF7AA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2931590", Offset = "0x2930390", VA = "0x182931590")]
	public FDCBCLHMBJG(float ACDBJHBECNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE730", Offset = "0x4EDD530", VA = "0x184EDE730")]
	public MCKOGFAAPEO BPIMNDEHAPO()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x73E0D0", Offset = "0x73CED0", VA = "0x18073E0D0")]
	public uint LBFONAAGEAJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE790", Offset = "0x4EDD590", VA = "0x184EDE790")]
	public int CKACGJLIEFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE7C0", Offset = "0x4EDD5C0", VA = "0x184EDE7C0")]
	public uint GCAODMKHGBH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE7B0", Offset = "0x4EDD5B0", VA = "0x184EDE7B0")]
	public bool GAENBIJHMEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE7E0", Offset = "0x4EDD5E0", VA = "0x184EDE7E0")]
	public void OCGOJNINOMO(out MCKOGFAAPEO HFEEKHKDPKI, out MCKOGFAAPEO ICKHFGECKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE910", Offset = "0x4EDD710", VA = "0x184EDE910")]
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
	[Cpp2IlInjected.Address(RVA = "0x4134C70", Offset = "0x4133A70", VA = "0x184134C70")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EDECB0", Offset = "0x4EDDAB0", VA = "0x184EDECB0")]
	public static void DOAJIIIOBDK(int FELOCCIEGCP, int OHGMGEJBFEL, out MCKOGFAAPEO ONBODKODHNJ, out int KAKDIMEDOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EDEDE0", Offset = "0x4EDDBE0", VA = "0x184EDEDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x413B220", Offset = "0x413A020", VA = "0x18413B220")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xB8EA10", Offset = "0xB8D810", VA = "0x180B8EA10")]
	public EBAINEELELO(byte[] HFAIGCGNPJJ, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x73E090", Offset = "0x73CE90", VA = "0x18073E090")]
	public int GKPOMAIMOAK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x413B1C0", Offset = "0x4139FC0", VA = "0x18413B1C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4137050", Offset = "0x4135E50", VA = "0x184137050")]
	private static byte[] CDOFLEPMFIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4136F70", Offset = "0x4135D70", VA = "0x184136F70")]
	private static EBAINEELELO BCILANKJMOK(EBAINEELELO CLABEIKAHOI)
	{
		return default(EBAINEELELO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4137F10", Offset = "0x4136D10", VA = "0x184137F10")]
	private static EBAINEELELO OJHNFDKLIKB(EBAINEELELO CLABEIKAHOI)
	{
		return default(EBAINEELELO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4137CB0", Offset = "0x4136AB0", VA = "0x184137CB0")]
	private static void JBBBIEKJKME(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, byte[] CFJGAKCNFDK, out int LMHMLHKDHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4137990", Offset = "0x4136790", VA = "0x184137990")]
	private static void HNGNEJMPDIB(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, byte[] JEILGJFMLBK, int PKPOJMGKFCM, out EBAINEELELO AFJBKCCDGCI, out int OPKBEOHPDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4137900", Offset = "0x4136700", VA = "0x184137900")]
	private static ulong GIAFBECHNCD(EBAINEELELO CLABEIKAHOI, out int NHNOEHFLLBP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4137140", Offset = "0x4135F40", VA = "0x184137140")]
	private static void COHKBGFCGBB(EBAINEELELO CLABEIKAHOI, out MCKOGFAAPEO BBLJKOEKFJI, out int AALPGFHIAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4137FF0", Offset = "0x4136DF0", VA = "0x184137FF0")]
	private static bool ONNDIKPEIDC(EBAINEELELO AFJBKCCDGCI, int MAJAOEBPCPC, out double BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4137D60", Offset = "0x4136B60", VA = "0x184137D60")]
	private static MCKOGFAAPEO LFHILEHJIBF(int MAJAOEBPCPC)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x41372D0", Offset = "0x41360D0", VA = "0x1841372D0")]
	private static bool FJLBJFGKHPL(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, out double BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4136E30", Offset = "0x4135C30", VA = "0x184136E30")]
	private static bool BCDALGHMIEM(EBAINEELELO AFJBKCCDGCI, int MAJAOEBPCPC, out double LADILAJMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x41377E0", Offset = "0x41365E0", VA = "0x1841377E0")]
	public static double? GAKKOOHBACE(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x4138470", Offset = "0x4137270", VA = "0x184138470")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EF07F0", Offset = "0x4EEF5F0", VA = "0x184EF07F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8B52D0", Offset = "0x8B40D0", VA = "0x1808B52D0")]
	public NINNIJFNFLD(byte[] CLABEIKAHOI, int LBACAALGKLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0610", Offset = "0x4EEF410", VA = "0x184EF0610")]
	public static NINNIJFNFLD CGPJMKBEIBP(NINNIJFNFLD CFFPEBFKEAC)
	{
		return default(NINNIJFNFLD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0750", Offset = "0x4EEF550", VA = "0x184EF0750")]
	public static NINNIJFNFLD KFDPIIJCIIP(NINNIJFNFLD CFFPEBFKEAC, int GKPOMAIMOAK)
	{
		return default(NINNIJFNFLD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0880", Offset = "0x4EEF680", VA = "0x184EF0880")]
	public static int MPKLCJPFEHE(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0620", Offset = "0x4EEF420", VA = "0x184EF0620")]
	public static bool CJJJLAGEFIA(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4EF06E0", Offset = "0x4EEF4E0", VA = "0x184EF06E0")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0640", Offset = "0x4EEF440", VA = "0x184EF0640")]
	public static bool CJJJLAGEFIA(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0690", Offset = "0x4EEF490", VA = "0x184EF0690")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0690", Offset = "0x4EEF490", VA = "0x184EF0690")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, byte PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0700", Offset = "0x4EEF500", VA = "0x184EF0700")]
	public static bool JGGBLBMCIBK(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4EF07A0", Offset = "0x4EEF5A0", VA = "0x184EF07A0")]
	public static bool LHGNIHDBGAI(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0830", Offset = "0x4EEF630", VA = "0x184EF0830")]
	public static bool MIELMPPJAGE(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4EF08A0", Offset = "0x4EEF6A0", VA = "0x184EF08A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x412DA60", Offset = "0x412C860", VA = "0x18412DA60")]
	private static byte[] OJPOPNBOHID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x412D7D0", Offset = "0x412C5D0", VA = "0x18412D7D0")]
	private static byte[] LJHGCDKIJLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x412C240", Offset = "0x412B040", VA = "0x18412C240")]
	public static double CIDIKAMMPKI(byte[] CLABEIKAHOI, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x412DB50", Offset = "0x412C950", VA = "0x18412DB50")]
	public static float OOPLEAAMOGO(byte[] CLABEIKAHOI, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x412D8C0", Offset = "0x412C6C0", VA = "0x18412D8C0")]
	private static bool NEHJKMMMHMI(int KNMKEOOODCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x412DC10", Offset = "0x412CA10", VA = "0x18412DC10")]
	private static bool PFHCHJONCGI(ref NINNIJFNFLD MGGGHPDHPFB, NINNIJFNFLD CBNJCJLIEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x412C340", Offset = "0x412B140", VA = "0x18412C340")]
	private static bool HNFJAKPMCCN(ref NINNIJFNFLD MGGGHPDHPFB, NINNIJFNFLD CBNJCJLIEMJ, byte[] IFBJOHKDNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x412C2F0", Offset = "0x412B0F0", VA = "0x18412C2F0")]
	private static bool FGJGBFPKIFD(ref NINNIJFNFLD KFEOAOMEMDH, byte[] JNFDLMOFJOO, int LBACAALGKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x412DA40", Offset = "0x412C840", VA = "0x18412DA40")]
	private static double NIBONLNAFOI(bool FHFLCMPABME)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x412C450", Offset = "0x412B250", VA = "0x18412C450")]
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
	[Cpp2IlInjected.Address(RVA = "0x26379F0", Offset = "0x26367F0", VA = "0x1826379F0")]
	public NKDCBHJFMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9940", Offset = "0x1EB8740", VA = "0x181EB9940")]
	public NKDCBHJFMAC(NEHADIAKNBK CPICKMCHCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2B56E90", Offset = "0x2B55C90", VA = "0x182B56E90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2B57500", Offset = "0x2B56300", VA = "0x182B57500", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x26379F0", Offset = "0x26367F0", VA = "0x1826379F0")]
	public MMJNKBLAMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9940", Offset = "0x1EB8740", VA = "0x181EB9940")]
	public MMJNKBLAMPL(NEHADIAKNBK CPICKMCHCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2636220", Offset = "0x2635020", VA = "0x182636220", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, List<T> IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2637450", Offset = "0x2636250", VA = "0x182637450", Slot = "5")]
	public List<T> HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class FAPDHICOOBP<TElement, TIntermediate, TEnumerator, TCollection> : global::JNNOLJAFELM<TCollection>, INIKLHPPANG where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2451AE0", Offset = "0x24508E0", VA = "0x182451AE0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TCollection IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x24527F0", Offset = "0x24515F0", VA = "0x1824527F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	protected FAPDHICOOBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class INMMIKOAELK<TElement, TIntermediate, TCollection> : global::FAPDHICOOBP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x213C830", Offset = "0x213B630", VA = "0x18213C830", Slot = "6")]
	protected override IEnumerator<TElement> PKBDEGDPEIJ(TCollection IKPEGPHMIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x213C880", Offset = "0x213B680", VA = "0x18213C880")]
	protected INMMIKOAELK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class GICLBPKPKOJ<TElement, TCollection> : global::INMMIKOAELK<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected sealed override TCollection NBKICENBLEL(ref TCollection MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class NGCFCLLFAIG<TElement, TCollection> : global::GICLBPKPKOJ<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2453590", Offset = "0x2452390", VA = "0x182453590", Slot = "7")]
	protected override TCollection DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8710", Offset = "0x2CA7510", VA = "0x182CA8710", Slot = "8")]
	protected override void HEFJCCLOLGO(ref TCollection FLHDOCMLBEH, int AIPHGHFENPJ, TElement IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class BJHBELBNLHA<T> : global::FAPDHICOOBP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x23B3FE0", Offset = "0x23B2DE0", VA = "0x1823B3FE0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref LinkedList<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override LinkedList<T> NBKICENBLEL(ref LinkedList<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override LinkedList<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x23B4020", Offset = "0x23B2E20", VA = "0x1823B4020", Slot = "6")]
	protected override LinkedList<T>.Enumerator PKBDEGDPEIJ(LinkedList<T> IKPEGPHMIII)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PDBNBLCPABN<T> : global::FAPDHICOOBP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x23B3FE0", Offset = "0x23B2DE0", VA = "0x1823B3FE0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Queue<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override Queue<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2C47E00", Offset = "0x2C46C00", VA = "0x182C47E00", Slot = "6")]
	protected override Queue<T>.Enumerator PKBDEGDPEIJ(Queue<T> IKPEGPHMIII)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override Queue<T> NBKICENBLEL(ref Queue<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class JKPPNIDGHBL<T> : global::FAPDHICOOBP<T, global::PFFGLIOAFFG<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x252C800", Offset = "0x252B600", VA = "0x18252C800", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x262D830", Offset = "0x262C630", VA = "0x18262D830", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2C47E00", Offset = "0x2C46C00", VA = "0x182C47E00", Slot = "6")]
	protected override Stack<T>.Enumerator PKBDEGDPEIJ(Stack<T> IKPEGPHMIII)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2C47D20", Offset = "0x2C46B20", VA = "0x182C47D20", Slot = "9")]
	protected override Stack<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class DBGJNMOMPBM<T> : global::FAPDHICOOBP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x23B3FE0", Offset = "0x23B2DE0", VA = "0x1823B3FE0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref HashSet<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override HashSet<T> NBKICENBLEL(ref HashSet<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override HashSet<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2C47E00", Offset = "0x2C46C00", VA = "0x182C47E00", Slot = "6")]
	protected override HashSet<T>.Enumerator PKBDEGDPEIJ(HashSet<T> IKPEGPHMIII)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class FLNAEEBJCMN<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x252C800", Offset = "0x252B600", VA = "0x18252C800", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x252C830", Offset = "0x252B630", VA = "0x18252C830", Slot = "9")]
	protected override ReadOnlyCollection<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x252C7C0", Offset = "0x252B5C0", VA = "0x18252C7C0", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class PIHNMDPAGPH<T> : global::INMMIKOAELK<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x23B3FE0", Offset = "0x23B2DE0", VA = "0x1823B3FE0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref List<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override List<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override IList<T> NBKICENBLEL(ref List<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class PPMCIAMAKEF<T> : global::INMMIKOAELK<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x23B3FE0", Offset = "0x23B2DE0", VA = "0x1823B3FE0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref List<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override List<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override ICollection<T> NBKICENBLEL(ref List<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class MIPDBMINNMM<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x252C800", Offset = "0x252B600", VA = "0x18252C800", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x262D830", Offset = "0x262C630", VA = "0x18262D830", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x262D870", Offset = "0x262C670", VA = "0x18262D870", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x23C65C0", Offset = "0x23C53C0", VA = "0x1823C65C0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x23C6880", Offset = "0x23C5680", VA = "0x1823C6880", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
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
	[Cpp2IlInjected.Address(RVA = "0x41361B0", Offset = "0x4134FB0", VA = "0x1841361B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IEnumerable IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x41363A0", Offset = "0x41351A0", VA = "0x1841363A0", Slot = "5")]
	public IEnumerable HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4132200", Offset = "0x4131000", VA = "0x184132200", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ICollection IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x41324C0", Offset = "0x41312C0", VA = "0x1841324C0", Slot = "5")]
	public ICollection HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEF880", Offset = "0x4EEE680", VA = "0x184EEF880", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IList IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFBF0", Offset = "0x4EEE9F0", VA = "0x184EEFBF0", Slot = "5")]
	public IList HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public MLMJMJDLKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KDHCNBFMNJO<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2C005C0", Offset = "0x2BFF3C0", VA = "0x182C005C0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x262D830", Offset = "0x262C630", VA = "0x18262D830", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2C005F0", Offset = "0x2BFF3F0", VA = "0x182C005F0", Slot = "9")]
	protected override IReadOnlyList<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x197F110", Offset = "0x197DF10", VA = "0x18197F110")]
	public KDHCNBFMNJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class AHFAOLEGJPA
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x412ECB0", Offset = "0x412DAB0", VA = "0x18412ECB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF1F50", Offset = "0x4EF0D50", VA = "0x184EF1F50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, DateTime IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4EF2BF0", Offset = "0x4EF19F0", VA = "0x184EF2BF0", Slot = "5")]
	public DateTime HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x412EEE0", Offset = "0x412DCE0", VA = "0x18412EEE0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, DateTimeOffset IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x412F2C0", Offset = "0x412E0C0", VA = "0x18412F2C0", Slot = "5")]
	public DateTimeOffset HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE1ED0", Offset = "0x4EE0CD0", VA = "0x184EE1ED0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TimeSpan IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4EE2380", Offset = "0x4EE1180", VA = "0x184EE2380", Slot = "5")]
	public TimeSpan HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public GFFIHBDONOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class BKBMJHPOIAP<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::JNNOLJAFELM<TDictionary>, INIKLHPPANG where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x23B8850", Offset = "0x23B7650", VA = "0x1823B8850", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TDictionary IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x23B9DA0", Offset = "0x23B8BA0", VA = "0x1823B9DA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	protected BKBMJHPOIAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class MPHILAFAGJN<TKey, TValue, TIntermediate, TDictionary> : global::BKBMJHPOIAP<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x213C830", Offset = "0x213B630", VA = "0x18213C830", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> PKBDEGDPEIJ(TDictionary IKPEGPHMIII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class LKHIFENEGPH<TKey, TValue, TDictionary> : global::MPHILAFAGJN<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override TDictionary NBKICENBLEL(ref TDictionary MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class PNLOKENDAFC<TKey, TValue> : global::BKBMJHPOIAP<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3508030", Offset = "0x3506E30", VA = "0x183508030", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Dictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override Dictionary<TKey, TValue> NBKICENBLEL(ref Dictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override Dictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3508070", Offset = "0x3506E70", VA = "0x183508070", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator PKBDEGDPEIJ(Dictionary<TKey, TValue> IKPEGPHMIII)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xD644C0", Offset = "0xD632C0", VA = "0x180D644C0")]
	public PNLOKENDAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LDMBIACGPCA<TKey, TValue, TDictionary> : global::LKHIFENEGPH<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC810", Offset = "0x2CDB610", VA = "0x182CDC810", Slot = "8")]
	protected override void HEFJCCLOLGO(ref TDictionary FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1EBDC00", Offset = "0x1EBCA00", VA = "0x181EBDC00", Slot = "7")]
	protected override TDictionary DAKLFHBAJIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class FONMAJJEAKJ<TKey, TValue> : global::MPHILAFAGJN<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2626F90", Offset = "0x2625D90", VA = "0x182626F90", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Dictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override Dictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override IDictionary<TKey, TValue> NBKICENBLEL(ref Dictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class MHPLNBNNPCH<TKey, TValue> : global::LKHIFENEGPH<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2626F90", Offset = "0x2625D90", VA = "0x182626F90", Slot = "8")]
	protected override void HEFJCCLOLGO(ref SortedList<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override SortedList<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class DBJBDNLCFFM<TKey, TValue> : global::BKBMJHPOIAP<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2626F90", Offset = "0x2625D90", VA = "0x182626F90", Slot = "8")]
	protected override void HEFJCCLOLGO(ref SortedDictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0xDD9FD0", Offset = "0xDD8DD0", VA = "0x180DD9FD0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NBKICENBLEL(ref SortedDictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B2D80", VA = "0x1823B3F80", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x309D1A0", Offset = "0x309BFA0", VA = "0x18309D1A0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator PKBDEGDPEIJ(SortedDictionary<TKey, TValue> IKPEGPHMIII)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NNHEBMEDJPP<T> : global::JNNOLJAFELM<T>, INIKLHPPANG where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2B601D0", Offset = "0x2B5EFD0", VA = "0x182B601D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2B60580", Offset = "0x2B5F380", VA = "0x182B60580", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
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
	[Cpp2IlInjected.Address(RVA = "0x41354F0", Offset = "0x41342F0", VA = "0x1841354F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IDictionary IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x41358A0", Offset = "0x41346A0", VA = "0x1841358A0", Slot = "5")]
	public IDictionary HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF1EB0", Offset = "0x4EF0CB0", VA = "0x184EF1EB0")]
	public OADKHBBMIBJ(params LOKDBPMCGHA[] BHDPJLDLLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4EF10D0", Offset = "0x4EEFED0", VA = "0x184EF10D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4EF1E10", Offset = "0x4EF0C10", VA = "0x184EF1E10", Slot = "5")]
	public object HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class DHMEDDBBKOC
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4139D30", Offset = "0x4138B30", VA = "0x184139D30")]
	public static object EPBJHGHLNPD(Type NKICFHCCMMH, out bool OBFKAKNHGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4139410", Offset = "0x4138210", VA = "0x184139410")]
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
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public NEJGELLMPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6CF0", Offset = "0x2CA5AF0", VA = "0x182CA6CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public LLCJHLMFDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D584B0", Offset = "0x2D572B0", VA = "0x182D584B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public OGPEOGCMCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2E5BFB0", Offset = "0x2E5ADB0", VA = "0x182E5BFB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x253AC10", Offset = "0x2539A10", VA = "0x18253AC10")]
	static FOKEMEJJPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2541820", Offset = "0x2540620", VA = "0x182541820")]
	public FOKEMEJJPEK(bool NLMEIKOHBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x25362D0", Offset = "0x25350D0", VA = "0x1825362D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2536EA0", Offset = "0x2535CA0", VA = "0x182536EA0", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x25354A0", Offset = "0x25342A0", VA = "0x1825354A0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2538530", Offset = "0x2537330", VA = "0x182538530", Slot = "7")]
	public T MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class BLLADHHJOOG<T> : global::JNNOLJAFELM<T[,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x23C10D0", Offset = "0x23BFED0", VA = "0x1823C10D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x23C1280", Offset = "0x23C0080", VA = "0x1823C1280", Slot = "5")]
	public T[,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	public BLLADHHJOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class AGPOBCKCLDF<T> : global::JNNOLJAFELM<T[,,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2280A00", Offset = "0x227F800", VA = "0x182280A00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2280C10", Offset = "0x227FA10", VA = "0x182280C10", Slot = "5")]
	public T[,,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	public AGPOBCKCLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LMCLGPMBMBI<T> : global::JNNOLJAFELM<T[,,,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2D59B50", Offset = "0x2D58950", VA = "0x182D59B50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,,,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D59DF0", Offset = "0x2D58BF0", VA = "0x182D59DF0", Slot = "5")]
	public T[,,,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	public LMCLGPMBMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class PLFDCJPPELA<T> : global::JNNOLJAFELM<T?>, INIKLHPPANG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x3068280", Offset = "0x3067080", VA = "0x183068280", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3068690", Offset = "0x3067490", VA = "0x183068690", Slot = "5")]
	public T? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
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
	[Cpp2IlInjected.Address(RVA = "0x166AFE0", Offset = "0x1669DE0", VA = "0x18166AFE0")]
	public HOPJKNANKFP(global::JNNOLJAFELM<T> ONFFLAMPLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2AC0", Offset = "0x2BE18C0", VA = "0x182BE2AC0")]
	public HOPJKNANKFP(Type HDCINCHPFJA, object[] ONLKLCKDLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1E00", Offset = "0x2BE0C00", VA = "0x182BE1E00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2960", Offset = "0x2BE1760", VA = "0x182BE2960", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEB9E0", Offset = "0x4EEA7E0", VA = "0x184EEB9E0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBA20", Offset = "0x4EEA820", VA = "0x184EEBA20", Slot = "5")]
	public sbyte HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB920", Offset = "0x4EEA720", VA = "0x184EEB920", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBA70", Offset = "0x4EEA870", VA = "0x184EEBA70", Slot = "7")]
	public sbyte MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF3CC0", Offset = "0x4EF2AC0", VA = "0x184EF3CC0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4EF3D50", Offset = "0x4EF2B50", VA = "0x184EF3D50", Slot = "5")]
	public sbyte? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4EF3BB0", Offset = "0x4EF29B0", VA = "0x184EF3BB0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4EF3E00", Offset = "0x4EF2C00", VA = "0x184EF3E00", Slot = "7")]
	public sbyte? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEBE90", Offset = "0x4EEAC90", VA = "0x184EEBE90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC030", Offset = "0x4EEAE30", VA = "0x184EEC030", Slot = "5")]
	public sbyte[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE0D50", Offset = "0x4EDFB50", VA = "0x184EE0D50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0D90", Offset = "0x4EDFB90", VA = "0x184EE0D90", Slot = "5")]
	public short HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0C90", Offset = "0x4EDFA90", VA = "0x184EE0C90", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, short IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0DF0", Offset = "0x4EDFBF0", VA = "0x184EE0DF0", Slot = "7")]
	public short MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x413AFB0", Offset = "0x4139DB0", VA = "0x18413AFB0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x413B030", Offset = "0x4139E30", VA = "0x18413B030", Slot = "5")]
	public short? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x413AF30", Offset = "0x4139D30", VA = "0x18413AF30", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, short? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x413B0A0", Offset = "0x4139EA0", VA = "0x18413B0A0", Slot = "7")]
	public short? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x50F07D0", Offset = "0x50EF5D0", VA = "0x1850F07D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x50F0890", Offset = "0x50EF690", VA = "0x1850F0890", Slot = "5")]
	public short[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF0440", Offset = "0x4EEF240", VA = "0x184EF0440", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0470", Offset = "0x4EEF270", VA = "0x184EF0470", Slot = "5")]
	public int HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0380", Offset = "0x4EEF180", VA = "0x184EF0380", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, int IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4EF04D0", Offset = "0x4EEF2D0", VA = "0x184EF04D0", Slot = "7")]
	public int MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEF510", Offset = "0x4EEE310", VA = "0x184EEF510", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF5A0", Offset = "0x4EEE3A0", VA = "0x184EEF5A0", Slot = "5")]
	public int? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF400", Offset = "0x4EEE200", VA = "0x184EEF400", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, int? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF650", Offset = "0x4EEE450", VA = "0x184EEF650", Slot = "7")]
	public int? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE2FC0", Offset = "0x4EE1DC0", VA = "0x184EE2FC0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3160", Offset = "0x4EE1F60", VA = "0x184EE3160", Slot = "5")]
	public int[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x50F0BC0", Offset = "0x50EF9C0", VA = "0x1850F0BC0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x50F0BE0", Offset = "0x50EF9E0", VA = "0x1850F0BE0", Slot = "5")]
	public long HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x50F0B80", Offset = "0x50EF980", VA = "0x1850F0B80", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, long IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x50F0BF0", Offset = "0x50EF9F0", VA = "0x1850F0BF0", Slot = "7")]
	public long MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x50F2B80", Offset = "0x50F1980", VA = "0x1850F2B80", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x50F2C00", Offset = "0x50F1A00", VA = "0x1850F2C00", Slot = "5")]
	public long? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x50F2AF0", Offset = "0x50F18F0", VA = "0x1850F2AF0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, long? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x50F2C90", Offset = "0x50F1A90", VA = "0x1850F2C90", Slot = "7")]
	public long? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x41452C0", Offset = "0x41440C0", VA = "0x1841452C0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4145380", Offset = "0x4144180", VA = "0x184145380", Slot = "5")]
	public long[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEFFA0", Offset = "0x4EEEDA0", VA = "0x184EEFFA0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFFE0", Offset = "0x4EEEDE0", VA = "0x184EEFFE0", Slot = "5")]
	public byte HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFEE0", Offset = "0x4EEECE0", VA = "0x184EEFEE0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, byte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0040", Offset = "0x4EEEE40", VA = "0x184EF0040", Slot = "7")]
	public byte MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF0A00", Offset = "0x4EEF800", VA = "0x184EF0A00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0A90", Offset = "0x4EEF890", VA = "0x184EF0A90", Slot = "5")]
	public byte? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4EF08F0", Offset = "0x4EEF6F0", VA = "0x184EF08F0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, byte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0B40", Offset = "0x4EEF940", VA = "0x184EF0B40", Slot = "7")]
	public byte? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEE980", Offset = "0x4EED780", VA = "0x184EEE980", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE9C0", Offset = "0x4EED7C0", VA = "0x184EEE9C0", Slot = "5")]
	public ushort HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE8C0", Offset = "0x4EED6C0", VA = "0x184EEE8C0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ushort IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEA20", Offset = "0x4EED820", VA = "0x184EEEA20", Slot = "7")]
	public ushort MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x41337B0", Offset = "0x41325B0", VA = "0x1841337B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4133830", Offset = "0x4132630", VA = "0x184133830", Slot = "5")]
	public ushort? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4133730", Offset = "0x4132530", VA = "0x184133730", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ushort? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x41338A0", Offset = "0x41326A0", VA = "0x1841338A0", Slot = "7")]
	public ushort? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x41391B0", Offset = "0x4137FB0", VA = "0x1841391B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4139270", Offset = "0x4138070", VA = "0x184139270", Slot = "5")]
	public ushort[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4133A00", Offset = "0x4132800", VA = "0x184133A00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4133A10", Offset = "0x4132810", VA = "0x184133A10", Slot = "5")]
	public uint HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x41339C0", Offset = "0x41327C0", VA = "0x1841339C0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, uint IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4133A20", Offset = "0x4132820", VA = "0x184133A20", Slot = "7")]
	public uint MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE51B0", Offset = "0x4EE3FB0", VA = "0x184EE51B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5240", Offset = "0x4EE4040", VA = "0x184EE5240", Slot = "5")]
	public uint? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4EE50A0", Offset = "0x4EE3EA0", VA = "0x184EE50A0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, uint? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4EE52F0", Offset = "0x4EE40F0", VA = "0x184EE52F0", Slot = "7")]
	public uint? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x41365B0", Offset = "0x41353B0", VA = "0x1841365B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4136670", Offset = "0x4135470", VA = "0x184136670", Slot = "5")]
	public uint[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEBD70", Offset = "0x4EEAB70", VA = "0x184EEBD70", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBDA0", Offset = "0x4EEABA0", VA = "0x184EEBDA0", Slot = "5")]
	public ulong HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBCB0", Offset = "0x4EEAAB0", VA = "0x184EEBCB0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ulong IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBDB0", Offset = "0x4EEABB0", VA = "0x184EEBDB0", Slot = "7")]
	public ulong MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x413C850", Offset = "0x413B650", VA = "0x18413C850", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x413C8D0", Offset = "0x413B6D0", VA = "0x18413C8D0", Slot = "5")]
	public ulong? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x413C7C0", Offset = "0x413B5C0", VA = "0x18413C7C0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ulong? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x413C960", Offset = "0x413B760", VA = "0x18413C960", Slot = "7")]
	public ulong? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF6F70", Offset = "0x4EF5D70", VA = "0x184EF6F70", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7110", Offset = "0x4EF5F10", VA = "0x184EF7110", Slot = "5")]
	public ulong[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4134F20", Offset = "0x4133D20", VA = "0x184134F20", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x4134F30", Offset = "0x4133D30", VA = "0x184134F30", Slot = "5")]
	public float HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x4134EE0", Offset = "0x4133CE0", VA = "0x184134EE0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, float IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4134F40", Offset = "0x4133D40", VA = "0x184134F40", Slot = "7")]
	public float MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEC9B0", Offset = "0x4EEB7B0", VA = "0x184EEC9B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x4EECA30", Offset = "0x4EEB830", VA = "0x184EECA30", Slot = "5")]
	public float? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC8B0", Offset = "0x4EEB6B0", VA = "0x184EEC8B0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, float? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4EECAA0", Offset = "0x4EEB8A0", VA = "0x184EECAA0", Slot = "7")]
	public float? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4134C80", Offset = "0x4133A80", VA = "0x184134C80", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4134D40", Offset = "0x4133B40", VA = "0x184134D40", Slot = "5")]
	public float[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEEBB0", Offset = "0x4EED9B0", VA = "0x184EEEBB0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEBC0", Offset = "0x4EED9C0", VA = "0x184EEEBC0", Slot = "5")]
	public double HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEB00", Offset = "0x4EED900", VA = "0x184EEEB00", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, double IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEBD0", Offset = "0x4EED9D0", VA = "0x184EEEBD0", Slot = "7")]
	public double MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x50EE390", Offset = "0x50ED190", VA = "0x1850EE390", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x50EE410", Offset = "0x50ED210", VA = "0x1850EE410", Slot = "5")]
	public double? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x50EE300", Offset = "0x50ED100", VA = "0x1850EE300", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, double? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x50EE4A0", Offset = "0x50ED2A0", VA = "0x1850EE4A0", Slot = "7")]
	public double? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE7A40", Offset = "0x4EE6840", VA = "0x184EE7A40", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7C20", Offset = "0x4EE6A20", VA = "0x184EE7C20", Slot = "5")]
	public double[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEC7A0", Offset = "0x4EEB5A0", VA = "0x184EEC7A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC7C0", Offset = "0x4EEB5C0", VA = "0x184EEC7C0", Slot = "5")]
	public bool HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC6F0", Offset = "0x4EEB4F0", VA = "0x184EEC6F0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, bool IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC7D0", Offset = "0x4EEB5D0", VA = "0x184EEC7D0", Slot = "7")]
	public bool MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x413AD20", Offset = "0x4139B20", VA = "0x18413AD20", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x413ADA0", Offset = "0x4139BA0", VA = "0x18413ADA0", Slot = "5")]
	public bool? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x413ACA0", Offset = "0x4139AA0", VA = "0x18413ACA0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, bool? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x413AE10", Offset = "0x4139C10", VA = "0x18413AE10", Slot = "7")]
	public bool? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE0ED0", Offset = "0x4EDFCD0", VA = "0x184EE0ED0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4EE1050", Offset = "0x4EDFE50", VA = "0x184EE1050", Slot = "5")]
	public bool[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE3D00", Offset = "0x4EE2B00", VA = "0x184EE3D00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE47D0", Offset = "0x4EE35D0", VA = "0x184EE47D0", Slot = "5")]
	public object HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEEE10", Offset = "0x4EEDC10", VA = "0x184EEEE10", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEEA0", Offset = "0x4EEDCA0", VA = "0x184EEEEA0", Slot = "5")]
	public byte[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EDE950", Offset = "0x4EDD750", VA = "0x184EDE950", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ArraySegment<byte> IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4EDEA10", Offset = "0x4EDD810", VA = "0x184EDEA10", Slot = "5")]
	public ArraySegment<byte> HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EECBC0", Offset = "0x4EEB9C0", VA = "0x184EECBC0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, string IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4EECBE0", Offset = "0x4EEB9E0", VA = "0x184EECBE0", Slot = "5")]
	public string HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4EECBC0", Offset = "0x4EEB9C0", VA = "0x184EECBC0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, string IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4EECBE0", Offset = "0x4EEB9E0", VA = "0x184EECBE0", Slot = "7")]
	public string MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF40F0", Offset = "0x4EF2EF0", VA = "0x184EF40F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, string[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4260", Offset = "0x4EF3060", VA = "0x184EF4260", Slot = "5")]
	public string[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEE740", Offset = "0x4EED540", VA = "0x184EEE740", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE7C0", Offset = "0x4EED5C0", VA = "0x184EEE7C0", Slot = "5")]
	public char HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEAFD0", Offset = "0x4EE9DD0", VA = "0x184EEAFD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB0C0", Offset = "0x4EE9EC0", VA = "0x184EEB0C0", Slot = "5")]
	public char? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EE75B0", Offset = "0x4EE63B0", VA = "0x184EE75B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE77F0", Offset = "0x4EE65F0", VA = "0x184EE77F0", Slot = "5")]
	public char[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4138F40", Offset = "0x4137D40", VA = "0x184138F40", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Guid IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x4139010", Offset = "0x4137E10", VA = "0x184139010", Slot = "5")]
	public Guid HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x4138E70", Offset = "0x4137C70", VA = "0x184138E70", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, Guid IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x4139010", Offset = "0x4137E10", VA = "0x184139010", Slot = "7")]
	public Guid MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x747010", Offset = "0x745E10", VA = "0x180747010")]
	public EKEGCAPCFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x10B7C10", Offset = "0x10B6A10", VA = "0x1810B7C10")]
	public EKEGCAPCFCA(bool IBJNOEDEBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x413C2B0", Offset = "0x413B0B0", VA = "0x18413C2B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, decimal IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x413C400", Offset = "0x413B200", VA = "0x18413C400", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x413B3C0", Offset = "0x413A1C0", VA = "0x18413B3C0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Uri IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x413B470", Offset = "0x413A270", VA = "0x18413B470", Slot = "5")]
	public Uri HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x412ED50", Offset = "0x412DB50", VA = "0x18412ED50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Version IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x412EE00", Offset = "0x412DC00", VA = "0x18412EE00", Slot = "5")]
	public Version HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4138D40", Offset = "0x4137B40", VA = "0x184138D40", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, StringBuilder IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4138D90", Offset = "0x4137B90", VA = "0x184138D90", Slot = "5")]
	public StringBuilder HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EEB1F0", Offset = "0x4EE9FF0", VA = "0x184EEB1F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, BitArray IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB2F0", Offset = "0x4EEA0F0", VA = "0x184EEB2F0", Slot = "5")]
	public BitArray HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x41344D0", Offset = "0x41332D0", VA = "0x1841344D0")]
	public BGOLDOIGOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x4134480", Offset = "0x4133280", VA = "0x184134480")]
	public BGOLDOIGOAD(bool IOMMIHKILIP, bool PAMAECJHBBM, bool KOCNBEFBMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x41341A0", Offset = "0x4132FA0", VA = "0x1841341A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Type IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x4134290", Offset = "0x4133090", VA = "0x184134290", Slot = "5")]
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
