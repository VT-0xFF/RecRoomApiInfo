using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PDNBIFHMCNE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread NDFJHFPHMAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool GOJAKKPJDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5B91830", Offset = "0x5B90C30", VA = "0x185B91830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B917D0", Offset = "0x5B90BD0", VA = "0x185B917D0")]
	[NPHAAKAPCJA(MIKPKJFIPHI.Unity_AfterSceneLoad)]
	private static void GOPHCAAEPOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MJJMANFKLKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NFMDBEGBAOF OBFGDPLNFAA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OHPJNLBLCFB GFEAHGHFDLK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KKJKFGHPOGD EDDEBJBIJLH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MGAOOCFLMHE IHBHKNEBIFF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OLEPCMKEOPO HMMOGIJMEIA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PJAPFILKCNL JOOOGFAEBLC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event HKEFHKLJEMH KJLEDBILCFI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GOBLCINPKCJ CCBENLPJLBG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DLNGHDMGNLF LGIPABNGDII;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OHPJNLBLCFB();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KKJKFGHPOGD();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MGAOOCFLMHE();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PJAPFILKCNL();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HKEFHKLJEMH();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void GOBLCINPKCJ();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void OLEPCMKEOPO();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void NFMDBEGBAOF(bool HGFHLCBGFPC);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void DLNGHDMGNLF();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5B91510", Offset = "0x5B90910", VA = "0x185B91510")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5B915F0", Offset = "0x5B909F0", VA = "0x185B915F0")]
		public static void SafeDestroyGameObject(GameObject IPAGFDLNMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DIOOKPOMGHN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool LFCHGGMPBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5B91750", Offset = "0x5B90B50", VA = "0x185B91750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B91690", Offset = "0x5B90A90", VA = "0x185B91690")]
	[NPHAAKAPCJA(MIKPKJFIPHI.Unity_AfterSceneLoad)]
	private static void FGBNJEBGKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B91790", Offset = "0x5B90B90", VA = "0x185B91790")]
	internal static void KNPBHGEECAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FICEHFNLLCN
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> LDIAEOOKPMI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(FICEHFNLLCN JDCGHMELGAO);
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
