using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NBAOJIGCEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread MGNIJFNOHLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool FFOJDLOAEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1D90", Offset = "0x6FF0390", VA = "0x186FF1D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1D40", Offset = "0x6FF0340", VA = "0x186FF1D40")]
	[OCOFNFINNCA(IDKLBGIEEOI.Unity_AfterSceneLoad)]
	private static void GBPEJJMEKGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PDCNDDIAECG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> LOMGGIOOBKE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(PDCNDDIAECG HPADGKEDAHA);
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FF19D0", Offset = "0x6FEFFD0", VA = "0x186FF19D0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AC0", Offset = "0x6FF00C0", VA = "0x186FF1AC0")]
		public static void SafeDestroyGameObject(GameObject FLCGKEKAMCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CLAFEOJFDKK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool BFGHFPNNHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1C40", Offset = "0x6FF0240", VA = "0x186FF1C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1B80", Offset = "0x6FF0180", VA = "0x186FF1B80")]
	[OCOFNFINNCA(IDKLBGIEEOI.Unity_AfterSceneLoad)]
	private static void GMAKAKECEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1C80", Offset = "0x6FF0280", VA = "0x186FF1C80")]
	internal static void IMFPKGAMHLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EGAMGCEGNED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event MBEOLMOOKMF JGLMBFGMJNF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FIANPHEBJJJ GFCEDFCLACE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CKPGCBHDCHK POMPHFNABOH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MKHILHCAKMM DOAPFPPDFEJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GHHLGLJEKLD JLLAOLKHGLE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event BOBEIHPAOED LBLOPNAABGG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MFCNGJEBACH LLBBNPCNJAE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LDCEJPMKDAE GKJDMAOFINF;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OGALMPHPAFG LJCBPBIPKOI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FIANPHEBJJJ();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CKPGCBHDCHK();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void MKHILHCAKMM();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void BOBEIHPAOED();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void MFCNGJEBACH();
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void LDCEJPMKDAE();
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void GHHLGLJEKLD();
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void MBEOLMOOKMF(bool GHGOAJFOICO);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate void OGALMPHPAFG();
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
