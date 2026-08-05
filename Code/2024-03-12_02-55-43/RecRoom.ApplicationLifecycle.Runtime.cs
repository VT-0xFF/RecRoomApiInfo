using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BFFFCAICDGO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread MGPAAHFBADH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool JOCEBGKENKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6006E30", Offset = "0x6006030", VA = "0x186006E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6006DD0", Offset = "0x6005FD0", VA = "0x186006DD0")]
	[NHKJGMGAMEG(BDNMCGCKBGD.Unity_AfterSceneLoad)]
	private static void LNEKOBBJHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PEDGDJANKOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event JCPLAHKNAOO BFJMPKJICMG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NKIKHHBBCDO HIJKAFNAKDI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FDIJCOFKEPH MAKJOECJKEI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ACEPJBFCMIA ALCJLJGGBAP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DJLOJKELOKA GADBGGEFPPL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DFIDMMLMKLG AECOBJOHFDH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event IDEALAEEMFN OLOGIJGOLMI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ACJMGKFFLGE AEPCAPMFGDA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LJEHAOGANBN HOIPMGDNHEE;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void NKIKHHBBCDO();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FDIJCOFKEPH();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void ACEPJBFCMIA();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void DFIDMMLMKLG();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IDEALAEEMFN();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void ACJMGKFFLGE();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void DJLOJKELOKA();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void JCPLAHKNAOO(bool BIKKNDEKLEP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void LJEHAOGANBN();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6006C50", Offset = "0x6005E50", VA = "0x186006C50")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6006D30", Offset = "0x6005F30", VA = "0x186006D30")]
		public static void SafeDestroyGameObject(GameObject JLBELLDLMIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FDPMMLNNLFN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool GCNKMMPILAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6006F40", Offset = "0x6006140", VA = "0x186006F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6006E80", Offset = "0x6006080", VA = "0x186006E80")]
	[NHKJGMGAMEG(BDNMCGCKBGD.Unity_AfterSceneLoad)]
	private static void AKCGAJHNOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6006F80", Offset = "0x6006180", VA = "0x186006F80")]
	internal static void IGFIOKHKJKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IFIANGBAEJP
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> PHJMCGEMCGF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(IFIANGBAEJP KFFAHNDOJHK);
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
