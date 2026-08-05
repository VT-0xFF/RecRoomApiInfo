using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LNAMKOANMMD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread JOOBCHAOODE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool AMNBACKALEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6835A20", Offset = "0x6834020", VA = "0x186835A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68359D0", Offset = "0x6833FD0", VA = "0x1868359D0")]
	[MMFLCHFLHAE(DIEKPBJOOBM.Unity_AfterSceneLoad)]
	private static void IPDGANODBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CMLEAMAKLKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KJKDBNEKKCD PIINFGJGLKM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NCIMLAEIIGG CCBJGFJMACJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EFIADGGHGNL MPCNGICJMFF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GNHBJOKCODA HOEDBKOHCKA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event ILFFLBCAGGC GNNPNHODKGD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JAAIBILAEKL OMCBKPPGCEC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FGAMINJLPCJ PDPDMNEOJHN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NDBDDKFKHLL NPDELNJBAMH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event AAKPOOPNGEH CNOFJICNFEB;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void NCIMLAEIIGG();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EFIADGGHGNL();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void GNHBJOKCODA();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void JAAIBILAEKL();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FGAMINJLPCJ();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NDBDDKFKHLL();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void ILFFLBCAGGC();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void KJKDBNEKKCD(bool OCCHIGIDODF);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void AAKPOOPNGEH();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6835710", Offset = "0x6833D10", VA = "0x186835710")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68357F0", Offset = "0x6833DF0", VA = "0x1868357F0")]
		public static void SafeDestroyGameObject(GameObject BBKKNFIIKNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HJOIMMBLKAB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool AHLFCIPGJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68358D0", Offset = "0x6833ED0", VA = "0x1868358D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6835910", Offset = "0x6833F10", VA = "0x186835910")]
	[MMFLCHFLHAE(DIEKPBJOOBM.Unity_AfterSceneLoad)]
	private static void HGDANEHJCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6835890", Offset = "0x6833E90", VA = "0x186835890")]
	internal static void FJFBPMHCLAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ALAKHLOJMPE
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> INBIFCGFIOB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(ALAKHLOJMPE FIGBHNGMOHJ);
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
