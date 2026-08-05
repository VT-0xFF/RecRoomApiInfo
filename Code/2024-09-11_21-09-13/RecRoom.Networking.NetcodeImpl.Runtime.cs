using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Dissonance.Integrations.Unity_NFGO;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Networking_NetcodeImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C08970", Offset = "0x6C06F70", VA = "0x186C08970", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace NetcodeImpl
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class DissonanceNetworkManagerInjector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private NfgoCommsNetwork nfgoCommsNetwork;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NfgoCommsNetwork FNMNDMNEFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C083A0", Offset = "0x6C069A0", VA = "0x186C083A0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C08560", Offset = "0x6C06B60", VA = "0x186C08560")]
		private void MLHMJKJJCCL(NetworkManager NOOIFLLDEMC, bool JAMBOEKGGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public DissonanceNetworkManagerInjector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
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

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C08880", Offset = "0x6C06E80", VA = "0x186C08880")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GFBJMKONGAO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MJDPFGPPMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA00000", Offset = "0x9FE600", VA = "0x180A00000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB69440", Offset = "0xB67A40", VA = "0x180B69440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NetworkManager AGAIEDLHPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NetworkManager PKMJNAEPOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88B6B0", Offset = "0x889CB0", VA = "0x18088B6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<NetworkManager, bool> MLHMJKJJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C085B0", Offset = "0x6C06BB0", VA = "0x186C085B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C08760", Offset = "0x6C06D60", VA = "0x186C08760")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C5A9F0", Offset = "0x5C58FF0", VA = "0x185C5A9F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GFBJMKONGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C08660", Offset = "0x6C06C60", VA = "0x186C08660")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	public static void MJICBONCJAL(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C08810", Offset = "0x6C06E10", VA = "0x186C08810")]
	public void ODKANMLCDMA(NetworkManager NOOIFLLDEMC, bool JAMBOEKGGOF)
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
