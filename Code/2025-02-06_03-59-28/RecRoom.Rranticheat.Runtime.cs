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
	public class EACManager : MonoBehaviour, BFKFHPBOKNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth LFJKDFEENJC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FPKIAPAIAPE;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A36260", Offset = "0x7A35060", VA = "0x187A36260")]
		public static string GenerateChallengeResponse(string OGPACDDBKMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7A363F0", Offset = "0x7A351F0", VA = "0x187A363F0")]
		private static void ILKLHIKPPPA(EDCPECPLKOC.NJKMLPCKDOF KGDIEBJBNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A36660", Offset = "0x7A35460", VA = "0x187A36660")]
		private static bool MABAGPNFIJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A36370", Offset = "0x7A35170", VA = "0x187A36370")]
		private static void HABLNLIONGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A35F80", Offset = "0x7A34D80", VA = "0x187A35F80")]
		private static void BCDEENLIPEF(object PPALLENNKLD, LoadProgressEventArgs BPGHDGEBGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A36090", Offset = "0x7A34E90", VA = "0x187A36090")]
		private static void BMFJBDJMOIB(object PPALLENNKLD, LoadCompletedEventArgs BPGHDGEBGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A364C0", Offset = "0x7A352C0", VA = "0x187A364C0")]
		private static void LMHOBBOJDAJ(object PPALLENNKLD, StateChangedEventArgs BPGHDGEBGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A36B30", Offset = "0x7A35930", VA = "0x187A36B30")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A36CC0", Offset = "0x7A35AC0", VA = "0x187A36CC0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A36930", Offset = "0x7A35730", VA = "0x187A36930")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A36370", Offset = "0x7A35170", VA = "0x187A36370")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A35F40", Offset = "0x7A34D40", VA = "0x187A35F40")]
		private void ADPNAPIDOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A36A60", Offset = "0x7A35860", VA = "0x187A36A60", Slot = "4")]
		public void PushNetworkMessage(EDCPECPLKOC.NJKMLPCKDOF KGDIEBJBNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
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
