using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FJCHLDEPIFG : NFBFIODBAEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KGEPBINIGNP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE2D0", Offset = "0x5CFD0D0", VA = "0x185CFE2D0")]
	public FJCHLDEPIFG(string MNEFKFEHNPP, string KGEPBINIGNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class KGJDCNECMBP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FGOOAAHGNMO;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x77ED80", Offset = "0x77DB80", VA = "0x18077ED80")]
	public KGJDCNECMBP(string FGOOAAHGNMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CDIJBINDLCN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EHGCIBCPLHN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE280", Offset = "0x5CFD080", VA = "0x185CFE280")]
	public EHGCIBCPLHN(CDIJBINDLCN AOPDMLJGEMB = CDIJBINDLCN.Self, bool PEAMBJBABIO = false, bool EBNLILAMDCE = false, bool JLHNPJBBEMF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ACHBEPFKCHF : EHGCIBCPLHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type BFDIPMBMMKL;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE1C0", Offset = "0x5CFCFC0", VA = "0x185CFE1C0")]
	public ACHBEPFKCHF(Type JKHBAAOEOGO, CDIJBINDLCN AOPDMLJGEMB = CDIJBINDLCN.Self, bool PEAMBJBABIO = false, bool EBNLILAMDCE = false, bool JLHNPJBBEMF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BICPFBOLGLL : EHGCIBCPLHN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE280", Offset = "0x5CFD080", VA = "0x185CFE280")]
	public BICPFBOLGLL(CDIJBINDLCN AOPDMLJGEMB = CDIJBINDLCN.Self, bool PEAMBJBABIO = false, bool EBNLILAMDCE = false, bool JLHNPJBBEMF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class FOKCBHGBPOI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum GGMEOCMKDFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Error
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string BLCJAOOBJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly GGMEOCMKDFE AOPDMLJGEMB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE440", Offset = "0x5CFD240", VA = "0x185CFE440")]
	public FOKCBHGBPOI(string BLCJAOOBJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE3F0", Offset = "0x5CFD1F0", VA = "0x185CFE3F0")]
	public FOKCBHGBPOI(string BLCJAOOBJMG, GGMEOCMKDFE AOPDMLJGEMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NFBFIODBAEO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string MNEFKFEHNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool GHLMKDALKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] MHLPBDALGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool KHPDOAEBCAG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE560", Offset = "0x5CFD360", VA = "0x185CFE560")]
	public NFBFIODBAEO(string MNEFKFEHNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE480", Offset = "0x5CFD280", VA = "0x185CFE480")]
	public NFBFIODBAEO(string MNEFKFEHNPP, object OJNDMCCDHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE660", Offset = "0x5CFD460", VA = "0x185CFE660")]
	public NFBFIODBAEO(string MNEFKFEHNPP, params object[] MHLPBDALGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class POODIKOMIAA : NFBFIODBAEO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE480", Offset = "0x5CFD280", VA = "0x185CFE480")]
	public POODIKOMIAA(string MNEFKFEHNPP, object OJNDMCCDHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE660", Offset = "0x5CFD460", VA = "0x185CFE660")]
	public POODIKOMIAA(string MNEFKFEHNPP, params object[] MHLPBDALGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BAENBPPGNMH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool FJBLDKJPNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string FGHNDADFGEG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE230", Offset = "0x5CFD030", VA = "0x185CFE230")]
	public BAENBPPGNMH(string PLCIHNBBDIK, bool GAOPOLFDDPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CHOOJACKFNB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	public CHOOJACKFNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EJFODAINCIH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	public EJFODAINCIH()
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
