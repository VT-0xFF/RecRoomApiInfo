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
public interface IONCCFOBBJM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BKLEHGBDNME([Out] Scene? KPJKFFHLGJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ServiceLifetime(Lifetime.Application)]
public interface KFGFFEGGOPH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string, LoadSceneMode> ALGBIGGHLGN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HJLBNNHILNK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ELEENNLCNGB(LoadSceneMode ENFBMLKHOJI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Scene> DMAGAOKIGIG(string HLFANMELOFL, LoadSceneMode ENFBMLKHOJI = LoadSceneMode.Single, bool HGCDIEMGEPF = false, [Optional] JBLIEDANKLD<string>.CKADLEMJOGG NKDACHKMEEI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NEFKBOAAHCB OGINFPMFOPA(string HLFANMELOFL, LoadSceneMode ENFBMLKHOJI, CancellationToken IFGGPDNONLM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OGAGHHMGLFK([Out] string OAPJGAALDOO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NEFKBOAAHCB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LJPJEJOOCCD();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IONCCFOBBJM> COCIPKFKDJC();
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
