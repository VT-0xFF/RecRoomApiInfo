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
public interface AKNOFAPAENK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLCBKCOBMAD([Out] Scene? PNBKBOMOJPD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ServiceLifetime(Lifetime.Application)]
public interface PKEPCGPLEKJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string, LoadSceneMode> KNHEDJOBNIP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NCHGAHLJOLO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPANKEDGFPH(LoadSceneMode LHFHKKPOGHI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Scene> ODJGDINEBGP(string DPEHEEBEAND, LoadSceneMode LHFHKKPOGHI = LoadSceneMode.Single, bool PGCPGHCJICA = false, [Optional] LLMBEMAOGHJ<string>.LBCCFMIMELL DOAHNMDENBF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GBPGDBLCPBP GJNEPFIOGJJ(string DPEHEEBEAND, LoadSceneMode LHFHKKPOGHI, CancellationToken FMFKCOIOLLA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GOIALINOBOP([Out] string JHJHELFFMED);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GBPGDBLCPBP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LIMPFFNBKKE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AKNOFAPAENK> OJKPDGHPNHK();
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
