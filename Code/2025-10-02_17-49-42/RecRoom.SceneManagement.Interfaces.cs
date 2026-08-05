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
public interface NAOLNCNMNOH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGODDBFNADP([Out] Scene? CFOJADJKDLM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ServiceLifetime(Lifetime.Application)]
public interface PJFNAIEGFFD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string, LoadSceneMode> EEEJMKMIMDB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NPKEHKICBDG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBNCKMCADBA(LoadSceneMode JFHIEBMGOBN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Scene> JODLEKMKBAG(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN = LoadSceneMode.Single, bool PGKONOJOANP = false, [Optional] OEEGBKAOPAE<string>.BANCHJBJHFK AKKOFJNCLAO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EAOBOKAGIGN NJHNGAKCAPG(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN, CancellationToken ICODIHINNBH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PDDEDIJDOBN([Out] string KODBAFKNPFG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EAOBOKAGIGN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ILDMBLJKEID();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NAOLNCNMNOH> JCJEKAAIKKC();
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
