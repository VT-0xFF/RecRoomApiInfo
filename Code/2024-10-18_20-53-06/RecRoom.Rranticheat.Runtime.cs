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
	public class EACManager : MonoBehaviour, CKAKLPMOAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FNHOFJJIEJK;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool HAPJDFJPJFG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x751CF20", Offset = "0x751C320", VA = "0x18751CF20")]
		public static string GenerateChallengeResponse(string JPIHLGBDMPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x751D290", Offset = "0x751C690", VA = "0x18751D290")]
		private static void OONJBELCLOO(MPHIMKHIPLO.NBKNFLKDLGM GKKLHKCNNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x751CA80", Offset = "0x751BE80", VA = "0x18751CA80")]
		private static bool ECBLOKMOMBD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x751D210", Offset = "0x751C610", VA = "0x18751D210")]
		private static void MPJCGDGAIGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x751C970", Offset = "0x751BD70", VA = "0x18751C970")]
		private static void CKGJKEOHHGA(object DLIGAMDFIAE, LoadProgressEventArgs HBFCAEMPBIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x751CD50", Offset = "0x751C150", VA = "0x18751CD50")]
		private static void FKBGEMKPIHL(object DLIGAMDFIAE, LoadCompletedEventArgs HBFCAEMPBIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x751D030", Offset = "0x751C430", VA = "0x18751D030")]
		private static void MKAFODMCJIL(object DLIGAMDFIAE, StateChangedEventArgs HBFCAEMPBIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x751D550", Offset = "0x751C950", VA = "0x18751D550")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x751D6D0", Offset = "0x751CAD0", VA = "0x18751D6D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x751D360", Offset = "0x751C760", VA = "0x18751D360")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x751D210", Offset = "0x751C610", VA = "0x18751D210")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x751D1D0", Offset = "0x751C5D0", VA = "0x18751D1D0")]
		private void MOCHDKHCPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x751D480", Offset = "0x751C880", VA = "0x18751D480", Slot = "4")]
		public void PushNetworkMessage(MPHIMKHIPLO.NBKNFLKDLGM GKKLHKCNNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
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
