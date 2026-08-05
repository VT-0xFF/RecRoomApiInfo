using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::PNPAJGDMLBC(typeof(ContainerFlagsData))]
public static class GPGLJGMBALJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C690", Offset = "0x6D0BA90", VA = "0x186D0C690")]
	[global::LNPMDFPEMFP(1)]
	public static void ENDEGPJIFKK([global::NIBAFDGJKME(1)] NOIFHPCOMKO NBDOEDDBPBM, [Out][global::NIBAFDGJKME(1)] NOIFHPCOMKO FOBOFKBBNPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::PNPAJGDMLBC(typeof(ObjectPolicyData))]
public static class EGDONKOIIOG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C680", Offset = "0x6D0BA80", VA = "0x186D0C680")]
	[global::LNPMDFPEMFP(2)]
	public static void JGDKHKCLDCK([global::NIBAFDGJKME(3)] bool JFHPHOAKGKL, [Out][global::NIBAFDGJKME(3)] JNFFHEALOJK JADACNGBBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::PNPAJGDMLBC(typeof(PersistentUserTagData))]
public static class APNGILBAKMD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C670", Offset = "0x6D0BA70", VA = "0x186D0C670")]
	[global::LNPMDFPEMFP(1)]
	public static void EDLHOCHKGKN([global::NIBAFDGJKME(1)] FixedList32Bytes<int> BGGIPDHEELK, [Out][global::NIBAFDGJKME(2)] bool ICEDOGNOIDA)
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
