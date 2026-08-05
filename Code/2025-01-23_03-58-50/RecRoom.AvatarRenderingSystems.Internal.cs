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
		[Cpp2IlInjected.Address(RVA = "0x6D99350", Offset = "0x6D97B50", VA = "0x186D99350", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CEHMFJJJKHI : JEKDBAMDHDH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private PMMNDJCDLIJ MENPDPHOBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private JBGKCNNBNKB AECOJGCKJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider IGFLDNIMHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool KKMIPFCDMEP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D99040", Offset = "0x6D97840", VA = "0x186D99040")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void GOKKBLJBDFN(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x607C8B0", Offset = "0x607B0B0", VA = "0x18607C8B0")]
	[UnityEngine.Scripting.Preserve]
	public CEHMFJJJKHI([NDCFMLCHJCI(null)] JBGKCNNBNKB PDAGIGFFIOB, [NDCFMLCHJCI(null)] PMMNDJCDLIJ EAJGDFFGPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D98F30", Offset = "0x6D97730", VA = "0x186D98F30")]
	private void DFFMJJLIMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D98FC0", Offset = "0x6D977C0", VA = "0x186D98FC0", Slot = "4")]
	public void DGGAAMICLNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D989B0", Offset = "0x6D971B0", VA = "0x186D989B0", Slot = "5")]
	public MGNFCCKNAGM<Texture2D> DAKDBGAPCAK(MHBANOEOHEP MMGGEOOMDLK, [Optional] AHGGHFEHEPP OFGFBCNFINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D99130", Offset = "0x6D97930", VA = "0x186D99130")]
	private uint HOEJMPBDKPA(MHBANOEOHEP MMGGEOOMDLK, AHGGHFEHEPP OFGFBCNFINC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JEKDBAMDHDH
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGGAAMICLNM();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MGNFCCKNAGM<Texture2D> DAKDBGAPCAK(MHBANOEOHEP MMGGEOOMDLK, [Optional] AHGGHFEHEPP OFGFBCNFINC);
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
