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
public interface HPMEOIFDBCL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OGEENDJIOBG<TExperiment>(out TExperiment NPKGHKAFOBO) where TExperiment : EMKAFBOMDKP, new();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGEENDJIOBG<TExperiment>(string IFGHBBPLIJN, out TExperiment NPKGHKAFOBO) where TExperiment : EMKAFBOMDKP, new();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LEAHIKDFLCE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OGEENDJIOBG<TExperiment>(out TExperiment NPKGHKAFOBO) where TExperiment : EMKAFBOMDKP, new();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGEENDJIOBG<TExperiment>(string IFGHBBPLIJN, out TExperiment NPKGHKAFOBO) where TExperiment : EMKAFBOMDKP, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJPINIHPDKA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EMKAFBOMDKP
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class NJLJKLDLIFJ : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal readonly struct KBNCMCIFDAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MemberInfo HEEAJNBHLNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type PAIACGFKOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1600", Offset = "0x6FEFC00", VA = "0x186FF1600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FF16D0", Offset = "0x6FEFCD0", VA = "0x186FF16D0")]
	public KBNCMCIFDAL(MemberInfo HEEAJNBHLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FF14E0", Offset = "0x6FEFAE0", VA = "0x186FF14E0")]
	public object KMEKHMMFBCC(object NKFOPKJGBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FF10D0", Offset = "0x6FEF6D0", VA = "0x186FF10D0")]
	public void ALGMGODHEFB(object NKFOPKJGBEM, object MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1270", Offset = "0x6FEF870", VA = "0x186FF1270")]
	private static bool DDFCENKAKFE(Type BPJFCKKOFHF, object MOLEJFDINLH, out object MHOPBKKAIKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ONEJPGBFBKC]
public class IAMDABKFJIL : HPMEOIFDBCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly LEAHIKDFLCE HINHIGGCLIA;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1040", Offset = "0x6FEF640", VA = "0x186FF1040")]
	[Preserve]
	public IAMDABKFJIL([NotNull][BBBJPGKHPHG(null)] LEAHIKDFLCE HINHIGGCLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x11D3240", Offset = "0x11D1840", VA = "0x1811D3240", Slot = "4")]
	public bool OGEENDJIOBG<TExperiment>(out TExperiment NPKGHKAFOBO) where TExperiment : EMKAFBOMDKP, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x11D3300", Offset = "0x11D1900", VA = "0x1811D3300", Slot = "5")]
	public bool OGEENDJIOBG<TExperiment>(string IFGHBBPLIJN, out TExperiment NPKGHKAFOBO) where TExperiment : EMKAFBOMDKP, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ONEJPGBFBKC]
public class LHCMONFGMLP : LEAHIKDFLCE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class CPGKEPJPAHG<TExperiment> where TExperiment : EMKAFBOMDKP, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public KMEIPPDNGNG statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public CPGKEPJPAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2C76CD0", Offset = "0x2C752D0", VA = "0x182C76CD0")]
		internal bool PCONEAEMGKJ(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NEOAJDCIMKB BBAIILANPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Dictionary<string, EMKAFBOMDKP> GLIICADOGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<Type, MAHEINOFGOG> IMKEOIKIHOP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1840", Offset = "0x6FEFE40", VA = "0x186FF1840")]
	[Preserve]
	public LHCMONFGMLP([NotNull][BBBJPGKHPHG(null)] NEOAJDCIMKB BBAIILANPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xF46B40", Offset = "0xF45140", VA = "0x180F46B40", Slot = "4")]
	public bool OGEENDJIOBG<TExperiment>(out TExperiment NPKGHKAFOBO) where TExperiment : EMKAFBOMDKP, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xF46560", Offset = "0xF44B60", VA = "0x180F46560", Slot = "5")]
	public bool OGEENDJIOBG<TExperiment>(string IFGHBBPLIJN, out TExperiment NPKGHKAFOBO) where TExperiment : EMKAFBOMDKP, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6FF17F0", Offset = "0x6FEFDF0", VA = "0x186FF17F0", Slot = "6")]
	public void IJPINIHPDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xF46010", Offset = "0xF44610", VA = "0x180F46010")]
	private bool CFEIKPNHMAJ<TExperiment>(out MAHEINOFGOG KEDKOLBEGAG) where TExperiment : EMKAFBOMDKP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xF46110", Offset = "0xF44710", VA = "0x180F46110")]
	private static void EPJOAKOGILA<TExperiment>(TExperiment NPKGHKAFOBO, Func<string, object, object> COPLBKJOEMD, Predicate<string> GLNHDAEODJG) where TExperiment : EMKAFBOMDKP
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class IOCAKFBLIAB : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string OMBLKOFJABM;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26FC680", Offset = "0x26FAC80", VA = "0x1826FC680")]
	public IOCAKFBLIAB(string ECMAPGHKHFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum KLJPOBAGBDD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MAHEINOFGOG : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string OMBLKOFJABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly bool BMKKNHDIDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly KLJPOBAGBDD BJFLOLKBEGK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1970", Offset = "0x6FEFF70", VA = "0x186FF1970")]
	public MAHEINOFGOG([Optional] string ECMAPGHKHFB, KLJPOBAGBDD KLGGKKGCLHM = KLJPOBAGBDD.Experiment, bool GMPGCNFAAAC = true)
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
