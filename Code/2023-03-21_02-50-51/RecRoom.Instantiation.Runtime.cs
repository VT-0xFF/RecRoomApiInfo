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
public class POKJHLBKKBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid FABJFPOJNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FFFNIMKCLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int IMHKKPGBPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid OBJMNPKPKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ADKDENCHBMP EFOFMIPHHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 MGCHMBJMOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion FBFBLLMGNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 DDNHBOFCIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PLJEBGAKLDG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65EA4C0", Offset = "0x65E8CC0", VA = "0x1865EA4C0")]
	public POKJHLBKKBA(string MPGBCBMLKLF, Guid LEFBENCNJPA, int JDNPHPFKMJD, Guid JNIANOGNEJA, ADKDENCHBMP MFGLNFFPMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65EA300", Offset = "0x65E8B00", VA = "0x1865EA300")]
	public MPNLCKJPJHL.HHNPPPEGJCD IIJONMDPJBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x65EA240", Offset = "0x65E8A40", VA = "0x1865EA240")]
	public FIIGBDHGIGK IEBFPECOOAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ADKDENCHBMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> KCCCHPJGKAN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65EA1B0", Offset = "0x65E89B0", VA = "0x1865EA1B0")]
	public ADKDENCHBMP([Optional] Dictionary<string, object> KCCCHPJGKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65EA000", Offset = "0x65E8800", VA = "0x1865EA000")]
	[NotNull]
	public static ADKDENCHBMP JIGEKNKFAEA(PhotonView EADBGDCJMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x17F1E30", Offset = "0x17F0630", VA = "0x1817F1E30")]
	public bool FEEDILOKHNP<T>(string NHBANLNJEIH, out T NPHADDCNBHE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x17F1C90", Offset = "0x17F0490", VA = "0x1817F1C90")]
	public void BJPKOCBPDKP<T>(string NHBANLNJEIH, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65E9FA0", Offset = "0x65E87A0", VA = "0x1865E9FA0")]
	public void ALIFOBNBCOA(string NHBANLNJEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
	public Dictionary<string, object> IKMNABGJNBJ()
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
