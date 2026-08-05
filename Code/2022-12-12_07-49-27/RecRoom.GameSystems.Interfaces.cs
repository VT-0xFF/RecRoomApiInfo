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
		[Cpp2IlInjected.Address(RVA = "0x75DE7AA802B92F1", Offset = "0x0", VA = "0x75DE7AC002B92F1", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IKOPDLJHMDJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BPGLOHOAFLE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x761C386802B940D", Offset = "0x0", VA = "0x761C388002B940D", Slot = "2")]
	bool CKAMLMGHDMF(GCIMEABKOPP JBAONCAFHPL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B9440802B9410", Offset = "0x0", VA = "0x2B9442002B9410", Slot = "3")]
	void HICKKBHHCEH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FPJKCIJBMIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JAGOCKEBIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B944E875DE7AC", Offset = "0x0", VA = "0x2B9450075DE7AC", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PMPKABCKPGL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75DFEA6802B94C9", Offset = "0x0", VA = "0x75DFEA8002B94C9", Slot = "0")]
	IDisposable Play(GNMHKLALLBD IJEGEENBOEA, string PFJJGOBKGFL, float OLGHJNFBDFD, [Optional] Action ONHFNOPIIKL, [Optional] object LOJDNDLGCPH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B950F802B94D0", Offset = "0x0", VA = "0x2B9511002B94D0", Slot = "1")]
	IDisposable Play(GNMHKLALLBD IJEGEENBOEA, float AAOLMNBMGIF, KCPENGMEKHP CKPLBCEGNGK, string PFJJGOBKGFL, Color? EEENMEMAEBP, string NOBPCOLCKLE, Color? CJPIACDPEPJ, float OLGHJNFBDFD, [Optional] Action ONHFNOPIIKL, [Optional] object LOJDNDLGCPH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DKAALNKMDPM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B951E875DF84C", Offset = "0x0", VA = "0x2B9520075DF84C", Slot = "0")]
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
