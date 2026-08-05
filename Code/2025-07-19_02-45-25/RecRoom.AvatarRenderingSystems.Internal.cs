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
		[Cpp2IlInjected.Address(RVA = "0x7F8BCF0", Offset = "0x7F8ACF0", VA = "0x187F8BCF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OEHDIDFONLM : IFEKOOPLJPJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private JCHDDGGHLLC FEHMIIEDFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NNBHCKAIOLB DAGIDBFKNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider IMFFBNMAPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool ELGBPIJDJIK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B3B0", Offset = "0x7F8A3B0", VA = "0x187F8B3B0")]
	[GOMLKAICHII.NIENCEEHOCF.GHHMJPKJCIP]
	internal static void EPDNEJGNLEO(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x70EB710", Offset = "0x70EA710", VA = "0x1870EB710")]
	[UnityEngine.Scripting.Preserve]
	public OEHDIDFONLM([KELEGLJPNHI(null)] NNBHCKAIOLB FJHJDHBIADB, [KELEGLJPNHI(null)] JCHDDGGHLLC ENKHHACCDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BBB0", Offset = "0x7F8ABB0", VA = "0x187F8BBB0")]
	private void PCEBLKAFMIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B330", Offset = "0x7F8A330", VA = "0x187F8B330", Slot = "4")]
	public void BCDGGODMHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B620", Offset = "0x7F8A620", VA = "0x187F8B620", Slot = "5")]
	public PHNCGCCJBCF<Texture2D> IFCAOIJPGCH(JIEDBCKBNMB MAKNEKEIMPI, [Optional] FABAOFAOADM OGEALFKCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B4B0", Offset = "0x7F8A4B0", VA = "0x187F8B4B0")]
	private uint IBLBJBNKBGM(JIEDBCKBNMB MAKNEKEIMPI, FABAOFAOADM OGEALFKCCAP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IFEKOOPLJPJ
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCDGGODMHGF();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PHNCGCCJBCF<Texture2D> IFCAOIJPGCH(JIEDBCKBNMB MAKNEKEIMPI, [Optional] FABAOFAOADM OGEALFKCCAP);
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
