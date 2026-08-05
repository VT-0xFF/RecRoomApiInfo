using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x764AE70", Offset = "0x764A270", VA = "0x18764AE70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DFDOLHIFELK : PFBLNDEPFKG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private CMHCKHHEDBK IGOEDGCDCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private GCELNKFLECM ICBEGBJOBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider MKFJEENINPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool HMNABFCOFHI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x764AC50", Offset = "0x764A050", VA = "0x18764AC50")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	internal static void JPJMIENCOHM(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6879710", Offset = "0x6878B10", VA = "0x186879710")]
	[UnityEngine.Scripting.Preserve]
	public DFDOLHIFELK([GKAMHFFOHNI(null)] GCELNKFLECM LAJEGIAELAD, [GKAMHFFOHNI(null)] CMHCKHHEDBK IJMLLAMDIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x764AA50", Offset = "0x7649E50", VA = "0x18764AA50")]
	private void ILHJKPBDGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x764AD50", Offset = "0x764A150", VA = "0x18764AD50", Slot = "4")]
	public void NIAALKAADHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x764A4E0", Offset = "0x76498E0", VA = "0x18764A4E0", Slot = "5")]
	public FHGKGMPNNBH<Texture2D> GODJJMDJNLF(GGNKMEABKGD NOLCKHPGHEI, [Optional] HDGGCAEIEHM NFHKMOGHIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x764AAE0", Offset = "0x7649EE0", VA = "0x18764AAE0")]
	private uint JDIJBPFGBMN(GGNKMEABKGD NOLCKHPGHEI, HDGGCAEIEHM NFHKMOGHIBC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PFBLNDEPFKG
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIAALKAADHC();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHGKGMPNNBH<Texture2D> GODJJMDJNLF(GGNKMEABKGD NOLCKHPGHEI, [Optional] HDGGCAEIEHM NFHKMOGHIBC);
}
namespace Cpp2IlInjected
{
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
}
