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
	public class EACManager : MonoBehaviour, EHPNFCFCHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth NNNJHIGDPCB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool LDJHPHJPBBB;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68737A0", Offset = "0x68729A0", VA = "0x1868737A0")]
		public static string GenerateChallengeResponse(string CICNMEHLJIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6873DA0", Offset = "0x6872FA0", VA = "0x186873DA0")]
		private static void LLDGEAOIPPA(FGFCIBNLKEO.AFKIOBFIJNO AENCBMJJMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68738B0", Offset = "0x6872AB0", VA = "0x1868738B0")]
		private static bool HGGIKMGNPFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6873B80", Offset = "0x6872D80", VA = "0x186873B80")]
		private static void HJCHCLCFOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6873EB0", Offset = "0x68730B0", VA = "0x186873EB0")]
		private static void NONIBEBJJBJ(object AFBKECIDIIA, LoadProgressEventArgs KCBEMOFAFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68735D0", Offset = "0x68727D0", VA = "0x1868735D0")]
		private static void FKHOANAFEME(object AFBKECIDIIA, LoadCompletedEventArgs KCBEMOFAFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6873C00", Offset = "0x6872E00", VA = "0x186873C00")]
		private static void KAONMJOMABI(object AFBKECIDIIA, StateChangedEventArgs KCBEMOFAFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68741B0", Offset = "0x68733B0", VA = "0x1868741B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6874330", Offset = "0x6873530", VA = "0x186874330")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6873FC0", Offset = "0x68731C0", VA = "0x186873FC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6873B80", Offset = "0x6872D80", VA = "0x186873B80")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6873E70", Offset = "0x6873070", VA = "0x186873E70")]
		private void LOBOMAEDIOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68740E0", Offset = "0x68732E0", VA = "0x1868740E0", Slot = "4")]
		public void PushNetworkMessage(FGFCIBNLKEO.AFKIOBFIJNO AENCBMJJMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
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
