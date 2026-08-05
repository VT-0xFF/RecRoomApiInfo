using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.ObjectModel;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LLIFOPCOJJN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGMJBBBCDFO([Out] Scene? ABCMAHBDJBP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ServiceLifetime(Lifetime.Application)]
public interface CFEFPICLLAN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string, LoadSceneMode> EFAPLJFMAFN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action COHGPCODNDD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FACIGKMOMOK(LoadSceneMode ENKPEABPNON);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Scene> BPODGMABAIK(string NOBPIEKKHNK, LoadSceneMode ENKPEABPNON = LoadSceneMode.Single, bool LPLCLLOHEOO = false, [Optional] EHDFINDMEJI<string>.NGEIFBMECIG COMDGGLFBDL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OLHIPLPGMDP NAHBGHEJPOB(string NOBPIEKKHNK, LoadSceneMode ENKPEABPNON, CancellationToken FOJIDEIIGFD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PLLIINKNAIG([Out] string HHGNFBEPCJD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OLHIPLPGMDP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JECFOCJEAIH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<LLIFOPCOJJN> NLJPHHNDBHF();
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
