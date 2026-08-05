using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::HELEMOKAGJH(typeof(ContainerFlagsData))]
public static class LLBNGGLOBBC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6181AE0", Offset = "0x6180EE0", VA = "0x186181AE0")]
	[global::GDKCBLLNEPI(1)]
	public static void JBKOCOMCCDM([global::ALGMDGFOCIH(1)] OCIFAGNHLMI NNOPDFHJCLF, [Out][global::ALGMDGFOCIH(1)] OCIFAGNHLMI AKCPIJIILLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::HELEMOKAGJH(typeof(ObjectPolicyData))]
public static class MMDJEKFLBFP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6181AF0", Offset = "0x6180EF0", VA = "0x186181AF0")]
	[global::GDKCBLLNEPI(2)]
	public static void HOIABHJDOIA([global::ALGMDGFOCIH(3)] bool HPELPDCHDEP, [Out][global::ALGMDGFOCIH(3)] LPMEJADPGOH KKLDALHJAEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::HELEMOKAGJH(typeof(PersistentUserTagData))]
public static class MOGNCKAGIBE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6181B00", Offset = "0x6180F00", VA = "0x186181B00")]
	[global::GDKCBLLNEPI(1)]
	public static void KHEGJFNMEGI([global::ALGMDGFOCIH(1)] FixedList32Bytes<int> FGNAEAFIHMM, [Out][global::ALGMDGFOCIH(2)] bool AKDHOJOKNHI)
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
