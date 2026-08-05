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
[LOKPKGJHMNM]
public class DNKNGNNGFMN : LDDLKMBELEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DECCEDICJGE LIFLIMCIFLF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA180", Offset = "0x5FF9580", VA = "0x185FFA180")]
	[Preserve]
	public DNKNGNNGFMN([AKCMIAONCHN(null)][NotNull] DECCEDICJGE LIFLIMCIFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24AF770", Offset = "0x24AEB70", VA = "0x1824AF770", Slot = "4")]
	public bool DHGDLIAPGFP<TExperiment>([Out] TExperiment NCJPKCDMODP) where TExperiment : BFOMKOCGMIA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24AF840", Offset = "0x24AEC40", VA = "0x1824AF840", Slot = "5")]
	public bool DHGDLIAPGFP<TExperiment>(string KACPDFCDCBB, [Out] TExperiment NCJPKCDMODP) where TExperiment : BFOMKOCGMIA, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BFOMKOCGMIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DECCEDICJGE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHGDLIAPGFP<TExperiment>([Out] TExperiment NCJPKCDMODP) where TExperiment : BFOMKOCGMIA, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHGDLIAPGFP<TExperiment>(string KACPDFCDCBB, [Out] TExperiment NCJPKCDMODP) where TExperiment : BFOMKOCGMIA, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIMNMCFDDIO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LDDLKMBELEP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHGDLIAPGFP<TExperiment>([Out] TExperiment NCJPKCDMODP) where TExperiment : BFOMKOCGMIA, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHGDLIAPGFP<TExperiment>(string KACPDFCDCBB, [Out] TExperiment NCJPKCDMODP) where TExperiment : BFOMKOCGMIA, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class AHIALAMKPCD : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct LAIHCPKJHFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo BCCDEKDKPMH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type HONHJEIPNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FFA940", Offset = "0x5FF9D40", VA = "0x185FFA940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFAA10", Offset = "0x5FF9E10", VA = "0x185FFAA10")]
	public LAIHCPKJHFI(MemberInfo BCCDEKDKPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA400", Offset = "0x5FF9800", VA = "0x185FFA400")]
	public object BLMBCPBHMDH(object DFFBALIDCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA530", Offset = "0x5FF9930", VA = "0x185FFA530")]
	public void CFMPBGGOLBB(object DFFBALIDCLL, object PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA6E0", Offset = "0x5FF9AE0", VA = "0x185FFA6E0")]
	private static bool DKOMNLNFJEB(Type DCJOFLDLJHI, object PAHKKNONPEO, [Out] object KBKBJAGCIAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum CGAIGEBCGDA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class APJFIAPAJBN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string DACJMNMHBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool PFNIIBEFOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly CGAIGEBCGDA IIJIPCLFFOA;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA120", Offset = "0x5FF9520", VA = "0x185FFA120")]
	public APJFIAPAJBN([Optional] string ADLKEGECLOG, CGAIGEBCGDA KHENBEDBKDI = CGAIGEBCGDA.Experiment, bool JFBJINOBOKA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class ELFMALKEPOE : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string DACJMNMHBIF;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA220", Offset = "0x5FF9620", VA = "0x185FFA220")]
	public ELFMALKEPOE(string ADLKEGECLOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[LOKPKGJHMNM]
public class HDHMALEHFPA : DECCEDICJGE
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AGILLIOIEJP<TExperiment> where TExperiment : BFOMKOCGMIA, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public POPMKNDFAAK statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public AGILLIOIEJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3746A00", Offset = "0x3745E00", VA = "0x183746A00")]
		internal bool MPAHKDCGNHE(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FDGEEPCHEBJ FNHOOFAHMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, BFOMKOCGMIA> GJEMHJOMBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, APJFIAPAJBN> OFHNIIPAPOI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA2B0", Offset = "0x5FF96B0", VA = "0x185FFA2B0")]
	[Preserve]
	public HDHMALEHFPA([NotNull][AKCMIAONCHN(null)] FDGEEPCHEBJ FNHOOFAHMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2614160", Offset = "0x2613560", VA = "0x182614160", Slot = "4")]
	public bool DHGDLIAPGFP<TExperiment>([Out] TExperiment NCJPKCDMODP) where TExperiment : BFOMKOCGMIA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2613BD0", Offset = "0x2612FD0", VA = "0x182613BD0", Slot = "5")]
	public bool DHGDLIAPGFP<TExperiment>(string KACPDFCDCBB, [Out] TExperiment NCJPKCDMODP) where TExperiment : BFOMKOCGMIA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA260", Offset = "0x5FF9660", VA = "0x185FFA260", Slot = "6")]
	public void AIMNMCFDDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2614590", Offset = "0x2613990", VA = "0x182614590")]
	private bool KICFEDMHGCF<TExperiment>([Out] APJFIAPAJBN BAJICFHCJBF) where TExperiment : BFOMKOCGMIA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26141F0", Offset = "0x26135F0", VA = "0x1826141F0")]
	private static void FGBAKGPGBAD<TExperiment>(TExperiment NCJPKCDMODP, Func<string, object, object> HGPGKEIIJEC, Predicate<string> IINEADCPOKI) where TExperiment : BFOMKOCGMIA
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
