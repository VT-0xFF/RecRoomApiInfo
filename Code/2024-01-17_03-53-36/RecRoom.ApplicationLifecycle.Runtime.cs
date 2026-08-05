using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PDBGAGHKBFK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread KJFBMIELNCP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool MOPGNNABBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5EA87E0", Offset = "0x5EA75E0", VA = "0x185EA87E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8780", Offset = "0x5EA7580", VA = "0x185EA8780")]
	[GEDGJALKBHL(HNLGNAJIJHC.Unity_AfterSceneLoad)]
	private static void JLCIFBCNJPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PIPKIFDPMAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ONMDGMODJBO AODAMEDANLJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DNNBNCMJCIF KBHDIJCCCPP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FGFBJMEBJCP ONLBGOJJDEH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MLEKEHBDOEK HLONJMJGPKP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HOLDOBPKJHK AFLOIJGCMIF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event AGPECJCBCPG OOINFGINDKO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event OHJBEKJPFCN BDCMIBECGEG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HFLEMGHNJHF NAJFCBJPEPB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event EKBPMMIAKNK JGJIMIJJCJA;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void DNNBNCMJCIF();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FGFBJMEBJCP();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MLEKEHBDOEK();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void AGPECJCBCPG();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void OHJBEKJPFCN();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void HFLEMGHNJHF();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void HOLDOBPKJHK();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void ONMDGMODJBO(bool DDDKHNFCHDP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void EKBPMMIAKNK();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EA84C0", Offset = "0x5EA72C0", VA = "0x185EA84C0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EA85A0", Offset = "0x5EA73A0", VA = "0x185EA85A0")]
		public static void SafeDestroyGameObject(GameObject FAIKIGMIEFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ECEDIPKFMNG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool KLMLCOCNHND
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8740", Offset = "0x5EA7540", VA = "0x185EA8740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8680", Offset = "0x5EA7480", VA = "0x185EA8680")]
	[GEDGJALKBHL(HNLGNAJIJHC.Unity_AfterSceneLoad)]
	private static void CGDOOEBPPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8640", Offset = "0x5EA7440", VA = "0x185EA8640")]
	internal static void BABNOLCEDDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EHJLPAOOJNI
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> NKNAAAOHFNM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(EHJLPAOOJNI CHJIPJIFJNC);
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
