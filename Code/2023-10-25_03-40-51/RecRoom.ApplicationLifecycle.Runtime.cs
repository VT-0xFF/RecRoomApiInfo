using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MMJNHFODPEB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread BMDCNHKHKFO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool FKCMDKNAMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5B93390", Offset = "0x5B92190", VA = "0x185B93390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B93330", Offset = "0x5B92130", VA = "0x185B93330")]
	[NDCOICPCJMM(JMJDGGKCJFL.Unity_AfterSceneLoad)]
	private static void AIJFPABKFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CPHGMPIAMOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event IOCGKMICMMJ DNGMEFBEPDI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event ACGMCNDMIHG NCDLFODJGAN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LMPMLOPEBDG ILGLEEIALCK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BPPMPAEMHAB ECIOPMJCBLO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event IGJDEKINFOE NAGHIDJCEIM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PAOBPPNPPCA CBCOHFOAIOM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event GPCPAMNGBOD EGOCJDCKHDI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ALKGBOBNIGA DNNDPLOAAJJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KLLKCADKOEP CCKGGHMLDII;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void ACGMCNDMIHG();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LMPMLOPEBDG();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void BPPMPAEMHAB();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PAOBPPNPPCA();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void GPCPAMNGBOD();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void ALKGBOBNIGA();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void IGJDEKINFOE();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void IOCGKMICMMJ(bool GLAKPGMDMPK);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void KLLKCADKOEP();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5B93070", Offset = "0x5B91E70", VA = "0x185B93070")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5B93150", Offset = "0x5B91F50", VA = "0x185B93150")]
		public static void SafeDestroyGameObject(GameObject LEMKPNELLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EGNHDEPGEME
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool OIHDELMILNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5B93230", Offset = "0x5B92030", VA = "0x185B93230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B93270", Offset = "0x5B92070", VA = "0x185B93270")]
	[NDCOICPCJMM(JMJDGGKCJFL.Unity_AfterSceneLoad)]
	private static void HCKCHEHGBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B931F0", Offset = "0x5B91FF0", VA = "0x185B931F0")]
	internal static void AIFIKJAFBJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HMJACFDCJMB
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> AHMBBKJIKJJ;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(HMJACFDCJMB JGCMMDEDOJB);
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
