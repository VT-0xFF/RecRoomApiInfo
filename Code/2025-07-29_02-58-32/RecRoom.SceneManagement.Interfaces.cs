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
public interface MGHKBAFLJKK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMHJEIKEGOH([Out] Scene? LLKELBPPILC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ServiceLifetime(Lifetime.Application)]
public interface DLPPJIOGBLH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string, LoadSceneMode> CHEFGCLBHNF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KAEPDOFOKBN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MENGONLFCLM(LoadSceneMode BHACEHIEDOF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Scene> GJLCEMGDIBE(string MPIBHFEHILP, LoadSceneMode BHACEHIEDOF = LoadSceneMode.Single, bool NAFEFMDLLJM = false, [Optional] OGMJCPNEHOO<string>.LOEEEDILNMC PJMOAOMFLIM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BJKINLKLGHG NCPLKKGIBCL(string MPIBHFEHILP, LoadSceneMode BHACEHIEDOF, CancellationToken BOJKDJLCGKE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MFBFMPGPLMP([Out] string FNGEHNNHLNI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BJKINLKLGHG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IPPLMOGOANG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MGHKBAFLJKK> PGIJJCNHINJ();
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
