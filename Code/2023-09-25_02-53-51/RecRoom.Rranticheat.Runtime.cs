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
	public class EACManager : MonoBehaviour, APPGNMMHMMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth JINGIBFHIEM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool JBDKMOLBCHJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x62BB550", Offset = "0x62BA950", VA = "0x1862BB550")]
		public static string GenerateChallengeResponse(string OEOIFLLIJMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62BB050", Offset = "0x62BA450", VA = "0x1862BB050")]
		private static void AAFKKMOLPJO(IEBOEGMDOBJ.LNLDHJCAPIK CJFCIOOMJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62BB770", Offset = "0x62BAB70", VA = "0x1862BB770")]
		private static bool OOIKIFNMMCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62BB2C0", Offset = "0x62BA6C0", VA = "0x1862BB2C0")]
		private static void CNJGFKFKKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62BB660", Offset = "0x62BAA60", VA = "0x1862BB660")]
		private static void KIIHMIJGJFB(object FNMNBJEPLBI, LoadProgressEventArgs EHFLGPPKDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62BB380", Offset = "0x62BA780", VA = "0x1862BB380")]
		private static void FBGIADFDOPB(object FNMNBJEPLBI, LoadCompletedEventArgs EHFLGPPKDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62BB120", Offset = "0x62BA520", VA = "0x1862BB120")]
		private static void CEBDKIHBAFO(object FNMNBJEPLBI, StateChangedEventArgs EHFLGPPKDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62BBC40", Offset = "0x62BB040", VA = "0x1862BBC40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62BBDD0", Offset = "0x62BB1D0", VA = "0x1862BBDD0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62BBA40", Offset = "0x62BAE40", VA = "0x1862BBA40")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62BB2C0", Offset = "0x62BA6C0", VA = "0x1862BB2C0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62BB340", Offset = "0x62BA740", VA = "0x1862BB340")]
		private void ELNIPFHKDPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62BBB70", Offset = "0x62BAF70", VA = "0x1862BBB70", Slot = "4")]
		public void PushNetworkMessage(IEBOEGMDOBJ.LNLDHJCAPIK CJFCIOOMJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
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
