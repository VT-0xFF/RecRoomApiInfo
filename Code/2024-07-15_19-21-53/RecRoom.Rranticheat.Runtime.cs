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
		[Cpp2IlInjected.Address(RVA = "0x6FE5870", Offset = "0x6FE4070", VA = "0x186FE5870")]
		public static string GenerateChallengeResponse(string HDCKIBFNKDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5980", Offset = "0x6FE4180", VA = "0x186FE5980")]
		private static void JAGDGAJHHED(BOJDFOBAFDK.CLDJBMNPCIJ MIJPDJDOIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5E60", Offset = "0x6FE4660", VA = "0x186FE5E60")]
		private static bool PPPPGEJLLIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5650", Offset = "0x6FE3E50", VA = "0x186FE5650")]
		private static void DMHAOHNINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5C20", Offset = "0x6FE4420", VA = "0x186FE5C20")]
		private static void NHALPKALAAC(object EEPCBCALBIK, LoadProgressEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5A50", Offset = "0x6FE4250", VA = "0x186FE5A50")]
		private static void LNDECEPEHBN(object EEPCBCALBIK, LoadCompletedEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FE56D0", Offset = "0x6FE3ED0", VA = "0x186FE56D0")]
		private static void GOGHEGOHDPF(object EEPCBCALBIK, StateChangedEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6200", Offset = "0x6FE4A00", VA = "0x186FE6200")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6390", Offset = "0x6FE4B90", VA = "0x186FE6390")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5D30", Offset = "0x6FE4530", VA = "0x186FE5D30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5650", Offset = "0x6FE3E50", VA = "0x186FE5650")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5610", Offset = "0x6FE3E10", VA = "0x186FE5610")]
		private void CIGAMIADOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6130", Offset = "0x6FE4930", VA = "0x186FE6130", Slot = "4")]
		public void PushNetworkMessage(BOJDFOBAFDK.CLDJBMNPCIJ MIJPDJDOIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
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
