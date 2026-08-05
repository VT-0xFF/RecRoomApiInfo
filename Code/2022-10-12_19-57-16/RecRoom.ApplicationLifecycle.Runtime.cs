using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ANAPHBJACBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FEOBNDCBOFL LAPDCJEPEOP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OLDOGMOHHKB FMPDGFOLIAO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GCMOJOFDPOP JDHHMNHLCML;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HCCNOMLFEFJ BEBFDDBPGKF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EJFGFJBPONJ BGLELDALBMG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ANLDBMDOCKG AMFOIDAJGNL;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event GECLADMFAJH EEDJIHJMFNE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IDPLAKOIFAM DEACOEAMCDC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event BIFPMKBJHEC MPLFJEKLKPE;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void OLDOGMOHHKB();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GCMOJOFDPOP();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void HCCNOMLFEFJ();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void ANLDBMDOCKG();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GECLADMFAJH();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IDPLAKOIFAM();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void EJFGFJBPONJ();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FEOBNDCBOFL(bool PMDABOLGDEO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void BIFPMKBJHEC();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E46FC0", Offset = "0x5E45FC0", VA = "0x185E46FC0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E470C0", Offset = "0x5E460C0", VA = "0x185E470C0")]
		public static void SafeDestroyGameObject(GameObject HBGIADIFHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OKBMNDEHCNN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool BHLBAPOJAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E472C0", Offset = "0x5E462C0", VA = "0x185E472C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E47200", Offset = "0x5E46200", VA = "0x185E47200")]
	[BMMLGDJGCIJ(IEFLDJIBODH.Unity_AfterSceneLoad)]
	private static void CDFKCHBFAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E47300", Offset = "0x5E46300", VA = "0x185E47300")]
	internal static void MFNAJEFPPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NOEMDDECFCF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MGNPCKLOIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> GCOOOHIJGNM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(NOEMDDECFCF FPHJBLLGCCG);
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
