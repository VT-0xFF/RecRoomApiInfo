using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NGHDNDEEKBC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread JDNFHEGPJBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool FLAAKKMEMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x674BD40", Offset = "0x674A740", VA = "0x18674BD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x674BCE0", Offset = "0x674A6E0", VA = "0x18674BCE0")]
	[DMPANLBIAGM(ACEEKKJJCPD.Unity_AfterSceneLoad)]
	private static void ACIIPLOJHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JEHOOFFEJCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MCABLLBDAOI MNLEHIHHDJB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NOAPPFLEBAD AIFEINMMINP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GKEIDMKCDJD PBPDAGNEOGG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ODADBNGCKOB HIKAIFAPIEJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FLNJBFMECAK DDEHLKCKMFK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ODPGJJJGPAB MNJLEMLFOGL;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FJDDLFHFLAB EEPMJEOOFBL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NKDEAPPDLJK AMKMDEFBFEE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LABLMIAEBHB KGBHJKMHMBB;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void NOAPPFLEBAD();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void GKEIDMKCDJD();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void ODADBNGCKOB();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void ODPGJJJGPAB();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FJDDLFHFLAB();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NKDEAPPDLJK();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FLNJBFMECAK();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void MCABLLBDAOI(bool MOJIPFDFMKL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void LABLMIAEBHB();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x674BA20", Offset = "0x674A420", VA = "0x18674BA20")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x674BB00", Offset = "0x674A500", VA = "0x18674BB00")]
		public static void SafeDestroyGameObject(GameObject AOOABPFBFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LAHALANCDON
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool JOBFAANABMG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x674BC60", Offset = "0x674A660", VA = "0x18674BC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x674BBA0", Offset = "0x674A5A0", VA = "0x18674BBA0")]
	[DMPANLBIAGM(ACEEKKJJCPD.Unity_AfterSceneLoad)]
	private static void CCPNKNOIBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x674BCA0", Offset = "0x674A6A0", VA = "0x18674BCA0")]
	internal static void OFLBIILMEAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HOOGKOOKANP
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> MLMBNHMPLAA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(HOOGKOOKANP BNNMABLFADN);
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
