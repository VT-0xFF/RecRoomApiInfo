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
		[Cpp2IlInjected.Address(RVA = "0x7BF1BD0", Offset = "0x7BF07D0", VA = "0x187BF1BD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OILEJJEPPKN : AKIIHKHIKPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private ODIJJKIPCKH ABJIFBJAGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private BGBIMECKFEN HEEHFLDHOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider LNEEMEMAIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool IIPMKDBFOJL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1830", Offset = "0x7BF0430", VA = "0x187BF1830")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void FCOHHCDLJHN(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A440", Offset = "0x6D89040", VA = "0x186D8A440")]
	[UnityEngine.Scripting.Preserve]
	public OILEJJEPPKN([GFNPNOLPMKK(null)] BGBIMECKFEN OKJHDPLFJEK, [GFNPNOLPMKK(null)] ODIJJKIPCKH CIMIILNFJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1AA0", Offset = "0x7BF06A0", VA = "0x187BF1AA0")]
	private void OJFIHMLAEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1240", Offset = "0x7BEFE40", VA = "0x187BF1240", Slot = "4")]
	public void BIOHKLDDAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BF12C0", Offset = "0x7BEFEC0", VA = "0x187BF12C0", Slot = "5")]
	public PHKGFEHMLBA<Texture2D> CMPBKCMEPEA(NFKAFHJLIGP HKEHHGCGFCF, [Optional] AKKOOIDKLNO GALEDNLDGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1930", Offset = "0x7BF0530", VA = "0x187BF1930")]
	private uint KFFBHCJKNAJ(NFKAFHJLIGP HKEHHGCGFCF, AKKOOIDKLNO GALEDNLDGCG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AKIIHKHIKPA
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIOHKLDDAKP();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PHKGFEHMLBA<Texture2D> CMPBKCMEPEA(NFKAFHJLIGP HKEHHGCGFCF, [Optional] AKKOOIDKLNO GALEDNLDGCG);
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
