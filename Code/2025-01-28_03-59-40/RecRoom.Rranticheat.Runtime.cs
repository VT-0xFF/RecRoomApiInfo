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
	public class EACManager : MonoBehaviour, PFKOLPLMEOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth IOELOFLLDEM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EDOPADPFCLH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79CEC40", Offset = "0x79CDE40", VA = "0x1879CEC40")]
		public static string GenerateChallengeResponse(string FELKCCHFADD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79CEDD0", Offset = "0x79CDFD0", VA = "0x1879CEDD0")]
		private static void IFHFGGDAAOK(ACPBIFGADHM.JIOPIBNKEEK OCPJHHIMKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CE930", Offset = "0x79CDB30", VA = "0x1879CE930")]
		private static bool FFNDKKJOGKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79CED50", Offset = "0x79CDF50", VA = "0x1879CED50")]
		private static void HKOAJGGDECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x79CEEA0", Offset = "0x79CE0A0", VA = "0x1879CEEA0")]
		private static void MNCMOPOCJBP(object ONKMLFJIAEH, LoadProgressEventArgs JFCBLKPMPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79CF0E0", Offset = "0x79CE2E0", VA = "0x1879CF0E0")]
		private static void PKLMFHMHHDJ(object ONKMLFJIAEH, LoadCompletedEventArgs JFCBLKPMPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x79CE790", Offset = "0x79CD990", VA = "0x1879CE790")]
		private static void EKFPBNGEGIF(object ONKMLFJIAEH, StateChangedEventArgs JFCBLKPMPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79CF380", Offset = "0x79CE580", VA = "0x1879CF380")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79CF510", Offset = "0x79CE710", VA = "0x1879CF510")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79CEFB0", Offset = "0x79CE1B0", VA = "0x1879CEFB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x79CED50", Offset = "0x79CDF50", VA = "0x1879CED50")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79CEC00", Offset = "0x79CDE00", VA = "0x1879CEC00")]
		private void GFEDOLCIMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x79CF2B0", Offset = "0x79CE4B0", VA = "0x1879CF2B0", Slot = "4")]
		public void PushNetworkMessage(ACPBIFGADHM.JIOPIBNKEEK OCPJHHIMKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
