using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GKBOCCBICLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BIBDIMLNGKH DIFIEDHBEBD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event CDEFBPCMMFM BLLHJLKIHHA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ADJCHABKNJC DMGJJDONCMM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BHBBKOLNEMO OGDIHOCCFFJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PIHDFHHLEAF CBNNCLBJDFM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JNGIDODJEMI MLNJELCGJJB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event EFFHICOMAIC PPCFGGFHHOD;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event AEPLOPBKCIA IOLHFPIHHEL;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void CDEFBPCMMFM();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void ADJCHABKNJC();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void BHBBKOLNEMO();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JNGIDODJEMI();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EFFHICOMAIC();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PIHDFHHLEAF();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void BIBDIMLNGKH(bool NBGAIJMICFI);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void AEPLOPBKCIA();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x51F31D0", Offset = "0x51F23D0", VA = "0x1851F31D0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x51F32D0", Offset = "0x51F24D0", VA = "0x1851F32D0")]
		public static void SafeDestroyGameObject(GameObject BCGNPHHHPEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDD9CF0", Offset = "0xDD8EF0", VA = "0x180DD9CF0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NJEEKLHMDEF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool IBEPMKIAKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x51F3450", Offset = "0x51F2650", VA = "0x1851F3450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x51F3490", Offset = "0x51F2690", VA = "0x1851F3490")]
	[OFEHMNLHHIP(LIDFJGFJDHH.Unity_AfterSceneLoad)]
	private static void INKIGOFOFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x51F3410", Offset = "0x51F2610", VA = "0x1851F3410")]
	internal static void BLIMEDBNJLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LJIKGKNACCB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KECLCPEEANJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<bool> BEGCILNBOJB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(LJIKGKNACCB OICGCBNPBMA);
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
