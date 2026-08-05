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
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
	public JAOCPNLBGPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class DDJEMGOIBKB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
	public DDJEMGOIBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IMJJJDMJDFE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
	public IMJJJDMJDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JNMGGIFPILP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
	public JNMGGIFPILP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class MHPACJDBJCH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E630", Offset = "0x4F7D630", VA = "0x184F7E630")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DBBDPLHFPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6726F0", Offset = "0x6716F0", VA = "0x1806726F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x27B82E0", Offset = "0x27B72E0", VA = "0x1827B82E0")]
	public static global::JNNOLJAFELM<T> BJMFONPJKFC<T>(this LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4289CD0", Offset = "0x4288CD0", VA = "0x184289CD0")]
	public static object GHNEFKFOBND(this LOKDBPMCGHA HGOBEINKIPD, Type NKICFHCCMMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LJFBOLBAABE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D710", Offset = "0x4F7C710", VA = "0x184F7D710")]
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
		[Cpp2IlInjected.Address(RVA = "0x5140AF0", Offset = "0x513FAF0", VA = "0x185140AF0")]
		public static byte[] OJPOPNBOHID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5140A60", Offset = "0x513FA60", VA = "0x185140A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F782B0", Offset = "0x4F772B0", VA = "0x184F782B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4F79B70", Offset = "0x4F78B70", VA = "0x184F79B70")]
	public JBBAGFKBPCP(byte[] HFAIGCGNPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F79980", Offset = "0x4F78980", VA = "0x184F79980")]
	public JBBAGFKBPCP(byte[] HFAIGCGNPJJ, int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4F76DF0", Offset = "0x4F75DF0", VA = "0x184F76DF0")]
	private PBGLHKMPJKG BAPHPGOLANA(string CHPNMHOBKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4F775A0", Offset = "0x4F765A0", VA = "0x184F775A0")]
	private PBGLHKMPJKG CALGIIKIFLC(string GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F78A80", Offset = "0x4F77A80", VA = "0x184F78A80")]
	public void MHOEICFHDBD(int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x656000", VA = "0x180657000")]
	public byte[] GMGHNENLGFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x771170", Offset = "0x770170", VA = "0x180771170")]
	public int BPONLNLGFFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4F779D0", Offset = "0x4F769D0", VA = "0x184F779D0")]
	public NMDNKBAMHJH EDBLNKKPJIK()
	{
		return default(NMDNKBAMHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4F78720", Offset = "0x4F77720", VA = "0x184F78720")]
	public void JPJNFJDEBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F77410", Offset = "0x4F76410", VA = "0x184F77410")]
	public bool BMGOFCHECKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4F78A20", Offset = "0x4F77A20", VA = "0x184F78A20")]
	public bool MDPLCCEBNJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4F778E0", Offset = "0x4F768E0", VA = "0x184F778E0")]
	public void DBIGCFOFHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4F78B10", Offset = "0x4F77B10", VA = "0x184F78B10")]
	public bool MMBHAEIDKOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4F785D0", Offset = "0x4F775D0", VA = "0x184F785D0")]
	public bool JJLDEKOPJNA(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4F77B50", Offset = "0x4F76B50", VA = "0x184F77B50")]
	public bool EJMDIIIKDEL(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4F78300", Offset = "0x4F77300", VA = "0x184F78300")]
	public bool IEOMCIFHNHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4F78860", Offset = "0x4F77860", VA = "0x184F78860")]
	public void KKLGFJHGMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4F77970", Offset = "0x4F76970", VA = "0x184F77970")]
	public bool DEMHLHDDDCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4F78A90", Offset = "0x4F77A90", VA = "0x184F78A90")]
	public bool MJHFGKFLELG(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4F77810", Offset = "0x4F76810", VA = "0x184F77810")]
	public bool CPNPFHLHIAL(ref int KOHJDBBJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4F776E0", Offset = "0x4F766E0", VA = "0x184F776E0")]
	public bool CMJNBJILBOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4F77510", Offset = "0x4F76510", VA = "0x184F77510")]
	public void BPOGEGJLBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4F79820", Offset = "0x4F78820", VA = "0x184F79820")]
	public bool PKONGHIEMEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4F77E20", Offset = "0x4F76E20", VA = "0x184F77E20")]
	public void GAEBGFBEEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4F78E50", Offset = "0x4F77E50", VA = "0x184F78E50")]
	private void OMIEPDAGOAC(out byte[] EPKHMOEKGLC, out int IOFHHCKLHFO, out int KCALDLLKIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4F77360", Offset = "0x4F76360", VA = "0x184F77360")]
	private static int BIJBALNHBIO(char BMPDKJEHGIN, char BMMLDIMMAAK, char KDPJFGIFCOL, char NAGBPGCPEDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4F78950", Offset = "0x4F77950", VA = "0x184F78950")]
	private static int MDCAOGIMPAJ(char KNMKEOOODCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4F77FD0", Offset = "0x4F76FD0", VA = "0x184F77FD0")]
	public ArraySegment<byte> GMEFMBJNABC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4F78530", Offset = "0x4F77530", VA = "0x184F78530")]
	public string JIGLGCNKCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4F782D0", Offset = "0x4F772D0", VA = "0x184F782D0")]
	public string ICAJOBHBLFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4F78360", Offset = "0x4F77360", VA = "0x184F78360")]
	public ArraySegment<byte> JAPIBLJDOJH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4F78B70", Offset = "0x4F77B70", VA = "0x184F78B70")]
	public ArraySegment<byte> NEALJAMHMPD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4F78BB0", Offset = "0x4F77BB0", VA = "0x184F78BB0")]
	public bool NKLENODONFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4F77F10", Offset = "0x4F76F10", VA = "0x184F77F10")]
	private static bool GIPJAOPNMEA(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F780D0", Offset = "0x4F770D0", VA = "0x184F780D0")]
	private void GOLEAFIJAJB(NMDNKBAMHJH MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4F778D0", Offset = "0x4F768D0", VA = "0x184F778D0")]
	public void DBEKBMHDCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F78650", Offset = "0x4F77650", VA = "0x184F78650")]
	private void JJNKMJJELHJ(int JKILKDNNGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4F77C10", Offset = "0x4F76C10", VA = "0x184F77C10")]
	public sbyte FCAFBJELBGE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4F77EB0", Offset = "0x4F76EB0", VA = "0x184F77EB0")]
	public short GBGLBFEDKLJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4F77680", Offset = "0x4F76680", VA = "0x184F77680")]
	public int CGCLBGFIAEF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F76D70", Offset = "0x4F75D70", VA = "0x184F76D70")]
	public long AKPKAJHPHND()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4F77300", Offset = "0x4F76300", VA = "0x184F77300")]
	public byte BBCKHJFHBCK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F788F0", Offset = "0x4F778F0", VA = "0x184F788F0")]
	public ushort KLFEMFLOKCA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F78DF0", Offset = "0x4F77DF0", VA = "0x184F78DF0")]
	public uint NNIEICDPABA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4F797A0", Offset = "0x4F787A0", VA = "0x184F797A0")]
	public ulong PHHJMKPOOCC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4F77D50", Offset = "0x4F76D50", VA = "0x184F77D50")]
	public float FIPEPGKAELM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4F77740", Offset = "0x4F76740", VA = "0x184F77740")]
	public double COEEEHMEAOP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4F77C60", Offset = "0x4F76C60", VA = "0x184F77C60")]
	public ArraySegment<byte> FGMOAFOJOOI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4F79610", Offset = "0x4F78610", VA = "0x184F79610")]
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
		[Cpp2IlInjected.Address(RVA = "0x112A700", Offset = "0x1129700", VA = "0x18112A700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KACHLMCPGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x90E920", Offset = "0x90D920", VA = "0x18090E920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5147C60", Offset = "0x5146C60", VA = "0x185147C60")]
	public PBGLHKMPJKG(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5147CD0", Offset = "0x5146CD0", VA = "0x185147CD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
				public JEIEILBPOKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x3687060", Offset = "0x3686060", VA = "0x183687060")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x51407B0", Offset = "0x513F7B0", VA = "0x1851407B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x513CC40", Offset = "0x513BC40", VA = "0x18513CC40")]
			public GBENGLEELEP(Type NKICFHCCMMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E84E90", Offset = "0x5E83E90", VA = "0x185E84E90")]
			private static T GMICCBEHNBC<T>(DynamicMethod CGPPEMAFIJG)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x513C9F0", Offset = "0x513B9F0", VA = "0x18513C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5143650", Offset = "0x5142650", VA = "0x185143650")]
		static NGEIBPLEEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x51435C0", Offset = "0x51425C0", VA = "0x1851435C0")]
		private static GBENGLEELEP NOCCDIAEOGP(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5143310", Offset = "0x5142310", VA = "0x185143310")]
		public static void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x51434A0", Offset = "0x51424A0", VA = "0x1851434A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x513A9F0", Offset = "0x51399F0", VA = "0x18513A9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x51488D0", Offset = "0x51478D0", VA = "0x1851488D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FLBGIACDMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5148870", Offset = "0x5147870", VA = "0x185148870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5148A90", Offset = "0x5147A90", VA = "0x185148A90")]
	public static void NCDFCANDEKP(LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3276520", Offset = "0x3275520", VA = "0x183276520")]
	public static byte[] DGAMFOBEJMM<T>(T CCPIHKCBGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3276330", Offset = "0x3275330", VA = "0x183276330")]
	public static byte[] DGAMFOBEJMM<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3276490", Offset = "0x3275490", VA = "0x183276490")]
	public static void DGAMFOBEJMM<T>(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3276250", Offset = "0x3275250", VA = "0x183276250")]
	public static void DGAMFOBEJMM<T>(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x32766C0", Offset = "0x32756C0", VA = "0x1832766C0")]
	public static void DGAMFOBEJMM<T>(Stream KCFDLMABGLC, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x32765A0", Offset = "0x32755A0", VA = "0x1832765A0")]
	public static void DGAMFOBEJMM<T>(Stream KCFDLMABGLC, T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x32761B0", Offset = "0x32751B0", VA = "0x1832761B0")]
	public static ArraySegment<byte> BKHPEFINPDB<T>(T CCPIHKCBGHF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3276030", Offset = "0x3275030", VA = "0x183276030")]
	public static ArraySegment<byte> BKHPEFINPDB<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3277B70", Offset = "0x3276B70", VA = "0x183277B70")]
	public static string LDBAPCDBCDE<T>(T IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3277BF0", Offset = "0x3276BF0", VA = "0x183277BF0")]
	public static string LDBAPCDBCDE<T>(T IGJPNMBCJPK, LOKDBPMCGHA HGOBEINKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x32770B0", Offset = "0x32760B0", VA = "0x1832770B0")]
	public static T HJFKJCGGCHL<T>(string IKGKCMLCBEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3277350", Offset = "0x3276350", VA = "0x183277350")]
	public static T HJFKJCGGCHL<T>(string IKGKCMLCBEH, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x32778E0", Offset = "0x32768E0", VA = "0x1832778E0")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3277150", Offset = "0x3276150", VA = "0x183277150")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3277960", Offset = "0x3276960", VA = "0x183277960")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, int LBACAALGKLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x32771F0", Offset = "0x32761F0", VA = "0x1832771F0")]
	public static T HJFKJCGGCHL<T>(byte[] HFAIGCGNPJJ, int LBACAALGKLG, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3277650", Offset = "0x3276650", VA = "0x183277650")]
	public static T HJFKJCGGCHL<T>(ref JBBAGFKBPCP ANKKMEDLEHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3277440", Offset = "0x3276440", VA = "0x183277440")]
	public static T HJFKJCGGCHL<T>(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3277A70", Offset = "0x3276A70", VA = "0x183277A70")]
	public static T HJFKJCGGCHL<T>(Stream KCFDLMABGLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32776D0", Offset = "0x32766D0", VA = "0x1832776D0")]
	public static T HJFKJCGGCHL<T>(Stream KCFDLMABGLC, LOKDBPMCGHA HGOBEINKIPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51481F0", Offset = "0x51471F0", VA = "0x1851481F0")]
	public static string BADPDEGNDFN(byte[] IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x51482D0", Offset = "0x51472D0", VA = "0x1851482D0")]
	public static string BADPDEGNDFN(byte[] IKGKCMLCBEH, int LBACAALGKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5148120", Offset = "0x5147120", VA = "0x185148120")]
	public static string BADPDEGNDFN(string IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5148B00", Offset = "0x5147B00", VA = "0x185148B00")]
	public static byte[] NLNJOHGDHLI(byte[] IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5148CB0", Offset = "0x5147CB0", VA = "0x185148CB0")]
	public static byte[] NLNJOHGDHLI(byte[] IKGKCMLCBEH, int LBACAALGKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5148BE0", Offset = "0x5147BE0", VA = "0x185148BE0")]
	public static byte[] NLNJOHGDHLI(string IKGKCMLCBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5148380", Offset = "0x5147380", VA = "0x185148380")]
	private static void DJAPCJDBINP(ref JBBAGFKBPCP ANKKMEDLEHC, ref KOGPHPAEDLF MLMFBHHJDGG, int MOLGFCBNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51489F0", Offset = "0x51479F0", VA = "0x1851489F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x771170", Offset = "0x770170", VA = "0x180771170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4F78A80", Offset = "0x4F77A80", VA = "0x184F78A80")]
	public void MHOEICFHDBD(int LBACAALGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CBC0", Offset = "0x4F7BBC0", VA = "0x184F7CBC0")]
	public static byte[] PFFPMGLMNKM(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C1B0", Offset = "0x4F7B1B0", VA = "0x184F7C1B0")]
	public static byte[] HMMNKHOIIGI(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CA80", Offset = "0x4F7BA80", VA = "0x184F7CA80")]
	public static byte[] OPMEIJFJIMK(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BF10", Offset = "0x4F7AF10", VA = "0x184F7BF10")]
	public static byte[] FNNMDLAEGOA(string JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xCCC2D0", Offset = "0xCCB2D0", VA = "0x180CCC2D0")]
	public KOGPHPAEDLF(byte[] JALDPIKJPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C9D0", Offset = "0x4F7B9D0", VA = "0x184F7C9D0")]
	public ArraySegment<byte> OJPOPNBOHID()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C130", Offset = "0x4F7B130", VA = "0x184F7C130")]
	public byte[] HEFOPHLAPJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CD40", Offset = "0x4F7BD40", VA = "0x184F7CD40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C720", Offset = "0x4F7B720", VA = "0x184F7C720")]
	public void JHOPBBOOCLA(int GIDHOGLCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A680", Offset = "0x4F79680", VA = "0x184F7A680")]
	public void NMHKAPAJACH(byte GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C970", Offset = "0x4F7B970", VA = "0x184F7C970")]
	public void NMHKAPAJACH(byte[] GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C8D0", Offset = "0x4F7B8D0", VA = "0x184F7C8D0")]
	public void MOLJKIMFMPH(byte GGPPIBPNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C850", Offset = "0x4F7B850", VA = "0x184F7C850")]
	public void LDMMPHGOIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BDE0", Offset = "0x4F7ADE0", VA = "0x184F7BDE0")]
	public void EEFEAAAPEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C800", Offset = "0x4F7B800", VA = "0x184F7C800")]
	public void LBNNBDPCDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CCF0", Offset = "0x4F7BCF0", VA = "0x184F7CCF0")]
	public void PPKOCOLAHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CCA0", Offset = "0x4F7BCA0", VA = "0x184F7CCA0")]
	public void PMPLPLANEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BD60", Offset = "0x4F7AD60", VA = "0x184F7BD60")]
	public void CPBAKJNJINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BE30", Offset = "0x4F7AE30", VA = "0x184F7BE30")]
	public void EILJLMDMNKK(string JLHBKPIPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C0E0", Offset = "0x4F7B0E0", VA = "0x184F7C0E0")]
	public void GHGOIIJGNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C730", Offset = "0x4F7B730", VA = "0x184F7C730")]
	public void KGAKMFFKNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BB70", Offset = "0x4F7AB70", VA = "0x184F7BB70")]
	public void CHFDGNHALIE(bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C060", Offset = "0x4F7B060", VA = "0x184F7C060")]
	public void FNOGHMDBDEL(float IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BE90", Offset = "0x4F7AE90", VA = "0x184F7BE90")]
	public void EPBJIIIEMKA(double IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BB10", Offset = "0x4F7AB10", VA = "0x184F7BB10")]
	public void BKGDHPNPAMF(byte IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BB40", Offset = "0x4F7AB40", VA = "0x184F7BB40")]
	public void CEALBOJAPHG(ushort IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C6C0", Offset = "0x4F7B6C0", VA = "0x184F7C6C0")]
	public void IDNCAIDOKMG(uint IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BDB0", Offset = "0x4F7ADB0", VA = "0x184F7BDB0")]
	public void DBMGIHAEODI(ulong IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C8A0", Offset = "0x4F7B8A0", VA = "0x184F7C8A0")]
	public void LNJJBAFCKCP(sbyte IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C6F0", Offset = "0x4F7B6F0", VA = "0x184F7C6F0")]
	public void IPFPLOLDINI(short IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C910", Offset = "0x4F7B910", VA = "0x184F7C910")]
	public void NDLKPLAIPFH(int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C940", Offset = "0x4F7B940", VA = "0x184F7C940")]
	public void NJBGPAHMPKF(long IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C2F0", Offset = "0x4F7B2F0", VA = "0x184F7C2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2844CB0", Offset = "0x2843CB0", VA = "0x182844CB0")]
		static FLNNKMACJBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private FPJKPJCPPNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4290E30", Offset = "0x428FE30", VA = "0x184290E30")]
	static EDPMACDGMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4290720", Offset = "0x428F720", VA = "0x184290720")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F70700", Offset = "0x4F6F700", VA = "0x184F70700")]
	public GBGIFKGBGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4F70200", Offset = "0x4F6F200", VA = "0x184F70200", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector2 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4F703B0", Offset = "0x4F6F3B0", VA = "0x184F703B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4289A30", Offset = "0x4288A30", VA = "0x184289A30")]
	public BHGNPGKFCBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4289750", Offset = "0x4288750", VA = "0x184289750", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector3 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4289870", Offset = "0x4288870", VA = "0x184289870", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4289040", Offset = "0x4288040", VA = "0x184289040")]
	public BFGOMBAKMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4288CD0", Offset = "0x4287CD0", VA = "0x184288CD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Vector4 IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4288E20", Offset = "0x4287E20", VA = "0x184288E20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x428BC00", Offset = "0x428AC00", VA = "0x18428BC00")]
	public CMIMAJPBIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4288CD0", Offset = "0x4287CD0", VA = "0x184288CD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Quaternion IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x428B9E0", Offset = "0x428A9E0", VA = "0x18428B9E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F74E50", Offset = "0x4F73E50", VA = "0x184F74E50")]
	public IFDHKELCIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F74710", Offset = "0x4F73710", VA = "0x184F74710", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Color IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F74A70", Offset = "0x4F73A70", VA = "0x184F74A70", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F72980", Offset = "0x4F71980", VA = "0x184F72980")]
	public GMLJBDBIOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F722B0", Offset = "0x4F712B0", VA = "0x184F722B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Bounds IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F72500", Offset = "0x4F71500", VA = "0x184F72500", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x428B050", Offset = "0x428A050", VA = "0x18428B050")]
	public CGBFCOIADGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x428ACA0", Offset = "0x4289CA0", VA = "0x18428ACA0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Rect IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x428AE10", Offset = "0x4289E10", VA = "0x18428AE10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x43306B0", Offset = "0x432F6B0", VA = "0x1843306B0")]
		static FONALAEPIBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private PCFPBNIHFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C9A6F0", Offset = "0x1C996F0", VA = "0x181C9A6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x513AA80", Offset = "0x5139A80", VA = "0x18513AA80")]
		internal static object IMMPCOIBHEB(Type MGEGOIPHNMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private GGCCKGJOEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5192C40", Offset = "0x5191C40", VA = "0x185192C40")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private OFECBDCGBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F864F0", Offset = "0x4F854F0", VA = "0x184F864F0")]
	public static void PJHBAIJLMNC(params LOKDBPMCGHA[] OEHGGFHFBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F865D0", Offset = "0x4F855D0", VA = "0x184F865D0")]
	public static void PJHBAIJLMNC(params INIKLHPPANG[] FHKOFGFBOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F86260", Offset = "0x4F85260", VA = "0x184F86260")]
	public static void NEEJJIGHCDA(INIKLHPPANG[] FHKOFGFBOGO, LOKDBPMCGHA[] OEHGGFHFBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32ED6A0", Offset = "0x32EC6A0", VA = "0x1832ED6A0")]
		static KKGOJDGNJCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private AECIOAJJJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x429A6F0", Offset = "0x42996F0", VA = "0x18429A6F0")]
	internal static object IMMPCOIBHEB(Type MGEGOIPHNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x429C050", Offset = "0x429B050", VA = "0x18429C050")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BAC210", Offset = "0x2BAB210", VA = "0x182BAC210")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7F110", Offset = "0x4F7E110", VA = "0x184F7F110")]
	static MPNMGKLJFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private MPNMGKLJFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CB4700", Offset = "0x1CB3700", VA = "0x181CB4700")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7CE00", Offset = "0x4F7BE00", VA = "0x184F7CE00")]
	static LCMGKPOECNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private LCMGKPOECNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x33416A0", Offset = "0x33406A0", VA = "0x1833416A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x429A360", Offset = "0x4299360", VA = "0x18429A360")]
	static FBIKMDGBHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private FBIKMDGBHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FD1120", Offset = "0x2FD0120", VA = "0x182FD1120")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7EFE0", Offset = "0x4F7DFE0", VA = "0x184F7EFE0")]
	static MPEOCIFCKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private MPEOCIFCKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AEE550", Offset = "0x2AED550", VA = "0x182AEE550")]
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
	[Cpp2IlInjected.Address(RVA = "0x4291860", Offset = "0x4290860", VA = "0x184291860")]
	static EKFDEAHHJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private EKFDEAHHJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F5D420", Offset = "0x2F5C420", VA = "0x182F5D420")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7B180", Offset = "0x4F7A180", VA = "0x184F7B180")]
	static KINIHMJJGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private KINIHMJJGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x25A61E0", Offset = "0x25A51E0", VA = "0x1825A61E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x25A19F0", Offset = "0x25A09F0", VA = "0x1825A19F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x26D8240", Offset = "0x26D7240", VA = "0x1826D8240")]
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
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2ED87C0", Offset = "0x2ED77C0", VA = "0x182ED87C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x27E1CB0", Offset = "0x27E0CB0", VA = "0x1827E1CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CAB720", Offset = "0x1CAA720", VA = "0x181CAB720")]
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
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
	public global::JNNOLJAFELM<T> IMMPCOIBHEB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x5148F40", Offset = "0x5147F40", VA = "0x185148F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x513FBC0", Offset = "0x513EBC0", VA = "0x18513FBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x51410F0", Offset = "0x51400F0", VA = "0x1851410F0")]
		public static MethodInfo DGAMFOBEJMM(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5141500", Offset = "0x5140500", VA = "0x185141500")]
		public static MethodInfo HJFKJCGGCHL(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x51413C0", Offset = "0x51403C0", VA = "0x1851413C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public IADCEBCEGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x513F4A0", Offset = "0x513E4A0", VA = "0x18513F4A0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x513F4E0", Offset = "0x513E4E0", VA = "0x18513F4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public AMCJPCCKCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5139660", Offset = "0x5138660", VA = "0x185139660")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public EIGLOLGFOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x513A7D0", Offset = "0x51397D0", VA = "0x18513A7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public HJILECBAOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x513EE50", Offset = "0x513DE50", VA = "0x18513EE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public LFMBAHPIGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5140B80", Offset = "0x513FB80", VA = "0x185140B80")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5140B90", Offset = "0x513FB90", VA = "0x185140B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public EGCLHDEEMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x513A4C0", Offset = "0x51394C0", VA = "0x18513A4C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public HCDINGGJEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x681FD0", Offset = "0x680FD0", VA = "0x180681FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public IAHHECMJGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x513F580", Offset = "0x513E580", VA = "0x18513F580")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public GKNHCDNKEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x513EB00", Offset = "0x513DB00", VA = "0x18513EB00")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x513EDB0", Offset = "0x513DDB0", VA = "0x18513EDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public JBIOEJEIPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x121F160", Offset = "0x121E160", VA = "0x18121F160")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public KJOFOODCOKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x121F160", Offset = "0x121E160", VA = "0x18121F160")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E277E0", Offset = "0x2E267E0", VA = "0x182E277E0")]
	public static object JHFDGOLFHCA<T>(ODAALDAPPKD DDEFJEHCKHG, LOKDBPMCGHA HAGKKODIIII, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CE20", Offset = "0x2E1BE20", VA = "0x182E1CE20")]
	public static object COCGOEDNNGF<T>(LOKDBPMCGHA HAGKKODIIII, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK, bool BOAEPGJEDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4296B80", Offset = "0x4295B80", VA = "0x184296B80")]
	private static TypeInfo INOHNGCOMJI(ODAALDAPPKD DDEFJEHCKHG, Type NKICFHCCMMH, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4294F80", Offset = "0x4293F80", VA = "0x184294F80")]
	public static object HIMKGIIFCGO(Type NKICFHCCMMH, Func<string, string> CMANJFKFPCG, bool EPFFAOOEBIK, bool BOAEPGJEDHO, bool NPFLMHNGGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4293060", Offset = "0x4292060", VA = "0x184293060")]
	private static Dictionary<CPHKEJEHFFI, FieldInfo> BIIIFMOAALF(TypeBuilder CAKAKLGNBLD, OGNLOCKLBCO JENKMGOKHPL, ConstructorInfo MFMGKGDAPJB, FieldBuilder NLBCEPDPEFF, ILGenerator BNJPLGFLIAJ, bool EPFFAOOEBIK, bool AFKBMADDCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x42996A0", Offset = "0x42986A0", VA = "0x1842996A0")]
	private static Dictionary<CPHKEJEHFFI, FieldInfo> PBBEJKFBHPM(TypeBuilder CAKAKLGNBLD, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4293740", Offset = "0x4292740", VA = "0x184293740")]
	private static void BIMPNHPDBKC(Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ, Action ICNCKAKELMF, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, bool EPFFAOOEBIK, bool AFKBMADDCEC, int LOHGOPDMHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4292920", Offset = "0x4291920", VA = "0x184292920")]
	private static void AICGJENGIME(TypeInfo NKICFHCCMMH, CPHKEJEHFFI KHAAONOKIMB, ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, DCCIMLEJMHH MLMFBHHJDGG, DCCIMLEJMHH JBHOHKLEENF, DCCIMLEJMHH FPBPADHDMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4298260", Offset = "0x4297260", VA = "0x184298260")]
	private static void ODJGGHNOEPM(Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, ILGenerator BNJPLGFLIAJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, bool DHDCDPCPHMO, int LOHGOPDMHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4297610", Offset = "0x4296610", VA = "0x184297610")]
	private static void JLHDIJGLJDI(ILGenerator BNJPLGFLIAJ, AIBNMNAFNCM JENKMGOKHPL, int AIPHGHFENPJ, Func<int, CPHKEJEHFFI, bool> JJFJCOGLDHC, DCCIMLEJMHH ANKKMEDLEHC, DCCIMLEJMHH FPBPADHDMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4291C70", Offset = "0x4290C70", VA = "0x184291C70")]
	private static LocalBuilder AGKGPBPIMDB(ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH, OGNLOCKLBCO JENKMGOKHPL, AIBNMNAFNCM[] OEKDHDGKNIJ, bool FOPIGMBNEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4297B60", Offset = "0x4296B60", VA = "0x184297B60")]
	private static bool LJCEKNKDABK(ConstructorInfo KEMDDJPADGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4294DD0", Offset = "0x4293DD0", VA = "0x184294DD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2AC91C0", Offset = "0x2AC81C0", VA = "0x182AC91C0")]
	public OHCOAOGFFMP(byte[][] NLBCEPDPEFF, object[] NNAJOCDFKGN, object[] JNANILGLAGM, global::DHFBONEBMAN<T> NHGODJCEDDK, global::GACMKDJBDLB<T> HEEJCHPDFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x31E3480", Offset = "0x31E2480", VA = "0x1831E3480", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x31E3560", Offset = "0x31E2560", VA = "0x1831E3560", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FCCFF0", Offset = "0x2FCBFF0", VA = "0x182FCCFF0")]
		static NIFOIMLPMFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private NHMDKOJMPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3331140", Offset = "0x3330140", VA = "0x183331140")]
		static PFDPDCJHJHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly LOKDBPMCGHA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private PLGJBPIIGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37C5740", Offset = "0x37C4740", VA = "0x1837C5740")]
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
			[Cpp2IlInjected.Address(RVA = "0x2597380", Offset = "0x2596380", VA = "0x182597380")]
			static AGBCCLGNMHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private GJAGDDOOIGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private OJGKJBIIILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F12830", Offset = "0x2F11830", VA = "0x182F12830")]
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
			[Cpp2IlInjected.Address(RVA = "0x3074F40", Offset = "0x3073F40", VA = "0x183074F40")]
			static LMLGOHNCAOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private NANBDBICHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private EFNMFAPIKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2955250", Offset = "0x2954250", VA = "0x182955250")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CC40C0", Offset = "0x3CC30C0", VA = "0x183CC40C0")]
			static LAHJHKFCDOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private ELFLPGMAPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private ONAMNPOMKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3075BF0", Offset = "0x3074BF0", VA = "0x183075BF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EF1150", Offset = "0x2EF0150", VA = "0x182EF1150")]
			static HLAAMGOAKNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private BAPBGFPHFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private OPNDONGIHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3379C60", Offset = "0x3378C60", VA = "0x183379C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x301ADA0", Offset = "0x3019DA0", VA = "0x18301ADA0")]
			static MCDCILNPIEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private AFEPIEBMHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private PFMMLNKGMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D0E40", Offset = "0x27CFE40", VA = "0x1827D0E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x31C2300", Offset = "0x31C1300", VA = "0x1831C2300")]
			static PDOJGJOLGIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private CBHPGKCLJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private LMALOAECNMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32F2700", Offset = "0x32F1700", VA = "0x1832F2700")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F0F460", Offset = "0x2F0E460", VA = "0x182F0F460")]
			static KAGNCNBLIMJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private MPDMCIPCILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private FMOBBBPOAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32DCCC0", Offset = "0x32DBCC0", VA = "0x1832DCCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F65E60", Offset = "0x2F64E60", VA = "0x182F65E60")]
			static JNKKDEGCIHL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private INDOHLPBKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private KDGOIEKLNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x35DAC40", Offset = "0x35D9C40", VA = "0x1835DAC40")]
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
			[Cpp2IlInjected.Address(RVA = "0x34AB980", Offset = "0x34AA980", VA = "0x1834AB980")]
			static JHFBIBKPIHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private NGCOOAIBJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private ONLIBBOOLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AF7330", Offset = "0x2AF6330", VA = "0x182AF7330")]
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
			[Cpp2IlInjected.Address(RVA = "0x27DD2F0", Offset = "0x27DC2F0", VA = "0x1827DD2F0")]
			static CMEGECDDPEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private EALEFALAMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private JCNGDHHCIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AFFB50", Offset = "0x2AFEB50", VA = "0x182AFFB50")]
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
			[Cpp2IlInjected.Address(RVA = "0x28D3000", Offset = "0x28D2000", VA = "0x1828D3000")]
			static DENOGIFGKAP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private ODDFHJDFAPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private CCPPKCGFGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3024000", Offset = "0x3023000", VA = "0x183024000")]
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
			[Cpp2IlInjected.Address(RVA = "0x2774E50", Offset = "0x2773E50", VA = "0x182774E50")]
			static FGFJDOHEBDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly LOKDBPMCGHA JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly LOKDBPMCGHA[] OEHGGFHFBON;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		private JCOCGCAPBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	private ECAABBFCBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x20F2470", Offset = "0x20F1470", VA = "0x1820F2470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x33352D0", Offset = "0x33342D0", VA = "0x1833352D0")]
	public PFFGLIOAFFG(int AIGDDFDNOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3335150", Offset = "0x3334150", VA = "0x183335150")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3335240", Offset = "0x3334240", VA = "0x183335240")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F79E40", Offset = "0x4F78E40", VA = "0x184F79E40")]
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
	[Cpp2IlInjected.Address(RVA = "0x32D7300", Offset = "0x32D6300", VA = "0x1832D7300")]
	public KEFICJEPPGO(int FMGFIHODCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x32D7050", Offset = "0x32D6050", VA = "0x1832D7050")]
	public T[] ACAAPGHKAHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x32D65D0", Offset = "0x32D55D0", VA = "0x1832D65D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
			[DebuggerHidden]
			public EHFOANLNPOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x513A660", Offset = "0x5139660", VA = "0x18513A660", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x513A790", Offset = "0x5139790", VA = "0x18513A790", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x513A6F0", Offset = "0x51396F0", VA = "0x18513A6F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AHENJGGJBFD> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x513A6F0", Offset = "0x51396F0", VA = "0x18513A6F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public APBNGAIOKMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x681FD0", Offset = "0x680FD0", VA = "0x180681FD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x681FD0", Offset = "0x680FD0", VA = "0x180681FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD83AC0", Offset = "0xD82AC0", VA = "0x180D83AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x51395A0", Offset = "0x51385A0", VA = "0x1851395A0")]
		public AHENJGGJBFD(ulong CCJNKBLKLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x51381F0", Offset = "0x51371F0", VA = "0x1851381F0")]
		public AHENJGGJBFD HEFJCCLOLGO(ulong CCJNKBLKLDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x51381A0", Offset = "0x51371A0", VA = "0x1851381A0")]
		public AHENJGGJBFD HEFJCCLOLGO(ulong CCJNKBLKLDJ, int IGJPNMBCJPK, string MGKBPDDPAGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x51391A0", Offset = "0x51381A0", VA = "0x1851391A0")]
		public AHENJGGJBFD KODACLNEAKH(byte[] JOLHNMOCKDJ, ref int LBACAALGKLG, ref int NCJHPIDHIAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5139490", Offset = "0x5138490", VA = "0x185139490")]
		internal static int MIFBMIGANDK(ulong[] DEJEDNNJILK, int AIPHGHFENPJ, int GKPOMAIMOAK, ulong IGJPNMBCJPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5138170", Offset = "0x5137170", VA = "0x185138170", Slot = "4")]
		public int CompareTo(AHENJGGJBFD HNOJKNGFFBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5138100", Offset = "0x5137100", VA = "0x185138100")]
		[IteratorStateMachine(typeof(EHFOANLNPOE))]
		public IEnumerable<AHENJGGJBFD> BLJCNLIHGCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5139350", Offset = "0x5138350", VA = "0x185139350")]
		public void MGBOALHDBNH(ILGenerator BNJPLGFLIAJ, LocalBuilder JOLHNMOCKDJ, LocalBuilder NCJHPIDHIAK, LocalBuilder CCJNKBLKLDJ, Action<KeyValuePair<string, int>> EOLLFGFOCNE, Action HOHJLGNLOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x51384B0", Offset = "0x51374B0", VA = "0x1851384B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5143CD0", Offset = "0x5142CD0", VA = "0x185143CD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B20", Offset = "0xAB1B20", VA = "0x180AB2B20")]
		[DebuggerHidden]
		public NMLCLJAJEPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5143D20", Offset = "0x5142D20", VA = "0x185143D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5143790", Offset = "0x5142790", VA = "0x185143790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5143E00", Offset = "0x5142E00", VA = "0x185143E00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5143E50", Offset = "0x5142E50", VA = "0x185143E50")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5143C90", Offset = "0x5142C90", VA = "0x185143C90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5143BF0", Offset = "0x5142BF0", VA = "0x185143BF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5143BF0", Offset = "0x5142BF0", VA = "0x185143BF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7D590", Offset = "0x4F7C590", VA = "0x184F7D590")]
	public LEFEBFDEKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D050", Offset = "0x4F7C050", VA = "0x184F7D050")]
	public void HEFJCCLOLGO(byte[] HFAIGCGNPJJ, int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D170", Offset = "0x4F7C170", VA = "0x184F7D170")]
	public bool IFNCCANGCPM(ArraySegment<byte> CCJNKBLKLDJ, out int IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D500", Offset = "0x4F7C500", VA = "0x184F7D500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D260", Offset = "0x4F7C260", VA = "0x184F7D260")]
	private static void PPPIDEIAKDM(IEnumerable<AHENJGGJBFD> CCMIPADPMIA, StringBuilder NHDKHCEFNFI, int MOLGFCBNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CFA0", Offset = "0x4F7BFA0", VA = "0x184F7CFA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CFA0", Offset = "0x4F7BFA0", VA = "0x184F7CFA0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CF30", Offset = "0x4F7BF30", VA = "0x184F7CF30")]
	[IteratorStateMachine(typeof(NMLCLJAJEPL))]
	private static IEnumerable<KeyValuePair<string, int>> FIODJCALBMH(IEnumerable<AHENJGGJBFD> CCMIPADPMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D230", Offset = "0x4F7C230", VA = "0x184F7D230")]
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
	[Cpp2IlInjected.Address(RVA = "0x42878A0", Offset = "0x42868A0", VA = "0x1842878A0")]
	public static ulong GHADMMGMIIG(byte[] HFAIGCGNPJJ, ref int LBACAALGKLG, ref int NCJHPIDHIAK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class BOFKLCAIDMC
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x428A310", Offset = "0x4289310", VA = "0x18428A310")]
	public static void JHOPBBOOCLA(ref byte[] HFAIGCGNPJJ, int LBACAALGKLG, int GIDHOGLCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x428A450", Offset = "0x4289450", VA = "0x18428A450")]
	public static void ONKELFNAKMD(ref byte[] DEJEDNNJILK, int EPOAMOEJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x428A1F0", Offset = "0x42891F0", VA = "0x18428A1F0")]
	public static byte[] DEPPCLKCHBF(byte[] ICAAAENIBKC, int EPOAMOEJPAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class BHBJCDJCMNC
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x42896C0", Offset = "0x42886C0", VA = "0x1842896C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24D96A0", Offset = "0x24D86A0", VA = "0x1824D96A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x28CD170", Offset = "0x28CC170", VA = "0x1828CD170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x21D1E20", Offset = "0x21D0E20", VA = "0x1821D1E20")]
		[DebuggerHidden]
		public DCPBCPGEPJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x337D130", Offset = "0x337C130", VA = "0x18337D130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x337D620", Offset = "0x337C620", VA = "0x18337D620", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x37D3720", Offset = "0x37D2720", VA = "0x1837D3720")]
	public JDGGAPLDNFH(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x37D3660", Offset = "0x37D2660", VA = "0x1837D3660")]
	public JDGGAPLDNFH(int CHMDLBBFMNF, float FLHOHCCGGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x37D3030", Offset = "0x37D2030", VA = "0x1837D3030")]
	public void HEFJCCLOLGO(byte[] CCJNKBLKLDJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x37D1A10", Offset = "0x37D0A10", VA = "0x1837D1A10")]
	private bool FGMLDBJKNBM(byte[] CCJNKBLKLDJ, T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x37CF310", Offset = "0x37CE310", VA = "0x1837CF310")]
	public bool CECEMJJAJEO(ArraySegment<byte> CCJNKBLKLDJ, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x37D2AC0", Offset = "0x37D1AC0", VA = "0x1837D2AC0")]
	private static ulong GJIHLCDPCGO(byte[] KNMKEOOODCL, int LBACAALGKLG, int KOHJDBBJEKM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x37D3630", Offset = "0x37D2630", VA = "0x1837D3630")]
	private static int MCHGIMDMKJF(int EOHIDHOLHCB, float FLHOHCCGGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x37D2BB0", Offset = "0x37D1BB0", VA = "0x1837D2BB0", Slot = "4")]
	[IteratorStateMachine(typeof(global::JDGGAPLDNFH<>.DCPBCPGEPJF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x27DEDB0", Offset = "0x27DDDB0", VA = "0x1827DEDB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F7FB20", Offset = "0x4F7EB20", VA = "0x184F7FB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FC90", Offset = "0x4F7EC90", VA = "0x184F7FC90")]
	static NLBDDAGFCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FF10", Offset = "0x4F7EF10", VA = "0x184F7FF10")]
	public NLBDDAGFCEM(byte[] EHDMHONDOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FB70", Offset = "0x4F7EB70", VA = "0x184F7FB70")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F85E20", Offset = "0x4F84E20", VA = "0x184F85E20")]
	public ODHCMGIBAIG(ref Guid IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4F849D0", Offset = "0x4F839D0", VA = "0x184F849D0")]
	public ODHCMGIBAIG(ref ArraySegment<byte> APMMOIAIFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4F833E0", Offset = "0x4F823E0", VA = "0x184F833E0")]
	private static byte CGCLCMEAHFG(byte[] HFAIGCGNPJJ, int IDILNIFMOPD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4F847F0", Offset = "0x4F837F0", VA = "0x184F847F0")]
	private static byte KOIBBIEFGGE(byte BMMLDIMMAAK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4F834A0", Offset = "0x4F824A0", VA = "0x184F834A0")]
	public void FJGIJIFMICL(byte[] CLABEIKAHOI, int LBACAALGKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class OLMHCAFJHFJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5145AC0", Offset = "0x5144AC0", VA = "0x185145AC0")]
	public static bool BCLLAJPEGNE(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5145AD0", Offset = "0x5144AD0", VA = "0x185145AD0")]
	public static bool BEGGFPCIAKB(byte KDPJFGIFCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x51463F0", Offset = "0x51453F0", VA = "0x1851463F0")]
	public static sbyte FCAFBJELBGE(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x51464D0", Offset = "0x51454D0", VA = "0x1851464D0")]
	public static short GBGLBFEDKLJ(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5145B40", Offset = "0x5144B40", VA = "0x185145B40")]
	public static int CGCLBGFIAEF(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x51459A0", Offset = "0x51449A0", VA = "0x1851459A0")]
	public static long AKPKAJHPHND(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5145A50", Offset = "0x5144A50", VA = "0x185145A50")]
	public static byte BBCKHJFHBCK(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5146540", Offset = "0x5145540", VA = "0x185146540")]
	public static ushort KLFEMFLOKCA(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5147450", Offset = "0x5146450", VA = "0x185147450")]
	public static uint NNIEICDPABA(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x51474D0", Offset = "0x51464D0", VA = "0x1851474D0")]
	public static ulong PHHJMKPOOCC(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5146460", Offset = "0x5145460", VA = "0x185146460")]
	public static float FIPEPGKAELM(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5145BB0", Offset = "0x5144BB0", VA = "0x185145BB0")]
	public static double COEEEHMEAOP(byte[] HFAIGCGNPJJ, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5145C20", Offset = "0x5144C20", VA = "0x185145C20")]
	public static int DBMGIHAEODI(ref byte[] CLABEIKAHOI, int LBACAALGKLG, ulong IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x51465B0", Offset = "0x51455B0", VA = "0x1851465B0")]
	public static int NJBGPAHMPKF(ref byte[] CLABEIKAHOI, int LBACAALGKLG, long IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x51471E0", Offset = "0x51461E0", VA = "0x1851471E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
		[DebuggerHidden]
		public HKPLMCLJINN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x513F310", Offset = "0x513E310", VA = "0x18513F310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x513EEB0", Offset = "0x513DEB0", VA = "0x18513EEB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x513F400", Offset = "0x513E400", VA = "0x18513F400")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x513F450", Offset = "0x513E450", VA = "0x18513F450")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x513F2D0", Offset = "0x513E2D0", VA = "0x18513F2D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x513F220", Offset = "0x513E220", VA = "0x18513F220", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x513F220", Offset = "0x513E220", VA = "0x18513F220", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
		[DebuggerHidden]
		public BJDICECIMCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5139D20", Offset = "0x5138D20", VA = "0x185139D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x51398C0", Offset = "0x51388C0", VA = "0x1851398C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5139E10", Offset = "0x5138E10", VA = "0x185139E10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5139E60", Offset = "0x5138E60", VA = "0x185139E60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5139CE0", Offset = "0x5138CE0", VA = "0x185139CE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5139C30", Offset = "0x5138C30", VA = "0x185139C30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5139C30", Offset = "0x5138C30", VA = "0x185139C30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x428F8F0", Offset = "0x428E8F0", VA = "0x18428F8F0")]
	public static bool EBDPBJNODHF(this TypeInfo NKICFHCCMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x428FB10", Offset = "0x428EB10", VA = "0x18428FB10")]
	public static bool NKMPCKAKMFA(this TypeInfo NKICFHCCMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x428FCC0", Offset = "0x428ECC0", VA = "0x18428FCC0")]
	public static IEnumerable<PropertyInfo> OGCLJNMGCPK(this Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x428FA80", Offset = "0x428EA80", VA = "0x18428FA80")]
	[IteratorStateMachine(typeof(HKPLMCLJINN))]
	private static IEnumerable<PropertyInfo> JJMEBKKINAO(Type NKICFHCCMMH, HashSet<string> BNCEPBFPPIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x428F9B0", Offset = "0x428E9B0", VA = "0x18428F9B0")]
	public static IEnumerable<FieldInfo> EKMIJLCFOOM(this Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x428FC30", Offset = "0x428EC30", VA = "0x18428FC30")]
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
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x736040", VA = "0x180737040")]
	public static string PKBMJFALMOK(string JELKAOENNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B2B0", Offset = "0x4F7A2B0", VA = "0x184F7B2B0")]
	public static string EEOGDNNBLDD(string JELKAOENNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B3C0", Offset = "0x4F7A3C0", VA = "0x184F7B3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x26DE4E0", Offset = "0x26DD4E0", VA = "0x1826DE4E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x26DE460", Offset = "0x26DD460", VA = "0x1826DE460")]
		private int MNCJKLLDCNE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public NMAHKMCIBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xD85AF0", Offset = "0xD84AF0", VA = "0x180D85AF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46736D0", Offset = "0x46726D0", VA = "0x1846736D0")]
	public DIEINJJIANO(int CHMDLBBFMNF = 4, float FLHOHCCGGBP = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4672A90", Offset = "0x4671A90", VA = "0x184672A90")]
	public bool LHAEMCGIOMO(Type CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4672BE0", Offset = "0x4671BE0", VA = "0x184672BE0")]
	public bool LHAEMCGIOMO(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x46724C0", Offset = "0x46714C0", VA = "0x1846724C0")]
	private bool FGMLDBJKNBM(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO, out TValue PNFHPOBCPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4672D30", Offset = "0x4671D30", VA = "0x184672D30")]
	private bool MKEGPABBLJI(BNIKACKJNKP[] BINDDLEDHON, Type PJEADMGHKIL, BNIKACKJNKP KNPOBLIOELK, Func<Type, TValue> BOHBMFGICDO, out TValue PNFHPOBCPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4672370", Offset = "0x4671370", VA = "0x184672370")]
	public bool CECEMJJAJEO(Type CCJNKBLKLDJ, out TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4673490", Offset = "0x4672490", VA = "0x184673490")]
	public TValue NOCCDIAEOGP(Type CCJNKBLKLDJ, Func<Type, TValue> BOHBMFGICDO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x37D3630", Offset = "0x37D2630", VA = "0x1837D3630")]
	private static int MCHGIMDMKJF(int EOHIDHOLHCB, float FLHOHCCGGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4672A60", Offset = "0x4671A60", VA = "0x184672A60")]
	private static void LGCDJLBFEOG(ref BNIKACKJNKP DEHOGNNECIF, BNIKACKJNKP IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4672A60", Offset = "0x4671A60", VA = "0x184672A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F82DE0", Offset = "0x4F81DE0", VA = "0x184F82DE0")]
	public TypeBuilder FAKEPLAFAMN(string BEMAPDNKPAD, TypeAttributes ACIANFKCINM, Type ADECAOLBLPJ, Type[] HBAHBAGNFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x4F82EB0", Offset = "0x4F81EB0", VA = "0x184F82EB0")]
	public ODAALDAPPKD(string LKBDENNFFEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class DINIDBMPFMB
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x428F820", Offset = "0x428E820", VA = "0x18428F820")]
	private static MethodInfo COPNDAHKOKA(LambdaExpression INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x267ACE0", Offset = "0x2679CE0", VA = "0x18267ACE0")]
	public static MethodInfo EKPOHGDIGNJ<T>(Expression<Func<T>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x267ACE0", Offset = "0x2679CE0", VA = "0x18267ACE0")]
	public static MethodInfo EKPOHGDIGNJ<T, TR>(Expression<Func<T, TR>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x267ACE0", Offset = "0x2679CE0", VA = "0x18267ACE0")]
	public static MethodInfo EKPOHGDIGNJ<T>(Expression<Action<T>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x267ACE0", Offset = "0x2679CE0", VA = "0x18267ACE0")]
	public static MethodInfo EKPOHGDIGNJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> INLHKOCHCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x267ACF0", Offset = "0x2679CF0", VA = "0x18267ACF0")]
	private static MemberInfo ELHFDECGBEO<T>(Expression<T> IKPEGPHMIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x267AC80", Offset = "0x2679C80", VA = "0x18267AC80")]
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
	[Cpp2IlInjected.Address(RVA = "0x428E340", Offset = "0x428D340", VA = "0x18428E340")]
	public DCCIMLEJMHH(ILGenerator BNJPLGFLIAJ, int HLAPKJLCEDC, bool KGPNFOGGFDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x428E2B0", Offset = "0x428D2B0", VA = "0x18428E2B0")]
	public DCCIMLEJMHH(ILGenerator BNJPLGFLIAJ, int HLAPKJLCEDC, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x428E290", Offset = "0x428D290", VA = "0x18428E290")]
	public void NPFEGMBBAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class IHKLPGNLPGD
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4F758E0", Offset = "0x4F748E0", VA = "0x184F758E0")]
	public static void IAKIHNPGLMM(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4F758A0", Offset = "0x4F748A0", VA = "0x184F758A0")]
	public static void IAKIHNPGLMM(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4F75CD0", Offset = "0x4F74CD0", VA = "0x184F75CD0")]
	public static void MHEHNDFBLFF(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4F75C90", Offset = "0x4F74C90", VA = "0x184F75C90")]
	public static void MHEHNDFBLFF(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4F75590", Offset = "0x4F74590", VA = "0x184F75590")]
	public static void FEPBJPBPFGA(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4F75480", Offset = "0x4F74480", VA = "0x184F75480")]
	public static void FEPBJPBPFGA(this ILGenerator BNJPLGFLIAJ, LocalBuilder BAMHLPOBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4F75F00", Offset = "0x4F74F00", VA = "0x184F75F00")]
	public static void MKOFPOGIEJE(this ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4F76010", Offset = "0x4F75010", VA = "0x184F76010")]
	public static void OJCINDEKKBB(this ILGenerator BNJPLGFLIAJ, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4F76020", Offset = "0x4F75020", VA = "0x184F76020")]
	public static void PFHIEDGBLKN(this ILGenerator BNJPLGFLIAJ, int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4F75BA0", Offset = "0x4F74BA0", VA = "0x184F75BA0")]
	public static void KECCPPHAMND(this ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4F75700", Offset = "0x4F74700", VA = "0x184F75700")]
	public static void FHNJGMJIFEM(this ILGenerator BNJPLGFLIAJ, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4F75250", Offset = "0x4F74250", VA = "0x184F75250")]
	public static void DAJDJDJAPAE(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4F75680", Offset = "0x4F74680", VA = "0x184F75680")]
	public static void FGEFJHEMAOJ(this ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4F757B0", Offset = "0x4F747B0", VA = "0x184F757B0")]
	public static void FOJJIHBCHFI(this ILGenerator BNJPLGFLIAJ, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4F75F10", Offset = "0x4F74F10", VA = "0x184F75F10")]
	public static void OBKNFOMFJIE(this ILGenerator BNJPLGFLIAJ, MethodInfo MKNJAKNCPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4F75B10", Offset = "0x4F74B10", VA = "0x184F75B10")]
	public static void IBJJLGAIEOE(this ILGenerator BNJPLGFLIAJ, FieldInfo LJNGIPHLJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4F751C0", Offset = "0x4F741C0", VA = "0x184F751C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public JCPIBIIPIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x513FAB0", Offset = "0x513EAB0", VA = "0x18513FAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string GKGPGJHPFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x676140", VA = "0x180677140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MHDKIMHMKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x428DA40", Offset = "0x428CA40", VA = "0x18428DA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BGKNHKLPBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6723D0", Offset = "0x6713D0", VA = "0x1806723D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x77E1D0", Offset = "0x77D1D0", VA = "0x18077E1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DFGCAAIFPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x6713E0", VA = "0x1806723E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD0F560", Offset = "0xD0E560", VA = "0x180D0F560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x6981C0", VA = "0x1806991C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo GPCNMDPLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo HPOEGHCFBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D570", VA = "0x18065E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D590", VA = "0x18065E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo KBFGBFIFGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x65E580", Offset = "0x65D580", VA = "0x18065E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x65E5A0", Offset = "0x65D5A0", VA = "0x18065E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x428DE90", Offset = "0x428CE90", VA = "0x18428DE90")]
	protected CPHKEJEHFFI(Type NKICFHCCMMH, string BEMAPDNKPAD, string NNNOJJMLEJC, bool OIGNCOPLCNN, bool JNEIHELLFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x428DD80", Offset = "0x428CD80", VA = "0x18428DD80")]
	public CPHKEJEHFFI(FieldInfo JENKMGOKHPL, string BEMAPDNKPAD, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x428DBD0", Offset = "0x428CBD0", VA = "0x18428DBD0")]
	public CPHKEJEHFFI(PropertyInfo JENKMGOKHPL, string BEMAPDNKPAD, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x428D8D0", Offset = "0x428C8D0", VA = "0x18428D8D0")]
	private static MethodInfo CDJPIALPBDP(MemberInfo JENKMGOKHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x229BD60", Offset = "0x229AD60", VA = "0x18229BD60")]
	public T CLMCKOPCBOH<T>(bool ODPKDODHNDF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x428DA50", Offset = "0x428CA50", VA = "0x18428DA50", Slot = "4")]
	public virtual void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x428DB10", Offset = "0x428CB10", VA = "0x18428DB10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7DF40", Offset = "0x4F7CF40", VA = "0x184F7DF40")]
	public LNIOBANDANN(string BEMAPDNKPAD, string BGHBALDEJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7DE40", Offset = "0x4F7CE40", VA = "0x184F7DE40", Slot = "4")]
	public override void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4F7DF00", Offset = "0x4F7CF00", VA = "0x184F7DF00", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4283970", Offset = "0x4282970", VA = "0x184283970")]
	public AFCJBCIFGFM(string BEMAPDNKPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4283310", Offset = "0x4282310", VA = "0x184283310", Slot = "4")]
	public override void MOPKIJLMCGJ(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x42833E0", Offset = "0x42823E0", VA = "0x1842833E0", Slot = "5")]
	public override void NNPPNMEPLJK(ILGenerator BNJPLGFLIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x42831C0", Offset = "0x42821C0", VA = "0x1842831C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IHJKHNKCKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6718D0", Offset = "0x6708D0", VA = "0x1806718D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x693000", Offset = "0x692000", VA = "0x180693000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FMKOEAAGOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x73B7F0", Offset = "0x73A7F0", VA = "0x18073B7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x73B800", Offset = "0x73A800", VA = "0x18073B800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo DNIMABPHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CPHKEJEHFFI[] EIAFCALOOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x6981C0", VA = "0x1806991C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CPHKEJEHFFI[] IPLHAKIFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5144150", Offset = "0x5143150", VA = "0x185144150")]
	public OGNLOCKLBCO(Type NKICFHCCMMH, Func<string, string> HMKJPMFPIEE, bool BOAEPGJEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5144060", Offset = "0x5143060", VA = "0x185144060")]
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
	[Cpp2IlInjected.Address(RVA = "0x204F230", Offset = "0x204E230", VA = "0x18204F230")]
	public MCKOGFAAPEO(ulong OLKMBLPMENH, int MAJAOEBPCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E130", Offset = "0x4F7D130", VA = "0x184F7E130")]
	public void HPPMEINDINK(ref MCKOGFAAPEO HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E140", Offset = "0x4F7D140", VA = "0x184F7E140")]
	public static MCKOGFAAPEO KLGDEBEOEEG(ref MCKOGFAAPEO BMPDKJEHGIN, ref MCKOGFAAPEO BMMLDIMMAAK)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E000", Offset = "0x4F7D000", VA = "0x184F7E000")]
	public void HBKIGLGNGGK(ref MCKOGFAAPEO HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E090", Offset = "0x4F7D090", VA = "0x184F7E090")]
	public static MCKOGFAAPEO HPCAGJGHFCC(ref MCKOGFAAPEO BMPDKJEHGIN, ref MCKOGFAAPEO BMMLDIMMAAK)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E1A0", Offset = "0x4F7D1A0", VA = "0x184F7E1A0")]
	public void PIDPECDHIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E150", Offset = "0x4F7D150", VA = "0x184F7E150")]
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
	[Cpp2IlInjected.Address(RVA = "0x771140", Offset = "0x770140", VA = "0x180771140")]
	public KBDAPDCFLAC(byte[] CLABEIKAHOI, int EIIEKPIPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A680", Offset = "0x4F79680", VA = "0x184F7A680")]
	public void KNMCHABHDGK(byte JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A560", Offset = "0x4F79560", VA = "0x184F7A560")]
	public void ANNLPGCBPFJ(byte[] JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A410", Offset = "0x4F79410", VA = "0x184F7A410")]
	public void AANBBHIJCGF(byte[] JNFDLMOFJOO, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A4B0", Offset = "0x4F794B0", VA = "0x184F7A4B0")]
	public void AANBBHIJCGF(byte[] JNFDLMOFJOO, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A600", Offset = "0x4F79600", VA = "0x184F7A600")]
	public void FGKBCOEHMKB(byte KDPJFGIFCOL, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A6E0", Offset = "0x4F796E0", VA = "0x184F7A6E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x42856E0", Offset = "0x42846E0", VA = "0x1842856E0")]
	private static byte[] DENDMDEOIEF(int MNKEEJPGFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x42867A0", Offset = "0x42857A0", VA = "0x1842867A0")]
	private static byte[] KNKAFADDMNC(int MNKEEJPGFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4285FD0", Offset = "0x4284FD0", VA = "0x184285FD0")]
	public static int FMAJACAKGLG(ref byte[] CLABEIKAHOI, int LBACAALGKLG, float IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x42860F0", Offset = "0x42850F0", VA = "0x1842860F0")]
	public static int FMAJACAKGLG(ref byte[] CLABEIKAHOI, int LBACAALGKLG, double IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4286DA0", Offset = "0x4285DA0", VA = "0x184286DA0")]
	private static bool NPBHHOBBNHH(byte[] CLABEIKAHOI, int GKPOMAIMOAK, ulong PMPHKPPDOJC, ulong BCPLKCMOHKM, ulong NCJHPIDHIAK, ulong NPOGEPMNLAA, ulong MHKGIFOFBOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x42855C0", Offset = "0x42845C0", VA = "0x1842855C0")]
	private static void BCNPPMPAPCL(uint IGDINCONBGD, int FNAGAAEAGLL, out uint ONBODKODHNJ, out int FONFFOECJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4286880", Offset = "0x4285880", VA = "0x184286880")]
	private static bool LEEOIBBLNPL(MCKOGFAAPEO MCDGEBBILIJ, MCKOGFAAPEO KKGHEBDDELA, MCKOGFAAPEO ILAOCNGHFLG, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int FMPGCHGBDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4286500", Offset = "0x4285500", VA = "0x184286500")]
	private static bool JILABDDABEE(double HFMHCLGICNJ, BAFKPIKAHOE CIJCIMPGNPO, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int KAKDIMEDOFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x42863F0", Offset = "0x42853F0", VA = "0x1842863F0")]
	private static bool IDCMKILOJPD(double HFMHCLGICNJ, BAFKPIKAHOE CIJCIMPGNPO, byte[] CLABEIKAHOI, out int GKPOMAIMOAK, out int MFEBBMOCEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4285430", Offset = "0x4284430", VA = "0x184285430")]
	private static bool AFLDOJPDIED(double IGJPNMBCJPK, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x42857C0", Offset = "0x42847C0", VA = "0x1842857C0")]
	private static bool DKHFMDGCBGD(double IGJPNMBCJPK, ref KBDAPDCFLAC CAGCFAOHBGH, JHIAIDKOECC CIJCIMPGNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4286210", Offset = "0x4285210", VA = "0x184286210")]
	private static void GILALFMFGMN(byte[] JEBACMJJMOF, int GKPOMAIMOAK, int MFEBBMOCEMA, int FCECNJBELMF, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4286EA0", Offset = "0x4285EA0", VA = "0x184286EA0")]
	private static void PBIDELMGLLI(byte[] JEBACMJJMOF, int GKPOMAIMOAK, int MAJAOEBPCPC, ref KBDAPDCFLAC CAGCFAOHBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4285E20", Offset = "0x4284E20", VA = "0x184285E20")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F86EE0", Offset = "0x4F85EE0", VA = "0x184F86EE0")]
	public OFMMJKGGOIM(double NAGBPGCPEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F86E40", Offset = "0x4F85E40", VA = "0x184F86E40")]
	public OFMMJKGGOIM(MCKOGFAAPEO NAGBPGCPEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4F86890", Offset = "0x4F85890", VA = "0x184F86890")]
	public MCKOGFAAPEO BPIMNDEHAPO()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F86A70", Offset = "0x4F85A70", VA = "0x184F86A70")]
	public MCKOGFAAPEO GEPPNEBKBOJ()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x656000", VA = "0x180657000")]
	public ulong HCIJEIGLJKD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4F86B00", Offset = "0x4F85B00", VA = "0x184F86B00")]
	public double GOOCLIIJOMI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F86D60", Offset = "0x4F85D60", VA = "0x184F86D60")]
	public double OKEODFPJMBI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F86910", Offset = "0x4F85910", VA = "0x184F86910")]
	public int CKACGJLIEFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F86A40", Offset = "0x4F85A40", VA = "0x184F86A40")]
	public ulong GCAODMKHGBH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F86A20", Offset = "0x4F85A20", VA = "0x184F86A20")]
	public bool GAENBIJHMEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F86870", Offset = "0x4F85870", VA = "0x184F86870")]
	public bool AFLFHJHNEJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F86D30", Offset = "0x4F85D30", VA = "0x184F86D30")]
	public bool OFOHPOFOPBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F86BB0", Offset = "0x4F85BB0", VA = "0x184F86BB0")]
	public bool LOIHEJDIILG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F86A00", Offset = "0x4F85A00", VA = "0x184F86A00")]
	public int DKKNBAHFPKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F86BE0", Offset = "0x4F85BE0", VA = "0x184F86BE0")]
	public void OCGOJNINOMO(out MCKOGFAAPEO HFEEKHKDPKI, out MCKOGFAAPEO ICKHFGECKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4F86DF0", Offset = "0x4F85DF0", VA = "0x184F86DF0")]
	public bool PJICEADNPEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4F86B90", Offset = "0x4F85B90", VA = "0x184F86B90")]
	public double IGJPNMBCJPK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4F86940", Offset = "0x4F85940", VA = "0x184F86940")]
	public static int CLFFFIHJIKC(int DHFODKLLKIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4F86BA0", Offset = "0x4F85BA0", VA = "0x184F86BA0")]
	public static double JMPCNHFGBNP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4F86960", Offset = "0x4F85960", VA = "0x184F86960")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C490E0", Offset = "0x2C480E0", VA = "0x182C490E0")]
	public FDCBCLHMBJG(float ACDBJHBECNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D5F0", Offset = "0x4F6C5F0", VA = "0x184F6D5F0")]
	public MCKOGFAAPEO BPIMNDEHAPO()
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20")]
	public uint LBFONAAGEAJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D650", Offset = "0x4F6C650", VA = "0x184F6D650")]
	public int CKACGJLIEFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D680", Offset = "0x4F6C680", VA = "0x184F6D680")]
	public uint GCAODMKHGBH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D670", Offset = "0x4F6C670", VA = "0x184F6D670")]
	public bool GAENBIJHMEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D6A0", Offset = "0x4F6C6A0", VA = "0x184F6D6A0")]
	public void OCGOJNINOMO(out MCKOGFAAPEO HFEEKHKDPKI, out MCKOGFAAPEO ICKHFGECKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D7D0", Offset = "0x4F6C7D0", VA = "0x184F6D7D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4289E40", Offset = "0x4288E40", VA = "0x184289E40")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F6DB70", Offset = "0x4F6CB70", VA = "0x184F6DB70")]
	public static void DOAJIIIOBDK(int FELOCCIEGCP, int OHGMGEJBFEL, out MCKOGFAAPEO ONBODKODHNJ, out int KAKDIMEDOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F6DCA0", Offset = "0x4F6CCA0", VA = "0x184F6DCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x42903F0", Offset = "0x428F3F0", VA = "0x1842903F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xCCD1E0", Offset = "0xCCC1E0", VA = "0x180CCD1E0")]
	public EBAINEELELO(byte[] HFAIGCGNPJJ, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x76A5E0", Offset = "0x7695E0", VA = "0x18076A5E0")]
	public int GKPOMAIMOAK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4290390", Offset = "0x428F390", VA = "0x184290390")]
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
	[Cpp2IlInjected.Address(RVA = "0x428C220", Offset = "0x428B220", VA = "0x18428C220")]
	private static byte[] CDOFLEPMFIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x428C140", Offset = "0x428B140", VA = "0x18428C140")]
	private static EBAINEELELO BCILANKJMOK(EBAINEELELO CLABEIKAHOI)
	{
		return default(EBAINEELELO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x428D0E0", Offset = "0x428C0E0", VA = "0x18428D0E0")]
	private static EBAINEELELO OJHNFDKLIKB(EBAINEELELO CLABEIKAHOI)
	{
		return default(EBAINEELELO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x428CE80", Offset = "0x428BE80", VA = "0x18428CE80")]
	private static void JBBBIEKJKME(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, byte[] CFJGAKCNFDK, out int LMHMLHKDHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x428CB60", Offset = "0x428BB60", VA = "0x18428CB60")]
	private static void HNGNEJMPDIB(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, byte[] JEILGJFMLBK, int PKPOJMGKFCM, out EBAINEELELO AFJBKCCDGCI, out int OPKBEOHPDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x428CAD0", Offset = "0x428BAD0", VA = "0x18428CAD0")]
	private static ulong GIAFBECHNCD(EBAINEELELO CLABEIKAHOI, out int NHNOEHFLLBP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x428C310", Offset = "0x428B310", VA = "0x18428C310")]
	private static void COHKBGFCGBB(EBAINEELELO CLABEIKAHOI, out MCKOGFAAPEO BBLJKOEKFJI, out int AALPGFHIAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x428D1C0", Offset = "0x428C1C0", VA = "0x18428D1C0")]
	private static bool ONNDIKPEIDC(EBAINEELELO AFJBKCCDGCI, int MAJAOEBPCPC, out double BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x428CF30", Offset = "0x428BF30", VA = "0x18428CF30")]
	private static MCKOGFAAPEO LFHILEHJIBF(int MAJAOEBPCPC)
	{
		return default(MCKOGFAAPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x428C4A0", Offset = "0x428B4A0", VA = "0x18428C4A0")]
	private static bool FJLBJFGKHPL(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC, out double BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x428C000", Offset = "0x428B000", VA = "0x18428C000")]
	private static bool BCDALGHMIEM(EBAINEELELO AFJBKCCDGCI, int MAJAOEBPCPC, out double LADILAJMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x428C9B0", Offset = "0x428B9B0", VA = "0x18428C9B0")]
	public static double? GAKKOOHBACE(EBAINEELELO CLABEIKAHOI, int MAJAOEBPCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x428D640", Offset = "0x428C640", VA = "0x18428D640")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F7F6B0", Offset = "0x4F7E6B0", VA = "0x184F7F6B0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x771140", Offset = "0x770140", VA = "0x180771140")]
	public NINNIJFNFLD(byte[] CLABEIKAHOI, int LBACAALGKLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F4D0", Offset = "0x4F7E4D0", VA = "0x184F7F4D0")]
	public static NINNIJFNFLD CGPJMKBEIBP(NINNIJFNFLD CFFPEBFKEAC)
	{
		return default(NINNIJFNFLD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F610", Offset = "0x4F7E610", VA = "0x184F7F610")]
	public static NINNIJFNFLD KFDPIIJCIIP(NINNIJFNFLD CFFPEBFKEAC, int GKPOMAIMOAK)
	{
		return default(NINNIJFNFLD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F740", Offset = "0x4F7E740", VA = "0x184F7F740")]
	public static int MPKLCJPFEHE(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F4E0", Offset = "0x4F7E4E0", VA = "0x184F7F4E0")]
	public static bool CJJJLAGEFIA(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F5A0", Offset = "0x4F7E5A0", VA = "0x184F7F5A0")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, NINNIJFNFLD PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F500", Offset = "0x4F7E500", VA = "0x184F7F500")]
	public static bool CJJJLAGEFIA(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F550", Offset = "0x4F7E550", VA = "0x184F7F550")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F550", Offset = "0x4F7E550", VA = "0x184F7F550")]
	public static bool HNHKEOFMCPG(NINNIJFNFLD AIAIDPGGDMM, byte PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F5C0", Offset = "0x4F7E5C0", VA = "0x184F7F5C0")]
	public static bool JGGBLBMCIBK(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F660", Offset = "0x4F7E660", VA = "0x184F7F660")]
	public static bool LHGNIHDBGAI(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F6F0", Offset = "0x4F7E6F0", VA = "0x184F7F6F0")]
	public static bool MIELMPPJAGE(NINNIJFNFLD AIAIDPGGDMM, char PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F760", Offset = "0x4F7E760", VA = "0x184F7F760")]
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
	[Cpp2IlInjected.Address(RVA = "0x4282C30", Offset = "0x4281C30", VA = "0x184282C30")]
	private static byte[] OJPOPNBOHID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x42829A0", Offset = "0x42819A0", VA = "0x1842829A0")]
	private static byte[] LJHGCDKIJLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x4281410", Offset = "0x4280410", VA = "0x184281410")]
	public static double CIDIKAMMPKI(byte[] CLABEIKAHOI, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4282D20", Offset = "0x4281D20", VA = "0x184282D20")]
	public static float OOPLEAAMOGO(byte[] CLABEIKAHOI, int LBACAALGKLG, out int PDAGJDHFPPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x4282A90", Offset = "0x4281A90", VA = "0x184282A90")]
	private static bool NEHJKMMMHMI(int KNMKEOOODCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x4282DE0", Offset = "0x4281DE0", VA = "0x184282DE0")]
	private static bool PFHCHJONCGI(ref NINNIJFNFLD MGGGHPDHPFB, NINNIJFNFLD CBNJCJLIEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4281510", Offset = "0x4280510", VA = "0x184281510")]
	private static bool HNFJAKPMCCN(ref NINNIJFNFLD MGGGHPDHPFB, NINNIJFNFLD CBNJCJLIEMJ, byte[] IFBJOHKDNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x42814C0", Offset = "0x42804C0", VA = "0x1842814C0")]
	private static bool FGJGBFPKIFD(ref NINNIJFNFLD KFEOAOMEMDH, byte[] JNFDLMOFJOO, int LBACAALGKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4282C10", Offset = "0x4281C10", VA = "0x184282C10")]
	private static double NIBONLNAFOI(bool FHFLCMPABME)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4281620", Offset = "0x4280620", VA = "0x184281620")]
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
	[Cpp2IlInjected.Address(RVA = "0x294F640", Offset = "0x294E640", VA = "0x18294F640")]
	public NKDCBHJFMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x21D1E20", Offset = "0x21D0E20", VA = "0x1821D1E20")]
	public NKDCBHJFMAC(NEHADIAKNBK CPICKMCHCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E3A0", Offset = "0x2E6D3A0", VA = "0x182E6E3A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EA10", Offset = "0x2E6DA10", VA = "0x182E6EA10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x294F640", Offset = "0x294E640", VA = "0x18294F640")]
	public MMJNKBLAMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x21D1E20", Offset = "0x21D0E20", VA = "0x1821D1E20")]
	public MMJNKBLAMPL(NEHADIAKNBK CPICKMCHCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x294DE70", Offset = "0x294CE70", VA = "0x18294DE70", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, List<T> IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x294F0A0", Offset = "0x294E0A0", VA = "0x18294F0A0", Slot = "5")]
	public List<T> HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class FAPDHICOOBP<TElement, TIntermediate, TEnumerator, TCollection> : global::JNNOLJAFELM<TCollection>, INIKLHPPANG where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2769820", Offset = "0x2768820", VA = "0x182769820", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TCollection IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x276A530", Offset = "0x2769530", VA = "0x18276A530", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
	protected FAPDHICOOBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class INMMIKOAELK<TElement, TIntermediate, TCollection> : global::FAPDHICOOBP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2454AB0", Offset = "0x2453AB0", VA = "0x182454AB0", Slot = "6")]
	protected override IEnumerator<TElement> PKBDEGDPEIJ(TCollection IKPEGPHMIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2454B00", Offset = "0x2453B00", VA = "0x182454B00")]
	protected INMMIKOAELK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class GICLBPKPKOJ<TElement, TCollection> : global::INMMIKOAELK<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected sealed override TCollection NBKICENBLEL(ref TCollection MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class NGCFCLLFAIG<TElement, TCollection> : global::GICLBPKPKOJ<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x276B2D0", Offset = "0x276A2D0", VA = "0x18276B2D0", Slot = "7")]
	protected override TCollection DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFB40", Offset = "0x2FBEB40", VA = "0x182FBFB40", Slot = "8")]
	protected override void HEFJCCLOLGO(ref TCollection FLHDOCMLBEH, int AIPHGHFENPJ, TElement IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class BJHBELBNLHA<T> : global::FAPDHICOOBP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x26CC080", Offset = "0x26CB080", VA = "0x1826CC080", Slot = "8")]
	protected override void HEFJCCLOLGO(ref LinkedList<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override LinkedList<T> NBKICENBLEL(ref LinkedList<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override LinkedList<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x26CC0C0", Offset = "0x26CB0C0", VA = "0x1826CC0C0", Slot = "6")]
	protected override LinkedList<T>.Enumerator PKBDEGDPEIJ(LinkedList<T> IKPEGPHMIII)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PDBNBLCPABN<T> : global::FAPDHICOOBP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x26CC080", Offset = "0x26CB080", VA = "0x1826CC080", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Queue<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override Queue<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F230", Offset = "0x2F5E230", VA = "0x182F5F230", Slot = "6")]
	protected override Queue<T>.Enumerator PKBDEGDPEIJ(Queue<T> IKPEGPHMIII)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override Queue<T> NBKICENBLEL(ref Queue<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class JKPPNIDGHBL<T> : global::FAPDHICOOBP<T, global::PFFGLIOAFFG<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x28444C0", Offset = "0x28434C0", VA = "0x1828444C0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2945480", Offset = "0x2944480", VA = "0x182945480", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F230", Offset = "0x2F5E230", VA = "0x182F5F230", Slot = "6")]
	protected override Stack<T>.Enumerator PKBDEGDPEIJ(Stack<T> IKPEGPHMIII)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F150", Offset = "0x2F5E150", VA = "0x182F5F150", Slot = "9")]
	protected override Stack<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class DBGJNMOMPBM<T> : global::FAPDHICOOBP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x26CC080", Offset = "0x26CB080", VA = "0x1826CC080", Slot = "8")]
	protected override void HEFJCCLOLGO(ref HashSet<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override HashSet<T> NBKICENBLEL(ref HashSet<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override HashSet<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F230", Offset = "0x2F5E230", VA = "0x182F5F230", Slot = "6")]
	protected override HashSet<T>.Enumerator PKBDEGDPEIJ(HashSet<T> IKPEGPHMIII)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class FLNAEEBJCMN<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x28444C0", Offset = "0x28434C0", VA = "0x1828444C0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x28444F0", Offset = "0x28434F0", VA = "0x1828444F0", Slot = "9")]
	protected override ReadOnlyCollection<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2844480", Offset = "0x2843480", VA = "0x182844480", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class PIHNMDPAGPH<T> : global::INMMIKOAELK<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x26CC080", Offset = "0x26CB080", VA = "0x1826CC080", Slot = "8")]
	protected override void HEFJCCLOLGO(ref List<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override List<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override IList<T> NBKICENBLEL(ref List<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class PPMCIAMAKEF<T> : global::INMMIKOAELK<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x26CC080", Offset = "0x26CB080", VA = "0x1826CC080", Slot = "8")]
	protected override void HEFJCCLOLGO(ref List<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override List<T> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override ICollection<T> NBKICENBLEL(ref List<T> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class MIPDBMINNMM<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x28444C0", Offset = "0x28434C0", VA = "0x1828444C0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2945480", Offset = "0x2944480", VA = "0x182945480", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x29454C0", Offset = "0x29444C0", VA = "0x1829454C0", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x26DE660", Offset = "0x26DD660", VA = "0x1826DE660", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x26DE920", Offset = "0x26DD920", VA = "0x1826DE920", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x428B380", Offset = "0x428A380", VA = "0x18428B380", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IEnumerable IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x428B570", Offset = "0x428A570", VA = "0x18428B570", Slot = "5")]
	public IEnumerable HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x42873D0", Offset = "0x42863D0", VA = "0x1842873D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ICollection IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x4287690", Offset = "0x4286690", VA = "0x184287690", Slot = "5")]
	public ICollection HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7E740", Offset = "0x4F7D740", VA = "0x184F7E740", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IList IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4F7EAB0", Offset = "0x4F7DAB0", VA = "0x184F7EAB0", Slot = "5")]
	public IList HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public MLMJMJDLKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KDHCNBFMNJO<T> : global::INMMIKOAELK<T, global::PFFGLIOAFFG<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2F17A00", Offset = "0x2F16A00", VA = "0x182F17A00", Slot = "8")]
	protected override void HEFJCCLOLGO(ref global::PFFGLIOAFFG<T> FLHDOCMLBEH, int AIPHGHFENPJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2945480", Offset = "0x2944480", VA = "0x182945480", Slot = "7")]
	protected override global::PFFGLIOAFFG<T> DAKLFHBAJIH()
	{
		return default(global::PFFGLIOAFFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2F17A30", Offset = "0x2F16A30", VA = "0x182F17A30", Slot = "9")]
	protected override IReadOnlyList<T> NBKICENBLEL(ref global::PFFGLIOAFFG<T> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x1C98470", Offset = "0x1C97470", VA = "0x181C98470")]
	public KDHCNBFMNJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class AHFAOLEGJPA
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x4283E80", Offset = "0x4282E80", VA = "0x184283E80")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F80E10", Offset = "0x4F7FE10", VA = "0x184F80E10", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, DateTime IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4F81AB0", Offset = "0x4F80AB0", VA = "0x184F81AB0", Slot = "5")]
	public DateTime HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x42840B0", Offset = "0x42830B0", VA = "0x1842840B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, DateTimeOffset IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4284490", Offset = "0x4283490", VA = "0x184284490", Slot = "5")]
	public DateTimeOffset HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F70D90", Offset = "0x4F6FD90", VA = "0x184F70D90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TimeSpan IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4F71240", Offset = "0x4F70240", VA = "0x184F71240", Slot = "5")]
	public TimeSpan HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public GFFIHBDONOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class BKBMJHPOIAP<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::JNNOLJAFELM<TDictionary>, INIKLHPPANG where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x26D08F0", Offset = "0x26CF8F0", VA = "0x1826D08F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, TDictionary IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x26D1E40", Offset = "0x26D0E40", VA = "0x1826D1E40", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
	protected BKBMJHPOIAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class MPHILAFAGJN<TKey, TValue, TIntermediate, TDictionary> : global::BKBMJHPOIAP<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2454AB0", Offset = "0x2453AB0", VA = "0x182454AB0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> PKBDEGDPEIJ(TDictionary IKPEGPHMIII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class LKHIFENEGPH<TKey, TValue, TDictionary> : global::MPHILAFAGJN<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override TDictionary NBKICENBLEL(ref TDictionary MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class PNLOKENDAFC<TKey, TValue> : global::BKBMJHPOIAP<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x37C38B0", Offset = "0x37C28B0", VA = "0x1837C38B0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Dictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override Dictionary<TKey, TValue> NBKICENBLEL(ref Dictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override Dictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x37C38F0", Offset = "0x37C28F0", VA = "0x1837C38F0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator PKBDEGDPEIJ(Dictionary<TKey, TValue> IKPEGPHMIII)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x107FE00", Offset = "0x107EE00", VA = "0x18107FE00")]
	public PNLOKENDAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LDMBIACGPCA<TKey, TValue, TDictionary> : global::LKHIFENEGPH<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3C40", Offset = "0x2FF2C40", VA = "0x182FF3C40", Slot = "8")]
	protected override void HEFJCCLOLGO(ref TDictionary FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x21D60E0", Offset = "0x21D50E0", VA = "0x1821D60E0", Slot = "7")]
	protected override TDictionary DAKLFHBAJIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class FONMAJJEAKJ<TKey, TValue> : global::MPHILAFAGJN<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x293EBE0", Offset = "0x293DBE0", VA = "0x18293EBE0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref Dictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override Dictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override IDictionary<TKey, TValue> NBKICENBLEL(ref Dictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class MHPLNBNNPCH<TKey, TValue> : global::LKHIFENEGPH<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x293EBE0", Offset = "0x293DBE0", VA = "0x18293EBE0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref SortedList<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override SortedList<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class DBJBDNLCFFM<TKey, TValue> : global::BKBMJHPOIAP<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x293EBE0", Offset = "0x293DBE0", VA = "0x18293EBE0", Slot = "8")]
	protected override void HEFJCCLOLGO(ref SortedDictionary<TKey, TValue> FLHDOCMLBEH, int AIPHGHFENPJ, TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x10F5070", Offset = "0x10F4070", VA = "0x1810F5070", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NBKICENBLEL(ref SortedDictionary<TKey, TValue> MMMBPDPBONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x26CC020", Offset = "0x26CB020", VA = "0x1826CC020", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> DAKLFHBAJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x337CD20", Offset = "0x337BD20", VA = "0x18337CD20", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator PKBDEGDPEIJ(SortedDictionary<TKey, TValue> IKPEGPHMIII)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NNHEBMEDJPP<T> : global::JNNOLJAFELM<T>, INIKLHPPANG where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2E776E0", Offset = "0x2E766E0", VA = "0x182E776E0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2E77A90", Offset = "0x2E76A90", VA = "0x182E77A90", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x428A6C0", Offset = "0x42896C0", VA = "0x18428A6C0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, IDictionary IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x428AA70", Offset = "0x4289A70", VA = "0x18428AA70", Slot = "5")]
	public IDictionary HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F80D70", Offset = "0x4F7FD70", VA = "0x184F80D70")]
	public OADKHBBMIBJ(params LOKDBPMCGHA[] BHDPJLDLLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FF90", Offset = "0x4F7EF90", VA = "0x184F7FF90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4F80CD0", Offset = "0x4F7FCD0", VA = "0x184F80CD0", Slot = "5")]
	public object HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class DHMEDDBBKOC
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x428EF00", Offset = "0x428DF00", VA = "0x18428EF00")]
	public static object EPBJHGHLNPD(Type NKICFHCCMMH, out bool OBFKAKNHGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x428E5E0", Offset = "0x428D5E0", VA = "0x18428E5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public NEJGELLMPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE120", Offset = "0x2FBD120", VA = "0x182FBE120")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public LLCJHLMFDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x306F8E0", Offset = "0x306E8E0", VA = "0x18306F8E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public OGPEOGCMCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x315D850", Offset = "0x315C850", VA = "0x18315D850")]
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
	[Cpp2IlInjected.Address(RVA = "0x28528D0", Offset = "0x28518D0", VA = "0x1828528D0")]
	static FOKEMEJJPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x28594E0", Offset = "0x28584E0", VA = "0x1828594E0")]
	public FOKEMEJJPEK(bool NLMEIKOHBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x284DF90", Offset = "0x284CF90", VA = "0x18284DF90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x284EB60", Offset = "0x284DB60", VA = "0x18284EB60", Slot = "5")]
	public T HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x284D160", Offset = "0x284C160", VA = "0x18284D160", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, T IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x28501F0", Offset = "0x284F1F0", VA = "0x1828501F0", Slot = "7")]
	public T MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class BLLADHHJOOG<T> : global::JNNOLJAFELM<T[,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x26D9170", Offset = "0x26D8170", VA = "0x1826D9170", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x26D9320", Offset = "0x26D8320", VA = "0x1826D9320", Slot = "5")]
	public T[,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
	public BLLADHHJOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class AGPOBCKCLDF<T> : global::JNNOLJAFELM<T[,,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2598C50", Offset = "0x2597C50", VA = "0x182598C50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2598E60", Offset = "0x2597E60", VA = "0x182598E60", Slot = "5")]
	public T[,,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
	public AGPOBCKCLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LMCLGPMBMBI<T> : global::JNNOLJAFELM<T[,,,]>, INIKLHPPANG
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x3070F80", Offset = "0x306FF80", VA = "0x183070F80", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T[,,,] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3071220", Offset = "0x3070220", VA = "0x183071220", Slot = "5")]
	public T[,,,] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
	public LMCLGPMBMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class PLFDCJPPELA<T> : global::JNNOLJAFELM<T?>, INIKLHPPANG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x3347E30", Offset = "0x3346E30", VA = "0x183347E30", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3348240", Offset = "0x3347240", VA = "0x183348240", Slot = "5")]
	public T? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x19845E0", Offset = "0x19835E0", VA = "0x1819845E0")]
	public HOPJKNANKFP(global::JNNOLJAFELM<T> ONFFLAMPLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9F00", Offset = "0x2EF8F00", VA = "0x182EF9F00")]
	public HOPJKNANKFP(Type HDCINCHPFJA, object[] ONLKLCKDLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9240", Offset = "0x2EF8240", VA = "0x182EF9240", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, T? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9DA0", Offset = "0x2EF8DA0", VA = "0x182EF9DA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7A8A0", Offset = "0x4F798A0", VA = "0x184F7A8A0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A8E0", Offset = "0x4F798E0", VA = "0x184F7A8E0", Slot = "5")]
	public sbyte HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A7E0", Offset = "0x4F797E0", VA = "0x184F7A7E0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A930", Offset = "0x4F79930", VA = "0x184F7A930", Slot = "7")]
	public sbyte MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F82B80", Offset = "0x4F81B80", VA = "0x184F82B80", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F82C10", Offset = "0x4F81C10", VA = "0x184F82C10", Slot = "5")]
	public sbyte? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F82A70", Offset = "0x4F81A70", VA = "0x184F82A70", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F82CC0", Offset = "0x4F81CC0", VA = "0x184F82CC0", Slot = "7")]
	public sbyte? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7AD50", Offset = "0x4F79D50", VA = "0x184F7AD50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, sbyte[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F7AEF0", Offset = "0x4F79EF0", VA = "0x184F7AEF0", Slot = "5")]
	public sbyte[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F6FC10", Offset = "0x4F6EC10", VA = "0x184F6FC10", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FC50", Offset = "0x4F6EC50", VA = "0x184F6FC50", Slot = "5")]
	public short HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FB50", Offset = "0x4F6EB50", VA = "0x184F6FB50", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, short IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FCB0", Offset = "0x4F6ECB0", VA = "0x184F6FCB0", Slot = "7")]
	public short MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4290180", Offset = "0x428F180", VA = "0x184290180", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4290200", Offset = "0x428F200", VA = "0x184290200", Slot = "5")]
	public short? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4290100", Offset = "0x428F100", VA = "0x184290100", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, short? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4290270", Offset = "0x428F270", VA = "0x184290270", Slot = "7")]
	public short? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5147A00", Offset = "0x5146A00", VA = "0x185147A00", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, short[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5147AC0", Offset = "0x5146AC0", VA = "0x185147AC0", Slot = "5")]
	public short[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7F300", Offset = "0x4F7E300", VA = "0x184F7F300", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F330", Offset = "0x4F7E330", VA = "0x184F7F330", Slot = "5")]
	public int HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F240", Offset = "0x4F7E240", VA = "0x184F7F240", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, int IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F390", Offset = "0x4F7E390", VA = "0x184F7F390", Slot = "7")]
	public int MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7E3D0", Offset = "0x4F7D3D0", VA = "0x184F7E3D0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E460", Offset = "0x4F7D460", VA = "0x184F7E460", Slot = "5")]
	public int? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E2C0", Offset = "0x4F7D2C0", VA = "0x184F7E2C0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, int? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F7E510", Offset = "0x4F7D510", VA = "0x184F7E510", Slot = "7")]
	public int? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F71E80", Offset = "0x4F70E80", VA = "0x184F71E80", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, int[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F72020", Offset = "0x4F71020", VA = "0x184F72020", Slot = "5")]
	public int[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5147DF0", Offset = "0x5146DF0", VA = "0x185147DF0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5147E10", Offset = "0x5146E10", VA = "0x185147E10", Slot = "5")]
	public long HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5147DB0", Offset = "0x5146DB0", VA = "0x185147DB0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, long IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5147E20", Offset = "0x5146E20", VA = "0x185147E20", Slot = "7")]
	public long MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5149DB0", Offset = "0x5148DB0", VA = "0x185149DB0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5149E30", Offset = "0x5148E30", VA = "0x185149E30", Slot = "5")]
	public long? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5149D20", Offset = "0x5148D20", VA = "0x185149D20", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, long? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5149EC0", Offset = "0x5148EC0", VA = "0x185149EC0", Slot = "7")]
	public long? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x429A490", Offset = "0x4299490", VA = "0x18429A490", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, long[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x429A550", Offset = "0x4299550", VA = "0x18429A550", Slot = "5")]
	public long[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7EE60", Offset = "0x4F7DE60", VA = "0x184F7EE60", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x4F7EEA0", Offset = "0x4F7DEA0", VA = "0x184F7EEA0", Slot = "5")]
	public byte HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4F7EDA0", Offset = "0x4F7DDA0", VA = "0x184F7EDA0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, byte IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4F7EF00", Offset = "0x4F7DF00", VA = "0x184F7EF00", Slot = "7")]
	public byte MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7F8C0", Offset = "0x4F7E8C0", VA = "0x184F7F8C0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F950", Offset = "0x4F7E950", VA = "0x184F7F950", Slot = "5")]
	public byte? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F7B0", Offset = "0x4F7E7B0", VA = "0x184F7F7B0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, byte? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FA00", Offset = "0x4F7EA00", VA = "0x184F7FA00", Slot = "7")]
	public byte? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7D840", Offset = "0x4F7C840", VA = "0x184F7D840", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D880", Offset = "0x4F7C880", VA = "0x184F7D880", Slot = "5")]
	public ushort HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D780", Offset = "0x4F7C780", VA = "0x184F7D780", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ushort IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D8E0", Offset = "0x4F7C8E0", VA = "0x184F7D8E0", Slot = "7")]
	public ushort MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4288980", Offset = "0x4287980", VA = "0x184288980", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4288A00", Offset = "0x4287A00", VA = "0x184288A00", Slot = "5")]
	public ushort? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4288900", Offset = "0x4287900", VA = "0x184288900", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ushort? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4288A70", Offset = "0x4287A70", VA = "0x184288A70", Slot = "7")]
	public ushort? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x428E380", Offset = "0x428D380", VA = "0x18428E380", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ushort[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x428E440", Offset = "0x428D440", VA = "0x18428E440", Slot = "5")]
	public ushort[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4288BD0", Offset = "0x4287BD0", VA = "0x184288BD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4288BE0", Offset = "0x4287BE0", VA = "0x184288BE0", Slot = "5")]
	public uint HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4288B90", Offset = "0x4287B90", VA = "0x184288B90", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, uint IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4288BF0", Offset = "0x4287BF0", VA = "0x184288BF0", Slot = "7")]
	public uint MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F74070", Offset = "0x4F73070", VA = "0x184F74070", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4F74100", Offset = "0x4F73100", VA = "0x184F74100", Slot = "5")]
	public uint? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4F73F60", Offset = "0x4F72F60", VA = "0x184F73F60", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, uint? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4F741B0", Offset = "0x4F731B0", VA = "0x184F741B0", Slot = "7")]
	public uint? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x428B780", Offset = "0x428A780", VA = "0x18428B780", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, uint[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x428B840", Offset = "0x428A840", VA = "0x18428B840", Slot = "5")]
	public uint[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7AC30", Offset = "0x4F79C30", VA = "0x184F7AC30", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x4F7AC60", Offset = "0x4F79C60", VA = "0x184F7AC60", Slot = "5")]
	public ulong HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7AB70", Offset = "0x4F79B70", VA = "0x184F7AB70", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ulong IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7AC70", Offset = "0x4F79C70", VA = "0x184F7AC70", Slot = "7")]
	public ulong MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4291A20", Offset = "0x4290A20", VA = "0x184291A20", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x4291AA0", Offset = "0x4290AA0", VA = "0x184291AA0", Slot = "5")]
	public ulong? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x4291990", Offset = "0x4290990", VA = "0x184291990", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, ulong? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4291B30", Offset = "0x4290B30", VA = "0x184291B30", Slot = "7")]
	public ulong? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F85E30", Offset = "0x4F84E30", VA = "0x184F85E30", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ulong[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4F85FD0", Offset = "0x4F84FD0", VA = "0x184F85FD0", Slot = "5")]
	public ulong[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x428A0F0", Offset = "0x42890F0", VA = "0x18428A0F0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x428A100", Offset = "0x4289100", VA = "0x18428A100", Slot = "5")]
	public float HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x428A0B0", Offset = "0x42890B0", VA = "0x18428A0B0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, float IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x428A110", Offset = "0x4289110", VA = "0x18428A110", Slot = "7")]
	public float MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7B870", Offset = "0x4F7A870", VA = "0x184F7B870", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B8F0", Offset = "0x4F7A8F0", VA = "0x184F7B8F0", Slot = "5")]
	public float? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B770", Offset = "0x4F7A770", VA = "0x184F7B770", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, float? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B960", Offset = "0x4F7A960", VA = "0x184F7B960", Slot = "7")]
	public float? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4289E50", Offset = "0x4288E50", VA = "0x184289E50", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, float[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4289F10", Offset = "0x4288F10", VA = "0x184289F10", Slot = "5")]
	public float[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7DA70", Offset = "0x4F7CA70", VA = "0x184F7DA70", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x4F7DA80", Offset = "0x4F7CA80", VA = "0x184F7DA80", Slot = "5")]
	public double HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D9C0", Offset = "0x4F7C9C0", VA = "0x184F7D9C0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, double IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7DA90", Offset = "0x4F7CA90", VA = "0x184F7DA90", Slot = "7")]
	public double MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x51455C0", Offset = "0x51445C0", VA = "0x1851455C0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5145640", Offset = "0x5144640", VA = "0x185145640", Slot = "5")]
	public double? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5145530", Offset = "0x5144530", VA = "0x185145530", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, double? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x51456D0", Offset = "0x51446D0", VA = "0x1851456D0", Slot = "7")]
	public double? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F76900", Offset = "0x4F75900", VA = "0x184F76900", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, double[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4F76AE0", Offset = "0x4F75AE0", VA = "0x184F76AE0", Slot = "5")]
	public double[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7B660", Offset = "0x4F7A660", VA = "0x184F7B660", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B680", Offset = "0x4F7A680", VA = "0x184F7B680", Slot = "5")]
	public bool HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B5B0", Offset = "0x4F7A5B0", VA = "0x184F7B5B0", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, bool IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B690", Offset = "0x4F7A690", VA = "0x184F7B690", Slot = "7")]
	public bool MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x428FEF0", Offset = "0x428EEF0", VA = "0x18428FEF0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x428FF70", Offset = "0x428EF70", VA = "0x18428FF70", Slot = "5")]
	public bool? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x428FE70", Offset = "0x428EE70", VA = "0x18428FE70", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, bool? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x428FFE0", Offset = "0x428EFE0", VA = "0x18428FFE0", Slot = "7")]
	public bool? MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F6FD90", Offset = "0x4F6ED90", VA = "0x184F6FD90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, bool[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FF10", Offset = "0x4F6EF10", VA = "0x184F6FF10", Slot = "5")]
	public bool[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F72BC0", Offset = "0x4F71BC0", VA = "0x184F72BC0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, object IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4F73690", Offset = "0x4F72690", VA = "0x184F73690", Slot = "5")]
	public object HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7DCD0", Offset = "0x4F7CCD0", VA = "0x184F7DCD0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, byte[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4F7DD60", Offset = "0x4F7CD60", VA = "0x184F7DD60", Slot = "5")]
	public byte[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F6D810", Offset = "0x4F6C810", VA = "0x184F6D810", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, ArraySegment<byte> IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D8D0", Offset = "0x4F6C8D0", VA = "0x184F6D8D0", Slot = "5")]
	public ArraySegment<byte> HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7BA80", Offset = "0x4F7AA80", VA = "0x184F7BA80", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, string IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BAA0", Offset = "0x4F7AAA0", VA = "0x184F7BAA0", Slot = "5")]
	public string HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BA80", Offset = "0x4F7AA80", VA = "0x184F7BA80", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, string IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BAA0", Offset = "0x4F7AAA0", VA = "0x184F7BAA0", Slot = "7")]
	public string MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F82FB0", Offset = "0x4F81FB0", VA = "0x184F82FB0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, string[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4F83120", Offset = "0x4F82120", VA = "0x184F83120", Slot = "5")]
	public string[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7D600", Offset = "0x4F7C600", VA = "0x184F7D600", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D680", Offset = "0x4F7C680", VA = "0x184F7D680", Slot = "5")]
	public char HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F79E90", Offset = "0x4F78E90", VA = "0x184F79E90", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char? IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4F79F80", Offset = "0x4F78F80", VA = "0x184F79F80", Slot = "5")]
	public char? HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F76470", Offset = "0x4F75470", VA = "0x184F76470", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, char[] IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4F766B0", Offset = "0x4F756B0", VA = "0x184F766B0", Slot = "5")]
	public char[] HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x428E110", Offset = "0x428D110", VA = "0x18428E110", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Guid IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x428E1E0", Offset = "0x428D1E0", VA = "0x18428E1E0", Slot = "5")]
	public Guid HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x428E040", Offset = "0x428D040", VA = "0x18428E040", Slot = "6")]
	public void AMIMOGLILMC(ref KOGPHPAEDLF MLMFBHHJDGG, Guid IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x428E1E0", Offset = "0x428D1E0", VA = "0x18428E1E0", Slot = "7")]
	public Guid MBFCOMICCPN(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x8D6400", Offset = "0x8D5400", VA = "0x1808D6400")]
	public EKEGCAPCFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x13D1810", Offset = "0x13D0810", VA = "0x1813D1810")]
	public EKEGCAPCFCA(bool IBJNOEDEBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x4291480", Offset = "0x4290480", VA = "0x184291480", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, decimal IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x42915D0", Offset = "0x42905D0", VA = "0x1842915D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4290590", Offset = "0x428F590", VA = "0x184290590", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Uri IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4290640", Offset = "0x428F640", VA = "0x184290640", Slot = "5")]
	public Uri HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4283F20", Offset = "0x4282F20", VA = "0x184283F20", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Version IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4283FD0", Offset = "0x4282FD0", VA = "0x184283FD0", Slot = "5")]
	public Version HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x428DF10", Offset = "0x428CF10", VA = "0x18428DF10", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, StringBuilder IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x428DF60", Offset = "0x428CF60", VA = "0x18428DF60", Slot = "5")]
	public StringBuilder HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F7A0B0", Offset = "0x4F790B0", VA = "0x184F7A0B0", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, BitArray IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A1B0", Offset = "0x4F791B0", VA = "0x184F7A1B0", Slot = "5")]
	public BitArray HJFKJCGGCHL(ref JBBAGFKBPCP ANKKMEDLEHC, LOKDBPMCGHA FLFIDBHDKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x42896A0", Offset = "0x42886A0", VA = "0x1842896A0")]
	public BGOLDOIGOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x4289650", Offset = "0x4288650", VA = "0x184289650")]
	public BGOLDOIGOAD(bool IOMMIHKILIP, bool PAMAECJHBBM, bool KOCNBEFBMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x4289370", Offset = "0x4288370", VA = "0x184289370", Slot = "4")]
	public void DGAMFOBEJMM(ref KOGPHPAEDLF MLMFBHHJDGG, Type IGJPNMBCJPK, LOKDBPMCGHA FLFIDBHDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x4289460", Offset = "0x4288460", VA = "0x184289460", Slot = "5")]
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
