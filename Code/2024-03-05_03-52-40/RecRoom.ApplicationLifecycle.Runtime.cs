using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ENAJGJDAENG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread INFIBPNEHJM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool HKIAMLAMDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F98B40", Offset = "0x5F97940", VA = "0x185F98B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F98B90", Offset = "0x5F97990", VA = "0x185F98B90")]
	[GJCBJFIHOBA(OPNAEKDCKEJ.Unity_AfterSceneLoad)]
	private static void PBOKBLGPDEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PMBLONHFIAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PCEBDCLJGOD FBLFAOHAMEF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PJHCNKNAAFL LAGHJNJIPJP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KHAJDDGACGJ OANLENBHCPB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JEIIFINAMME IEPPHNOBAPL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OJBFMIDCAEI LJDMGDGLNPG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LPOKILOMMJF DILHLNFHKCE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event OGOFBALLDOB ODOCDGJFKKO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FAEOBAAGOLL CDIOBNBFBLE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FAPFOIIBIEF JMNBOJBHGMP;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void PJHCNKNAAFL();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KHAJDDGACGJ();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JEIIFINAMME();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LPOKILOMMJF();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void OGOFBALLDOB();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FAEOBAAGOLL();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void OJBFMIDCAEI();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void PCEBDCLJGOD(bool NGFBEJKNDHP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void FAPFOIIBIEF();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F989C0", Offset = "0x5F977C0", VA = "0x185F989C0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F98AA0", Offset = "0x5F978A0", VA = "0x185F98AA0")]
		public static void SafeDestroyGameObject(GameObject EAPMMKKAJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LIPBPNJLHBL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool FDKJABDFKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F98CF0", Offset = "0x5F97AF0", VA = "0x185F98CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F98BF0", Offset = "0x5F979F0", VA = "0x185F98BF0")]
	[GJCBJFIHOBA(OPNAEKDCKEJ.Unity_AfterSceneLoad)]
	private static void KCJBJGBIMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F98CB0", Offset = "0x5F97AB0", VA = "0x185F98CB0")]
	internal static void MKCMELPPGGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GHMENDIJHAC
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> CLHNDLNLDIL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(GHMENDIJHAC NKGPGCGHNEN);
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
