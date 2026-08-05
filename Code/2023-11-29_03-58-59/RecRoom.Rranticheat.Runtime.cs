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
	public class EACManager : MonoBehaviour, CMLNMDHILIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth KHCFPDBHLLC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DCLNDFMKPEF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x64566C0", Offset = "0x6455AC0", VA = "0x1864566C0")]
		public static string GenerateChallengeResponse(string JEPAPAGHGCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64562C0", Offset = "0x64556C0", VA = "0x1864562C0")]
		private static void BBIAPNOODIH(POCNIECOCFL.ICDCADDGOKM LJIMLOGOIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64569A0", Offset = "0x6455DA0", VA = "0x1864569A0")]
		private static bool OGEDHCNAGEL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64564A0", Offset = "0x64558A0", VA = "0x1864564A0")]
		private static void FINBMFCHKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6456390", Offset = "0x6455790", VA = "0x186456390")]
		private static void FDINNCLMMMO(object MDPAJIKKLGB, LoadProgressEventArgs PKAIMBGOOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64567D0", Offset = "0x6455BD0", VA = "0x1864567D0")]
		private static void JFIGBCHKEEH(object MDPAJIKKLGB, LoadCompletedEventArgs PKAIMBGOOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6456520", Offset = "0x6455920", VA = "0x186456520")]
		private static void GHAOECHBHEJ(object MDPAJIKKLGB, StateChangedEventArgs PKAIMBGOOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6456EB0", Offset = "0x64562B0", VA = "0x186456EB0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6457040", Offset = "0x6456440", VA = "0x186457040")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6456CB0", Offset = "0x64560B0", VA = "0x186456CB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64564A0", Offset = "0x64558A0", VA = "0x1864564A0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6456C70", Offset = "0x6456070", VA = "0x186456C70")]
		private void OHALMCDJOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6456DE0", Offset = "0x64561E0", VA = "0x186456DE0", Slot = "4")]
		public void PushNetworkMessage(POCNIECOCFL.ICDCADDGOKM LJIMLOGOIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
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
