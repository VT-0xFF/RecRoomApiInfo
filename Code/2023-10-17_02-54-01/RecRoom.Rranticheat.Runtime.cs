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
	public class EACManager : MonoBehaviour, OBMNABLFGGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth PPBFAPIKJBN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EOMEIKJLJKM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x62C5AC0", Offset = "0x62C42C0", VA = "0x1862C5AC0")]
		public static string GenerateChallengeResponse(string ALFELJLBNPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62C5FF0", Offset = "0x62C47F0", VA = "0x1862C5FF0")]
		private static void NKAIOLIFEML(BJDOIIEJCCL.CIDCAIHFPJM KAAIDPFBBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62C5C10", Offset = "0x62C4410", VA = "0x1862C5C10")]
		private static bool IEIAGKPPAPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62C5870", Offset = "0x62C4070", VA = "0x1862C5870")]
		private static void FIDJGDLIFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62C5EE0", Offset = "0x62C46E0", VA = "0x1862C5EE0")]
		private static void MOFKHBCMDHN(object FLHFAHCCAHB, LoadProgressEventArgs CMKKIGKBAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62C58F0", Offset = "0x62C40F0", VA = "0x1862C58F0")]
		private static void FKPBNFMIEMD(object FLHFAHCCAHB, LoadCompletedEventArgs CMKKIGKBAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62C56D0", Offset = "0x62C3ED0", VA = "0x1862C56D0")]
		private static void AOPFFNMKDPP(object FLHFAHCCAHB, StateChangedEventArgs CMKKIGKBAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62C62C0", Offset = "0x62C4AC0", VA = "0x1862C62C0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62C6450", Offset = "0x62C4C50", VA = "0x1862C6450")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62C60C0", Offset = "0x62C48C0", VA = "0x1862C60C0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62C5870", Offset = "0x62C4070", VA = "0x1862C5870")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62C5BD0", Offset = "0x62C43D0", VA = "0x1862C5BD0")]
		private void HOPLNLCHFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62C61F0", Offset = "0x62C49F0", VA = "0x1862C61F0", Slot = "4")]
		public void PushNetworkMessage(BJDOIIEJCCL.CIDCAIHFPJM KAAIDPFBBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
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
