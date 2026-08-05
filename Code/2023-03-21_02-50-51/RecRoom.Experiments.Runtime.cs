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
[JKEBBOLEEMC]
public class PCCGFLCDINM : MGLGJADENMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MLDPJFIBHOM GOCCJCEPNBI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65EBA70", Offset = "0x65EA270", VA = "0x1865EBA70")]
	[Preserve]
	public PCCGFLCDINM([NotNull][LJAGOLJKNEF(null)] MLDPJFIBHOM GOCCJCEPNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A15880", Offset = "0x2A14080", VA = "0x182A15880", Slot = "4")]
	public bool ANLIBPODPBN<TExperiment>(string HFGILEGILPP, out TExperiment PLIKKODBFKE) where TExperiment : MOOONGFMPEP, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MOOONGFMPEP
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MLDPJFIBHOM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANLIBPODPBN<TExperiment>(string HFGILEGILPP, out TExperiment PLIKKODBFKE) where TExperiment : MOOONGFMPEP, new();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKCIKNFCKBA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MGLGJADENMP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANLIBPODPBN<TExperiment>(string HFGILEGILPP, out TExperiment PLIKKODBFKE) where TExperiment : MOOONGFMPEP, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class JJODDBKMENG : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct EHJJOCDPOMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo MOBLKDMNBPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type MKMMGJKPOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x65EB400", Offset = "0x65E9C00", VA = "0x1865EB400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65EB780", Offset = "0x65E9F80", VA = "0x1865EB780")]
	public EHJJOCDPOMK(MemberInfo MOBLKDMNBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65EB4C0", Offset = "0x65E9CC0", VA = "0x1865EB4C0")]
	public object JCAOJAAFFGN(object BFHAMCLNCKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65EB5E0", Offset = "0x65E9DE0", VA = "0x1865EB5E0")]
	public void LPDBNOLGMBP(object BFHAMCLNCKB, object NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x65EB1B0", Offset = "0x65E99B0", VA = "0x1865EB1B0")]
	private static bool CCJGGAPAPKC(Type AEDNBFJFMGD, object NPHADDCNBHE, out object PLCGFLJKLCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KAPKBFJELHG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LMHNEOCEOLM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string ILMHEGPAEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool GFPJJGIENOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly KAPKBFJELHG ECHKLFAEIOA;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65EBA10", Offset = "0x65EA210", VA = "0x1865EBA10")]
	public LMHNEOCEOLM([Optional] string LOIAMCEJAFO, KAPKBFJELHG EHPFPOFFCEJ = KAPKBFJELHG.Experiment, bool HNJPOBOGMIA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class GEILEDJHKOB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string ILMHEGPAEKG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F06F0", Offset = "0x6EEEF0", VA = "0x1806F06F0")]
	public GEILEDJHKOB(string LOIAMCEJAFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[JKEBBOLEEMC]
public class LJCGPNECKEI : MLDPJFIBHOM
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LMJHCLONPAJ<TExperiment> where TExperiment : MOOONGFMPEP, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GNAOLMDHMGB statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public LMJHCLONPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8290", Offset = "0x2FE6A90", VA = "0x182FE8290")]
		internal bool <TryGetExperiment>b__0(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MIJGMBFDPDO OLBIELOOMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, MOOONGFMPEP> BDAANAFICGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, LMHNEOCEOLM> CIONLANBEKP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65EB8E0", Offset = "0x65EA0E0", VA = "0x1865EB8E0")]
	[Preserve]
	public LJCGPNECKEI([NotNull][LJAGOLJKNEF(null)] MIJGMBFDPDO OLBIELOOMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24DF7F0", Offset = "0x24DDFF0", VA = "0x1824DF7F0", Slot = "4")]
	public bool ANLIBPODPBN<TExperiment>(string HFGILEGILPP, out TExperiment PLIKKODBFKE) where TExperiment : MOOONGFMPEP, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65EB890", Offset = "0x65EA090", VA = "0x1865EB890", Slot = "5")]
	public void PKCIKNFCKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24DFDD0", Offset = "0x24DE5D0", VA = "0x1824DFDD0")]
	private bool BHGNBFGAKGO<TExperiment>(out LMHNEOCEOLM BIFADJFJBNC) where TExperiment : MOOONGFMPEP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x24DFED0", Offset = "0x24DE6D0", VA = "0x1824DFED0")]
	private static void HJOKOICONMG<TExperiment>(TExperiment PLIKKODBFKE, Func<string, object, object> BEHIHHMDOCP, Predicate<string> NMBKEPBADCO) where TExperiment : MOOONGFMPEP
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
