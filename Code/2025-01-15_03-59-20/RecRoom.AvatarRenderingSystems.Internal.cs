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
		[Cpp2IlInjected.Address(RVA = "0x6E458E0", Offset = "0x6E44CE0", VA = "0x186E458E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MFGIDOCDPEC : MPGKKAFOEHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private FHDKBPLPNAH CPHFABAAKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OHIBLGFBNDM KDOBPCAFPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider PAOAEIDOCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool AIJNEPHAKLO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E456C0", Offset = "0x6E44AC0", VA = "0x186E456C0")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void IPMBADGOCPB(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6139DB0", Offset = "0x61391B0", VA = "0x186139DB0")]
	[UnityEngine.Scripting.Preserve]
	public MFGIDOCDPEC([CNGCCDLPGOD(null)] OHIBLGFBNDM PCEDPHKHKKD, [CNGCCDLPGOD(null)] FHDKBPLPNAH IDFGIFHDAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E457B0", Offset = "0x6E44BB0", VA = "0x186E457B0")]
	private void LKFPJPPHCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E454D0", Offset = "0x6E448D0", VA = "0x186E454D0", Slot = "4")]
	public void DBCNOMCEKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E44F60", Offset = "0x6E44360", VA = "0x186E44F60", Slot = "5")]
	public PLBFKJMGACI<Texture2D> AABIDMNNKMD(CIEFFCCPBAN BNGOHAFPBOK, [Optional] LDNADNDABII OKAMEPDCJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E45550", Offset = "0x6E44950", VA = "0x186E45550")]
	private uint GDBLGJKOKIA(CIEFFCCPBAN BNGOHAFPBOK, LDNADNDABII OKAMEPDCJCI)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MPGKKAFOEHK
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBCNOMCEKMH();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PLBFKJMGACI<Texture2D> AABIDMNNKMD(CIEFFCCPBAN BNGOHAFPBOK, [Optional] LDNADNDABII OKAMEPDCJCI);
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
