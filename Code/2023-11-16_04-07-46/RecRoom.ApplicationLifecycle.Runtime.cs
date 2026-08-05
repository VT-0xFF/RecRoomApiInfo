using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GJILGEDGJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread LANJGLFLKLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool IBCCBAHMAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D03AB0", Offset = "0x5D02AB0", VA = "0x185D03AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D03A50", Offset = "0x5D02A50", VA = "0x185D03A50")]
	[GABBFJBHOKF(HMIDDPKLECI.Unity_AfterSceneLoad)]
	private static void DFABGLAHNPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PFDKAPMDOON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OONCOLDPGMD IMKNLGPBMAN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GKFLJGDACNO HOEJNKLEAPP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PFHLKGDKLDK FLBMAAPGJBA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LGMLLFLCFNB LGDGBDMKDKJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DHKOEKFJALJ PEMFIHCABAG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event BMIPMEPDFDD KMLEPBAHFAC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NKBHHPOAFHA IKFNMPCIMEM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LIIOPKHHDJP IPEBMNIPEIP;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NEHLNOALKMM BGEKEFGNOCM;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GKFLJGDACNO();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PFHLKGDKLDK();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void LGMLLFLCFNB();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void BMIPMEPDFDD();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NKBHHPOAFHA();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void LIIOPKHHDJP();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void DHKOEKFJALJ();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void OONCOLDPGMD(bool LLBIPFOHHDH);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void NEHLNOALKMM();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D03790", Offset = "0x5D02790", VA = "0x185D03790")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D03870", Offset = "0x5D02870", VA = "0x185D03870")]
		public static void SafeDestroyGameObject(GameObject GFBHJHHLEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CIPKFEMJPKE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool MPLOLCJAMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D039D0", Offset = "0x5D029D0", VA = "0x185D039D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D03910", Offset = "0x5D02910", VA = "0x185D03910")]
	[GABBFJBHOKF(HMIDDPKLECI.Unity_AfterSceneLoad)]
	private static void EMCBFDNIFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D03A10", Offset = "0x5D02A10", VA = "0x185D03A10")]
	internal static void OAJNDDADCAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHCBLMNEPCM
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> JNDGPGHBBPA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(JHCBLMNEPCM MADNCEDCBHH);
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
