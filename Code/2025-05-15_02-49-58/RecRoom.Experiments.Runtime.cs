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
[HJNCDIOGCJG]
public class LHHHKNCNPFJ : MEJGMCPLHEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OAAGLLNLIEN PAMLFPGMJBA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C0EDD0", Offset = "0x7C0D3D0", VA = "0x187C0EDD0")]
	[Preserve]
	public LHHHKNCNPFJ([DJIFKCCBBND(null)][NotNull] OAAGLLNLIEN PAMLFPGMJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3915EF0", Offset = "0x39144F0", VA = "0x183915EF0", Slot = "4")]
	public bool POPMDLGCPPO<TExperiment>(string AHENDINOEMN, [Out] TExperiment KMNBBMDKPOK) where TExperiment : EMJDFMFELAB, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EMJDFMFELAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OAAGLLNLIEN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POPMDLGCPPO<TExperiment>([Out] TExperiment KMNBBMDKPOK) where TExperiment : EMJDFMFELAB, new();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POPMDLGCPPO<TExperiment>(string AHENDINOEMN, [Out] TExperiment KMNBBMDKPOK) where TExperiment : EMJDFMFELAB, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLLALONGNCG();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MEJGMCPLHEK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POPMDLGCPPO<TExperiment>(string AHENDINOEMN, [Out] TExperiment KMNBBMDKPOK) where TExperiment : EMJDFMFELAB, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class LBMDDFOJIHK : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct JCBOAKKLBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo JDEEIAMIMNP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type EGBKKNBMGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C0EA70", Offset = "0x7C0D070", VA = "0x187C0EA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C0ECC0", Offset = "0x7C0D2C0", VA = "0x187C0ECC0")]
	public JCBOAKKLBKH(MemberInfo JDEEIAMIMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C0EB70", Offset = "0x7C0D170", VA = "0x187C0EB70")]
	public object LNLLCGCJJDK(object BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E640", Offset = "0x7C0CC40", VA = "0x187C0E640")]
	public void DKFJJBJKAHH(object BOMDCGFKGKF, object OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E810", Offset = "0x7C0CE10", VA = "0x187C0E810")]
	private static bool GBPGOIKPFDI(Type EEGGCODEADK, object OHLIHBDBKCE, [Out] object OOCIOIOKELI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KEBBNCOBNDC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IBBPMKBIGBI : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string IJKBIMCGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool KKPLFLFBLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly KEBBNCOBNDC KFIKOGBAHMD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E5E0", Offset = "0x7C0CBE0", VA = "0x187C0E5E0")]
	public IBBPMKBIGBI([Optional] string NFHOBPDKIPM, KEBBNCOBNDC MLCOGCMJLBB = KEBBNCOBNDC.Experiment, bool EJAMFKGKGPN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class HHEGLDJKLIG : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string IJKBIMCGCEM;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E5A0", Offset = "0x7C0CBA0", VA = "0x187C0E5A0")]
	public HHEGLDJKLIG(string NFHOBPDKIPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HJNCDIOGCJG]
public class ABOLNEFNOKG : OAAGLLNLIEN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AHBCEHBLNML<TExperiment> where TExperiment : EMJDFMFELAB, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MJOJGIJEOGI statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AHBCEHBLNML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4A82500", Offset = "0x4A80B00", VA = "0x184A82500")]
		internal bool GLLECAAPGAG(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LPGGOLFFKPF NNAMEELADIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, EMJDFMFELAB> CCOBKPLDJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, IBBPMKBIGBI> AJJLPBEFEOG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E450", Offset = "0x7C0CA50", VA = "0x187C0E450")]
	[Preserve]
	public ABOLNEFNOKG([NotNull][DJIFKCCBBND(null)] LPGGOLFFKPF NNAMEELADIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FB9C00", Offset = "0x3FB8200", VA = "0x183FB9C00", Slot = "4")]
	public bool POPMDLGCPPO<TExperiment>([Out] TExperiment KMNBBMDKPOK) where TExperiment : EMJDFMFELAB, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FB9CB0", Offset = "0x3FB82B0", VA = "0x183FB9CB0", Slot = "5")]
	public bool POPMDLGCPPO<TExperiment>(string AHENDINOEMN, [Out] TExperiment KMNBBMDKPOK) where TExperiment : EMJDFMFELAB, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E400", Offset = "0x7C0CA00", VA = "0x187C0E400", Slot = "6")]
	public void PLLALONGNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3FB9B10", Offset = "0x3FB8110", VA = "0x183FB9B10")]
	private bool GPFIGKIKOFB<TExperiment>([Out] IBBPMKBIGBI IMANPKGHLPM) where TExperiment : EMJDFMFELAB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FB9720", Offset = "0x3FB7D20", VA = "0x183FB9720")]
	private static void CMMFNEFCFED<TExperiment>(TExperiment KMNBBMDKPOK, NDABMIJNJMI DMLAGOHNFIG, Predicate<string> AJJEBLPGMNE) where TExperiment : EMJDFMFELAB
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
