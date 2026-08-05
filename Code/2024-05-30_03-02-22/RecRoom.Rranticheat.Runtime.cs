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
	public class EACManager : MonoBehaviour, KLAEBBOLLOE
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth GBJHKOFOLEO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FNAAKPEGGDI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A992D0", Offset = "0x6A984D0", VA = "0x186A992D0")]
		public static string GenerateChallengeResponse(string DBGILFOPNOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A995B0", Offset = "0x6A987B0", VA = "0x186A995B0")]
		private static void ODAGPLKCHLD(ODADENGCNJP.LNEHLLEENAB EIAKFCMMIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A99000", Offset = "0x6A98200", VA = "0x186A99000")]
		private static bool GLEHJPOGFLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A98F80", Offset = "0x6A98180", VA = "0x186A98F80")]
		private static void GHAPIEKFFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A98E30", Offset = "0x6A98030", VA = "0x186A98E30")]
		private static void CGPJKBJPIAP(object AGIKKFANKBP, LoadProgressEventArgs BKCEDPGPJGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A993E0", Offset = "0x6A985E0", VA = "0x186A993E0")]
		private static void MNKLNEHIPEM(object AGIKKFANKBP, LoadCompletedEventArgs BKCEDPGPJGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A99680", Offset = "0x6A98880", VA = "0x186A99680")]
		private static void OFJHPABBPOE(object AGIKKFANKBP, StateChangedEventArgs BKCEDPGPJGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A99A20", Offset = "0x6A98C20", VA = "0x186A99A20")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A99BB0", Offset = "0x6A98DB0", VA = "0x186A99BB0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6A99820", Offset = "0x6A98A20", VA = "0x186A99820")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A98F80", Offset = "0x6A98180", VA = "0x186A98F80")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A98F40", Offset = "0x6A98140", VA = "0x186A98F40")]
		private void GELMDBBLNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A99950", Offset = "0x6A98B50", VA = "0x186A99950", Slot = "4")]
		public void PushNetworkMessage(ODADENGCNJP.LNEHLLEENAB EIAKFCMMIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
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
