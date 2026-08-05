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
		[Cpp2IlInjected.Address(RVA = "0x7DCD5C0", Offset = "0x7DCBDC0", VA = "0x187DCD5C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MKGMBCOJDIN : NEBMDAECEKB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private GLNMBJMDEPI MELBEPABBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private AGKENCJENIJ EPLICDIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider NEKJNPAFKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool NEFGIMNFAEJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD430", Offset = "0x7DCBC30", VA = "0x187DCD430")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	internal static void NOFOGNDLKLM(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F97990", Offset = "0x6F96190", VA = "0x186F97990")]
	[UnityEngine.Scripting.Preserve]
	public MKGMBCOJDIN([FAPODKMFODF(null)] AGKENCJENIJ IADJPOODAKJ, [FAPODKMFODF(null)] GLNMBJMDEPI EHLHGBKANLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCC40", Offset = "0x7DCB440", VA = "0x187DCCC40")]
	private void ELBAMFKKKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCCD0", Offset = "0x7DCB4D0", VA = "0x187DCCCD0", Slot = "4")]
	public void JPHPIDHNMKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCEC0", Offset = "0x7DCB6C0", VA = "0x187DCCEC0", Slot = "5")]
	public OBKOLGEFKBC<Texture2D> LCDKIEOHBCA(MEPPJFCAKFJ EIIBJBICIAK, [Optional] FOIPDPBDMCD JCPNJLMMOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCD50", Offset = "0x7DCB550", VA = "0x187DCCD50")]
	private uint KPOGKFICPFL(MEPPJFCAKFJ EIIBJBICIAK, FOIPDPBDMCD JCPNJLMMOLN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NEBMDAECEKB
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPHPIDHNMKP();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBKOLGEFKBC<Texture2D> LCDKIEOHBCA(MEPPJFCAKFJ EIIBJBICIAK, [Optional] FOIPDPBDMCD JCPNJLMMOLN);
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
