using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MMIGHMJKPCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread GJIOFJHBPLL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool AJNMFALFBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7BD0", Offset = "0x5EA65D0", VA = "0x185EA7BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7B70", Offset = "0x5EA6570", VA = "0x185EA7B70")]
	[DLKEJLMCDAC(LIAHCPEMJMG.Unity_AfterSceneLoad)]
	private static void CJBKIPIOHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GOIIOKPNLBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CNDLODFDOHD DCFINABAKPF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event AIHDGLICNEF ADFCFFECPNL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OMBAOBEAAIJ AOAHONMAAIN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OIIBCODLBIK CBMAMNPMDLD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FMGPPONEJAI PFBLGOEIFMP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PCNBDJLEFBA IEJCEJFPCCK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event BGEIEGOICAG LOKEKEACNDO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KENCEPKHFCP AKBGMEDBPEI;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HKCIOCGMBAE KEDFHMMCAAK;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void AIHDGLICNEF();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OMBAOBEAAIJ();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void OIIBCODLBIK();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PCNBDJLEFBA();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void BGEIEGOICAG();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void KENCEPKHFCP();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FMGPPONEJAI();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void CNDLODFDOHD(bool KFJACIMAMME);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void HKCIOCGMBAE();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EA78B0", Offset = "0x5EA62B0", VA = "0x185EA78B0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7990", Offset = "0x5EA6390", VA = "0x185EA7990")]
		public static void SafeDestroyGameObject(GameObject PKKHAEKNIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FCGGMDMFPAD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool EHJHGOFELIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7A30", Offset = "0x5EA6430", VA = "0x185EA7A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7A70", Offset = "0x5EA6470", VA = "0x185EA7A70")]
	[DLKEJLMCDAC(LIAHCPEMJMG.Unity_AfterSceneLoad)]
	private static void IAMMEFBKIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7B30", Offset = "0x5EA6530", VA = "0x185EA7B30")]
	internal static void KOMJIIOFNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FALNAJOIMND
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> OCGKNLDMCFL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(FALNAJOIMND CEPHMJCELIC);
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
