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
	public class EACManager : MonoBehaviour, GLMGILOKIAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth JBBMFBLGDJA;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool JFLCLBELJCN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x62C54F0", Offset = "0x62C42F0", VA = "0x1862C54F0")]
		public static string GenerateChallengeResponse(string GEKAGBDHCHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62C5420", Offset = "0x62C4220", VA = "0x1862C5420")]
		private static void FOHFKPBIOLK(NNDABIECKNC.DDNIFLNFHDJ JPGMJABDIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62C58B0", Offset = "0x62C46B0", VA = "0x1862C58B0")]
		private static bool KDEEOCGAKBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62C5360", Offset = "0x62C4160", VA = "0x1862C5360")]
		private static void AFCKBFEAFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62C57A0", Offset = "0x62C45A0", VA = "0x1862C57A0")]
		private static void IDKLDLDCIIM(object MDBCIPILAGP, LoadProgressEventArgs CNPNNHEJECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62C5CB0", Offset = "0x62C4AB0", VA = "0x1862C5CB0")]
		private static void PGNDBALBCMO(object MDBCIPILAGP, LoadCompletedEventArgs CNPNNHEJECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62C5600", Offset = "0x62C4400", VA = "0x1862C5600")]
		private static void HLEOFLMJFOC(object MDBCIPILAGP, StateChangedEventArgs CNPNNHEJECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62C5F50", Offset = "0x62C4D50", VA = "0x1862C5F50")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62C60E0", Offset = "0x62C4EE0", VA = "0x1862C60E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62C5B80", Offset = "0x62C4980", VA = "0x1862C5B80")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62C5360", Offset = "0x62C4160", VA = "0x1862C5360")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62C53E0", Offset = "0x62C41E0", VA = "0x1862C53E0")]
		private void ANDDMCCACPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62C5E80", Offset = "0x62C4C80", VA = "0x1862C5E80", Slot = "4")]
		public void PushNetworkMessage(NNDABIECKNC.DDNIFLNFHDJ JPGMJABDIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
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
