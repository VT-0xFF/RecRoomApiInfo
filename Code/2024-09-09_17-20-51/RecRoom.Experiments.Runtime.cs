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
[DEKINLCKNLM]
public class KMGPEAFPENK : FCALAPKBOCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AGFFPIBBLON CDNGDGIHDCC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B83FC0", Offset = "0x6B829C0", VA = "0x186B83FC0")]
	[Preserve]
	public KMGPEAFPENK([LKKACOOMNBP(null)][NotNull] AGFFPIBBLON CDNGDGIHDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2E149E0", Offset = "0x2E133E0", VA = "0x182E149E0", Slot = "4")]
	public bool HACOPNBJFHJ<TExperiment>([Out] TExperiment PIFFAAIBNEO) where TExperiment : ECHIABHEEON, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E14AB0", Offset = "0x2E134B0", VA = "0x182E14AB0", Slot = "5")]
	public bool HACOPNBJFHJ<TExperiment>(string IGGHGPJEENH, [Out] TExperiment PIFFAAIBNEO) where TExperiment : ECHIABHEEON, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ECHIABHEEON
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AGFFPIBBLON
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HACOPNBJFHJ<TExperiment>([Out] TExperiment PIFFAAIBNEO) where TExperiment : ECHIABHEEON, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HACOPNBJFHJ<TExperiment>(string IGGHGPJEENH, [Out] TExperiment PIFFAAIBNEO) where TExperiment : ECHIABHEEON, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELLLCJILGPD();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FCALAPKBOCC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HACOPNBJFHJ<TExperiment>([Out] TExperiment PIFFAAIBNEO) where TExperiment : ECHIABHEEON, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HACOPNBJFHJ<TExperiment>(string IGGHGPJEENH, [Out] TExperiment PIFFAAIBNEO) where TExperiment : ECHIABHEEON, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class NOAMLHJNJKB : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct AMDAAKGIIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo HPJJFDGFIAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type PDALNJIKMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B83BB0", Offset = "0x6B825B0", VA = "0x186B83BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B83CB0", Offset = "0x6B826B0", VA = "0x186B83CB0")]
	public AMDAAKGIIBB(MemberInfo HPJJFDGFIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B83A60", Offset = "0x6B82460", VA = "0x186B83A60")]
	public object LNFDLNBFLOL(object FHFDEAHMMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B83630", Offset = "0x6B82030", VA = "0x186B83630")]
	public void BANKOIMGLDC(object FHFDEAHMMBI, object IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B83800", Offset = "0x6B82200", VA = "0x186B83800")]
	private static bool IFFKBOLOCIC(Type LGAAECIJHBO, object IPHMAHBENGI, [Out] object KKKJDABCNHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DDKLNDLENHF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class FOLALHEEOBE : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string FMJDNGHFJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool GPDHIEHLBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly DDKLNDLENHF GPKIFFDGPEH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B83F60", Offset = "0x6B82960", VA = "0x186B83F60")]
	public FOLALHEEOBE([Optional] string DDDMPLCOGIM, DDKLNDLENHF AOGCIMANLIJ = DDKLNDLENHF.Experiment, bool FJCGGNNJGKO = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class NLFCDIDFKPC : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string FMJDNGHFJGI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B84060", Offset = "0x6B82A60", VA = "0x186B84060")]
	public NLFCDIDFKPC(string DDDMPLCOGIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DEKINLCKNLM]
public class EOBPGMMBCGC : AGFFPIBBLON
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CEDAPEAJNMB<TExperiment> where TExperiment : ECHIABHEEON, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DJNLDFPFJHM statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CEDAPEAJNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x54CE760", Offset = "0x54CD160", VA = "0x1854CE760")]
		internal bool ACMNJIDOEBD(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly DGMMCJOACNP DAHEHAAEHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, ECHIABHEEON> IMFJHFHPKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, FOLALHEEOBE> KBGEGPPIPLK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B83E10", Offset = "0x6B82810", VA = "0x186B83E10")]
	[Preserve]
	public EOBPGMMBCGC([NotNull][LKKACOOMNBP(null)] DGMMCJOACNP DAHEHAAEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2660", Offset = "0x2BD1060", VA = "0x182BD2660", Slot = "4")]
	public bool HACOPNBJFHJ<TExperiment>([Out] TExperiment PIFFAAIBNEO) where TExperiment : ECHIABHEEON, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2710", Offset = "0x2BD1110", VA = "0x182BD2710", Slot = "5")]
	public bool HACOPNBJFHJ<TExperiment>(string IGGHGPJEENH, [Out] TExperiment PIFFAAIBNEO) where TExperiment : ECHIABHEEON, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B83DC0", Offset = "0x6B827C0", VA = "0x186B83DC0", Slot = "6")]
	public void ELLLCJILGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3000", Offset = "0x2BD1A00", VA = "0x182BD3000")]
	private bool PEACKCPMNND<TExperiment>([Out] FOLALHEEOBE IFOEDAJCMCK) where TExperiment : ECHIABHEEON
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2C60", Offset = "0x2BD1660", VA = "0x182BD2C60")]
	private static void HNHDJOLHAEI<TExperiment>(TExperiment PIFFAAIBNEO, GJKBNHPOBGK PJOLIFMLFBM, Predicate<string> CNBNKEKJMHP) where TExperiment : ECHIABHEEON
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
