using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using EasyAntiCheat.Client;
using EasyAntiCheat.Client.ClientAuth;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AntiCheat
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class EACManager : MonoBehaviour, GAJPALANNAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth AFGHNCDCLFK;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DBAHIAEGKKH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE290", Offset = "0x6FED090", VA = "0x186FEE290")]
		public static string GenerateChallengeResponse(string LNHHBPLIKLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE980", Offset = "0x6FED780", VA = "0x186FEE980")]
		private static void ONEGIBHILFD(LNKKCGPHOJA.JFMEIGNJDFI GNCDGJDGENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDF80", Offset = "0x6FECD80", VA = "0x186FEDF80")]
		private static bool CLEBCHDLOFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE3C0", Offset = "0x6FED1C0", VA = "0x186FEE3C0")]
		private static void IGNAJBAKNLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE450", Offset = "0x6FED250", VA = "0x186FEE450")]
		private static void JAOCGGOHMLA(object DMPKDDEBOCC, LoadProgressEventArgs MAOCFNHOEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE570", Offset = "0x6FED370", VA = "0x186FEE570")]
		private static void KLHLMCEHFBP(object DMPKDDEBOCC, LoadCompletedEventArgs MAOCFNHOEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE770", Offset = "0x6FED570", VA = "0x186FEE770")]
		private static void NBJIKFEJOBC(object DMPKDDEBOCC, StateChangedEventArgs MAOCFNHOEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEC40", Offset = "0x6FEDA40", VA = "0x186FEEC40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEDB0", Offset = "0x6FEDBB0", VA = "0x186FEEDB0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEA60", Offset = "0x6FED860", VA = "0x186FEEA60")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE3C0", Offset = "0x6FED1C0", VA = "0x186FEE3C0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE930", Offset = "0x6FED730", VA = "0x186FEE930")]
		private void OKHEPKMEFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEB60", Offset = "0x6FED960", VA = "0x186FEEB60", Slot = "4")]
		public void PushNetworkMessage(LNKKCGPHOJA.JFMEIGNJDFI GNCDGJDGENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public EACManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
