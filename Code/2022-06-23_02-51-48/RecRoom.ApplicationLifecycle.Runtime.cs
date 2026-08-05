using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DOPHOGLGFOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NFMOAAILIHL AFNBENHEOPN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event MOMCLPPLDPK BOOBIECFMHO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LNCADKMOIKK IHKBPLEMDPD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BBONPFEBLCP JPMOHPEOFLN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DDPKAHFNNJK EADOLPAKPNF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OGDLICOJOJN NJCCEPDGOIG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event MODAODFBDFM EENHEHCHIIL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CAJKILCHCAP CIAPGFNEFFN;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void MOMCLPPLDPK();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void LNCADKMOIKK();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void BBONPFEBLCP();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void OGDLICOJOJN();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MODAODFBDFM();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void DDPKAHFNNJK();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NFMOAAILIHL(bool FKCKKNLICLB);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void CAJKILCHCAP();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3800", Offset = "0x4FF2A00", VA = "0x184FF3800")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3900", Offset = "0x4FF2B00", VA = "0x184FF3900")]
		public static void SafeDestroyGameObject(GameObject JMCMCLEMHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NKCHBNJMPBD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool ECBCGHBKCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3AE0", Offset = "0x4FF2CE0", VA = "0x184FF3AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3A40", Offset = "0x4FF2C40", VA = "0x184FF3A40")]
	[NMODJAENCHM(APAEGONANLC.Unity_AfterSceneLoad)]
	private static void GDDEOJNJOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3B20", Offset = "0x4FF2D20", VA = "0x184FF3B20")]
	internal static void MPMFHDJLHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MEJLFBFMBFH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool AFDLAPDIFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<bool> OFHFBFEJAIC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(MEJLFBFMBFH FPGMENMHPEA);
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
