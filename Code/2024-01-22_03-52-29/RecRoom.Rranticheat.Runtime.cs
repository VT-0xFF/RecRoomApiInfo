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
	public class EACManager : MonoBehaviour, HKKADADMFLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth CIPPEPFEMEO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KFLGLCPJHNI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6676680", Offset = "0x6675A80", VA = "0x186676680")]
		public static string GenerateChallengeResponse(string FOHMBBDLGCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6676790", Offset = "0x6675B90", VA = "0x186676790")]
		private static void IEEJNKKHMCG(GNNCAACKPPH.MJNMGLDPOJM JFKHFDHADBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66768E0", Offset = "0x6675CE0", VA = "0x1866768E0")]
		private static bool LPMMMGBLIGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6676860", Offset = "0x6675C60", VA = "0x186676860")]
		private static void LELACDPAINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6676570", Offset = "0x6675970", VA = "0x186676570")]
		private static void FIEACOOJHAC(object MGNFJOHPLBA, LoadProgressEventArgs ENODGAHJCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66761C0", Offset = "0x66755C0", VA = "0x1866761C0")]
		private static void BIAAEKJDFPG(object MGNFJOHPLBA, LoadCompletedEventArgs ENODGAHJCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6676390", Offset = "0x6675790", VA = "0x186676390")]
		private static void CIKFHHMOMML(object MGNFJOHPLBA, StateChangedEventArgs ENODGAHJCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6676DB0", Offset = "0x66761B0", VA = "0x186676DB0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6676F40", Offset = "0x6676340", VA = "0x186676F40")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6676BB0", Offset = "0x6675FB0", VA = "0x186676BB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6676860", Offset = "0x6675C60", VA = "0x186676860")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6676530", Offset = "0x6675930", VA = "0x186676530")]
		private void EPOBFPFDCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6676CE0", Offset = "0x66760E0", VA = "0x186676CE0", Slot = "4")]
		public void PushNetworkMessage(GNNCAACKPPH.MJNMGLDPOJM JFKHFDHADBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
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
