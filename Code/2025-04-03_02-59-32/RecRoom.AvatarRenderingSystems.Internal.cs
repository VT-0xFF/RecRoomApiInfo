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
		[Cpp2IlInjected.Address(RVA = "0x76B4FE0", Offset = "0x76B43E0", VA = "0x1876B4FE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KNJDLBKDMJL : ACGNFPAMCFO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private CAOKFFPJANC LBHOCIFDCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private MKEHAOLCFAM LDDIIEECGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider FLBNJJJPFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool LNNNHLFANLN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x76B4730", Offset = "0x76B3B30", VA = "0x1876B4730")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void HDPPCAJLLGN(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68C5660", Offset = "0x68C4A60", VA = "0x1868C5660")]
	[UnityEngine.Scripting.Preserve]
	public KNJDLBKDMJL([CMKKAFOAFJE(null)] MKEHAOLCFAM PKMFECLHKLB, [CMKKAFOAFJE(null)] CAOKFFPJANC EFOJOBOBHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76B46A0", Offset = "0x76B3AA0", VA = "0x1876B46A0")]
	private void FOJBOBNPMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x76B4620", Offset = "0x76B3A20", VA = "0x1876B4620", Slot = "4")]
	public void DNHDIFGBNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x76B49A0", Offset = "0x76B3DA0", VA = "0x1876B49A0", Slot = "5")]
	public HLFDOLJKNKL<Texture2D> IFPHIFDCPIA(DJCHPNOLIOG CMAOBOAFDDE, [Optional] BGAIKOLNNLM MHBNBGGMEBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76B4830", Offset = "0x76B3C30", VA = "0x1876B4830")]
	private uint HMJLGKGCCLE(DJCHPNOLIOG CMAOBOAFDDE, BGAIKOLNNLM MHBNBGGMEBA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ACGNFPAMCFO
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNHDIFGBNAA();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HLFDOLJKNKL<Texture2D> IFPHIFDCPIA(DJCHPNOLIOG CMAOBOAFDDE, [Optional] BGAIKOLNNLM MHBNBGGMEBA);
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
