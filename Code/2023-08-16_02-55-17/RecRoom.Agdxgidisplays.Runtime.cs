using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DMBLHFLFFMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum KIDMCMGNBEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MOCPENKAGIP(IntPtr DMFMJBFFPPI, int JPJMMBFGIEG, int ILLPOFHPCFE);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MAKBIJPBGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F809D0", Offset = "0x6F7FBD0", VA = "0x186F809D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F80CD0", Offset = "0x6F7FED0", VA = "0x186F80CD0")]
	private static extern void KPOKDIIJHBM(MOCPENKAGIP JHGMNDBGFFP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F80AB0", Offset = "0x6F7FCB0", VA = "0x186F80AB0")]
	[MonoPInvokeCallback(typeof(MOCPENKAGIP))]
	private static void DBLBLMJGDDH(IntPtr DMFMJBFFPPI, int JPJMMBFGIEG, int ILLPOFHPCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F80C60", Offset = "0x6F7FE60", VA = "0x186F80C60")]
	private static extern void KCEHONPEIFO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F80A40", Offset = "0x6F7FC40", VA = "0x186F80A40")]
	private static extern void CGDJIOIJABH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F809D0", Offset = "0x6F7FBD0", VA = "0x186F809D0")]
	private static extern int BBAKCMPBBEI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F80BE0", Offset = "0x6F7FDE0", VA = "0x186F80BE0")]
	private static extern int HDIGMEMNCFO(int CJNGPAPKKID);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F80DE0", Offset = "0x6F7FFE0", VA = "0x186F80DE0")]
	private static extern int PAGPJLOFHIN(int CJNGPAPKKID);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F80D60", Offset = "0x6F7FF60", VA = "0x186F80D60")]
	private static extern int ONNIFNHKLMK(int CJNGPAPKKID);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F80750", Offset = "0x6F7F950", VA = "0x186F80750")]
	private static extern int AAGDPPFKFGE(int CJNGPAPKKID);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F80E60", Offset = "0x6F80060", VA = "0x186F80E60")]
	public DMBLHFLFFMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F80A40", Offset = "0x6F7FC40", VA = "0x186F80A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F807D0", Offset = "0x6F7F9D0", VA = "0x186F807D0")]
	public Rect AKIMFHKOPOF(int JLHNJFKEDBE)
	{
		return default(Rect);
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
