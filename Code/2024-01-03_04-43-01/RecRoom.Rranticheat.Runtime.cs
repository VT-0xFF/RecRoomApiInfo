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
		[Cpp2IlInjected.Address(RVA = "0x6456F90", Offset = "0x6455B90", VA = "0x186456F90")]
		public static string GenerateChallengeResponse(string BFAJMAKEGAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6457300", Offset = "0x6455F00", VA = "0x186457300")]
		private static void MBMCGAJCDNL(HKMHKJKBMDH.LIEOEFPPHNO AGEBEEELPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64569E0", Offset = "0x64555E0", VA = "0x1864569E0")]
		private static bool DFEJDJGHMCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64570E0", Offset = "0x6455CE0", VA = "0x1864570E0")]
		private static void IOPBDLDFABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6456E80", Offset = "0x6455A80", VA = "0x186456E80")]
		private static void GLPHKELLBGI(object OJEFACDOGEP, LoadProgressEventArgs GPKKLIMOJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6456CB0", Offset = "0x64558B0", VA = "0x186456CB0")]
		private static void GGKECJAKDPN(object OJEFACDOGEP, LoadCompletedEventArgs GPKKLIMOJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6457160", Offset = "0x6455D60", VA = "0x186457160")]
		private static void MBLHPIBMCLH(object OJEFACDOGEP, StateChangedEventArgs GPKKLIMOJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64575D0", Offset = "0x64561D0", VA = "0x1864575D0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6457760", Offset = "0x6456360", VA = "0x186457760")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64573D0", Offset = "0x6455FD0", VA = "0x1864573D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64570E0", Offset = "0x6455CE0", VA = "0x1864570E0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64570A0", Offset = "0x6455CA0", VA = "0x1864570A0")]
		private void INFBHKDBHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6457500", Offset = "0x6456100", VA = "0x186457500", Slot = "4")]
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
