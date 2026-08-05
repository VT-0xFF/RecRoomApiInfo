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
[CMGJJOIKLEE]
public class GPBOIEDDMPA : HCDEOIPALIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MIMMBBMMBIA LFHHEEFALLB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x613C7B0", Offset = "0x613B9B0", VA = "0x18613C7B0")]
	[Preserve]
	public GPBOIEDDMPA([BALLJMBCNAE(null)][NotNull] MIMMBBMMBIA LFHHEEFALLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2769930", Offset = "0x2768B30", VA = "0x182769930", Slot = "4")]
	public bool CCDPFPFBBGN<TExperiment>([Out] TExperiment EDAFELLALIO) where TExperiment : CKMPJPDGMGD, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2769A00", Offset = "0x2768C00", VA = "0x182769A00", Slot = "5")]
	public bool CCDPFPFBBGN<TExperiment>(string FGDKDKHFMEE, [Out] TExperiment EDAFELLALIO) where TExperiment : CKMPJPDGMGD, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CKMPJPDGMGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MIMMBBMMBIA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCDPFPFBBGN<TExperiment>([Out] TExperiment EDAFELLALIO) where TExperiment : CKMPJPDGMGD, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCDPFPFBBGN<TExperiment>(string FGDKDKHFMEE, [Out] TExperiment EDAFELLALIO) where TExperiment : CKMPJPDGMGD, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOAOCHKBNEL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HCDEOIPALIO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCDPFPFBBGN<TExperiment>([Out] TExperiment EDAFELLALIO) where TExperiment : CKMPJPDGMGD, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCDPFPFBBGN<TExperiment>(string FGDKDKHFMEE, [Out] TExperiment EDAFELLALIO) where TExperiment : CKMPJPDGMGD, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class AHADGEPBFFB : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct BIOOGFNKALO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo MIODFLDOHKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type NEIGAFHOCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x613C0F0", Offset = "0x613B2F0", VA = "0x18613C0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x613C4A0", Offset = "0x613B6A0", VA = "0x18613C4A0")]
	public BIOOGFNKALO(MemberInfo MIODFLDOHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x613C370", Offset = "0x613B570", VA = "0x18613C370")]
	public object POCHEIMJHNI(object MFLACBLODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x613C1C0", Offset = "0x613B3C0", VA = "0x18613C1C0")]
	public void EMIGLMHDFJK(object MFLACBLODGN, object AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x613BE90", Offset = "0x613B090", VA = "0x18613BE90")]
	private static bool ABMMCMIFIKL(Type INOFNCKLAAL, object AFCGKMGKPEF, [Out] object ODJLGNFOGLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IOPBNGLFBIN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GEECABECKDE : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string IHKMJLPGIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool FMJNAEOHLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly IOPBNGLFBIN OFDHKLACDLG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x613C750", Offset = "0x613B950", VA = "0x18613C750")]
	public GEECABECKDE([Optional] string NLBAJPAADNH, IOPBNGLFBIN DMEGHACCPAC = IOPBNGLFBIN.Experiment, bool OJEEIOOHBLD = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class POPELMDFCMN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string IHKMJLPGIHG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x613C850", Offset = "0x613BA50", VA = "0x18613C850")]
	public POPELMDFCMN(string NLBAJPAADNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CMGJJOIKLEE]
public class BJLIBIKLBJK : MIMMBBMMBIA
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OMMMEBOONFN<TExperiment> where TExperiment : CKMPJPDGMGD, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public FEHHIODPLBN statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public OMMMEBOONFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x407DF10", Offset = "0x407D110", VA = "0x18407DF10")]
		internal bool CPOHJMFLMKH(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly DHHKPNDEBCG KELEKGKEJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, CKMPJPDGMGD> LDHFCNJBCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, GEECABECKDE> AAFONNPBBOL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x613C600", Offset = "0x613B800", VA = "0x18613C600")]
	[Preserve]
	public BJLIBIKLBJK([NotNull][BALLJMBCNAE(null)] DHHKPNDEBCG KELEKGKEJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2574830", Offset = "0x2573A30", VA = "0x182574830", Slot = "4")]
	public bool CCDPFPFBBGN<TExperiment>([Out] TExperiment EDAFELLALIO) where TExperiment : CKMPJPDGMGD, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x25748C0", Offset = "0x2573AC0", VA = "0x1825748C0", Slot = "5")]
	public bool CCDPFPFBBGN<TExperiment>(string FGDKDKHFMEE, [Out] TExperiment EDAFELLALIO) where TExperiment : CKMPJPDGMGD, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x613C5B0", Offset = "0x613B7B0", VA = "0x18613C5B0", Slot = "6")]
	public void BOAOCHKBNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2574DB0", Offset = "0x2573FB0", VA = "0x182574DB0")]
	private bool LCPBIANDBNF<TExperiment>([Out] GEECABECKDE GEGDJOBCBIF) where TExperiment : CKMPJPDGMGD
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2574EA0", Offset = "0x25740A0", VA = "0x182574EA0")]
	private static void MEDDDAGNPBN<TExperiment>(TExperiment EDAFELLALIO, EMHIJBALADO KMMJHFMCIII, Predicate<string> DFCAMDCPANA) where TExperiment : CKMPJPDGMGD
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
