using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GCJBLFPNLMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NGPHKKEFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2A439D8772F130", Offset = "0x0", VA = "0x2A439F0772F130", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IKOPDLJHMDJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BPGLOHOAFLE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A43DB8772F130", Offset = "0x0", VA = "0x2A43DD0772F130", Slot = "2")]
	bool CKAMLMGHDMF(GCIMEABKOPP JBAONCAFHPL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x772F13E802A43E3", Offset = "0x0", VA = "0x772F140002A43E3", Slot = "3")]
	void HICKKBHHCEH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FPJKCIJBMIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JAGOCKEBIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A4472802A43F0", Offset = "0x0", VA = "0x2A4474002A43F0", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PMPKABCKPGL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A447E875E1580", Offset = "0x0", VA = "0x2A4480075E1580", Slot = "0")]
	IDisposable Play(GNMHKLALLBD IJEGEENBOEA, string PFJJGOBKGFL, float OLGHJNFBDFD, [Optional] Action ONHFNOPIIKL, [Optional] object LOJDNDLGCPH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x772F0AA802A45BF", Offset = "0x0", VA = "0x772F0AC002A45BF", Slot = "1")]
	IDisposable Play(GNMHKLALLBD IJEGEENBOEA, float AAOLMNBMGIF, KCPENGMEKHP CKPLBCEGNGK, string PFJJGOBKGFL, Color? EEENMEMAEBP, string NOBPCOLCKLE, Color? CJPIACDPEPJ, float OLGHJNFBDFD, [Optional] Action ONHFNOPIIKL, [Optional] object LOJDNDLGCPH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DKAALNKMDPM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A46FD802A45C0", Offset = "0x0", VA = "0x2A46FF002A45C0", Slot = "0")]
	void AIECJFHNPPI(CIFBNNGALCD MMDGBAGPDDA, List<KeepsakeInstanceDTO> NGPKGEFFHIE);
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
