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
		public NfgoCommsNetwork NHCIMNOEIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6029BF0", Offset = "0x60285F0", VA = "0x186029BF0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6029D90", Offset = "0x6028790", VA = "0x186029D90")]
		private void GJIGIBAEBAD(NetworkManager IBFOMOJHANB, bool LDLLCKOPMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
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
		[Cpp2IlInjected.Address(RVA = "0x6029DE0", Offset = "0x60287E0", VA = "0x186029DE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DIDCBLBAHGL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MMIGNIGLLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E0510", Offset = "0x7DEF10", VA = "0x1807E0510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97E930", Offset = "0x97D330", VA = "0x18097E930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NetworkManager NDBAEIBCHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x790CA0", Offset = "0x78F6A0", VA = "0x180790CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NetworkManager ADDOIHDHJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x793D30", Offset = "0x792730", VA = "0x180793D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<NetworkManager, bool> GJIGIBAEBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6029990", Offset = "0x6028390", VA = "0x186029990")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6029B40", Offset = "0x6028540", VA = "0x186029B40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5187FB0", Offset = "0x51869B0", VA = "0x185187FB0")]
	[Preserve]
	public DIDCBLBAHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6029A40", Offset = "0x6028440", VA = "0x186029A40")]
	[BBBFDPEBAMC(HLEKCCEDPHP.None)]
	public static void JEKICECHJMN(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6029920", Offset = "0x6028320", VA = "0x186029920")]
	public void EHGEOIGHPCL(NetworkManager IBFOMOJHANB, bool LDLLCKOPMJN)
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
