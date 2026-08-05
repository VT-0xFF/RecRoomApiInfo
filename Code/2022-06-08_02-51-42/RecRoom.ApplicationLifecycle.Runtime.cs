using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MJEPMDIMFPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CGKIJAHDGLC JKCBLPMMLLJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KKIJEHMGCOI ADBHOPCDBIC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event AGNDMABBDKD CLBMHHNKOMA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JNGDHAGPAGA CDEIPGNFLGB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event IOCHMNFDLJG FLKIIAFHPEC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event EBEPDJJFLKB AMGAJMKKFJD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KEOPCFPJCOE OEELLJOIJCB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MJAKHKLBIJG KCFBNJBEHKD;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void KKIJEHMGCOI();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void AGNDMABBDKD();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JNGDHAGPAGA();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void EBEPDJJFLKB();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KEOPCFPJCOE();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IOCHMNFDLJG();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void CGKIJAHDGLC(bool JECOMMGAJNF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void MJAKHKLBIJG();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4DA2F80", Offset = "0x4DA1F80", VA = "0x184DA2F80")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4DA3080", Offset = "0x4DA2080", VA = "0x184DA3080")]
		public static void SafeDestroyGameObject(GameObject NJCEGNEAEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IKANGLIFMEL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool EBEGGDKDAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4DA32A0", Offset = "0x4DA22A0", VA = "0x184DA32A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4DA31C0", Offset = "0x4DA21C0", VA = "0x184DA31C0")]
	[HPAOLEFNIIC(NINHAEJAJKD.Unity_AfterSceneLoad)]
	private static void EMFGCIHFDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4DA3260", Offset = "0x4DA2260", VA = "0x184DA3260")]
	internal static void HNPHIAGLAAL()
	{
	}
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
