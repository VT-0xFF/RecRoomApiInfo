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
[DBJDBDKBAOF]
public class LBMBODGDIDN : MNKAOBHNFLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DIKNKFONGBL GGIJIFDHMIL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x663B990", Offset = "0x663A790", VA = "0x18663B990")]
	[Preserve]
	public LBMBODGDIDN([NotNull][KIJADEHPJBH(null)] DIKNKFONGBL GGIJIFDHMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x25E6C20", Offset = "0x25E5A20", VA = "0x1825E6C20", Slot = "4")]
	public bool EJCEGIGGBFE<TExperiment>(string DDMALLIIPEG, out TExperiment FAFJKFLHCMI) where TExperiment : NPHENGNKEBJ, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NPHENGNKEBJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DIKNKFONGBL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJCEGIGGBFE<TExperiment>(string DDMALLIIPEG, out TExperiment FAFJKFLHCMI) where TExperiment : NPHENGNKEBJ, new();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKAFPHPNJGA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MNKAOBHNFLB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJCEGIGGBFE<TExperiment>(string DDMALLIIPEG, out TExperiment FAFJKFLHCMI) where TExperiment : NPHENGNKEBJ, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class BHLFBBPCGJF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct ENNEDNCIDPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo IICDCHOJKLJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type OEEFEAFCCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x663B7C0", Offset = "0x663A5C0", VA = "0x18663B7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x663B880", Offset = "0x663A680", VA = "0x18663B880")]
	public ENNEDNCIDPC(MemberInfo IICDCHOJKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x663B6A0", Offset = "0x663A4A0", VA = "0x18663B6A0")]
	public object GMDGPINAMDC(object BLIKPCIFNNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x663B500", Offset = "0x663A300", VA = "0x18663B500")]
	public void DJFHMHBCIBN(object BLIKPCIFNNO, object NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x663B2B0", Offset = "0x663A0B0", VA = "0x18663B2B0")]
	private static bool DDPHDOKKBJA(Type LABJIADKJHG, object NLHFEJHKLAH, out object KNLGFDGAJKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GGHFKKFNBGM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class EANGDAAPECD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string LMPHGOGJNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool AGBJGCLECMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly GGHFKKFNBGM DKNGEPPLFHH;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x663B250", Offset = "0x663A050", VA = "0x18663B250")]
	public EANGDAAPECD([Optional] string EOPECGOILOC, GGHFKKFNBGM MAIOHDHBGKE = GGHFKKFNBGM.Experiment, bool KKDLANHGLLK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class NJGEHKLPOBJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string LMPHGOGJNDD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x740BD0", Offset = "0x73F9D0", VA = "0x180740BD0")]
	public NJGEHKLPOBJ(string EOPECGOILOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DBJDBDKBAOF]
public class CHDEPBCCCKE : DIKNKFONGBL
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GLPLLFJJJCM<TExperiment> where TExperiment : NPHENGNKEBJ, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NDHJFFILMBD statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public GLPLLFJJJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D24E00", Offset = "0x3D23C00", VA = "0x183D24E00")]
		internal bool <TryGetExperiment>b__0(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MGFDLFIFDLL MDMEKLKMCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, NPHENGNKEBJ> FGNIAHFINFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, EANGDAAPECD> CBJAPBLMAHB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x663B120", Offset = "0x6639F20", VA = "0x18663B120")]
	[Preserve]
	public CHDEPBCCCKE([NotNull][KIJADEHPJBH(null)] MGFDLFIFDLL MDMEKLKMCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x285A350", Offset = "0x2859150", VA = "0x18285A350", Slot = "4")]
	public bool EJCEGIGGBFE<TExperiment>(string DDMALLIIPEG, out TExperiment FAFJKFLHCMI) where TExperiment : NPHENGNKEBJ, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x663B0D0", Offset = "0x6639ED0", VA = "0x18663B0D0", Slot = "5")]
	public void DKAFPHPNJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x285A930", Offset = "0x2859730", VA = "0x18285A930")]
	private bool FDFLOPBJLFE<TExperiment>(out EANGDAAPECD JEBIFFGKIKD) where TExperiment : NPHENGNKEBJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x285AA30", Offset = "0x2859830", VA = "0x18285AA30")]
	private static void MPLKFGIHOBK<TExperiment>(TExperiment FAFJKFLHCMI, Func<string, object, object> NPBGPMGMOGC, Predicate<string> HICHMMGMFDL) where TExperiment : NPHENGNKEBJ
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
