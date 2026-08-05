using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EPLDJOOJJDC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KDOADDENEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75DC4F6802A3436", Offset = "0x0", VA = "0x75DC4F8002A3436", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CHOIOHHGLAC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BGFMLKAACML;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75DC37A802A34AE", Offset = "0x0", VA = "0x75DC37C002A34AE", Slot = "2")]
	bool JMGIOIFHJCD(EMCPEAEPHOP GKIBGBMBMLC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A34F9802A34B0", Offset = "0x0", VA = "0x2A34FB002A34B0", Slot = "3")]
	void DADCONOFGEF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FIGAMFLKCCP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DAAOOPIPGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A34FE875DC37C", Offset = "0x0", VA = "0x2A3500075DC37C", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LFLICGCJOBI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75DC4F6802A3586", Offset = "0x0", VA = "0x75DC4F8002A3586", Slot = "0")]
	IDisposable Play(IINGONEGNDA JKFDEJHDOHC, string NBBOKIMEDEF, float FNJNHCECBOJ, [Optional] Action JGLIBPMCCNL, [Optional] object EALELPHJCKK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A362C802A3590", Offset = "0x0", VA = "0x2A362E002A3590", Slot = "1")]
	IDisposable Play(IINGONEGNDA JKFDEJHDOHC, float HNJKIGGOAFN, PLIKDLPLDIN CDJMECAFNDD, string NBBOKIMEDEF, Color? COHKGCJCFBM, string JIKMCAFPKLC, Color? KCMABHDBCEF, float FNJNHCECBOJ, [Optional] Action JGLIBPMCCNL, [Optional] object EALELPHJCKK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JMOEENOGAGB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A362E875DC4F8", Offset = "0x0", VA = "0x2A3630075DC4F8", Slot = "0")]
	void MEPILFDFNHE(HNMNGPNPECE IGGGBNHKMFN, List<KeepsakeInstanceDTO> EOPEDNJNJGM);
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
