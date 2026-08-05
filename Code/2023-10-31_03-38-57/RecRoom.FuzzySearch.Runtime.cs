using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LIMMNGLLNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DFMNCKLIBLH JGOBHHHIFJO;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class DFMNCKLIBLH
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate int BJOENBCLJBH(IReadOnlyList<char> KLFHEFAPNHM, int MNHJKNJCEJI, string JNFEEJFJDPO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FMOPOAPBKPP JHHMIMMJNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BJOENBCLJBH AIINBIBKCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly char[] FGGJLJAJMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly OIJBDAPBDLL[] HDIIMCLFKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly bool[] ABGBNAIEPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] OAGGCILJIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly OIJBDAPBDLL[] PDJMIEPGBFB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0")]
	public static int LGFIMPMNMKB(IReadOnlyList<char> KLFHEFAPNHM, int MNHJKNJCEJI, string JNFEEJFJDPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C85DB0", Offset = "0x5C851B0", VA = "0x185C85DB0")]
	public DFMNCKLIBLH(IReadOnlyCollection<string> DMPMNANABEP, [In] FMOPOAPBKPP LFFIOALMHGC, [Optional] BJOENBCLJBH OLIAGKEPENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C85D10", Offset = "0x5C85110", VA = "0x185C85D10")]
	public string BNDICJJAHPE(string MGDJBMEDKLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5C85DA0", Offset = "0x5C851A0", VA = "0x185C85DA0")]
	public int HCBFNDAGNHG(int MPJMHCDEKLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C85710", Offset = "0x5C84B10", VA = "0x185C85710")]
	public int AKOOAEHJHDE(string MGDJBMEDKLM, int HAANLPLIHLG, int AJKCFFMDNAH, int MNHJKNJCEJI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct FMOPOAPBKPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool JDHOCBJPKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool CAEBLMCMGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int MMIFLBLHJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly int OONKDNHKMAB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly FMOPOAPBKPP GALHKOFLFEN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FMOPOAPBKPP BDJLOIHNJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C868C0", Offset = "0x5C85CC0", VA = "0x185C868C0")]
		get
		{
			return default(FMOPOAPBKPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C86970", Offset = "0x5C85D70", VA = "0x185C86970")]
	public FMOPOAPBKPP(bool CBCBLOGMJKK, bool JCPOKGENMOM, int BCODNNAOCKN, int NNEMAODGKHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct OIJBDAPBDLL : IEquatable<OIJBDAPBDLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int CBNNNKAIBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int AKOOAEHJHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int KIBNJALIFEA;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x17683C0", Offset = "0x17677C0", VA = "0x1817683C0")]
	public OIJBDAPBDLL(int APOENOPNHBG, int OBAEDODACPF, int NIBFMOKEPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C87400", Offset = "0x5C86800", VA = "0x185C87400")]
	public static int BPGFFNLKMEK([In] OIJBDAPBDLL IBOMHLKOLJB, [In] OIJBDAPBDLL FFDHLLBEMJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1B76E20", Offset = "0x1B76220", VA = "0x181B76E20", Slot = "4")]
	public bool Equals(OIJBDAPBDLL LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C87420", Offset = "0x5C86820", VA = "0x185C87420", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C874D0", Offset = "0x5C868D0", VA = "0x185C874D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IIEJPBCODHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DFMNCKLIBLH JGOBHHHIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private string HGIFFHHIOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int BLOKGFIICJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int NAOBKFFKGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int AEPBEEALGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int OEBBIJFJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Func<bool> LNFFENDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private PIIOFBJELDI.COBGCKBHHDC<OIJBDAPBDLL> EODFELFMCAK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<OIJBDAPBDLL> NEEODLOGMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E73D90", Offset = "0x4E73190", VA = "0x184E73D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> OPHNBAKGNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x871900", Offset = "0x870D00", VA = "0x180871900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C86D00", Offset = "0x5C86100", VA = "0x185C86D00")]
	public IIEJPBCODHF(IReadOnlyCollection<string> DMPMNANABEP, [In] FMOPOAPBKPP LFFIOALMHGC, [Optional] DFMNCKLIBLH.BJOENBCLJBH OLIAGKEPENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C86B60", Offset = "0x5C85F60", VA = "0x185C86B60")]
	public bool OGGHIOKPODN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C86990", Offset = "0x5C85D90", VA = "0x185C86990")]
	public void EKDMCALIDFA(string MGDJBMEDKLM, int DMDIHCNAMIP, Func<bool> OMFFLLECFLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KFMBMGEJHKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void ENELHBEBNBA(IReadOnlyList<OIJBDAPBDLL> EKAOINOBOKL, IReadOnlyList<bool> MGBOLPJEFBK);

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int ANHKBAJCKHP = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const double COKBLJOHDNL = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IIEJPBCODHF DKGMAPEOFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly ENELHBEBNBA BGBBFMNMICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MonoBehaviour AFOEKLOPIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int OEBBIJFJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly double MBMODGGJGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Stopwatch BGFFPPJHDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IDisposable AAEOOAMNDHE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<OIJBDAPBDLL> NEEODLOGMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5C870D0", Offset = "0x5C864D0", VA = "0x185C870D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> OPHNBAKGNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C870A0", Offset = "0x5C864A0", VA = "0x185C870A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KMJBMANEOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xE23A70", Offset = "0xE22E70", VA = "0x180E23A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double NEEBAKBIPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5C87010", Offset = "0x5C86410", VA = "0x185C87010")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C87280", Offset = "0x5C86680", VA = "0x185C87280")]
	public KFMBMGEJHKD(IReadOnlyCollection<string> DMPMNANABEP, [In] FMOPOAPBKPP LFFIOALMHGC, ENELHBEBNBA CFHIBFLEFEO, MonoBehaviour FJHKACIMEOO, [Optional] DFMNCKLIBLH.BJOENBCLJBH OLIAGKEPENI, int DMDIHCNAMIP = 100, double GBHLGJGCGIK = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C86E00", Offset = "0x5C86200", VA = "0x185C86E00")]
	public void EBJCHNJJCME(string MGDJBMEDKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C87100", Offset = "0x5C86500", VA = "0x185C87100")]
	private bool NCHGGAOEHHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C871A0", Offset = "0x5C865A0", VA = "0x185C871A0")]
	private void OGGHIOKPODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C86DB0", Offset = "0x5C861B0", VA = "0x185C86DB0", Slot = "4")]
	public void Dispose()
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
