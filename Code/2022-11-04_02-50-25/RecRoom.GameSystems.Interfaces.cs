using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IDIFJJMOKNE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HJIILGMIMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2A521B802A5200", Offset = "0x0", VA = "0x2A521D002A5200", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HAJDJKBCKCJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KHEGIJPIFIC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A5263802A525A", Offset = "0x0", VA = "0x2A5265002A525A", Slot = "2")]
	bool FEFNCLGAFJN(GJFIKDCMIDE KMJKACJIMCF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A526E8764BF64", Offset = "0x0", VA = "0x2A52700764BF64", Slot = "3")]
	void LEBJLOIMIPN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EDABJDHJNNI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MLDCCIIENDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7507AF2802A52D1", Offset = "0x0", VA = "0x7507AF4002A52D1", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KGGFIFMGOHC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A53A6802A52E0", Offset = "0x0", VA = "0x2A53A8002A52E0", Slot = "0")]
	IDisposable Play(MONENFNKOHC NCIGGMOGJCP, string MHEIMALMFNH, float BIOAJJBMPPP, [Optional] Action EGLKIOCIBPB, [Optional] object EFFGEMIKKND);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A53AE87508320", Offset = "0x0", VA = "0x2A53B007508320", Slot = "1")]
	IDisposable Play(MONENFNKOHC NCIGGMOGJCP, float KAPEJGKHDFL, GDPBEIKMDEA OEPFLDMLFCH, string MHEIMALMFNH, Color? MJLFJIPMOHM, string OCLBPKFPDGL, Color? NIFAFKOJFNB, float BIOAJJBMPPP, [Optional] Action EGLKIOCIBPB, [Optional] object EFFGEMIKKND);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MJMAFMCEMBF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x750831E802A5479", Offset = "0x0", VA = "0x7508320002A5479", Slot = "0")]
	void OFHBGOEKGAN(NDKLHPOCFKB IALLIBEMNLL, List<KeepsakeInstanceDTO> MFFDHEPPNOD);
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
