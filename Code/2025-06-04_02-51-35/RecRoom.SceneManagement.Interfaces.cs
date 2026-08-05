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
public interface NIGHPONAAAI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPMGHGDBBOK([Out] Scene? FBEGPGJFHFP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ServiceLifetime(Lifetime.Application)]
public interface IDHNMEIGPID
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string, LoadSceneMode> DPJHMKBHDMB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DJGGAOIDDGH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABKLJDGJIPJ(LoadSceneMode JDNBDAPOGAO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Scene> OCKGJALJDLL(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO = LoadSceneMode.Single, bool JBDNOPCAAAA = false, [Optional] DKKFAAJNJJM<string>.BNLIHIFJPDL EHKOIFCHJFP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FDNEDNLHGAA PMHPMALOMGL(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO, CancellationToken DGACCOBPOIM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DEJBLGHDPEF([Out] string GPHEDLFMGLC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FDNEDNLHGAA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OHAMCKIGLFE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NIGHPONAAAI> ACIFNFNLLOE();
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
