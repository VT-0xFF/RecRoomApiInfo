using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Logging;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.ObjectModel.Logging;
using RecRoom.RoomLoading.RoomOperation;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3AD0", Offset = "0x8BD26D0", VA = "0x188BD3AD0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class DZISONAGUEP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public DZISONAGUEP()
	{
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3960", Offset = "0x8BD2560", VA = "0x188BD3960", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int[] XIOCEUOZJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] XIIVHNVBZUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset MVEDDDGEAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset MVJKAKABJST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] RDDCMKUXPDN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x269CC00", Offset = "0x269B800", VA = "0x18269CC00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BD90F0", Offset = "0x8BD7CF0", VA = "0x188BD90F0")]
		private void SGYKGOYOYBS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BD94A0", Offset = "0x8BD80A0", VA = "0x188BD94A0")]
		private void SHDRDVSMHNB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9040", Offset = "0x8BD7C40", VA = "0x188BD9040", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD97A0", Offset = "0x8BD83A0", VA = "0x188BD97A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(IBWVCOGWDHO), new string[] { "Photon" })]
	public class PUXAUVOQOFZ : IBWVCOGWDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class YXJKVDZZKMX : RXQYZOWYROW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public RQAGMLJLYPY WJSZKIIILZB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public StatusCode SCZYBLYZXSW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public QELHJBGZNGU KELZWYSJMAU;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType JGVJNZJVVLT
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x8BD87F0", Offset = "0x8BD73F0", VA = "0x188BD87F0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId ZIHFNJEOTOM
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x8BD8840", Offset = "0x8BD7440", VA = "0x188BD8840", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool IXMXVPLBPKT
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x8BD8290", Offset = "0x8BD6E90", VA = "0x188BD8290", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool RWWHELATSGW
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8BD7B60", Offset = "0x8BD6760", VA = "0x188BD7B60", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8BD7F40", Offset = "0x8BD6B40", VA = "0x188BD7F40", Slot = "8")]
			public object JHATJPQHDTZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8BD7F90", Offset = "0x8BD6B90", VA = "0x188BD7F90", Slot = "9")]
			private (PlayerId, Dictionary<object, object>) ODKFRKARBXX()
			{
				return default((PlayerId, Dictionary<object, object>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8BD7D20", Offset = "0x8BD6920", VA = "0x188BD7D20", Slot = "10")]
			private (ObjectNetworkId, PlayerId) JCEHPHYZOVD()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8BD7E10", Offset = "0x8BD6A10", VA = "0x188BD7E10", Slot = "11")]
			private VNYHAVSIRVK<(ObjectNetworkId, PlayerId)> JCUDLVDSTJW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8BD85C0", Offset = "0x8BD71C0", VA = "0x188BD85C0", Slot = "12")]
			private (OutOfBandMessageType, byte[]) UROQDHZIYKM()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8BD8390", Offset = "0x8BD6F90", VA = "0x188BD8390", Slot = "13")]
			private (PacketSource, byte[]) UBJZOPTEJYT()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4219E90", Offset = "0x4218A90", VA = "0x184219E90", Slot = "14")]
			public a WAESNVBKOLG<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8BD82A0", Offset = "0x8BD6EA0", VA = "0x188BD82A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public YXJKVDZZKMX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class QELHJBGZNGU : VNYHAVSIRVK<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int[] ZTTYYMXBRXD;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int TXICYPISMOZ
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x8BD47C0", Offset = "0x8BD33C0", VA = "0x188BD47C0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8BD47E0", Offset = "0x8BD33E0", VA = "0x188BD47E0", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QELHJBGZNGU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4500", Offset = "0x8BD3100", VA = "0x188BD4500", Slot = "4")]
		public bool OLZFYBCEPRL(object a, RXQYZOWYROW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public PUXAUVOQOFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class XHTYHSGRUCU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(VMPPWIPCAKF), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : PEEXKGKATXF, SJOHKXRHEUT, VMPPWIPCAKF, GAEEWOIWDJG, OBETOEUHEYQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private ZAFZJFSWBQT PONDLUKDZAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[DependsOn]
		private FUYMSGBSFIU FZOWBPFTNWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Hashtable BQHXHTVSYKI;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3D50", Offset = "0x8BD2950", VA = "0x188BD3D50", Slot = "4")]
		public void InitReferences(BVNDYEZSFBO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4240", Offset = "0x8BD2E40", VA = "0x188BD4240", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3E30", Offset = "0x8BD2A30", VA = "0x188BD3E30", Slot = "6")]
		public void KUDRDCWTPQI(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BD42E0", Offset = "0x8BD2EE0", VA = "0x188BD42E0", Slot = "10")]
		public void ZADDXDPLZSJ(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3B50", Offset = "0x8BD2750", VA = "0x188BD3B50", Slot = "7")]
		public void BXNYRWYFBFA(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3F90", Offset = "0x8BD2B90", VA = "0x188BD3F90")]
		private Hashtable MDISSLNOFBZ(Hashtable a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8BD41E0", Offset = "0x8BD2DE0", VA = "0x188BD41E0")]
		public void OnEvent(object networkEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3CE0", Offset = "0x8BD28E0", VA = "0x188BD3CE0", Slot = "8")]
		private void HGJHKCHSQDI(BVNDYEZSFBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10EF1C0", Offset = "0x10EDDC0", VA = "0x1810EF1C0", Slot = "9")]
		private void PBSAMQJMUVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4490", Offset = "0x8BD3090", VA = "0x188BD4490")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.TRJNOEDAMFY), new string[] { })]
	internal class CXONOTAOLYV : BTQQBOCLSYJ, RecRoom.RoomLoading.RoomOperation.TRJNOEDAMFY
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log LHJYYAYKRPS;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] IXIHRWDJONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3440", Offset = "0x8BD2040", VA = "0x188BD3440", Slot = "11")]
		public void DLXIGXGIFEU(RXQYZOWYROW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3650", Offset = "0x8BD2250", VA = "0x188BD3650", Slot = "12")]
		public void DNZTKFUXAPI(RXQYZOWYROW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD38B0", Offset = "0x8BD24B0", VA = "0x188BD38B0")]
		public CXONOTAOLYV()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class XSKYOAJWQUW : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7910", Offset = "0x8BD6510", VA = "0x188BD7910", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7B10", Offset = "0x8BD6710", VA = "0x188BD7B10")]
		public XSKYOAJWQUW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class QHXGQGJFNEX
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public JsonSerializerSettings GALFIHXQREW;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8BD4680", Offset = "0x8BD3280", VA = "0x188BD4680")]
			internal string DUCTIWYSJJD(RQAGMLJLYPY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8BD49C0", Offset = "0x8BD35C0", VA = "0x188BD49C0")]
		public static string CTSHMIEZNMJ(this RQAGMLJLYPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4880", Offset = "0x8BD3480", VA = "0x188BD4880")]
		public static NetworkEventType CIYKMMZIDOW(this RQAGMLJLYPY a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4EB0", Offset = "0x8BD3AB0", VA = "0x188BD4EB0")]
		public static ViewId LPTXGNWANWV(this RQAGMLJLYPY a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4C30", Offset = "0x8BD3830", VA = "0x188BD4C30")]
		public static string IPPHZNBZMJN(this RQAGMLJLYPY a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4B40", Offset = "0x8BD3740", VA = "0x188BD4B40")]
		private static string GLRFDPTJGRX(RQAGMLJLYPY a, Func<RQAGMLJLYPY, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8BD49E0", Offset = "0x8BD35E0", VA = "0x188BD49E0")]
		public static string GEBZEKNUMIH(this RQAGMLJLYPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4CF0", Offset = "0x8BD38F0", VA = "0x188BD4CF0")]
		public static ViewId LDQLBDEGSVK(this RQAGMLJLYPY a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD50A0", Offset = "0x8BD3CA0", VA = "0x188BD50A0")]
		public static string LUJSJYMCPEM(this RQAGMLJLYPY a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class SVRWYFAGHGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class NNQKGJNKZWB
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static string NXNDIAFKSCU;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7000", Offset = "0x8BD5C00", VA = "0x188BD7000")]
		public static string QUTPEBYOSMW(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(ZRHLWPRSETE), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class ZRHLWPRSETE : BTQQBOCLSYJ
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log ZETAQPUIUZD;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log JMIGIVYZNYO;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log OXCJWDGHPII;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] IXIHRWDJONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BD8B00", Offset = "0x8BD7700", VA = "0x188BD8B00", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BD8980", Offset = "0x8BD7580", VA = "0x188BD8980", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BD88C0", Offset = "0x8BD74C0", VA = "0x188BD88C0")]
		private void FURXDZZDBNV(RQAGMLJLYPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8BD8890", Offset = "0x8BD7490", VA = "0x188BD8890")]
		private void AUVBITKLUSK(RQAGMLJLYPY a, PZIMWREHPGJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BD8C80", Offset = "0x8BD7880", VA = "0x188BD8C80")]
		public void PXBHTQOVHYS(RQAGMLJLYPY a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BD88D0", Offset = "0x8BD74D0", VA = "0x188BD88D0")]
		private static Log KQSMGYVIIYW(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8BD8F50", Offset = "0x8BD7B50", VA = "0x188BD8F50")]
		public ZRHLWPRSETE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class SUNIQNXNLLH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public byte[] payload;
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly JsonSerializerSettings YOZMTBXQEGY;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5CC0", Offset = "0x8BD48C0", VA = "0x188BD5CC0")]
		public static EventWriter WQYFGVYKUTE([In] this EventWriter evt, RXQYZOWYROW a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5DD0", Offset = "0x8BD49D0", VA = "0x188BD5DD0")]
		public static EventWriter WQYFGVYKUTE([In] this EventWriter evt, RQAGMLJLYPY a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD54A0", Offset = "0x8BD40A0", VA = "0x188BD54A0")]
		public static EventWriter DBENHMVXKAB([In] this EventWriter evt, RQAGMLJLYPY a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5AE0", Offset = "0x8BD46E0", VA = "0x188BD5AE0")]
		public static string RULSCTBWUAC(RQAGMLJLYPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD51B0", Offset = "0x8BD3DB0", VA = "0x188BD51B0")]
		public static string ADJGMXXSNWN(RQAGMLJLYPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5950", Offset = "0x8BD4550", VA = "0x188BD5950")]
		public static string OSWFFAHVJDT(RQAGMLJLYPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5410", Offset = "0x8BD4010", VA = "0x188BD5410")]
		[CompilerGenerated]
		internal static bool CYSHIEGTSMJ([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8BD57F0", Offset = "0x8BD43F0", VA = "0x188BD57F0")]
		[CompilerGenerated]
		internal static bool JNIGCPXVELS([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
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
