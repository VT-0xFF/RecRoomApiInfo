using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using EasyAntiCheat.Client;
using EasyAntiCheat.Client.ClientAuth;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AntiCheat
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class EACManager : MonoBehaviour, NDIBLPMCGNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth LHDFDBIPBNM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CIHMBAPJFIK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72D0C60", Offset = "0x72CFC60", VA = "0x1872D0C60")]
		public static string GenerateChallengeResponse(string ELBCKNGGECO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72D0AF0", Offset = "0x72CFAF0", VA = "0x1872D0AF0")]
		private static void GDFICMDIEHO(FOMFBKJNJOM.KKEFOJFNNBH EMBONFDCNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72D10E0", Offset = "0x72D00E0", VA = "0x1872D10E0")]
		private static bool PJDKJBFLONK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72D0BD0", Offset = "0x72CFBD0", VA = "0x1872D0BD0")]
		private static void GFACELABJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72D09D0", Offset = "0x72CF9D0", VA = "0x1872D09D0")]
		private static void BLBPOPAGKNL(object PCPFAFBEAGD, LoadProgressEventArgs HDNELHAIGOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72D0EE0", Offset = "0x72CFEE0", VA = "0x1872D0EE0")]
		private static void PJBEPABGENK(object PCPFAFBEAGD, LoadCompletedEventArgs HDNELHAIGOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72D0810", Offset = "0x72CF810", VA = "0x1872D0810")]
		private static void AHAADDONNEE(object PCPFAFBEAGD, StateChangedEventArgs HDNELHAIGOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72D14D0", Offset = "0x72D04D0", VA = "0x1872D14D0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72D1640", Offset = "0x72D0640", VA = "0x1872D1640")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72D0DE0", Offset = "0x72CFDE0", VA = "0x1872D0DE0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72D0BD0", Offset = "0x72CFBD0", VA = "0x1872D0BD0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72D0D90", Offset = "0x72CFD90", VA = "0x1872D0D90")]
		private void JIODBFONOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72D13F0", Offset = "0x72D03F0", VA = "0x1872D13F0", Slot = "4")]
		public void PushNetworkMessage(FOMFBKJNJOM.KKEFOJFNNBH EMBONFDCNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public EACManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
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
