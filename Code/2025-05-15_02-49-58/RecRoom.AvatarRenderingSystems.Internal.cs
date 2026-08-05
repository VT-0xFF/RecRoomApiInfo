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
		[Cpp2IlInjected.Address(RVA = "0x7A5EED0", Offset = "0x7A5D4D0", VA = "0x187A5EED0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HCALMKHBFLE : IAEEKEIIGFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private JBAGGEAGHKI JPNDENNNCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private HEAKNPJEKDG HICEOICDBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider LOADJOCDOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool INLAHEKHDGL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7A5EAB0", Offset = "0x7A5D0B0", VA = "0x187A5EAB0")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void IIICHJGEEFG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C354A0", Offset = "0x6C33AA0", VA = "0x186C354A0")]
	[UnityEngine.Scripting.Preserve]
	public HCALMKHBFLE([DJIFKCCBBND(null)] HEAKNPJEKDG LAIFMBJMEGH, [DJIFKCCBBND(null)] JBAGGEAGHKI NJAOMGICPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7A5EDA0", Offset = "0x7A5D3A0", VA = "0x187A5EDA0")]
	private void PKKHIIMCEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7A5EBB0", Offset = "0x7A5D1B0", VA = "0x187A5EBB0", Slot = "4")]
	public void OCIFJLNEIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A5E540", Offset = "0x7A5CB40", VA = "0x187A5E540", Slot = "5")]
	public GKHPBLLBAIL<Texture2D> IAHEGBOADHI(NEKJHAOPALN FBHFLHKDNPN, [Optional] NAFFPEBCHPI PMLCGCAHNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A5EC30", Offset = "0x7A5D230", VA = "0x187A5EC30")]
	private uint PEGIKGKDCPK(NEKJHAOPALN FBHFLHKDNPN, NAFFPEBCHPI PMLCGCAHNGK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IAEEKEIIGFG
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCIFJLNEIAN();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GKHPBLLBAIL<Texture2D> IAHEGBOADHI(NEKJHAOPALN FBHFLHKDNPN, [Optional] NAFFPEBCHPI PMLCGCAHNGK);
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
