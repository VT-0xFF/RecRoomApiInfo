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
	public class EACManager : MonoBehaviour, JKHNNOLKOCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth DFAKJLNKPEE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DCLIBJGBPLF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6638E60", Offset = "0x6637C60", VA = "0x186638E60")]
		public static string GenerateChallengeResponse(string DMPIBGABAFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6638FB0", Offset = "0x6637DB0", VA = "0x186638FB0")]
		private static void JDMBLPOGEAO(JNGFGDKKPAJ.DGEDEHBHAHH PLFMLOLFNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6638B10", Offset = "0x6637910", VA = "0x186638B10")]
		private static bool DJBKFMJGMOC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6638DE0", Offset = "0x6637BE0", VA = "0x186638DE0")]
		private static void EOKAOLECMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6639080", Offset = "0x6637E80", VA = "0x186639080")]
		private static void NMJPECFHIFB(object DOADBPHFKPA, LoadProgressEventArgs AHIMEAGCCKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6638940", Offset = "0x6637740", VA = "0x186638940")]
		private static void DENJGADMFND(object DOADBPHFKPA, LoadCompletedEventArgs AHIMEAGCCKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66387A0", Offset = "0x66375A0", VA = "0x1866387A0")]
		private static void DDKDENHLDGK(object DOADBPHFKPA, StateChangedEventArgs AHIMEAGCCKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6639390", Offset = "0x6638190", VA = "0x186639390")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6639520", Offset = "0x6638320", VA = "0x186639520")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6639190", Offset = "0x6637F90", VA = "0x186639190")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6638DE0", Offset = "0x6637BE0", VA = "0x186638DE0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6638F70", Offset = "0x6637D70", VA = "0x186638F70")]
		private void HKBINNAJOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66392C0", Offset = "0x66380C0", VA = "0x1866392C0", Slot = "4")]
		public void PushNetworkMessage(JNGFGDKKPAJ.DGEDEHBHAHH PLFMLOLFNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
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
