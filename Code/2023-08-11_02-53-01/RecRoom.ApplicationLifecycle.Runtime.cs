using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ENFLICNABPP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread BDNJEJADJIE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool FHIJGLFEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F25080", Offset = "0x6F23880", VA = "0x186F25080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F25030", Offset = "0x6F23830", VA = "0x186F25030")]
	[OEEILBBPFDK(LAKEBMDCEIM.Unity_AfterSceneLoad)]
	private static void ICOGGLLGJEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EFGLECLLKKL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> HBONLGPOKAB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(EFGLECLLKKL CNDDNJHBCGP);
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F24E80", Offset = "0x6F23680", VA = "0x186F24E80")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F24F70", Offset = "0x6F23770", VA = "0x186F24F70")]
		public static void SafeDestroyGameObject(GameObject OAOEKKJFJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MMOAEEMKIOG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool OFPHJLGGNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F251D0", Offset = "0x6F239D0", VA = "0x186F251D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F250D0", Offset = "0x6F238D0", VA = "0x186F250D0")]
	[OEEILBBPFDK(LAKEBMDCEIM.Unity_AfterSceneLoad)]
	private static void BDCEDMLOOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F25190", Offset = "0x6F23990", VA = "0x186F25190")]
	internal static void BLKGADBNJDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JLELFANOIJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NNIKIHJJHNM DACBMBJCBMA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BFJEJAHPDBI DNNKNEBJAJP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JFKBKNAHMJA EOBJHGDDJNN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HFFEHJNLIBD DKCCEOOONFA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LCKKMKLHGOH CJJKJIAFIJJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CPCONGDJLGM AOGCCNEMOMH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LJGOOOCKLLF OEBMDPDFMAA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event BLDPKNMKBOD OMOBLILHCIE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JGKMJLMKDPM MIPJKKHFOMP;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void BFJEJAHPDBI();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void JFKBKNAHMJA();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void HFFEHJNLIBD();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void CPCONGDJLGM();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void LJGOOOCKLLF();
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void BLDPKNMKBOD();
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void LCKKMKLHGOH();
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void NNIKIHJJHNM(bool JEJMPPELMIF);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate void JGKMJLMKDPM();
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
