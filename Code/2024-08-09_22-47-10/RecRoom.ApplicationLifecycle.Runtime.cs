using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ABJHAEMEODF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread KMIHHEMAOMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool APPGMCDPAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6778C30", Offset = "0x6778030", VA = "0x186778C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6778C80", Offset = "0x6778080", VA = "0x186778C80")]
	[NOENHMEFMBP(NDPGHFIEDII.Unity_AfterSceneLoad)]
	private static void LJKJKOBPKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FEMOAGJKFIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OGNGECPJKBD LAHOJLJODCM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HGIBOKFKLEB DKKALNJCGIH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CAMDLIOEFKI EGMEIPNOEJH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GPPPCNMOJNE AIMMALFDAGC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DGIJOGCKKCK PAHOEKKJBFC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GPDODAPGIND LDKDDDMCOMI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event PLHLGDIKLBE IHICNOINJAM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ECANAODACIA FPPDBKGALFB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event ENEKJFBJBJN PEDDHNGLDBN;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void HGIBOKFKLEB();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void CAMDLIOEFKI();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void GPPPCNMOJNE();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GPDODAPGIND();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PLHLGDIKLBE();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void ECANAODACIA();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void DGIJOGCKKCK();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void OGNGECPJKBD(bool HGDPPFOLIJE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void ENEKJFBJBJN();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6778E20", Offset = "0x6778220", VA = "0x186778E20")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6778F00", Offset = "0x6778300", VA = "0x186778F00")]
		public static void SafeDestroyGameObject(GameObject GODEJCKEDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AOCFEOHECHP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool AHFBLCJMFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6778CE0", Offset = "0x67780E0", VA = "0x186778CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6778D60", Offset = "0x6778160", VA = "0x186778D60")]
	[NOENHMEFMBP(NDPGHFIEDII.Unity_AfterSceneLoad)]
	private static void MGIGIPLLEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6778D20", Offset = "0x6778120", VA = "0x186778D20")]
	internal static void LHGLKGFOHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GJCFMCDAOJH
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> CNEKHCCPEKL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(GJCFMCDAOJH MDEMALKKIBO);
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
