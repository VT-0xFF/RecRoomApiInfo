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
	public class EACManager : MonoBehaviour, MGAEAECAOBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth DFLILJALCCJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OHIENBBJPCN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D267A0", Offset = "0x7D24DA0", VA = "0x187D267A0")]
		public static string GenerateChallengeResponse(string BOBPHKCPJGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D261B0", Offset = "0x7D247B0", VA = "0x187D261B0")]
		private static void DJCGBCEDNHF(JCCNJGGJDFL.IHGLBGJFMDA GOAPBALNOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D26300", Offset = "0x7D24900", VA = "0x187D26300")]
		private static bool EECNCBKDLPN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D26280", Offset = "0x7D24880", VA = "0x187D26280")]
		private static void DLKKCPJBDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D268B0", Offset = "0x7D24EB0", VA = "0x187D268B0")]
		private static void JFKGEIFDCMI(object FNPCBNFJCBL, LoadProgressEventArgs IPOMBOOEGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D265D0", Offset = "0x7D24BD0", VA = "0x187D265D0")]
		private static void FOBOFHFIDAN(object FNPCBNFJCBL, LoadCompletedEventArgs IPOMBOOEGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D26AF0", Offset = "0x7D250F0", VA = "0x187D26AF0")]
		private static void PLBPNKBCJAC(object FNPCBNFJCBL, StateChangedEventArgs IPOMBOOEGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D26D60", Offset = "0x7D25360", VA = "0x187D26D60")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D26EF0", Offset = "0x7D254F0", VA = "0x187D26EF0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D269C0", Offset = "0x7D24FC0", VA = "0x187D269C0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D26280", Offset = "0x7D24880", VA = "0x187D26280")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D26170", Offset = "0x7D24770", VA = "0x187D26170")]
		private void BGJCDOONABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D26C90", Offset = "0x7D25290", VA = "0x187D26C90", Slot = "4")]
		public void PushNetworkMessage(JCCNJGGJDFL.IHGLBGJFMDA GOAPBALNOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
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
