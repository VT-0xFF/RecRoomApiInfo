using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IAKPENOAKGL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBDPOBMMGJP(FHHKGBHDBDG GEFIJDDLJAH, OKHNDDOCAAL KDGODPPMJPE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(FHHKGBHDBDG, ComponentTypeList, DGDGLOCLMDO)> CIFIALNFEPJ(NAFGDCGOLKF AEDBHHDIHNI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void DGDGLOCLMDO(FHHKGBHDBDG GEFIJDDLJAH, OKHNDDOCAAL KDGODPPMJPE);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OKHNDDOCAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity NFFCGLFHPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager LMKGBBMBMBN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23B0040", Offset = "0x23AF240", VA = "0x1823B0040")]
	public OKHNDDOCAAL(Entity NFFCGLFHPNG, EntityManager LMKGBBMBMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AF10", Offset = "0x2A4A110", VA = "0x182A4AF10")]
	public void BHMONLIGLCO<T>(T NICEPFIEJED) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B130", Offset = "0x2A4A330", VA = "0x182A4B130")]
	public void DLAEDEBBMBB<T>(T NICEPFIEJED) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62C1AE0", Offset = "0x62C0CE0", VA = "0x1862C1AE0")]
	public void NKNGGNGCBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NAFGDCGOLKF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(OONAHILDADH, FHHKGBHDBDG)> LDBJBHNIINH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class JKKDODHHLBP : NDNLFDIDCML
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4110", Offset = "0x7C3310", VA = "0x1807C4110")]
	public JKKDODHHLBP()
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
