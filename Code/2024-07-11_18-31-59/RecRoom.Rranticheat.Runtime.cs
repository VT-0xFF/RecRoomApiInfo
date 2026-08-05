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
	public class EACManager : MonoBehaviour, HFHEDDGPOMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FLMGMFKPBAB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OPLMKEEHLJM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6280", Offset = "0x6FE4C80", VA = "0x186FE6280")]
		public static string GenerateChallengeResponse(string HDCKIBFNKDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6390", Offset = "0x6FE4D90", VA = "0x186FE6390")]
		private static void JAGDGAJHHED(BOJDFOBAFDK.CLDJBMNPCIJ MIJPDJDOIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6870", Offset = "0x6FE5270", VA = "0x186FE6870")]
		private static bool PPPPGEJLLIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6060", Offset = "0x6FE4A60", VA = "0x186FE6060")]
		private static void DMHAOHNINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6630", Offset = "0x6FE5030", VA = "0x186FE6630")]
		private static void NHALPKALAAC(object EEPCBCALBIK, LoadProgressEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6460", Offset = "0x6FE4E60", VA = "0x186FE6460")]
		private static void LNDECEPEHBN(object EEPCBCALBIK, LoadCompletedEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FE60E0", Offset = "0x6FE4AE0", VA = "0x186FE60E0")]
		private static void GOGHEGOHDPF(object EEPCBCALBIK, StateChangedEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6C10", Offset = "0x6FE5610", VA = "0x186FE6C10")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6DA0", Offset = "0x6FE57A0", VA = "0x186FE6DA0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6740", Offset = "0x6FE5140", VA = "0x186FE6740")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6060", Offset = "0x6FE4A60", VA = "0x186FE6060")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6020", Offset = "0x6FE4A20", VA = "0x186FE6020")]
		private void CIGAMIADOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6B40", Offset = "0x6FE5540", VA = "0x186FE6B40", Slot = "4")]
		public void PushNetworkMessage(BOJDFOBAFDK.CLDJBMNPCIJ MIJPDJDOIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
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
