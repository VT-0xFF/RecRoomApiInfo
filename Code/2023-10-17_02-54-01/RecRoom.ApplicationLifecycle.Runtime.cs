using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class APNMHMJJAMN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread GMGCKPIPEEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool MJOJJAFCANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEAC0", Offset = "0x5BED2C0", VA = "0x185BEEAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BEEA60", Offset = "0x5BED260", VA = "0x185BEEA60")]
	[MPOGKHKBIDF(EDLHBKHFALL.Unity_AfterSceneLoad)]
	private static void DIEHNCAGMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DLHKCJLDEBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HJJIJDONLPE CMACBLFGJMB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event AHOKBGANMDO IDAKBLNHKFP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KNHFMPNLLKL BJCOGLJOKLA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IJPGHMJNJNP MDHPIDLBGLO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KKFHDHDLCIE OPMIHEHAOGH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PJIJHFHIAFC MFMLCLDHPMP;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event HHELOIFLMDI KOBDLGKGOHE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KLEPJILLLBJ OHGNDNEBEFM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KMPBBPPHMON MLBJJBHIILF;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void AHOKBGANMDO();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KNHFMPNLLKL();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void IJPGHMJNJNP();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PJIJHFHIAFC();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HHELOIFLMDI();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void KLEPJILLLBJ();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void KKFHDHDLCIE();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void HJJIJDONLPE(bool HCLFOGECOHG);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void KMPBBPPHMON();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEB10", Offset = "0x5BED310", VA = "0x185BEEB10")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEBF0", Offset = "0x5BED3F0", VA = "0x185BEEBF0")]
		public static void SafeDestroyGameObject(GameObject GOGHJGCCDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ODNOHCJNDHM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool JLFPIOGJBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5BEED90", Offset = "0x5BED590", VA = "0x185BEED90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BEECD0", Offset = "0x5BED4D0", VA = "0x185BEECD0")]
	[MPOGKHKBIDF(EDLHBKHFALL.Unity_AfterSceneLoad)]
	private static void GLJEDCMMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BEEC90", Offset = "0x5BED490", VA = "0x185BEEC90")]
	internal static void GFCPFBPIAEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ONEOGJHMMIP
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> KEECIAGCPMN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(ONEOGJHMMIP CLDBNJMMOJN);
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
