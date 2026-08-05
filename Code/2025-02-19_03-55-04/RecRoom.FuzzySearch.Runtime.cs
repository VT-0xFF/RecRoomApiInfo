using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class NHBONBMGHID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HOPIJICNGBI GMAMOGJFOPF;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class HOPIJICNGBI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate int PLDNEHGLINO(IReadOnlyList<char> PNCGIPGDBDB, int EGAHFKEDDOK, string NELBAACLBDO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FDDLBEFBOEH KGMIPNAHBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PLDNEHGLINO FPBKEEOIKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly char[] DEBNEINNLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NFHMMHPNMCK[] CMBADIJPMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly bool[] OOIHGPFEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] CFFEIPJCJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly NFHMMHPNMCK[] DAPOJMADBCO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0")]
	public static int PGALPMAJMOK(IReadOnlyList<char> PNCGIPGDBDB, int EGAHFKEDDOK, string NELBAACLBDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74D5D20", Offset = "0x74D4920", VA = "0x1874D5D20")]
	public HOPIJICNGBI(IReadOnlyCollection<string> GNOLPDEIPAL, [In] FDDLBEFBOEH DGEAKNFBBOD, [Optional] PLDNEHGLINO IGBLFLBMCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74D5C90", Offset = "0x74D4890", VA = "0x1874D5C90")]
	public string MOOGCNOBFFP(string EODLBGMMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74D5680", Offset = "0x74D4280", VA = "0x1874D5680")]
	public int ADFCAJHLIBF(int IIPPKEBJFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74D5690", Offset = "0x74D4290", VA = "0x1874D5690")]
	public int ECABGGFEIJC(string EODLBGMMAKH, int FHJEJDGDFCG, int LMKJHBKDFPO, int EGAHFKEDDOK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct FDDLBEFBOEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool HKOCPCCKPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool NGFNEAIEDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int MDMKMKFEMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly int FDKHIFAJDGE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly FDDLBEFBOEH GCAFFJGIEBJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FDDLBEFBOEH EPMIHDCFDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74D55B0", Offset = "0x74D41B0", VA = "0x1874D55B0")]
		get
		{
			return default(FDDLBEFBOEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74D5660", Offset = "0x74D4260", VA = "0x1874D5660")]
	public FDDLBEFBOEH(bool OCJLNJKNMKF, bool LOANABIIFOC, int FNBAKCBJOPN, int BMCGFNHNHHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NFHMMHPNMCK : IEquatable<NFHMMHPNMCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int AHDPANGFLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int ECABGGFEIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int CJAEHLPICDB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xBB9010", Offset = "0xBB7C10", VA = "0x180BB9010")]
	public NFHMMHPNMCK(int BIEEMEKMINN, int DCILDCAPKIJ, int JIPCLHLNJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74D6C30", Offset = "0x74D5830", VA = "0x1874D6C30")]
	public static int COHNDPNICIG([In] NFHMMHPNMCK IFMENDFGFGN, [In] NFHMMHPNMCK DPEOCFNLADP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x241DC30", Offset = "0x241C830", VA = "0x18241DC30", Slot = "4")]
	public bool Equals(NFHMMHPNMCK PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74D6C50", Offset = "0x74D5850", VA = "0x1874D6C50", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74D6D00", Offset = "0x74D5900", VA = "0x1874D6D00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JDIEKIDOPKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HOPIJICNGBI GMAMOGJFOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private string OMGDAHJMIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int LDCEFGPOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int IFJCDDJMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int BHOIHPNJINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int BMIBDGMEDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Func<bool> EKOBHADOFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private HHPEEAENMHF.ONKJKIGIIAM<NFHMMHPNMCK> DPKADPFBIKP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<NFHMMHPNMCK> ODOCFKFIDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x18DE730", Offset = "0x18DD330", VA = "0x1818DE730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> CFDHEPLJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6639B40", Offset = "0x6638740", VA = "0x186639B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74D6B80", Offset = "0x74D5780", VA = "0x1874D6B80")]
	public JDIEKIDOPKL(IReadOnlyCollection<string> GNOLPDEIPAL, [In] FDDLBEFBOEH DGEAKNFBBOD, [Optional] HOPIJICNGBI.PLDNEHGLINO IGBLFLBMCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74D69E0", Offset = "0x74D55E0", VA = "0x1874D69E0")]
	public bool PDMGFMOMPNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x74D6810", Offset = "0x74D5410", VA = "0x1874D6810")]
	public void MPGBAGKJFIA(string EODLBGMMAKH, int BIPAOKCJJGL, Func<bool> ANCEILKEKBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HFMJBENPINL<TSchedulerContext> : IDisposable where TSchedulerContext : MonoBehaviour, PMHAEKLGAHN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void HLBELOBHHBB(IReadOnlyList<NFHMMHPNMCK> NGCHBNELFOG, IReadOnlyList<bool> JNKLHKFKAIE);

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int EPHCDNNMHDG = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const double IECNGMAEBGJ = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly JDIEKIDOPKL AFJCIBNNHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HLBELOBHHBB PGMFGAPDGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly TSchedulerContext DDBCIGIHPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int BMIBDGMEDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly double EFAMDNLBEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Stopwatch MGKAHPFEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IDisposable HFBKNELAIAO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<NFHMMHPNMCK> ODOCFKFIDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x45AE4D0", Offset = "0x45AD0D0", VA = "0x1845AE4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> CFDHEPLJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x45AE4F0", Offset = "0x45AD0F0", VA = "0x1845AE4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LFOIIIBCPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x17FD390", Offset = "0x17FBF90", VA = "0x1817FD390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double HEHPNDGLGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x45AE650", Offset = "0x45AD250", VA = "0x1845AE650")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x45AE6E0", Offset = "0x45AD2E0", VA = "0x1845AE6E0")]
	public HFMJBENPINL(IReadOnlyCollection<string> GNOLPDEIPAL, [In] FDDLBEFBOEH DGEAKNFBBOD, HLBELOBHHBB ECLFFBNACGI, TSchedulerContext HJIAOGEIAJO, [Optional] HOPIJICNGBI.PLDNEHGLINO IGBLFLBMCHH, int BIPAOKCJJGL = 100, double BAICDJDIBJO = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x45AE2D0", Offset = "0x45ACED0", VA = "0x1845AE2D0")]
	public void DOFDBEHAHPP(string EODLBGMMAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x45AE280", Offset = "0x45ACE80", VA = "0x1845AE280")]
	private bool AKFCIECNHNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x45AE510", Offset = "0x45AD110", VA = "0x1845AE510")]
	private void PDMGFMOMPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x45AE480", Offset = "0x45AD080", VA = "0x1845AE480", Slot = "4")]
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
