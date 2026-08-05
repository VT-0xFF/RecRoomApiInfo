using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GOOIHJDEJFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FACNIFKJBKL NPHGPLKELKM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OLJADICHBDI HGBIKKNOCLO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event AKBDKHPFHDH HHDAFANMJKG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PCGDBNABDDH DLPAEGMPPEP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CMJKBIPEDMB DLBLECHFOEK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event MLJDNBPKFPO JBCNABGOKBC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CINIFHJONBL PNCJKABBCAK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event AODEIABMPGF AFPAPMEINNO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DLHAHFNKPGG NOADFNJJFDM;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void OLJADICHBDI();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void AKBDKHPFHDH();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PCGDBNABDDH();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MLJDNBPKFPO();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void CINIFHJONBL();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void AODEIABMPGF();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void CMJKBIPEDMB();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FACNIFKJBKL(bool ELFCDIFJAOF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void DLHAHFNKPGG();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x289B1C0", Offset = "0x289A3C0", VA = "0x18289B1C0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x289B2C0", Offset = "0x289A4C0", VA = "0x18289B2C0")]
		public static void SafeDestroyGameObject(GameObject NEFMINHNLIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IKIAMNDGCFE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool GIEMOJONPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x289B440", Offset = "0x289A640", VA = "0x18289B440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x289B480", Offset = "0x289A680", VA = "0x18289B480")]
	[BAGFEACOEOD(DHALNGCEHDC.Unity_AfterSceneLoad)]
	private static void MGEPLKAAEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x289B400", Offset = "0x289A600", VA = "0x18289B400")]
	internal static void CPBONBIDAPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BALOLAFAEPP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LAKLLJIFDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> MLEFBKLEGOB;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(BALOLAFAEPP EKJJPLNMKDI);
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
