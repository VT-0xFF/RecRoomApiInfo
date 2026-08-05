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
		[Cpp2IlInjected.Address(RVA = "0x64565E0", Offset = "0x64559E0", VA = "0x1864565E0")]
		public static string GenerateChallengeResponse(string JEPAPAGHGCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64561E0", Offset = "0x64555E0", VA = "0x1864561E0")]
		private static void BBIAPNOODIH(POCNIECOCFL.ICDCADDGOKM LJIMLOGOIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64568C0", Offset = "0x6455CC0", VA = "0x1864568C0")]
		private static bool OGEDHCNAGEL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64563C0", Offset = "0x64557C0", VA = "0x1864563C0")]
		private static void FINBMFCHKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64562B0", Offset = "0x64556B0", VA = "0x1864562B0")]
		private static void FDINNCLMMMO(object MDPAJIKKLGB, LoadProgressEventArgs PKAIMBGOOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64566F0", Offset = "0x6455AF0", VA = "0x1864566F0")]
		private static void JFIGBCHKEEH(object MDPAJIKKLGB, LoadCompletedEventArgs PKAIMBGOOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6456440", Offset = "0x6455840", VA = "0x186456440")]
		private static void GHAOECHBHEJ(object MDPAJIKKLGB, StateChangedEventArgs PKAIMBGOOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6456DD0", Offset = "0x64561D0", VA = "0x186456DD0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6456F60", Offset = "0x6456360", VA = "0x186456F60")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6456BD0", Offset = "0x6455FD0", VA = "0x186456BD0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64563C0", Offset = "0x64557C0", VA = "0x1864563C0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6456B90", Offset = "0x6455F90", VA = "0x186456B90")]
		private void OHALMCDJOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6456D00", Offset = "0x6456100", VA = "0x186456D00", Slot = "4")]
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
