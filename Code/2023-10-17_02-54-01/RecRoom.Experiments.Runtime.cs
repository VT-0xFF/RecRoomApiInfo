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
[IJHFDBGCIOC]
public class BPNKGHHCAKO : LIJLBNBGANO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OIFLBLKIEOD AGJMHGKNENJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3270", Offset = "0x5CC1A70", VA = "0x185CC3270")]
	[Preserve]
	public BPNKGHHCAKO([KEKICHOEFEB(null)][NotNull] OIFLBLKIEOD AGJMHGKNENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2195200", Offset = "0x2193A00", VA = "0x182195200", Slot = "4")]
	public bool AGLHJOGIAKG<TExperiment>([Out] TExperiment APEFCALIOGL) where TExperiment : NJNEFDGEIMF, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21952D0", Offset = "0x2193AD0", VA = "0x1821952D0", Slot = "5")]
	public bool AGLHJOGIAKG<TExperiment>(string GJBFMEHMNMD, [Out] TExperiment APEFCALIOGL) where TExperiment : NJNEFDGEIMF, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NJNEFDGEIMF
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OIFLBLKIEOD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLHJOGIAKG<TExperiment>([Out] TExperiment APEFCALIOGL) where TExperiment : NJNEFDGEIMF, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGLHJOGIAKG<TExperiment>(string GJBFMEHMNMD, [Out] TExperiment APEFCALIOGL) where TExperiment : NJNEFDGEIMF, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOABOPEAMAL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LIJLBNBGANO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLHJOGIAKG<TExperiment>([Out] TExperiment APEFCALIOGL) where TExperiment : NJNEFDGEIMF, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGLHJOGIAKG<TExperiment>(string GJBFMEHMNMD, [Out] TExperiment APEFCALIOGL) where TExperiment : NJNEFDGEIMF, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class AMJIKCBAGJE : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct CODOOLPLBGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo IEIPFGJACPP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FCIDJBKHIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CC34C0", Offset = "0x5CC1CC0", VA = "0x185CC34C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3920", Offset = "0x5CC2120", VA = "0x185CC3920")]
	public CODOOLPLBGO(MemberInfo IEIPFGJACPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC37F0", Offset = "0x5CC1FF0", VA = "0x185CC37F0")]
	public object HDCIFCDCJJM(object CBBCDNDPNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3310", Offset = "0x5CC1B10", VA = "0x185CC3310")]
	public void DKMEDKGGILM(object CBBCDNDPNHF, object FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3590", Offset = "0x5CC1D90", VA = "0x185CC3590")]
	private static bool FOEIJNOHCPK(Type CIPGIAFFCPN, object FKKGMPDEPMA, [Out] object BLHFCLFDPOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum EAIICMIEAKD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class KGBCMDGJFGF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string MBENGICGPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool APKHJHHADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly EAIICMIEAKD DAKFPFPAGLI;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3BD0", Offset = "0x5CC23D0", VA = "0x185CC3BD0")]
	public KGBCMDGJFGF([Optional] string HNHMJGCODBA, EAIICMIEAKD GFGNPBCFEMC = EAIICMIEAKD.Experiment, bool MJJIKEINBPJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class BGAMGNMKOPB : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string MBENGICGPDH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3230", Offset = "0x5CC1A30", VA = "0x185CC3230")]
	public BGAMGNMKOPB(string HNHMJGCODBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[IJHFDBGCIOC]
public class ELDAAHAKEAN : OIFLBLKIEOD
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EFBGFAKOPGH<TExperiment> where TExperiment : NJNEFDGEIMF, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GOAMHJHIPKL statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EFBGFAKOPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3065360", Offset = "0x3063B60", VA = "0x183065360")]
		internal bool BKHCAPEBDLM(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JJCDNFCIIMN PENIHBIONCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, NJNEFDGEIMF> ADMGCDJHAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, KGBCMDGJFGF> NGFMDGPNNLM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3A80", Offset = "0x5CC2280", VA = "0x185CC3A80")]
	[Preserve]
	public ELDAAHAKEAN([NotNull][KEKICHOEFEB(null)] JJCDNFCIIMN PENIHBIONCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2245210", Offset = "0x2243A10", VA = "0x182245210", Slot = "4")]
	public bool AGLHJOGIAKG<TExperiment>([Out] TExperiment APEFCALIOGL) where TExperiment : NJNEFDGEIMF, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x22452A0", Offset = "0x2243AA0", VA = "0x1822452A0", Slot = "5")]
	public bool AGLHJOGIAKG<TExperiment>(string GJBFMEHMNMD, [Out] TExperiment APEFCALIOGL) where TExperiment : NJNEFDGEIMF, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3A30", Offset = "0x5CC2230", VA = "0x185CC3A30", Slot = "6")]
	public void LOABOPEAMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2245BD0", Offset = "0x22443D0", VA = "0x182245BD0")]
	private bool PBFABICJHNP<TExperiment>([Out] KGBCMDGJFGF LEFMPNOIEGE) where TExperiment : NJNEFDGEIMF
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2245830", Offset = "0x2244030", VA = "0x182245830")]
	private static void FOCAIBJHGID<TExperiment>(TExperiment APEFCALIOGL, Func<string, object, object> FLPHGHLPPGL, Predicate<string> NKJMBOJJLMM) where TExperiment : NJNEFDGEIMF
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
