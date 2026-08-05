using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LDAHOLMKBNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KFBEGDMKFKH LIPJNAJHAJD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LBBBGACCBHD LNGAPHKLFPJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GDEBNNLIJNE EFOJCKLDKBK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HBKDHLJOIPN OCIIBKKEOHB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KDNNLGKAODI JIJGOJOFJEJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PPALFADLCAC JDKBDKOGGIO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event GKDOPHPBCKM EBOLOCLJDBG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IEJFFJLPIEN OIEPDAEMHMA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event BHIPCNABECG MFEJGKNDJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LBBBGACCBHD();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GDEBNNLIJNE();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void HBKDHLJOIPN();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void PPALFADLCAC();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GKDOPHPBCKM();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IEJFFJLPIEN();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void KDNNLGKAODI();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void KFBEGDMKFKH(bool OGOPMOHCAML);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void BHIPCNABECG();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5858BB0", Offset = "0x5857BB0", VA = "0x185858BB0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5858CB0", Offset = "0x5857CB0", VA = "0x185858CB0")]
		public static void SafeDestroyGameObject(GameObject PKGBHIMGLPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LBEKONMCFKE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool GKKHAKBPKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5858E90", Offset = "0x5857E90", VA = "0x185858E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5858DF0", Offset = "0x5857DF0", VA = "0x185858DF0")]
	[BHDPALLLPBG(PKIMCINHCCF.Unity_AfterSceneLoad)]
	private static void AICHPOAHICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5858ED0", Offset = "0x5857ED0", VA = "0x185858ED0")]
	internal static void EIGNFBEPGNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MAJJMCAENPD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CKLKBLKGKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> KLPGKAONFBE;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(MAJJMCAENPD ICLBJJNEBII);
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
