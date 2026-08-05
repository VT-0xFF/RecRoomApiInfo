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
public interface GFLMKCMBFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODINLCAENP([Out] Scene? DDICLPMKHNP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ServiceLifetime(Lifetime.Application)]
public interface AHEOMIBFHKH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string, LoadSceneMode> ALPLDDJCIKM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PGLFAKAEOKK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCNIPGLMLHM(LoadSceneMode LHFDCOKPDDP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Scene> FMAFDEIPNLH(string KFEKBOLMGJM, LoadSceneMode LHFDCOKPDDP = LoadSceneMode.Single, bool LPEBBANBBFG = false, [Optional] BGHCJGPGCNF<string>.IPAINGKGFDM AGKKDFBHOHO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PMNACDPOEAJ PDEJHEHLMEB(string KFEKBOLMGJM, LoadSceneMode LHFDCOKPDDP, CancellationToken CDMFGCJPANH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KBIBPHNKPBA([Out] string GLDNIGIAOIB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PMNACDPOEAJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HIGGMAFONHE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GFLMKCMBFNN> CMNHAKKLOJD();
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
