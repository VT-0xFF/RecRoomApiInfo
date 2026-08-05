using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PGGKCAJIBHL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KIADOFKDMMA DDGFHEMEJEL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event MNFPBNKMHNJ HFCDGCMEJPN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BGALEIFACJE HACHGPIJOGH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KGBHBPBJOMG DDMICJGFALP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JDKJEBJOCMO AMFGGLNIHJC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CLJNCMEBMIH IHJBKIPPOPK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FMPOKCMKIDI EMBODCDHMNH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EOGHMPPLAPA NILNEJILOMM;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void MNFPBNKMHNJ();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void BGALEIFACJE();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KGBHBPBJOMG();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void CLJNCMEBMIH();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FMPOKCMKIDI();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void JDKJEBJOCMO();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void KIADOFKDMMA(bool GJBDGPPAGFH);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void EOGHMPPLAPA();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x520C2C0", Offset = "0x520B2C0", VA = "0x18520C2C0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x520C3C0", Offset = "0x520B3C0", VA = "0x18520C3C0")]
		public static void SafeDestroyGameObject(GameObject CPHKFFAMPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IPENIMOMMDN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool ILMDFPAGMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x520C480", Offset = "0x520B480", VA = "0x18520C480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x520C500", Offset = "0x520B500", VA = "0x18520C500")]
	[PFKLLAIKJFA(AOOAHLGEHHB.Unity_AfterSceneLoad)]
	private static void JMPIMFJAEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x520C4C0", Offset = "0x520B4C0", VA = "0x18520C4C0")]
	internal static void JKAKDPDODAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EJBEEBOPCOD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BBCGDKPEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<bool> MDKBFGACLDC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(EJBEEBOPCOD KINFAPMPKIE);
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
