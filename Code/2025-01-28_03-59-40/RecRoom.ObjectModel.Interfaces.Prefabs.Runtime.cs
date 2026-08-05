using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EMPCEPDOBEG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJIEAKDALNL(EHDGIFBGGFC FNDCBDLPGJI, EHICGONPOHJ GOANMAGHDNL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(EHDGIFBGGFC, ComponentTypeList, PKHOHDEPKAM)> OINNEFGLFJD(FGBFMJENEAA DFKGLOMKKEA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void PKHOHDEPKAM(EHDGIFBGGFC FNDCBDLPGJI, EHICGONPOHJ GOANMAGHDNL);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EHICGONPOHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity KPFAGKHHMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager ACAAJNNIMJL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C430", Offset = "0x2B4B630", VA = "0x182B4C430")]
	public EHICGONPOHJ(Entity KPFAGKHHMMH, EntityManager ACAAJNNIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3115120", Offset = "0x3114320", VA = "0x183115120")]
	public void CEJFMFJKFIE<T>(T OMEFCJCOLII) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3115340", Offset = "0x3114540", VA = "0x183115340")]
	public void IEJCKBDEOOP<T>(T OMEFCJCOLII) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7375BF0", Offset = "0x7374DF0", VA = "0x187375BF0")]
	public void JIMBEAADDOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FGBFMJENEAA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(EAOBBGHPEOO, EHDGIFBGGFC)> FFPIDLEPICC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LJDGGNDFKNL : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
	public LJDGGNDFKNL()
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
