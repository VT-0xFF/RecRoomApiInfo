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
		[Cpp2IlInjected.Address(RVA = "0x70C6700", Offset = "0x70C5500", VA = "0x1870C6700", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OKCHKIGBDNC : JBBHIELOMIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NCMBOMIDNHI NEBHFOOIPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CEFBMPGBCKC EJJIPPIBJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider HJJKJLNNMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool BMMBPKGMHHK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70C6360", Offset = "0x70C5160", VA = "0x1870C6360")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void DIFEJPOBKHM(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x639A170", Offset = "0x6398F70", VA = "0x18639A170")]
	[UnityEngine.Scripting.Preserve]
	public OKCHKIGBDNC([MHFJPMCEEAM(null)] CEFBMPGBCKC LOFJHKDFNLA, [MHFJPMCEEAM(null)] NCMBOMIDNHI CGOKNOBFDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x70C6450", Offset = "0x70C5250", VA = "0x1870C6450")]
	private void FOIDDJMLDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x70C62E0", Offset = "0x70C50E0", VA = "0x1870C62E0", Slot = "4")]
	public void BDHPACOGOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70C5D60", Offset = "0x70C4B60", VA = "0x1870C5D60", Slot = "5")]
	public MEPEJIIMKOI<Texture2D> AJCKBLBHEGF(MNKIDGEDDMP JBHFBMFIHME, [Optional] KKKMJGNFFIF KODPGCABALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70C64E0", Offset = "0x70C52E0", VA = "0x1870C64E0")]
	private uint JINDKEAMKKI(MNKIDGEDDMP JBHFBMFIHME, KKKMJGNFFIF KODPGCABALO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JBBHIELOMIP
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDHPACOGOEJ();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEPEJIIMKOI<Texture2D> AJCKBLBHEGF(MNKIDGEDDMP JBHFBMFIHME, [Optional] KKKMJGNFFIF KODPGCABALO);
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
