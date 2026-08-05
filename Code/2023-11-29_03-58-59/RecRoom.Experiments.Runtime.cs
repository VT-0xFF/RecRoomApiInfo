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
[GOIFFELMODE]
public class DIMFGEALIOE : GHCLNGPFIIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly GEMAODGIADB JAGPHEOOIIE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9B20", Offset = "0x5DF8F20", VA = "0x185DF9B20")]
	[Preserve]
	public DIMFGEALIOE([MJHHGJKKIMK(null)][NotNull] GEMAODGIADB JAGPHEOOIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2378660", Offset = "0x2377A60", VA = "0x182378660", Slot = "4")]
	public bool AHJJINPPHHC<TExperiment>([Out] TExperiment MCMGFENEKLM) where TExperiment : BCBBFGLDPCA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2378590", Offset = "0x2377990", VA = "0x182378590", Slot = "5")]
	public bool AHJJINPPHHC<TExperiment>(string PEIPHDMPMCC, [Out] TExperiment MCMGFENEKLM) where TExperiment : BCBBFGLDPCA, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BCBBFGLDPCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GEMAODGIADB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHJJINPPHHC<TExperiment>([Out] TExperiment MCMGFENEKLM) where TExperiment : BCBBFGLDPCA, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHJJINPPHHC<TExperiment>(string PEIPHDMPMCC, [Out] TExperiment MCMGFENEKLM) where TExperiment : BCBBFGLDPCA, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAEAHEPJNEC();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GHCLNGPFIIM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHJJINPPHHC<TExperiment>([Out] TExperiment MCMGFENEKLM) where TExperiment : BCBBFGLDPCA, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHJJINPPHHC<TExperiment>(string PEIPHDMPMCC, [Out] TExperiment MCMGFENEKLM) where TExperiment : BCBBFGLDPCA, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class HNABIMEFMPH : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct KBFJBNFFIDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo EDBPIDFKLNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type AMIIBKGJJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9F50", Offset = "0x5DF9350", VA = "0x185DF9F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA1D0", Offset = "0x5DF95D0", VA = "0x185DFA1D0")]
	public KBFJBNFFIDC(MemberInfo EDBPIDFKLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9E20", Offset = "0x5DF9220", VA = "0x185DF9E20")]
	public object HOPALDFECFK(object ECLCDMJMICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA020", Offset = "0x5DF9420", VA = "0x185DFA020")]
	public void JCPHNDDGFIE(object ECLCDMJMICA, object NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9BC0", Offset = "0x5DF8FC0", VA = "0x185DF9BC0")]
	private static bool AJCPDNHPBML(Type HDNAPDPFEMP, object NMENOOMOOJP, [Out] object IFNBLELJHFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GNOMIONKPGB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CKBLHBLIICK : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string MFBMONNEDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool GAMDBLDKGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly GNOMIONKPGB MELBEGGEDAJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9AC0", Offset = "0x5DF8EC0", VA = "0x185DF9AC0")]
	public CKBLHBLIICK([Optional] string MDFAJJKMBAI, GNOMIONKPGB LFLAEPCPMDG = GNOMIONKPGB.Experiment, bool LHEFEDLCLDN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class CEAPMHFNAFE : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string MFBMONNEDKC;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9A80", Offset = "0x5DF8E80", VA = "0x185DF9A80")]
	public CEAPMHFNAFE(string MDFAJJKMBAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GOIFFELMODE]
public class OIHGJBALNNP : GEMAODGIADB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IAIHJHDMMPC<TExperiment> where TExperiment : BCBBFGLDPCA, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DNENAFPHOAO statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public IAIHJHDMMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x36B7AF0", Offset = "0x36B6EF0", VA = "0x1836B7AF0")]
		internal bool GAIDLFPGHHA(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EKLGCGNBGGK PJKJNIBPDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, BCBBFGLDPCA> FHCFDMDELKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, CKBLHBLIICK> LCCFLMGEHEE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA330", Offset = "0x5DF9730", VA = "0x185DFA330")]
	[Preserve]
	public OIHGJBALNNP([NotNull][MJHHGJKKIMK(null)] EKLGCGNBGGK PJKJNIBPDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x265D790", Offset = "0x265CB90", VA = "0x18265D790", Slot = "4")]
	public bool AHJJINPPHHC<TExperiment>([Out] TExperiment MCMGFENEKLM) where TExperiment : BCBBFGLDPCA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x265D820", Offset = "0x265CC20", VA = "0x18265D820", Slot = "5")]
	public bool AHJJINPPHHC<TExperiment>(string PEIPHDMPMCC, [Out] TExperiment MCMGFENEKLM) where TExperiment : BCBBFGLDPCA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA2E0", Offset = "0x5DF96E0", VA = "0x185DFA2E0", Slot = "6")]
	public void AAEAHEPJNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x265DDB0", Offset = "0x265D1B0", VA = "0x18265DDB0")]
	private bool DMHGNOLDEOG<TExperiment>([Out] CKBLHBLIICK HEAPBHFPEFB) where TExperiment : BCBBFGLDPCA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x265DEA0", Offset = "0x265D2A0", VA = "0x18265DEA0")]
	private static void OGLCAMCGDPN<TExperiment>(TExperiment MCMGFENEKLM, Func<string, object, object> KOEPFFBFMFA, Predicate<string> KLLDCAHOGOC) where TExperiment : BCBBFGLDPCA
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
