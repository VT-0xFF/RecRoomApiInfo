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
		public NfgoCommsNetwork GLCADPEMMED
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6968D30", Offset = "0x6967730", VA = "0x186968D30")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6968ED0", Offset = "0x69678D0", VA = "0x186968ED0")]
		private void PGONLGMNJMN(NetworkManager NALAKLLKMFA, bool LNMHDHBOJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6968F20", Offset = "0x6967920", VA = "0x186968F20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OGHLJKIBAJC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BFEIEPINJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A0E90", Offset = "0x89F890", VA = "0x1808A0E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A34A0", Offset = "0x9A1EA0", VA = "0x1809A34A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NetworkManager GEAGCJEMPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NetworkManager KGFLFMGDLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x850E30", Offset = "0x84F830", VA = "0x180850E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<NetworkManager, bool> PGONLGMNJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6969200", Offset = "0x6967C00", VA = "0x186969200")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6969150", Offset = "0x6967B50", VA = "0x186969150")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x59C3110", Offset = "0x59C1B10", VA = "0x1859C3110")]
	[Preserve]
	public OGHLJKIBAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6969060", Offset = "0x6967A60", VA = "0x186969060")]
	[MHFEIEAPENL(CMFCLNIIIKO.None)]
	public static void DPEMEKBPEDM(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6968FF0", Offset = "0x69679F0", VA = "0x186968FF0")]
	public void DDDDMNJELJO(NetworkManager NALAKLLKMFA, bool LNMHDHBOJKC)
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
