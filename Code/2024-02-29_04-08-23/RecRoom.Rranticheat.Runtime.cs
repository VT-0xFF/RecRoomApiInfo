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
	public class EACManager : MonoBehaviour, AGGBOLOJAOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth CFOIJFFKCDN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool AFGBFMPGEME;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66156B0", Offset = "0x66144B0", VA = "0x1866156B0")]
		public static string GenerateChallengeResponse(string FJKOMOOALFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66155E0", Offset = "0x66143E0", VA = "0x1866155E0")]
		private static void GGNDECEIONB(HDJLKKJJAKI.HCOACOMLMDA FCMJAHOHNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6615310", Offset = "0x6614110", VA = "0x186615310")]
		private static bool FHDDOFFADAL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6615960", Offset = "0x6614760", VA = "0x186615960")]
		private static void JHIKDDIAMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66159E0", Offset = "0x66147E0", VA = "0x1866159E0")]
		private static void MOAKENOHDPH(object ECAJJALPIEL, LoadProgressEventArgs HCOIPILALII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6615140", Offset = "0x6613F40", VA = "0x186615140")]
		private static void EKKOJNFENJK(object ECAJJALPIEL, LoadCompletedEventArgs HCOIPILALII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66157C0", Offset = "0x66145C0", VA = "0x1866157C0")]
		private static void HLIEDDINFDD(object ECAJJALPIEL, StateChangedEventArgs HCOIPILALII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6615CF0", Offset = "0x6614AF0", VA = "0x186615CF0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6615E80", Offset = "0x6614C80", VA = "0x186615E80")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6615AF0", Offset = "0x66148F0", VA = "0x186615AF0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6615960", Offset = "0x6614760", VA = "0x186615960")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6615100", Offset = "0x6613F00", VA = "0x186615100")]
		private void DHEGIDLDMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6615C20", Offset = "0x6614A20", VA = "0x186615C20", Slot = "4")]
		public void PushNetworkMessage(HDJLKKJJAKI.HCOACOMLMDA FCMJAHOHNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
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
