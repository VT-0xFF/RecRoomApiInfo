using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ADNOODHHIFM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread EPKKBABCFBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool IEEIDMFHEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5A60", Offset = "0x5BD4260", VA = "0x185BD5A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BD5A00", Offset = "0x5BD4200", VA = "0x185BD5A00")]
	[OBMNFKLINDG(KBJMBFFAEHK.Unity_AfterSceneLoad)]
	private static void HMIMLLFNGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OOBMLCDGGBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DLNGEPALMDF CHHHICGCBMG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event BJFLLNAAGEN HFBGFFHILGI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IKGBENGMIGF MDBJAHPMOGO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OKFEJFFODJP OIMFHECNOCP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LEAANOBIJNM BMEBNGCPCHP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LINDAFBAHMD EPOHNONKJPO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CEFFOOPGFCJ GMCLFOMPAAN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FALKFLCCHPI HOELCNDCGMK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HHIDOOANPIC FHOJPFKBNLB;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void BJFLLNAAGEN();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void IKGBENGMIGF();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void OKFEJFFODJP();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LINDAFBAHMD();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CEFFOOPGFCJ();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FALKFLCCHPI();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void LEAANOBIJNM();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void DLNGEPALMDF(bool KJHCPHIPCAK);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void HHIDOOANPIC();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5AB0", Offset = "0x5BD42B0", VA = "0x185BD5AB0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5B90", Offset = "0x5BD4390", VA = "0x185BD5B90")]
		public static void SafeDestroyGameObject(GameObject AAAOHJGLLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class COABBBGMFPC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool DNFPNEHPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5C30", Offset = "0x5BD4430", VA = "0x185BD5C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BD5CB0", Offset = "0x5BD44B0", VA = "0x185BD5CB0")]
	[OBMNFKLINDG(KBJMBFFAEHK.Unity_AfterSceneLoad)]
	private static void MJKJMKCCJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BD5C70", Offset = "0x5BD4470", VA = "0x185BD5C70")]
	internal static void HFJJAGJFLOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LMKIHNIIMJP
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> MFIMLCAJPHM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(LMKIHNIIMJP KBEHNLCEONM);
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
