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
		[Cpp2IlInjected.Address(RVA = "0x7BC7680", Offset = "0x7BC6480", VA = "0x187BC7680", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NJKEBOKIHKP : CJAMNLPGAIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NOMGFLACJAJ KHMBKFINFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CNLDFKCLFLK GBOMAHDIBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider HICCAOLCDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool HBOGFMBJOAD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6DD0", Offset = "0x7BC5BD0", VA = "0x187BC6DD0")]
	[ENKLKENGHAE.AANPNKKBMFF.ENPJKGAFAPD]
	internal static void IDDOKBJHCPH(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D82510", Offset = "0x6D81310", VA = "0x186D82510")]
	[UnityEngine.Scripting.Preserve]
	public NJKEBOKIHKP([LCNEJNNIOGA(null)] CNLDFKCLFLK ECKKMJNOGEM, [LCNEJNNIOGA(null)] NOMGFLACJAJ PMIAOMLIHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6CC0", Offset = "0x7BC5AC0", VA = "0x187BC6CC0")]
	private void BMMMJFJBMPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6D50", Offset = "0x7BC5B50", VA = "0x187BC6D50", Slot = "4")]
	public void EIAJADOCKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6ED0", Offset = "0x7BC5CD0", VA = "0x187BC6ED0", Slot = "5")]
	public EHIFMMNJMNN<Texture2D> MGPKLFNCJHL(ENEIBBPOIAJ NFKPLLMBIOK, [Optional] MNCBCAJDKJB CNCKIIIBBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7460", Offset = "0x7BC6260", VA = "0x187BC7460")]
	private uint POIAAALPDLD(ENEIBBPOIAJ NFKPLLMBIOK, MNCBCAJDKJB CNCKIIIBBGO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CJAMNLPGAIA
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIAJADOCKIJ();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHIFMMNJMNN<Texture2D> MGPKLFNCJHL(ENEIBBPOIAJ NFKPLLMBIOK, [Optional] MNCBCAJDKJB CNCKIIIBBGO);
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
