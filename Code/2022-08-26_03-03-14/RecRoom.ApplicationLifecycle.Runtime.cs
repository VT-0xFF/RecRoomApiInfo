using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DFMKMHIIOPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CNNOKKJFDMC JLEBOJABNMJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event IMJCKLPBMIK KLCBFOGAMFB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LPIMJABKLLH KFDGJJNCHCL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PABLOOLOGEN DGJMKJBKOHJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PKKJMPPFJCC FPAHLGMDHOC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DEBMHLLJOCE IKCOGJEBFCL;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event MJPFAFJNMHJ JMJCBPDFLOG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IKBGFCOLFOL JMJHGEHGHNB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KBJGGLIKGBA HKMFANEPHEH;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IMJCKLPBMIK();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void LPIMJABKLLH();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PABLOOLOGEN();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void DEBMHLLJOCE();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MJPFAFJNMHJ();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IKBGFCOLFOL();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void PKKJMPPFJCC();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void CNNOKKJFDMC(bool ICGGGOGAJPJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void KBJGGLIKGBA();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x58B0A40", Offset = "0x58AF640", VA = "0x1858B0A40")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x58B0B40", Offset = "0x58AF740", VA = "0x1858B0B40")]
		public static void SafeDestroyGameObject(GameObject MHECAANKLIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PAMKFPHNPPD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool FIIKHPBGFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x58B0C80", Offset = "0x58AF880", VA = "0x1858B0C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x58B0D00", Offset = "0x58AF900", VA = "0x1858B0D00")]
	[NMEEOODADNP(NIEOHKLALIA.Unity_AfterSceneLoad)]
	private static void NEDKCOBOAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x58B0CC0", Offset = "0x58AF8C0", VA = "0x1858B0CC0")]
	internal static void LBGKGHPKNNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NOBPHNBDPPI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BILGEFJKJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> BCMLGDJCODK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(NOBPHNBDPPI OOPFMJCLBFN);
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
