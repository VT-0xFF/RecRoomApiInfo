using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EDKKGLBAGJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event JJGHIABGDFO OMPNEAHBOLG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event BMGAAAMFCDH FCLLPBMAPJJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CFDMCNFKPND EPJKJEECOLI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event APCILBAENBN MDLFJKEANEL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OPIPGFJIFPE BGIMCGNMNKN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JJAIBPNOJGJ KKFNMENELJD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LBOKOLFBHCP ECPHNMLBJDA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EFLMIDECHJC IAICGJPHLGK;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void BMGAAAMFCDH();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void CFDMCNFKPND();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void APCILBAENBN();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JJAIBPNOJGJ();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LBOKOLFBHCP();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void OPIPGFJIFPE();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void JJGHIABGDFO(bool ADMLMOPBFII);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void EFLMIDECHJC();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5213C60", Offset = "0x5212C60", VA = "0x185213C60")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5213D60", Offset = "0x5212D60", VA = "0x185213D60")]
		public static void SafeDestroyGameObject(GameObject EMHOKENKLPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NIEGAFHDOMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool PHAFHMKINDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5213F80", Offset = "0x5212F80", VA = "0x185213F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5213EA0", Offset = "0x5212EA0", VA = "0x185213EA0")]
	[BBCGKKBBDLI(ANPEOBJOGFO.Unity_AfterSceneLoad)]
	private static void BGKBBGPIDLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5213F40", Offset = "0x5212F40", VA = "0x185213F40")]
	internal static void DLDKMBAGAAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OGNOKHIAFJL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FADIEHCHJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<bool> LDAJFNDCOND;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(OGNOKHIAFJL BHHJEKEPBNC);
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
