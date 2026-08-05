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
[KALJIFHMJGE]
public class GFBELLEDGBH : AOLKMMEDLCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly KAHKBHLEPFG JCIANALDNNO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x680C540", Offset = "0x680B740", VA = "0x18680C540")]
	[Preserve]
	public GFBELLEDGBH([NotNull][CDOANEBODFP(null)] KAHKBHLEPFG JCIANALDNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x149F9B0", Offset = "0x149EBB0", VA = "0x18149F9B0", Slot = "4")]
	public bool DNAFLLMHNBA<TExperiment>(string BJJDBMNFODL, out TExperiment GLKANIPHPAO) where TExperiment : HOIBMKCCJMK, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HOIBMKCCJMK
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KAHKBHLEPFG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNAFLLMHNBA<TExperiment>(string BJJDBMNFODL, out TExperiment GLKANIPHPAO) where TExperiment : HOIBMKCCJMK, new();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEPCACOBCEA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AOLKMMEDLCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNAFLLMHNBA<TExperiment>(string BJJDBMNFODL, out TExperiment GLKANIPHPAO) where TExperiment : HOIBMKCCJMK, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class BCDKODAPPBE : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct CJECFPKJLGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo JCIBHDCKCOC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FBKMOAMAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x680C000", Offset = "0x680B200", VA = "0x18680C000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x680C430", Offset = "0x680B630", VA = "0x18680C430")]
	public CJECFPKJLGL(MemberInfo JCIBHDCKCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x680C0C0", Offset = "0x680B2C0", VA = "0x18680C0C0")]
	public object IIEIMKIPEKF(object ICHBECDKHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x680BE60", Offset = "0x680B060", VA = "0x18680BE60")]
	public void FIDBGNANPBO(object ICHBECDKHOJ, object IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x680C1E0", Offset = "0x680B3E0", VA = "0x18680C1E0")]
	private static bool LDBIIHFAAPP(Type GHFKDODLJHK, object IPMIIEAGJKC, out object ILDFBKJBAEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BNLDNBNOAGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AICENJKOCHI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string PALADLMJNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool GEKBDAOJGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly BNLDNBNOAGJ MMMENNAAGAA;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x680BE00", Offset = "0x680B000", VA = "0x18680BE00")]
	public AICENJKOCHI([Optional] string KNOPFGAGMCN, BNLDNBNOAGJ NIFOGEBEDNG = BNLDNBNOAGJ.Experiment, bool LGKPFIGJMBN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class DBPKFLCLCEB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string PALADLMJNAK;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
	public DBPKFLCLCEB(string KNOPFGAGMCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KALJIFHMJGE]
public class JLGIIPEICIP : KAHKBHLEPFG
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class ABEEOOPOIND<TExperiment> where TExperiment : HOIBMKCCJMK, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HAIDJDDBCPP statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public ABEEOOPOIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BA6B00", Offset = "0x1BA5D00", VA = "0x181BA6B00")]
		internal bool <TryGetExperiment>b__0(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FEIKFKAICHC HKNAHLAFLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, HOIBMKCCJMK> PNCPHMDGNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, AICENJKOCHI> MPNKDHOEADK;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x680C620", Offset = "0x680B820", VA = "0x18680C620")]
	[Preserve]
	public JLGIIPEICIP([NotNull][CDOANEBODFP(null)] FEIKFKAICHC HKNAHLAFLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x12E35A0", Offset = "0x12E27A0", VA = "0x1812E35A0", Slot = "4")]
	public bool DNAFLLMHNBA<TExperiment>(string BJJDBMNFODL, out TExperiment GLKANIPHPAO) where TExperiment : HOIBMKCCJMK, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x680C5D0", Offset = "0x680B7D0", VA = "0x18680C5D0", Slot = "5")]
	public void JEPCACOBCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x12E3B80", Offset = "0x12E2D80", VA = "0x1812E3B80")]
	private bool EFGNKJPLBAM<TExperiment>(out AICENJKOCHI MPEFFCINAGA) where TExperiment : HOIBMKCCJMK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x12E3C80", Offset = "0x12E2E80", VA = "0x1812E3C80")]
	private static void IDCGJGHILAB<TExperiment>(TExperiment GLKANIPHPAO, Func<string, object, object> ACNNJPJFKOD, Predicate<string> INDAGLGNOLK) where TExperiment : HOIBMKCCJMK
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
