using System;
using System.Reflection;
using Cpp2IlInjected;
using EasyAntiCheat.Client;
using EasyAntiCheat.Client.ClientAuth;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AntiCheat
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class EACManager : MonoBehaviour, MKLHMCKDPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth KEOHKFLNEDC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool INHEMPNAFDG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F48B40", Offset = "0x6F47340", VA = "0x186F48B40")]
		public static string GenerateChallengeResponse(string PBIFHGGADAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F488A0", Offset = "0x6F470A0", VA = "0x186F488A0")]
		private static void EKICKJDEAOJ(JJOLLADBMCK.EEAGINFPNLB EMIMPCIEFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F483F0", Offset = "0x6F46BF0", VA = "0x186F483F0")]
		private static bool AFBHANJHEJO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F48370", Offset = "0x6F46B70", VA = "0x186F48370")]
		private static void AADLEMKHFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F48C50", Offset = "0x6F47450", VA = "0x186F48C50")]
		private static void MIFKNHNNNMP(object PFBKDLOKJDO, LoadProgressEventArgs EDBDHICBOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F48970", Offset = "0x6F47170", VA = "0x186F48970")]
		private static void GEJJEHODPHO(object PFBKDLOKJDO, LoadCompletedEventArgs EDBDHICBOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F48700", Offset = "0x6F46F00", VA = "0x186F48700")]
		private static void BGDDDIGFDCK(object PFBKDLOKJDO, StateChangedEventArgs EDBDHICBOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F48F50", Offset = "0x6F47750", VA = "0x186F48F50")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F490D0", Offset = "0x6F478D0", VA = "0x186F490D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F48D60", Offset = "0x6F47560", VA = "0x186F48D60")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F48370", Offset = "0x6F46B70", VA = "0x186F48370")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F486C0", Offset = "0x6F46EC0", VA = "0x186F486C0")]
		private void ALJAIFJLHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F48E80", Offset = "0x6F47680", VA = "0x186F48E80", Slot = "4")]
		public void PushNetworkMessage(JJOLLADBMCK.EEAGINFPNLB EMIMPCIEFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public EACManager()
		{
		}
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
