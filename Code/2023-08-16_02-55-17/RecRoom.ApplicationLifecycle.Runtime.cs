using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AJHJKPAPENO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread HMJKHONMKNA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool JCGOIEONGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F77190", Offset = "0x6F76390", VA = "0x186F77190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F771E0", Offset = "0x6F763E0", VA = "0x186F771E0")]
	[MCHKNLLMMBN(LDMPMPAPAMM.Unity_AfterSceneLoad)]
	private static void BPLMCGEOOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LKOHEOLCKMJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> JNAJKECBCIB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(LKOHEOLCKMJ ALFFGAALODJ);
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F77230", Offset = "0x6F76430", VA = "0x186F77230")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F77320", Offset = "0x6F76520", VA = "0x186F77320")]
		public static void SafeDestroyGameObject(GameObject HAAGKPEGEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CBJHBNEDHJP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool HHMNNDBNDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F774E0", Offset = "0x6F766E0", VA = "0x186F774E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F77420", Offset = "0x6F76620", VA = "0x186F77420")]
	[MCHKNLLMMBN(LDMPMPAPAMM.Unity_AfterSceneLoad)]
	private static void KCEHONPEIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F773E0", Offset = "0x6F765E0", VA = "0x186F773E0")]
	internal static void EMNOIEBAPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CMEIMDNBBNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DGDKDGLALGI MINMLKKMNKI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EMDJIFLHMHE KGILAIAHHCE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HGOGPOEBHBL LBFNILJHKNK;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CHPDKJLBDLF PKDIGHCDKKE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event MPLLHLHBAGH MEFBHDGKBDA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KKDMPEMBIHB PMMALJGHDGI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EAAICPIGACD GEBCILCGOMK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HAGMCAJCDEJ IACKMEKIPFA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event BDEKIEHOJBC NNEBEINMACE;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EMDJIFLHMHE();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HGOGPOEBHBL();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void CHPDKJLBDLF();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void KKDMPEMBIHB();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void EAAICPIGACD();
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void HAGMCAJCDEJ();
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void MPLLHLHBAGH();
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void DGDKDGLALGI(bool DGHBDNCEDAG);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate void BDEKIEHOJBC();
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
