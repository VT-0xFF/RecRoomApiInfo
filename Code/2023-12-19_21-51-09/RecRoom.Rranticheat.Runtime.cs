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
	public class EACManager : MonoBehaviour, KDOAAIGAKPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth MLBLDPCGODL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CLOIOJMLEAD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6456F00", Offset = "0x6455B00", VA = "0x186456F00")]
		public static string GenerateChallengeResponse(string BFAJMAKEGAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6457270", Offset = "0x6455E70", VA = "0x186457270")]
		private static void MBMCGAJCDNL(HKMHKJKBMDH.LIEOEFPPHNO AGEBEEELPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6456950", Offset = "0x6455550", VA = "0x186456950")]
		private static bool DFEJDJGHMCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6457050", Offset = "0x6455C50", VA = "0x186457050")]
		private static void IOPBDLDFABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6456DF0", Offset = "0x64559F0", VA = "0x186456DF0")]
		private static void GLPHKELLBGI(object OJEFACDOGEP, LoadProgressEventArgs GPKKLIMOJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6456C20", Offset = "0x6455820", VA = "0x186456C20")]
		private static void GGKECJAKDPN(object OJEFACDOGEP, LoadCompletedEventArgs GPKKLIMOJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64570D0", Offset = "0x6455CD0", VA = "0x1864570D0")]
		private static void MBLHPIBMCLH(object OJEFACDOGEP, StateChangedEventArgs GPKKLIMOJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6457540", Offset = "0x6456140", VA = "0x186457540")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64576D0", Offset = "0x64562D0", VA = "0x1864576D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6457340", Offset = "0x6455F40", VA = "0x186457340")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6457050", Offset = "0x6455C50", VA = "0x186457050")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6457010", Offset = "0x6455C10", VA = "0x186457010")]
		private void INFBHKDBHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6457470", Offset = "0x6456070", VA = "0x186457470", Slot = "4")]
		public void PushNetworkMessage(HKMHKJKBMDH.LIEOEFPPHNO AGEBEEELPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
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
