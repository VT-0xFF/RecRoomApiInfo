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
		public NfgoCommsNetwork JGAJLKPGBEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x603AD60", Offset = "0x6039760", VA = "0x18603AD60")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x603AF00", Offset = "0x6039900", VA = "0x18603AF00")]
		private void BKBDABDPJPO(NetworkManager IBNFHGFPHJB, bool HDOJDGIBCNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
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
		[Cpp2IlInjected.Address(RVA = "0x603B220", Offset = "0x6039C20", VA = "0x18603B220")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FODNIBPKAIB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OPJFHELDCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F4420", Offset = "0x7F2E20", VA = "0x1807F4420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x998D80", Offset = "0x997780", VA = "0x180998D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NetworkManager GDEEBIEMOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NetworkManager KKDHELFEHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC260", Offset = "0x7AAC60", VA = "0x1807AC260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<NetworkManager, bool> BKBDABDPJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x603AF50", Offset = "0x6039950", VA = "0x18603AF50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x603B070", Offset = "0x6039A70", VA = "0x18603B070")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x514B490", Offset = "0x5149E90", VA = "0x18514B490")]
	[Preserve]
	public FODNIBPKAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x603B120", Offset = "0x6039B20", VA = "0x18603B120")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	public static void GLBIFIOAFNJ(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x603B000", Offset = "0x6039A00", VA = "0x18603B000")]
	public void CKPNPGFNBFI(NetworkManager IBNFHGFPHJB, bool HDOJDGIBCNB)
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
