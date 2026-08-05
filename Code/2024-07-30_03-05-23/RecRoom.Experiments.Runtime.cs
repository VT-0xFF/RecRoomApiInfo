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
[OBKEFOLKLJN]
public class OONACKPDCIL : KBMKPAIPLME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly KJAMDDDAEAM LECMHIHADPE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69F17E0", Offset = "0x69EFDE0", VA = "0x1869F17E0")]
	[Preserve]
	public OONACKPDCIL([JAMCDGPOOBO(null)][NotNull] KJAMDDDAEAM LECMHIHADPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B30", Offset = "0x2D15130", VA = "0x182D16B30", Slot = "4")]
	public bool AGLJPIKBJDF<TExperiment>([Out] TExperiment BOOHFNNMNIJ) where TExperiment : IHGEHMNOBHL, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2D16A60", Offset = "0x2D15060", VA = "0x182D16A60", Slot = "5")]
	public bool AGLJPIKBJDF<TExperiment>(string POILCNJJAME, [Out] TExperiment BOOHFNNMNIJ) where TExperiment : IHGEHMNOBHL, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IHGEHMNOBHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KJAMDDDAEAM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLJPIKBJDF<TExperiment>([Out] TExperiment BOOHFNNMNIJ) where TExperiment : IHGEHMNOBHL, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGLJPIKBJDF<TExperiment>(string POILCNJJAME, [Out] TExperiment BOOHFNNMNIJ) where TExperiment : IHGEHMNOBHL, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNJODFLNOFG();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KBMKPAIPLME
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLJPIKBJDF<TExperiment>([Out] TExperiment BOOHFNNMNIJ) where TExperiment : IHGEHMNOBHL, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGLJPIKBJDF<TExperiment>(string POILCNJJAME, [Out] TExperiment BOOHFNNMNIJ) where TExperiment : IHGEHMNOBHL, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class KDMJHNMDFDO : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct CKEKPPPGOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo BLOCHHLHGBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type PDLKJCMNHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69F1410", Offset = "0x69EFA10", VA = "0x1869F1410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69F14D0", Offset = "0x69EFAD0", VA = "0x1869F14D0")]
	public CKEKPPPGOAK(MemberInfo BLOCHHLHGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69F0EE0", Offset = "0x69EF4E0", VA = "0x1869F0EE0")]
	public object AACDCMAOBJC(object NJKKPOFFNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69F1000", Offset = "0x69EF600", VA = "0x1869F1000")]
	public void IFICIMIEIPO(object NJKKPOFFNNJ, object DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69F11B0", Offset = "0x69EF7B0", VA = "0x1869F11B0")]
	private static bool JMJHDJFDAHC(Type KIMEBIGKPLK, object DMNGPNKHPKF, [Out] object LALFDGGAEIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DNLLMHKENHC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class FPIIHICKCMA : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string OABCLOFHIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool ONCCNPBPCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly DNLLMHKENHC LADEKBPIHJB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x69F15E0", Offset = "0x69EFBE0", VA = "0x1869F15E0")]
	public FPIIHICKCMA([Optional] string GJEDHMJMNJA, DNLLMHKENHC GOAECDHCJMK = DNLLMHKENHC.Experiment, bool FDGEMHKANEP = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class POJGIKOEJJO : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string OABCLOFHIGC;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69F1880", Offset = "0x69EFE80", VA = "0x1869F1880")]
	public POJGIKOEJJO(string GJEDHMJMNJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[OBKEFOLKLJN]
public class KKFPMHCONMH : KJAMDDDAEAM
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CCBEFPBJCDM<TExperiment> where TExperiment : IHGEHMNOBHL, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public OGADDIHGPOA statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public CCBEFPBJCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51AD840", Offset = "0x51ABE40", VA = "0x1851AD840")]
		internal bool JGHKGMKDNDA(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NMMBPCBEFII ICHJIAGMLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, IHGEHMNOBHL> DMKEKBEOJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, FPIIHICKCMA> MHKBBFPIAPC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69F1690", Offset = "0x69EFC90", VA = "0x1869F1690")]
	[Preserve]
	public KKFPMHCONMH([NotNull][JAMCDGPOOBO(null)] NMMBPCBEFII ICHJIAGMLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2C39070", Offset = "0x2C37670", VA = "0x182C39070", Slot = "4")]
	public bool AGLJPIKBJDF<TExperiment>([Out] TExperiment BOOHFNNMNIJ) where TExperiment : IHGEHMNOBHL, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2C38B10", Offset = "0x2C37110", VA = "0x182C38B10", Slot = "5")]
	public bool AGLJPIKBJDF<TExperiment>(string POILCNJJAME, [Out] TExperiment BOOHFNNMNIJ) where TExperiment : IHGEHMNOBHL, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69F1640", Offset = "0x69EFC40", VA = "0x1869F1640", Slot = "6")]
	public void GNJODFLNOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2C394C0", Offset = "0x2C37AC0", VA = "0x182C394C0")]
	private bool GLOMHGEFOGP<TExperiment>([Out] FPIIHICKCMA IOHCDONHNMD) where TExperiment : IHGEHMNOBHL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2C39120", Offset = "0x2C37720", VA = "0x182C39120")]
	private static void DJDHGIFDBMC<TExperiment>(TExperiment BOOHFNNMNIJ, GIMNFONOJIN DOHIDCNNCPC, Predicate<string> AOFFMLADLMM) where TExperiment : IHGEHMNOBHL
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
