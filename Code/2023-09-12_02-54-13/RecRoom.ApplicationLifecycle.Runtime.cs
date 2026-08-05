using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IJLDLIPMEBO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread AHMABHBHJEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool CECLMBOKELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x722A980", Offset = "0x7229D80", VA = "0x18722A980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x722A930", Offset = "0x7229D30", VA = "0x18722A930")]
	[EAKEEMOLAGA(GCOHNAPHEPC.Unity_AfterSceneLoad)]
	private static void KBCIPFBKDFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EIFBOPLLECN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> BJPPNGHJNEG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(EIFBOPLLECN DDPMEJDAOLK);
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x722A780", Offset = "0x7229B80", VA = "0x18722A780")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x722A870", Offset = "0x7229C70", VA = "0x18722A870")]
		public static void SafeDestroyGameObject(GameObject NNAKJIJAOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LJOFLAPBFCG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool AKIBNBPIJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x722AA90", Offset = "0x7229E90", VA = "0x18722AA90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x722AAD0", Offset = "0x7229ED0", VA = "0x18722AAD0")]
	[EAKEEMOLAGA(GCOHNAPHEPC.Unity_AfterSceneLoad)]
	private static void MHIDNOPDKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x722AA50", Offset = "0x7229E50", VA = "0x18722AA50")]
	internal static void HCBNIHEGPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AGAJJBLMBLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KHDIJIFLAHP DPFKJPAPOCD;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IEHKLBNKAJI GLINDFMMGLK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FCGFJEKOOJG BKGCCEADAFP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GLALJGFEGNI OJDMEHEMBJE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OFLBPFLBJBD OMNFINNPAHA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CJDCAEDHHBO NFKNALDLKDL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FGOIHKAAPDH JIDKDJPJFLO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JLLKGOBPENK HAFCONHMIDE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PDIDLKEAKJF GEEMFLGABFH;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IEHKLBNKAJI();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FCGFJEKOOJG();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void GLALJGFEGNI();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void CJDCAEDHHBO();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void FGOIHKAAPDH();
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void JLLKGOBPENK();
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void OFLBPFLBJBD();
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void KHDIJIFLAHP(bool DHKKHBECOJI);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate void PDIDLKEAKJF();
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
