using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[KPAMBFFNOBG]
public class AHGCHPECKLA : MDKMDNCMBAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FJDNLOJMGNI JAHJLINGCAO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68BCC00", Offset = "0x68BB800", VA = "0x1868BCC00")]
	[Preserve]
	public AHGCHPECKLA([GOICEJLKLIB(null)][NotNull] FJDNLOJMGNI JAHJLINGCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x31DA880", Offset = "0x31D9480", VA = "0x1831DA880", Slot = "4")]
	public bool POCEDOMDDJG<TExperiment>([Out] TExperiment GPOBDBFMCIA) where TExperiment : OBJMDADKKDL, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x31DA950", Offset = "0x31D9550", VA = "0x1831DA950", Slot = "5")]
	public bool POCEDOMDDJG<TExperiment>(string BMEBIGNEDAP, [Out] TExperiment GPOBDBFMCIA) where TExperiment : OBJMDADKKDL, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OBJMDADKKDL
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FJDNLOJMGNI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POCEDOMDDJG<TExperiment>([Out] TExperiment GPOBDBFMCIA) where TExperiment : OBJMDADKKDL, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POCEDOMDDJG<TExperiment>(string BMEBIGNEDAP, [Out] TExperiment GPOBDBFMCIA) where TExperiment : OBJMDADKKDL, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAGBEEPPPHA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MDKMDNCMBAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POCEDOMDDJG<TExperiment>([Out] TExperiment GPOBDBFMCIA) where TExperiment : OBJMDADKKDL, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POCEDOMDDJG<TExperiment>(string BMEBIGNEDAP, [Out] TExperiment GPOBDBFMCIA) where TExperiment : OBJMDADKKDL, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class HGIIBPALJHD : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct EHGMKIHDAEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo BDBOOOMGEPP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type PGBAPAHKMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68BCD00", Offset = "0x68BB900", VA = "0x1868BCD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68BD2F0", Offset = "0x68BBEF0", VA = "0x1868BD2F0")]
	public EHGMKIHDAEF(MemberInfo BDBOOOMGEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68BCDC0", Offset = "0x68BB9C0", VA = "0x1868BCDC0")]
	public object BIKHNENFGLC(object HAHECKLGOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68BD140", Offset = "0x68BBD40", VA = "0x1868BD140")]
	public void MFIFNAPDHPO(object HAHECKLGOJC, object GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68BCEE0", Offset = "0x68BBAE0", VA = "0x1868BCEE0")]
	private static bool CABGEEFPMMC(Type ANICKBFNADK, object GLMEMJNJKAN, [Out] object BLAOIDEJIBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JCDNAFNLDNK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AMBCAEDIAIF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string JBJAOBKIEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool FPNLJHOPCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly JCDNAFNLDNK AJCKJIKGPNK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68BCCA0", Offset = "0x68BB8A0", VA = "0x1868BCCA0")]
	public AMBCAEDIAIF([Optional] string GFLNGGKHEOH, JCDNAFNLDNK NCNNODEFPOG = JCDNAFNLDNK.Experiment, bool BGJKIJHLMHM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class MPFPFLDGPCF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string JBJAOBKIEOM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68BD400", Offset = "0x68BC000", VA = "0x1868BD400")]
	public MPFPFLDGPCF(string GFLNGGKHEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KPAMBFFNOBG]
public class NPAFHBOFHNC : FJDNLOJMGNI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GPCHKDHHLGA<TExperiment> where TExperiment : OBJMDADKKDL, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public APPGGIIHCCP statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public GPCHKDHHLGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3CE71B0", Offset = "0x3CE5DB0", VA = "0x183CE71B0")]
		internal bool KKEBJPLLKFA(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GKDHMMKGFLI MPAGJNLPKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, OBJMDADKKDL> EHDKFIHODFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, AMBCAEDIAIF> ODEGDBGAPGI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68BD490", Offset = "0x68BC090", VA = "0x1868BD490")]
	[Preserve]
	public NPAFHBOFHNC([NotNull][GOICEJLKLIB(null)] GKDHMMKGFLI MPAGJNLPKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC480", Offset = "0x2CBB080", VA = "0x182CBC480", Slot = "4")]
	public bool POCEDOMDDJG<TExperiment>([Out] TExperiment GPOBDBFMCIA) where TExperiment : OBJMDADKKDL, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC530", Offset = "0x2CBB130", VA = "0x182CBC530", Slot = "5")]
	public bool POCEDOMDDJG<TExperiment>(string BMEBIGNEDAP, [Out] TExperiment GPOBDBFMCIA) where TExperiment : OBJMDADKKDL, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68BD440", Offset = "0x68BC040", VA = "0x1868BD440", Slot = "6")]
	public void LAGBEEPPPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2CBBFF0", Offset = "0x2CBABF0", VA = "0x182CBBFF0")]
	private bool NFKKAMICCCJ<TExperiment>([Out] AMBCAEDIAIF JIHAMKODDLH) where TExperiment : OBJMDADKKDL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC0E0", Offset = "0x2CBACE0", VA = "0x182CBC0E0")]
	private static void PDEOOCFPKOM<TExperiment>(TExperiment GPOBDBFMCIA, CLMICMJGMJK IPJAAADFNKD, Predicate<string> EOGBHJMPIMG) where TExperiment : OBJMDADKKDL
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
