using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::HKOGDBIDOFL(typeof(ContainerFlagsData))]
public static class KMGMPCEPIBK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61B4FA0", Offset = "0x61B41A0", VA = "0x1861B4FA0")]
	[global::BKHJONDHCJD(1)]
	public static void GKPLELICAPB([global::JBILIDMDGLK(1)] DMFJIBOHKNI LAAOKPCAINF, [Out][global::JBILIDMDGLK(1)] DMFJIBOHKNI LALJNBPJCBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::HKOGDBIDOFL(typeof(ObjectPolicyData))]
public static class DCPPLDKDKFB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61B4F90", Offset = "0x61B4190", VA = "0x1861B4F90")]
	[global::BKHJONDHCJD(2)]
	public static void FHOPJLLCBHE([global::JBILIDMDGLK(3)] bool MINNFCJDBIN, [Out][global::JBILIDMDGLK(3)] ENENJKLEDNA KIAPHNPFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::HKOGDBIDOFL(typeof(PersistentUserTagData))]
public static class NEFOGMDECGH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61B4FB0", Offset = "0x61B41B0", VA = "0x1861B4FB0")]
	[global::BKHJONDHCJD(1)]
	public static void NBJOAKHBJNF([global::JBILIDMDGLK(1)] FixedList32Bytes<int> EHMKHCNPLNL, [Out][global::JBILIDMDGLK(2)] bool KNHHMICEHBO)
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
