using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BKLFFHGFDAF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread EBHNBPLABOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool OOIAJPFADJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D217C0", Offset = "0x5D20BC0", VA = "0x185D217C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D21760", Offset = "0x5D20B60", VA = "0x185D21760")]
	[HJCCINDKAPB(LDDPNLEJGAE.Unity_AfterSceneLoad)]
	private static void OODFKLIGDLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NHEGGEMENKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MOLGHPAENED HKMEECNEDJJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LIGNNKMEOGK LFKJJNEOHNN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HODKGKCIBNJ MNPPDGLOEEG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event AGCBEKJBCHD IELNLCCEBJE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JBLDIDOILLC OGIJHLOOLBC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JDLMGCLNGNJ AKCENFLAMLH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event DBKKIBFOKHN HNKMLJMDFME;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FLKLIGIDDCP JAEICAJHCLC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event BHFAINNFLOP PJFKLACEOEF;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void LIGNNKMEOGK();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void HODKGKCIBNJ();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void AGCBEKJBCHD();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void JDLMGCLNGNJ();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void DBKKIBFOKHN();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FLKLIGIDDCP();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void JBLDIDOILLC();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void MOLGHPAENED(bool OHKFABCALMB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void BHFAINNFLOP();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D215E0", Offset = "0x5D209E0", VA = "0x185D215E0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D216C0", Offset = "0x5D20AC0", VA = "0x185D216C0")]
		public static void SafeDestroyGameObject(GameObject PLLPJJEOIKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CLEKNINKCNG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool IFHIOCEEICL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D21910", Offset = "0x5D20D10", VA = "0x185D21910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D21850", Offset = "0x5D20C50", VA = "0x185D21850")]
	[HJCCINDKAPB(LDDPNLEJGAE.Unity_AfterSceneLoad)]
	private static void GJHPIDDJMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D21810", Offset = "0x5D20C10", VA = "0x185D21810")]
	internal static void BOLHOHGEBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ELDODCKCEEI
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> NCEBMCAOJOK;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(ELDODCKCEEI MLCIAHDDNEJ);
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
