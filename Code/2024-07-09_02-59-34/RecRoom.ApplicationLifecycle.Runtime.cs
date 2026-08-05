using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MGFDDABAMMF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread NAOPCDGGLEN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool IBNIJCKLHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6852390", Offset = "0x6850F90", VA = "0x186852390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68523E0", Offset = "0x6850FE0", VA = "0x1868523E0")]
	[ECODOIAJHDJ(JPJJCBLCFNP.Unity_AfterSceneLoad)]
	private static void NGIENJGHIMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MLOMOJCGHGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PNPPCJBPONI IKMBNDOIBDF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event JOJMEIOKLJD LMJHDDPLKGM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MOIAKMPOHLL ODKIHACCDAD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IMACCKMOJDK LPBJNGIPPCB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event ACAEKHJBPKF HMMJGHGLEIH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OBAMOPKHGAN AAPOELOOOGJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event IEEDADFECOK DNPPJJAMKBM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NFMAMMCMHFK IIBCFLHHLGA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MBCFPBKEBPC IGKDODPKIEI;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void JOJMEIOKLJD();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MOIAKMPOHLL();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void IMACCKMOJDK();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void OBAMOPKHGAN();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IEEDADFECOK();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NFMAMMCMHFK();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void ACAEKHJBPKF();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void PNPPCJBPONI(bool KBCOIMFAAAE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void MBCFPBKEBPC();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6852210", Offset = "0x6850E10", VA = "0x186852210")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68522F0", Offset = "0x6850EF0", VA = "0x1868522F0")]
		public static void SafeDestroyGameObject(GameObject OJCNPGOLEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NEABAINDKMC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool IHBONGNEIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6852440", Offset = "0x6851040", VA = "0x186852440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68524C0", Offset = "0x68510C0", VA = "0x1868524C0")]
	[ECODOIAJHDJ(JPJJCBLCFNP.Unity_AfterSceneLoad)]
	private static void NJFEGHENHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6852480", Offset = "0x6851080", VA = "0x186852480")]
	internal static void EGCFBCEMIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BKJIHGOOAEH
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> ICMEEBEDHCD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(BKJIHGOOAEH KLNMDJKLADI);
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
