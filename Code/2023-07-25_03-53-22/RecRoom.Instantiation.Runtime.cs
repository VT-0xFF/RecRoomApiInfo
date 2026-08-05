using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Photon.Pun;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FLMOHKGBJCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IDLMNIHAGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string LLHGDBOGPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int NPHBHGOJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid KALJOKFFAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly KNKIFCIDEJM PDJBCPDHBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 JILJAGCFLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion AOEKNCDMNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 DCIGGAMPNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GLKCDLMHEHI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7300BC0", Offset = "0x72FFBC0", VA = "0x187300BC0")]
	public FLMOHKGBJCK(string LIOPPJMKGHC, Guid AOFMJLBNNMP, int CMNDJBOENNF, Guid BEBKJGLBKKE, KNKIFCIDEJM GGDHKLAEHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7300A00", Offset = "0x72FFA00", VA = "0x187300A00")]
	public BKBHABHEKNN PFDNBJALFHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7300AC0", Offset = "0x72FFAC0", VA = "0x187300AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KNKIFCIDEJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> EAMFLJNNCGE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7300EB0", Offset = "0x72FFEB0", VA = "0x187300EB0")]
	public KNKIFCIDEJM([Optional] Dictionary<string, object> EAMFLJNNCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7300CF0", Offset = "0x72FFCF0", VA = "0x187300CF0")]
	[NotNull]
	public static KNKIFCIDEJM HGFOOMPDCGB(PhotonView ILDIOIFMEIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B5BD80", Offset = "0x2B5AD80", VA = "0x182B5BD80")]
	public bool JLLAOJKGHMF<T>(string LOHIKDGDMPP, out T CKDFGEALFAK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B5BBE0", Offset = "0x2B5ABE0", VA = "0x182B5BBE0")]
	public void DGLJBNFHKAF<T>(string LOHIKDGDMPP, T CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7300C90", Offset = "0x72FFC90", VA = "0x187300C90")]
	public void DNDEJFPIDIA(string LOHIKDGDMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x90AAB0", Offset = "0x909AB0", VA = "0x18090AAB0")]
	public Dictionary<string, object> LPFHAEBDCKD()
	{
		return null;
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
