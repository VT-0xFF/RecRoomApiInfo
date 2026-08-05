using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CLMOCOOFKDC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread NDFLHMHKBAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool LHNMEEKCPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF160", Offset = "0x5EADF60", VA = "0x185EAF160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF1B0", Offset = "0x5EADFB0", VA = "0x185EAF1B0")]
	[FIGCBHDOGLN(HCIPOEFGANF.Unity_AfterSceneLoad)]
	private static void PMDBOALDHOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DJHJGNKNHBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CFIEKEKBNLG FJLFENJBLON;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GHBJPLCANHC LLIADGIKINC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KJOOMGKFLEG MBMAKNJPLGK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OMAHMABBKCD KHALEDIHAJH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PAHHIAOPLIB BFMFLFDBCDN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event AOIOLHPFELM DIHFIOOAPBI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CBPOFJGGIKB PGMLDCHMFLK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MIDLEOLFPJC MHELOKCAJOE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GDLGCFHNNJP JPMKGKDALHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GHBJPLCANHC();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KJOOMGKFLEG();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void OMAHMABBKCD();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void AOIOLHPFELM();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CBPOFJGGIKB();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void MIDLEOLFPJC();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void PAHHIAOPLIB();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void CFIEKEKBNLG(bool HBCPNKKLDHE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GDLGCFHNNJP();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEFE0", Offset = "0x5EADDE0", VA = "0x185EAEFE0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF0C0", Offset = "0x5EADEC0", VA = "0x185EAF0C0")]
		public static void SafeDestroyGameObject(GameObject IPHCMOEHILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MCNJKNCNOJD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool JAEPAGBKGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF210", Offset = "0x5EAE010", VA = "0x185EAF210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF250", Offset = "0x5EAE050", VA = "0x185EAF250")]
	[FIGCBHDOGLN(HCIPOEFGANF.Unity_AfterSceneLoad)]
	private static void FCIFMHNEBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF310", Offset = "0x5EAE110", VA = "0x185EAF310")]
	internal static void IDMKEGNPNMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KGDFNECONLN
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> AOFNPMNIPAF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(KGDFNECONLN KNNEJMENJIO);
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
