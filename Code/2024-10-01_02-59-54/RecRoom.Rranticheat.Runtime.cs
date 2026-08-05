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
	public class EACManager : MonoBehaviour, KINLOJJPEGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth MCKMMJCBCGL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EKEFDHJLEKN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x752D0D0", Offset = "0x752C4D0", VA = "0x18752D0D0")]
		public static string GenerateChallengeResponse(string IEFHGKAJODL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x752D440", Offset = "0x752C840", VA = "0x18752D440")]
		private static void OFJHMHDKIGI(GCKAFCEOIOO.KGNFMBLLAIH NNNHDMLPIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x752CE00", Offset = "0x752C200", VA = "0x18752CE00")]
		private static bool GMDMKHFJKDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x752D220", Offset = "0x752C620", VA = "0x18752D220")]
		private static void IIBDHCGOGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x752CB20", Offset = "0x752BF20", VA = "0x18752CB20")]
		private static void EDHOOPICDLD(object MMAGMKBAGDJ, LoadProgressEventArgs IOIICCDDIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x752CC30", Offset = "0x752C030", VA = "0x18752CC30")]
		private static void FACPGBIHJMG(object MMAGMKBAGDJ, LoadCompletedEventArgs IOIICCDDIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x752D2A0", Offset = "0x752C6A0", VA = "0x18752D2A0")]
		private static void JDOPEBPACED(object MMAGMKBAGDJ, StateChangedEventArgs IOIICCDDIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x752D700", Offset = "0x752CB00", VA = "0x18752D700")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x752D880", Offset = "0x752CC80", VA = "0x18752D880")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x752D510", Offset = "0x752C910", VA = "0x18752D510")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x752D220", Offset = "0x752C620", VA = "0x18752D220")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x752D1E0", Offset = "0x752C5E0", VA = "0x18752D1E0")]
		private void IBBHKKGIJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x752D630", Offset = "0x752CA30", VA = "0x18752D630", Slot = "4")]
		public void PushNetworkMessage(GCKAFCEOIOO.KGNFMBLLAIH NNNHDMLPIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
