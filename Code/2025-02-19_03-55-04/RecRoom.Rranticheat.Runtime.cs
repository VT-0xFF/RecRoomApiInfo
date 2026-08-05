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
	public class EACManager : MonoBehaviour, INKODIDMGDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth OEFAFKCGEIP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool NAEBBCBAIEM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8350", Offset = "0x7CA6F50", VA = "0x187CA8350")]
		public static string GenerateChallengeResponse(string JMLFDAMIECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7CA80E0", Offset = "0x7CA6CE0", VA = "0x187CA80E0")]
		private static void FLHPHMMGNMN(KJNKDPIKEHP.GJLJDFEJABK BFDCDDMLJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8570", Offset = "0x7CA7170", VA = "0x187CA8570")]
		private static bool MMADPFBJOGO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8880", Offset = "0x7CA7480", VA = "0x187CA8880")]
		private static void NGLEIJKMILB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8460", Offset = "0x7CA7060", VA = "0x187CA8460")]
		private static void LDMBLFPNENE(object DAHPADKNCHM, LoadProgressEventArgs EJKIMBGPIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7CA7F10", Offset = "0x7CA6B10", VA = "0x187CA7F10")]
		private static void FGDEPJILGGK(object DAHPADKNCHM, LoadCompletedEventArgs EJKIMBGPIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CA81B0", Offset = "0x7CA6DB0", VA = "0x187CA81B0")]
		private static void GAHBIOJPPPL(object DAHPADKNCHM, StateChangedEventArgs EJKIMBGPIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8AF0", Offset = "0x7CA76F0", VA = "0x187CA8AF0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8C70", Offset = "0x7CA7870", VA = "0x187CA8C70")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8900", Offset = "0x7CA7500", VA = "0x187CA8900")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8880", Offset = "0x7CA7480", VA = "0x187CA8880")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8840", Offset = "0x7CA7440", VA = "0x187CA8840")]
		private void MPOAMPHLBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8A20", Offset = "0x7CA7620", VA = "0x187CA8A20", Slot = "4")]
		public void PushNetworkMessage(KJNKDPIKEHP.GJLJDFEJABK BFDCDDMLJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
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
