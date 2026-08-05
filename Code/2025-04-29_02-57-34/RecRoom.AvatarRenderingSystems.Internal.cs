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
		[Cpp2IlInjected.Address(RVA = "0x7929880", Offset = "0x7928C80", VA = "0x187929880", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FLBFKPGPHGG : ABMDHCIHMHM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private ANCPLCIOCFN CBLFHNNMIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NMOOECPHCFK HNCOCLNFJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider JGPDDEAPICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool IPHKKJNBPKG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x79290C0", Offset = "0x79284C0", VA = "0x1879290C0")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	internal static void EDMJPONJHMF(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B081D0", Offset = "0x6B075D0", VA = "0x186B081D0")]
	[UnityEngine.Scripting.Preserve]
	public FLBFKPGPHGG([MGCCDFKFGBG(null)] NMOOECPHCFK GNPJKGCKLHN, [MGCCDFKFGBG(null)] ANCPLCIOCFN LAGALIFKCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7928EC0", Offset = "0x79282C0", VA = "0x187928EC0")]
	private void BOPFGFHANMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x79291C0", Offset = "0x79285C0", VA = "0x1879291C0", Slot = "4")]
	public void MPKEHNIBNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7929240", Offset = "0x7928640", VA = "0x187929240", Slot = "5")]
	public PKCCCOBBKFK<Texture2D> PPDOIKDMBIK(GKNIOEJCNCI FAACDEPHFJE, [Optional] KIDHHIPBIAG OPJDOLNIGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7928F50", Offset = "0x7928350", VA = "0x187928F50")]
	private uint BPCGNGBLMIB(GKNIOEJCNCI FAACDEPHFJE, KIDHHIPBIAG OPJDOLNIGOE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ABMDHCIHMHM
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPKEHNIBNPF();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PKCCCOBBKFK<Texture2D> PPDOIKDMBIK(GKNIOEJCNCI FAACDEPHFJE, [Optional] KIDHHIPBIAG OPJDOLNIGOE);
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
