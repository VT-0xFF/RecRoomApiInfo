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
		[Cpp2IlInjected.Address(RVA = "0x70050D0", Offset = "0x70042D0", VA = "0x1870050D0")]
		public static string GenerateChallengeResponse(string HDCKIBFNKDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70051E0", Offset = "0x70043E0", VA = "0x1870051E0")]
		private static void JAGDGAJHHED(BOJDFOBAFDK.CLDJBMNPCIJ MIJPDJDOIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70056C0", Offset = "0x70048C0", VA = "0x1870056C0")]
		private static bool PPPPGEJLLIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7004EB0", Offset = "0x70040B0", VA = "0x187004EB0")]
		private static void DMHAOHNINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7005480", Offset = "0x7004680", VA = "0x187005480")]
		private static void NHALPKALAAC(object EEPCBCALBIK, LoadProgressEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70052B0", Offset = "0x70044B0", VA = "0x1870052B0")]
		private static void LNDECEPEHBN(object EEPCBCALBIK, LoadCompletedEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7004F30", Offset = "0x7004130", VA = "0x187004F30")]
		private static void GOGHEGOHDPF(object EEPCBCALBIK, StateChangedEventArgs EKFLNDFCGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7005A60", Offset = "0x7004C60", VA = "0x187005A60")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7005BF0", Offset = "0x7004DF0", VA = "0x187005BF0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7005590", Offset = "0x7004790", VA = "0x187005590")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7004EB0", Offset = "0x70040B0", VA = "0x187004EB0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7004E70", Offset = "0x7004070", VA = "0x187004E70")]
		private void CIGAMIADOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7005990", Offset = "0x7004B90", VA = "0x187005990", Slot = "4")]
		public void PushNetworkMessage(BOJDFOBAFDK.CLDJBMNPCIJ MIJPDJDOIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
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
