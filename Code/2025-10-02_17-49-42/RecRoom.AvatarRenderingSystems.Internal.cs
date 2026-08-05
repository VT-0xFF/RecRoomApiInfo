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
		[Cpp2IlInjected.Address(RVA = "0x83071D0", Offset = "0x8305BD0", VA = "0x1883071D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OCOBKNHOLGB : CHKEHNMJNLA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private EMNHMFAFJOP BMFADOHBMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CBJAOFNNIOB KICCNPDPJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider MKHGFDFFKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool MDJGPDAKFFD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x83068B0", Offset = "0x83052B0", VA = "0x1883068B0")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	internal static void BLOFFOENOGO(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x254D6A0", Offset = "0x254C0A0", VA = "0x18254D6A0")]
	[UnityEngine.Scripting.Preserve]
	public OCOBKNHOLGB([BMCONCJPCIA(null)] CBJAOFNNIOB EMHCGOGBKFA, [BMCONCJPCIA(null)] EMNHMFAFJOP DELKNNMMNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83069A0", Offset = "0x83053A0", VA = "0x1883069A0")]
	private void CHAGPJLDJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8306830", Offset = "0x8305230", VA = "0x188306830", Slot = "4")]
	public void AOKAEHPBAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8306A30", Offset = "0x8305430", VA = "0x188306A30", Slot = "5")]
	public AACADPLMCLK<Texture2D> COBKBPPIBOI(ADJAHFDAOOH ABPKGCNICIE, [Optional] JLDDJMHEPLP PDCLAJMPOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8306FB0", Offset = "0x83059B0", VA = "0x188306FB0")]
	private uint PLJNFHJKCFE(ADJAHFDAOOH ABPKGCNICIE, JLDDJMHEPLP PDCLAJMPOEB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CHKEHNMJNLA
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOKAEHPBAOF();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AACADPLMCLK<Texture2D> COBKBPPIBOI(ADJAHFDAOOH ABPKGCNICIE, [Optional] JLDDJMHEPLP PDCLAJMPOEB);
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
