using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GMLIDMGBKLK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread PCNBHIENEAM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool IEOCPHEODIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6044D20", Offset = "0x6043D20", VA = "0x186044D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6044D70", Offset = "0x6043D70", VA = "0x186044D70")]
	[HMAONFLKHFC(PNOGLCABCMB.Unity_AfterSceneLoad)]
	private static void NGBEIAHPFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PPHCMAEKOIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NJBHLAGFNPO MNLNKOECPNE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event CLPAIMEOGLN EKOOOFBJPAE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FIPMEMJBGPB NKNAKIMNIHM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PKEFDNJKIOO CDGBILPFIDL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KOLKKHODGHD JIHLOIFECJA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NLHJPPBDDFG EHAODBFOAJE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CANLAFJCAPP AILFJGJJPHK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event COICKLBJCHN CJFNILAJDNM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CDAJHIJJELN IHPAIIMNBAN;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void CLPAIMEOGLN();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FIPMEMJBGPB();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void PKEFDNJKIOO();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NLHJPPBDDFG();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CANLAFJCAPP();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void COICKLBJCHN();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void KOLKKHODGHD();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void NJBHLAGFNPO(bool GIAMLAJLMKA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void CDAJHIJJELN();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6044BA0", Offset = "0x6043BA0", VA = "0x186044BA0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6044C80", Offset = "0x6043C80", VA = "0x186044C80")]
		public static void SafeDestroyGameObject(GameObject LNIPGKDIFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GNHOEFKJNMP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool IOOKCEPOJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6044DD0", Offset = "0x6043DD0", VA = "0x186044DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6044E10", Offset = "0x6043E10", VA = "0x186044E10")]
	[HMAONFLKHFC(PNOGLCABCMB.Unity_AfterSceneLoad)]
	private static void DPGLELIALOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6044ED0", Offset = "0x6043ED0", VA = "0x186044ED0")]
	internal static void MILLDIHDADG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GOEEHHAOEPC
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> DKDKPKLKLJC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(GOEEHHAOEPC LGGFMDJBFOM);
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
