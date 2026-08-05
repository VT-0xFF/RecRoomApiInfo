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
public interface ECHCFABKOME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPCDJKGLCDK([Out] Scene? HLMLFHGLFLM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ServiceLifetime(Lifetime.Application)]
public interface HCBNAGBEJCI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string, LoadSceneMode> GNMLLFDIMHE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ACLHDDHMMGO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNLLLECPCFL(LoadSceneMode DGDIBHLCNMP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Scene> MHGJBPJCCMC(string BEKFDLHNIFG, LoadSceneMode DGDIBHLCNMP = LoadSceneMode.Single, bool OLOKGIGCHEI = false, [Optional] LHKIACFOHBL<string>.NJLPFCODNGJ EMGBPEKOBGP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LDIAKJGNBHC OFKEIIJLAEG(string BEKFDLHNIFG, LoadSceneMode DGDIBHLCNMP, CancellationToken KNEMOCFJIEK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GMCHJFIODPG([Out] string HHHPAHHKAMD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LDIAKJGNBHC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JLCCDNJJPPJ();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ECHCFABKOME> FPGAEOKKJOM();
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
