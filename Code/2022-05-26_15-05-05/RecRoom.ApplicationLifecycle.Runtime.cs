using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GOIPPPJLIMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ELKFKIIECMB JPDAHAKPGOC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NPMONCIPKDI IFFNNMKLCCI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MPEPKDBPGKH GFBMFMEHLCJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GJGOHKIONDL FALPMDMPBEL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EPIIHKEEPOO BGGFMMIBAEK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event HEGILLPPNOB GDABLGCLPIJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event HJFCKAPKBML ABEEGEPPHOO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FHBDMEPEJCD NLFNGEOBDJI;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void NPMONCIPKDI();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void MPEPKDBPGKH();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void GJGOHKIONDL();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void HEGILLPPNOB();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HJFCKAPKBML();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void EPIIHKEEPOO();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void ELKFKIIECMB(bool BPMIAAECHAF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FHBDMEPEJCD();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4E80BF0", Offset = "0x4E7F1F0", VA = "0x184E80BF0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4E80CF0", Offset = "0x4E7F2F0", VA = "0x184E80CF0")]
		public static void SafeDestroyGameObject(GameObject NIKGFIPEJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CDPAFIGMGHO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool ELDKAGHIIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4E80E50", Offset = "0x4E7F450", VA = "0x184E80E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E80DB0", Offset = "0x4E7F3B0", VA = "0x184E80DB0")]
	[LFFPJIGGALK(CGKCNJFGIMF.Unity_AfterSceneLoad)]
	private static void EDEIJCODOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E80E90", Offset = "0x4E7F490", VA = "0x184E80E90")]
	internal static void OOLPLIPIKLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KICHOCHLBEC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OLIAEFNMDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<bool> CJCBDELOEHC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(KICHOCHLBEC NENCCJFMAOH);
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
