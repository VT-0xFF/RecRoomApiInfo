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
		[Cpp2IlInjected.Address(RVA = "0x7956F70", Offset = "0x7955770", VA = "0x187956F70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LHLJCDCNGEI : OGIFKEKKKMB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private INFCLDBDBDF GIHLNMIEHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private PLBGOAOMEFP FFALPIHMHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider DLPNCEFENMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool EKFBLLOBFOA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7956DD0", Offset = "0x79555D0", VA = "0x187956DD0")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	internal static void NBFJIMGACKJ(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E050", Offset = "0x6B3C850", VA = "0x186B3E050")]
	[UnityEngine.Scripting.Preserve]
	public LHLJCDCNGEI([LDAFGEHKDJK(null)] PLBGOAOMEFP MCIFHDIDLCH, [LDAFGEHKDJK(null)] INFCLDBDBDF FMPIAHOHMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7956B50", Offset = "0x7955350", VA = "0x187956B50")]
	private void AJPFDLCACFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7956D50", Offset = "0x7955550", VA = "0x187956D50", Slot = "4")]
	public void HNJIBNOFGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x79565E0", Offset = "0x7954DE0", VA = "0x1879565E0", Slot = "5")]
	public GOANNPAHNKI<Texture2D> AJBHMFFLIJB(CKJDFPHEKDD KEDHOOCMLMA, [Optional] NLDCDOOJMDE KIAKHLGFPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7956BE0", Offset = "0x79553E0", VA = "0x187956BE0")]
	private uint BMBLDDDDCLF(CKJDFPHEKDD KEDHOOCMLMA, NLDCDOOJMDE KIAKHLGFPAF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OGIFKEKKKMB
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNJIBNOFGDF();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GOANNPAHNKI<Texture2D> AJBHMFFLIJB(CKJDFPHEKDD KEDHOOCMLMA, [Optional] NLDCDOOJMDE KIAKHLGFPAF);
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
