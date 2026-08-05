using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Dissonance.Integrations.Unity_NFGO;
using RecRoom.NoEngine.Common;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace NetcodeImpl
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class DissonanceNetworkManagerInjector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private NfgoCommsNetwork nfgoCommsNetwork;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NfgoCommsNetwork GHMFHPCLCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FE10", Offset = "0x6A4E410", VA = "0x186A4FE10")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FFB0", Offset = "0x6A4E5B0", VA = "0x186A4FFB0")]
		private void KIFNABMLOLE(NetworkManager OAALKNBOAOA, bool NJKJBGIJDJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public DissonanceNetworkManagerInjector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class NetworkManagerBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private NetworkManager networkManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private NetworkManager secondaryNetworkManager;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A50000", Offset = "0x6A4E600", VA = "0x186A50000")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BMOAFPKGBHN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FOCNGDCCILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2A0", Offset = "0x8AD8A0", VA = "0x1808AF2A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAB2620", Offset = "0xAB0C20", VA = "0x180AB2620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NetworkManager KJAHIFLGGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NetworkManager NODCOJDDGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x860CF0", Offset = "0x85F2F0", VA = "0x180860CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<NetworkManager, bool> KIFNABMLOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FD60", Offset = "0x6A4E360", VA = "0x186A4FD60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FCB0", Offset = "0x6A4E2B0", VA = "0x186A4FCB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD700", Offset = "0x5AABD00", VA = "0x185AAD700")]
	[Preserve]
	public BMOAFPKGBHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FBC0", Offset = "0x6A4E1C0", VA = "0x186A4FBC0")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	public static void FOHNGNBNDJE(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FB50", Offset = "0x6A4E150", VA = "0x186A4FB50")]
	public void DEEEDNGPKCL(NetworkManager OAALKNBOAOA, bool NJKJBGIJDJK)
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
