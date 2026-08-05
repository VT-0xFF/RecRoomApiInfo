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
[EAFHNCFGKJO]
public class IOLMEHHMFBA : PHEMKFLLHJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PGFKCJGDAEC LGMBKMGAIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8288580", Offset = "0x8287980", VA = "0x188288580")]
	[Preserve]
	public IOLMEHHMFBA([PKIHAALFADL(null)][NotNull] PGFKCJGDAEC LGMBKMGAIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D32AB0", Offset = "0x3D31EB0", VA = "0x183D32AB0", Slot = "4")]
	public bool LIFNCJBBCFB<TExperiment>([Out] TExperiment MFOPLKAAPAF) where TExperiment : CDAHENCIOHF, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D329E0", Offset = "0x3D31DE0", VA = "0x183D329E0", Slot = "5")]
	public bool LIFNCJBBCFB<TExperiment>(string DLKPFOFOMAN, [Out] TExperiment MFOPLKAAPAF) where TExperiment : CDAHENCIOHF, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CDAHENCIOHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PGFKCJGDAEC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIFNCJBBCFB<TExperiment>([Out] TExperiment MFOPLKAAPAF) where TExperiment : CDAHENCIOHF, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIFNCJBBCFB<TExperiment>(string DLKPFOFOMAN, [Out] TExperiment MFOPLKAAPAF) where TExperiment : CDAHENCIOHF, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILGFKIFODGO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PHEMKFLLHJI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIFNCJBBCFB<TExperiment>([Out] TExperiment MFOPLKAAPAF) where TExperiment : CDAHENCIOHF, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIFNCJBBCFB<TExperiment>(string DLKPFOFOMAN, [Out] TExperiment MFOPLKAAPAF) where TExperiment : CDAHENCIOHF, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class HAAAFMFOFGD : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct MFECINANNCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo LPEIKPMKJII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type NBDNDCDAJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8288A10", Offset = "0x8287E10", VA = "0x188288A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8288CE0", Offset = "0x82880E0", VA = "0x188288CE0")]
	public MFECINANNCJ(MemberInfo LPEIKPMKJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82888C0", Offset = "0x8287CC0", VA = "0x1882888C0")]
	public object FLBGDLPGKPP(object DEJGDIIDCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8288B10", Offset = "0x8287F10", VA = "0x188288B10")]
	public void OEOEKNMFCIO(object DEJGDIIDCDN, object CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8288660", Offset = "0x8287A60", VA = "0x188288660")]
	private static bool CDDHFKJJIGM(Type PICPHMBNEOK, object CBMEHPPMEEA, [Out] object IJBIOOACMAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DKHMILNCBEG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PEBPPDINMOM : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string GODGCHFEMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool PJGLKFMMJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly DKHMILNCBEG GBFFBDIJNIN;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8288DF0", Offset = "0x82881F0", VA = "0x188288DF0")]
	public PEBPPDINMOM([Optional] string HDNPPEBJPAE, DKHMILNCBEG IIHAKBEOLJD = DKHMILNCBEG.Experiment, bool AFKKEEHNPKC = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class MBINPJKEBFA : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string GODGCHFEMGD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8288620", Offset = "0x8287A20", VA = "0x188288620")]
	public MBINPJKEBFA(string HDNPPEBJPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[EAFHNCFGKJO]
public class HLLCOMIJDMM : PGFKCJGDAEC
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class APAGDCELEBL<TExperiment> where TExperiment : CDAHENCIOHF, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public BNCOHPPDMKG statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public APAGDCELEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53A9DF0", Offset = "0x53A91F0", VA = "0x1853A9DF0")]
		internal bool OFDPOKHJHBO(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FEGLFIFLMGC JNHBEKDBGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, CDAHENCIOHF> IPLIDMKOPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, PEBPPDINMOM> PCOALKMMPOP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8288430", Offset = "0x8287830", VA = "0x188288430")]
	[Preserve]
	public HLLCOMIJDMM([NotNull][PKIHAALFADL(null)] FEGLFIFLMGC JNHBEKDBGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA910", Offset = "0x3CC9D10", VA = "0x183CCA910", Slot = "4")]
	public bool LIFNCJBBCFB<TExperiment>([Out] TExperiment MFOPLKAAPAF) where TExperiment : CDAHENCIOHF, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA9A0", Offset = "0x3CC9DA0", VA = "0x183CCA9A0", Slot = "5")]
	public bool LIFNCJBBCFB<TExperiment>(string DLKPFOFOMAN, [Out] TExperiment MFOPLKAAPAF) where TExperiment : CDAHENCIOHF, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82883E0", Offset = "0x82877E0", VA = "0x1882883E0", Slot = "6")]
	public void ILGFKIFODGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA820", Offset = "0x3CC9C20", VA = "0x183CCA820")]
	private bool HFJEPBJNGEG<TExperiment>([Out] PEBPPDINMOM ABENOOGGODI) where TExperiment : CDAHENCIOHF
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA430", Offset = "0x3CC9830", VA = "0x183CCA430")]
	private static void EALIMKEEIFI<TExperiment>(TExperiment MFOPLKAAPAF, MNDOOCNGLFC HDMOLIEDBFC, Predicate<string> LPHFJKFNLGH) where TExperiment : CDAHENCIOHF
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
