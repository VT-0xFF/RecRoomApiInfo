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
		[Cpp2IlInjected.Address(RVA = "0x4F03D40", Offset = "0x4F02540", VA = "0x184F03D40")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4F03E40", Offset = "0x4F02640", VA = "0x184F03E40")]
		public static void SafeDestroyGameObject(GameObject NJCEGNEAEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F04060", Offset = "0x4F02860", VA = "0x184F04060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4F03F80", Offset = "0x4F02780", VA = "0x184F03F80")]
	[HPAOLEFNIIC(NINHAEJAJKD.Unity_AfterSceneLoad)]
	private static void EMFGCIHFDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4F04020", Offset = "0x4F02820", VA = "0x184F04020")]
	internal static void HNPHIAGLAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HDLDINAKCMF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ACEBLDKAOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<bool> BGPPKOPNGMK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(HDLDINAKCMF LJKNHMPLFLG);
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
