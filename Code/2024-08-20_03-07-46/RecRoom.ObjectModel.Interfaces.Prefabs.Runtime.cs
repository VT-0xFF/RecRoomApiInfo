using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HOCOOOIFCED
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPAPLPDOEEA(NCCOBPNELMJ LFOOJAPBKNN, OOPLCNKADPI OKOMPAGDCIF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(NCCOBPNELMJ, ComponentTypeList, POGINNDLKFG)> LCNLMKLEEMJ(DJDDFOCGEFA MJMFFAOKGMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void POGINNDLKFG(NCCOBPNELMJ LFOOJAPBKNN, OOPLCNKADPI OKOMPAGDCIF);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OOPLCNKADPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity BOENFECPGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager OOHOEBAONBK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25C1970", Offset = "0x25C0970", VA = "0x1825C1970")]
	public OOPLCNKADPI(Entity BOENFECPGGB, EntityManager OOHOEBAONBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D64FC0", Offset = "0x2D63FC0", VA = "0x182D64FC0")]
	public void HACKMLKKHNE<T>(T JJCEIJMGOAB) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2D651E0", Offset = "0x2D641E0", VA = "0x182D651E0")]
	public void IHOMFGOLDLP<T>(T JJCEIJMGOAB) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A69050", Offset = "0x6A68050", VA = "0x186A69050")]
	public void EOIGGNDBCJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DJDDFOCGEFA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(CBPMDLJFIEM, NCCOBPNELMJ)> DNNGEEFJEDD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class KKJCGJIHOOH : DFFPGBKEHKH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2B30", VA = "0x1815C3B30")]
	public KKJCGJIHOOH()
	{
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
